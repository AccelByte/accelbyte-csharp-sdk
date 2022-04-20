// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminConcurrentRecord
    {
        private readonly AccelByteSDK _sdk;

        public AdminConcurrentRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder AdminPutGameRecordConcurrentHandlerV1Op
        {
            get { return Operation.AdminPutGameRecordConcurrentHandlerV1.Builder.SetWrapperObject(this); }
        }
        public AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder AdminPutPlayerPublicRecordConcurrentHandlerV1Op
        {
            get { return Operation.AdminPutPlayerPublicRecordConcurrentHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void AdminPutGameRecordConcurrentHandlerV1(AdminPutGameRecordConcurrentHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerPublicRecordConcurrentHandlerV1(AdminPutPlayerPublicRecordConcurrentHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminConcurrentRecord_OperationExtensions
    {
        public static void Execute(
            this AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_
        )
        {
            AdminPutGameRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            ((AdminConcurrentRecord)builder.WrapperObject!).AdminPutGameRecordConcurrentHandlerV1(op);
        }

        public static void Execute(
            this AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            AdminPutPlayerPublicRecordConcurrentHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((AdminConcurrentRecord)builder.WrapperObject!).AdminPutPlayerPublicRecordConcurrentHandlerV1(op);
        }

    }
}