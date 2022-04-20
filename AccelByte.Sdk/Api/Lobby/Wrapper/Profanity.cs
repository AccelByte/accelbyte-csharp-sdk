// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Profanity
    {
        private readonly AccelByteSDK _sdk;

        public Profanity(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminDebugProfanityFilters.AdminDebugProfanityFiltersBuilder AdminDebugProfanityFiltersOp
        {
            get { return Operation.AdminDebugProfanityFilters.Builder.SetWrapperObject(this); }
        }
        public AdminGetProfanityListFiltersV1.AdminGetProfanityListFiltersV1Builder AdminGetProfanityListFiltersV1Op
        {
            get { return Operation.AdminGetProfanityListFiltersV1.Builder.SetWrapperObject(this); }
        }
        public AdminAddProfanityFilterIntoList.AdminAddProfanityFilterIntoListBuilder AdminAddProfanityFilterIntoListOp
        {
            get { return Operation.AdminAddProfanityFilterIntoList.Builder.SetWrapperObject(this); }
        }
        public AdminAddProfanityFilters.AdminAddProfanityFiltersBuilder AdminAddProfanityFiltersOp
        {
            get { return Operation.AdminAddProfanityFilters.Builder.SetWrapperObject(this); }
        }
        public AdminImportProfanityFiltersFromFile.AdminImportProfanityFiltersFromFileBuilder AdminImportProfanityFiltersFromFileOp
        {
            get { return Operation.AdminImportProfanityFiltersFromFile.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteProfanityFilter.AdminDeleteProfanityFilterBuilder AdminDeleteProfanityFilterOp
        {
            get { return Operation.AdminDeleteProfanityFilter.Builder.SetWrapperObject(this); }
        }
        public AdminGetProfanityLists.AdminGetProfanityListsBuilder AdminGetProfanityListsOp
        {
            get { return Operation.AdminGetProfanityLists.Builder.SetWrapperObject(this); }
        }
        public AdminCreateProfanityList.AdminCreateProfanityListBuilder AdminCreateProfanityListOp
        {
            get { return Operation.AdminCreateProfanityList.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateProfanityList.AdminUpdateProfanityListBuilder AdminUpdateProfanityListOp
        {
            get { return Operation.AdminUpdateProfanityList.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteProfanityList.AdminDeleteProfanityListBuilder AdminDeleteProfanityListOp
        {
            get { return Operation.AdminDeleteProfanityList.Builder.SetWrapperObject(this); }
        }
        public AdminGetProfanityRule.AdminGetProfanityRuleBuilder AdminGetProfanityRuleOp
        {
            get { return Operation.AdminGetProfanityRule.Builder.SetWrapperObject(this); }
        }
        public AdminSetProfanityRuleForNamespace.AdminSetProfanityRuleForNamespaceBuilder AdminSetProfanityRuleForNamespaceOp
        {
            get { return Operation.AdminSetProfanityRuleForNamespace.Builder.SetWrapperObject(this); }
        }
        public AdminVerifyMessageProfanityResponse.AdminVerifyMessageProfanityResponseBuilder AdminVerifyMessageProfanityResponseOp
        {
            get { return Operation.AdminVerifyMessageProfanityResponse.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.ModelsProfanityFilter>? AdminDebugProfanityFilters(AdminDebugProfanityFilters input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminGetProfanityListFiltersV1Response? AdminGetProfanityListFiltersV1(AdminGetProfanityListFiltersV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddProfanityFilterIntoList(AdminAddProfanityFilterIntoList input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddProfanityFilters(AdminAddProfanityFilters input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminImportProfanityFiltersFromFile(AdminImportProfanityFiltersFromFile input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsProfanityFilter>? AdminDeleteProfanityFilter(AdminDeleteProfanityFilter input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsAdminGetProfanityListsListResponse>? AdminGetProfanityLists(AdminGetProfanityLists input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCreateProfanityList(AdminCreateProfanityList input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateProfanityList(AdminUpdateProfanityList input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteProfanityList(AdminDeleteProfanityList input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsProfanityRule? AdminGetProfanityRule(AdminGetProfanityRule input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSetProfanityRuleForNamespace(AdminSetProfanityRuleForNamespace input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminVerifyMessageProfanityResponse? AdminVerifyMessageProfanityResponse(AdminVerifyMessageProfanityResponse input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}