#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=34

FINISHED_COUNT=0
SUCCESS_COUNT=0
FAILED_COUNT=0

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_APP_NAME="UnitTest"
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

#- 1 GetLeaderboardConfigurationsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV1 \
    --namespace $TEST_NAMESPACE \
    --isArchived 'False' \
    --isDeleted 'True' \
    --limit '18' \
    --offset '42' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLeaderboardConfigurationsAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "4Ax7NzYk"}, "descending": false, "iconURL": "ppa0VgFJ", "leaderboardCode": "AhHwTb5q", "monthly": {"resetDate": 12, "resetTime": "N2MQrbpe"}, "name": "RnxTlCTF", "seasonPeriod": 89, "startTime": "MIbl1a2j", "statCode": "XLCtWmHJ", "weekly": {"resetDay": 54, "resetTime": "i9SoMkSE"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateLeaderboardConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 AdminGetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op AdminGetArchivedLeaderboardRankingDataV1Handler \
    --namespace $TEST_NAMESPACE \
    --slug '4eJelwO4' \
    --leaderboardCodes 'KPMky2h8' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetArchivedLeaderboardRankingDataV1Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["R2fIXoXP"], "limit": 12, "slug": "d7JUabYc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateArchivedLeaderboardRankingDataV1Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["3GMbxTlm"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op DeleteBulkLeaderboardConfigurationAdminV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteBulkLeaderboardConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 GetLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationAdminV1 \
    --leaderboardCode '1fsu6J3C' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetLeaderboardConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "4s5ppGR9"}, "descending": false, "iconURL": "oxYTGgew", "monthly": {"resetDate": 34, "resetTime": "LfwvzJF4"}, "name": "TpbNhKq2", "seasonPeriod": 47, "startTime": "dmgEBepF", "statCode": "Htf6Zieg", "weekly": {"resetDay": 32, "resetTime": "dEL4fsM6"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'nBzRVuC1' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateLeaderboardConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'r7UH1Liu' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteLeaderboardConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode '7UQ0304M' \
    --namespace $TEST_NAMESPACE \
    --limit '4' \
    --offset '73' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllTimeLeaderboardRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode '873tRtr5' \
    --namespace $TEST_NAMESPACE \
    --limit '4' \
    --offset '11' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentMonthLeaderboardRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'WO5JJ2c6' \
    --namespace $TEST_NAMESPACE \
    --limit '42' \
    --offset '36' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentSeasonLeaderboardRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'Ons4jNWG' \
    --namespace $TEST_NAMESPACE \
    --limit '5' \
    --offset '57' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTodayLeaderboardRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode 'iUa4wM5E' \
    --namespace $TEST_NAMESPACE \
    --userId 'u3VqymsF' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.7745104729900811, "latestValue": 0.23590661756813225}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'rMqEDR8E' \
    --namespace $TEST_NAMESPACE \
    --userId '72XMKfhl' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserPointAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode '6eq2FzU3' \
    --namespace $TEST_NAMESPACE \
    --userId 'VL3LNmPL' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 'eZdoCXfa' \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '62' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentWeekLeaderboardRankingAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'XzvjLmai' \
    --leaderboardCode '["7fPKvE2Z"]' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserRankingsAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $TEST_NAMESPACE \
    --userId '4a63UVtL' \
    --limit '2' \
    --offset '85' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserLeaderboardRankingsAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $TEST_NAMESPACE \
    --isArchived 'True' \
    --isDeleted 'True' \
    --limit '48' \
    --offset '51' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLeaderboardConfigurationsPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "0mGGyHHF"}, "descending": false, "iconURL": "IKsXgvSr", "leaderboardCode": "kEgTYVk5", "monthly": {"resetDate": 17, "resetTime": "RBE6zJJ1"}, "name": "BRHrfCHq", "seasonPeriod": 33, "startTime": "p2GwPcmz", "statCode": "SuY8w9VY", "weekly": {"resetDay": 44, "resetTime": "BEfRXoZL"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationPublicV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateLeaderboardConfigurationPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 GetAllTimeLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV1 \
    --leaderboardCode 'fpVFfDwj' \
    --namespace $TEST_NAMESPACE \
    --limit '66' \
    --offset '66' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllTimeLeaderboardRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode 'CW2g5u8z' \
    --namespace $TEST_NAMESPACE \
    --slug '9yrpJdIx' \
    --leaderboardCodes '5vvHS3d6' \
    >$TEMP_FILE 2>&1
update_status $? 'GetArchivedLeaderboardRankingDataV1Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'PKPE27mI' \
    --namespace $TEST_NAMESPACE \
    --limit '82' \
    --offset '46' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentMonthLeaderboardRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode '8jt8Lq4x' \
    --namespace $TEST_NAMESPACE \
    --limit '63' \
    --offset '79' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentSeasonLeaderboardRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'cocelJjt' \
    --namespace $TEST_NAMESPACE \
    --limit '23' \
    --offset '73' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTodayLeaderboardRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'Yu8iCPzn' \
    --namespace $TEST_NAMESPACE \
    --userId 'x0s5TzT5' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode '1oV4HTmi' \
    --namespace $TEST_NAMESPACE \
    --userId 'vmb6tPmC' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'irkhYvcO' \
    --namespace $TEST_NAMESPACE \
    --limit '92' \
    --offset '40' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentWeekLeaderboardRankingPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'cjPWGwPs' \
    --namespace $TEST_NAMESPACE \
    --limit '43' \
    --offset '19' \
    >$TEMP_FILE 2>&1
update_status $? 'GetHiddenUsersV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode 'LK1CjPt9' \
    --namespace $TEST_NAMESPACE \
    --userId '3utbMkpU' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserVisibilityStatusV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode 'HT0fL9q9' \
    --namespace $TEST_NAMESPACE \
    --userId 'SMNAUQVo' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SetUserLeaderboardVisibilityStatusV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 SetUserVisibilityStatusV2
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityStatusV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'QtSQC2kN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SetUserVisibilityStatusV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $TEST_NAMESPACE \
    --limit '88' \
    --offset '37' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLeaderboardConfigurationsPublicV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'mT0d2aBG' \
    --namespace $TEST_NAMESPACE \
    --limit '50' \
    --offset '53' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllTimeLeaderboardRankingPublicV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT