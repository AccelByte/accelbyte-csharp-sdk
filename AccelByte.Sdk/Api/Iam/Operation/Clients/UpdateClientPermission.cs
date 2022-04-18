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
    /// UpdateClientPermission
    ///
    /// Required permission 'CLIENT:ADMIN [UPDATE]'
    /// </summary>
    public class UpdateClientPermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateClientPermissionBuilder Builder = new UpdateClientPermissionBuilder();

        public class UpdateClientPermissionBuilder
            : OperationBuilder<UpdateClientPermissionBuilder>
        {
            
            
            internal UpdateClientPermissionBuilder() { }





            public UpdateClientPermission Build(
                AccountcommonClientPermissions body,
                string clientId
            )
            {
                UpdateClientPermission op = new UpdateClientPermission(this,
                    body,                    
                    clientId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateClientPermission(UpdateClientPermissionBuilder builder,
            AccountcommonClientPermissions body,
            string clientId
        )
        {
            PathParams["clientId"] = clientId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateClientPermission(
            string clientId,            
            Model.AccountcommonClientPermissions body            
        )
        {
            PathParams["clientId"] = clientId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients/{clientId}/clientpermissions";

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