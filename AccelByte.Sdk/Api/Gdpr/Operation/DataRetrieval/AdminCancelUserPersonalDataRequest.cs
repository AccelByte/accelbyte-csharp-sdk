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
    /// AdminCancelUserPersonalDataRequest
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [DELETE]` and scope `account`
    /// </summary>
    public class AdminCancelUserPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCancelUserPersonalDataRequestBuilder Builder { get => new AdminCancelUserPersonalDataRequestBuilder(); }

        public class AdminCancelUserPersonalDataRequestBuilder
            : OperationBuilder<AdminCancelUserPersonalDataRequestBuilder>
        {





            internal AdminCancelUserPersonalDataRequestBuilder() { }






            public AdminCancelUserPersonalDataRequest Build(
                string namespace_,
                string requestDate,
                string userId
            )
            {
                AdminCancelUserPersonalDataRequest op = new AdminCancelUserPersonalDataRequest(this,
                    namespace_,
                    requestDate,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminCancelUserPersonalDataRequest(AdminCancelUserPersonalDataRequestBuilder builder,
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

        public AdminCancelUserPersonalDataRequest(
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

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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