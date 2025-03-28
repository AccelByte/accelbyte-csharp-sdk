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
    /// deleteBasePolicy
    ///
    /// Delete base legal policy.Can only be deleted if match these criteria:
    /// 
    /// 
    ///   * Base policy don't have published policy version
    ///   * Policy version under base policy has never been accepted by any user
    /// </summary>
    public class DeleteBasePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteBasePolicyBuilder Builder { get => new DeleteBasePolicyBuilder(); }

        public class DeleteBasePolicyBuilder
            : OperationBuilder<DeleteBasePolicyBuilder>
        {





            internal DeleteBasePolicyBuilder() { }






            public DeleteBasePolicy Build(
                string basePolicyId,
                string namespace_
            )
            {
                DeleteBasePolicy op = new DeleteBasePolicy(this,
                    basePolicyId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteBasePolicy(DeleteBasePolicyBuilder builder,
            string basePolicyId,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteBasePolicy(
            string basePolicyId,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId}";

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