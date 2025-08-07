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
    public class OnDemandTokenRefreshOptions : ITokenRefreshOptions
    {
        [JsonPropertyName("rate")]
        public float Rate { get; set; } = 0.8f;

        [JsonPropertyName("max_retry")]
        public int MaxRetry { get; set; } = 2;

        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; } = true;

        public static OnDemandTokenRefreshOptions Default { get => new OnDemandTokenRefreshOptions(); }

        public static OnDemandTokenRefreshOptions Override(Action<OnDemandTokenRefreshOptions> optFunc)
        {
            OnDemandTokenRefreshOptions opts = Default;
            optFunc(opts);
            return opts;
        }

        public static OnDemandTokenRefreshOptions LoadFromJson(string jsonStr)
        {
            var temp = JsonSerializer.Deserialize<OnDemandTokenRefreshOptions>(jsonStr);
            if (temp == null)
                throw new Exception("Could not deserialize option json.");
            return temp;
        }

        private OnDemandTokenRefreshOptions()
        {
            string? sRate = Environment.GetEnvironmentVariable("AB_REFRESH_RATE");
            if (sRate != null)
                Rate = float.Parse(sRate);
            string? sMaxRetry = Environment.GetEnvironmentVariable("AB_REFRESH_MAX_RETRY");
            if (sMaxRetry != null)
                MaxRetry = int.Parse(sMaxRetry);
            string? sEnabled = Environment.GetEnvironmentVariable("AB_REFRESH_ONDEMAND_ENABLED");
            if (sEnabled != null)
                IsEnabled = sEnabled.Trim().ToLower() == "true";
        }
    }
}
