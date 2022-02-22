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
    /// AdminDeleteContentScreenshot
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class AdminDeleteContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteContentScreenshotBuilder Builder = new AdminDeleteContentScreenshotBuilder();

        public class AdminDeleteContentScreenshotBuilder
        {
            
            
            
            internal AdminDeleteContentScreenshotBuilder() { }





            public AdminDeleteContentScreenshot Build(
                string contentId,
                string namespace_,
                string screenshotId
            )
            {
                return new AdminDeleteContentScreenshot(this,
                    contentId,                    
                    namespace_,                    
                    screenshotId                    
                );
            }
        }

        private AdminDeleteContentScreenshot(AdminDeleteContentScreenshotBuilder builder,
            string contentId,
            string namespace_,
            string screenshotId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            
            
            
            
            
        }
        #endregion

        public AdminDeleteContentScreenshot(
            string contentId,            
            string namespace_,            
            string screenshotId            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots/{screenshotId}";

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