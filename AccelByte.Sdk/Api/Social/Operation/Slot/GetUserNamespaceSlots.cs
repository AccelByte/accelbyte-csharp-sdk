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
    /// getUserNamespaceSlots
    ///
    /// GetÂ slots for a given user.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=2 (READ)
    ///         *  Returns : list of slots
    /// </summary>
    public class GetUserNamespaceSlots : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserNamespaceSlotsBuilder Builder = new GetUserNamespaceSlotsBuilder();

        public class GetUserNamespaceSlotsBuilder
        {
            
            
            internal GetUserNamespaceSlotsBuilder() { }





            public GetUserNamespaceSlots Build(
                string namespace_,
                string userId
            )
            {
                return new GetUserNamespaceSlots(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetUserNamespaceSlots(GetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public GetUserNamespaceSlots(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/slots";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.SlotInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}