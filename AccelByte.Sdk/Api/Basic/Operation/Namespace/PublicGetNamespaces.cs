// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetNamespaces
    ///
    /// Get all namespaces.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    ///   *  Action code : 11303
    ///   *  Returns : list of namespaces
    /// </summary>
    public class PublicGetNamespaces : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetNamespacesBuilder Builder = new PublicGetNamespacesBuilder();

        public class PublicGetNamespacesBuilder
            : OperationBuilder<PublicGetNamespacesBuilder>
        {

            public bool? ActiveOnly { get; set; }





            internal PublicGetNamespacesBuilder() { }


            public PublicGetNamespacesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }





            public PublicGetNamespaces Build(
            )
            {
                PublicGetNamespaces op = new PublicGetNamespaces(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetNamespaces(PublicGetNamespacesBuilder builder
        )
        {

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetNamespaces(
            bool? activeOnly
        )
        {

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.NamespaceInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.NamespaceInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.NamespaceInfo>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}