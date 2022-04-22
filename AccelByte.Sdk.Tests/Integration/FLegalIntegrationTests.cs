// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class FLegalIntegrationTests : BaseIntegrationTest
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

            List<RetrieveBasePolicyResponse>? bPolicies = _Sdk.Legal.BaseLegalPolicies.RetrieveAllLegalPoliciesOp.Execute();
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
                List<RetrievePolicyTypeResponse>? policyTypes = _Sdk.Legal.BaseLegalPolicies.RetrieveAllPolicyTypesOp
                    .SetOffset(0)
                    .Execute(100);
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

                CreateBasePolicyResponse? bPolResp = _Sdk.Legal.BaseLegalPolicies.CreatePolicyOp
                    .SetBody(createPolicy)
                    .Execute();
                Assert.IsNotNull(bPolResp);
                targetPolicyId = bPolResp!.PolicyId!;
            }

            List<RetrievePolicyVersionResponse>? polVers = _Sdk.Legal.PolicyVersions.RetrieveSinglePolicyVersionOp
                .Execute(targetPolicyId);
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

                CreatePolicyVersionResponse? polVerResp = _Sdk.Legal.PolicyVersions.CreatePolicyVersionOp
                    .SetBody(policyVersion)
                    .Execute(targetPolicyId);
                Assert.IsNotNull(polVerResp);
                targetPolicyVersionId = polVerResp!.Id!;
            }
            else
            {
                targetPolicyVersionId = polVers![0].Id!;
            }

            List<RetrieveLocalizedPolicyVersionResponse>? locPolVers = _Sdk.Legal.LocalizedPolicyVersions.RetrieveLocalizedPolicyVersionsOp
                .Execute(targetPolicyVersionId);
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

                CreateLocalizedPolicyVersionResponse? locPolResp = _Sdk.Legal.LocalizedPolicyVersions.CreateLocalizedPolicyVersionOp
                    .SetBody(localPolicy)
                    .Execute(targetPolicyVersionId);
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
                    IsAccepted = true,
                    IsNeedToSendEventMarketing = false
                }
            };

            string userId = _Sdk.Configuration.Credential!.UserId;
            _Sdk.Legal.Agreement.ChangePreferenceConsentOp
                .SetBody(aggreementRequests)
                .Execute(_Sdk.Namespace, userId);
        }

        [Test]
        public void RetrieveAgreementsPublicTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;
            
            List<RetrieveAcceptedAgreementResponse>? aggrs = _Sdk.Legal.Agreement.RetrieveAgreementsPublicOp
                .Execute();
            Assert.IsNotNull(aggrs);
        }
    }
}