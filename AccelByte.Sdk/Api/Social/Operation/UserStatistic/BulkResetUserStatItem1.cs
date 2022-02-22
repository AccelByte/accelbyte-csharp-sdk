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
    /// bulkResetUserStatItem_1
    ///
    /// Bulk reset user's statitems value for given namespace and user.
    /// Other detail info:
    /// + *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkResetUserStatItem1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkResetUserStatItem1Builder Builder = new BulkResetUserStatItem1Builder();

        public class BulkResetUserStatItem1Builder
        {
            
            
            public List<Model.BulkStatItemReset>? Body { get; set; }
            
            internal BulkResetUserStatItem1Builder() { }



            public BulkResetUserStatItem1Builder SetBody(List<Model.BulkStatItemReset> _body)
            {
                Body = _body;
                return this;
            }



            public BulkResetUserStatItem1 Build(
                string namespace_,
                string userId
            )
            {
                return new BulkResetUserStatItem1(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private BulkResetUserStatItem1(BulkResetUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public BulkResetUserStatItem1(
            string namespace_,            
            string userId,            
            List<Model.BulkStatItemReset> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.BulkStatItemOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatItemOperationResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatItemOperationResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}