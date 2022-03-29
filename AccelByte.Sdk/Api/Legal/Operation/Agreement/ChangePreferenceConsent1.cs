// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// changePreferenceConsent_1
    ///
    /// Change marketing preference consent.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class ChangePreferenceConsent1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChangePreferenceConsent1Builder Builder = new ChangePreferenceConsent1Builder();

        public class ChangePreferenceConsent1Builder
        {
            public List<Model.AcceptAgreementRequest>? Body { get; set; }
            
            internal ChangePreferenceConsent1Builder() { }



            public ChangePreferenceConsent1Builder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }



            public ChangePreferenceConsent1 Build(
            )
            {
                return new ChangePreferenceConsent1(this
                );
            }
        }

        private ChangePreferenceConsent1(ChangePreferenceConsent1Builder builder
        )
        {
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public ChangePreferenceConsent1(
            List<Model.AcceptAgreementRequest> body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/public/agreements/localized-policy-versions/preferences";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}