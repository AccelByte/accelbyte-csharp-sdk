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
    /// GetImagePatches
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get image patches by version.
    /// </summary>
    public class GetImagePatches : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetImagePatchesBuilder Builder = new GetImagePatchesBuilder();

        public class GetImagePatchesBuilder
            : OperationBuilder<GetImagePatchesBuilder>
        {
            
            
            internal GetImagePatchesBuilder() { }





            public GetImagePatches Build(
                string namespace_,
                string version
            )
            {
                GetImagePatches op = new GetImagePatches(this,
                    namespace_,                    
                    version                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetImagePatches(GetImagePatchesBuilder builder,
            string namespace_,
            string version
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetImagePatches(
            string namespace_,            
            string version            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsListImagePatchesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImagePatchesResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImagePatchesResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}