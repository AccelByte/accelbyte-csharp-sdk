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
    /// AdminResetInputValidations
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:CONFIGURATION' [DELETE]
    /// 
    /// This endpoint is used to reset input validation to the default input validation configurations
    /// </summary>
    public class AdminResetInputValidations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminResetInputValidationsBuilder Builder = new AdminResetInputValidationsBuilder();

        public class AdminResetInputValidationsBuilder
            : OperationBuilder<AdminResetInputValidationsBuilder>
        {
            
            internal AdminResetInputValidationsBuilder() { }






            public AdminResetInputValidations Build(
                string field
            )
            {
                AdminResetInputValidations op = new AdminResetInputValidations(this,
                    field                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminResetInputValidations(AdminResetInputValidationsBuilder builder,
            string field
        )
        {
            PathParams["field"] = field;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminResetInputValidations(
            string field            
        )
        {
            PathParams["field"] = field;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/inputValidations/{field}";

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