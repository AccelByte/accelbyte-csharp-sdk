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
    /// publicDeletePaymentAccount
    ///
    /// Delete payment account.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:PAYMENT:ACCOUNT", action=8 (DELETE)
    ///   *  Returns :
    /// </summary>
    public class PublicDeletePaymentAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePaymentAccountBuilder Builder = new PublicDeletePaymentAccountBuilder();

        public class PublicDeletePaymentAccountBuilder
        {
            
            
            
            
            internal PublicDeletePaymentAccountBuilder() { }





            public PublicDeletePaymentAccount Build(
                string id,
                string namespace_,
                string type,
                string userId
            )
            {
                return new PublicDeletePaymentAccount(this,
                    id,                    
                    namespace_,                    
                    type,                    
                    userId                    
                );
            }
        }

        private PublicDeletePaymentAccount(PublicDeletePaymentAccountBuilder builder,
            string id,
            string namespace_,
            string type,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["type"] = type;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public PublicDeletePaymentAccount(
            string id,            
            string namespace_,            
            string type,            
            string userId            
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["type"] = type;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts/{type}/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}