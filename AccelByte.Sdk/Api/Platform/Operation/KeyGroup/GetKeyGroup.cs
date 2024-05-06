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
    /// getKeyGroup
    ///
    /// Get key group.
    /// Other detail info:
    /// 
    ///   * Returns : key group info
    /// </summary>
    public class GetKeyGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetKeyGroupBuilder Builder { get => new GetKeyGroupBuilder(); }

        public class GetKeyGroupBuilder
            : OperationBuilder<GetKeyGroupBuilder>
        {





            internal GetKeyGroupBuilder() { }






            public GetKeyGroup Build(
                string keyGroupId,
                string namespace_
            )
            {
                GetKeyGroup op = new GetKeyGroup(this,
                    keyGroupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetKeyGroup(GetKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetKeyGroup(
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.KeyGroupInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}