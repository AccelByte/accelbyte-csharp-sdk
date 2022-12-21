// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicPatchUpdateParty
    ///
    /// Update specified fields from party data. Note: Join type can only be updated by the party's leader.
    /// </summary>
    public class PublicPatchUpdateParty : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPatchUpdatePartyBuilder Builder = new PublicPatchUpdatePartyBuilder();

        public class PublicPatchUpdatePartyBuilder
            : OperationBuilder<PublicPatchUpdatePartyBuilder>
        {





            internal PublicPatchUpdatePartyBuilder() { }






            public PublicPatchUpdateParty Build(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPatchUpdateParty op = new PublicPatchUpdateParty(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPatchUpdateParty(PublicPatchUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
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

        public PublicPatchUpdateParty(
            string namespace_,            
            string partyId,            
            Model.ApimodelsUpdatePartyRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApimodelsPartySessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}