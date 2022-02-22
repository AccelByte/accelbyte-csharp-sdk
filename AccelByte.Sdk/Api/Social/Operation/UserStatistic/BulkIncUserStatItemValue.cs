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
    /// bulkIncUserStatItemValue
    ///
    /// Bulk update multiple user's statitems value.
    /// Other detail info:
    ///           *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STATITEM", action=4 (UPDATE)
    ///           *  Returns : bulk updated result
    /// </summary>
    public class BulkIncUserStatItemValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkIncUserStatItemValueBuilder Builder = new BulkIncUserStatItemValueBuilder();

        public class BulkIncUserStatItemValueBuilder
        {
            
            public List<Model.BulkUserStatItemInc>? Body { get; set; }
            
            internal BulkIncUserStatItemValueBuilder() { }



            public BulkIncUserStatItemValueBuilder SetBody(List<Model.BulkUserStatItemInc> _body)
            {
                Body = _body;
                return this;
            }



            public BulkIncUserStatItemValue Build(
                string namespace_
            )
            {
                return new BulkIncUserStatItemValue(this,
                    namespace_                    
                );
            }
        }

        private BulkIncUserStatItemValue(BulkIncUserStatItemValueBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public BulkIncUserStatItemValue(
            string namespace_,            
            List<Model.BulkUserStatItemInc> body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Patch;

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