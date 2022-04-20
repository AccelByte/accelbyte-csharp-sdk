// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class FulfillmentScript
    {
        private readonly AccelByteSDK _sdk;

        public FulfillmentScript(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListFulfillmentScripts.ListFulfillmentScriptsBuilder ListFulfillmentScriptsOp
        {
            get { return Operation.ListFulfillmentScripts.Builder.SetWrapperObject(this); }
        }
        public TestFulfillmentScriptEval.TestFulfillmentScriptEvalBuilder TestFulfillmentScriptEvalOp
        {
            get { return Operation.TestFulfillmentScriptEval.Builder.SetWrapperObject(this); }
        }
        public GetFulfillmentScript.GetFulfillmentScriptBuilder GetFulfillmentScriptOp
        {
            get { return Operation.GetFulfillmentScript.Builder.SetWrapperObject(this); }
        }
        public CreateFulfillmentScript.CreateFulfillmentScriptBuilder CreateFulfillmentScriptOp
        {
            get { return Operation.CreateFulfillmentScript.Builder.SetWrapperObject(this); }
        }
        public DeleteFulfillmentScript.DeleteFulfillmentScriptBuilder DeleteFulfillmentScriptOp
        {
            get { return Operation.DeleteFulfillmentScript.Builder.SetWrapperObject(this); }
        }
        public UpdateFulfillmentScript.UpdateFulfillmentScriptBuilder UpdateFulfillmentScriptOp
        {
            get { return Operation.UpdateFulfillmentScript.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.FulfillmentScriptInfo>? ListFulfillmentScripts(ListFulfillmentScripts input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptEvalTestResult? TestFulfillmentScriptEval(TestFulfillmentScriptEval input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptInfo? GetFulfillmentScript(GetFulfillmentScript input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptInfo? CreateFulfillmentScript(CreateFulfillmentScript input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteFulfillmentScript(DeleteFulfillmentScript input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptInfo? UpdateFulfillmentScript(UpdateFulfillmentScript input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}