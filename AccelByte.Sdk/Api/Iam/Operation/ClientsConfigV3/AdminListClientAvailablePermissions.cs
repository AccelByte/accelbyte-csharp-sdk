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
    /// AdminListClientAvailablePermissions
    ///
    /// List Client available permissions
    /// </summary>
    public class AdminListClientAvailablePermissions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListClientAvailablePermissionsBuilder Builder { get => new AdminListClientAvailablePermissionsBuilder(); }

        public class AdminListClientAvailablePermissionsBuilder
            : OperationBuilder<AdminListClientAvailablePermissionsBuilder>
        {

            public bool? ExcludePermissions { get; set; }





            internal AdminListClientAvailablePermissionsBuilder() { }


            public AdminListClientAvailablePermissionsBuilder SetExcludePermissions(bool _excludePermissions)
            {
                ExcludePermissions = _excludePermissions;
                return this;
            }





            public AdminListClientAvailablePermissions Build(
            )
            {
                AdminListClientAvailablePermissions op = new AdminListClientAvailablePermissions(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListClientAvailablePermissions(AdminListClientAvailablePermissionsBuilder builder
        )
        {

            if (builder.ExcludePermissions != null) QueryParams["excludePermissions"] = Convert.ToString(builder.ExcludePermissions)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListClientAvailablePermissions(
            bool? excludePermissions
        )
        {

            if (excludePermissions != null) QueryParams["excludePermissions"] = Convert.ToString(excludePermissions)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/clientConfig/permissions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ClientmodelListClientPermissionSet? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ClientmodelListClientPermissionSet>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ClientmodelListClientPermissionSet>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelListClientPermissionSet>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}