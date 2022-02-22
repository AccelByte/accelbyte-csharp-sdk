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
    /// createCodes
    ///
    /// This API is used to create campaign codes, it will increase the batch No. based on last creation.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=1 (CREATE)
    ///   *  Returns : number of codes created
    /// </summary>
    public class CreateCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateCodesBuilder Builder = new CreateCodesBuilder();

        public class CreateCodesBuilder
        {
            
            
            public Model.CodeCreate? Body { get; set; }
            
            internal CreateCodesBuilder() { }



            public CreateCodesBuilder SetBody(Model.CodeCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateCodes Build(
                string campaignId,
                string namespace_
            )
            {
                return new CreateCodes(this,
                    campaignId,                    
                    namespace_                    
                );
            }
        }

        private CreateCodes(CreateCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateCodes(
            string campaignId,            
            string namespace_,            
            Model.CodeCreate body            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CodeCreateResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeCreateResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeCreateResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}