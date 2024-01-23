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
    /// syncEpicGameDLC
    ///
    /// Sync epic games dlc items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:USER:{userId}:DLC, action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncEpicGameDLC : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncEpicGameDLCBuilder Builder { get => new SyncEpicGameDLCBuilder(); }

        public class SyncEpicGameDLCBuilder
            : OperationBuilder<SyncEpicGameDLCBuilder>
        {


            public Model.EpicGamesDLCSyncRequest? Body { get; set; }




            internal SyncEpicGameDLCBuilder() { }



            public SyncEpicGameDLCBuilder SetBody(Model.EpicGamesDLCSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncEpicGameDLC Build(
                string namespace_,
                string userId
            )
            {
                SyncEpicGameDLC op = new SyncEpicGameDLC(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private SyncEpicGameDLC(SyncEpicGameDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncEpicGameDLC(
            string namespace_,
            string userId,
            Model.EpicGamesDLCSyncRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/dlc/epicgames/sync";

        public override HttpMethod Method => HttpMethod.Put;

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