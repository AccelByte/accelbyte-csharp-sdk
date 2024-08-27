// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.Text;
using System.Web;

using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Pipeline;

using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Core
{
    public partial class AccelByteSDK : IDisposable
    {
        public static AccelByteSdkBuilder<AccelByteSDK> Builder { get => new AccelByteSdkBuilder<AccelByteSDK>(); }

        private List<ISdkService> _Services = new List<ISdkService>();

        public OperationProcessPipeline OpProcess { get => _OpProcess; }
        private OperationProcessPipeline _OpProcess;

        public AccelByteConfig Configuration { get; private set; }

        public string Namespace { get => Configuration.ConfigRepository.Namespace; }

        public SdkLocalData LocalData { get; } = new SdkLocalData();

        public string FlightId { get; private set; } = String.Empty;

        public AccelByteSDK(AccelByteConfig config)
        {
            Configuration = config;
            LocalData = new SdkLocalData();

            _OpProcess = new OperationProcessPipeline();
            _OpProcess.AppendToChain(new SdkMandatoryOperationProcess());
        }

        public AccelByteSDK(AccelByteConfig config, List<ISdkService> services)
        {
            Configuration = config;
            LocalData = new SdkLocalData();

            _OpProcess = new OperationProcessPipeline();
            _OpProcess.AppendToChain(new SdkMandatoryOperationProcess());

            _Services = services;
            foreach (var service in _Services)
                service.Start(this);
        }

        public void Dispose()
        {
            foreach (var service in _Services)
            {
                service.Stop();
                if (service is IDisposable)
                    ((IDisposable)service).Dispose();
            }
        }

        public void StopServices()
        {
            foreach (var service in _Services)
                service.Stop();
        }

        public T? GetService<T>() where T : ISdkService
        {
            foreach (var service in _Services)
            {
                if (service is T)
                    return (T)service;
            }
            return default(T);
        }

        public HttpResponse RunRequest(Operation operation)
        {
            Operation pOperation = _OpProcess.RunProcessPipeline(operation, this);

            var baseUrl = Configuration.ConfigRepository.BaseUrl;
            return Configuration.HttpClient.SendRequest(pOperation, baseUrl);
        }

        public async Task<HttpResponse> RunRequestAsync(Operation operation)
        {
            Operation pOperation = await _OpProcess.RunProcessPipelineAsync(operation, this);

            var baseUrl = Configuration.ConfigRepository.BaseUrl;
            return await Configuration.HttpClient.SendRequestAsync(pOperation, baseUrl);
        }

        public bool LoginUser()
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return LoginUser(cred.Username, cred.Password, "", null);
        }

        public bool LoginUser(Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return LoginUser(cred.Username, cred.Password, "", onTokenReceived);
        }

        public bool LoginUser(string scopes)
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return LoginUser(cred.Username, cred.Password, scopes, null);
        }

        public bool LoginUser(string scopes, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return LoginUser(cred.Username, cred.Password, scopes, onTokenReceived);
        }

        public bool LoginUser(string username, string password)
            => LoginUser(username, password, "", null);

        public bool LoginUser(string username, string password, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
            => LoginUser(username, password, "", onTokenReceived);

        public bool LoginUser(string username, string password, string? scopes, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if ((Configuration.UseRefreshIfPossible) && (Configuration.TokenRepository.TokenData != null))
            {
                if (Configuration.TokenRepository.IsTokenExpired)
                {
                    bool b = RefreshAccessToken(Configuration.TokenRepository.TokenData.RefreshToken!, onTokenReceived);
                    Configuration.OnAfterLogin?.Invoke(LoginType.User, AuthActionType.TokenRefresh, Configuration.TokenRepository.TokenData, this);
                    return b;
                }
                else
                    return true;
            }
            else
                Configuration.TokenRepository.RemoveToken();

            var codeVerifier = Helper.GenerateCodeVerifier();
            var codeChallenge = Helper.GenerateCodeChallenge(codeVerifier);
            var clientId = Configuration.ConfigRepository.ClientId;

            var oAuth20 = new OAuth20(this);
            AuthorizeV3 authorizeV3;
            if (scopes == null)
            {
                authorizeV3 = AuthorizeV3.Builder
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .Build(clientId, "code");
            }
            else if (scopes == "")
            {
                authorizeV3 = AuthorizeV3.Builder
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .SetScope("commerce account social publishing analytics")
                    .Build(clientId, "code");
            }
            else
            {
                authorizeV3 = AuthorizeV3.Builder
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .SetScope(scopes)
                    .Build(clientId, "code");
            }

            var authorizeV3Response = oAuth20.AuthorizeV3(authorizeV3);

            var authorizeV3Query = HttpUtility.ParseQueryString(new Uri(authorizeV3Response).Query);
            var requestId = authorizeV3Query[authorizeV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {authorizeV3.LocationQuery})"); ;

            var oAuth20Extension = new OAuth20Extension(this);
            var userAuthenticationV3 = UserAuthenticationV3.Builder
                .SetClientId(clientId)
                .Build(password, requestId, username);
            var userAuthenticationResponse = oAuth20Extension.UserAuthenticationV3(userAuthenticationV3);

            authorizeV3Query = HttpUtility.ParseQueryString(new Uri(userAuthenticationResponse).Query);
            var code = authorizeV3Query[userAuthenticationV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {userAuthenticationV3.LocationQuery})"); ;

            var tokenGrantV3 = TokenGrantV3.Builder
                .SetClientId(clientId)
                .SetCode(code)
                .SetCodeVerifier(codeVerifier)
                .Build("authorization_code");

            var token = oAuth20.TokenGrantV3(tokenGrantV3) ??
                    throw new Exception($"TokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(LoginType.User, token);
            if ((Configuration.Credential != null) && (token.UserId != null))
                Configuration.Credential.UserId = token.UserId;

            onTokenReceived?.Invoke(token);
            Configuration.OnAfterLogin?.Invoke(LoginType.User, AuthActionType.Login, Configuration.TokenRepository.TokenData, this);
            return true;
        }

        public async Task<bool> LoginUserAsync()
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return await LoginUserAsync(cred.Username, cred.Password, "", null);
        }

        public async Task<bool> LoginUserAsync(Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return await LoginUserAsync(cred.Username, cred.Password, "", onTokenReceived);
        }

        public async Task<bool> LoginUserAsync(string scopes)
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return await LoginUserAsync(cred.Username, cred.Password, scopes, null);
        }

        public async Task<bool> LoginUserAsync(string scopes, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return await LoginUserAsync(cred.Username, cred.Password, scopes, onTokenReceived);
        }

        public async Task<bool> LoginUserAsync(string username, string password)
            => await LoginUserAsync(username, password, "", null);

        public async Task<bool> LoginUserAsync(string username, string password, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
            => await LoginUserAsync(username, password, "", onTokenReceived);

        public async Task<bool> LoginUserAsync(string username, string password, string? scopes, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if ((Configuration.UseRefreshIfPossible) && (Configuration.TokenRepository.TokenData != null))
            {
                if (Configuration.TokenRepository.IsTokenExpired)
                {
                    bool b = await RefreshAccessTokenAsync(Configuration.TokenRepository.TokenData.RefreshToken!, onTokenReceived);
                    Configuration.OnAfterLogin?.Invoke(LoginType.User, AuthActionType.TokenRefresh, Configuration.TokenRepository.TokenData, this);
                    return b;
                }
                else
                    return true;
            }
            else
                Configuration.TokenRepository.RemoveToken();

            var codeVerifier = Helper.GenerateCodeVerifier();
            var codeChallenge = Helper.GenerateCodeChallenge(codeVerifier);
            var clientId = Configuration.ConfigRepository.ClientId;

            var oAuth20 = new OAuth20(this);
            AuthorizeV3 authorizeV3;
            if (scopes == null)
            {
                authorizeV3 = AuthorizeV3.Builder
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .Build(clientId, "code");
            }
            else if (scopes == "")
            {
                authorizeV3 = AuthorizeV3.Builder
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .SetScope("commerce account social publishing analytics")
                    .Build(clientId, "code");
            }
            else
            {
                authorizeV3 = AuthorizeV3.Builder
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .SetScope(scopes)
                    .Build(clientId, "code");
            }

            var authorizeV3Response = await oAuth20.AuthorizeV3Async(authorizeV3);

            var authorizeV3Query = HttpUtility.ParseQueryString(new Uri(authorizeV3Response).Query);
            var requestId = authorizeV3Query[authorizeV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {authorizeV3.LocationQuery})"); ;

            var oAuth20Extension = new OAuth20Extension(this);
            var userAuthenticationV3 = UserAuthenticationV3.Builder
                .SetClientId(clientId)
                .Build(password, requestId, username);
            var userAuthenticationResponse = await oAuth20Extension.UserAuthenticationV3Async(userAuthenticationV3);

            authorizeV3Query = HttpUtility.ParseQueryString(new Uri(userAuthenticationResponse).Query);
            var code = authorizeV3Query[userAuthenticationV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {userAuthenticationV3.LocationQuery})"); ;

            var tokenGrantV3 = TokenGrantV3.Builder
                .SetClientId(clientId)
                .SetCode(code)
                .SetCodeVerifier(codeVerifier)
                .Build("authorization_code");

            var token = await oAuth20.TokenGrantV3Async(tokenGrantV3) ??
                    throw new Exception($"TokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(LoginType.User, token);
            if ((Configuration.Credential != null) && (token.UserId != null))
                Configuration.Credential.UserId = token.UserId;

            onTokenReceived?.Invoke(token);
            Configuration.OnAfterLogin?.Invoke(LoginType.User, AuthActionType.Login, Configuration.TokenRepository.TokenData, this);
            return true;
        }

        public bool LoginClient()
            => LoginClient(null);

        public bool LoginClient(Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if ((Configuration.UseRefreshIfPossible) && (Configuration.TokenRepository.TokenData != null))
            {
                if (!Configuration.TokenRepository.IsTokenExpired)
                    return true;
            }
            else
                Configuration.TokenRepository.RemoveToken();

            var tokenGrantV3 = TokenGrantV3.Builder.Build("client_credentials");
            var oAuth20 = new OAuth20(this);

            var token = oAuth20.TokenGrantV3(tokenGrantV3) ??
                    throw new Exception($"TokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(LoginType.Client, token);

            onTokenReceived?.Invoke(token);
            Configuration.OnAfterLogin?.Invoke(LoginType.Client, AuthActionType.Login, Configuration.TokenRepository.TokenData, this);
            return true;
        }

        public async Task<bool> LoginClientAsync()
            => await LoginClientAsync(null);

        public async Task<bool> LoginClientAsync(Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            if ((Configuration.UseRefreshIfPossible) && (Configuration.TokenRepository.TokenData != null))
            {
                if (!Configuration.TokenRepository.IsTokenExpired)
                    return true;
            }
            else
                Configuration.TokenRepository.RemoveToken();

            var tokenGrantV3 = TokenGrantV3.Builder.Build("client_credentials");
            var oAuth20 = new OAuth20(this);

            var token = await oAuth20.TokenGrantV3Async(tokenGrantV3) ??
                    throw new Exception($"TokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(LoginType.Client, token);

            onTokenReceived?.Invoke(token);
            Configuration.OnAfterLogin?.Invoke(LoginType.Client, AuthActionType.Login, Configuration.TokenRepository.TokenData, this);
            return true;
        }

        public bool LoginPlatform(string platformId, string platformToken)
            => LoginPlatform(platformId, platformToken, null);

        public bool LoginPlatform(string platformId, string platformToken, Action<OauthmodelTokenResponse>? onTokenReceived)
        {
            if ((Configuration.UseRefreshIfPossible) && (Configuration.TokenRepository.TokenData != null))
            {
                if (Configuration.TokenRepository.IsTokenExpired)
                {
                    if (onTokenReceived != null)
                    {
                        bool b = RefreshAccessToken(Configuration.TokenRepository.TokenData.RefreshToken!,
                            (oToken) => onTokenReceived.Invoke(TokenData.ConvertToOAuthModelTokenResponse(oToken)));
                        Configuration.OnAfterLogin?.Invoke(LoginType.Platform, AuthActionType.TokenRefresh, Configuration.TokenRepository.TokenData, this);
                        return b;
                    }
                    else
                    {
                        bool b = RefreshAccessToken(Configuration.TokenRepository.TokenData.RefreshToken!, null);
                        Configuration.OnAfterLogin?.Invoke(LoginType.Platform, AuthActionType.TokenRefresh, Configuration.TokenRepository.TokenData, this);
                        return b;
                    }
                }
                else
                    return true;
            }
            else
                Configuration.TokenRepository.RemoveToken();

            var tokenGrantV3 = PlatformTokenGrantV3.Builder
                .SetPlatformToken(platformToken)
                .Build(platformId);

            var oAuth20 = new OAuth20(this);
            var token = oAuth20.PlatformTokenGrantV3(tokenGrantV3) ??
                throw new Exception($"PlatformTokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(LoginType.Platform, token);

            onTokenReceived?.Invoke(token);
            Configuration.OnAfterLogin?.Invoke(LoginType.Platform, AuthActionType.Login, Configuration.TokenRepository.TokenData, this);
            return true;
        }

        public async Task<bool> LoginPlatformAsync(string platformId, string platformToken)
            => await LoginPlatformAsync(platformId, platformToken, null);

        public async Task<bool> LoginPlatformAsync(string platformId, string platformToken, Action<OauthmodelTokenResponse>? onTokenReceived)
        {
            if ((Configuration.UseRefreshIfPossible) && (Configuration.TokenRepository.TokenData != null))
            {
                if (Configuration.TokenRepository.IsTokenExpired)
                {
                    if (onTokenReceived != null)
                    {
                        bool b = await RefreshAccessTokenAsync(Configuration.TokenRepository.TokenData.RefreshToken!,
                            (oToken) => onTokenReceived.Invoke(TokenData.ConvertToOAuthModelTokenResponse(oToken)));
                        Configuration.OnAfterLogin?.Invoke(LoginType.Platform, AuthActionType.TokenRefresh, Configuration.TokenRepository.TokenData, this);
                        return b;
                    }
                    else
                    {
                        bool b = await RefreshAccessTokenAsync(Configuration.TokenRepository.TokenData.RefreshToken!, null);
                        Configuration.OnAfterLogin?.Invoke(LoginType.Platform, AuthActionType.TokenRefresh, Configuration.TokenRepository.TokenData, this);
                        return b;
                    }
                }
                else
                    return true;
            }
            else
                Configuration.TokenRepository.RemoveToken();

            var tokenGrantV3 = PlatformTokenGrantV3.Builder
                .SetPlatformToken(platformToken)
                .Build(platformId);

            var oAuth20 = new OAuth20(this);
            var token = await oAuth20.PlatformTokenGrantV3Async(tokenGrantV3) ??
                throw new Exception($"PlatformTokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(LoginType.Platform, token);

            onTokenReceived?.Invoke(token);
            Configuration.OnAfterLogin?.Invoke(LoginType.Platform, AuthActionType.Login, Configuration.TokenRepository.TokenData, this);
            return true;
        }

        public bool RefreshAccessToken(string refreshToken)
            => RefreshAccessToken(refreshToken, null);

        public bool RefreshAccessToken(string refreshToken, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            TokenGrantV3 op = TokenGrantV3.Builder
                .SetRefreshToken(refreshToken)
                .Build(TokenGrantV3GrantType.RefreshToken);
            var oAuth20 = new OAuth20(this);

            var token = oAuth20.TokenGrantV3(op) ??
                throw new Exception("TokenGrantV3 for RefreshToken returned null");

            Configuration.TokenRepository.UpdateToken(token);
            onTokenReceived?.Invoke(token);

            if (Configuration.TokenRepository is IObservableTokenRepository)
            {
                var oTokenRepo = (IObservableTokenRepository)Configuration.TokenRepository;
                _ = oTokenRepo.UpdateObserversWithNewToken();
            }

            return true;
        }

        public async Task<bool> RefreshAccessTokenAsync(string refreshToken)
            => await RefreshAccessTokenAsync(refreshToken, null);

        public async Task<bool> RefreshAccessTokenAsync(string refreshToken, Action<OauthmodelTokenWithDeviceCookieResponseV3>? onTokenReceived)
        {
            TokenGrantV3 op = TokenGrantV3.Builder
                .SetRefreshToken(refreshToken)
                .Build(TokenGrantV3GrantType.RefreshToken);
            var oAuth20 = new OAuth20(this);

            var token = await oAuth20.TokenGrantV3Async(op) ??
                throw new Exception("TokenGrantV3 for RefreshToken returned null");

            Configuration.TokenRepository.UpdateToken(token);
            onTokenReceived?.Invoke(token);

            if (Configuration.TokenRepository is IObservableTokenRepository)
            {
                var oTokenRepo = (IObservableTokenRepository)Configuration.TokenRepository;
                await oTokenRepo.UpdateObserversWithNewToken();
            }

            return true;
        }

        public bool Logout()
        {
            Configuration.TokenRepository.RemoveToken();
            return true;
        }

        public bool ValidateToken(string accessToken)
        {
            if (Configuration.TokenValidator != null)
                return Configuration.TokenValidator.Validate(this, accessToken);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public bool ValidateToken(string accessToken, string permission, int action)
        {
            if (Configuration.TokenValidator != null)
                return Configuration.TokenValidator.Validate(this, accessToken, permission, action);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public bool ValidateToken(string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            if (Configuration.TokenValidator != null)
                return Configuration.TokenValidator.Validate(this, accessToken, permission, action, aNamespace, userId);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public async Task<bool> ValidateTokenAsync(string accessToken)
        {
            if ((Configuration.TokenValidator != null) && (Configuration.TokenValidator is IAsyncTokenValidator))
                return await ((IAsyncTokenValidator)Configuration.TokenValidator).ValidateAsync(this, accessToken);
            else
                throw new Exception("Could not validate token. No token validator assigned or invalid token validator.");
        }

        public async Task<bool> ValidateTokenAsync(string accessToken, string permission, int action)
        {
            if ((Configuration.TokenValidator != null) && (Configuration.TokenValidator is IAsyncTokenValidator))
                return await ((IAsyncTokenValidator)Configuration.TokenValidator).ValidateAsync(this, accessToken, permission, action);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public async Task<bool> ValidateTokenAsync(string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            if ((Configuration.TokenValidator != null) && (Configuration.TokenValidator is IAsyncTokenValidator))
                return await ((IAsyncTokenValidator)Configuration.TokenValidator).ValidateAsync(this, accessToken, permission, action, aNamespace, userId);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public void UpdateFlightId(string flightId)
        {
            FlightId = flightId;
        }

        public bool UploadBinaryData(string url, byte[] dataToUpload, string contentType)
        {
            return Configuration.HttpClient.UploadBinaryData(url, dataToUpload, contentType);
        }

        public async Task<bool> UploadBinaryDataAsync(string url, byte[] dataToUpload, string contentType)
        {
            return await Configuration.HttpClient.UploadBinaryDataAsync(url, dataToUpload, contentType);
        }

        public byte[] DownloadBinaryData(string url)
        {
            return Configuration.HttpClient.DownloadBinaryData(url);
        }

        public async Task<byte[]> DownloadBinaryDataAsync(string url)
        {
            return await Configuration.HttpClient.DownloadBinaryDataAsync(url);
        }
    }

    public partial class AccelByteSdkBuilder<T> where T : AccelByteSDK
    {
        private IHttpClient? _Client = null;

        private ITokenRepository? _TokenRepository = null;

        private IConfigRepository? _ConfigRepository = null;

        private ICredentialRepository? _Credential = null;

        private IHttpLogger? _Logger = null;

        private ITokenValidator? _TokenValidator = null;

        private bool _EnableLogging = false;

        private List<IOperationProcessPipeline> _OpProcesses = new List<IOperationProcessPipeline>();

        private List<ISdkService> _Services = new List<ISdkService>();

        private bool _UseRefreshIfPossible = false;

        private Action<LoginType, AuthActionType, TokenData?, AccelByteSDK>? _OnAfterLogin = null;

        private string _FlightId = "";

        public AccelByteSdkBuilder<T> SetHttpClient(IHttpClient client)
        {
            _Client = client;
            return this;
        }

        public AccelByteSdkBuilder<T> UseDefaultHttpClient()
        {
            _Client = AccelByte.Sdk.Core.Client.HttpClient.Default;
            return this;
        }

        public AccelByteSdkBuilder<T> SetTokenRepository(ITokenRepository repository)
        {
            _TokenRepository = repository;
            return this;
        }

        public AccelByteSdkBuilder<T> UseDefaultTokenRepository()
        {
            _TokenRepository = new DefaultTokenRepository();
            return this;
        }

        public AccelByteSdkBuilder<T> UseSharedTokenRepository()
        {
            _TokenRepository = SharedTokenRepository.Instance;
            return this;
        }

        // Deprecated(2023-02-13): Please use default token repository instead.
        [Obsolete("# Deprecated(2023-02-13): Please use default token repository instead.", DiagnosticId = "AB_TOKEN_REPO_DEPRECATED_METHOD")]
        public AccelByteSdkBuilder<T> UseInMemoryTokenRepository()
        {
            _TokenRepository = new InMemoryTokenRepository();
            return this;
        }

        public AccelByteSdkBuilder<T> SetConfigRepository(IConfigRepository repository)
        {
            _ConfigRepository = repository;
            return this;
        }

        public AccelByteSdkBuilder<T> UseDefaultConfigRepository()
        {
            _ConfigRepository = new DefaultConfigRepository();
            return this;
        }

        public AccelByteSdkBuilder<T> SetCredentialRepository(ICredentialRepository credential)
        {
            _Credential = credential;
            return this;
        }

        public AccelByteSdkBuilder<T> UseDefaultCredentialRepository()
        {
            _Credential = new DefaultCredentialRepository();
            return this;
        }

        public AccelByteSdkBuilder<T> EnableLog()
        {
            _EnableLogging = true;
            return this;
        }

        public AccelByteSdkBuilder<T> SetLogger(IHttpLogger logger)
        {
            _Logger = logger;
            return this;
        }

        public AccelByteSdkBuilder<T> SetTokenValidator(ITokenValidator tokenValidator)
        {
            _TokenValidator = tokenValidator;
            return this;
        }

        public AccelByteSdkBuilder<T> AddOperationProcess(IOperationProcessPipeline opProcess)
        {
            _OpProcesses.Add(opProcess);
            return this;
        }

        public AccelByteSdkBuilder<T> UseRefreshIfPossible()
        {
            _UseRefreshIfPossible = true;
            return this;
        }

        public AccelByteSdkBuilder<T> SetOnAfterLoginAction(Action<LoginType, AuthActionType, TokenData?, AccelByteSDK> action)
        {
            _OnAfterLogin = action;
            return this;
        }

        public AccelByteSdkBuilder<T> RegisterService(ISdkService service)
        {
            _Services.Add(service);
            return this;
        }

        public AccelByteSdkBuilder<T> SetFlightId(string flightId)
        {
            _FlightId = flightId;
            return this;
        }

        public AccelByteSdkBuilder<T> UseTokenValidatorAutoClearCache(int refreshInterval)
        {
            _Services.Add(new CacheInvalidationSdkService(refreshInterval));
            return this;
        }

        public AccelByteSdkBuilder<T> UseTokenValidatorAutoClearCache()
        {
            _Services.Add(new CacheInvalidationSdkService(3600));
            return this;
        }

        public virtual T Build()
        {
            if (_Client == null)
                throw IncompleteComponentException.NoHttpClient;
            if (_TokenRepository == null)
                throw IncompleteComponentException.NoTokenRepository;
            if (_ConfigRepository == null)
                throw IncompleteComponentException.NoConfigRepository;

            if (_EnableLogging)
            {
                if (_Logger == null)
                {
                    IHttpLogger logger = new DefaultHttpLogger();
                    _Client.SetLogger(logger);
                }
                else
                    _Client.SetLogger(_Logger);
            }

            AccelByteConfig config = new AccelByteConfig(_Client, _TokenRepository, _ConfigRepository);
            config.UseRefreshIfPossible = _UseRefreshIfPossible;
            config.OnAfterLogin = _OnAfterLogin;

            if (_Credential != null)
                config.Credential = _Credential;
            if (_TokenValidator != null)
                config.TokenValidator = _TokenValidator;
            else
                config.TokenValidator = new DefaultTokenValidator();

            T? sdk;
            if (_Services.Count > 0)
                sdk = (T?)Activator.CreateInstance(typeof(T), config, _Services);
            else
                sdk = (T?)Activator.CreateInstance(typeof(T), config);
            if (sdk == null)
                throw new Exception($"Could not create instance of {typeof(T).FullName} due to missing matching constructor.");

            if (_TokenRepository is ISdkConsumerRepository)
                ((ISdkConsumerRepository)_TokenRepository).SetSdkObject(sdk);
            if (_ConfigRepository is ISdkConsumerRepository)
                ((ISdkConsumerRepository)_ConfigRepository).SetSdkObject(sdk);
            if ((_Credential != null) && (_Credential is ISdkConsumerRepository))
                ((ISdkConsumerRepository)_Credential).SetSdkObject(sdk);

            if (_OpProcesses.Count > 0)
            {
                foreach (IOperationProcessPipeline opp in _OpProcesses)
                    sdk.OpProcess.AppendToChain(opp);
            }

            if (_FlightId == "")
                _FlightId = AccelByteConfig.DefaultFlightId;
            sdk.UpdateFlightId(_FlightId);

            return sdk;
        }
    }
}