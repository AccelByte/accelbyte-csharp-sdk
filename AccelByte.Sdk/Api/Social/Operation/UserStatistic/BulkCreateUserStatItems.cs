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
    /// bulkCreateUserStatItems
    ///
    /// Bulk create user's statItems.
    /// Other detail info:
    ///           *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=1 (CREATE)
    ///           *  Returns : bulk created result
    /// </summary>
    public class BulkCreateUserStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkCreateUserStatItemsBuilder Builder = new BulkCreateUserStatItemsBuilder();

        public class BulkCreateUserStatItemsBuilder
            : OperationBuilder<BulkCreateUserStatItemsBuilder>
        {
            
            
            public List<Model.BulkStatItemCreate>? Body { get; set; }
            
            internal BulkCreateUserStatItemsBuilder() { }



            public BulkCreateUserStatItemsBuilder SetBody(List<Model.BulkStatItemCreate> _body)
            {
                Body = _body;
                return this;
            }



            public BulkCreateUserStatItems Build(
                string namespace_,
                string userId
            )
            {
                BulkCreateUserStatItems op = new BulkCreateUserStatItems(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkCreateUserStatItems(BulkCreateUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkCreateUserStatItems(
            string namespace_,            
            string userId,            
            List<Model.BulkStatItemCreate> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/bulk";

        public override HttpMethod Method => HttpMethod.Post;

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