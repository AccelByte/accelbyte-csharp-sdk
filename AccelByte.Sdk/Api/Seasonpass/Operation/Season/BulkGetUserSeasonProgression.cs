// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// bulkGetUserSeasonProgression
    ///
    /// This API is used to bulk get user current season progression, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : user season progression
    /// </summary>
    public class BulkGetUserSeasonProgression : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetUserSeasonProgressionBuilder Builder { get => new BulkGetUserSeasonProgressionBuilder(); }

        public class BulkGetUserSeasonProgressionBuilder
            : OperationBuilder<BulkGetUserSeasonProgressionBuilder>
        {


            public Model.BulkUserProgressionRequest? Body { get; set; }




            internal BulkGetUserSeasonProgressionBuilder() { }



            public BulkGetUserSeasonProgressionBuilder SetBody(Model.BulkUserProgressionRequest _body)
            {
                Body = _body;
                return this;
            }




            public BulkGetUserSeasonProgression Build(
                string namespace_
            )
            {
                BulkGetUserSeasonProgression op = new BulkGetUserSeasonProgression(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private BulkGetUserSeasonProgression(BulkGetUserSeasonProgressionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetUserSeasonProgression(
            string namespace_,
            Model.BulkUserProgressionRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/current/users/bulk/progression";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.UserSeasonSummary>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.UserSeasonSummary>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.UserSeasonSummary>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserSeasonSummary>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}