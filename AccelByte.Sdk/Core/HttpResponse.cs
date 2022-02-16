// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;

namespace AccelByte.Sdk.Core
{
    public class HttpResponse // TODO Make disposable
    {
        public HttpResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            this.Code = code;
            this.ContentType = contentType;
            this.Payload = payload;
        }

        public HttpStatusCode Code { get; }
        public string ContentType { get; }
        public Stream Payload { get; }
    }
}
