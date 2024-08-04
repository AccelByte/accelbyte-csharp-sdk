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
    /// AdminListUsersStatItems
    ///
    /// Admin list all statItems of user
    /// NOTE: Legacy endpoint , please use POST /v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk/getOrDefault
    ///             * If stat code does not exist, will ignore this stat code.
    ///             * If stat item does not exist, will return default value
    /// Other detail info:
    ///             *  Returns : stat items
    /// </summary>
    public class AdminListUsersStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUsersStatItemsBuilder Builder { get => new AdminListUsersStatItemsBuilder(); }

        public class AdminListUsersStatItemsBuilder
            : OperationBuilder<AdminListUsersStatItemsBuilder>
        {

            public string? AdditionalKey { get; set; }

            public List<string>? StatCodes { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListUsersStatItemsBuilder() { }


            public AdminListUsersStatItemsBuilder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }

            public AdminListUsersStatItemsBuilder SetStatCodes(List<string> _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }

            public AdminListUsersStatItemsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListUsersStatItems Build(
                string namespace_,
                string userId
            )
            {
                AdminListUsersStatItems op = new AdminListUsersStatItems(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListUsersStatItems(AdminListUsersStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["statCodes"] = "multi";
            CollectionFormatMap["tags"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUsersStatItems(
            string namespace_,
            string userId,
            string? additionalKey,
            List<string>? statCodes,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["statCodes"] = "multi";
            CollectionFormatMap["tags"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ADTOObjectForUserStatItemValue>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}