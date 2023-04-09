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
    /// deleteSection
    ///
    /// This API is used to delete s section.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=8 (DELETE)
    /// </summary>
    public class DeleteSection : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSectionBuilder Builder { get => new DeleteSectionBuilder(); }

        public class DeleteSectionBuilder
            : OperationBuilder<DeleteSectionBuilder>
        {





            internal DeleteSectionBuilder() { }






            public DeleteSection Build(
                string namespace_,
                string sectionId,
                string storeId
            )
            {
                DeleteSection op = new DeleteSection(this,
                    namespace_,
                    sectionId,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteSection(DeleteSectionBuilder builder,
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sectionId"] = sectionId;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSection(
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sectionId"] = sectionId;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/sections/{sectionId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

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