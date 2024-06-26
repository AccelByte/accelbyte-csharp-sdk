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
    /// requestPresignedURL_1
    ///
    /// Request presigned URL for upload attachment for a particular localized version of base policy.
    /// </summary>
    public class RequestPresignedURL1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestPresignedURL1Builder Builder { get => new RequestPresignedURL1Builder(); }

        public class RequestPresignedURL1Builder
            : OperationBuilder<RequestPresignedURL1Builder>
        {


            public Model.UploadPolicyVersionAttachmentRequest? Body { get; set; }




            internal RequestPresignedURL1Builder() { }



            public RequestPresignedURL1Builder SetBody(Model.UploadPolicyVersionAttachmentRequest _body)
            {
                Body = _body;
                return this;
            }




            public RequestPresignedURL1 Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RequestPresignedURL1 op = new RequestPresignedURL1(this,
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

        private RequestPresignedURL1(RequestPresignedURL1Builder builder,
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

        public RequestPresignedURL1(
            string localizedPolicyVersionId,
            string namespace_,
            Model.UploadPolicyVersionAttachmentRequest body
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}/attachments";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.UploadLocalizedPolicyVersionAttachmentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}