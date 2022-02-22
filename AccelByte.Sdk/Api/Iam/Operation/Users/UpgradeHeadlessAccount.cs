// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// upgradeHeadlessAccount
    ///
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// </summary>
    public class UpgradeHeadlessAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpgradeHeadlessAccountBuilder Builder = new UpgradeHeadlessAccountBuilder();

        public class UpgradeHeadlessAccountBuilder
        {
            
            
            
            internal UpgradeHeadlessAccountBuilder() { }





            public UpgradeHeadlessAccount Build(
                ModelUpgradeHeadlessAccountRequest body,
                string namespace_,
                string userId
            )
            {
                return new UpgradeHeadlessAccount(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private UpgradeHeadlessAccount(UpgradeHeadlessAccountBuilder builder,
            ModelUpgradeHeadlessAccountRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpgradeHeadlessAccount(
            string namespace_,            
            string userId,            
            Model.ModelUpgradeHeadlessAccountRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/upgradeHeadlessAccount";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}