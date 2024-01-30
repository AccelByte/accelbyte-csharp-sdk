// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Profanity
    {
        private readonly AccelByteSDK _sdk;

        public Profanity(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminProfanityQuery.AdminProfanityQueryBuilder AdminProfanityQueryOp
        {
            get { return Operation.AdminProfanityQuery.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityCreate.AdminProfanityCreateBuilder AdminProfanityCreateOp
        {
            get { return Operation.AdminProfanityCreate.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityCreateBulk.AdminProfanityCreateBulkBuilder AdminProfanityCreateBulkOp
        {
            get { return Operation.AdminProfanityCreateBulk.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityExport.AdminProfanityExportBuilder AdminProfanityExportOp
        {
            get { return Operation.AdminProfanityExport.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityGroup.AdminProfanityGroupBuilder AdminProfanityGroupOp
        {
            get { return Operation.AdminProfanityGroup.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityImport.AdminProfanityImportBuilder AdminProfanityImportOp
        {
            get { return Operation.AdminProfanityImport.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityUpdate.AdminProfanityUpdateBuilder AdminProfanityUpdateOp
        {
            get { return Operation.AdminProfanityUpdate.Builder.SetWrapperObject(this); }
        }
        public AdminProfanityDelete.AdminProfanityDeleteBuilder AdminProfanityDeleteOp
        {
            get { return Operation.AdminProfanityDelete.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsDictionaryQueryResult? AdminProfanityQuery(AdminProfanityQuery input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionary? AdminProfanityCreate(AdminProfanityCreate input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionary? AdminProfanityCreateBulk(AdminProfanityCreateBulk input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionaryExport? AdminProfanityExport(AdminProfanityExport input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsDictionaryGroup>? AdminProfanityGroup(AdminProfanityGroup input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionaryImportResult? AdminProfanityImport(AdminProfanityImport input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDictionary? AdminProfanityUpdate(AdminProfanityUpdate input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminProfanityDelete(AdminProfanityDelete input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}