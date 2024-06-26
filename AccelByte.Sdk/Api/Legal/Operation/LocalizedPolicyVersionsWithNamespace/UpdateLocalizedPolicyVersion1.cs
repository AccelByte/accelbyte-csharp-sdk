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
    /// updateLocalizedPolicyVersion_1
    ///
    /// Update a version of a particular country-specific policy.
    /// </summary>
    public class UpdateLocalizedPolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLocalizedPolicyVersion1Builder Builder { get => new UpdateLocalizedPolicyVersion1Builder(); }

        public class UpdateLocalizedPolicyVersion1Builder
            : OperationBuilder<UpdateLocalizedPolicyVersion1Builder>
        {


            public Model.UpdateLocalizedPolicyVersionRequest? Body { get; set; }




            internal UpdateLocalizedPolicyVersion1Builder() { }



            public UpdateLocalizedPolicyVersion1Builder SetBody(Model.UpdateLocalizedPolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateLocalizedPolicyVersion1 Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                UpdateLocalizedPolicyVersion1 op = new UpdateLocalizedPolicyVersion1(this,
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

        private UpdateLocalizedPolicyVersion1(UpdateLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateLocalizedPolicyVersion1(
            string localizedPolicyVersionId,
            string namespace_,
            Model.UpdateLocalizedPolicyVersionRequest body
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.UpdateLocalizedPolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}