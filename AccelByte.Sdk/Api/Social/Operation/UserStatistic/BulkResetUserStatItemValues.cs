// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkResetUserStatItemValues
    ///
    /// Bulk reset user's statitem values for given namespace and user.
    /// Other detail info:
    /// + *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkResetUserStatItemValues : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkResetUserStatItemValuesBuilder Builder = new BulkResetUserStatItemValuesBuilder();

        public class BulkResetUserStatItemValuesBuilder
            : OperationBuilder<BulkResetUserStatItemValuesBuilder>
        {

            public string? AdditionalKey { get; set; }


            public List<Model.ADTOObjectForResettingUserStatItems>? Body { get; set; }




            internal BulkResetUserStatItemValuesBuilder() { }


            public BulkResetUserStatItemValuesBuilder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }


            public BulkResetUserStatItemValuesBuilder SetBody(List<Model.ADTOObjectForResettingUserStatItems> _body)
            {
                Body = _body;
                return this;
            }




            public BulkResetUserStatItemValues Build(
                string namespace_,
                string userId
            )
            {
                BulkResetUserStatItemValues op = new BulkResetUserStatItemValues(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkResetUserStatItemValues(BulkResetUserStatItemValuesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkResetUserStatItemValues(
            string namespace_,            
            string userId,            
            string? additionalKey,            
            List<Model.ADTOObjectForResettingUserStatItems> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk";

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