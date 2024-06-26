// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Core
{
    public class SessionhistorySdkWrappers
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

        public Config Config
        {
            get
            {
                if (_Config == null)
                    _Config = new Config(_SdkObject);
                return _Config;
            }
        }
        private Config? _Config = null;

        public GameSessionDetail GameSessionDetail
        {
            get
            {
                if (_GameSessionDetail == null)
                    _GameSessionDetail = new GameSessionDetail(_SdkObject);
                return _GameSessionDetail;
            }
        }
        private GameSessionDetail? _GameSessionDetail = null;

        public XRay XRay
        {
            get
            {
                if (_XRay == null)
                    _XRay = new XRay(_SdkObject);
                return _XRay;
            }
        }
        private XRay? _XRay = null;

        internal SessionhistorySdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public SessionhistorySdkWrappers Sessionhistory
        {
            get
            {
                if (_Sessionhistory == null)
                    _Sessionhistory = new SessionhistorySdkWrappers(this);
                return _Sessionhistory;
            }
        }
        private SessionhistorySdkWrappers? _Sessionhistory = null;
    }
}