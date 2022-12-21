// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Core
{
    public class Match2SdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Operations Operations
        {
            get
            {
                if (_Operations == null)
                    _Operations = new Operations(_SdkObject);
                return _Operations;
            }
        }
        private Operations? _Operations = null;

        public Backfill Backfill
        {
            get
            {
                if (_Backfill == null)
                    _Backfill = new Backfill(_SdkObject);
                return _Backfill;
            }
        }
        private Backfill? _Backfill = null;

        public MatchFunctions MatchFunctions
        {
            get
            {
                if (_MatchFunctions == null)
                    _MatchFunctions = new MatchFunctions(_SdkObject);
                return _MatchFunctions;
            }
        }
        private MatchFunctions? _MatchFunctions = null;

        public MatchPools MatchPools
        {
            get
            {
                if (_MatchPools == null)
                    _MatchPools = new MatchPools(_SdkObject);
                return _MatchPools;
            }
        }
        private MatchPools? _MatchPools = null;

        public MatchTickets MatchTickets
        {
            get
            {
                if (_MatchTickets == null)
                    _MatchTickets = new MatchTickets(_SdkObject);
                return _MatchTickets;
            }
        }
        private MatchTickets? _MatchTickets = null;

        public RuleSets RuleSets
        {
            get
            {
                if (_RuleSets == null)
                    _RuleSets = new RuleSets(_SdkObject);
                return _RuleSets;
            }
        }
        private RuleSets? _RuleSets = null;

        internal Match2SdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public Match2SdkWrappers Match2
        {
            get
            {
                if (_Match2 == null)
                    _Match2 = new Match2SdkWrappers(this);
                return _Match2;
            }
        }
        private Match2SdkWrappers? _Match2 = null;
    }
}