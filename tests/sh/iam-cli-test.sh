#!/usr/bin/env bash

# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

# Meta:
# - random seed: 512
# - template file: cli-test.j2

# Instructions:
# - Run the Justice SDK Mock Server first before running this script.

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_NAMESPACE="test"
export AB_APP_NAME="UnitTest"

EXIT_CODE=0

eval_tap() {
  if [ $1 -eq 0 ]; then
    echo "ok $2 - $3"
  else
    EXIT_CODE=1
    echo "not ok $2 - $3"
    sed 's/^/# /g' $4
  fi
  rm -f $4
}

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"

echo "TAP version 13"
echo "1..299"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetBansType
$CLI_EXE \
    --sn iam \
    --op GetBansType \
    > test.out 2>&1
eval_tap $? 2 'GetBansType' test.out

#- 3 GetListBanReason
$CLI_EXE \
    --sn iam \
    --op GetListBanReason \
    > test.out 2>&1
eval_tap $? 3 'GetListBanReason' test.out

#- 4 GetClients
eval_tap 0 4 'GetClients # SKIP deprecated' test.out

#- 5 CreateClient
eval_tap 0 5 'CreateClient # SKIP deprecated' test.out

#- 6 GetClient
$CLI_EXE \
    --sn iam \
    --op GetClient \
    --clientId 'b0Cjv4Ax' \
    > test.out 2>&1
eval_tap $? 6 'GetClient' test.out

#- 7 UpdateClient
# body param: body
echo '{"ClientName": "7NzYkopp", "RedirectUri": "a0VgFJAh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateClient \
    --clientId 'HwTb5q01' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateClient' test.out

#- 8 DeleteClient
eval_tap 0 8 'DeleteClient # SKIP deprecated' test.out

#- 9 UpdateClientPermission
# body param: body
echo '{"Permissions": [{"Action": 12, "Resource": "N2MQrbpe"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateClientPermission \
    --clientId 'RnxTlCTF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateClientPermission' test.out

#- 10 AddClientPermission
$CLI_EXE \
    --sn iam \
    --op AddClientPermission \
    --action '89' \
    --clientId 'MIbl1a2j' \
    --resource 'XLCtWmHJ' \
    > test.out 2>&1
eval_tap $? 10 'AddClientPermission' test.out

#- 11 DeleteClientPermission
$CLI_EXE \
    --sn iam \
    --op DeleteClientPermission \
    --action '54' \
    --clientId 'i9SoMkSE' \
    --resource '4eJelwO4' \
    > test.out 2>&1
eval_tap $? 11 'DeleteClientPermission' test.out

#- 12 UpdateClientSecret
# body param: body
echo '{"NewSecret": "KPMky2h8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateClientSecret \
    --clientId 'R2fIXoXP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateClientSecret' test.out

#- 13 GetClientsbyNamespace
$CLI_EXE \
    --sn iam \
    --op GetClientsbyNamespace \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetClientsbyNamespace' test.out

#- 14 CreateClientByNamespace
# body param: body
echo '{"ClientId": "8gd7JUab", "ClientName": "Yc3GMbxT", "ClientPermissions": [{"Action": 22, "Resource": "m1fsu6J3", "SchedAction": 57, "SchedCron": "4s5ppGR9", "SchedRange": ["XcoxYTGg"]}], "Namespace": "ewrLfwvz", "RedirectUri": "JF4TpbNh", "Secret": "Kq2xdmgE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateClientByNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreateClientByNamespace' test.out

#- 15 DeleteClientByNamespace
$CLI_EXE \
    --sn iam \
    --op DeleteClientByNamespace \
    --clientId 'BepFHtf6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DeleteClientByNamespace' test.out

#- 16 CreateUser
# body param: body
echo '{"AuthType": "ZiegqdEL", "Country": "4fsM6nBz", "DisplayName": "RVuC1r7U", "LoginId": "H1Liu7UQ", "Password": "0304McK8", "PasswordMD5Sum": "73tRtr5c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUser \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'CreateUser' test.out

#- 17 GetAdminUsersByRoleID
$CLI_EXE \
    --sn iam \
    --op GetAdminUsersByRoleID \
    --namespace $AB_NAMESPACE \
    --after '11' \
    --before '97' \
    --limit '80' \
    --roleId '5JJ2c6vs' \
    > test.out 2>&1
eval_tap $? 17 'GetAdminUsersByRoleID' test.out

#- 18 GetUserByLoginID
$CLI_EXE \
    --sn iam \
    --op GetUserByLoginID \
    --namespace $AB_NAMESPACE \
    --loginId 'Ons4jNWG' \
    > test.out 2>&1
eval_tap $? 18 'GetUserByLoginID' test.out

#- 19 GetUserByPlatformUserID
$CLI_EXE \
    --sn iam \
    --op GetUserByPlatformUserID \
    --namespace $AB_NAMESPACE \
    --platformID 'c7CiUa4w' \
    --platformUserID 'M5Eu3Vqy' \
    > test.out 2>&1
eval_tap $? 19 'GetUserByPlatformUserID' test.out

#- 20 ForgotPassword
# body param: body
echo '{"Context": "msFXporM", "LanguageTag": "qEDR8E72", "LoginID": "XMKfhl6e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op ForgotPassword \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'ForgotPassword' test.out

#- 21 GetUsersByLoginIds
$CLI_EXE \
    --sn iam \
    --op GetUsersByLoginIds \
    --namespace $AB_NAMESPACE \
    --loginIds 'q2FzU3VL' \
    > test.out 2>&1
eval_tap $? 21 'GetUsersByLoginIds' test.out

#- 22 ResetPassword
# body param: body
echo '{"Code": "3LNmPLeZ", "LoginID": "doCXfabF", "NewPassword": "XzvjLmai"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op ResetPassword \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'ResetPassword' test.out

#- 23 SearchUser
eval_tap 0 23 'SearchUser # SKIP deprecated' test.out

#- 24 GetUserByUserID
$CLI_EXE \
    --sn iam \
    --op GetUserByUserID \
    --namespace $AB_NAMESPACE \
    --userId '7fPKvE2Z' \
    > test.out 2>&1
eval_tap $? 24 'GetUserByUserID' test.out

#- 25 UpdateUser
# body param: body
echo '{"Country": "4a63UVtL", "DateOfBirth": "bQSWtsyz", "DisplayName": "0mGGyHHF", "LanguageTag": "IlIKsXgv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateUser \
    --namespace $AB_NAMESPACE \
    --userId 'SrkEgTYV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateUser' test.out

#- 26 DeleteUser
$CLI_EXE \
    --sn iam \
    --op DeleteUser \
    --namespace $AB_NAMESPACE \
    --userId 'k5iRBE6z' \
    > test.out 2>&1
eval_tap $? 26 'DeleteUser' test.out

#- 27 BanUser
# body param: body
echo '{"ban": "JJ1BRHrf", "comment": "CHqqp2Gw", "endDate": "PcmzSuY8", "reason": "w9VYwBEf", "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op BanUser \
    --namespace $AB_NAMESPACE \
    --userId 'ZLfpVFfD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'BanUser' test.out

#- 28 GetUserBanHistory
$CLI_EXE \
    --sn iam \
    --op GetUserBanHistory \
    --namespace $AB_NAMESPACE \
    --userId 'wjHHCW2g' \
    > test.out 2>&1
eval_tap $? 28 'GetUserBanHistory' test.out

#- 29 DisableUserBan
$CLI_EXE \
    --sn iam \
    --op DisableUserBan \
    --banId '5u8z9yrp' \
    --namespace $AB_NAMESPACE \
    --userId 'JdIx5vvH' \
    > test.out 2>&1
eval_tap $? 29 'DisableUserBan' test.out

#- 30 EnableUserBan
$CLI_EXE \
    --sn iam \
    --op EnableUserBan \
    --banId 'S3d6PKPE' \
    --namespace $AB_NAMESPACE \
    --userId '27mI6Px8' \
    > test.out 2>&1
eval_tap $? 30 'EnableUserBan' test.out

#- 31 ListCrossNamespaceAccountLink
eval_tap 0 31 'ListCrossNamespaceAccountLink # SKIP deprecated' test.out

#- 32 DisableUser
eval_tap 0 32 'DisableUser # SKIP deprecated' test.out

#- 33 EnableUser
eval_tap 0 33 'EnableUser # SKIP deprecated' test.out

#- 34 GetUserInformation
$CLI_EXE \
    --sn iam \
    --op GetUserInformation \
    --namespace $AB_NAMESPACE \
    --userId 'jt8Lq4x0' \
    > test.out 2>&1
eval_tap $? 34 'GetUserInformation' test.out

#- 35 DeleteUserInformation
$CLI_EXE \
    --sn iam \
    --op DeleteUserInformation \
    --namespace $AB_NAMESPACE \
    --userId 'F7Ncocel' \
    > test.out 2>&1
eval_tap $? 35 'DeleteUserInformation' test.out

#- 36 GetUserLoginHistories
$CLI_EXE \
    --sn iam \
    --op GetUserLoginHistories \
    --namespace $AB_NAMESPACE \
    --userId 'JjtlKYu8' \
    --after '0.1327360902074043' \
    --before '0.6426606729236638' \
    --limit '26' \
    > test.out 2>&1
eval_tap $? 36 'GetUserLoginHistories' test.out

#- 37 UpdatePassword
eval_tap 0 37 'UpdatePassword # SKIP deprecated' test.out

#- 38 SaveUserPermission
# body param: body
echo '{"Permissions": [{"Action": 47, "Resource": "0s5TzT51", "SchedAction": 28, "SchedCron": "V4HTmivm", "SchedRange": ["b6tPmCir"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SaveUserPermission \
    --namespace $AB_NAMESPACE \
    --userId 'khYvcOUu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'SaveUserPermission' test.out

#- 39 AddUserPermission
# body param: body
echo '{"SchedAction": 5, "SchedCron": "jPWGwPsv", "SchedRange": ["jLK1CjPt"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddUserPermission \
    --action '40' \
    --namespace $AB_NAMESPACE \
    --resource 'tbMkpUFH' \
    --userId 'T0fL9q9S' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AddUserPermission' test.out

#- 40 DeleteUserPermission
$CLI_EXE \
    --sn iam \
    --op DeleteUserPermission \
    --action '77' \
    --namespace $AB_NAMESPACE \
    --resource 'NAUQVoiQ' \
    --userId 'tSQC2kNS' \
    > test.out 2>&1
eval_tap $? 40 'DeleteUserPermission' test.out

#- 41 GetUserPlatformAccounts
$CLI_EXE \
    --sn iam \
    --op GetUserPlatformAccounts \
    --namespace $AB_NAMESPACE \
    --userId 'smT0d2aB' \
    > test.out 2>&1
eval_tap $? 41 'GetUserPlatformAccounts' test.out

