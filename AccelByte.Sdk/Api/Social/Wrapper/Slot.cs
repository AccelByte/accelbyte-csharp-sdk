// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class Slot
    {
        private readonly AccelByteSDK _sdk;

        public Slot(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder GetUserNamespaceSlotsOp
        {
            get { return Operation.GetUserNamespaceSlots.Builder.SetWrapperObject(this); }
        }
        public GetSlotData.GetSlotDataBuilder GetSlotDataOp
        {
            get { return Operation.GetSlotData.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder PublicGetUserNamespaceSlotsOp
        {
            get { return Operation.PublicGetUserNamespaceSlots.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserNamespaceSlot.PublicCreateUserNamespaceSlotBuilder PublicCreateUserNamespaceSlotOp
        {
            get { return Operation.PublicCreateUserNamespaceSlot.Builder.SetWrapperObject(this); }
        }
        public PublicGetSlotData.PublicGetSlotDataBuilder PublicGetSlotDataOp
        {
            get { return Operation.PublicGetSlotData.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserNamespaceSlot.PublicUpdateUserNamespaceSlotBuilder PublicUpdateUserNamespaceSlotOp
        {
            get { return Operation.PublicUpdateUserNamespaceSlot.Builder.SetWrapperObject(this); }
        }
        public PublicDeleteUserNamespaceSlot.PublicDeleteUserNamespaceSlotBuilder PublicDeleteUserNamespaceSlotOp
        {
            get { return Operation.PublicDeleteUserNamespaceSlot.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserNamespaceSlotMetadata.PublicUpdateUserNamespaceSlotMetadataBuilder PublicUpdateUserNamespaceSlotMetadataOp
        {
            get { return Operation.PublicUpdateUserNamespaceSlotMetadata.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.SlotInfo>? GetUserNamespaceSlots(GetUserNamespaceSlots input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public byte[]? GetSlotData(GetSlotData input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.SlotInfo>? PublicGetUserNamespaceSlots(PublicGetUserNamespaceSlots input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCreateUserNamespaceSlot(PublicCreateUserNamespaceSlot input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public byte[]? PublicGetSlotData(PublicGetSlotData input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SlotInfo? PublicUpdateUserNamespaceSlot(PublicUpdateUserNamespaceSlot input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeleteUserNamespaceSlot(PublicDeleteUserNamespaceSlot input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SlotInfo? PublicUpdateUserNamespaceSlotMetadata(PublicUpdateUserNamespaceSlotMetadata input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Slot_OperationExtensions
    {
        public static List<Model.SlotInfo>? Execute(
            this GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserNamespaceSlots op = builder.Build(
                namespace_,
                userId
            );

            return ((Slot)builder.WrapperObject!).GetUserNamespaceSlots(op);
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

            return ((Slot)builder.WrapperObject!).GetSlotData(op);
        }

        public static List<Model.SlotInfo>? Execute(
            this PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserNamespaceSlots op = builder.Build(
                namespace_,
                userId
            );

            return ((Slot)builder.WrapperObject!).PublicGetUserNamespaceSlots(op);
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

            ((Slot)builder.WrapperObject!).PublicCreateUserNamespaceSlot(op);
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

            return ((Slot)builder.WrapperObject!).PublicGetSlotData(op);
        }

        public static Model.SlotInfo? Execute(
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

            return ((Slot)builder.WrapperObject!).PublicUpdateUserNamespaceSlot(op);
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

            ((Slot)builder.WrapperObject!).PublicDeleteUserNamespaceSlot(op);
        }

        public static Model.SlotInfo? Execute(
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

            return ((Slot)builder.WrapperObject!).PublicUpdateUserNamespaceSlotMetadata(op);
        }

    }
}