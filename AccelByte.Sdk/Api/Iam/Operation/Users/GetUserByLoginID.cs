// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetUserByLoginID
    ///
    /// Required permission 'NAMESPACE:{namespace}:USER [READ]'
    /// </summary>
    public class GetUserByLoginID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserByLoginIDBuilder Builder = new GetUserByLoginIDBuilder();

        public class GetUserByLoginIDBuilder
        {
            
            public string? LoginId { get; set; }
            
            internal GetUserByLoginIDBuilder() { }


            public GetUserByLoginIDBuilder SetLoginId(string _loginId)
            {
                LoginId = _loginId;
                return this;
            }




            public GetUserByLoginID Build(
                string namespace_
            )
            {
                return new GetUserByLoginID(this,
                    namespace_                    
                );
            }
        }

        private GetUserByLoginID(GetUserByLoginIDBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.LoginId != null) QueryParams["loginId"] = builder.LoginId;
            
            
            
            
        }
        #endregion

        public GetUserByLoginID(
            string namespace_,            
            string? loginId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (loginId != null) QueryParams["loginId"] = loginId;
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/byLoginId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelPublicUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}