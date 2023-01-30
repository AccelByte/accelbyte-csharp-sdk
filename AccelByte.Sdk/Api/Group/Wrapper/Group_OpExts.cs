// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GroupGroup_OpExts
    {
        public static Group.Model.ModelsGetGroupsListResponseV1? Execute(
            this GetGroupListAdminV1.GetGroupListAdminV1Builder builder,
            string namespace_
        )
        {
            GetGroupListAdminV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).GetGroupListAdminV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this GetSingleGroupAdminV1.GetSingleGroupAdminV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetSingleGroupAdminV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).GetSingleGroupAdminV1(op);
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

            ((Group.Wrapper.Group)builder.WrapperObject!).DeleteGroupAdminV1(op);
        }

        public static Group.Model.ModelsGetGroupsListResponseV1? Execute(
            this GetGroupListPublicV1.GetGroupListPublicV1Builder builder,
            string namespace_
        )
        {
            GetGroupListPublicV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).GetGroupListPublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this CreateNewGroupPublicV1.CreateNewGroupPublicV1Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            CreateNewGroupPublicV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).CreateNewGroupPublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this GetSingleGroupPublicV1.GetSingleGroupPublicV1Builder builder,
            string groupId,
            string namespace_
        )
        {
            GetSingleGroupPublicV1 op = builder.Build(
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).GetSingleGroupPublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
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

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateSingleGroupV1(op);
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

            ((Group.Wrapper.Group)builder.WrapperObject!).DeleteGroupPublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
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

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdatePatchSingleGroupPublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
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

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateGroupCustomAttributesPublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
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

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateGroupCustomRulePublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
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

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateGroupPredefinedRulePublicV1(op);
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

            ((Group.Wrapper.Group)builder.WrapperObject!).DeleteGroupPredefinedRulePublicV1(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this CreateNewGroupPublicV2.CreateNewGroupPublicV2Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            CreateNewGroupPublicV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).CreateNewGroupPublicV2(op);
        }

        public static Group.Model.ModelsGetGroupsResponseV1? Execute(
            this GetListGroupByIDsV2.GetListGroupByIDsV2Builder builder,
            ModelsPublicGetGroupListRequestV2 body,
            string namespace_
        )
        {
            GetListGroupByIDsV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).GetListGroupByIDsV2(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this UpdatePutSingleGroupPublicV2.UpdatePutSingleGroupPublicV2Builder builder,
            ModelsUpdateGroupRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdatePutSingleGroupPublicV2 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdatePutSingleGroupPublicV2(op);
        }

        public static void Execute(
            this DeleteGroupPublicV2.DeleteGroupPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            DeleteGroupPublicV2 op = builder.Build(
                groupId,
                namespace_
            );

            ((Group.Wrapper.Group)builder.WrapperObject!).DeleteGroupPublicV2(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this UpdatePatchSingleGroupPublicV2.UpdatePatchSingleGroupPublicV2Builder builder,
            ModelsUpdateGroupRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdatePatchSingleGroupPublicV2 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdatePatchSingleGroupPublicV2(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this UpdateGroupCustomAttributesPublicV2.UpdateGroupCustomAttributesPublicV2Builder builder,
            ModelsUpdateGroupCustomAttributesRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdateGroupCustomAttributesPublicV2 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateGroupCustomAttributesPublicV2(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this UpdateGroupCustomRulePublicV2.UpdateGroupCustomRulePublicV2Builder builder,
            ModelsUpdateGroupCustomRuleRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            UpdateGroupCustomRulePublicV2 op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateGroupCustomRulePublicV2(op);
        }

        public static Group.Model.ModelsGroupResponseV1? Execute(
            this UpdateGroupPredefinedRulePublicV2.UpdateGroupPredefinedRulePublicV2Builder builder,
            ModelsUpdateGroupPredefinedRuleRequestV1 body,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            UpdateGroupPredefinedRulePublicV2 op = builder.Build(
                body,
                allowedAction,
                groupId,
                namespace_
            );

            return ((Group.Wrapper.Group)builder.WrapperObject!).UpdateGroupPredefinedRulePublicV2(op);
        }

        public static void Execute(
            this DeleteGroupPredefinedRulePublicV2.DeleteGroupPredefinedRulePublicV2Builder builder,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            DeleteGroupPredefinedRulePublicV2 op = builder.Build(
                allowedAction,
                groupId,
                namespace_
            );

            ((Group.Wrapper.Group)builder.WrapperObject!).DeleteGroupPredefinedRulePublicV2(op);
        }

    }
}