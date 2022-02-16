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
    /// deletePaymentProviderConfig
    ///
    /// Delete payment provider config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=8 (DELETE)
    ///   *  Returns : payment provider config
    /// </summary>
    public class DeletePaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        public DeletePaymentProviderConfig(
            string id            
        )
        {
            PathParams["id"] = id;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/payment/config/provider/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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