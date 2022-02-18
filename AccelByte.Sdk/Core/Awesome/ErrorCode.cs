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
    public class ErrorCode
    {
        public int Code { get; private set; }

        public string Message { get; private set; }

        public static readonly ErrorCode None = new(0, "");

        public static readonly ErrorCode MessageFieldTypeNotSupported = new(14015, "Serialization for expected field type is not supported.");

        public static readonly ErrorCode MessageFormatInvalid = new(14016, "Message is not well formed.");

        public static readonly ErrorCode MessageFieldDoesNotExist = new(14017, "Expected message field cannot be found.");

        public static readonly ErrorCode MessageFieldConversionFailed = new(14018, "Message field value cannot be converted to expected field type.");

        public static readonly ErrorCode MessageCannotBeSent = new(14019, "Sending message to server failed.");

        public static readonly ErrorCode MessageTypeNotSupported = new(14020, "Unsupported type of message.");

        public static readonly ErrorCode ErrorFromMessage = new(999999, "Error from message.");

        private ErrorCode(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}