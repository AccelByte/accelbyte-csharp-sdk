// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// ResetPassword
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PASSWORD:USER [UPDATE]' or valid basic auth header
    /// </summary>
    public class ResetPassword : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetPasswordBuilder Builder = new ResetPasswordBuilder();

        public class ResetPasswordBuilder
        {
            
            
            internal ResetPasswordBuilder() { }





            public ResetPassword Build(
                ModelResetPasswordRequest body,
                string namespace_
            )
            {
                return new ResetPassword(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private ResetPassword(ResetPasswordBuilder builder,
            ModelResetPasswordRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public ResetPassword(
            string namespace_,            
            Model.ModelResetPasswordRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/resetPassword";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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