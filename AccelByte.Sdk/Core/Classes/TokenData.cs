// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Core
{
    public class TokenData
    {
        public static OauthmodelTokenResponse ConvertToOAuthModelTokenResponse(OauthmodelTokenWithDeviceCookieResponseV3 oToken)
        {
            List<AccountcommonPermission>? permissions = null;
            if (oToken.Permissions != null)
            {
                permissions = new List<AccountcommonPermission>();
                foreach (var p in oToken.Permissions)
                {
                    permissions.Add(new AccountcommonPermission()
                    {
                        Action = p.Action,
                        Resource = p.Resource,
                        SchedAction = p.SchedAction,
                        SchedCron = p.SchedCron,
                        SchedRange = p.SchedRange
                    });
                }
            }

            return new OauthmodelTokenResponse()
            {
                AccessToken = oToken.AccessToken,
                RefreshToken = oToken.RefreshToken,
                Bans = oToken.Bans,
                DisplayName = oToken.DisplayName,
                ExpiresIn = oToken.ExpiresIn,
                IsComply = oToken.IsComply,
                Jflgs = oToken.Jflgs,
                Namespace = oToken.Namespace,
                NamespaceRoles = oToken.NamespaceRoles,
                Permissions = permissions,
                PlatformId = oToken.PlatformId,
                PlatformUserId = oToken.PlatformUserId,
                RefreshExpiresIn = oToken.RefreshExpiresIn,
                Roles = oToken.Roles,
                TokenType = oToken.TokenType,
                UserId = oToken.UserId
            };
        }

        public string? AccessToken { get; set; }

        public string? DisplayName { get; set; }

        public int? ExpiresIn { get; set; }

        public string? Namespace { get; set; }

        public string? PlatformId { get; set; }

        public string? PlatformUserId { get; set; }

        public int? RefreshExpiresIn { get; set; }

        public string? RefreshToken { get; set; }

        public List<string>? Roles { get; set; }

        public string? TokenType { get; set; }

        public string? UserId { get; set; }

        public TokenData() { }

        public TokenData(OauthmodelTokenResponseV3 source)
        {
            AccessToken = source.AccessToken;
            DisplayName = source.DisplayName;
            ExpiresIn = source.ExpiresIn;
            Namespace = source.Namespace;
            PlatformId = source.PlatformId;
            PlatformUserId = source.PlatformUserId;
            RefreshExpiresIn = source.RefreshExpiresIn;
            RefreshToken = source.RefreshToken;
            Roles = source.Roles;
            TokenType = source.TokenType;
            UserId = source.UserId;
        }

        public TokenData(OauthmodelTokenResponse source)
        {
            AccessToken = source.AccessToken;
            DisplayName = source.DisplayName;
            ExpiresIn = source.ExpiresIn;
            Namespace = source.Namespace;
            PlatformId = source.PlatformId;
            PlatformUserId = source.PlatformUserId;
            RefreshExpiresIn = source.RefreshExpiresIn;
            RefreshToken = source.RefreshToken;
            Roles = source.Roles;
            TokenType = source.TokenType;
            UserId = source.UserId;
        }

        public TokenData(OauthmodelTokenWithDeviceCookieResponseV3 source)
        {
            AccessToken = source.AccessToken;
            DisplayName = source.DisplayName;
            ExpiresIn = source.ExpiresIn;
            Namespace = source.Namespace;
            PlatformId = source.PlatformId;
            PlatformUserId = source.PlatformUserId;
            RefreshExpiresIn = source.RefreshExpiresIn;
            RefreshToken = source.RefreshToken;
            Roles = source.Roles;
            TokenType = source.TokenType;
            UserId = source.UserId;
        }
    }
}
