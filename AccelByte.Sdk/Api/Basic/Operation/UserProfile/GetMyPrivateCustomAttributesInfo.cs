// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getMyPrivateCustomAttributesInfo
    ///
    /// Get my private custom attributes.
    /// Other detail info:
    /// 
    ///   * Returns : custom attributes
    ///   *  Action code : 11403
    /// </summary>
    public class GetMyPrivateCustomAttributesInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMyPrivateCustomAttributesInfoBuilder Builder { get => new GetMyPrivateCustomAttributesInfoBuilder(); }

        public class GetMyPrivateCustomAttributesInfoBuilder
            : OperationBuilder<GetMyPrivateCustomAttributesInfoBuilder>
        {





            internal GetMyPrivateCustomAttributesInfoBuilder() { }






            public GetMyPrivateCustomAttributesInfo Build(
                string namespace_
            )
            {
                GetMyPrivateCustomAttributesInfo op = new GetMyPrivateCustomAttributesInfo(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetMyPrivateCustomAttributesInfo(GetMyPrivateCustomAttributesInfoBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMyPrivateCustomAttributesInfo(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}