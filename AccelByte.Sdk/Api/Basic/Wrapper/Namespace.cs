// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class Namespace
    {
        private readonly AccelByteSDK _sdk;

        public Namespace(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetNamespaces.GetNamespacesBuilder GetNamespacesOp
        {
            get { return Operation.GetNamespaces.Builder.SetWrapperObject(this); }
        }
        public CreateNamespace.CreateNamespaceBuilder CreateNamespaceOp
        {
            get { return Operation.CreateNamespace.Builder.SetWrapperObject(this); }
        }
        public GetNamespace.GetNamespaceBuilder GetNamespaceOp
        {
            get { return Operation.GetNamespace.Builder.SetWrapperObject(this); }
        }
        public DeleteNamespace.DeleteNamespaceBuilder DeleteNamespaceOp
        {
            get { return Operation.DeleteNamespace.Builder.SetWrapperObject(this); }
        }
        public UpdateNamespace.UpdateNamespaceBuilder UpdateNamespaceOp
        {
            get { return Operation.UpdateNamespace.Builder.SetWrapperObject(this); }
        }
        public GetGameNamespaces.GetGameNamespacesBuilder GetGameNamespacesOp
        {
            get { return Operation.GetGameNamespaces.Builder.SetWrapperObject(this); }
        }
        public GetNamespacePublisher.GetNamespacePublisherBuilder GetNamespacePublisherOp
        {
            get { return Operation.GetNamespacePublisher.Builder.SetWrapperObject(this); }
        }
        public ChangeNamespaceStatus.ChangeNamespaceStatusBuilder ChangeNamespaceStatusOp
        {
            get { return Operation.ChangeNamespaceStatus.Builder.SetWrapperObject(this); }
        }
        public PublicGetNamespaces.PublicGetNamespacesBuilder PublicGetNamespacesOp
        {
            get { return Operation.PublicGetNamespaces.Builder.SetWrapperObject(this); }
        }
        public PublicGetNamespacePublisher.PublicGetNamespacePublisherBuilder PublicGetNamespacePublisherOp
        {
            get { return Operation.PublicGetNamespacePublisher.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.NamespaceInfo>? GetNamespaces(GetNamespaces input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? CreateNamespace(CreateNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? GetNamespace(GetNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? DeleteNamespace(DeleteNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? UpdateNamespace(UpdateNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.NamespaceInfo>? GetGameNamespaces(GetGameNamespaces input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespacePublisherInfo? GetNamespacePublisher(GetNamespacePublisher input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? ChangeNamespaceStatus(ChangeNamespaceStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.NamespaceInfo>? PublicGetNamespaces(PublicGetNamespaces input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespacePublisherInfo? PublicGetNamespacePublisher(PublicGetNamespacePublisher input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}