// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// deleteCountryGroup
    ///
    /// Delete a country groups by its country group code. This endpoint usually used for testing purpose to cleanup test data.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=8 (DELETE)
    /// </summary>
    public class DeleteCountryGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteCountryGroupBuilder Builder = new DeleteCountryGroupBuilder();

        public class DeleteCountryGroupBuilder
            : OperationBuilder<DeleteCountryGroupBuilder>
        {
            
            
            internal DeleteCountryGroupBuilder() { }





            public DeleteCountryGroup Build(
                string countryGroupCode,
                string namespace_
            )
            {
                DeleteCountryGroup op = new DeleteCountryGroup(this,
                    countryGroupCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteCountryGroup(DeleteCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteCountryGroup(
            string countryGroupCode,            
            string namespace_            
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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