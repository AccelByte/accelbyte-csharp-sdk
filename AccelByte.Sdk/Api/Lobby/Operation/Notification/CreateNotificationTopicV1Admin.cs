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
    /// createNotificationTopicV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Create new notification topic.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// 
    /// Action Code: 50214
    /// </summary>
    public class CreateNotificationTopicV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNotificationTopicV1AdminBuilder Builder = new CreateNotificationTopicV1AdminBuilder();

        public class CreateNotificationTopicV1AdminBuilder
            : OperationBuilder<CreateNotificationTopicV1AdminBuilder>
        {
            
            
            internal CreateNotificationTopicV1AdminBuilder() { }





            public CreateNotificationTopicV1Admin Build(
                ModelCreateTopicRequestV1 body,
                string namespace_
            )
            {
                CreateNotificationTopicV1Admin op = new CreateNotificationTopicV1Admin(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateNotificationTopicV1Admin(CreateNotificationTopicV1AdminBuilder builder,
            ModelCreateTopicRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateNotificationTopicV1Admin(
            string namespace_,            
            Model.ModelCreateTopicRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/topics";

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