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
    /// listKeys
    ///
    /// This API is used to list keys of a key group.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=2 (READ)
    ///   *  Returns : keys
    /// </summary>
    public class ListKeys : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListKeysBuilder Builder = new ListKeysBuilder();

        public class ListKeysBuilder
        {
            
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Status { get; set; }
            
            internal ListKeysBuilder() { }


            public ListKeysBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListKeysBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListKeysBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }




            public ListKeys Build(
                string keyGroupId,
                string namespace_
            )
            {
                return new ListKeys(this,
                    keyGroupId,                    
                    namespace_                    
                );
            }
        }

        private ListKeys(ListKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            
            
            
            
        }
        #endregion

        public ListKeys(
            string keyGroupId,            
            string namespace_,            
            int? limit,            
            int? offset,            
            string? status            
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status != null) QueryParams["status"] = status;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.KeyPagingSliceResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.KeyPagingSliceResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyPagingSliceResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}