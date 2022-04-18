// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// listPlayerRecordHandlerV1
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]
    /// 
    /// Required scope: `social`
    /// 
    /// Retrieve list of player records key and userID under given namespace.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class ListPlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListPlayerRecordHandlerV1Builder Builder = new ListPlayerRecordHandlerV1Builder();

        public class ListPlayerRecordHandlerV1Builder
            : OperationBuilder<ListPlayerRecordHandlerV1Builder>
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            public string? Query { get; set; }
            
            internal ListPlayerRecordHandlerV1Builder() { }


            public ListPlayerRecordHandlerV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListPlayerRecordHandlerV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListPlayerRecordHandlerV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }




            public ListPlayerRecordHandlerV1 Build(
                string namespace_
            )
            {
                ListPlayerRecordHandlerV1 op = new ListPlayerRecordHandlerV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListPlayerRecordHandlerV1(ListPlayerRecordHandlerV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Query != null) QueryParams["query"] = builder.Query;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListPlayerRecordHandlerV1(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? query            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query != null) QueryParams["query"] = query;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListPlayerRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}