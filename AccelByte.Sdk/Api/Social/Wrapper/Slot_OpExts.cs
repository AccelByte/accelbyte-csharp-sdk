// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SocialSlot_OpExts
    {
        public static List<Social.Model.SlotInfo>? Execute(
            this GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserNamespaceSlots op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.Slot)builder.WrapperObject!).GetUserNamespaceSlots(op);
        }

        public static byte[]? Execute(
            this GetSlotData.GetSlotDataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            GetSlotData op = builder.Build(
                namespace_,
                slotId,
                userId
            );

            return ((Social.Wrapper.Slot)builder.WrapperObject!).GetSlotData(op);
        }

        public static List<Social.Model.SlotInfo>? Execute(
            this PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserNamespaceSlots op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.Slot)builder.WrapperObject!).PublicGetUserNamespaceSlots(op);
        }

        public static void Execute(
            this PublicCreateUserNamespaceSlot.PublicCreateUserNamespaceSlotBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateUserNamespaceSlot op = builder.Build(
                namespace_,
                userId
            );

            ((Social.Wrapper.Slot)builder.WrapperObject!).PublicCreateUserNamespaceSlot(op);
        }

        public static byte[]? Execute(
            this PublicGetSlotData.PublicGetSlotDataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PublicGetSlotData op = builder.Build(
                namespace_,
                slotId,
                userId
            );

            return ((Social.Wrapper.Slot)builder.WrapperObject!).PublicGetSlotData(op);
        }

        public static Social.Model.SlotInfo? Execute(
            this PublicUpdateUserNamespaceSlot.PublicUpdateUserNamespaceSlotBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PublicUpdateUserNamespaceSlot op = builder.Build(
                namespace_,
                slotId,
                userId
            );

            return ((Social.Wrapper.Slot)builder.WrapperObject!).PublicUpdateUserNamespaceSlot(op);
        }

        public static void Execute(
            this PublicDeleteUserNamespaceSlot.PublicDeleteUserNamespaceSlotBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PublicDeleteUserNamespaceSlot op = builder.Build(
                namespace_,
                slotId,
                userId
            );

            ((Social.Wrapper.Slot)builder.WrapperObject!).PublicDeleteUserNamespaceSlot(op);
        }

        public static Social.Model.SlotInfo? Execute(
            this PublicUpdateUserNamespaceSlotMetadata.PublicUpdateUserNamespaceSlotMetadataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PublicUpdateUserNamespaceSlotMetadata op = builder.Build(
                namespace_,
                slotId,
                userId
            );

            return ((Social.Wrapper.Slot)builder.WrapperObject!).PublicUpdateUserNamespaceSlotMetadata(op);
        }

    }
}