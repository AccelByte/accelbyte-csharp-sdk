// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RevokeAUser
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// 
    /// 
    /// This endpoint revokes a user.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint requires all requests to have Authorization header set with Bearer access authentication with valid access token.
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userID}:ADMIN [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// When other clients know that the userID has been revoked and the token is issued before the revocation, forcing a new token will contain banned permissions.
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/revoke [POST]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class RevokeAUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeAUserBuilder Builder { get => new RevokeAUserBuilder(); }

        public class RevokeAUserBuilder
            : OperationBuilder<RevokeAUserBuilder>
        {





            internal RevokeAUserBuilder() { }






            public RevokeAUser Build(
                string userID
            )
            {
                RevokeAUser op = new RevokeAUser(this,
                    userID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private RevokeAUser(RevokeAUserBuilder builder,
            string userID
        )
        {


            if (userID is not null) FormParams["userID"] = userID;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RevokeAUser(
            string userID
        )
        {


            if (userID is not null) FormParams["userID"] = userID;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/revoke/user";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

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