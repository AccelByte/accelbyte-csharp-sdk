// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Core
{
    public class SeasonpassSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Season Season
        {
            get
            {
                if (_Season == null)
                    _Season = new Season(_SdkObject);
                return _Season;
            }
        }
        private Season? _Season = null;

        public Pass Pass
        {
            get
            {
                if (_Pass == null)
                    _Pass = new Pass(_SdkObject);
                return _Pass;
            }
        }
        private Pass? _Pass = null;

        public Reward Reward
        {
            get
            {
                if (_Reward == null)
                    _Reward = new Reward(_SdkObject);
                return _Reward;
            }
        }
        private Reward? _Reward = null;

        public Tier Tier
        {
            get
            {
                if (_Tier == null)
                    _Tier = new Tier(_SdkObject);
                return _Tier;
            }
        }
        private Tier? _Tier = null;

        internal SeasonpassSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public SeasonpassSdkWrappers Seasonpass
        {
            get
            {
                if (_Seasonpass == null)
                    _Seasonpass = new SeasonpassSdkWrappers(this);
                return _Seasonpass;
            }
        }
        private SeasonpassSdkWrappers? _Seasonpass = null;
    }
}