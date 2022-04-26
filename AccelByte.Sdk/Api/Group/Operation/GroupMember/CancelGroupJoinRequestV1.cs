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
    /// CancelGroupJoinRequestV1
    ///
    /// 
    /// 
    /// Requires valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint allows user to cancel request to join specific group.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73411
    /// </summary>
    public class CancelGroupJoinRequestV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CancelGroupJoinRequestV1Builder Builder = new CancelGroupJoinRequestV1Builder();

        public class CancelGroupJoinRequestV1Builder
            : OperationBuilder<CancelGroupJoinRequestV1Builder>
        {
            
            
            internal CancelGroupJoinRequestV1Builder() { }






            public CancelGroupJoinRequestV1 Build(
                string groupId,
                string namespace_
            )
            {
                CancelGroupJoinRequestV1 op = new CancelGroupJoinRequestV1(this,
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CancelGroupJoinRequestV1(CancelGroupJoinRequestV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CancelGroupJoinRequestV1(
            string groupId,            
            string namespace_            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/join/cancel";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsMemberRequestGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}