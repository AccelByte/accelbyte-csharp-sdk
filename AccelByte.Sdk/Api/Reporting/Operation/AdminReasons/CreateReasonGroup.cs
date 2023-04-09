// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// createReasonGroup
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:REASON [CREATE]
    /// Create a reason group for easier query. You can query reasons by specifying the group title in the list reasons query.
    /// Reason group title is case insensitive, meaning you can't have reason if you already create a reason titled Reason
    /// </summary>
    public class CreateReasonGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateReasonGroupBuilder Builder { get => new CreateReasonGroupBuilder(); }

        public class CreateReasonGroupBuilder
            : OperationBuilder<CreateReasonGroupBuilder>
        {





            internal CreateReasonGroupBuilder() { }






            public CreateReasonGroup Build(
                RestapiCreateReasonGroupRequest body,
                string namespace_
            )
            {
                CreateReasonGroup op = new CreateReasonGroup(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateReasonGroup(CreateReasonGroupBuilder builder,
            RestapiCreateReasonGroupRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateReasonGroup(
            string namespace_,
            Model.RestapiCreateReasonGroupRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasonGroups";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiReasonGroupResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiReasonGroupResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiReasonGroupResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}