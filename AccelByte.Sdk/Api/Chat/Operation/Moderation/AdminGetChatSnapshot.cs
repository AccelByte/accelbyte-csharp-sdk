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
    /// adminGetChatSnapshot
    ///
    /// Get the chat snapshot
    /// </summary>
    public class AdminGetChatSnapshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetChatSnapshotBuilder Builder { get => new AdminGetChatSnapshotBuilder(); }

        public class AdminGetChatSnapshotBuilder
            : OperationBuilder<AdminGetChatSnapshotBuilder>
        {





            internal AdminGetChatSnapshotBuilder() { }






            public AdminGetChatSnapshot Build(
                string chatId,
                string namespace_
            )
            {
                AdminGetChatSnapshot op = new AdminGetChatSnapshot(this,
                    chatId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetChatSnapshot(AdminGetChatSnapshotBuilder builder,
            string chatId,
            string namespace_
        )
        {
            PathParams["chatId"] = chatId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetChatSnapshot(
            string chatId,            
            string namespace_            
        )
        {
            PathParams["chatId"] = chatId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/namespaces/{namespace}/snapshot/{chatId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsChatSnapshots? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsChatSnapshots>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsChatSnapshots>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChatSnapshots>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}