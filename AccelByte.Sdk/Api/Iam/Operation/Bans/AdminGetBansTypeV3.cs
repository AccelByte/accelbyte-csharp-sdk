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
    /// AdminGetBansTypeV3
    ///
    /// Required permission 'ADMIN:BAN [READ]'
    /// Ban type is the code
    /// available for ban assignment. It is applicable globally for any namespace.
    /// action code : 10201
    /// </summary>
    public class AdminGetBansTypeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBansTypeV3Builder Builder = new AdminGetBansTypeV3Builder();

        public class AdminGetBansTypeV3Builder
        {
            internal AdminGetBansTypeV3Builder() { }





            public AdminGetBansTypeV3 Build(
            )
            {
                return new AdminGetBansTypeV3(this
                );
            }
        }

        private AdminGetBansTypeV3(AdminGetBansTypeV3Builder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public AdminGetBansTypeV3(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonBansV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBansV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBansV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}