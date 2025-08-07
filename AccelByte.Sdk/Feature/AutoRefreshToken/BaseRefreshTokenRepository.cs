// Copyright (c) 2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public abstract class BaseRefreshTokenRepository : DefaultTokenRepository, IRefreshTokenRepository
    {
        private object _ROPLock = new object();

        private bool _IsRefreshOnProgress = false;

        private int _RefreshExpireIn = 0;

        private int _MaxRetry = 2;

        public bool RefreshTokenEnabled { get; set; } = false;

        public string RefreshToken { get; protected set; } = "";

        public bool HasRefreshToken { get => RefreshToken != ""; }

        public bool IsTokenExpiring
        {
            get
            {
                long tExpiry = (long)Math.Round((RefreshThreshold * TokenExpiryIn), 0);
                long tgt = IssuedTimestamp + tExpiry;
                return (CurrentTimestamp >= tgt);
            }
        }

        public float RefreshThreshold { get; protected set; } = 0.8f;

        public bool IsRefreshOnProgress
        {
            get
            {
                lock (_ROPLock)
                    return _IsRefreshOnProgress;
            }
            set
            {
                lock (_ROPLock)
                    _IsRefreshOnProgress = value;
            }
        }

        public BaseRefreshTokenRepository(ITokenRefreshOptions opts)
        {
            RefreshThreshold = opts.Rate;
            _MaxRetry = opts.MaxRetry;
            RefreshTokenEnabled = opts.IsEnabled;
        }

        public bool TryToSetRefreshOnProgressToTrue()
        {
            lock (_ROPLock)
            {
                if (_IsRefreshOnProgress)
                    return false;
                else
                {
                    _IsRefreshOnProgress = true;
                    return _IsRefreshOnProgress;
                }
            }
        }

        [Obsolete("Please use overloaded method of `UpdateRefreshToken` that accepts token response model.")]
        public void StoreRefreshToken(string refreshToken, float refreshThreshold)
        {
            RefreshToken = refreshToken;
            RefreshThreshold = refreshThreshold;
            lock (_ROPLock)
                _IsRefreshOnProgress = false;
        }

        [Obsolete("Please use overloaded method of `UpdateRefreshToken` that accepts token response model.")]
        public void UpdateRefreshToken(string refreshToken)
        {
            RefreshToken = refreshToken;
            lock (_ROPLock)
                _IsRefreshOnProgress = false;
        }

        public void UpdateRefreshToken(OauthmodelTokenResponseV3 tokenResponse)
        {
            RefreshToken = tokenResponse.RefreshToken!;
            _RefreshExpireIn = tokenResponse.RefreshExpiresIn!.Value;
            lock (_ROPLock)
                _IsRefreshOnProgress = false;
        }


        public void UpdateRefreshToken(OauthmodelTokenResponse tokenResponse)
        {
            RefreshToken = tokenResponse.RefreshToken!;
            _RefreshExpireIn = tokenResponse.RefreshExpiresIn!.Value;
            lock (_ROPLock)
                _IsRefreshOnProgress = false;
        }

        public void UpdateRefreshToken(OauthmodelTokenWithDeviceCookieResponseV3 tokenResponse)
        {
            RefreshToken = tokenResponse.RefreshToken!;
            _RefreshExpireIn = tokenResponse.RefreshExpiresIn!.Value;
            lock (_ROPLock)
                _IsRefreshOnProgress = false;
        }

        public void DoRefreshToken(AccelByteSDK sdk, Action? onUpdated, Action<Exception>? onFailed, bool rethrowOnError)
        {
            if (HasToken && IsTokenExpiring && !IsRefreshOnProgress)
            {
                //only try refresh if token exists and it is near expired.
                if (TryToSetRefreshOnProgressToTrue())
                {
                    int retryCount = 0;
                    while (true)
                    {
                        try
                        {
                            if (LoginType == LoginType.User ||
                                LoginType == LoginType.Platform)
                            {
                                if (!HasRefreshToken)
                                    throw new Exception("No refresh token stored.");
                                sdk.RefreshAccessToken(RefreshToken, token => onUpdated?.Invoke());
                            }
                            else if (LoginType == LoginType.Client)
                            {
                                sdk.LoginClient(token => onUpdated?.Invoke());
                                _ = UpdateObserversWithNewToken();
                            }

                            break; //retry success, get out of the loop
                        }
                        catch (Exception x)
                        {
                            retryCount++;
                            if (retryCount >= _MaxRetry)
                            {
                                onFailed?.Invoke(x);
                                if (rethrowOnError)
                                    throw;
                                else
                                    break; //this should break the loop and continue
                            }
                        }
                    }
                }
            }
        }

        public async Task DoRefreshTokenAsync(AccelByteSDK sdk, Action? onUpdated, Action<Exception>? onFailed, bool rethrowOnError)
        {
            if (HasToken && IsTokenExpiring && !IsRefreshOnProgress)
            {
                //only try refresh if token exists and it is near expired.
                if (TryToSetRefreshOnProgressToTrue())
                {
                    int retryCount = 0;
                    while (true)
                    {
                        try
                        {
                            if (LoginType == LoginType.User ||
                                LoginType == LoginType.Platform)
                            {
                                if (!HasRefreshToken)
                                    throw new Exception("No refresh token stored.");
                                await sdk.RefreshAccessTokenAsync(RefreshToken, token => onUpdated?.Invoke());
                            }
                            else if (LoginType == LoginType.Client)
                            {
                                await sdk.LoginClientAsync(token => onUpdated?.Invoke());
                                await UpdateObserversWithNewToken();
                            }

                            break; //retry success, get out of the loop
                        }
                        catch (Exception x)
                        {
                            retryCount++;
                            if (retryCount >= _MaxRetry)
                            {
                                onFailed?.Invoke(x);
                                if (rethrowOnError)
                                    throw;
                                else
                                    break; //this should break the loop and continue
                            }
                        }
                    }
                }
            }
        }
    }
}
