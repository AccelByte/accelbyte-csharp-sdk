// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// indirectBulkAcceptVersionedPolicy_1
    ///
    /// Accepts many legal policy versions all at once. Supply with localized version policy id and userId to accept an agreement. This endpoint used by Authentication Service during new user registration.
    /// 
    /// Available Extra Information to return:
    /// 
    /// 
    ///   * userIds : List of userId mapping ( IMPORTANT: GOING TO DEPRECATE )
    /// 
    /// Other detail info:
    ///   * Required permission : login user
    /// </summary>
    public class IndirectBulkAcceptVersionedPolicy1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IndirectBulkAcceptVersionedPolicy1Builder Builder = new IndirectBulkAcceptVersionedPolicy1Builder();

        public class IndirectBulkAcceptVersionedPolicy1Builder
            : OperationBuilder<IndirectBulkAcceptVersionedPolicy1Builder>
        {
            
            public List<Model.AcceptAgreementRequest>? Body { get; set; }
            
            internal IndirectBulkAcceptVersionedPolicy1Builder() { }



            public IndirectBulkAcceptVersionedPolicy1Builder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }



            public IndirectBulkAcceptVersionedPolicy1 Build(
                string userId
            )
            {
                IndirectBulkAcceptVersionedPolicy1 op = new IndirectBulkAcceptVersionedPolicy1(this,
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private IndirectBulkAcceptVersionedPolicy1(IndirectBulkAcceptVersionedPolicy1Builder builder,
            string userId
        )
        {
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public IndirectBulkAcceptVersionedPolicy1(
            string userId,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies/users/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AcceptAgreementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}