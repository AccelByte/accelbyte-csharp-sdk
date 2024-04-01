// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class MaxActive
    {
        private readonly AccelByteSDK _sdk;

        public MaxActive(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetMemberActiveSession.AdminGetMemberActiveSessionBuilder AdminGetMemberActiveSessionOp
        {
            get { return Operation.AdminGetMemberActiveSession.Builder.SetWrapperObject(this); }
        }
        public AdminReconcileMaxActiveSession.AdminReconcileMaxActiveSessionBuilder AdminReconcileMaxActiveSessionOp
        {
            get { return Operation.AdminReconcileMaxActiveSession.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsMemberActiveSession? AdminGetMemberActiveSession(AdminGetMemberActiveSession input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsMemberActiveSession?> AdminGetMemberActiveSessionAsync(AdminGetMemberActiveSession input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminReconcileMaxActiveSession(AdminReconcileMaxActiveSession input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminReconcileMaxActiveSessionAsync(AdminReconcileMaxActiveSession input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}