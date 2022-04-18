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
    /// GetTotalActiveSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// </summary>
    public class GetTotalActiveSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetTotalActiveSessionBuilder Builder = new GetTotalActiveSessionBuilder();

        public class GetTotalActiveSessionBuilder
            : OperationBuilder<GetTotalActiveSessionBuilder>
        {
            
            public string? SessionType { get; set; }
            
            internal GetTotalActiveSessionBuilder() { }


            public GetTotalActiveSessionBuilder SetSessionType(string _sessionType)
            {
                SessionType = _sessionType;
                return this;
            }




            public GetTotalActiveSession Build(
                string namespace_
            )
            {
                GetTotalActiveSession op = new GetTotalActiveSession(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetTotalActiveSession(GetTotalActiveSessionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.SessionType != null) QueryParams["session_type"] = builder.SessionType;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetTotalActiveSession(
            string namespace_,            
            string? sessionType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (sessionType != null) QueryParams["session_type"] = sessionType;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/count";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsCountActiveSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountActiveSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountActiveSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}