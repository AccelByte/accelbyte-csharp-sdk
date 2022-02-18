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
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class WebSocketEventAttribute : Attribute
    {
        public string Name { get; internal set; }

        public WebSocketEventAttribute(string name)
        {
            Name = name;
        }
    }
}