// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getOrder
    ///
    /// Get order by orderNo.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ORDER", action=2 (READ)
    ///   *  Returns : order instance
    /// </summary>
    public class GetOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetOrderBuilder Builder = new GetOrderBuilder();

        public class GetOrderBuilder
            : OperationBuilder<GetOrderBuilder>
        {





            internal GetOrderBuilder() { }






            public GetOrder Build(
                string namespace_,
                string orderNo
            )
            {
                GetOrder op = new GetOrder(this,
                    namespace_,
                    orderNo
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetOrder(GetOrderBuilder builder,
            string namespace_,
            string orderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetOrder(
            string namespace_,
            string orderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/orders/{orderNo}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}