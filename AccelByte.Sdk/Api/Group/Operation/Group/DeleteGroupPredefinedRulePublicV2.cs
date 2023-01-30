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
    /// deleteGroupPredefinedRulePublicV2
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
    /// Delete group predefined rule based on the allowed action. This endpoint will check the group ID of the user based on the access token
    /// and compare it with the group ID in path parameter. It will also check the member role of the user based on
    /// the access token
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73309
    /// </summary>
    public class DeleteGroupPredefinedRulePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteGroupPredefinedRulePublicV2Builder Builder = new DeleteGroupPredefinedRulePublicV2Builder();

        public class DeleteGroupPredefinedRulePublicV2Builder
            : OperationBuilder<DeleteGroupPredefinedRulePublicV2Builder>
        {





            internal DeleteGroupPredefinedRulePublicV2Builder() { }






            public DeleteGroupPredefinedRulePublicV2 Build(
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                DeleteGroupPredefinedRulePublicV2 op = new DeleteGroupPredefinedRulePublicV2(this,
                    allowedAction,                    
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteGroupPredefinedRulePublicV2(DeleteGroupPredefinedRulePublicV2Builder builder,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteGroupPredefinedRulePublicV2(
            string allowedAction,            
            string groupId,            
            string namespace_            
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}