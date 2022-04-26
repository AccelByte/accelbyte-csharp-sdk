// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicDeleteUserNamespaceSlot
    ///
    /// Deletes the slot.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=8 (DELETE)
    /// </summary>
    public class PublicDeleteUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeleteUserNamespaceSlotBuilder Builder = new PublicDeleteUserNamespaceSlotBuilder();

        public class PublicDeleteUserNamespaceSlotBuilder
            : OperationBuilder<PublicDeleteUserNamespaceSlotBuilder>
        {
            
            
            
            internal PublicDeleteUserNamespaceSlotBuilder() { }






            public PublicDeleteUserNamespaceSlot Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicDeleteUserNamespaceSlot op = new PublicDeleteUserNamespaceSlot(this,
                    namespace_,                    
                    slotId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicDeleteUserNamespaceSlot(PublicDeleteUserNamespaceSlotBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeleteUserNamespaceSlot(
            string namespace_,            
            string slotId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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