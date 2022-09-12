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
    /// bulkResetUserStatItem
    ///
    /// Bulk reset multiple user's statitems value.
    /// User's statitem value will be reset to the default value defined in the statistic configuration.
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkResetUserStatItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkResetUserStatItemBuilder Builder = new BulkResetUserStatItemBuilder();

        public class BulkResetUserStatItemBuilder
            : OperationBuilder<BulkResetUserStatItemBuilder>
        {


            public List<Model.BulkUserStatItemReset>? Body { get; set; }




            internal BulkResetUserStatItemBuilder() { }



            public BulkResetUserStatItemBuilder SetBody(List<Model.BulkUserStatItemReset> _body)
            {
                Body = _body;
                return this;
            }




            public BulkResetUserStatItem Build(
                string namespace_
            )
            {
                BulkResetUserStatItem op = new BulkResetUserStatItem(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkResetUserStatItem(BulkResetUserStatItemBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkResetUserStatItem(
            string namespace_,
            List<Model.BulkUserStatItemReset> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statitems/value/reset/bulk";

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