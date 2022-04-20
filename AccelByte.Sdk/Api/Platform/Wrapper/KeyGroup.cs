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

    public static class KeyGroup_OperationExtensions
    {
        public static Model.KeyGroupPagingSlicedResult? Execute(
            this QueryKeyGroups.QueryKeyGroupsBuilder builder,
            string namespace_
        )
        {
            QueryKeyGroups op = builder.Build(
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).QueryKeyGroups(op);
        }

        public static Model.KeyGroupInfo? Execute(
            this CreateKeyGroup.CreateKeyGroupBuilder builder,
            string namespace_
        )
        {
            CreateKeyGroup op = builder.Build(
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).CreateKeyGroup(op);
        }

        public static Model.KeyGroupInfo? Execute(
            this GetKeyGroup.GetKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            GetKeyGroup op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).GetKeyGroup(op);
        }

        public static Model.KeyGroupInfo? Execute(
            this UpdateKeyGroup.UpdateKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            UpdateKeyGroup op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).UpdateKeyGroup(op);
        }

        public static Model.KeyGroupDynamicInfo? Execute(
            this GetKeyGroupDynamic.GetKeyGroupDynamicBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            GetKeyGroupDynamic op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).GetKeyGroupDynamic(op);
        }

        public static Model.KeyPagingSliceResult? Execute(
            this ListKeys.ListKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            ListKeys op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).ListKeys(op);
        }

        public static Model.BulkOperationResult? Execute(
            this UploadKeys.UploadKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            UploadKeys op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((KeyGroup)builder.WrapperObject!).UploadKeys(op);
        }

    }
}