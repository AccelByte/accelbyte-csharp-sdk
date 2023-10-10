// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class AdminItemTypes
    {
        private readonly AccelByteSDK _sdk;

        public AdminItemTypes(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListItemTypes.AdminListItemTypesBuilder AdminListItemTypesOp
        {
            get { return Operation.AdminListItemTypes.Builder.SetWrapperObject(this); }
        }
        public AdminCreateItemType.AdminCreateItemTypeBuilder AdminCreateItemTypeOp
        {
            get { return Operation.AdminCreateItemType.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteItemType.AdminDeleteItemTypeBuilder AdminDeleteItemTypeOp
        {
            get { return Operation.AdminDeleteItemType.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsListItemTypesResp? AdminListItemTypes(AdminListItemTypes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsCreateItemTypeResp? AdminCreateItemType(AdminCreateItemType input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteItemType(AdminDeleteItemType input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}