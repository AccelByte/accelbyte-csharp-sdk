// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;
using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class Match2MatchFunctions_OpExts
    {
        public static Match2.Model.ApiListMatchFunctionsResponse? Execute(
            this MatchFunctionList.MatchFunctionListBuilder builder,
            string namespace_
        )
        {
            MatchFunctionList op = builder.Build(
                namespace_
            );

            return ((Match2.Wrapper.MatchFunctions)builder.WrapperObject!).MatchFunctionList(op);
        }
        public static void Execute(
            this CreateMatchFunction.CreateMatchFunctionBuilder builder,
            ApiMatchFunctionRequest body,
            string namespace_
        )
        {
            CreateMatchFunction op = builder.Build(
                body,
                namespace_
            );

            ((Match2.Wrapper.MatchFunctions)builder.WrapperObject!).CreateMatchFunction(op);
        }
        public static void Execute(
            this DeleteMatchFunction.DeleteMatchFunctionBuilder builder,
            string name,
            string namespace_
        )
        {
            DeleteMatchFunction op = builder.Build(
                name,
                namespace_
            );

            ((Match2.Wrapper.MatchFunctions)builder.WrapperObject!).DeleteMatchFunction(op);
        }
    }
}