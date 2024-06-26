// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// QoSRegionsUpdate
    ///
    /// ```
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:QOS:SERVER [UPDATE]
    /// 
    /// This endpoint updates the registered QoS service's configurable configuration.
    /// </summary>
    public class QoSRegionsUpdate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QoSRegionsUpdateBuilder Builder { get => new QoSRegionsUpdateBuilder(); }

        public class QoSRegionsUpdateBuilder
            : OperationBuilder<QoSRegionsUpdateBuilder>
        {





            internal QoSRegionsUpdateBuilder() { }






            public QoSRegionsUpdate Build(
                ApiUpdateServerRequest body,
                string namespace_,
                string region
            )
            {
                QoSRegionsUpdate op = new QoSRegionsUpdate(this,
                    body,                    
                    namespace_,                    
                    region                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QoSRegionsUpdate(QoSRegionsUpdateBuilder builder,
            ApiUpdateServerRequest body,
            string namespace_,
            string region
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QoSRegionsUpdate(
            string namespace_,            
            string region,            
            Model.ApiUpdateServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/qos/{region}";

        public override HttpMethod Method => HttpMethod.Patch;

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