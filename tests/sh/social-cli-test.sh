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
echo "1..70"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetNamespaceSlotConfig
$CLI_EXE \
    --sn social \
    --op GetNamespaceSlotConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 2 'GetNamespaceSlotConfig' test.out

#- 3 UpdateNamespaceSlotConfig
# body param: body
echo '{"maxSlotSize": 2, "maxSlots": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateNamespaceSlotConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'UpdateNamespaceSlotConfig' test.out

#- 4 DeleteNamespaceSlotConfig
$CLI_EXE \
    --sn social \
    --op DeleteNamespaceSlotConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'DeleteNamespaceSlotConfig' test.out

#- 5 GetUserSlotConfig
$CLI_EXE \
    --sn social \
    --op GetUserSlotConfig \
    --namespace $AB_NAMESPACE \
    --userId 'jv4Ax7Nz' \
    > test.out 2>&1
eval_tap $? 5 'GetUserSlotConfig' test.out

#- 6 UpdateUserSlotConfig
# body param: body
echo '{"maxSlotSize": 100, "maxSlots": 21}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserSlotConfig \
    --namespace $AB_NAMESPACE \
    --userId 'oppa0VgF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'UpdateUserSlotConfig' test.out

#- 7 DeleteUserSlotConfig
$CLI_EXE \
    --sn social \
    --op DeleteUserSlotConfig \
    --namespace $AB_NAMESPACE \
    --userId 'JAhHwTb5' \
    > test.out 2>&1
eval_tap $? 7 'DeleteUserSlotConfig' test.out

#- 8 GetUserProfiles
$CLI_EXE \
    --sn social \
    --op GetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'q010gN2M' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'QrbpeRnx' \
    --userId 'TlCTFSMI' \
    > test.out 2>&1
eval_tap $? 9 'GetProfile' test.out

#- 10 GetUserNamespaceSlots
$CLI_EXE \
    --sn social \
    --op GetUserNamespaceSlots \
    --namespace $AB_NAMESPACE \
    --userId 'bl1a2jXL' \
    > test.out 2>&1
eval_tap $? 10 'GetUserNamespaceSlots' test.out

#- 11 GetSlotData
$CLI_EXE \
    --sn social \
    --op GetSlotData \
    --namespace $AB_NAMESPACE \
    --slotId 'CtWmHJBi' \
    --userId '9SoMkSE4' \
    > test.out 2>&1
eval_tap $? 11 'GetSlotData' test.out

