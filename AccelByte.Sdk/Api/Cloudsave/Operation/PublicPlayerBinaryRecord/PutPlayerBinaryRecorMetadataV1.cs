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
    /// putPlayerBinaryRecorMetadataV1
    ///
    /// Update a player binary record metadata by its key
    /// </summary>
    public class PutPlayerBinaryRecorMetadataV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PutPlayerBinaryRecorMetadataV1Builder Builder { get => new PutPlayerBinaryRecorMetadataV1Builder(); }

        public class PutPlayerBinaryRecorMetadataV1Builder
            : OperationBuilder<PutPlayerBinaryRecorMetadataV1Builder>
        {





            internal PutPlayerBinaryRecorMetadataV1Builder() { }






            public PutPlayerBinaryRecorMetadataV1 Build(
                ModelsPlayerBinaryRecordMetadataPublicRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecorMetadataV1 op = new PutPlayerBinaryRecorMetadataV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PutPlayerBinaryRecorMetadataV1(PutPlayerBinaryRecorMetadataV1Builder builder,
            ModelsPlayerBinaryRecordMetadataPublicRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PutPlayerBinaryRecorMetadataV1(
            string key,
            string namespace_,
            string userId,
            Model.ModelsPlayerBinaryRecordMetadataPublicRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}/metadata";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPlayerBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}