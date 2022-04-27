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
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"

echo "TAP version 13"
echo "1..33"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AgentTypeDescriptionHandler
eval_tap 0 2 'AgentTypeDescriptionHandler # SKIP deprecated' test.out

#- 3 SpecificAgentTypeDescriptionHandler
eval_tap 0 3 'SpecificAgentTypeDescriptionHandler # SKIP deprecated' test.out

#- 4 EventIDDescriptionHandler
eval_tap 0 4 'EventIDDescriptionHandler # SKIP deprecated' test.out

#- 5 SpecificEventIDDescriptionHandler
eval_tap 0 5 'SpecificEventIDDescriptionHandler # SKIP deprecated' test.out

#- 6 EventLevelDescriptionHandler
eval_tap 0 6 'EventLevelDescriptionHandler # SKIP deprecated' test.out

#- 7 SpecificEventLevelDescriptionHandler
eval_tap 0 7 'SpecificEventLevelDescriptionHandler # SKIP deprecated' test.out

#- 8 EventTypeDescriptionHandler
eval_tap 0 8 'EventTypeDescriptionHandler # SKIP deprecated' test.out

#- 9 SpecificEventTypeDescriptionHandler
eval_tap 0 9 'SpecificEventTypeDescriptionHandler # SKIP deprecated' test.out

#- 10 UXNameDescriptionHandler
eval_tap 0 10 'UXNameDescriptionHandler # SKIP deprecated' test.out

#- 11 SpecificUXDescriptionHandler
eval_tap 0 11 'SpecificUXDescriptionHandler # SKIP deprecated' test.out

#- 12 GetEventByNamespaceHandler
eval_tap 0 12 'GetEventByNamespaceHandler # SKIP deprecated' test.out

#- 13 PostEventHandler
eval_tap 0 13 'PostEventHandler # SKIP deprecated' test.out

#- 14 GetEventByEventIDHandler
eval_tap 0 14 'GetEventByEventIDHandler # SKIP deprecated' test.out

#- 15 GetEventByEventTypeHandler
eval_tap 0 15 'GetEventByEventTypeHandler # SKIP deprecated' test.out

#- 16 GetEventByEventTypeAndEventIDHandler
eval_tap 0 16 'GetEventByEventTypeAndEventIDHandler # SKIP deprecated' test.out

#- 17 GetEventByUserIDHandler
eval_tap 0 17 'GetEventByUserIDHandler # SKIP deprecated' test.out

#- 18 GetUserActivitiesHandler
eval_tap 0 18 'GetUserActivitiesHandler # SKIP deprecated' test.out

#- 19 DeleteUserActivitiesHandler
eval_tap 0 19 'DeleteUserActivitiesHandler # SKIP deprecated' test.out

#- 20 GetEventByUserIDAndEventIDHandler
eval_tap 0 20 'GetEventByUserIDAndEventIDHandler # SKIP deprecated' test.out

#- 21 GetEventByUserIDAndEventTypeHandler
eval_tap 0 21 'GetEventByUserIDAndEventTypeHandler # SKIP deprecated' test.out

#- 22 GetEventByUserEventIDAndEventTypeHandler
eval_tap 0 22 'GetEventByUserEventIDAndEventTypeHandler # SKIP deprecated' test.out

#- 23 LastUserActivityTimeHandler
eval_tap 0 23 'LastUserActivityTimeHandler # SKIP deprecated' test.out

#- 24 GetRegisteredEventsHandler
eval_tap 0 24 'GetRegisteredEventsHandler # SKIP deprecated' test.out

#- 25 RegisterEventHandler
eval_tap 0 25 'RegisterEventHandler # SKIP deprecated' test.out

#- 26 GetRegisteredEventIDHandler
eval_tap 0 26 'GetRegisteredEventIDHandler # SKIP deprecated' test.out

#- 27 UpdateEventRegistryHandler
eval_tap 0 27 'UpdateEventRegistryHandler # SKIP deprecated' test.out

#- 28 UnregisterEventIDHandler
eval_tap 0 28 'UnregisterEventIDHandler # SKIP deprecated' test.out

#- 29 GetRegisteredEventsByEventTypeHandler
eval_tap 0 29 'GetRegisteredEventsByEventTypeHandler # SKIP deprecated' test.out

#- 30 QueryEventStreamHandler
# body param: body
echo '{"clientId": "b0Cjv4Ax", "eventName": "7NzYkopp", "payloadQuery": {"a0VgFJAh": {}}, "sessionId": "HwTb5q01", "traceId": "0gN2MQrb", "userId": "peRnxTlC", "version": 90}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn eventlog \
    --op QueryEventStreamHandler \
    --namespace $AB_NAMESPACE \
    --endDate 'FSMIbl1a' \
    --offset '18' \
    --pageSize '98' \
    --startDate 'LCtWmHJB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'QueryEventStreamHandler' test.out

#- 31 GetEventSpecificUserV2Handler
$CLI_EXE \
    --sn eventlog \
    --op GetEventSpecificUserV2Handler \
    --namespace $AB_NAMESPACE \
    --userId 'i9SoMkSE' \
    --endDate '4eJelwO4' \
    --eventName 'KPMky2h8' \
    --offset '86' \
    --pageSize '11' \
    --startDate 'IXoXP8gd' \
    > test.out 2>&1
eval_tap $? 31 'GetEventSpecificUserV2Handler' test.out

#- 32 GetPublicEditHistory
$CLI_EXE \
    --sn eventlog \
    --op GetPublicEditHistory \
    --namespace $AB_NAMESPACE \
    --userId '7JUabYc3' \
    --endDate 'GMbxTlm1' \
    --offset '10' \
    --pageSize '37' \
    --startDate 'u6J3C4s5' \
    --type 'ppGR9Xco' \
    > test.out 2>&1
eval_tap $? 32 'GetPublicEditHistory' test.out

#- 33 GetUserEventsV2Public
$CLI_EXE \
    --sn eventlog \
    --op GetUserEventsV2Public \
    --namespace $AB_NAMESPACE \
    --userId 'xYTGgewr' \
    --endDate 'LfwvzJF4' \
    --eventName 'TpbNhKq2' \
    --offset '47' \
    --pageSize '6' \
    --startDate 'mgEBepFH' \
    > test.out 2>&1
eval_tap $? 33 'GetUserEventsV2Public' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE