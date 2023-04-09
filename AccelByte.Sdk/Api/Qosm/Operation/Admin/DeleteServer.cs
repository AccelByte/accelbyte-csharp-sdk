// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// DeleteServer
    ///
    /// ```
    /// Required permission: ADMIN:QOS:SERVER [DELETE]
    /// Required scope: social
    /// 
    /// This endpoint delete a registered QoS service record.
    /// ```
    /// </summary>
    public class DeleteServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteServerBuilder Builder { get => new DeleteServerBuilder(); }

        public class DeleteServerBuilder
            : OperationBuilder<DeleteServerBuilder>
        {





            internal DeleteServerBuilder() { }






            public DeleteServer Build(
                string region
            )
            {
                DeleteServer op = new DeleteServer(this,
                    region
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteServer(DeleteServerBuilder builder,
            string region
        )
        {
            PathParams["region"] = region;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteServer(
            string region
        )
        {
            PathParams["region"] = region;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/admin/servers/{region}";

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