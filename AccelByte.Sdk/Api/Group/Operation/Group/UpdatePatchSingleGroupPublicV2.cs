// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// updatePatchSingleGroupPublicV2
    ///
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP [UPDATE]"
    /// 
    /// 
    /// 
    /// 
    /// Update existing group. This endpoint supports partial update. This endpoint will check the group ID of the user based on the access token and compare it with the group ID in path parameter.
    /// It will also check the member role of the user based on the access token
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73307
    /// </summary>
    public class UpdatePatchSingleGroupPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePatchSingleGroupPublicV2Builder Builder = new UpdatePatchSingleGroupPublicV2Builder();

        public class UpdatePatchSingleGroupPublicV2Builder
            : OperationBuilder<UpdatePatchSingleGroupPublicV2Builder>
        {





            internal UpdatePatchSingleGroupPublicV2Builder() { }






            public UpdatePatchSingleGroupPublicV2 Build(
                ModelsUpdateGroupRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdatePatchSingleGroupPublicV2 op = new UpdatePatchSingleGroupPublicV2(this,
                    body,                    
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdatePatchSingleGroupPublicV2(UpdatePatchSingleGroupPublicV2Builder builder,
            ModelsUpdateGroupRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePatchSingleGroupPublicV2(
            string groupId,            
            string namespace_,            
            Model.ModelsUpdateGroupRequestV1 body            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}