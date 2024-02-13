// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminDeleteTagHandlerV1
    ///
    /// ## Description
    /// 
    /// Endpoint to delete a tag
    /// </summary>
    public class AdminDeleteTagHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteTagHandlerV1Builder Builder { get => new AdminDeleteTagHandlerV1Builder(); }

        public class AdminDeleteTagHandlerV1Builder
            : OperationBuilder<AdminDeleteTagHandlerV1Builder>
        {





            internal AdminDeleteTagHandlerV1Builder() { }






            public AdminDeleteTagHandlerV1 Build(
                string namespace_,
                string tag
            )
            {
                AdminDeleteTagHandlerV1 op = new AdminDeleteTagHandlerV1(this,
                    namespace_,
                    tag
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDeleteTagHandlerV1(AdminDeleteTagHandlerV1Builder builder,
            string namespace_,
            string tag
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tag"] = tag;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteTagHandlerV1(
            string namespace_,
            string tag
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tag"] = tag;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/tags/{tag}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}