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
    /// PublicListUserIDByPlatformUserIDsV3
    ///
    /// List User ID By Platform User ID
    /// This endpoint intended to list game user ID from the given namespace
    /// This endpoint return list of user ID by given platform ID and list of platform user ID
    /// 
    /// **nintendo platform user ID**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class PublicListUserIDByPlatformUserIDsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserIDByPlatformUserIDsV3Builder Builder { get => new PublicListUserIDByPlatformUserIDsV3Builder(); }

        public class PublicListUserIDByPlatformUserIDsV3Builder
            : OperationBuilder<PublicListUserIDByPlatformUserIDsV3Builder>
        {

            public bool? RawPID { get; set; }





            internal PublicListUserIDByPlatformUserIDsV3Builder() { }


            public PublicListUserIDByPlatformUserIDsV3Builder SetRawPID(bool _rawPID)
            {
                RawPID = _rawPID;
                return this;
            }





            public PublicListUserIDByPlatformUserIDsV3 Build(
                ModelPlatformUserIDRequest body,
                string namespace_,
                string platformId
            )
            {
                PublicListUserIDByPlatformUserIDsV3 op = new PublicListUserIDByPlatformUserIDsV3(this,
                    body,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicListUserIDByPlatformUserIDsV3(PublicListUserIDByPlatformUserIDsV3Builder builder,
            ModelPlatformUserIDRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;

            if (builder.RawPID != null) QueryParams["rawPID"] = Convert.ToString(builder.RawPID)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListUserIDByPlatformUserIDsV3(
            string namespace_,
            string platformId,
            bool? rawPID,
            Model.ModelPlatformUserIDRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;

            if (rawPID != null) QueryParams["rawPID"] = Convert.ToString(rawPID)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountcommonUserPlatforms? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}