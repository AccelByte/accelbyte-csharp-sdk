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
    /// getSingleMemberRoleAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [READ]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get member role based on the role ID
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73203
    /// </summary>
    public class GetSingleMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleMemberRoleAdminV1Builder Builder = new GetSingleMemberRoleAdminV1Builder();

        public class GetSingleMemberRoleAdminV1Builder
        {
            
            
            internal GetSingleMemberRoleAdminV1Builder() { }





            public GetSingleMemberRoleAdminV1 Build(
                string memberRoleId,
                string namespace_
            )
            {
                return new GetSingleMemberRoleAdminV1(this,
                    memberRoleId,                    
                    namespace_                    
                );
            }
        }

        private GetSingleMemberRoleAdminV1(GetSingleMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public GetSingleMemberRoleAdminV1(
            string memberRoleId,            
            string namespace_            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRoleResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRoleResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}