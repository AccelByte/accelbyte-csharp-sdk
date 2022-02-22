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
    /// UpdatePassword
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated. Admin user please use this instead: iam/v2/admin/namespaces/{namespace}/users/{userId}/password
    /// 
    /// 
    /// +
    /// 
    /// Required permission 'NAMESPACE:{namespace}:PASSWORD:USER:{userId} [UPDATE]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdatePassword : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePasswordBuilder Builder = new UpdatePasswordBuilder();

        public class UpdatePasswordBuilder
        {
            
            
            
            internal UpdatePasswordBuilder() { }





            public UpdatePassword Build(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                return new UpdatePassword(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private UpdatePassword(UpdatePasswordBuilder builder,
            ModelUserPasswordUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdatePassword(
            string namespace_,            
            string userId,            
            Model.ModelUserPasswordUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/password";

        public override HttpMethod Method => HttpMethod.Put;

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