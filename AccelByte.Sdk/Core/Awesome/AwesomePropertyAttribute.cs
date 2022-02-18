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
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AwesomePropertyAttribute : Attribute
    {
        public string Name { get; set; } = String.Empty;

        public AwesomePropertyAttribute(string name)
        {
            Name = name;
        }
    }
}