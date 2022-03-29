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
    /// AdminBulkCheckValidUserIDV4
    ///
    /// Use this endpoint to check if userID exists or not
    /// 
    /// Required permission ' ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// Maximum number of userID to be checked is 50
    /// </summary>
    public class AdminBulkCheckValidUserIDV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkCheckValidUserIDV4Builder Builder = new AdminBulkCheckValidUserIDV4Builder();

        public class AdminBulkCheckValidUserIDV4Builder
        {
            
            
            internal AdminBulkCheckValidUserIDV4Builder() { }





            public AdminBulkCheckValidUserIDV4 Build(
                ModelCheckValidUserIDRequestV4 body,
                string namespace_
            )
            {
                return new AdminBulkCheckValidUserIDV4(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private AdminBulkCheckValidUserIDV4(AdminBulkCheckValidUserIDV4Builder builder,
            ModelCheckValidUserIDRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminBulkCheckValidUserIDV4(
            string namespace_,            
            Model.ModelCheckValidUserIDRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/bulk/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelListValidUserIDResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListValidUserIDResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListValidUserIDResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}