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
    /// postGameRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:CLOUDSAVE:RECORD [CREATE]`
    /// --------------------|---------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// If there's already record, the record will be merged with conditions:
    /// - If field name is already exist, the value will be replaced
    /// - If field name is not exists it will append the field and its value
    /// 
    /// Example:
    /// 
    /// Replace value in a specific JSON key
    /// 
    /// 
    /// 
    /// 
    ///     // existed record
    ///     {
    ///         "foo": "bar"
    ///     }
    /// 
    ///     // new update (request body)
    ///     {
    ///         "foo": "barUpdated"
    ///     }
    /// 
    ///     // result
    ///     {
    ///         "foo": "barUpdated"
    ///     }
    /// 
    /// 
    /// 
    /// 
    /// Append new json item
    /// 
    /// 
    /// 
    /// 
    ///     // existed record
    ///     {
    ///         "foo": "bar"
    ///     }
    /// 
    ///     // new update (request body)
    ///     {
    ///         "foo_new": "bar_new"
    ///     }
    /// 
    ///     // result
    ///     {
    ///         "foo": "bar",
    ///         "foo_new": "bar_new"
    ///     }
    /// </summary>
    public class PostGameRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PostGameRecordHandlerV1Builder Builder = new PostGameRecordHandlerV1Builder();

        public class PostGameRecordHandlerV1Builder
        {
            
            
            
            internal PostGameRecordHandlerV1Builder() { }





            public PostGameRecordHandlerV1 Build(
                ModelsGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                return new PostGameRecordHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );
            }
        }

        private PostGameRecordHandlerV1(PostGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PostGameRecordHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsGameRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/records/{key}";

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