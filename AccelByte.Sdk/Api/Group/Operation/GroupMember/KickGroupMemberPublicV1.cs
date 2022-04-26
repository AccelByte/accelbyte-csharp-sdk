// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// kickGroupMemberPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP:KICK [CREATE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to kick group member.
    /// 
    /// 
    /// 
    /// 
    /// Kick group member. This endpoint will check the member and group information, and also the role permission of the the user who accesses this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73409
    /// </summary>
    public class KickGroupMemberPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static KickGroupMemberPublicV1Builder Builder = new KickGroupMemberPublicV1Builder();

        public class KickGroupMemberPublicV1Builder
            : OperationBuilder<KickGroupMemberPublicV1Builder>
        {
            
            
            internal KickGroupMemberPublicV1Builder() { }






            public KickGroupMemberPublicV1 Build(
                string namespace_,
                string userId
            )
            {
                KickGroupMemberPublicV1 op = new KickGroupMemberPublicV1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private KickGroupMemberPublicV1(KickGroupMemberPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public KickGroupMemberPublicV1(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/users/{userId}/kick";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsKickGroupMemberResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsKickGroupMemberResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsKickGroupMemberResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}