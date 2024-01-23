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
    /// publishPolicyVersion_1
    ///
    /// Manually publish a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class PublishPolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublishPolicyVersion1Builder Builder { get => new PublishPolicyVersion1Builder(); }

        public class PublishPolicyVersion1Builder
            : OperationBuilder<PublishPolicyVersion1Builder>
        {

            public bool? ShouldNotify { get; set; }





            internal PublishPolicyVersion1Builder() { }


            public PublishPolicyVersion1Builder SetShouldNotify(bool _shouldNotify)
            {
                ShouldNotify = _shouldNotify;
                return this;
            }





            public PublishPolicyVersion1 Build(
                string namespace_,
                string policyVersionId
            )
            {
                PublishPolicyVersion1 op = new PublishPolicyVersion1(this,
                    namespace_,
                    policyVersionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublishPolicyVersion1(PublishPolicyVersion1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;

            if (builder.ShouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(builder.ShouldNotify)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublishPolicyVersion1(
            string namespace_,
            string policyVersionId,
            bool? shouldNotify
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;

            if (shouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(shouldNotify)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/versions/{policyVersionId}/latest";

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