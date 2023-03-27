// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicQueryUserStatItems_1
    ///
    /// Public list all statItems of user.
    /// NOTE:
    ///           * If stat code does not exist, will ignore this stat code.
    ///           * If stat item does not exist, will return default value
    /// Other detail info:
    ///           *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=2 (READ)
    ///           *  Returns : stat items
    /// </summary>
    public class PublicQueryUserStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserStatItems1Builder Builder { get => new PublicQueryUserStatItems1Builder(); }

        public class PublicQueryUserStatItems1Builder
            : OperationBuilder<PublicQueryUserStatItems1Builder>
        {

            public List<string>? StatCodes { get; set; }

            public List<string>? Tags { get; set; }





            internal PublicQueryUserStatItems1Builder() { }


            public PublicQueryUserStatItems1Builder SetStatCodes(List<string> _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }

            public PublicQueryUserStatItems1Builder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicQueryUserStatItems1 Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserStatItems1 op = new PublicQueryUserStatItems1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicQueryUserStatItems1(PublicQueryUserStatItems1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            

            
            CollectionFormatMap["statCodes"] = "multi";
            CollectionFormatMap["tags"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserStatItems1(
            string namespace_,            
            string userId,            
            List<string>? statCodes,            
            List<string>? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;
            if (tags is not null) QueryParams["tags"] = tags;
            

            
            CollectionFormatMap["statCodes"] = "multi";
            CollectionFormatMap["tags"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ADTOObjectForUserStatItemValue>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}