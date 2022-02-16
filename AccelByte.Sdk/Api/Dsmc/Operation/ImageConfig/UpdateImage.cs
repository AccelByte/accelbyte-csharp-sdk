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
    /// UpdateImage
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint will update an image name and/or image persistent flag.
    /// 
    /// Sample image:
    /// {
    /// "namespace":"dewa",
    /// "version":"1.0.0",
    /// "image":"144436415367.dkr.ecr.us-west-2.amazonaws.com/dewa:1.0.0",
    /// "persistent":false
    /// }
    /// ```
    /// </summary>
    public class UpdateImage : AccelByte.Sdk.Core.Operation
    {
        public UpdateImage(
            Model.ModelsImageRecordUpdate body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/admin/images";

        public override HttpMethod Method => HttpMethod.Put;

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