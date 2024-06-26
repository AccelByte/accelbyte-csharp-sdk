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
    /// publicGetNamespacePublisher
    ///
    /// Get namespace info related publisher namespace.
    /// Other detail info:
    /// 
    ///   * Action code : 11305
    ///   *  Returns : Namespace info related publisher namespace
    /// </summary>
    public class PublicGetNamespacePublisher : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetNamespacePublisherBuilder Builder { get => new PublicGetNamespacePublisherBuilder(); }

        public class PublicGetNamespacePublisherBuilder
            : OperationBuilder<PublicGetNamespacePublisherBuilder>
        {





            internal PublicGetNamespacePublisherBuilder() { }






            public PublicGetNamespacePublisher Build(
                string namespace_
            )
            {
                PublicGetNamespacePublisher op = new PublicGetNamespacePublisher(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetNamespacePublisher(PublicGetNamespacePublisherBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetNamespacePublisher(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/publisher";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.NamespacePublisherInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.NamespacePublisherInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.NamespacePublisherInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespacePublisherInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}