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
    /// GetRecentPlayer
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:RECENTPLAYER [READ]
    /// 
    /// Required scope: social
    /// 
    /// Query recent player by user ID
    /// </summary>
    public class GetRecentPlayer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRecentPlayerBuilder Builder = new GetRecentPlayerBuilder();

        public class GetRecentPlayerBuilder
            : OperationBuilder<GetRecentPlayerBuilder>
        {
            
            
            internal GetRecentPlayerBuilder() { }






            public GetRecentPlayer Build(
                string namespace_,
                string userID
            )
            {
                GetRecentPlayer op = new GetRecentPlayer(this,
                    namespace_,                    
                    userID                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetRecentPlayer(GetRecentPlayerBuilder builder,
            string namespace_,
            string userID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRecentPlayer(
            string namespace_,            
            string userID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/recentplayer/{userID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsRecentPlayerQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}