// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Core
{
    public class QosmSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Admin Admin
        {
            get
            {
                if (_Admin == null)
                    _Admin = new Admin(_SdkObject);
                return _Admin;
            }
        }
        private Admin? _Admin = null;

        public Public Public
        {
            get
            {
                if (_Public == null)
                    _Public = new Public(_SdkObject);
                return _Public;
            }
        }
        private Public? _Public = null;

        public Server Server
        {
            get
            {
                if (_Server == null)
                    _Server = new Server(_SdkObject);
                return _Server;
            }
        }
        private Server? _Server = null;

        internal QosmSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public QosmSdkWrappers Qosm
        {
            get
            {
                if (_Qosm == null)
                    _Qosm = new QosmSdkWrappers(this);
                return _Qosm;
            }
        }
        private QosmSdkWrappers? _Qosm = null;
    }
}