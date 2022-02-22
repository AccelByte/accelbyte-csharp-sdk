// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// DownloadContentByShareCode
    ///
    /// Requires valid user token
    /// </summary>
    public class DownloadContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadContentByShareCodeBuilder Builder = new DownloadContentByShareCodeBuilder();

        public class DownloadContentByShareCodeBuilder
        {
            
            
            internal DownloadContentByShareCodeBuilder() { }





            public DownloadContentByShareCode Build(
                string namespace_,
                string shareCode
            )
            {
                return new DownloadContentByShareCode(this,
                    namespace_,                    
                    shareCode                    
                );
            }
        }

        private DownloadContentByShareCode(DownloadContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            
            
            
            
            
        }
        #endregion

        public DownloadContentByShareCode(
            string namespace_,            
            string shareCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}