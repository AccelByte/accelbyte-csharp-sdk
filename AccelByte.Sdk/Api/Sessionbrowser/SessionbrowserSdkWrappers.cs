// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Core
{
    public class SessionbrowserSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Session Session
        {
            get
            {
                if (_Session == null)
                    _Session = new Session(_SdkObject);
                return _Session;
            }
        }
        private Session? _Session = null;

        internal SessionbrowserSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public SessionbrowserSdkWrappers Sessionbrowser
        {
            get
            {
                if (_Sessionbrowser == null)
                    _Sessionbrowser = new SessionbrowserSdkWrappers(this);
                return _Sessionbrowser;
            }
        }
        private SessionbrowserSdkWrappers? _Sessionbrowser = null;
    }
}