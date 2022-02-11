using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// ImportAchievements
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [UPDATE] Required
    /// Scope: social Import channels configuration from file. It will merge with
    /// existing channels. Available import strategy: - leaveOut: if channel with
    /// same key exist, the existing will be used and imported one will be ignored
    /// (default) - replace: if channel with same key exist, the imported channel
    /// will be used and existing one will be removed
    /// </summary>
    public class ImportAchievements : AccelByte.Sdk.Core.Operation
    {
        public ImportAchievements(
            string namespace_,            
            Stream? file,            
            string? strategy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = file;
            if (strategy != null) FormParams["strategy"] = strategy;
            
            
            
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ServiceImportConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServiceImportConfigResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServiceImportConfigResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}