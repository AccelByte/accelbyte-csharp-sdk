// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicReportUser
    ///
    /// This API is used to report a game user.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ACTION", action=1 (CREATE)
    /// </summary>
    public class PublicReportUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicReportUserBuilder Builder = new PublicReportUserBuilder();

        public class PublicReportUserBuilder
        {
            
            
            public Model.UserReportRequest? Body { get; set; }
            
            internal PublicReportUserBuilder() { }



            public PublicReportUserBuilder SetBody(Model.UserReportRequest _body)
            {
                Body = _body;
                return this;
            }



            public PublicReportUser Build(
                string namespace_,
                string userId
            )
            {
                return new PublicReportUser(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicReportUser(PublicReportUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PublicReportUser(
            string namespace_,            
            string userId,            
            Model.UserReportRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/actions/report";

        public override HttpMethod Method => HttpMethod.Post;

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