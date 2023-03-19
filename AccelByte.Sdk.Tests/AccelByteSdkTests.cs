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
        [TestCase("GET", "csv")]
        [TestCase("GET", "multi")]
        public void HttpbinRequestQueryStringArray(string method, string collectionFormat)
        {
            var key = "?key=key&";  // Special characters need to be escaped
            var value = new List<string> { "?a=a&\"?a=a&", "?b=b&\"?b=b&" };  // Special characters need to be escaped

            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            using var sdk = new AccelByteSDK(config);

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
                var result = op.ParseResponse<Dictionary<string, List<string>>>(response.Code, response.ContentType, response.Payload) ??
                        throw new AssertionException("Result is null");

                var args = result.Args ?? throw new AssertionException("Args is null");

                Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");
                Assert.AreEqual(value, args[key], $"Query value assert failed: {args[key]}");
            }
            else if (collectionFormat == Operation.COLLECTION_FORMAT_CSV)
            {
                var result = op.ParseResponse<Dictionary<string, string>>(response.Code, response.ContentType, response.Payload) ??
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
            else
            {
                throw new NotSupportedException($"Unsupported test collection format (format: {collectionFormat})");
            }
        }

        [Test]
        [TestCase("POST")] // Special characters need to be escaped
        public void HttpbinRequestUploadFile(string method)
        {
            var config = new AccelByteConfig(_httpClient, _tokenRepository, _httpbinConfigRepository);
            using var sdk = new AccelByteSDK(config);

            var op = new HttpbinOperation(new HttpMethod(method), consumes: "multipart/form-data");

            op.FormParams["strategy"] = "replace";
            op.FormParams["file"] = new MemoryStream(Encoding.UTF8.GetBytes("ABC123"));

            var response = sdk.RunRequest(op);

            var result = op.ParseResponse<Dictionary<string, string>>(response.Code, response.ContentType, response.Payload) ??
                    throw new AssertionException("Result is null");

            var form = result.Form ?? throw new AssertionException("Form is null");
            var headers = result.Headers ?? throw new AssertionException("Headers is null");

            Assert.AreEqual(method, result.Method, $"Method assert failed: {result.Method}");

            //Removed this assertion since content-type for file upload has 'boundary' property which has dynamic value.
            //Assert.AreEqual(headers["Content-Type"], "multipart/form-data", $"Form value assert failed: {headers["Content-Type"]}");    // XXX Assertion need to be improved
        }
    }
}
