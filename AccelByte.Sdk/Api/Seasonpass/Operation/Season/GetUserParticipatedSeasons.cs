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
    /// getUserParticipatedSeasons
    ///
    /// This API is used to get user participated season data, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : user participated season data
    /// </summary>
    public class GetUserParticipatedSeasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserParticipatedSeasonsBuilder Builder = new GetUserParticipatedSeasonsBuilder();

        public class GetUserParticipatedSeasonsBuilder
            : OperationBuilder<GetUserParticipatedSeasonsBuilder>
        {
            
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            internal GetUserParticipatedSeasonsBuilder() { }


            public GetUserParticipatedSeasonsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserParticipatedSeasonsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetUserParticipatedSeasons Build(
                string namespace_,
                string userId
            )
            {
                GetUserParticipatedSeasons op = new GetUserParticipatedSeasons(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserParticipatedSeasons(GetUserParticipatedSeasonsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserParticipatedSeasons(
            string namespace_,            
            string userId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ListUserSeasonInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ListUserSeasonInfoPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ListUserSeasonInfoPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}