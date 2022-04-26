// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetListDeletionDataRequest
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER[READ]` and scope `account`
    /// </summary>
    public class AdminGetListDeletionDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListDeletionDataRequestBuilder Builder = new AdminGetListDeletionDataRequestBuilder();

        public class AdminGetListDeletionDataRequestBuilder
            : OperationBuilder<AdminGetListDeletionDataRequestBuilder>
        {
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            public string? RequestDate { get; set; }
            
            internal AdminGetListDeletionDataRequestBuilder() { }


            public AdminGetListDeletionDataRequestBuilder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetRequestDate(string _requestDate)
            {
                RequestDate = _requestDate;
                return this;
            }





            public AdminGetListDeletionDataRequest Build(
                string namespace_
            )
            {
                AdminGetListDeletionDataRequest op = new AdminGetListDeletionDataRequest(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetListDeletionDataRequest(AdminGetListDeletionDataRequestBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.RequestDate != null) QueryParams["requestDate"] = builder.RequestDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListDeletionDataRequest(
            string namespace_,            
            string? after,            
            string? before,            
            long? limit,            
            long? offset,            
            string? requestDate            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (requestDate != null) QueryParams["requestDate"] = requestDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/deletions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListDeletionDataResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeletionDataResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeletionDataResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}