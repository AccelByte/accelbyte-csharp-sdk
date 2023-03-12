#!/usr/bin/env bash

# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

# This code is generated by tool. DO NOT EDIT.

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
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.json"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"

echo "TAP version 13"
echo "1..67"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetNamespaces
$CLI_EXE \
    --sn basic \
    --op GetNamespaces \
    --activeOnly 'false' \
    > test.out 2>&1
eval_tap $? 2 'GetNamespaces' test.out

#- 3 CreateNamespace
# body param: body
echo '{"displayName": "Yi3wMWno", "namespace": "ZgIhwb8Y"}' > $TEMP_JSON_INPUT
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
    --activeOnly 'false' \
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
echo '{"actionId": 79, "comment": "0PbemSBE", "userIds": ["LbZ0VBUG", "A7nkDeev", "2Oj060Hn"]}' > $TEMP_JSON_INPUT
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
    --userIds '["Of5S8X1L", "xkZs4233", "oQWoXFeq"]' \
    > test.out 2>&1
eval_tap $? 8 'GetBannedUsers' test.out

#- 9 ReportUser
# body param: body
echo '{"category": "euI2oMJ0", "description": "cgAoGfXe", "gameSessionId": "pE3r5AQU", "subcategory": "BqS8KtTY", "userId": "ZLJ58Qqc"}' > $TEMP_JSON_INPUT
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
    --userId 'V3IcuNs9' \
    > test.out 2>&1
eval_tap $? 10 'GetUserStatus' test.out

#- 11 UnBanUsers
# body param: body
echo '{"comment": "MF5BT2KD", "userIds": ["18yrWorp", "C65VJh4q", "1z1KJmKe"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UnBanUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UnBanUsers' test.out

#- 12 UpdateNamespace
# body param: body
echo '{"displayName": "dBfbWvKa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateNamespace' test.out

#- 13 CreateConfig
# body param: body
echo '{"key": "5Ou124Ts", "value": "bQsxYFxG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'CreateConfig' test.out

#- 14 GetConfig1
$CLI_EXE \
    --sn basic \
    --op GetConfig1 \
    --configKey 'GHrfQkgX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'GetConfig1' test.out

#- 15 DeleteConfig1
$CLI_EXE \
    --sn basic \
    --op DeleteConfig1 \
    --configKey 'kiA5IZPq' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DeleteConfig1' test.out

#- 16 UpdateConfig1
# body param: body
echo '{"value": "Cqp9vcyt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig1 \
    --configKey '67WAfWXf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdateConfig1' test.out

#- 17 GetConfig
$CLI_EXE \
    --sn basic \
    --op GetConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetConfig' test.out

#- 18 DeleteConfig
$CLI_EXE \
    --sn basic \
    --op DeleteConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'DeleteConfig' test.out

#- 19 UpdateConfig
# body param: body
echo '{"apiKey": "UfwGB03t"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateConfig' test.out

#- 20 GeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUploadUrl \
    --folder 'z8qIH4uR' \
    --namespace $AB_NAMESPACE \
    --fileType 'dNO08HN6' \
    > test.out 2>&1
eval_tap $? 20 'GeneratedUploadUrl' test.out

#- 21 GetGameNamespaces
$CLI_EXE \
    --sn basic \
    --op GetGameNamespaces \
    --namespace $AB_NAMESPACE \
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 21 'GetGameNamespaces' test.out

#- 22 GetCountries
$CLI_EXE \
    --sn basic \
    --op GetCountries \
    --namespace $AB_NAMESPACE \
    --lang '6K2wEMnc' \
    > test.out 2>&1
eval_tap $? 22 'GetCountries' test.out

#- 23 GetCountryGroups
$CLI_EXE \
    --sn basic \
    --op GetCountryGroups \
    --namespace $AB_NAMESPACE \
    --groupCode 'kjlW6Byw' \
    > test.out 2>&1
eval_tap $? 23 'GetCountryGroups' test.out

#- 24 AddCountryGroup
# body param: body
echo '{"countries": [{"code": "sSSZTGlu", "name": "bsmhjXcS"}, {"code": "cOUvrjJB", "name": "O7tbkTGY"}, {"code": "KqRMSTis", "name": "P0MrSdaF"}], "countryGroupCode": "y0pJYCdf", "countryGroupName": "kfyt09ro"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AddCountryGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AddCountryGroup' test.out

#- 25 UpdateCountryGroup
# body param: body
echo '{"countries": [{"code": "5fHdWqJT", "name": "NjrmpnnE"}, {"code": "ckHH8kT9", "name": "oXVander"}, {"code": "cf1nq4Hf", "name": "32SL5Pja"}], "countryGroupName": "YEDxaYN8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCountryGroup \
    --countryGroupCode 'w9KUW0py' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateCountryGroup' test.out

#- 26 DeleteCountryGroup
$CLI_EXE \
    --sn basic \
    --op DeleteCountryGroup \
    --countryGroupCode '8KrcQfuc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'DeleteCountryGroup' test.out

#- 27 GetLanguages
$CLI_EXE \
    --sn basic \
    --op GetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'GetLanguages' test.out

#- 28 GetTimeZones
$CLI_EXE \
    --sn basic \
    --op GetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'GetTimeZones' test.out

#- 29 GetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'Sq2X8gFu' \
    > test.out 2>&1
eval_tap $? 29 'GetUserProfileInfoByPublicId' test.out

#- 30 AdminGetUserProfilePublicInfoByIds
# body param: body
echo '{"userIds": ["JORk4j04", "YfnXTsQU", "rA0WWyKl"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AdminGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminGetUserProfilePublicInfoByIds' test.out

#- 31 GetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op GetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'GetNamespacePublisher' test.out

#- 32 ChangeNamespaceStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ChangeNamespaceStatus \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'ChangeNamespaceStatus' test.out

#- 33 AnonymizeUserProfile
$CLI_EXE \
    --sn basic \
    --op AnonymizeUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'K5mCSoGe' \
    > test.out 2>&1
eval_tap $? 33 'AnonymizeUserProfile' test.out

#- 34 GeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'QCahcox6' \
    --category '3cyDxAAY' \
    --fileType 'cRXJdoST' \
    > test.out 2>&1
eval_tap $? 34 'GeneratedUserUploadContentUrl' test.out

#- 35 GetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'xNCK9AIj' \
    > test.out 2>&1
eval_tap $? 35 'GetUserProfileInfo' test.out

#- 36 UpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "NmbfoW8b", "avatarSmallUrl": "Dq5jPqzh", "avatarUrl": "N0YdGSrA", "customAttributes": {"9LXRwU6W": {}, "LgpQE9nX": {}, "zhBC0uyM": {}}, "dateOfBirth": "1993-06-09", "firstName": "4Xf2nfYv", "language": "gWEh", "lastName": "uQ14Ahsx", "status": "ACTIVE", "timeZone": "Njxyw7RH", "zipCode": "ldq0m7Nj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'UZ95Z5XD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'UpdateUserProfile' test.out

#- 37 DeleteUserProfile
$CLI_EXE \
    --sn basic \
    --op DeleteUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'LBN9YGVP' \
    > test.out 2>&1
eval_tap $? 37 'DeleteUserProfile' test.out

#- 38 GetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'tkjt0OyB' \
    > test.out 2>&1
eval_tap $? 38 'GetCustomAttributesInfo' test.out

#- 39 UpdateCustomAttributesPartially
# body param: body
echo '{"lJi4RbZ0": {}, "Iy11mfOF": {}, "jCzZVcGo": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'mWF1oAqU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'UpdateCustomAttributesPartially' test.out

#- 40 GetPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'NFDtXnXL' \
    > test.out 2>&1
eval_tap $? 40 'GetPrivateCustomAttributesInfo' test.out

#- 41 UpdatePrivateCustomAttributesPartially
# body param: body
echo '{"vOAsW8wY": {}, "h4gq7pRV": {}, "ZVLJiDx3": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdatePrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'au9b9Qjh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'UpdatePrivateCustomAttributesPartially' test.out

#- 42 UpdateUserProfileStatus
# body param: body
echo '{"status": "INACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'MRkcOr1L' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateUserProfileStatus' test.out

#- 43 PublicGetTime
$CLI_EXE \
    --sn basic \
    --op PublicGetTime \
    > test.out 2>&1
eval_tap $? 43 'PublicGetTime' test.out

#- 44 PublicGetNamespaces
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespaces \
    --activeOnly 'false' \
    > test.out 2>&1
eval_tap $? 44 'PublicGetNamespaces' test.out

#- 45 PublicGeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUploadUrl \
    --folder 'TMIczbYi' \
    --namespace $AB_NAMESPACE \
    --fileType 'lOziwG8C' \
    > test.out 2>&1
eval_tap $? 45 'PublicGeneratedUploadUrl' test.out

#- 46 PublicGetCountries
$CLI_EXE \
    --sn basic \
    --op PublicGetCountries \
    --namespace $AB_NAMESPACE \
    --lang 'PLOzSZm9' \
    > test.out 2>&1
eval_tap $? 46 'PublicGetCountries' test.out

#- 47 PublicGetLanguages
$CLI_EXE \
    --sn basic \
    --op PublicGetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'PublicGetLanguages' test.out

#- 48 PublicGetTimeZones
$CLI_EXE \
    --sn basic \
    --op PublicGetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'PublicGetTimeZones' test.out

#- 49 PublicGetUserProfilePublicInfoByIds
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --userIds 'K3cMY617' \
    > test.out 2>&1
eval_tap $? 49 'PublicGetUserProfilePublicInfoByIds' test.out

#- 50 PublicGetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'HSCYZaL4' \
    > test.out 2>&1
eval_tap $? 50 'PublicGetUserProfileInfoByPublicId' test.out

#- 51 PublicGetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'PublicGetNamespacePublisher' test.out

#- 52 GetMyProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetMyProfileInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'GetMyProfileInfo' test.out

#- 53 UpdateMyProfile
# body param: body
echo '{"avatarLargeUrl": "6I3PgCcQ", "avatarSmallUrl": "0axTWnmy", "avatarUrl": "EYLZQTpv", "customAttributes": {"LH6QPEBP": {}, "8kSSFjeu": {}, "L3wQQPYw": {}}, "dateOfBirth": "1977-06-21", "firstName": "YFbxRvHY", "language": "adm_XNha", "lastName": "H7fz4BdP", "privateCustomAttributes": {"hLtHRJOI": {}, "mSq37aeA": {}, "aGq0NIj5": {}}, "timeZone": "3gXkmray", "zipCode": "vcIYiWxI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'UpdateMyProfile' test.out

#- 54 CreateMyProfile
# body param: body
echo '{"avatarLargeUrl": "AxfvLzSp", "avatarSmallUrl": "DFY3lxe1", "avatarUrl": "6KsSRzkf", "customAttributes": {"2HzBcEio": {}, "5UyvuFv5": {}, "z6wosJGn": {}}, "dateOfBirth": "1995-12-12", "firstName": "yCMEbHh1", "language": "vfY_tdVJ", "lastName": "jaNCRV3h", "privateCustomAttributes": {"SIiTEoTC": {}, "SxjAqg9o": {}, "GVEdC8mQ": {}}, "timeZone": "ir1Af0G6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'CreateMyProfile' test.out

#- 55 GetMyPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetMyPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'GetMyPrivateCustomAttributesInfo' test.out

#- 56 UpdateMyPrivateCustomAttributesPartially
# body param: body
echo '{"OrPH6Zsj": {}, "pPgHKISH": {}, "tB8tWdJM": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyPrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'UpdateMyPrivateCustomAttributesPartially' test.out

#- 57 GetMyZipCode
$CLI_EXE \
    --sn basic \
    --op GetMyZipCode \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'GetMyZipCode' test.out

#- 58 UpdateMyZipCode
# body param: userZipCodeUpdate
echo '{"zipCode": "9Qc5HmR0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyZipCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'UpdateMyZipCode' test.out

#- 59 PublicReportUser
# body param: body
echo '{"category": "vknXO45A", "description": "UtNXSTIt", "gameSessionId": "t35OJTfJ", "subcategory": "BZX62yI9", "userId": "g5RDrlzP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicReportUser \
    --namespace $AB_NAMESPACE \
    --userId 'FQmNu3ER' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'PublicReportUser' test.out

#- 60 PublicGeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'xV0UTaiS' \
    --category 'zfi0FnBE' \
    --fileType 'Re8qNYRT' \
    > test.out 2>&1
eval_tap $? 60 'PublicGeneratedUserUploadContentUrl' test.out

#- 61 PublicGetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'YSaZw4Nq' \
    > test.out 2>&1
eval_tap $? 61 'PublicGetUserProfileInfo' test.out

#- 62 PublicUpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "SNylclju", "avatarSmallUrl": "NM3eUUSD", "avatarUrl": "1pZGMfPd", "customAttributes": {"GIOAZ86u": {}, "n0L98WUo": {}, "XvfU4qMI": {}}, "dateOfBirth": "1979-02-13", "firstName": "jCpNtJSM", "language": "Xs_Ds", "lastName": "K2r4wWs6", "timeZone": "IpYBxafo", "zipCode": "9b4xJyNn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'vHKrm8Uu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicUpdateUserProfile' test.out

#- 63 PublicCreateUserProfile
# body param: body
echo '{"avatarLargeUrl": "NlT86N9y", "avatarSmallUrl": "O0vyD6J5", "avatarUrl": "brVo20e6", "customAttributes": {"POTjrinA": {}, "VVovpAAX": {}, "NzcpbmX3": {}}, "dateOfBirth": "1977-01-14", "firstName": "LFeXCiaX", "language": "Kvbd", "lastName": "K81t2V9T", "timeZone": "VauFcGkP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicCreateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'gQ0hb2tL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'PublicCreateUserProfile' test.out

#- 64 PublicGetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'rsMeoZiR' \
    > test.out 2>&1
eval_tap $? 64 'PublicGetCustomAttributesInfo' test.out

#- 65 PublicUpdateCustomAttributesPartially
# body param: body
echo '{"YkbhEM1z": {}, "TNY3lpin": {}, "cuf5d5sa": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'QvKfFRqB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PublicUpdateCustomAttributesPartially' test.out

#- 66 PublicGetUserProfilePublicInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfo \
    --namespace $AB_NAMESPACE \
    --userId 'am8jPtKH' \
    > test.out 2>&1
eval_tap $? 66 'PublicGetUserProfilePublicInfo' test.out

#- 67 PublicUpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'HEWQMmCk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicUpdateUserProfileStatus' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE