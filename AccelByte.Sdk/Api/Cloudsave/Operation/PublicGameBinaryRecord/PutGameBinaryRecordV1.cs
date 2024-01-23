// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// putGameBinaryRecordV1
    ///
    /// Update a game binary record file by its key
    /// </summary>
    public class PutGameBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PutGameBinaryRecordV1Builder Builder { get => new PutGameBinaryRecordV1Builder(); }

        public class PutGameBinaryRecordV1Builder
            : OperationBuilder<PutGameBinaryRecordV1Builder>
        {





            internal PutGameBinaryRecordV1Builder() { }






            public PutGameBinaryRecordV1 Build(
                ModelsBinaryRecordRequest body,
                string key,
                string namespace_
            )
            {
                PutGameBinaryRecordV1 op = new PutGameBinaryRecordV1(this,
                    body,
                    key,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PutGameBinaryRecordV1(PutGameBinaryRecordV1Builder builder,
            ModelsBinaryRecordRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PutGameBinaryRecordV1(
            string key,
            string namespace_,
            Model.ModelsBinaryRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/binaries/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGameBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGameBinaryRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGameBinaryRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGameBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}