// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// BulkCreatePSNEvent
    ///
    /// Create PSN UDS events. Player need to login first using playstation token to IAM service.
    /// </summary>
    public class BulkCreatePSNEvent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkCreatePSNEventBuilder Builder { get => new BulkCreatePSNEventBuilder(); }

        public class BulkCreatePSNEventBuilder
            : OperationBuilder<BulkCreatePSNEventBuilder>
        {





            internal BulkCreatePSNEventBuilder() { }






            public BulkCreatePSNEvent Build(
                ModelsBulkCreatePSNEvents body,
                string namespace_
            )
            {
                BulkCreatePSNEvent op = new BulkCreatePSNEvent(this,
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

        private BulkCreatePSNEvent(BulkCreatePSNEventBuilder builder,
            ModelsBulkCreatePSNEvents body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkCreatePSNEvent(
            string namespace_,
            Model.ModelsBulkCreatePSNEvents body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/platforms/psn/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsBulkCreatePSNEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsBulkCreatePSNEventResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsBulkCreatePSNEventResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkCreatePSNEventResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}