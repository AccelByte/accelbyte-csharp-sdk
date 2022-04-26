// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// PublicGetUserAccountDeletionStatus
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// </summary>
    public class PublicGetUserAccountDeletionStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserAccountDeletionStatusBuilder Builder = new PublicGetUserAccountDeletionStatusBuilder();

        public class PublicGetUserAccountDeletionStatusBuilder
            : OperationBuilder<PublicGetUserAccountDeletionStatusBuilder>
        {
            
            
            internal PublicGetUserAccountDeletionStatusBuilder() { }






            public PublicGetUserAccountDeletionStatus Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserAccountDeletionStatus op = new PublicGetUserAccountDeletionStatus(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserAccountDeletionStatus(PublicGetUserAccountDeletionStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserAccountDeletionStatus(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/deletions/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsDeletionStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeletionStatus>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeletionStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}