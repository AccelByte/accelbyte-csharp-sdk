// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// deleteLocalizedPolicy
    ///
    /// Delete localized version policy.
    /// Can only be deleted if match these criteria:
    /// 
    /// 
    ///   * Policy Version that this localized policy version belongs to is not active
    ///   * Has never been accepted by any user
    /// </summary>
    public class DeleteLocalizedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteLocalizedPolicyBuilder Builder { get => new DeleteLocalizedPolicyBuilder(); }

        public class DeleteLocalizedPolicyBuilder
            : OperationBuilder<DeleteLocalizedPolicyBuilder>
        {





            internal DeleteLocalizedPolicyBuilder() { }






            public DeleteLocalizedPolicy Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                DeleteLocalizedPolicy op = new DeleteLocalizedPolicy(this,
                    localizedPolicyVersionId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteLocalizedPolicy(DeleteLocalizedPolicyBuilder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteLocalizedPolicy(
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}