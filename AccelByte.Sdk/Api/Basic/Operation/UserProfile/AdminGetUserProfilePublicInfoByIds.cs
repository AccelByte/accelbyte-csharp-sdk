// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// adminGetUserProfilePublicInfoByIds
    ///
    /// Admin get user public profile by ids.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:PROFILE" , action=2 (GET)
    ///   *  Action code : 11405
    ///   *  Returns : user public profiles
    /// </summary>
    public class AdminGetUserProfilePublicInfoByIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserProfilePublicInfoByIdsBuilder Builder { get => new AdminGetUserProfilePublicInfoByIdsBuilder(); }

        public class AdminGetUserProfilePublicInfoByIdsBuilder
            : OperationBuilder<AdminGetUserProfilePublicInfoByIdsBuilder>
        {


            public Model.UserProfileBulkRequest? Body { get; set; }




            internal AdminGetUserProfilePublicInfoByIdsBuilder() { }



            public AdminGetUserProfilePublicInfoByIdsBuilder SetBody(Model.UserProfileBulkRequest _body)
            {
                Body = _body;
                return this;
            }




            public AdminGetUserProfilePublicInfoByIds Build(
                string namespace_
            )
            {
                AdminGetUserProfilePublicInfoByIds op = new AdminGetUserProfilePublicInfoByIds(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetUserProfilePublicInfoByIds(AdminGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserProfilePublicInfoByIds(
            string namespace_,
            Model.UserProfileBulkRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/profiles/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.UserProfilePublicInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.UserProfilePublicInfo<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}