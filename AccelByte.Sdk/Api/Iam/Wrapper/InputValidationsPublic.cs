// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class InputValidationsPublic
    {
        private readonly AccelByteSDK _sdk;

        public InputValidationsPublic(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicGetInputValidations.PublicGetInputValidationsBuilder PublicGetInputValidationsOp
        {
            get { return Operation.PublicGetInputValidations.Builder.SetWrapperObject(this); }
        }
        public PublicGetInputValidationByField.PublicGetInputValidationByFieldBuilder PublicGetInputValidationByFieldOp
        {
            get { return Operation.PublicGetInputValidationByField.Builder.SetWrapperObject(this); }
        }
        #endregion

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