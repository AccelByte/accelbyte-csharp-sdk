#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="/tmp/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=20

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

#- 1 AdminGetListDeletionDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListDeletionDataRequest \
    --namespace $TEST_NAMESPACE \
    --after 'b0Cjv4Ax' \
    --before '7NzYkopp' \
    --limit '0' \
    --offset '95' \
    --requestDate 'gFJAhHwT' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListDeletionDataRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 GetAdminEmailConfiguration
$CLI_EXE \
    --sn gdpr \
    --op GetAdminEmailConfiguration \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminEmailConfiguration'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 UpdateAdminEmailConfiguration
# body param: body
echo '["b5q010gN"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op UpdateAdminEmailConfiguration \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateAdminEmailConfiguration'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 SaveAdminEmailConfiguration
# body param: body
echo '["2MQrbpeR"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op SaveAdminEmailConfiguration \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SaveAdminEmailConfiguration'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 DeleteAdminEmailConfiguration
$CLI_EXE \
    --sn gdpr \
    --op DeleteAdminEmailConfiguration \
    --namespace $TEST_NAMESPACE \
    --emails '["nxTlCTFS"]' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAdminEmailConfiguration'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 AdminGetListPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListPersonalDataRequest \
    --namespace $TEST_NAMESPACE \
    --limit '76' \
    --offset '69' \
    --requestDate 'bl1a2jXL' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListPersonalDataRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 AdminGetUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserAccountDeletionRequest \
    --namespace $TEST_NAMESPACE \
    --userId 'CtWmHJBi' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserAccountDeletionRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 AdminSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminSubmitUserAccountDeletionRequest \
    --namespace $TEST_NAMESPACE \
    --userId '9SoMkSE4' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSubmitUserAccountDeletionRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 AdminCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserAccountDeletionRequest \
    --namespace $TEST_NAMESPACE \
    --userId 'eJelwO4K' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCancelUserAccountDeletionRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 AdminGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserPersonalDataRequests \
    --namespace $TEST_NAMESPACE \
    --userId 'PMky2h8R' \
    --limit '11' \
    --offset '69' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserPersonalDataRequests'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 AdminRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op AdminRequestDataRetrieval \
    --namespace $TEST_NAMESPACE \
    --userId 'XoXP8gd7' \
    --password 'JUabYc3G' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRequestDataRetrieval'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 AdminCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserPersonalDataRequest \
    --namespace $TEST_NAMESPACE \
    --requestDate 'MbxTlm1f' \
    --userId 'su6J3C4s' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCancelUserPersonalDataRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 AdminGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op AdminGeneratePersonalDataURL \
    --namespace $TEST_NAMESPACE \
    --requestDate '5ppGR9Xc' \
    --userId 'oxYTGgew' \
    --password 'rLfwvzJF' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGeneratePersonalDataURL'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 PublicSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitUserAccountDeletionRequest \
    --namespace $TEST_NAMESPACE \
    --userId '4TpbNhKq' \
    --password '2xdmgEBe' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSubmitUserAccountDeletionRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 PublicCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserAccountDeletionRequest \
    --namespace $TEST_NAMESPACE \
    --userId 'pFHtf6Zi' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCancelUserAccountDeletionRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 PublicGetUserAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserAccountDeletionStatus \
    --namespace $TEST_NAMESPACE \
    --userId 'egqdEL4f' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserAccountDeletionStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 PublicGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserPersonalDataRequests \
    --namespace $TEST_NAMESPACE \
    --userId 'sM6nBzRV' \
    --limit '40' \
    --offset '56' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserPersonalDataRequests'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 PublicRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op PublicRequestDataRetrieval \
    --namespace $TEST_NAMESPACE \
    --userId '1r7UH1Li' \
    --password 'u7UQ0304' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicRequestDataRetrieval'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 PublicCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserPersonalDataRequest \
    --namespace $TEST_NAMESPACE \
    --requestDate 'McK873tR' \
    --userId 'tr5cfWO5' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCancelUserPersonalDataRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 PublicGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op PublicGeneratePersonalDataURL \
    --namespace $TEST_NAMESPACE \
    --requestDate 'JJ2c6vsO' \
    --userId 'ns4jNWGc' \
    --password '7CiUa4wM' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGeneratePersonalDataURL'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT