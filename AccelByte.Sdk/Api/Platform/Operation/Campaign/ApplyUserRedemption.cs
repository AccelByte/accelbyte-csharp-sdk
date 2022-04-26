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
    /// applyUserRedemption
    ///
    ///  [SERVICE COMMUNICATION ONLY] Redeem code. If the campaign which the code belongs to is INACTIVE, the code couldn't be redeemed even if its status is ACTIVE.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:REDEMPTION", action=1 (CREATE)
    ///   *  Returns : Redeem result
    /// </summary>
    public class ApplyUserRedemption : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ApplyUserRedemptionBuilder Builder = new ApplyUserRedemptionBuilder();

        public class ApplyUserRedemptionBuilder
            : OperationBuilder<ApplyUserRedemptionBuilder>
        {
            
            
            public Model.RedeemRequest? Body { get; set; }
            
            internal ApplyUserRedemptionBuilder() { }



            public ApplyUserRedemptionBuilder SetBody(Model.RedeemRequest _body)
            {
                Body = _body;
                return this;
            }




            public ApplyUserRedemption Build(
                string namespace_,
                string userId
            )
            {
                ApplyUserRedemption op = new ApplyUserRedemption(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ApplyUserRedemption(ApplyUserRedemptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ApplyUserRedemption(
            string namespace_,            
            string userId,            
            Model.RedeemRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/redemption";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.RedeemResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RedeemResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RedeemResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}