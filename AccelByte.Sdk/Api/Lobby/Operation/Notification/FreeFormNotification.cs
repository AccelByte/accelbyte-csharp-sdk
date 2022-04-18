// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// freeFormNotification
    ///
    /// Required permission : `NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to all connected users in a namespace.
    /// </summary>
    public class FreeFormNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FreeFormNotificationBuilder Builder = new FreeFormNotificationBuilder();

        public class FreeFormNotificationBuilder
            : OperationBuilder<FreeFormNotificationBuilder>
        {
            
            
            internal FreeFormNotificationBuilder() { }





            public FreeFormNotification Build(
                ModelFreeFormNotificationRequest body,
                string namespace_
            )
            {
                FreeFormNotification op = new FreeFormNotification(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private FreeFormNotification(FreeFormNotificationBuilder builder,
            ModelFreeFormNotificationRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FreeFormNotification(
            string namespace_,            
            Model.ModelFreeFormNotificationRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/freeform";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}