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

    public static class Pass_OperationExtensions
    {
        public static List<Model.PassInfo>? Execute(
            this QueryPasses.QueryPassesBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            QueryPasses op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Pass)builder.WrapperObject!).QueryPasses(op);
        }

        public static Model.PassInfo? Execute(
            this CreatePass.CreatePassBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            CreatePass op = builder.Build(
                namespace_,
                seasonId
            );

            return ((Pass)builder.WrapperObject!).CreatePass(op);
        }

        public static Model.PassInfo? Execute(
            this GetPass.GetPassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            GetPass op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            return ((Pass)builder.WrapperObject!).GetPass(op);
        }

        public static void Execute(
            this DeletePass.DeletePassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            DeletePass op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            ((Pass)builder.WrapperObject!).DeletePass(op);
        }

        public static Model.PassInfo? Execute(
            this UpdatePass.UpdatePassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            UpdatePass op = builder.Build(
                code,
                namespace_,
                seasonId
            );

            return ((Pass)builder.WrapperObject!).UpdatePass(op);
        }

        public static Model.UserSeasonSummary? Execute(
            this GrantUserPass.GrantUserPassBuilder builder,
            string namespace_,
            string userId
        )
        {
            GrantUserPass op = builder.Build(
                namespace_,
                userId
            );

            return ((Pass)builder.WrapperObject!).GrantUserPass(op);
        }

    }
}