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
    /// publicPartyKick
    ///
    /// Kick a player from a party. Requires invoker to be the party leader.
    /// </summary>
    public class PublicPartyKick : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPartyKickBuilder Builder { get => new PublicPartyKickBuilder(); }

        public class PublicPartyKickBuilder
            : OperationBuilder<PublicPartyKickBuilder>
        {





            internal PublicPartyKickBuilder() { }






            public PublicPartyKick Build(
                string namespace_,
                string partyId,
                string userId
            )
            {
                PublicPartyKick op = new PublicPartyKick(this,
                    namespace_,                    
                    partyId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPartyKick(PublicPartyKickBuilder builder,
            string namespace_,
            string partyId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPartyKick(
            string namespace_,            
            string partyId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/{userId}/kick";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApimodelsKickResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsKickResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsKickResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}