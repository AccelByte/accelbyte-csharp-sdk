// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class Clients
    {
        private readonly AccelByteSDK _sdk;

        public Clients(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetClients.GetClientsBuilder GetClientsOp
        {
            get { return Operation.GetClients.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public CreateClient.CreateClientBuilder CreateClientOp
        {
            get { return Operation.CreateClient.Builder.SetWrapperObject(this); }
        }
        public GetClient.GetClientBuilder GetClientOp
        {
            get { return Operation.GetClient.Builder.SetWrapperObject(this); }
        }
        public UpdateClient.UpdateClientBuilder UpdateClientOp
        {
            get { return Operation.UpdateClient.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DeleteClient.DeleteClientBuilder DeleteClientOp
        {
            get { return Operation.DeleteClient.Builder.SetWrapperObject(this); }
        }
        public UpdateClientPermission.UpdateClientPermissionBuilder UpdateClientPermissionOp
        {
            get { return Operation.UpdateClientPermission.Builder.SetWrapperObject(this); }
        }
        public AddClientPermission.AddClientPermissionBuilder AddClientPermissionOp
        {
            get { return Operation.AddClientPermission.Builder.SetWrapperObject(this); }
        }
        public DeleteClientPermission.DeleteClientPermissionBuilder DeleteClientPermissionOp
        {
            get { return Operation.DeleteClientPermission.Builder.SetWrapperObject(this); }
        }
        public UpdateClientSecret.UpdateClientSecretBuilder UpdateClientSecretOp
        {
            get { return Operation.UpdateClientSecret.Builder.SetWrapperObject(this); }
        }
        public GetClientsbyNamespace.GetClientsbyNamespaceBuilder GetClientsbyNamespaceOp
        {
            get { return Operation.GetClientsbyNamespace.Builder.SetWrapperObject(this); }
        }
        public CreateClientByNamespace.CreateClientByNamespaceBuilder CreateClientByNamespaceOp
        {
            get { return Operation.CreateClientByNamespace.Builder.SetWrapperObject(this); }
        }
        public DeleteClientByNamespace.DeleteClientByNamespaceBuilder DeleteClientByNamespaceOp
        {
            get { return Operation.DeleteClientByNamespace.Builder.SetWrapperObject(this); }
        }
        public AdminGetClientsByNamespaceV3.AdminGetClientsByNamespaceV3Builder AdminGetClientsByNamespaceV3Op
        {
            get { return Operation.AdminGetClientsByNamespaceV3.Builder.SetWrapperObject(this); }
        }
        public AdminCreateClientV3.AdminCreateClientV3Builder AdminCreateClientV3Op
        {
            get { return Operation.AdminCreateClientV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetClientsbyNamespacebyIDV3.AdminGetClientsbyNamespacebyIDV3Builder AdminGetClientsbyNamespacebyIDV3Op
        {
            get { return Operation.AdminGetClientsbyNamespacebyIDV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteClientV3.AdminDeleteClientV3Builder AdminDeleteClientV3Op
        {
            get { return Operation.AdminDeleteClientV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateClientV3.AdminUpdateClientV3Builder AdminUpdateClientV3Op
        {
            get { return Operation.AdminUpdateClientV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateClientPermissionV3.AdminUpdateClientPermissionV3Builder AdminUpdateClientPermissionV3Op
        {
            get { return Operation.AdminUpdateClientPermissionV3.Builder.SetWrapperObject(this); }
        }
        public AdminAddClientPermissionsV3.AdminAddClientPermissionsV3Builder AdminAddClientPermissionsV3Op
        {
            get { return Operation.AdminAddClientPermissionsV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteClientPermissionV3.AdminDeleteClientPermissionV3Builder AdminDeleteClientPermissionV3Op
        {
            get { return Operation.AdminDeleteClientPermissionV3.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public List<Model.ClientmodelClientResponse>? GetClients(GetClients input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ClientmodelClientCreationResponse? CreateClient(CreateClient input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ClientmodelClientResponse? GetClient(GetClient input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelClientResponse? UpdateClient(UpdateClient input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void DeleteClient(DeleteClient input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void UpdateClientPermission(UpdateClientPermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddClientPermission(AddClientPermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteClientPermission(DeleteClientPermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateClientSecret(UpdateClientSecret input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ClientmodelClientResponse>? GetClientsbyNamespace(GetClientsbyNamespace input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelClientCreationResponse? CreateClientByNamespace(CreateClientByNamespace input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteClientByNamespace(DeleteClientByNamespace input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelClientsV3Response? AdminGetClientsByNamespaceV3(AdminGetClientsByNamespaceV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelClientV3Response? AdminCreateClientV3(AdminCreateClientV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelClientV3Response? AdminGetClientsbyNamespacebyIDV3(AdminGetClientsbyNamespacebyIDV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteClientV3(AdminDeleteClientV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelClientV3Response? AdminUpdateClientV3(AdminUpdateClientV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateClientPermissionV3(AdminUpdateClientPermissionV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddClientPermissionsV3(AdminAddClientPermissionsV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteClientPermissionV3(AdminDeleteClientPermissionV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Clients_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static List<Model.ClientmodelClientResponse>? Execute(
            this GetClients.GetClientsBuilder builder
        )
        {
            GetClients op = builder.Build(
            );

            return ((Clients)builder.WrapperObject!).GetClients(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ClientmodelClientCreationResponse? Execute(
            this CreateClient.CreateClientBuilder builder,
            ClientmodelClientCreateRequest body
        )
        {
            CreateClient op = builder.Build(
                body
            );

            return ((Clients)builder.WrapperObject!).CreateClient(op);
        }

        public static Model.ClientmodelClientResponse? Execute(
            this GetClient.GetClientBuilder builder,
            string clientId
        )
        {
            GetClient op = builder.Build(
                clientId
            );

            return ((Clients)builder.WrapperObject!).GetClient(op);
        }

        public static Model.ClientmodelClientResponse? Execute(
            this UpdateClient.UpdateClientBuilder builder,
            ClientmodelClientUpdateRequest body,
            string clientId
        )
        {
            UpdateClient op = builder.Build(
                body,
                clientId
            );

            return ((Clients)builder.WrapperObject!).UpdateClient(op);
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

            ((Clients)builder.WrapperObject!).DeleteClient(op);
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

            ((Clients)builder.WrapperObject!).UpdateClientPermission(op);
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

            ((Clients)builder.WrapperObject!).AddClientPermission(op);
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

            ((Clients)builder.WrapperObject!).DeleteClientPermission(op);
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

            ((Clients)builder.WrapperObject!).UpdateClientSecret(op);
        }

        public static List<Model.ClientmodelClientResponse>? Execute(
            this GetClientsbyNamespace.GetClientsbyNamespaceBuilder builder,
            string namespace_
        )
        {
            GetClientsbyNamespace op = builder.Build(
                namespace_
            );

            return ((Clients)builder.WrapperObject!).GetClientsbyNamespace(op);
        }

        public static Model.ClientmodelClientCreationResponse? Execute(
            this CreateClientByNamespace.CreateClientByNamespaceBuilder builder,
            ClientmodelClientCreateRequest body,
            string namespace_
        )
        {
            CreateClientByNamespace op = builder.Build(
                body,
                namespace_
            );

            return ((Clients)builder.WrapperObject!).CreateClientByNamespace(op);
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

            ((Clients)builder.WrapperObject!).DeleteClientByNamespace(op);
        }

        public static Model.ClientmodelClientsV3Response? Execute(
            this AdminGetClientsByNamespaceV3.AdminGetClientsByNamespaceV3Builder builder,
            string namespace_
        )
        {
            AdminGetClientsByNamespaceV3 op = builder.Build(
                namespace_
            );

            return ((Clients)builder.WrapperObject!).AdminGetClientsByNamespaceV3(op);
        }

        public static Model.ClientmodelClientV3Response? Execute(
            this AdminCreateClientV3.AdminCreateClientV3Builder builder,
            ClientmodelClientCreationV3Request body,
            string namespace_
        )
        {
            AdminCreateClientV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Clients)builder.WrapperObject!).AdminCreateClientV3(op);
        }

        public static Model.ClientmodelClientV3Response? Execute(
            this AdminGetClientsbyNamespacebyIDV3.AdminGetClientsbyNamespacebyIDV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            AdminGetClientsbyNamespacebyIDV3 op = builder.Build(
                clientId,
                namespace_
            );

            return ((Clients)builder.WrapperObject!).AdminGetClientsbyNamespacebyIDV3(op);
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

            ((Clients)builder.WrapperObject!).AdminDeleteClientV3(op);
        }

        public static Model.ClientmodelClientV3Response? Execute(
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

            return ((Clients)builder.WrapperObject!).AdminUpdateClientV3(op);
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

            ((Clients)builder.WrapperObject!).AdminUpdateClientPermissionV3(op);
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

            ((Clients)builder.WrapperObject!).AdminAddClientPermissionsV3(op);
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

            ((Clients)builder.WrapperObject!).AdminDeleteClientPermissionV3(op);
        }

    }
}