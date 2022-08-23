// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class APIException : Exception
    {
        public int ResponseCode { get; private set; }

        public int StatusCode { get; private set; }

        public APIException(string message, int responseCode = 0, int statusCode = 500)
            : base(message)
        {
            ResponseCode = responseCode;
            StatusCode = statusCode;
        }
    }
}