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
    /// AccountLinkTokenGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:ACCOUNT [READ]
    /// </summary>
    public class AccountLinkTokenGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AccountLinkTokenGetBuilder Builder { get => new AccountLinkTokenGetBuilder(); }

        public class AccountLinkTokenGetBuilder
            : OperationBuilder<AccountLinkTokenGetBuilder>
        {





            internal AccountLinkTokenGetBuilder() { }






            public AccountLinkTokenGet Build(
                string namespace_
            )
            {
                AccountLinkTokenGet op = new AccountLinkTokenGet(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AccountLinkTokenGet(AccountLinkTokenGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AccountLinkTokenGet(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/account/link";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiAccountLinkTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiAccountLinkTokenResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiAccountLinkTokenResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiAccountLinkTokenResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}