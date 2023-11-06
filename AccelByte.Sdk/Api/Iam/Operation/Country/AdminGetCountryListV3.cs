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
    /// AdminGetCountryListV3
    ///
    /// Admin get country list
    /// </summary>
    public class AdminGetCountryListV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetCountryListV3Builder Builder { get => new AdminGetCountryListV3Builder(); }

        public class AdminGetCountryListV3Builder
            : OperationBuilder<AdminGetCountryListV3Builder>
        {

            public bool? FilterBlacklist { get; set; }





            internal AdminGetCountryListV3Builder() { }


            public AdminGetCountryListV3Builder SetFilterBlacklist(bool _filterBlacklist)
            {
                FilterBlacklist = _filterBlacklist;
                return this;
            }





            public AdminGetCountryListV3 Build(
                string namespace_
            )
            {
                AdminGetCountryListV3 op = new AdminGetCountryListV3(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetCountryListV3(AdminGetCountryListV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.FilterBlacklist != null) QueryParams["filterBlacklist"] = Convert.ToString(builder.FilterBlacklist)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetCountryListV3(
            string namespace_,
            bool? filterBlacklist
        )
        {
            PathParams["namespace"] = namespace_;

            if (filterBlacklist != null) QueryParams["filterBlacklist"] = Convert.ToString(filterBlacklist)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelCountryResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelCountryResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelCountryResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelCountryResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}