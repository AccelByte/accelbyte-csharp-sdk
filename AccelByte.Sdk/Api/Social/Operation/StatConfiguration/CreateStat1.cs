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
    /// createStat_1
    ///
    /// Create stat.
    /// Other detail info:
    ///               *  Required permission : resource="NAMESPACE:{namespace}:STAT", action=1 (CREATE)
    ///               *  Returns : created stat template
    /// </summary>
    public class CreateStat1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateStat1Builder Builder = new CreateStat1Builder();

        public class CreateStat1Builder
        {
            
            public Model.StatCreate? Body { get; set; }
            
            internal CreateStat1Builder() { }



            public CreateStat1Builder SetBody(Model.StatCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateStat1 Build(
                string namespace_
            )
            {
                return new CreateStat1(this,
                    namespace_                    
                );
            }
        }

        private CreateStat1(CreateStat1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateStat1(
            string namespace_,            
            Model.StatCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/stats";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StatInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}