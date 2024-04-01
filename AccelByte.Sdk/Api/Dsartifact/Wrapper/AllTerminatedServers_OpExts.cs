// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;
using AccelByte.Sdk.Api.Dsartifact.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class DsartifactAllTerminatedServers_OpExts
    {
        public static Dsartifact.Model.ModelsListTerminatedServersResponse? Execute(
            this ListTerminatedServers.ListTerminatedServersBuilder builder
        )
        {
            ListTerminatedServers op = builder.Build(
            );

            return ((Dsartifact.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListTerminatedServers(op);
        }
        public static async Task<Dsartifact.Model.ModelsListTerminatedServersResponse?> ExecuteAsync(
            this ListTerminatedServers.ListTerminatedServersBuilder builder
        )
        {
            ListTerminatedServers op = builder.Build(
            );

            return await ((Dsartifact.Wrapper.AllTerminatedServers)builder.WrapperObject!).ListTerminatedServersAsync(op);
        }
    }
}