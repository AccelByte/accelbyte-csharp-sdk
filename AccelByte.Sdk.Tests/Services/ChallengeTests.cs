// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class ChallengeTests : BaseServiceTests
    {
        public ChallengeTests() : base(false) { }

        [Test]
        public void ChallengeAndGoalTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string challengeCode = $"csharp-{Helper.GenerateRandomId(6)}-challenge";
            string challengeName = "CSharp Challenge Test";
            string goalCode = $"csharp-{Helper.GenerateRandomId(6)}-goal";
            string goalName = $"CSharp Goal Test";

            #region Create a new challenge
            var newChallenge = _Sdk.Challenge.ChallengeConfiguration.AdminCreateChallengeOp
                .Execute(new ModelCreateChallengeRequest()
                {
                    Code = challengeCode,
                    Description = "",
                    Name = challengeName,
                    AssignmentRule = ModelCreateChallengeRequestAssignmentRule.FIXED,
                    GoalsVisibility = ModelCreateChallengeRequestGoalsVisibility.SHOWALL,
                    Rotation = ModelCreateChallengeRequestRotation.DAILY,
                    StartDate = DateTime.Now.AddDays(1)
                }, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(newChallenge);
            if (newChallenge != null)
            {
                Assert.AreEqual(challengeName, newChallenge.Name);
            }

            try
            {
                #region Get challenge
                var challengeData = _Sdk.Challenge.ChallengeConfiguration.AdminGetChallengeOp
                    .Execute(challengeCode, _Sdk.Namespace);
                #endregion
                Assert.IsNotNull(challengeData);
                if (challengeData != null)
                {
                    Assert.AreEqual(challengeName, challengeData.Name);
                }

                #region Update a challenge
                var updatedChallenge = _Sdk.Challenge.ChallengeConfiguration.AdminUpdateChallengeOp
                    .Execute(new ModelUpdateChallengeRequest()
                    {
                        Name = $"{challengeName} UPDATED"
                    }, challengeCode, _Sdk.Namespace);
                #endregion
                Assert.IsNotNull(updatedChallenge);
                if (updatedChallenge != null)
                {
                    Assert.AreEqual($"{challengeName} UPDATED", updatedChallenge.Name);
                }

                #region Create a goal
                var newGoal = _Sdk.Challenge.GoalConfiguration.AdminCreateGoalOp
                    .Execute(new ModelCreateGoalRequest()
                    {
                        Code = goalCode,
                        Name = goalName,
                        Description = "",
                        Schedule = new ModelGoalScheduleRequest()
                        {
                            StartTime = DateTime.Now.AddDays(1),
                            Order = 1
                        },
                        RequirementGroups = new List<ModelRequirement>()
                        {
                        new ModelRequirement()
                        {
                            Operator = ModelRequirementOperator.AND,
                            Predicates = new List<ModelPredicate>()
                            {
                                new ModelPredicate()
                                {
                                    ParameterType = ModelPredicateParameterType.USERACCOUNT,
                                    ParameterName = "userAccountVerified",
                                    Matcher = ModelPredicateMatcher.EQUAL,
                                    TargetValue = 1
                                }
                            }
                        }
                        }
                    }, challengeCode, _Sdk.Namespace);
                #endregion
                Assert.IsNotNull(newGoal);

                #region Delete a goal
                _Sdk.Challenge.GoalConfiguration.AdminDeleteGoalOp
                    .Execute(challengeCode, goalCode, _Sdk.Namespace);
                #endregion
            }
            finally
            {
                #region Delete a challenge
                _Sdk.Challenge.ChallengeConfiguration.AdminDeleteChallengeOp
                    .Execute(challengeCode, _Sdk.Namespace);
                #endregion
            }
        }
    }
}
