// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminDeleteProfanityList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [DELETE]` with scope `social`
    /// 
    /// delete a list include all filters inside of it
    /// </summary>
    public class AdminDeleteProfanityList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteProfanityListBuilder Builder = new AdminDeleteProfanityListBuilder();

        public class AdminDeleteProfanityListBuilder
            : OperationBuilder<AdminDeleteProfanityListBuilder>
        {
            
            
            internal AdminDeleteProfanityListBuilder() { }






            public AdminDeleteProfanityList Build(
                string list,
                string namespace_
            )
            {
                AdminDeleteProfanityList op = new AdminDeleteProfanityList(this,
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteProfanityList(AdminDeleteProfanityListBuilder builder,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteProfanityList(
            string list,            
            string namespace_            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}