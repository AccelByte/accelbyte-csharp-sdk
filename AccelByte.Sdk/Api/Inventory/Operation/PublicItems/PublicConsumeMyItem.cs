// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// PublicConsumeMyItem
    ///
    /// 
    /// Consume user's own item.
    /// Client should pass item ID in options if item type is OPTIONBOX
    /// </summary>
    public class PublicConsumeMyItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicConsumeMyItemBuilder Builder { get => new PublicConsumeMyItemBuilder(); }

        public class PublicConsumeMyItemBuilder
            : OperationBuilder<PublicConsumeMyItemBuilder>
        {





            internal PublicConsumeMyItemBuilder() { }






            public PublicConsumeMyItem Build(
                ApimodelsConsumeItemReq body,
                string inventoryId,
                string namespace_
            )
            {
                PublicConsumeMyItem op = new PublicConsumeMyItem(this,
                    body,
                    inventoryId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicConsumeMyItem(PublicConsumeMyItemBuilder builder,
            ApimodelsConsumeItemReq body,
            string inventoryId,
            string namespace_
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicConsumeMyItem(
            string inventoryId,
            string namespace_,
            Model.ApimodelsConsumeItemReq body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/consume";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsItemResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsItemResp<T1, T2, T3>? ParseResponse<T1, T2, T3>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}