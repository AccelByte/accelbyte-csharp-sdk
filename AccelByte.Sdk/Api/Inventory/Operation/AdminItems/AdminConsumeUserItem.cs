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
    /// AdminConsumeUserItem
    ///
    /// 
    /// Consume user's own item
    /// Client should pass item ID in options if item type is OPTIONBOX
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [UPDATE]
    /// </summary>
    public class AdminConsumeUserItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminConsumeUserItemBuilder Builder { get => new AdminConsumeUserItemBuilder(); }

        public class AdminConsumeUserItemBuilder
            : OperationBuilder<AdminConsumeUserItemBuilder>
        {

            public string? DateRangeValidation { get; set; }





            internal AdminConsumeUserItemBuilder() { }


            public AdminConsumeUserItemBuilder SetDateRangeValidation(string _dateRangeValidation)
            {
                DateRangeValidation = _dateRangeValidation;
                return this;
            }





            public AdminConsumeUserItem Build(
                ApimodelsConsumeItemReq body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminConsumeUserItem op = new AdminConsumeUserItem(this,
                    body,
                    inventoryId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminConsumeUserItem(AdminConsumeUserItemBuilder builder,
            ApimodelsConsumeItemReq body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.DateRangeValidation is not null) QueryParams["dateRangeValidation"] = builder.DateRangeValidation;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminConsumeUserItem(
            string inventoryId,
            string namespace_,
            string userId,
            string? dateRangeValidation,
            Model.ApimodelsConsumeItemReq body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (dateRangeValidation is not null) QueryParams["dateRangeValidation"] = dateRangeValidation;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/consume";

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