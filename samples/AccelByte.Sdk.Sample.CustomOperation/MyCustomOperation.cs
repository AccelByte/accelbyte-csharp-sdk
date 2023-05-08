// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Sample.CustomOperation
{
    public class MyCustomOperation : Operation
    {
        //Use existing endpoint only for this sample.
        public override string Path => "/achievement/v1/public/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        //Still need to implement this. set "Bearer" for SECURITY_BEARER, and "Basic" for SECURITY_BASIC.
        //This property requirement will be removed in future release.
        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        #region Builder Part
        public static MyCustomOperationBuilder Builder { get => new MyCustomOperationBuilder(); }

        public class MyCustomOperationBuilder : OperationBuilder<MyCustomOperationBuilder>
        {
            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public MyCustomOperationBuilder() { }

            public MyCustomOperationBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public MyCustomOperationBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public MyCustomOperationBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public MyCustomOperationBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public MyCustomOperation Build(
                string namespace_
            )
            {
                MyCustomOperation op = new MyCustomOperation(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public MyCustomResponseModel? Execute(string namespace_)
            {
                MyCustomOperation op = Build(
                    namespace_
                );

                return GetWrapperObject<MyCustomWrapper>().CallMyCustomOperation(op);
            }
        }

        private MyCustomOperation(MyCustomOperationBuilder builder, string namespace_)
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null)
                QueryParams["limit"] = Convert.ToString(builder.Limit)!;

            if (builder.Name is not null)
                QueryParams["name"] = builder.Name;

            if (builder.Offset != null)
                QueryParams["offset"] = Convert.ToString(builder.Offset)!;

            if (builder.SortBy is not null)
                QueryParams["sortBy"] = builder.SortBy;

            //Use SECURITY_BEARER for endpoint that need authorization token,
            //or use SECURITY_BASIC for endpoint that only need basic auth using client id and secret._
            Securities.Add(SECURITY_BEARER);
        }
        #endregion

        public MyCustomOperation(string namespace_, long? limit, string? name, long? offset, string? sortBy)
        {
            PathParams["namespace"] = namespace_;

            if (limit != null)
                QueryParams["limit"] = Convert.ToString(limit)!;

            if (name != null)
                QueryParams["name"] = name;

            if (offset != null)
                QueryParams["offset"] = Convert.ToString(offset)!;

            if (sortBy != null)
                QueryParams["sortBy"] = sortBy;

            //Use SECURITY_BEARER for endpoint that need authorization token,
            //or use SECURITY_BASIC for endpoint that only need basic auth using client id and secret._
            Securities.Add(SECURITY_BEARER);
        }

        public MyCustomResponseModel? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<MyCustomResponseModel>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<MyCustomResponseModel>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }
}