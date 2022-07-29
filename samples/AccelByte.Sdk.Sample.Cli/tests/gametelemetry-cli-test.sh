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
echo "1..5"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet
$CLI_EXE \
    --sn gametelemetry \
    --op GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet \
    --namespace $AB_NAMESPACE \
    --endTime 'CPZYDdyr' \
    --eventId 'RtEnkBnb' \
    --eventName '9hGB3EQb' \
    --eventPayload 'f0PVPgBn' \
    --limit '60' \
    --offset '62' \
    --startTime 'lVarq5K3' \
    > test.out 2>&1
eval_tap $? 2 'GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet' test.out

#- 3 ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost
# body param: body
echo '[{"EventId": "ruqqXIMi", "EventName": "GW7QhSAC", "EventNamespace": "6MOGWng8", "EventTimestamp": "1973-03-14T00:00:00Z", "Payload": {"9PUutP6a": {}, "uV5BkpjB": {}, "E4TqZsBq": {}}}, {"EventId": "B3GTOj4F", "EventName": "iF0Qo6mB", "EventNamespace": "3B8LAcuP", "EventTimestamp": "1990-04-28T00:00:00Z", "Payload": {"KxjzmiDW": {}, "JfR2ElbJ": {}, "9bhR4DF4": {}}}, {"EventId": "CKrN8IOh", "EventName": "aLynnqsK", "EventNamespace": "VVSJZEsD", "EventTimestamp": "1976-09-27T00:00:00Z", "Payload": {"1vZjB4WD": {}, "Zf4BTCkN": {}, "1yxUnfsb": {}}}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gametelemetry \
    --op ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost \
    --access_token 'CrPYN2VQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost' test.out

#- 4 ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet
$CLI_EXE \
    --sn gametelemetry \
    --op ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet \
    --steamId 'veVhfJa9' \
    --access_token '1B4suNdo' \
    > test.out 2>&1
eval_tap $? 4 'ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet' test.out

#- 5 ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut
$CLI_EXE \
    --sn gametelemetry \
    --op ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut \
    --playtime 'UqMUyeX8' \
    --steamId 'BfL89Uog' \
    --access_token 'KwWSlnEz' \
    > test.out 2>&1
eval_tap $? 5 'ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE