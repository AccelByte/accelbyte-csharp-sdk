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
    /// CountServerDetailed
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint counts all of dedicated servers in a region managed by this service.
    /// </summary>
    public class CountServerDetailed : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CountServerDetailedBuilder Builder = new CountServerDetailedBuilder();

        public class CountServerDetailedBuilder
            : OperationBuilder<CountServerDetailedBuilder>
        {
            
            public string? Region { get; set; }
            
            internal CountServerDetailedBuilder() { }


            public CountServerDetailedBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public CountServerDetailed Build(
                string namespace_
            )
            {
                CountServerDetailed op = new CountServerDetailed(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CountServerDetailed(CountServerDetailedBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CountServerDetailed(
            string namespace_,            
            string? region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (region != null) QueryParams["region"] = region;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers/count/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsDetailedCountServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDetailedCountServerResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDetailedCountServerResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}