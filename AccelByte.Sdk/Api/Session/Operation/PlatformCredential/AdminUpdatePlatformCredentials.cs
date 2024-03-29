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
    /// adminUpdatePlatformCredentials
    ///
    /// Update platform credentials for Native Session sync. Currently supports PSN platform.
    /// Send an empty body to clear data.
    /// PSN:
    /// - clientID: Auth Server (Client Credential) ClientID
    /// - clientSecret: Auth Server (Client Credential) Secret
    /// - scope: psn:s2s.service (For Sync non PSN member to PSN Session)
    /// </summary>
    public class AdminUpdatePlatformCredentials : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdatePlatformCredentialsBuilder Builder { get => new AdminUpdatePlatformCredentialsBuilder(); }

        public class AdminUpdatePlatformCredentialsBuilder
            : OperationBuilder<AdminUpdatePlatformCredentialsBuilder>
        {





            internal AdminUpdatePlatformCredentialsBuilder() { }






            public AdminUpdatePlatformCredentials Build(
                ApimodelsPutPlatformCredentialsRequest body,
                string namespace_
            )
            {
                AdminUpdatePlatformCredentials op = new AdminUpdatePlatformCredentials(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdatePlatformCredentials(AdminUpdatePlatformCredentialsBuilder builder,
            ApimodelsPutPlatformCredentialsRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdatePlatformCredentials(
            string namespace_,
            Model.ApimodelsPutPlatformCredentialsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/platform-credentials";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPlatformCredentials? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}