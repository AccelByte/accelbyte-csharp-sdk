// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyNotification_OpExts
    {
        public static void Execute(
            this SendMultipleUsersFreeformNotificationV1Admin.SendMultipleUsersFreeformNotificationV1AdminBuilder builder,
            ModelBulkUsersFreeFormNotificationRequestV1 body,
            string namespace_
        )
        {
            SendMultipleUsersFreeformNotificationV1Admin op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendMultipleUsersFreeformNotificationV1Admin(op);
        }

        public static void Execute(
            this SendUsersFreeformNotificationV1Admin.SendUsersFreeformNotificationV1AdminBuilder builder,
            ModelFreeFormNotificationRequestV1 body,
            string namespace_
        )
        {
            SendUsersFreeformNotificationV1Admin op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendUsersFreeformNotificationV1Admin(op);
        }

        public static void Execute(
            this SendPartyFreeformNotificationV1Admin.SendPartyFreeformNotificationV1AdminBuilder builder,
            ModelFreeFormNotificationRequestV1 body,
            string namespace_,
            string partyId
        )
        {
            SendPartyFreeformNotificationV1Admin op = builder.Build(
                body,
                namespace_,
                partyId
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendPartyFreeformNotificationV1Admin(op);
        }

        public static void Execute(
            this SendPartyTemplatedNotificationV1Admin.SendPartyTemplatedNotificationV1AdminBuilder builder,
            ModelNotificationWithTemplateRequestV1 body,
            string namespace_,
            string partyId
        )
        {
            SendPartyTemplatedNotificationV1Admin op = builder.Build(
                body,
                namespace_,
                partyId
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendPartyTemplatedNotificationV1Admin(op);
        }

        public static List<Lobby.Model.ModelNotificationTemplateResponse>? Execute(
            this GetAllNotificationTemplatesV1Admin.GetAllNotificationTemplatesV1AdminBuilder builder,
            string namespace_
        )
        {
            GetAllNotificationTemplatesV1Admin op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetAllNotificationTemplatesV1Admin(op);
        }

        public static void Execute(
            this CreateNotificationTemplateV1Admin.CreateNotificationTemplateV1AdminBuilder builder,
            ModelCreateTemplateRequest body,
            string namespace_
        )
        {
            CreateNotificationTemplateV1Admin op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).CreateNotificationTemplateV1Admin(op);
        }

        public static void Execute(
            this SendUsersTemplatedNotificationV1Admin.SendUsersTemplatedNotificationV1AdminBuilder builder,
            ModelNotificationWithTemplateRequestV1 body,
            string namespace_
        )
        {
            SendUsersTemplatedNotificationV1Admin op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendUsersTemplatedNotificationV1Admin(op);
        }

        public static Lobby.Model.ModelGetAllNotificationTemplateSlugResp? Execute(
            this GetTemplateSlugLocalizationsTemplateV1Admin.GetTemplateSlugLocalizationsTemplateV1AdminBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            GetTemplateSlugLocalizationsTemplateV1Admin op = builder.Build(
                namespace_,
                templateSlug
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetTemplateSlugLocalizationsTemplateV1Admin(op);
        }

        public static void Execute(
            this DeleteNotificationTemplateSlugV1Admin.DeleteNotificationTemplateSlugV1AdminBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            DeleteNotificationTemplateSlugV1Admin op = builder.Build(
                namespace_,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).DeleteNotificationTemplateSlugV1Admin(op);
        }

        public static Lobby.Model.ModelLocalization? Execute(
            this GetSingleTemplateLocalizationV1Admin.GetSingleTemplateLocalizationV1AdminBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            GetSingleTemplateLocalizationV1Admin op = builder.Build(
                namespace_,
                templateLanguage,
                templateSlug
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetSingleTemplateLocalizationV1Admin(op);
        }

        public static void Execute(
            this UpdateTemplateLocalizationV1Admin.UpdateTemplateLocalizationV1AdminBuilder builder,
            ModelUpdateTemplateRequest body,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            UpdateTemplateLocalizationV1Admin op = builder.Build(
                body,
                namespace_,
                templateLanguage,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).UpdateTemplateLocalizationV1Admin(op);
        }

        public static void Execute(
            this DeleteTemplateLocalizationV1Admin.DeleteTemplateLocalizationV1AdminBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            DeleteTemplateLocalizationV1Admin op = builder.Build(
                namespace_,
                templateLanguage,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).DeleteTemplateLocalizationV1Admin(op);
        }

        public static void Execute(
            this PublishTemplateLocalizationV1Admin.PublishTemplateLocalizationV1AdminBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PublishTemplateLocalizationV1Admin op = builder.Build(
                namespace_,
                templateLanguage,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).PublishTemplateLocalizationV1Admin(op);
        }

        public static Lobby.Model.ModelGetAllNotificationTopicsResponse? Execute(
            this GetAllNotificationTopicsV1Admin.GetAllNotificationTopicsV1AdminBuilder builder,
            string namespace_
        )
        {
            GetAllNotificationTopicsV1Admin op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetAllNotificationTopicsV1Admin(op);
        }

        public static void Execute(
            this CreateNotificationTopicV1Admin.CreateNotificationTopicV1AdminBuilder builder,
            ModelCreateTopicRequestV1 body,
            string namespace_
        )
        {
            CreateNotificationTopicV1Admin op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).CreateNotificationTopicV1Admin(op);
        }

        public static Lobby.Model.ModelNotificationTopicResponseV1? Execute(
            this GetNotificationTopicV1Admin.GetNotificationTopicV1AdminBuilder builder,
            string namespace_,
            string topicName
        )
        {
            GetNotificationTopicV1Admin op = builder.Build(
                namespace_,
                topicName
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetNotificationTopicV1Admin(op);
        }

        public static void Execute(
            this UpdateNotificationTopicV1Admin.UpdateNotificationTopicV1AdminBuilder builder,
            ModelUpdateTopicRequest body,
            string namespace_,
            string topicName
        )
        {
            UpdateNotificationTopicV1Admin op = builder.Build(
                body,
                namespace_,
                topicName
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).UpdateNotificationTopicV1Admin(op);
        }

        public static void Execute(
            this DeleteNotificationTopicV1Admin.DeleteNotificationTopicV1AdminBuilder builder,
            string namespace_,
            string topicName
        )
        {
            DeleteNotificationTopicV1Admin op = builder.Build(
                namespace_,
                topicName
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).DeleteNotificationTopicV1Admin(op);
        }

        public static void Execute(
            this SendSpecificUserFreeformNotificationV1Admin.SendSpecificUserFreeformNotificationV1AdminBuilder builder,
            ModelFreeFormNotificationRequestV1 body,
            string namespace_,
            string userId
        )
        {
            SendSpecificUserFreeformNotificationV1Admin op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendSpecificUserFreeformNotificationV1Admin(op);
        }

        public static void Execute(
            this SendSpecificUserTemplatedNotificationV1Admin.SendSpecificUserTemplatedNotificationV1AdminBuilder builder,
            ModelNotificationWithTemplateRequestV1 body,
            string namespace_,
            string userId
        )
        {
            SendSpecificUserTemplatedNotificationV1Admin op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).SendSpecificUserTemplatedNotificationV1Admin(op);
        }

        public static void Execute(
            this FreeFormNotification.FreeFormNotificationBuilder builder,
            ModelFreeFormNotificationRequest body,
            string namespace_
        )
        {
            FreeFormNotification op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).FreeFormNotification(op);
        }

        public static void Execute(
            this NotificationWithTemplate.NotificationWithTemplateBuilder builder,
            ModelNotificationWithTemplateRequest body,
            string namespace_
        )
        {
            NotificationWithTemplate op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).NotificationWithTemplate(op);
        }

        public static List<Lobby.Model.ModelTemplateResponse>? Execute(
            this GetGameTemplate.GetGameTemplateBuilder builder,
            string namespace_
        )
        {
            GetGameTemplate op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetGameTemplate(op);
        }

        public static void Execute(
            this CreateTemplate.CreateTemplateBuilder builder,
            ModelCreateTemplateRequest body,
            string namespace_
        )
        {
            CreateTemplate op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).CreateTemplate(op);
        }

        public static Lobby.Model.ModelTemplateLocalizationResponse? Execute(
            this GetSlugTemplate.GetSlugTemplateBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            GetSlugTemplate op = builder.Build(
                namespace_,
                templateSlug
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetSlugTemplate(op);
        }

        public static void Execute(
            this DeleteTemplateSlug.DeleteTemplateSlugBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            DeleteTemplateSlug op = builder.Build(
                namespace_,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).DeleteTemplateSlug(op);
        }

        public static Lobby.Model.ModelTemplateLocalization? Execute(
            this GetLocalizationTemplate.GetLocalizationTemplateBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            GetLocalizationTemplate op = builder.Build(
                namespace_,
                templateLanguage,
                templateSlug
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetLocalizationTemplate(op);
        }

        public static void Execute(
            this UpdateLocalizationTemplate.UpdateLocalizationTemplateBuilder builder,
            ModelUpdateTemplateRequest body,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            UpdateLocalizationTemplate op = builder.Build(
                body,
                namespace_,
                templateLanguage,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).UpdateLocalizationTemplate(op);
        }

        public static void Execute(
            this DeleteTemplateLocalization.DeleteTemplateLocalizationBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            DeleteTemplateLocalization op = builder.Build(
                namespace_,
                templateLanguage,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).DeleteTemplateLocalization(op);
        }

        public static void Execute(
            this PublishTemplate.PublishTemplateBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PublishTemplate op = builder.Build(
                namespace_,
                templateLanguage,
                templateSlug
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).PublishTemplate(op);
        }

        public static Lobby.Model.ModelTopicByNamespacesResponse? Execute(
            this GetTopicByNamespace.GetTopicByNamespaceBuilder builder,
            string namespace_
        )
        {
            GetTopicByNamespace op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetTopicByNamespace(op);
        }

        public static void Execute(
            this CreateTopic.CreateTopicBuilder builder,
            ModelCreateTopicRequest body,
            string namespace_
        )
        {
            CreateTopic op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).CreateTopic(op);
        }

        public static Lobby.Model.ModelNotificationTopicResponse? Execute(
            this GetTopicByTopicName.GetTopicByTopicNameBuilder builder,
            string namespace_,
            string topic
        )
        {
            GetTopicByTopicName op = builder.Build(
                namespace_,
                topic
            );

            return ((Lobby.Wrapper.Notification)builder.WrapperObject!).GetTopicByTopicName(op);
        }

        public static void Execute(
            this UpdateTopicByTopicName.UpdateTopicByTopicNameBuilder builder,
            ModelUpdateTopicRequest body,
            string namespace_,
            string topic
        )
        {
            UpdateTopicByTopicName op = builder.Build(
                body,
                namespace_,
                topic
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).UpdateTopicByTopicName(op);
        }

        public static void Execute(
            this DeleteTopicByTopicName.DeleteTopicByTopicNameBuilder builder,
            string namespace_,
            string topic
        )
        {
            DeleteTopicByTopicName op = builder.Build(
                namespace_,
                topic
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).DeleteTopicByTopicName(op);
        }

        public static void Execute(
            this FreeFormNotificationByUserID.FreeFormNotificationByUserIDBuilder builder,
            ModelFreeFormNotificationRequest body,
            string namespace_,
            string userId
        )
        {
            FreeFormNotificationByUserID op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).FreeFormNotificationByUserID(op);
        }

        public static void Execute(
            this NotificationWithTemplateByUserID.NotificationWithTemplateByUserIDBuilder builder,
            ModelNotificationWithTemplateRequest body,
            string namespace_,
            string userId
        )
        {
            NotificationWithTemplateByUserID op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Notification)builder.WrapperObject!).NotificationWithTemplateByUserID(op);
        }

    }
}