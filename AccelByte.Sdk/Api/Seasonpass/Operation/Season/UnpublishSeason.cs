// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// unpublishSeason
    ///
    /// This API is used to unpublish a published season, if the season already started it will report error except with force.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : season info
    /// </summary>
    public class UnpublishSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnpublishSeasonBuilder Builder = new UnpublishSeasonBuilder();

        public class UnpublishSeasonBuilder
            : OperationBuilder<UnpublishSeasonBuilder>
        {
            
            
            public bool? Force { get; set; }
            
            internal UnpublishSeasonBuilder() { }


            public UnpublishSeasonBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public UnpublishSeason Build(
                string namespace_,
                string seasonId
            )
            {
                UnpublishSeason op = new UnpublishSeason(this,
                    namespace_,                    
                    seasonId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UnpublishSeason(UnpublishSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnpublishSeason(
            string namespace_,            
            string seasonId,            
            bool? force            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (force != null) QueryParams["force"] = Convert.ToString(force)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/unpublish";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.SeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}