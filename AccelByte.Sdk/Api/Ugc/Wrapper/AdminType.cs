// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminType
    {
        private readonly AccelByteSDK _sdk;

        public AdminType(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetType.AdminGetTypeBuilder AdminGetTypeOp
        {
            get { return Operation.AdminGetType.Builder.SetWrapperObject(this); }
        }
        public AdminCreateType.AdminCreateTypeBuilder AdminCreateTypeOp
        {
            get { return Operation.AdminCreateType.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateType.AdminUpdateTypeBuilder AdminUpdateTypeOp
        {
            get { return Operation.AdminUpdateType.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteType.AdminDeleteTypeBuilder AdminDeleteTypeOp
        {
            get { return Operation.AdminDeleteType.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGetTypeResponse? AdminGetType(AdminGetType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTypeResponse? AdminCreateType(AdminCreateType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTypeResponse? AdminUpdateType(AdminUpdateType input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteType(AdminDeleteType input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminType_OperationExtensions
    {
        public static Model.ModelsPaginatedGetTypeResponse? Execute(
            this AdminGetType.AdminGetTypeBuilder builder,
            string namespace_
        )
        {
            AdminGetType op = builder.Build(
                namespace_
            );

            return ((AdminType)builder.WrapperObject!).AdminGetType(op);
        }

        public static Model.ModelsCreateTypeResponse? Execute(
            this AdminCreateType.AdminCreateTypeBuilder builder,
            ModelsCreateTypeRequest body,
            string namespace_
        )
        {
            AdminCreateType op = builder.Build(
                body,
                namespace_
            );

            return ((AdminType)builder.WrapperObject!).AdminCreateType(op);
        }

        public static Model.ModelsCreateTypeResponse? Execute(
            this AdminUpdateType.AdminUpdateTypeBuilder builder,
            ModelsCreateTypeRequest body,
            string namespace_,
            string typeId
        )
        {
            AdminUpdateType op = builder.Build(
                body,
                namespace_,
                typeId
            );

            return ((AdminType)builder.WrapperObject!).AdminUpdateType(op);
        }

        public static void Execute(
            this AdminDeleteType.AdminDeleteTypeBuilder builder,
            string namespace_,
            string typeId
        )
        {
            AdminDeleteType op = builder.Build(
                namespace_,
                typeId
            );

            ((AdminType)builder.WrapperObject!).AdminDeleteType(op);
        }

    }
}