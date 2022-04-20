// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Core
{
    public class DslogmanagerSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public TerminatedServers TerminatedServers
        {
            get
            {
                if (_TerminatedServers == null)
                    _TerminatedServers = new TerminatedServers(_SdkObject);
                return _TerminatedServers;
            }
        }
        private TerminatedServers? _TerminatedServers = null;

        public AllTerminatedServers AllTerminatedServers
        {
            get
            {
                if (_AllTerminatedServers == null)
                    _AllTerminatedServers = new AllTerminatedServers(_SdkObject);
                return _AllTerminatedServers;
            }
        }
        private AllTerminatedServers? _AllTerminatedServers = null;

        public DslogmanagerOperations DslogmanagerOperations
        {
            get
            {
                if (_DslogmanagerOperations == null)
                    _DslogmanagerOperations = new DslogmanagerOperations(_SdkObject);
                return _DslogmanagerOperations;
            }
        }
        private DslogmanagerOperations? _DslogmanagerOperations = null;

        internal DslogmanagerSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public DslogmanagerSdkWrappers Dslogmanager
        {
            get
            {
                if (_Dslogmanager == null)
                    _Dslogmanager = new DslogmanagerSdkWrappers(this);
                return _Dslogmanager;
            }
        }
        private DslogmanagerSdkWrappers? _Dslogmanager = null;
    }
}