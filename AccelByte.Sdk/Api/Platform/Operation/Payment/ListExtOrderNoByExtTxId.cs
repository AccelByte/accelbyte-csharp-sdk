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
    /// listExtOrderNoByExtTxId
    ///
    /// List external order No by external transaction id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=2 (READ)
    ///   *  Returns : payment orders
    /// </summary>
    public class ListExtOrderNoByExtTxId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListExtOrderNoByExtTxIdBuilder Builder = new ListExtOrderNoByExtTxIdBuilder();

        public class ListExtOrderNoByExtTxIdBuilder
            : OperationBuilder<ListExtOrderNoByExtTxIdBuilder>
        {
            
            
            internal ListExtOrderNoByExtTxIdBuilder() { }





            public ListExtOrderNoByExtTxId Build(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = new ListExtOrderNoByExtTxId(this,
                    namespace_,                    
                    extTxId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListExtOrderNoByExtTxId(ListExtOrderNoByExtTxIdBuilder builder,
            string namespace_,
            string extTxId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (extTxId != null) QueryParams["extTxId"] = extTxId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListExtOrderNoByExtTxId(
            string namespace_,            
            string extTxId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (extTxId != null) QueryParams["extTxId"] = extTxId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/byExtTxId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}