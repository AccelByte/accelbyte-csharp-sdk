// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Core
{
    public class CloudsaveSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public AdminConcurrentRecord AdminConcurrentRecord
        {
            get
            {
                if (_AdminConcurrentRecord == null)
                    _AdminConcurrentRecord = new AdminConcurrentRecord(_SdkObject);
                return _AdminConcurrentRecord;
            }
        }
        private AdminConcurrentRecord? _AdminConcurrentRecord = null;

        public AdminGameRecord AdminGameRecord
        {
            get
            {
                if (_AdminGameRecord == null)
                    _AdminGameRecord = new AdminGameRecord(_SdkObject);
                return _AdminGameRecord;
            }
        }
        private AdminGameRecord? _AdminGameRecord = null;

        public AdminPlayerRecord AdminPlayerRecord
        {
            get
            {
                if (_AdminPlayerRecord == null)
                    _AdminPlayerRecord = new AdminPlayerRecord(_SdkObject);
                return _AdminPlayerRecord;
            }
        }
        private AdminPlayerRecord? _AdminPlayerRecord = null;

        public ConcurrentRecord ConcurrentRecord
        {
            get
            {
                if (_ConcurrentRecord == null)
                    _ConcurrentRecord = new ConcurrentRecord(_SdkObject);
                return _ConcurrentRecord;
            }
        }
        private ConcurrentRecord? _ConcurrentRecord = null;

        public PublicGameRecord PublicGameRecord
        {
            get
            {
                if (_PublicGameRecord == null)
                    _PublicGameRecord = new PublicGameRecord(_SdkObject);
                return _PublicGameRecord;
            }
        }
        private PublicGameRecord? _PublicGameRecord = null;

        public PublicPlayerRecord PublicPlayerRecord
        {
            get
            {
                if (_PublicPlayerRecord == null)
                    _PublicPlayerRecord = new PublicPlayerRecord(_SdkObject);
                return _PublicPlayerRecord;
            }
        }
        private PublicPlayerRecord? _PublicPlayerRecord = null;

        internal CloudsaveSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public CloudsaveSdkWrappers Cloudsave
        {
            get
            {
                if (_Cloudsave == null)
                    _Cloudsave = new CloudsaveSdkWrappers(this);
                return _Cloudsave;
            }
        }
        private CloudsaveSdkWrappers? _Cloudsave = null;
    }
}