#- 42 GetUserMapping
$CLI_EXE \
    --sn iam \
    --op GetUserMapping \
    --namespace $AB_NAMESPACE \
    --targetNamespace 'G4zA2zp1' \
    --userId 'Ls0bD6dG' \
    > test.out 2>&1
eval_tap $? 42 'GetUserMapping' test.out

#- 43 GetUserJusticePlatformAccount
eval_tap 0 43 'GetUserJusticePlatformAccount # SKIP deprecated' test.out

#- 44 PlatformLink
$CLI_EXE \
    --sn iam \
    --op PlatformLink \
    --namespace $AB_NAMESPACE \
    --platformId 'gwkYgHzK' \
    --userId 'uI2RJrbo' \
    --ticket 'P7kfpIle' \
    > test.out 2>&1
eval_tap $? 44 'PlatformLink' test.out

#- 45 PlatformUnlink
$CLI_EXE \
    --sn iam \
    --op PlatformUnlink \
    --namespace $AB_NAMESPACE \
    --platformId 'tXrCK1UV' \
    --userId 'O0jcs7nC' \
    --platform_namespace 'qsodoTFT' \
    > test.out 2>&1
eval_tap $? 45 'PlatformUnlink' test.out

#- 46 GetPublisherUser
$CLI_EXE \
    --sn iam \
    --op GetPublisherUser \
    --namespace $AB_NAMESPACE \
    --userId 'cWlaIBJA' \
    > test.out 2>&1
eval_tap $? 46 'GetPublisherUser' test.out

#- 47 SaveUserRoles
# body param: body
echo '["AknU6Hob"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SaveUserRoles \
    --namespace $AB_NAMESPACE \
    --userId 'ZgWlaLne' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'SaveUserRoles' test.out

#- 48 AddUserRole
$CLI_EXE \
    --sn iam \
    --op AddUserRole \
    --namespace $AB_NAMESPACE \
    --roleId 'dDfasTc8' \
    --userId 'gr2znWqD' \
    > test.out 2>&1
eval_tap $? 48 'AddUserRole' test.out

#- 49 DeleteUserRole
$CLI_EXE \
    --sn iam \
    --op DeleteUserRole \
    --namespace $AB_NAMESPACE \
    --roleId '6tIcfI5Z' \
    --userId '4tUNQ7mQ' \
    > test.out 2>&1
eval_tap $? 49 'DeleteUserRole' test.out

#- 50 UpgradeHeadlessAccount
# body param: body
echo '{"LoginID": "PjCalZgF", "Password": "VEQyqav0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpgradeHeadlessAccount \
    --namespace $AB_NAMESPACE \
    --userId '9OYmxCvM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpgradeHeadlessAccount' test.out

#- 51 UpgradeHeadlessAccountWithVerificationCode
# body param: body
echo '{"Code": "qVcXs2Oq", "Password": "Nz8ZLBsn", "loginId": "cbRrf6uE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpgradeHeadlessAccountWithVerificationCode \
    --namespace $AB_NAMESPACE \
    --userId 'djUnr04W' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpgradeHeadlessAccountWithVerificationCode' test.out

#- 52 UserVerification
# body param: body
echo '{"Code": "ZNhgEGvq", "ContactType": "KWQTkE65", "LanguageTag": "j6186p0W", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UserVerification \
    --namespace $AB_NAMESPACE \
    --userId 'snWZuUPs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'UserVerification' test.out

#- 53 SendVerificationCode
# body param: body
echo '{"Context": "aRnVdrdB", "LanguageTag": "A2hXwYyz", "LoginID": "ZMdlR4cL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SendVerificationCode \
    --namespace $AB_NAMESPACE \
    --userId '76hnFDgT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'SendVerificationCode' test.out

#- 54 Authorization
$CLI_EXE \
    --sn iam \
    --op Authorization \
    --login 'fofHdfoS' \
    --password 'qDcaFhOc' \
    --scope '1oKxI8f5' \
    --state 'ocfy4EIx' \
    --client_id 'wBiB90vd' \
    --redirect_uri 'gS5YpKsd' \
    --response_type 'code' \
    > test.out 2>&1
eval_tap $? 54 'Authorization' test.out

#- 55 GetJWKS
$CLI_EXE \
    --sn iam \
    --op GetJWKS \
    > test.out 2>&1
eval_tap $? 55 'GetJWKS' test.out

#- 56 PlatformTokenRequestHandler
eval_tap 0 56 'PlatformTokenRequestHandler # SKIP deprecated' test.out

#- 57 RevokeUser
$CLI_EXE \
    --sn iam \
    --op RevokeUser \
    --namespace $AB_NAMESPACE \
    --userId 'piU2UfyM' \
    > test.out 2>&1
eval_tap $? 57 'RevokeUser' test.out

#- 58 GetRevocationList
$CLI_EXE \
    --sn iam \
    --op GetRevocationList \
    > test.out 2>&1
eval_tap $? 58 'GetRevocationList' test.out

#- 59 RevokeToken
eval_tap 0 59 'RevokeToken # SKIP deprecated' test.out

#- 60 RevokeAUser
eval_tap 0 60 'RevokeAUser # SKIP deprecated' test.out

#- 61 TokenGrant
$CLI_EXE \
    --sn iam \
    --op TokenGrant \
    --code 'O4DhL9fB' \
    --extend_exp 'True' \
    --namespace 'jBOUn3bY' \
    --password 'f5ouXqkb' \
    --redirect_uri 'iExqT6Dk' \
    --refresh_token '9QFqaAjh' \
    --username 'wOI1P04d' \
    --grant_type 'authorization_code' \
    > test.out 2>&1
eval_tap $? 61 'TokenGrant' test.out

#- 62 VerifyToken
$CLI_EXE \
    --sn iam \
    --op VerifyToken \
    --token 'TwrxBRfM' \
    > test.out 2>&1
eval_tap $? 62 'VerifyToken' test.out

#- 63 GetRoles
$CLI_EXE \
    --sn iam \
    --op GetRoles \
    --isWildcard 'xZrSfx3V' \
    > test.out 2>&1
eval_tap $? 63 'GetRoles' test.out

#- 64 CreateRole
# body param: body
echo '{"AdminRole": false, "Managers": [{"DisplayName": "Mng7p2Sy", "Namespace": "FDEnmYQz", "UserId": "ehPBqD12"}], "Members": [{"DisplayName": "DvvzNNZS", "Namespace": "u5zZVgY3", "UserId": "Zosfd01v"}], "Permissions": [{"Action": 0, "Resource": "OGweHacv", "SchedAction": 66, "SchedCron": "RV345xB8", "SchedRange": ["hos4yaOB"]}], "RoleName": "jMxizCxx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateRole \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'CreateRole' test.out

#- 65 GetRole
$CLI_EXE \
    --sn iam \
    --op GetRole \
    --roleId '9qTOIKlp' \
    > test.out 2>&1
eval_tap $? 65 'GetRole' test.out

#- 66 UpdateRole
# body param: body
echo '{"RoleName": "drqo2smD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateRole \
    --roleId '9RPpjOWK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'UpdateRole' test.out

#- 67 DeleteRole
$CLI_EXE \
    --sn iam \
    --op DeleteRole \
    --roleId '0k76i1g7' \
    > test.out 2>&1
eval_tap $? 67 'DeleteRole' test.out

#- 68 GetRoleAdminStatus
$CLI_EXE \
    --sn iam \
    --op GetRoleAdminStatus \
    --roleId 'rYaEuNCy' \
    > test.out 2>&1
eval_tap $? 68 'GetRoleAdminStatus' test.out

#- 69 SetRoleAsAdmin
$CLI_EXE \
    --sn iam \
    --op SetRoleAsAdmin \
    --roleId 'PoQ0oHYX' \
    > test.out 2>&1
eval_tap $? 69 'SetRoleAsAdmin' test.out

#- 70 RemoveRoleAdmin
$CLI_EXE \
    --sn iam \
    --op RemoveRoleAdmin \
    --roleId 'UQdtIkAk' \
    > test.out 2>&1
eval_tap $? 70 'RemoveRoleAdmin' test.out

#- 71 GetRoleManagers
$CLI_EXE \
    --sn iam \
    --op GetRoleManagers \
    --roleId 'ltd1zQBz' \
    > test.out 2>&1
eval_tap $? 71 'GetRoleManagers' test.out

#- 72 AddRoleManagers
# body param: body
echo '{"Managers": [{"DisplayName": "zC6ldKri", "Namespace": "I6lTRbc1", "UserId": "Z1HJHzl3"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddRoleManagers \
    --roleId '23Ynwf5P' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'AddRoleManagers' test.out

#- 73 RemoveRoleManagers
# body param: body
echo '{"Managers": [{"DisplayName": "vGejCDgA", "Namespace": "r1pXDcsH", "UserId": "nobnaYxG"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op RemoveRoleManagers \
    --roleId 'h3FovBnr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'RemoveRoleManagers' test.out

#- 74 GetRoleMembers
$CLI_EXE \
    --sn iam \
    --op GetRoleMembers \
    --roleId '5VUOHGqE' \
    > test.out 2>&1
eval_tap $? 74 'GetRoleMembers' test.out

#- 75 AddRoleMembers
# body param: body
echo '{"Members": [{"DisplayName": "cuJYo3Yf", "Namespace": "MDw4PaBK", "UserId": "sFXorxY0"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddRoleMembers \
    --roleId 'ahG5AgHr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'AddRoleMembers' test.out

#- 76 RemoveRoleMembers
# body param: body
echo '{"Members": [{"DisplayName": "E98qQTSX", "Namespace": "h1W7MnK2", "UserId": "i8Ely255"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op RemoveRoleMembers \
    --roleId 'awvulbNG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'RemoveRoleMembers' test.out

#- 77 UpdateRolePermissions
# body param: body
echo '{"Permissions": [{"Action": 88, "Resource": "AjeiiANE", "SchedAction": 90, "SchedCron": "lkncKPmr", "SchedRange": ["i36MY2aV"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateRolePermissions \
    --roleId 'CNUJgcpA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'UpdateRolePermissions' test.out

#- 78 AddRolePermission
# body param: body
echo '{"SchedAction": 3, "SchedCron": "j0fidlWP", "SchedRange": ["SAIjaw5H"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddRolePermission \
    --action '89' \
    --resource 'yDsQqMUP' \
    --roleId 'rAxUd1bm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'AddRolePermission' test.out

#- 79 DeleteRolePermission
$CLI_EXE \
    --sn iam \
    --op DeleteRolePermission \
    --action '94' \
    --resource 'SM44scgN' \
    --roleId 'AZf7a3R9' \
    > test.out 2>&1
eval_tap $? 79 'DeleteRolePermission' test.out

#- 80 AdminGetAgeRestrictionStatusV2
$CLI_EXE \
    --sn iam \
    --op AdminGetAgeRestrictionStatusV2 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 80 'AdminGetAgeRestrictionStatusV2' test.out

