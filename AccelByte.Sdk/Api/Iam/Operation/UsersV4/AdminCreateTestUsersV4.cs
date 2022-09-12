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
    /// AdminCreateTestUsersV4
    ///
    /// Create test users and not send verification code email.
    /// 
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:USER
    /// </summary>
    public class AdminCreateTestUsersV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateTestUsersV4Builder Builder = new AdminCreateTestUsersV4Builder();

        public class AdminCreateTestUsersV4Builder
            : OperationBuilder<AdminCreateTestUsersV4Builder>
        {





            internal AdminCreateTestUsersV4Builder() { }






            public AdminCreateTestUsersV4 Build(
                AccountCreateTestUsersRequestV4 body,
                string namespace_
            )
            {
                AdminCreateTestUsersV4 op = new AdminCreateTestUsersV4(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminCreateTestUsersV4(AdminCreateTestUsersV4Builder builder,
            AccountCreateTestUsersRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateTestUsersV4(
            string namespace_,
            Model.AccountCreateTestUsersRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/test_users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountCreateTestUsersResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateTestUsersResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateTestUsersResponseV4>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}