// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformKeyGroup_OpExts
    {
        public static Platform.Model.KeyGroupPagingSlicedResult? Execute(
            this QueryKeyGroups.QueryKeyGroupsBuilder builder,
            string namespace_
        )
        {
            QueryKeyGroups op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).QueryKeyGroups(op);
        }

        public static Platform.Model.KeyGroupInfo? Execute(
            this CreateKeyGroup.CreateKeyGroupBuilder builder,
            string namespace_
        )
        {
            CreateKeyGroup op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).CreateKeyGroup(op);
        }

        public static Platform.Model.KeyGroupInfo? Execute(
            this GetKeyGroup.GetKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            GetKeyGroup op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).GetKeyGroup(op);
        }

        public static Platform.Model.KeyGroupInfo? Execute(
            this UpdateKeyGroup.UpdateKeyGroupBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            UpdateKeyGroup op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).UpdateKeyGroup(op);
        }

        public static Platform.Model.KeyGroupDynamicInfo? Execute(
            this GetKeyGroupDynamic.GetKeyGroupDynamicBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            GetKeyGroupDynamic op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).GetKeyGroupDynamic(op);
        }

        public static Platform.Model.KeyPagingSliceResult? Execute(
            this ListKeys.ListKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            ListKeys op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).ListKeys(op);
        }

        public static Platform.Model.BulkOperationResult? Execute(
            this UploadKeys.UploadKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            UploadKeys op = builder.Build(
                keyGroupId,
                namespace_
            );

            return ((Platform.Wrapper.KeyGroup)builder.WrapperObject!).UploadKeys(op);
        }

    }
}