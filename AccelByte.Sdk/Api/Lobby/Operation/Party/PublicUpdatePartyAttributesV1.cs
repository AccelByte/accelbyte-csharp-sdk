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
    /// publicUpdatePartyAttributesV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// update party attributes in a namespace.
    /// </summary>
    public class PublicUpdatePartyAttributesV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePartyAttributesV1Builder Builder = new PublicUpdatePartyAttributesV1Builder();

        public class PublicUpdatePartyAttributesV1Builder
            : OperationBuilder<PublicUpdatePartyAttributesV1Builder>
        {
            
            
            
            internal PublicUpdatePartyAttributesV1Builder() { }





            public PublicUpdatePartyAttributesV1 Build(
                ModelsPartyPUTCustomAttributesRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdatePartyAttributesV1 op = new PublicUpdatePartyAttributesV1(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUpdatePartyAttributesV1(PublicUpdatePartyAttributesV1Builder builder,
            ModelsPartyPUTCustomAttributesRequest body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdatePartyAttributesV1(
            string namespace_,            
            string partyId,            
            Model.ModelsPartyPUTCustomAttributesRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/attributes";

        public override HttpMethod Method => HttpMethod.Put;

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