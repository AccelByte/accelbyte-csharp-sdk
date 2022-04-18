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
    /// adminPostPlayerRecordHandlerV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [CREATE]`
    /// Required scope: `social`
    /// 
    /// 
    /// 
    /// ## Description
    /// 
    /// 
    /// 
    /// This endpoints will create new player record or append the existing player record.
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
    /// ## Record Metadata
    /// 
    /// 
    /// 
    /// Metadata allows user to define the behaviour of the record.
    /// Metadata can be defined in request body with field name __META.
    /// When creating record, if __META field is not defined, the metadata value will use the default value.
    /// When updating record, if __META field is not defined, the existing metadata value will stay as is.
    /// 
    ///  Metadata List:
    /// 1. set_by (default: CLIENT, type: string)
    /// Indicate which party that could modify the game record.
    /// SERVER: record can be modified by server only.
    /// CLIENT: record can be modified by client and server.
    /// 2. is_public (default: false, type: bool)
    /// Indicate whether the player record is a public record or not.
    /// 
    ///  Request Body Example:
    /// 
    /// 
    /// 
    /// 
    ///         {
    ///             "__META": {
    ///                 "set_by": "SERVER",
    ///                 "is_public": true
    ///             }
    ///             ...
    ///         }
    /// </summary>
    public class AdminPostPlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostPlayerRecordHandlerV1Builder Builder = new AdminPostPlayerRecordHandlerV1Builder();

        public class AdminPostPlayerRecordHandlerV1Builder
            : OperationBuilder<AdminPostPlayerRecordHandlerV1Builder>
        {
            
            
            
            
            internal AdminPostPlayerRecordHandlerV1Builder() { }





            public AdminPostPlayerRecordHandlerV1 Build(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerRecordHandlerV1 op = new AdminPostPlayerRecordHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminPostPlayerRecordHandlerV1(AdminPostPlayerRecordHandlerV1Builder builder,
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
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPostPlayerRecordHandlerV1(
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
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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