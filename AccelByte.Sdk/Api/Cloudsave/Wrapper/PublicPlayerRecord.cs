// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PublicPlayerRecord
    {
        private readonly AccelByteSDK _sdk;

        public PublicPlayerRecord(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public BulkGetPlayerPublicRecordHandlerV1.BulkGetPlayerPublicRecordHandlerV1Builder BulkGetPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.BulkGetPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PublicDeletePlayerPublicRecordHandlerV1.PublicDeletePlayerPublicRecordHandlerV1Builder PublicDeletePlayerPublicRecordHandlerV1Op
        {
            get { return Operation.PublicDeletePlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public GetPlayerRecordHandlerV1.GetPlayerRecordHandlerV1Builder GetPlayerRecordHandlerV1Op
        {
            get { return Operation.GetPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PutPlayerRecordHandlerV1.PutPlayerRecordHandlerV1Builder PutPlayerRecordHandlerV1Op
        {
            get { return Operation.PutPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PostPlayerRecordHandlerV1.PostPlayerRecordHandlerV1Builder PostPlayerRecordHandlerV1Op
        {
            get { return Operation.PostPlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public DeletePlayerRecordHandlerV1.DeletePlayerRecordHandlerV1Builder DeletePlayerRecordHandlerV1Op
        {
            get { return Operation.DeletePlayerRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public GetPlayerPublicRecordHandlerV1.GetPlayerPublicRecordHandlerV1Builder GetPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.GetPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PutPlayerPublicRecordHandlerV1.PutPlayerPublicRecordHandlerV1Builder PutPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.PutPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        public PostPlayerPublicRecordHandlerV1.PostPlayerPublicRecordHandlerV1Builder PostPlayerPublicRecordHandlerV1Op
        {
            get { return Operation.PostPlayerPublicRecordHandlerV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsBulkGetPlayerRecordResponse? BulkGetPlayerPublicRecordHandlerV1(BulkGetPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeletePlayerPublicRecordHandlerV1(PublicDeletePlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? GetPlayerRecordHandlerV1(GetPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PutPlayerRecordHandlerV1(PutPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PostPlayerRecordHandlerV1(PostPlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlayerRecordHandlerV1(DeletePlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? GetPlayerPublicRecordHandlerV1(GetPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PutPlayerPublicRecordHandlerV1(PutPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PostPlayerPublicRecordHandlerV1(PostPlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PublicPlayerRecord_OperationExtensions
    {
        public static Model.ModelsBulkGetPlayerRecordResponse? Execute(
            this BulkGetPlayerPublicRecordHandlerV1.BulkGetPlayerPublicRecordHandlerV1Builder builder,
            ModelsBulkUserIDsRequest body,
            string key,
            string namespace_
        )
        {
            BulkGetPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_
            );

            return ((PublicPlayerRecord)builder.WrapperObject!).BulkGetPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this PublicDeletePlayerPublicRecordHandlerV1.PublicDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_
        )
        {
            PublicDeletePlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_
            );

            ((PublicPlayerRecord)builder.WrapperObject!).PublicDeletePlayerPublicRecordHandlerV1(op);
        }

        public static Model.ModelsPlayerRecordResponse? Execute(
            this GetPlayerRecordHandlerV1.GetPlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            GetPlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((PublicPlayerRecord)builder.WrapperObject!).GetPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this PutPlayerRecordHandlerV1.PutPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PutPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((PublicPlayerRecord)builder.WrapperObject!).PutPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this PostPlayerRecordHandlerV1.PostPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PostPlayerRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((PublicPlayerRecord)builder.WrapperObject!).PostPlayerRecordHandlerV1(op);
        }

        public static void Execute(
            this DeletePlayerRecordHandlerV1.DeletePlayerRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            DeletePlayerRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            ((PublicPlayerRecord)builder.WrapperObject!).DeletePlayerRecordHandlerV1(op);
        }

        public static Model.ModelsPlayerRecordResponse? Execute(
            this GetPlayerPublicRecordHandlerV1.GetPlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            GetPlayerPublicRecordHandlerV1 op = builder.Build(
                key,
                namespace_,
                userId
            );

            return ((PublicPlayerRecord)builder.WrapperObject!).GetPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this PutPlayerPublicRecordHandlerV1.PutPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PutPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((PublicPlayerRecord)builder.WrapperObject!).PutPlayerPublicRecordHandlerV1(op);
        }

        public static void Execute(
            this PostPlayerPublicRecordHandlerV1.PostPlayerPublicRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PostPlayerPublicRecordHandlerV1 op = builder.Build(
                body,
                key,
                namespace_,
                userId
            );

            ((PublicPlayerRecord)builder.WrapperObject!).PostPlayerPublicRecordHandlerV1(op);
        }

    }
}