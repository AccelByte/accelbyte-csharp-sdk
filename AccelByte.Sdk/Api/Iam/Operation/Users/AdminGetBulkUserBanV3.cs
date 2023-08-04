// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetBulkUserBanV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint returns user bans of userIDs specified in the payload
    /// 
    /// 
    /// 
    /// 
    /// action code : 10127
    /// </summary>
    public class AdminGetBulkUserBanV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBulkUserBanV3Builder Builder { get => new AdminGetBulkUserBanV3Builder(); }

        public class AdminGetBulkUserBanV3Builder
            : OperationBuilder<AdminGetBulkUserBanV3Builder>
        {

            public bool? ActiveOnly { get; set; }

            public string? BanType { get; set; }





            internal AdminGetBulkUserBanV3Builder() { }


            public AdminGetBulkUserBanV3Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public AdminGetBulkUserBanV3Builder SetBanType(string _banType)
            {
                BanType = _banType;
                return this;
            }





            public AdminGetBulkUserBanV3 Build(
                ModelGetBulkUserBansRequest body,
                string namespace_
            )
            {
                AdminGetBulkUserBanV3 op = new AdminGetBulkUserBanV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetBulkUserBanV3(AdminGetBulkUserBanV3Builder builder,
            ModelGetBulkUserBansRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.BanType is not null) QueryParams["banType"] = builder.BanType;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public AdminGetBulkUserBanV3(
            string namespace_,
            bool? activeOnly,
            string? banType,
            Model.ModelGetBulkUserBansRequest body
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (banType is not null) QueryParams["banType"] = banType;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/bans";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public Model.ModelGetUserBanV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}