#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="/tmp/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=28

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

#- 1 GetHealthcheckInfo
$CLI_EXE \
    --sn matchmaking \
    --op GetHealthcheckInfo \
    >$TEMP_FILE 2>&1
update_status $? 'GetHealthcheckInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 HandlerV3Healthz
$CLI_EXE \
    --sn matchmaking \
    --op HandlerV3Healthz \
    >$TEMP_FILE 2>&1
update_status $? 'HandlerV3Healthz'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetAllChannelsHandler
$CLI_EXE \
    --sn matchmaking \
    --op GetAllChannelsHandler \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '56' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllChannelsHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 CreateChannelHandler
# body param: body
echo '{"deployment": "jv4Ax7Nz", "description": "Ykoppa0V", "find_match_timeout_seconds": 12, "game_mode": "FJAhHwTb", "joinable": true, "max_delay_ms": 12, "rule_set": {"alliance": {"max_number": 79, "min_number": 76, "player_max_number": 85, "player_min_number": 34}, "alliance_flexing_rule": [{"duration": 2, "max_number": 31, "min_number": 8, "player_max_number": 87, "player_min_number": 26}], "flexing_rule": [{"attribute": "xTlCTFSM", "criteria": "Ibl1a2jX", "duration": 75, "reference": 0.447800154283432}], "match_options": {"options": [{"name": "WmHJBi9S", "type": "oMkSE4eJ"}]}, "matching_rule": [{"attribute": "elwO4KPM", "criteria": "ky2h8R2f", "reference": 0.5412446839893738}], "sub_game_modes": {"oXP8gd7J": {"alliance": {"max_number": 92, "min_number": 0, "player_max_number": 3, "player_min_number": 5}, "alliance_flexing_rule": [{"duration": 65, "max_number": 77, "min_number": 2, "player_max_number": 47, "player_min_number": 90}], "name": "lm1fsu6J"}}}, "session_queue_timeout_seconds": 57, "social_matchmaking": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateChannelHandler \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateChannelHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 DeleteChannelHandler
$CLI_EXE \
    --sn matchmaking \
    --op DeleteChannelHandler \
    --channel 'pGR9Xcox' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteChannelHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 StoreMatchResults
# body param: body
echo '{"match_id": "YTGgewrL", "players": [{"results": [{"attribute": "fwvzJF4T", "value": 0.24164757154358074}], "user_id": "NhKq2xdm"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'StoreMatchResults'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 QueueSessionHandler
# body param: body
echo '{"channel": "gEBepFHt", "client_version": "f6Ziegqd", "deployment": "EL4fsM6n", "game_mode": "BzRVuC1r", "joinable": false, "match_id": "u7UQ0304", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 77, "party_attributes": {"cK873tRt": {}}, "party_id": "r5cfWO5J", "party_members": [{"extra_attributes": {"J2c6vsOn": {}}, "user_id": "s4jNWGc7"}]}]}], "namespace": "CiUa4wM5", "party_attributes": {"Eu3Vqyms": {}}, "party_id": "FXporMqE", "queued_at": 59, "region": "R8E72XMK", "server_name": "fhl6eq2F", "status": "zU3VL3LN", "updated_at": "1977-11-30T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'QueueSessionHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 DequeueSessionHandler
# body param: body
echo '{"match_id": "LeZdoCXf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op DequeueSessionHandler \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DequeueSessionHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 QuerySessionHandler
$CLI_EXE \
    --sn matchmaking \
    --op QuerySessionHandler \
    --matchID 'abFXzvjL' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'QuerySessionHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 25, "userID": "ai7fPKvE", "weight": 0.8591577024149795}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdatePlayTimeWeight \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePlayTimeWeight'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 GetAllPartyInAllChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInAllChannel \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllPartyInAllChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 BulkGetSessions
$CLI_EXE \
    --sn matchmaking \
    --op BulkGetSessions \
    --namespace $TEST_NAMESPACE \
    --matchIDs '4a63UVtL' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkGetSessions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 ExportChannels
$CLI_EXE \
    --sn matchmaking \
    --op ExportChannels \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportChannels'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 ImportChannels
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn matchmaking \
    --op ImportChannels \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --strategy 'bQSWtsyz' \
    >$TEMP_FILE 2>&1
update_status $? 'ImportChannels'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName '0mGGyHHF' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetSingleMatchmakingChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "IlIKsXgv", "description": "SrkEgTYV", "findMatchTimeoutSeconds": 21, "joinable": false, "max_delay_ms": 86, "ruleSet": {"alliance": {"maxNumber": 54, "minNumber": 61, "playerMaxNumber": 51, "playerMinNumber": 71}, "alliance_flexing_rule": [{"duration": 70, "max_number": 54, "min_number": 86, "player_max_number": 67, "player_min_number": 34}], "flexingRules": [{"attribute": "fCHqqp2G", "criteria": "wPcmzSuY", "duration": 44, "reference": 0.966459071248867}], "match_options": {"options": [{"name": "YwBEfRXo", "type": "ZLfpVFfD"}]}, "matchingRules": [{"attribute": "wjHHCW2g", "criteria": "5u8z9yrp", "reference": 0.5580847789487178}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 68, "socialMatchmaking": true, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'vHS3d6PK' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateMatchmakingChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'PE27mI6P' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllPartyInChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'x8jt8Lq4' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllSessionsInChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["x0F7Ncoc"], "party_id": "elJjtlKY", "user_id": "u8iCPznx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName '0s5TzT51' \
    --matchID 'oV4HTmiv' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddUserIntoSessionInChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'mb6tPmCi' \
    --matchID 'rkhYvcOU' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSessionInChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'ucjPWGwP' \
    --matchID 'svjLK1Cj' \
    --namespace $TEST_NAMESPACE \
    --userID 'Pt93utbM' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserFromSessionInChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 SearchSessions
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessions \
    --namespace $TEST_NAMESPACE \
    --channel 'kpUFHT0f' \
    --deleted 'True' \
    --matchID '9SMNAUQV' \
    --partyID 'oiQtSQC2' \
    --userID 'kNSsmT0d' \
    --limit '0.8471044674591004' \
    --offset '0.4343179427166882' \
    >$TEMP_FILE 2>&1
update_status $? 'SearchSessions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 GetSessionHistoryDetailed
$CLI_EXE \
    --sn matchmaking \
    --op GetSessionHistoryDetailed \
    --matchID '4zA2zp1L' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetSessionHistoryDetailed'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 PublicGetMessages
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetMessages \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMessages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 PublicGetAllMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetAllMatchmakingChannel \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetAllMatchmakingChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 PublicGetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetSingleMatchmakingChannel \
    --channelName 's0bD6dGg' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetSingleMatchmakingChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 SearchSessionsV2
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessionsV2 \
    --namespace $TEST_NAMESPACE \
    --channel 'wkYgHzKu' \
    --deleted 'True' \
    --matchID 'boP7kfpI' \
    --partyID 'letXrCK1' \
    --userID 'UVO0jcs7' \
    --limit '0.20615094482549756' \
    --offset '0.25349997202377916' \
    >$TEMP_FILE 2>&1
update_status $? 'SearchSessionsV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 VersionCheckHandler
$CLI_EXE \
    --sn matchmaking \
    --op VersionCheckHandler \
    >$TEMP_FILE 2>&1
update_status $? 'VersionCheckHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT