// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// deleteItemTypeConfig
    ///
    /// This API is used to delete an item type config permanently.Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:ITEM:CONFIG", action=8 (DELETE)
    /// </summary>
    public class DeleteItemTypeConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteItemTypeConfigBuilder Builder = new DeleteItemTypeConfigBuilder();

        public class DeleteItemTypeConfigBuilder
            : OperationBuilder<DeleteItemTypeConfigBuilder>
        {





            internal DeleteItemTypeConfigBuilder() { }






            public DeleteItemTypeConfig Build(
                string id
            )
            {
                DeleteItemTypeConfig op = new DeleteItemTypeConfig(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteItemTypeConfig(DeleteItemTypeConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteItemTypeConfig(
            string id            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/items/configs/{id}";

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