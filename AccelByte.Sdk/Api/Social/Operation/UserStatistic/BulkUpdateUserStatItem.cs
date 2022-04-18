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
    /// bulkUpdateUserStatItem
    ///
    /// Bulk update user's statitems value for given namespace and user with specific update strategy.
    /// There are four supported update strategies:
    /// + *OVERRIDE*: update user statitem with the new value
    /// + *INCREMENT*: increment user statitem with the specified value
    /// + *MAX*: update user statitem with the specified value if it's larger than the existing value
    /// + *MIN*: update user statitem with the specified value if it's lower than the existing value
    /// 
    /// The *additionalKey* parameter will be suffixed to *userId* and is used to support multi level user's statitems, such as character's statitems.
    /// If provided, user's statitems will be saved with key: *userId_additionalKey*
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkUpdateUserStatItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkUpdateUserStatItemBuilder Builder = new BulkUpdateUserStatItemBuilder();

        public class BulkUpdateUserStatItemBuilder
            : OperationBuilder<BulkUpdateUserStatItemBuilder>
        {
            
            
            public string? AdditionalKey { get; set; }
            
            public List<Model.BulkStatItemUpdate>? Body { get; set; }
            
            internal BulkUpdateUserStatItemBuilder() { }


            public BulkUpdateUserStatItemBuilder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }


            public BulkUpdateUserStatItemBuilder SetBody(List<Model.BulkStatItemUpdate> _body)
            {
                Body = _body;
                return this;
            }



            public BulkUpdateUserStatItem Build(
                string namespace_,
                string userId
            )
            {
                BulkUpdateUserStatItem op = new BulkUpdateUserStatItem(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkUpdateUserStatItem(BulkUpdateUserStatItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AdditionalKey != null) QueryParams["additionalKey"] = builder.AdditionalKey;
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkUpdateUserStatItem(
            string namespace_,            
            string userId,            
            string? additionalKey,            
            List<Model.BulkStatItemUpdate> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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