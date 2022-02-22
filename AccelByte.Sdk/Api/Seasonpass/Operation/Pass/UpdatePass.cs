// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// updatePass
    ///
    /// This API is used to update a pass. Only draft season pass can be updated.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : updated pass
    /// </summary>
    public class UpdatePass : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePassBuilder Builder = new UpdatePassBuilder();

        public class UpdatePassBuilder
        {
            
            
            
            public Model.PassUpdate? Body { get; set; }
            
            internal UpdatePassBuilder() { }



            public UpdatePassBuilder SetBody(Model.PassUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdatePass Build(
                string code,
                string namespace_,
                string seasonId
            )
            {
                return new UpdatePass(this,
                    code,                    
                    namespace_,                    
                    seasonId                    
                );
            }
        }

        private UpdatePass(UpdatePassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdatePass(
            string code,            
            string namespace_,            
            string seasonId,            
            Model.PassUpdate body            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PassInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PassInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PassInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}