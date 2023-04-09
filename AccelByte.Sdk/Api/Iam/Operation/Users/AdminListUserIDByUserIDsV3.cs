// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminListUserIDByUserIDsV3
    ///
    /// List User By User ID
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER [READ] permission.
    /// This endpoint intended to list user information from the given list of userID and namespace
    /// </summary>
    public class AdminListUserIDByUserIDsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserIDByUserIDsV3Builder Builder { get => new AdminListUserIDByUserIDsV3Builder(); }

        public class AdminListUserIDByUserIDsV3Builder
            : OperationBuilder<AdminListUserIDByUserIDsV3Builder>
        {





            internal AdminListUserIDByUserIDsV3Builder() { }






            public AdminListUserIDByUserIDsV3 Build(
                ModelUserIDsRequest body,
                string namespace_
            )
            {
                AdminListUserIDByUserIDsV3 op = new AdminListUserIDByUserIDsV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminListUserIDByUserIDsV3(AdminListUserIDByUserIDsV3Builder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUserIDByUserIDsV3(
            string namespace_,
            Model.ModelUserIDsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListUserInformationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserInformationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserInformationResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}