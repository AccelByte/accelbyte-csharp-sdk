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
    /// publicGetUserNamespaceSlots
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Get list of slots for a given user in namespace.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=2 (READ)
    ///         *  Returns : list of slots
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetUserNamespaceSlots : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserNamespaceSlotsBuilder Builder { get => new PublicGetUserNamespaceSlotsBuilder(); }

        public class PublicGetUserNamespaceSlotsBuilder
            : OperationBuilder<PublicGetUserNamespaceSlotsBuilder>
        {





            internal PublicGetUserNamespaceSlotsBuilder() { }






            public PublicGetUserNamespaceSlots Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserNamespaceSlots op = new PublicGetUserNamespaceSlots(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicGetUserNamespaceSlots(PublicGetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserNamespaceSlots(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.SlotInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}