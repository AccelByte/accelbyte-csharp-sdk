// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// UpdateAppResourcesResourceLimitFormV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [UPDATE]`
    /// 
    /// Update app resources provided on request body
    /// </summary>
    public class UpdateAppResourcesResourceLimitFormV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppResourcesResourceLimitFormV2Builder Builder { get => new UpdateAppResourcesResourceLimitFormV2Builder(); }

        public class UpdateAppResourcesResourceLimitFormV2Builder
            : OperationBuilder<UpdateAppResourcesResourceLimitFormV2Builder>
        {





            internal UpdateAppResourcesResourceLimitFormV2Builder() { }






            public UpdateAppResourcesResourceLimitFormV2 Build(
                ApimodelIncreaseLimitFormRequest body,
                string app,
                string namespace_
            )
            {
                UpdateAppResourcesResourceLimitFormV2 op = new UpdateAppResourcesResourceLimitFormV2(this,
                    body,                    
                    app,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateAppResourcesResourceLimitFormV2(UpdateAppResourcesResourceLimitFormV2Builder builder,
            ApimodelIncreaseLimitFormRequest body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAppResourcesResourceLimitFormV2(
            string app,            
            string namespace_,            
            Model.ApimodelIncreaseLimitFormRequest body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources/form";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}