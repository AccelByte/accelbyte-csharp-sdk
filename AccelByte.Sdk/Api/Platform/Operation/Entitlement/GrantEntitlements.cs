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
    /// grantEntitlements
    ///
    /// Grant entitlements to multiple users, skipped granting will be treated as fail.
    /// 
    /// Notes:
    /// 
    /// Support Item Types:
    /// 
    ///   *  APP
    ///   *  INGAMEITEM
    ///   *  CODE
    ///   *  SUBSCRIPTION
    ///   *  MEDIA
    ///   *  OPTIONBOX
    ///   *  LOOTBOX
    /// 
    /// Other detail info:
    ///   * Returns : bulk grant entitlements result
    /// </summary>
    public class GrantEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantEntitlementsBuilder Builder { get => new GrantEntitlementsBuilder(); }

        public class GrantEntitlementsBuilder
            : OperationBuilder<GrantEntitlementsBuilder>
        {


            public Model.BulkEntitlementGrantRequest? Body { get; set; }




            internal GrantEntitlementsBuilder() { }



            public GrantEntitlementsBuilder SetBody(Model.BulkEntitlementGrantRequest _body)
            {
                Body = _body;
                return this;
            }




            public GrantEntitlements Build(
                string namespace_
            )
            {
                GrantEntitlements op = new GrantEntitlements(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GrantEntitlements(GrantEntitlementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GrantEntitlements(
            string namespace_,
            Model.BulkEntitlementGrantRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements/grant";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.BulkEntitlementGrantResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.BulkEntitlementGrantResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.BulkEntitlementGrantResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkEntitlementGrantResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}