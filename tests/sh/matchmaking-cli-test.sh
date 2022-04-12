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
echo "1..29"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetHealthcheckInfo
$CLI_EXE \
    --sn matchmaking \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 HandlerV3Healthz
$CLI_EXE \
    --sn matchmaking \
    --op HandlerV3Healthz \
    > test.out 2>&1
eval_tap $? 3 'HandlerV3Healthz' test.out

#- 4 GetAllChannelsHandler
$CLI_EXE \
    --sn matchmaking \
    --op GetAllChannelsHandler \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "jv4Ax7Nz", "description": "Ykoppa0V", "find_match_timeout_seconds": 12, "game_mode": "FJAhHwTb", "joinable": true, "max_delay_ms": 12, "rule_set": {"alliance": {"max_number": 79, "min_number": 76, "player_max_number": 85, "player_min_number": 34}, "alliance_flexing_rule": [{"duration": 2, "max_number": 31, "min_number": 8, "player_max_number": 87, "player_min_number": 26}], "flexing_rule": [{"attribute": "xTlCTFSM", "criteria": "Ibl1a2jX", "duration": 75, "reference": 0.447800154283432}], "match_options": {"options": [{"name": "WmHJBi9S", "type": "oMkSE4eJ"}]}, "matching_rule": [{"attribute": "elwO4KPM", "criteria": "ky2h8R2f", "reference": 0.5412446839893738}], "sub_game_modes": {"oXP8gd7J": {"alliance": {"max_number": 92, "min_number": 0, "player_max_number": 3, "player_min_number": 5}, "alliance_flexing_rule": [{"duration": 65, "max_number": 77, "min_number": 2, "player_max_number": 47, "player_min_number": 90}], "name": "lm1fsu6J"}}}, "session_queue_timeout_seconds": 57, "social_matchmaking": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateChannelHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateChannelHandler' test.out

#- 6 DeleteChannelHandler
$CLI_EXE \
    --sn matchmaking \
    --op DeleteChannelHandler \
    --channel 'pGR9Xcox' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "YTGgewrL", "players": [{"results": [{"attribute": "fwvzJF4T", "value": 0.24164757154358074}], "user_id": "NhKq2xdm"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 QueueSessionHandler
# body param: body
echo '{"channel": "gEBepFHt", "client_version": "f6Ziegqd", "deployment": "EL4fsM6n", "game_mode": "BzRVuC1r", "joinable": false, "match_id": "u7UQ0304", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 77, "party_attributes": {"cK873tRt": {}}, "party_id": "r5cfWO5J", "party_members": [{"extra_attributes": {"J2c6vsOn": {}}, "user_id": "s4jNWGc7"}]}]}], "namespace": "CiUa4wM5", "party_attributes": {"Eu3Vqyms": {}}, "party_id": "FXporMqE", "queued_at": 59, "region": "R8E72XMK", "server_name": "fhl6eq2F", "status": "zU3VL3LN", "updated_at": "1977-11-30T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'QueueSessionHandler' test.out

#- 9 DequeueSessionHandler
# body param: body
echo '{"match_id": "LeZdoCXf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op DequeueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'DequeueSessionHandler' test.out

#- 10 QuerySessionHandler
$CLI_EXE \
    --sn matchmaking \
    --op QuerySessionHandler \
    --matchID 'abFXzvjL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'QuerySessionHandler' test.out

#- 11 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 25, "userID": "ai7fPKvE", "weight": 0.8591577024149795}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdatePlayTimeWeight \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UpdatePlayTimeWeight' test.out

#- 12 GetAllPartyInAllChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInAllChannel \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'GetAllPartyInAllChannel' test.out

#- 13 BulkGetSessions
$CLI_EXE \
    --sn matchmaking \
    --op BulkGetSessions \
    --namespace $AB_NAMESPACE \
    --matchIDs '4a63UVtL' \
    > test.out 2>&1
eval_tap $? 13 'BulkGetSessions' test.out

#- 14 ExportChannels
$CLI_EXE \
    --sn matchmaking \
    --op ExportChannels \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'ExportChannels' test.out

#- 15 ImportChannels
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn matchmaking \
    --op ImportChannels \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --strategy 'bQSWtsyz' \
    > test.out 2>&1
eval_tap $? 15 'ImportChannels' test.out

#- 16 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName '0mGGyHHF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'GetSingleMatchmakingChannel' test.out

#- 17 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "IlIKsXgv", "description": "SrkEgTYV", "findMatchTimeoutSeconds": 21, "joinable": false, "max_delay_ms": 86, "ruleSet": {"alliance": {"maxNumber": 54, "minNumber": 61, "playerMaxNumber": 51, "playerMinNumber": 71}, "alliance_flexing_rule": [{"duration": 70, "max_number": 54, "min_number": 86, "player_max_number": 67, "player_min_number": 34}], "flexingRules": [{"attribute": "fCHqqp2G", "criteria": "wPcmzSuY", "duration": 44, "reference": 0.966459071248867}], "match_options": {"options": [{"name": "YwBEfRXo", "type": "ZLfpVFfD"}]}, "matchingRules": [{"attribute": "wjHHCW2g", "criteria": "5u8z9yrp", "reference": 0.5580847789487178}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 68, "socialMatchmaking": true, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'vHS3d6PK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateMatchmakingChannel' test.out

#- 18 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'PE27mI6P' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetAllPartyInChannel' test.out

#- 19 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'x8jt8Lq4' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllSessionsInChannel' test.out

#- 20 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["x0F7Ncoc"], "party_id": "elJjtlKY", "user_id": "u8iCPznx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName '0s5TzT51' \
    --matchID 'oV4HTmiv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AddUserIntoSessionInChannel' test.out

#- 21 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'mb6tPmCi' \
    --matchID 'rkhYvcOU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'DeleteSessionInChannel' test.out

#- 22 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'ucjPWGwP' \
    --matchID 'svjLK1Cj' \
    --namespace $AB_NAMESPACE \
    --userID 'Pt93utbM' \
    > test.out 2>&1
eval_tap $? 22 'DeleteUserFromSessionInChannel' test.out

#- 23 SearchSessions
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessions \
    --namespace $AB_NAMESPACE \
    --channel 'kpUFHT0f' \
    --deleted 'True' \
    --matchID '9SMNAUQV' \
    --partyID 'oiQtSQC2' \
    --userID 'kNSsmT0d' \
    --limit '0' \
    --offset '55' \
    > test.out 2>&1
eval_tap $? 23 'SearchSessions' test.out

#- 24 GetSessionHistoryDetailed
$CLI_EXE \
    --sn matchmaking \
    --op GetSessionHistoryDetailed \
    --matchID 'G4zA2zp1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetSessionHistoryDetailed' test.out

#- 25 PublicGetMessages
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 25 'PublicGetMessages' test.out

#- 26 PublicGetAllMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetAllMatchmakingChannel \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'PublicGetAllMatchmakingChannel' test.out

#- 27 PublicGetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetSingleMatchmakingChannel \
    --channelName 'Ls0bD6dG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'PublicGetSingleMatchmakingChannel' test.out

#- 28 SearchSessionsV2
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessionsV2 \
    --namespace $AB_NAMESPACE \
    --channel 'gwkYgHzK' \
    --deleted 'True' \
    --matchID 'I2RJrboP' \
    --partyID '7kfpIlet' \
    --userID 'XrCK1UVO' \
    --limit '19' \
    --offset '5' \
    > test.out 2>&1
eval_tap $? 28 'SearchSessionsV2' test.out

#- 29 VersionCheckHandler
$CLI_EXE \
    --sn matchmaking \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 29 'VersionCheckHandler' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE