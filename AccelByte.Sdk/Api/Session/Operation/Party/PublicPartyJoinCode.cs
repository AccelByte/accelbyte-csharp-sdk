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
    /// publicPartyJoinCode
    ///
    /// Join a party by code. The user can join a party as long as the code is valid
    /// </summary>
    public class PublicPartyJoinCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPartyJoinCodeBuilder Builder = new PublicPartyJoinCodeBuilder();

        public class PublicPartyJoinCodeBuilder
            : OperationBuilder<PublicPartyJoinCodeBuilder>
        {





            internal PublicPartyJoinCodeBuilder() { }






            public PublicPartyJoinCode Build(
                ApimodelsJoinByCodeRequest body,
                string namespace_
            )
            {
                PublicPartyJoinCode op = new PublicPartyJoinCode(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPartyJoinCode(PublicPartyJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPartyJoinCode(
            string namespace_,            
            Model.ApimodelsJoinByCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/users/me/join/code";

        public override HttpMethod Method => HttpMethod.Post;

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