#- 81 AdminUpdateAgeRestrictionConfigV2
# body param: body
echo '{"AgeRestriction": 35, "Enable": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAgeRestrictionConfigV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'AdminUpdateAgeRestrictionConfigV2' test.out

#- 82 GetListCountryAgeRestriction
$CLI_EXE \
    --sn iam \
    --op GetListCountryAgeRestriction \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 82 'GetListCountryAgeRestriction' test.out

#- 83 UpdateCountryAgeRestriction
# body param: body
echo '{"AgeRestriction": 58}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateCountryAgeRestriction \
    --countryCode 'XZ1fahMp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'UpdateCountryAgeRestriction' test.out

#- 84 AdminSearchUsersV2
$CLI_EXE \
    --sn iam \
    --op AdminSearchUsersV2 \
    --namespace $AB_NAMESPACE \
    --after '688Jv5wQ' \
    --before '3hbDlcGR' \
    --displayName 'x2aExmVb' \
    --limit '99' \
    --loginId 'DomWyrFZ' \
    --platformUserId 'ZdM00sSd' \
    --roleId 'UypOvoMv' \
    --userId 'IN7cRBRx' \
    --platformId 'FsCUQz0k' \
    > test.out 2>&1
eval_tap $? 84 'AdminSearchUsersV2' test.out

#- 85 AdminGetUserByUserIdV2
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByUserIdV2 \
    --namespace $AB_NAMESPACE \
    --userId 'oUsUcGfj' \
    > test.out 2>&1
eval_tap $? 85 'AdminGetUserByUserIdV2' test.out

#- 86 AdminUpdateUserV2
# body param: body
echo '{"Country": "tfyuPNb5", "DateOfBirth": "exiRtR1Q", "DisplayName": "e0mxLnvZ", "LanguageTag": "EG2biyKS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV2 \
    --namespace $AB_NAMESPACE \
    --userId '8vfIsZ5E' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'AdminUpdateUserV2' test.out

#- 87 AdminBanUserV2
# body param: body
echo '{"ban": "ADM0xJp6", "comment": "HXexnHAX", "endDate": "YShIg82f", "reason": "fzx6WCUd", "skipNotif": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV2 \
    --namespace $AB_NAMESPACE \
    --userId 'QnivM1tf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'AdminBanUserV2' test.out

#- 88 AdminGetUserBanV2
$CLI_EXE \
    --sn iam \
    --op AdminGetUserBanV2 \
    --namespace $AB_NAMESPACE \
    --userId 'IoSsKaP5' \
    --activeOnly 'False' \
    > test.out 2>&1
eval_tap $? 88 'AdminGetUserBanV2' test.out

#- 89 AdminDisableUserV2
# body param: body
echo '{"Reason": "0UGr95D9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDisableUserV2 \
    --namespace $AB_NAMESPACE \
    --userId 'VatfxBoa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'AdminDisableUserV2' test.out

#- 90 AdminEnableUserV2
$CLI_EXE \
    --sn iam \
    --op AdminEnableUserV2 \
    --namespace $AB_NAMESPACE \
    --userId 'kHUqz2uO' \
    > test.out 2>&1
eval_tap $? 90 'AdminEnableUserV2' test.out

#- 91 AdminResetPasswordV2
# body param: body
echo '{"LanguageTag": "KJVjX7j5", "NewPassword": "MgRZ3kPm", "OldPassword": "SrNaFzJw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminResetPasswordV2 \
    --namespace $AB_NAMESPACE \
    --userId 'BceJQ0vi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'AdminResetPasswordV2' test.out

#- 92 AdminDeletePlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op AdminDeletePlatformLinkV2 \
    --namespace $AB_NAMESPACE \
    --platformId 'EYQy4JxB' \
    --userId 'kyXfgwzM' \
    --platform_namespace 'TAlT2q2E' \
    > test.out 2>&1
eval_tap $? 92 'AdminDeletePlatformLinkV2' test.out

#- 93 AdminPutUserRolesV2
# body param: body
echo '["bG4Z95Sl"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPutUserRolesV2 \
    --namespace $AB_NAMESPACE \
    --userId 'dyWe2X8c' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'AdminPutUserRolesV2' test.out

#- 94 AdminCreateUserRolesV2
# body param: body
echo '["Les0TRTA"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateUserRolesV2 \
    --namespace $AB_NAMESPACE \
    --userId 'ekrfR30I' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'AdminCreateUserRolesV2' test.out

#- 95 PublicGetCountryAgeRestriction
$CLI_EXE \
    --sn iam \
    --op PublicGetCountryAgeRestriction \
    --countryCode 'RA6CzcXF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 95 'PublicGetCountryAgeRestriction' test.out

#- 96 PublicCreateUserV2
# body param: body
echo '{"AuthType": "cjRpu7wV", "Country": "EzbwHvOG", "DisplayName": "qwb7FAI8", "LoginId": "lxDoRtwK", "Password": "NHCncWRy", "PasswordMD5Sum": "VDPNRFIb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateUserV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 96 'PublicCreateUserV2' test.out

#- 97 PublicForgotPasswordV2
# body param: body
echo '{"Context": "OIi021vV", "LanguageTag": "F26yEKnK", "LoginID": "L26vTDvj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicForgotPasswordV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'PublicForgotPasswordV2' test.out

#- 98 PublicResetPasswordV2
# body param: body
echo '{"Code": "jj8aEPjD", "LoginID": "WSwW548h", "NewPassword": "HTuJ1jV4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicResetPasswordV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'PublicResetPasswordV2' test.out

#- 99 PublicGetUserByUserIDV2
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIDV2 \
    --namespace $AB_NAMESPACE \
    --userId 'EKppV4Df' \
    > test.out 2>&1
eval_tap $? 99 'PublicGetUserByUserIDV2' test.out

#- 100 PublicUpdateUserV2
# body param: body
echo '{"Country": "Txfj3AGr", "DateOfBirth": "DhoJooH5", "DisplayName": "WNF4d6DE", "LanguageTag": "LnHRwigr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV2 \
    --namespace $AB_NAMESPACE \
    --userId '039B7fw1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 100 'PublicUpdateUserV2' test.out

#- 101 PublicGetUserBan
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBan \
    --namespace $AB_NAMESPACE \
    --userId 'zHG7KQTr' \
    --activeOnly 'False' \
    > test.out 2>&1
eval_tap $? 101 'PublicGetUserBan' test.out

#- 102 PublicUpdatePasswordV2
# body param: body
echo '{"LanguageTag": "Iv8R1CtN", "NewPassword": "kXpuQ4g9", "OldPassword": "IiLxJpTl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdatePasswordV2 \
    --namespace $AB_NAMESPACE \
    --userId 'IMuKCdAt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 102 'PublicUpdatePasswordV2' test.out

#- 103 GetListJusticePlatformAccounts
$CLI_EXE \
    --sn iam \
    --op GetListJusticePlatformAccounts \
    --namespace $AB_NAMESPACE \
    --userId '0XTdLLO1' \
    > test.out 2>&1
eval_tap $? 103 'GetListJusticePlatformAccounts' test.out

#- 104 PublicPlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV2 \
    --namespace $AB_NAMESPACE \
    --platformId 'WSvdw7FI' \
    --userId '8mOSB2rv' \
    --ticket 'QkdnYlPH' \
    > test.out 2>&1
eval_tap $? 104 'PublicPlatformLinkV2' test.out

#- 105 PublicDeletePlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op PublicDeletePlatformLinkV2 \
    --namespace $AB_NAMESPACE \
    --platformId '6J70BXWV' \
    --userId 'txOyZzUr' \
    --platform_namespace 'VRKRtJuZ' \
    > test.out 2>&1
eval_tap $? 105 'PublicDeletePlatformLinkV2' test.out

#- 106 AdminGetBansTypeV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBansTypeV3 \
    > test.out 2>&1
eval_tap $? 106 'AdminGetBansTypeV3' test.out

#- 107 AdminGetListBanReasonV3
$CLI_EXE \
    --sn iam \
    --op AdminGetListBanReasonV3 \
    > test.out 2>&1
eval_tap $? 107 'AdminGetListBanReasonV3' test.out

#- 108 AdminGetInputValidations
$CLI_EXE \
    --sn iam \
    --op AdminGetInputValidations \
    > test.out 2>&1
eval_tap $? 108 'AdminGetInputValidations' test.out

#- 109 AdminUpdateInputValidations
# body param: body
echo '[{"field": "5W7nPrKt", "validation": {"allowDigit": false, "allowLetter": false, "allowSpace": true, "allowUnicode": true, "description": [{"language": "31jYv883", "message": ["2yIJUngm"]}], "isCustomRegex": true, "letterCase": "Elr5mgz0", "maxLength": 86, "maxRepeatingAlphaNum": 48, "maxRepeatingSpecialCharacter": 65, "minCharType": 88, "minLength": 25, "regex": "nOvu24EF", "specialCharacterLocation": "zSQyIXv2", "specialCharacters": ["yW4Uka5j"]}}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateInputValidations \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 109 'AdminUpdateInputValidations' test.out

#- 110 AdminResetInputValidations
$CLI_EXE \
    --sn iam \
    --op AdminResetInputValidations \
    --field 'sUlAifni' \
    > test.out 2>&1
eval_tap $? 110 'AdminResetInputValidations' test.out

#- 111 ListAdminsV3
$CLI_EXE \
    --sn iam \
    --op ListAdminsV3 \
    --namespace $AB_NAMESPACE \
    --after '52mGYo0B' \
    --before 'jFUSZeNr' \
    --limit '82' \
    > test.out 2>&1
eval_tap $? 111 'ListAdminsV3' test.out

#- 112 AdminGetAgeRestrictionStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetAgeRestrictionStatusV3 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 112 'AdminGetAgeRestrictionStatusV3' test.out

#- 113 AdminUpdateAgeRestrictionConfigV3
# body param: body
echo '{"ageRestriction": 9, "enable": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAgeRestrictionConfigV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 113 'AdminUpdateAgeRestrictionConfigV3' test.out

#- 114 AdminGetListCountryAgeRestrictionV3
$CLI_EXE \
    --sn iam \
    --op AdminGetListCountryAgeRestrictionV3 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 114 'AdminGetListCountryAgeRestrictionV3' test.out

#- 115 AdminUpdateCountryAgeRestrictionV3
# body param: body
echo '{"ageRestriction": 93}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateCountryAgeRestrictionV3 \
    --countryCode 'a0UxaP0K' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 115 'AdminUpdateCountryAgeRestrictionV3' test.out

#- 116 AdminGetBannedUsersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBannedUsersV3 \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --banType 'v68OsqOU' \
    --limit '90' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 116 'AdminGetBannedUsersV3' test.out

#- 117 AdminGetBansTypeWithNamespaceV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBansTypeWithNamespaceV3 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 117 'AdminGetBansTypeWithNamespaceV3' test.out

