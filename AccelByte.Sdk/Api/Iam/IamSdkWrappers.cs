// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Core
{
    public class IamSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Bans Bans
        {
            get
            {
                if (_Bans == null)
                    _Bans = new Bans(_SdkObject);
                return _Bans;
            }
        }
        private Bans? _Bans = null;

        public Clients Clients
        {
            get
            {
                if (_Clients == null)
                    _Clients = new Clients(_SdkObject);
                return _Clients;
            }
        }
        private Clients? _Clients = null;

        public Users Users
        {
            get
            {
                if (_Users == null)
                    _Users = new Users(_SdkObject);
                return _Users;
            }
        }
        private Users? _Users = null;

        public OAuth OAuth
        {
            get
            {
                if (_OAuth == null)
                    _OAuth = new OAuth(_SdkObject);
                return _OAuth;
            }
        }
        private OAuth? _OAuth = null;

        public Roles Roles
        {
            get
            {
                if (_Roles == null)
                    _Roles = new Roles(_SdkObject);
                return _Roles;
            }
        }
        private Roles? _Roles = null;

        public InputValidations InputValidations
        {
            get
            {
                if (_InputValidations == null)
                    _InputValidations = new InputValidations(_SdkObject);
                return _InputValidations;
            }
        }
        private InputValidations? _InputValidations = null;

        public ThirdPartyCredential ThirdPartyCredential
        {
            get
            {
                if (_ThirdPartyCredential == null)
                    _ThirdPartyCredential = new ThirdPartyCredential(_SdkObject);
                return _ThirdPartyCredential;
            }
        }
        private ThirdPartyCredential? _ThirdPartyCredential = null;

        public SSOCredential SSOCredential
        {
            get
            {
                if (_SSOCredential == null)
                    _SSOCredential = new SSOCredential(_SdkObject);
                return _SSOCredential;
            }
        }
        private SSOCredential? _SSOCredential = null;

        public OAuth20Extension OAuth20Extension
        {
            get
            {
                if (_OAuth20Extension == null)
                    _OAuth20Extension = new OAuth20Extension(_SdkObject);
                return _OAuth20Extension;
            }
        }
        private OAuth20Extension? _OAuth20Extension = null;

        public OAuth20 OAuth20
        {
            get
            {
                if (_OAuth20 == null)
                    _OAuth20 = new OAuth20(_SdkObject);
                return _OAuth20;
            }
        }
        private OAuth20? _OAuth20 = null;

        public SSOSAML20 SSOSAML20
        {
            get
            {
                if (_SSOSAML20 == null)
                    _SSOSAML20 = new SSOSAML20(_SdkObject);
                return _SSOSAML20;
            }
        }
        private SSOSAML20? _SSOSAML20 = null;

        public SSO SSO
        {
            get
            {
                if (_SSO == null)
                    _SSO = new SSO(_SdkObject);
                return _SSO;
            }
        }
        private SSO? _SSO = null;

        public UsersV4 UsersV4
        {
            get
            {
                if (_UsersV4 == null)
                    _UsersV4 = new UsersV4(_SdkObject);
                return _UsersV4;
            }
        }
        private UsersV4? _UsersV4 = null;

        internal IamSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public IamSdkWrappers Iam
        {
            get
            {
                if (_Iam == null)
                    _Iam = new IamSdkWrappers(this);
                return _Iam;
            }
        }
        private IamSdkWrappers? _Iam = null;
    }
}