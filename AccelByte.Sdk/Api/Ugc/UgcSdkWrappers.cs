// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Core
{
    public class UgcSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public AdminChannel AdminChannel
        {
            get
            {
                if (_AdminChannel == null)
                    _AdminChannel = new AdminChannel(_SdkObject);
                return _AdminChannel;
            }
        }
        private AdminChannel? _AdminChannel = null;

        public AdminContent AdminContent
        {
            get
            {
                if (_AdminContent == null)
                    _AdminContent = new AdminContent(_SdkObject);
                return _AdminContent;
            }
        }
        private AdminContent? _AdminContent = null;

        public AdminGroup AdminGroup
        {
            get
            {
                if (_AdminGroup == null)
                    _AdminGroup = new AdminGroup(_SdkObject);
                return _AdminGroup;
            }
        }
        private AdminGroup? _AdminGroup = null;

        public AdminTag AdminTag
        {
            get
            {
                if (_AdminTag == null)
                    _AdminTag = new AdminTag(_SdkObject);
                return _AdminTag;
            }
        }
        private AdminTag? _AdminTag = null;

        public AdminType AdminType
        {
            get
            {
                if (_AdminType == null)
                    _AdminType = new AdminType(_SdkObject);
                return _AdminType;
            }
        }
        private AdminType? _AdminType = null;

        public Anonymization Anonymization
        {
            get
            {
                if (_Anonymization == null)
                    _Anonymization = new Anonymization(_SdkObject);
                return _Anonymization;
            }
        }
        private Anonymization? _Anonymization = null;

        public PublicContent PublicContent
        {
            get
            {
                if (_PublicContent == null)
                    _PublicContent = new PublicContent(_SdkObject);
                return _PublicContent;
            }
        }
        private PublicContent? _PublicContent = null;

        public PublicFollow PublicFollow
        {
            get
            {
                if (_PublicFollow == null)
                    _PublicFollow = new PublicFollow(_SdkObject);
                return _PublicFollow;
            }
        }
        private PublicFollow? _PublicFollow = null;

        public PublicLike PublicLike
        {
            get
            {
                if (_PublicLike == null)
                    _PublicLike = new PublicLike(_SdkObject);
                return _PublicLike;
            }
        }
        private PublicLike? _PublicLike = null;

        public PublicDownloadCount PublicDownloadCount
        {
            get
            {
                if (_PublicDownloadCount == null)
                    _PublicDownloadCount = new PublicDownloadCount(_SdkObject);
                return _PublicDownloadCount;
            }
        }
        private PublicDownloadCount? _PublicDownloadCount = null;

        public PublicTag PublicTag
        {
            get
            {
                if (_PublicTag == null)
                    _PublicTag = new PublicTag(_SdkObject);
                return _PublicTag;
            }
        }
        private PublicTag? _PublicTag = null;

        public PublicType PublicType
        {
            get
            {
                if (_PublicType == null)
                    _PublicType = new PublicType(_SdkObject);
                return _PublicType;
            }
        }
        private PublicType? _PublicType = null;

        public PublicCreator PublicCreator
        {
            get
            {
                if (_PublicCreator == null)
                    _PublicCreator = new PublicCreator(_SdkObject);
                return _PublicCreator;
            }
        }
        private PublicCreator? _PublicCreator = null;

        public PublicChannel PublicChannel
        {
            get
            {
                if (_PublicChannel == null)
                    _PublicChannel = new PublicChannel(_SdkObject);
                return _PublicChannel;
            }
        }
        private PublicChannel? _PublicChannel = null;

        public PublicGroup PublicGroup
        {
            get
            {
                if (_PublicGroup == null)
                    _PublicGroup = new PublicGroup(_SdkObject);
                return _PublicGroup;
            }
        }
        private PublicGroup? _PublicGroup = null;

        internal UgcSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public UgcSdkWrappers Ugc
        {
            get
            {
                if (_Ugc == null)
                    _Ugc = new UgcSdkWrappers(this);
                return _Ugc;
            }
        }
        private UgcSdkWrappers? _Ugc = null;
    }
}