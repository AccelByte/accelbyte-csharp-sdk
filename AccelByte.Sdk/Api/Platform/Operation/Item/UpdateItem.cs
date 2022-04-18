// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateItem
    ///
    /// This API is used to update an item.
    /// 
    /// An item update example:
    /// 
    /// 
    ///     {
    /// 
    ///         "categoryPath": "/games",
    /// 
    ///         "localizations": {
    /// 
    ///            "en": {
    /// 
    ///                "title":"required",
    /// 
    ///                "description":"optional",
    /// 
    ///                "longDescription":"optional",
    /// 
    ///                "localExt": {
    /// 
    ///                       "properties":[
    /// 
    ///                                        {
    /// 
    ///                                            "key1":"value1",
    /// 
    ///                                            "key2":"value2"
    /// 
    ///                                        }
    /// 
    ///                       ],
    /// 
    ///                       "functions":[
    /// 
    ///                                        {
    /// 
    ///                                            "key1":"value1",
    /// 
    ///                                            "key2":"value2"
    /// 
    ///                                        }
    /// 
    ///                      ]
    /// 
    ///                }
    /// 
    ///            }
    /// 
    ///        },
    /// 
    ///        "images": [
    /// 
    ///          {
    /// 
    ///                "as":"optional, image for",
    /// 
    ///                "caption":"optional",
    /// 
    ///                "height":10,
    /// 
    ///                "width":10,
    /// 
    ///                "imageUrl":"http://img-url-required",
    /// 
    ///                "smallImageUrl":"http://small-img-url-required"
    /// 
    ///          }
    /// 
    ///        ],
    /// 
    ///        "thumbnailUrl": "optional, thumbnail url",
    /// 
    ///        "status": "ACTIVE",
    /// 
    ///        "listable": true,
    /// 
    ///        "purchasable": true,
    /// 
    ///        "itemType": "APP(allowed: [APP,COINS,INGAMEITEM,CODE,BUNDLE])",
    /// 
    ///        "name": "optional",
    /// 
    ///        "entitlementType": "DURABLE(allowed:[DURABLE,CONSUMABLE], should be CONSUMABLE when item type is COINS)",
    /// 
    ///        "useCount": 1(optional, required if the entitlement type is consumable),
    /// 
    ///        "stackable": false,
    /// 
    ///        "appId": "optional, required if itemType is APP",
    /// 
    ///        "baseAppId": "optional, set value of game app id if you want to link to a game",
    /// 
    ///        "appType": "GAME(optional, required if itemType is APP)",
    /// 
    ///        "seasonType": "PASS(optional, required if itemType is SEASON)",
    /// 
    ///        "sku": "optional, commonly unique item code",
    /// 
    ///        "targetCurrencyCode": "optional, required if itemType is COINS",
    /// 
    ///        "targetNamespace": "optional, required when itemType is INGAMEITEM, the targetNamespace will only take effect when the item
    /// 
    ///        created belongs to the publisher namespace",
    /// 
    ///        "regionData": {
    /// 
    ///            "US(store's default region is required)": [
    /// 
    ///              {
    /// 
    ///                 "price":10,
    /// 
    ///                 "discountPercentage":0(integer, optional, range[0,100], discountedPrice = price*((100 - discountPercentage) * 0.01),
    /// 
    ///                   if it is not 0, will use it to calculate discounted price),
    /// 
    ///                 "discountAmount":0(integer, optional, range[0,itemPrice], will use it to calculate discounted price if discountPercentage is 0),
    /// 
    ///                 "currencyCode":"code(required, example: USD)",
    /// 
    ///                 "currencyNamespace":"test-ns-required(allow publisher namespace if namespace is publisher namespace, allow publisher and game namespace if namespace is not publisher namespace)",
    /// 
    ///                 "trialPrice":5(required while fixedTrialCycles set, should >=0 and <= price, will same as price if not present),
    /// 
    ///                 "purchaseAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'",
    /// 
    ///                 "expireAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'",
    /// 
    ///                 "discountPurchaseAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'",
    /// 
    ///                 "discountExpireAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'"
    /// 
    ///              }
    /// 
    ///            ]
    /// 
    ///        },
    /// 
    ///        "itemIds": [
    /// 
    ///            "itemId"
    /// 
    ///        ],
    /// 
    ///        "itemQty": {
    /// 
    ///            "itemId":1
    /// 
    ///        },
    /// 
    ///        "recurring": {
    /// 
    ///            "cycle":"MONTHLY(allowed: [WEEKLY,MONTHLY,QUARTERLY,YEARLY])",
    /// 
    ///            "fixedFreeDays":0(integer, fixed free days, 0 means not set),
    /// 
    ///            "fixedTrialCycles":0(integer, fixed trial cycles, 0 means not set, will not take effect if fixedFreeDays set),
    /// 
    ///            "graceDays":7(integer, recurring grace days, retry recurring charge within configured days if charge fail, default 7)
    /// 
    ///        },
    /// 
    ///        "tags": [
    /// 
    ///            "exampleTag24"
    /// 
    ///        ],
    /// 
    ///        "features": [
    /// 
    ///            "feature"
    /// 
    ///        ],
    /// 
    ///        "clazz": "weapon",
    /// 
    ///        "boothName": "C_campaign1",
    /// 
    ///        "displayOrder": 1000,
    /// 
    ///        "ext": {
    /// 
    ///            "properties":[
    /// 
    ///                {
    /// 
    ///                    "key1":"value1",
    /// 
    ///                    "key2":"value2"
    /// 
    ///                }
    /// 
    ///            ],
    /// 
    ///            "functions":[
    /// 
    ///                {
    /// 
    ///                    "key1":"value1",
    /// 
    ///                    "key2":"value2"
    /// 
    ///                }
    /// 
    ///            ]
    /// 
    ///        },
    /// 
    ///        "maxCountPerUser": 1(integer, optional, -1 means UNLIMITED),
    /// 
    ///        "maxCount": 1(integer, optional, -1 means UNLIMITED, new value should >= old value if both old value and new value is
    /// 
    ///        limited, unset when item type is CODE)
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=4 (UPDATE)
    ///   *  Returns : updated item data
    /// </summary>
    public class UpdateItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateItemBuilder Builder = new UpdateItemBuilder();

        public class UpdateItemBuilder
            : OperationBuilder<UpdateItemBuilder>
        {
            
            
            
            public Model.ItemUpdate? Body { get; set; }
            
            internal UpdateItemBuilder() { }



            public UpdateItemBuilder SetBody(Model.ItemUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdateItem Build(
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItem op = new UpdateItem(this,
                    itemId,                    
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateItem(UpdateItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateItem(
            string itemId,            
            string namespace_,            
            string storeId,            
            Model.ItemUpdate body            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.FullItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}