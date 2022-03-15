// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetUserActivitiesHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetUserActivitiesHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserActivitiesHandlerBuilder Builder = new GetUserActivitiesHandlerBuilder();

        public class GetUserActivitiesHandlerBuilder
        {
            
            
            public long? Offset { get; set; }
            
            
            internal GetUserActivitiesHandlerBuilder() { }


            public GetUserActivitiesHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetUserActivitiesHandler Build(
                string namespace_,
                string userId,
                long pageSize
            )
            {
                return new GetUserActivitiesHandler(this,
                    namespace_,                    
                    userId,                    
                    pageSize                    
                );
            }
        }

        private GetUserActivitiesHandler(GetUserActivitiesHandlerBuilder builder,
            string namespace_,
            string userId,
            long pageSize
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            
            
            
            
        }
        #endregion

        public GetUserActivitiesHandler(
            string namespace_,            
            string userId,            
            long? offset,            
            long pageSize            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            
            
            
            
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}/activities";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}