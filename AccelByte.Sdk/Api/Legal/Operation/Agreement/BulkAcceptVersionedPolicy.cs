// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// bulkAcceptVersionedPolicy
    ///
    /// Accepts many legal policy versions all at once. Supply with localized version policy id to accept an agreement.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class BulkAcceptVersionedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkAcceptVersionedPolicyBuilder Builder = new BulkAcceptVersionedPolicyBuilder();

        public class BulkAcceptVersionedPolicyBuilder
            : OperationBuilder<BulkAcceptVersionedPolicyBuilder>
        {
            public List<Model.AcceptAgreementRequest>? Body { get; set; }
            
            internal BulkAcceptVersionedPolicyBuilder() { }



            public BulkAcceptVersionedPolicyBuilder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public BulkAcceptVersionedPolicy Build(
            )
            {
                BulkAcceptVersionedPolicy op = new BulkAcceptVersionedPolicy(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkAcceptVersionedPolicy(BulkAcceptVersionedPolicyBuilder builder
        )
        {
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkAcceptVersionedPolicy(
            List<Model.AcceptAgreementRequest> body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies";

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