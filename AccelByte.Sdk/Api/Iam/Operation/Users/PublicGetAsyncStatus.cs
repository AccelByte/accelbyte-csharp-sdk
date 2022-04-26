// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetAsyncStatus
    ///
    /// This endpoint is used to get linking status.
    /// </summary>
    public class PublicGetAsyncStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetAsyncStatusBuilder Builder = new PublicGetAsyncStatusBuilder();

        public class PublicGetAsyncStatusBuilder
            : OperationBuilder<PublicGetAsyncStatusBuilder>
        {
            
            
            internal PublicGetAsyncStatusBuilder() { }






            public PublicGetAsyncStatus Build(
                string namespace_,
                string requestId
            )
            {
                PublicGetAsyncStatus op = new PublicGetAsyncStatus(this,
                    namespace_,                    
                    requestId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetAsyncStatus(PublicGetAsyncStatusBuilder builder,
            string namespace_,
            string requestId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestId"] = requestId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetAsyncStatus(
            string namespace_,            
            string requestId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestId"] = requestId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/requests/{requestId}/async/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelLinkRequest? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}