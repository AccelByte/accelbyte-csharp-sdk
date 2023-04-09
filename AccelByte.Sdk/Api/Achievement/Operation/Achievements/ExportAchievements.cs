// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// ExportAchievements
    ///
    /// 
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [READ]`
    /// 
    /// Required Scope: `social`
    /// 
    /// Successful response header will contain: `content-disposition: attachment; filename=achievement__config.json`
    /// </summary>
    public class ExportAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportAchievementsBuilder Builder { get => new ExportAchievementsBuilder(); }

        public class ExportAchievementsBuilder
            : OperationBuilder<ExportAchievementsBuilder>
        {

            public List<string>? Tags { get; set; }





            internal ExportAchievementsBuilder() { }


            public ExportAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public ExportAchievements Build(
                string namespace_
            )
            {
                ExportAchievements op = new ExportAchievements(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ExportAchievements(ExportAchievementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExportAchievements(
            string namespace_,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}