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
    public abstract class HttpBinRequestTests
    {
        protected AccelByteSDK? _Sdk = null;

        protected abstract IHttpClient GetHttpClientObject();

        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .SetHttpClient(GetHttpClientObject())
                .SetConfigRepository(new HttpbinConfigRepository("client"))
                .UseDefaultTokenRepository()
                .EnableLog()
                .Build();
        }

        [Test]
        [TestCase("GET")]
        [TestCase("POST")]
        [TestCase("PUT")]
        [TestCase("PATCH")]
        [TestCase("DELETE")]
        public void RequestMethodTest(string method)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(method);
            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            Assert.AreEqual(method, result!.Method);
        }

        [Test]
        [TestCase("test?qmark")]
        [TestCase("test;qmark")]
        //[TestCase("test/qmark")]
        [TestCase("test qmark")]
        //[TestCase("test ?;=qmark")]
        public void PathParamsTest(string path)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Post)
                .AddPathParam("test_path", path);
            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Args);
                Assert.AreEqual(0, result.Args!.Count);

                string pathCheck = HttpUtility.UrlEncode(path);
                string fullUrl = (_Sdk.Configuration.ConfigRepository.BaseUrl + "/anything/" + pathCheck);
                Assert.AreEqual(fullUrl.ToLower(), result.Url.ToLower());
            }
        }

        [Test]
        [TestCase("1", "2")]
        [TestCase("1 4", "2")]
        [TestCase(" ?1", "2")]
        [TestCase(" ? ", "2")]
        [TestCase("1", " ?34")]
        public void QueryStringTest(string xValue, string yValue)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Post)
                .AddQueryParam("x", xValue)
                .AddQueryParam("y", yValue);
            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Args);
                Assert.GreaterOrEqual(2, result.Args!.Count);
                Assert.AreEqual(result.Args["x"], xValue);
                Assert.AreEqual(result.Args["y"], yValue);
            }
        }

        [Test]
        public void UserAgentTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Get);
            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Headers);
                string userAgent = result.Headers!["User-Agent"].Trim();

                Regex check = new Regex("AccelByteCSharpSDK/([0-9\\.]+) \\(" + _Sdk.Configuration.ConfigRepository.AppName + "\\)");
                Assert.IsTrue(check.IsMatch(userAgent));
            }
        }

        [Test]
        public void AmazonTraceIdTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Get);
            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Headers);
                Regex check = new Regex(_Sdk.Configuration.ConfigRepository.TraceIdVersion + "-([0-9a-f]+)-([0-9a-f]+)");

                string eTraceId = op.HeaderParams["X-Amzn-Trace-Id"].Trim();
                string sTraceId = result.Headers!["X-Amzn-Trace-Id"].Trim();

                bool found = false;
                foreach (Match m in check.Matches(sTraceId))
                {
                    if (m.Value.Trim() == eTraceId)
                    {
                        found = true;
                        break;
                    }
                }

                Assert.IsTrue(found);
            }
        }

        [Test]
        [TestCase("123457890")]
        [TestCase("1234 57890")]
        [TestCase("1234,57890")]
        [TestCase("1234;57890")]
        public void CookieTests(string cookieValue)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var op = new HttpbinCookieOperation();
            op.Cookies["test_token"] = cookieValue;

            var response = _Sdk.RunRequest(op);

            var result = op.ParseResponse(response.Code, response.ContentType, response.Payload) ??
                throw new AssertionException("Result is null");

            Assert.IsNotNull(result.Cookies);
            Assert.IsTrue(result.Cookies!.ContainsKey("test_token"));
            Assert.AreEqual(cookieValue, HttpUtility.UrlDecode(result.Cookies!["test_token"]));
        }

        [Test]
        [TestCase("normal_key", "normal_value")]
        [TestCase("?key=key&", "?value=value&")]
        public void FormDataTests(string key, string value)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Post)
                .SetConsume("application/x-www-form-urlencoded")
                .AddFormParam(key, value);

            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Form);
                Assert.AreEqual(value, result.Form![key]);
            }
        }

        [Test]
        [TestCase(200)]
        [TestCase(201)]
        [TestCase(204)]
        public void RequestAndResponseBodyTest(int statusCode)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            TestRequest request = new TestRequest()
            {
                Name = "test item",
                Weight = 1.2345,
                Quantity = 999,
                Dimensions = new Dictionary<string, double>() { { "x", 6.7890 } }
            };

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder
                .SetBodyParam(request)
                .Create(HttpMethod.Post);

            HttpResponse response = _Sdk.RunRequest(op);
            int monkeyPatchStatusCode = statusCode; //Monkey patching since current Httpbin server does not provide endpoint with specified status code and response object altogether.
            var result = op.ParseResponse<Dictionary<string, string>, TestRequest>(
                (HttpStatusCode)monkeyPatchStatusCode,
                response.ContentType,
                response.Payload);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Data);
                Assert.That(request,
                    Has.Property("Name").EqualTo(result.Data!.Name) &
                    Has.Property("Weight").EqualTo(result.Data!.Weight) &
                    Has.Property("Quantity").EqualTo(result.Data!.Quantity));
                CollectionAssert.AreEqual(request.Dimensions, result.Data!.Dimensions);
            }
        }

        [Test]
        public void MultipartFormDataTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Post)
                .SetConsume("multipart/form-data")
                .AddFormParam("strategy", "replace")
                .AddFormParam("file", new MemoryStream(Encoding.UTF8.GetBytes("ABC123")));

            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Form);
                Assert.IsNotNull(result.Files);

                Assert.AreEqual("replace", result.Form!["strategy"]);
                Assert.AreEqual("ABC123", result.Files!["file"]);
            }
        }

        [Test]
        public void EmptyResponseBodyTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder.Create(HttpMethod.Post)
                .SetConsume("");

            var result = op.Execute(_Sdk);
            Assert.IsNotNull(result);
        }

        [Test]
        public void BinaryResponseBodyTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var op = new HttpbinBytesOperation();
            var response = _Sdk.RunRequest(op);

            var result = op.ParseResponse(response.Code, response.ContentType, response.Payload) ??
                throw new AssertionException("Result is null");

            System.Security.Cryptography.HashAlgorithm md5 = System.Security.Cryptography.MD5.Create();
            string actual = Convert.ToHexString(md5.ComputeHash(result));

            Assert.AreEqual("A27095E7727C70909C910CEFE16D30DE", actual);
        }

        [Test]
        public void LocationHeaderTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string targetLocation = "https://httpbin.org/get";

            var op = new HttpbinRedirectOperation(targetLocation, 200);
            var response = _Sdk.RunRequest(op);
            string newLocation = op.ParseResponse(response.Code, response.ContentType, response.Payload);

            Assert.AreEqual((HttpStatusCode)302, response.Code);
            Assert.AreEqual(targetLocation, newLocation);
        }

        [Test]
        [TestCase(403)]
        [TestCase(404)]
        [TestCase(503)]
        public void ErrorResponseBodyTest(int statusCode)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var op = new HttpbinCodeOperation(statusCode);
            var response = _Sdk.RunRequest(op);
            int actCode = op.ParseResponse(response.Code, response.ContentType, response.Payload);
            Assert.AreEqual(statusCode, actCode);
        }

        [Test]
        [TestCase(403)]
        [TestCase(404)]
        [TestCase(503)]
        public void ErrorResponseBodyHtmlTest(int statusCode)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var op = new HttpbinHtmlOperation();
            HttpResponseException? x = Assert.Catch<HttpResponseException>(() =>
            {
                var response = _Sdk.RunRequest(op);
                int monkeyPatchStatusCode = statusCode; //Monkey patching since current Httpbin server does not provide endpoint with specified status code and html response altogether.
                string? result = op.ParseResponse(
                    (HttpStatusCode)monkeyPatchStatusCode,
                    response.ContentType,
                    response.Payload);
            });

            Assert.IsNotNull(x);
            Assert.AreEqual((HttpStatusCode)statusCode, x!.StatusCode);
        }

        [Test]
        [TestCase(401)]
        [TestCase(500)]
        public void UndocumentedResponseBodyTest(int statusCode)
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var op = new HttpbinCodeOperation(statusCode);
            HttpResponseException? x = Assert.Catch<HttpResponseException>(() =>
            {
                var response = _Sdk.RunRequest(op);
                op.ParseResponse(response.Code, response.ContentType, response.Payload);
            });

            Assert.IsNotNull(x);
            Assert.AreEqual((HttpStatusCode)statusCode, x!.StatusCode);
        }

        [Test]
        public void DefaultFlightIdRequestTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder
                .Create(HttpMethod.Get);
            var result = op.Execute(_Sdk);

            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Headers);
                if (result.Headers != null)
                {
                    string hFlightId = "";
                    if (result.Headers.ContainsKey("X-Flight-Id"))
                        hFlightId = result.Headers["X-Flight-Id"].Trim();
                    else if (result.Headers.ContainsKey("x-flight-id"))
                        hFlightId = result.Headers["x-flight-id"].Trim();
                    else
                        Assert.Fail("No x-flight-id in response data.");

                    string expectedFlightId = AccelByteConfig.DefaultFlightId;
                    Assert.AreEqual(expectedFlightId, hFlightId);
                }
            }
        }

        [Test]
        public void SdkObjectFlightIdRequestTest()
        {
            string newFlightId = Guid.NewGuid().ToString();

            var sdk = AccelByteSDK.Builder
                .SetHttpClient(GetHttpClientObject())
                .SetConfigRepository(new HttpbinConfigRepository("client"))
                .UseDefaultTokenRepository()
                .EnableLog()
                .Build();
            sdk.UpdateFlightId(newFlightId);

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder
                .Create(HttpMethod.Get);
            var result = op.Execute(sdk);

            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Headers);
                if (result.Headers != null)
                {
                    string hFlightId = "";
                    if (result.Headers.ContainsKey("X-Flight-Id"))
                        hFlightId = result.Headers["X-Flight-Id"].Trim();
                    else if (result.Headers.ContainsKey("x-flight-id"))
                        hFlightId = result.Headers["x-flight-id"].Trim();
                    else
                        Assert.Fail("No x-flight-id in response data.");

                    Assert.AreEqual(newFlightId, hFlightId);
                }
            }
        }

        [Test]
        public void SdkBuildFlightIdRequestTest()
        {
            string newFlightId = Guid.NewGuid().ToString();

            var sdk = AccelByteSDK.Builder
                .SetHttpClient(GetHttpClientObject())
                .SetConfigRepository(new HttpbinConfigRepository("client"))
                .UseDefaultTokenRepository()
                .SetFlightId(newFlightId)
                .EnableLog()
                .Build();

            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder
                .Create(HttpMethod.Get);
            var result = op.Execute(sdk);

            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Headers);
                if (result.Headers != null)
                {
                    string hFlightId = "";
                    if (result.Headers.ContainsKey("X-Flight-Id"))
                        hFlightId = result.Headers["X-Flight-Id"].Trim();
                    else if (result.Headers.ContainsKey("x-flight-id"))
                        hFlightId = result.Headers["x-flight-id"].Trim();
                    else
                        Assert.Fail("No x-flight-id in response data.");

                    Assert.AreEqual(newFlightId, hFlightId);
                }
            }
        }

        [Test]
        public void OperationObjectFlightIdRequestTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string newFlightId = Guid.NewGuid().ToString();
            HttpbinAnythingOperation op = HttpbinAnythingOperation.Builder
                .UpdateFlightId(newFlightId)
                .Create(HttpMethod.Get);
            var result = op.Execute(_Sdk);

            Assert.IsNotNull(result);
            if (result != null)
            {
                Assert.IsNotNull(result.Headers);
                if (result.Headers != null)
                {
                    string hFlightId = "";
                    if (result.Headers.ContainsKey("X-Flight-Id"))
                        hFlightId = result.Headers["X-Flight-Id"].Trim();
                    else if (result.Headers.ContainsKey("x-flight-id"))
                        hFlightId = result.Headers["x-flight-id"].Trim();
                    else
                        Assert.Fail("No x-flight-id in response data.");

                    Assert.AreEqual(newFlightId, hFlightId);
                }
            }

        }
    }
}