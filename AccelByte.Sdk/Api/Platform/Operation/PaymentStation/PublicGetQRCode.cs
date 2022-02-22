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
    /// publicGetQRCode
    ///
    /// Get qrcode.
    /// Other detail info:
    /// 
    ///   * Returns : QRCode image stream
    /// </summary>
    public class PublicGetQRCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetQRCodeBuilder Builder = new PublicGetQRCodeBuilder();

        public class PublicGetQRCodeBuilder
        {
            
            
            internal PublicGetQRCodeBuilder() { }





            public PublicGetQRCode Build(
                string namespace_,
                string code
            )
            {
                return new PublicGetQRCode(this,
                    namespace_,                    
                    code                    
                );
            }
        }

        private PublicGetQRCode(PublicGetQRCodeBuilder builder,
            string namespace_,
            string code
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (code != null) QueryParams["code"] = code;
            
            
            
            
        }
        #endregion

        public PublicGetQRCode(
            string namespace_,            
            string code            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (code != null) QueryParams["code"] = code;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/qrcode";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "image/png" };

        public override string? Security {get; set;} = "Bearer";
        
        public byte[]? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            else if (code == (HttpStatusCode)200)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}