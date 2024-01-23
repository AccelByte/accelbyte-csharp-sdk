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
    /// setDefaultPolicy_2
    ///
    /// Update a policy to be the default.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class SetDefaultPolicy2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetDefaultPolicy2Builder Builder { get => new SetDefaultPolicy2Builder(); }

        public class SetDefaultPolicy2Builder
            : OperationBuilder<SetDefaultPolicy2Builder>
        {





            internal SetDefaultPolicy2Builder() { }






            public SetDefaultPolicy2 Build(
                string policyId
            )
            {
                SetDefaultPolicy2 op = new SetDefaultPolicy2(this,
                    policyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private SetDefaultPolicy2(SetDefaultPolicy2Builder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetDefaultPolicy2(
            string policyId
        )
        {
            PathParams["policyId"] = policyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}/default";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}