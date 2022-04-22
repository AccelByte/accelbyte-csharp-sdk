// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Core
{
    public class LegalSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Agreement Agreement
        {
            get
            {
                if (_Agreement == null)
                    _Agreement = new Agreement(_SdkObject);
                return _Agreement;
            }
        }
        private Agreement? _Agreement = null;

        public BaseLegalPolicies BaseLegalPolicies
        {
            get
            {
                if (_BaseLegalPolicies == null)
                    _BaseLegalPolicies = new BaseLegalPolicies(_SdkObject);
                return _BaseLegalPolicies;
            }
        }
        private BaseLegalPolicies? _BaseLegalPolicies = null;

        public LocalizedPolicyVersions LocalizedPolicyVersions
        {
            get
            {
                if (_LocalizedPolicyVersions == null)
                    _LocalizedPolicyVersions = new LocalizedPolicyVersions(_SdkObject);
                return _LocalizedPolicyVersions;
            }
        }
        private LocalizedPolicyVersions? _LocalizedPolicyVersions = null;

        public AdminUserAgreement AdminUserAgreement
        {
            get
            {
                if (_AdminUserAgreement == null)
                    _AdminUserAgreement = new AdminUserAgreement(_SdkObject);
                return _AdminUserAgreement;
            }
        }
        private AdminUserAgreement? _AdminUserAgreement = null;

        public AdminUserEligibilities AdminUserEligibilities
        {
            get
            {
                if (_AdminUserEligibilities == null)
                    _AdminUserEligibilities = new AdminUserEligibilities(_SdkObject);
                return _AdminUserEligibilities;
            }
        }
        private AdminUserEligibilities? _AdminUserEligibilities = null;

        public Policies Policies
        {
            get
            {
                if (_Policies == null)
                    _Policies = new Policies(_SdkObject);
                return _Policies;
            }
        }
        private Policies? _Policies = null;

        public PolicyVersions PolicyVersions
        {
            get
            {
                if (_PolicyVersions == null)
                    _PolicyVersions = new PolicyVersions(_SdkObject);
                return _PolicyVersions;
            }
        }
        private PolicyVersions? _PolicyVersions = null;

        public UserInfo UserInfo
        {
            get
            {
                if (_UserInfo == null)
                    _UserInfo = new UserInfo(_SdkObject);
                return _UserInfo;
            }
        }
        private UserInfo? _UserInfo = null;

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

        public Eligibilities Eligibilities
        {
            get
            {
                if (_Eligibilities == null)
                    _Eligibilities = new Eligibilities(_SdkObject);
                return _Eligibilities;
            }
        }
        private Eligibilities? _Eligibilities = null;

        public Utility Utility
        {
            get
            {
                if (_Utility == null)
                    _Utility = new Utility(_SdkObject);
                return _Utility;
            }
        }
        private Utility? _Utility = null;

        internal LegalSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public LegalSdkWrappers Legal
        {
            get
            {
                if (_Legal == null)
                    _Legal = new LegalSdkWrappers(this);
                return _Legal;
            }
        }
        private LegalSdkWrappers? _Legal = null;
    }
}