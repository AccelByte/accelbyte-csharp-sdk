// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class Misc
    {
        private readonly AccelByteSDK _sdk;

        public Misc(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetCountries.GetCountriesBuilder GetCountriesOp
        {
            get { return Operation.GetCountries.Builder.SetWrapperObject(this); }
        }
        public GetCountryGroups.GetCountryGroupsBuilder GetCountryGroupsOp
        {
            get { return Operation.GetCountryGroups.Builder.SetWrapperObject(this); }
        }
        public AddCountryGroup.AddCountryGroupBuilder AddCountryGroupOp
        {
            get { return Operation.AddCountryGroup.Builder.SetWrapperObject(this); }
        }
        public UpdateCountryGroup.UpdateCountryGroupBuilder UpdateCountryGroupOp
        {
            get { return Operation.UpdateCountryGroup.Builder.SetWrapperObject(this); }
        }
        public DeleteCountryGroup.DeleteCountryGroupBuilder DeleteCountryGroupOp
        {
            get { return Operation.DeleteCountryGroup.Builder.SetWrapperObject(this); }
        }
        public GetLanguages.GetLanguagesBuilder GetLanguagesOp
        {
            get { return Operation.GetLanguages.Builder.SetWrapperObject(this); }
        }
        public GetTimeZones.GetTimeZonesBuilder GetTimeZonesOp
        {
            get { return Operation.GetTimeZones.Builder.SetWrapperObject(this); }
        }
        public PublicGetTime.PublicGetTimeBuilder PublicGetTimeOp
        {
            get { return Operation.PublicGetTime.Builder.SetWrapperObject(this); }
        }
        public PublicGetCountries.PublicGetCountriesBuilder PublicGetCountriesOp
        {
            get { return Operation.PublicGetCountries.Builder.SetWrapperObject(this); }
        }
        public PublicGetLanguages.PublicGetLanguagesBuilder PublicGetLanguagesOp
        {
            get { return Operation.PublicGetLanguages.Builder.SetWrapperObject(this); }
        }
        public PublicGetTimeZones.PublicGetTimeZonesBuilder PublicGetTimeZonesOp
        {
            get { return Operation.PublicGetTimeZones.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.CountryObject>? GetCountries(GetCountries input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveCountryGroupResponse>? GetCountryGroups(GetCountryGroups input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AddCountryGroupResponse? AddCountryGroup(AddCountryGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CountryGroupObject? UpdateCountryGroup(UpdateCountryGroup input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteCountryGroup(DeleteCountryGroup input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetLanguages(GetLanguages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? GetTimeZones(GetTimeZones input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveTimeResponse? PublicGetTime(PublicGetTime input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CountryObject>? PublicGetCountries(PublicGetCountries input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicGetLanguages(PublicGetLanguages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? PublicGetTimeZones(PublicGetTimeZones input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Misc_OperationExtensions
    {
        public static List<Model.CountryObject>? Execute(
            this GetCountries.GetCountriesBuilder builder,
            string namespace_
        )
        {
            GetCountries op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).GetCountries(op);
        }

        public static List<Model.RetrieveCountryGroupResponse>? Execute(
            this GetCountryGroups.GetCountryGroupsBuilder builder,
            string namespace_
        )
        {
            GetCountryGroups op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).GetCountryGroups(op);
        }

        public static Model.AddCountryGroupResponse? Execute(
            this AddCountryGroup.AddCountryGroupBuilder builder,
            string namespace_
        )
        {
            AddCountryGroup op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).AddCountryGroup(op);
        }

        public static Model.CountryGroupObject? Execute(
            this UpdateCountryGroup.UpdateCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            UpdateCountryGroup op = builder.Build(
                countryGroupCode,
                namespace_
            );

            return ((Misc)builder.WrapperObject!).UpdateCountryGroup(op);
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

            ((Misc)builder.WrapperObject!).DeleteCountryGroup(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetLanguages.GetLanguagesBuilder builder,
            string namespace_
        )
        {
            GetLanguages op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).GetLanguages(op);
        }

        public static List<string>? Execute(
            this GetTimeZones.GetTimeZonesBuilder builder,
            string namespace_
        )
        {
            GetTimeZones op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).GetTimeZones(op);
        }

        public static Model.RetrieveTimeResponse? Execute(
            this PublicGetTime.PublicGetTimeBuilder builder
        )
        {
            PublicGetTime op = builder.Build(
            );

            return ((Misc)builder.WrapperObject!).PublicGetTime(op);
        }

        public static List<Model.CountryObject>? Execute(
            this PublicGetCountries.PublicGetCountriesBuilder builder,
            string namespace_
        )
        {
            PublicGetCountries op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).PublicGetCountries(op);
        }

        public static Dictionary<string, object>? Execute(
            this PublicGetLanguages.PublicGetLanguagesBuilder builder,
            string namespace_
        )
        {
            PublicGetLanguages op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).PublicGetLanguages(op);
        }

        public static List<string>? Execute(
            this PublicGetTimeZones.PublicGetTimeZonesBuilder builder,
            string namespace_
        )
        {
            PublicGetTimeZones op = builder.Build(
                namespace_
            );

            return ((Misc)builder.WrapperObject!).PublicGetTimeZones(op);
        }

    }
}