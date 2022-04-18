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
        #region Builder Part
        public static PublicSyncPsnDlcInventoryBuilder Builder = new PublicSyncPsnDlcInventoryBuilder();

        public class PublicSyncPsnDlcInventoryBuilder
            : OperationBuilder<PublicSyncPsnDlcInventoryBuilder>
        {
            
            
            public Model.PlayStationDLCSyncRequest? Body { get; set; }
            
            internal PublicSyncPsnDlcInventoryBuilder() { }



            public PublicSyncPsnDlcInventoryBuilder SetBody(Model.PlayStationDLCSyncRequest _body)
            {
                Body = _body;
                return this;
            }



            public PublicSyncPsnDlcInventory Build(
                string namespace_,
                string userId
            )
            {
                PublicSyncPsnDlcInventory op = new PublicSyncPsnDlcInventory(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicSyncPsnDlcInventory(PublicSyncPsnDlcInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSyncPsnDlcInventory(
            string namespace_,            
            string userId,            
            Model.PlayStationDLCSyncRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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