#- 118 AdminGetClientsByNamespaceV3
$CLI_EXE \
    --sn iam \
    --op AdminGetClientsByNamespaceV3 \
    --namespace $AB_NAMESPACE \
    --limit '98' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 118 'AdminGetClientsByNamespaceV3' test.out

#- 119 AdminCreateClientV3
# body param: body
echo '{"audiences": ["elychmgj"], "baseUri": "LvnOWOk5", "clientId": "AekVVmTI", "clientName": "EG2ppf1f", "clientPermissions": [{"action": 66, "resource": "3NwfEQkd", "schedAction": 51, "schedCron": "I8JQzAp0", "schedRange": ["rF8gvdnF"]}], "deletable": true, "namespace": "MvoXLWNo", "oauthClientType": "QZhvPg7V", "redirectUri": "X5rUNWJa", "secret": "q1fjgDyp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateClientV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 119 'AdminCreateClientV3' test.out

#- 120 AdminGetClientsbyNamespacebyIDV3
$CLI_EXE \
    --sn iam \
    --op AdminGetClientsbyNamespacebyIDV3 \
    --clientId 'xO4ufKfU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 120 'AdminGetClientsbyNamespacebyIDV3' test.out

#- 121 AdminDeleteClientV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteClientV3 \
    --clientId '7OumxSk0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 121 'AdminDeleteClientV3' test.out

#- 122 AdminUpdateClientV3
# body param: body
echo '{"audiences": ["Ebju4dSL"], "baseUri": "x4vsb6rx", "clientName": "9Xxsu8TJ", "clientPermissions": [{"action": 66, "resource": "pdZVC6y6", "schedAction": 2, "schedCron": "9fQpa7b3", "schedRange": ["6my8LWzM"]}], "deletable": false, "namespace": "njwsIxM4", "redirectUri": "s9m2qWNv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateClientV3 \
    --clientId 'mPPlRULr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 122 'AdminUpdateClientV3' test.out

#- 123 AdminUpdateClientPermissionV3
# body param: body
echo '{"permissions": [{"action": 31, "resource": "PFCzbPX1"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateClientPermissionV3 \
    --clientId 'wwBznD7N' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 123 'AdminUpdateClientPermissionV3' test.out

#- 124 AdminAddClientPermissionsV3
# body param: body
echo '{"permissions": [{"action": 74, "resource": "s7fb4sqW"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddClientPermissionsV3 \
    --clientId 'UpB4t2ie' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 124 'AdminAddClientPermissionsV3' test.out

#- 125 AdminDeleteClientPermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteClientPermissionV3 \
    --action '52' \
    --clientId '8XRPhVzk' \
    --namespace $AB_NAMESPACE \
    --resource 'tsWibnpB' \
    > test.out 2>&1
eval_tap $? 125 'AdminDeleteClientPermissionV3' test.out

#- 126 RetrieveAllThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllThirdPartyLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 126 'RetrieveAllThirdPartyLoginPlatformCredentialV3' test.out

#- 127 RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 127 'RetrieveAllActiveThirdPartyLoginPlatformCredentialV3' test.out

#- 128 RetrieveAllSSOLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllSSOLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    --limit '72' \
    --offset '98' \
    > test.out 2>&1
eval_tap $? 128 'RetrieveAllSSOLoginPlatformCredentialV3' test.out

#- 129 RetrieveThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveThirdPartyLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'MWuoFv0q' \
    > test.out 2>&1
eval_tap $? 129 'RetrieveThirdPartyLoginPlatformCredentialV3' test.out

#- 130 AddThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "jBvBzZGO", "AWSCognitoRegion": "hAwcbpyb", "AWSCognitoUserPool": "Zn4ZE5Om", "AppId": "bNkHnefZ", "ClientId": "WDwi6anY", "Environment": "nQ92kVBD", "FederationMetadataURL": "kaMy03Bu", "GenericOauthFlow": false, "IsActive": true, "Issuer": "bxvTGycc", "JWKSEndpoint": "HSkFQzgV", "KeyID": "R72Dhxbr", "OrganizationId": "4HtKMGr8", "PlatformName": "tnOEeip5", "RedirectUri": "05iJTzZu", "Secret": "ksb4hREc", "TeamID": "Ox3mATUs", "TokenAuthenticationType": "OS0e5Tma", "TokenClaimsMapping": {"pkimopcl": "vfm7fdu7"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddThirdPartyLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'isKaWRcv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 130 'AddThirdPartyLoginPlatformCredentialV3' test.out

#- 131 DeleteThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'kLtfmGyS' \
    > test.out 2>&1
eval_tap $? 131 'DeleteThirdPartyLoginPlatformCredentialV3' test.out

#- 132 UpdateThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "rACKa0mW", "AWSCognitoRegion": "WkDRcuLb", "AWSCognitoUserPool": "IpVJnIAF", "AppId": "pX2SKNmn", "ClientId": "cDRknJor", "Environment": "twVqipgp", "FederationMetadataURL": "XVyWoDjO", "GenericOauthFlow": true, "IsActive": false, "Issuer": "zaXWipcA", "JWKSEndpoint": "HtRkBJXZ", "KeyID": "wQ443FfW", "OrganizationId": "tsTAAgtC", "PlatformName": "nvDp28TM", "RedirectUri": "vlTcBalj", "Secret": "k3sB4LS4", "TeamID": "4hWONXuX", "TokenAuthenticationType": "ihqBVEXS", "TokenClaimsMapping": {"yrZKBvGa": "0LshfP3L"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'qrZcSsGF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 132 'UpdateThirdPartyLoginPlatformCredentialV3' test.out

#- 133 UpdateThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"affectedClientIDs": ["DDAiSjXH"], "assignedNamespaces": ["3ypQaqFP"], "domain": "MAjx7edU", "roleId": "xN5KMSLs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformDomainV3 \
    --namespace $AB_NAMESPACE \
    --platformId '21gdQU0F' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 133 'UpdateThirdPartyLoginPlatformDomainV3' test.out

#- 134 DeleteThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"domain": "hAQYQaHZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformDomainV3 \
    --namespace $AB_NAMESPACE \
    --platformId '7WtAApJt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 134 'DeleteThirdPartyLoginPlatformDomainV3' test.out

#- 135 RetrieveSSOLoginPlatformCredential
$CLI_EXE \
    --sn iam \
    --op RetrieveSSOLoginPlatformCredential \
    --namespace $AB_NAMESPACE \
    --platformId 'fB0Xt8Zc' \
    > test.out 2>&1
eval_tap $? 135 'RetrieveSSOLoginPlatformCredential' test.out

#- 136 AddSSOLoginPlatformCredential
# body param: body
echo '{"acsUrl": "puz7BY3J", "apiKey": "PVnMt1HR", "appId": "DFxkSaTd", "federationMetadataUrl": "INJTdRQm", "isActive": true, "redirectUri": "xBjpVFnE", "secret": "gsovZbx4", "ssoUrl": "UF3pYMze"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddSSOLoginPlatformCredential \
    --namespace $AB_NAMESPACE \
    --platformId 'FcsBLCwh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 136 'AddSSOLoginPlatformCredential' test.out

#- 137 DeleteSSOLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op DeleteSSOLoginPlatformCredentialV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'TStBJZGk' \
    > test.out 2>&1
eval_tap $? 137 'DeleteSSOLoginPlatformCredentialV3' test.out

#- 138 UpdateSSOPlatformCredential
# body param: body
echo '{"acsUrl": "ISL9Sco6", "apiKey": "HxX79bWJ", "appId": "ClH3pXWC", "federationMetadataUrl": "q3ysdpW3", "isActive": true, "redirectUri": "QQmftmA5", "secret": "HUHioxzV", "ssoUrl": "hzHc1rBq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateSSOPlatformCredential \
    --namespace $AB_NAMESPACE \
    --platformId 'AXud4JQO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 138 'UpdateSSOPlatformCredential' test.out

#- 139 AdminGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByPlatformUserIDV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'WZBzUvNk' \
    --platformUserId 'xTUqI2Xh' \
    > test.out 2>&1
eval_tap $? 139 'AdminGetUserByPlatformUserIDV3' test.out

#- 140 GetAdminUsersByRoleIdV3
$CLI_EXE \
    --sn iam \
    --op GetAdminUsersByRoleIdV3 \
    --namespace $AB_NAMESPACE \
    --roleId 'bYwTxVSX' \
    --after '31' \
    --before '71' \
    --limit '3' \
    > test.out 2>&1
eval_tap $? 140 'GetAdminUsersByRoleIdV3' test.out

#- 141 AdminGetUserByEmailAddressV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByEmailAddressV3 \
    --namespace $AB_NAMESPACE \
    --emailAddress '2JSuHHCR' \
    > test.out 2>&1
eval_tap $? 141 'AdminGetUserByEmailAddressV3' test.out

#- 142 AdminListUserIDByUserIDsV3
# body param: body
echo '{"userIds": ["P9xW9VeY"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminListUserIDByUserIDsV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 142 'AdminListUserIDByUserIDsV3' test.out

#- 143 AdminInviteUserV3
# body param: body
echo '{"emailAddresses": ["JCDikIap"], "isAdmin": true, "roles": ["mYwbaGfs"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 143 'AdminInviteUserV3' test.out

#- 144 AdminListUsersV3
$CLI_EXE \
    --sn iam \
    --op AdminListUsersV3 \
    --namespace $AB_NAMESPACE \
    --limit '70' \
    --offset '90' \
    > test.out 2>&1
eval_tap $? 144 'AdminListUsersV3' test.out

#- 145 AdminSearchUserV3
$CLI_EXE \
    --sn iam \
    --op AdminSearchUserV3 \
    --namespace $AB_NAMESPACE \
    --by 'gobWG93d' \
    --endDate 'H2MCGvoh' \
    --limit '35' \
    --offset '6' \
    --platformBy 'Rx6lVi7U' \
    --platformId 'cTmEwe9m' \
    --query 'WH3XVfye' \
    --startDate 'jgTi2E85' \
    > test.out 2>&1
eval_tap $? 145 'AdminSearchUserV3' test.out

#- 146 AdminGetBulkUserByEmailAddressV3
# body param: body
echo '{"listEmailAddressRequest": ["VnFsoXaR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminGetBulkUserByEmailAddressV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 146 'AdminGetBulkUserByEmailAddressV3' test.out

#- 147 AdminGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByUserIdV3 \
    --namespace $AB_NAMESPACE \
    --userId 'Ea1WpsZ5' \
    > test.out 2>&1
eval_tap $? 147 'AdminGetUserByUserIdV3' test.out

#- 148 AdminUpdateUserV3
# body param: body
echo '{"country": "PoXUApZE", "dateOfBirth": "Pfic39c2", "displayName": "q3a6kRuG", "languageTag": "qHcwZVjA", "userName": "QCkWjE3g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV3 \
    --namespace $AB_NAMESPACE \
    --userId 'J6AwW953' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 148 'AdminUpdateUserV3' test.out

#- 149 AdminGetUserBanV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserBanV3 \
    --namespace $AB_NAMESPACE \
    --userId 'NlFHpDCF' \
    --activeOnly 'True' \
    --after 't39Jhj3l' \
    --before 'mfXJxKJN' \
    --limit '87' \
    > test.out 2>&1
eval_tap $? 149 'AdminGetUserBanV3' test.out

#- 150 AdminBanUserV3
# body param: body
echo '{"ban": "D3KumRjk", "comment": "3wZYVb3S", "endDate": "Fssnx4JY", "reason": "y1kXakVQ", "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV3 \
    --namespace $AB_NAMESPACE \
    --userId 'G01upsR2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 150 'AdminBanUserV3' test.out

#- 151 AdminUpdateUserBanV3
# body param: body
echo '{"enabled": true, "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserBanV3 \
    --banId 'WaCZcCX2' \
    --namespace $AB_NAMESPACE \
    --userId 'iLiQGTL6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 151 'AdminUpdateUserBanV3' test.out

#- 152 AdminSendVerificationCodeV3
# body param: body
echo '{"context": "OYjLlXUV", "emailAddress": "78i8csQI", "languageTag": "O0DRagPX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSendVerificationCodeV3 \
    --namespace $AB_NAMESPACE \
    --userId 'zsBfUhCo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 152 'AdminSendVerificationCodeV3' test.out

#- 153 AdminVerifyAccountV3
# body param: body
echo '{"Code": "GFgirdML", "ContactType": "exA5zJvQ", "LanguageTag": "d2cOVXFo", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminVerifyAccountV3 \
    --namespace $AB_NAMESPACE \
    --userId 'aYaSoog7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 153 'AdminVerifyAccountV3' test.out

#- 154 GetUserVerificationCode
$CLI_EXE \
    --sn iam \
    --op GetUserVerificationCode \
    --namespace $AB_NAMESPACE \
    --userId 'pSsQhvXb' \
    > test.out 2>&1
eval_tap $? 154 'GetUserVerificationCode' test.out

#- 155 AdminGetUserDeletionStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserDeletionStatusV3 \
    --namespace $AB_NAMESPACE \
    --userId 'GvqRVSSw' \
    > test.out 2>&1
eval_tap $? 155 'AdminGetUserDeletionStatusV3' test.out

#- 156 AdminUpdateUserDeletionStatusV3
# body param: body
echo '{"enabled": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserDeletionStatusV3 \
    --namespace $AB_NAMESPACE \
    --userId 'lRzdNXrf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 156 'AdminUpdateUserDeletionStatusV3' test.out

#- 157 AdminUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "oKVR4Hhl", "country": "PEfSM2K2", "dateOfBirth": "9oqfZssi", "displayName": "bgoTFQAm", "emailAddress": "IZiTSstC", "password": "2yOumzHM", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpgradeHeadlessAccountV3 \
    --namespace $AB_NAMESPACE \
    --userId 'Xysws3Fw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 157 'AdminUpgradeHeadlessAccountV3' test.out

#- 158 AdminDeleteUserInformationV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserInformationV3 \
    --namespace $AB_NAMESPACE \
    --userId 'nu7OX9FZ' \
    > test.out 2>&1
eval_tap $? 158 'AdminDeleteUserInformationV3' test.out

#- 159 AdminGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserLoginHistoriesV3 \
    --namespace $AB_NAMESPACE \
    --userId 'vwJ8OQFu' \
    --after '0.44960385203985576' \
    --before '0.9114964301877354' \
    --limit '31' \
    > test.out 2>&1
eval_tap $? 159 'AdminGetUserLoginHistoriesV3' test.out

#- 160 AdminUpdateUserPermissionV3
# body param: body
echo '{"Permissions": [{"Action": 90, "Resource": "mT632j8Q", "SchedAction": 11, "SchedCron": "hNDTHb8l", "SchedRange": ["FvBolf9P"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserPermissionV3 \
    --namespace $AB_NAMESPACE \
    --userId 'di5BLCsT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 160 'AdminUpdateUserPermissionV3' test.out

#- 161 AdminAddUserPermissionsV3
# body param: body
echo '{"Permissions": [{"Action": 12, "Resource": "72thhduZ", "SchedAction": 27, "SchedCron": "Nj9cRNlT", "SchedRange": ["Bxl3nKj6"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserPermissionsV3 \
    --namespace $AB_NAMESPACE \
    --userId 'B4ffgtxi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 161 'AdminAddUserPermissionsV3' test.out

#- 162 AdminDeleteUserPermissionBulkV3
# body param: body
echo '[{"Action": 82, "Resource": "LdV0odbf"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionBulkV3 \
    --namespace $AB_NAMESPACE \
    --userId 'ast4NDIB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 162 'AdminDeleteUserPermissionBulkV3' test.out

#- 163 AdminDeleteUserPermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionV3 \
    --action '84' \
    --namespace $AB_NAMESPACE \
    --resource 'l3UryryO' \
    --userId 'WzhhEmSV' \
    > test.out 2>&1
eval_tap $? 163 'AdminDeleteUserPermissionV3' test.out

#- 164 AdminGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserPlatformAccountsV3 \
    --namespace $AB_NAMESPACE \
    --userId 'FhAlEacA' \
    --after 'AoAfsuMB' \
    --before '4W3HIcvS' \
    --limit '53' \
    > test.out 2>&1
eval_tap $? 164 'AdminGetUserPlatformAccountsV3' test.out

#- 165 AdminGetListJusticePlatformAccounts
$CLI_EXE \
    --sn iam \
    --op AdminGetListJusticePlatformAccounts \
    --namespace $AB_NAMESPACE \
    --userId 'L4tYCwCd' \
    > test.out 2>&1
eval_tap $? 165 'AdminGetListJusticePlatformAccounts' test.out

#- 166 AdminCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op AdminCreateJusticeUser \
    --namespace $AB_NAMESPACE \
    --targetNamespace 'Cigcxlbl' \
    --userId '30hHHEjM' \
    > test.out 2>&1
eval_tap $? 166 'AdminCreateJusticeUser' test.out

#- 167 AdminLinkPlatformAccount
# body param: body
echo '{"platformId": "I4LcgkyD", "platformUserId": "sccFdvzo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminLinkPlatformAccount \
    --namespace $AB_NAMESPACE \
    --userId 'afMLoraV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 167 'AdminLinkPlatformAccount' test.out

#- 168 AdminPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "j5RiDHvo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPlatformUnlinkV3 \
    --namespace $AB_NAMESPACE \
    --platformId '7KepgBTM' \
    --userId 'RiEdeeQw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 168 'AdminPlatformUnlinkV3' test.out

#- 169 AdminPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op AdminPlatformLinkV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'LUW0VLup' \
    --userId 'H83AuxFE' \
    --ticket 'FRDTt2ma' \
    > test.out 2>&1
eval_tap $? 169 'AdminPlatformLinkV3' test.out

#- 170 AdminDeleteUserRolesV3
# body param: body
echo '["uywaKEsP"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRolesV3 \
    --namespace $AB_NAMESPACE \
    --userId 'BAM1aujN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 170 'AdminDeleteUserRolesV3' test.out

#- 171 AdminSaveUserRoleV3
# body param: body
echo '[{"namespace": "qlmpKGhv", "roleId": "TKiXeZep"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSaveUserRoleV3 \
    --namespace $AB_NAMESPACE \
    --userId 'm7tF1wKh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 171 'AdminSaveUserRoleV3' test.out

#- 172 AdminAddUserRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV3 \
    --namespace $AB_NAMESPACE \
    --roleId 'Q4HjEcag' \
    --userId 'yjZITRuo' \
    > test.out 2>&1
eval_tap $? 172 'AdminAddUserRoleV3' test.out

#- 173 AdminDeleteUserRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRoleV3 \
    --namespace $AB_NAMESPACE \
    --roleId 'WjICoCN3' \
    --userId 'NyzAV4ni' \
    > test.out 2>&1
eval_tap $? 173 'AdminDeleteUserRoleV3' test.out

#- 174 AdminUpdateUserStatusV3
# body param: body
echo '{"enabled": false, "reason": "gDJE12W5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserStatusV3 \
    --namespace $AB_NAMESPACE \
    --userId 'eoplrOXw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 174 'AdminUpdateUserStatusV3' test.out

#- 175 AdminVerifyUserWithoutVerificationCodeV3
$CLI_EXE \
    --sn iam \
    --op AdminVerifyUserWithoutVerificationCodeV3 \
    --namespace $AB_NAMESPACE \
    --userId 'ASJ1PtQu' \
    > test.out 2>&1
eval_tap $? 175 'AdminVerifyUserWithoutVerificationCodeV3' test.out

#- 176 AdminGetRolesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV3 \
    --after 'xOJQKgor' \
    --before '2UMJt4EJ' \
    --isWildcard 'False' \
    --limit '5' \
    > test.out 2>&1
eval_tap $? 176 'AdminGetRolesV3' test.out

#- 177 AdminCreateRoleV3
# body param: body
echo '{"adminRole": true, "deletable": false, "isWildcard": false, "managers": [{"displayName": "BNsUvUKh", "namespace": "ANjquBEH", "userId": "OJbaQpz0"}], "members": [{"displayName": "dfiuv051", "namespace": "lkPCaZsj", "userId": "vFvhZdwi"}], "permissions": [{"action": 91, "resource": "i6V2uWuC", "schedAction": 37, "schedCron": "B8FbVDwh", "schedRange": ["pNCLl2bg"]}], "roleName": "Ic1y49bq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV3 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 177 'AdminCreateRoleV3' test.out

#- 178 AdminGetRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV3 \
    --roleId 'pbfyytwm' \
    > test.out 2>&1
eval_tap $? 178 'AdminGetRoleV3' test.out

#- 179 AdminDeleteRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV3 \
    --roleId '6jQJpfOI' \
    > test.out 2>&1
eval_tap $? 179 'AdminDeleteRoleV3' test.out

#- 180 AdminUpdateRoleV3
# body param: body
echo '{"deletable": true, "isWildcard": false, "roleName": "gUjKQRjo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV3 \
    --roleId 'yn3bGyFG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 180 'AdminUpdateRoleV3' test.out

#- 181 AdminGetRoleAdminStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleAdminStatusV3 \
    --roleId 'wcAylTi4' \
    > test.out 2>&1
eval_tap $? 181 'AdminGetRoleAdminStatusV3' test.out

#- 182 AdminUpdateAdminRoleStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAdminRoleStatusV3 \
    --roleId 'qPF190sf' \
    > test.out 2>&1
eval_tap $? 182 'AdminUpdateAdminRoleStatusV3' test.out

#- 183 AdminRemoveRoleAdminV3
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleAdminV3 \
    --roleId '2ZwPi5hI' \
    > test.out 2>&1
eval_tap $? 183 'AdminRemoveRoleAdminV3' test.out

