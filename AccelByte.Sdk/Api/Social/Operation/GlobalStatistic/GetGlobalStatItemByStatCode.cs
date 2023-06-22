// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getGlobalStatItemByStatCode
    ///
    /// Get global statItem by stat code.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    ///         *  Returns : global stat item
    /// </summary>
    public class GetGlobalStatItemByStatCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItemByStatCodeBuilder Builder { get => new GetGlobalStatItemByStatCodeBuilder(); }

        public class GetGlobalStatItemByStatCodeBuilder
            : OperationBuilder<GetGlobalStatItemByStatCodeBuilder>
        {





            internal GetGlobalStatItemByStatCodeBuilder() { }






            public GetGlobalStatItemByStatCode Build(
                string namespace_,
                string statCode
            )
            {
                GetGlobalStatItemByStatCode op = new GetGlobalStatItemByStatCode(this,
                    namespace_,
                    statCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetGlobalStatItemByStatCode(GetGlobalStatItemByStatCodeBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGlobalStatItemByStatCode(
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/globalstatitems/{statCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GlobalStatItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}