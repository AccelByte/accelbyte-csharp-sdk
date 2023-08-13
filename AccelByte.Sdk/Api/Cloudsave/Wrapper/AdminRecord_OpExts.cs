// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class CloudsaveAdminRecord_OpExts
    {
        public static Cloudsave.Model.ModelsListAdminGameRecordKeysResponse? Execute(
            this AdminListAdminGameRecordV1.AdminListAdminGameRecordV1Builder builder,
            string namespace_
        )
        {
            AdminListAdminGameRecordV1 op = builder.Build(
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminListAdminGameRecordV1(op);
        }
        public static Cloudsave.Model.ModelsBulkGetAdminGameRecordResponse? Execute(
            this AdminBulkGetAdminGameRecordV1.AdminBulkGetAdminGameRecordV1Builder builder,
            ModelsBulkGetAdminGameRecordRequest body,
            string namespace_
        )
        {
            AdminBulkGetAdminGameRecordV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminBulkGetAdminGameRecordV1(op);
        }
        public static Cloudsave.Model.ModelsAdminGameRecordResponse? Execute(
            this AdminGetAdminGameRecordV1.AdminGetAdminGameRecordV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminGetAdminGameRecordV1 op = builder.Build(
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminGetAdminGameRecordV1(op);
        }

        public static Cloudsave.Model.ModelsAdminGameRecordResponse<T1>? Execute<T1>(
            this AdminGetAdminGameRecordV1.AdminGetAdminGameRecordV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminGetAdminGameRecordV1 op = builder.Build(
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminGetAdminGameRecordV1<T1>(op);
        }
        public static Cloudsave.Model.ModelsAdminGameRecordResponse? Execute(
            this AdminPutAdminGameRecordV1.AdminPutAdminGameRecordV1Builder builder,
            ModelsAdminGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutAdminGameRecordV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPutAdminGameRecordV1(op);
        }

        public static Cloudsave.Model.ModelsAdminGameRecordResponse<T1>? Execute<T1>(
            this AdminPutAdminGameRecordV1.AdminPutAdminGameRecordV1Builder builder,
            ModelsAdminGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutAdminGameRecordV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPutAdminGameRecordV1<T1>(op);
        }
        public static Cloudsave.Model.ModelsAdminGameRecordResponse? Execute(
            this AdminPostAdminGameRecordV1.AdminPostAdminGameRecordV1Builder builder,
            ModelsAdminGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPostAdminGameRecordV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPostAdminGameRecordV1(op);
        }

        public static Cloudsave.Model.ModelsAdminGameRecordResponse<T1>? Execute<T1>(
            this AdminPostAdminGameRecordV1.AdminPostAdminGameRecordV1Builder builder,
            ModelsAdminGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPostAdminGameRecordV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPostAdminGameRecordV1<T1>(op);
        }
        public static void Execute(
            this AdminDeleteAdminGameRecordV1.AdminDeleteAdminGameRecordV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminDeleteAdminGameRecordV1 op = builder.Build(
                key,
                namespace_
            );

            ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminDeleteAdminGameRecordV1(op);
        }
        public static Cloudsave.Model.ModelsBulkGetAdminPlayerRecordResponse? Execute(
            this BulkGetAdminPlayerRecordByUserIdsV1.BulkGetAdminPlayerRecordByUserIdsV1Builder builder,
            ModelsBulkUserIDsRequest body,
            string key,
            string namespace_
        )
        {
            BulkGetAdminPlayerRecordByUserIdsV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).BulkGetAdminPlayerRecordByUserIdsV1(op);
        }
        public static Cloudsave.Model.ModelsListAdminPlayerRecordKeysResponse? Execute(
            this AdminListAdminUserRecordsV1.AdminListAdminUserRecordsV1Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminListAdminUserRecordsV1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminListAdminUserRecordsV1(op);
        }
        public static Cloudsave.Model.ModelsBulkGetAdminPlayerRecordResponse? Execute(
            this AdminBulkGetAdminPlayerRecordV1.AdminBulkGetAdminPlayerRecordV1Builder builder,
            ModelsBulkGetAdminPlayerRecordRequest body,
            string namespace_,
            string userId
        )
        {
            AdminBulkGetAdminPlayerRecordV1 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminBulkGetAdminPlayerRecordV1(op);
        }
        public static Cloudsave.Model.ModelsAdminPlayerRecordResponse? Execute(
            this AdminGetAdminPlayerRecordV1.AdminGetAdminPlayerRecordV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminGetAdminPlayerRecordV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminGetAdminPlayerRecordV1(op);
        }

        public static Cloudsave.Model.ModelsAdminPlayerRecordResponse<T1>? Execute<T1>(
            this AdminGetAdminPlayerRecordV1.AdminGetAdminPlayerRecordV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminGetAdminPlayerRecordV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminGetAdminPlayerRecordV1<T1>(op);
        }
        public static Cloudsave.Model.ModelsAdminPlayerRecordResponse? Execute(
            this AdminPutAdminPlayerRecordV1.AdminPutAdminPlayerRecordV1Builder builder,
            ModelsAdminPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutAdminPlayerRecordV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPutAdminPlayerRecordV1(op);
        }

        public static Cloudsave.Model.ModelsAdminPlayerRecordResponse<T1>? Execute<T1>(
            this AdminPutAdminPlayerRecordV1.AdminPutAdminPlayerRecordV1Builder builder,
            ModelsAdminPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutAdminPlayerRecordV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPutAdminPlayerRecordV1<T1>(op);
        }
        public static Cloudsave.Model.ModelsAdminPlayerRecordResponse? Execute(
            this AdminPostPlayerAdminRecordV1.AdminPostPlayerAdminRecordV1Builder builder,
            ModelsAdminPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPostPlayerAdminRecordV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPostPlayerAdminRecordV1(op);
        }

        public static Cloudsave.Model.ModelsAdminPlayerRecordResponse<T1>? Execute<T1>(
            this AdminPostPlayerAdminRecordV1.AdminPostPlayerAdminRecordV1Builder builder,
            ModelsAdminPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPostPlayerAdminRecordV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            return ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminPostPlayerAdminRecordV1<T1>(op);
        }
        public static void Execute(
            this AdminDeleteAdminPlayerRecordV1.AdminDeleteAdminPlayerRecordV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAdminPlayerRecordV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((Cloudsave.Wrapper.AdminRecord)builder.WrapperObject!).AdminDeleteAdminPlayerRecordV1(op);
        }
    }
}