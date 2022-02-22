// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// checkSeasonPurchasable
    ///
    /// This API is used to check pass or tier purchasable, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    /// </summary>
    public class CheckSeasonPurchasable : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckSeasonPurchasableBuilder Builder = new CheckSeasonPurchasableBuilder();

        public class CheckSeasonPurchasableBuilder
        {
            
            
            public Model.UserPurchasable? Body { get; set; }
            
            internal CheckSeasonPurchasableBuilder() { }



            public CheckSeasonPurchasableBuilder SetBody(Model.UserPurchasable _body)
            {
                Body = _body;
                return this;
            }



            public CheckSeasonPurchasable Build(
                string namespace_,
                string userId
            )
            {
                return new CheckSeasonPurchasable(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private CheckSeasonPurchasable(CheckSeasonPurchasableBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CheckSeasonPurchasable(
            string namespace_,            
            string userId,            
            Model.UserPurchasable body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/purchasable";

        public override HttpMethod Method => HttpMethod.Post;

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