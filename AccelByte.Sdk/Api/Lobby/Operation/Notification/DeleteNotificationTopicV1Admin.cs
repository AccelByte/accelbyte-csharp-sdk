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
    /// deleteNotificationTopicV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [DELETE]` with scope `social`
    /// 
    /// delete topic information by topic name.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// 
    /// Action Code: 50217
    /// </summary>
    public class DeleteNotificationTopicV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNotificationTopicV1AdminBuilder Builder = new DeleteNotificationTopicV1AdminBuilder();

        public class DeleteNotificationTopicV1AdminBuilder
            : OperationBuilder<DeleteNotificationTopicV1AdminBuilder>
        {
            
            
            internal DeleteNotificationTopicV1AdminBuilder() { }






            public DeleteNotificationTopicV1Admin Build(
                string namespace_,
                string topicName
            )
            {
                DeleteNotificationTopicV1Admin op = new DeleteNotificationTopicV1Admin(this,
                    namespace_,                    
                    topicName                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteNotificationTopicV1Admin(DeleteNotificationTopicV1AdminBuilder builder,
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteNotificationTopicV1Admin(
            string namespace_,            
            string topicName            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}";

        public override HttpMethod Method => HttpMethod.Delete;

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