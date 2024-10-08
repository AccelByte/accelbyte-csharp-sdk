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
    /// updateView
    ///
    /// This API is used to update a view.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : updated view data
    /// 
    /// 
    /// 
    /// ## Restrictions for localization extension
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class UpdateView : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateViewBuilder Builder { get => new UpdateViewBuilder(); }

        public class UpdateViewBuilder
            : OperationBuilder<UpdateViewBuilder>
        {





            internal UpdateViewBuilder() { }






            public UpdateView Build(
                ViewUpdate body,
                string namespace_,
                string viewId,
                string storeId
            )
            {
                UpdateView op = new UpdateView(this,
                    body,
                    namespace_,
                    viewId,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateView(UpdateViewBuilder builder,
            ViewUpdate body,
            string namespace_,
            string viewId,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["viewId"] = viewId;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateView(
            string namespace_,
            string viewId,
            string storeId,
            Model.ViewUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["viewId"] = viewId;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/views/{viewId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FullViewInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.FullViewInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.FullViewInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}