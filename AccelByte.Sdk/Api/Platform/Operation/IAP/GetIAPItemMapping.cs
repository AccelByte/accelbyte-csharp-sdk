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
    /// getIAPItemMapping
    ///
    /// Get iap item mapping.
    /// </summary>
    public class GetIAPItemMapping : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetIAPItemMappingBuilder Builder { get => new GetIAPItemMappingBuilder(); }

        public class GetIAPItemMappingBuilder
            : OperationBuilder<GetIAPItemMappingBuilder>
        {

            public GetIAPItemMappingPlatform? Platform { get; set; }





            internal GetIAPItemMappingBuilder() { }


            public GetIAPItemMappingBuilder SetPlatform(GetIAPItemMappingPlatform _platform)
            {
                Platform = _platform;
                return this;
            }





            public GetIAPItemMapping Build(
                string namespace_
            )
            {
                GetIAPItemMapping op = new GetIAPItemMapping(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetIAPItemMapping(GetIAPItemMappingBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetIAPItemMapping(
            string namespace_,
            GetIAPItemMappingPlatform? platform
        )
        {
            PathParams["namespace"] = namespace_;

            if (platform is not null) QueryParams["platform"] = platform.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/iap/item/mapping";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.IAPItemMappingInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.IAPItemMappingInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.IAPItemMappingInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPItemMappingInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetIAPItemMappingPlatform : StringEnum<GetIAPItemMappingPlatform>
    {
        public static readonly GetIAPItemMappingPlatform APPLE
            = new GetIAPItemMappingPlatform("APPLE");

        public static readonly GetIAPItemMappingPlatform EPICGAMES
            = new GetIAPItemMappingPlatform("EPICGAMES");

        public static readonly GetIAPItemMappingPlatform GOOGLE
            = new GetIAPItemMappingPlatform("GOOGLE");

        public static readonly GetIAPItemMappingPlatform OCULUS
            = new GetIAPItemMappingPlatform("OCULUS");

        public static readonly GetIAPItemMappingPlatform PLAYSTATION
            = new GetIAPItemMappingPlatform("PLAYSTATION");

        public static readonly GetIAPItemMappingPlatform STADIA
            = new GetIAPItemMappingPlatform("STADIA");

        public static readonly GetIAPItemMappingPlatform STEAM
            = new GetIAPItemMappingPlatform("STEAM");

        public static readonly GetIAPItemMappingPlatform TWITCH
            = new GetIAPItemMappingPlatform("TWITCH");

        public static readonly GetIAPItemMappingPlatform XBOX
            = new GetIAPItemMappingPlatform("XBOX");


        public static implicit operator GetIAPItemMappingPlatform(string value)
        {
            return NewValue(value);
        }

        public GetIAPItemMappingPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}