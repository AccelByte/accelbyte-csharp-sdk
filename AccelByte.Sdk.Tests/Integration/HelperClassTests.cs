// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using NUnit.Framework;

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Tests;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "Integration")]
    [Explicit]
    public class HelperClassTests
    {
        [Test]
        public void RandomPasswordTests()
        {
            Random random = new Random();
            Regex xCheck = new Regex(@"([A-Z]+)([a-z]+)([0-9!@#$%^&*()]+)");
            Regex yCheck = new Regex(@"^(?=.{8,32}$)(([\S])\2?(?!\2))+$");

            for (int i = 0; i < 1000000; i++)
            {
                string gen = Helper.GenerateRandomPassword(random.Next(8, 32));

                string xMessage = "[" + i.ToString() + "] Password: " + gen + " does not match first security requirement.";
                Assert.IsTrue(xCheck.IsMatch(gen), xMessage);

                string yMessage = "[" + i.ToString() + "] Password: " + gen + " does not match second security requirement.";
                Assert.IsTrue(yCheck.IsMatch(gen), yMessage);
            }
        }
    }
}