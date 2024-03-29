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
    /// GetUsersByLoginIds
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint(query by email list): _/iam/v3/public/namespaces/{namespace}/users/bulk/basic [POST]_**
    /// - **Substitute endpoint(query by user id list): _/iam/v3/admin/namespaces/{namespace}/users/search/bulk [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUsersByLoginIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUsersByLoginIdsBuilder Builder { get => new GetUsersByLoginIdsBuilder(); }

        public class GetUsersByLoginIdsBuilder
            : OperationBuilder<GetUsersByLoginIdsBuilder>
        {

            public string? LoginIds { get; set; }





            internal GetUsersByLoginIdsBuilder() { }


            public GetUsersByLoginIdsBuilder SetLoginIds(string _loginIds)
            {
                LoginIds = _loginIds;
                return this;
            }





            public GetUsersByLoginIds Build(
                string namespace_
            )
            {
                GetUsersByLoginIds op = new GetUsersByLoginIds(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetUsersByLoginIds(GetUsersByLoginIdsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.LoginIds is not null) QueryParams["loginIds"] = builder.LoginIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUsersByLoginIds(
            string namespace_,
            string? loginIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (loginIds is not null) QueryParams["loginIds"] = loginIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/listByLoginIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelPublicUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUsersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}