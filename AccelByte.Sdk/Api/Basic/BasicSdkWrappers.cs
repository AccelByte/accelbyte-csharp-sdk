// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Core
{
    public class BasicSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Namespace Namespace
        {
            get
            {
                if (_Namespace == null)
                    _Namespace = new Namespace(_SdkObject);
                return _Namespace;
            }
        }
        private Namespace? _Namespace = null;

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

        public FileUpload FileUpload
        {
            get
            {
                if (_FileUpload == null)
                    _FileUpload = new FileUpload(_SdkObject);
                return _FileUpload;
            }
        }
        private FileUpload? _FileUpload = null;

        public Misc Misc
        {
            get
            {
                if (_Misc == null)
                    _Misc = new Misc(_SdkObject);
                return _Misc;
            }
        }
        private Misc? _Misc = null;

        public UserProfile UserProfile
        {
            get
            {
                if (_UserProfile == null)
                    _UserProfile = new UserProfile(_SdkObject);
                return _UserProfile;
            }
        }
        private UserProfile? _UserProfile = null;

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

        internal BasicSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public BasicSdkWrappers Basic
        {
            get
            {
                if (_Basic == null)
                    _Basic = new BasicSdkWrappers(this);
                return _Basic;
            }
        }
        private BasicSdkWrappers? _Basic = null;
    }
}