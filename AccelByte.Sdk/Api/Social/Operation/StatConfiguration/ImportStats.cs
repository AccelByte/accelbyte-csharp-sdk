// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// importStats
    ///
    /// Import stat configurations for a given namespace from file. At current, only JSON file is supported.
    /// 
    /// Other detail info:
    ///           *  *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:STAT", action=1 (CREATE)
    /// </summary>
    public class ImportStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportStatsBuilder Builder = new ImportStatsBuilder();

        public class ImportStatsBuilder
            : OperationBuilder<ImportStatsBuilder>
        {
            
            public bool? ReplaceExisting { get; set; }
            
            public Stream? File { get; set; }
            
            internal ImportStatsBuilder() { }


            public ImportStatsBuilder SetReplaceExisting(bool _replaceExisting)
            {
                ReplaceExisting = _replaceExisting;
                return this;
            }



            public ImportStatsBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public ImportStats Build(
                string namespace_
            )
            {
                ImportStats op = new ImportStats(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ImportStats(ImportStatsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ReplaceExisting != null) QueryParams["replaceExisting"] = Convert.ToString(builder.ReplaceExisting)!;
            
            if (builder.File != null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ImportStats(
            string namespace_,            
            bool? replaceExisting,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (replaceExisting != null) QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (file != null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.StatImportInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatImportInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatImportInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}