// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamClients_OpExts
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static List<Iam.Model.ClientmodelClientResponse>? Execute(
            this GetClients.GetClientsBuilder builder
        )
        {
            GetClients op = builder.Build(
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).GetClients(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Iam.Model.ClientmodelClientCreationResponse? Execute(
            this CreateClient.CreateClientBuilder builder,
            ClientmodelClientCreateRequest body
        )
        {
            CreateClient op = builder.Build(
                body
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).CreateClient(op);
        }

        public static Iam.Model.ClientmodelClientResponse? Execute(
            this GetClient.GetClientBuilder builder,
            string clientId
        )
        {
            GetClient op = builder.Build(
                clientId
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).GetClient(op);
        }

        public static Iam.Model.ClientmodelClientResponse? Execute(
            this UpdateClient.UpdateClientBuilder builder,
            ClientmodelClientUpdateRequest body,
            string clientId
        )
        {
            UpdateClient op = builder.Build(
                body,
                clientId
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).UpdateClient(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this DeleteClient.DeleteClientBuilder builder,
            string clientId
        )
        {
            DeleteClient op = builder.Build(
                clientId
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).DeleteClient(op);
        }

        public static void Execute(
            this UpdateClientPermission.UpdateClientPermissionBuilder builder,
            AccountcommonClientPermissions body,
            string clientId
        )
        {
            UpdateClientPermission op = builder.Build(
                body,
                clientId
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).UpdateClientPermission(op);
        }

        public static void Execute(
            this AddClientPermission.AddClientPermissionBuilder builder,
            long action,
            string clientId,
            string resource
        )
        {
            AddClientPermission op = builder.Build(
                action,
                clientId,
                resource
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).AddClientPermission(op);
        }

        public static void Execute(
            this DeleteClientPermission.DeleteClientPermissionBuilder builder,
            long action,
            string clientId,
            string resource
        )
        {
            DeleteClientPermission op = builder.Build(
                action,
                clientId,
                resource
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).DeleteClientPermission(op);
        }

        public static void Execute(
            this UpdateClientSecret.UpdateClientSecretBuilder builder,
            ClientmodelClientUpdateSecretRequest body,
            string clientId
        )
        {
            UpdateClientSecret op = builder.Build(
                body,
                clientId
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).UpdateClientSecret(op);
        }

        public static List<Iam.Model.ClientmodelClientResponse>? Execute(
            this GetClientsbyNamespace.GetClientsbyNamespaceBuilder builder,
            string namespace_
        )
        {
            GetClientsbyNamespace op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).GetClientsbyNamespace(op);
        }

        public static Iam.Model.ClientmodelClientCreationResponse? Execute(
            this CreateClientByNamespace.CreateClientByNamespaceBuilder builder,
            ClientmodelClientCreateRequest body,
            string namespace_
        )
        {
            CreateClientByNamespace op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).CreateClientByNamespace(op);
        }

        public static void Execute(
            this DeleteClientByNamespace.DeleteClientByNamespaceBuilder builder,
            string clientId,
            string namespace_
        )
        {
            DeleteClientByNamespace op = builder.Build(
                clientId,
                namespace_
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).DeleteClientByNamespace(op);
        }

        public static Iam.Model.ClientmodelClientsV3Response? Execute(
            this AdminGetClientsByNamespaceV3.AdminGetClientsByNamespaceV3Builder builder,
            string namespace_
        )
        {
            AdminGetClientsByNamespaceV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminGetClientsByNamespaceV3(op);
        }

        public static Iam.Model.ClientmodelClientV3Response? Execute(
            this AdminCreateClientV3.AdminCreateClientV3Builder builder,
            ClientmodelClientCreationV3Request body,
            string namespace_
        )
        {
            AdminCreateClientV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminCreateClientV3(op);
        }

        public static Iam.Model.ClientmodelClientV3Response? Execute(
            this AdminGetClientsbyNamespacebyIDV3.AdminGetClientsbyNamespacebyIDV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            AdminGetClientsbyNamespacebyIDV3 op = builder.Build(
                clientId,
                namespace_
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminGetClientsbyNamespacebyIDV3(op);
        }

        public static void Execute(
            this AdminDeleteClientV3.AdminDeleteClientV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            AdminDeleteClientV3 op = builder.Build(
                clientId,
                namespace_
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminDeleteClientV3(op);
        }

        public static Iam.Model.ClientmodelClientV3Response? Execute(
            this AdminUpdateClientV3.AdminUpdateClientV3Builder builder,
            ClientmodelClientUpdateV3Request body,
            string clientId,
            string namespace_
        )
        {
            AdminUpdateClientV3 op = builder.Build(
                body,
                clientId,
                namespace_
            );

            return ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminUpdateClientV3(op);
        }

        public static void Execute(
            this AdminUpdateClientPermissionV3.AdminUpdateClientPermissionV3Builder builder,
            AccountcommonClientPermissionsV3 body,
            string clientId,
            string namespace_
        )
        {
            AdminUpdateClientPermissionV3 op = builder.Build(
                body,
                clientId,
                namespace_
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminUpdateClientPermissionV3(op);
        }

        public static void Execute(
            this AdminAddClientPermissionsV3.AdminAddClientPermissionsV3Builder builder,
            AccountcommonClientPermissionsV3 body,
            string clientId,
            string namespace_
        )
        {
            AdminAddClientPermissionsV3 op = builder.Build(
                body,
                clientId,
                namespace_
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminAddClientPermissionsV3(op);
        }

        public static void Execute(
            this AdminDeleteClientPermissionV3.AdminDeleteClientPermissionV3Builder builder,
            long action,
            string clientId,
            string namespace_,
            string resource
        )
        {
            AdminDeleteClientPermissionV3 op = builder.Build(
                action,
                clientId,
                namespace_,
                resource
            );

            ((Iam.Wrapper.Clients)builder.WrapperObject!).AdminDeleteClientPermissionV3(op);
        }

    }
}