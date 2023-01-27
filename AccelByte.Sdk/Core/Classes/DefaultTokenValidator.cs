// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Core
{
    public class DefaultTokenValidator : TokenValidator, ITokenValidator
    {
        public bool Validate(AccelByteSDK sdk, string accessToken)
        {
            try
            {
                OauthmodelTokenResponseV3? response = sdk.Iam.OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action)
        {
            try
            {
                OauthmodelTokenResponseV3? response = sdk.Iam.OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                if (response.Permissions == null)
                    return false;

                bool foundMatchingPermission = false;
                foreach (var p in response.Permissions)
                {
                    if ((p.Resource != null) && (p.Action != null))
                    {
                        if (IsResourceAllowed(p.Resource, permission))
                        {
                            if (PermissionAction.Has(p.Action.Value, action))
                            {
                                foundMatchingPermission = true;
                                break;
                            }
                        }
                    }
                }

                if (!foundMatchingPermission)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
