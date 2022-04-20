// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class Group
    {
        private readonly AccelByteSDK _sdk;

        public Group(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGroupListAdminV1.GetGroupListAdminV1Builder GetGroupListAdminV1Op
        {
            get { return Operation.GetGroupListAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetSingleGroupAdminV1.GetSingleGroupAdminV1Builder GetSingleGroupAdminV1Op
        {
            get { return Operation.GetSingleGroupAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupAdminV1.DeleteGroupAdminV1Builder DeleteGroupAdminV1Op
        {
            get { return Operation.DeleteGroupAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetGroupListPublicV1.GetGroupListPublicV1Builder GetGroupListPublicV1Op
        {
            get { return Operation.GetGroupListPublicV1.Builder.SetWrapperObject(this); }
        }
        public CreateNewGroupPublicV1.CreateNewGroupPublicV1Builder CreateNewGroupPublicV1Op
        {
            get { return Operation.CreateNewGroupPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetSingleGroupPublicV1.GetSingleGroupPublicV1Builder GetSingleGroupPublicV1Op
        {
            get { return Operation.GetSingleGroupPublicV1.Builder.SetWrapperObject(this); }
        }
        public UpdateSingleGroupV1.UpdateSingleGroupV1Builder UpdateSingleGroupV1Op
        {
            get { return Operation.UpdateSingleGroupV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupPublicV1.DeleteGroupPublicV1Builder DeleteGroupPublicV1Op
        {
            get { return Operation.DeleteGroupPublicV1.Builder.SetWrapperObject(this); }
        }
        public UpdatePatchSingleGroupPublicV1.UpdatePatchSingleGroupPublicV1Builder UpdatePatchSingleGroupPublicV1Op
        {
            get { return Operation.UpdatePatchSingleGroupPublicV1.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupCustomAttributesPublicV1.UpdateGroupCustomAttributesPublicV1Builder UpdateGroupCustomAttributesPublicV1Op
        {
            get { return Operation.UpdateGroupCustomAttributesPublicV1.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupCustomRulePublicV1.UpdateGroupCustomRulePublicV1Builder UpdateGroupCustomRulePublicV1Op
        {
            get { return Operation.UpdateGroupCustomRulePublicV1.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupPredefinedRulePublicV1.UpdateGroupPredefinedRulePublicV1Builder UpdateGroupPredefinedRulePublicV1Op
        {
            get { return Operation.UpdateGroupPredefinedRulePublicV1.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupPredefinedRulePublicV1.DeleteGroupPredefinedRulePublicV1Builder DeleteGroupPredefinedRulePublicV1Op
        {
            get { return Operation.DeleteGroupPredefinedRulePublicV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetGroupsListResponseV1? GetGroupListAdminV1(GetGroupListAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? GetSingleGroupAdminV1(GetSingleGroupAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupAdminV1(DeleteGroupAdminV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsListResponseV1? GetGroupListPublicV1(GetGroupListPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? CreateNewGroupPublicV1(CreateNewGroupPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? GetSingleGroupPublicV1(GetSingleGroupPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateSingleGroupV1(UpdateSingleGroupV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPublicV1(DeleteGroupPublicV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePatchSingleGroupPublicV1(UpdatePatchSingleGroupPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomAttributesPublicV1(UpdateGroupCustomAttributesPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomRulePublicV1(UpdateGroupCustomRulePublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupPredefinedRulePublicV1(UpdateGroupPredefinedRulePublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPredefinedRulePublicV1(DeleteGroupPredefinedRulePublicV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Group_OperationExtensions
    {
        public static Model.ModelsGetGroupsListResponseV1? Execute(
            this GetGroupListAdminV1.GetGroupListAdminV1Builder builder,
            string namespace_
        )
        {
            GetGroupListAdminV1 op = builder.Build(
                namespace_
            );

            return ((Group)builder.WrapperObject!).GetGroupListAdminV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this GetSingleGroupAdminV1.GetSingleGroupAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetSingleGroupAdminV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).GetSingleGroupAdminV1(op);
        }

        public static void Execute(
            this DeleteGroupAdminV1.DeleteGroupAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            DeleteGroupAdminV1 op = builder.Build(
                groupId,
                namespace_
            );

            ((Group)builder.WrapperObject!).DeleteGroupAdminV1(op);
        }

        public static Model.ModelsGetGroupsListResponseV1? Execute(
            this GetGroupListPublicV1.GetGroupListPublicV1Builder builder,
            string namespace_
        )
        {
            GetGroupListPublicV1 op = builder.Build(
                namespace_
            );

            return ((Group)builder.WrapperObject!).GetGroupListPublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this CreateNewGroupPublicV1.CreateNewGroupPublicV1Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            CreateNewGroupPublicV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Group)builder.WrapperObject!).CreateNewGroupPublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this GetSingleGroupPublicV1.GetSingleGroupPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetSingleGroupPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).GetSingleGroupPublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this UpdateSingleGroupV1.UpdateSingleGroupV1Builder builder,
            ModelsUpdateGroupRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdateSingleGroupV1 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).UpdateSingleGroupV1(op);
        }

        public static void Execute(
            this DeleteGroupPublicV1.DeleteGroupPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            DeleteGroupPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            ((Group)builder.WrapperObject!).DeleteGroupPublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this UpdatePatchSingleGroupPublicV1.UpdatePatchSingleGroupPublicV1Builder builder,
            ModelsUpdateGroupRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdatePatchSingleGroupPublicV1 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).UpdatePatchSingleGroupPublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this UpdateGroupCustomAttributesPublicV1.UpdateGroupCustomAttributesPublicV1Builder builder,
            ModelsUpdateGroupCustomAttributesRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdateGroupCustomAttributesPublicV1 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).UpdateGroupCustomAttributesPublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this UpdateGroupCustomRulePublicV1.UpdateGroupCustomRulePublicV1Builder builder,
            ModelsUpdateGroupCustomRuleRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdateGroupCustomRulePublicV1 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).UpdateGroupCustomRulePublicV1(op);
        }

        public static Model.ModelsGroupResponseV1? Execute(
            this UpdateGroupPredefinedRulePublicV1.UpdateGroupPredefinedRulePublicV1Builder builder,
            ModelsUpdateGroupPredefinedRuleRequestV1 body,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            UpdateGroupPredefinedRulePublicV1 op = builder.Build(
                body,
                allowedAction,
                groupId,
                namespace_
            );

            return ((Group)builder.WrapperObject!).UpdateGroupPredefinedRulePublicV1(op);
        }

        public static void Execute(
            this DeleteGroupPredefinedRulePublicV1.DeleteGroupPredefinedRulePublicV1Builder builder,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            DeleteGroupPredefinedRulePublicV1 op = builder.Build(
                allowedAction,
                groupId,
                namespace_
            );

            ((Group)builder.WrapperObject!).DeleteGroupPredefinedRulePublicV1(op);
        }

    }
}