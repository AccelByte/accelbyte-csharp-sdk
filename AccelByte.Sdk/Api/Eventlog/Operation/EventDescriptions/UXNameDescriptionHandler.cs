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
    /// UXNameDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UXNameDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UXNameDescriptionHandlerBuilder Builder = new UXNameDescriptionHandlerBuilder();

        public class UXNameDescriptionHandlerBuilder
        {
            internal UXNameDescriptionHandlerBuilder() { }





            public UXNameDescriptionHandler Build(
            )
            {
                return new UXNameDescriptionHandler(this
                );
            }
        }

        private UXNameDescriptionHandler(UXNameDescriptionHandlerBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public UXNameDescriptionHandler(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/event/descriptions/ux";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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