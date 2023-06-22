// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// adminCreateModAction
    ///
    /// Required permission: ADMIN:REPORTINGCONFIG [CREATE]
    /// Create auto moderation action
    /// </summary>
    public class AdminCreateModAction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateModActionBuilder Builder { get => new AdminCreateModActionBuilder(); }

        public class AdminCreateModActionBuilder
            : OperationBuilder<AdminCreateModActionBuilder>
        {





            internal AdminCreateModActionBuilder() { }






            public AdminCreateModAction Build(
                RestapiActionApiRequest body
            )
            {
                AdminCreateModAction op = new AdminCreateModAction(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminCreateModAction(AdminCreateModActionBuilder builder,
            RestapiActionApiRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateModAction(
            Model.RestapiActionApiRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/extensionActions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiActionApiResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RestapiActionApiResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RestapiActionApiResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiActionApiResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}