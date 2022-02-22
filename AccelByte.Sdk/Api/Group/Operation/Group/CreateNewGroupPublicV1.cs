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
    /// createNewGroupPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to create new group
    /// 
    /// 
    /// 
    /// 
    /// There are some fields that needs to be fulfilled
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * groupDescription : the description of the group (optional)
    /// 
    /// 
    ///   * groupIcon : group icon URL link (optional)
    /// 
    /// 
    ///   * groupName : name of the group
    /// 
    /// 
    ///   * groupRegion : region of the group
    /// 
    /// 
    ///   * groupRules : rules for specific group. It consists of groupCustomRule that can be used to save custom rule, and groupPredefinedRules that has similar usage with configuration, but this rule only works in specific group
    /// 
    /// 
    ///   * allowedAction : available action in group service. It consist of joinGroup and inviteGroup
    /// 
    /// 
    ///   * ruleAttribute : attribute of the player that needs to be checked
    /// 
    /// 
    ///   * ruleCriteria : criteria of the value. The value will be in enum of EQUAL, MINIMUM, MAXIMUM
    /// 
    /// 
    ///   * ruleValue : value that needs to be checked
    /// 
    /// 
    ///   * customAttributes : additional custom group attributes (optional)
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73304
    /// </summary>
    public class CreateNewGroupPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNewGroupPublicV1Builder Builder = new CreateNewGroupPublicV1Builder();

        public class CreateNewGroupPublicV1Builder
        {
            
            
            internal CreateNewGroupPublicV1Builder() { }





            public CreateNewGroupPublicV1 Build(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                return new CreateNewGroupPublicV1(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private CreateNewGroupPublicV1(CreateNewGroupPublicV1Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public CreateNewGroupPublicV1(
            string namespace_,            
            Model.ModelsPublicCreateNewGroupRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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