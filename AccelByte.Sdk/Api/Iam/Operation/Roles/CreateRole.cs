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
    /// CreateRole
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ROLE:ADMIN [CREATE]' or 'ADMIN:ROLE [CREATE]'
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// 
    /// 
    /// 
    /// If role is an administrator role (i.e. AdminRole == true), it will list out the role's members.
    /// 
    /// 
    /// 
    /// 
    /// Administrator role can be created only when at least 1 manager is specified.
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/roles [POST]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class CreateRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRoleBuilder Builder { get => new CreateRoleBuilder(); }

        public class CreateRoleBuilder
            : OperationBuilder<CreateRoleBuilder>
        {





            internal CreateRoleBuilder() { }






            public CreateRole Build(
                ModelRoleCreateRequest body
            )
            {
                CreateRole op = new CreateRole(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private CreateRole(CreateRoleBuilder builder,
            ModelRoleCreateRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateRole(
            Model.ModelRoleCreateRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountcommonRole? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}