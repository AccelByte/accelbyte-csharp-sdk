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
    /// updateStat
    ///
    /// Update stat.
    /// Other detail info:
    ///           *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=4 (UPDATE)
    ///           *  Returns : updated stat
    /// </summary>
    public class UpdateStat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStatBuilder Builder = new UpdateStatBuilder();

        public class UpdateStatBuilder
        {
            
            
            public Model.StatUpdate? Body { get; set; }
            
            internal UpdateStatBuilder() { }



            public UpdateStatBuilder SetBody(Model.StatUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdateStat Build(
                string namespace_,
                string statCode
            )
            {
                return new UpdateStat(this,
                    namespace_,                    
                    statCode                    
                );
            }
        }

        private UpdateStat(UpdateStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateStat(
            string namespace_,            
            string statCode,            
            Model.StatUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}";

        public override HttpMethod Method => HttpMethod.Patch;

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