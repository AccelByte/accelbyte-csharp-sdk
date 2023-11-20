// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class StatCycleConfiguration
    {
        private readonly AccelByteSDK _sdk;

        public StatCycleConfiguration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetStatCycles.GetStatCyclesBuilder GetStatCyclesOp
        {
            get { return Operation.GetStatCycles.Builder.SetWrapperObject(this); }
        }
        public CreateStatCycle.CreateStatCycleBuilder CreateStatCycleOp
        {
            get { return Operation.CreateStatCycle.Builder.SetWrapperObject(this); }
        }
        public BulkGetStatCycle.BulkGetStatCycleBuilder BulkGetStatCycleOp
        {
            get { return Operation.BulkGetStatCycle.Builder.SetWrapperObject(this); }
        }
        public ExportStatCycle.ExportStatCycleBuilder ExportStatCycleOp
        {
            get { return Operation.ExportStatCycle.Builder.SetWrapperObject(this); }
        }
        public GetStatCycle.GetStatCycleBuilder GetStatCycleOp
        {
            get { return Operation.GetStatCycle.Builder.SetWrapperObject(this); }
        }
        public UpdateStatCycle.UpdateStatCycleBuilder UpdateStatCycleOp
        {
            get { return Operation.UpdateStatCycle.Builder.SetWrapperObject(this); }
        }
        public DeleteStatCycle.DeleteStatCycleBuilder DeleteStatCycleOp
        {
            get { return Operation.DeleteStatCycle.Builder.SetWrapperObject(this); }
        }
        public BulkAddStats.BulkAddStatsBuilder BulkAddStatsOp
        {
            get { return Operation.BulkAddStats.Builder.SetWrapperObject(this); }
        }
        public StopStatCycle.StopStatCycleBuilder StopStatCycleOp
        {
            get { return Operation.StopStatCycle.Builder.SetWrapperObject(this); }
        }
        public GetStatCycles1.GetStatCycles1Builder GetStatCycles1Op
        {
            get { return Operation.GetStatCycles1.Builder.SetWrapperObject(this); }
        }
        public BulkGetStatCycle1.BulkGetStatCycle1Builder BulkGetStatCycle1Op
        {
            get { return Operation.BulkGetStatCycle1.Builder.SetWrapperObject(this); }
        }
        public GetStatCycle1.GetStatCycle1Builder GetStatCycle1Op
        {
            get { return Operation.GetStatCycle1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.StatCyclePagingSlicedResult? GetStatCycles(GetStatCycles input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? CreateStatCycle(CreateStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkStatCycleResult? BulkGetStatCycle(BulkGetStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Stream? ExportStatCycle(ExportStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? GetStatCycle(GetStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? UpdateStatCycle(UpdateStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteStatCycle(DeleteStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatCycleOperationResult>? BulkAddStats(BulkAddStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.BulkStatCycleOperationResult<T1>>? BulkAddStats<T1>(BulkAddStats input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? StopStatCycle(StopStatCycle input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCyclePagingSlicedResult? GetStatCycles1(GetStatCycles1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkStatCycleResult? BulkGetStatCycle1(BulkGetStatCycle1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatCycleInfo? GetStatCycle1(GetStatCycle1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}