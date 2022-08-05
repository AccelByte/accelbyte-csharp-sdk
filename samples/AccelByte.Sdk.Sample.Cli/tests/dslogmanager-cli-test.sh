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
    --deployment 'tKUtHB2V' \
    --endDate 'lxL0wfiG' \
    --gameMode 'eMAhSMx2' \
    --limit '6' \
    --next 'I0j8vat5' \
    --partyId 'kUX5YZsG' \
    --podName 'NaMVFNOn' \
    --previous 'SKmTAfM9' \
    --provider 'IdXGUlgV' \
    --region 'azix9ZAh' \
    --sessionId 'tJXLDtkS' \
    --startDate 'h9TLgyPt' \
    --status 'fwO1OIOs' \
    --userId '8NcoswmD' \
    > test.out 2>&1
eval_tap $? 2 'ListTerminatedServers' test.out

#- 3 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'yXcQ9JWO' \
    > test.out 2>&1
eval_tap $? 3 'DownloadServerLogs' test.out

#- 4 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'nt1E2RSx' \
    > test.out 2>&1
eval_tap $? 4 'CheckServerLogs' test.out

#- 5 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "pHxZYwz1", "namespace": "M0YTqgEK", "pod_name": "N30sN2IB"}, {"alloc_id": "NLSpruzn", "namespace": "5cCSGM41", "pod_name": "43230tSC"}, {"alloc_id": "XwFHicUV", "namespace": "D0JHiMk0", "pod_name": "8si7c8Tm"}]}' > $TEMP_JSON_INPUT
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
    --deployment 'FeyJJ8Ga' \
    --endDate '44yrr17t' \
    --gameMode 'Sl1cxbN3' \
    --limit '69' \
    --namespace_ 'bUj77sP4' \
    --next 'rRiwhFd1' \
    --partyId 'nrMBJezE' \
    --podName 'PR6OVYlW' \
    --previous 'RoUQhWS3' \
    --provider 'qAjBcMII' \
    --region '2G9eMdqn' \
    --sessionId 'cds8cr5e' \
    --startDate 'glNCt302' \
    --status 'rzDWhIHy' \
    --userId 'RdPeJ3Sn' \
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