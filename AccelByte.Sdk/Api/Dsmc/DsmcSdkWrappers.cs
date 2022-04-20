// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Core
{
    public class DsmcSdkWrappers
    {
        private AccelByteSDK _SdkObject;

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

        public ImageConfig ImageConfig
        {
            get
            {
                if (_ImageConfig == null)
                    _ImageConfig = new ImageConfig(_SdkObject);
                return _ImageConfig;
            }
        }
        private ImageConfig? _ImageConfig = null;

        public DeploymentConfig DeploymentConfig
        {
            get
            {
                if (_DeploymentConfig == null)
                    _DeploymentConfig = new DeploymentConfig(_SdkObject);
                return _DeploymentConfig;
            }
        }
        private DeploymentConfig? _DeploymentConfig = null;

        public PodConfig PodConfig
        {
            get
            {
                if (_PodConfig == null)
                    _PodConfig = new PodConfig(_SdkObject);
                return _PodConfig;
            }
        }
        private PodConfig? _PodConfig = null;

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

        public DsmcOperations DsmcOperations
        {
            get
            {
                if (_DsmcOperations == null)
                    _DsmcOperations = new DsmcOperations(_SdkObject);
                return _DsmcOperations;
            }
        }
        private DsmcOperations? _DsmcOperations = null;

        internal DsmcSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public DsmcSdkWrappers Dsmc
        {
            get
            {
                if (_Dsmc == null)
                    _Dsmc = new DsmcSdkWrappers(this);
                return _Dsmc;
            }
        }
        private DsmcSdkWrappers? _Dsmc = null;
    }
}