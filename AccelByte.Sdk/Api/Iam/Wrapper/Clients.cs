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
}