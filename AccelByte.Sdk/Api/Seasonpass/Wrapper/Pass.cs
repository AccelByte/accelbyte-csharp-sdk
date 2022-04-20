// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Pass
    {
        private readonly AccelByteSDK _sdk;

        public Pass(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryPasses.QueryPassesBuilder QueryPassesOp
        {
            get { return Operation.QueryPasses.Builder.SetWrapperObject(this); }
        }
        public CreatePass.CreatePassBuilder CreatePassOp
        {
            get { return Operation.CreatePass.Builder.SetWrapperObject(this); }
        }
        public GetPass.GetPassBuilder GetPassOp
        {
            get { return Operation.GetPass.Builder.SetWrapperObject(this); }
        }
        public DeletePass.DeletePassBuilder DeletePassOp
        {
            get { return Operation.DeletePass.Builder.SetWrapperObject(this); }
        }
        public UpdatePass.UpdatePassBuilder UpdatePassOp
        {
            get { return Operation.UpdatePass.Builder.SetWrapperObject(this); }
        }
        public GrantUserPass.GrantUserPassBuilder GrantUserPassOp
        {
            get { return Operation.GrantUserPass.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.PassInfo>? QueryPasses(QueryPasses input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PassInfo? CreatePass(CreatePass input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PassInfo? GetPass(GetPass input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePass(DeletePass input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PassInfo? UpdatePass(UpdatePass input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSeasonSummary? GrantUserPass(GrantUserPass input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}