// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AddClientPermission
    ///
    /// Required permission 'CLIENT:ADMIN [UPDATE]'
    /// </summary>
    public class AddClientPermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddClientPermissionBuilder Builder = new AddClientPermissionBuilder();

        public class AddClientPermissionBuilder
            : OperationBuilder<AddClientPermissionBuilder>
        {
            
            
            
            internal AddClientPermissionBuilder() { }






            public AddClientPermission Build(
                long action,
                string clientId,
                string resource
            )
            {
                AddClientPermission op = new AddClientPermission(this,
                    action,                    
                    clientId,                    
                    resource                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AddClientPermission(AddClientPermissionBuilder builder,
            long action,
            string clientId,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["resource"] = resource;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddClientPermission(
            long action,            
            string clientId,            
            string resource            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["resource"] = resource;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients/{clientId}/clientpermissions/{resource}/{action}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "*/*" };

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