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
    /// commit
    ///
    /// This API is used to create a chained operations
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:TRADE, action=1 (CREATE)
    ///   *  Returns : chain action history
    /// 
    /// 
    /// 
    /// ## Restrictions for metadata
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class Commit : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CommitBuilder Builder { get => new CommitBuilder(); }

        public class CommitBuilder
            : OperationBuilder<CommitBuilder>
        {


            public Model.TradeChainedActionCommitRequest? Body { get; set; }




            internal CommitBuilder() { }



            public CommitBuilder SetBody(Model.TradeChainedActionCommitRequest _body)
            {
                Body = _body;
                return this;
            }




            public Commit Build(
                string namespace_
            )
            {
                Commit op = new Commit(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private Commit(CommitBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Commit(
            string namespace_,
            Model.TradeChainedActionCommitRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/trade/commit";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.TradeChainActionHistoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.TradeChainActionHistoryInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}