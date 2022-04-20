// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Core
{
    public class AchievementSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Achievements Achievements
        {
            get
            {
                if (_Achievements == null)
                    _Achievements = new Achievements(_SdkObject);
                return _Achievements;
            }
        }
        private Achievements? _Achievements = null;

        internal AchievementSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public AchievementSdkWrappers Achievement
        {
            get
            {
                if (_Achievement == null)
                    _Achievement = new AchievementSdkWrappers(this);
                return _Achievement;
            }
        }
        private AchievementSdkWrappers? _Achievement = null;
    }
}