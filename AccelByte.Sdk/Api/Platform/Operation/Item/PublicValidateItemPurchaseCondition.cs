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
    /// publicValidateItemPurchaseCondition
    ///
    /// This API is used to validate user item purchase condition
    /// </summary>
    public class PublicValidateItemPurchaseCondition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicValidateItemPurchaseConditionBuilder Builder { get => new PublicValidateItemPurchaseConditionBuilder(); }

        public class PublicValidateItemPurchaseConditionBuilder
            : OperationBuilder<PublicValidateItemPurchaseConditionBuilder>
        {


            public Model.ItemPurchaseConditionValidateRequest? Body { get; set; }




            internal PublicValidateItemPurchaseConditionBuilder() { }



            public PublicValidateItemPurchaseConditionBuilder SetBody(Model.ItemPurchaseConditionValidateRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicValidateItemPurchaseCondition Build(
                string namespace_
            )
            {
                PublicValidateItemPurchaseCondition op = new PublicValidateItemPurchaseCondition(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicValidateItemPurchaseCondition(PublicValidateItemPurchaseConditionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicValidateItemPurchaseCondition(
            string namespace_,
            Model.ItemPurchaseConditionValidateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/purchase/conditions/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ItemPurchaseConditionValidateResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ItemPurchaseConditionValidateResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemPurchaseConditionValidateResult>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}