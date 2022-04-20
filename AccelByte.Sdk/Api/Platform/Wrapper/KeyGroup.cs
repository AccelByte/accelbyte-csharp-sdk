// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class KeyGroup
    {
        private readonly AccelByteSDK _sdk;

        public KeyGroup(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryKeyGroups.QueryKeyGroupsBuilder QueryKeyGroupsOp
        {
            get { return Operation.QueryKeyGroups.Builder.SetWrapperObject(this); }
        }
        public CreateKeyGroup.CreateKeyGroupBuilder CreateKeyGroupOp
        {
            get { return Operation.CreateKeyGroup.Builder.SetWrapperObject(this); }
        }
        public GetKeyGroup.GetKeyGroupBuilder GetKeyGroupOp
        {
            get { return Operation.GetKeyGroup.Builder.SetWrapperObject(this); }
        }
        public UpdateKeyGroup.UpdateKeyGroupBuilder UpdateKeyGroupOp
        {
            get { return Operation.UpdateKeyGroup.Builder.SetWrapperObject(this); }
        }
        public GetKeyGroupDynamic.GetKeyGroupDynamicBuilder GetKeyGroupDynamicOp
        {
            get { return Operation.GetKeyGroupDynamic.Builder.SetWrapperObject(this); }
        }
        public ListKeys.ListKeysBuilder ListKeysOp
        {
            get { return Operation.ListKeys.Builder.SetWrapperObject(this); }
        }
        public UploadKeys.UploadKeysBuilder UploadKeysOp
        {
            get { return Operation.UploadKeys.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.KeyGroupPagingSlicedResult? QueryKeyGroups(QueryKeyGroups input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupInfo? CreateKeyGroup(CreateKeyGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupInfo? GetKeyGroup(GetKeyGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupInfo? UpdateKeyGroup(UpdateKeyGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupDynamicInfo? GetKeyGroupDynamic(GetKeyGroupDynamic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyPagingSliceResult? ListKeys(ListKeys input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? UploadKeys(UploadKeys input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}