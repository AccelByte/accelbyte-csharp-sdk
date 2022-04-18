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
    /// SaveAdminEmailConfiguration
    ///
    /// Add admin email address for receiving personal data request notification.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EMAIL:CONFIGURATION [CREATE]` and scope `account`
    /// </summary>
    public class SaveAdminEmailConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SaveAdminEmailConfigurationBuilder Builder = new SaveAdminEmailConfigurationBuilder();

        public class SaveAdminEmailConfigurationBuilder
            : OperationBuilder<SaveAdminEmailConfigurationBuilder>
        {
            
            
            internal SaveAdminEmailConfigurationBuilder() { }





            public SaveAdminEmailConfiguration Build(
                List<string> body,
                string namespace_
            )
            {
                SaveAdminEmailConfiguration op = new SaveAdminEmailConfiguration(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SaveAdminEmailConfiguration(SaveAdminEmailConfigurationBuilder builder,
            List<string> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SaveAdminEmailConfiguration(
            string namespace_,            
            List<string> body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/emails/configurations";

        public override HttpMethod Method => HttpMethod.Post;

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