﻿// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class ChatTests : BaseServiceTests
    {
        public ChatTests() : base(true) { }

        [Test]
        public void ChatProfanityTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string profanityWord = $"xsdk{Helper.GenerateRandomAlphabet(4)}";

            #region Register a new profanity word
            var createResult = _Sdk.Chat.Profanity.AdminProfanityCreateOp
                .Execute(new ModelsDictionaryInsertRequest()
                {
                    Word = profanityWord,
                    WordType = "PROFANITY"
                }, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(createResult);
            if (createResult != null)
                Assert.AreEqual(profanityWord, createResult.Word);

            #region Query profanity word
            var queryResults = _Sdk.Chat.Profanity.AdminProfanityQueryOp
                .SetIncludeChildren(false)
                .SetWordType("PROFANITY")
                .SetStartWith(profanityWord)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(queryResults);
            if (queryResults == null)
                throw new Exception("NULL query result.");

            Assert.IsNotNull(queryResults.Data);
            if (queryResults.Data == null)
                throw new Exception("NULL query result data");

            if (queryResults.Data.Count <= 0)
                Assert.Fail($"Query result does not contain word '{profanityWord}'.");

            ModelsDictionaryWithChildren word = queryResults.Data[0];
            Assert.AreEqual(profanityWord, word.Word);

            string editProfanityWord = $"xsdk{Helper.GenerateRandomAlphabet(4)}";
            #region Update profanity word
            var updateResult = _Sdk.Chat.Profanity.AdminProfanityUpdateOp
                .Execute(new ModelsDictionaryUpdateRequest()
                {
                    WordType = "PROFANITY",
                    Word = editProfanityWord
                }, word.Id!, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(updateResult);

            #region Delete profanity word
            _Sdk.Chat.Profanity.AdminProfanityDeleteOp
                .Execute(word.Id!, _Sdk.Namespace);
            #endregion
        }

        [Test]
        public void ChatInboxCategoryTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string inboxName = $"xsdk_{Helper.GenerateRandomAlphabet(4)}";

            #region Add chat inbox category
            var insertResult = _Sdk.Chat.Inbox.AdminAddInboxCategoryOp
                .Execute(new ModelsAddInboxCategoryRequest()
                {
                    ExpiresIn = 3600000000,
                    Name = inboxName

                }, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(insertResult);
            Assert.AreEqual(inboxName, insertResult!.Name);

            #region Get chat inbox categories
            var getResult = _Sdk.Chat.Inbox.AdminGetInboxCategoriesOp
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(getResult);
            if (getResult != null)
            {
                bool found = false;
                foreach (var item in getResult)
                {
                    if (item.Name == inboxName)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Assert.Fail($"'{inboxName}' not found.");
            }

            #region Update chat inbox category
            _Sdk.Chat.Inbox.AdminUpdateInboxCategoryOp
                .Execute(new ModelsUpdateInboxCategoryRequest()
                {
                    ExpiresIn = 1800000000
                }, inboxName, _Sdk.Namespace);
            #endregion

            #region Delete chat inbox category
            _Sdk.Chat.Inbox.AdminDeleteInboxCategoryOp
                .Execute(inboxName, _Sdk.Namespace);
            #endregion
        }
    }
}
