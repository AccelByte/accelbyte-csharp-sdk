// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class DataRetrieval
    {
        private readonly AccelByteSDK _sdk;

        public DataRetrieval(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAdminEmailConfiguration.GetAdminEmailConfigurationBuilder GetAdminEmailConfigurationOp
        {
            get { return Operation.GetAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public UpdateAdminEmailConfiguration.UpdateAdminEmailConfigurationBuilder UpdateAdminEmailConfigurationOp
        {
            get { return Operation.UpdateAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public SaveAdminEmailConfiguration.SaveAdminEmailConfigurationBuilder SaveAdminEmailConfigurationOp
        {
            get { return Operation.SaveAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public DeleteAdminEmailConfiguration.DeleteAdminEmailConfigurationBuilder DeleteAdminEmailConfigurationOp
        {
            get { return Operation.DeleteAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminGetListPersonalDataRequest.AdminGetListPersonalDataRequestBuilder AdminGetListPersonalDataRequestOp
        {
            get { return Operation.AdminGetListPersonalDataRequest.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserPersonalDataRequests.AdminGetUserPersonalDataRequestsBuilder AdminGetUserPersonalDataRequestsOp
        {
            get { return Operation.AdminGetUserPersonalDataRequests.Builder.SetWrapperObject(this); }
        }
        public AdminRequestDataRetrieval.AdminRequestDataRetrievalBuilder AdminRequestDataRetrievalOp
        {
            get { return Operation.AdminRequestDataRetrieval.Builder.SetWrapperObject(this); }
        }
        public AdminCancelUserPersonalDataRequest.AdminCancelUserPersonalDataRequestBuilder AdminCancelUserPersonalDataRequestOp
        {
            get { return Operation.AdminCancelUserPersonalDataRequest.Builder.SetWrapperObject(this); }
        }
        public AdminGeneratePersonalDataURL.AdminGeneratePersonalDataURLBuilder AdminGeneratePersonalDataURLOp
        {
            get { return Operation.AdminGeneratePersonalDataURL.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserPersonalDataRequests.PublicGetUserPersonalDataRequestsBuilder PublicGetUserPersonalDataRequestsOp
        {
            get { return Operation.PublicGetUserPersonalDataRequests.Builder.SetWrapperObject(this); }
        }
        public PublicRequestDataRetrieval.PublicRequestDataRetrievalBuilder PublicRequestDataRetrievalOp
        {
            get { return Operation.PublicRequestDataRetrieval.Builder.SetWrapperObject(this); }
        }
        public PublicCancelUserPersonalDataRequest.PublicCancelUserPersonalDataRequestBuilder PublicCancelUserPersonalDataRequestOp
        {
            get { return Operation.PublicCancelUserPersonalDataRequest.Builder.SetWrapperObject(this); }
        }
        public PublicGeneratePersonalDataURL.PublicGeneratePersonalDataURLBuilder PublicGeneratePersonalDataURLOp
        {
            get { return Operation.PublicGeneratePersonalDataURL.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<string>? GetAdminEmailConfiguration(GetAdminEmailConfiguration input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateAdminEmailConfiguration(UpdateAdminEmailConfiguration input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SaveAdminEmailConfiguration(SaveAdminEmailConfiguration input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAdminEmailConfiguration(DeleteAdminEmailConfiguration input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListPersonalDataResponse? AdminGetListPersonalDataRequest(AdminGetListPersonalDataRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserPersonalDataResponse? AdminGetUserPersonalDataRequests(AdminGetUserPersonalDataRequests input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDataRetrievalResponse? AdminRequestDataRetrieval(AdminRequestDataRetrieval input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCancelUserPersonalDataRequest(AdminCancelUserPersonalDataRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserDataURL? AdminGeneratePersonalDataURL(AdminGeneratePersonalDataURL input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserPersonalDataResponse? PublicGetUserPersonalDataRequests(PublicGetUserPersonalDataRequests input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDataRetrievalResponse? PublicRequestDataRetrieval(PublicRequestDataRetrieval input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListPersonalDataResponse? PublicCancelUserPersonalDataRequest(PublicCancelUserPersonalDataRequest input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserDataURL? PublicGeneratePersonalDataURL(PublicGeneratePersonalDataURL input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}