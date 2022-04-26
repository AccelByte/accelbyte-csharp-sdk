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
    /// batchDownloadServerLogs
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:LOG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will download dedicated server's log file (.zip).
    /// </summary>
    public class BatchDownloadServerLogs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BatchDownloadServerLogsBuilder Builder = new BatchDownloadServerLogsBuilder();

        public class BatchDownloadServerLogsBuilder
            : OperationBuilder<BatchDownloadServerLogsBuilder>
        {
            
            internal BatchDownloadServerLogsBuilder() { }






            public BatchDownloadServerLogs Build(
                ModelsBatchDownloadLogsRequest body
            )
            {
                BatchDownloadServerLogs op = new BatchDownloadServerLogs(this,
                    body                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BatchDownloadServerLogs(BatchDownloadServerLogsBuilder builder,
            ModelsBatchDownloadLogsRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BatchDownloadServerLogs(
            Model.ModelsBatchDownloadLogsRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/servers/logs/download";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}