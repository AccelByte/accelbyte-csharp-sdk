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
    /// getUserGroupInformationPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get user group information.
    /// 
    /// 
    /// 
    /// 
    /// Get user group information. If user is not belong to any group, it will return warning to give information about it
    /// 
    /// 
    /// 
    /// 
    /// Group Member Status:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * JOIN : status of user requested to join group
    /// 
    /// 
    ///   * INVITE: status of user invited to a group
    /// 
    /// 
    ///   * JOINED: status of user already joined to a group
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73405
    /// </summary>
    public class GetUserGroupInformationPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserGroupInformationPublicV1Builder Builder = new GetUserGroupInformationPublicV1Builder();

        public class GetUserGroupInformationPublicV1Builder
        {
            
            
            internal GetUserGroupInformationPublicV1Builder() { }





            public GetUserGroupInformationPublicV1 Build(
                string namespace_,
                string userId
            )
            {
                return new GetUserGroupInformationPublicV1(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetUserGroupInformationPublicV1(GetUserGroupInformationPublicV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public GetUserGroupInformationPublicV1(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetUserGroupInformationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserGroupInformationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}