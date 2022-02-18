// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Awesome
{
    public class MessageException : Exception
    {
        public int Code { get; private set; }

        public MessageException(ErrorCode errorCode) :
            base(errorCode.Message)
        {
            Code = errorCode.Code;
        }

        public MessageException(ErrorCode errorCode, int customCode) :
            base(errorCode.Message)
        {
            Code = customCode;
        }
    }
}