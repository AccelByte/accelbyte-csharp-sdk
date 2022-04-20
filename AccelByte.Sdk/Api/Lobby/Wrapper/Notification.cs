// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public FreeFormNotification.FreeFormNotificationBuilder FreeFormNotificationOp
        {
            get { return Operation.FreeFormNotification.Builder.SetWrapperObject(this); }
        }
        public NotificationWithTemplate.NotificationWithTemplateBuilder NotificationWithTemplateOp
        {
            get { return Operation.NotificationWithTemplate.Builder.SetWrapperObject(this); }
        }
        public GetGameTemplate.GetGameTemplateBuilder GetGameTemplateOp
        {
            get { return Operation.GetGameTemplate.Builder.SetWrapperObject(this); }
        }
        public CreateTemplate.CreateTemplateBuilder CreateTemplateOp
        {
            get { return Operation.CreateTemplate.Builder.SetWrapperObject(this); }
        }
        public GetSlugTemplate.GetSlugTemplateBuilder GetSlugTemplateOp
        {
            get { return Operation.GetSlugTemplate.Builder.SetWrapperObject(this); }
        }
        public DeleteTemplateSlug.DeleteTemplateSlugBuilder DeleteTemplateSlugOp
        {
            get { return Operation.DeleteTemplateSlug.Builder.SetWrapperObject(this); }
        }
        public GetLocalizationTemplate.GetLocalizationTemplateBuilder GetLocalizationTemplateOp
        {
            get { return Operation.GetLocalizationTemplate.Builder.SetWrapperObject(this); }
        }
        public UpdateLocalizationTemplate.UpdateLocalizationTemplateBuilder UpdateLocalizationTemplateOp
        {
            get { return Operation.UpdateLocalizationTemplate.Builder.SetWrapperObject(this); }
        }
        public DeleteTemplateLocalization.DeleteTemplateLocalizationBuilder DeleteTemplateLocalizationOp
        {
            get { return Operation.DeleteTemplateLocalization.Builder.SetWrapperObject(this); }
        }
        public PublishTemplate.PublishTemplateBuilder PublishTemplateOp
        {
            get { return Operation.PublishTemplate.Builder.SetWrapperObject(this); }
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
        
        public void SendMultipleUsersFreeformNotificationV1Admin(SendMultipleUsersFreeformNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendUsersFreeformNotificationV1Admin(SendUsersFreeformNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendPartyFreeformNotificationV1Admin(SendPartyFreeformNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendPartyTemplatedNotificationV1Admin(SendPartyTemplatedNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelNotificationTemplateResponse>? GetAllNotificationTemplatesV1Admin(GetAllNotificationTemplatesV1Admin input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateNotificationTemplateV1Admin(CreateNotificationTemplateV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendUsersTemplatedNotificationV1Admin(SendUsersTemplatedNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetAllNotificationTemplateSlugResp? GetTemplateSlugLocalizationsTemplateV1Admin(GetTemplateSlugLocalizationsTemplateV1Admin input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNotificationTemplateSlugV1Admin(DeleteNotificationTemplateSlugV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLocalization? GetSingleTemplateLocalizationV1Admin(GetSingleTemplateLocalizationV1Admin input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateTemplateLocalizationV1Admin(UpdateTemplateLocalizationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateLocalizationV1Admin(DeleteTemplateLocalizationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublishTemplateLocalizationV1Admin(PublishTemplateLocalizationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetAllNotificationTopicsResponse? GetAllNotificationTopicsV1Admin(GetAllNotificationTopicsV1Admin input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateNotificationTopicV1Admin(CreateNotificationTopicV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelNotificationTopicResponseV1? GetNotificationTopicV1Admin(GetNotificationTopicV1Admin input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateNotificationTopicV1Admin(UpdateNotificationTopicV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNotificationTopicV1Admin(DeleteNotificationTopicV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendSpecificUserFreeformNotificationV1Admin(SendSpecificUserFreeformNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendSpecificUserTemplatedNotificationV1Admin(SendSpecificUserTemplatedNotificationV1Admin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void FreeFormNotification(FreeFormNotification input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void NotificationWithTemplate(NotificationWithTemplate input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelTemplateResponse>? GetGameTemplate(GetGameTemplate input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateTemplate(CreateTemplate input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelTemplateLocalizationResponse? GetSlugTemplate(GetSlugTemplate input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateSlug(DeleteTemplateSlug input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelTemplateLocalization? GetLocalizationTemplate(GetLocalizationTemplate input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateLocalizationTemplate(UpdateLocalizationTemplate input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTemplateLocalization(DeleteTemplateLocalization input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublishTemplate(PublishTemplate input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelTopicByNamespacesResponse? GetTopicByNamespace(GetTopicByNamespace input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateTopic(CreateTopic input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelNotificationTopicResponse? GetTopicByTopicName(GetTopicByTopicName input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateTopicByTopicName(UpdateTopicByTopicName input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTopicByTopicName(DeleteTopicByTopicName input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void FreeFormNotificationByUserID(FreeFormNotificationByUserID input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void NotificationWithTemplateByUserID(NotificationWithTemplateByUserID input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}