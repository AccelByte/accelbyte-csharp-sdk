// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// deleteRewardConditionRecord
    ///
    /// [TEST FACILITY ONLY] Forbidden in live environment. This API is used to delete a reward condition record by reward Id and condition Name (optional).
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=8 (DELETE)
    ///   *  Returns : 204 No Content
    /// </summary>
    public class DeleteRewardConditionRecord : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRewardConditionRecordBuilder Builder = new DeleteRewardConditionRecordBuilder();

        public class DeleteRewardConditionRecordBuilder
            : OperationBuilder<DeleteRewardConditionRecordBuilder>
        {


            public Model.DeleteRewardConditionRequest? Body { get; set; }




            internal DeleteRewardConditionRecordBuilder() { }



            public DeleteRewardConditionRecordBuilder SetBody(Model.DeleteRewardConditionRequest _body)
            {
                Body = _body;
                return this;
            }




            public DeleteRewardConditionRecord Build(
                string namespace_,
                string rewardId
            )
            {
                DeleteRewardConditionRecord op = new DeleteRewardConditionRecord(this,
                    namespace_,                    
                    rewardId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteRewardConditionRecord(DeleteRewardConditionRecordBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteRewardConditionRecord(
            string namespace_,            
            string rewardId,            
            Model.DeleteRewardConditionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}/record";

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