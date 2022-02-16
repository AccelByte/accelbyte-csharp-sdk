// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonListUsersWithPlatformAccountsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<AccountcommonUserWithPlatformAccounts>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
        [JsonPropertyName("totalData")]
        public long? TotalData { get; set; }
        
    }
}