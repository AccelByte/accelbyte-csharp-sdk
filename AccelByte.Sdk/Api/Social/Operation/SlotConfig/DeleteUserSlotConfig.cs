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
    /// deleteUserSlotConfig
    ///
    /// Deletes a user slot configuration in given namespace, the namespace slot configuration will be returned after delete.
    /// Other detail info:
    ///       *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SLOTCONFIG", action=8 (DELETE)
    /// </summary>
    public class DeleteUserSlotConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserSlotConfigBuilder Builder = new DeleteUserSlotConfigBuilder();

        public class DeleteUserSlotConfigBuilder
            : OperationBuilder<DeleteUserSlotConfigBuilder>
        {
            
            
            internal DeleteUserSlotConfigBuilder() { }





            public DeleteUserSlotConfig Build(
                string namespace_,
                string userId
            )
            {
                DeleteUserSlotConfig op = new DeleteUserSlotConfig(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteUserSlotConfig(DeleteUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserSlotConfig(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/config";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

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