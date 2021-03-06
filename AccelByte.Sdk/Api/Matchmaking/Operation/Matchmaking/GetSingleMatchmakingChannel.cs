// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetSingleMatchmakingChannel
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Reads single channel based on namespace and channel name
    /// 
    /// Action Code: 510112
    /// </summary>
    public class GetSingleMatchmakingChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleMatchmakingChannelBuilder Builder = new GetSingleMatchmakingChannelBuilder();

        public class GetSingleMatchmakingChannelBuilder
            : OperationBuilder<GetSingleMatchmakingChannelBuilder>
        {





            internal GetSingleMatchmakingChannelBuilder() { }






            public GetSingleMatchmakingChannel Build(
                string channelName,
                string namespace_
            )
            {
                GetSingleMatchmakingChannel op = new GetSingleMatchmakingChannel(this,
                    channelName,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSingleMatchmakingChannel(GetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSingleMatchmakingChannel(
            string channelName,            
            string namespace_            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsChannelV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}