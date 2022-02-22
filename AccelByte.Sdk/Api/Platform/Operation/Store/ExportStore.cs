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
    /// exportStore
    ///
    /// This API is used to export a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    /// </summary>
    public class ExportStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportStoreBuilder Builder = new ExportStoreBuilder();

        public class ExportStoreBuilder
        {
            
            
            internal ExportStoreBuilder() { }





            public ExportStore Build(
                string namespace_,
                string storeId
            )
            {
                return new ExportStore(this,
                    namespace_,                    
                    storeId                    
                );
            }
        }

        private ExportStore(ExportStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            
            
            
            
        }
        #endregion

        public ExportStore(
            string namespace_,            
            string storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/zip" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}