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
    /// updateApp
    ///
    /// This API is used to update an app.
    /// 
    /// An app update example:
    /// 
    /// 
    ///     {
    /// 
    ///       "developer": "accelbyte",
    /// 
    ///       "publisher": "accelbyte",
    /// 
    ///       "websiteUrl": "http://accelbyte.io",
    /// 
    ///       "forumUrl": "http://accelbyte.io",
    /// 
    ///       "platforms": ["Windows(allowed values: Windows, MacOS, Linux, IOS, Android)"],
    /// 
    ///       "platformRequirements": {
    /// 
    ///         "Windows": [
    /// 
    ///           {
    /// 
    ///             "label":"minimum(can be minimum or recommended)",
    /// 
    ///             "osVersion":"os version",
    /// 
    ///             "processor":"processor",
    /// 
    ///             "ram":"RAM",
    /// 
    ///             "graphics":"graphics",
    /// 
    ///             "directXVersion":"directXVersion",
    /// 
    ///             "diskSpace":"diskSpace",
    /// 
    ///             "soundCard":"soundCard",
    /// 
    ///             "additionals":"additionals"
    /// 
    ///           }
    /// 
    ///          ]
    /// 
    ///       },
    /// 
    ///       "carousel": [
    /// 
    ///         {
    /// 
    ///           "type":"image(allowed values: image, video)",
    /// 
    ///           "videoSource":"generic(allowed values:generic, youtube, viemo)",
    /// 
    ///           "url":"url",
    /// 
    ///           "alt":"alternative url or text",
    /// 
    ///           "thumbnailUrl":"thumbnail url",
    /// 
    ///           "previewUrl":"preview url",
    /// 
    ///         }
    /// 
    ///       ],
    /// 
    ///       "localizations": {
    /// 
    ///         "en": {
    /// 
    ///           "slogan":"slogan",
    /// 
    ///           "announcement":"announcement",
    /// 
    ///         }
    /// 
    ///       },
    /// 
    ///       "primaryGenre": "Action",
    /// 
    ///       "genres": ["Action", "Adventure"],
    /// 
    ///       "players": ["Single"],
    /// 
    ///       "releaseDate": "optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'"
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : updated app data
    /// </summary>
    public class UpdateApp : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppBuilder Builder { get => new UpdateAppBuilder(); }

        public class UpdateAppBuilder
            : OperationBuilder<UpdateAppBuilder>
        {





            internal UpdateAppBuilder() { }






            public UpdateApp Build(
                AppUpdate body,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateApp op = new UpdateApp(this,
                    body,
                    itemId,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateApp(UpdateAppBuilder builder,
            AppUpdate body,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateApp(
            string itemId,
            string namespace_,
            string storeId,
            Model.AppUpdate body
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/app";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FullAppInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.FullAppInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.FullAppInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullAppInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}