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
    /// getNamespace_1
    ///
    /// Get a namespace info.
    /// Other detail info:
    /// 
    ///   * Returns : namespace info
    /// </summary>
    public class GetNamespace1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNamespace1Builder Builder { get => new GetNamespace1Builder(); }

        public class GetNamespace1Builder
            : OperationBuilder<GetNamespace1Builder>
        {





            internal GetNamespace1Builder() { }






            public GetNamespace1 Build(
                string namespace_
            )
            {
                GetNamespace1 op = new GetNamespace1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetNamespace1(GetNamespace1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







        }
        #endregion

        public GetNamespace1(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.NamespaceSimpleInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.NamespaceSimpleInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.NamespaceSimpleInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespaceSimpleInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}