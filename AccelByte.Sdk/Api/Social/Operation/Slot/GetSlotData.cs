// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getSlotData
    ///
    /// Get slot data.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=2 (READ)
    ///         *  Returns : slot data
    /// </summary>
    public class GetSlotData : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSlotDataBuilder Builder = new GetSlotDataBuilder();

        public class GetSlotDataBuilder
            : OperationBuilder<GetSlotDataBuilder>
        {
            
            
            
            internal GetSlotDataBuilder() { }






            public GetSlotData Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                GetSlotData op = new GetSlotData(this,
                    namespace_,                    
                    slotId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSlotData(GetSlotDataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSlotData(
            string namespace_,            
            string slotId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/octet-stream" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public byte[]? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            else if (code == (HttpStatusCode)200)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}