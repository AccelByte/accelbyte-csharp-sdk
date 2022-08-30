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
    /// updateItemTypeConfig
    ///
    /// This API is used to update an item type config.
    /// 
    /// *  Required permission : resource="ADMIN:ITEM:CONFIG", action=4 (UPDATE)
    /// *  Returns : item type config data
    /// </summary>
    public class UpdateItemTypeConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateItemTypeConfigBuilder Builder = new UpdateItemTypeConfigBuilder();

        public class UpdateItemTypeConfigBuilder
            : OperationBuilder<UpdateItemTypeConfigBuilder>
        {


            public Model.ItemTypeConfigUpdate? Body { get; set; }




            internal UpdateItemTypeConfigBuilder() { }



            public UpdateItemTypeConfigBuilder SetBody(Model.ItemTypeConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateItemTypeConfig Build(
                string id
            )
            {
                UpdateItemTypeConfig op = new UpdateItemTypeConfig(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateItemTypeConfig(UpdateItemTypeConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateItemTypeConfig(
            string id,            
            Model.ItemTypeConfigUpdate body            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/items/configs/{id}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ItemTypeConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}