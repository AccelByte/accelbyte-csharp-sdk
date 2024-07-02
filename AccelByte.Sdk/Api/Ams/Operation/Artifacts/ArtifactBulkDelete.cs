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
    /// ArtifactBulkDelete
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA [DELETE]
    /// </summary>
    public class ArtifactBulkDelete : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ArtifactBulkDeleteBuilder Builder { get => new ArtifactBulkDeleteBuilder(); }

        public class ArtifactBulkDeleteBuilder
            : OperationBuilder<ArtifactBulkDeleteBuilder>
        {

            public string? ArtifactType { get; set; }

            public string? FleetId { get; set; }

            public DateTime? UploadedBefore { get; set; }





            internal ArtifactBulkDeleteBuilder() { }


            public ArtifactBulkDeleteBuilder SetArtifactType(string _artifactType)
            {
                ArtifactType = _artifactType;
                return this;
            }

            public ArtifactBulkDeleteBuilder SetFleetId(string _fleetId)
            {
                FleetId = _fleetId;
                return this;
            }

            public ArtifactBulkDeleteBuilder SetUploadedBefore(DateTime _uploadedBefore)
            {
                UploadedBefore = _uploadedBefore;
                return this;
            }





            public ArtifactBulkDelete Build(
                string namespace_
            )
            {
                ArtifactBulkDelete op = new ArtifactBulkDelete(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private ArtifactBulkDelete(ArtifactBulkDeleteBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ArtifactType is not null) QueryParams["artifactType"] = builder.ArtifactType;
            if (builder.FleetId is not null) QueryParams["fleetId"] = builder.FleetId;
            if (builder.UploadedBefore != null)
                QueryParams["uploadedBefore"] = builder.UploadedBefore.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ArtifactBulkDelete(
            string namespace_,            
            string? artifactType,            
            string? fleetId,            
            DateTime? uploadedBefore            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (artifactType is not null) QueryParams["artifactType"] = artifactType;
            if (fleetId is not null) QueryParams["fleetId"] = fleetId;
            if (uploadedBefore != null)
                QueryParams["uploadedBefore"] = uploadedBefore.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/artifacts";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}