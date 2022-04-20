// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyProfanity_OpExts
    {
        public static List<Lobby.Model.ModelsProfanityFilter>? Execute(
            this AdminDebugProfanityFilters.AdminDebugProfanityFiltersBuilder builder,
            ModelsDebugProfanityFilterRequest body,
            string namespace_
        )
        {
            AdminDebugProfanityFilters op = builder.Build(
                body,
                namespace_
            );

            return ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminDebugProfanityFilters(op);
        }

        public static Lobby.Model.ModelsAdminGetProfanityListFiltersV1Response? Execute(
            this AdminGetProfanityListFiltersV1.AdminGetProfanityListFiltersV1Builder builder,
            string list,
            string namespace_
        )
        {
            AdminGetProfanityListFiltersV1 op = builder.Build(
                list,
                namespace_
            );

            return ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminGetProfanityListFiltersV1(op);
        }

        public static void Execute(
            this AdminAddProfanityFilterIntoList.AdminAddProfanityFilterIntoListBuilder builder,
            ModelsAdminAddProfanityFilterIntoListRequest body,
            string list,
            string namespace_
        )
        {
            AdminAddProfanityFilterIntoList op = builder.Build(
                body,
                list,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminAddProfanityFilterIntoList(op);
        }

        public static void Execute(
            this AdminAddProfanityFilters.AdminAddProfanityFiltersBuilder builder,
            ModelsAdminAddProfanityFiltersRequest body,
            string list,
            string namespace_
        )
        {
            AdminAddProfanityFilters op = builder.Build(
                body,
                list,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminAddProfanityFilters(op);
        }

        public static void Execute(
            this AdminImportProfanityFiltersFromFile.AdminImportProfanityFiltersFromFileBuilder builder,
            List<long> body,
            string list,
            string namespace_
        )
        {
            AdminImportProfanityFiltersFromFile op = builder.Build(
                body,
                list,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminImportProfanityFiltersFromFile(op);
        }

        public static List<Lobby.Model.ModelsProfanityFilter>? Execute(
            this AdminDeleteProfanityFilter.AdminDeleteProfanityFilterBuilder builder,
            ModelsAdminDeleteProfanityFilterRequest body,
            string list,
            string namespace_
        )
        {
            AdminDeleteProfanityFilter op = builder.Build(
                body,
                list,
                namespace_
            );

            return ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminDeleteProfanityFilter(op);
        }

        public static List<Lobby.Model.ModelsAdminGetProfanityListsListResponse>? Execute(
            this AdminGetProfanityLists.AdminGetProfanityListsBuilder builder,
            string namespace_
        )
        {
            AdminGetProfanityLists op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminGetProfanityLists(op);
        }

        public static void Execute(
            this AdminCreateProfanityList.AdminCreateProfanityListBuilder builder,
            ModelsAdminCreateProfanityListRequest body,
            string namespace_
        )
        {
            AdminCreateProfanityList op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminCreateProfanityList(op);
        }

        public static void Execute(
            this AdminUpdateProfanityList.AdminUpdateProfanityListBuilder builder,
            ModelsAdminUpdateProfanityList body,
            string list,
            string namespace_
        )
        {
            AdminUpdateProfanityList op = builder.Build(
                body,
                list,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminUpdateProfanityList(op);
        }

        public static void Execute(
            this AdminDeleteProfanityList.AdminDeleteProfanityListBuilder builder,
            string list,
            string namespace_
        )
        {
            AdminDeleteProfanityList op = builder.Build(
                list,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminDeleteProfanityList(op);
        }

        public static Lobby.Model.ModelsProfanityRule? Execute(
            this AdminGetProfanityRule.AdminGetProfanityRuleBuilder builder,
            string namespace_
        )
        {
            AdminGetProfanityRule op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminGetProfanityRule(op);
        }

        public static void Execute(
            this AdminSetProfanityRuleForNamespace.AdminSetProfanityRuleForNamespaceBuilder builder,
            ModelsAdminSetProfanityRuleForNamespaceRequest body,
            string namespace_
        )
        {
            AdminSetProfanityRuleForNamespace op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminSetProfanityRuleForNamespace(op);
        }

        public static Lobby.Model.ModelsAdminVerifyMessageProfanityResponse? Execute(
            this AdminVerifyMessageProfanityResponse.AdminVerifyMessageProfanityResponseBuilder builder,
            ModelsAdminVerifyMessageProfanityRequest body,
            string namespace_
        )
        {
            AdminVerifyMessageProfanityResponse op = builder.Build(
                body,
                namespace_
            );

            return ((Lobby.Wrapper.Profanity)builder.WrapperObject!).AdminVerifyMessageProfanityResponse(op);
        }

    }
}