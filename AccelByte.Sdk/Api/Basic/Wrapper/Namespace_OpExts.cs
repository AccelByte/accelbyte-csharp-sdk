// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicNamespace_OpExts
    {
        public static List<Basic.Model.NamespaceInfo>? Execute(
            this GetNamespaces.GetNamespacesBuilder builder
        )
        {
            GetNamespaces op = builder.Build(
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).GetNamespaces(op);
        }

        public static Basic.Model.NamespaceInfo? Execute(
            this CreateNamespace.CreateNamespaceBuilder builder
        )
        {
            CreateNamespace op = builder.Build(
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).CreateNamespace(op);
        }

        public static Basic.Model.NamespaceInfo? Execute(
            this GetNamespace.GetNamespaceBuilder builder,
            string namespace_
        )
        {
            GetNamespace op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).GetNamespace(op);
        }

        public static Basic.Model.NamespaceInfo? Execute(
            this DeleteNamespace.DeleteNamespaceBuilder builder,
            string namespace_
        )
        {
            DeleteNamespace op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).DeleteNamespace(op);
        }

        public static Basic.Model.NamespaceInfo? Execute(
            this UpdateNamespace.UpdateNamespaceBuilder builder,
            string namespace_
        )
        {
            UpdateNamespace op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).UpdateNamespace(op);
        }

        public static Basic.Model.NamespacePublisherInfo? Execute(
            this GetNamespacePublisher.GetNamespacePublisherBuilder builder,
            string namespace_
        )
        {
            GetNamespacePublisher op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).GetNamespacePublisher(op);
        }

        public static Basic.Model.NamespaceInfo? Execute(
            this ChangeNamespaceStatus.ChangeNamespaceStatusBuilder builder,
            string namespace_
        )
        {
            ChangeNamespaceStatus op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).ChangeNamespaceStatus(op);
        }

        public static List<Basic.Model.NamespaceInfo>? Execute(
            this PublicGetNamespaces.PublicGetNamespacesBuilder builder
        )
        {
            PublicGetNamespaces op = builder.Build(
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).PublicGetNamespaces(op);
        }

        public static Basic.Model.NamespacePublisherInfo? Execute(
            this PublicGetNamespacePublisher.PublicGetNamespacePublisherBuilder builder,
            string namespace_
        )
        {
            PublicGetNamespacePublisher op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.Namespace)builder.WrapperObject!).PublicGetNamespacePublisher(op);
        }

    }
}