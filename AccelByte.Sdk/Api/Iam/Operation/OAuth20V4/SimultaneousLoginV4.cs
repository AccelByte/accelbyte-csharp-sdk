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
    /// SimultaneousLoginV4
    ///
    /// Simultaneous login flow.
    /// 
    /// The primary goals of this project are to entitle players to authenticate on a native PC platform(Steam/Epic) and the PlayStation platform,
    /// link their accounts, and provide support for platform sync with a valid 3rd platform access token.
    /// 
    /// ## Given a valid native ticket and empty simultaneous ticket, these cases will be failed
    /// - Native ticket's account is not linked AGS account yet
    /// - Native ticket's account is linked AGS account, but ASG account is not linked simultaneous platform yet
    /// - Native ticket's account is linked AGS account, AGS account is linked simultaneous platform but there is no available simultaneous token.(only if this platform is expected to store the platform token)
    /// 
    /// ## Given a valid native ticket and empty simultaneous ticket, this case will be success
    /// - Native ticket's account already linked AGS account, this AGS account already linked simultaneous platform. There is valid simultaneous token.(this is required only when this simultaneous is expected to cache platform token)
    /// 
    /// ## Given a valid native ticket token and valid simultaneous ticket, these cases will be failed
    /// #### Native ticket's account is already linked with AGS account
    /// - Native linked AGS account is linked this simultaneous platform but is different with simultaneous ticket's account
    /// - Native linked AGS account is not linked with simultaneous but has a linking history with simultaneous platform and it is different with simultaneous ticket's account
    /// #### Native ticket's account is not linked with AGS account and Simultaneous ticket's account is already linked wth AGS account
    /// - Simultaneous linked AGS account is linked this native platform but is different with native ticket's account
    /// - Simultaneous linked AGS account is not linked with native but has a linking history with native platform and it is different with native ticket's account
    /// 
    /// ## Given a valid native ticket and valid simultaneous ticket, these cases will be success
    /// - Native ticket's account & Simultaneous ticket's account are both not linked to AGS account yet
    /// - Native ticket's account & Simultaneous ticket's account are already linked to same AGS account
    /// </summary>
    public class SimultaneousLoginV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SimultaneousLoginV4Builder Builder { get => new SimultaneousLoginV4Builder(); }

        public class SimultaneousLoginV4Builder
            : OperationBuilder<SimultaneousLoginV4Builder>
        {

            public string? CodeChallenge { get; set; }

            public SimultaneousLoginV4CodeChallengeMethod? CodeChallengeMethod { get; set; }



            public SimultaneousLoginV4SimultaneousPlatform? SimultaneousPlatform { get; set; }

            public string? SimultaneousTicket { get; set; }



            internal SimultaneousLoginV4Builder() { }


            public SimultaneousLoginV4Builder SetCodeChallenge(string _codeChallenge)
            {
                CodeChallenge = _codeChallenge;
                return this;
            }

            public SimultaneousLoginV4Builder SetCodeChallengeMethod(SimultaneousLoginV4CodeChallengeMethod _codeChallengeMethod)
            {
                CodeChallengeMethod = _codeChallengeMethod;
                return this;
            }



            public SimultaneousLoginV4Builder SetSimultaneousPlatform(SimultaneousLoginV4SimultaneousPlatform _simultaneousPlatform)
            {
                SimultaneousPlatform = _simultaneousPlatform;
                return this;
            }

            public SimultaneousLoginV4Builder SetSimultaneousTicket(string _simultaneousTicket)
            {
                SimultaneousTicket = _simultaneousTicket;
                return this;
            }



            public SimultaneousLoginV4 Build(
                SimultaneousLoginV4NativePlatform nativePlatform,
                string nativePlatformTicket
            )
            {
                SimultaneousLoginV4 op = new SimultaneousLoginV4(this,
                    nativePlatform,
                    nativePlatformTicket
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private SimultaneousLoginV4(SimultaneousLoginV4Builder builder,
            SimultaneousLoginV4NativePlatform nativePlatform,
            string nativePlatformTicket
        )
        {

            if (builder.CodeChallenge is not null) QueryParams["code_challenge"] = builder.CodeChallenge;
            if (builder.CodeChallengeMethod is not null) QueryParams["code_challenge_method"] = builder.CodeChallengeMethod.Value;

            if (builder.SimultaneousPlatform is not null) FormParams["simultaneousPlatform"] = builder.SimultaneousPlatform.Value;
            if (builder.SimultaneousTicket is not null) FormParams["simultaneousTicket"] = builder.SimultaneousTicket;
            if (nativePlatform is not null) FormParams["nativePlatform"] = nativePlatform.Value;
            if (nativePlatformTicket is not null) FormParams["nativePlatformTicket"] = nativePlatformTicket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SimultaneousLoginV4(
            string? codeChallenge,
            SimultaneousLoginV4CodeChallengeMethod? codeChallengeMethod,
            SimultaneousLoginV4SimultaneousPlatform? simultaneousPlatform,
            string? simultaneousTicket,
            SimultaneousLoginV4NativePlatform nativePlatform,
            string nativePlatformTicket
        )
        {

            if (codeChallenge is not null) QueryParams["code_challenge"] = codeChallenge;
            if (codeChallengeMethod is not null) QueryParams["code_challenge_method"] = codeChallengeMethod.Value;

            if (simultaneousPlatform is not null) FormParams["simultaneousPlatform"] = simultaneousPlatform.Value;
            if (simultaneousTicket is not null) FormParams["simultaneousTicket"] = simultaneousTicket;
            if (nativePlatform is not null) FormParams["nativePlatform"] = nativePlatform.Value;
            if (nativePlatformTicket is not null) FormParams["nativePlatformTicket"] = nativePlatformTicket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/oauth/simultaneousLogin";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class SimultaneousLoginV4SimultaneousPlatform : StringEnum<SimultaneousLoginV4SimultaneousPlatform>
    {
        public static readonly SimultaneousLoginV4SimultaneousPlatform Pspc
            = new SimultaneousLoginV4SimultaneousPlatform("pspc");


        public static implicit operator SimultaneousLoginV4SimultaneousPlatform(string value)
        {
            return NewValue(value);
        }

        public SimultaneousLoginV4SimultaneousPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class SimultaneousLoginV4NativePlatform : StringEnum<SimultaneousLoginV4NativePlatform>
    {
        public static readonly SimultaneousLoginV4NativePlatform Epicgames
            = new SimultaneousLoginV4NativePlatform("epicgames");

        public static readonly SimultaneousLoginV4NativePlatform Steam
            = new SimultaneousLoginV4NativePlatform("steam");


        public static implicit operator SimultaneousLoginV4NativePlatform(string value)
        {
            return NewValue(value);
        }

        public SimultaneousLoginV4NativePlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class SimultaneousLoginV4CodeChallengeMethod : StringEnum<SimultaneousLoginV4CodeChallengeMethod>
    {
        public static readonly SimultaneousLoginV4CodeChallengeMethod S256
            = new SimultaneousLoginV4CodeChallengeMethod("S256");

        public static readonly SimultaneousLoginV4CodeChallengeMethod Plain
            = new SimultaneousLoginV4CodeChallengeMethod("plain");


        public static implicit operator SimultaneousLoginV4CodeChallengeMethod(string value)
        {
            return NewValue(value);
        }

        public SimultaneousLoginV4CodeChallengeMethod(string enumValue)
            : base(enumValue)
        {

        }
    }

}