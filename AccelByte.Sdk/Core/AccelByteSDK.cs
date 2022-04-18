// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.Text;
using System.Web;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Core
{
    public class AccelByteSDK
    {
        public static AccelByteSdkBuilder Builder = new AccelByteSdkBuilder();

        public class AccelByteSdkBuilder
        {
            private IHttpClient? _Client = null;

            private ITokenRepository? _TokenRepository = null;

            private IConfigRepository? _ConfigRepository = null;

            private ICredentialRepository? _Credential = null;

            private IHttpLogger? _Logger = null;

            private bool _EnableLogging = false;

            public AccelByteSdkBuilder SetHttpClient(IHttpClient client)
            {
                _Client = client;
                return this;
            }

            public AccelByteSdkBuilder UseDefaultHttpClient()
            {
                _Client = AccelByte.Sdk.Core.Client.HttpClient.Default;
                return this;
            }

            public AccelByteSdkBuilder SetTokenRepository(ITokenRepository repository)
            {
                _TokenRepository = repository;
                return this;
            }

            public AccelByteSdkBuilder UseDefaultTokenRepository()
            {
                _TokenRepository = DefaultTokenRepository.GetInstance();
                return this;
            }

            public AccelByteSdkBuilder UseInMemoryTokenRepository()
            {
                _TokenRepository = new InMemoryTokenRepository();
                return this;
            }

            public AccelByteSdkBuilder SetConfigRepository(IConfigRepository repository)
            {
                _ConfigRepository = repository;
                return this;
            }

            public AccelByteSdkBuilder UseDefaultConfigRepository()
            {
                _ConfigRepository = new DefaultConfigRepository();
                return this;
            }

            public AccelByteSdkBuilder SetCredentialRepository(ICredentialRepository credential)
            {
                _Credential = credential;
                return this;
            }

            public AccelByteSdkBuilder UseDefaultCredentialRepository()
            {
                _Credential = new DefaultCredentialRepository();
                return this;
            }

            public AccelByteSdkBuilder EnableLog()
            {
                _EnableLogging = true;
                return this;
            }

            public AccelByteSdkBuilder SetLogger(IHttpLogger logger)
            {
                _Logger = logger;
                return this;
            }

            public AccelByteSDK Build()
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
                if (_Credential != null)
                    config.Credential = _Credential;

                return new AccelByteSDK(config);
            }
        }

        public AccelByteConfig Configuration { get; private set; }

        public string Namespace { get => Configuration.ConfigRepository.Namespace; }

        public AccelByteSDK(AccelByteConfig config)
        {
            Configuration = config;
        }

        public HttpResponse RunRequest(Operation operation)
        {
            var baseUrl = Configuration.ConfigRepository.BaseUrl;

            string selectedSecurity = Operation.SECURITY_BASIC;
            if (operation.PreferredSecurityMethod != String.Empty)
                selectedSecurity = operation.PreferredSecurityMethod;
            else
            {
                if (operation.Securities.Count > 0)
                    selectedSecurity = operation.Securities[0];
            }

            switch (selectedSecurity)
            {
                case Operation.SECURITY_BEARER:
                    if (!string.IsNullOrEmpty(Configuration.TokenRepository.GetToken()))
                    {
                        operation.HeaderParams["Authorization"] = $"{Operation.SECURITY_BEARER} {Configuration.TokenRepository.GetToken()}";
                    }
                    break;
                case Operation.SECURITY_BASIC:
                    var basicAuth = $"{Configuration.ConfigRepository.ClientId}:{Configuration.ConfigRepository.ClientSecret}";
                    var basicAuthBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(basicAuth));
                    operation.HeaderParams["Authorization"] = $"{Operation.SECURITY_BASIC} {basicAuthBase64}";
                    break;
                case Operation.SECURITY_COOKIE:
                    if (!string.IsNullOrEmpty(Configuration.TokenRepository.GetToken()))
                    {
                        operation.Cookies["access_token"] = $"{Operation.SECURITY_BEARER} {Configuration.TokenRepository.GetToken()}";
                    }
                    break;
            }

            if (Configuration.ConfigRepository.EnableUserAgentInfo)
            {
                Version asVer = this.GetType().Assembly.GetName().Version!;
                string userAgent = String.Format("AccelByteCSharpSDK/{0}.{1}.{2} ({3})", asVer.Major, asVer.Minor, asVer.Revision, Configuration.ConfigRepository.AppName);
                operation.HeaderParams["User-Agent"] = userAgent;
            }

            if (Configuration.ConfigRepository.EnableTraceId)
            {
                string uTime = DateTimeOffset.Now.ToUnixTimeSeconds().ToString("X").PadLeft(8, '0').ToLowerInvariant();
                string rGuid = Guid.NewGuid().ToString().Replace("-", "");
                string guid = String.Empty;
                for (int i = 0; i < rGuid.Length; i += 4)
                    guid += rGuid.Substring(i, 3);

                string amazonTraceId = String.Format("{0}-{1}-{2}", Configuration.ConfigRepository.TraceIdVersion, uTime, guid);
                operation.HeaderParams["X-Amzn-Trace-Id"] = amazonTraceId;
            }

            return Configuration.HttpClient.SendRequest(operation, baseUrl);
        }

        public bool LoginUser()
        {
            if (Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = Configuration.Credential;
            return LoginUser(cred.Username, cred.Password);
        }

        public bool LoginUser(string username, string password)
        {
            var codeVerifier = Helper.GenerateCodeVerifier();
            var codeChallenge = Helper.GenerateCodeChallenge(codeVerifier);
            var clientId = Configuration.ConfigRepository.ClientId;

            var oAuth20 = new OAuth20(this);            
            var authorizeV3 = AuthorizeV3.Builder
                .SetCodeChallenge(codeChallenge)
                .SetCodeChallengeMethod("S256")
                .SetScope("commerce account social publishing analytics")
                .Build(clientId,"code");

            var authorizeV3Response = oAuth20.AuthorizeV3(authorizeV3);

            var authorizeV3Query = HttpUtility.ParseQueryString( new Uri(authorizeV3Response).Query);
            var requestId = authorizeV3Query[authorizeV3.LocationQuery] ?? 
                    throw new Exception($"Not getting the expected value from backend (key: {authorizeV3.LocationQuery})");;

            var oAuth20Extension = new OAuth20Extension(this);
            var userAuthenticationV3 = UserAuthenticationV3.Builder
                .SetClientId(clientId)
                .Build(password,requestId,username);
            var userAuthenticationResponse = oAuth20Extension.UserAuthenticationV3(userAuthenticationV3);

            authorizeV3Query = HttpUtility.ParseQueryString( new Uri(userAuthenticationResponse).Query);
            var code = authorizeV3Query[userAuthenticationV3.LocationQuery] ?? 
                    throw new Exception($"Not getting the expected value from backend (key: {userAuthenticationV3.LocationQuery})");;

            var tokenGrantV3 = TokenGrantV3.Builder
                .SetClientId(clientId)
                .SetCode(code)
                .SetCodeVerifier(codeVerifier)
                .Build("authorization_code");            

            var token = oAuth20.TokenGrantV3(tokenGrantV3) ??
                    throw new Exception($"TokenGrantV3 returned null");

            if (token == null)
                throw new Exception("Token is null");
            if (token.AccessToken == null)
                throw new Exception("Access token is null");

            Configuration.TokenRepository.StoreToken(token.AccessToken);
            if ((Configuration.Credential != null) && (token.UserId != null))
                Configuration.Credential.UserId = token.UserId;

            return true;
        }

        public bool LoginClient()
        {
            var tokenGrantV3 = TokenGrantV3.Builder.Build("client_credentials");
            var oAuth20 = new OAuth20(this);

            var token = oAuth20.TokenGrantV3(tokenGrantV3) ??
                    throw new Exception($"TokenGrantV3 returned null");

            Configuration.TokenRepository.StoreToken(token.AccessToken ??
                    throw new Exception($"Access token is null"));

            return true;
        }

        public bool Logout()
        {
            Configuration.TokenRepository.RemoveToken();

            return true;
        }
    }
}