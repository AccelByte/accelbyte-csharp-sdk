// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Util
{
    public class IncompleteComponentException : Exception
    {
        public static IncompleteComponentException NoHttpClient { get => new IncompleteComponentException("No HttpClient component."); }

        public static IncompleteComponentException NoConfigRepository { get => new IncompleteComponentException("No config repository component."); }

        public static IncompleteComponentException NoTokenRepository { get => new IncompleteComponentException("No token repository component."); }


        public IncompleteComponentException(string message)
            : base(message)
        {

        }
    }
}