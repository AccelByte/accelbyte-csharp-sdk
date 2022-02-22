// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ListServer
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of dedicated servers in a namespace managed by this service.
    /// </summary>
    public class ListServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListServerBuilder Builder = new ListServerBuilder();

        public class ListServerBuilder
        {
            
            public long? Count { get; set; }
            
            public long? Offset { get; set; }
            
            public string? Region { get; set; }
            
            internal ListServerBuilder() { }


            public ListServerBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public ListServerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListServerBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }




            public ListServer Build(
                string namespace_
            )
            {
                return new ListServer(this,
                    namespace_                    
                );
            }
        }

        private ListServer(ListServerBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            
            
            
            
        }
        #endregion

        public ListServer(
            string namespace_,            
            long? count,            
            long? offset,            
            string? region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}