// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "Integration")]
    [Explicit]
    public class LegalIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseInMemoryTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        [Test]
        public void CreateMarketingPreferencePolicyAndAcceptTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string basePolicyName = "CSharp Server SDK Test Policy";
            string marketingPrefPolicyTypeId = String.Empty;
            string targetPolicyId = String.Empty;
            string targetPolicyVersionId;
            string targetLocalizedPolicyId;

            BaseLegalPolicies wPolicy = new BaseLegalPolicies(_Sdk);
            PolicyVersions wPolicyVersions = new PolicyVersions(_Sdk);
            LocalizedPolicyVersions wLocalizedPolicy = new LocalizedPolicyVersions(_Sdk);
            Agreement wLegalAgreement = new Agreement(_Sdk);

            List<RetrieveBasePolicyResponse>? bPolicies = wPolicy.RetrieveAllLegalPolicies(
                RetrieveAllLegalPolicies.Builder
                .Build());
            Assert.IsNotNull(bPolicies);

            //Try to find existing policy with specified name.
            foreach (var bPolicy in bPolicies!)
            {
                if (bPolicy.BasePolicyName == basePolicyName)
                {
                    Assert.Greater(bPolicy!.Policies!.Count, 0);
                    targetPolicyId = bPolicy!.Policies![0].Id!;
                }   
            }

            if (targetPolicyId == String.Empty)
            {
                //Policy does not exists. so we create it.

                //Retrieving policy type id for Marketing Preference
                List<RetrievePolicyTypeResponse>? policyTypes = wPolicy.RetrieveAllPolicyTypes(
                    RetrieveAllPolicyTypes.Builder
                    .SetOffset(0)
                    .Build(100));
                Assert.IsNotNull(policyTypes);

                foreach (RetrievePolicyTypeResponse policyType in policyTypes!)
                {
                    if (policyType.PolicyTypeName!.Trim().ToLower() == "marketing preference")
                        marketingPrefPolicyTypeId = policyType.Id!;
                }
                Assert.IsNotEmpty(marketingPrefPolicyTypeId, "Marketing preference policy type not found.");

                //Create a policy for marketing preference.
                CreateBasePolicyRequest createPolicy = new CreateBasePolicyRequest()
                {
                    TypeId = marketingPrefPolicyTypeId,
                    BasePolicyName = basePolicyName,
                    Description = "Testing CSharp Server SDK legal endpoints.",
                    Namespace = _Sdk.Namespace,
                    Tags = new List<string>() { "csharp", "server_sdk", "test" },
                    AffectedCountries = new List<string>() { "ID" },
                    AffectedClientIds = new List<string>()
                };

                CreateBasePolicyResponse? bPolResp = wPolicy.CreatePolicy(
                    CreatePolicy.Builder
                    .SetBody(createPolicy)
                    .Build());
                Assert.IsNotNull(bPolResp);
                targetPolicyId = bPolResp!.PolicyId!;
            }

            List<RetrievePolicyVersionResponse>? polVers = wPolicyVersions.RetrieveSinglePolicyVersion(
                RetrieveSinglePolicyVersion.Builder
                .Build(targetPolicyId));
            Assert.IsNotNull(polVers);
            if (polVers!.Count <= 0)
            {
                //No version available, so create one
                CreatePolicyVersionRequest policyVersion = new CreatePolicyVersionRequest()
                {
                    DisplayVersion = "1.0.0",
                    Description = "Testing CSharp Server SDK legal endpoints.",
                    IsCommitted = false
                };

                CreatePolicyVersionResponse? polVerResp = wPolicyVersions.CreatePolicyVersion(
                    CreatePolicyVersion.Builder
                    .SetBody(policyVersion)
                    .Build(targetPolicyId));
                Assert.IsNotNull(polVerResp);
                targetPolicyVersionId = polVerResp!.Id!;
            }
            else
            {
                targetPolicyVersionId = polVers![0].Id!;
            }

            List<RetrieveLocalizedPolicyVersionResponse>? locPolVers = wLocalizedPolicy.RetrieveLocalizedPolicyVersions(
                RetrieveLocalizedPolicyVersions.Builder
                .Build(targetPolicyVersionId));
            Assert.IsNotNull(locPolVers);
            if (locPolVers!.Count <= 0)
            {
                //No localized version available, so create one
                CreateLocalizedPolicyVersionRequest localPolicy = new CreateLocalizedPolicyVersionRequest()
                {
                    LocaleCode = "ID",
                    ContentType = "CSharp Server SDK Legal Content for ID",
                    Description = "Testing CSharp Server SDK legal endpoints."
                };

                CreateLocalizedPolicyVersionResponse? locPolResp = wLocalizedPolicy.CreateLocalizedPolicyVersion(
                    CreateLocalizedPolicyVersion.Builder
                    .SetBody(localPolicy)
                    .Build(targetPolicyVersionId));
                Assert.IsNotNull(locPolResp);
                targetLocalizedPolicyId = locPolResp!.Id!;
            }
            else
            {
                targetLocalizedPolicyId = locPolVers![0].Id!;
            }
           
            List<AcceptAgreementRequest> aggreementRequests = new List<AcceptAgreementRequest>()
            {
                new AcceptAgreementRequest()
                {
                    LocalizedPolicyVersionId = targetLocalizedPolicyId,
                    PolicyVersionId = targetPolicyVersionId,
                    PolicyId = targetPolicyId,
                    IsAccepted = true
                }
            };

            wLegalAgreement.ChangePreferenceConsent(
                ChangePreferenceConsent.Builder
                .SetBody(aggreementRequests)
                .Build());
        }

        [Test]
        public void RetrieveAgreementsPublicTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Agreement wLegalAgreement = new Agreement(_Sdk);

            List<RetrieveAcceptedAgreementResponse>? aggrs = wLegalAgreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs);
        }

        [Test]
        [Ignore("Deprecated due to redundant with CreatePolicyAndAcceptTest")]
        public void ChangePreferenceConsentTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Agreement wLegalAgreement = new Agreement(_Sdk);

            List<AcceptAgreementRequest> aggreementRequests = new List<AcceptAgreementRequest>()
            {
                new AcceptAgreementRequest()
                {
                    LocalizedPolicyVersionId = "152b9b0f-7b8e-4a9e-8a9d-8c82420ad8b3",
                    PolicyVersionId = "a76ea12c-14fd-46c5-886f-fd3d0ded4408",
                    PolicyId = "6adb3d65-b428-4dbc-a08d-e5126c644557", // the marketing policy
                    IsAccepted = true
                }
            };

            wLegalAgreement.ChangePreferenceConsent(
                ChangePreferenceConsent.Builder
                .SetBody(aggreementRequests)
                .Build());
        }
    }
}