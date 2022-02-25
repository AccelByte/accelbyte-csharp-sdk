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
    /// DeleteImagePatch
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will delete an image patch that specified in the request parameter
    /// </summary>
    public class DeleteImagePatch : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteImagePatchBuilder Builder = new DeleteImagePatchBuilder();

        public class DeleteImagePatchBuilder
        {
            
            
            
            
            internal DeleteImagePatchBuilder() { }





            public DeleteImagePatch Build(
                string namespace_,
                string imageURI,
                string version,
                string versionPatch
            )
            {
                return new DeleteImagePatch(this,
                    namespace_,                    
                    imageURI,                    
                    version,                    
                    versionPatch                    
                );
            }
        }

        private DeleteImagePatch(DeleteImagePatchBuilder builder,
            string namespace_,
            string imageURI,
            string version,
            string versionPatch
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (imageURI != null) QueryParams["imageURI"] = imageURI;
            if (version != null) QueryParams["version"] = version;
            if (versionPatch != null) QueryParams["versionPatch"] = versionPatch;
            
            
            
            
        }
        #endregion

        public DeleteImagePatch(
            string namespace_,            
            string imageURI,            
            string version,            
            string versionPatch            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (imageURI != null) QueryParams["imageURI"] = imageURI;
            if (version != null) QueryParams["version"] = version;
            if (versionPatch != null) QueryParams["versionPatch"] = versionPatch;
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images/patches";

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