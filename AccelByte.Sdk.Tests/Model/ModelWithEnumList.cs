// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Tests.Model
{
    public class ModelWithEnumList
    {
        [JsonStringEnum]
        public ModelWithEnumListAggregate? Aggregate { get; set; }

        public string? Namespace { get; set; }
        
        public string? Region { get; set; }

        [JsonStringEnum]
        public List<ModelWithEnumListSpecials>? Specials { get; set; }
    }

    public class ModelWithEnumListAggregate : StringEnum<ModelWithEnumListAggregate>
    {
        public static readonly ModelWithEnumListAggregate XSOLLA
            = new ModelWithEnumListAggregate("XSOLLA");

        public static readonly ModelWithEnumListAggregate ADYEN
            = new ModelWithEnumListAggregate("ADYEN");


        public static implicit operator ModelWithEnumListAggregate(string value)
        {
            return Create(value);
        }

        public ModelWithEnumListAggregate(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelWithEnumListSpecials : StringEnum<ModelWithEnumListSpecials>
    {
        public static readonly ModelWithEnumListSpecials WALLET
            = new ModelWithEnumListSpecials("WALLET");

        public static readonly ModelWithEnumListSpecials XSOLLA
            = new ModelWithEnumListSpecials("XSOLLA");

        public static readonly ModelWithEnumListSpecials ADYEN
            = new ModelWithEnumListSpecials("ADYEN");

        public static readonly ModelWithEnumListSpecials STRIPE
            = new ModelWithEnumListSpecials("STRIPE");

        public static readonly ModelWithEnumListSpecials CHECKOUT
            = new ModelWithEnumListSpecials("CHECKOUT");

        public static readonly ModelWithEnumListSpecials ALIPAY
            = new ModelWithEnumListSpecials("ALIPAY");

        public static readonly ModelWithEnumListSpecials WXPAY
            = new ModelWithEnumListSpecials("WXPAY");

        public static readonly ModelWithEnumListSpecials PAYPAL
            = new ModelWithEnumListSpecials("PAYPAL");


        public static implicit operator ModelWithEnumListSpecials(string value)
        {
            return Create(value);
        }

        public ModelWithEnumListSpecials(string enumValue)
            : base(enumValue)
        {

        }
    }
}