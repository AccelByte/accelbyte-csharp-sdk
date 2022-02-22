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
    /// createKeyGroup
    ///
    /// Create key group.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=1 (CREATE)
    ///   *  Returns : created key group
    /// </summary>
    public class CreateKeyGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateKeyGroupBuilder Builder = new CreateKeyGroupBuilder();

        public class CreateKeyGroupBuilder
        {
            
            public Model.KeyGroupCreate? Body { get; set; }
            
            internal CreateKeyGroupBuilder() { }



            public CreateKeyGroupBuilder SetBody(Model.KeyGroupCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateKeyGroup Build(
                string namespace_
            )
            {
                return new CreateKeyGroup(this,
                    namespace_                    
                );
            }
        }

        private CreateKeyGroup(CreateKeyGroupBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateKeyGroup(
            string namespace_,            
            Model.KeyGroupCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups";

        public override HttpMethod Method => HttpMethod.Post;

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