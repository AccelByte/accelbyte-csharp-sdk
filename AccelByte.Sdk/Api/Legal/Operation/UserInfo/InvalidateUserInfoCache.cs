// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// invalidateUserInfoCache
    ///
    /// Important: GOING TO DEPRECATE
    /// 
    /// Invalidate user info cache in agreement service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=8 (DELETE)
    /// </summary>
    public class InvalidateUserInfoCache : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static InvalidateUserInfoCacheBuilder Builder = new InvalidateUserInfoCacheBuilder();

        public class InvalidateUserInfoCacheBuilder
            : OperationBuilder<InvalidateUserInfoCacheBuilder>
        {

            public string? Namespace { get; set; }





            internal InvalidateUserInfoCacheBuilder() { }


            public InvalidateUserInfoCacheBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }





            public InvalidateUserInfoCache Build(
            )
            {
                InvalidateUserInfoCache op = new InvalidateUserInfoCache(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private InvalidateUserInfoCache(InvalidateUserInfoCacheBuilder builder
        )
        {
            
            if (builder.Namespace is not null) QueryParams["namespace"] = builder.Namespace;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public InvalidateUserInfoCache(
            string? namespace_            
        )
        {
            
            if (namespace_ is not null) QueryParams["namespace"] = namespace_;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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