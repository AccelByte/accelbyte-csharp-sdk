// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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
    public partial class AccelByteSDK
    {
        public static AccelByteSdkBuilder Builder = new AccelByteSdkBuilder();

        public OperationProcessPipeline OpProcess { get => _OpProcess; }
        private OperationProcessPipeline _OpProcess;

        public AccelByteConfig Configuration { get; private set; }

        public string Namespace { get => Configuration.ConfigRepository.Namespace; }

        public AccelByteSDK(AccelByteConfig config)
        {
            Configuration = config;
            _OpProcess = new OperationProcessPipeline();
            _OpProcess.AppendToChain(new SdkMandatoryOperationProcess());
        }

        public HttpResponse RunRequest(Operation operation)
        {
            Operation pOperation = _OpProcess.RunProcessPipeline(operation, this);

            var baseUrl = Configuration.ConfigRepository.BaseUrl;
            return Configuration.HttpClient.SendRequest(pOperation, baseUrl);
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

    public class AccelByteSdkBuilder
    {
        private IHttpClient? _Client = null;

        private ITokenRepository? _TokenRepository = null;

        private IConfigRepository? _ConfigRepository = null;

        private ICredentialRepository? _Credential = null;

        private IHttpLogger? _Logger = null;

        private bool _EnableLogging = false;

        private List<IOperationProcessPipeline> _OpProcesses = new List<IOperationProcessPipeline>();

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

        public AccelByteSdkBuilder AddOperationProcess(IOperationProcessPipeline opProcess)
        {
            _OpProcesses.Add(opProcess);
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

            AccelByteSDK sdk = new AccelByteSDK(config);
            if (_OpProcesses.Count > 0)
            {
                foreach (IOperationProcessPipeline opp in _OpProcesses)
                    sdk.OpProcess.AppendToChain(opp);
            }

            return sdk;
        }
    }
}