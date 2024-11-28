// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// DeleteAppV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [DELETE]`
    /// 
    /// Delete App by given DeploymentID
    /// 
    /// This endpoint intended to delete ECR repo, ECR manifests, service images, uninstall helm-release,
    /// and update the deleted_at in DB by given App Name.
    /// 
    /// Required: Valid Access Token
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteAppV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAppV1Builder Builder { get => new DeleteAppV1Builder(); }

        public class DeleteAppV1Builder
            : OperationBuilder<DeleteAppV1Builder>
        {

            public string? Forced { get; set; }





            internal DeleteAppV1Builder() { }


            public DeleteAppV1Builder SetForced(string _forced)
            {
                Forced = _forced;
                return this;
            }





            public DeleteAppV1 Build(
                string app,
                string namespace_
            )
            {
                DeleteAppV1 op = new DeleteAppV1(this,
                    app,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteAppV1(DeleteAppV1Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (builder.Forced is not null) QueryParams["forced"] = builder.Forced;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteAppV1(
            string app,            
            string namespace_,            
            string? forced            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (forced is not null) QueryParams["forced"] = forced;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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