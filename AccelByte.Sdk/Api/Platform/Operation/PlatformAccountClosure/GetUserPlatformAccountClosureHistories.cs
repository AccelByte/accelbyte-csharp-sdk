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
    /// getUserPlatformAccountClosureHistories
    ///
    /// Get user platform account closure history.
    /// </summary>
    public class GetUserPlatformAccountClosureHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserPlatformAccountClosureHistoriesBuilder Builder { get => new GetUserPlatformAccountClosureHistoriesBuilder(); }

        public class GetUserPlatformAccountClosureHistoriesBuilder
            : OperationBuilder<GetUserPlatformAccountClosureHistoriesBuilder>
        {





            internal GetUserPlatformAccountClosureHistoriesBuilder() { }






            public GetUserPlatformAccountClosureHistories Build(
                string namespace_,
                string userId
            )
            {
                GetUserPlatformAccountClosureHistories op = new GetUserPlatformAccountClosureHistories(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetUserPlatformAccountClosureHistories(GetUserPlatformAccountClosureHistoriesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserPlatformAccountClosureHistories(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/platform/closure/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.PlatformAccountClosureHistoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.PlatformAccountClosureHistoryInfo>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.PlatformAccountClosureHistoryInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PlatformAccountClosureHistoryInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}