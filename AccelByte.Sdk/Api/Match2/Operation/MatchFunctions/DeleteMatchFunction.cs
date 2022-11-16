// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// DeleteMatchFunction
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:FUNCTIONS [DELETE]
    /// 
    /// Required Scope: social
    /// 
    /// Deletes an existing match function.
    /// </summary>
    public class DeleteMatchFunction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMatchFunctionBuilder Builder = new DeleteMatchFunctionBuilder();

        public class DeleteMatchFunctionBuilder
            : OperationBuilder<DeleteMatchFunctionBuilder>
        {





            internal DeleteMatchFunctionBuilder() { }






            public DeleteMatchFunction Build(
                string name,
                string namespace_
            )
            {
                DeleteMatchFunction op = new DeleteMatchFunction(this,
                    name,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteMatchFunction(DeleteMatchFunctionBuilder builder,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMatchFunction(
            string name,            
            string namespace_            
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-functions/{name}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}