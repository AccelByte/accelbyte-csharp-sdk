// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// SetUserVisibilityStatusV2
    ///
    /// User with false visibility status will have hidden attribute set to true on it's leaderboard entry
    /// </summary>
    public class SetUserVisibilityStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetUserVisibilityStatusV2Builder Builder { get => new SetUserVisibilityStatusV2Builder(); }

        public class SetUserVisibilityStatusV2Builder
            : OperationBuilder<SetUserVisibilityStatusV2Builder>
        {





            internal SetUserVisibilityStatusV2Builder() { }






            public SetUserVisibilityStatusV2 Build(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityStatusV2 op = new SetUserVisibilityStatusV2(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private SetUserVisibilityStatusV2(SetUserVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetUserVisibilityStatusV2(
            string namespace_,
            string userId,
            Model.ModelsSetUserVisibilityRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v2/admin/namespaces/{namespace}/users/{userId}/visibility";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetUserVisibilityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}