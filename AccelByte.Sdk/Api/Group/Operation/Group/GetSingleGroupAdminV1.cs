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
    /// getSingleGroupAdminV1
    ///
    /// 
    /// 
    /// Required Permission: "ADMIN:NAMESPACE:{namespace}:GROUP [READ]"
    /// 
    /// 
    /// 
    /// 
    /// Get single group information. This endpoint will show the group information by the groupId
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73306
    /// </summary>
    public class GetSingleGroupAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleGroupAdminV1Builder Builder = new GetSingleGroupAdminV1Builder();

        public class GetSingleGroupAdminV1Builder
            : OperationBuilder<GetSingleGroupAdminV1Builder>
        {
            
            
            internal GetSingleGroupAdminV1Builder() { }






            public GetSingleGroupAdminV1 Build(
                string groupId,
                string namespace_
            )
            {
                GetSingleGroupAdminV1 op = new GetSingleGroupAdminV1(this,
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSingleGroupAdminV1(GetSingleGroupAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSingleGroupAdminV1(
            string groupId,            
            string namespace_            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/groups/{groupId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

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