// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// SingleAdminDeleteGroup
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENTGROUP [DELETE]
    /// </summary>
    public class SingleAdminDeleteGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminDeleteGroupBuilder Builder = new SingleAdminDeleteGroupBuilder();

        public class SingleAdminDeleteGroupBuilder
            : OperationBuilder<SingleAdminDeleteGroupBuilder>
        {
            
            
            internal SingleAdminDeleteGroupBuilder() { }






            public SingleAdminDeleteGroup Build(
                string groupId,
                string namespace_
            )
            {
                SingleAdminDeleteGroup op = new SingleAdminDeleteGroup(this,
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SingleAdminDeleteGroup(SingleAdminDeleteGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SingleAdminDeleteGroup(
            string groupId,            
            string namespace_            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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