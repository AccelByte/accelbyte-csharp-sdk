// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// LastUserActivityTimeHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class LastUserActivityTimeHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LastUserActivityTimeHandlerBuilder Builder = new LastUserActivityTimeHandlerBuilder();

        public class LastUserActivityTimeHandlerBuilder
            : OperationBuilder<LastUserActivityTimeHandlerBuilder>
        {
            
            
            internal LastUserActivityTimeHandlerBuilder() { }





            public LastUserActivityTimeHandler Build(
                string namespace_,
                string userId
            )
            {
                LastUserActivityTimeHandler op = new LastUserActivityTimeHandler(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private LastUserActivityTimeHandler(LastUserActivityTimeHandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LastUserActivityTimeHandler(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}/lastActivityTime";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsUserLastActivity? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserLastActivity>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserLastActivity>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}