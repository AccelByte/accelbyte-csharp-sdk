using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PublicGetInputValidations : AccelByte.Sdk.Core.Operation
    {
        public PublicGetInputValidations(
            bool? defaultOnEmpty,            
            string? languageCode            
        )
        {
            
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (languageCode != null) QueryParams["languageCode"] = languageCode;
            
            
            
        }

        public override string Path => "/iam/v3/public/inputValidations";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelInputValidationsPublicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsPublicResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}