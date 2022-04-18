// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    /// <summary>
    /// checkServerLogs
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:LOG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will check log file existence before download file.
    /// </summary>
    public class CheckServerLogs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckServerLogsBuilder Builder = new CheckServerLogsBuilder();

        public class CheckServerLogsBuilder
            : OperationBuilder<CheckServerLogsBuilder>
        {
            
            
            internal CheckServerLogsBuilder() { }





            public CheckServerLogs Build(
                string namespace_,
                string podName
            )
            {
                CheckServerLogs op = new CheckServerLogs(this,
                    namespace_,                    
                    podName                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CheckServerLogs(CheckServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CheckServerLogs(
            string namespace_,            
            string podName            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/exists";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json","text/x-log" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsLogFileStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsLogFileStatus>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsLogFileStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}