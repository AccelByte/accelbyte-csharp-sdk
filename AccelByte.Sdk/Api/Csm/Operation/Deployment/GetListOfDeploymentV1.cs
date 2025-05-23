// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// GetListOfDeploymentV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:DEPLOYMENT [READ]`
    /// 
    /// Filters the List of Deployments
    /// 
    /// This endpoint intended to get list of Deployment done for the given publisher and game.
    /// 
    /// Required: Valid Access Token
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetListOfDeploymentV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListOfDeploymentV1Builder Builder { get => new GetListOfDeploymentV1Builder(); }

        public class GetListOfDeploymentV1Builder
            : OperationBuilder<GetListOfDeploymentV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetListOfDeploymentV1Builder() { }


            public GetListOfDeploymentV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetListOfDeploymentV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetListOfDeploymentV1 Build(
                GeneratedGetDeploymentListV1Request body,
                string namespace_
            )
            {
                GetListOfDeploymentV1 op = new GetListOfDeploymentV1(this,
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

        private GetListOfDeploymentV1(GetListOfDeploymentV1Builder builder,
            GeneratedGetDeploymentListV1Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetListOfDeploymentV1(
            string namespace_,
            long? limit,
            long? offset,
            Model.GeneratedGetDeploymentListV1Request body
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/deployments";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GeneratedGetDeploymentListV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GeneratedGetDeploymentListV1Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GeneratedGetDeploymentListV1Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GeneratedGetDeploymentListV1Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}