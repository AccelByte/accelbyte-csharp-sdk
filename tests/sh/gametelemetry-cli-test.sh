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
echo "1..6"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminGetEventsGameTelemetryV1AdminEventsGet
$CLI_EXE \
    --sn gametelemetry \
    --op AdminGetEventsGameTelemetryV1AdminEventsGet \
    --namespace_ 'b0Cjv4Ax' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetEventsGameTelemetryV1AdminEventsGet' test.out

#- 3 AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet
$CLI_EXE \
    --sn gametelemetry \
    --op AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet \
    > test.out 2>&1
eval_tap $? 3 'AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet' test.out

#- 4 ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost
# body param: body
echo '[{"EventId": "7NzYkopp", "EventName": "a0VgFJAh", "EventNamespace": "HwTb5q01", "EventTimestamp": "1997-02-12T00:00:00Z", "Payload": {"N2MQrbpe": {}}}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gametelemetry \
    --op ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost' test.out

#- 5 ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet
$CLI_EXE \
    --sn gametelemetry \
    --op ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet \
    --steamId 'RnxTlCTF' \
    > test.out 2>&1
eval_tap $? 5 'ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet' test.out

#- 6 ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut
$CLI_EXE \
    --sn gametelemetry \
    --op ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut \
    --playtime 'SMIbl1a2' \
    --steamId 'jXLCtWmH' \
    > test.out 2>&1
eval_tap $? 6 'ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE