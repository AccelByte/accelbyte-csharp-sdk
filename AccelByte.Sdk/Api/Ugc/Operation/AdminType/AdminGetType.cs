// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminGetType
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:UGCCONFIG [READ]
    /// </summary>
    public class AdminGetType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetTypeBuilder Builder = new AdminGetTypeBuilder();

        public class AdminGetTypeBuilder
        {
            
            public string? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal AdminGetTypeBuilder() { }


            public AdminGetTypeBuilder SetLimit(string _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetTypeBuilder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public AdminGetType Build(
                string namespace_
            )
            {
                return new AdminGetType(this,
                    namespace_                    
                );
            }
        }

        private AdminGetType(AdminGetTypeBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = builder.Limit;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            
        }
        #endregion

        public AdminGetType(
            string namespace_,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/types";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPaginatedGetTypeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetTypeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetTypeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}