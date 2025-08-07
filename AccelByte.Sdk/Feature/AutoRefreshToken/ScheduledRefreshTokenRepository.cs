// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class ScheduledRefreshTokenRepository : BaseRefreshTokenRepository, ISdkConsumerRepository
    {
        private AccelByteSDK? _Sdk = null;

        private Timer _Timer;

        private int _CheckInterval = 2000; // in ms

        private Action? _OnTokenRefreshed = null;

        private Action<Exception>? _OnRefreshFailed = null;

        private void _TimerCallback(object? state)
        {
            if (_Sdk == null)
                return;

            Task.Run(() => DoRefreshTokenAsync(_Sdk, _OnTokenRefreshed, _OnRefreshFailed, false));
        }

        public ScheduledRefreshTokenRepository() :
            base(BackgroundTokenRefreshOptions.Default)
        {
            _Timer = new Timer(_TimerCallback);
        }

        public ScheduledRefreshTokenRepository(Action? onTokenRefreshed) :
            base(BackgroundTokenRefreshOptions.Default)
        {
            _Timer = new Timer(_TimerCallback);
            _OnTokenRefreshed = onTokenRefreshed;
        }

        public ScheduledRefreshTokenRepository(BackgroundTokenRefreshOptions opts, bool startImmediately)
            : base(opts)
        {
            _CheckInterval = opts.Interval * 1000; //in ms
            _OnTokenRefreshed = opts.OnTokenRefreshed;
            _OnRefreshFailed = opts.OnRefreshFailed;

            _Timer = new Timer(_TimerCallback);
            if (startImmediately)
                _Timer.Change(0, _CheckInterval);
        }

        public void SetSdkObject(AccelByteSDK sdk)
        {
            _Sdk = sdk;
        }

        public void Start()
        {
            _Timer.Change(0, _CheckInterval);
        }

        public void Stop()
        {
            _Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}