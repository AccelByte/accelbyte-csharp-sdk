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
echo "1..99"

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
echo '{"cycleType": "MONTHLY", "description": "wWs6IpYBxafo9b4x", "end": "1989-07-19T00:00:00Z", "id": "Lfjsw270pMmOQJrp", "name": "EBbVvBn8Lsf2qSAt", "resetDate": 16, "resetDay": 9, "resetMonth": 52, "resetTime": "6POTjrinAVVovpAA", "seasonPeriod": 64, "start": "1991-02-28T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["FcGkPgQ0hb2tLrsM", "zcpbmX3lLFeXCiaX", "P8jBjK81t2V9TVau"]}' > $TEMP_JSON_INPUT
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
    --replaceExisting 'false' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ImportStatCycle' test.out

#- 33 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId 'i33Iztr2QcwlRrRe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "DAILY", "description": "ajlpk8lfuiJVcktl", "end": "1983-12-21T00:00:00Z", "name": "9zJZVVCc9bpIHEWQ", "resetDate": 78, "resetDay": 25, "resetMonth": 26, "resetTime": "cQmnsUigVynjGFyV", "seasonPeriod": 16, "start": "1978-01-22T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'zsjIXO2EUsAfBvo6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'Llcalks2R3VMtipT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["VxXAF8KhOKqbrECi", "jFxOpOzxeTLJQsZc", "TEzXaXUzpsAV6ct6"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'XITL0QEkadMSQluA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'oED9oYwS8oLyErKv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'RtHFGJRoGW7VBG1V' \
    --userIds 'B2sp2x9mszGGoyhG' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.8296439444544509, "statCode": "Azt2OVBTLwSH8hWR", "userId": "U9pbItGQ7VUWBhGo"}, {"inc": 0.18901769659465395, "statCode": "wafIfbF1GLFnrQ4T", "userId": "5cmw7U1TxiS06UEo"}, {"inc": 0.006405381005212263, "statCode": "DZpXOWzpXOi2cpaj", "userId": "tqcXjPkj2IzU3MEp"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.4525425992635611, "statCode": "t1IjlfHJM92t9j1X", "userId": "T2ErwIxkaTnYtr1Y"}, {"inc": 0.4795231733772417, "statCode": "naXB0JOS4XKVT66s", "userId": "HYPgVsfhoEidKw4I"}, {"inc": 0.6669438261912336, "statCode": "0NVnaangorhVFpTR", "userId": "uQyMroT2hNfKJ7q8"}]' > $TEMP_JSON_INPUT
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
    --statCode 'sifSPmYSsBxtyKWs' \
    --userIds '["sEn5VEvIMEB4pl50", "6fLCG6EAl7d3Ks65", "thtnjcMSw1J42fth"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "KUobas2CAlSxxVhD", "userId": "R9hlaznetBUGcQz2"}, {"statCode": "WvdiclkYGDL2ckC9", "userId": "cdzaLnajQ8GnJpAL"}, {"statCode": "iddv9UUtG1tEECsm", "userId": "8xaDOz0tMlpFuJVX"}]' > $TEMP_JSON_INPUT
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
    --cycleIds 'o9s0JPG8cgjHQo9H' \
    --isGlobal 'false' \
    --isPublic 'true' \
    --limit '78' \
    --offset '78' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["zIOP8NOf91LsD7cW", "yz3iP8gH88UenlMV", "WOgAs8ThMpAGIapY"], "defaultValue": 0.09194004639108355, "description": "tYZkBXiEhdiS41VB", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": true, "incrementOnly": false, "isPublic": true, "maximum": 0.3505108215903011, "minimum": 0.2402851180917862, "name": "BlbH02bobxtljIfH", "setAsGlobal": true, "setBy": "CLIENT", "statCode": "gjP9onbxFcxS2OZZ", "tags": ["eqnMeKFo7U8Scr9x", "25C1zEnAMGmFy7w6", "fXO3HkJTOPscPA2n"]}' > $TEMP_JSON_INPUT
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
    --isGlobal 'true' \
    --isPublic 'false' \
    --limit '45' \
    --offset '71' \
    --keyword 's9RMx2hc45QX234x' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'nqlbRAPFQsca6n9v' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'GZTCCXQ2Lf7jtexB' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["45vMiR3QYZJKVNlK", "EY2zrpLuvrx96OOz", "613cbiJEUePVZQao"], "defaultValue": 0.9799216524522069, "description": "PTaIXRWFTyA9MDnK", "globalAggregationMethod": "MIN", "ignoreAdditionalDataOnValueRejected": true, "isPublic": true, "name": "6yQK1AsC18UO6JcX", "tags": ["mwQfkseTpH6l2Dv8", "jViKkKw4gHA4CaLs", "SvqYKc56PcPSL2xm"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'PqRsTdKzcKtkGcvn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode '44NWse6VLPkM1VTr' \
    --limit '87' \
    --offset '95' \
    --sortBy 'BywhJ7lbBLw9xy1W' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'QM5qUS8baUqkzSr4' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId '1y6RPBHJuPjj8zDw' \
    --namespace $AB_NAMESPACE \
    --userId 'Ok0IgmYfUTpFzyQh' \
    --isPublic 'false' \
    --limit '95' \
    --offset '90' \
    --sortBy 'VhmAwmAygsnn8pM7' \
    --statCodes 'l6v0elLMceGGgb5F' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'JHWE6s13b7dmnPij' \
    --isPublic 'true' \
    --limit '32' \
    --offset '95' \
    --sortBy 'qY6T7TUEBotSNIwG' \
    --statCodes 'hia6cqoWmnhtuzxi' \
    --tags 'r12r0VUWI0kJAczj' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "5ApcsiEQ65llgGnT"}, {"statCode": "HAsTCZa7xE4nwGKl"}, {"statCode": "bPRxfucxoRKFLxxc"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'L9SyuHbvRxR6LaKW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.10459598645075252, "statCode": "AVjZKDxiezEbuMCz"}, {"inc": 0.9911806159229382, "statCode": "J4dPRGzoQLYIWPPZ"}, {"inc": 0.3532486267901107, "statCode": "yPupimCENHEenqjR"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'SxO9oZ0fCxLR0Gfj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.36259340843310417, "statCode": "CmDrbDR0Q0ixpqYt"}, {"inc": 0.16516145812055183, "statCode": "ZuhL6qbAhRExsnbW"}, {"inc": 0.7178446296311664, "statCode": "H45LarTmOqto4Otw"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'F9uPUAxerdIqWmOo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "MyYp2tSrLxpJnj9J"}, {"statCode": "tgjWmjx1WuNQq4v8"}, {"statCode": "FnVzdbNW1xuV7rVe"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'i1o9zV6rhVfcQmLf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'En5ZUGeYlOwODWBA' \
    --userId 'z6skHMfl4Hjw9KEn' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'x8cNfDK45zWtwYhR' \
    --userId 'oNPwKema6caMTOci' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.34112275862500363}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'PAkmP8Awb0NqtvSR' \
    --userId '9q6l5k9BLQMrPoTu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"xdzEYAw5VdW05WnQ": {}, "EAbK416LN2N6D6yc": {}, "zitn4OkZfx0Xa6sg": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'egAWYz2z4qSPPQBD' \
    --userId 'FQsvRHbGTC2ynue7' \
    --additionalKey 'Xk4uDF5mdakWJ2As' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --offset '34' \
    --statCodes 'f8UfQqTQ8v7gXyFu' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'LFZViQbxYQvUyapo' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'SEASONAL' \
    --limit '65' \
    --name 'CzYWxYbbphuiQPU0' \
    --offset '0' \
    --sortBy 'e6T4pYH3BPyFurT4' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["OhjEKFWmj7ioi5WZ", "6ZymQeVSZZma57V6", "aotJoQQyL1bCDNis"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'b9uLloAA9KoetyNP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'kgWcTCN7aBIFfeRd' \
    --userIds 'nHpse2T7eZwkVrB3' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.5250722555533031, "statCode": "SEmVq8CjR5rCx0Zi", "userId": "HwUqL5rITYFhcdeN"}, {"inc": 0.3699796919828442, "statCode": "LmZenRqEBM0VGzhV", "userId": "VGdipdi33u9U14rG"}, {"inc": 0.3641803365037791, "statCode": "vMExAllZtPzNRiR3", "userId": "5CZhclugjyDzCPI8"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.31287523732989975, "statCode": "slD0HuRrAMzMB9XH", "userId": "HkfZgB6Vt5qWaae3"}, {"inc": 0.7109379250837153, "statCode": "boVKgjsryC98whmI", "userId": "5koBT6iCuVa643kk"}, {"inc": 0.9734849336645656, "statCode": "gvvnsu0ABei0go2w", "userId": "smPfpsbkzAIsJ06Q"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "lFCAa55r89MdFidv", "userId": "2kFVXgnjrAfzEn26"}, {"statCode": "mHgxUgVDgnlU5H2U", "userId": "La1LYlsqYrUpXncY"}, {"statCode": "v2BVIS1BtMqvdE5Q", "userId": "QizMBWYPYerJ1FmK"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["6MsoQcFDfKSJymqZ", "5tDVsJ63mFWW0u95", "BX6U18gMIl7TSPm9"], "defaultValue": 0.27709629454723717, "description": "5ylQKcWi0o5zcWp7", "globalAggregationMethod": "MAX", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": false, "maximum": 0.44493163778528233, "minimum": 0.5599882322395674, "name": "4m6PVEQWCNw7DHkX", "setAsGlobal": true, "setBy": "CLIENT", "statCode": "qXaR2w60X5Vb0TV0", "tags": ["dZ6luOW977EgotvO", "x3nmq9UCZbdVFY3W", "rnRjb5UT6Vf5jxoB"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'Bg2lM3DQXyC3oKu1' \
    --namespace $AB_NAMESPACE \
    --limit '37' \
    --offset '49' \
    --sortBy 'RjkCeuRY0tsnbKAG' \
    --statCodes '["RTCvAZKiSB7bYvWm", "bUbWlRZtcIUry87y", "JBlfjPI5tfjbyZkY"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '70' \
    --sortBy 'RLBMgcD5OJgp6wHy' \
    --statCodes '["nVKwWgdAibFBESdI", "0Ab1zgjMC3hp1s4t", "ElQhEA9ThpSbyAYJ"]' \
    --tags '["eBCrKDcRkI5LI6Uq", "ivHoIArvDT62TaGF", "Sxd4y808Fey8nfaG"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'Ew6BAuz1YkANj6LH' \
    --statCodes '["aNMxGL2cjWg68JcP", "wqh2N4nelbmKVyNZ", "Y8IVtOeznPwNRnzt"]' \
    --tags '["P1VeNj0XYtINcOQI", "iLdvpuYVOAU9uuKP", "GNN6m8BLNzJxMR9F"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId '8QPVUh3Fxn8VCvtd' \
    --namespace $AB_NAMESPACE \
    --userId 'iiwNMAdIodiW3hcY' \
    --limit '42' \
    --offset '2' \
    --sortBy 'KSRkkKQKIVOduQww' \
    --statCodes 'DrBnpQpIKdlw0Q8Q' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'm0lpTupwpI0MCORO' \
    --limit '69' \
    --offset '68' \
    --sortBy 'iQI9ieQ8y75Biw4p' \
    --statCodes 'KJ8hey5JmuUDlojE' \
    --tags 'c712JEhS1VFA1Eo4' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "Rxcnq5DtzSaifBya"}, {"statCode": "ju2TY0QdHndDWB60"}, {"statCode": "eGxKadAf6UL9MkkV"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'f8dHJYJF19NcUSJg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'QSBwkX1FU71K0CzX' \
    --additionalKey 'zdQIWh5PSp024SIh' \
    --statCodes '["nu3h3uK1jRHhQ2uS", "27tXHvtxi6EbWHrM", "rbpZd2bt6P3sZXAZ"]' \
    --tags '["kdh450P2HCQEysNY", "mCndtXXQgiHJgjwp", "CxGEBsc3HVarhLlw"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.18819452932279634, "statCode": "mf1l5JhrQSpGlguv"}, {"inc": 0.7304100118714585, "statCode": "ECefhiKKuc8Urg4a"}, {"inc": 0.3118076057853877, "statCode": "ANoOfyCbfBoH6zLg"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'TsYmAw4mFyLcIq00' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.7705891480247623, "statCode": "l8sxzC1fJxroZeNI"}, {"inc": 0.1801063153480832, "statCode": "bxAUeRUjUbaPklfV"}, {"inc": 0.1430312139837019, "statCode": "c7zYJTjpmhWVBgTD"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'm8IGJL3sEpnq2qNg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "EjKMemoxx1k2s5gW"}, {"statCode": "8zADPqu8PVXnN0xl"}, {"statCode": "48RoZbNL7cXCVaF9"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'U1H9bQv7EybPwbHE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'HxSPaGCQl5y1geke' \
    --userId 'qHnzZfY22Z1SmIc5' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'NTRyLbOzAYD5IH4d' \
    --userId 'eTFCDORAsuT0lseQ' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.31346972123108396}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'OoohdBYhvvwspKpE' \
    --userId 'PUUxc2NKFB2qxCiW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.6285733465110026}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'NdvN9SDRKye6n1t8' \
    --userId 'RXF5qayS4UAMJrRr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'nNfXdTnJz7e3tD8K' \
    --userId 'VlMU17V03QDQjU64' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"lc3oek3RWXWJhPXv": {}, "S9OmmtZ14XROPpbg": {}, "qS9a9eP72cbSH4Tv": {}}, "additionalKey": "Y6sMCkitXsNfi8EF", "statCode": "3mgABwFe1N0QNery", "updateStrategy": "MIN", "userId": "oLl4yLZgHlatL7nb", "value": 0.2962897462290668}, {"additionalData": {"rfkzQM5RtMqCRiYe": {}, "7QxHteM0QsfB4cKc": {}, "pv0nqsAzwhiinZMK": {}}, "additionalKey": "2PQePnMgPL2upEuz", "statCode": "GkAuUgSs7KjVR3KE", "updateStrategy": "MAX", "userId": "SEc6kg2UWX8dfboa", "value": 0.26882993763783225}, {"additionalData": {"kOS5P8ijeU7ceEjs": {}, "JO7xZUK7lMGDnKhx": {}, "DxWqk0FyDBDBxAzn": {}}, "additionalKey": "XS1mfs6uZ9OaZwm6", "statCode": "pPAdF5lHMHzBycY7", "updateStrategy": "INCREMENT", "userId": "nprty5BQCd5sVLr7", "value": 0.7339844736017369}]' > $TEMP_JSON_INPUT
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
    --additionalKey 'lnKnQhYH2PkwSPXd' \
    --statCode 'Yk0YxFNno9WQq9ZH' \
    --userIds '["HjrwqKsa8ZqhezPI", "lBtGhWc8fY9HfUsE", "aPxVM4cVRtjpUequ"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'cPWZP6mJ5k9QPUVO' \
    --additionalKey '9elCnXCnhXRiCBS6' \
    --statCodes '["wONO7EzD1HwKEgGh", "6MctPOqg2vfaFiXb", "kyxYVJYoECX5Zk7z"]' \
    --tags '["rqRFfKg2QLfgPky9", "2H0SjmRKLX0YyNLg", "OIbDguxdqP6c448A"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"niKDjnb5cFYyJtzD": {}, "cKD3CR18eggGJVXR": {}, "OWQLNP4J0I2wDjuM": {}}, "statCode": "HSknrvHsarToh01s", "updateStrategy": "INCREMENT", "value": 0.5683579078239941}, {"additionalData": {"JJydenJ93Kb1pQle": {}, "HG1UoswJzp9GPpGy": {}, "kMepZ0J4UuZWR407": {}}, "statCode": "SE9ddXzA6F73IwV8", "updateStrategy": "INCREMENT", "value": 0.9250488496302502}, {"additionalData": {"ZjWvAiWvl12Eyddb": {}, "FelmB60OEQrMIsKC": {}, "f8GsPEl1i9RQ9tNv": {}}, "statCode": "9ZoFgoU8geQqTHsg", "updateStrategy": "INCREMENT", "value": 0.3356766722846478}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'ueyPPcbPVe3xxdxV' \
    --additionalKey 'hu4rkZZo8fTr6agu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkGetOrDefaultByUserId
