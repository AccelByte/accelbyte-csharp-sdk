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
    /// getLootBoxGrpcInfo
    ///
    /// Get lootbox plugin gRPC info.
    /// </summary>
    public class GetLootBoxGrpcInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLootBoxGrpcInfoBuilder Builder { get => new GetLootBoxGrpcInfoBuilder(); }

        public class GetLootBoxGrpcInfoBuilder
            : OperationBuilder<GetLootBoxGrpcInfoBuilder>
        {

            public bool? Force { get; set; }





            internal GetLootBoxGrpcInfoBuilder() { }


            public GetLootBoxGrpcInfoBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public GetLootBoxGrpcInfo Build(
                string namespace_
            )
            {
                GetLootBoxGrpcInfo op = new GetLootBoxGrpcInfo(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetLootBoxGrpcInfo(GetLootBoxGrpcInfoBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLootBoxGrpcInfo(
            string namespace_,
            bool? force
        )
        {
            PathParams["namespace"] = namespace_;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/grpcInfo";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GrpcServerInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GrpcServerInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GrpcServerInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GrpcServerInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}