// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateImagePatch
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// Required scope: social
    /// 
    /// This endpoint will create image patch.
    /// 
    /// Sample image:
    /// {
    /// "namespace":"dewa",
    /// "version":"1.0.0",
    /// "patchVersion":"1.0.0-patch",
    /// "image":"144436415367.dkr.ecr.us-west-2.amazonaws.com/dewa:1.0.0-patch",
    /// "persistent":false
    /// }
    /// ```
    /// </summary>
    public class CreateImagePatch : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateImagePatchBuilder Builder = new CreateImagePatchBuilder();

        public class CreateImagePatchBuilder
            : OperationBuilder<CreateImagePatchBuilder>
        {





            internal CreateImagePatchBuilder() { }






            public CreateImagePatch Build(
                ModelsCreateImagePatchRequest body
            )
            {
                CreateImagePatch op = new CreateImagePatch(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateImagePatch(CreateImagePatchBuilder builder,
            ModelsCreateImagePatchRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateImagePatch(
            Model.ModelsCreateImagePatchRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/images/patches";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}