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
    /// geDLCDurableRewardShortMap
    ///
    /// Get dlc reward simple map, only return the sku of durable item reward
    /// Other detail info:
    /// 
    ///   * Required permission : Authorized user
    /// </summary>
    public class GeDLCDurableRewardShortMap : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GeDLCDurableRewardShortMapBuilder Builder { get => new GeDLCDurableRewardShortMapBuilder(); }

        public class GeDLCDurableRewardShortMapBuilder
            : OperationBuilder<GeDLCDurableRewardShortMapBuilder>
        {





            internal GeDLCDurableRewardShortMapBuilder() { }






            public GeDLCDurableRewardShortMap Build(
                string namespace_,
                GeDLCDurableRewardShortMapDlcType dlcType
            )
            {
                GeDLCDurableRewardShortMap op = new GeDLCDurableRewardShortMap(this,
                    namespace_,
                    dlcType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GeDLCDurableRewardShortMap(GeDLCDurableRewardShortMapBuilder builder,
            string namespace_,
            GeDLCDurableRewardShortMapDlcType dlcType
        )
        {
            PathParams["namespace"] = namespace_;

            if (dlcType is not null) QueryParams["dlcType"] = dlcType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GeDLCDurableRewardShortMap(
            string namespace_,
            GeDLCDurableRewardShortMapDlcType dlcType
        )
        {
            PathParams["namespace"] = namespace_;

            if (dlcType is not null) QueryParams["dlcType"] = dlcType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/dlc/rewards/durable/map";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.DLCConfigRewardShortInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.DLCConfigRewardShortInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.DLCConfigRewardShortInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DLCConfigRewardShortInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GeDLCDurableRewardShortMapDlcType : StringEnum<GeDLCDurableRewardShortMapDlcType>
    {
        public static readonly GeDLCDurableRewardShortMapDlcType EPICGAMES
            = new GeDLCDurableRewardShortMapDlcType("EPICGAMES");

        public static readonly GeDLCDurableRewardShortMapDlcType OCULUS
            = new GeDLCDurableRewardShortMapDlcType("OCULUS");

        public static readonly GeDLCDurableRewardShortMapDlcType PSN
            = new GeDLCDurableRewardShortMapDlcType("PSN");

        public static readonly GeDLCDurableRewardShortMapDlcType STEAM
            = new GeDLCDurableRewardShortMapDlcType("STEAM");

        public static readonly GeDLCDurableRewardShortMapDlcType XBOX
            = new GeDLCDurableRewardShortMapDlcType("XBOX");


        public static implicit operator GeDLCDurableRewardShortMapDlcType(string value)
        {
            return NewValue(value);
        }

        public GeDLCDurableRewardShortMapDlcType(string enumValue)
            : base(enumValue)
        {

        }
    }

}