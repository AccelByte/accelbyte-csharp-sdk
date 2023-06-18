// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class InputValidations
    {
        private readonly AccelByteSDK _sdk;

        public InputValidations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetInputValidations.AdminGetInputValidationsBuilder AdminGetInputValidationsOp
        {
            get { return Operation.AdminGetInputValidations.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateInputValidations.AdminUpdateInputValidationsBuilder AdminUpdateInputValidationsOp
        {
            get { return Operation.AdminUpdateInputValidations.Builder.SetWrapperObject(this); }
        }
        public AdminResetInputValidations.AdminResetInputValidationsBuilder AdminResetInputValidationsOp
        {
            get { return Operation.AdminResetInputValidations.Builder.SetWrapperObject(this); }
        }
        public PublicGetInputValidations.PublicGetInputValidationsBuilder PublicGetInputValidationsOp
        {
            get { return Operation.PublicGetInputValidations.Builder.SetWrapperObject(this); }
        }
        public PublicGetInputValidationByField.PublicGetInputValidationByFieldBuilder PublicGetInputValidationByFieldOp
        {
            get { return Operation.PublicGetInputValidationByField.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelInputValidationsResponse? AdminGetInputValidations(AdminGetInputValidations input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateInputValidations(AdminUpdateInputValidations input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetInputValidations(AdminResetInputValidations input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInputValidationsPublicResponse? PublicGetInputValidations(PublicGetInputValidations input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInputValidationConfigVersion? PublicGetInputValidationByField(PublicGetInputValidationByField input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}