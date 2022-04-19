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
echo "1..16"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetTotalActiveSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetTotalActiveSession \
    --namespace $AB_NAMESPACE \
    --sessionType 'b0Cjv4Ax' \
    > test.out 2>&1
eval_tap $? 2 'GetTotalActiveSession' test.out

#- 3 GetActiveCustomGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveCustomGameSessions \
    --namespace $AB_NAMESPACE \
    --serverRegion '7NzYkopp' \
    --sessionId 'a0VgFJAh' \
    > test.out 2>&1
eval_tap $? 3 'GetActiveCustomGameSessions' test.out

#- 4 GetActiveMatchmakingGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveMatchmakingGameSessions \
    --namespace $AB_NAMESPACE \
    --matchId 'HwTb5q01' \
    --serverRegion '0gN2MQrb' \
    --sessionId 'peRnxTlC' \
    > test.out 2>&1
eval_tap $? 4 'GetActiveMatchmakingGameSessions' test.out

#- 5 AdminGetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminGetSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'TFSMIbl1' \
    > test.out 2>&1
eval_tap $? 5 'AdminGetSession' test.out

#- 6 QuerySession
$CLI_EXE \
    --sn sessionbrowser \
    --op QuerySession \
    --namespace $AB_NAMESPACE \
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
    > test.out 2>&1
eval_tap $? 6 'QuerySession' test.out

#- 7 CreateSession
# body param: body
echo '{"game_session_setting": {"allow_join_in_progress": true, "current_internal_player": 36, "current_player": 30, "map_name": "pGR9Xcox", "max_internal_player": 90, "max_player": 65, "mode": "gewrLfwv", "num_bot": 51, "password": "JF4TpbNh", "settings": {"Kq2xdmgE": {}}}, "game_version": "BepFHtf6", "namespace": "ZiegqdEL", "session_type": "4fsM6nBz", "username": "RVuC1r7U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'CreateSession' test.out

#- 8 GetSessionByUserIDs
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSessionByUserIDs \
    --namespace $AB_NAMESPACE \
    --userIds 'H1Liu7UQ' \
    > test.out 2>&1
eval_tap $? 8 'GetSessionByUserIDs' test.out

#- 9 GetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID '0304McK8' \
    > test.out 2>&1
eval_tap $? 9 'GetSession' test.out

#- 10 UpdateSession
# body param: body
echo '{"game_current_player": 39, "game_max_player": 87}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op UpdateSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'tr5cfWO5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'UpdateSession' test.out

#- 11 DeleteSession
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'JJ2c6vsO' \
    > test.out 2>&1
eval_tap $? 11 'DeleteSession' test.out

#- 12 JoinSession
# body param: body
echo '{"password": "ns4jNWGc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op JoinSession \
    --namespace $AB_NAMESPACE \
    --sessionID '7CiUa4wM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'JoinSession' test.out

#- 13 DeleteSessionLocalDS
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSessionLocalDS \
    --namespace $AB_NAMESPACE \
    --sessionID '5Eu3Vqym' \
    > test.out 2>&1
eval_tap $? 13 'DeleteSessionLocalDS' test.out

#- 14 AddPlayerToSession
# body param: body
echo '{"as_spectator": true, "user_id": "FXporMqE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op AddPlayerToSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'DR8E72XM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AddPlayerToSession' test.out

#- 15 RemovePlayerFromSession
$CLI_EXE \
    --sn sessionbrowser \
    --op RemovePlayerFromSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'Kfhl6eq2' \
    --userID 'FzU3VL3L' \
    > test.out 2>&1
eval_tap $? 15 'RemovePlayerFromSession' test.out

#- 16 GetRecentPlayer
$CLI_EXE \
    --sn sessionbrowser \
    --op GetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --userID 'NmPLeZdo' \
    > test.out 2>&1
eval_tap $? 16 'GetRecentPlayer' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE