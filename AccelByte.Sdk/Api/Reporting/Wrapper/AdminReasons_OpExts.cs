// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ReportingAdminReasons_OpExts
    {
        public static Reporting.Model.RestapiReasonGroupListResponse? Execute(
            this AdminListReasonGroups.AdminListReasonGroupsBuilder builder,
            string namespace_
        )
        {
            AdminListReasonGroups op = builder.Build(
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminListReasonGroups(op);
        }
        public static async Task<Reporting.Model.RestapiReasonGroupListResponse?> ExecuteAsync(
            this AdminListReasonGroups.AdminListReasonGroupsBuilder builder,
            string namespace_
        )
        {
            AdminListReasonGroups op = builder.Build(
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminListReasonGroupsAsync(op);
        }
        public static Reporting.Model.RestapiReasonGroupResponse? Execute(
            this CreateReasonGroup.CreateReasonGroupBuilder builder,
            RestapiCreateReasonGroupRequest body,
            string namespace_
        )
        {
            CreateReasonGroup op = builder.Build(
                body,
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).CreateReasonGroup(op);
        }
        public static async Task<Reporting.Model.RestapiReasonGroupResponse?> ExecuteAsync(
            this CreateReasonGroup.CreateReasonGroupBuilder builder,
            RestapiCreateReasonGroupRequest body,
            string namespace_
        )
        {
            CreateReasonGroup op = builder.Build(
                body,
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).CreateReasonGroupAsync(op);
        }
        public static Reporting.Model.RestapiReasonGroupResponse? Execute(
            this GetReasonGroup.GetReasonGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            GetReasonGroup op = builder.Build(
                groupId,
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).GetReasonGroup(op);
        }
        public static async Task<Reporting.Model.RestapiReasonGroupResponse?> ExecuteAsync(
            this GetReasonGroup.GetReasonGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            GetReasonGroup op = builder.Build(
                groupId,
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).GetReasonGroupAsync(op);
        }
        public static void Execute(
            this DeleteReasonGroup.DeleteReasonGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            DeleteReasonGroup op = builder.Build(
                groupId,
                namespace_
            );

            ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).DeleteReasonGroup(op);
        }
        public static async Task ExecuteAsync(
            this DeleteReasonGroup.DeleteReasonGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            DeleteReasonGroup op = builder.Build(
                groupId,
                namespace_
            );

            await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).DeleteReasonGroupAsync(op);
        }
        public static Reporting.Model.RestapiReasonGroupResponse? Execute(
            this UpdateReasonGroup.UpdateReasonGroupBuilder builder,
            RestapiUpdateReasonGroupRequest body,
            string groupId,
            string namespace_
        )
        {
            UpdateReasonGroup op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).UpdateReasonGroup(op);
        }
        public static async Task<Reporting.Model.RestapiReasonGroupResponse?> ExecuteAsync(
            this UpdateReasonGroup.UpdateReasonGroupBuilder builder,
            RestapiUpdateReasonGroupRequest body,
            string groupId,
            string namespace_
        )
        {
            UpdateReasonGroup op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).UpdateReasonGroupAsync(op);
        }
        public static Reporting.Model.RestapiAdminReasonListResponse? Execute(
            this AdminGetReasons.AdminGetReasonsBuilder builder,
            string namespace_
        )
        {
            AdminGetReasons op = builder.Build(
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetReasons(op);
        }
        public static async Task<Reporting.Model.RestapiAdminReasonListResponse?> ExecuteAsync(
            this AdminGetReasons.AdminGetReasonsBuilder builder,
            string namespace_
        )
        {
            AdminGetReasons op = builder.Build(
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetReasonsAsync(op);
        }
        public static Reporting.Model.RestapiAdminReasonResponse? Execute(
            this CreateReason.CreateReasonBuilder builder,
            RestapiCreateReasonRequest body,
            string namespace_
        )
        {
            CreateReason op = builder.Build(
                body,
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).CreateReason(op);
        }
        public static async Task<Reporting.Model.RestapiAdminReasonResponse?> ExecuteAsync(
            this CreateReason.CreateReasonBuilder builder,
            RestapiCreateReasonRequest body,
            string namespace_
        )
        {
            CreateReason op = builder.Build(
                body,
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).CreateReasonAsync(op);
        }
        public static Reporting.Model.RestapiAdminAllReasonsResponse? Execute(
            this AdminGetAllReasons.AdminGetAllReasonsBuilder builder,
            string namespace_
        )
        {
            AdminGetAllReasons op = builder.Build(
                namespace_
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetAllReasons(op);
        }
        public static async Task<Reporting.Model.RestapiAdminAllReasonsResponse?> ExecuteAsync(
            this AdminGetAllReasons.AdminGetAllReasonsBuilder builder,
            string namespace_
        )
        {
            AdminGetAllReasons op = builder.Build(
                namespace_
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetAllReasonsAsync(op);
        }
        public static Reporting.Model.RestapiUnusedReasonListResponse? Execute(
            this AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder builder,
            string namespace_,
            string category
        )
        {
            AdminGetUnusedReasons op = builder.Build(
                namespace_,
                category
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetUnusedReasons(op);
        }
        public static async Task<Reporting.Model.RestapiUnusedReasonListResponse?> ExecuteAsync(
            this AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder builder,
            string namespace_,
            string category
        )
        {
            AdminGetUnusedReasons op = builder.Build(
                namespace_,
                category
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetUnusedReasonsAsync(op);
        }
        public static Reporting.Model.RestapiAdminReasonResponse? Execute(
            this AdminGetReason.AdminGetReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            AdminGetReason op = builder.Build(
                namespace_,
                reasonId
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetReason(op);
        }
        public static async Task<Reporting.Model.RestapiAdminReasonResponse?> ExecuteAsync(
            this AdminGetReason.AdminGetReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            AdminGetReason op = builder.Build(
                namespace_,
                reasonId
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).AdminGetReasonAsync(op);
        }
        public static void Execute(
            this DeleteReason.DeleteReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            DeleteReason op = builder.Build(
                namespace_,
                reasonId
            );

            ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).DeleteReason(op);
        }
        public static async Task ExecuteAsync(
            this DeleteReason.DeleteReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            DeleteReason op = builder.Build(
                namespace_,
                reasonId
            );

            await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).DeleteReasonAsync(op);
        }
        public static Reporting.Model.RestapiAdminReasonResponse? Execute(
            this UpdateReason.UpdateReasonBuilder builder,
            RestapiCreateReasonRequest body,
            string namespace_,
            string reasonId
        )
        {
            UpdateReason op = builder.Build(
                body,
                namespace_,
                reasonId
            );

            return ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).UpdateReason(op);
        }
        public static async Task<Reporting.Model.RestapiAdminReasonResponse?> ExecuteAsync(
            this UpdateReason.UpdateReasonBuilder builder,
            RestapiCreateReasonRequest body,
            string namespace_,
            string reasonId
        )
        {
            UpdateReason op = builder.Build(
                body,
                namespace_,
                reasonId
            );

            return await ((Reporting.Wrapper.AdminReasons)builder.WrapperObject!).UpdateReasonAsync(op);
        }
    }
}