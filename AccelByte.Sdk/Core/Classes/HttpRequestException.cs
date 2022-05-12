// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;

using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Core
{
    public class HttpRequestException : Exception
    {
        public Stream Payload { get; init; }

        public string ResponseContentType { get; init; } = String.Empty;

        public HttpRequestException(HttpStatusCode statusCode, string respContentType, Stream payload) : base()
        {
            StatusCode = statusCode;
            Payload = payload;
            ResponseContentType = respContentType;
        }

        public HttpStatusCode StatusCode { get; }

        public string PayloadMessage
        {
            get { return Helper.ConvertInputStreamToString(Payload); }
        }

        public HttpResponse AsHttpResponse
        {
            get { return new HttpResponse(StatusCode, ResponseContentType, Payload); }
        }
    }
}