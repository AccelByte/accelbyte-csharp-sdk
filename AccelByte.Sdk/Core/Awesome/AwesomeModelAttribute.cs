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
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class AwesomeModelAttribute : Attribute
    {
        public string Name { get; set; } = String.Empty;

        public AwesomeModelAttribute(string name)
        {
            Name = name;
        }
    }
}
