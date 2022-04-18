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
    /// updateTopicByTopicName
    ///
    /// Required permission : `NAMESPACE:{namespace}:TOPIC [UPDATE]` with scope `social`
    /// 
    /// update topic information by topic name.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// </summary>
    public class UpdateTopicByTopicName : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTopicByTopicNameBuilder Builder = new UpdateTopicByTopicNameBuilder();

        public class UpdateTopicByTopicNameBuilder
            : OperationBuilder<UpdateTopicByTopicNameBuilder>
        {
            
            
            
            internal UpdateTopicByTopicNameBuilder() { }





            public UpdateTopicByTopicName Build(
                ModelUpdateTopicRequest body,
                string namespace_,
                string topic
            )
            {
                UpdateTopicByTopicName op = new UpdateTopicByTopicName(this,
                    body,                    
                    namespace_,                    
                    topic                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateTopicByTopicName(UpdateTopicByTopicNameBuilder builder,
            ModelUpdateTopicRequest body,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateTopicByTopicName(
            string namespace_,            
            string topic,            
            Model.ModelUpdateTopicRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/topics/{topic}";

        public override HttpMethod Method => HttpMethod.Put;

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