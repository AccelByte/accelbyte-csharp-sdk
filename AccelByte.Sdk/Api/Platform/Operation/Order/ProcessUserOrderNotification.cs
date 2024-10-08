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
    /// processUserOrderNotification
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used as a web hook for payment notification from justice payment service.
    /// Other detail info:
    /// 
    ///   * Returns : Process result
    /// </summary>
    public class ProcessUserOrderNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ProcessUserOrderNotificationBuilder Builder { get => new ProcessUserOrderNotificationBuilder(); }

        public class ProcessUserOrderNotificationBuilder
            : OperationBuilder<ProcessUserOrderNotificationBuilder>
        {





            internal ProcessUserOrderNotificationBuilder() { }






            public ProcessUserOrderNotification Build(
                TradeNotification body,
                string namespace_,
                string orderNo,
                string userId
            )
            {
                ProcessUserOrderNotification op = new ProcessUserOrderNotification(this,
                    body,
                    namespace_,
                    orderNo,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private ProcessUserOrderNotification(ProcessUserOrderNotificationBuilder builder,
            TradeNotification body,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ProcessUserOrderNotification(
            string namespace_,
            string orderNo,
            string userId,
            Model.TradeNotification body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/notifications";

        public override HttpMethod Method => HttpMethod.Post;

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