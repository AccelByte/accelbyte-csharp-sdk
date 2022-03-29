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
    /// Required permission: `NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [CREATE]`
    /// Required scope: `social`
    /// 
    /// 
    /// 
    /// ## Description
    /// 
    /// 
    /// 
    /// This endpoints will create new player record or append the existing player record.
    /// Only user that own the existing player record could modify.
    /// 
    ///  Append example:
    /// 
    /// Example 1
    /// - Existing JSON:
    /// 
    /// 
    /// 
    ///     { "data1": "value" }
    /// 
    /// 
    /// - New JSON:
    /// 
    /// 
    /// 
    ///     { "data2": "new value" }
    /// 
    /// 
    /// - Result:
    /// 
    /// 
    /// 
    ///     { "data1": "value", "data2": "new value" }
    /// 
    /// 
    /// 
    /// Example 2
    /// - Existing JSON:
    /// 
    /// 
    /// 
    ///     { "data1": { "data2": "value" }
    /// 
    /// 
    /// - New JSON:
    /// 
    /// 
    /// 
    ///     { "data1": { "data3": "new value" }
    /// 
    /// 
    /// - Result:
    /// 
    /// 
    /// 
    ///     { "data1": { "data2": "value", "data3": "new value" }
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Record Metadata
    /// 
    /// 
    /// 
    /// Metadata allows user to define the behaviour of the record.
    /// Metadata can be defined in request body with field name META.
    /// When creating record, if META field is not defined, the metadata value will use the default value.
    /// When updating record, if META field is not defined, the existing metadata value will stay as is.
    /// 
    ///  Metadata List:
    /// 1. is_public (default: false, type: bool)
    /// Indicate whether the player record is a public record or not.
    /// 
    ///  Request Body Example:
    /// 
    /// 
    /// 
    /// 
    ///         {
    ///             "META": {
    ///                 "is_public": true
    ///             }
    ///             ...
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