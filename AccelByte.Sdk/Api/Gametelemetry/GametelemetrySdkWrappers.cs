// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Api.Gametelemetry.Operation;

namespace AccelByte.Sdk.Core
{
    public class GametelemetrySdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public GametelemetryOperations GametelemetryOperations
        {
            get
            {
                if (_GametelemetryOperations == null)
                    _GametelemetryOperations = new GametelemetryOperations(_SdkObject);
                return _GametelemetryOperations;
            }
        }
        private GametelemetryOperations? _GametelemetryOperations = null;

        internal GametelemetrySdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public GametelemetrySdkWrappers Gametelemetry
        {
            get
            {
                if (_Gametelemetry == null)
                    _Gametelemetry = new GametelemetrySdkWrappers(this);
                return _Gametelemetry;
            }
        }
        private GametelemetrySdkWrappers? _Gametelemetry = null;
    }
}