using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// CreateUserFromInvitationV4
    ///
    /// This endpoint create user from saved roles when creating invitation and
    /// submitted data. User will be able to login after completing submitting the
    /// data through this endpoint. Available Authentication Types: EMAILPASSWD: an
    /// authentication type used for new user registration through email. Country use
    /// ISO3166-1 alpha-2 two letter, e.g. US. Date of Birth format : YYYY-MM-DD, e.g.
    /// 2019-04-29. Required attributes: - authType: possible value is EMAILPASSWD
    /// (see above) - country: ISO3166-1 alpha-2 two letter, e.g. US. - dateOfBirth:
    /// YYYY-MM-DD, e.g. 1990-01-01. valid values are between 1905-01-01 until current
    /// date. - displayName: case insensitive, alphanumeric with allowed symbols dash
    /// (-), comma (,), and dot (.) - password: 8 to 32 characters, satisfy at least
    /// 3 out of 4 conditions(uppercase, lowercase letters, numbers and special
    /// characters) and should not have more than 2 equal characters in a row. -
    /// username: case insensitive, alphanumeric with allowed symbols underscore (_)
    /// and dot (.)
    /// </summary>
    public class CreateUserFromInvitationV4 : AccelByte.Sdk.Core.Operation
    {
        public CreateUserFromInvitationV4(
            string invitationId,            
            string namespace_,            
            Model.ModelUserCreateFromInvitationRequestV4 body            
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountCreateUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}