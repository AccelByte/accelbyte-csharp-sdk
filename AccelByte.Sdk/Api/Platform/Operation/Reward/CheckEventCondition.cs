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
    /// checkEventCondition
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : match result
    /// </summary>
    public class CheckEventCondition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckEventConditionBuilder Builder = new CheckEventConditionBuilder();

        public class CheckEventConditionBuilder
        {
            
            
            public Model.EventPayload? Body { get; set; }
            
            internal CheckEventConditionBuilder() { }



            public CheckEventConditionBuilder SetBody(Model.EventPayload _body)
            {
                Body = _body;
                return this;
            }



            public CheckEventCondition Build(
                string namespace_,
                string rewardId
            )
            {
                return new CheckEventCondition(this,
                    namespace_,                    
                    rewardId                    
                );
            }
        }

        private CheckEventCondition(CheckEventConditionBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CheckEventCondition(
            string namespace_,            
            string rewardId,            
            Model.EventPayload body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}/match";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ConditionMatchResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ConditionMatchResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConditionMatchResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}