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
    /// ResetPasswordV3
    ///
    /// 
    /// 
    /// action code: 10105
    /// </summary>
    public class ResetPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetPasswordV3Builder Builder = new ResetPasswordV3Builder();

        public class ResetPasswordV3Builder
        {
            
            
            internal ResetPasswordV3Builder() { }





            public ResetPasswordV3 Build(
                ModelResetPasswordRequestV3 body,
                string namespace_
            )
            {
                return new ResetPasswordV3(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private ResetPasswordV3(ResetPasswordV3Builder builder,
            ModelResetPasswordRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public ResetPasswordV3(
            string namespace_,            
            Model.ModelResetPasswordRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/reset";

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