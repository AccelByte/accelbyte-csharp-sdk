// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Core
{
    public class SocialSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public SlotConfig SlotConfig
        {
            get
            {
                if (_SlotConfig == null)
                    _SlotConfig = new SlotConfig(_SdkObject);
                return _SlotConfig;
            }
        }
        private SlotConfig? _SlotConfig = null;

        public GameProfile GameProfile
        {
            get
            {
                if (_GameProfile == null)
                    _GameProfile = new GameProfile(_SdkObject);
                return _GameProfile;
            }
        }
        private GameProfile? _GameProfile = null;

        public Slot Slot
        {
            get
            {
                if (_Slot == null)
                    _Slot = new Slot(_SdkObject);
                return _Slot;
            }
        }
        private Slot? _Slot = null;

        public GlobalStatistic GlobalStatistic
        {
            get
            {
                if (_GlobalStatistic == null)
                    _GlobalStatistic = new GlobalStatistic(_SdkObject);
                return _GlobalStatistic;
            }
        }
        private GlobalStatistic? _GlobalStatistic = null;

        public UserStatistic UserStatistic
        {
            get
            {
                if (_UserStatistic == null)
                    _UserStatistic = new UserStatistic(_SdkObject);
                return _UserStatistic;
            }
        }
        private UserStatistic? _UserStatistic = null;

        public StatConfiguration StatConfiguration
        {
            get
            {
                if (_StatConfiguration == null)
                    _StatConfiguration = new StatConfiguration(_SdkObject);
                return _StatConfiguration;
            }
        }
        private StatConfiguration? _StatConfiguration = null;

        internal SocialSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public SocialSdkWrappers Social
        {
            get
            {
                if (_Social == null)
                    _Social = new SocialSdkWrappers(this);
                return _Social;
            }
        }
        private SocialSdkWrappers? _Social = null;
    }
}