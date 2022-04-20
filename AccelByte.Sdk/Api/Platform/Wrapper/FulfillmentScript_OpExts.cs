// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformFulfillmentScript_OpExts
    {
        public static List<Platform.Model.FulfillmentScriptInfo>? Execute(
            this ListFulfillmentScripts.ListFulfillmentScriptsBuilder builder
        )
        {
            ListFulfillmentScripts op = builder.Build(
            );

            return ((Platform.Wrapper.FulfillmentScript)builder.WrapperObject!).ListFulfillmentScripts(op);
        }

        public static Platform.Model.FulfillmentScriptEvalTestResult? Execute(
            this TestFulfillmentScriptEval.TestFulfillmentScriptEvalBuilder builder
        )
        {
            TestFulfillmentScriptEval op = builder.Build(
            );

            return ((Platform.Wrapper.FulfillmentScript)builder.WrapperObject!).TestFulfillmentScriptEval(op);
        }

        public static Platform.Model.FulfillmentScriptInfo? Execute(
            this GetFulfillmentScript.GetFulfillmentScriptBuilder builder,
            string id
        )
        {
            GetFulfillmentScript op = builder.Build(
                id
            );

            return ((Platform.Wrapper.FulfillmentScript)builder.WrapperObject!).GetFulfillmentScript(op);
        }

        public static Platform.Model.FulfillmentScriptInfo? Execute(
            this CreateFulfillmentScript.CreateFulfillmentScriptBuilder builder,
            string id
        )
        {
            CreateFulfillmentScript op = builder.Build(
                id
            );

            return ((Platform.Wrapper.FulfillmentScript)builder.WrapperObject!).CreateFulfillmentScript(op);
        }

        public static void Execute(
            this DeleteFulfillmentScript.DeleteFulfillmentScriptBuilder builder,
            string id
        )
        {
            DeleteFulfillmentScript op = builder.Build(
                id
            );

            ((Platform.Wrapper.FulfillmentScript)builder.WrapperObject!).DeleteFulfillmentScript(op);
        }

        public static Platform.Model.FulfillmentScriptInfo? Execute(
            this UpdateFulfillmentScript.UpdateFulfillmentScriptBuilder builder,
            string id
        )
        {
            UpdateFulfillmentScript op = builder.Build(
                id
            );

            return ((Platform.Wrapper.FulfillmentScript)builder.WrapperObject!).UpdateFulfillmentScript(op);
        }

    }
}