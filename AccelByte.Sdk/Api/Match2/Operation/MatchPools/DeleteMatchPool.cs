// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// DeleteMatchPool
    ///
    /// Deletes an existing matchmaking pool.
    /// </summary>
    public class DeleteMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMatchPoolBuilder Builder { get => new DeleteMatchPoolBuilder(); }

        public class DeleteMatchPoolBuilder
            : OperationBuilder<DeleteMatchPoolBuilder>
        {





            internal DeleteMatchPoolBuilder() { }






            public DeleteMatchPool Build(
                string namespace_,
                string pool
            )
            {
                DeleteMatchPool op = new DeleteMatchPool(this,
                    namespace_,
                    pool
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private DeleteMatchPool(DeleteMatchPoolBuilder builder,
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMatchPool(
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools/{pool}";

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