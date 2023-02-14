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
    /// getPlayerRecordsBulkHandlerV1
    ///
    /// Required valid user token
    /// 
    /// Required scope: `social`
    /// 
    /// Retrieve player record key and payload in bulk under given namespace.
    /// 
    /// Maximum bulk key limit per request 20
    /// </summary>
    public class GetPlayerRecordsBulkHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPlayerRecordsBulkHandlerV1Builder Builder { get => new GetPlayerRecordsBulkHandlerV1Builder(); }

        public class GetPlayerRecordsBulkHandlerV1Builder
            : OperationBuilder<GetPlayerRecordsBulkHandlerV1Builder>
        {





            internal GetPlayerRecordsBulkHandlerV1Builder() { }






            public GetPlayerRecordsBulkHandlerV1 Build(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_
            )
            {
                GetPlayerRecordsBulkHandlerV1 op = new GetPlayerRecordsBulkHandlerV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetPlayerRecordsBulkHandlerV1(GetPlayerRecordsBulkHandlerV1Builder builder,
            ModelsBulkGetPlayerRecordsRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPlayerRecordsBulkHandlerV1(
            string namespace_,
            Model.ModelsBulkGetPlayerRecordsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsBulkGetPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}