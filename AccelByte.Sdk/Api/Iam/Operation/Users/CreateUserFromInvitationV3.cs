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
    /// CreateUserFromInvitationV3
    ///
    /// This endpoint create user from saved roles when creating invitation and submitted data.
    /// User will be able to login after completing submitting the data through this endpoint.
    /// Available Authentication Types:
    /// 
    /// EMAILPASSWD: an authentication type used for new user registration through email.
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// </summary>
    public class CreateUserFromInvitationV3 : AccelByte.Sdk.Core.Operation
    {
        public CreateUserFromInvitationV3(
            string invitationId,            
            string namespace_,            
            Model.ModelUserCreateFromInvitationRequestV3 body            
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserCreateResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}