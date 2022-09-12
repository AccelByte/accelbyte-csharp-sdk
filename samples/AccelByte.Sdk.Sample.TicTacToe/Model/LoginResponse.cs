// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Sample.TicTacToe.Model
{
    public class LoginResponse
    {
        public string AccessToken { get; set; } = String.Empty;

        public string access_token { get => AccessToken; }
    }
}