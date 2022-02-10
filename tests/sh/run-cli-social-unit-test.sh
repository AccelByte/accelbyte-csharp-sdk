#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=68

FINISHED_COUNT=0
SUCCESS_COUNT=0
FAILED_COUNT=0

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_NAMESPACE=$TEST_NAMESPACE

get_current_year() { echo $(date +'%Y'); }
get_adult_birthday() { echo "$(( $(get_current_year) - 22))-01-01"; }

get_random_int() { echo $(( $1 + ( RANDOM % (($2 - $1)) ) )); }
get_random_bool() { ( (( (RANDOM % 2) == 1)) && echo "true" ) || ( echo "false" ) }
get_random_element() { declare -a a=("$@"); r=$((RANDOM % ${#a[@]})); echo ${a[$r]}; }

create_file() {
    touch $1
}

delete_file() {
    [ ! -e $1 ] || rm $1
}

update_status() {
    return_code=$1
    operation_name=$2

    FINISHED_COUNT=$(( $FINISHED_COUNT + 1 ))

    if [ $return_code == 0 ]
    then
        SUCCESS_COUNT=$(( $SUCCESS_COUNT + 1 ))
        echo "ok $FINISHED_COUNT $operation_name"
    else
        FAILED_COUNT=$(( $FAILED_COUNT + 1 ))
        echo "not ok $FINISHED_COUNT - $operation_name"
        echo '  ---'
        echo '  error: |-'
        while read line; do
          echo "    $line" | tr '\n' ' '
        echo $line
        done < $TEMP_FILE
    fi
}

touch $TEMP_FILE

$CLI_EXE --op login --lt user --user user --pass user
rm -f $CLI_TOKEN_FILE
echo "foo" >> $CLI_TOKEN_FILE

echo 'TAP version 13'
echo "1..$OPERATIONS_COUNT"

#- 1 GetNamespaceSlotConfig
$CLI_EXE \
    --sn social \
    --op GetNamespaceSlotConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetNamespaceSlotConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 UpdateNamespaceSlotConfig
# body param: body
echo '{"maxSlotSize": 2, "maxSlots": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateNamespaceSlotConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateNamespaceSlotConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 DeleteNamespaceSlotConfig
$CLI_EXE \
    --sn social \
    --op DeleteNamespaceSlotConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteNamespaceSlotConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 GetUserSlotConfig
$CLI_EXE \
    --sn social \
    --op GetUserSlotConfig \
    --namespace $TEST_NAMESPACE \
    --userId 'jv4Ax7Nz' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSlotConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 UpdateUserSlotConfig
# body param: body
echo '{"maxSlotSize": 100, "maxSlots": 21}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserSlotConfig \
    --namespace $TEST_NAMESPACE \
    --userId 'oppa0VgF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserSlotConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 DeleteUserSlotConfig
$CLI_EXE \
    --sn social \
    --op DeleteUserSlotConfig \
    --namespace $TEST_NAMESPACE \
    --userId 'JAhHwTb5' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserSlotConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 GetUserProfiles
$CLI_EXE \
    --sn social \
    --op GetUserProfiles \
    --namespace $TEST_NAMESPACE \
    --userId 'q010gN2M' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserProfiles'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $TEST_NAMESPACE \
    --profileId 'QrbpeRnx' \
    --userId 'TlCTFSMI' \
    >$TEMP_FILE 2>&1
update_status $? 'GetProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 GetUserNamespaceSlots
$CLI_EXE \
    --sn social \
    --op GetUserNamespaceSlots \
    --namespace $TEST_NAMESPACE \
    --userId 'bl1a2jXL' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserNamespaceSlots'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 GetSlotData
$CLI_EXE \
    --sn social \
    --op GetSlotData \
    --namespace $TEST_NAMESPACE \
    --slotId 'CtWmHJBi' \
    --userId '9SoMkSE4' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSlotData'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 PublicGetUserGameProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserGameProfiles \
    --namespace $TEST_NAMESPACE \
    --userIds '["eJelwO4K"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserGameProfiles'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $TEST_NAMESPACE \
    --userId 'PMky2h8R' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserProfiles'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 PublicCreateProfile
# body param: body
echo '{"achievements": ["2fIXoXP8"], "attributes": {"gd7JUabY": "c3GMbxTl"}, "avatarUrl": "m1fsu6J3", "inventories": ["C4s5ppGR"], "label": "9XcoxYTG", "profileName": "gewrLfwv", "statistics": ["zJF4TpbN"], "tags": ["hKq2xdmg"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $TEST_NAMESPACE \
    --userId 'EBepFHtf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $TEST_NAMESPACE \
    --profileId '6ZiegqdE' \
    --userId 'L4fsM6nB' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 PublicUpdateProfile
# body param: body
echo '{"achievements": ["zRVuC1r7"], "attributes": {"UH1Liu7U": "Q0304McK"}, "avatarUrl": "873tRtr5", "inventories": ["cfWO5JJ2"], "label": "c6vsOns4", "profileName": "jNWGc7Ci", "statistics": ["Ua4wM5Eu"], "tags": ["3VqymsFX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $TEST_NAMESPACE \
    --profileId 'porMqEDR' \
    --userId '8E72XMKf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $TEST_NAMESPACE \
    --profileId 'hl6eq2Fz' \
    --userId 'U3VL3LNm' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeleteProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'PLeZdoCX' \
    --namespace $TEST_NAMESPACE \
    --profileId 'fabFXzvj' \
    --userId 'Lmai7fPK' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetProfileAttribute'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 PublicUpdateAttribute
# body param: body
echo '{"name": "vE2Z4a63", "value": "UVtLbQSW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'tsyz0mGG' \
    --namespace $TEST_NAMESPACE \
    --profileId 'yHHFIlIK' \
    --userId 'sXgvSrkE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateAttribute'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 PublicGetUserNamespaceSlots
$CLI_EXE \
    --sn social \
    --op PublicGetUserNamespaceSlots \
    --namespace $TEST_NAMESPACE \
    --userId 'gTYVk5iR' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserNamespaceSlots'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 PublicCreateUserNamespaceSlot
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op PublicCreateUserNamespaceSlot \
    --namespace $TEST_NAMESPACE \
    --userId 'BE6zJJ1B' \
    --label 'RHrfCHqq' \
    --tags '["p2GwPcmz"]' \
    --checksum 'SuY8w9VY' \
    --customAttribute 'wBEfRXoZ' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserNamespaceSlot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 PublicGetSlotData
$CLI_EXE \
    --sn social \
    --op PublicGetSlotData \
    --namespace $TEST_NAMESPACE \
    --slotId 'LfpVFfDw' \
    --userId 'jHHCW2g5' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetSlotData'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 PublicUpdateUserNamespaceSlot
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op PublicUpdateUserNamespaceSlot \
    --namespace $TEST_NAMESPACE \
    --slotId 'u8z9yrpJ' \
    --userId 'dIx5vvHS' \
    --label '3d6PKPE2' \
    --tags '["7mI6Px8j"]' \
    --checksum 't8Lq4x0F' \
    --customAttribute '7NcocelJ' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserNamespaceSlot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 PublicDeleteUserNamespaceSlot
$CLI_EXE \
    --sn social \
    --op PublicDeleteUserNamespaceSlot \
    --namespace $TEST_NAMESPACE \
    --slotId 'jtlKYu8i' \
    --userId 'CPznx0s5' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeleteUserNamespaceSlot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 PublicUpdateUserNamespaceSlotMetadata
# body param: body
echo '{"customAttribute": "TzT51oV4", "label": "HTmivmb6", "tags": ["tPmCirkh"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateUserNamespaceSlotMetadata \
    --namespace $TEST_NAMESPACE \
    --slotId 'YvcOUucj' \
    --userId 'PWGwPsvj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserNamespaceSlotMetadata'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 GetGlobalStatItems
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems \
    --namespace $TEST_NAMESPACE \
    --limit '74' \
    --offset '73' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGlobalStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $TEST_NAMESPACE \
    --statCode '1CjPt93u' \
    --userIds 'tbMkpUFH' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkFetchStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.7081205458396344, "statCode": "fL9q9SMN", "userId": "AUQVoiQt"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkIncUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.7002685939379123, "statCode": "C2kNSsmT", "userId": "0d2aBG4z"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkIncUserStatItemValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "A2zp1Ls0", "userId": "bD6dGgwk"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkResetUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 GetStats
$CLI_EXE \
    --sn social \
    --op GetStats \
    --namespace $TEST_NAMESPACE \
    --limit '100' \
    --offset '12' \
    >$TEMP_FILE 2>&1
update_status $? 'GetStats'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 CreateStat
# body param: body
echo '{"defaultValue": 0.5157158777225033, "description": "KuI2RJrb", "incrementOnly": false, "maximum": 0.6468212673965411, "minimum": 0.15942482713964934, "name": "pIletXrC", "setAsGlobal": false, "setBy": "CLIENT", "statCode": "s7nCqsod", "tags": ["oTFTcWla"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateStat'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 ExportStats
$CLI_EXE \
    --sn social \
    --op ExportStats \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportStats'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 ImportStats
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStats \
    --namespace $TEST_NAMESPACE \
    --replaceExisting 'True' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ImportStats'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $TEST_NAMESPACE \
    --limit '70' \
    --offset '52' \
    --keyword 'AknU6Hob' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryStats'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $TEST_NAMESPACE \
    --statCode 'ZgWlaLne' \
    >$TEMP_FILE 2>&1
update_status $? 'GetStat'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $TEST_NAMESPACE \
    --statCode 'dDfasTc8' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteStat'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 UpdateStat
# body param: body
echo '{"description": "gr2znWqD", "name": "6tIcfI5Z", "tags": ["4tUNQ7mQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $TEST_NAMESPACE \
    --statCode 'PjCalZgF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateStat'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $TEST_NAMESPACE \
    --userId 'VEQyqav0' \
    --limit '81' \
    --offset '100' \
    --statCodes 'mxCvMqVc' \
    --tags 'Xs2OqNz8' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "ZLBsncbR"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $TEST_NAMESPACE \
    --userId 'rf6uEdjU' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkCreateUserStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.20332129500511464, "statCode": "04WZNhgE"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $TEST_NAMESPACE \
    --userId 'GvqKWQTk' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkIncUserStatItem1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.47518057307118, "statCode": "5j6186p0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $TEST_NAMESPACE \
    --userId 'WfsnWZuU' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkIncUserStatItemValue1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "PsaRnVdr"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $TEST_NAMESPACE \
    --userId 'dBA2hXwY' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkResetUserStatItem1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $TEST_NAMESPACE \
    --statCode 'yzZMdlR4' \
    --userId 'cL76hnFD' \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $TEST_NAMESPACE \
    --statCode 'gTfofHdf' \
    --userId 'oSqDcaFh' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 IncUserStatItemValue
# body param: body
echo '{"inc": 0.6264282691012373}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $TEST_NAMESPACE \
    --statCode '1oKxI8f5' \
    --userId 'ocfy4EIx' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'IncUserStatItemValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"wBiB90vd": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $TEST_NAMESPACE \
    --statCode 'gS5YpKsd' \
    --userId 'bpiU2Ufy' \
    --additionalKey 'MO4DhL9f' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ResetUserStatItemValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $TEST_NAMESPACE \
    --statCode 'BKJvjBOU' \
    --userIds 'n3bYf5ou' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkFetchStatItems1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.7745398898284622, "statCode": "kbiExqT6", "userId": "Dk9QFqaA"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkIncUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.14783424224128894, "statCode": "wOI1P04d", "userId": "MHfTwrxB"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkIncUserStatItemValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "RfMxZrSf", "userId": "x3V8OXkM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkResetUserStatItem2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 CreateStat1
# body param: body
echo '{"defaultValue": 0.20443951411826944, "description": "7p2SyFDE", "incrementOnly": false, "maximum": 0.192094138217056, "minimum": 0.6678047284770188, "name": "ehPBqD12", "setAsGlobal": true, "setBy": "SERVER", "statCode": "vzNNZSu5", "tags": ["zZVgY3Zo"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateStat1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $TEST_NAMESPACE \
    --userId 'sfd01vaO' \
    --limit '65' \
    --offset '44' \
    --statCodes 'eHacvHRV' \
    --tags '345xB8ho' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "s4yaOBjM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $TEST_NAMESPACE \
    --userId 'xizCxx9q' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkCreateUserStatItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.707850639824159, "statCode": "IKlpdrqo"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $TEST_NAMESPACE \
    --userId '2smD9RPp' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkIncUserStatItem1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.15493470151047362, "statCode": "WK0k76i1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $TEST_NAMESPACE \
    --userId 'g7rYaEuN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkIncUserStatItemValue2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "CyPoQ0oH"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $TEST_NAMESPACE \
    --userId 'YXUQdtIk' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkResetUserStatItem3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $TEST_NAMESPACE \
    --statCode 'Akltd1zQ' \
    --userId 'BzzC6ldK' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 58 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $TEST_NAMESPACE \
    --statCode 'riI6lTRb' \
    --userId 'c1Z1HJHz' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserStatItems1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 59 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.1814296756879875}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $TEST_NAMESPACE \
    --statCode '23Ynwf5P' \
    --userId 'vGejCDgA' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicIncUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 60 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.27921450013155624}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $TEST_NAMESPACE \
    --statCode 'pXDcsHno' \
    --userId 'bnaYxGh3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicIncUserStatItemValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $TEST_NAMESPACE \
    --statCode 'FovBnr5V' \
    --userId 'UOHGqEcu' \
    >$TEMP_FILE 2>&1
update_status $? 'ResetUserStatItemValue1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"JYo3YfMD": {}}, "additionalKey": "w4PaBKsF", "statCode": "XorxY0ah", "updateStrategy": "MIN", "userId": "gHrE98qQ", "value": 0.7052280135420906}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItemV2 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkUpdateUserStatItemV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"Xh1W7MnK": {}}, "statCode": "2i8Ely25", "updateStrategy": "OVERRIDE", "value": 0.3477008218868378}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $TEST_NAMESPACE \
    --userId 'ulbNGSAj' \
    --additionalKey 'eiiANETl' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkUpdateUserStatItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $TEST_NAMESPACE \
    --statCode 'kncKPmri' \
    --userId '36MY2aVC' \
    --additionalKey 'NUJgcpAY' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserStatItems2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 65 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"bj0fidlW": {}}, "updateStrategy": "MIN", "value": 0.5449884544395301}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $TEST_NAMESPACE \
    --statCode 'aw5HSyDs' \
    --userId 'QqMUPrAx' \
    --additionalKey 'Ud1bmVSM' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserStatItemValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"44scgNAZ": {}}, "additionalKey": "f7a3R9rI", "statCode": "VTDDXZ1f", "updateStrategy": "OVERRIDE", "userId": "hMp688Jv", "value": 0.8988485437152824}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkUpdateUserStatItem1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 67 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"Q3hbDlcG": {}}, "statCode": "Rx2aExmV", "updateStrategy": "OVERRIDE", "value": 0.7799687494605654}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $TEST_NAMESPACE \
    --userId 'omWyrFZZ' \
    --additionalKey 'dM00sSdU' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkUpdateUserStatItem2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"ypOvoMvI": {}}, "updateStrategy": "OVERRIDE", "value": 0.6786082046185243}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $TEST_NAMESPACE \
    --statCode 'RxFsCUQz' \
    --userId '0koUsUcG' \
    --additionalKey 'fjtfyuPN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserStatItemValue1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT