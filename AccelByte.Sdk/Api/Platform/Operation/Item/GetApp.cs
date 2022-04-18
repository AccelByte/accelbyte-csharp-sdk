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
    /// getApp
    ///
    /// This API is used to get an app info.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : app data
    /// </summary>
    public class GetApp : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAppBuilder Builder = new GetAppBuilder();

        public class GetAppBuilder
            : OperationBuilder<GetAppBuilder>
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            public string? StoreId { get; set; }
            
            internal GetAppBuilder() { }


            public GetAppBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetAppBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public GetApp Build(
                string itemId,
                string namespace_
            )
            {
                GetApp op = new GetApp(this,
                    itemId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetApp(GetAppBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetApp(
            string itemId,            
            string namespace_,            
            bool? activeOnly,            
            string? storeId            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/app";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.FullAppInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullAppInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullAppInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}