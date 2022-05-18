// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

using System.Text;
using System.Text.Json;

using NUnit.Framework;

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

            string expected = "{\"RuleAttribute\":\"abc\",\"RuleCriteria\":\"EQUAL\",\"RuleValue\":20}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnum));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumToJSON_Test02()
        {
            ModelWithEnum model = new ModelWithEnum()
            {
                RuleAttribute = "abc",
                RuleCriteria = ModelWithEnumRuleCriteria.NewValue("CUSTOM"),
                RuleValue = 20.0
            };

            string expected = "{\"RuleAttribute\":\"abc\",\"RuleCriteria\":\"CUSTOM\",\"RuleValue\":20}";
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

            string expected = "{\"RuleAttribute\":\"abc\",\"RuleCriteria\":\"CUSTOM\",\"RuleValue\":20}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnum));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumFromJSON_Test01()
        {
            string json = "{\"RuleAttribute\":\"abc\",\"RuleCriteria\":\"EQUAL\",\"RuleValue\":20}";
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
            string json = "{\"RuleAttribute\":\"abc\",\"RuleCriteria\":\"CUSTOM\",\"RuleValue\":20}";
            ModelWithEnum? model = JsonSerializer.Deserialize<ModelWithEnum>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(ModelWithEnumRuleCriteria.NewValue("CUSTOM"), model.RuleCriteria);
                Assert.True(model.RuleCriteria! == "CUSTOM");
            }
        }

        [Test]
        public void ModelWithEnumListToJSON_Test01()
        {
            ModelWithEnumList model = new ModelWithEnumList()
            {
                Aggregate = ModelWithEnumListAggregate.ADYEN,
                Namespace = "test",
                Region = "id",
                Specials = new List<ModelWithEnumListSpecials>()
            };

            string expected = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":[]}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnumList));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumListToJSON_Test02()
        {
            ModelWithEnumList model = new ModelWithEnumList()
            {
                Aggregate = ModelWithEnumListAggregate.ADYEN,
                Namespace = "test",
                Region = "id",
                Specials = new List<ModelWithEnumListSpecials>()
                {
                    ModelWithEnumListSpecials.ADYEN,
                    ModelWithEnumListSpecials.ALIPAY
                }
            };

            string expected = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":[\"ADYEN\",\"ALIPAY\"]}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnumList));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumListToJSON_Test03()
        {
            ModelWithEnumList model = new ModelWithEnumList()
            {
                Aggregate = ModelWithEnumListAggregate.ADYEN,
                Namespace = "test",
                Region = "id",
                Specials = ModelWithEnumListSpecials.ADYEN | ModelWithEnumListSpecials.ALIPAY
            };

            string expected = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":[\"ADYEN\",\"ALIPAY\"]}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnumList));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumListToJSON_Test04()
        {
            ModelWithEnumList model = new ModelWithEnumList()
            {
                Aggregate = ModelWithEnumListAggregate.ADYEN,
                Namespace = "test",
                Region = "id",
                Specials = ModelWithEnumListSpecials.ADYEN
                    | ModelWithEnumListSpecials.ALIPAY
                    | ModelWithEnumListSpecials.STRIPE
            };

            string expected = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":[\"ADYEN\",\"ALIPAY\",\"STRIPE\"]}";
            string actual = JsonSerializer.Serialize(model, typeof(ModelWithEnumList));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ModelWithEnumListFromJSON_Test01()
        {
            string json = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":[\"ADYEN\",\"ALIPAY\"]}";
            ModelWithEnumList? model = JsonSerializer.Deserialize<ModelWithEnumList>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(ModelWithEnumListAggregate.ADYEN, model.Aggregate);
                Assert.AreEqual(2, model.Specials!.Count);
                Assert.AreEqual(ModelWithEnumListSpecials.ADYEN, model.Specials![0]);
            }
        }

        [Test]
        public void ModelWithEnumListFromJSON_Test02()
        {
            string json = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":[]}";
            ModelWithEnumList? model = JsonSerializer.Deserialize<ModelWithEnumList>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(ModelWithEnumListAggregate.ADYEN, model.Aggregate);
                Assert.AreEqual(0, model.Specials!.Count);
            }
        }

        [Test]
        public void ModelWithEnumListFromJSON_Test03()
        {
            string json = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\",\"Specials\":null}";
            ModelWithEnumList? model = JsonSerializer.Deserialize<ModelWithEnumList>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(ModelWithEnumListAggregate.ADYEN, model.Aggregate);
                Assert.IsNull(model.Specials);
            }
        }

        [Test]
        public void ModelWithEnumListFromJSON_Test04()
        {
            string json = "{\"Aggregate\":\"ADYEN\",\"Namespace\":\"test\",\"Region\":\"id\"}";
            ModelWithEnumList? model = JsonSerializer.Deserialize<ModelWithEnumList>(json);
            Assert.IsNotNull(model);
            if (model != null)
            {
                Assert.AreEqual(ModelWithEnumListAggregate.ADYEN, model.Aggregate);
                Assert.IsNull(model.Specials);
            }
        }
    }
}