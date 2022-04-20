// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamInputValidations_OpExts
    {
        public static Iam.Model.ModelInputValidationsResponse? Execute(
            this AdminGetInputValidations.AdminGetInputValidationsBuilder builder
        )
        {
            AdminGetInputValidations op = builder.Build(
            );

            return ((Iam.Wrapper.InputValidations)builder.WrapperObject!).AdminGetInputValidations(op);
        }

        public static void Execute(
            this AdminUpdateInputValidations.AdminUpdateInputValidationsBuilder builder,
            List<ModelInputValidationUpdatePayload> body
        )
        {
            AdminUpdateInputValidations op = builder.Build(
                body
            );

            ((Iam.Wrapper.InputValidations)builder.WrapperObject!).AdminUpdateInputValidations(op);
        }

        public static void Execute(
            this AdminResetInputValidations.AdminResetInputValidationsBuilder builder,
            string field
        )
        {
            AdminResetInputValidations op = builder.Build(
                field
            );

            ((Iam.Wrapper.InputValidations)builder.WrapperObject!).AdminResetInputValidations(op);
        }

        public static Iam.Model.ModelInputValidationsPublicResponse? Execute(
            this PublicGetInputValidations.PublicGetInputValidationsBuilder builder
        )
        {
            PublicGetInputValidations op = builder.Build(
            );

            return ((Iam.Wrapper.InputValidations)builder.WrapperObject!).PublicGetInputValidations(op);
        }

    }
}