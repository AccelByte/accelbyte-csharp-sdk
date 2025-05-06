// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    public class NewTestPlayer : ITestPlayer
    {
        private string _UserName = String.Empty;

        private readonly bool _DeleteOnLogout;

        private readonly DefaultTokenRepository _TokenRepo;

        private readonly AccelByteSDK _SdkClient;

        private readonly AccelByteSDK _Sdk;

        public string AccessToken
        {
            get => _TokenRepo.Token;
        }

        public string UserId { get; private set; } = String.Empty;

        public static string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            string chars = "0123456789";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Create an ITestPlayer object by creating a new user via IAM.
        /// </summary>
        /// <param name="sdkClient">AccelByteSDK object with necessary access and permission to create a user.</param>
        /// <param name="deleteOnLogout">Set true to delete the created user on logout.</param>
        public NewTestPlayer(AccelByteSDK sdkClient, bool deleteOnLogout)
        {
            _DeleteOnLogout = deleteOnLogout;
            _SdkClient = sdkClient;

            _UserName = ("csharpsdk_" + Helper.GenerateRandomId(8));
            string user_password = Helper.GenerateRandomPassword(10);
            string user_email = $"{_UserName}@dummy.com";

            AccountCreateTestUserRequestV4 newUser = new()
            {
                Verified = true,
                AuthType = "EMAILPASSWD",
                Username = _UserName,
                EmailAddress = user_email,
                Password = user_password,
                Country = "ID",
                DateOfBirth = "1995-01-10",
                DisplayName = $"Extend SDK Test Player {GenerateRandomNumber(3)}",
                UniqueDisplayName = _UserName
            };

            AccountCreateUserResponseV4? cuResp = sdkClient.Iam.UsersV4.PublicCreateTestUserV4Op
                .Execute(newUser, sdkClient.Namespace);
            if (cuResp != null)
                UserId = cuResp.UserId!;

            _TokenRepo = new DefaultTokenRepository();
            _Sdk = AccelByteSDK.Builder
                .UseDefaultConfigRepository()
                .UseDefaultHttpClient()
                .SetTokenRepository(_TokenRepo)
                .Build();

            _Sdk.LoginUser(user_email, user_password);
        }

        public void Login() { }

        public void Logout()
        {
            _Sdk.Logout();
            if (_DeleteOnLogout)
                _SdkClient.Iam.Users.AdminDeleteUserInformationV3Op.Execute(_SdkClient.Namespace, UserId);
        }

        public void Run(Action<AccelByteSDK, ITestPlayer> action)
        {
            action.Invoke(_Sdk, this);
        }
    }
}