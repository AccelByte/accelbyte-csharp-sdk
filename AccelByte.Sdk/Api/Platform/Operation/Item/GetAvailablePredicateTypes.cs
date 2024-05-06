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
    /// getAvailablePredicateTypes
    ///
    /// Get available predicate types.
    /// Other detail info:
    /// 
    ///   * Returns : available predicate types
    /// </summary>
    public class GetAvailablePredicateTypes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAvailablePredicateTypesBuilder Builder { get => new GetAvailablePredicateTypesBuilder(); }

        public class GetAvailablePredicateTypesBuilder
            : OperationBuilder<GetAvailablePredicateTypesBuilder>
        {





            internal GetAvailablePredicateTypesBuilder() { }






            public GetAvailablePredicateTypes Build(
                string namespace_
            )
            {
                GetAvailablePredicateTypes op = new GetAvailablePredicateTypes(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetAvailablePredicateTypes(GetAvailablePredicateTypesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAvailablePredicateTypes(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/predicate/types";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.AvailablePredicate>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.AvailablePredicate>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.AvailablePredicate>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.AvailablePredicate>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}