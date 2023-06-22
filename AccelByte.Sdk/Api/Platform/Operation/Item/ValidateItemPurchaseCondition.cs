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


            public Model.ItemPurchaseConditionValidateRequest? Body { get; set; }




            internal ValidateItemPurchaseConditionBuilder() { }



            public ValidateItemPurchaseConditionBuilder SetBody(Model.ItemPurchaseConditionValidateRequest _body)
            {
                Body = _body;
                return this;
            }




            public ValidateItemPurchaseCondition Build(
                string namespace_,
                string userId
            )
            {
                ValidateItemPurchaseCondition op = new ValidateItemPurchaseCondition(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private ValidateItemPurchaseCondition(ValidateItemPurchaseConditionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (userId is not null) QueryParams["userId"] = userId;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ValidateItemPurchaseCondition(
            string namespace_,
            string userId,
            Model.ItemPurchaseConditionValidateRequest body
        )
        {
            PathParams["namespace"] = namespace_;

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