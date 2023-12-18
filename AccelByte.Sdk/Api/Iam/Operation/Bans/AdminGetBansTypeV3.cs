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
    /// AdminGetBansTypeV3
    ///
    /// Ban type is the code
    /// available for ban assignment. It is applicable globally for any namespace.
    /// action code : 10201
    /// </summary>
    public class AdminGetBansTypeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBansTypeV3Builder Builder { get => new AdminGetBansTypeV3Builder(); }

        public class AdminGetBansTypeV3Builder
            : OperationBuilder<AdminGetBansTypeV3Builder>
        {





            internal AdminGetBansTypeV3Builder() { }






            public AdminGetBansTypeV3 Build(
            )
            {
                AdminGetBansTypeV3 op = new AdminGetBansTypeV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetBansTypeV3(AdminGetBansTypeV3Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetBansTypeV3(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountcommonBansV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AccountcommonBansV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AccountcommonBansV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBansV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}