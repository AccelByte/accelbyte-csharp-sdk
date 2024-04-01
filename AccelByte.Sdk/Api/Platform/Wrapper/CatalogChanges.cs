// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class CatalogChanges
    {
        private readonly AccelByteSDK _sdk;

        public CatalogChanges(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryChanges.QueryChangesBuilder QueryChangesOp
        {
            get { return Operation.QueryChanges.Builder.SetWrapperObject(this); }
        }
        public PublishAll.PublishAllBuilder PublishAllOp
        {
            get { return Operation.PublishAll.Builder.SetWrapperObject(this); }
        }
        public PublishSelected.PublishSelectedBuilder PublishSelectedOp
        {
            get { return Operation.PublishSelected.Builder.SetWrapperObject(this); }
        }
        public SelectAllRecords.SelectAllRecordsBuilder SelectAllRecordsOp
        {
            get { return Operation.SelectAllRecords.Builder.SetWrapperObject(this); }
        }
        public SelectAllRecordsByCriteria.SelectAllRecordsByCriteriaBuilder SelectAllRecordsByCriteriaOp
        {
            get { return Operation.SelectAllRecordsByCriteria.Builder.SetWrapperObject(this); }
        }
        public GetStatistic.GetStatisticBuilder GetStatisticOp
        {
            get { return Operation.GetStatistic.Builder.SetWrapperObject(this); }
        }
        public UnselectAllRecords.UnselectAllRecordsBuilder UnselectAllRecordsOp
        {
            get { return Operation.UnselectAllRecords.Builder.SetWrapperObject(this); }
        }
        public SelectRecord.SelectRecordBuilder SelectRecordOp
        {
            get { return Operation.SelectRecord.Builder.SetWrapperObject(this); }
        }
        public UnselectRecord.UnselectRecordBuilder UnselectRecordOp
        {
            get { return Operation.UnselectRecord.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.CatalogChangePagingResult? QueryChanges(QueryChanges input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CatalogChangePagingResult?> QueryChangesAsync(QueryChanges input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? PublishAll(PublishAll input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.StoreInfo?> PublishAllAsync(PublishAll input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.StoreInfo? PublishSelected(PublishSelected input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.StoreInfo?> PublishSelectedAsync(PublishSelected input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SelectAllRecords(SelectAllRecords input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SelectAllRecordsAsync(SelectAllRecords input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SelectAllRecordsByCriteria(SelectAllRecordsByCriteria input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SelectAllRecordsByCriteriaAsync(SelectAllRecordsByCriteria input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CatalogChangeStatistics? GetStatistic(GetStatistic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CatalogChangeStatistics?> GetStatisticAsync(GetStatistic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UnselectAllRecords(UnselectAllRecords input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UnselectAllRecordsAsync(UnselectAllRecords input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SelectRecord(SelectRecord input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SelectRecordAsync(SelectRecord input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UnselectRecord(UnselectRecord input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UnselectRecordAsync(UnselectRecord input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}