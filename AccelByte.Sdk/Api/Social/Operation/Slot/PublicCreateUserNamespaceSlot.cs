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
    /// publicCreateUserNamespaceSlot
    ///
    /// Creates a slot.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=1 (CREATE)
    ///         *  Returns : created slot info
    /// </summary>
    public class PublicCreateUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserNamespaceSlotBuilder Builder = new PublicCreateUserNamespaceSlotBuilder();

        public class PublicCreateUserNamespaceSlotBuilder
            : OperationBuilder<PublicCreateUserNamespaceSlotBuilder>
        {
            
            
            public string? Label { get; set; }
            
            public List<string>? Tags { get; set; }
            
            public string? Checksum { get; set; }
            
            public string? CustomAttribute { get; set; }
            
            public Stream? File { get; set; }
            
            internal PublicCreateUserNamespaceSlotBuilder() { }


            public PublicCreateUserNamespaceSlotBuilder SetLabel(string _label)
            {
                Label = _label;
                return this;
            }

            public PublicCreateUserNamespaceSlotBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }



            public PublicCreateUserNamespaceSlotBuilder SetChecksum(string _checksum)
            {
                Checksum = _checksum;
                return this;
            }

            public PublicCreateUserNamespaceSlotBuilder SetCustomAttribute(string _customAttribute)
            {
                CustomAttribute = _customAttribute;
                return this;
            }

            public PublicCreateUserNamespaceSlotBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }


            public PublicCreateUserNamespaceSlot Build(
                string namespace_,
                string userId
            )
            {
                PublicCreateUserNamespaceSlot op = new PublicCreateUserNamespaceSlot(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCreateUserNamespaceSlot(PublicCreateUserNamespaceSlotBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Label != null) QueryParams["label"] = builder.Label;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            
            if (builder.Checksum != null) FormParams["checksum"] = builder.Checksum;
            if (builder.CustomAttribute != null) FormParams["customAttribute"] = builder.CustomAttribute;
            if (builder.File != null) FormParams["file"] = builder.File;
            
            CollectionFormatMap["tags"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateUserNamespaceSlot(
            string namespace_,            
            string userId,            
            string? label,            
            List<string>? tags,            
            string? checksum,            
            string? customAttribute,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (label != null) QueryParams["label"] = label;
            if (tags != null) QueryParams["tags"] = tags;
            
            if (checksum != null) FormParams["checksum"] = checksum;
            if (customAttribute != null) FormParams["customAttribute"] = customAttribute;
            if (file != null) FormParams["file"] = file;
            
            CollectionFormatMap["tags"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

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