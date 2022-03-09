// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using AccelByte.Sdk.Core.Awesome;
using AccelByte.Sdk.Api.Lobby.WSModel;

namespace AccelByte.Sdk.Tests
{
    public class AwesomeMessageTests
    {

        [Test]
        [TestCase("", TestName = "Case 01")]
        [TestCase("type:unknownResponse\nid:id123\ncode:0", TestName = "Case 02")]
        [TestCase("type : unknownResponse\nid : id123\ncode : 0", TestName = "Case 03")]
        [TestCase("alpha: 42.0\nbeta: false\ngamma: 2013-03-03", TestName = "Case 06")]
        [TestCase("code: 11111\nid: id123\ntype: unknownResponse\nbeta: false\ngamma: 2013-03-03", TestName = "Case 08")]
        [TestCase("type: unknownResponse\nid: id123\ncode: 0\n: false\n: 2013-03-03", TestName = "Case 13")]
        [TestCase("type: unknownResponse\nid: id123\ncode: 0\nbeta: false\nbeta: 2013-03-03", TestName = "Case 17")]
        [TestCase("type: unknownResponse\nid: id123\ncode: 0\nalpha: 11111\nid: false\ntype: 2013-03-03", TestName = "Case 18")]
        public void InvalidFormatTestCases(string rawMessage)
        {
            MessageException? mx = Assert.Throws<MessageException>(() =>
            {
                Message msg = new Message(rawMessage);
            });

            Assert.AreEqual(ErrorCode.MessageFormatInvalid.Code, mx!.Code);
        }

        [Test]
        [TestCase("type: unknownResponse\nid: id123\ncode: Error_in_response\nbeta: false\ngamma: 2013-03-03", TestName = "Case 09")]
        public void FailedFieldConverstionTestCases(string rawMessage)
        {
            MessageException? mx = Assert.Throws<MessageException>(() =>
            {
                Message msg = new Message(rawMessage);
            });

            Assert.AreEqual(ErrorCode.MessageFieldConversionFailed.Code, mx!.Code);
        }

        [Test]
        [TestCase("type: unknownResponse\nid: id123\ncode: 0", TestName = "Case 04")]
        [TestCase("type: unknownResponse\nid: id123\ncode: 0\nbeta: false\ngamma: 2013-03-03", TestName = "Case 05")]
        [TestCase("type: unknownResponse\nbeta: false\ngamma: 2013-03-03", TestName = "Case 07")]
        [TestCase("type: unknownResponse\nid: id123\ncode: 11111\nbeta: false\ngamma: 2013-03-03", TestName = "Case 12")]
        [TestCase("type: unknownResponse\nid: id123\ncode: 0\n+aaa123: false\n 123: false\n(bbb456): 2013-03-03", TestName = "Case 14")]
        [TestCase("type: unknownResponse\nid: id123\nalpha: 11111\nbeta: false\ncode: 2013-03-03", TestName = "Case 15")]
        [TestCase("type: unknown\nid: id123\ncode: 0\nalpha: 11111\nbeta: false\ngamma: 2013-03-03", TestName = "Case 16")]
        [TestCase("type: unknownResponse\nid: 123\nbeta: false\ngamma: 2013-03-03", TestName = "Case 19")]
        [TestCase("type: unknownResponse\nid: 123\ncode: 0\nbeta: false\ngamma: 2013-03-03", TestName = "Case 20")]
        public void ValidFormatTestCases(string rawMessage)
        {
            Message msg = new Message(rawMessage);
        }

        [Test]
        [TestCase("type: partyCreateResponse\nid: 4k3saqd76egh4ind0ssq93hutg09ai52l98i4duwd5qmd3ol1pqveben9il8klnf\ncode: 11232\npartyID: \nleaderID: \nmembers: []\ninvitees: []\ninvitationToken: \npartyCode: ", TestName = "Case 22")]
        public void ValidFormatTryToSerializeTestCases(string rawMessage)
        {
            Message msg = new Message(rawMessage);
            var obj = msg.To<PartyCreateResponse>();
        }

        [Test]
        [TestCase("type: unknownResponse\nid: 123\ncode: 12350\nbeta: false\ngamma: 2013-03-03", 12350, TestName = "Case 21")]
        public void ValidFormatButErrorFromMessageTestCases(string rawMessage, int expectedCode)
        {
            Message msg = new Message(rawMessage);
            Assert.AreEqual(expectedCode, msg.Code);
        }
    }
}