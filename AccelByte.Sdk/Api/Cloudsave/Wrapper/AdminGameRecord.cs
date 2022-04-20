// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminGameRecord
    {
        private readonly AccelByteSDK _sdk;

        public AdminGameRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListGameRecordsHandlerV1.ListGameRecordsHandlerV1Builder ListGameRecordsHandlerV1Op
        {
            get { return Operation.ListGameRecordsHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetGameRecordHandlerV1.AdminGetGameRecordHandlerV1Builder AdminGetGameRecordHandlerV1Op
        {
            get { return Operation.AdminGetGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutGameRecordHandlerV1.AdminPutGameRecordHandlerV1Builder AdminPutGameRecordHandlerV1Op
        {
            get { return Operation.AdminPutGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPostGameRecordHandlerV1.AdminPostGameRecordHandlerV1Builder AdminPostGameRecordHandlerV1Op
        {
            get { return Operation.AdminPostGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteGameRecordHandlerV1.AdminDeleteGameRecordHandlerV1Builder AdminDeleteGameRecordHandlerV1Op
        {
            get { return Operation.AdminDeleteGameRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListGameRecordKeysResponse? ListGameRecordsHandlerV1(ListGameRecordsHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? AdminGetGameRecordHandlerV1(AdminGetGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutGameRecordHandlerV1(AdminPutGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPostGameRecordHandlerV1(AdminPostGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGameRecordHandlerV1(AdminDeleteGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminGameRecord_OperationExtensions
    {
        public static Model.ModelsListGameRecordKeysResponse? Execute(
            this ListGameRecordsHandlerV1.ListGameRecordsHandlerV1Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            ListGameRecordsHandlerV1 op = builder.Build(
                namespace_,
                limit,
                offset
            );

            return ((AdminGameRecord)builder.WrapperObject!).ListGameRecordsHandlerV1(op);
        }

        public static Model.ModelsGameRecordResponse? Execute(
            this AdminGetGameRecordHandlerV1.AdminGetGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminGetGameRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            return ((AdminGameRecord)builder.WrapperObject!).AdminGetGameRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPutGameRecordHandlerV1.AdminPutGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutGameRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((AdminGameRecord)builder.WrapperObject!).AdminPutGameRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminPostGameRecordHandlerV1.AdminPostGameRecordHandlerV1Builder builder,
            ModelsGameRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPostGameRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((AdminGameRecord)builder.WrapperObject!).AdminPostGameRecordHandlerV1(op);
        }

        public static void Execute(
            this AdminDeleteGameRecordHandlerV1.AdminDeleteGameRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            AdminDeleteGameRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            ((AdminGameRecord)builder.WrapperObject!).AdminDeleteGameRecordHandlerV1(op);
        }

    }
}