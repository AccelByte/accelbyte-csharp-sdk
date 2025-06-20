// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// adminUpsertPlayFeatureFlag
    ///
    /// Upsert matchmaking Play Feature Flag.
    /// </summary>
    public class AdminUpsertPlayFeatureFlag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpsertPlayFeatureFlagBuilder Builder { get => new AdminUpsertPlayFeatureFlagBuilder(); }

        public class AdminUpsertPlayFeatureFlagBuilder
            : OperationBuilder<AdminUpsertPlayFeatureFlagBuilder>
        {





            internal AdminUpsertPlayFeatureFlagBuilder() { }






            public AdminUpsertPlayFeatureFlag Build(
                ModelsPlayFeatureFlag body,
                string namespace_
            )
            {
                AdminUpsertPlayFeatureFlag op = new AdminUpsertPlayFeatureFlag(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpsertPlayFeatureFlag(AdminUpsertPlayFeatureFlagBuilder builder,
            ModelsPlayFeatureFlag body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpsertPlayFeatureFlag(
            string namespace_,
            Model.ModelsPlayFeatureFlag body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/admin/namespaces/{namespace}/playfeatureflag";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPlayFeatureFlag? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPlayFeatureFlag>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPlayFeatureFlag>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayFeatureFlag>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}