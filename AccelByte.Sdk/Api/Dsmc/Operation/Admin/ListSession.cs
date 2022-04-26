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
    /// ListSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of sessions in a namespace managed by this service.
    /// </summary>
    public class ListSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListSessionBuilder Builder = new ListSessionBuilder();

        public class ListSessionBuilder
            : OperationBuilder<ListSessionBuilder>
        {
            
            public long? Count { get; set; }
            
            public long? Offset { get; set; }
            
            public string? Region { get; set; }
            
            public bool? WithServer { get; set; }
            
            internal ListSessionBuilder() { }


            public ListSessionBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public ListSessionBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListSessionBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ListSessionBuilder SetWithServer(bool _withServer)
            {
                WithServer = _withServer;
                return this;
            }





            public ListSession Build(
                string namespace_
            )
            {
                ListSession op = new ListSession(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListSession(ListSessionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.WithServer != null) QueryParams["withServer"] = Convert.ToString(builder.WithServer)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListSession(
            string namespace_,            
            long? count,            
            long? offset,            
            string? region,            
            bool? withServer            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            if (withServer != null) QueryParams["withServer"] = Convert.ToString(withServer)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/sessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}