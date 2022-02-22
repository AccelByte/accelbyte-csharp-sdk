// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetPublicEditHistory
    ///
    /// 
    /// 
    /// Available Type:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * email
    /// 
    /// 
    ///   * password
    /// 
    /// 
    ///   * displayname
    /// 
    /// 
    ///   * dateofbirth
    /// 
    /// 
    ///   * country
    /// 
    /// 
    ///   * language
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Requires a valid user access token
    /// </summary>
    public class GetPublicEditHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublicEditHistoryBuilder Builder = new GetPublicEditHistoryBuilder();

        public class GetPublicEditHistoryBuilder
        {
            
            
            public string? EndDate { get; set; }
            
            public double? Offset { get; set; }
            
            public double? PageSize { get; set; }
            
            public string? StartDate { get; set; }
            
            public string? Type { get; set; }
            
            internal GetPublicEditHistoryBuilder() { }


            public GetPublicEditHistoryBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public GetPublicEditHistoryBuilder SetOffset(double _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetPublicEditHistoryBuilder SetPageSize(double _pageSize)
            {
                PageSize = _pageSize;
                return this;
            }

            public GetPublicEditHistoryBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public GetPublicEditHistoryBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }




            public GetPublicEditHistory Build(
                string namespace_,
                string userId
            )
            {
                return new GetPublicEditHistory(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetPublicEditHistory(GetPublicEditHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EndDate != null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PageSize != null) QueryParams["pageSize"] = Convert.ToString(builder.PageSize)!;
            if (builder.StartDate != null) QueryParams["startDate"] = builder.StartDate;
            if (builder.Type != null) QueryParams["type"] = builder.Type;
            
            
            
            
        }
        #endregion

        public GetPublicEditHistory(
            string namespace_,            
            string userId,            
            string? endDate,            
            double? offset,            
            double? pageSize,            
            string? startDate,            
            string? type            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            if (type != null) QueryParams["type"] = type;
            
            
            
            
        }

        public override string Path => "/event/v2/public/namespaces/{namespace}/users/{userId}/edithistory";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}