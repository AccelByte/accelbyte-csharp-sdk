// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// DeleteUserActivitiesHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteUserActivitiesHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserActivitiesHandlerBuilder Builder = new DeleteUserActivitiesHandlerBuilder();

        public class DeleteUserActivitiesHandlerBuilder
            : OperationBuilder<DeleteUserActivitiesHandlerBuilder>
        {
            
            
            internal DeleteUserActivitiesHandlerBuilder() { }






            public DeleteUserActivitiesHandler Build(
                string namespace_,
                string userId
            )
            {
                DeleteUserActivitiesHandler op = new DeleteUserActivitiesHandler(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteUserActivitiesHandler(DeleteUserActivitiesHandlerBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserActivitiesHandler(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}/activities";

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