// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonSsoConfigPatchReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("googleKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? GoogleKey { get; set; }

        [JsonPropertyName("groupConfigs")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<AccountcommonGroupAndRoleMappingForPatch>? GroupConfigs { get; set; }

    }

    public class AccountcommonSsoConfigPatchReq<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("googleKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? GoogleKey { get; set; }

        [JsonPropertyName("groupConfigs")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<AccountcommonGroupAndRoleMappingForPatch>? GroupConfigs { get; set; }

    }

}