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
    /// banUsers
    ///
    /// Ban user.
    /// actionId: 1 means permanent ban, actionId: 10 means Temporary ban.Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:ACTION" , action=4 (UPDATE)
    /// </summary>
    public class BanUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BanUsersBuilder Builder = new BanUsersBuilder();

        public class BanUsersBuilder
        {
            
            public Model.UserBanRequest? Body { get; set; }
            
            internal BanUsersBuilder() { }



            public BanUsersBuilder SetBody(Model.UserBanRequest _body)
            {
                Body = _body;
                return this;
            }



            public BanUsers Build(
                string namespace_
            )
            {
                return new BanUsers(this,
                    namespace_                    
                );
            }
        }

        private BanUsers(BanUsersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public BanUsers(
            string namespace_,            
            Model.UserBanRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/ban";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if ( code == (HttpStatusCode)400 || code == (HttpStatusCode)404 || code == (HttpStatusCode)422 || code == (HttpStatusCode)500 )
            {
                var payloadString = Helper.ConvertInputStreamToString(payload);
                
                throw new HttpResponseException(code, payloadString);
            }
        }
    }
}