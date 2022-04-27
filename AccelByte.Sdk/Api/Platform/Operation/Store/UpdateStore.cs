// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateStore
    ///
    /// This API is used to Update a store basic info.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=4 (UPDATE)
    ///   *  Returns : updated store data
    /// </summary>
    public class UpdateStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStoreBuilder Builder = new UpdateStoreBuilder();

        public class UpdateStoreBuilder
            : OperationBuilder<UpdateStoreBuilder>
        {
            
            
            public Model.StoreUpdate? Body { get; set; }
            
            internal UpdateStoreBuilder() { }



            public UpdateStoreBuilder SetBody(Model.StoreUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateStore Build(
                string namespace_,
                string storeId
            )
            {
                UpdateStore op = new UpdateStore(this,
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateStore(UpdateStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateStore(
            string namespace_,            
            string storeId,            
            Model.StoreUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}