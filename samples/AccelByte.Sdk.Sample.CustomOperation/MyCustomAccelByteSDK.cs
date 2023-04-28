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
    public class MyCustomAccelByteSDK : AccelByteSDK
    {
        public static new AccelByteSdkBuilder<MyCustomAccelByteSDK> Builder { get => new AccelByteSdkBuilder<MyCustomAccelByteSDK>(); }


        public MyCustomWrapper CustomWrapper
        {
            get
            {
                if (_CustomWrapper == null)
                    _CustomWrapper = new MyCustomWrapper(this);
                return _CustomWrapper;
            }
        }
        private MyCustomWrapper? _CustomWrapper = null;


        public MyCustomAccelByteSDK(AccelByteConfig config)
            : base(config) { }

        public MyCustomAccelByteSDK(AccelByteConfig config, List<ISdkService> services)
            : base(config, services) { }
    }
}
