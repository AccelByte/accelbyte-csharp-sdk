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

OPERATIONS_COUNT=30

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

#- 1 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $TEST_NAMESPACE \
    --query 'b0Cjv4Ax' \
    --limit '79' \
    --offset '51' \
    >$TEMP_FILE 2>&1
update_status $? 'ListGameRecordsHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'Ykoppa0V' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'gFJAhHwT' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPutGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'b5q010gN' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPostGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key '2MQrbpeR' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 ListPlayerRecordHandlerV1
update_status 0 'ListPlayerRecordHandlerV1 (skipped deprecated)'

#- 7 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $TEST_NAMESPACE \
    --userId 'nxTlCTFS' \
    --limit '76' \
    --offset '69' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRetrievePlayerRecords'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key 'bl1a2jXL' \
    --namespace $TEST_NAMESPACE \
    --userId 'CtWmHJBi' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetPlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key '9SoMkSE4' \
    --namespace $TEST_NAMESPACE \
    --userId 'eJelwO4K' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPutPlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'PMky2h8R' \
    --namespace $TEST_NAMESPACE \
    --userId '2fIXoXP8' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPostPlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key 'gd7JUabY' \
    --namespace $TEST_NAMESPACE \
    --userId 'c3GMbxTl' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeletePlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'm1fsu6J3' \
    --namespace $TEST_NAMESPACE \
    --userId 'C4s5ppGR' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key '9XcoxYTG' \
    --namespace $TEST_NAMESPACE \
    --userId 'gewrLfwv' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPutPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'zJF4TpbN' \
    --namespace $TEST_NAMESPACE \
    --userId 'hKq2xdmg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPostPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'EBepFHtf' \
    --namespace $TEST_NAMESPACE \
    --userId '6ZiegqdE' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeletePlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "L4fsM6nB", "value": {"zRVuC1r7": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'UH1Liu7U' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PutGameRecordConcurrentHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'Q0304McK' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key '873tRtr5' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PutGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'cfWO5JJ2' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PostGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'c6vsOns4' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGameRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["jNWGc7Ci"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'Ua4wM5Eu' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkGetPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key '3VqymsFX' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeletePlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "porMqEDR", "value": {"8E72XMKf": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'hl6eq2Fz' \
    --namespace $TEST_NAMESPACE \
    --userId 'U3VL3LNm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PutPlayerPublicRecordConcurrentHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'PLeZdoCX' \
    --namespace $TEST_NAMESPACE \
    --userId 'fabFXzvj' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'Lmai7fPK' \
    --namespace $TEST_NAMESPACE \
    --userId 'vE2Z4a63' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PutPlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'UVtLbQSW' \
    --namespace $TEST_NAMESPACE \
    --userId 'tsyz0mGG' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PostPlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'yHHFIlIK' \
    --namespace $TEST_NAMESPACE \
    --userId 'sXgvSrkE' \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePlayerRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'gTYVk5iR' \
    --namespace $TEST_NAMESPACE \
    --userId 'BE6zJJ1B' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'RHrfCHqq' \
    --namespace $TEST_NAMESPACE \
    --userId 'p2GwPcmz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PutPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'SuY8w9VY' \
    --namespace $TEST_NAMESPACE \
    --userId 'wBEfRXoZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PostPlayerPublicRecordHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT