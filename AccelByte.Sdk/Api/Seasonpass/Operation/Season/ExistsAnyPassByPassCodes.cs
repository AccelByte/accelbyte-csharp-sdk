// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// existsAnyPassByPassCodes
    ///
    /// [SERVICE COMMUNICATION ONLY]This API is used to get ownership for any pass codes, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : ownership
    /// </summary>
    public class ExistsAnyPassByPassCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExistsAnyPassByPassCodesBuilder Builder = new ExistsAnyPassByPassCodesBuilder();

        public class ExistsAnyPassByPassCodesBuilder
            : OperationBuilder<ExistsAnyPassByPassCodesBuilder>
        {
            
            
            public List<string>? PassCodes { get; set; }
            
            internal ExistsAnyPassByPassCodesBuilder() { }


            public ExistsAnyPassByPassCodesBuilder SetPassCodes(List<string> _passCodes)
            {
                PassCodes = _passCodes;
                return this;
            }





            public ExistsAnyPassByPassCodes Build(
                string namespace_,
                string userId
            )
            {
                ExistsAnyPassByPassCodes op = new ExistsAnyPassByPassCodes(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ExistsAnyPassByPassCodes(ExistsAnyPassByPassCodesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.PassCodes != null) QueryParams["passCodes"] = builder.PassCodes;
            

            
            CollectionFormatMap["passCodes"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExistsAnyPassByPassCodes(
            string namespace_,            
            string userId,            
            List<string>? passCodes            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (passCodes != null) QueryParams["passCodes"] = passCodes;
            

            
            CollectionFormatMap["passCodes"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes/ownership/any";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}