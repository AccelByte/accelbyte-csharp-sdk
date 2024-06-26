// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class PublicItemTypes
    {
        private readonly AccelByteSDK _sdk;

        public PublicItemTypes(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicListItemTypes.PublicListItemTypesBuilder PublicListItemTypesOp
        {
            get { return Operation.PublicListItemTypes.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsListItemTypesResp? PublicListItemTypes(PublicListItemTypes input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsListItemTypesResp?> PublicListItemTypesAsync(PublicListItemTypes input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}