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
    /// adminUpdatePartyAttributesV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PARTY:STORAGE [UPDATE]` with scope `social`
    /// 
    /// update party attributes in a namespace.
    /// </summary>
    public class AdminUpdatePartyAttributesV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdatePartyAttributesV1Builder Builder = new AdminUpdatePartyAttributesV1Builder();

        public class AdminUpdatePartyAttributesV1Builder
        {
            
            
            
            internal AdminUpdatePartyAttributesV1Builder() { }





            public AdminUpdatePartyAttributesV1 Build(
                ModelsPartyPUTCustomAttributesRequest body,
                string namespace_,
                string partyId
            )
            {
                return new AdminUpdatePartyAttributesV1(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );
            }
        }

        private AdminUpdatePartyAttributesV1(AdminUpdatePartyAttributesV1Builder builder,
            ModelsPartyPUTCustomAttributesRequest body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdatePartyAttributesV1(
            string namespace_,            
            string partyId,            
            Model.ModelsPartyPUTCustomAttributesRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/attributes";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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