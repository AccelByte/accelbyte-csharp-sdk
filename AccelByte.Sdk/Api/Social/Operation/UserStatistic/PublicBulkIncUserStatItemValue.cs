// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicBulkIncUserStatItemValue
    ///
    /// Public bulk update multiple user's statitems value.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:STATITEM", action=4 (UPDATE)
    ///             *  Returns : bulk updated result
    /// </summary>
    public class PublicBulkIncUserStatItemValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkIncUserStatItemValueBuilder Builder { get => new PublicBulkIncUserStatItemValueBuilder(); }

        public class PublicBulkIncUserStatItemValueBuilder
            : OperationBuilder<PublicBulkIncUserStatItemValueBuilder>
        {


            public List<Model.BulkUserStatItemInc>? Body { get; set; }




            internal PublicBulkIncUserStatItemValueBuilder() { }



            public PublicBulkIncUserStatItemValueBuilder SetBody(List<Model.BulkUserStatItemInc> _body)
            {
                Body = _body;
                return this;
            }




            public PublicBulkIncUserStatItemValue Build(
                string namespace_
            )
            {
                PublicBulkIncUserStatItemValue op = new PublicBulkIncUserStatItemValue(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicBulkIncUserStatItemValue(PublicBulkIncUserStatItemValueBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicBulkIncUserStatItemValue(
            string namespace_,
            List<Model.BulkUserStatItemInc> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.BulkStatOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.BulkStatOperationResult<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}