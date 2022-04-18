// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// SpecificUXDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SpecificUXDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SpecificUXDescriptionHandlerBuilder Builder = new SpecificUXDescriptionHandlerBuilder();

        public class SpecificUXDescriptionHandlerBuilder
            : OperationBuilder<SpecificUXDescriptionHandlerBuilder>
        {
            public string? Ux { get; set; }
            
            internal SpecificUXDescriptionHandlerBuilder() { }


            public SpecificUXDescriptionHandlerBuilder SetUx(string _ux)
            {
                Ux = _ux;
                return this;
            }




            public SpecificUXDescriptionHandler Build(
            )
            {
                SpecificUXDescriptionHandler op = new SpecificUXDescriptionHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SpecificUXDescriptionHandler(SpecificUXDescriptionHandlerBuilder builder
        )
        {
            
            if (builder.Ux != null) QueryParams["ux"] = builder.Ux;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SpecificUXDescriptionHandler(
            string? ux            
        )
        {
            
            if (ux != null) QueryParams["ux"] = ux;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/descriptions/ux/listByUx";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsMultipleUX? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleUX>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleUX>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}