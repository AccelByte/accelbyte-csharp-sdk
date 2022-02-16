// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// processUserSubscriptionNotification
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used as a web hook for payment notification from justice payment service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=4 (UPDATE)
    ///   *  Returns : Process result
    /// </summary>
    public class ProcessUserSubscriptionNotification : AccelByte.Sdk.Core.Operation
    {
        public ProcessUserSubscriptionNotification(
            string namespace_,            
            string subscriptionId,            
            string userId,            
            Model.TradeNotification body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/notifications";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}