// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Core
{
    public class LeaderboardSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public LeaderboardConfiguration LeaderboardConfiguration
        {
            get
            {
                if (_LeaderboardConfiguration == null)
                    _LeaderboardConfiguration = new LeaderboardConfiguration(_SdkObject);
                return _LeaderboardConfiguration;
            }
        }
        private LeaderboardConfiguration? _LeaderboardConfiguration = null;

        public LeaderboardData LeaderboardData
        {
            get
            {
                if (_LeaderboardData == null)
                    _LeaderboardData = new LeaderboardData(_SdkObject);
                return _LeaderboardData;
            }
        }
        private LeaderboardData? _LeaderboardData = null;

        public UserData UserData
        {
            get
            {
                if (_UserData == null)
                    _UserData = new UserData(_SdkObject);
                return _UserData;
            }
        }
        private UserData? _UserData = null;

        public UserVisibility UserVisibility
        {
            get
            {
                if (_UserVisibility == null)
                    _UserVisibility = new UserVisibility(_SdkObject);
                return _UserVisibility;
            }
        }
        private UserVisibility? _UserVisibility = null;

        internal LeaderboardSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public LeaderboardSdkWrappers Leaderboard
        {
            get
            {
                if (_Leaderboard == null)
                    _Leaderboard = new LeaderboardSdkWrappers(this);
                return _Leaderboard;
            }
        }
        private LeaderboardSdkWrappers? _Leaderboard = null;
    }
}