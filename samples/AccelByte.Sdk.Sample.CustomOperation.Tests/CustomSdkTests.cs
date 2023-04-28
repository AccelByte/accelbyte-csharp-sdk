// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CustomOperation;

namespace AccelByte.Sdk.Sample.CustomOperation.Tests
{
    public class CustomSdkTests
    {
        protected MyCustomAccelByteSDK? _Sdk = null;

        [OneTimeSetUp]
        public void Setup()
        {
            _Sdk = MyCustomAccelByteSDK.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [Test]
        public void CustomOpTest1()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            MyCustomResponseModel? response = _Sdk.CustomWrapper.MyCustomOperationOp.Execute(_Sdk.Namespace);
            Assert.IsNotNull(response);
        }
    }
}