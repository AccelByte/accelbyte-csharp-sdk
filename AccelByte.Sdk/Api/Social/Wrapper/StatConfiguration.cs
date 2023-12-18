// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class StatConfiguration
    {
        private readonly AccelByteSDK _sdk;

        public StatConfiguration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetStats.GetStatsBuilder GetStatsOp
        {
            get { return Operation.GetStats.Builder.SetWrapperObject(this); }
        }
        public CreateStat.CreateStatBuilder CreateStatOp
        {
            get { return Operation.CreateStat.Builder.SetWrapperObject(this); }
        }
        public ExportStats.ExportStatsBuilder ExportStatsOp
        {
            get { return Operation.ExportStats.Builder.SetWrapperObject(this); }
        }
        public ImportStats.ImportStatsBuilder ImportStatsOp
        {
            get { return Operation.ImportStats.Builder.SetWrapperObject(this); }
        }
        public QueryStats.QueryStatsBuilder QueryStatsOp
        {
            get { return Operation.QueryStats.Builder.SetWrapperObject(this); }
        }
        public GetStat.GetStatBuilder GetStatOp
        {
            get { return Operation.GetStat.Builder.SetWrapperObject(this); }
        }
        public DeleteStat.DeleteStatBuilder DeleteStatOp
        {
            get { return Operation.DeleteStat.Builder.SetWrapperObject(this); }
        }
        public UpdateStat.UpdateStatBuilder UpdateStatOp
        {
            get { return Operation.UpdateStat.Builder.SetWrapperObject(this); }
        }
        public DeleteTiedStat.DeleteTiedStatBuilder DeleteTiedStatOp
        {
            get { return Operation.DeleteTiedStat.Builder.SetWrapperObject(this); }
        }
        public CreateStat1.CreateStat1Builder CreateStat1Op
        {
            get { return Operation.CreateStat1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.StatPagingSlicedResult? GetStats(GetStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatInfo? CreateStat(CreateStat input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Stream? ExportStats(ExportStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatImportInfo? ImportStats(ImportStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatPagingSlicedResult? QueryStats(QueryStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatInfo? GetStat(GetStat input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteStat(DeleteStat input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatInfo? UpdateStat(UpdateStat input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTiedStat(DeleteTiedStat input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatInfo? CreateStat1(CreateStat1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}