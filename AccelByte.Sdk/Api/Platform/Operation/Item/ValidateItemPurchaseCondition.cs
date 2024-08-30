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
    /// validateItemPurchaseCondition
    ///
    /// This API is used to validate user purchase condition
    /// </summary>
    public class ValidateItemPurchaseCondition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ValidateItemPurchaseConditionBuilder Builder { get => new ValidateItemPurchaseConditionBuilder(); }

        public class ValidateItemPurchaseConditionBuilder
            : OperationBuilder<ValidateItemPurchaseConditionBuilder>
        {

            public string? Platform { get; set; }





            internal ValidateItemPurchaseConditionBuilder() { }


            public ValidateItemPurchaseConditionBuilder SetPlatform(string _platform)
            {
                Platform = _platform;
                return this;
            }





            public ValidateItemPurchaseCondition Build(
                ItemPurchaseConditionValidateRequest body,
                string namespace_,
                string userId
            )
            {
                ValidateItemPurchaseCondition op = new ValidateItemPurchaseCondition(this,
                    body,
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

        private ValidateItemPurchaseCondition(ValidateItemPurchaseConditionBuilder builder,
            ItemPurchaseConditionValidateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform;
            if (userId is not null) QueryParams["userId"] = userId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ValidateItemPurchaseCondition(
            string namespace_,
            string? platform,
            string userId,
            Model.ItemPurchaseConditionValidateRequest body
        )
        {
            PathParams["namespace"] = namespace_;

            if (platform is not null) QueryParams["platform"] = platform;
            if (userId is not null) QueryParams["userId"] = userId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/purchase/conditions/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ItemPurchaseConditionValidateResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ItemPurchaseConditionValidateResult>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ItemPurchaseConditionValidateResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemPurchaseConditionValidateResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}