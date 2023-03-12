// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// syncUserInfo
    ///
    ///  Important: GOING TO DEPRECATE
    /// 
    /// Sync user info cache in agreement service with iam service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class SyncUserInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncUserInfoBuilder Builder { get => new SyncUserInfoBuilder(); }

        public class SyncUserInfoBuilder
            : OperationBuilder<SyncUserInfoBuilder>
        {





            internal SyncUserInfoBuilder() { }






            public SyncUserInfo Build(
                string namespace_
            )
            {
                SyncUserInfo op = new SyncUserInfo(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SyncUserInfo(SyncUserInfoBuilder builder,
            string namespace_
        )
        {

            if (namespace_ is not null) QueryParams["namespace"] = namespace_;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncUserInfo(
            string namespace_
        )
        {

            if (namespace_ is not null) QueryParams["namespace"] = namespace_;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}