// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetImagePatchDetail
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get specific image patch version of dedicated servers version.
    /// </summary>
    public class GetImagePatchDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetImagePatchDetailBuilder Builder = new GetImagePatchDetailBuilder();

        public class GetImagePatchDetailBuilder
        {
            
            
            
            internal GetImagePatchDetailBuilder() { }





            public GetImagePatchDetail Build(
                string namespace_,
                string version,
                string versionPatch
            )
            {
                return new GetImagePatchDetail(this,
                    namespace_,                    
                    version,                    
                    versionPatch                    
                );
            }
        }

        private GetImagePatchDetail(GetImagePatchDetailBuilder builder,
            string namespace_,
            string version,
            string versionPatch
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            PathParams["versionPatch"] = versionPatch;
            
            
            
            
            
        }
        #endregion

        public GetImagePatchDetail(
            string namespace_,            
            string version,            
            string versionPatch            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            PathParams["versionPatch"] = versionPatch;
            
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches/{versionPatch}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetImagePatchDetailResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetImagePatchDetailResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetImagePatchDetailResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}