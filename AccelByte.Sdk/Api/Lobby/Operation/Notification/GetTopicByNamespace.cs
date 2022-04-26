// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getTopicByNamespace
    ///
    /// Required permission : `NAMESPACE:{namespace}:TOPIC [READ]` with scope `social`
    /// 
    /// get topic by namespace.
    /// </summary>
    public class GetTopicByNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetTopicByNamespaceBuilder Builder = new GetTopicByNamespaceBuilder();

        public class GetTopicByNamespaceBuilder
            : OperationBuilder<GetTopicByNamespaceBuilder>
        {
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal GetTopicByNamespaceBuilder() { }


            public GetTopicByNamespaceBuilder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public GetTopicByNamespaceBuilder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public GetTopicByNamespaceBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public GetTopicByNamespace Build(
                string namespace_
            )
            {
                GetTopicByNamespace op = new GetTopicByNamespace(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetTopicByNamespace(GetTopicByNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetTopicByNamespace(
            string namespace_,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/topics";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelTopicByNamespacesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelTopicByNamespacesResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelTopicByNamespacesResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}