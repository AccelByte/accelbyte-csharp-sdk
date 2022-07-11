// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.IO;

using Microsoft.AspNetCore.Http;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Sample.OIDC.Web
{
    public class SampleWebAPIMiddleware
    {
        private List<ProviderSpecification> _Providers;

        private readonly RequestDelegate _Next;

        protected OAuthTokens GetAuthorizedToken(ProviderSpecification spec, string authorizationToken)
        {
            HttpClient client = new HttpClient();
            DiscoveryData dData = DiscoveryData.Retrieve(client, spec.DiscoveryUrl);

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, dData.TokenEndpoint);
            req.Content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"grant_type", "authorization_code" },
                {"client_id", spec.ClientId },
                {"client_secret", spec.ClientSecret },
                {"redirect_uri", "http://localhost:9090/callback" },
                {"code", authorizationToken }
            });
            
            HttpResponseMessage response = client.Send(req);
            string jsonString = Helper.ConvertInputStreamToString(response.Content.ReadAsStream());

            return JsonSerializer.Deserialize<OAuthTokens>(jsonString)!;
        }

        public SampleWebAPIMiddleware(RequestDelegate next)
        {
            _Next = next;

            string basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
            _Providers = ProviderSpecification.LoadProviderSpecifications(Path.Combine(basePath, "providers.json"));
        }

        public async Task Invoke(HttpContext context)
        {
            string route = (context.Request.Method.ToUpper() + " " + context.Request.Path);
            if (route == "GET /callback")
            {
                string providerId = String.Empty;
                string authCode = String.Empty;

                if (context.Request.Query.ContainsKey("provider"))
                    providerId = context.Request.Query["provider"].ToString().Trim().ToLower();
                if (context.Request.Query.ContainsKey("code"))
                    authCode = context.Request.Query["code"].ToString().Trim();

                var dProviders = _Providers.ToDictionary();
                if (!dProviders.ContainsKey(providerId))
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("UNRECOGNIZED PROVIDER");
                }

                ProviderSpecification spec = dProviders[providerId];
                OAuthTokens tokens = GetAuthorizedToken(spec, authCode);

                try
                {
                    AccelByteSDK sdk = AccelByteSDK.Builder
                        .UseDefaultHttpClient()
                        .UseDefaultConfigRepository()
                        .UseInMemoryTokenRepository()
                        .UseDefaultCredentialRepository()
                        .Build();

                    string output = String.Empty;
                    sdk.LoginPlatform(spec.ABPlatformId, tokens.ID, (otr) =>
                      {
                          output = JsonSerializer.Serialize(otr);                          
                      });

                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync(output);
                }
                catch (Exception x)
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync(x.Message);
                }
            }
            else if (route == "GET /oidconfig.js")
            {
                string cJsonContent = _Providers.ToJSONStringForFrontend(true);
                string s = String.Format("var cJson = atob(\"{0}\")\n", cJsonContent);
                s += "document.OidConfig = JSON.parse(cJson);";

                context.Response.ContentType = "text/javascript";
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(s);
            }
            else
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("NOT FOUND");
            }
        }
    }
}