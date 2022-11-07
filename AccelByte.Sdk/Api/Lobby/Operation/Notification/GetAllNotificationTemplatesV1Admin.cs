// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getAllNotificationTemplatesV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [READ]` with scope `social`
    /// 
    /// Get all templates in a namespace
    /// 
    /// Action Code: 50203
    /// </summary>
    public class GetAllNotificationTemplatesV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllNotificationTemplatesV1AdminBuilder Builder = new GetAllNotificationTemplatesV1AdminBuilder();

        public class GetAllNotificationTemplatesV1AdminBuilder
            : OperationBuilder<GetAllNotificationTemplatesV1AdminBuilder>
        {





            internal GetAllNotificationTemplatesV1AdminBuilder() { }






            public GetAllNotificationTemplatesV1Admin Build(
                string namespace_
            )
            {
                GetAllNotificationTemplatesV1Admin op = new GetAllNotificationTemplatesV1Admin(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetAllNotificationTemplatesV1Admin(GetAllNotificationTemplatesV1AdminBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllNotificationTemplatesV1Admin(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelNotificationTemplateResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelNotificationTemplateResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelNotificationTemplateResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}