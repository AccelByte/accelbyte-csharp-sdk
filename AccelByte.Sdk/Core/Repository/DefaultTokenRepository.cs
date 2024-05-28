// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core.Util;
using Microsoft.IdentityModel.Tokens;

namespace AccelByte.Sdk.Core.Repository
{
    public class DefaultTokenRepository : ITokenRepository, IObservableTokenRepository
    {
        private object _TokenLock = new object();

        public long CurrentTimestamp
        {
            get => (new DateTimeOffset(DateTime.UtcNow)).ToUnixTimeSeconds();
        }

        private string _Token = String.Empty;
        public string Token
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Token != String.Empty)
                        return _Token;
                    else
                        throw new Exception("No token stored.");
                }
            }
            protected set
            {
                lock (_TokenLock)
                {
                    _Token = value;
                }
            }
        }

        private int _TokenExpiryIn = 0;

        public int TokenExpiryIn
        {
            get
            {
                lock (_TokenLock)
                {
                    return _TokenExpiryIn;
                }
            }
        }

        public int SecondsUntilExpiry
        {
            get
            {
                lock (_TokenLock)
                {
                    return (int)((IssuedTimestamp + _TokenExpiryIn) - CurrentTimestamp);
                }
            }
        }

        public long IssuedTimestamp { get; set; } = 0;

        public bool HasToken
        {
            get
            {
                lock (_TokenLock)
                {
                    return (_Token != String.Empty);
                }
            }
        }

        public bool IsTokenExpired
        {
            get
            {
                lock (_TokenLock)
                {
                    return CurrentTimestamp >= (IssuedTimestamp + _TokenExpiryIn);
                }
            }
        }

        private LoginType _LoginType = LoginType.User;
        public LoginType LoginType
        {
            get
            {
                lock (_TokenLock)
                {
                    return _LoginType;
                }
            }
        }

        public TokenData? TokenData { get; protected set; } = null;

        private List<ITokenRepositoryObserver> _Observers = new List<ITokenRepositoryObserver>();

        // Deprecated(2023-02-13): Please use `Token` property instead.
        [Obsolete("# Deprecated(2023-02-13): Please use `Token` property instead.", DiagnosticId = "AB_TOKEN_REPO_DEPRECATED_METHOD")]
        public string GetToken()
        {
            lock (_TokenLock)
            {
                if (_Token != null)
                    return _Token;
                else
                    throw new Exception("No token stored.");
            }
        }

        public virtual void RemoveToken()
        {
            lock (_TokenLock)
            {
                _Token = String.Empty;
                _TokenExpiryIn = 0;
                IssuedTimestamp = 0;
                TokenData = null;
            }
        }

        public void StoreToken(LoginType loginType, OauthmodelTokenResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = new TokenData(tokenResponse);

                _Token = tokenResponse.AccessToken;
                _LoginType = loginType;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        public void StoreToken(LoginType loginType, OauthmodelTokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = new TokenData(tokenResponse);

                _Token = tokenResponse.AccessToken;
                _LoginType = loginType;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        public void StoreToken(LoginType loginType, OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = new TokenData(tokenResponse);

                _Token = tokenResponse.AccessToken;
                _LoginType = loginType;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        public void UpdateToken(OauthmodelTokenResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = new TokenData(tokenResponse);

                _Token = tokenResponse.AccessToken;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        public void UpdateToken(OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = new TokenData(tokenResponse);

                _Token = tokenResponse.AccessToken;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        // Deprecated(2023-02-13): Please use `StoreToken` with `OauthmodelTokenResponseV3` or `OauthmodelTokenWithDeviceCookieResponseV3` parameter.
        [Obsolete("# Deprecated(2023-02-13): Please use `StoreToken` with `OauthmodelTokenResponseV3` or `OauthmodelTokenWithDeviceCookieResponseV3` parameter.", DiagnosticId = "AB_TOKEN_REPO_DEPRECATED_METHOD")]
        public void StoreToken(string token)
        {
            lock (_TokenLock)
            {
                _Token = token;
            }
        }

        public void SetTokenExpiry(int value)
        {
            lock (_TokenLock)
            {
                _TokenExpiryIn = value;
            }   
        }

        public void RegisterObserver(ITokenRepositoryObserver observer)
        {
            _Observers.Add(observer);
        }

        public void UnregisterObserver(ITokenRepositoryObserver observer)
        {
            _Observers.Remove(observer);
        }

        public async Task UpdateObserversWithNewToken()
        {
            string newToken = Token;
            foreach (var observer in _Observers)
                await observer.OnAccessTokenChanged(newToken);
        }
    }
}