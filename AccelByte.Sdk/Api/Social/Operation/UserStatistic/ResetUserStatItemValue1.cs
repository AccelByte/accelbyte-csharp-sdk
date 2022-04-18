// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// resetUserStatItemValue_1
    ///
    /// Reset user's statitem value for a given namespace and user.
    /// User's statitem value will be reset to the default value defined in the statistic configuration.
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: updated user's statItem
    /// </summary>
    public class ResetUserStatItemValue1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetUserStatItemValue1Builder Builder = new ResetUserStatItemValue1Builder();

        public class ResetUserStatItemValue1Builder
            : OperationBuilder<ResetUserStatItemValue1Builder>
        {
            
            
            
            internal ResetUserStatItemValue1Builder() { }





            public ResetUserStatItemValue1 Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                ResetUserStatItemValue1 op = new ResetUserStatItemValue1(this,
                    namespace_,                    
                    statCode,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ResetUserStatItemValue1(ResetUserStatItemValue1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ResetUserStatItemValue1(
            string namespace_,            
            string statCode,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}