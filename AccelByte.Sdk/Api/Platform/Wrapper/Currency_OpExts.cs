// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformCurrency_OpExts
    {
        public static List<Platform.Model.CurrencyInfo>? Execute(
            this ListCurrencies.ListCurrenciesBuilder builder,
            string namespace_
        )
        {
            ListCurrencies op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).ListCurrencies(op);
        }
        public static Platform.Model.CurrencyInfo? Execute(
            this CreateCurrency.CreateCurrencyBuilder builder,
            string namespace_
        )
        {
            CreateCurrency op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).CreateCurrency(op);
        }
        public static Platform.Model.CurrencyInfo? Execute(
            this UpdateCurrency.UpdateCurrencyBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            UpdateCurrency op = builder.Build(
                currencyCode,
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).UpdateCurrency(op);
        }
        public static Platform.Model.CurrencyInfo? Execute(
            this DeleteCurrency.DeleteCurrencyBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            DeleteCurrency op = builder.Build(
                currencyCode,
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).DeleteCurrency(op);
        }
        public static Platform.Model.CurrencyConfig? Execute(
            this GetCurrencyConfig.GetCurrencyConfigBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            GetCurrencyConfig op = builder.Build(
                currencyCode,
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).GetCurrencyConfig(op);
        }
        public static Platform.Model.CurrencySummary? Execute(
            this GetCurrencySummary.GetCurrencySummaryBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            GetCurrencySummary op = builder.Build(
                currencyCode,
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).GetCurrencySummary(op);
        }
        public static List<Platform.Model.CurrencyInfo>? Execute(
            this PublicListCurrencies.PublicListCurrenciesBuilder builder,
            string namespace_
        )
        {
            PublicListCurrencies op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Currency)builder.WrapperObject!).PublicListCurrencies(op);
        }
    }
}