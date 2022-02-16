// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

namespace AccelByte.Sdk.Core.Repository
{

    public class DefaultTokenRepository : ITokenRepository
    {
        public static object InstanceLock = new object();
        private static DefaultTokenRepository Instance = default!;

        private string _token = string.Empty;

        public static DefaultTokenRepository GetInstance()
        {
            lock (InstanceLock)
            {
                if (Instance == null)
                {
                    Instance = new DefaultTokenRepository();
                }

                return Instance;
            }
        }

        private DefaultTokenRepository()
        {
        }

        public void StoreToken(string token)
        {
            _token = token;
        }

        public string GetToken()
        {
            return _token;
        }

        public void RemoveToken()
        {
            _token = string.Empty;
        }
    }
}