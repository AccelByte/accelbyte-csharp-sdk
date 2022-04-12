// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Converters
{
    public class JsonDateTimeConverterAttribute : JsonConverterAttribute
    {
        private string _Format;

        public JsonDateTimeConverterAttribute(string format)
        {
            _Format = format;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert)
        {
            return new FormattedDateTimeJsonConverter(_Format);
        }
    }
}