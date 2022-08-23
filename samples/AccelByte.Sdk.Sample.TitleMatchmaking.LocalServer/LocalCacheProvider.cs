// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class LocalCacheProvider : ICacheProvider
    {
        private Dictionary<string, string> _SCache;

        private Dictionary<string, List<string>> _LCache;

        public LocalCacheProvider(
            Dictionary<string, string> sglCacheObj,
            Dictionary<string, List<string>> listCacheObj)
        {
            _SCache = sglCacheObj;
            _LCache = listCacheObj;
        }

        public LocalCacheProvider()
        {
            _SCache = new Dictionary<string, string>();
            _LCache = new Dictionary<string, List<string>>();
        }

        public string? Load(string key)
        {
            if (_SCache.ContainsKey(key))
                return _SCache[key];
            else
                return null;
        }

        public void Remove(string key)
        {
            if (_SCache.ContainsKey(key))
                _SCache.Remove(key);
            if (_LCache.ContainsKey(key))
                _LCache.Remove(key);
        }

        public bool IsExists(string key)
        {
            return (_SCache.ContainsKey(key) || _LCache.ContainsKey(key));
        }

        public bool Save(string key, string value)
        {
            if (_SCache.ContainsKey(key))
                _SCache[key] = value;
            else
                _SCache.Add(key, value);
            return true;
        }

        public bool PushItem(string key, string item)
        {
            if (!_LCache.ContainsKey(key))
                _LCache.Add(key, new List<string>());
            _LCache[key].Add(item);
            return true;
        }

        public List<string>? GetItems(string key)
        {
            if (_LCache.ContainsKey(key))
                return _LCache[key];
            else
                return null;
        }
    }
}