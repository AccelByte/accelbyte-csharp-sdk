// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonClientModulePermission : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("moduleId")]
        public string? ModuleId { get; set; }

        [JsonPropertyName("selectedGroups")]
        public List<AccountcommonClientSelectedGroup>? SelectedGroups { get; set; }

    }


}