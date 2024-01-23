// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminPostGameBinaryRecordV1
    ///
    /// Create a game binary record.
    /// 
    /// Other detail info:
    /// 
    /// `key` should follow these rules:
    /// 1. support uppercase and lowercase letters, numbers, and separators **"-"**, **"_"**, **"."** are allowed
    /// 2. begin and end with letters or numbers
    /// 3. spaces are not allowed
    /// 4. separators must not appears twice in a row
    /// 
    /// 
    /// Supported file types: jpeg, jpg, png, bmp, gif, mp3, webp, and bin.
    /// </summary>
    public class AdminPostGameBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostGameBinaryRecordV1Builder Builder { get => new AdminPostGameBinaryRecordV1Builder(); }

        public class AdminPostGameBinaryRecordV1Builder
            : OperationBuilder<AdminPostGameBinaryRecordV1Builder>
        {





            internal AdminPostGameBinaryRecordV1Builder() { }






            public AdminPostGameBinaryRecordV1 Build(
                ModelsGameBinaryRecordCreate body,
                string namespace_
            )
            {
                AdminPostGameBinaryRecordV1 op = new AdminPostGameBinaryRecordV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminPostGameBinaryRecordV1(AdminPostGameBinaryRecordV1Builder builder,
            ModelsGameBinaryRecordCreate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPostGameBinaryRecordV1(
            string namespace_,
            Model.ModelsGameBinaryRecordCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/binaries";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsUploadBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsUploadBinaryRecordResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsUploadBinaryRecordResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUploadBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}