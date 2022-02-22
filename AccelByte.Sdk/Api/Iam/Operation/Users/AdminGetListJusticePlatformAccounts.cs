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
    /// AdminGetListJusticePlatformAccounts
    ///
    /// This endpoint gets list justice platform account by providing publisher namespace and publisher userID.
    /// </summary>
    public class AdminGetListJusticePlatformAccounts : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListJusticePlatformAccountsBuilder Builder = new AdminGetListJusticePlatformAccountsBuilder();

        public class AdminGetListJusticePlatformAccountsBuilder
        {
            
            
            internal AdminGetListJusticePlatformAccountsBuilder() { }





            public AdminGetListJusticePlatformAccounts Build(
                string namespace_,
                string userId
            )
            {
                return new AdminGetListJusticePlatformAccounts(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetListJusticePlatformAccounts(AdminGetListJusticePlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminGetListJusticePlatformAccounts(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelGetUserMapping>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserMapping>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserMapping>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}