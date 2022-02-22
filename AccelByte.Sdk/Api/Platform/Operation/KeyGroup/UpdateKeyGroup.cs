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
    /// updateKeyGroup
    ///
    /// Update key group.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=4 (UPDATE)
    ///   *  Returns : updated key group
    /// </summary>
    public class UpdateKeyGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateKeyGroupBuilder Builder = new UpdateKeyGroupBuilder();

        public class UpdateKeyGroupBuilder
        {
            
            
            public Model.KeyGroupUpdate? Body { get; set; }
            
            internal UpdateKeyGroupBuilder() { }



            public UpdateKeyGroupBuilder SetBody(Model.KeyGroupUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdateKeyGroup Build(
                string keyGroupId,
                string namespace_
            )
            {
                return new UpdateKeyGroup(this,
                    keyGroupId,                    
                    namespace_                    
                );
            }
        }

        private UpdateKeyGroup(UpdateKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateKeyGroup(
            string keyGroupId,            
            string namespace_,            
            Model.KeyGroupUpdate body            
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.KeyGroupInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}