// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class Bans
    {
        private readonly AccelByteSDK _sdk;

        public Bans(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetBansType.GetBansTypeBuilder GetBansTypeOp
        {
            get { return Operation.GetBansType.Builder.SetWrapperObject(this); }
        }
        public GetListBanReason.GetListBanReasonBuilder GetListBanReasonOp
        {
            get { return Operation.GetListBanReason.Builder.SetWrapperObject(this); }
        }
        public AdminGetBansTypeV3.AdminGetBansTypeV3Builder AdminGetBansTypeV3Op
        {
            get { return Operation.AdminGetBansTypeV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetListBanReasonV3.AdminGetListBanReasonV3Builder AdminGetListBanReasonV3Op
        {
            get { return Operation.AdminGetListBanReasonV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetBannedUsersV3.AdminGetBannedUsersV3Builder AdminGetBannedUsersV3Op
        {
            get { return Operation.AdminGetBannedUsersV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetBansTypeWithNamespaceV3.AdminGetBansTypeWithNamespaceV3Builder AdminGetBansTypeWithNamespaceV3Op
        {
            get { return Operation.AdminGetBansTypeWithNamespaceV3.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.AccountcommonBans? GetBansType(GetBansType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonBanReasons? GetListBanReason(GetListBanReason input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonBansV3? AdminGetBansTypeV3(AdminGetBansTypeV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonBanReasonsV3? AdminGetListBanReasonV3(AdminGetListBanReasonV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUserBanV3Response? AdminGetBannedUsersV3(AdminGetBannedUsersV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonBansV3? AdminGetBansTypeWithNamespaceV3(AdminGetBansTypeWithNamespaceV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Bans_OperationExtensions
    {
        public static Model.AccountcommonBans? Execute(
            this GetBansType.GetBansTypeBuilder builder
        )
        {
            GetBansType op = builder.Build(
            );

            return ((Bans)builder.WrapperObject!).GetBansType(op);
        }

        public static Model.AccountcommonBanReasons? Execute(
            this GetListBanReason.GetListBanReasonBuilder builder
        )
        {
            GetListBanReason op = builder.Build(
            );

            return ((Bans)builder.WrapperObject!).GetListBanReason(op);
        }

        public static Model.AccountcommonBansV3? Execute(
            this AdminGetBansTypeV3.AdminGetBansTypeV3Builder builder
        )
        {
            AdminGetBansTypeV3 op = builder.Build(
            );

            return ((Bans)builder.WrapperObject!).AdminGetBansTypeV3(op);
        }

        public static Model.AccountcommonBanReasonsV3? Execute(
            this AdminGetListBanReasonV3.AdminGetListBanReasonV3Builder builder
        )
        {
            AdminGetListBanReasonV3 op = builder.Build(
            );

            return ((Bans)builder.WrapperObject!).AdminGetListBanReasonV3(op);
        }

        public static Model.ModelGetUserBanV3Response? Execute(
            this AdminGetBannedUsersV3.AdminGetBannedUsersV3Builder builder,
            string namespace_
        )
        {
            AdminGetBannedUsersV3 op = builder.Build(
                namespace_
            );

            return ((Bans)builder.WrapperObject!).AdminGetBannedUsersV3(op);
        }

        public static Model.AccountcommonBansV3? Execute(
            this AdminGetBansTypeWithNamespaceV3.AdminGetBansTypeWithNamespaceV3Builder builder,
            string namespace_
        )
        {
            AdminGetBansTypeWithNamespaceV3 op = builder.Build(
                namespace_
            );

            return ((Bans)builder.WrapperObject!).AdminGetBansTypeWithNamespaceV3(op);
        }

    }
}