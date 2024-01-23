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
    /// cloneSeason
    ///
    /// This API is used to clone a season.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=1 (CREATE)
    ///   *  Returns : cloned season info
    /// </summary>
    public class CloneSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CloneSeasonBuilder Builder { get => new CloneSeasonBuilder(); }

        public class CloneSeasonBuilder
            : OperationBuilder<CloneSeasonBuilder>
        {


            public Model.SeasonCloneRequest? Body { get; set; }




            internal CloneSeasonBuilder() { }



            public CloneSeasonBuilder SetBody(Model.SeasonCloneRequest _body)
            {
                Body = _body;
                return this;
            }




            public CloneSeason Build(
                string namespace_,
                string seasonId
            )
            {
                CloneSeason op = new CloneSeason(this,
                    namespace_,
                    seasonId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CloneSeason(CloneSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CloneSeason(
            string namespace_,
            string seasonId,
            Model.SeasonCloneRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/clone";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.SeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.SeasonInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.SeasonInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}