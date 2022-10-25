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
    --deployment 'f1FSdItx' \
    --endDate 'f6HgLmoN' \
    --gameMode 'CjnAqc2t' \
    --limit '9' \
    --next 'NJlv8avu' \
    --partyId '1eVgRXSp' \
    --podName 'dyVp9yxC' \
    --previous 'IirjcUxb' \
    --provider 'HlUGVMol' \
    --region 'WtylS524' \
    --sessionId 'wKPQ04AF' \
    --startDate 'b3VKnvsk' \
    --status 'PoCu2TgX' \
    --userId 'hJxvDds8' \
    > test.out 2>&1
eval_tap $? 2 'ListTerminatedServers' test.out

#- 3 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'j1q1NFsa' \
    > test.out 2>&1
eval_tap $? 3 'DownloadServerLogs' test.out

#- 4 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'Rzux7rx2' \
    > test.out 2>&1
eval_tap $? 4 'CheckServerLogs' test.out

#- 5 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "MgWBGhrB", "namespace": "95bPvbyn", "pod_name": "YDbaHM1R"}, {"alloc_id": "U2RzO5dT", "namespace": "XSCLPmKa", "pod_name": "mskipOzI"}, {"alloc_id": "nwYnlyZS", "namespace": "XExzjY2L", "pod_name": "tAUV1mEv"}]}' > $TEMP_JSON_INPUT
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
    --deployment 'B6V9mYwg' \
    --endDate 'hJxVIxAs' \
    --gameMode 'XeqzhuRv' \
    --limit '11' \
    --namespace_ 'EEy43bWn' \
    --next 'lt5l4O06' \
    --partyId '4T5Xn3tH' \
    --podName 'TBmbo7FT' \
    --previous 'QrUj9Qkb' \
    --provider 'sfsWEkeQ' \
    --region 'GNt42dWr' \
    --sessionId 'eSsfnoGK' \
    --startDate '9RMCgkdO' \
    --status 'bZ9CBBIw' \
    --userId 'f9YJHDiy' \
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