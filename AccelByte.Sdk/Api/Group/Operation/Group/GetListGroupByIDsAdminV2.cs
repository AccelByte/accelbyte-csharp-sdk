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
    /// getListGroupByIDsAdminV2
    ///
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Get list of groups by group Ids.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73303
    /// </summary>
    public class GetListGroupByIDsAdminV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListGroupByIDsAdminV2Builder Builder { get => new GetListGroupByIDsAdminV2Builder(); }

        public class GetListGroupByIDsAdminV2Builder
            : OperationBuilder<GetListGroupByIDsAdminV2Builder>
        {





            internal GetListGroupByIDsAdminV2Builder() { }






            public GetListGroupByIDsAdminV2 Build(
                ModelsGetGroupListRequestV2 body,
                string namespace_
            )
            {
                GetListGroupByIDsAdminV2 op = new GetListGroupByIDsAdminV2(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetListGroupByIDsAdminV2(GetListGroupByIDsAdminV2Builder builder,
            ModelsGetGroupListRequestV2 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetListGroupByIDsAdminV2(
            string namespace_,
            Model.ModelsGetGroupListRequestV2 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/admin/namespaces/{namespace}/groups/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetGroupsResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsResponseV1>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}