#- 184 AdminGetRoleManagersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleManagersV3 \
    --roleId '4k3KwV7P' \
    --after '8R9t4dBR' \
    --before 'pBp4noj3' \
    --limit '71' \
    > test.out 2>&1
eval_tap $? 184 'AdminGetRoleManagersV3' test.out

#- 185 AdminAddRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "79DD3bAZ", "namespace": "F4nYBuNx", "userId": "ISmVGVz9"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleManagersV3 \
    --roleId 'Jxj8wegr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 185 'AdminAddRoleManagersV3' test.out

#- 186 AdminRemoveRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "Do6OmeKL", "namespace": "7GPoI9uW", "userId": "OFTWdRrL"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleManagersV3 \
    --roleId '6yNmv8k1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 186 'AdminRemoveRoleManagersV3' test.out

#- 187 AdminGetRoleMembersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleMembersV3 \
    --roleId 'w19JsHSq' \
    --after 'OByh4hhk' \
    --before 'cO6J7jSv' \
    --limit '7' \
    > test.out 2>&1
eval_tap $? 187 'AdminGetRoleMembersV3' test.out

#- 188 AdminAddRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "4J5c6ayF", "namespace": "nSrfmObF", "userId": "TUBRRDGC"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleMembersV3 \
    --roleId 'RQtMc3an' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 188 'AdminAddRoleMembersV3' test.out

#- 189 AdminRemoveRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "8ZoxLwXH", "namespace": "S1oUzDdD", "userId": "cZ0Rj3YM"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleMembersV3 \
    --roleId '1fz9Cjqt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 189 'AdminRemoveRoleMembersV3' test.out

#- 190 AdminUpdateRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 33, "resource": "eiyDCK7C", "schedAction": 40, "schedCron": "5GcPbmi5", "schedRange": ["KiFDVpfv"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV3 \
    --roleId 'R2Wl0iSh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 190 'AdminUpdateRolePermissionsV3' test.out

#- 191 AdminAddRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 0, "resource": "gpvFuZu4", "schedAction": 51, "schedCron": "srSpvMLv", "schedRange": ["Qw3sPxFu"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV3 \
    --roleId '8LQGQCAj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 191 'AdminAddRolePermissionsV3' test.out

#- 192 AdminDeleteRolePermissionsV3
# body param: body
echo '["6O7ivhNI"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV3 \
    --roleId 'jVT5HSR0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 192 'AdminDeleteRolePermissionsV3' test.out

#- 193 AdminDeleteRolePermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionV3 \
    --action '93' \
    --resource 'KSLWWzOp' \
    --roleId 'lTLwZQZU' \
    > test.out 2>&1
eval_tap $? 193 'AdminDeleteRolePermissionV3' test.out

#- 194 AdminGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op AdminGetMyUserV3 \
    > test.out 2>&1
eval_tap $? 194 'AdminGetMyUserV3' test.out

#- 195 UserAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op UserAuthenticationV3 \
    --client_id 'MaAJ6ZBT' \
    --extend_exp 'False' \
    --redirect_uri 'GbVtzsBT' \
    --password 'COWEnaLz' \
    --request_id 'HuYKrr89' \
    --user_name 'z0RkL932' \
    > test.out 2>&1
eval_tap $? 195 'UserAuthenticationV3' test.out

#- 196 GetCountryLocationV3
$CLI_EXE \
    --sn iam \
    --op GetCountryLocationV3 \
    > test.out 2>&1
eval_tap $? 196 'GetCountryLocationV3' test.out

#- 197 Logout
$CLI_EXE \
    --sn iam \
    --op Logout \
    > test.out 2>&1
eval_tap $? 197 'Logout' test.out

#- 198 AdminRetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op AdminRetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'B7thDQ3h' \
    --userId 'fVnPK8iK' \
    > test.out 2>&1
eval_tap $? 198 'AdminRetrieveUserThirdPartyPlatformTokenV3' test.out

#- 199 RevokeUserV3
$CLI_EXE \
    --sn iam \
    --op RevokeUserV3 \
    --namespace $AB_NAMESPACE \
    --userId '8cdZPnXw' \
    > test.out 2>&1
eval_tap $? 199 'RevokeUserV3' test.out

#- 200 AuthorizeV3
$CLI_EXE \
    --sn iam \
    --op AuthorizeV3 \
    --codeChallenge 'GS9fAlxt' \
    --codeChallengeMethod 'S256' \
    --redirectUri 'eZUrqmIc' \
    --scope '7El44MEA' \
    --state 'vaPTwwJr' \
    --targetAuthPage 'G06MtcF7' \
    --clientId 't8DQxcoQ' \
    --responseType 'code' \
    > test.out 2>&1
eval_tap $? 200 'AuthorizeV3' test.out

#- 201 TokenIntrospectionV3
$CLI_EXE \
    --sn iam \
    --op TokenIntrospectionV3 \
    --token 'TWMc41xD' \
    > test.out 2>&1
eval_tap $? 201 'TokenIntrospectionV3' test.out

#- 202 GetJWKSV3
$CLI_EXE \
    --sn iam \
    --op GetJWKSV3 \
    > test.out 2>&1
eval_tap $? 202 'GetJWKSV3' test.out

#- 203 Change2faMethod
$CLI_EXE \
    --sn iam \
    --op Change2faMethod \
    --factor 'mUjkXi2L' \
    --mfaToken 'gkALGxw6' \
    > test.out 2>&1
eval_tap $? 203 'Change2faMethod' test.out

#- 204 Verify2faCode
$CLI_EXE \
    --sn iam \
    --op Verify2faCode \
    --code 'qgvIJBe6' \
    --factor 'rDGbFNzs' \
    --mfaToken 'yQVqvSgt' \
    --rememberDevice 'False' \
    > test.out 2>&1
eval_tap $? 204 'Verify2faCode' test.out

#- 205 RetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op RetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'UVddL6A1' \
    --userId 'cTLmuKlG' \
    > test.out 2>&1
eval_tap $? 205 'RetrieveUserThirdPartyPlatformTokenV3' test.out

#- 206 AuthCodeRequestV3
$CLI_EXE \
    --sn iam \
    --op AuthCodeRequestV3 \
    --platformId 'HZdwwo66' \
    --clientId 'H6QOfYzt' \
    --redirectUri 'Hev8RX4M' \
    --requestId 'WRFklN13' \
    > test.out 2>&1
eval_tap $? 206 'AuthCodeRequestV3' test.out

#- 207 PlatformTokenGrantV3
$CLI_EXE \
    --sn iam \
    --op PlatformTokenGrantV3 \
    --platformId 'WW7U0sRV' \
    --client_id 'CnzRxni0' \
    --device_id 'Kq9Zl2b7' \
    --platform_token 'ChMCxb6x' \
    > test.out 2>&1
eval_tap $? 207 'PlatformTokenGrantV3' test.out

#- 208 GetRevocationListV3
$CLI_EXE \
    --sn iam \
    --op GetRevocationListV3 \
    > test.out 2>&1
eval_tap $? 208 'GetRevocationListV3' test.out

#- 209 TokenRevocationV3
$CLI_EXE \
    --sn iam \
    --op TokenRevocationV3 \
    --token 'dzl2OYVR' \
    > test.out 2>&1
eval_tap $? 209 'TokenRevocationV3' test.out

#- 210 TokenGrantV3
$CLI_EXE \
    --sn iam \
    --op TokenGrantV3 \
    --client_id 'JNC7EruV' \
    --code 'ITunbxaO' \
    --code_verifier 'WNrMkfAL' \
    --extend_exp 'True' \
    --password 'rR6M3vzu' \
    --redirect_uri '84TNQYCZ' \
    --refresh_token 'IpKFvpQO' \
    --username 'jjkIYAQE' \
    --grant_type 'authorization_code' \
    > test.out 2>&1
eval_tap $? 210 'TokenGrantV3' test.out

#- 211 PlatformAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticationV3 \
    --platformId 'xGPTkn2N' \
    --code 'J9gHmB0v' \
    --error 'flV2VptG' \
    --openidAssocHandle 'YAEziSth' \
    --openidClaimedId 'hR9WLiVT' \
    --openidIdentity 'XHhZmByx' \
    --openidMode 'lmWBLyhg' \
    --openidNs 'ZsJoonMp' \
    --openidOpEndpoint 'OQ9Jmh8w' \
    --openidResponseNonce 'wQ28fmxM' \
    --openidReturnTo 'FN8d9fdH' \
    --openidSig 'AHphhby7' \
    --openidSigned 'hGbKeIkY' \
    --state '4Fc8atJ3' \
    > test.out 2>&1
eval_tap $? 211 'PlatformAuthenticationV3' test.out

#- 212 PublicGetInputValidations
$CLI_EXE \
    --sn iam \
    --op PublicGetInputValidations \
    --defaultOnEmpty 'False' \
    --languageCode 'bk9YdEm0' \
    > test.out 2>&1
eval_tap $? 212 'PublicGetInputValidations' test.out

#- 213 RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 213 'RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3' test.out

#- 214 PublicListUserIDByPlatformUserIDsV3
# body param: body
echo '{"platformUserIds": ["o9Rjjnkh"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicListUserIDByPlatformUserIDsV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'wq75VqZH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 214 'PublicListUserIDByPlatformUserIDsV3' test.out

#- 215 PublicGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByPlatformUserIDV3 \
    --namespace $AB_NAMESPACE \
    --platformId '8HUq92UF' \
    --platformUserId 'WFC8oFuU' \
    > test.out 2>&1
eval_tap $? 215 'PublicGetUserByPlatformUserIDV3' test.out

#- 216 PublicGetAsyncStatus
$CLI_EXE \
    --sn iam \
    --op PublicGetAsyncStatus \
    --namespace $AB_NAMESPACE \
    --requestId '2OFJ6w1H' \
    > test.out 2>&1
eval_tap $? 216 'PublicGetAsyncStatus' test.out

#- 217 PublicSearchUserV3
$CLI_EXE \
    --sn iam \
    --op PublicSearchUserV3 \
    --namespace $AB_NAMESPACE \
    --by 'bioiiaZ8' \
    --query 'Uc2rWpzX' \
    > test.out 2>&1
eval_tap $? 217 'PublicSearchUserV3' test.out

#- 218 PublicCreateUserV3
# body param: body
echo '{"PasswordMD5Sum": "2mgoBhru", "acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "vEzpyRiF", "policyId": "s63b4Pru", "policyVersionId": "2pWiVBYj"}], "authType": "KI1ZlcKX", "code": "BXcPAsjW", "country": "7zBxpVc8", "dateOfBirth": "svjiFtRe", "displayName": "8k7amplf", "emailAddress": "huHropVx", "password": "IvBjsYUE", "reachMinimumAge": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateUserV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 218 'PublicCreateUserV3' test.out

#- 219 CheckUserAvailability
$CLI_EXE \
    --sn iam \
    --op CheckUserAvailability \
    --namespace $AB_NAMESPACE \
    --field 'p1taP9py' \
    --query '4Fl6UoVx' \
    > test.out 2>&1
