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
    /// DeleteUserInformation
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [DELETE]'.
    /// </summary>
    public class DeleteUserInformation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserInformationBuilder Builder = new DeleteUserInformationBuilder();

        public class DeleteUserInformationBuilder
        {
            
            
            internal DeleteUserInformationBuilder() { }





            public DeleteUserInformation Build(
                string namespace_,
                string userId
            )
            {
                return new DeleteUserInformation(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private DeleteUserInformation(DeleteUserInformationBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public DeleteUserInformation(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/information";

        public override HttpMethod Method => HttpMethod.Delete;

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