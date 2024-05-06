// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Notification
    {
        private readonly AccelByteSDK _sdk;

        public Notification(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SendMultipleUsersFreeformNotificationV1Admin.SendMultipleUsersFreeformNotificationV1AdminBuilder SendMultipleUsersFreeformNotificationV1AdminOp
        {
            get { return Operation.SendMultipleUsersFreeformNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public SendUsersFreeformNotificationV1Admin.SendUsersFreeformNotificationV1AdminBuilder SendUsersFreeformNotificationV1AdminOp
        {
            get { return Operation.SendUsersFreeformNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public SendPartyFreeformNotificationV1Admin.SendPartyFreeformNotificationV1AdminBuilder SendPartyFreeformNotificationV1AdminOp
        {
            get { return Operation.SendPartyFreeformNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public SendPartyTemplatedNotificationV1Admin.SendPartyTemplatedNotificationV1AdminBuilder SendPartyTemplatedNotificationV1AdminOp
        {
            get { return Operation.SendPartyTemplatedNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public GetAllNotificationTemplatesV1Admin.GetAllNotificationTemplatesV1AdminBuilder GetAllNotificationTemplatesV1AdminOp
        {
            get { return Operation.GetAllNotificationTemplatesV1Admin.Builder.SetWrapperObject(this); }
        }
        public CreateNotificationTemplateV1Admin.CreateNotificationTemplateV1AdminBuilder CreateNotificationTemplateV1AdminOp
        {
            get { return Operation.CreateNotificationTemplateV1Admin.Builder.SetWrapperObject(this); }
        }
        public SendUsersTemplatedNotificationV1Admin.SendUsersTemplatedNotificationV1AdminBuilder SendUsersTemplatedNotificationV1AdminOp
        {
            get { return Operation.SendUsersTemplatedNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public GetTemplateSlugLocalizationsTemplateV1Admin.GetTemplateSlugLocalizationsTemplateV1AdminBuilder GetTemplateSlugLocalizationsTemplateV1AdminOp
        {
            get { return Operation.GetTemplateSlugLocalizationsTemplateV1Admin.Builder.SetWrapperObject(this); }
        }
        public DeleteNotificationTemplateSlugV1Admin.DeleteNotificationTemplateSlugV1AdminBuilder DeleteNotificationTemplateSlugV1AdminOp
        {
            get { return Operation.DeleteNotificationTemplateSlugV1Admin.Builder.SetWrapperObject(this); }
        }
        public GetSingleTemplateLocalizationV1Admin.GetSingleTemplateLocalizationV1AdminBuilder GetSingleTemplateLocalizationV1AdminOp
        {
            get { return Operation.GetSingleTemplateLocalizationV1Admin.Builder.SetWrapperObject(this); }
        }
        public UpdateTemplateLocalizationV1Admin.UpdateTemplateLocalizationV1AdminBuilder UpdateTemplateLocalizationV1AdminOp
        {
            get { return Operation.UpdateTemplateLocalizationV1Admin.Builder.SetWrapperObject(this); }
        }
        public DeleteTemplateLocalizationV1Admin.DeleteTemplateLocalizationV1AdminBuilder DeleteTemplateLocalizationV1AdminOp
        {
            get { return Operation.DeleteTemplateLocalizationV1Admin.Builder.SetWrapperObject(this); }
        }
        public PublishTemplateLocalizationV1Admin.PublishTemplateLocalizationV1AdminBuilder PublishTemplateLocalizationV1AdminOp
        {
            get { return Operation.PublishTemplateLocalizationV1Admin.Builder.SetWrapperObject(this); }
        }
        public GetAllNotificationTopicsV1Admin.GetAllNotificationTopicsV1AdminBuilder GetAllNotificationTopicsV1AdminOp
        {
            get { return Operation.GetAllNotificationTopicsV1Admin.Builder.SetWrapperObject(this); }
        }
        public CreateNotificationTopicV1Admin.CreateNotificationTopicV1AdminBuilder CreateNotificationTopicV1AdminOp
        {
            get { return Operation.CreateNotificationTopicV1Admin.Builder.SetWrapperObject(this); }
        }
        public GetNotificationTopicV1Admin.GetNotificationTopicV1AdminBuilder GetNotificationTopicV1AdminOp
        {
            get { return Operation.GetNotificationTopicV1Admin.Builder.SetWrapperObject(this); }
        }
        public UpdateNotificationTopicV1Admin.UpdateNotificationTopicV1AdminBuilder UpdateNotificationTopicV1AdminOp
        {
            get { return Operation.UpdateNotificationTopicV1Admin.Builder.SetWrapperObject(this); }
        }
        public DeleteNotificationTopicV1Admin.DeleteNotificationTopicV1AdminBuilder DeleteNotificationTopicV1AdminOp
        {
            get { return Operation.DeleteNotificationTopicV1Admin.Builder.SetWrapperObject(this); }
        }
        public SendSpecificUserFreeformNotificationV1Admin.SendSpecificUserFreeformNotificationV1AdminBuilder SendSpecificUserFreeformNotificationV1AdminOp
        {
            get { return Operation.SendSpecificUserFreeformNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public SendSpecificUserTemplatedNotificationV1Admin.SendSpecificUserTemplatedNotificationV1AdminBuilder SendSpecificUserTemplatedNotificationV1AdminOp
        {
            get { return Operation.SendSpecificUserTemplatedNotificationV1Admin.Builder.SetWrapperObject(this); }
        }
        public GetMyNotifications.GetMyNotificationsBuilder GetMyNotificationsOp
        {
            get { return Operation.GetMyNotifications.Builder.SetWrapperObject(this); }
        }
        public GetTopicByNamespace.GetTopicByNamespaceBuilder GetTopicByNamespaceOp
        {
            get { return Operation.GetTopicByNamespace.Builder.SetWrapperObject(this); }
        }
        public CreateTopic.CreateTopicBuilder CreateTopicOp
        {
            get { return Operation.CreateTopic.Builder.SetWrapperObject(this); }
        }
        public GetTopicByTopicName.GetTopicByTopicNameBuilder GetTopicByTopicNameOp
        {
            get { return Operation.GetTopicByTopicName.Builder.SetWrapperObject(this); }
        }
        public UpdateTopicByTopicName.UpdateTopicByTopicNameBuilder UpdateTopicByTopicNameOp
        {
            get { return Operation.UpdateTopicByTopicName.Builder.SetWrapperObject(this); }
        }
        public DeleteTopicByTopicName.DeleteTopicByTopicNameBuilder DeleteTopicByTopicNameOp
        {
            get { return Operation.DeleteTopicByTopicName.Builder.SetWrapperObject(this); }
        }
        public FreeFormNotificationByUserID.FreeFormNotificationByUserIDBuilder FreeFormNotificationByUserIDOp
        {
            get { return Operation.FreeFormNotificationByUserID.Builder.SetWrapperObject(this); }
        }
        public NotificationWithTemplateByUserID.NotificationWithTemplateByUserIDBuilder NotificationWithTemplateByUserIDOp
        {
            get { return Operation.NotificationWithTemplateByUserID.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void SendMultipleUsersFreeformNotificationV1Admin(SendMultipleUsersFreeformNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendMultipleUsersFreeformNotificationV1AdminAsync(SendMultipleUsersFreeformNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendUsersFreeformNotificationV1Admin(SendUsersFreeformNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendUsersFreeformNotificationV1AdminAsync(SendUsersFreeformNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendPartyFreeformNotificationV1Admin(SendPartyFreeformNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendPartyFreeformNotificationV1AdminAsync(SendPartyFreeformNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendPartyTemplatedNotificationV1Admin(SendPartyTemplatedNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendPartyTemplatedNotificationV1AdminAsync(SendPartyTemplatedNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelNotificationTemplateResponse>? GetAllNotificationTemplatesV1Admin(GetAllNotificationTemplatesV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelNotificationTemplateResponse>?> GetAllNotificationTemplatesV1AdminAsync(GetAllNotificationTemplatesV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateNotificationTemplateV1Admin(CreateNotificationTemplateV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateNotificationTemplateV1AdminAsync(CreateNotificationTemplateV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendUsersTemplatedNotificationV1Admin(SendUsersTemplatedNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendUsersTemplatedNotificationV1AdminAsync(SendUsersTemplatedNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetAllNotificationTemplateSlugResp? GetTemplateSlugLocalizationsTemplateV1Admin(GetTemplateSlugLocalizationsTemplateV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelGetAllNotificationTemplateSlugResp?> GetTemplateSlugLocalizationsTemplateV1AdminAsync(GetTemplateSlugLocalizationsTemplateV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNotificationTemplateSlugV1Admin(DeleteNotificationTemplateSlugV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteNotificationTemplateSlugV1AdminAsync(DeleteNotificationTemplateSlugV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLocalization? GetSingleTemplateLocalizationV1Admin(GetSingleTemplateLocalizationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelLocalization?> GetSingleTemplateLocalizationV1AdminAsync(GetSingleTemplateLocalizationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateTemplateLocalizationV1Admin(UpdateTemplateLocalizationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateTemplateLocalizationV1AdminAsync(UpdateTemplateLocalizationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateLocalizationV1Admin(DeleteTemplateLocalizationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteTemplateLocalizationV1AdminAsync(DeleteTemplateLocalizationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublishTemplateLocalizationV1Admin(PublishTemplateLocalizationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublishTemplateLocalizationV1AdminAsync(PublishTemplateLocalizationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetAllNotificationTopicsResponse? GetAllNotificationTopicsV1Admin(GetAllNotificationTopicsV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelGetAllNotificationTopicsResponse?> GetAllNotificationTopicsV1AdminAsync(GetAllNotificationTopicsV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateNotificationTopicV1Admin(CreateNotificationTopicV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateNotificationTopicV1AdminAsync(CreateNotificationTopicV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelNotificationTopicResponseV1? GetNotificationTopicV1Admin(GetNotificationTopicV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelNotificationTopicResponseV1?> GetNotificationTopicV1AdminAsync(GetNotificationTopicV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateNotificationTopicV1Admin(UpdateNotificationTopicV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateNotificationTopicV1AdminAsync(UpdateNotificationTopicV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNotificationTopicV1Admin(DeleteNotificationTopicV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteNotificationTopicV1AdminAsync(DeleteNotificationTopicV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendSpecificUserFreeformNotificationV1Admin(SendSpecificUserFreeformNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendSpecificUserFreeformNotificationV1AdminAsync(SendSpecificUserFreeformNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendSpecificUserTemplatedNotificationV1Admin(SendSpecificUserTemplatedNotificationV1Admin input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendSpecificUserTemplatedNotificationV1AdminAsync(SendSpecificUserTemplatedNotificationV1Admin input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelNotificationResponse? GetMyNotifications(GetMyNotifications input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelNotificationResponse?> GetMyNotificationsAsync(GetMyNotifications input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelTopicByNamespacesResponse? GetTopicByNamespace(GetTopicByNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelTopicByNamespacesResponse?> GetTopicByNamespaceAsync(GetTopicByNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateTopic(CreateTopic input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateTopicAsync(CreateTopic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelNotificationTopicResponse? GetTopicByTopicName(GetTopicByTopicName input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelNotificationTopicResponse?> GetTopicByTopicNameAsync(GetTopicByTopicName input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateTopicByTopicName(UpdateTopicByTopicName input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateTopicByTopicNameAsync(UpdateTopicByTopicName input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTopicByTopicName(DeleteTopicByTopicName input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteTopicByTopicNameAsync(DeleteTopicByTopicName input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void FreeFormNotificationByUserID(FreeFormNotificationByUserID input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task FreeFormNotificationByUserIDAsync(FreeFormNotificationByUserID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void NotificationWithTemplateByUserID(NotificationWithTemplateByUserID input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task NotificationWithTemplateByUserIDAsync(NotificationWithTemplateByUserID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}