eval_tap $? 219 'CheckUserAvailability' test.out

#- 220 PublicBulkGetUsers
# body param: body
echo '{"userIds": ["gHJLBm3b"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicBulkGetUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 220 'PublicBulkGetUsers' test.out

#- 221 PublicSendRegistrationCode
# body param: body
echo '{"emailAddress": "gRvSUyOg", "languageTag": "yu9dhxao"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicSendRegistrationCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 221 'PublicSendRegistrationCode' test.out

#- 222 PublicVerifyRegistrationCode
# body param: body
echo '{"code": "fTjMYGTM", "emailAddress": "Xy4ypcIN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicVerifyRegistrationCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 222 'PublicVerifyRegistrationCode' test.out

#- 223 PublicForgotPasswordV3
# body param: body
echo '{"emailAddress": "4uUIzvUI", "languageTag": "5b1wxS2y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicForgotPasswordV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 223 'PublicForgotPasswordV3' test.out

#- 224 GetAdminInvitationV3
$CLI_EXE \
    --sn iam \
    --op GetAdminInvitationV3 \
    --invitationId 'BTD8uNea' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 224 'GetAdminInvitationV3' test.out

#- 225 CreateUserFromInvitationV3
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "LeXNgQBn", "policyId": "XZkQ06LU", "policyVersionId": "EgyyiBeJ"}], "authType": "ARFVbUvL", "country": "NtDdAntK", "dateOfBirth": "I6vd3QdS", "displayName": "HH2AvosR", "password": "9Nk0JJYX", "reachMinimumAge": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV3 \
    --invitationId 'Qg1LwgzW' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 225 'CreateUserFromInvitationV3' test.out

#- 226 UpdateUserV3
# body param: body
echo '{"country": "Ru5q2i8n", "dateOfBirth": "tDdFSOEI", "displayName": "qFse4ocr", "languageTag": "qjWTbUay", "userName": "IP8oO0z1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateUserV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 226 'UpdateUserV3' test.out

#- 227 PublicUpdateUserV3
# body param: body
echo '{"country": "VffDHyFM", "dateOfBirth": "7T2H6g4j", "displayName": "bxDDxngE", "languageTag": "qsAbWEfT", "userName": "c2nSU2Si"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 227 'PublicUpdateUserV3' test.out

#- 228 PublicSendVerificationCodeV3
# body param: body
echo '{"context": "jySpnqX0", "emailAddress": "1uDkQ1tv", "languageTag": "3iMMW8aq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicSendVerificationCodeV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 228 'PublicSendVerificationCodeV3' test.out

#- 229 PublicUserVerificationV3
# body param: body
echo '{"code": "VbwArhGS", "contactType": "aFxyAsPn", "languageTag": "fbHX5TpI", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUserVerificationV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 229 'PublicUserVerificationV3' test.out

#- 230 PublicUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "7dMKaAr2", "country": "VSmtP8qx", "dateOfBirth": "tNo76oPR", "displayName": "uvxUGNJv", "emailAddress": "DRuWXBzy", "password": "WeusWdEJ", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpgradeHeadlessAccountV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 230 'PublicUpgradeHeadlessAccountV3' test.out

#- 231 PublicVerifyHeadlessAccountV3
# body param: body
echo '{"emailAddress": "qhXgmVQH", "password": "oZNPy0Wq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicVerifyHeadlessAccountV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 231 'PublicVerifyHeadlessAccountV3' test.out

#- 232 PublicUpdatePasswordV3
# body param: body
echo '{"languageTag": "u4qtxTyr", "newPassword": "vNhypNLp", "oldPassword": "orjcAKSu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdatePasswordV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 232 'PublicUpdatePasswordV3' test.out

#- 233 PublicCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op PublicCreateJusticeUser \
    --namespace $AB_NAMESPACE \
    --targetNamespace 'vgVjdXMn' \
    > test.out 2>&1
eval_tap $? 233 'PublicCreateJusticeUser' test.out

#- 234 PublicPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV3 \
    --namespace $AB_NAMESPACE \
    --platformId '2juyP3WX' \
    --redirectUri '3u1OLRUr' \
    --ticket 'Z6vwIqGn' \
    > test.out 2>&1
eval_tap $? 234 'PublicPlatformLinkV3' test.out

#- 235 PublicPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "oqXXAZd7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicPlatformUnlinkV3 \
    --namespace $AB_NAMESPACE \
    --platformId 'bvO6Xg2x' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 235 'PublicPlatformUnlinkV3' test.out

#- 236 PublicWebLinkPlatform
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatform \
    --namespace $AB_NAMESPACE \
    --platformId 'x5vZXC9Y' \
    --clientId 'sEXEe9iC' \
    --redirectUri '3Hp95AtW' \
    > test.out 2>&1
eval_tap $? 236 'PublicWebLinkPlatform' test.out

#- 237 PublicWebLinkPlatformEstablish
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatformEstablish \
    --namespace $AB_NAMESPACE \
    --platformId 'E8drEipX' \
    --state 'ZfocCS9n' \
    > test.out 2>&1
eval_tap $? 237 'PublicWebLinkPlatformEstablish' test.out

#- 238 ResetPasswordV3
# body param: body
echo '{"code": "GM6fYF1o", "emailAddress": "77M1VVgH", "newPassword": "HeL0flEP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op ResetPasswordV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 238 'ResetPasswordV3' test.out

#- 239 PublicGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIdV3 \
    --namespace $AB_NAMESPACE \
    --userId 'UxHPhE4Y' \
    > test.out 2>&1
eval_tap $? 239 'PublicGetUserByUserIdV3' test.out

#- 240 PublicGetUserBanHistoryV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBanHistoryV3 \
    --namespace $AB_NAMESPACE \
    --userId 'wCRBGAR8' \
    --activeOnly 'True' \
    --after 'ZlDIjOfY' \
    --before 'lF5jISj4' \
    --limit '45' \
    > test.out 2>&1
eval_tap $? 240 'PublicGetUserBanHistoryV3' test.out

#- 241 PublicGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserLoginHistoriesV3 \
    --namespace $AB_NAMESPACE \
    --userId 'wqLpFnnN' \
    --after '0.3799038459198859' \
    --before '0.9696465709614522' \
    --limit '5' \
    > test.out 2>&1
eval_tap $? 241 'PublicGetUserLoginHistoriesV3' test.out

#- 242 PublicGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserPlatformAccountsV3 \
    --namespace $AB_NAMESPACE \
    --userId 'POtfkEyL' \
    --after 'h6l74AQY' \
    --before '5ulxH0li' \
    --limit '29' \
    > test.out 2>&1
eval_tap $? 242 'PublicGetUserPlatformAccountsV3' test.out

#- 243 PublicLinkPlatformAccount
# body param: body
echo '{"platformId": "SoooPhQ9", "platformUserId": "xlLMe7ma"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicLinkPlatformAccount \
    --namespace $AB_NAMESPACE \
    --userId '8Qc9aGN5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 243 'PublicLinkPlatformAccount' test.out

#- 244 PublicValidateUserByUserIDAndPasswordV3
$CLI_EXE \
    --sn iam \
    --op PublicValidateUserByUserIDAndPasswordV3 \
    --namespace $AB_NAMESPACE \
    --userId 'UJPLchii' \
    --password 'vOQdByk3' \
    > test.out 2>&1
eval_tap $? 244 'PublicValidateUserByUserIDAndPasswordV3' test.out

#- 245 PublicGetRolesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRolesV3 \
    --after 'mWQ93Bxb' \
    --before 'P1VP8rKu' \
    --isWildcard 'True' \
    --limit '90' \
    > test.out 2>&1
eval_tap $? 245 'PublicGetRolesV3' test.out

#- 246 PublicGetRoleV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRoleV3 \
    --roleId 'TGSX5rG8' \
    > test.out 2>&1
eval_tap $? 246 'PublicGetRoleV3' test.out

#- 247 PublicGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op PublicGetMyUserV3 \
    > test.out 2>&1
eval_tap $? 247 'PublicGetMyUserV3' test.out

#- 248 PlatformAuthenticateSAMLV3Handler
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticateSAMLV3Handler \
    --platformId 'ymO7ml7S' \
    --code 'CwM6RZNe' \
    --error 'rJQroYUk' \
    --state 'vHx2dAjF' \
    > test.out 2>&1
eval_tap $? 248 'PlatformAuthenticateSAMLV3Handler' test.out

#- 249 LoginSSOClient
$CLI_EXE \
    --sn iam \
    --op LoginSSOClient \
    --platformId 'F0BBGwZ7' \
    --payload 'XWhdoYx1' \
    > test.out 2>&1
eval_tap $? 249 'LoginSSOClient' test.out

#- 250 LogoutSSOClient
$CLI_EXE \
    --sn iam \
    --op LogoutSSOClient \
    --platformId '27YYBoxS' \
    > test.out 2>&1
eval_tap $? 250 'LogoutSSOClient' test.out

#- 251 AdminBulkCheckValidUserIDV4
# body param: body
echo '{"userIds": ["CFsBbZL1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBulkCheckValidUserIDV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 251 'AdminBulkCheckValidUserIDV4' test.out

#- 252 AdminUpdateUserV4
# body param: body
echo '{"country": "6L2P8eNm", "dateOfBirth": "Oi4OPQ8Z", "displayName": "EV8XzBcA", "languageTag": "niVuoW6w", "userName": "PQlP1zgk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV4 \
    --namespace $AB_NAMESPACE \
    --userId 'xv25ZHaR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 252 'AdminUpdateUserV4' test.out

#- 253 AdminUpdateUserEmailAddressV4
# body param: body
echo '{"code": "8vsMhIfo", "emailAddress": "gRB8XeZh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserEmailAddressV4 \
    --namespace $AB_NAMESPACE \
    --userId 'AM4MAL57' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 253 'AdminUpdateUserEmailAddressV4' test.out

#- 254 AdminDisableUserMFAV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableUserMFAV4 \
    --namespace $AB_NAMESPACE \
    --userId 'riU2QbQF' \
    > test.out 2>&1
eval_tap $? 254 'AdminDisableUserMFAV4' test.out

#- 255 AdminListUserRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminListUserRolesV4 \
    --namespace $AB_NAMESPACE \
    --userId 'RCXEWG8S' \
    > test.out 2>&1
eval_tap $? 255 'AdminListUserRolesV4' test.out

#- 256 AdminUpdateUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["xt5vtTkI"], "roleId": "WbiHTUDD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserRoleV4 \
    --namespace $AB_NAMESPACE \
    --userId 'L4yzTnQv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 256 'AdminUpdateUserRoleV4' test.out

#- 257 AdminAddUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["0e99zYNk"], "roleId": "H6PuvERG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV4 \
    --namespace $AB_NAMESPACE \
    --userId 'P7fmyd8a' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 257 'AdminAddUserRoleV4' test.out

