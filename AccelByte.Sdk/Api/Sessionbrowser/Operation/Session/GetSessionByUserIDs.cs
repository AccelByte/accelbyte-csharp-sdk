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
    /// GetSessionByUserIDs
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// Query game sessions by comma separated user ids
    /// </summary>
    public class GetSessionByUserIDs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSessionByUserIDsBuilder Builder = new GetSessionByUserIDsBuilder();

        public class GetSessionByUserIDsBuilder
            : OperationBuilder<GetSessionByUserIDsBuilder>
        {
            
            
            internal GetSessionByUserIDsBuilder() { }






            public GetSessionByUserIDs Build(
                string namespace_,
                string userIds
            )
            {
                GetSessionByUserIDs op = new GetSessionByUserIDs(this,
                    namespace_,                    
                    userIds                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSessionByUserIDs(GetSessionByUserIDsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userIds != null) QueryParams["user_ids"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSessionByUserIDs(
            string namespace_,            
            string userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userIds != null) QueryParams["user_ids"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsSessionByUserIDsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionByUserIDsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionByUserIDsResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}