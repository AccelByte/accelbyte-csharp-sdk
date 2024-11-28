// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;
using AccelByte.Sdk.Api.Csm.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CsmConfigurationV2_OpExts
    {
        public static Csm.Model.ApimodelGetListOfConfigurationsV2Response? Execute(
            this GetListOfSecretsV2.GetListOfSecretsV2Builder builder,
            string app,
            string namespace_
        )
        {
            GetListOfSecretsV2 op = builder.Build(
                app,
                namespace_
            );

            return ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).GetListOfSecretsV2(op);
        }
        public static async Task<Csm.Model.ApimodelGetListOfConfigurationsV2Response?> ExecuteAsync(
            this GetListOfSecretsV2.GetListOfSecretsV2Builder builder,
            string app,
            string namespace_
        )
        {
            GetListOfSecretsV2 op = builder.Build(
                app,
                namespace_
            );

            return await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).GetListOfSecretsV2Async(op);
        }
        public static Csm.Model.ApimodelSaveConfigurationV2Response? Execute(
            this SaveSecretV2.SaveSecretV2Builder builder,
            ApimodelSaveConfigurationV2Request body,
            string app,
            string namespace_
        )
        {
            SaveSecretV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).SaveSecretV2(op);
        }
        public static async Task<Csm.Model.ApimodelSaveConfigurationV2Response?> ExecuteAsync(
            this SaveSecretV2.SaveSecretV2Builder builder,
            ApimodelSaveConfigurationV2Request body,
            string app,
            string namespace_
        )
        {
            SaveSecretV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).SaveSecretV2Async(op);
        }
        public static Csm.Model.ApimodelUpdateConfigurationV2Response? Execute(
            this UpdateSecretV2.UpdateSecretV2Builder builder,
            ApimodelUpdateConfigurationV2Request body,
            string app,
            string configId,
            string namespace_
        )
        {
            UpdateSecretV2 op = builder.Build(
                body,
                app,
                configId,
                namespace_
            );

            return ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).UpdateSecretV2(op);
        }
        public static async Task<Csm.Model.ApimodelUpdateConfigurationV2Response?> ExecuteAsync(
            this UpdateSecretV2.UpdateSecretV2Builder builder,
            ApimodelUpdateConfigurationV2Request body,
            string app,
            string configId,
            string namespace_
        )
        {
            UpdateSecretV2 op = builder.Build(
                body,
                app,
                configId,
                namespace_
            );

            return await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).UpdateSecretV2Async(op);
        }
        public static void Execute(
            this DeleteSecretV2.DeleteSecretV2Builder builder,
            string app,
            string configId,
            string namespace_
        )
        {
            DeleteSecretV2 op = builder.Build(
                app,
                configId,
                namespace_
            );

            ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).DeleteSecretV2(op);
        }
        public static async Task ExecuteAsync(
            this DeleteSecretV2.DeleteSecretV2Builder builder,
            string app,
            string configId,
            string namespace_
        )
        {
            DeleteSecretV2 op = builder.Build(
                app,
                configId,
                namespace_
            );

            await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).DeleteSecretV2Async(op);
        }
        public static Csm.Model.ApimodelGetListOfConfigurationsV2Response? Execute(
            this GetListOfVariablesV2.GetListOfVariablesV2Builder builder,
            string app,
            string namespace_
        )
        {
            GetListOfVariablesV2 op = builder.Build(
                app,
                namespace_
            );

            return ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).GetListOfVariablesV2(op);
        }
        public static async Task<Csm.Model.ApimodelGetListOfConfigurationsV2Response?> ExecuteAsync(
            this GetListOfVariablesV2.GetListOfVariablesV2Builder builder,
            string app,
            string namespace_
        )
        {
            GetListOfVariablesV2 op = builder.Build(
                app,
                namespace_
            );

            return await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).GetListOfVariablesV2Async(op);
        }
        public static Csm.Model.ApimodelSaveConfigurationV2Response? Execute(
            this SaveVariableV2.SaveVariableV2Builder builder,
            ApimodelSaveConfigurationV2Request body,
            string app,
            string namespace_
        )
        {
            SaveVariableV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).SaveVariableV2(op);
        }
        public static async Task<Csm.Model.ApimodelSaveConfigurationV2Response?> ExecuteAsync(
            this SaveVariableV2.SaveVariableV2Builder builder,
            ApimodelSaveConfigurationV2Request body,
            string app,
            string namespace_
        )
        {
            SaveVariableV2 op = builder.Build(
                body,
                app,
                namespace_
            );

            return await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).SaveVariableV2Async(op);
        }
        public static Csm.Model.ApimodelUpdateConfigurationV2Response? Execute(
            this UpdateVariableV2.UpdateVariableV2Builder builder,
            ApimodelUpdateConfigurationV2Request body,
            string app,
            string configId,
            string namespace_
        )
        {
            UpdateVariableV2 op = builder.Build(
                body,
                app,
                configId,
                namespace_
            );

            return ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).UpdateVariableV2(op);
        }
        public static async Task<Csm.Model.ApimodelUpdateConfigurationV2Response?> ExecuteAsync(
            this UpdateVariableV2.UpdateVariableV2Builder builder,
            ApimodelUpdateConfigurationV2Request body,
            string app,
            string configId,
            string namespace_
        )
        {
            UpdateVariableV2 op = builder.Build(
                body,
                app,
                configId,
                namespace_
            );

            return await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).UpdateVariableV2Async(op);
        }
        public static void Execute(
            this DeleteVariableV2.DeleteVariableV2Builder builder,
            string app,
            string configId,
            string namespace_
        )
        {
            DeleteVariableV2 op = builder.Build(
                app,
                configId,
                namespace_
            );

            ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).DeleteVariableV2(op);
        }
        public static async Task ExecuteAsync(
            this DeleteVariableV2.DeleteVariableV2Builder builder,
            string app,
            string configId,
            string namespace_
        )
        {
            DeleteVariableV2 op = builder.Build(
                app,
                configId,
                namespace_
            );

            await ((Csm.Wrapper.ConfigurationV2)builder.WrapperObject!).DeleteVariableV2Async(op);
        }
    }
}