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
    /// PublicMoveMyItems
    ///
    /// 
    /// Move items between inventories that is owned by the same user.
    /// </summary>
    public class PublicMoveMyItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicMoveMyItemsBuilder Builder { get => new PublicMoveMyItemsBuilder(); }

        public class PublicMoveMyItemsBuilder
            : OperationBuilder<PublicMoveMyItemsBuilder>
        {





            internal PublicMoveMyItemsBuilder() { }






            public PublicMoveMyItems Build(
                ApimodelsMoveItemsReq body,
                string inventoryId,
                string namespace_
            )
            {
                PublicMoveMyItems op = new PublicMoveMyItems(this,
                    body,
                    inventoryId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicMoveMyItems(PublicMoveMyItemsBuilder builder,
            ApimodelsMoveItemsReq body,
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

        public PublicMoveMyItems(
            string inventoryId,
            string namespace_,
            Model.ApimodelsMoveItemsReq body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items/movement";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsMoveItemsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsMoveItemsResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsMoveItemsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsMoveItemsResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}