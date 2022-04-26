// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// publicGetPartyDataV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// load personal party data in a namespace based on Party ID
    /// 
    /// Action Code: 50101
    /// </summary>
    public class PublicGetPartyDataV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPartyDataV1Builder Builder = new PublicGetPartyDataV1Builder();

        public class PublicGetPartyDataV1Builder
            : OperationBuilder<PublicGetPartyDataV1Builder>
        {
            
            
            internal PublicGetPartyDataV1Builder() { }






            public PublicGetPartyDataV1 Build(
                string namespace_,
                string partyId
            )
            {
                PublicGetPartyDataV1 op = new PublicGetPartyDataV1(this,
                    namespace_,                    
                    partyId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetPartyDataV1(PublicGetPartyDataV1Builder builder,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPartyDataV1(
            string namespace_,            
            string partyId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPartyData? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPartyData>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPartyData>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}