// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicMisc_OpExts
    {
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static List<Basic.Model.CountryObject>? Execute(
            this GetCountries.GetCountriesBuilder builder,
            string namespace_
        )
        {
            GetCountries op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).GetCountries(op);
        }
        public static async Task<List<Basic.Model.CountryObject>?> ExecuteAsync(
            this GetCountries.GetCountriesBuilder builder,
            string namespace_
        )
        {
            GetCountries op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).GetCountriesAsync(op);
        }
        public static List<Basic.Model.RetrieveCountryGroupResponse>? Execute(
            this GetCountryGroups.GetCountryGroupsBuilder builder,
            string namespace_
        )
        {
            GetCountryGroups op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).GetCountryGroups(op);
        }
        public static async Task<List<Basic.Model.RetrieveCountryGroupResponse>?> ExecuteAsync(
            this GetCountryGroups.GetCountryGroupsBuilder builder,
            string namespace_
        )
        {
            GetCountryGroups op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).GetCountryGroupsAsync(op);
        }
        public static Basic.Model.AddCountryGroupResponse? Execute(
            this AddCountryGroup.AddCountryGroupBuilder builder,
            string namespace_
        )
        {
            AddCountryGroup op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).AddCountryGroup(op);
        }
        public static async Task<Basic.Model.AddCountryGroupResponse?> ExecuteAsync(
            this AddCountryGroup.AddCountryGroupBuilder builder,
            string namespace_
        )
        {
            AddCountryGroup op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).AddCountryGroupAsync(op);
        }
        public static Basic.Model.CountryGroupObject? Execute(
            this UpdateCountryGroup.UpdateCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            UpdateCountryGroup op = builder.Build(
                countryGroupCode,
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).UpdateCountryGroup(op);
        }
        public static async Task<Basic.Model.CountryGroupObject?> ExecuteAsync(
            this UpdateCountryGroup.UpdateCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            UpdateCountryGroup op = builder.Build(
                countryGroupCode,
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).UpdateCountryGroupAsync(op);
        }
        public static void Execute(
            this DeleteCountryGroup.DeleteCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            DeleteCountryGroup op = builder.Build(
                countryGroupCode,
                namespace_
            );

            ((Basic.Wrapper.Misc)builder.WrapperObject!).DeleteCountryGroup(op);
        }
        public static async Task ExecuteAsync(
            this DeleteCountryGroup.DeleteCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            DeleteCountryGroup op = builder.Build(
                countryGroupCode,
                namespace_
            );

            await ((Basic.Wrapper.Misc)builder.WrapperObject!).DeleteCountryGroupAsync(op);
        }
        public static Dictionary<string, string>? Execute(
            this GetLanguages.GetLanguagesBuilder builder,
            string namespace_
        )
        {
            GetLanguages op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).GetLanguages(op);
        }
        public static async Task<Dictionary<string, string>?> ExecuteAsync(
            this GetLanguages.GetLanguagesBuilder builder,
            string namespace_
        )
        {
            GetLanguages op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).GetLanguagesAsync(op);
        }
        public static List<string>? Execute(
            this GetTimeZones.GetTimeZonesBuilder builder,
            string namespace_
        )
        {
            GetTimeZones op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).GetTimeZones(op);
        }
        public static async Task<List<string>?> ExecuteAsync(
            this GetTimeZones.GetTimeZonesBuilder builder,
            string namespace_
        )
        {
            GetTimeZones op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).GetTimeZonesAsync(op);
        }
        public static Basic.Model.RetrieveTimeResponse? Execute(
            this PublicGetTime.PublicGetTimeBuilder builder
        )
        {
            PublicGetTime op = builder.Build(
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetTime(op);
        }
        public static async Task<Basic.Model.RetrieveTimeResponse?> ExecuteAsync(
            this PublicGetTime.PublicGetTimeBuilder builder
        )
        {
            PublicGetTime op = builder.Build(
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetTimeAsync(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static List<Basic.Model.CountryObject>? Execute(
            this PublicGetCountries.PublicGetCountriesBuilder builder,
            string namespace_
        )
        {
            PublicGetCountries op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetCountries(op);
        }
        public static async Task<List<Basic.Model.CountryObject>?> ExecuteAsync(
            this PublicGetCountries.PublicGetCountriesBuilder builder,
            string namespace_
        )
        {
            PublicGetCountries op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetCountriesAsync(op);
        }
        public static Dictionary<string, object>? Execute(
            this PublicGetLanguages.PublicGetLanguagesBuilder builder,
            string namespace_
        )
        {
            PublicGetLanguages op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetLanguages(op);
        }
        public static async Task<Dictionary<string, object>?> ExecuteAsync(
            this PublicGetLanguages.PublicGetLanguagesBuilder builder,
            string namespace_
        )
        {
            PublicGetLanguages op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetLanguagesAsync(op);
        }
        public static List<string>? Execute(
            this PublicGetTimeZones.PublicGetTimeZonesBuilder builder,
            string namespace_
        )
        {
            PublicGetTimeZones op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetTimeZones(op);
        }
        public static async Task<List<string>?> ExecuteAsync(
            this PublicGetTimeZones.PublicGetTimeZonesBuilder builder,
            string namespace_
        )
        {
            PublicGetTimeZones op = builder.Build(
                namespace_
            );

            return await ((Basic.Wrapper.Misc)builder.WrapperObject!).PublicGetTimeZonesAsync(op);
        }
    }
}