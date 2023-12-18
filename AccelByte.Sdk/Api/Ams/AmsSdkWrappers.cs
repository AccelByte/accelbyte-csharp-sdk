// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Core
{
    public class AmsSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Auth Auth
        {
            get
            {
                if (_Auth == null)
                    _Auth = new Auth(_SdkObject);
                return _Auth;
            }
        }
        private Auth? _Auth = null;

        public FleetCommander FleetCommander
        {
            get
            {
                if (_FleetCommander == null)
                    _FleetCommander = new FleetCommander(_SdkObject);
                return _FleetCommander;
            }
        }
        private FleetCommander? _FleetCommander = null;

        public Account Account
        {
            get
            {
                if (_Account == null)
                    _Account = new Account(_SdkObject);
                return _Account;
            }
        }
        private Account? _Account = null;

        public Artifacts Artifacts
        {
            get
            {
                if (_Artifacts == null)
                    _Artifacts = new Artifacts(_SdkObject);
                return _Artifacts;
            }
        }
        private Artifacts? _Artifacts = null;

        public Fleets Fleets
        {
            get
            {
                if (_Fleets == null)
                    _Fleets = new Fleets(_SdkObject);
                return _Fleets;
            }
        }
        private Fleets? _Fleets = null;

        public Servers Servers
        {
            get
            {
                if (_Servers == null)
                    _Servers = new Servers(_SdkObject);
                return _Servers;
            }
        }
        private Servers? _Servers = null;

        public Images Images
        {
            get
            {
                if (_Images == null)
                    _Images = new Images(_SdkObject);
                return _Images;
            }
        }
        private Images? _Images = null;

        public AMSQoS AMSQoS
        {
            get
            {
                if (_AMSQoS == null)
                    _AMSQoS = new AMSQoS(_SdkObject);
                return _AMSQoS;
            }
        }
        private AMSQoS? _AMSQoS = null;

        public AMSInfo AMSInfo
        {
            get
            {
                if (_AMSInfo == null)
                    _AMSInfo = new AMSInfo(_SdkObject);
                return _AMSInfo;
            }
        }
        private AMSInfo? _AMSInfo = null;

        public Watchdogs Watchdogs
        {
            get
            {
                if (_Watchdogs == null)
                    _Watchdogs = new Watchdogs(_SdkObject);
                return _Watchdogs;
            }
        }
        private Watchdogs? _Watchdogs = null;

        internal AmsSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public AmsSdkWrappers Ams
        {
            get
            {
                if (_Ams == null)
                    _Ams = new AmsSdkWrappers(this);
                return _Ams;
            }
        }
        private AmsSdkWrappers? _Ams = null;
    }
}