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
    /// deleteUserStatItems_2
    ///
    /// Delete user's stat items for given namespace, statCode, and user Id.
    /// If query param *additionalKey* is provided, it will delete user stat items of specific key (i.e. characterName).
    /// Otherwise, it will delete all stat items related to the user Id.
    /// 
    /// Delete user's statItems given stat code.
    /// Other detail info:
    ///             *  Returns : no content
    /// </summary>
    public class DeleteUserStatItems2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserStatItems2Builder Builder { get => new DeleteUserStatItems2Builder(); }

        public class DeleteUserStatItems2Builder
            : OperationBuilder<DeleteUserStatItems2Builder>
        {

            public string? AdditionalKey { get; set; }





            internal DeleteUserStatItems2Builder() { }


            public DeleteUserStatItems2Builder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }





            public DeleteUserStatItems2 Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                DeleteUserStatItems2 op = new DeleteUserStatItems2(this,
                    namespace_,
                    statCode,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteUserStatItems2(DeleteUserStatItems2Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;

            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserStatItems2(
            string namespace_,
            string statCode,
            string userId,
            string? additionalKey
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;

            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}