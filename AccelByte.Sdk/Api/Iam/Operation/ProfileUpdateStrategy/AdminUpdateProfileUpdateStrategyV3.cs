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
    /// AdminUpdateProfileUpdateStrategyV3
    ///
    /// This API includes upsert behavior.
    /// Note:
    /// 1. field 'config'' in request body will only work when type is limited
    /// </summary>
    public class AdminUpdateProfileUpdateStrategyV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateProfileUpdateStrategyV3Builder Builder { get => new AdminUpdateProfileUpdateStrategyV3Builder(); }

        public class AdminUpdateProfileUpdateStrategyV3Builder
            : OperationBuilder<AdminUpdateProfileUpdateStrategyV3Builder>
        {





            internal AdminUpdateProfileUpdateStrategyV3Builder() { }






            public AdminUpdateProfileUpdateStrategyV3 Build(
                ModelUpdateProfileUpdateStrategyConfigRequest body,
                string namespace_,
                AdminUpdateProfileUpdateStrategyV3Field field
            )
            {
                AdminUpdateProfileUpdateStrategyV3 op = new AdminUpdateProfileUpdateStrategyV3(this,
                    body,
                    namespace_,
                    field
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateProfileUpdateStrategyV3(AdminUpdateProfileUpdateStrategyV3Builder builder,
            ModelUpdateProfileUpdateStrategyConfigRequest body,
            string namespace_,
            AdminUpdateProfileUpdateStrategyV3Field field
        )
        {
            PathParams["namespace"] = namespace_;

            if (field is not null) QueryParams["field"] = field.Value;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateProfileUpdateStrategyV3(
            string namespace_,
            AdminUpdateProfileUpdateStrategyV3Field field,
            Model.ModelUpdateProfileUpdateStrategyConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;

            if (field is not null) QueryParams["field"] = field.Value;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/profileUpdateStrategies";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelSimpleProfileUpdateStrategyConfigs? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelSimpleProfileUpdateStrategyConfigs>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelSimpleProfileUpdateStrategyConfigs>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSimpleProfileUpdateStrategyConfigs>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminUpdateProfileUpdateStrategyV3Field : StringEnum<AdminUpdateProfileUpdateStrategyV3Field>
    {
        public static readonly AdminUpdateProfileUpdateStrategyV3Field Country
            = new AdminUpdateProfileUpdateStrategyV3Field("country");

        public static readonly AdminUpdateProfileUpdateStrategyV3Field DisplayName
            = new AdminUpdateProfileUpdateStrategyV3Field("display_name");

        public static readonly AdminUpdateProfileUpdateStrategyV3Field Dob
            = new AdminUpdateProfileUpdateStrategyV3Field("dob");

        public static readonly AdminUpdateProfileUpdateStrategyV3Field Username
            = new AdminUpdateProfileUpdateStrategyV3Field("username");


        public static implicit operator AdminUpdateProfileUpdateStrategyV3Field(string value)
        {
            return NewValue(value);
        }

        public AdminUpdateProfileUpdateStrategyV3Field(string enumValue)
            : base(enumValue)
        {

        }
    }

}