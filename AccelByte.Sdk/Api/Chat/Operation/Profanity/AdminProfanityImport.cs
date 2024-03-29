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
    /// adminProfanityImport
    ///
    /// Import profanity words
    /// </summary>
    public class AdminProfanityImport : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminProfanityImportBuilder Builder { get => new AdminProfanityImportBuilder(); }

        public class AdminProfanityImportBuilder
            : OperationBuilder<AdminProfanityImportBuilder>
        {

            public AdminProfanityImportAction? Action { get; set; }

            public bool? ShowResult { get; set; }





            internal AdminProfanityImportBuilder() { }


            public AdminProfanityImportBuilder SetAction(AdminProfanityImportAction _action)
            {
                Action = _action;
                return this;
            }

            public AdminProfanityImportBuilder SetShowResult(bool _showResult)
            {
                ShowResult = _showResult;
                return this;
            }





            public AdminProfanityImport Build(
                Stream file,
                string namespace_
            )
            {
                AdminProfanityImport op = new AdminProfanityImport(this,
                    file,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminProfanityImport(AdminProfanityImportBuilder builder,
            Stream file,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Action is not null) QueryParams["action"] = builder.Action.Value;
            if (builder.ShowResult != null) QueryParams["showResult"] = Convert.ToString(builder.ShowResult)!;

            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminProfanityImport(
            string namespace_,
            AdminProfanityImportAction? action,
            bool? showResult,
            Stream file
        )
        {
            PathParams["namespace"] = namespace_;

            if (action is not null) QueryParams["action"] = action.Value;
            if (showResult != null) QueryParams["showResult"] = Convert.ToString(showResult)!;

            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsDictionaryImportResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsDictionaryImportResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsDictionaryImportResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDictionaryImportResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminProfanityImportAction : StringEnum<AdminProfanityImportAction>
    {
        public static readonly AdminProfanityImportAction FULLREPLACE
            = new AdminProfanityImportAction("FULLREPLACE");

        public static readonly AdminProfanityImportAction LEAVEOUT
            = new AdminProfanityImportAction("LEAVEOUT");

        public static readonly AdminProfanityImportAction REPLACE
            = new AdminProfanityImportAction("REPLACE");


        public static implicit operator AdminProfanityImportAction(string value)
        {
            return NewValue(value);
        }

        public AdminProfanityImportAction(string enumValue)
            : base(enumValue)
        {

        }
    }

}