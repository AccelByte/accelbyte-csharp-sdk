// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// DeleteAppImagesV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:IMAGE [DELETE]`
    /// 
    /// Deletes list of provided image tags from the app image repository
    /// </summary>
    public class DeleteAppImagesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAppImagesV2Builder Builder { get => new DeleteAppImagesV2Builder(); }

        public class DeleteAppImagesV2Builder
            : OperationBuilder<DeleteAppImagesV2Builder>
        {





            internal DeleteAppImagesV2Builder() { }






            public DeleteAppImagesV2 Build(
                GeneratedDeleteAppImagesV1Request body,
                string app,
                string namespace_
            )
            {
                DeleteAppImagesV2 op = new DeleteAppImagesV2(this,
                    body,
                    app,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteAppImagesV2(DeleteAppImagesV2Builder builder,
            GeneratedDeleteAppImagesV1Request body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteAppImagesV2(
            string app,
            string namespace_,
            Model.GeneratedDeleteAppImagesV1Request body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/images";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}