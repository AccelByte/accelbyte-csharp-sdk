// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class NamespaceStatusUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        [JsonStringEnum]
        public NamespaceStatusUpdateStatus? Status { get; set; }

    }

    public class NamespaceStatusUpdateStatus : StringEnum<NamespaceStatusUpdateStatus>
    {
        public static readonly NamespaceStatusUpdateStatus ACTIVE
            = new NamespaceStatusUpdateStatus("ACTIVE");

        public static readonly NamespaceStatusUpdateStatus INACTIVE
            = new NamespaceStatusUpdateStatus("INACTIVE");


        public static implicit operator NamespaceStatusUpdateStatus(string value)
        {
            return Create(value);
        }

        public NamespaceStatusUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}