# body param: body
echo '{"statCodes": ["73WSpmtV8p2sf0f3", "uCNxJIMiWHlRKeE5", "nz2XzHsONpORaUZ5"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetOrDefaultByUserId \
    --namespace $AB_NAMESPACE \
    --userId 'RKhreFD6wFvnLOEQ' \
    --additionalKey 'R2tp6q9pPGaWcS02' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkGetOrDefaultByUserId' test.out

#- 93 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"LciOGbTW0UOPodtV": {}, "EAHUTPJcWSRPDFdk": {}, "QZDrW0M7eIDrifb9": {}}, "statCode": "ovouuoyV36gCehJP"}, {"additionalData": {"43Xpu5gyQ14gMP9Z": {}, "4mEvMNjtERuv6NrO": {}, "6SjBOH0izSSpVoq4": {}}, "statCode": "E6CtycfHMbZoBgzD"}, {"additionalData": {"SnBtqToPbBDwdvFV": {}, "FTK8mQqqA2VoUKBl": {}, "sPXL4ibYVB9w0ETf": {}}, "statCode": "SauutS9JWgSB39nW"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'J0AdErhRmHmtCl6M' \
    --additionalKey '85ELRv5NEe9bR9ck' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'BulkResetUserStatItemValues' test.out

#- 94 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'NLMJjsgaXBRR415W' \
    --userId 'Jviuc5vA36xYMMPe' \
    --additionalKey 'p0zplFiRg22RpUVt' \
    > test.out 2>&1
