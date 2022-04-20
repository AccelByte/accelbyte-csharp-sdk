// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminPlayerRecord
    {
        private readonly AccelByteSDK _sdk;

        public AdminPlayerRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder ListPlayerRecordHandlerV1Op
        {
            get { return Operation.ListPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder AdminRetrievePlayerRecordsOp
        {
            get { return Operation.AdminRetrievePlayerRecords.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder AdminGetPlayerRecordHandlerV1Op
        {
            get { return Operation.AdminGetPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder AdminPutPlayerRecordHandlerV1Op
        {
            get { return Operation.AdminPutPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder AdminPostPlayerRecordHandlerV1Op
        {
            get { return Operation.AdminPostPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder AdminDeletePlayerRecordHandlerV1Op
        {
            get { return Operation.AdminDeletePlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder AdminGetPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminGetPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder AdminPutPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminPutPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder AdminPostPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminPostPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder AdminDeletePlayerPublicRecordHandlerV1Op
        {
            get { return Operation.AdminDeletePlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsListPlayerRecordKeysResponse? ListPlayerRecordHandlerV1(ListPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsListPlayerRecordKeysResponse? AdminRetrievePlayerRecords(AdminRetrievePlayerRecords input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminGetPlayerRecordHandlerV1(AdminGetPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerRecordHandlerV1(AdminPutPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPostPlayerRecordHandlerV1(AdminPostPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerRecordHandlerV1(AdminDeletePlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminGetPlayerPublicRecordHandlerV1(AdminGetPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerPublicRecordHandlerV1(AdminPutPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPostPlayerPublicRecordHandlerV1(AdminPostPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerPublicRecordHandlerV1(AdminDeletePlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminPlayerRecord_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsListPlayerRecordKeysResponse? Execute(
            this ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder builder,
            string namespace_
        )
        {
            ListPlayerRecordHandlerV1 op = builder.Build(
                namespace_
            );

            return ((AdminPlayerRecord)builder.WrapperObject!).ListPlayerRecordHandlerV1(op);
        }

        public static Model.ModelsListPlayerRecordKeysResponse? Execute(
            this AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminRetrievePlayerRecords op = builder.Build(
                namespace_,
                userId
            );

            return ((AdminPlayerRecord)builder.WrapperObject!).AdminRetrievePlayerRecords(op);
        }

        public static Model.ModelsPlayerRecordResponse? Execute(
            this AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((AdminPlayerRecord)builder.WrapperObject!).AdminGetPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((AdminPlayerRecord)builder.WrapperObject!).AdminPutPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPostPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((AdminPlayerRecord)builder.WrapperObject!).AdminPostPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminDeletePlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((AdminPlayerRecord)builder.WrapperObject!).AdminDeletePlayerRecordHandlerV1(op);
        }

        public static Model.ModelsPlayerRecordResponse? Execute(
            this AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminGetPlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((AdminPlayerRecord)builder.WrapperObject!).AdminGetPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((AdminPlayerRecord)builder.WrapperObject!).AdminPutPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPostPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((AdminPlayerRecord)builder.WrapperObject!).AdminPostPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminDeletePlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((AdminPlayerRecord)builder.WrapperObject!).AdminDeletePlayerPublicRecordHandlerV1(op);
        }

    }
}