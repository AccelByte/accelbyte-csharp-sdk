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
echo "1..58"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetNamespaces
$CLI_EXE \
    --sn basic \
    --op GetNamespaces \
    --activeOnly 'False' \
    > test.out 2>&1
eval_tap $? 2 'GetNamespaces' test.out

#- 3 CreateNamespace
# body param: body
echo '{"displayName": "0Cjv4Ax7", "namespace": "NzYkoppa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateNamespace \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateNamespace' test.out

#- 4 GetNamespace
$CLI_EXE \
    --sn basic \
    --op GetNamespace \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    > test.out 2>&1
eval_tap $? 4 'GetNamespace' test.out

#- 5 DeleteNamespace
$CLI_EXE \
    --sn basic \
    --op DeleteNamespace \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'DeleteNamespace' test.out

#- 6 GetActions
$CLI_EXE \
    --sn basic \
    --op GetActions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'GetActions' test.out

#- 7 BanUsers
# body param: body
echo '{"actionId": 63, "comment": "JAhHwTb5", "userIds": ["q010gN2M"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op BanUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'BanUsers' test.out

#- 8 GetBannedUsers
$CLI_EXE \
    --sn basic \
    --op GetBannedUsers \
    --namespace $AB_NAMESPACE \
    --userIds '["QrbpeRnx"]' \
    > test.out 2>&1
eval_tap $? 8 'GetBannedUsers' test.out

#- 9 ReportUser
# body param: body
echo '{"category": "TlCTFSMI", "description": "bl1a2jXL", "gameSessionId": "CtWmHJBi", "subcategory": "9SoMkSE4", "userId": "eJelwO4K"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ReportUser \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'ReportUser' test.out

#- 10 GetUserStatus
$CLI_EXE \
    --sn basic \
    --op GetUserStatus \
    --namespace $AB_NAMESPACE \
    --userId 'PMky2h8R' \
    > test.out 2>&1
eval_tap $? 10 'GetUserStatus' test.out

#- 11 UnBanUsers
# body param: body
echo '{"comment": "2fIXoXP8", "userIds": ["gd7JUabY"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UnBanUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UnBanUsers' test.out

#- 12 UpdateNamespace
# body param: body
echo '{"displayName": "c3GMbxTl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateNamespace' test.out

#- 13 GetConfig
$CLI_EXE \
    --sn basic \
    --op GetConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetConfig' test.out

#- 14 DeleteConfig
$CLI_EXE \
    --sn basic \
    --op DeleteConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteConfig' test.out

#- 15 UpdateConfig
# body param: body
echo '{"apiKey": "m1fsu6J3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdateConfig' test.out

#- 16 GeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUploadUrl \
    --folder 'C4s5ppGR' \
    --namespace $AB_NAMESPACE \
    --fileType '9XcoxYTG' \
    > test.out 2>&1
eval_tap $? 16 'GeneratedUploadUrl' test.out

#- 17 GetCountries
$CLI_EXE \
    --sn basic \
    --op GetCountries \
    --namespace $AB_NAMESPACE \
    --lang 'gewrLfwv' \
    > test.out 2>&1
eval_tap $? 17 'GetCountries' test.out

#- 18 GetCountryGroups
$CLI_EXE \
    --sn basic \
    --op GetCountryGroups \
    --namespace $AB_NAMESPACE \
    --groupCode 'zJF4TpbN' \
    > test.out 2>&1
eval_tap $? 18 'GetCountryGroups' test.out

#- 19 AddCountryGroup
# body param: body
echo '{"countries": [{"code": "hKq2xdmg", "name": "EBepFHtf"}], "countryGroupCode": "6ZiegqdE", "countryGroupName": "L4fsM6nB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AddCountryGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AddCountryGroup' test.out

#- 20 UpdateCountryGroup
# body param: body
echo '{"countries": [{"code": "zRVuC1r7", "name": "UH1Liu7U"}], "countryGroupName": "Q0304McK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCountryGroup \
    --countryGroupCode '873tRtr5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateCountryGroup' test.out

#- 21 DeleteCountryGroup
$CLI_EXE \
    --sn basic \
    --op DeleteCountryGroup \
    --countryGroupCode 'cfWO5JJ2' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'DeleteCountryGroup' test.out

#- 22 GetLanguages
$CLI_EXE \
    --sn basic \
    --op GetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'GetLanguages' test.out

#- 23 GetTimeZones
$CLI_EXE \
    --sn basic \
    --op GetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'GetTimeZones' test.out

#- 24 AdminGetUserProfilePublicInfoByIds
# body param: body
echo '{"userIds": ["c6vsOns4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AdminGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminGetUserProfilePublicInfoByIds' test.out

#- 25 GetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op GetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'GetNamespacePublisher' test.out

#- 26 ChangeNamespaceStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ChangeNamespaceStatus \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'ChangeNamespaceStatus' test.out

#- 27 AnonymizeUserProfile
$CLI_EXE \
    --sn basic \
    --op AnonymizeUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'NWGc7CiU' \
    > test.out 2>&1
eval_tap $? 27 'AnonymizeUserProfile' test.out

#- 28 GeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'a4wM5Eu3' \
    --fileType 'VqymsFXp' \
    > test.out 2>&1
eval_tap $? 28 'GeneratedUserUploadContentUrl' test.out

#- 29 GetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'orMqEDR8' \
    > test.out 2>&1
eval_tap $? 29 'GetUserProfileInfo' test.out

#- 30 UpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "E72XMKfh", "avatarSmallUrl": "l6eq2FzU", "avatarUrl": "3VL3LNmP", "customAttributes": {"LeZdoCXf": {}}, "dateOfBirth": "0765-04-03", "firstName": "7fPKvE2Z", "language": "uv_SYZM-xG", "lastName": "vSrkEgTY", "status": "ACTIVE", "timeZone": "5iRBE6zJ", "zipCode": "J1BRHrfC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'Hqqp2GwP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateUserProfile' test.out

#- 31 DeleteUserProfile
$CLI_EXE \
    --sn basic \
    --op DeleteUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'cmzSuY8w' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserProfile' test.out

#- 32 GetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId '9VYwBEfR' \
    > test.out 2>&1
eval_tap $? 32 'GetCustomAttributesInfo' test.out

#- 33 UpdateCustomAttributesPartially
# body param: body
echo '{"XoZLfpVF": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'fDwjHHCW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateCustomAttributesPartially' test.out

#- 34 GetPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId '2g5u8z9y' \
    > test.out 2>&1
eval_tap $? 34 'GetPrivateCustomAttributesInfo' test.out

#- 35 UpdatePrivateCustomAttributesPartially
# body param: body
echo '{"rpJdIx5v": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdatePrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'vHS3d6PK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdatePrivateCustomAttributesPartially' test.out

#- 36 UpdateUserProfileStatus
# body param: body
echo '{"status": "INACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId '27mI6Px8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'UpdateUserProfileStatus' test.out

#- 37 PublicGetTime
$CLI_EXE \
    --sn basic \
    --op PublicGetTime \
    > test.out 2>&1
eval_tap $? 37 'PublicGetTime' test.out

#- 38 PublicGetNamespaces
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespaces \
    --activeOnly 'False' \
    > test.out 2>&1
eval_tap $? 38 'PublicGetNamespaces' test.out

#- 39 PublicGeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUploadUrl \
    --folder 't8Lq4x0F' \
    --namespace $AB_NAMESPACE \
    --fileType '7NcocelJ' \
    > test.out 2>&1
eval_tap $? 39 'PublicGeneratedUploadUrl' test.out

#- 40 PublicGetCountries
$CLI_EXE \
    --sn basic \
    --op PublicGetCountries \
    --namespace $AB_NAMESPACE \
    --lang 'jtlKYu8i' \
    > test.out 2>&1
eval_tap $? 40 'PublicGetCountries' test.out

#- 41 PublicGetLanguages
$CLI_EXE \
    --sn basic \
    --op PublicGetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 41 'PublicGetLanguages' test.out

#- 42 PublicGetTimeZones
$CLI_EXE \
    --sn basic \
    --op PublicGetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'PublicGetTimeZones' test.out

#- 43 PublicGetUserProfilePublicInfoByIds
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --userIds 'CPznx0s5' \
    > test.out 2>&1
eval_tap $? 43 'PublicGetUserProfilePublicInfoByIds' test.out

#- 44 PublicGetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'PublicGetNamespacePublisher' test.out

#- 45 GetMyProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetMyProfileInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 45 'GetMyProfileInfo' test.out

#- 46 UpdateMyProfile
# body param: body
echo '{"avatarLargeUrl": "TzT51oV4", "avatarSmallUrl": "HTmivmb6", "avatarUrl": "tPmCirkh", "customAttributes": {"YvcOUucj": {}}, "dateOfBirth": "4529-10-31", "firstName": "93utbMkp", "language": "fhtF-IqTs_006", "lastName": "G4zA2zp1", "privateCustomAttributes": {"Ls0bD6dG": {}}, "timeZone": "gwkYgHzK", "zipCode": "uI2RJrbo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'UpdateMyProfile' test.out

#- 47 CreateMyProfile
# body param: body
echo '{"avatarLargeUrl": "P7kfpIle", "avatarSmallUrl": "tXrCK1UV", "avatarUrl": "O0jcs7nC", "customAttributes": {"qsodoTFT": {}}, "dateOfBirth": "2086-11-04", "firstName": "U6HobZgW", "language": "Al", "lastName": "dDfasTc8", "privateCustomAttributes": {"gr2znWqD": {}}, "timeZone": "6tIcfI5Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'CreateMyProfile' test.out

#- 48 GetMyZipCode
$CLI_EXE \
    --sn basic \
    --op GetMyZipCode \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'GetMyZipCode' test.out

#- 49 UpdateMyZipCode
# body param: userZipCodeUpdate
echo '{"zipCode": "4tUNQ7mQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyZipCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'UpdateMyZipCode' test.out

#- 50 PublicReportUser
# body param: body
echo '{"category": "PjCalZgF", "description": "VEQyqav0", "gameSessionId": "9OYmxCvM", "subcategory": "qVcXs2Oq", "userId": "Nz8ZLBsn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicReportUser \
    --namespace $AB_NAMESPACE \
    --userId 'cbRrf6uE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicReportUser' test.out

#- 51 PublicGeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'djUnr04W' \
    --fileType 'ZNhgEGvq' \
    > test.out 2>&1
eval_tap $? 51 'PublicGeneratedUserUploadContentUrl' test.out

#- 52 PublicGetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'KWQTkE65' \
    > test.out 2>&1
eval_tap $? 52 'PublicGetUserProfileInfo' test.out

#- 53 PublicUpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "j6186p0W", "avatarSmallUrl": "fsnWZuUP", "avatarUrl": "saRnVdrd", "customAttributes": {"BA2hXwYy": {}}, "dateOfBirth": "9020-04-21", "firstName": "TfofHdfo", "language": "QdCA_OkXi", "lastName": "5ocfy4EI", "timeZone": "xwBiB90v", "zipCode": "dgS5YpKs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'dbpiU2Uf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'PublicUpdateUserProfile' test.out

#- 54 PublicCreateUserProfile
# body param: body
echo '{"avatarLargeUrl": "yMO4DhL9", "avatarSmallUrl": "fBKJvjBO", "avatarUrl": "Un3bYf5o", "customAttributes": {"uXqkbiEx": {}}, "dateOfBirth": "7274-07-02", "firstName": "wOI1P04d", "language": "hFtW-rFmX_931", "lastName": "7p2SyFDE", "timeZone": "nmYQzehP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicCreateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'BqD12Dvv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'PublicCreateUserProfile' test.out

#- 55 PublicGetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'zNNZSu5z' \
    > test.out 2>&1
eval_tap $? 55 'PublicGetCustomAttributesInfo' test.out

#- 56 PublicUpdateCustomAttributesPartially
# body param: body
echo '{"ZVgY3Zos": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'fd01vaOG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PublicUpdateCustomAttributesPartially' test.out

#- 57 PublicGetUserProfilePublicInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfo \
    --namespace $AB_NAMESPACE \
    --userId 'weHacvHR' \
    > test.out 2>&1
eval_tap $? 57 'PublicGetUserProfilePublicInfo' test.out

#- 58 PublicUpdateUserProfileStatus
# body param: body
echo '{"status": "INACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'B8hos4ya' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicUpdateUserProfileStatus' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE