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
    /// resetUserStatItemValue
    ///
    /// Reset user's statitem value for a given namespace and user.
    /// User's statitem value will be reset to the default value defined in the statistic configuration.
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: updated user's statItem
    /// </summary>
    public class ResetUserStatItemValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetUserStatItemValueBuilder Builder = new ResetUserStatItemValueBuilder();

        public class ResetUserStatItemValueBuilder
        {
            
            
            
            public string? AdditionalKey { get; set; }
            
            public Model.StatResetInfo? Body { get; set; }
            
            internal ResetUserStatItemValueBuilder() { }


            public ResetUserStatItemValueBuilder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }


            public ResetUserStatItemValueBuilder SetBody(Model.StatResetInfo _body)
            {
                Body = _body;
                return this;
            }



            public ResetUserStatItemValue Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                return new ResetUserStatItemValue(this,
                    namespace_,                    
                    statCode,                    
                    userId                    
                );
            }
        }

        private ResetUserStatItemValue(ResetUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (builder.AdditionalKey != null) QueryParams["additionalKey"] = builder.AdditionalKey;
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public ResetUserStatItemValue(
            string namespace_,            
            string statCode,            
            string userId,            
            string? additionalKey,            
            Model.StatResetInfo body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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