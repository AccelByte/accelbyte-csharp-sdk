// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// publicBanTopicMembers
    ///
    /// Ban topic members in a group topic.
    /// </summary>
    public class PublicBanTopicMembers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBanTopicMembersBuilder Builder { get => new PublicBanTopicMembersBuilder(); }

        public class PublicBanTopicMembersBuilder
            : OperationBuilder<PublicBanTopicMembersBuilder>
        {





            internal PublicBanTopicMembersBuilder() { }






            public PublicBanTopicMembers Build(
                ModelsPublicBanTopicMembersRequest body,
                string namespace_,
                string topic
            )
            {
                PublicBanTopicMembers op = new PublicBanTopicMembers(this,
                    body,                    
                    namespace_,                    
                    topic                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicBanTopicMembers(PublicBanTopicMembersBuilder builder,
            ModelsPublicBanTopicMembersRequest body,
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

        public PublicBanTopicMembers(
            string namespace_,            
            string topic,            
            Model.ModelsPublicBanTopicMembersRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/public/namespaces/{namespace}/topic/{topic}/ban-members";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPublicBanTopicMembersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPublicBanTopicMembersResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPublicBanTopicMembersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicBanTopicMembersResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}