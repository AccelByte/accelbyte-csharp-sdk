// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getCode
    ///
    /// Get campaign code, it will check code whether available to redeem if redeemable true.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=2 (READ) (READ)
    ///   *  Returns : code info
    /// </summary>
    public class GetCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCodeBuilder Builder = new GetCodeBuilder();

        public class GetCodeBuilder
            : OperationBuilder<GetCodeBuilder>
        {
            
            
            public bool? Redeemable { get; set; }
            
            internal GetCodeBuilder() { }


            public GetCodeBuilder SetRedeemable(bool _redeemable)
            {
                Redeemable = _redeemable;
                return this;
            }





            public GetCode Build(
                string code,
                string namespace_
            )
            {
                GetCode op = new GetCode(this,
                    code,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetCode(GetCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            
            if (builder.Redeemable != null) QueryParams["redeemable"] = Convert.ToString(builder.Redeemable)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCode(
            string code,            
            string namespace_,            
            bool? redeemable            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            
            if (redeemable != null) QueryParams["redeemable"] = Convert.ToString(redeemable)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/{code}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.CodeInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}