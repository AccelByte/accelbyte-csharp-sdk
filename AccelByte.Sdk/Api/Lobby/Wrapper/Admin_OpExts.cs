// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyAdmin_OpExts
    {
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).FreeFormNotification(op);
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).NotificationWithTemplate(op);
        }
        public static List<Lobby.Model.ModelTemplateResponse>? Execute(
            this GetGameTemplate.GetGameTemplateBuilder builder,
            string namespace_
        )
        {
            GetGameTemplate op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Admin)builder.WrapperObject!).GetGameTemplate(op);
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).CreateTemplate(op);
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

            return ((Lobby.Wrapper.Admin)builder.WrapperObject!).GetSlugTemplate(op);
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).DeleteTemplateSlug(op);
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

            return ((Lobby.Wrapper.Admin)builder.WrapperObject!).GetLocalizationTemplate(op);
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).UpdateLocalizationTemplate(op);
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).DeleteTemplateLocalization(op);
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

            ((Lobby.Wrapper.Admin)builder.WrapperObject!).PublishTemplate(op);
        }
    }
}