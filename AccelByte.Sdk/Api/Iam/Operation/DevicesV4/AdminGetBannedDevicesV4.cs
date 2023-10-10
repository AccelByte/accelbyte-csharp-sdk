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
    /// AdminGetBannedDevicesV4
    ///
    /// 
    /// 
    /// This is the endpoint for an admin to get banned devices.
    /// 
    /// 
    /// 
    /// Required permission
    /// 
    ///                                                                         'ADMIN:NAMESPACE:{namespace}:DEVICE [READ]'
    /// </summary>
    public class AdminGetBannedDevicesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBannedDevicesV4Builder Builder { get => new AdminGetBannedDevicesV4Builder(); }

        public class AdminGetBannedDevicesV4Builder
            : OperationBuilder<AdminGetBannedDevicesV4Builder>
        {

            public string? DeviceType { get; set; }

            public string? EndDate { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? StartDate { get; set; }





            internal AdminGetBannedDevicesV4Builder() { }


            public AdminGetBannedDevicesV4Builder SetDeviceType(string _deviceType)
            {
                DeviceType = _deviceType;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public AdminGetBannedDevicesV4 Build(
                string namespace_
            )
            {
                AdminGetBannedDevicesV4 op = new AdminGetBannedDevicesV4(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetBannedDevicesV4(AdminGetBannedDevicesV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.DeviceType is not null) QueryParams["deviceType"] = builder.DeviceType;
            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetBannedDevicesV4(
            string namespace_,
            string? deviceType,
            string? endDate,
            long? limit,
            long? offset,
            string? startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (deviceType is not null) QueryParams["deviceType"] = deviceType;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/banned";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelDeviceBannedResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelDeviceBannedResponseV4>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelDeviceBannedResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBannedResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}