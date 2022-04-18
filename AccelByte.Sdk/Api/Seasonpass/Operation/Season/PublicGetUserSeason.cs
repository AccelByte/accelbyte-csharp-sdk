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
    /// publicGetUserSeason
    ///
    /// This API is used to get user season data, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : user season data
    /// </summary>
    public class PublicGetUserSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserSeasonBuilder Builder = new PublicGetUserSeasonBuilder();

        public class PublicGetUserSeasonBuilder
            : OperationBuilder<PublicGetUserSeasonBuilder>
        {
            
            
            
            internal PublicGetUserSeasonBuilder() { }





            public PublicGetUserSeason Build(
                string namespace_,
                string seasonId,
                string userId
            )
            {
                PublicGetUserSeason op = new PublicGetUserSeason(this,
                    namespace_,                    
                    seasonId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserSeason(PublicGetUserSeasonBuilder builder,
            string namespace_,
            string seasonId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserSeason(
            string namespace_,            
            string seasonId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ClaimableUserSeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}