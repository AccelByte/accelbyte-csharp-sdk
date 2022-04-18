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
    /// getItemDynamicData
    ///
    /// Get item dynamic data for published item.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : item dynamic data
    /// </summary>
    public class GetItemDynamicData : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemDynamicDataBuilder Builder = new GetItemDynamicDataBuilder();

        public class GetItemDynamicDataBuilder
            : OperationBuilder<GetItemDynamicDataBuilder>
        {
            
            
            internal GetItemDynamicDataBuilder() { }





            public GetItemDynamicData Build(
                string itemId,
                string namespace_
            )
            {
                GetItemDynamicData op = new GetItemDynamicData(this,
                    itemId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetItemDynamicData(GetItemDynamicDataBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetItemDynamicData(
            string itemId,            
            string namespace_            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/dynamic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ItemDynamicDataInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemDynamicDataInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemDynamicDataInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}