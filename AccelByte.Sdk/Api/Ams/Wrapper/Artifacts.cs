// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class Artifacts
    {
        private readonly AccelByteSDK _sdk;

        public Artifacts(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ArtifactGet.ArtifactGetBuilder ArtifactGetOp
        {
            get { return Operation.ArtifactGet.Builder.SetWrapperObject(this); }
        }
        public ArtifactUsageGet.ArtifactUsageGetBuilder ArtifactUsageGetOp
        {
            get { return Operation.ArtifactUsageGet.Builder.SetWrapperObject(this); }
        }
        public ArtifactDelete.ArtifactDeleteBuilder ArtifactDeleteOp
        {
            get { return Operation.ArtifactDelete.Builder.SetWrapperObject(this); }
        }
        public ArtifactGetURL.ArtifactGetURLBuilder ArtifactGetURLOp
        {
            get { return Operation.ArtifactGetURL.Builder.SetWrapperObject(this); }
        }
        public FleetArtifactSamplingRulesGet.FleetArtifactSamplingRulesGetBuilder FleetArtifactSamplingRulesGetOp
        {
            get { return Operation.FleetArtifactSamplingRulesGet.Builder.SetWrapperObject(this); }
        }
        public FleetArtifactSamplingRulesSet.FleetArtifactSamplingRulesSetBuilder FleetArtifactSamplingRulesSetOp
        {
            get { return Operation.FleetArtifactSamplingRulesSet.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.ApiArtifactResponse>? ArtifactGet(ArtifactGet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiArtifactUsageResponse? ArtifactUsageGet(ArtifactUsageGet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ArtifactDelete(ArtifactDelete input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiArtifactURLResponse? ArtifactGetURL(ArtifactGetURL input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiFleetArtifactsSampleRules? FleetArtifactSamplingRulesGet(FleetArtifactSamplingRulesGet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiFleetArtifactsSampleRules? FleetArtifactSamplingRulesSet(FleetArtifactSamplingRulesSet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}