eval_tap $? 94 'DeleteUserStatItems2' test.out

#- 95 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"QXjItygvyTYykvnB": {}, "2kvfxE0sqbjAHF9Q": {}, "LlS2lC0QB41qRS25": {}}, "updateStrategy": "OVERRIDE", "value": 0.7429965423200106}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'z3vp9jpSUMWJyDVl' \
    --userId 'daDNtR0AXW63sbPY' \
    --additionalKey 'TKP8EQupMajWTKw5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'UpdateUserStatItemValue' test.out

#- 96 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"FeR8ri3yXrzd1ieT": {}, "RurPzBSUlLhIUZaq": {}, "DR1n6aKcCVL5Fd1b": {}}, "additionalKey": "8wgnlhP7Pg5lC7Ea", "statCode": "270WU05apXkWulzf", "updateStrategy": "MIN", "userId": "ESEwZkxwcIoptsiG", "value": 0.8542888427997943}, {"additionalData": {"JEo50u4dtDARQghC": {}, "kujmLLnrNNSLh36U": {}, "QbPSJQQhceSla9ER": {}}, "additionalKey": "YYip5g4u0MAPcVPH", "statCode": "3gZ7BL95xBXZ4Q2k", "updateStrategy": "INCREMENT", "userId": "xP6eRLWH719H0S96", "value": 0.0579003946970309}, {"additionalData": {"6o92O9JTphnwOfFz": {}, "h20ovT23TbEK3bM3": {}, "0lxx1rT6fsKa4Igt": {}}, "additionalKey": "UwYePFCH42h6Lucf", "statCode": "BcrN83Rs41H9Aya2", "updateStrategy": "MAX", "userId": "gl7sPCMcCq8KOF1F", "value": 0.6635179009909143}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 96 'BulkUpdateUserStatItem1' test.out

#- 97 PublicQueryUserStatItems2
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --userId 'ASWEGLvHi2yA6ZsX' \
    --additionalKey 'JoVWUuZ6fQXMhnC8' \
    --statCodes '["iRACppkc2GjnJ6Mq", "okeFNTOal7C9QhMy", "KSxoXxGxkYjDcp3p"]' \
    --tags '["GTMJShikvBpSOkSV", "huAqkZqR3gW3GfD7", "JtchRl8UCypNxxUb"]' \
    > test.out 2>&1
eval_tap $? 97 'PublicQueryUserStatItems2' test.out

#- 98 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"XgFF9TJrlNNryir2": {}, "rcfzqMDXs2AMIqwX": {}, "xAtcjA062eWYCE2B": {}}, "statCode": "ZKl6Ks6ND0evlW05", "updateStrategy": "OVERRIDE", "value": 0.5881439377952264}, {"additionalData": {"ZuPAGpzW8YEovlYX": {}, "MD76ZVrjTwBhG6Px": {}, "RbXyacvJKvH2fI22": {}}, "statCode": "7sFhXEPpERr10WrT", "updateStrategy": "OVERRIDE", "value": 0.18934120132391907}, {"additionalData": {"9c1J0YV5SAUWFWpU": {}, "4iAd1zlFBNJu2Wke": {}, "GDSzlCaFt7Cu0JKj": {}}, "statCode": "LegxbCcIqhcBHRl1", "updateStrategy": "MIN", "value": 0.17569338692523195}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'eTI3GtLp33o0hY1h' \
    --additionalKey 'JyjnnZKdSiFaVEfx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'BulkUpdateUserStatItem2' test.out

#- 99 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"NwD82TygHqJCY44t": {}, "teOU73MUia86OHeE": {}, "ezPfPVoLzuailZgh": {}}, "updateStrategy": "MAX", "value": 0.0834519508820406}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'tM4duhPOP3T7IILg' \
    --userId 'TKDtEBnyydnlmrax' \
    --additionalKey '9HkcVJkcKNqoctZZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE