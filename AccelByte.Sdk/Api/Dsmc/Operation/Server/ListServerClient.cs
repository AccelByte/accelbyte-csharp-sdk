// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ListServerClient
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of dedicated servers in a namespace managed by this service.
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class ListServerClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListServerClientBuilder Builder { get => new ListServerClientBuilder(); }

        public class ListServerClientBuilder
            : OperationBuilder<ListServerClientBuilder>
        {

            public string? Region { get; set; }





            internal ListServerClientBuilder() { }


            public ListServerClientBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public ListServerClient Build(
                string namespace_,
                long count,
                long offset
            )
            {
                ListServerClient op = new ListServerClient(this,
                    namespace_,
                    count,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListServerClient(ListServerClientBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListServerClient(
            string namespace_,
            string? region,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (region is not null) QueryParams["region"] = region;
            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}