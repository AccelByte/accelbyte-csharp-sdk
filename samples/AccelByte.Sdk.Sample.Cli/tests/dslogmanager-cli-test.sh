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
echo "1..8"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op GetServerLogs \
    --namespace $AB_NAMESPACE \
    --podName '0hyFYlMm' \
    --logType 'I16Nk7kC' \
    --offset '64' \
    --origin 'UwVv9Gt3' \
    > test.out 2>&1
eval_tap $? 2 'GetServerLogs' test.out

#- 3 ListTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListTerminatedServers \
    --namespace $AB_NAMESPACE \
    --deployment 'wQ8IXSPK' \
    --endDate 'iI9HhLMd' \
    --gameMode 'bIc0rooi' \
    --limit '40' \
    --next 'WH2cuIkL' \
    --partyId '61bTCR3d' \
    --podName 'v4eUEumT' \
    --previous 'KCHdEeSt' \
    --provider 'zeUg2hsN' \
    --region 'nOiOiwxf' \
    --sessionId '93zcXUJU' \
    --startDate '17he947u' \
    --status 'Sa6WibfX' \
    --userId '5hK7ryzB' \
    > test.out 2>&1
eval_tap $? 3 'ListTerminatedServers' test.out

#- 4 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'B234e45H' \
    > test.out 2>&1
eval_tap $? 4 'DownloadServerLogs' test.out

#- 5 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'ndexeWmU' \
    > test.out 2>&1
eval_tap $? 5 'CheckServerLogs' test.out

#- 6 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "NN4bJKYN", "namespace": "bwf6fWfz", "pod_name": "XQPcVyku"}, {"alloc_id": "FOY5vcq8", "namespace": "xl1Ma4j4", "pod_name": "eNfOsf2v"}, {"alloc_id": "6yYfMX8F", "namespace": "hIcJbpzI", "pod_name": "deuaGqeW"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dslogmanager \
    --op BatchDownloadServerLogs \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'BatchDownloadServerLogs' test.out

#- 7 ListAllTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListAllTerminatedServers \
    --deployment 'TJjBXU6J' \
    --endDate 'cDomkHTS' \
    --gameMode 'xmgV9A6t' \
    --limit '89' \
    --namespace_ 'WwSC9Ie1' \
    --next 'VA0ZjMXe' \
    --partyId 'M4ds2Zbs' \
    --podName 'FTCTfWNb' \
    --previous 'O986B4bs' \
    --provider 'XhoUqSKv' \
    --region 'EWHjO3fG' \
    --sessionId 'EPajuViq' \
    --startDate 'sVIIzzrE' \
    --status 'Nehvzx1n' \
    --userId 'KV9JPaYm' \
    > test.out 2>&1
eval_tap $? 7 'ListAllTerminatedServers' test.out

#- 8 PublicGetMessages
$CLI_EXE \
    --sn dslogmanager \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 8 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE