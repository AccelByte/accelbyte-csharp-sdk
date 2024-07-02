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
    /// S2SGetListFinishedPersonalDataRequest
    ///
    /// Scope: account
    /// 
    /// Get list of finished personal data requests based on the finished time period.
    /// Unfinished personal data requests will not appear here, i.e. have Status **Pending**, **In-Progress** or **Canceled**.
    /// 
    /// **Anonymize userId for deleted account:**
    /// For user accounts that have been deleted, the **userId** field in this API will be anonymized automatically after **7 days** from the success deletion.
    /// This measure is implemented to ensure compliance with GDPR regulations. Please make sure to synchronize the data from this API before it undergoes anonymization.
    /// 
    /// ---
    /// ## This API for S2S integration purpose only
    /// </summary>
    public class S2SGetListFinishedPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static S2SGetListFinishedPersonalDataRequestBuilder Builder { get => new S2SGetListFinishedPersonalDataRequestBuilder(); }

        public class S2SGetListFinishedPersonalDataRequestBuilder
            : OperationBuilder<S2SGetListFinishedPersonalDataRequestBuilder>
        {





            internal S2SGetListFinishedPersonalDataRequestBuilder() { }






            public S2SGetListFinishedPersonalDataRequest Build(
                string namespace_,
                string end,
                string start
            )
            {
                S2SGetListFinishedPersonalDataRequest op = new S2SGetListFinishedPersonalDataRequest(this,
                    namespace_,
                    end,
                    start
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private S2SGetListFinishedPersonalDataRequest(S2SGetListFinishedPersonalDataRequestBuilder builder,
            string namespace_,
            string end,
            string start
        )
        {
            PathParams["namespace"] = namespace_;

            if (end is not null) QueryParams["end"] = end;
            if (start is not null) QueryParams["start"] = start;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public S2SGetListFinishedPersonalDataRequest(
            string namespace_,
            string end,
            string start
        )
        {
            PathParams["namespace"] = namespace_;

            if (end is not null) QueryParams["end"] = end;
            if (start is not null) QueryParams["start"] = start;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/s2s/namespaces/{namespace}/requests/finished";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.DtoListFinishedDataRequests? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.DtoListFinishedDataRequests>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.DtoListFinishedDataRequests>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DtoListFinishedDataRequests>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}