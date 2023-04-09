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
    /// syncTwitchDropsEntitlement
    ///
    /// Sync my game twitch drops entitlements.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:IAP, action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncTwitchDropsEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncTwitchDropsEntitlementBuilder Builder { get => new SyncTwitchDropsEntitlementBuilder(); }

        public class SyncTwitchDropsEntitlementBuilder
            : OperationBuilder<SyncTwitchDropsEntitlementBuilder>
        {


            public Model.TwitchSyncRequest? Body { get; set; }




            internal SyncTwitchDropsEntitlementBuilder() { }



            public SyncTwitchDropsEntitlementBuilder SetBody(Model.TwitchSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncTwitchDropsEntitlement Build(
                string namespace_
            )
            {
                SyncTwitchDropsEntitlement op = new SyncTwitchDropsEntitlement(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SyncTwitchDropsEntitlement(SyncTwitchDropsEntitlementBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncTwitchDropsEntitlement(
            string namespace_,
            Model.TwitchSyncRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/iap/twitch/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.TwitchSyncResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.TwitchSyncResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.TwitchSyncResult>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}