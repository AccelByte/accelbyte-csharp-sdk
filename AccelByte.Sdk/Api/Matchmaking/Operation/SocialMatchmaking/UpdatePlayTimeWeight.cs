// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// UpdatePlayTimeWeight
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Update a connection weight between player and playtime.
    /// 
    /// This endpoint is intended to be called by admin for debugging purpose on social matchmaking rule.
    /// </summary>
    public class UpdatePlayTimeWeight : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePlayTimeWeightBuilder Builder = new UpdatePlayTimeWeightBuilder();

        public class UpdatePlayTimeWeightBuilder
            : OperationBuilder<UpdatePlayTimeWeightBuilder>
        {





            internal UpdatePlayTimeWeightBuilder() { }






            public UpdatePlayTimeWeight Build(
                ModelsUpdatePlayTimeWeightRequest body,
                string namespace_
            )
            {
                UpdatePlayTimeWeight op = new UpdatePlayTimeWeight(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdatePlayTimeWeight(UpdatePlayTimeWeightBuilder builder,
            ModelsUpdatePlayTimeWeightRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePlayTimeWeight(
            string namespace_,            
            Model.ModelsUpdatePlayTimeWeightRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/social/playtime/namespaces/{namespace}/weight";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsUpdatePlayerPlaytimeWeightResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdatePlayerPlaytimeWeightResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdatePlayerPlaytimeWeightResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}