// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class DeploymentConfig
    {
        private readonly AccelByteSDK _sdk;

        public DeploymentConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAllDeployment.GetAllDeploymentBuilder GetAllDeploymentOp
        {
            get { return Operation.GetAllDeployment.Builder.SetWrapperObject(this); }
        }
        public GetDeployment.GetDeploymentBuilder GetDeploymentOp
        {
            get { return Operation.GetDeployment.Builder.SetWrapperObject(this); }
        }
        public CreateDeployment.CreateDeploymentBuilder CreateDeploymentOp
        {
            get { return Operation.CreateDeployment.Builder.SetWrapperObject(this); }
        }
        public DeleteDeployment.DeleteDeploymentBuilder DeleteDeploymentOp
        {
            get { return Operation.DeleteDeployment.Builder.SetWrapperObject(this); }
        }
        public UpdateDeployment.UpdateDeploymentBuilder UpdateDeploymentOp
        {
            get { return Operation.UpdateDeployment.Builder.SetWrapperObject(this); }
        }
        public CreateRootRegionOverride.CreateRootRegionOverrideBuilder CreateRootRegionOverrideOp
        {
            get { return Operation.CreateRootRegionOverride.Builder.SetWrapperObject(this); }
        }
        public DeleteRootRegionOverride.DeleteRootRegionOverrideBuilder DeleteRootRegionOverrideOp
        {
            get { return Operation.DeleteRootRegionOverride.Builder.SetWrapperObject(this); }
        }
        public UpdateRootRegionOverride.UpdateRootRegionOverrideBuilder UpdateRootRegionOverrideOp
        {
            get { return Operation.UpdateRootRegionOverride.Builder.SetWrapperObject(this); }
        }
        public CreateDeploymentOverride.CreateDeploymentOverrideBuilder CreateDeploymentOverrideOp
        {
            get { return Operation.CreateDeploymentOverride.Builder.SetWrapperObject(this); }
        }
        public DeleteDeploymentOverride.DeleteDeploymentOverrideBuilder DeleteDeploymentOverrideOp
        {
            get { return Operation.DeleteDeploymentOverride.Builder.SetWrapperObject(this); }
        }
        public UpdateDeploymentOverride.UpdateDeploymentOverrideBuilder UpdateDeploymentOverrideOp
        {
            get { return Operation.UpdateDeploymentOverride.Builder.SetWrapperObject(this); }
        }
        public CreateOverrideRegionOverride.CreateOverrideRegionOverrideBuilder CreateOverrideRegionOverrideOp
        {
            get { return Operation.CreateOverrideRegionOverride.Builder.SetWrapperObject(this); }
        }
        public DeleteOverrideRegionOverride.DeleteOverrideRegionOverrideBuilder DeleteOverrideRegionOverrideOp
        {
            get { return Operation.DeleteOverrideRegionOverride.Builder.SetWrapperObject(this); }
        }
        public UpdateOverrideRegionOverride.UpdateOverrideRegionOverrideBuilder UpdateOverrideRegionOverrideOp
        {
            get { return Operation.UpdateOverrideRegionOverride.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsListDeploymentResponse? GetAllDeployment(GetAllDeployment input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? GetDeployment(GetDeployment input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateDeployment(CreateDeployment input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteDeployment(DeleteDeployment input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateDeployment(UpdateDeployment input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateRootRegionOverride(CreateRootRegionOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? DeleteRootRegionOverride(DeleteRootRegionOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateRootRegionOverride(UpdateRootRegionOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateDeploymentOverride(CreateDeploymentOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? DeleteDeploymentOverride(DeleteDeploymentOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateDeploymentOverride(UpdateDeploymentOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? CreateOverrideRegionOverride(CreateOverrideRegionOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? DeleteOverrideRegionOverride(DeleteOverrideRegionOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeploymentWithOverride? UpdateOverrideRegionOverride(UpdateOverrideRegionOverride input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class DeploymentConfig_OperationExtensions
    {
        public static Model.ModelsListDeploymentResponse? Execute(
            this GetAllDeployment.GetAllDeploymentBuilder builder,
            string namespace_
        )
        {
            GetAllDeployment op = builder.Build(
                namespace_
            );

            return ((DeploymentConfig)builder.WrapperObject!).GetAllDeployment(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this GetDeployment.GetDeploymentBuilder builder,
            string deployment,
            string namespace_
        )
        {
            GetDeployment op = builder.Build(
                deployment,
                namespace_
            );

            return ((DeploymentConfig)builder.WrapperObject!).GetDeployment(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this CreateDeployment.CreateDeploymentBuilder builder,
            ModelsCreateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            CreateDeployment op = builder.Build(
                body,
                deployment,
                namespace_
            );

            return ((DeploymentConfig)builder.WrapperObject!).CreateDeployment(op);
        }

        public static void Execute(
            this DeleteDeployment.DeleteDeploymentBuilder builder,
            string deployment,
            string namespace_
        )
        {
            DeleteDeployment op = builder.Build(
                deployment,
                namespace_
            );

            ((DeploymentConfig)builder.WrapperObject!).DeleteDeployment(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this UpdateDeployment.UpdateDeploymentBuilder builder,
            ModelsUpdateDeploymentRequest body,
            string deployment,
            string namespace_
        )
        {
            UpdateDeployment op = builder.Build(
                body,
                deployment,
                namespace_
            );

            return ((DeploymentConfig)builder.WrapperObject!).UpdateDeployment(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this CreateRootRegionOverride.CreateRootRegionOverrideBuilder builder,
            ModelsCreateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region
        )
        {
            CreateRootRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region
            );

            return ((DeploymentConfig)builder.WrapperObject!).CreateRootRegionOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this DeleteRootRegionOverride.DeleteRootRegionOverrideBuilder builder,
            string deployment,
            string namespace_,
            string region
        )
        {
            DeleteRootRegionOverride op = builder.Build(
                deployment,
                namespace_,
                region
            );

            return ((DeploymentConfig)builder.WrapperObject!).DeleteRootRegionOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this UpdateRootRegionOverride.UpdateRootRegionOverrideBuilder builder,
            ModelsUpdateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region
        )
        {
            UpdateRootRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region
            );

            return ((DeploymentConfig)builder.WrapperObject!).UpdateRootRegionOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this CreateDeploymentOverride.CreateDeploymentOverrideBuilder builder,
            ModelsCreateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            CreateDeploymentOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                version
            );

            return ((DeploymentConfig)builder.WrapperObject!).CreateDeploymentOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this DeleteDeploymentOverride.DeleteDeploymentOverrideBuilder builder,
            string deployment,
            string namespace_,
            string version
        )
        {
            DeleteDeploymentOverride op = builder.Build(
                deployment,
                namespace_,
                version
            );

            return ((DeploymentConfig)builder.WrapperObject!).DeleteDeploymentOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this UpdateDeploymentOverride.UpdateDeploymentOverrideBuilder builder,
            ModelsUpdateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            UpdateDeploymentOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                version
            );

            return ((DeploymentConfig)builder.WrapperObject!).UpdateDeploymentOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this CreateOverrideRegionOverride.CreateOverrideRegionOverrideBuilder builder,
            ModelsCreateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            CreateOverrideRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region,
                version
            );

            return ((DeploymentConfig)builder.WrapperObject!).CreateOverrideRegionOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this DeleteOverrideRegionOverride.DeleteOverrideRegionOverrideBuilder builder,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            DeleteOverrideRegionOverride op = builder.Build(
                deployment,
                namespace_,
                region,
                version
            );

            return ((DeploymentConfig)builder.WrapperObject!).DeleteOverrideRegionOverride(op);
        }

        public static Model.ModelsDeploymentWithOverride? Execute(
            this UpdateOverrideRegionOverride.UpdateOverrideRegionOverrideBuilder builder,
            ModelsUpdateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            UpdateOverrideRegionOverride op = builder.Build(
                body,
                deployment,
                namespace_,
                region,
                version
            );

            return ((DeploymentConfig)builder.WrapperObject!).UpdateOverrideRegionOverride(op);
        }

    }
}