// Copyright (c) 2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class BackgroundTokenRefreshOptions : ITokenRefreshOptions
    {
        [JsonPropertyName("rate")]
        public float Rate { get; set; } = 0.8f;

        [JsonPropertyName("max_retry")]
        public int MaxRetry { get; set; } = 2;

        /// <summary>
        /// Check interval in seconds
        /// </summary>
        [JsonPropertyName("interval")]
        public int Interval { get; set; } = 10;

        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; } = true;

        public Action? OnTokenRefreshed { get; set; } = null;

        public Action<Exception>? OnRefreshFailed { get; set; } = null;

        public static BackgroundTokenRefreshOptions Default { get => new BackgroundTokenRefreshOptions(); }

        public static BackgroundTokenRefreshOptions Override(Action<BackgroundTokenRefreshOptions> optFunc)
        {
            BackgroundTokenRefreshOptions opts = Default;
            optFunc(opts);
            return opts;
        }

        public static BackgroundTokenRefreshOptions LoadFromJson(string jsonStr)
        {
            var temp = JsonSerializer.Deserialize<BackgroundTokenRefreshOptions>(jsonStr);
            if (temp == null)
                throw new Exception("Could not deserialize option json.");
            return temp;
        }

        private BackgroundTokenRefreshOptions()
        {
            string? sRate = Environment.GetEnvironmentVariable("AB_REFRESH_RATE");
            if (sRate != null)
                Rate = float.Parse(sRate);
            string? sMaxRetry = Environment.GetEnvironmentVariable("AB_REFRESH_MAX_RETRY");
            if (sMaxRetry != null)
                MaxRetry = int.Parse(sMaxRetry);
            string? sInterval = Environment.GetEnvironmentVariable("AB_REFRESH_BACKGROUND_INTERVAL");
            if (sInterval != null)
                Interval = int.Parse(sInterval);
            string? sEnabled = Environment.GetEnvironmentVariable("AB_REFRESH_BACKGROUND_ENABLED");
            if (sEnabled != null)
                IsEnabled = sEnabled.Trim().ToLower() == "true";
        }
    }
}
