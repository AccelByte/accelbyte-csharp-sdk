// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicListStores
    ///
    /// This API is used to list all stores in a namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store)
    ///   *  Returns : the list of stores
    /// </summary>
    public class PublicListStores : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListStoresBuilder Builder = new PublicListStoresBuilder();

        public class PublicListStoresBuilder
            : OperationBuilder<PublicListStoresBuilder>
        {
            
            internal PublicListStoresBuilder() { }






            public PublicListStores Build(
                string namespace_
            )
            {
                PublicListStores op = new PublicListStores(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicListStores(PublicListStoresBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

        }
        #endregion

        public PublicListStores(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/stores";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.StoreInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.StoreInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.StoreInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}