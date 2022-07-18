// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class ScheduledRefreshTokenRepository : DefaultTokenRepository, IRefreshTokenRepository, ISdkConsumerRepository
    {
        private AccelByteSDK? _Sdk = null;

        private Timer _Timer;

        private string _RefreshToken = String.Empty;

        private float _RefreshThreshold = 1.0f;

        private bool _IsRefreshInProgress = false;

        private Action? _OnTokenRefreshed = null;


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

        public bool IsRefreshOnProgress { get; set; } = false;        

        private void _TimerCallback(object? state)
        {
            if (_Sdk == null)
                return;

            if (this.LoginType == LoginType.User ||
                this.LoginType == LoginType.Platform)
            {
                if (HasRefreshToken)
                {
                    _Sdk.RefreshAccessToken(_RefreshToken, (token) =>
                    {
                        UpdateRefreshToken(token.RefreshToken!);
                        _OnTokenRefreshed?.Invoke();
                        if (RefreshTokenEnabled)
                        {
                            int tExpiry = (int)Math.Round((_RefreshThreshold * TokenExpiryIn), 0);
                            _Timer.Change(tExpiry * 1000, Timeout.Infinite);
                        }
                    });
                }
                else
                    _Sdk.LoginUser(true, _RefreshThreshold);
            }
            else if (this.LoginType == LoginType.Client)
            {
                _Sdk.LoginClient(true, _RefreshThreshold);
            }
        }

        public ScheduledRefreshTokenRepository()
        {
            _Timer = new Timer(_TimerCallback);
        }

        public ScheduledRefreshTokenRepository(Action? onTokenRefreshed)
        {
            _Timer = new Timer(_TimerCallback);
            _OnTokenRefreshed = onTokenRefreshed;
        }

        public bool TryToSetRefreshOnProgressToTrue()
        {
            if (_IsRefreshInProgress)
                return false;
            else
            {
                _IsRefreshInProgress = true;
                return _IsRefreshInProgress;
            }
        }

        public void StoreRefreshToken(string refreshToken, float refreshThreshold)
        {
            _RefreshToken = refreshToken;
            _RefreshThreshold = refreshThreshold;
            _IsRefreshInProgress = false;

            if (RefreshTokenEnabled)
            {
                int tExpiry = (int)Math.Round((_RefreshThreshold * TokenExpiryIn), 0);
                _Timer.Change(tExpiry * 1000, Timeout.Infinite);
            }
        }

        public void UpdateRefreshToken(string refreshToken)
        {
            _RefreshToken = refreshToken;
            _IsRefreshInProgress = false;
        }

        public void SetSdkObject(AccelByteSDK sdk)
        {
            _Sdk = sdk;
        }

        public override void RemoveToken()
        {
            base.RemoveToken();
            _Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}