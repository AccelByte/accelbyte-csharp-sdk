// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminDeleteProfanityFilter
    ///
    /// Delete the filter from the list
    /// </summary>
    public class AdminDeleteProfanityFilter : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteProfanityFilterBuilder Builder { get => new AdminDeleteProfanityFilterBuilder(); }

        public class AdminDeleteProfanityFilterBuilder
            : OperationBuilder<AdminDeleteProfanityFilterBuilder>
        {





            internal AdminDeleteProfanityFilterBuilder() { }






            public AdminDeleteProfanityFilter Build(
                ModelsAdminDeleteProfanityFilterRequest body,
                string list,
                string namespace_
            )
            {
                AdminDeleteProfanityFilter op = new AdminDeleteProfanityFilter(this,
                    body,
                    list,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminDeleteProfanityFilter(AdminDeleteProfanityFilterBuilder builder,
            ModelsAdminDeleteProfanityFilterRequest body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteProfanityFilter(
            string list,
            string namespace_,
            Model.ModelsAdminDeleteProfanityFilterRequest body
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/delete";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsProfanityFilter>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}