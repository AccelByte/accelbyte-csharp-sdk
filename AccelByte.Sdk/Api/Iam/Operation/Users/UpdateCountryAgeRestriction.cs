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
    /// UpdateCountryAgeRestriction
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/agerestrictions/countries/{countryCode} [PATCH]
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:AGERESTRICTION [UPDATE]'
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdateCountryAgeRestriction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCountryAgeRestrictionBuilder Builder { get => new UpdateCountryAgeRestrictionBuilder(); }

        public class UpdateCountryAgeRestrictionBuilder
            : OperationBuilder<UpdateCountryAgeRestrictionBuilder>
        {





            internal UpdateCountryAgeRestrictionBuilder() { }






            public UpdateCountryAgeRestriction Build(
                ModelCountryAgeRestrictionRequest body,
                string countryCode,
                string namespace_
            )
            {
                UpdateCountryAgeRestriction op = new UpdateCountryAgeRestriction(this,
                    body,
                    countryCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateCountryAgeRestriction(UpdateCountryAgeRestrictionBuilder builder,
            ModelCountryAgeRestrictionRequest body,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCountryAgeRestriction(
            string countryCode,
            string namespace_,
            Model.ModelCountryAgeRestrictionRequest body
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelCountry? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCountry>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCountry>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}