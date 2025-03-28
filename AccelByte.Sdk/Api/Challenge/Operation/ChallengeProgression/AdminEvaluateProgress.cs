// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminEvaluateProgress
    ///
    /// - Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:PROGRESSION [UPDATE]
    /// - Limited up to 10 users per request
    /// </summary>
    public class AdminEvaluateProgress : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEvaluateProgressBuilder Builder { get => new AdminEvaluateProgressBuilder(); }

        public class AdminEvaluateProgressBuilder
            : OperationBuilder<AdminEvaluateProgressBuilder>
        {





            internal AdminEvaluateProgressBuilder() { }






            public AdminEvaluateProgress Build(
                ModelEvaluatePlayerProgressionRequest body,
                string namespace_
            )
            {
                AdminEvaluateProgress op = new AdminEvaluateProgress(this,
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

        private AdminEvaluateProgress(AdminEvaluateProgressBuilder builder,
            ModelEvaluatePlayerProgressionRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminEvaluateProgress(
            string namespace_,
            Model.ModelEvaluatePlayerProgressionRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/progress/evaluate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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