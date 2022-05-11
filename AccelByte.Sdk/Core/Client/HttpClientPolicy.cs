// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccelByte.Sdk.Core.Client
{
    public class HttpClientPolicy
    {
        /// <summary>
        /// Get default HttpClientPolicy object.
        /// </summary>
        public static readonly HttpClientPolicy Default = new HttpClientPolicy()
        {
            RetryOnException = true,
            MaxRetryCount = 5,
            RetryInterval = 500,
            IntervalType = RetryIntervalType.Linear,
            RequestTimeOut = 100,
            AddRetryCountToHeaders = false,
            RetryLogicHandler = new DefaultRetryLogicHandler()
        };

        /// <summary>
        /// Flag to enable or disable retry on exception.
        /// </summary>
        public bool? RetryOnException { get; set; } = null;

        /// <summary>
        /// No. of retry before it considered failed.
        /// </summary>
        public int? MaxRetryCount { get; set; } = null;

        /// <summary>
        /// Interval between retry, in milliseconds.
        /// </summary>
        public int? RetryInterval { get; set; } = null;

        /// <summary>
        /// Retry interval growth type. Linear or exponential.
        /// For linear type, interval time between retry is specified by RetryInterval.
        /// For Exponential type, interval time betwen retry is calculated from RetryInterval multiplied by the number of retries.
        /// </summary>
        public RetryIntervalType? IntervalType { get; set; } = null;

        /// <summary>
        /// Set request timeout in seconds
        /// </summary>
        public int? RequestTimeOut { get; set; } = null;

        /// <summary>
        /// Add the number of retry into request header with name X-Client-Retry-Count
        /// First request contains 0
        /// </summary>
        public bool? AddRetryCountToHeaders { get; set; } = null;

        /// <summary>
        /// Set a retry logic handler object for this policy.
        /// </summary>
        public IRetryLogicHandler? RetryLogicHandler { get; set; } = null;

        /// <summary>
        /// Merge current policy with other policy specified in parameter.
        /// Each value will be merge if the value in other policy is not null, and different from current policy.
        /// Returns a new policy with combined value from both policies.
        /// </summary>
        /// <param name="policy">The other policy</param>
        /// <returns>New policy</returns>
        public HttpClientPolicy MergeWith(HttpClientPolicy policy)
        {
            HttpClientPolicy newPol = new HttpClientPolicy();

            if (policy.RetryOnException != null)
                newPol.RetryOnException = (this.RetryOnException != policy.RetryOnException
                    ? policy.RetryOnException : this.RetryOnException);

            if (policy.MaxRetryCount != null)
                newPol.MaxRetryCount = (this.MaxRetryCount != policy.MaxRetryCount
                    ? policy.MaxRetryCount : this.MaxRetryCount);

            if (policy.RetryInterval != null)
                newPol.RetryInterval = (this.RetryInterval != policy.RetryInterval
                    ? policy.RetryInterval : this.RetryInterval);

            if (policy.IntervalType != null)
                newPol.IntervalType = (this.IntervalType != policy.IntervalType
                    ? policy.IntervalType : this.IntervalType);

            if (policy.RequestTimeOut != null)
                newPol.RequestTimeOut = (this.RequestTimeOut != policy.RequestTimeOut
                    ? policy.RequestTimeOut : this.RequestTimeOut);

            if (policy.AddRetryCountToHeaders != null)
                newPol.AddRetryCountToHeaders = (this.AddRetryCountToHeaders != policy.AddRetryCountToHeaders
                    ? policy.AddRetryCountToHeaders : this.AddRetryCountToHeaders);

            return newPol;
        }
    }
}
