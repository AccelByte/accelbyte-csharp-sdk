using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Client
{
    public class HttpClient
    {
        public static readonly IHttpClient Default = new DefaultHttpClient();
    }
}
