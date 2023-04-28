// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Sample.CustomOperation
{
    public class MyCustomWrapper
    {
        private readonly AccelByteSDK _sdk;

        public MyCustomWrapper(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        public MyCustomResponseModel? CallMyCustomOperation(MyCustomOperation input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public MyCustomOperation.MyCustomOperationBuilder MyCustomOperationOp
        {
            get { return MyCustomOperation.Builder.SetWrapperObject(this); }
        }
    }
}
