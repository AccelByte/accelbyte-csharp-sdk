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
    /// changePreferenceConsent
    /// </summary>
    public class ChangePreferenceConsent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChangePreferenceConsentBuilder Builder = new ChangePreferenceConsentBuilder();

        public class ChangePreferenceConsentBuilder
        {
            
            
            public List<Model.AcceptAgreementRequest>? Body { get; set; }
            
            internal ChangePreferenceConsentBuilder() { }



            public ChangePreferenceConsentBuilder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }



            public ChangePreferenceConsent Build(
                string namespace_,
                string userId
            )
            {
                return new ChangePreferenceConsent(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private ChangePreferenceConsent(ChangePreferenceConsentBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public ChangePreferenceConsent(
            string namespace_,            
            string userId,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/agreements/localized-policy-versions/preferences/namespaces/{namespace}/userId/{userId}";

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