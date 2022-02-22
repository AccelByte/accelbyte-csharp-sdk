// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// postPlayerRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [WRITE]`
    /// --------------------|----------------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Create player record if it is not exists otherwise merge with these criteria:
    /// - If field name is already exists, replace the value
    /// - If field name is not exists, append it
    /// 
    /// Example
    /// 
    /// Replace value:
    /// 
    /// 
    /// 
    /// 
    ///         // existed record
    ///         {
    ///             "foo": "bar"
    ///         }
    /// 
    ///         // new record (request body)
    ///         {
    ///             "foo": "bar_updated"
    ///         }
    /// 
    ///         // result
    ///         {
    ///             "foo": "bar_updated"
    ///         }
    /// 
    /// 
    /// 
    /// 
    /// Append value:
    /// 
    /// 
    /// 
    /// 
    ///         // existed record
    ///         {
    ///             "foo": "bar"
    ///         }
    /// 
    ///         // new record (request body)
    ///         {
    ///             "foo_new": "bar_new"
    ///         }
    /// 
    ///         // result
    ///         {
    ///             "foo": "bar",
    ///             "foo_new": "bar_new"
    ///         }
    /// </summary>
    public class PostPlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PostPlayerRecordHandlerV1Builder Builder = new PostPlayerRecordHandlerV1Builder();

        public class PostPlayerRecordHandlerV1Builder
        {
            
            
            
            
            internal PostPlayerRecordHandlerV1Builder() { }





            public PostPlayerRecordHandlerV1 Build(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                return new PostPlayerRecordHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PostPlayerRecordHandlerV1(PostPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PostPlayerRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId,            
            Model.ModelsPlayerRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}