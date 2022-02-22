// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// ImportChannels
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Update]
    /// 
    /// Required Scope: social
    /// 
    /// Import channels configuration from file. It will merge with existing channels.
    /// Available import strategy:
    /// - leaveOut: if channel with same key exist, the existing will be used and imported one will be ignored (default)
    /// - replace: if channel with same key exist, the imported channel will be used and existing one will be removed
    /// 
    /// Action Code: 510113
    /// </summary>
    public class ImportChannels : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ImportChannelsBuilder Builder = new ImportChannelsBuilder();

        public class ImportChannelsBuilder
        {
            
            public Stream? File { get; set; }
            
            public string? Strategy { get; set; }
            
            internal ImportChannelsBuilder() { }




            public ImportChannelsBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }

            public ImportChannelsBuilder SetStrategy(string _strategy)
            {
                Strategy = _strategy;
                return this;
            }


            public ImportChannels Build(
                string namespace_
            )
            {
                return new ImportChannels(this,
                    namespace_                    
                );
            }
        }

        private ImportChannels(ImportChannelsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File != null) FormParams["file"] = builder.File;
            if (builder.Strategy != null) FormParams["strategy"] = builder.Strategy;
            
            
            
        }
        #endregion

        public ImportChannels(
            string namespace_,            
            Stream? file,            
            string? strategy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = file;
            if (strategy != null) FormParams["strategy"] = strategy;
            
            
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsImportConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}