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
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Repository;
using NUnit.Framework;

namespace AccelByte.Sdk.Tests
{
    public class Tests
    {
        private static readonly IHttpClient _httpClient = new DefaultHttpClient();

        private static readonly ITokenRepository _tokenRepository = new DefaultTokenRepository();

        private static readonly TestConfigRepository _httpbinConfigRepository = new TestConfigRepository(
            "https://httpbin.org",      // Requires internet connection
            "DUMMY_CLIENT_ID",
            "DUMMY_CLIENT_SECRET",
            "CSharpTests");
        private static readonly TestConfigRepository _clientConfigRepository = new TestConfigRepository(
            "http://localhost:8080",    // Requires justice-codegen-sdk-mock-server with iam.json loaded
            "admin",
            "admin",
            "CSharpTests");
        private static readonly TestConfigRepository _userConfigRepository = new TestConfigRepository(
            "http://localhost:8080",    // Requires justice-codegen-sdk-mock-server with iam.json loaded
            "admin",
            "admin",
            "CSharpTests");

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("GET")]
        [TestCase("POST")]
        [TestCase("PUT")]
        [TestCase("PATCH")]
        [TestCase("DELETE")]
        public void HttpbinRequestMethod(string method)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method));

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
        }

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("GET")]
        public void HttpbinNoRequestBodyType(string method)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method), "/anything", null!, null!, null, "", null!);

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string, string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
        }

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("POST", "abc/def:123?x=1&y=2")] // Special characters need to be escaped
        public void HttpbinRequestPathParam(string method, string pathParam)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(
                    new HttpMethod(method),
                    "/anything/{test_path_param}",
                    new Dictionary<string, string>() {
                        {"test_path_param", pathParam}
                    });

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            var basePath = sdk.Configuration.ConfigRepository.BaseUrl;
            var escapedPathParam = HttpUtility.UrlEncode(pathParam);
            var url = op.GetUrl(basePath);
            var isPathParamEscaped = url.Contains(escapedPathParam);

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
            Assert.True(isPathParamEscaped, $"Path param assert failed: {url}");

            var args = result.Args ?? throw new AssertionException("Args is null");

            Assert.False(args.Any(), $"Args assert failed: {args.Count}");
        }

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("GET", "?key=key&", "?value=value&")] // Special characters need to be escaped
        public void HttpbinRequestQueryString(string method, string key, string value)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method),
                    queryParams: new Dictionary<string, dynamic>() { { key, value } });
            op.WrapQueryParamValueWithQuote = true;

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            var args = result.Args ?? throw new AssertionException("Args is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
            Assert.AreEqual(value, args[key], $"Query value assert failed: {value}");
        }

        [Test]
        [TestCase("GET", "csv")]
        [TestCase("GET", "multi")]
        public void HttpbinRequestQueryStringArray(string method, string collectionFormat)
        {
            var key = "?key=key&";  // Special characters need to be escaped
            var value = new List<string> { "?a=a&\"?a=a&", "?b=b&\"?b=b&" };  // Special characters need to be escaped

            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method),
                    queryParams: new Dictionary<string, dynamic>() {
                        { key, value }
                    },
                    collectionFormatMap: new Dictionary<string, string>() {
                        {key, collectionFormat } 
                    });
            op.WrapQueryParamValueWithQuote = true;

            var response = sdk.RunRequest(op);

            if (collectionFormat == Operation.COLLECTION_FORMAT_MULTI)
            {
                var result = op.ParseResponse<Dictionary<string,List<string>>>(response.Code, response.ContentType, response.Payload) ??
                        throw new AssertionException("Result is null");

                var args = result.Args ?? throw new AssertionException("Args is null");

                Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
                Assert.AreEqual(value, args[key], $"Query value assert failed: {args[key]}");
            }
            else if (collectionFormat == Operation.COLLECTION_FORMAT_CSV)
            {
                var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                        throw new AssertionException("Result is null");

                var args = result.Args ?? throw new AssertionException("Args is null");

                var expected = new StringBuilder();
                foreach (var v in value)
                {
                    var escapedValue = v.Replace("\"", "\"\"");
                    expected.Append($"\"{escapedValue}\",");
                }
                expected.Length--;   // Trim end ","

                Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
                Assert.AreEqual(expected.ToString(), args[key], $"Query value assert failed: {args[key]}");
            }
            else {
                throw new NotSupportedException($"Unsupported test collection format (format: {collectionFormat})");
            }
        }

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("POST", "?key=key&", "?value=value&")] // Special characters need to be escaped
        public void HttpbinRequestFormParam(string method, string key, string value)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method), consumes: "application/x-www-form-urlencoded");

            op.FormParams[key] = value;

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            var form = result.Form ?? throw new AssertionException("Form is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
            Assert.AreEqual(form[key], value, $"Form value assert failed: {form[key]}");
        }

        [Test]
        [TestCase("POST")] // Special characters need to be escaped
        public void HttpbinRequestUploadFile(string method)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method), consumes: "multipart/form-data");

            op.FormParams["strategy"] = "replace";
            op.FormParams["file"] = new MemoryStream(Encoding.UTF8.GetBytes("ABC123"));

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            var form = result.Form ?? throw new AssertionException("Form is null");
            var headers = result.Headers ?? throw new AssertionException("Headers is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
            //Removed this assertion since content-type for file upload has 'boundary' property which has dynamic value.
            //Assert.AreEqual(headers["Content-Type"], "multipart/form-data", $"Form value assert failed: {headers["Content-Type"]}");    // XXX Assertion need to be improved
        }


        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("POST")] // Special characters need to be escaped
        public void HttpbinRequestJson(string method)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var request = new TestRequest()
            {
                Name = "test item",
                Weight = 1.2345,
                Quantity = 999,
                Dimensions = new Dictionary<string, double>() { { "x", 6.7890 } }
            };

            var op = new HttpbinOperation(new HttpMethod(method), bodyParams: request);

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");

            var dataString = result.Data ?? throw new AssertionException("Data string is null");
            var data = JsonSerializer.Deserialize<TestRequest>(result.Data) ?? throw new AssertionException("Data is null"); ;

            Assert.AreEqual(request.Name, data.Name);
            Assert.AreEqual(request.Weight, data.Weight);
            Assert.AreEqual(request.Quantity, data.Quantity);
            CollectionAssert.AreEqual(request.Dimensions, data.Dimensions);
        }

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("POST")] // Special characters need to be escaped
        public void HttpbinRequestError(string method)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            var sdk = new AccelByteSDK(config);

            var request = new TestRequest();

            var op = new HttpbinOperation(new HttpMethod(method), path: "/status/500",
                    bodyParams: request);

            var response = sdk.RunRequest(op);

            Assert.Throws<HttpResponseException>(() =>
            {
                op.ParseResponse<Dictionary<string,string>>(response.Code, response.ContentType, response.Payload);
            });
        }

        [Test]
        [Ignore("This test is replaced by HttpBinRequestTests.")]
        [TestCase("123457890")]
        [TestCase("1234 57890")]
        [TestCase("1234,57890")]
        [TestCase("1234;57890")]
        public void HttpBinCookieRequestTest(string cookieValue)
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .SetHttpClient(_httpClient)
                .SetTokenRepository(_tokenRepository)
                .SetConfigRepository(_httpbinConfigRepository)
                .EnableLog()
                .Build();

            var op = new HttpbinCookieOperation();
            op.Cookies["test_token"] = cookieValue;

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse(response.Code, response.ContentType, response.Payload) ??
                throw new AssertionException("Result is null");

            Assert.IsNotNull(result.Cookies);
            Assert.IsTrue(result.Cookies!.ContainsKey("test_token"));
            Assert.AreEqual(cookieValue, HttpUtility.UrlDecode(result.Cookies!["test_token"]));
        }

        [Test]        
        [Ignore("This test already exists in CLI unit test")]
        public void LoginLogoutClient()
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _clientConfigRepository);
            var sdk = new AccelByteSDK(config);

            Assert.True(!string.IsNullOrEmpty(sdk.Configuration.ConfigRepository.BaseUrl));
            Assert.True(!string.IsNullOrEmpty(sdk.Configuration.ConfigRepository.ClientId));
            Assert.True(!string.IsNullOrEmpty(sdk.Configuration.ConfigRepository.ClientSecret));

            Assert.IsTrue(sdk.LoginClient(), $"Login client failed");
            Assert.IsTrue(!string.IsNullOrEmpty(sdk.Configuration.TokenRepository.Token));

            sdk.Logout();
            Assert.IsTrue(string.IsNullOrEmpty(sdk.Configuration.TokenRepository.Token));
        }

        [Test]
        [Ignore("This test already exists in CLI unit test")]
        public void LoginLogoutUser()
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _userConfigRepository);
            var sdk = new AccelByteSDK(config);

            Assert.True(!string.IsNullOrEmpty(sdk.Configuration.ConfigRepository.BaseUrl));
            Assert.True(!string.IsNullOrEmpty(sdk.Configuration.ConfigRepository.ClientId));
            //Assert.True(!string.IsNullOrEmpty(sdk.Configuration.ConfigRepository.ClientSecret)); // Not required for user login

            Assert.IsTrue(sdk.LoginUser("user", "user"), $"Login user failed");
            Assert.IsTrue(!string.IsNullOrEmpty(sdk.Configuration.TokenRepository.Token));

            sdk.Logout();
            Assert.IsTrue(string.IsNullOrEmpty(sdk.Configuration.TokenRepository.Token));
        }

        // TODO Binary request & response
    }
}
