// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Core
{
    public class GdprSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public DataDeletion DataDeletion
        {
            get
            {
                if (_DataDeletion == null)
                    _DataDeletion = new DataDeletion(_SdkObject);
                return _DataDeletion;
            }
        }
        private DataDeletion? _DataDeletion = null;

        public DataRetrieval DataRetrieval
        {
            get
            {
                if (_DataRetrieval == null)
                    _DataRetrieval = new DataRetrieval(_SdkObject);
                return _DataRetrieval;
            }
        }
        private DataRetrieval? _DataRetrieval = null;

        internal GdprSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public GdprSdkWrappers Gdpr
        {
            get
            {
                if (_Gdpr == null)
                    _Gdpr = new GdprSdkWrappers(this);
                return _Gdpr;
            }
        }
        private GdprSdkWrappers? _Gdpr = null;
    }
}