#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="dotnet ../../AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/AccelByte.Sdk.Sample.Cli.dll"
CLI_TOKEN_FILE="../../AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=14

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

#- 1 AdminListAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListAchievements \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '56' \
    --sortBy 'jv4Ax7Nz' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListAchievements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "Ykoppa0V", "defaultLanguage": "gFJAhHwT", "description": {"b5q010gN": "2MQrbpeR"}, "goalValue": 0.20816307040117976, "hidden": false, "incremental": true, "lockedIcons": [{"slug": "TFSMIbl1", "url": "a2jXLCtW"}], "name": {"mHJBi9So": "MkSE4eJe"}, "statCode": "lwO4KPMk", "tags": ["y2h8R2fI"], "unlockedIcons": [{"slug": "XoXP8gd7", "url": "JUabYc3G"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminCreateNewAchievement \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateNewAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 ExportAchievements
$CLI_EXE \
    --sn achievement \
    --op ExportAchievements \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportAchievements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 ImportAchievements
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn achievement \
    --op ImportAchievements \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --strategy 'MbxTlm1f' \
    >$TEMP_FILE 2>&1
update_status $? 'ImportAchievements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode 'su6J3C4s' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 AdminUpdateAchievement
# body param: body
echo '{"defaultLanguage": "5ppGR9Xc", "description": {"oxYTGgew": "rLfwvzJF"}, "goalValue": 0.886609202013211, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "NhKq2xdm", "url": "gEBepFHt"}], "name": {"f6Ziegqd": "EL4fsM6n"}, "statCode": "BzRVuC1r", "tags": ["7UH1Liu7"], "unlockedIcons": [{"slug": "UQ0304Mc", "url": "K873tRtr"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode '5cfWO5JJ' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode '2c6vsOns' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode 'NWGc7CiU' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAchievementListOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $TEST_NAMESPACE \
    --userId 'a4wM5Eu3' \
    --limit '94' \
    --offset '33' \
    --preferUnlocked 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUserAchievements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'msFXporM' \
    --namespace $TEST_NAMESPACE \
    --userId 'qEDR8E72' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUnlockAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $TEST_NAMESPACE \
    --limit '99' \
    --offset '76' \
    --sortBy 'Kfhl6eq2' \
    --language 'FzU3VL3L' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListAchievements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode 'NmPLeZdo' \
    --namespace $TEST_NAMESPACE \
    --language 'CXfabFXz' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $TEST_NAMESPACE \
    --userId 'vjLmai7f' \
    --limit '82' \
    --offset '72' \
    --preferUnlocked 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserAchievements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'E2Z4a63U' \
    --namespace $TEST_NAMESPACE \
    --userId 'VtLbQSWt' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUnlockAchievement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT