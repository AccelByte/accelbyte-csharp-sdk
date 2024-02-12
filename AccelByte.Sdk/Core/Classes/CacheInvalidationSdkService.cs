// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public class CacheInvalidationSdkService : ISdkService
    {
        private AccelByteSDK? _Sdk = null;

        private Timer _Timer;

        private int _RefreshInterval;

        private void _TimerCallback(object? state)
        {
            if (_Sdk == null)
                return;

            if (_Sdk.Configuration.TokenValidator != null)
                _Sdk.Configuration.TokenValidator.InvalidateCache();
        }

        public CacheInvalidationSdkService(int refreshInterval)
        {
            _RefreshInterval = refreshInterval;
            _Timer = new Timer(_TimerCallback);
        }

        public void Start(AccelByteSDK sdk)
        {
            _Sdk = sdk;
            _Timer.Change(0, _RefreshInterval);
        }

        public void Stop()
        {
            _Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}
