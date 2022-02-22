// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminImportProfanityFiltersFromFile
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [CREATE]` with scope `social`
    /// 
    /// import a file with filters
    /// </summary>
    public class AdminImportProfanityFiltersFromFile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminImportProfanityFiltersFromFileBuilder Builder = new AdminImportProfanityFiltersFromFileBuilder();

        public class AdminImportProfanityFiltersFromFileBuilder
        {
            
            
            
            internal AdminImportProfanityFiltersFromFileBuilder() { }





            public AdminImportProfanityFiltersFromFile Build(
                List<long> body,
                string list,
                string namespace_
            )
            {
                return new AdminImportProfanityFiltersFromFile(this,
                    body,                    
                    list,                    
                    namespace_                    
                );
            }
        }

        private AdminImportProfanityFiltersFromFile(AdminImportProfanityFiltersFromFileBuilder builder,
            List<long> body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminImportProfanityFiltersFromFile(
            string list,            
            string namespace_,            
            List<long> body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk-file";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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