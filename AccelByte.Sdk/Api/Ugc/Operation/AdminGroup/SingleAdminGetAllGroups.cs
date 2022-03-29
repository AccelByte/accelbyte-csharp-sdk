// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// SingleAdminGetAllGroups
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENTGROUP [READ].
    /// </summary>
    public class SingleAdminGetAllGroups : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminGetAllGroupsBuilder Builder = new SingleAdminGetAllGroupsBuilder();

        public class SingleAdminGetAllGroupsBuilder
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal SingleAdminGetAllGroupsBuilder() { }


            public SingleAdminGetAllGroupsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public SingleAdminGetAllGroupsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public SingleAdminGetAllGroups Build(
                string namespace_
            )
            {
                return new SingleAdminGetAllGroups(this,
                    namespace_                    
                );
            }
        }

        private SingleAdminGetAllGroups(SingleAdminGetAllGroupsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public SingleAdminGetAllGroups(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPaginatedGroupResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGroupResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGroupResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}