using System.Net;

namespace AccelByte.Sdk.Core
{
    public class HttpResponse // TODO Make disposable
    {
        public HttpResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            this.Code = code;
            this.ContentType = contentType;
            this.Payload = payload;
        }

        public HttpStatusCode Code { get; }
        public string ContentType { get; }
        public Stream Payload { get; }
    }
}
