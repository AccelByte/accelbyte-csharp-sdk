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
echo "1..98"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetNamespaceSlotConfig
eval_tap 0 2 'GetNamespaceSlotConfig # SKIP deprecated' test.out

#- 3 UpdateNamespaceSlotConfig
eval_tap 0 3 'UpdateNamespaceSlotConfig # SKIP deprecated' test.out

#- 4 DeleteNamespaceSlotConfig
eval_tap 0 4 'DeleteNamespaceSlotConfig # SKIP deprecated' test.out

#- 5 GetUserSlotConfig
eval_tap 0 5 'GetUserSlotConfig # SKIP deprecated' test.out

#- 6 UpdateUserSlotConfig
eval_tap 0 6 'UpdateUserSlotConfig # SKIP deprecated' test.out

#- 7 DeleteUserSlotConfig
eval_tap 0 7 'DeleteUserSlotConfig # SKIP deprecated' test.out

#- 8 GetUserProfiles
$CLI_EXE \
    --sn social \
    --op GetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'bBuz5zkoaUEzGS3q' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'Zf0PbemSBELbZ0VB' \
    --userId 'UGA7nkDeev2Oj060' \
    > test.out 2>&1
eval_tap $? 9 'GetProfile' test.out

#- 10 GetUserNamespaceSlots
eval_tap 0 10 'GetUserNamespaceSlots # SKIP deprecated' test.out

#- 11 GetSlotData
eval_tap 0 11 'GetSlotData # SKIP deprecated' test.out

