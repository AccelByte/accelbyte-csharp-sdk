// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Tests.MockServer
{
    public class MockTestLogger : IHttpLogger
    {
        public List<int> ResponseCodes { get; set; } = new List<int>();

        public int RequestCount { get; set; } = 0;

        public ILogOutputWriter? OutputWriter { get; set; } = null;

        public MockTestLogger()
        {
            string filePath = "http_log.txt";
            OutputWriter = new DefaultOutputWriter(filePath);
        }

        public void LogRequest(HttpRequestMessage request, long timestamp)
        {
            if (OutputWriter == null)
                return;

            Dictionary<string, object> logs = new Dictionary<string, object>();
            logs.Add("url", request.RequestUri!.ToString());
            logs.Add("method", request.Method.ToString());

            Dictionary<string, object> headers = new Dictionary<string, object>();
            foreach (var header in request.Headers)
                headers.Add(header.Key, String.Join(",", header.Value));

            if (headers.ContainsKey("X-Amzn-Trace-Id"))
                logs.Add("trace_id", headers["X-Amzn-Trace-Id"].ToString()!);
            logs.Add("headers", headers);

            if (request.Content is FormUrlEncodedContent)
            {
                string bodyContent = request.Content.ReadAsStringAsync().Result;
                logs.Add("body", bodyContent);
            }
            else if (request.Content is MultipartFormDataContent)
            {
                byte[] body = request.Content.ReadAsByteArrayAsync().Result;
                logs.Add("body", body);
            }
            else if (request.Content is StringContent)
            {
                string bodyContent = request.Content.ReadAsStringAsync().Result;
                logs.Add("body", bodyContent);
            }

            logs.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
            OutputWriter.Write("request", logs);

            RequestCount++;
        }

        public void LogResponse(HttpResponseMessage response, long timestamp, long reqTimestamp)
        {
            if (OutputWriter == null)
                return;

            Dictionary<string, object> logs = new Dictionary<string, object>();
            logs.Add("url", response.RequestMessage!.RequestUri!.ToString());
            logs.Add("status_code", ((int)response.StatusCode).ToString() + " (" + response.StatusCode.ToString() + ")");
            ResponseCodes.Add((int)response.StatusCode);

            double dElapsed = ((double)(timestamp - reqTimestamp) / 1000.0);
            logs.Add("elapsed", dElapsed.ToString(System.Globalization.CultureInfo.InvariantCulture));

            if (response.RequestMessage.Headers.Contains("X-Amzn-Trace-Id"))
            {
                string traceId = String.Join(",", response.RequestMessage.Headers.GetValues("X-Amzn-Trace-Id"));
                logs.Add("trace_id", traceId);
            }

            Dictionary<string, object> headers = new Dictionary<string, object>();
            foreach (var header in response.Headers)
                headers.Add(header.Key, String.Join(",", header.Value));

            if (response.Content != null)
            {
                var respHeaders = response.Content.Headers;
                foreach (var header in respHeaders)
                    headers.Add(header.Key, String.Join(",", header.Value));
                logs.Add("headers", headers);

                string contentType = String.Empty;
                IEnumerable<string>? ctValues = null;
                if (respHeaders.TryGetValues("Content-Type", out ctValues))
                    contentType = String.Join(",", ctValues).Trim();

                if (contentType != String.Empty)
                {
                    string[] ctSplits = contentType.Split(';');
                    if (ctSplits.Length > 0)
                        contentType = ctSplits[0].Trim();
                }

                if ((contentType == "application/json") || (contentType == "text/json")
                        || (contentType == "text/plain"))
                {
                    string body = response.Content.ReadAsStringAsync().Result;
                    logs.Add("body", body);
                }
                else if (contentType == String.Empty)
                {
                    logs.Add("body", "");
                }
                else
                {
                    byte[] body = response.Content.ReadAsByteArrayAsync().Result;
                    logs.Add("body", body);
                }
            }
            else
                logs.Add("headers", headers);

            logs.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
            OutputWriter.Write("response", logs);
        }
    }
}