// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkFetchStatItems_1
    ///
    /// Public bulk fetch multiple user's statitem value for a given namespace and statCode.
    /// Other detail info:
    /// + *Required permission*: resource="NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    /// + *Returns*: list of user's statItem
    /// </summary>
    public class BulkFetchStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkFetchStatItems1Builder Builder = new BulkFetchStatItems1Builder();

        public class BulkFetchStatItems1Builder
        {
            
            
            
            internal BulkFetchStatItems1Builder() { }





            public BulkFetchStatItems1 Build(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                return new BulkFetchStatItems1(this,
                    namespace_,                    
                    statCode,                    
                    userIds                    
                );
            }
        }

        private BulkFetchStatItems1(BulkFetchStatItems1Builder builder,
            string namespace_,
            string statCode,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (statCode != null) QueryParams["statCode"] = statCode;
            if (userIds != null) QueryParams["userIds"] = userIds;
            
            
            
            
        }
        #endregion

        public BulkFetchStatItems1(
            string namespace_,            
            string statCode,            
            string userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (statCode != null) QueryParams["statCode"] = statCode;
            if (userIds != null) QueryParams["userIds"] = userIds;
            
            
            
            
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statitems/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.UserStatItemInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserStatItemInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserStatItemInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}