// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Web;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests
{
    [TestFixture]
    public class ModelTests
    {

        [Test]
        public void ModelWithEnumToJSON_Test01()
        {
            ModelWithEnum model = new ModelWithEnum()
            {
                RuleAttribute = "abc",
                RuleCriteria = ModelWithEnumRuleCriteria.EQUAL,
                RuleValue = 20.0
            };

            string expected = "{\"ruleAttribute\":\"abc\",\"ruleCriteria\":\"EQUAL\",\"ruleValue\":20}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnum));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumToJSON_Test02()
        {
            ModelWithEnum model = new ModelWithEnum()
            {
                RuleAttribute = "abc",
                RuleCriteria = StringEnum.Create<ModelWithEnumRuleCriteria>("CUSTOM"),
                RuleValue = 20.0
            };

            string expected = "{\"ruleAttribute\":\"abc\",\"ruleCriteria\":\"CUSTOM\",\"ruleValue\":20}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnum));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumToJSON_Test03()
        {
            ModelWithEnum model = new ModelWithEnum()
            {
                RuleAttribute = "abc",
                RuleCriteria = "CUSTOM",
                RuleValue = 20.0
            };

            string expected = "{\"ruleAttribute\":\"abc\",\"ruleCriteria\":\"CUSTOM\",\"ruleValue\":20}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnum));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumFromJSON_Test01()
        {
            string json = "{\"ruleAttribute\":\"abc\",\"ruleCriteria\":\"EQUAL\",\"ruleValue\":20}";
            ModelWithEnum? model = JsonSerializer.Deserialize<ModelWithEnum>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(ModelWithEnumRuleCriteria.EQUAL, model.RuleCriteria);
            }
        }

        [Test]
        public void ModelWithEnumFromJSON_Test02()
        {
            string json = "{\"ruleAttribute\":\"abc\",\"ruleCriteria\":\"CUSTOM\",\"ruleValue\":20}";
            ModelWithEnum? model = JsonSerializer.Deserialize<ModelWithEnum>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(StringEnum.Create<ModelWithEnumRuleCriteria>("CUSTOM"), model.RuleCriteria);
                Assert.True(model.RuleCriteria! == "CUSTOM");
            }
        }
    }
}