// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetBansType
    ///
    /// Required permission 'BAN:ADMIN [READ]' or 'ADMIN:BAN [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Required Permission 'BAN:ADMIN [READ]' is going to be DEPRECATED for security purpose.
    /// It is going to be deprecated on 31 JANUARY 2019 , please use permission 'ADMIN:BAN [READ]' instead.
    /// </summary>
    public class GetBansType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBansTypeBuilder Builder = new GetBansTypeBuilder();

        public class GetBansTypeBuilder
        {
            internal GetBansTypeBuilder() { }





            public GetBansType Build(
            )
            {
                return new GetBansType(this
                );
            }
        }

        private GetBansType(GetBansTypeBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public GetBansType(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonBans? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBans>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBans>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}