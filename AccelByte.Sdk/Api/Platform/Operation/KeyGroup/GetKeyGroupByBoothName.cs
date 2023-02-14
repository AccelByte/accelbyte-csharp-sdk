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
    /// getKeyGroupByBoothName
    ///
    /// Get key group.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=2 (READ)
    ///   *  Returns : key group info
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetKeyGroupByBoothName : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetKeyGroupByBoothNameBuilder Builder { get => new GetKeyGroupByBoothNameBuilder(); }

        public class GetKeyGroupByBoothNameBuilder
            : OperationBuilder<GetKeyGroupByBoothNameBuilder>
        {





            internal GetKeyGroupByBoothNameBuilder() { }






            public GetKeyGroupByBoothName Build(
                string namespace_,
                string boothName
            )
            {
                GetKeyGroupByBoothName op = new GetKeyGroupByBoothName(this,
                    namespace_,
                    boothName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetKeyGroupByBoothName(GetKeyGroupByBoothNameBuilder builder,
            string namespace_,
            string boothName
        )
        {
            PathParams["namespace"] = namespace_;

            if (boothName is not null) QueryParams["boothName"] = boothName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetKeyGroupByBoothName(
            string namespace_,
            string boothName
        )
        {
            PathParams["namespace"] = namespace_;

            if (boothName is not null) QueryParams["boothName"] = boothName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/byBoothName";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.KeyGroupInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}