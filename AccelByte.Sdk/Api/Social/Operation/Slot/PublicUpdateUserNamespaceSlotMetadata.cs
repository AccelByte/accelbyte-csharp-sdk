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
    /// publicUpdateUserNamespaceSlotMetadata
    ///
    /// Updates the slot metadata.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=4 (UPDATE)
    ///         *  Returns : updated slot
    /// </summary>
    public class PublicUpdateUserNamespaceSlotMetadata : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserNamespaceSlotMetadataBuilder Builder = new PublicUpdateUserNamespaceSlotMetadataBuilder();

        public class PublicUpdateUserNamespaceSlotMetadataBuilder
            : OperationBuilder<PublicUpdateUserNamespaceSlotMetadataBuilder>
        {
            
            
            
            public Model.SlotMetadataUpdate? Body { get; set; }
            
            internal PublicUpdateUserNamespaceSlotMetadataBuilder() { }



            public PublicUpdateUserNamespaceSlotMetadataBuilder SetBody(Model.SlotMetadataUpdate _body)
            {
                Body = _body;
                return this;
            }



            public PublicUpdateUserNamespaceSlotMetadata Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicUpdateUserNamespaceSlotMetadata op = new PublicUpdateUserNamespaceSlotMetadata(this,
                    namespace_,                    
                    slotId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUpdateUserNamespaceSlotMetadata(PublicUpdateUserNamespaceSlotMetadataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateUserNamespaceSlotMetadata(
            string namespace_,            
            string slotId,            
            string userId,            
            Model.SlotMetadataUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}/metadata";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.SlotInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}