#- 12 PublicGetUserGameProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserGameProfiles \
    --namespace $AB_NAMESPACE \
    --userIds '["HnOf5S8X1LxkZs42", "33oQWoXFeqeuI2oM", "J0cgAoGfXepE3r5A"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'QUBqS8KtTYZLJ58Q' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["qcV3IcuNs9MF5BT2", "KD18yrWorpC65VJh", "4q1z1KJmKedBfbWv"], "attributes": {"Ka5Ou124TsbQsxYF": "xGGHrfQkgXkiA5IZ", "PqCqp9vcyt67WAfW": "XfUfwGB03tz8qIH4", "uRdNO08HN6s9p8Y5": "c9eItJtiNmY3y3n2"}, "avatarUrl": "Rim4NBqhuNtj8FOv", "inventories": ["KZjs1tLpERf77LzP", "oORBkRmZ0A2zyZsb", "4FvWFIHPIbOjpls9"], "label": "BZTYc5BsdSSVaAzz", "profileName": "n4GbgkKeCaS6qyUC", "statistics": ["scHXs8PlOBlfUOqv", "7WmCuqcsNM7YAnbq", "4DjmYUMhD9qU89D3"], "tags": ["56pVsUtNanddzgwx", "YdQc5hEfefdopcEM", "0JHfof2Hwi7vg3os"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'bh0fL2h7eJvAS2W4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'uqkhwSC7EajwHO3L' \
    --userId 'fvwPewrf19Njm50x' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["CDlPeNq0CvMXtyUW", "XrdZaFeacGT2x6o2", "8Njxyw7RHldq0m7N"], "attributes": {"jUZ95Z5XDLBN9YGV": "Ptkjt0OyBlJi4RbZ", "0Iy11mfOFjCzZVcG": "omWF1oAqUNFDtXnX", "LvOAsW8wYh4gq7pR": "VZVLJiDx3au9b9Qj"}, "avatarUrl": "hzDlnJmi4XaBTgoX", "inventories": ["jfdUQHa3RxspSqwd", "bTR2sgzfaQrUCW9f", "go69uv1bkFx8DmbC"], "label": "9UqYdYrdxNnuMcAw", "profileName": "rSzYnrcetxObeisZ", "statistics": ["elKuD0iJ6fs3zL9H", "4WxGWRH7fz4BdPhL", "tHRJOImSq37aeAaG"], "tags": ["q0NIj53gXkmrayvc", "IYiWxIAxfvLzSpDF", "Y3lxe16KsSRzkf2H"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'zBcEio5UyvuFv5z6' \
    --userId 'wosJGnUyCMEbHh1u' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'E4DmJ4Suj6DjUw36' \
    --userId 'GtZ83Jp2f9f1FCoI' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'o3L24DKGwgZ85vyF' \
    --namespace $AB_NAMESPACE \
    --profileId 'JR8euQBLVu27iwpl' \
    --userId 'LJdzYS9K0VvwE6MA' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "qPc8lGIYWTwxyqQQ", "value": "IXVmrtRlq1jv60HT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'nmFrl3gYx6Xmv1Dz' \
    --namespace $AB_NAMESPACE \
    --profileId 'PHux3k3skhn3mWZj' \
    --userId 'TYM95e4aa8xOJu7r' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'PublicUpdateAttribute' test.out

#- 20 PublicGetUserNamespaceSlots
eval_tap 0 20 'PublicGetUserNamespaceSlots # SKIP deprecated' test.out

#- 21 PublicCreateUserNamespaceSlot
eval_tap 0 21 'PublicCreateUserNamespaceSlot # SKIP deprecated' test.out

#- 22 PublicGetSlotData
eval_tap 0 22 'PublicGetSlotData # SKIP deprecated' test.out

#- 23 PublicUpdateUserNamespaceSlot
eval_tap 0 23 'PublicUpdateUserNamespaceSlot # SKIP deprecated' test.out

#- 24 PublicDeleteUserNamespaceSlot
eval_tap 0 24 'PublicDeleteUserNamespaceSlot # SKIP deprecated' test.out

#- 25 PublicUpdateUserNamespaceSlotMetadata
eval_tap 0 25 'PublicUpdateUserNamespaceSlotMetadata # SKIP deprecated' test.out

#- 26 GetGlobalStatItems
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems \
    --namespace $AB_NAMESPACE \
    --limit '81' \
    --offset '92' \
    --statCodes 'RVdygfKmUkzj9mHF' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'pff2vDkz68zorEgc' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'SEASONAL' \
    --limit '49' \
    --name 'L98WUoXvfU4qMIpf' \
    --offset '13' \
    --sortBy 'CpNtJSMm8kDi3Rwu' \
    --status 'ACTIVE' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "MONTHLY", "description": "wWs6IpYBxafo9b4x", "end": "1989-07-19T00:00:00Z", "name": "Lfjsw270pMmOQJrp", "resetDate": 62, "resetDay": 56, "resetMonth": 51, "resetTime": "bVvBn8Lsf2qSAtiz", "seasonPeriod": 98, "start": "1992-11-22T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["70TCayYAkF18YBwR", "hzsVbpJLtEZjuyFh", "vbxX2DNbknfVv4nm"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'BulkGetStatCycle' test.out

#- 31 ExportStatCycle
$CLI_EXE \
    --sn social \
    --op ExportStatCycle \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ExportStatCycle' test.out

#- 32 ImportStatCycle
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStatCycle \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'true' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ImportStatCycle' test.out

#- 33 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId 'cGkPgQ0hb2tLrsMe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "DAILY", "description": "33Iztr2QcwlRrReR", "end": "1971-05-06T00:00:00Z", "name": "jlpk8lfuiJVcktlx", "resetDate": 34, "resetDay": 52, "resetMonth": 57, "resetTime": "JZVVCc9bpIHEWQMm", "seasonPeriod": 58, "start": "1992-03-24T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'mnsUigVynjGFyVic' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'GQAVv32ftRAsmC0R' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["uRA8j1AJ3hNWWhAD", "RqJvaZrf2qXQFCzR", "V1paELj5dw3LK0gP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'YhPPG5sAIfYtYozA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId '2OntGCwQSHHdPLwj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'Tngrvb2E1X9ecBBh' \
    --userIds 'RAYjR7c4x5bIk8pV' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.2556900894064902, "statCode": "xdUWOPel3TiwTycq", "userId": "pVdINXzvkSp0Wbvx"}, {"inc": 0.6933794244533641, "statCode": "WI0QGCOx7eICkauW", "userId": "bFrSnU7d1Buhdwli"}, {"inc": 0.7308903190191015, "statCode": "SDdmGVfegiD3mrVQ", "userId": "aUr3oT88Dfc7114Q"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.5154174138626199, "statCode": "GwTzBVDg5v71kGCE", "userId": "t7h1mVwIQCJmQkvW"}, {"inc": 0.024239330528998626, "statCode": "Qrn2W0VkOF0pQOY0", "userId": "UCcViiFKNjkT5hcO"}, {"inc": 0.6405132324544628, "statCode": "CaOyATBFgqLeAzvd", "userId": "cUEhWRo6ROvbuPQw"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'BulkIncUserStatItemValue' test.out

#- 41 BulkFetchOrDefaultStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'l9dVfJQGkDR00ofX' \
    --userIds '["sbnEzHiRs0NmGhxv", "1vuN7Xv6OuG6RR1j", "Ph8RblvnfNiABRf1"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "gdXM7QlAlnjAfgxO", "userId": "dZdf9tLHO1qrNyhm"}, {"statCode": "UEADczzrL31HuYKs", "userId": "CBBgwb1hGjHJgxrc"}, {"statCode": "EvnfJqU4hCv5egSQ", "userId": "DePKSZKp6zwDQS1a"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'BulkResetUserStatItem' test.out

#- 43 GetStats
$CLI_EXE \
    --sn social \
    --op GetStats \
    --namespace $AB_NAMESPACE \
    --cycleIds 'tvJrALaiplJgRhed' \
    --isGlobal 'false' \
    --isPublic 'true' \
    --limit '63' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["0tuwIJnrSI2IFcRw", "UnPTiCD0038or8wR", "JPG8cgjHQo9HoLLy"], "defaultValue": 0.714188300834931, "description": "oMTuJziuDNbOydiu", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": true, "maximum": 0.011615356842494706, "minimum": 0.2825271423500434, "name": "uuYw0iUuts6bChMK", "setAsGlobal": false, "setBy": "CLIENT", "statCode": "H02bobxtljIfHBgj", "tags": ["C1zEnAMGmFy7w6eq", "O3HkJTOPscPA2n25", "P9onbxFcxS2OZZfX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'CreateStat' test.out

#- 45 ExportStats
$CLI_EXE \
    --sn social \
    --op ExportStats \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 45 'ExportStats' test.out

#- 46 ImportStats
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStats \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'false' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'ImportStats' test.out

#- 47 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'false' \
    --isPublic 'false' \
    --limit '73' \
    --offset '75' \
    --keyword '5OHuNEVQK4Mvk00I' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode '9GqAhhjNIivdIcaE' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'QfNETQCBPK1mYwKV' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["QoydbYjXZyBpqhCJ", "BtFOm3iCpu0lhhgu", "tt3rQuKP1OEtKFBj"], "defaultValue": 0.6367246205689969, "description": "ihHU8GP8TRVypSvY", "ignoreAdditionalDataOnValueRejected": false, "isPublic": true, "name": "IXRWFTyA9MDnKGXq", "tags": ["OwIF5tEsCwoAVcZC", "NVF7zwjXqlcD2Lza", "q7Zk705hOhenJi6d"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'Sj80gzFvpvIerFEy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'xTugoTd50RmJFX9v' \
    --limit '67' \
    --offset '85' \
    --sortBy 'NWse6VLPkM1VTrQB' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'ywhJ7lbBLw9xy1WQ' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'M5qUS8baUqkzSr41' \
    --namespace $AB_NAMESPACE \
    --userId 'y6RPBHJuPjj8zDwO' \
    --isPublic 'false' \
    --limit '27' \
    --offset '78' \
    --sortBy 'IgmYfUTpFzyQhPVh' \
    --statCodes 'RGX9xlUKhXI8mL8O' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'IhvP68xE68dzohxh' \
    --isPublic 'false' \
    --limit '72' \
    --offset '9' \
    --sortBy 'HWE6s13b7dmnPijw' \
    --statCodes '6U8GGp0E886E90E4' \
    --tags 'ZboiXT1Uy0gArtDp' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "QE4bOtoiAjHXcVVO"}, {"statCode": "sVywU6uisejapftq"}, {"statCode": "oxujXDosOo2kSUfI"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'A1guTNx7haejXSV2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.23745001134438415, "statCode": "H2uH8S4Zx0ACteue"}, {"inc": 0.6190549292012749, "statCode": "OmYP4SgxAIQTTKsd"}, {"inc": 0.2062749787507997, "statCode": "tHu1dG0us7kIWLcg"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'KgU9406tdRDqr3cp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.7593164422150821, "statCode": "baH69NyTfGE59942"}, {"inc": 0.01644552024150936, "statCode": "CwgpzUfcmTQjRmV0"}, {"inc": 0.46315049503118877, "statCode": "Pt1LUaTvrFaxzOfG"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId '3pTddIA0Rt6wM5oQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "vTMICtWyUtVDnhgT"}, {"statCode": "GXO8Utpwxug8Mpqc"}, {"statCode": "zRvUdK1uOV1ZJTYu"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'HpnpVX5u4gw4XBXD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'D7BG73sDdDoXnB8F' \
    --userId '5X05KUgGKfDSGh3v' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'QFPSYCi8WEjR3wqp' \
    --userId 'nMdSNskxhl3O3kGl' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.22875930892413887}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'ooh7kL598P7F3IKh' \
    --userId 'iNdx1V7199NT7JTR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"FV3FxMl5Rw4YeHqW": {}, "kG09iEAFYWhow1WA": {}, "wCs9Y0KOemhNPYUV": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'A9mU8UvONyjv3GQu' \
    --userId 'LHoQ6ehLLK5h1bE9' \
    --additionalKey 'WU6w3tjUhSCKySPY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --offset '79' \
    --statCodes 'k4uDF5mdakWJ2AsK' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'f8UfQqTQ8v7gXyFu' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'WEEKLY' \
    --limit '70' \
    --name 'FZViQbxYQvUyapo6' \
    --offset '65' \
    --sortBy 'CzYWxYbbphuiQPU0' \
    --status 'ACTIVE' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["p8zoRYG8WKTaUyB0", "UyrKKulHUnompTrS", "e6T4pYH3BPyFurT4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetStatCycle1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'BulkGetStatCycle1' test.out

#- 67 GetStatCycle1
$CLI_EXE \
    --sn social \
    --op GetStatCycle1 \
    --cycleId '7DIOakX65w7RpxY6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'pd1QTpFpaxbCjHSC' \
    --userIds 'XM7sL1nnOoRIg7oS' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.11972897658709425, "statCode": "4yVttp53wasuHbA0", "userId": "keUomVCh681OMZFN"}, {"inc": 0.705645341783697, "statCode": "w8YvLGLnB4xfqdHh", "userId": "PHA2ZbIvW1oxENH4"}, {"inc": 0.6236184370442103, "statCode": "sVlbCMc5hx0W14Sk", "userId": "vovINegS29legebq"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.5201628277510786, "statCode": "wej59Ok8EM0OFW93", "userId": "FkJicmK6qeaDEm9b"}, {"inc": 0.6689352135517234, "statCode": "CS2a5WoOtwavdioa", "userId": "djCN0lC0MZRZAvhZ"}, {"inc": 0.9641259455862792, "statCode": "XQmcT57Hl2PvPOKv", "userId": "c25nnSLnEnv4ipAV"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "JzPHM6kTwfu1vSD9", "userId": "gROMknwVRJfXHGB1"}, {"statCode": "r66lbNcbMIJEY0Bm", "userId": "pF215jJycJcSyXLz"}, {"statCode": "U9Uqk079uhBLl4yz", "userId": "32RqkNzYSNYl4zvy"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["BU2g8Eo7uAb4Hndx", "W7TE5WdocKzvgr3j", "D8SUZv2LFFZer6T3"], "defaultValue": 0.26325876214387434, "description": "QYO14lFR2YtIb1fu", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": true, "isPublic": true, "maximum": 0.5731791048531858, "minimum": 0.13446122178106323, "name": "odJFjEbn1ASMAied", "setAsGlobal": false, "setBy": "CLIENT", "statCode": "v6WmW9mRXQwc5sfO", "tags": ["rXKhZOekpygvRDCk", "0koCGDPfbiGdBQ5D", "ZbgnCmULqltV5xjj"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'CreateStat1' test.out

#- 73 PublicListMyStatCycleItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatCycleItems \
    --cycleId 'NVJAgfAkD0w0H6QM' \
    --namespace $AB_NAMESPACE \
    --limit '57' \
    --offset '55' \
    --sortBy 'Bg2lM3DQXyC3oKu1' \
    --statCodes '["4sRjkCeuRY0tsnbK", "AGRTCvAZKiSB7bYv", "WmbUbWlRZtcIUry8"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '26' \
    --offset '49' \
    --sortBy 'iAxHczgRu4VYjQq4' \
    --statCodes '["VIVFUqNPuW223zuU", "v8ShbYBe9hLKcN6m", "yFUWf7IuLG63jl9r"]' \
    --tags '["YXaEFcUySnsIREQU", "lwDt2XB6DgoJm4dq", "rLVSBWToF03dQYi0"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'OxI4DZZd2V80fjN9' \
    --statCodes '["CwM4qNT3awIjWoFC", "W5BTW9laFjsd7gSF", "kIVGnXJLeUdD8XNx"]' \
    --tags '["AkoeHk0BXouyKC6R", "nO4PckO3syHJOMlg", "AqtsnZlLvEczKKAy"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId 'iQv93N1fbGovPLBp' \
    --namespace $AB_NAMESPACE \
    --userId 'XX8vScPhhhoeTbxu' \
    --limit '27' \
    --offset '6' \
    --sortBy 'gca58m1uNcxsQxrs' \
    --statCodes 'xbLSv7uFZXdW5GyQ' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '2mveLZEnmSCeWTCX' \
    --limit '10' \
    --offset '88' \
    --sortBy 'ARUx3U3KrfqoZi5x' \
    --statCodes 'iHiQI9ieQ8y75Biw' \
    --tags '4pKJ8hey5JmuUDlo' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "jEc712JEhS1VFA1E"}, {"statCode": "o4Rxcnq5DtzSaifB"}, {"statCode": "yaju2TY0QdHndDWB"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '60eGxKadAf6UL9Mk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'kVf8dHJYJF19NcUS' \
    --additionalKey 'JgQSBwkX1FU71K0C' \
    --statCodes '["zXzdQIWh5PSp024S", "Ihnu3h3uK1jRHhQ2", "uS27tXHvtxi6EbWH"]' \
    --tags '["rMrbpZd2bt6P3sZX", "AZkdh450P2HCQEys", "NYmCndtXXQgiHJgj"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.3575180036861718, "statCode": "pCxGEBsc3HVarhLl"}, {"inc": 0.3659029824601472, "statCode": "lmf1l5JhrQSpGlgu"}, {"inc": 0.35023995223284854, "statCode": "TECefhiKKuc8Urg4"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'atANoOfyCbfBoH6z' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.6062486014130047, "statCode": "gTsYmAw4mFyLcIq0"}, {"inc": 0.8461614247631773, "statCode": "Vl8sxzC1fJxroZeN"}, {"inc": 0.5587616464162156, "statCode": "lbxAUeRUjUbaPklf"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'Vic7zYJTjpmhWVBg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "TDm8IGJL3sEpnq2q"}, {"statCode": "NgEjKMemoxx1k2s5"}, {"statCode": "gW8zADPqu8PVXnN0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'xl48RoZbNL7cXCVa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'F9U1H9bQv7EybPwb' \
    --userId 'HEHxSPaGCQl5y1ge' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'keqHnzZfY22Z1SmI' \
    --userId 'c5NTRyLbOzAYD5IH' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.9061222581485947}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'deTFCDORAsuT0lse' \
    --userId 'QtOoohdBYhvvwspK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.2572333160106922}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'EPUUxc2NKFB2qxCi' \
    --userId 'WMNdvN9SDRKye6n1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 't8RXF5qayS4UAMJr' \
    --userId 'RrnNfXdTnJz7e3tD' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"8KVlMU17V03QDQjU": {}, "64lc3oek3RWXWJhP": {}, "XvS9OmmtZ14XROPp": {}}, "additionalKey": "bgqS9a9eP72cbSH4", "statCode": "TvY6sMCkitXsNfi8", "updateStrategy": "OVERRIDE", "userId": "EO7zBX353qlmBOmz", "value": 0.47017786198364886}, {"additionalData": {"ZoLl4yLZgHlatL7n": {}, "bsrfkzQM5RtMqCRi": {}, "Ye7QxHteM0QsfB4c": {}}, "additionalKey": "Kcpv0nqsAzwhiinZ", "statCode": "MK2PQePnMgPL2upE", "updateStrategy": "MIN", "userId": "lNT7v5QycBCxJG7D", "value": 0.08063419528917748}, {"additionalData": {"hSEc6kg2UWX8dfbo": {}, "aqkOS5P8ijeU7ceE": {}, "jsJO7xZUK7lMGDnK": {}}, "additionalKey": "hxDxWqk0FyDBDBxA", "statCode": "znXS1mfs6uZ9OaZw", "updateStrategy": "MAX", "userId": "H7I8lYD68ZI9yJ2F", "value": 0.20928622751802395}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItemV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'BulkUpdateUserStatItemV2' test.out

#- 89 BulkFetchOrDefaultStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems1 \
    --namespace $AB_NAMESPACE \
    --additionalKey 'Hnprty5BQCd5sVLr' \
    --statCode '7TlnKnQhYH2PkwSP' \
    --userIds '["XdYk0YxFNno9WQq9", "ZHHjrwqKsa8Zqhez", "PIlBtGhWc8fY9HfU"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'sEaPxVM4cVRtjpUe' \
    --additionalKey 'qucPWZP6mJ5k9QPU' \
    --statCodes '["VO9elCnXCnhXRiCB", "S6wONO7EzD1HwKEg", "Gh6MctPOqg2vfaFi"]' \
    --tags '["XbkyxYVJYoECX5Zk", "7zrqRFfKg2QLfgPk", "y92H0SjmRKLX0YyN"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"LgOIbDguxdqP6c44": {}, "8AniKDjnb5cFYyJt": {}, "zDcKD3CR18eggGJV": {}}, "statCode": "XROWQLNP4J0I2wDj", "updateStrategy": "MIN", "value": 0.4847860531354017}, {"additionalData": {"PZQmxEO4oKOcsZUb": {}, "eZJJJydenJ93Kb1p": {}, "QleHG1UoswJzp9GP": {}}, "statCode": "pGykMepZ0J4UuZWR", "updateStrategy": "OVERRIDE", "value": 0.21192269015674292}, {"additionalData": {"xc82WUAqFNlxPL5Z": {}, "jWvAiWvl12EyddbF": {}, "elmB60OEQrMIsKCf": {}}, "statCode": "8GsPEl1i9RQ9tNv9", "updateStrategy": "MAX", "value": 0.07599008466910684}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId '9AzmsPC0C5hWQuue' \
    --additionalKey 'yPPcbPVe3xxdxVhu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"4rkZZo8fTr6agunz": {}, "2XzHsONpORaUZ573": {}, "WSpmtV8p2sf0f3uC": {}}, "statCode": "NxJIMiWHlRKeE5RK"}, {"additionalData": {"hreFD6wFvnLOEQR2": {}, "tp6q9pPGaWcS02Lc": {}, "iOGbTW0UOPodtVEA": {}}, "statCode": "HUTPJcWSRPDFdkQZ"}, {"additionalData": {"DrW0M7eIDrifb9ov": {}, "ouuoyV36gCehJP43": {}, "Xpu5gyQ14gMP9Z4m": {}}, "statCode": "EvMNjtERuv6NrO6S"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'jBOH0izSSpVoq4E6' \
    --additionalKey 'CtycfHMbZoBgzDSn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkResetUserStatItemValues' test.out

#- 93 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'BtqToPbBDwdvFVFT' \
    --userId 'K8mQqqA2VoUKBlsP' \
    --additionalKey 'XL4ibYVB9w0ETfSa' \
    > test.out 2>&1
eval_tap $? 93 'DeleteUserStatItems2' test.out

#- 94 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"uutS9JWgSB39nWJ0": {}, "AdErhRmHmtCl6M85": {}, "ELRv5NEe9bR9ckNL": {}}, "updateStrategy": "MIN", "value": 0.15032177302659366}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'sgaXBRR415WJviuc' \
    --userId '5vA36xYMMPep0zpl' \
    --additionalKey 'FiRg22RpUVtQXjIt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'UpdateUserStatItemValue' test.out

#- 95 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"ygvyTYykvnB2kvfx": {}, "E0sqbjAHF9QLlS2l": {}, "C0QB41qRS25yYg5f": {}}, "additionalKey": "kChtyUjcBHShoy4r", "statCode": "AmtQkeCoVHY89b92", "updateStrategy": "OVERRIDE", "userId": "WEF9gisonsVtIIBD", "value": 0.48227477916637995}, {"additionalData": {"ZzSa012J2Vd3MaSm": {}, "OIA08Q4Pe45ZkF7U": {}, "CeoZEUNVKjMQUM30": {}}, "additionalKey": "waRuDKnw63w8ZD7G", "statCode": "zTZ0WS0ZfkVqKowf", "updateStrategy": "INCREMENT", "userId": "kxwcIoptsiG0JEo5", "value": 0.841603368334571}, {"additionalData": {"u4dtDARQghCkujmL": {}, "LnrNNSLh36UQbPSJ": {}, "QQhceSla9ERYYip5": {}}, "additionalKey": "g4u0MAPcVPH3gZ7B", "statCode": "L95xBXZ4Q2kZcVEt", "updateStrategy": "MAX", "userId": "RLWH719H0S96d6o9", "value": 0.881881240995999}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'BulkUpdateUserStatItem1' test.out

#- 96 PublicQueryUserStatItems2
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --userId 'O9JTphnwOfFzh20o' \
    --additionalKey 'vT23TbEK3bM30lxx' \
    --statCodes '["1rT6fsKa4IgtUwYe", "PFCH42h6LucfBcrN", "83Rs41H9Aya2Ugl7"]' \
    --tags '["sPCMcCq8KOF1FPAS", "WEGLvHi2yA6ZsXJo", "VWUuZ6fQXMhnC8iR"]' \
    > test.out 2>&1
eval_tap $? 96 'PublicQueryUserStatItems2' test.out

#- 97 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"ACppkc2GjnJ6Mqok": {}, "eFNTOal7C9QhMyKS": {}, "xoXxGxkYjDcp3pGT": {}}, "statCode": "MJShikvBpSOkSVhu", "updateStrategy": "OVERRIDE", "value": 0.03605871844536235}, {"additionalData": {"3OUVUdC6vEQ0Fb0f": {}, "OzSwVrTe2Pix8IgO": {}, "yJOxbfiuUDdzfJOv": {}}, "statCode": "eiGttirPw49eDkkT", "updateStrategy": "MAX", "value": 0.15326124537738595}, {"additionalData": {"A062eWYCE2BZKl6K": {}, "s6ND0evlW05Ize0E": {}, "KI1ogofwrtjPjSrj": {}}, "statCode": "vrgKMZ79d1xh7UR0", "updateStrategy": "OVERRIDE", "value": 0.3788019269734856}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'rnZ5OMXgRDRM3gg9' \
    --additionalKey 'nVFQuxaksqHEV6l9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'BulkUpdateUserStatItem2' test.out

#- 98 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"c1J0YV5SAUWFWpU4": {}, "iAd1zlFBNJu2WkeG": {}, "DSzlCaFt7Cu0JKjL": {}}, "updateStrategy": "INCREMENT", "value": 0.5513031565067877}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'DQryhqRPwaSbAake' \
    --userId 'TI3GtLp33o0hY1hJ' \
    --additionalKey 'yjnnZKdSiFaVEfxN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE