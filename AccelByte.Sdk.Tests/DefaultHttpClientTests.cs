// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using System.IO;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;

namespace AccelByte.Sdk.Tests
{
    [TestFixture(Category = "DefaultHttpClient")]
    public class DefaultHttpClientTests : HttpBinRequestTests
    {
        protected override IHttpClient GetHttpClientObject()
        {
            return AccelByte.Sdk.Core.Client.HttpClient.Default;
        }
    }
}