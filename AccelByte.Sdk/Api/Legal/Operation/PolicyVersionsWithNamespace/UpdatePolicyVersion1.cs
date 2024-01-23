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
    /// updatePolicyVersion_1
    ///
    /// Update a particular policy version.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class UpdatePolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePolicyVersion1Builder Builder { get => new UpdatePolicyVersion1Builder(); }

        public class UpdatePolicyVersion1Builder
            : OperationBuilder<UpdatePolicyVersion1Builder>
        {


            public Model.UpdatePolicyVersionRequest? Body { get; set; }




            internal UpdatePolicyVersion1Builder() { }



            public UpdatePolicyVersion1Builder SetBody(Model.UpdatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePolicyVersion1 Build(
                string namespace_,
                string policyVersionId
            )
            {
                UpdatePolicyVersion1 op = new UpdatePolicyVersion1(this,
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

        private UpdatePolicyVersion1(UpdatePolicyVersion1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePolicyVersion1(
            string namespace_,
            string policyVersionId,
            Model.UpdatePolicyVersionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.UpdatePolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.UpdatePolicyVersionResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.UpdatePolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdatePolicyVersionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}