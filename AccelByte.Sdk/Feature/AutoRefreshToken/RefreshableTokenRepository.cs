// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class RefreshableTokenRepository : ITokenRepository, IRefreshTokenRepository
    {
        private static object _ROPLock = new object();

        private string _AccessToken = String.Empty;

        private string _RefreshToken = String.Empty;

        private LoginType _LoginType = LoginType.User;

        private float _RefreshThreshold = 1.0f;

        private int _TokenExpiryIn = 0;

        private bool _IsRefreshInProgress = false;


        public bool RefreshTokenEnabled { get; set; } = false;

        public int SecondsUntilExpiry
        {
            get => (int)((IssuedTimestamp + _TokenExpiryIn) - CurrentTimestamp);
        }

        public string RefreshToken { get => _RefreshToken; }

        public long IssuedTimestamp { get; set; }

        public bool HasToken { get => (_AccessToken != String.Empty); }

        public bool HasRefreshToken { get => (_RefreshToken != String.Empty); }

        public bool IsTokenExpired
        {
            get => (CurrentTimestamp >= (IssuedTimestamp + _TokenExpiryIn));
        }
        public bool IsTokenExpiring
        {
            get
            {
                long tExpiry = (long)Math.Round((_RefreshThreshold * _TokenExpiryIn), 0);
                long tgt = IssuedTimestamp + tExpiry;
                return (CurrentTimestamp >= tgt);
            }
        }

        public float RefreshThreshold { get => _RefreshThreshold; }

        public LoginType LoginType { get => _LoginType; }

        public bool IsRefreshOnProgress
        {
            get
            {
                lock (_ROPLock)
                {
                    return _IsRefreshInProgress;
                }                
            }
            set
            {
                lock(_ROPLock)
                {
                    _IsRefreshInProgress = value;
                }
            }            
        }

        public long CurrentTimestamp
        {
            get => (new DateTimeOffset(DateTime.UtcNow)).ToUnixTimeSeconds();
        }

        public string GetToken()
        {
            return _AccessToken;
        }        

        public void RemoveToken()
        {
            _AccessToken = String.Empty;
        }

        public void StoreToken(string token)
        {
            _AccessToken = token;
        }

        public bool TryToSetRefreshOnProgressToTrue()
        {
            lock (_ROPLock)
            {
                if (_IsRefreshInProgress)
                    return false;
                else
                {
                    _IsRefreshInProgress = true;
                    return _IsRefreshInProgress;
                }
            }
        }

        public void StoreRefreshToken(LoginType loginType, string refreshToken, float refreshThreshold, int expiryIn)
        {
            _LoginType = loginType;
            _RefreshToken = refreshToken;
            _RefreshThreshold = refreshThreshold;
            _TokenExpiryIn = expiryIn;

            IssuedTimestamp = CurrentTimestamp;
            _IsRefreshInProgress = false;
        }

        public void UpdateRefreshToken(string refreshToken, int expiryIn)
        {
            _RefreshToken = refreshToken;
            _TokenExpiryIn = expiryIn;

            IssuedTimestamp = CurrentTimestamp;
            _IsRefreshInProgress = false;
        }

        public void SetTokenExpiry(int expiryIn)
        {
            _TokenExpiryIn = expiryIn;
        }
    }
}