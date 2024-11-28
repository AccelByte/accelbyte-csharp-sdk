// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateAppleP8File
    ///
    /// Upload Apple Store p8 file.
    /// Other detail info:
    /// 
    ///   * Returns : updated apple iap config
    /// </summary>
    public class UpdateAppleP8File : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppleP8FileBuilder Builder { get => new UpdateAppleP8FileBuilder(); }

        public class UpdateAppleP8FileBuilder
            : OperationBuilder<UpdateAppleP8FileBuilder>
        {



            public Stream? File { get; set; }



            internal UpdateAppleP8FileBuilder() { }




            public UpdateAppleP8FileBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UpdateAppleP8File Build(
                string namespace_
            )
            {
                UpdateAppleP8File op = new UpdateAppleP8File(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateAppleP8File(UpdateAppleP8FileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.File is not null) FormParams["file"] = builder.File;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAppleP8File(
            string namespace_,
            Stream? file
        )
        {
            PathParams["namespace"] = namespace_;


            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/apple/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AppleIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}