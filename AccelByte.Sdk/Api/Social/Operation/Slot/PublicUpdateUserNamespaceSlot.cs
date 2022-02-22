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
    /// publicUpdateUserNamespaceSlot
    ///
    /// Updates a slot.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=4 (UPDATE)
    ///         *  Returns : updated slot
    /// </summary>
    public class PublicUpdateUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserNamespaceSlotBuilder Builder = new PublicUpdateUserNamespaceSlotBuilder();

        public class PublicUpdateUserNamespaceSlotBuilder
        {
            
            
            
            public string? Label { get; set; }
            
            public List<string>? Tags { get; set; }
            
            public string? Checksum { get; set; }
            
            public string? CustomAttribute { get; set; }
            
            public Stream? File { get; set; }
            
            internal PublicUpdateUserNamespaceSlotBuilder() { }


            public PublicUpdateUserNamespaceSlotBuilder SetLabel(string _label)
            {
                Label = _label;
                return this;
            }

            public PublicUpdateUserNamespaceSlotBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }



            public PublicUpdateUserNamespaceSlotBuilder SetChecksum(string _checksum)
            {
                Checksum = _checksum;
                return this;
            }

            public PublicUpdateUserNamespaceSlotBuilder SetCustomAttribute(string _customAttribute)
            {
                CustomAttribute = _customAttribute;
                return this;
            }

            public PublicUpdateUserNamespaceSlotBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }


            public PublicUpdateUserNamespaceSlot Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                return new PublicUpdateUserNamespaceSlot(this,
                    namespace_,                    
                    slotId,                    
                    userId                    
                );
            }
        }

        private PublicUpdateUserNamespaceSlot(PublicUpdateUserNamespaceSlotBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            if (builder.Label != null) QueryParams["label"] = builder.Label;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            
            if (builder.Checksum != null) FormParams["checksum"] = builder.Checksum;
            if (builder.CustomAttribute != null) FormParams["customAttribute"] = builder.CustomAttribute;
            if (builder.File != null) FormParams["file"] = builder.File;
            
            CollectionFormatMap["tags"] = "multi";
            
            
        }
        #endregion

        public PublicUpdateUserNamespaceSlot(
            string namespace_,            
            string slotId,            
            string userId,            
            string? label,            
            List<string>? tags,            
            string? checksum,            
            string? customAttribute,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            if (label != null) QueryParams["label"] = label;
            if (tags != null) QueryParams["tags"] = tags;
            
            if (checksum != null) FormParams["checksum"] = checksum;
            if (customAttribute != null) FormParams["customAttribute"] = customAttribute;
            if (file != null) FormParams["file"] = file;
            
            CollectionFormatMap["tags"] = "multi";
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.SlotInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}