#- 258 AdminRemoveUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["JkJYGKf4"], "roleId": "wBCsCLrf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveUserRoleV4 \
    --namespace $AB_NAMESPACE \
    --userId 'H6V3fTRa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 258 'AdminRemoveUserRoleV4' test.out

#- 259 AdminGetRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV4 \
    --adminRole 'True' \
    --isWildcard 'True' \
    --limit '59' \
    --offset '34' \
    > test.out 2>&1
eval_tap $? 259 'AdminGetRolesV4' test.out

#- 260 AdminCreateRoleV4
# body param: body
echo '{"adminRole": false, "deletable": false, "isWildcard": true, "roleName": "yfGQvBMJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV4 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 260 'AdminCreateRoleV4' test.out

#- 261 AdminGetRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV4 \
    --roleId 'Ga0RWFil' \
    > test.out 2>&1
eval_tap $? 261 'AdminGetRoleV4' test.out

#- 262 AdminDeleteRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV4 \
    --roleId 'SDbJxY0Y' \
    > test.out 2>&1
eval_tap $? 262 'AdminDeleteRoleV4' test.out

#- 263 AdminUpdateRoleV4
# body param: body
echo '{"adminRole": true, "deletable": true, "isWildcard": false, "roleName": "yquoA8CG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV4 \
    --roleId 'DmAN0yX8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 263 'AdminUpdateRoleV4' test.out

#- 264 AdminUpdateRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 47, "resource": "u01b0bUq", "schedAction": 59, "schedCron": "heu9idRv", "schedRange": ["Q8V1CaeT"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV4 \
    --roleId '74VP6Kqp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 264 'AdminUpdateRolePermissionsV4' test.out

#- 265 AdminAddRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 70, "resource": "C53CGQXz", "schedAction": 18, "schedCron": "GEvvr9VR", "schedRange": ["6QqaoAup"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV4 \
    --roleId 'KSo0RHRz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 265 'AdminAddRolePermissionsV4' test.out

#- 266 AdminDeleteRolePermissionsV4
# body param: body
echo '["XML3VcaD"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV4 \
    --roleId 'WEzPCi2t' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 266 'AdminDeleteRolePermissionsV4' test.out

#- 267 AdminListAssignedUsersV4
$CLI_EXE \
    --sn iam \
    --op AdminListAssignedUsersV4 \
    --roleId 'WPzhrjLF' \
    --after 'LLuGlXIn' \
    --before 'Vkn9ojnp' \
    --limit '31' \
    > test.out 2>&1
eval_tap $? 267 'AdminListAssignedUsersV4' test.out

#- 268 AdminAssignUserToRoleV4
# body param: body
echo '{"assignedNamespaces": ["iU7rYU09"], "namespace": "8E1JzPma", "userId": "RkeYX8U7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAssignUserToRoleV4 \
    --roleId '1w09mTap' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 268 'AdminAssignUserToRoleV4' test.out

#- 269 AdminRevokeUserFromRoleV4
# body param: body
echo '{"namespace": "7y90X88q", "userId": "bd2vRMUm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRevokeUserFromRoleV4 \
    --roleId 'qoGBqBax' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 269 'AdminRevokeUserFromRoleV4' test.out

#- 270 AdminUpdateMyUserV4
# body param: body
echo '{"country": "LbpDekuI", "dateOfBirth": "zTODQZkN", "displayName": "g9XscMV2", "languageTag": "DnOo9Pao", "userName": "BSJJGgg8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateMyUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 270 'AdminUpdateMyUserV4' test.out

#- 271 AdminDisableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableMyAuthenticatorV4 \
    > test.out 2>&1
eval_tap $? 271 'AdminDisableMyAuthenticatorV4' test.out

#- 272 AdminEnableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op AdminEnableMyAuthenticatorV4 \
    --code 'epTUehn6' \
    > test.out 2>&1
eval_tap $? 272 'AdminEnableMyAuthenticatorV4' test.out

#- 273 AdminGenerateMyAuthenticatorKeyV4
$CLI_EXE \
    --sn iam \
    --op AdminGenerateMyAuthenticatorKeyV4 \
    > test.out 2>&1
eval_tap $? 273 'AdminGenerateMyAuthenticatorKeyV4' test.out

#- 274 AdminGetMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetMyBackupCodesV4 \
    > test.out 2>&1
eval_tap $? 274 'AdminGetMyBackupCodesV4' test.out

#- 275 AdminGenerateMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminGenerateMyBackupCodesV4 \
    > test.out 2>&1
eval_tap $? 275 'AdminGenerateMyBackupCodesV4' test.out

#- 276 AdminDisableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableMyBackupCodesV4 \
    > test.out 2>&1
eval_tap $? 276 'AdminDisableMyBackupCodesV4' test.out

#- 277 AdminDownloadMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminDownloadMyBackupCodesV4 \
    > test.out 2>&1
eval_tap $? 277 'AdminDownloadMyBackupCodesV4' test.out

#- 278 AdminEnableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminEnableMyBackupCodesV4 \
    > test.out 2>&1
eval_tap $? 278 'AdminEnableMyBackupCodesV4' test.out

#- 279 AdminGetMyEnabledFactorsV4
$CLI_EXE \
    --sn iam \
    --op AdminGetMyEnabledFactorsV4 \
    > test.out 2>&1
eval_tap $? 279 'AdminGetMyEnabledFactorsV4' test.out

#- 280 AdminMakeFactorMyDefaultV4
$CLI_EXE \
    --sn iam \
    --op AdminMakeFactorMyDefaultV4 \
    --factor 'IzqXsteu' \
    > test.out 2>&1
eval_tap $? 280 'AdminMakeFactorMyDefaultV4' test.out

#- 281 AdminInviteUserV4
# body param: body
echo '{"assignedNamespaces": ["4pU694ex"], "emailAddresses": ["0bxtkvXI"], "isAdmin": true, "roleId": "bCB52HlT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 281 'AdminInviteUserV4' test.out

#- 282 PublicCreateTestUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "FVmpXnrW", "policyId": "DCij8S73", "policyVersionId": "sQDNy12G"}], "authType": "1PiTJwxV", "country": "0rwMM7Hs", "dateOfBirth": "MJnUBZ6G", "displayName": "yhfcrdde", "emailAddress": "IOhxQMIm", "password": "B13f1obT", "passwordMD5Sum": "KrwFXC2O", "username": "p2yXEIOA", "verified": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateTestUserV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 282 'PublicCreateTestUserV4' test.out

#- 283 PublicCreateUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "HWdmibqD", "policyId": "eNic565h", "policyVersionId": "vy1VY236"}], "authType": "5rUHkxww", "code": "pNwFJyOB", "country": "elglT04u", "dateOfBirth": "RmAeOhTe", "displayName": "ibSq4H7x", "emailAddress": "De1jh7cl", "password": "QulgjFzO", "passwordMD5Sum": "E2zPDGQY", "reachMinimumAge": true, "username": "GsklKEj2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateUserV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 283 'PublicCreateUserV4' test.out

#- 284 CreateUserFromInvitationV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "ImuLS8rr", "policyId": "BfOaAENF", "policyVersionId": "CnYbIQID"}], "authType": "kTf41ag7", "country": "CX8oWPut", "dateOfBirth": "7xraYvae", "displayName": "aiep5aTd", "password": "bjoDWOL2", "reachMinimumAge": false, "username": "mjDt1rOz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV4 \
    --invitationId '0DT1Axwh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 284 'CreateUserFromInvitationV4' test.out

#- 285 PublicUpdateUserV4
# body param: body
echo '{"country": "im0K97Zl", "dateOfBirth": "RomBcUU8", "displayName": "6i9DJulX", "languageTag": "4aR8w6Q4", "userName": "PkLkwcg4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 285 'PublicUpdateUserV4' test.out

#- 286 PublicUpdateUserEmailAddressV4
# body param: body
echo '{"code": "w7voonsT", "emailAddress": "uM2oBECn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserEmailAddressV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 286 'PublicUpdateUserEmailAddressV4' test.out

#- 287 PublicUpgradeHeadlessAccountWithVerificationCodeV4
# body param: body
echo '{"code": "fwi61igq", "country": "pB4WwKtA", "dateOfBirth": "nQQIfNq8", "displayName": "tkbUlxAf", "emailAddress": "BvJ3twKU", "password": "1E8SglSH", "reachMinimumAge": true, "username": "OBkao6x7", "validateOnly": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpgradeHeadlessAccountWithVerificationCodeV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 287 'PublicUpgradeHeadlessAccountWithVerificationCodeV4' test.out

#- 288 PublicUpgradeHeadlessAccountV4
# body param: body
echo '{"emailAddress": "SKfNZdIG", "password": "HiCd3vs4", "username": "8k8GmWbZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpgradeHeadlessAccountV4 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 288 'PublicUpgradeHeadlessAccountV4' test.out

#- 289 PublicDisableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op PublicDisableMyAuthenticatorV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 289 'PublicDisableMyAuthenticatorV4' test.out

#- 290 PublicEnableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op PublicEnableMyAuthenticatorV4 \
    --namespace $AB_NAMESPACE \
    --code 'OgcnbkNs' \
    > test.out 2>&1
eval_tap $? 290 'PublicEnableMyAuthenticatorV4' test.out

#- 291 PublicGenerateMyAuthenticatorKeyV4
$CLI_EXE \
    --sn iam \
    --op PublicGenerateMyAuthenticatorKeyV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 291 'PublicGenerateMyAuthenticatorKeyV4' test.out

#- 292 PublicGetMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicGetMyBackupCodesV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 292 'PublicGetMyBackupCodesV4' test.out

#- 293 PublicGenerateMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicGenerateMyBackupCodesV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 293 'PublicGenerateMyBackupCodesV4' test.out

#- 294 PublicDisableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicDisableMyBackupCodesV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 294 'PublicDisableMyBackupCodesV4' test.out

#- 295 PublicDownloadMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicDownloadMyBackupCodesV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 295 'PublicDownloadMyBackupCodesV4' test.out

#- 296 PublicEnableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicEnableMyBackupCodesV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 296 'PublicEnableMyBackupCodesV4' test.out

#- 297 PublicRemoveTrustedDeviceV4
$CLI_EXE \
    --sn iam \
    --op PublicRemoveTrustedDeviceV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 297 'PublicRemoveTrustedDeviceV4' test.out

#- 298 PublicGetMyEnabledFactorsV4
$CLI_EXE \
    --sn iam \
    --op PublicGetMyEnabledFactorsV4 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 298 'PublicGetMyEnabledFactorsV4' test.out

#- 299 PublicMakeFactorMyDefaultV4
$CLI_EXE \
    --sn iam \
    --op PublicMakeFactorMyDefaultV4 \
    --namespace $AB_NAMESPACE \
    --factor 'JBKfFAZF' \
    > test.out 2>&1
eval_tap $? 299 'PublicMakeFactorMyDefaultV4' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE