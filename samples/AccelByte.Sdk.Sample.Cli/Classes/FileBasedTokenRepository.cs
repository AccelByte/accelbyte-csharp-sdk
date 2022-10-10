// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Sample.Cli
{
    public class FileBasedTokenRepository : ITokenRepository
    {
        private class _TokenStore
        {
            [JsonPropertyName("token")]
            public string Token { get; set; } = String.Empty;

            [JsonPropertyName("expiry_in")]
            public int TokenExpiryIn { get; set; } = 0;

            [JsonPropertyName("type")]
            public LoginType Type { get; set; } = LoginType.User;

            [JsonPropertyName("issued")]
            public long IssuedTimestamp { get; set; } = 0;

            public static _TokenStore? LoadFromFile(string fileName)
            {
                if (!File.Exists(fileName))
                    return null;

                string content = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<_TokenStore>(content, new JsonSerializerOptions()
                {
                    AllowTrailingCommas = true,
                    ReadCommentHandling = JsonCommentHandling.Skip
                })!;
            }

            public void SaveToFile(string fileName)
            {
                string content = JsonSerializer.Serialize(this);
                File.WriteAllText(fileName, content);
            }
        }

        private string _FileName;

        private _TokenStore? _Store = null;

        private object _TokenLock = new object();

        public long CurrentTimestamp
        {
            get => (new DateTimeOffset(DateTime.UtcNow)).ToUnixTimeSeconds();
        }

        public string Token
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Store == null)
                        _Store = _TokenStore.LoadFromFile(_FileName);

                    if (_Store == null)
                        throw new Exception("No token stored.");

                    return _Store.Token;
                }
            }
        }

        public int TokenExpiryIn
        {
            get
            {
                lock (_TokenLock)
                {
                    return (_Store != null ? _Store.TokenExpiryIn : 0);
                }
            }
        }

        public int SecondsUntilExpiry
        {
            get => (int)((IssuedTimestamp + TokenExpiryIn) - CurrentTimestamp);
        }

        public long IssuedTimestamp
        {
            get
            {
                lock (_TokenLock)
                {
                    return (_Store != null ? _Store.IssuedTimestamp : 0);
                }
            }
            set
            {
                lock (_TokenLock)
                {
                    if (_Store != null)
                        _Store.IssuedTimestamp = value;
                }
            }
        }

        public bool HasToken
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Store == null)
                        _Store = _TokenStore.LoadFromFile(_FileName);
                    return (_Store != null);
                }
            }
        }

        public bool IsTokenExpired
        {
            get => (CurrentTimestamp >= (IssuedTimestamp + TokenExpiryIn));
        }

        public LoginType LoginType
        {
            get => (_Store != null ? _Store.Type : LoginType.User);
        }

        public FileBasedTokenRepository(string fileName)
        {
            _FileName = fileName;
            _Store = _TokenStore.LoadFromFile(_FileName);
        }

        public FileBasedTokenRepository()
        {
            string aLoc = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
            _FileName = (aLoc + Path.DirectorySeparatorChar + "token.json");
            _Store = _TokenStore.LoadFromFile(_FileName);
        }

        public string GetToken()
        {
            return Token;
        }

        public void RemoveToken()
        {
            lock (_TokenLock)
            {
                if (File.Exists(_FileName))
                    File.Delete(_FileName);
                _Store = null;
            }
        }

        public void StoreToken(LoginType loginType, OauthmodelTokenResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                _Store = new _TokenStore()
                {
                    Token = tokenResponse.AccessToken,
                    Type = LoginType,
                    IssuedTimestamp = CurrentTimestamp
                };

                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void StoreToken(LoginType loginType, OauthmodelTokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                _Store = new _TokenStore()
                {
                    Token = tokenResponse.AccessToken,
                    Type = LoginType,
                    IssuedTimestamp = CurrentTimestamp
                };

                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void StoreToken(LoginType loginType, OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                _Store = new _TokenStore()
                {
                    Token = tokenResponse.AccessToken,
                    Type = LoginType,
                    IssuedTimestamp = CurrentTimestamp
                };

                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void UpdateToken(OauthmodelTokenResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                if (_Store == null)
                    _Store = new _TokenStore();

                _Store.Token = tokenResponse.AccessToken;
                _Store.IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void UpdateToken(OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                if (_Store == null)
                    _Store = new _TokenStore();

                _Store.Token = tokenResponse.AccessToken;
                _Store.IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void StoreToken(string token)
        {

        }
    }
}