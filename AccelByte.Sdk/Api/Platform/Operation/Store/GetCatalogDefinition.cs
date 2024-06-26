// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getCatalogDefinition
    ///
    /// This API is used to get catalog definition for import/export store by CSV
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : catalog definition
    /// </summary>
    public class GetCatalogDefinition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCatalogDefinitionBuilder Builder { get => new GetCatalogDefinitionBuilder(); }

        public class GetCatalogDefinitionBuilder
            : OperationBuilder<GetCatalogDefinitionBuilder>
        {





            internal GetCatalogDefinitionBuilder() { }






            public GetCatalogDefinition Build(
                string namespace_,
                GetCatalogDefinitionCatalogType catalogType
            )
            {
                GetCatalogDefinition op = new GetCatalogDefinition(this,
                    namespace_,
                    catalogType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetCatalogDefinition(GetCatalogDefinitionBuilder builder,
            string namespace_,
            GetCatalogDefinitionCatalogType catalogType
        )
        {
            PathParams["namespace"] = namespace_;

            if (catalogType is not null) QueryParams["catalogType"] = catalogType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCatalogDefinition(
            string namespace_,
            GetCatalogDefinitionCatalogType catalogType
        )
        {
            PathParams["namespace"] = namespace_;

            if (catalogType is not null) QueryParams["catalogType"] = catalogType.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/catalogDefinition";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.CatalogDefinitionInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.CatalogDefinitionInfo>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.CatalogDefinitionInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CatalogDefinitionInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetCatalogDefinitionCatalogType : StringEnum<GetCatalogDefinitionCatalogType>
    {
        public static readonly GetCatalogDefinitionCatalogType APP
            = new GetCatalogDefinitionCatalogType("APP");

        public static readonly GetCatalogDefinitionCatalogType CATEGORY
            = new GetCatalogDefinitionCatalogType("CATEGORY");

        public static readonly GetCatalogDefinitionCatalogType ITEM
            = new GetCatalogDefinitionCatalogType("ITEM");

        public static readonly GetCatalogDefinitionCatalogType SECTION
            = new GetCatalogDefinitionCatalogType("SECTION");

        public static readonly GetCatalogDefinitionCatalogType VIEW
            = new GetCatalogDefinitionCatalogType("VIEW");


        public static implicit operator GetCatalogDefinitionCatalogType(string value)
        {
            return NewValue(value);
        }

        public GetCatalogDefinitionCatalogType(string enumValue)
            : base(enumValue)
        {

        }
    }

}