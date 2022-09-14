// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class RefreshableTokenRepository : DefaultTokenRepository, IRefreshTokenRepository
    {
        private static object _ROPLock = new object();

        private string _RefreshToken = String.Empty;

        private float _RefreshThreshold = 1.0f;

        private bool _IsRefreshInProgress = false;

        public bool RefreshTokenEnabled { get; set; } = false;

        public string RefreshToken { get => _RefreshToken; }

        public bool HasRefreshToken { get => (_RefreshToken != String.Empty); }

        public bool IsTokenExpiring
        {
            get
            {
                long tExpiry = (long)Math.Round((_RefreshThreshold * TokenExpiryIn), 0);
                long tgt = IssuedTimestamp + tExpiry;
                return (CurrentTimestamp >= tgt);
            }
        }

        public float RefreshThreshold { get => _RefreshThreshold; }

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
                lock (_ROPLock)
                {
                    _IsRefreshInProgress = value;
                }
            }
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

        public void StoreRefreshToken(string refreshToken, float refreshThreshold)
        {
            _RefreshToken = refreshToken;
            _RefreshThreshold = refreshThreshold;
            lock (_ROPLock)
            {
                _IsRefreshInProgress = false;
            }            
        }

        public void UpdateRefreshToken(string refreshToken)
        {
            _RefreshToken = refreshToken;
            lock (_ROPLock)
            {
                _IsRefreshInProgress = false;
            }            
        }
    }
}