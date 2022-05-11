// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Client
{
    public class ResponseCodeCheckLogicHandler : IRetryLogicHandler
    {
        public List<int> ResponseCodes { get; private set; }

        /// <summary>
        /// Parse comma separated values. For code range, use minus sign to denote range.
        /// You can mix single value and ranged values.
        /// For example: 401, 410-420
        /// </summary>
        /// <param name="integers">integer list in comma separated string format</param>
        /// <returns>List of integers</returns>
        /// <exception cref="InvalidCastException"></exception>
        protected List<int> TranslateIntegerListStringToList(string integers)
        {
            List<int> final = new List<int>();
            List<string> parts = new List<string>(integers.Trim().Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
            foreach (string part in parts)
            {
                string[] rangeParts = part.Trim().Split('-', 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                if (rangeParts.Length == 2)
                {
                    int lowerBound = 0;
                    if (!int.TryParse(rangeParts[0], out lowerBound))
                        throw new InvalidCastException("Invalid integer list value [" + rangeParts[0] + "].");
                    int upperBound = 0;
                    if (!int.TryParse(rangeParts[1], out upperBound))
                        throw new InvalidCastException("Invalid integer list value [" + rangeParts[1] + "].");
                    for (int i = lowerBound; i <= upperBound; i++)
                        final.Add(i);
                }
                else if (rangeParts.Length == 1)
                {
                    int theValue = 0;
                    if (!int.TryParse(rangeParts[0], out theValue))
                        throw new InvalidCastException("Invalid integer list value [" + rangeParts[0] + "].");
                    final.Add(theValue);
                }
            }
            return final;
        }

        public ResponseCodeCheckLogicHandler(string codes)
        {
            ResponseCodes = TranslateIntegerListStringToList(codes);
        }

        public bool ExecuteRetryLogic(HttpClientPolicy policy, int retryCount, Exception exception)
        {
            if (!policy.RetryOnException!.Value)
                return false;

            if (retryCount >= policy.MaxRetryCount)
                return false;

            if (exception is HttpResponseException)
            {
                int statusCode = (int)((HttpResponseException)exception).StatusCode;
                if (!ResponseCodes.Contains(statusCode))
                    return false;
            }

            if (policy.IntervalType == RetryIntervalType.Linear)
                Thread.Sleep(policy.RetryInterval!.Value);
            else if (policy.IntervalType == RetryIntervalType.Exponential)
            {
                int nextDelay = (policy.RetryInterval!.Value * retryCount);
                Thread.Sleep(nextDelay);
            }

            return true;
        }
    }
}
