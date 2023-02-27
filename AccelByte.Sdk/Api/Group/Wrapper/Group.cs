// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public GetListGroupByIDsAdminV2.GetListGroupByIDsAdminV2Builder GetListGroupByIDsAdminV2Op
        {
            get { return Operation.GetListGroupByIDsAdminV2.Builder.SetWrapperObject(this); }
        }
        public CreateNewGroupPublicV2.CreateNewGroupPublicV2Builder CreateNewGroupPublicV2Op
        {
            get { return Operation.CreateNewGroupPublicV2.Builder.SetWrapperObject(this); }
        }
        public GetListGroupByIDsV2.GetListGroupByIDsV2Builder GetListGroupByIDsV2Op
        {
            get { return Operation.GetListGroupByIDsV2.Builder.SetWrapperObject(this); }
        }
        public UpdatePutSingleGroupPublicV2.UpdatePutSingleGroupPublicV2Builder UpdatePutSingleGroupPublicV2Op
        {
            get { return Operation.UpdatePutSingleGroupPublicV2.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupPublicV2.DeleteGroupPublicV2Builder DeleteGroupPublicV2Op
        {
            get { return Operation.DeleteGroupPublicV2.Builder.SetWrapperObject(this); }
        }
        public UpdatePatchSingleGroupPublicV2.UpdatePatchSingleGroupPublicV2Builder UpdatePatchSingleGroupPublicV2Op
        {
            get { return Operation.UpdatePatchSingleGroupPublicV2.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupCustomAttributesPublicV2.UpdateGroupCustomAttributesPublicV2Builder UpdateGroupCustomAttributesPublicV2Op
        {
            get { return Operation.UpdateGroupCustomAttributesPublicV2.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupCustomRulePublicV2.UpdateGroupCustomRulePublicV2Builder UpdateGroupCustomRulePublicV2Op
        {
            get { return Operation.UpdateGroupCustomRulePublicV2.Builder.SetWrapperObject(this); }
        }
        public UpdateGroupPredefinedRulePublicV2.UpdateGroupPredefinedRulePublicV2Builder UpdateGroupPredefinedRulePublicV2Op
        {
            get { return Operation.UpdateGroupPredefinedRulePublicV2.Builder.SetWrapperObject(this); }
        }
        public DeleteGroupPredefinedRulePublicV2.DeleteGroupPredefinedRulePublicV2Builder DeleteGroupPredefinedRulePublicV2Op
        {
            get { return Operation.DeleteGroupPredefinedRulePublicV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsGetGroupsListResponseV1? GetGroupListAdminV1(GetGroupListAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? GetSingleGroupAdminV1(GetSingleGroupAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? GetSingleGroupAdminV1<T1>(GetSingleGroupAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupAdminV1(DeleteGroupAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsListResponseV1? GetGroupListPublicV1(GetGroupListPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? CreateNewGroupPublicV1(CreateNewGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? CreateNewGroupPublicV1<T1>(CreateNewGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? GetSingleGroupPublicV1(GetSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? GetSingleGroupPublicV1<T1>(GetSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateSingleGroupV1(UpdateSingleGroupV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateSingleGroupV1<T1>(UpdateSingleGroupV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPublicV1(DeleteGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePatchSingleGroupPublicV1(UpdatePatchSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdatePatchSingleGroupPublicV1<T1>(UpdatePatchSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomAttributesPublicV1(UpdateGroupCustomAttributesPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomAttributesPublicV1<T1>(UpdateGroupCustomAttributesPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomRulePublicV1(UpdateGroupCustomRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomRulePublicV1<T1>(UpdateGroupCustomRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupPredefinedRulePublicV1(UpdateGroupPredefinedRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupPredefinedRulePublicV1<T1>(UpdateGroupPredefinedRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPredefinedRulePublicV1(DeleteGroupPredefinedRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsResponseV1? GetListGroupByIDsAdminV2(GetListGroupByIDsAdminV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? CreateNewGroupPublicV2(CreateNewGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? CreateNewGroupPublicV2<T1>(CreateNewGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsResponseV1? GetListGroupByIDsV2(GetListGroupByIDsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePutSingleGroupPublicV2(UpdatePutSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdatePutSingleGroupPublicV2<T1>(UpdatePutSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPublicV2(DeleteGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePatchSingleGroupPublicV2(UpdatePatchSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdatePatchSingleGroupPublicV2<T1>(UpdatePatchSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomAttributesPublicV2(UpdateGroupCustomAttributesPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomAttributesPublicV2<T1>(UpdateGroupCustomAttributesPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomRulePublicV2(UpdateGroupCustomRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomRulePublicV2<T1>(UpdateGroupCustomRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupPredefinedRulePublicV2(UpdateGroupPredefinedRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupPredefinedRulePublicV2<T1>(UpdateGroupPredefinedRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPredefinedRulePublicV2(DeleteGroupPredefinedRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}