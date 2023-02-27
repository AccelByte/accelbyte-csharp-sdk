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
    /// bulkUpdateUserStatItem_1
    ///
    /// Public bulk update multiple user's statitems value with specific update strategy.
    /// There are four supported update strategies:
    /// + *OVERRIDE*: update user statitem with the new value
    /// + *INCREMENT*: increment user statitem with the specified value
    /// + *MAX*: update user statitem with the specified value if it's larger than the existing value
    /// + *MIN*: update user statitem with the specified value if it's lower than the existing value
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="NAMESPACE:{namespace}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkUpdateUserStatItem1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkUpdateUserStatItem1Builder Builder { get => new BulkUpdateUserStatItem1Builder(); }

        public class BulkUpdateUserStatItem1Builder
            : OperationBuilder<BulkUpdateUserStatItem1Builder>
        {


            public List<Model.BulkUserStatItemUpdate>? Body { get; set; }




            internal BulkUpdateUserStatItem1Builder() { }



            public BulkUpdateUserStatItem1Builder SetBody(List<Model.BulkUserStatItemUpdate> _body)
            {
                Body = _body;
                return this;
            }




            public BulkUpdateUserStatItem1 Build(
                string namespace_
            )
            {
                BulkUpdateUserStatItem1 op = new BulkUpdateUserStatItem1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkUpdateUserStatItem1(BulkUpdateUserStatItem1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkUpdateUserStatItem1(
            string namespace_,
            List<Model.BulkUserStatItemUpdate> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/public/namespaces/{namespace}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.BulkStatOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.BulkStatOperationResult<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}