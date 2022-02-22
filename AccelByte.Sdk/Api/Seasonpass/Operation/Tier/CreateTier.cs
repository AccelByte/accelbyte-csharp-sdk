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
    /// createTier
    ///
    /// This API is used to create tier for a draft season, can create multiple tiers at same time.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=1 (CREATE)
    /// </summary>
    public class CreateTier : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateTierBuilder Builder = new CreateTierBuilder();

        public class CreateTierBuilder
        {
            
            
            public Model.TierCreate? Body { get; set; }
            
            internal CreateTierBuilder() { }



            public CreateTierBuilder SetBody(Model.TierCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateTier Build(
                string namespace_,
                string seasonId
            )
            {
                return new CreateTier(this,
                    namespace_,                    
                    seasonId                    
                );
            }
        }

        private CreateTier(CreateTierBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateTier(
            string namespace_,            
            string seasonId,            
            Model.TierCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.Tier>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.Tier>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.Tier>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}