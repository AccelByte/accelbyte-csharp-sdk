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
    /// DisableUserBan
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [UPDATE]'.
    /// 
    ///  Notes for using IAM in publisher - game studio scenarios
    /// 
    /// 
    /// The endpoint allows:
    /// 
    ///     * The admin user in publisher namespace disables userâs ban in publisher namespace.
    ///     * The admin user in game namespace disables userâs ban in game namespace.
    ///     * The admin user in publisher namespace disables userâs ban in publisher namespace.
    /// 
    /// Other scenarios are not supported and will return 403: Forbidden.
    /// </summary>
    public class DisableUserBan : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableUserBanBuilder Builder = new DisableUserBanBuilder();

        public class DisableUserBanBuilder
            : OperationBuilder<DisableUserBanBuilder>
        {
            
            
            
            internal DisableUserBanBuilder() { }





            public DisableUserBan Build(
                string banId,
                string namespace_,
                string userId
            )
            {
                DisableUserBan op = new DisableUserBan(this,
                    banId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DisableUserBan(DisableUserBanBuilder builder,
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DisableUserBan(
            string banId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/bans/{banId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "*/*" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelUserBanResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}