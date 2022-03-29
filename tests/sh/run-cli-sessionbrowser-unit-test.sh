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

OPERATIONS_COUNT=15

FINISHED_COUNT=0
SUCCESS_COUNT=0
FAILED_COUNT=0

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_APP_NAME="UnitTest"
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

#- 1 GetTotalActiveSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetTotalActiveSession \
    --namespace $TEST_NAMESPACE \
    --sessionType 'b0Cjv4Ax' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTotalActiveSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 GetActiveCustomGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveCustomGameSessions \
    --namespace $TEST_NAMESPACE \
    --serverRegion '7NzYkopp' \
    --sessionId 'a0VgFJAh' \
    >$TEMP_FILE 2>&1
update_status $? 'GetActiveCustomGameSessions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetActiveMatchmakingGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveMatchmakingGameSessions \
    --namespace $TEST_NAMESPACE \
    --matchId 'HwTb5q01' \
    --serverRegion '0gN2MQrb' \
    --sessionId 'peRnxTlC' \
    >$TEMP_FILE 2>&1
update_status $? 'GetActiveMatchmakingGameSessions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 AdminGetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminGetSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'TFSMIbl1' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 QuerySession
$CLI_EXE \
    --sn sessionbrowser \
    --op QuerySession \
    --namespace $TEST_NAMESPACE \
    --gameMode 'a2jXLCtW' \
    --gameVersion 'mHJBi9So' \
    --joinable 'MkSE4eJe' \
    --limit '23' \
    --matchExist 'wO4KPMky' \
    --matchId '2h8R2fIX' \
    --offset '28' \
    --serverStatus 'XP8gd7JU' \
    --userId 'abYc3GMb' \
    --sessionType 'xTlm1fsu' \
    >$TEMP_FILE 2>&1
update_status $? 'QuerySession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 CreateSession
# body param: body
echo '{"game_session_setting": {"allow_join_in_progress": true, "current_internal_player": 36, "current_player": 30, "map_name": "pGR9Xcox", "max_internal_player": 90, "max_player": 65, "mode": "gewrLfwv", "num_bot": 51, "password": "JF4TpbNh", "settings": {"Kq2xdmgE": {}}}, "game_version": "BepFHtf6", "namespace": "ZiegqdEL", "session_type": "4fsM6nBz", "username": "RVuC1r7U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op CreateSession \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 GetSessionByUserIDs
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSessionByUserIDs \
    --namespace $TEST_NAMESPACE \
    --userIds 'H1Liu7UQ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSessionByUserIDs'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 GetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSession \
    --namespace $TEST_NAMESPACE \
    --sessionID '0304McK8' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 UpdateSession
# body param: body
echo '{"game_current_player": 39, "game_max_player": 87}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op UpdateSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'tr5cfWO5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 DeleteSession
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'JJ2c6vsO' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 JoinSession
# body param: body
echo '{"password": "ns4jNWGc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op JoinSession \
    --namespace $TEST_NAMESPACE \
    --sessionID '7CiUa4wM' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'JoinSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 DeleteSessionLocalDS
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSessionLocalDS \
    --namespace $TEST_NAMESPACE \
    --sessionID '5Eu3Vqym' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSessionLocalDS'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 AddPlayerToSession
# body param: body
echo '{"as_spectator": true, "user_id": "FXporMqE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op AddPlayerToSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'DR8E72XM' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddPlayerToSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 RemovePlayerFromSession
$CLI_EXE \
    --sn sessionbrowser \
    --op RemovePlayerFromSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'Kfhl6eq2' \
    --userID 'FzU3VL3L' \
    >$TEMP_FILE 2>&1
update_status $? 'RemovePlayerFromSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 GetRecentPlayer
$CLI_EXE \
    --sn sessionbrowser \
    --op GetRecentPlayer \
    --namespace $TEST_NAMESPACE \
    --userID 'NmPLeZdo' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRecentPlayer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT