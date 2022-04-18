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
    /// AdminSearchUserV3
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER [READ]
    /// 
    /// 
    /// 
    /// 
    /// Endpoint behavior :
    /// 
    ///           * by default this endpoint searches all users on the specified namespace
    /// 
    /// 
    ///           * if query parameter is defined, endpoint will search users whose email address, display name, username, or third party partially match with the query
    /// 
    /// 
    ///           * if startDate and endDate parameters is defined, endpoint will search users which created on the certain date range
    /// 
    /// 
    ///           * if query, startDate and endDate parameters are defined, endpoint will search users whose email address and display name match and created on the certain date range
    /// 
    /// 
    ///           * if startDate parameter is defined, endpoint will search users that created start from the defined date
    /// 
    /// 
    ///           * if endDate parameter is defined, endpoint will search users that created until the defined date
    /// 
    /// 
    ///           * if platformId parameter is defined and by parameter is using thirdparty, endpoint will search users based on the platformId they have linked to
    /// 
    /// 
    ///           * if platformBy parameter is defined and by parameter is using thirdparty, endpoint will search users based on the platformUserId or platformDisplayName they have linked to, example value: platformUserId or platformDisplayName
    /// 
    /// 
    ///           * if limit is not defined, The default limit is 100
    /// 
    /// 
    /// 
    /// 
    /// 
    /// action code : 10133
    /// </summary>
    public class AdminSearchUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSearchUserV3Builder Builder = new AdminSearchUserV3Builder();

        public class AdminSearchUserV3Builder
            : OperationBuilder<AdminSearchUserV3Builder>
        {
            
            public string? By { get; set; }
            
            public string? EndDate { get; set; }
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            public string? PlatformBy { get; set; }
            
            public string? PlatformId { get; set; }
            
            public string? Query { get; set; }
            
            public string? StartDate { get; set; }
            
            internal AdminSearchUserV3Builder() { }


            public AdminSearchUserV3Builder SetBy(string _by)
            {
                By = _by;
                return this;
            }

            public AdminSearchUserV3Builder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminSearchUserV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminSearchUserV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminSearchUserV3Builder SetPlatformBy(string _platformBy)
            {
                PlatformBy = _platformBy;
                return this;
            }

            public AdminSearchUserV3Builder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }

            public AdminSearchUserV3Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }

            public AdminSearchUserV3Builder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }




            public AdminSearchUserV3 Build(
                string namespace_
            )
            {
                AdminSearchUserV3 op = new AdminSearchUserV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminSearchUserV3(AdminSearchUserV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.By != null) QueryParams["by"] = builder.By;
            if (builder.EndDate != null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PlatformBy != null) QueryParams["platformBy"] = builder.PlatformBy;
            if (builder.PlatformId != null) QueryParams["platformId"] = builder.PlatformId;
            if (builder.Query != null) QueryParams["query"] = builder.Query;
            if (builder.StartDate != null) QueryParams["startDate"] = builder.StartDate;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSearchUserV3(
            string namespace_,            
            string? by,            
            string? endDate,            
            long? limit,            
            long? offset,            
            string? platformBy,            
            string? platformId,            
            string? query,            
            string? startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (by != null) QueryParams["by"] = by;
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (platformBy != null) QueryParams["platformBy"] = platformBy;
            if (platformId != null) QueryParams["platformId"] = platformId;
            if (query != null) QueryParams["query"] = query;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelSearchUsersResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}