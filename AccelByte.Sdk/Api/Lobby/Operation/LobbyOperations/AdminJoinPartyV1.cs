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
    /// adminJoinPartyV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PARTY:STORAGE [UPDATE]` with scope `social`
    /// 
    /// admin join a player into a party.
    /// </summary>
    public class AdminJoinPartyV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminJoinPartyV1Builder Builder = new AdminJoinPartyV1Builder();

        public class AdminJoinPartyV1Builder
            : OperationBuilder<AdminJoinPartyV1Builder>
        {
            
            
            
            internal AdminJoinPartyV1Builder() { }





            public AdminJoinPartyV1 Build(
                string namespace_,
                string partyId,
                string userId
            )
            {
                AdminJoinPartyV1 op = new AdminJoinPartyV1(this,
                    namespace_,                    
                    partyId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminJoinPartyV1(AdminJoinPartyV1Builder builder,
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

        public AdminJoinPartyV1(
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

        public override string Path => "/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/join/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}