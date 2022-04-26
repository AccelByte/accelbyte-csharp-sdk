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
    /// DeleteContentScreenshot
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class DeleteContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteContentScreenshotBuilder Builder = new DeleteContentScreenshotBuilder();

        public class DeleteContentScreenshotBuilder
            : OperationBuilder<DeleteContentScreenshotBuilder>
        {
            
            
            
            
            internal DeleteContentScreenshotBuilder() { }






            public DeleteContentScreenshot Build(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = new DeleteContentScreenshot(this,
                    contentId,                    
                    namespace_,                    
                    screenshotId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteContentScreenshot(DeleteContentScreenshotBuilder builder,
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteContentScreenshot(
            string contentId,            
            string namespace_,            
            string screenshotId,            
            string userId            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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