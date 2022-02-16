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
    /// downloadUserOrderReceipt
    ///
    /// Download user order receipt by orderNo.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : order receipt pdf
    /// </summary>
    public class DownloadUserOrderReceipt : AccelByte.Sdk.Core.Operation
    {
        public DownloadUserOrderReceipt(
            string namespace_,            
            string orderNo,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/pdf" };

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