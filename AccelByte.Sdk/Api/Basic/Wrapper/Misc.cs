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
}