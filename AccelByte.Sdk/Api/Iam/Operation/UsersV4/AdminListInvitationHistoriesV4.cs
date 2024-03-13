// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminListInvitationHistoriesV4
    ///
    /// This endpoint is to list all Invitation Histories for new studio namespace in multi tenant mode.
    /// It will return error if the service multi tenant mode is set to false.
    /// Accepted Query:
    /// - namespace
    /// - offset
    /// - limit
    /// </summary>
    public class AdminListInvitationHistoriesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListInvitationHistoriesV4Builder Builder { get => new AdminListInvitationHistoriesV4Builder(); }

        public class AdminListInvitationHistoriesV4Builder
            : OperationBuilder<AdminListInvitationHistoriesV4Builder>
        {

            public long? Limit { get; set; }

            public string? Namespace { get; set; }

            public long? Offset { get; set; }





            internal AdminListInvitationHistoriesV4Builder() { }


            public AdminListInvitationHistoriesV4Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListInvitationHistoriesV4Builder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public AdminListInvitationHistoriesV4Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminListInvitationHistoriesV4 Build(
            )
            {
                AdminListInvitationHistoriesV4 op = new AdminListInvitationHistoriesV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListInvitationHistoriesV4(AdminListInvitationHistoriesV4Builder builder
        )
        {

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Namespace is not null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListInvitationHistoriesV4(
            long? limit,
            string? namespace_,
            long? offset
        )
        {

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (namespace_ is not null) QueryParams["namespace"] = namespace_;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/invitationHistories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListInvitationHistoriesV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelListInvitationHistoriesV4Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelListInvitationHistoriesV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListInvitationHistoriesV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}