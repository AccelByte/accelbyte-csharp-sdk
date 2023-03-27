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
    /// listBasicItemsByFeatures
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used to list basic items by features.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of basic items
    /// </summary>
    public class ListBasicItemsByFeatures : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListBasicItemsByFeaturesBuilder Builder { get => new ListBasicItemsByFeaturesBuilder(); }

        public class ListBasicItemsByFeaturesBuilder
            : OperationBuilder<ListBasicItemsByFeaturesBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public List<string>? Features { get; set; }





            internal ListBasicItemsByFeaturesBuilder() { }


            public ListBasicItemsByFeaturesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public ListBasicItemsByFeaturesBuilder SetFeatures(List<string> _features)
            {
                Features = _features;
                return this;
            }





            public ListBasicItemsByFeatures Build(
                string namespace_
            )
            {
                ListBasicItemsByFeatures op = new ListBasicItemsByFeatures(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListBasicItemsByFeatures(ListBasicItemsByFeaturesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Features is not null) QueryParams["features"] = builder.Features;
            

            
            CollectionFormatMap["features"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListBasicItemsByFeatures(
            string namespace_,            
            bool? activeOnly,            
            List<string>? features            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (features is not null) QueryParams["features"] = features;
            

            
            CollectionFormatMap["features"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byFeatures/basic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.BasicItem>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BasicItem>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BasicItem>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}