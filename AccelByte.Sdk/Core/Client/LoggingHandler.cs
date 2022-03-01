// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Core.Client
{
    public class LoggingHandler : DelegatingHandler
    {
        public IHttpLogger? Logger { get; set; } = null;

        public LoggingHandler(HttpMessageHandler handler)
            :base(handler)
        {

        }

        protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            long reqTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Logger?.LogRequest(request,reqTimestamp);
            HttpResponseMessage response = base.Send(request, cancellationToken);
            long respTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Logger?.LogResponse(response, respTimestamp, reqTimestamp);
            return response;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            long reqTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Logger?.LogRequest(request, reqTimestamp);
            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
            long respTimestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Logger?.LogResponse(response, respTimestamp, reqTimestamp);
            return response;
        }
    }
}