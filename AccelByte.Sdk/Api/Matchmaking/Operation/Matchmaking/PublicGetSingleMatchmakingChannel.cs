// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// PublicGetSingleMatchmakingChannel
    ///
    /// Reads single channel based on namespace and channel name
    /// </summary>
    public class PublicGetSingleMatchmakingChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetSingleMatchmakingChannelBuilder Builder = new PublicGetSingleMatchmakingChannelBuilder();

        public class PublicGetSingleMatchmakingChannelBuilder
            : OperationBuilder<PublicGetSingleMatchmakingChannelBuilder>
        {
            
            
            internal PublicGetSingleMatchmakingChannelBuilder() { }





            public PublicGetSingleMatchmakingChannel Build(
                string channelName,
                string namespace_
            )
            {
                PublicGetSingleMatchmakingChannel op = new PublicGetSingleMatchmakingChannel(this,
                    channelName,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetSingleMatchmakingChannel(PublicGetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetSingleMatchmakingChannel(
            string channelName,            
            string namespace_            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/public/namespaces/{namespace}/channels/{channelName}";

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