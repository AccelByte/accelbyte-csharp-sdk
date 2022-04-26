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
    /// freeFormNotificationByUserID
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to a user.
    /// </summary>
    public class FreeFormNotificationByUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FreeFormNotificationByUserIDBuilder Builder = new FreeFormNotificationByUserIDBuilder();

        public class FreeFormNotificationByUserIDBuilder
            : OperationBuilder<FreeFormNotificationByUserIDBuilder>
        {
            
            
            
            internal FreeFormNotificationByUserIDBuilder() { }






            public FreeFormNotificationByUserID Build(
                ModelFreeFormNotificationRequest body,
                string namespace_,
                string userId
            )
            {
                FreeFormNotificationByUserID op = new FreeFormNotificationByUserID(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private FreeFormNotificationByUserID(FreeFormNotificationByUserIDBuilder builder,
            ModelFreeFormNotificationRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FreeFormNotificationByUserID(
            string namespace_,            
            string userId,            
            Model.ModelFreeFormNotificationRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/users/{userId}/freeform";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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