// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Store
    {
        private readonly AccelByteSDK _sdk;

        public Store(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListStores.ListStoresBuilder ListStoresOp
        {
            get { return Operation.ListStores.Builder.SetWrapperObject(this); }
        }
        public CreateStore.CreateStoreBuilder CreateStoreOp
        {
            get { return Operation.CreateStore.Builder.SetWrapperObject(this); }
        }
        public ImportStore.ImportStoreBuilder ImportStoreOp
        {
            get { return Operation.ImportStore.Builder.SetWrapperObject(this); }
        }
        public GetPublishedStore.GetPublishedStoreBuilder GetPublishedStoreOp
        {
            get { return Operation.GetPublishedStore.Builder.SetWrapperObject(this); }
        }
        public DeletePublishedStore.DeletePublishedStoreBuilder DeletePublishedStoreOp
        {
            get { return Operation.DeletePublishedStore.Builder.SetWrapperObject(this); }
        }
        public GetPublishedStoreBackup.GetPublishedStoreBackupBuilder GetPublishedStoreBackupOp
        {
            get { return Operation.GetPublishedStoreBackup.Builder.SetWrapperObject(this); }
        }
        public RollbackPublishedStore.RollbackPublishedStoreBuilder RollbackPublishedStoreOp
        {
            get { return Operation.RollbackPublishedStore.Builder.SetWrapperObject(this); }
        }
        public GetStore.GetStoreBuilder GetStoreOp
        {
            get { return Operation.GetStore.Builder.SetWrapperObject(this); }
        }
        public UpdateStore.UpdateStoreBuilder UpdateStoreOp
        {
            get { return Operation.UpdateStore.Builder.SetWrapperObject(this); }
        }
        public DeleteStore.DeleteStoreBuilder DeleteStoreOp
        {
            get { return Operation.DeleteStore.Builder.SetWrapperObject(this); }
        }
        public CloneStore.CloneStoreBuilder CloneStoreOp
        {
            get { return Operation.CloneStore.Builder.SetWrapperObject(this); }
        }
        public ExportStore.ExportStoreBuilder ExportStoreOp
        {
            get { return Operation.ExportStore.Builder.SetWrapperObject(this); }
        }
        public PublicListStores.PublicListStoresBuilder PublicListStoresOp
        {
            get { return Operation.PublicListStores.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.StoreInfo>? ListStores(ListStores input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? CreateStore(CreateStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? ImportStore(ImportStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? GetPublishedStore(GetPublishedStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? DeletePublishedStore(DeletePublishedStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreBackupInfo? GetPublishedStoreBackup(GetPublishedStoreBackup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? RollbackPublishedStore(RollbackPublishedStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? GetStore(GetStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? UpdateStore(UpdateStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? DeleteStore(DeleteStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? CloneStore(CloneStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ExportStore(ExportStore input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.StoreInfo>? PublicListStores(PublicListStores input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}