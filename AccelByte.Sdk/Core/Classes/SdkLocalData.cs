// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public class SdkLocalData
    {
        private object _LocalDataLock = new object();

        private Dictionary<string, object> _LocalData = new Dictionary<string, object>();

        public object? this[string key]
        {
            get
            {
                lock (_LocalDataLock)
                {
                    if (_LocalData.ContainsKey(key))
                        return _LocalData[key];
                    else
                        return null;
                }
            }
            set
            {
                lock (_LocalDataLock)
                {
                    if (value != null)
                        _LocalData[key] = value;
                }
            }
        }

        internal SdkLocalData() { }

        public T? GetData<T>(string key)
        {
            lock (_LocalDataLock)
            {
                if (_LocalData.ContainsKey(key))
                    return (T)_LocalData[key];
                else
                    return default(T);
            }
        }
    }
}
