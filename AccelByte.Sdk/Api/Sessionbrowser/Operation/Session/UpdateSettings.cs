// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// UpdateSettings
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// Update game session, used to update OtherSettings
    /// </summary>
    public class UpdateSettings : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSettingsBuilder Builder { get => new UpdateSettingsBuilder(); }

        public class UpdateSettingsBuilder
            : OperationBuilder<UpdateSettingsBuilder>
        {





            internal UpdateSettingsBuilder() { }






            public UpdateSettings Build(
                ModelsUpdateSettingsRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSettings op = new UpdateSettings(this,
                    body,
                    namespace_,
                    sessionID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateSettings(UpdateSettingsBuilder builder,
            ModelsUpdateSettingsRequest body,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateSettings(
            string namespace_,
            string sessionID,
            Model.ModelsUpdateSettingsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/settings";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}