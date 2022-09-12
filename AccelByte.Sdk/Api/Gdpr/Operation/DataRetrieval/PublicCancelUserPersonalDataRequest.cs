// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// PublicCancelUserPersonalDataRequest
    ///
    /// Requires valid user access token
    /// </summary>
    public class PublicCancelUserPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCancelUserPersonalDataRequestBuilder Builder = new PublicCancelUserPersonalDataRequestBuilder();

        public class PublicCancelUserPersonalDataRequestBuilder
            : OperationBuilder<PublicCancelUserPersonalDataRequestBuilder>
        {





            internal PublicCancelUserPersonalDataRequestBuilder() { }






            public PublicCancelUserPersonalDataRequest Build(
                string namespace_,
                string requestDate,
                string userId
            )
            {
                PublicCancelUserPersonalDataRequest op = new PublicCancelUserPersonalDataRequest(this,
                    namespace_,
                    requestDate,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCancelUserPersonalDataRequest(PublicCancelUserPersonalDataRequestBuilder builder,
            string namespace_,
            string requestDate,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCancelUserPersonalDataRequest(
            string namespace_,
            string requestDate,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}