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
    /// getGlobalStatItemByStatCode_1
    ///
    /// Get global statItem by stat code.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    ///             *  Returns : global stat item
    /// </summary>
    public class GetGlobalStatItemByStatCode1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItemByStatCode1Builder Builder { get => new GetGlobalStatItemByStatCode1Builder(); }

        public class GetGlobalStatItemByStatCode1Builder
            : OperationBuilder<GetGlobalStatItemByStatCode1Builder>
        {





            internal GetGlobalStatItemByStatCode1Builder() { }






            public GetGlobalStatItemByStatCode1 Build(
                string namespace_,
                string statCode
            )
            {
                GetGlobalStatItemByStatCode1 op = new GetGlobalStatItemByStatCode1(this,
                    namespace_,
                    statCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetGlobalStatItemByStatCode1(GetGlobalStatItemByStatCode1Builder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGlobalStatItemByStatCode1(
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/globalstatitems/{statCode}";

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
                return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}