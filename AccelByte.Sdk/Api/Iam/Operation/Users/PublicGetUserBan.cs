// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetUserBan
    /// </summary>
    public class PublicGetUserBan : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserBanBuilder Builder = new PublicGetUserBanBuilder();

        public class PublicGetUserBanBuilder
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            internal PublicGetUserBanBuilder() { }


            public PublicGetUserBanBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }




            public PublicGetUserBan Build(
                string namespace_,
                string userId
            )
            {
                return new PublicGetUserBan(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicGetUserBan(PublicGetUserBanBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            
            
            
            
        }
        #endregion

        public PublicGetUserBan(
            string namespace_,            
            string userId,            
            bool? activeOnly            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            
            
            
            
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelUserBanResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserBanResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserBanResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}