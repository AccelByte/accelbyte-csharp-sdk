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
    /// AdminGetListPersonalDataRequest
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER [READ]` and scope `account`
    /// </summary>
    public class AdminGetListPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListPersonalDataRequestBuilder Builder = new AdminGetListPersonalDataRequestBuilder();

        public class AdminGetListPersonalDataRequestBuilder
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            public string? RequestDate { get; set; }
            
            internal AdminGetListPersonalDataRequestBuilder() { }


            public AdminGetListPersonalDataRequestBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetListPersonalDataRequestBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetListPersonalDataRequestBuilder SetRequestDate(string _requestDate)
            {
                RequestDate = _requestDate;
                return this;
            }




            public AdminGetListPersonalDataRequest Build(
                string namespace_
            )
            {
                return new AdminGetListPersonalDataRequest(this,
                    namespace_                    
                );
            }
        }

        private AdminGetListPersonalDataRequest(AdminGetListPersonalDataRequestBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.RequestDate != null) QueryParams["requestDate"] = builder.RequestDate;
            
            
            
            
        }
        #endregion

        public AdminGetListPersonalDataRequest(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? requestDate            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (requestDate != null) QueryParams["requestDate"] = requestDate;
            
            
            
            
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/requests";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListPersonalDataResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPersonalDataResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPersonalDataResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}