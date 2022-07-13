// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core.Repository
{
    public class SharedTokenRepository : DefaultTokenRepository
    {
        private static SharedTokenRepository? _Instance = null;

        private static object _InstanceLock = new object();

        public static SharedTokenRepository Instance
        {
            get
            {
                lock(_InstanceLock)
                {
                    if (_Instance == null)
                        _Instance = new SharedTokenRepository();
                    return _Instance;
                }
            }
        }
    }
}