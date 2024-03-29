// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class QosmPublic_OpExts
    {
        public static Qosm.Model.ModelsListServerResponse? Execute(
            this ListServerPerNamespace.ListServerPerNamespaceBuilder builder,
            string namespace_
        )
        {
            ListServerPerNamespace op = builder.Build(
                namespace_
            );

            return ((Qosm.Wrapper.Public)builder.WrapperObject!).ListServerPerNamespace(op);
        }
        public static Qosm.Model.ModelsListServerResponse? Execute(
            this ListServer.ListServerBuilder builder
        )
        {
            ListServer op = builder.Build(
            );

            return ((Qosm.Wrapper.Public)builder.WrapperObject!).ListServer(op);
        }
    }
}