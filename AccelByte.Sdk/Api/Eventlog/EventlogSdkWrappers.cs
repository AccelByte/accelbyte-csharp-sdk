// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Core
{
    public class EventlogSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public EventDescriptions EventDescriptions
        {
            get
            {
                if (_EventDescriptions == null)
                    _EventDescriptions = new EventDescriptions(_SdkObject);
                return _EventDescriptions;
            }
        }
        private EventDescriptions? _EventDescriptions = null;

        public Event Event
        {
            get
            {
                if (_Event == null)
                    _Event = new Event(_SdkObject);
                return _Event;
            }
        }
        private Event? _Event = null;

        public UserInformation UserInformation
        {
            get
            {
                if (_UserInformation == null)
                    _UserInformation = new UserInformation(_SdkObject);
                return _UserInformation;
            }
        }
        private UserInformation? _UserInformation = null;

        public EventRegistry EventRegistry
        {
            get
            {
                if (_EventRegistry == null)
                    _EventRegistry = new EventRegistry(_SdkObject);
                return _EventRegistry;
            }
        }
        private EventRegistry? _EventRegistry = null;

        public EventV2 EventV2
        {
            get
            {
                if (_EventV2 == null)
                    _EventV2 = new EventV2(_SdkObject);
                return _EventV2;
            }
        }
        private EventV2? _EventV2 = null;

        internal EventlogSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public EventlogSdkWrappers Eventlog
        {
            get
            {
                if (_Eventlog == null)
                    _Eventlog = new EventlogSdkWrappers(this);
                return _Eventlog;
            }
        }
        private EventlogSdkWrappers? _Eventlog = null;
    }
}