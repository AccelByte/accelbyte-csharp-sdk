// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// AdminAccountLinkTokenPost
    ///
    /// This route will attempt to register the account to namespace linkage in AMS and requires a valid account link token. This route fails if an account is already linked
    /// 
    /// AdminAccountLink
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:ACCOUNT [CREATE]
    /// </summary>
    public class AdminAccountLinkTokenPost : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAccountLinkTokenPostBuilder Builder { get => new AdminAccountLinkTokenPostBuilder(); }

        public class AdminAccountLinkTokenPostBuilder
            : OperationBuilder<AdminAccountLinkTokenPostBuilder>
        {





            internal AdminAccountLinkTokenPostBuilder() { }






            public AdminAccountLinkTokenPost Build(
                ApiAccountLinkRequest body,
                string namespace_
            )
            {
                AdminAccountLinkTokenPost op = new AdminAccountLinkTokenPost(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminAccountLinkTokenPost(AdminAccountLinkTokenPostBuilder builder,
            ApiAccountLinkRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAccountLinkTokenPost(
            string namespace_,
            Model.ApiAccountLinkRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/account/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiAccountLinkResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiAccountLinkResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiAccountLinkResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiAccountLinkResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}