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
    /// AdminAddRolePermissionsV4
    ///
    /// This endpoint will ATTACH permission(s) into the role
    /// action code: 10404
    /// 
    /// Schedule contains cron string or date range (both are UTC, also in cron syntax) to indicate when a permission and action are in effect.
    /// Both schedule types accepts quartz compatible cron syntax e.g. * * * * * * *.
    /// In ranged schedule, first element will be start date, and second one will be end date
    /// If schedule is set, the scheduled action must be valid too, that is between 1 to 15, inclusive
    /// Syntax reference
    /// Fields:
    /// 1. Seconds: 0-59 * / , -
    /// 2. Minutes: 0-59 * / , -
    /// 3. Hours: 0-23 * / , -
    /// 4. Day of month: 1-31 * / , - L W
    /// 5. Month: 1-12 JAN-DEC * / , -
    /// 6. Day of week: 0-6 SUN-SAT * / , - L #
    /// 7. Year: 1970-2099 * / , -
    /// 
    /// Special characters:
    /// 1. *: all values in the fields, e.g. * in seconds fields indicates every second
    /// 2. /: increments of ranges, e.g. 3-59/15 in the minute field indicate the third minute of the hour and every 15 minutes thereafter
    /// 3. ,: separate items of a list, e.g. MON,WED,FRI in day of week
    /// 4. -: range, e.g. 2010-2018 indicates every year between 2010 and 2018, inclusive
    /// 5. L: last, e.g. When used in the day-of-week field, it allows you to specify constructs such as "the last Friday" (5L) of a given month. In the day-of-month field, it specifies the last day of the month.
    /// 6. W: business day, e.g. if you were to specify 15W as the value for the day-of-month field, the meaning is: "the nearest business day to the 15th of the month."
    /// 7. #: must be followed by a number between one and five. It allows you to specify constructs such as "the second Friday" of a given month.
    /// </summary>
    public class AdminAddRolePermissionsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddRolePermissionsV4Builder Builder { get => new AdminAddRolePermissionsV4Builder(); }

        public class AdminAddRolePermissionsV4Builder
            : OperationBuilder<AdminAddRolePermissionsV4Builder>
        {





            internal AdminAddRolePermissionsV4Builder() { }






            public AdminAddRolePermissionsV4 Build(
                AccountcommonPermissionsV3 body,
                string roleId
            )
            {
                AdminAddRolePermissionsV4 op = new AdminAddRolePermissionsV4(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminAddRolePermissionsV4(AdminAddRolePermissionsV4Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddRolePermissionsV4(
            string roleId,
            Model.AccountcommonPermissionsV3 body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/permissions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelRoleV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}