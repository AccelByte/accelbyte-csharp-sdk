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
    /// adminPutGameRecordHandlerV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [UPDATE]`
    /// Required scope: `social`
    /// 
    /// 
    /// 
    /// ## Description
    /// 
    /// 
    /// 
    /// This endpoints will create new game record or replace the existing game record.
    /// 
    ///  Replace behaviour:
    /// The existing value will be replaced completely with the new value.
    /// 
    /// Example
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
    ///     { "data2": "new value" }
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
    /// 
    ///  Request Body Example:
    /// 
    /// 
    /// 
    /// 
    ///         {
    ///             "__META": {
    ///                 "set_by": "SERVER"
    ///             }
    ///             ...
    ///         }
    /// </summary>
    public class AdminPutGameRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutGameRecordHandlerV1Builder Builder = new AdminPutGameRecordHandlerV1Builder();

        public class AdminPutGameRecordHandlerV1Builder
            : OperationBuilder<AdminPutGameRecordHandlerV1Builder>
        {
            
            
            
            internal AdminPutGameRecordHandlerV1Builder() { }





            public AdminPutGameRecordHandlerV1 Build(
                ModelsGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutGameRecordHandlerV1 op = new AdminPutGameRecordHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminPutGameRecordHandlerV1(AdminPutGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPutGameRecordHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsGameRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/records/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}