#- 12 PublicGetUserGameProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserGameProfiles \
    --namespace $AB_NAMESPACE \
    --userIds '["eJelwO4K"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'PMky2h8R' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["2fIXoXP8"], "attributes": {"gd7JUabY": "c3GMbxTl"}, "avatarUrl": "m1fsu6J3", "inventories": ["C4s5ppGR"], "label": "9XcoxYTG", "profileName": "gewrLfwv", "statistics": ["zJF4TpbN"], "tags": ["hKq2xdmg"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'EBepFHtf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId '6ZiegqdE' \
    --userId 'L4fsM6nB' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["zRVuC1r7"], "attributes": {"UH1Liu7U": "Q0304McK"}, "avatarUrl": "873tRtr5", "inventories": ["cfWO5JJ2"], "label": "c6vsOns4", "profileName": "jNWGc7Ci", "statistics": ["Ua4wM5Eu"], "tags": ["3VqymsFX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'porMqEDR' \
    --userId '8E72XMKf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'hl6eq2Fz' \
    --userId 'U3VL3LNm' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'PLeZdoCX' \
    --namespace $AB_NAMESPACE \
    --profileId 'fabFXzvj' \
    --userId 'Lmai7fPK' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "vE2Z4a63", "value": "UVtLbQSW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'tsyz0mGG' \
    --namespace $AB_NAMESPACE \
    --profileId 'yHHFIlIK' \
    --userId 'sXgvSrkE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'PublicUpdateAttribute' test.out

#- 20 PublicGetUserNamespaceSlots
$CLI_EXE \
    --sn social \
    --op PublicGetUserNamespaceSlots \
    --namespace $AB_NAMESPACE \
    --userId 'gTYVk5iR' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetUserNamespaceSlots' test.out

#- 21 PublicCreateUserNamespaceSlot
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op PublicCreateUserNamespaceSlot \
    --namespace $AB_NAMESPACE \
    --userId 'BE6zJJ1B' \
    --label 'RHrfCHqq' \
    --tags '["p2GwPcmz"]' \
    --checksum 'SuY8w9VY' \
    --customAttribute 'wBEfRXoZ' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'PublicCreateUserNamespaceSlot' test.out

#- 22 PublicGetSlotData
$CLI_EXE \
    --sn social \
    --op PublicGetSlotData \
    --namespace $AB_NAMESPACE \
    --slotId 'LfpVFfDw' \
    --userId 'jHHCW2g5' \
    > test.out 2>&1
eval_tap $? 22 'PublicGetSlotData' test.out

#- 23 PublicUpdateUserNamespaceSlot
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op PublicUpdateUserNamespaceSlot \
    --namespace $AB_NAMESPACE \
    --slotId 'u8z9yrpJ' \
    --userId 'dIx5vvHS' \
    --label '3d6PKPE2' \
    --tags '["7mI6Px8j"]' \
    --checksum 't8Lq4x0F' \
    --customAttribute '7NcocelJ' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 23 'PublicUpdateUserNamespaceSlot' test.out

#- 24 PublicDeleteUserNamespaceSlot
$CLI_EXE \
    --sn social \
    --op PublicDeleteUserNamespaceSlot \
    --namespace $AB_NAMESPACE \
    --slotId 'jtlKYu8i' \
    --userId 'CPznx0s5' \
    > test.out 2>&1
eval_tap $? 24 'PublicDeleteUserNamespaceSlot' test.out

#- 25 PublicUpdateUserNamespaceSlotMetadata
# body param: body
echo '{"customAttribute": "TzT51oV4", "label": "HTmivmb6", "tags": ["tPmCirkh"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateUserNamespaceSlotMetadata \
    --namespace $AB_NAMESPACE \
    --slotId 'YvcOUucj' \
    --userId 'PWGwPsvj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicUpdateUserNamespaceSlotMetadata' test.out

#- 26 GetGlobalStatItems
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems \
    --namespace $AB_NAMESPACE \
    --limit '74' \
    --offset '73' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode '1CjPt93u' \
    --userIds 'tbMkpUFH' \
    > test.out 2>&1
eval_tap $? 27 'BulkFetchStatItems' test.out

#- 28 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.7081205458396344, "statCode": "fL9q9SMN", "userId": "AUQVoiQt"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'BulkIncUserStatItem' test.out

#- 29 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.7002685939379123, "statCode": "C2kNSsmT", "userId": "0d2aBG4z"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'BulkIncUserStatItemValue' test.out

#- 30 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "A2zp1Ls0", "userId": "bD6dGgwk"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'BulkResetUserStatItem' test.out

#- 31 GetStats
$CLI_EXE \
    --sn social \
    --op GetStats \
    --namespace $AB_NAMESPACE \
    --limit '100' \
    --offset '12' \
    > test.out 2>&1
eval_tap $? 31 'GetStats' test.out

#- 32 CreateStat
# body param: body
echo '{"defaultValue": 0.5157158777225033, "description": "KuI2RJrb", "incrementOnly": false, "maximum": 0.6468212673965411, "minimum": 0.15942482713964934, "name": "pIletXrC", "setAsGlobal": false, "setBy": "CLIENT", "statCode": "s7nCqsod", "tags": ["oTFTcWla"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'CreateStat' test.out

#- 33 ExportStats
$CLI_EXE \
    --sn social \
    --op ExportStats \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'ExportStats' test.out

#- 34 ImportStats
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStats \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'True' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 34 'ImportStats' test.out

#- 35 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --limit '70' \
    --offset '52' \
    --keyword 'AknU6Hob' \
    > test.out 2>&1
eval_tap $? 35 'QueryStats' test.out

#- 36 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'ZgWlaLne' \
    > test.out 2>&1
eval_tap $? 36 'GetStat' test.out

#- 37 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'dDfasTc8' \
    > test.out 2>&1
eval_tap $? 37 'DeleteStat' test.out

#- 38 UpdateStat
# body param: body
echo '{"description": "gr2znWqD", "name": "6tIcfI5Z", "tags": ["4tUNQ7mQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'PjCalZgF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateStat' test.out

#- 39 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'VEQyqav0' \
    --limit '81' \
    --offset '100' \
    --statCodes 'mxCvMqVc' \
    --tags 'Xs2OqNz8' \
    > test.out 2>&1
eval_tap $? 39 'GetUserStatItems' test.out

#- 40 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "ZLBsncbR"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'rf6uEdjU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'BulkCreateUserStatItems' test.out

#- 41 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.20332129500511464, "statCode": "04WZNhgE"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'GvqKWQTk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'BulkIncUserStatItem1' test.out

#- 42 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.47518057307118, "statCode": "5j6186p0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'WfsnWZuU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'BulkIncUserStatItemValue1' test.out

#- 43 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "PsaRnVdr"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'dBA2hXwY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'BulkResetUserStatItem1' test.out

#- 44 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'yzZMdlR4' \
    --userId 'cL76hnFD' \
    > test.out 2>&1
eval_tap $? 44 'CreateUserStatItem' test.out

#- 45 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'gTfofHdf' \
    --userId 'oSqDcaFh' \
    > test.out 2>&1
eval_tap $? 45 'DeleteUserStatItems' test.out

#- 46 IncUserStatItemValue
# body param: body
echo '{"inc": 0.6264282691012373}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode '1oKxI8f5' \
    --userId 'ocfy4EIx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'IncUserStatItemValue' test.out

#- 47 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"wBiB90vd": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'gS5YpKsd' \
    --userId 'bpiU2Ufy' \
    --additionalKey 'MO4DhL9f' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'ResetUserStatItemValue' test.out

#- 48 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'BKJvjBOU' \
    --userIds 'n3bYf5ou' \
    > test.out 2>&1
eval_tap $? 48 'BulkFetchStatItems1' test.out

#- 49 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.7745398898284622, "statCode": "kbiExqT6", "userId": "Dk9QFqaA"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PublicBulkIncUserStatItem' test.out

#- 50 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.14783424224128894, "statCode": "wOI1P04d", "userId": "MHfTwrxB"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicBulkIncUserStatItemValue' test.out

#- 51 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "RfMxZrSf", "userId": "x3V8OXkM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'BulkResetUserStatItem2' test.out

#- 52 CreateStat1
# body param: body
echo '{"defaultValue": 0.20443951411826944, "description": "7p2SyFDE", "incrementOnly": false, "maximum": 0.192094138217056, "minimum": 0.6678047284770188, "name": "ehPBqD12", "setAsGlobal": true, "setBy": "SERVER", "statCode": "vzNNZSu5", "tags": ["zZVgY3Zo"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'CreateStat1' test.out

#- 53 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'sfd01vaO' \
    --limit '65' \
    --offset '44' \
    --statCodes 'eHacvHRV' \
    --tags '345xB8ho' \
    > test.out 2>&1
eval_tap $? 53 'PublicQueryUserStatItems' test.out

#- 54 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "s4yaOBjM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'xizCxx9q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'PublicBulkCreateUserStatItems' test.out

#- 55 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.707850639824159, "statCode": "IKlpdrqo"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId '2smD9RPp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'PublicBulkIncUserStatItem1' test.out

#- 56 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.15493470151047362, "statCode": "WK0k76i1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'g7rYaEuN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItemValue2' test.out

#- 57 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "CyPoQ0oH"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'YXUQdtIk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkResetUserStatItem3' test.out

#- 58 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'Akltd1zQ' \
    --userId 'BzzC6ldK' \
    > test.out 2>&1
eval_tap $? 58 'PublicCreateUserStatItem' test.out

#- 59 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'riI6lTRb' \
    --userId 'c1Z1HJHz' \
    > test.out 2>&1
eval_tap $? 59 'DeleteUserStatItems1' test.out

#- 60 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.1814296756879875}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode '23Ynwf5P' \
    --userId 'vGejCDgA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicIncUserStatItem' test.out

#- 61 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.27921450013155624}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'pXDcsHno' \
    --userId 'bnaYxGh3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicIncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'FovBnr5V' \
    --userId 'UOHGqEcu' \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue1' test.out

#- 63 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"JYo3YfMD": {}}, "additionalKey": "w4PaBKsF", "statCode": "XorxY0ah", "updateStrategy": "MIN", "userId": "gHrE98qQ", "value": 0.7052280135420906}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItemV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'BulkUpdateUserStatItemV2' test.out

#- 64 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"Xh1W7MnK": {}}, "statCode": "2i8Ely25", "updateStrategy": "OVERRIDE", "value": 0.3477008218868378}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'ulbNGSAj' \
    --additionalKey 'eiiANETl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'BulkUpdateUserStatItem' test.out

#- 65 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"kncKPmri": {}}, "statCode": "36MY2aVC"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'NUJgcpAY' \
    --additionalKey 'bj0fidlW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'BulkResetUserStatItemValues' test.out

#- 66 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'PSAIjaw5' \
    --userId 'HSyDsQqM' \
    --additionalKey 'UPrAxUd1' \
    > test.out 2>&1
eval_tap $? 66 'DeleteUserStatItems2' test.out

#- 67 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"bmVSM44s": {}}, "updateStrategy": "OVERRIDE", "value": 0.10258285420378233}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'AZf7a3R9' \
    --userId 'rIVTDDXZ' \
    --additionalKey '1fahMp68' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'UpdateUserStatItemValue' test.out

#- 68 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"8Jv5wQ3h": {}}, "additionalKey": "bDlcGRx2", "statCode": "aExmVbXD", "updateStrategy": "INCREMENT", "userId": "mWyrFZZd", "value": 0.6090126843195359}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'BulkUpdateUserStatItem1' test.out

#- 69 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"0sSdUypO": {}}, "statCode": "voMvIN7c", "updateStrategy": "MIN", "value": 0.6750061762714327}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'FsCUQz0k' \
    --additionalKey 'oUsUcGfj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'BulkUpdateUserStatItem2' test.out

#- 70 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"tfyuPNb5": {}}, "updateStrategy": "OVERRIDE", "value": 0.3703090782219526}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'RtR1Qe0m' \
    --userId 'xLnvZEG2' \
    --additionalKey 'biyKS8vf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'UpdateUserStatItemValue1' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE