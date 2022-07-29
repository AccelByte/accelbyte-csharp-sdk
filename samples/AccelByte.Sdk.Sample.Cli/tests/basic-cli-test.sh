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
echo "1..60"

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
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 2 'GetNamespaces' test.out

#- 3 CreateNamespace
# body param: body
echo '{"displayName": "WI3UBHvq", "namespace": "IymtAnp5"}' > $TEMP_JSON_INPUT
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
    --activeOnly 'true' \
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
echo '{"actionId": 40, "comment": "EiqsDnJ1", "userIds": ["gaXw5RCQ", "OdLjCJGZ", "SeQQXVad"]}' > $TEMP_JSON_INPUT
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
    --userIds '["iA4czrkc", "iQeLhjmj", "w8AgCx4a"]' \
    > test.out 2>&1
eval_tap $? 8 'GetBannedUsers' test.out

#- 9 ReportUser
# body param: body
echo '{"category": "Zwb0DZ3J", "description": "vRfq8P8i", "gameSessionId": "lElBC2iN", "subcategory": "cfr2opje", "userId": "DULVQNxa"}' > $TEMP_JSON_INPUT
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
    --userId 'm84HgJN1' \
    > test.out 2>&1
eval_tap $? 10 'GetUserStatus' test.out

#- 11 UnBanUsers
# body param: body
echo '{"comment": "nAYq4FPJ", "userIds": ["HITZ0kAu", "0JQwn6M9", "R1s3S0PJ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UnBanUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UnBanUsers' test.out

#- 12 UpdateNamespace
# body param: body
echo '{"displayName": "0EaU5plt"}' > $TEMP_JSON_INPUT
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
echo '{"apiKey": "qIy4oSW6"}' > $TEMP_JSON_INPUT
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
    --folder 'Ci9pzUSm' \
    --namespace $AB_NAMESPACE \
    --fileType 'EFuce6ci' \
    > test.out 2>&1
eval_tap $? 16 'GeneratedUploadUrl' test.out

#- 17 GetCountries
$CLI_EXE \
    --sn basic \
    --op GetCountries \
    --namespace $AB_NAMESPACE \
    --lang 'qwr33Wse' \
    > test.out 2>&1
eval_tap $? 17 'GetCountries' test.out

#- 18 GetCountryGroups
$CLI_EXE \
    --sn basic \
    --op GetCountryGroups \
    --namespace $AB_NAMESPACE \
    --groupCode 'Fc0qhPKF' \
    > test.out 2>&1
eval_tap $? 18 'GetCountryGroups' test.out

#- 19 AddCountryGroup
# body param: body
echo '{"countries": [{"code": "jmXNHir5", "name": "DBmLcPmn"}, {"code": "TTgOgis2", "name": "L5B5UuLx"}, {"code": "mgM0ZwOG", "name": "ecIQ7pNE"}], "countryGroupCode": "CCUFKmvX", "countryGroupName": "QO5fJjNc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AddCountryGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AddCountryGroup' test.out

#- 20 UpdateCountryGroup
# body param: body
echo '{"countries": [{"code": "IDCl1Hxz", "name": "GwYOqo60"}, {"code": "9Tz1glkb", "name": "lie4fCre"}, {"code": "xEFG9XAQ", "name": "ikB78G3i"}], "countryGroupName": "MMbCEAni"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCountryGroup \
    --countryGroupCode 'zJo1CBLH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateCountryGroup' test.out

#- 21 DeleteCountryGroup
$CLI_EXE \
    --sn basic \
    --op DeleteCountryGroup \
    --countryGroupCode 'uXasvXtJ' \
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

#- 24 GetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId '9MUMdVOa' \
    > test.out 2>&1
eval_tap $? 24 'GetUserProfileInfoByPublicId' test.out

#- 25 AdminGetUserProfilePublicInfoByIds
# body param: body
echo '{"userIds": ["1CiAA9Ub", "VefvRctQ", "p2IAV8Ob"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AdminGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminGetUserProfilePublicInfoByIds' test.out

#- 26 GetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op GetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'GetNamespacePublisher' test.out

#- 27 ChangeNamespaceStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ChangeNamespaceStatus \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'ChangeNamespaceStatus' test.out

#- 28 AnonymizeUserProfile
$CLI_EXE \
    --sn basic \
    --op AnonymizeUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'yHupeo1Z' \
    > test.out 2>&1
eval_tap $? 28 'AnonymizeUserProfile' test.out

#- 29 GeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'OM82QAfZ' \
    --category 'NcorBKrL' \
    --fileType 'fTJz4I0M' \
    > test.out 2>&1
eval_tap $? 29 'GeneratedUserUploadContentUrl' test.out

#- 30 GetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'wa6Qsl1m' \
    > test.out 2>&1
eval_tap $? 30 'GetUserProfileInfo' test.out

#- 31 UpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "rcI6mp9e", "avatarSmallUrl": "qpHWI1ZQ", "avatarUrl": "7NwTCgu4", "customAttributes": {"lGGqH1t1": {}, "DQAp34tV": {}, "IV66DfL9": {}}, "dateOfBirth": "1999-04-26", "firstName": "CrkKvmfK", "language": "DuT", "lastName": "5N2t5HpL", "status": "INACTIVE", "timeZone": "5pNAJrK7", "zipCode": "04A8sZfB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'MIngzR8C' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'UpdateUserProfile' test.out

#- 32 DeleteUserProfile
$CLI_EXE \
    --sn basic \
    --op DeleteUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'YDTCV95X' \
    > test.out 2>&1
eval_tap $? 32 'DeleteUserProfile' test.out

#- 33 GetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'P4zA8p5v' \
    > test.out 2>&1
eval_tap $? 33 'GetCustomAttributesInfo' test.out

#- 34 UpdateCustomAttributesPartially
# body param: body
echo '{"JNwmLPNw": {}, "tRuKDQnZ": {}, "it37Q97o": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'uT6zw0tn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateCustomAttributesPartially' test.out

#- 35 GetPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'lSaeDZfd' \
    > test.out 2>&1
eval_tap $? 35 'GetPrivateCustomAttributesInfo' test.out

#- 36 UpdatePrivateCustomAttributesPartially
# body param: body
echo '{"W1k61i8H": {}, "JxjWumwD": {}, "2T9Cxzd1": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdatePrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'CMheQ3ly' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'UpdatePrivateCustomAttributesPartially' test.out

#- 37 UpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'oRXBUUC4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateUserProfileStatus' test.out

#- 38 PublicGetTime
$CLI_EXE \
    --sn basic \
    --op PublicGetTime \
    > test.out 2>&1
eval_tap $? 38 'PublicGetTime' test.out

#- 39 PublicGetNamespaces
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespaces \
    --activeOnly 'false' \
    > test.out 2>&1
eval_tap $? 39 'PublicGetNamespaces' test.out

#- 40 PublicGeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUploadUrl \
    --folder 'F5jWrBhG' \
    --namespace $AB_NAMESPACE \
    --fileType 'xXIenO0q' \
    > test.out 2>&1
eval_tap $? 40 'PublicGeneratedUploadUrl' test.out

#- 41 PublicGetCountries
$CLI_EXE \
    --sn basic \
    --op PublicGetCountries \
    --namespace $AB_NAMESPACE \
    --lang '4d25OLJ7' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCountries' test.out

#- 42 PublicGetLanguages
$CLI_EXE \
    --sn basic \
    --op PublicGetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'PublicGetLanguages' test.out

#- 43 PublicGetTimeZones
$CLI_EXE \
    --sn basic \
    --op PublicGetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'PublicGetTimeZones' test.out

#- 44 PublicGetUserProfilePublicInfoByIds
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --userIds 'Wbgk7akh' \
    > test.out 2>&1
eval_tap $? 44 'PublicGetUserProfilePublicInfoByIds' test.out

#- 45 PublicGetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'gsJ3lUHD' \
    > test.out 2>&1
eval_tap $? 45 'PublicGetUserProfileInfoByPublicId' test.out

#- 46 PublicGetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'PublicGetNamespacePublisher' test.out

#- 47 GetMyProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetMyProfileInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'GetMyProfileInfo' test.out

#- 48 UpdateMyProfile
# body param: body
echo '{"avatarLargeUrl": "7TjoYZpr", "avatarSmallUrl": "IlgilzvV", "avatarUrl": "tca8E9q4", "customAttributes": {"rsW4zT49": {}, "Ku2s39r2": {}, "Vxx7xOqX": {}}, "dateOfBirth": "1977-01-14", "firstName": "MYj0mUFz", "language": "ID_cBIS", "lastName": "yuFwSRdE", "privateCustomAttributes": {"fejFWJwu": {}, "dxGmCZGz": {}, "AVPh8Zt9": {}}, "timeZone": "fydwDGO6", "zipCode": "GnkzMuZ5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'UpdateMyProfile' test.out

#- 49 CreateMyProfile
# body param: body
echo '{"avatarLargeUrl": "m6m46dei", "avatarSmallUrl": "qcdzJ9Ty", "avatarUrl": "MTZQPmK5", "customAttributes": {"DWJultX6": {}, "GJmScOfC": {}, "v3AoWIiw": {}}, "dateOfBirth": "1987-07-07", "firstName": "aJBcgWUE", "language": "lvzV-PZnP", "lastName": "Cl5XoHL3", "privateCustomAttributes": {"4DeNK1Gg": {}, "BCaCnPxc": {}, "RhZZcXtI": {}}, "timeZone": "TGhbmVfK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'CreateMyProfile' test.out

#- 50 GetMyZipCode
$CLI_EXE \
    --sn basic \
    --op GetMyZipCode \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'GetMyZipCode' test.out

#- 51 UpdateMyZipCode
# body param: userZipCodeUpdate
echo '{"zipCode": "mamr8MoL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyZipCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdateMyZipCode' test.out

#- 52 PublicReportUser
# body param: body
echo '{"category": "33VKeDs0", "description": "9sHojaol", "gameSessionId": "AdBUrEf3", "subcategory": "MNj4i9d5", "userId": "tsLUyL7s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicReportUser \
    --namespace $AB_NAMESPACE \
    --userId 'jqofM3DC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'PublicReportUser' test.out

#- 53 PublicGeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId '44nwf2Ry' \
    --category 'RnZF7ws2' \
    --fileType '876E7aea' \
    > test.out 2>&1
eval_tap $? 53 'PublicGeneratedUserUploadContentUrl' test.out

#- 54 PublicGetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'TJx2xCr3' \
    > test.out 2>&1
eval_tap $? 54 'PublicGetUserProfileInfo' test.out

#- 55 PublicUpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "sZv88dVE", "avatarSmallUrl": "D0Y32vWc", "avatarUrl": "k7GNDSpz", "customAttributes": {"9ur25rrR": {}, "mdH6LUn6": {}, "zOkaYTaM": {}}, "dateOfBirth": "1976-06-08", "firstName": "dPUJmnKL", "language": "iYWQ-wCMl-PQ", "lastName": "jwQBEbOx", "timeZone": "W3UDH9FL", "zipCode": "nRCPaKqt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'KCHMRw24' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'PublicUpdateUserProfile' test.out

#- 56 PublicCreateUserProfile
# body param: body
echo '{"avatarLargeUrl": "mGvgn6i3", "avatarSmallUrl": "EAgXdcYW", "avatarUrl": "Sx5kZbbT", "customAttributes": {"Il3jgd8r": {}, "YPc498NY": {}, "EBWsL4IS": {}}, "dateOfBirth": "1996-01-16", "firstName": "97XLPztW", "language": "KcVw-hmic_895", "lastName": "NQoNteiZ", "timeZone": "RdpGWG6w"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicCreateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'QlTus8Sl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PublicCreateUserProfile' test.out

#- 57 PublicGetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'AbUSuAnD' \
    > test.out 2>&1
eval_tap $? 57 'PublicGetCustomAttributesInfo' test.out

#- 58 PublicUpdateCustomAttributesPartially
# body param: body
echo '{"ghIqRpih": {}, "h3PmTknU": {}, "cjwIVfI2": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'ZxiWaFgX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicUpdateCustomAttributesPartially' test.out

#- 59 PublicGetUserProfilePublicInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfo \
    --namespace $AB_NAMESPACE \
    --userId 't0TwkTAv' \
    > test.out 2>&1
eval_tap $? 59 'PublicGetUserProfilePublicInfo' test.out

#- 60 PublicUpdateUserProfileStatus
# body param: body
echo '{"status": "INACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'tiBZIzMD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicUpdateUserProfileStatus' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE