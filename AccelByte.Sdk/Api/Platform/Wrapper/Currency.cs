// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Currency
    {
        private readonly AccelByteSDK _sdk;

        public Currency(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListCurrencies.ListCurrenciesBuilder ListCurrenciesOp
        {
            get { return Operation.ListCurrencies.Builder.SetWrapperObject(this); }
        }
        public CreateCurrency.CreateCurrencyBuilder CreateCurrencyOp
        {
            get { return Operation.CreateCurrency.Builder.SetWrapperObject(this); }
        }
        public UpdateCurrency.UpdateCurrencyBuilder UpdateCurrencyOp
        {
            get { return Operation.UpdateCurrency.Builder.SetWrapperObject(this); }
        }
        public DeleteCurrency.DeleteCurrencyBuilder DeleteCurrencyOp
        {
            get { return Operation.DeleteCurrency.Builder.SetWrapperObject(this); }
        }
        public GetCurrencyConfig.GetCurrencyConfigBuilder GetCurrencyConfigOp
        {
            get { return Operation.GetCurrencyConfig.Builder.SetWrapperObject(this); }
        }
        public GetCurrencySummary.GetCurrencySummaryBuilder GetCurrencySummaryOp
        {
            get { return Operation.GetCurrencySummary.Builder.SetWrapperObject(this); }
        }
        public PublicListCurrencies.PublicListCurrenciesBuilder PublicListCurrenciesOp
        {
            get { return Operation.PublicListCurrencies.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.CurrencyInfo>? ListCurrencies(ListCurrencies input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CurrencyInfo? CreateCurrency(CreateCurrency input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CurrencyInfo? UpdateCurrency(UpdateCurrency input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CurrencyInfo? DeleteCurrency(DeleteCurrency input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CurrencyConfig? GetCurrencyConfig(GetCurrencyConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CurrencySummary? GetCurrencySummary(GetCurrencySummary input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CurrencyInfo>? PublicListCurrencies(PublicListCurrencies input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}