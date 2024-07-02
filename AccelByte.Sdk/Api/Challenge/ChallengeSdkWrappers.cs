// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Challenge.Wrapper;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Core
{
    public class ChallengeSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public ChallengeConfiguration ChallengeConfiguration
        {
            get
            {
                if (_ChallengeConfiguration == null)
                    _ChallengeConfiguration = new ChallengeConfiguration(_SdkObject);
                return _ChallengeConfiguration;
            }
        }
        private ChallengeConfiguration? _ChallengeConfiguration = null;

        public GoalConfiguration GoalConfiguration
        {
            get
            {
                if (_GoalConfiguration == null)
                    _GoalConfiguration = new GoalConfiguration(_SdkObject);
                return _GoalConfiguration;
            }
        }
        private GoalConfiguration? _GoalConfiguration = null;

        public ChallengeProgression ChallengeProgression
        {
            get
            {
                if (_ChallengeProgression == null)
                    _ChallengeProgression = new ChallengeProgression(_SdkObject);
                return _ChallengeProgression;
            }
        }
        private ChallengeProgression? _ChallengeProgression = null;

        public PlayerReward PlayerReward
        {
            get
            {
                if (_PlayerReward == null)
                    _PlayerReward = new PlayerReward(_SdkObject);
                return _PlayerReward;
            }
        }
        private PlayerReward? _PlayerReward = null;

        public ChallengeList ChallengeList
        {
            get
            {
                if (_ChallengeList == null)
                    _ChallengeList = new ChallengeList(_SdkObject);
                return _ChallengeList;
            }
        }
        private ChallengeList? _ChallengeList = null;

        internal ChallengeSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public ChallengeSdkWrappers Challenge
        {
            get
            {
                if (_Challenge == null)
                    _Challenge = new ChallengeSdkWrappers(this);
                return _Challenge;
            }
        }
        private ChallengeSdkWrappers? _Challenge = null;
    }
}