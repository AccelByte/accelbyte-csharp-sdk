using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminUpdateInputValidations
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:CONFIGURATION' [UPDATE]
    /// 
    /// This endpoint is used to update input validation configuration.
    /// 
    /// Supported `field`:
    /// 
    ///           * displayName
    ///           * password
    ///           * username
    /// 
    /// If `isCustomRegex` is set to true, `regex` parameter will be used as input
    /// validation and the other parameters will be ignored. Otherwise, `regex`
    /// parameter will be ignored and regex for input validation will be generated
    /// based on the combination of the other parameters.
    /// 
    /// If `allowUnicode` is set to true, unicode regex pattern will be use as the
    /// input validation and the other parameters will be ignored.
    /// 
    /// Supported `letterCase`:
    /// 
    ///           * lowercase
    ///           * uppercase
    ///           * mixed: uppercase and lowercase
    ///           * mixed: uppercase and/or lowercase
    /// Supported `specialCharacterLocation`:
    /// 
    ///           * anywhere
    ///           * middle
    /// 
    /// If `specialCharacters` is empty, `specialCharacterLocation` and
    /// `maxRepeatingSpecialCharacter` will be ignored.
    /// 
    /// `minCharType` is used to identify how many required criteria in the regex. The
    /// supported criteria are number, letter, special character, and letter case. If
    /// set to 0 or 1 means all criteria are optional. It can be set as much as the
    /// number of criteria enabled.
    /// </summary>
    public class AdminUpdateInputValidations : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateInputValidations(
            List<Model.ModelInputValidationUpdatePayload> body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/inputValidations";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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