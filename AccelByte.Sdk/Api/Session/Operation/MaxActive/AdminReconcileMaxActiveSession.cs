// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminReconcileMaxActiveSession
    ///
    /// 
    /// Reconcile Max Active Session.
    /// </summary>
    public class AdminReconcileMaxActiveSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminReconcileMaxActiveSessionBuilder Builder { get => new AdminReconcileMaxActiveSessionBuilder(); }

        public class AdminReconcileMaxActiveSessionBuilder
            : OperationBuilder<AdminReconcileMaxActiveSessionBuilder>
        {





            internal AdminReconcileMaxActiveSessionBuilder() { }






            public AdminReconcileMaxActiveSession Build(
                ModelsRequestReconcileMaxActiveSession body,
                string name,
                string namespace_
            )
            {
                AdminReconcileMaxActiveSession op = new AdminReconcileMaxActiveSession(this,
                    body,
                    name,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminReconcileMaxActiveSession(AdminReconcileMaxActiveSessionBuilder builder,
            ModelsRequestReconcileMaxActiveSession body,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminReconcileMaxActiveSession(
            string name,
            string namespace_,
            Model.ModelsRequestReconcileMaxActiveSession body
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configurations/{name}/reconcile";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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