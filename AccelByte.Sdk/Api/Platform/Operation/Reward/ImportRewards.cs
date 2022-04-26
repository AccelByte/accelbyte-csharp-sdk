// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// importRewards
    ///
    /// Import reward configurations for a given namespace from file. At current, only JSON file is supported.
    /// 
    /// Other detail info:
    /// 
    ///   *  *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=1 (CREATE)
    /// </summary>
    public class ImportRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportRewardsBuilder Builder = new ImportRewardsBuilder();

        public class ImportRewardsBuilder
            : OperationBuilder<ImportRewardsBuilder>
        {
            
            
            public Stream? File { get; set; }
            
            internal ImportRewardsBuilder() { }




            public ImportRewardsBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public ImportRewards Build(
                string namespace_,
                bool replaceExisting
            )
            {
                ImportRewards op = new ImportRewards(this,
                    namespace_,                    
                    replaceExisting                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ImportRewards(ImportRewardsBuilder builder,
            string namespace_,
            bool replaceExisting
        )
        {
            PathParams["namespace"] = namespace_;
            
            QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (builder.File != null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImportRewards(
            string namespace_,            
            bool replaceExisting,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (file != null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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