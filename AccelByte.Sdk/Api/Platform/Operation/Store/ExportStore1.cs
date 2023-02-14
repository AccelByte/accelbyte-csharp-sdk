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
    /// exportStore_1
    ///
    /// This API is used to export a whole or partial store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    /// </summary>
    public class ExportStore1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportStore1Builder Builder { get => new ExportStore1Builder(); }

        public class ExportStore1Builder
            : OperationBuilder<ExportStore1Builder>
        {


            public Model.ExportStoreRequest? Body { get; set; }




            internal ExportStore1Builder() { }



            public ExportStore1Builder SetBody(Model.ExportStoreRequest _body)
            {
                Body = _body;
                return this;
            }




            public ExportStore1 Build(
                string namespace_,
                string storeId
            )
            {
                ExportStore1 op = new ExportStore1(this,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ExportStore1(ExportStore1Builder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExportStore1(
            string namespace_,
            string storeId,
            Model.ExportStoreRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/stores/{storeId}/export";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/zip" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}