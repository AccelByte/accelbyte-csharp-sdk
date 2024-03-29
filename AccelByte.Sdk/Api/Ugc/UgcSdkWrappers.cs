// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

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

        public PublicContentLegacy PublicContentLegacy
        {
            get
            {
                if (_PublicContentLegacy == null)
                    _PublicContentLegacy = new PublicContentLegacy(_SdkObject);
                return _PublicContentLegacy;
            }
        }
        private PublicContentLegacy? _PublicContentLegacy = null;

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

        public PublicLikeLegacy PublicLikeLegacy
        {
            get
            {
                if (_PublicLikeLegacy == null)
                    _PublicLikeLegacy = new PublicLikeLegacy(_SdkObject);
                return _PublicLikeLegacy;
            }
        }
        private PublicLikeLegacy? _PublicLikeLegacy = null;

        public PublicDownloadCountLegacy PublicDownloadCountLegacy
        {
            get
            {
                if (_PublicDownloadCountLegacy == null)
                    _PublicDownloadCountLegacy = new PublicDownloadCountLegacy(_SdkObject);
                return _PublicDownloadCountLegacy;
            }
        }
        private PublicDownloadCountLegacy? _PublicDownloadCountLegacy = null;

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

        public AdminContentV2 AdminContentV2
        {
            get
            {
                if (_AdminContentV2 == null)
                    _AdminContentV2 = new AdminContentV2(_SdkObject);
                return _AdminContentV2;
            }
        }
        private AdminContentV2? _AdminContentV2 = null;

        public AdminConfig AdminConfig
        {
            get
            {
                if (_AdminConfig == null)
                    _AdminConfig = new AdminConfig(_SdkObject);
                return _AdminConfig;
            }
        }
        private AdminConfig? _AdminConfig = null;

        public AdminStagingContent AdminStagingContent
        {
            get
            {
                if (_AdminStagingContent == null)
                    _AdminStagingContent = new AdminStagingContent(_SdkObject);
                return _AdminStagingContent;
            }
        }
        private AdminStagingContent? _AdminStagingContent = null;

        public PublicContentV2 PublicContentV2
        {
            get
            {
                if (_PublicContentV2 == null)
                    _PublicContentV2 = new PublicContentV2(_SdkObject);
                return _PublicContentV2;
            }
        }
        private PublicContentV2? _PublicContentV2 = null;

        public PublicDownloadCountV2 PublicDownloadCountV2
        {
            get
            {
                if (_PublicDownloadCountV2 == null)
                    _PublicDownloadCountV2 = new PublicDownloadCountV2(_SdkObject);
                return _PublicDownloadCountV2;
            }
        }
        private PublicDownloadCountV2? _PublicDownloadCountV2 = null;

        public PublicLikeV2 PublicLikeV2
        {
            get
            {
                if (_PublicLikeV2 == null)
                    _PublicLikeV2 = new PublicLikeV2(_SdkObject);
                return _PublicLikeV2;
            }
        }
        private PublicLikeV2? _PublicLikeV2 = null;

        public PublicStagingContent PublicStagingContent
        {
            get
            {
                if (_PublicStagingContent == null)
                    _PublicStagingContent = new PublicStagingContent(_SdkObject);
                return _PublicStagingContent;
            }
        }
        private PublicStagingContent? _PublicStagingContent = null;

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