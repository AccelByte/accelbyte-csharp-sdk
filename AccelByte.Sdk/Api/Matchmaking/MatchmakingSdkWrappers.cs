// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Core
{
    public class MatchmakingSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public MatchmakingOperations MatchmakingOperations
        {
            get
            {
                if (_MatchmakingOperations == null)
                    _MatchmakingOperations = new MatchmakingOperations(_SdkObject);
                return _MatchmakingOperations;
            }
        }
        private MatchmakingOperations? _MatchmakingOperations = null;

        public Matchmaking Matchmaking
        {
            get
            {
                if (_Matchmaking == null)
                    _Matchmaking = new Matchmaking(_SdkObject);
                return _Matchmaking;
            }
        }
        private Matchmaking? _Matchmaking = null;

        public SocialMatchmaking SocialMatchmaking
        {
            get
            {
                if (_SocialMatchmaking == null)
                    _SocialMatchmaking = new SocialMatchmaking(_SdkObject);
                return _SocialMatchmaking;
            }
        }
        private SocialMatchmaking? _SocialMatchmaking = null;

        internal MatchmakingSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public MatchmakingSdkWrappers Matchmaking
        {
            get
            {
                if (_Matchmaking == null)
                    _Matchmaking = new MatchmakingSdkWrappers(this);
                return _Matchmaking;
            }
        }
        private MatchmakingSdkWrappers? _Matchmaking = null;
    }
}