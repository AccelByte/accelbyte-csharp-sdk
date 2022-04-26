// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// DeleteSessionLocalDS
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// Only use for local DS entry, will error when calling non local DS entry
    /// </summary>
    public class DeleteSessionLocalDS : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSessionLocalDSBuilder Builder = new DeleteSessionLocalDSBuilder();

        public class DeleteSessionLocalDSBuilder
            : OperationBuilder<DeleteSessionLocalDSBuilder>
        {
            
            
            internal DeleteSessionLocalDSBuilder() { }






            public DeleteSessionLocalDS Build(
                string namespace_,
                string sessionID
            )
            {
                DeleteSessionLocalDS op = new DeleteSessionLocalDS(this,
                    namespace_,                    
                    sessionID                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteSessionLocalDS(DeleteSessionLocalDSBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSessionLocalDS(
            string namespace_,            
            string sessionID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/localds";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}