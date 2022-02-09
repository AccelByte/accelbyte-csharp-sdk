#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="dotnet ../../samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/AccelByte.Sdk.Sample.Cli.dll"
CLI_TOKEN_FILE="../../samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=32

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

#- 1 AgentTypeDescriptionHandler
update_status 0 'AgentTypeDescriptionHandler (skipped deprecated)'

#- 2 SpecificAgentTypeDescriptionHandler
update_status 0 'SpecificAgentTypeDescriptionHandler (skipped deprecated)'

#- 3 EventIDDescriptionHandler
update_status 0 'EventIDDescriptionHandler (skipped deprecated)'

#- 4 SpecificEventIDDescriptionHandler
update_status 0 'SpecificEventIDDescriptionHandler (skipped deprecated)'

#- 5 EventLevelDescriptionHandler
update_status 0 'EventLevelDescriptionHandler (skipped deprecated)'

#- 6 SpecificEventLevelDescriptionHandler
update_status 0 'SpecificEventLevelDescriptionHandler (skipped deprecated)'

#- 7 EventTypeDescriptionHandler
update_status 0 'EventTypeDescriptionHandler (skipped deprecated)'

#- 8 SpecificEventTypeDescriptionHandler
update_status 0 'SpecificEventTypeDescriptionHandler (skipped deprecated)'

#- 9 UXNameDescriptionHandler
update_status 0 'UXNameDescriptionHandler (skipped deprecated)'

#- 10 SpecificUXDescriptionHandler
update_status 0 'SpecificUXDescriptionHandler (skipped deprecated)'

#- 11 GetEventByNamespaceHandler
update_status 0 'GetEventByNamespaceHandler (skipped deprecated)'

#- 12 PostEventHandler
update_status 0 'PostEventHandler (skipped deprecated)'

#- 13 GetEventByEventIDHandler
update_status 0 'GetEventByEventIDHandler (skipped deprecated)'

#- 14 GetEventByEventTypeHandler
update_status 0 'GetEventByEventTypeHandler (skipped deprecated)'

#- 15 GetEventByEventTypeAndEventIDHandler
update_status 0 'GetEventByEventTypeAndEventIDHandler (skipped deprecated)'

#- 16 GetEventByUserIDHandler
update_status 0 'GetEventByUserIDHandler (skipped deprecated)'

#- 17 GetUserActivitiesHandler
update_status 0 'GetUserActivitiesHandler (skipped deprecated)'

#- 18 DeleteUserActivitiesHandler
update_status 0 'DeleteUserActivitiesHandler (skipped deprecated)'

#- 19 GetEventByUserIDAndEventIDHandler
update_status 0 'GetEventByUserIDAndEventIDHandler (skipped deprecated)'

#- 20 GetEventByUserIDAndEventTypeHandler
update_status 0 'GetEventByUserIDAndEventTypeHandler (skipped deprecated)'

#- 21 GetEventByUserEventIDAndEventTypeHandler
update_status 0 'GetEventByUserEventIDAndEventTypeHandler (skipped deprecated)'

#- 22 LastUserActivityTimeHandler
update_status 0 'LastUserActivityTimeHandler (skipped deprecated)'

#- 23 GetRegisteredEventsHandler
update_status 0 'GetRegisteredEventsHandler (skipped deprecated)'

#- 24 RegisterEventHandler
update_status 0 'RegisterEventHandler (skipped deprecated)'

#- 25 GetRegisteredEventIDHandler
update_status 0 'GetRegisteredEventIDHandler (skipped deprecated)'

#- 26 UpdateEventRegistryHandler
update_status 0 'UpdateEventRegistryHandler (skipped deprecated)'

#- 27 UnregisterEventIDHandler
update_status 0 'UnregisterEventIDHandler (skipped deprecated)'

#- 28 GetRegisteredEventsByEventTypeHandler
update_status 0 'GetRegisteredEventsByEventTypeHandler (skipped deprecated)'

#- 29 QueryEventStreamHandler
# body param: body
echo '{"clientId": "b0Cjv4Ax", "eventName": "7NzYkopp", "payloadQuery": {"a0VgFJAh": {}}, "sessionId": "HwTb5q01", "traceId": "0gN2MQrb", "userId": "peRnxTlC", "version": 90}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn eventlog \
    --op QueryEventStreamHandler \
    --namespace $TEST_NAMESPACE \
    --endDate 'FSMIbl1a' \
    --offset '0.8447271223694742' \
    --pageSize '0.7713504924814581' \
    --startDate 'CtWmHJBi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'QueryEventStreamHandler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 GetEventSpecificUserV2Handler
$CLI_EXE \
    --sn eventlog \
    --op GetEventSpecificUserV2Handler \
    --namespace $TEST_NAMESPACE \
    --userId '9SoMkSE4' \
    --endDate 'eJelwO4K' \
    --eventName 'PMky2h8R' \
    --offset '0.8507215387484592' \
    --pageSize '0.5412446839893738' \
    --startDate 'oXP8gd7J' \
    >$TEMP_FILE 2>&1
update_status $? 'GetEventSpecificUserV2Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 GetPublicEditHistory
$CLI_EXE \
    --sn eventlog \
    --op GetPublicEditHistory \
    --namespace $TEST_NAMESPACE \
    --userId 'UabYc3GM' \
    --endDate 'bxTlm1fs' \
    --offset '0.32294313545773834' \
    --pageSize '0.5616305535504991' \
    --startDate 'C4s5ppGR' \
    --type '9XcoxYTG' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublicEditHistory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 GetUserEventsV2Public
$CLI_EXE \
    --sn eventlog \
    --op GetUserEventsV2Public \
    --namespace $TEST_NAMESPACE \
    --userId 'gewrLfwv' \
    --endDate 'zJF4TpbN' \
    --eventName 'hKq2xdmg' \
    --offset '0.47139104773825513' \
    --pageSize '0.06357235639685577' \
    --startDate 'FHtf6Zie' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEventsV2Public'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT