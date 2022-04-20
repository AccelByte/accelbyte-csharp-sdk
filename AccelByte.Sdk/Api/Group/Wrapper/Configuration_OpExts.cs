// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GroupConfiguration_OpExts
    {
        public static Group.Model.ModelsListConfigurationResponseV1? Execute(
            this ListGroupConfigurationAdminV1.ListGroupConfigurationAdminV1Builder builder,
            string namespace_
        )
        {
            ListGroupConfigurationAdminV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).ListGroupConfigurationAdminV1(op);
        }

        public static Group.Model.ModelsCreateGroupConfigurationResponseV1? Execute(
            this CreateGroupConfigurationAdminV1.CreateGroupConfigurationAdminV1Builder builder,
            ModelsCreateGroupConfigurationRequestV1 body,
            string namespace_
        )
        {
            CreateGroupConfigurationAdminV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).CreateGroupConfigurationAdminV1(op);
        }

        public static Group.Model.ModelsCreateGroupConfigurationResponseV1? Execute(
            this InitiateGroupConfigurationAdminV1.InitiateGroupConfigurationAdminV1Builder builder,
            string namespace_
        )
        {
            InitiateGroupConfigurationAdminV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).InitiateGroupConfigurationAdminV1(op);
        }

        public static Group.Model.ModelsGetGroupConfigurationResponseV1? Execute(
            this GetGroupConfigurationAdminV1.GetGroupConfigurationAdminV1Builder builder,
            string configurationCode,
            string namespace_
        )
        {
            GetGroupConfigurationAdminV1 op = builder.Build(
                configurationCode,
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).GetGroupConfigurationAdminV1(op);
        }

        public static void Execute(
            this DeleteGroupConfigurationV1.DeleteGroupConfigurationV1Builder builder,
            string configurationCode,
            string namespace_
        )
        {
            DeleteGroupConfigurationV1 op = builder.Build(
                configurationCode,
                namespace_
            );

            ((Group.Wrapper.Configuration)builder.WrapperObject!).DeleteGroupConfigurationV1(op);
        }

        public static Group.Model.ModelsUpdateGroupConfigurationResponseV1? Execute(
            this UpdateGroupConfigurationAdminV1.UpdateGroupConfigurationAdminV1Builder builder,
            ModelsUpdateGroupConfigurationRequestV1 body,
            string configurationCode,
            string namespace_
        )
        {
            UpdateGroupConfigurationAdminV1 op = builder.Build(
                body,
                configurationCode,
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).UpdateGroupConfigurationAdminV1(op);
        }

        public static Group.Model.ModelsUpdateGroupConfigurationResponseV1? Execute(
            this UpdateGroupConfigurationGlobalRuleAdminV1.UpdateGroupConfigurationGlobalRuleAdminV1Builder builder,
            ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
            string allowedAction,
            string configurationCode,
            string namespace_
        )
        {
            UpdateGroupConfigurationGlobalRuleAdminV1 op = builder.Build(
                body,
                allowedAction,
                configurationCode,
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).UpdateGroupConfigurationGlobalRuleAdminV1(op);
        }

        public static Group.Model.ModelsUpdateGroupConfigurationResponseV1? Execute(
            this DeleteGroupConfigurationGlobalRuleAdminV1.DeleteGroupConfigurationGlobalRuleAdminV1Builder builder,
            string allowedAction,
            string configurationCode,
            string namespace_
        )
        {
            DeleteGroupConfigurationGlobalRuleAdminV1 op = builder.Build(
                allowedAction,
                configurationCode,
                namespace_
            );

            return ((Group.Wrapper.Configuration)builder.WrapperObject!).DeleteGroupConfigurationGlobalRuleAdminV1(op);
        }

    }
}