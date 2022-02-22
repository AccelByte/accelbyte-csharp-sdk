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
    /// GetUserJusticePlatformAccount
    ///
    /// 
    /// 
    /// This endpoint requires the client access token as the bearer token. Required permission 'ADMIN:NAMESPACE:{namespace}:JUSTICE:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    ///  It is going to be removed on November 26th, 2018
    /// 
    /// 
    /// 
    /// 
    /// The endpoint returns user Justice platform account linked with the given user. If the user Justice platform account doesn't exist in the designated namespace, the endpoint is going toÂ create and return the new Justice platform account.
    /// The newly user Justice platform account is going to be forced to perform token grant through the given user and can't perform password update
    /// 
    /// 
    /// 
    /// 
    /// ### Read Justice Platform Account UserID
    /// 
    /// 
    /// 
    /// 
    /// In order to read the Justice platform account UserID, it is required to have the permission: NAMESPACE:{namespace}:JUSTICE:USER:{userId} [READ] , otherwise the UserID is going to be censored and replaced with âRedactedâ text.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetUserJusticePlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserJusticePlatformAccountBuilder Builder = new GetUserJusticePlatformAccountBuilder();

        public class GetUserJusticePlatformAccountBuilder
        {
            
            
            
            internal GetUserJusticePlatformAccountBuilder() { }





            public GetUserJusticePlatformAccount Build(
                string namespace_,
                string targetNamespace,
                string userId
            )
            {
                return new GetUserJusticePlatformAccount(this,
                    namespace_,                    
                    targetNamespace,                    
                    userId                    
                );
            }
        }

        private GetUserJusticePlatformAccount(GetUserJusticePlatformAccountBuilder builder,
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public GetUserJusticePlatformAccount(
            string namespace_,            
            string targetNamespace,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetUserJusticePlatformAccountResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserJusticePlatformAccountResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserJusticePlatformAccountResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}