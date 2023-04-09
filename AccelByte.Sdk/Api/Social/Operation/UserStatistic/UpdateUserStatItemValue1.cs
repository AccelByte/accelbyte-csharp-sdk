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
    /// updateUserStatItemValue_1
    ///
    /// Public update user's statitem value for a given namespace and user with a certain update strategy.
    /// There are four supported update strategies:
    /// + *OVERRIDE*: update user statitem with the new value
    /// + *INCREMENT*: increment user statitem with the specified value
    /// + *MAX*: update user statitem with the specified value if it's larger than the existing value
    /// + *MIN*: update user statitem with the specified value if it's lower than the existing value
    /// 
    /// The *additionalKey* parameter will be suffixed to *userId* and is used to support multi level user's statitems, such as character's statitems.
    /// If provided, user's statitems will be saved with key: *userId_additionalKey*
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: updated user's statItem
    /// </summary>
    public class UpdateUserStatItemValue1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserStatItemValue1Builder Builder { get => new UpdateUserStatItemValue1Builder(); }

        public class UpdateUserStatItemValue1Builder
            : OperationBuilder<UpdateUserStatItemValue1Builder>
        {

            public string? AdditionalKey { get; set; }


            public Model.StatItemUpdate? Body { get; set; }




            internal UpdateUserStatItemValue1Builder() { }


            public UpdateUserStatItemValue1Builder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }


            public UpdateUserStatItemValue1Builder SetBody(Model.StatItemUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateUserStatItemValue1 Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                UpdateUserStatItemValue1 op = new UpdateUserStatItemValue1(this,
                    namespace_,
                    statCode,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateUserStatItemValue1(UpdateUserStatItemValue1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;

            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateUserStatItemValue1(
            string namespace_,
            string statCode,
            string userId,
            string? additionalKey,
            Model.StatItemUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;

            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}