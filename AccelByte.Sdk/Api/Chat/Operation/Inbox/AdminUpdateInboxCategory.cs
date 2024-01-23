// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminUpdateInboxCategory
    ///
    /// Update inbox category
    /// </summary>
    public class AdminUpdateInboxCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateInboxCategoryBuilder Builder { get => new AdminUpdateInboxCategoryBuilder(); }

        public class AdminUpdateInboxCategoryBuilder
            : OperationBuilder<AdminUpdateInboxCategoryBuilder>
        {





            internal AdminUpdateInboxCategoryBuilder() { }






            public AdminUpdateInboxCategory Build(
                ModelsUpdateInboxCategoryRequest body,
                string category,
                string namespace_
            )
            {
                AdminUpdateInboxCategory op = new AdminUpdateInboxCategory(this,
                    body,
                    category,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateInboxCategory(AdminUpdateInboxCategoryBuilder builder,
            ModelsUpdateInboxCategoryRequest body,
            string category,
            string namespace_
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateInboxCategory(
            string category,
            string namespace_,
            Model.ModelsUpdateInboxCategoryRequest body
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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