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
    /// publicSyncPsnDlcInventory
    ///
    /// Synchronize with dlc entitlements in PSN Store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:USER:{userId}:DLC, action=4 (UPDATE)
    ///   *  Returns : result of synchronization
    /// </summary>
    public class PublicSyncPsnDlcInventory : AccelByte.Sdk.Core.Operation
    {
        public PublicSyncPsnDlcInventory(
            string namespace_,            
            string userId,            
            Model.PlayStationDLCSyncRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

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