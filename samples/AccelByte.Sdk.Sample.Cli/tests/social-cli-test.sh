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
echo "1..89"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

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
    --userId 'i3wMWnoZ' \
    > test.out 2>&1
eval_tap $? 5 'GetUserSlotConfig' test.out

#- 6 UpdateUserSlotConfig
# body param: body
echo '{"maxSlotSize": 12, "maxSlots": 63}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserSlotConfig \
    --namespace $AB_NAMESPACE \
    --userId 'Ihwb8YYM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'UpdateUserSlotConfig' test.out

#- 7 DeleteUserSlotConfig
$CLI_EXE \
    --sn social \
    --op DeleteUserSlotConfig \
    --namespace $AB_NAMESPACE \
    --userId 'LqpQwkRR' \
    > test.out 2>&1
eval_tap $? 7 'DeleteUserSlotConfig' test.out

#- 8 GetUserProfiles
$CLI_EXE \
    --sn social \
    --op GetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'HkaiKsmI' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'iRLR3IlN' \
    --userId 'JKxhPfWV' \
    > test.out 2>&1
eval_tap $? 9 'GetProfile' test.out

#- 10 GetUserNamespaceSlots
$CLI_EXE \
    --sn social \
    --op GetUserNamespaceSlots \
    --namespace $AB_NAMESPACE \
    --userId '6dIabcFb' \
    > test.out 2>&1
eval_tap $? 10 'GetUserNamespaceSlots' test.out

#- 11 GetSlotData
$CLI_EXE \
    --sn social \
    --op GetSlotData \
    --namespace $AB_NAMESPACE \
    --slotId 'SmeuIBro' \
    --userId 'F7bwRgwK' \
    > test.out 2>&1
eval_tap $? 11 'GetSlotData' test.out

#- 12 PublicGetUserGameProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserGameProfiles \
    --namespace $AB_NAMESPACE \
    --userIds '["vzESbhpx", "lDdEs4ig", "dKeLmy8t"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'Z5GZi5P1' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["2c61ts3f", "MI04rm2j", "Uc9iav3t"], "attributes": {"TqlE9oLD": "PD0Lfle8", "ESU1MO8X": "nVaEyjmi", "fJDYa1TJ": "PUszmFGE"}, "avatarUrl": "kJVvqDSU", "inventories": ["3PDyIAGf", "Gq1FNmRW", "vUvDPnKo"], "label": "ECjGUg86", "profileName": "7xodwuG1", "statistics": ["4ID5l5wj", "6K2wEMnc", "kjlW6Byw"], "tags": ["sSSZTGlu", "bsmhjXcS", "cOUvrjJB"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'O7tbkTGY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'KqRMSTis' \
    --userId 'P0MrSdaF' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["y0pJYCdf", "kfyt09ro", "5fHdWqJT"], "attributes": {"NjrmpnnE": "ckHH8kT9", "oXVander": "cf1nq4Hf", "32SL5Pja": "YEDxaYN8"}, "avatarUrl": "w9KUW0py", "inventories": ["8KrcQfuc", "Sq2X8gFu", "JORk4j04"], "label": "YfnXTsQU", "profileName": "rA0WWyKl", "statistics": ["2K5mCSoG", "eQCahcox", "63cyDxAA"], "tags": ["YcRXJdoS", "TxNCK9AI", "jNmbfoW8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'bDq5jPqz' \
    --userId 'hN0YdGSr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'A9LXRwU6' \
    --userId 'WLgpQE9n' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'XzhBC0uy' \
    --namespace $AB_NAMESPACE \
    --profileId 'MR4Xf2nf' \
    --userId 'YvNvG8uQ' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "14AhsxaA", "value": "LiBwpNJo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'rnrCQpMJ' \
    --namespace $AB_NAMESPACE \
    --profileId 'j5igqat8' \
    --userId 'xnPoWTdH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'PublicUpdateAttribute' test.out

#- 20 PublicGetUserNamespaceSlots
$CLI_EXE \
    --sn social \
    --op PublicGetUserNamespaceSlots \
    --namespace $AB_NAMESPACE \
    --userId 'AkcyAy4d' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetUserNamespaceSlots' test.out

#- 21 PublicCreateUserNamespaceSlot
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op PublicCreateUserNamespaceSlot \
    --namespace $AB_NAMESPACE \
    --userId 'rHlPcXGG' \
    --label 'l0Xw3veB' \
    --tags '["frpCrnba", "xhEvn3SG", "qcH91fC3"]' \
    --checksum 'aJEoqWaF' \
    --customAttribute 'AGD6PRg9' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'PublicCreateUserNamespaceSlot' test.out

#- 22 PublicGetSlotData
$CLI_EXE \
    --sn social \
    --op PublicGetSlotData \
    --namespace $AB_NAMESPACE \
    --slotId '5m07l03v' \
    --userId 'tlMFzeiM' \
    > test.out 2>&1
eval_tap $? 22 'PublicGetSlotData' test.out

#- 23 PublicUpdateUserNamespaceSlot
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op PublicUpdateUserNamespaceSlot \
    --namespace $AB_NAMESPACE \
    --slotId 'RkcOr1L0' \
    --userId 'TMIczbYi' \
    --label 'lOziwG8C' \
    --tags '["PLOzSZm9", "K3cMY617", "HSCYZaL4"]' \
    --checksum '6I3PgCcQ' \
    --customAttribute '0axTWnmy' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 23 'PublicUpdateUserNamespaceSlot' test.out

#- 24 PublicDeleteUserNamespaceSlot
$CLI_EXE \
    --sn social \
    --op PublicDeleteUserNamespaceSlot \
    --namespace $AB_NAMESPACE \
    --slotId 'EYLZQTpv' \
    --userId 'LH6QPEBP' \
    > test.out 2>&1
eval_tap $? 24 'PublicDeleteUserNamespaceSlot' test.out

#- 25 PublicUpdateUserNamespaceSlotMetadata
# body param: body
echo '{"customAttribute": "8kSSFjeu", "label": "L3wQQPYw", "tags": ["mYFbxRvH", "YDCYwoGd", "mzXgf1ew"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateUserNamespaceSlotMetadata \
    --namespace $AB_NAMESPACE \
    --slotId 'UTvnu0en' \
    --userId 'sa3MZF7D' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicUpdateUserNamespaceSlotMetadata' test.out

#- 26 GetGlobalStatItems
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems \
    --namespace $AB_NAMESPACE \
    --limit '94' \
    --offset '0' \
    --statCodes 'swnkSyuJ' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'TVjKQ1OR' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'WEEKLY' \
    --limit '0' \
    --name 'EIAePvDO' \
    --offset '71' \
    --sortBy 'xkVgyRk1' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "ANNUALLY", "description": "FY3lxe16", "end": "1989-02-04T00:00:00Z", "name": "sSRzkf2H", "resetDate": 53, "resetDay": 56, "resetMonth": 50, "resetTime": "cEio5Uyv", "seasonPeriod": 43, "start": "1991-09-15T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId 'qbEHkCQw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'GetStatCycle' test.out

#- 31 UpdateStatCycle
# body param: body
echo '{"cycleType": "WEEKLY", "description": "GnUyCMEb", "end": "1988-03-02T00:00:00Z", "name": "YZT0yJJ0", "resetDate": 42, "resetDay": 91, "resetMonth": 58, "resetTime": "uj6DjUw3", "seasonPeriod": 14, "start": "1987-06-08T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'IiTEoTCS' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'UpdateStatCycle' test.out

#- 32 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'xjAqg9oG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'DeleteStatCycle' test.out

#- 33 BulkAddStats
# body param: body
echo '{"statCodes": ["VEdC8mQi", "r1Af0G6O", "rPH6Zsjp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'PgHKISHt' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'BulkAddStats' test.out

#- 34 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'B8tWdJM9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'StopStatCycle' test.out

#- 35 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'Qc5HmR0v' \
    --userIds 'knXO45AU' \
    > test.out 2>&1
eval_tap $? 35 'BulkFetchStatItems' test.out

#- 36 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.312124858527712, "statCode": "NXSTItt3", "userId": "5OJTfJBZ"}, {"inc": 0.7943413282934074, "statCode": "62yI9g5R", "userId": "DrlzPFQm"}, {"inc": 0.6329432900421776, "statCode": "u3ERxV0U", "userId": "TaiSzfi0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkIncUserStatItem' test.out

#- 37 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.5021550788236379, "statCode": "nBERe8qN", "userId": "YRTYSaZw"}, {"inc": 0.9172352176303227, "statCode": "NqSNylcl", "userId": "juNM3eUU"}, {"inc": 0.7120540852993618, "statCode": "D1pZGMfP", "userId": "dGIOAZ86"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'BulkIncUserStatItemValue' test.out

#- 38 BulkFetchOrDefaultStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'un0L98WU' \
    --userIds '["oXvfU4qM", "Ipfgxw2f", "f5twRYbt"]' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchOrDefaultStatItems' test.out

#- 39 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "dK2r4wWs", "userId": "6IpYBxaf"}, {"statCode": "o9b4xJyN", "userId": "nvHKrm8U"}, {"statCode": "uNlT86N9", "userId": "yO0vyD6J"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkResetUserStatItem' test.out

#- 40 GetStats
$CLI_EXE \
    --sn social \
    --op GetStats \
    --namespace $AB_NAMESPACE \
    --cycleIds '5brVo20e' \
    --isGlobal 'false' \
    --limit '94' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 40 'GetStats' test.out

#- 41 CreateStat
# body param: body
echo '{"cycleIds": ["jrinAVVo", "pbmX3lLF", "vpAAXNzc"], "defaultValue": 0.07778216215575195, "description": "XCiaXP8j", "incrementOnly": true, "maximum": 0.46758681653803336, "minimum": 0.01193050738646595, "name": "yYAkF18Y", "setAsGlobal": true, "setBy": "CLIENT", "statCode": "wRxcREyU", "tags": ["r2QcwlRr", "nDi33Izt", "5CwqGJF6"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'CreateStat' test.out

#- 42 ExportStats
$CLI_EXE \
    --sn social \
    --op ExportStats \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'ExportStats' test.out

#- 43 ImportStats
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStats \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'false' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 43 'ImportStats' test.out

#- 44 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'false' \
    --limit '1' \
    --offset '31' \
    --keyword 'jlpk8lfu' \
    > test.out 2>&1
eval_tap $? 44 'QueryStats' test.out

#- 45 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'iJVcktlx' \
    > test.out 2>&1
eval_tap $? 45 'GetStat' test.out

#- 46 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode '9zJZVVCc' \
    > test.out 2>&1
eval_tap $? 46 'DeleteStat' test.out

#- 47 UpdateStat
# body param: body
echo '{"cycleIds": ["poTVCNrc", "MmCkIqwq", "9bpIHEWQ"], "defaultValue": 0.0032914859645957195, "description": "VozsjIXO", "name": "2EUsAfBv", "tags": ["s2R3VMti", "o6Llcalk", "pTVxXAF8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'KhOKqbrE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'UpdateStat' test.out

#- 48 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'CijFxOpO' \
    > test.out 2>&1
eval_tap $? 48 'DeleteTiedStat' test.out

#- 49 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'zxeTLJQs' \
    --namespace $AB_NAMESPACE \
    --userId 'ZcTEzXaX' \
    --limit '96' \
    --offset '38' \
    --sortBy 'zpsAV6ct' \
    --statCodes '6XITL0QE' \
    > test.out 2>&1
eval_tap $? 49 'GetUserStatCycleItems' test.out

#- 50 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'kadMSQlu' \
    --limit '54' \
    --offset '18' \
    --sortBy 'oED9oYwS' \
    --statCodes '8oLyErKv' \
    --tags 'RtHFGJRo' \
    > test.out 2>&1
eval_tap $? 50 'GetUserStatItems' test.out

#- 51 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "GW7VBG1V"}, {"statCode": "B2sp2x9m"}, {"statCode": "szGGoyhG"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'ZAzt2OVB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'BulkCreateUserStatItems' test.out

#- 52 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.7270946081061889, "statCode": "LwSH8hWR"}, {"inc": 0.745854479770209, "statCode": "9pbItGQ7"}, {"inc": 0.7588972446402034, "statCode": "UWBhGolw"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'afIfbF1G' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'BulkIncUserStatItem1' test.out

#- 53 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.6026307005118765, "statCode": "FnrQ4T5c"}, {"inc": 0.19864064810988324, "statCode": "w7U1TxiS"}, {"inc": 0.8474451487970959, "statCode": "6UEoaDZp"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'XOWzpXOi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'BulkIncUserStatItemValue1' test.out

#- 54 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "2cpajtqc"}, {"statCode": "XjPkj2Iz"}, {"statCode": "U3MEpCt1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'IjlfHJM9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'BulkResetUserStatItem1' test.out

#- 55 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode '2t9j1XT2' \
    --userId 'ErwIxkaT' \
    > test.out 2>&1
eval_tap $? 55 'CreateUserStatItem' test.out

#- 56 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'nYtr1YDn' \
    --userId 'aXB0JOS4' \
    > test.out 2>&1
eval_tap $? 56 'DeleteUserStatItems' test.out

#- 57 IncUserStatItemValue
# body param: body
echo '{"inc": 0.7924250524786457}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'KVT66sHY' \
    --userId 'PgVsfhoE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'IncUserStatItemValue' test.out

#- 58 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"idKw4IP0": {}, "NVnaango": {}, "rhVFpTRu": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'QyMroT2h' \
    --userId 'NfKJ7q8s' \
    --additionalKey 'ifSPmYSs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'ResetUserStatItemValue' test.out

#- 59 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '57' \
    --offset '48' \
    --statCodes 'NmGhxv1v' \
    > test.out 2>&1
eval_tap $? 59 'GetGlobalStatItems1' test.out

#- 60 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'uN7Xv6Ou' \
    > test.out 2>&1
eval_tap $? 60 'GetGlobalStatItemByStatCode1' test.out

#- 61 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'WEEKLY' \
    --limit '31' \
    --name 'RR1jPh8R' \
    --offset '3' \
    --sortBy '6EAl7d3K' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 61 'GetStatCycles1' test.out

#- 62 GetStatCycle1
$CLI_EXE \
    --sn social \
    --op GetStatCycle1 \
    --cycleId 'Rf1gdXM7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 62 'GetStatCycle1' test.out

#- 63 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'QlAlnjAf' \
    --userIds 'gxOdZdf9' \
    > test.out 2>&1
eval_tap $? 63 'BulkFetchStatItems1' test.out

#- 64 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.3115894934536876, "statCode": "LHO1qrNy", "userId": "hmUEADcz"}, {"inc": 0.41159323662322433, "statCode": "rL31HuYK", "userId": "sCBBgwb1"}, {"inc": 0.1237534696372321, "statCode": "GjHJgxrc", "userId": "EvnfJqU4"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'PublicBulkIncUserStatItem' test.out

#- 65 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.12539159491563012, "statCode": "Cv5egSQD", "userId": "ePKSZKp6"}, {"inc": 0.418958547095038, "statCode": "wDQS1atv", "userId": "JrALaipl"}, {"inc": 0.5670547076130424, "statCode": "gRhedl5E", "userId": "wh3jDayY"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PublicBulkIncUserStatItemValue' test.out

#- 66 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "StUiBB1y", "userId": "z3iP8gH8"}, {"statCode": "8UenlMVz", "userId": "IOP8NOf9"}, {"statCode": "1LsD7cWW", "userId": "OgAs8ThM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'BulkResetUserStatItem2' test.out

#- 67 CreateStat1
# body param: body
echo '{"cycleIds": ["pAGIapYf", "hdiS41VB", "tYZkBXiE"], "defaultValue": 0.4303432922187934, "description": "EUvoBlbH", "incrementOnly": true, "maximum": 0.879647195099073, "minimum": 0.028796480984580097, "name": "obxtljIf", "setAsGlobal": true, "setBy": "CLIENT", "statCode": "gjP9onbx", "tags": ["FcxS2OZZ", "fXO3HkJT", "OPscPA2n"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'CreateStat1' test.out

#- 68 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId '25C1zEnA' \
    --namespace $AB_NAMESPACE \
    --userId 'MGmFy7w6' \
    --limit '9' \
    --offset '12' \
    --sortBy 'qnMeKFo7' \
    --statCodes 'U8Scr9xm' \
    > test.out 2>&1
eval_tap $? 68 'GetUserStatCycleItems1' test.out

#- 69 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '68w7s9RM' \
    --limit '48' \
    --offset '14' \
    --sortBy '2hc45QX2' \
    --statCodes '34xnqlbR' \
    --tags 'APFQsca6' \
    > test.out 2>&1
eval_tap $? 69 'PublicQueryUserStatItems' test.out

#- 70 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "n9vGZTCC"}, {"statCode": "XQ2Lf7jt"}, {"statCode": "exB613cb"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'iJEUePVZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkCreateUserStatItems' test.out

#- 71 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'QaoEY2zr' \
    --statCodes '["pLuvrx96", "OOz45vMi", "R3QYZJKV"]' \
    --tags '["NlK8PTaI", "XRWFTyA9", "MDnKGXqq"]' \
    > test.out 2>&1
eval_tap $? 71 'PublicQueryUserStatItems1' test.out

#- 72 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.9572451442605838, "statCode": "Zk705hOh"}, {"inc": 0.0801473464747956, "statCode": "nJi6dNVF"}, {"inc": 0.9555565870676781, "statCode": "zwjXqlcD"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId '2LzaOwIF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicBulkIncUserStatItem1' test.out

#- 73 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.919728097284807, "statCode": "tEsCwoAV"}, {"inc": 0.0374882286731234, "statCode": "ZCSj80gz"}, {"inc": 0.5108245191617625, "statCode": "vpvIerFE"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'yxTugoTd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'BulkIncUserStatItemValue2' test.out

#- 74 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "50RmJFX9"}, {"statCode": "v4GPfyGu"}, {"statCode": "Q2UEl0U5"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'Z9UnQmZq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'BulkResetUserStatItem3' test.out

#- 75 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'X15hBb4d' \
    --userId 'lNTIBDtH' \
    > test.out 2>&1
eval_tap $? 75 'PublicCreateUserStatItem' test.out

#- 76 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'unwNLLfK' \
    --userId 'CQKuu2MW' \
    > test.out 2>&1
eval_tap $? 76 'DeleteUserStatItems1' test.out

#- 77 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.8044886853056008}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'pEpNjHWP' \
    --userId 'cFSnM7GA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'PublicIncUserStatItem' test.out

#- 78 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.33990671554491625}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'k19sXDis' \
    --userId 'h7KUVhmA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicIncUserStatItemValue' test.out

#- 79 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'wmAygsnn' \
    --userId '8pM7l6v0' \
    > test.out 2>&1
eval_tap $? 79 'ResetUserStatItemValue1' test.out

#- 80 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"elLMceGG": {}, "gb5FJHWE": {}, "6s13b7dm": {}}, "additionalKey": "nPijw6U8", "statCode": "GGp0E886", "updateStrategy": "OVERRIDE", "userId": "tSNIwGhi", "value": 0.011898121236294523}, {"additionalData": {"6cqoWmnh": {}, "tuzxir12": {}, "r0VUWI0k": {}}, "additionalKey": "JAczj5Ap", "statCode": "csiEQ65l", "updateStrategy": "MAX", "userId": "ftqoxujX", "value": 0.47942725909424944}, {"additionalData": {"osOo2kSU": {}, "fIA1guTN": {}, "x7haejXS": {}}, "additionalKey": "V2oH2uH8", "statCode": "S4Zx0ACt", "updateStrategy": "INCREMENT", "userId": "aKWgAVjZ", "value": 0.5926769653309975}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItemV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'BulkUpdateUserStatItemV2' test.out

#- 81 BulkFetchOrDefaultStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems1 \
    --namespace $AB_NAMESPACE \
    --additionalKey 'DxiezEbu' \
    --statCode 'MCz9J4dP' \
    --userIds '["RGzoQLYI", "WPPZvyPu", "pimCENHE"]' \
    > test.out 2>&1
eval_tap $? 81 'BulkFetchOrDefaultStatItems1' test.out

#- 82 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"enqjRSxO": {}, "9oZ0fCxL": {}, "R0GfjwCm": {}}, "statCode": "DrbDR0Q0", "updateStrategy": "MAX", "value": 0.1530562071664967}, {"additionalData": {"RmV0CPt1": {}, "LUaTvrFa": {}, "xzOfG3pT": {}}, "statCode": "ddIA0Rt6", "updateStrategy": "MIN", "value": 0.30719314977669576}, {"additionalData": {"o4OtwF9u": {}, "PUAxerdI": {}, "qWmOoMyY": {}}, "statCode": "p2tSrLxp", "updateStrategy": "MAX", "value": 0.21955879234231113}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'j9JtgjWm' \
    --additionalKey 'jx1WuNQq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkUpdateUserStatItem' test.out

#- 83 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"4v8FnVzd": {}, "bNW1xuV7": {}, "rVei1o9z": {}}, "statCode": "V6rhVfcQ"}, {"additionalData": {"mLfEn5ZU": {}, "GeYlOwOD": {}, "WBAz6skH": {}}, "statCode": "Mfl4Hjw9"}, {"additionalData": {"KEnx8cNf": {}, "DK45zWtw": {}, "YhRoNPwK": {}}, "statCode": "ema6caMT"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'OcivPAkm' \
    --additionalKey 'P8Awb0Nq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'BulkResetUserStatItemValues' test.out

#- 84 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'tvSR9q6l' \
    --userId '5k9BLQMr' \
    --additionalKey 'PoTuxdzE' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems2' test.out

#- 85 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"YAw5VdW0": {}, "5WnQEAbK": {}, "416LN2N6": {}}, "updateStrategy": "OVERRIDE", "value": 0.7457343336192778}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'VA9mU8Uv' \
    --userId 'ONyjv3GQ' \
    --additionalKey 'uLHoQ6eh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'UpdateUserStatItemValue' test.out

#- 86 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"LLK5h1bE": {}, "9WU6w3tj": {}, "UhSCKySP": {}}, "additionalKey": "Y7yMGOuQ", "statCode": "Ofx6HIFf", "updateStrategy": "MIN", "userId": "AsKf8UfQ", "value": 0.27153671401292867}, {"additionalData": {"TQ8v7gXy": {}, "FuLFZViQ": {}, "bxYQvUya": {}}, "additionalKey": "po6FmMy6", "statCode": "tZYSCe7d", "updateStrategy": "MIN", "userId": "PU0aS2OI", "value": 0.2470636875287998}, {"additionalData": {"0B2FWiDu": {}, "7POaotJo": {}, "QQyL1bCD": {}}, "additionalKey": "NisOhjEK", "statCode": "FWmj7ioi", "updateStrategy": "MIN", "userId": "WZ6ZymQe", "value": 0.773230745941379}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'BulkUpdateUserStatItem1' test.out

#- 87 PublicQueryUserStatItems2
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --userId 'SZZma57V' \
    --additionalKey '6b9uLloA' \
    --statCodes '["A9KoetyN", "PkgWcTCN", "7aBIFfeR"]' \
    --tags '["dnHpse2T", "7eZwkVrB", "3GSEmVq8"]' \
    > test.out 2>&1
eval_tap $? 87 'PublicQueryUserStatItems2' test.out

#- 88 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"CjR5rCx0": {}, "ZiHwUqL5": {}, "rITYFhcd": {}}, "statCode": "eNwLmZen", "updateStrategy": "MIN", "value": 0.3547559640822787}, {"additionalData": {"W1oxENH4": {}, "MsVlbCMc": {}, "5hx0W14S": {}}, "statCode": "kvovINeg", "updateStrategy": "MIN", "value": 0.9838738491772198}, {"additionalData": {"legebqGw": {}, "ej59Ok8E": {}, "M0OFW93F": {}}, "statCode": "kJicmK6q", "updateStrategy": "INCREMENT", "value": 0.6256966889399064}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'zMB9XHHk' \
    --additionalKey 'fZgB6Vt5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'BulkUpdateUserStatItem2' test.out

#- 89 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"qWaae3Sb": {}, "oVKgjsry": {}, "C98whmI5": {}}, "updateStrategy": "MAX", "value": 0.6858077811418138}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'mcT57Hl2' \
    --userId 'PvPOKvc2' \
    --additionalKey '5nnSLnEn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE