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
echo "1..7"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListTerminatedServers \
    --namespace $AB_NAMESPACE \
    --deployment 'b0Cjv4Ax' \
    --endDate '7NzYkopp' \
    --gameMode 'a0VgFJAh' \
    --limit '66' \
    --next 'wTb5q010' \
    --partyId 'gN2MQrbp' \
    --podName 'eRnxTlCT' \
    --previous 'FSMIbl1a' \
    --provider '2jXLCtWm' \
    --region 'HJBi9SoM' \
    --sessionId 'kSE4eJel' \
    --startDate 'wO4KPMky' \
    --status '2h8R2fIX' \
    --userId 'oXP8gd7J' \
    > test.out 2>&1
eval_tap $? 2 'ListTerminatedServers' test.out

#- 3 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'UabYc3GM' \
    > test.out 2>&1
eval_tap $? 3 'DownloadServerLogs' test.out

#- 4 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'bxTlm1fs' \
    > test.out 2>&1
eval_tap $? 4 'CheckServerLogs' test.out

#- 5 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "u6J3C4s5", "namespace": "ppGR9Xco", "pod_name": "xYTGgewr"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dslogmanager \
    --op BatchDownloadServerLogs \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'BatchDownloadServerLogs' test.out

#- 6 ListAllTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListAllTerminatedServers \
    --deployment 'LfwvzJF4' \
    --endDate 'TpbNhKq2' \
    --gameMode 'xdmgEBep' \
    --limit '62' \
    --namespace_ 'Htf6Zieg' \
    --next 'qdEL4fsM' \
    --partyId '6nBzRVuC' \
    --podName '1r7UH1Li' \
    --previous 'u7UQ0304' \
    --provider 'McK873tR' \
    --region 'tr5cfWO5' \
    --sessionId 'JJ2c6vsO' \
    --startDate 'ns4jNWGc' \
    --status '7CiUa4wM' \
    --userId '5Eu3Vqym' \
    > test.out 2>&1
eval_tap $? 6 'ListAllTerminatedServers' test.out

#- 7 PublicGetMessages
$CLI_EXE \
    --sn dslogmanager \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 7 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE