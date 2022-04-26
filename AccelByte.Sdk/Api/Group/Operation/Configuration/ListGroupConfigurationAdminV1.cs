// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// listGroupConfigurationAdminV1
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get existing configuration. This Configuration is used as the main rule of the service. Each namespace will have its own configuration
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73101
    /// </summary>
    public class ListGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListGroupConfigurationAdminV1Builder Builder = new ListGroupConfigurationAdminV1Builder();

        public class ListGroupConfigurationAdminV1Builder
            : OperationBuilder<ListGroupConfigurationAdminV1Builder>
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal ListGroupConfigurationAdminV1Builder() { }


            public ListGroupConfigurationAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListGroupConfigurationAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public ListGroupConfigurationAdminV1 Build(
                string namespace_
            )
            {
                ListGroupConfigurationAdminV1 op = new ListGroupConfigurationAdminV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListGroupConfigurationAdminV1(ListGroupConfigurationAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListGroupConfigurationAdminV1(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListConfigurationResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}