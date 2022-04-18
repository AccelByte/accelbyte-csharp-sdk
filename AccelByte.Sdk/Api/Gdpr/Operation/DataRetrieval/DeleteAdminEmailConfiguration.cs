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
    /// DeleteAdminEmailConfiguration
    ///
    /// Delete a list of admin email addresses to stop receiving personal data request notification.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EMAIL:CONFIGURATION [DELETE]` and scope `account`
    /// </summary>
    public class DeleteAdminEmailConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAdminEmailConfigurationBuilder Builder = new DeleteAdminEmailConfigurationBuilder();

        public class DeleteAdminEmailConfigurationBuilder
            : OperationBuilder<DeleteAdminEmailConfigurationBuilder>
        {
            
            
            internal DeleteAdminEmailConfigurationBuilder() { }





            public DeleteAdminEmailConfiguration Build(
                string namespace_,
                List<string> emails
            )
            {
                DeleteAdminEmailConfiguration op = new DeleteAdminEmailConfiguration(this,
                    namespace_,                    
                    emails                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteAdminEmailConfiguration(DeleteAdminEmailConfigurationBuilder builder,
            string namespace_,
            List<string> emails
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (emails != null) QueryParams["emails"] = emails;
            
            
            CollectionFormatMap["emails"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteAdminEmailConfiguration(
            string namespace_,            
            List<string> emails            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (emails != null) QueryParams["emails"] = emails;
            
            
            CollectionFormatMap["emails"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/emails/configurations";

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