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
    /// updateGroupPredefinedRulePublicV1
    ///
    /// 
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
    /// Update predefined group rule. This endpoint will check the group ID of the user based on the access token
    /// and compare it with the group ID in path parameter. It will also check the member role of the user based on
    /// the access token
    /// 
    /// 
    /// 
    /// 
    /// If the rule action is not defined in the group, it will be added immediately to the predefined group rule
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73310
    /// </summary>
    public class UpdateGroupPredefinedRulePublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupPredefinedRulePublicV1Builder Builder = new UpdateGroupPredefinedRulePublicV1Builder();

        public class UpdateGroupPredefinedRulePublicV1Builder
            : OperationBuilder<UpdateGroupPredefinedRulePublicV1Builder>
        {
            
            
            
            
            internal UpdateGroupPredefinedRulePublicV1Builder() { }





            public UpdateGroupPredefinedRulePublicV1 Build(
                ModelsUpdateGroupPredefinedRuleRequestV1 body,
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupPredefinedRulePublicV1 op = new UpdateGroupPredefinedRulePublicV1(this,
                    body,                    
                    allowedAction,                    
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateGroupPredefinedRulePublicV1(UpdateGroupPredefinedRulePublicV1Builder builder,
            ModelsUpdateGroupPredefinedRuleRequestV1 body,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateGroupPredefinedRulePublicV1(
            string allowedAction,            
            string groupId,            
            string namespace_,            
            Model.ModelsUpdateGroupPredefinedRuleRequestV1 body            
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Put;

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