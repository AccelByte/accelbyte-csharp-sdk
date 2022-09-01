// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StackExchange.Redis;

using AccelByte.Sdk.Sample.TicTacToe.Provider;

namespace AccelByte.Sdk.Sample.TicTacToe.Lambda
{
    public class RedisCacheProvider : ICacheProvider
    {
        private string _RedisHost = "127.0.0.1";

        private int _RedisPort = 6379;

        private ConnectionMultiplexer _ConnMpx;

        public RedisCacheProvider()
        {
            if (Environment.GetEnvironmentVariable("AB_REDIS_HOST") != null)
                _RedisHost = Environment.GetEnvironmentVariable("AB_REDIS_HOST")!.Trim();

            if (Environment.GetEnvironmentVariable("AB_REDIS_PORT") != null)
            {
                string sRedisPort = Environment.GetEnvironmentVariable("AB_REDIS_PORT")!.Trim();
                _RedisPort = int.Parse(sRedisPort);
            }

            _ConnMpx = ConnectionMultiplexer.Connect(String.Format("{0}:{1}", _RedisHost, _RedisPort));
        }

        public List<string>? GetItems(string key)
        {
            IDatabase db = _ConnMpx.GetDatabase();
            RedisValue[] redisValues = db.ListRange(key, 0, -1);

            List<string> items = new List<string>();
            foreach (RedisValue redisValue in redisValues)
                items.Add(redisValue.ToString());
            return items;
        }

        public bool IsExists(string key)
        {
            IDatabase db = _ConnMpx.GetDatabase();
            return db.KeyExists(key);
        }

        public string? Load(string key)
        {
            IDatabase db = _ConnMpx.GetDatabase();
            RedisValue value = db.StringGet(key);
            if (value.HasValue)
                return value.ToString();
            else
                return null;
        }

        public bool PushItem(string key, string item)
        {
            IDatabase db = _ConnMpx.GetDatabase();
            db.ListRightPush(key, item);
            return true;
        }

        public void Remove(string key)
        {
            IDatabase db = _ConnMpx.GetDatabase();
            db.KeyDelete(key);
        }

        public bool Save(string key, string value)
        {
            IDatabase db = _ConnMpx.GetDatabase();
            return db.StringSet(key, value);
        }
    }
}