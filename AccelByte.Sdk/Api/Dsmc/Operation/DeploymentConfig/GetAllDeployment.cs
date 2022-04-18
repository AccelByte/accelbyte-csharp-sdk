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
    /// GetAllDeployment
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get a all deployments in a namespace
    /// </summary>
    public class GetAllDeployment : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllDeploymentBuilder Builder = new GetAllDeploymentBuilder();

        public class GetAllDeploymentBuilder
            : OperationBuilder<GetAllDeploymentBuilder>
        {
            
            public long? Count { get; set; }
            
            public string? Name { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetAllDeploymentBuilder() { }


            public GetAllDeploymentBuilder SetCount(long _count)
            {
                Count = _count;
                return this;
            }

            public GetAllDeploymentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public GetAllDeploymentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetAllDeployment Build(
                string namespace_
            )
            {
                GetAllDeployment op = new GetAllDeployment(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetAllDeployment(GetAllDeploymentBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Count != null) QueryParams["count"] = Convert.ToString(builder.Count)!;
            if (builder.Name != null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllDeployment(
            string namespace_,            
            long? count,            
            string? name,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (count != null) QueryParams["count"] = Convert.ToString(count)!;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListDeploymentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeploymentResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeploymentResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}