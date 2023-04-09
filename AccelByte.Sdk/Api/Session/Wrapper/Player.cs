// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class Player
    {
        private readonly AccelByteSDK _sdk;

        public Player(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryPlayerAttributes.AdminQueryPlayerAttributesBuilder AdminQueryPlayerAttributesOp
        {
            get { return Operation.AdminQueryPlayerAttributes.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerAttributes.AdminGetPlayerAttributesBuilder AdminGetPlayerAttributesOp
        {
            get { return Operation.AdminGetPlayerAttributes.Builder.SetWrapperObject(this); }
        }
        public PublicGetPlayerAttributes.PublicGetPlayerAttributesBuilder PublicGetPlayerAttributesOp
        {
            get { return Operation.PublicGetPlayerAttributes.Builder.SetWrapperObject(this); }
        }
        public PublicStorePlayerAttributes.PublicStorePlayerAttributesBuilder PublicStorePlayerAttributesOp
        {
            get { return Operation.PublicStorePlayerAttributes.Builder.SetWrapperObject(this); }
        }
        public PublicDeletePlayerAttributes.PublicDeletePlayerAttributesBuilder PublicDeletePlayerAttributesOp
        {
            get { return Operation.PublicDeletePlayerAttributes.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.ApimodelsPlayerAttributesResponseBody>? AdminQueryPlayerAttributes(AdminQueryPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ApimodelsPlayerAttributesResponseBody<T1>>? AdminQueryPlayerAttributes<T1>(AdminQueryPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayerAttributesResponseBody? AdminGetPlayerAttributes(AdminGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? AdminGetPlayerAttributes<T1>(AdminGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayerAttributesResponseBody? PublicGetPlayerAttributes(PublicGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? PublicGetPlayerAttributes<T1>(PublicGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayerAttributesResponseBody? PublicStorePlayerAttributes(PublicStorePlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? PublicStorePlayerAttributes<T1>(PublicStorePlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeletePlayerAttributes(PublicDeletePlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}