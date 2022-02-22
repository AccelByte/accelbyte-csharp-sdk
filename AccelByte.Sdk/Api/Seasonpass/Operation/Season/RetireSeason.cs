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
    /// retireSeason
    ///
    /// This API is used to retire a published season, if the season has not ended it will report error except with force.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : season info
    /// </summary>
    public class RetireSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetireSeasonBuilder Builder = new RetireSeasonBuilder();

        public class RetireSeasonBuilder
        {
            
            
            public bool? Force { get; set; }
            
            internal RetireSeasonBuilder() { }


            public RetireSeasonBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }




            public RetireSeason Build(
                string namespace_,
                string seasonId
            )
            {
                return new RetireSeason(this,
                    namespace_,                    
                    seasonId                    
                );
            }
        }

        private RetireSeason(RetireSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;
            
            
            
            
        }
        #endregion

        public RetireSeason(
            string namespace_,            
            string seasonId,            
            bool? force            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (force != null) QueryParams["force"] = Convert.ToString(force)!;
            
            
            
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/retire";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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