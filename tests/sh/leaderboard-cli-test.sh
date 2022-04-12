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
echo "1..35"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetLeaderboardConfigurationsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'False' \
    --isDeleted 'True' \
    --limit '18' \
    --offset '42' \
    > test.out 2>&1
eval_tap $? 2 'GetLeaderboardConfigurationsAdminV1' test.out

#- 3 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "4Ax7NzYk"}, "descending": false, "iconURL": "ppa0VgFJ", "leaderboardCode": "AhHwTb5q", "monthly": {"resetDate": 12, "resetTime": "N2MQrbpe"}, "name": "RnxTlCTF", "seasonPeriod": 89, "startTime": "MIbl1a2j", "statCode": "XLCtWmHJ", "weekly": {"resetDay": 54, "resetTime": "i9SoMkSE"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateLeaderboardConfigurationAdminV1' test.out

#- 4 AdminGetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op AdminGetArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --slug '4eJelwO4' \
    --leaderboardCodes 'KPMky2h8' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetArchivedLeaderboardRankingDataV1Handler' test.out

#- 5 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["R2fIXoXP"], "limit": 12, "slug": "d7JUabYc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateArchivedLeaderboardRankingDataV1Handler' test.out

#- 6 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["3GMbxTlm"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op DeleteBulkLeaderboardConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'DeleteBulkLeaderboardConfigurationAdminV1' test.out

#- 7 GetLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationAdminV1 \
    --leaderboardCode '1fsu6J3C' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetLeaderboardConfigurationAdminV1' test.out

#- 8 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "4s5ppGR9"}, "descending": false, "iconURL": "oxYTGgew", "monthly": {"resetDate": 34, "resetTime": "LfwvzJF4"}, "name": "TpbNhKq2", "seasonPeriod": 47, "startTime": "dmgEBepF", "statCode": "Htf6Zieg", "weekly": {"resetDay": 32, "resetTime": "dEL4fsM6"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'nBzRVuC1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateLeaderboardConfigurationAdminV1' test.out

#- 9 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'r7UH1Liu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteLeaderboardConfigurationAdminV1' test.out

#- 10 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode '7UQ0304M' \
    --namespace $AB_NAMESPACE \
    --limit '4' \
    --offset '73' \
    > test.out 2>&1
eval_tap $? 10 'GetAllTimeLeaderboardRankingAdminV1' test.out

#- 11 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode '873tRtr5' \
    --namespace $AB_NAMESPACE \
    --limit '4' \
    --offset '11' \
    > test.out 2>&1
eval_tap $? 11 'GetCurrentMonthLeaderboardRankingAdminV1' test.out

#- 12 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'WO5JJ2c6' \
    --namespace $AB_NAMESPACE \
    --limit '42' \
    --offset '36' \
    > test.out 2>&1
eval_tap $? 12 'GetCurrentSeasonLeaderboardRankingAdminV1' test.out

#- 13 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'Ons4jNWG' \
    --namespace $AB_NAMESPACE \
    --limit '5' \
    --offset '57' \
    > test.out 2>&1
eval_tap $? 13 'GetTodayLeaderboardRankingAdminV1' test.out

#- 14 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode 'iUa4wM5E' \
    --namespace $AB_NAMESPACE \
    --userId 'u3VqymsF' \
    > test.out 2>&1
eval_tap $? 14 'GetUserRankingAdminV1' test.out

#- 15 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.7745104729900811, "latestValue": 0.23590661756813225}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'rMqEDR8E' \
    --namespace $AB_NAMESPACE \
    --userId '72XMKfhl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdateUserPointAdminV1' test.out

#- 16 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode '6eq2FzU3' \
    --namespace $AB_NAMESPACE \
    --userId 'VL3LNmPL' \
    > test.out 2>&1
eval_tap $? 16 'DeleteUserRankingAdminV1' test.out

#- 17 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 'eZdoCXfa' \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '62' \
    > test.out 2>&1
eval_tap $? 17 'GetCurrentWeekLeaderboardRankingAdminV1' test.out

#- 18 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'XzvjLmai' \
    --leaderboardCode '["7fPKvE2Z"]' \
    > test.out 2>&1
eval_tap $? 18 'DeleteUserRankingsAdminV1' test.out

#- 19 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId '4a63UVtL' \
    --limit '2' \
    --offset '85' \
    > test.out 2>&1
eval_tap $? 19 'GetUserLeaderboardRankingsAdminV1' test.out

#- 20 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'True' \
    --isDeleted 'True' \
    --limit '48' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 20 'GetLeaderboardConfigurationsPublicV1' test.out

#- 21 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "0mGGyHHF"}, "descending": false, "iconURL": "IKsXgvSr", "leaderboardCode": "kEgTYVk5", "monthly": {"resetDate": 17, "resetTime": "RBE6zJJ1"}, "name": "BRHrfCHq", "seasonPeriod": 33, "startTime": "p2GwPcmz", "statCode": "SuY8w9VY", "weekly": {"resetDay": 44, "resetTime": "BEfRXoZL"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationPublicV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateLeaderboardConfigurationPublicV1' test.out

#- 22 GetAllTimeLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV1 \
    --leaderboardCode 'fpVFfDwj' \
    --namespace $AB_NAMESPACE \
    --limit '66' \
    --offset '66' \
    > test.out 2>&1
eval_tap $? 22 'GetAllTimeLeaderboardRankingPublicV1' test.out

#- 23 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode 'CW2g5u8z' \
    --namespace $AB_NAMESPACE \
    --slug '9yrpJdIx' \
    --leaderboardCodes '5vvHS3d6' \
    > test.out 2>&1
eval_tap $? 23 'GetArchivedLeaderboardRankingDataV1Handler' test.out

#- 24 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'PKPE27mI' \
    --namespace $AB_NAMESPACE \
    --limit '82' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 24 'GetCurrentMonthLeaderboardRankingPublicV1' test.out

#- 25 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode '8jt8Lq4x' \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 25 'GetCurrentSeasonLeaderboardRankingPublicV1' test.out

#- 26 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'cocelJjt' \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '73' \
    > test.out 2>&1
eval_tap $? 26 'GetTodayLeaderboardRankingPublicV1' test.out

#- 27 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'Yu8iCPzn' \
    --namespace $AB_NAMESPACE \
    --userId 'x0s5TzT5' \
    > test.out 2>&1
eval_tap $? 27 'GetUserRankingPublicV1' test.out

#- 28 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode '1oV4HTmi' \
    --namespace $AB_NAMESPACE \
    --userId 'vmb6tPmC' \
    > test.out 2>&1
eval_tap $? 28 'DeleteUserRankingPublicV1' test.out

#- 29 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'irkhYvcO' \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '40' \
    > test.out 2>&1
eval_tap $? 29 'GetCurrentWeekLeaderboardRankingPublicV1' test.out

#- 30 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'cjPWGwPs' \
    --namespace $AB_NAMESPACE \
    --limit '43' \
    --offset '19' \
    > test.out 2>&1
eval_tap $? 30 'GetHiddenUsersV2' test.out

#- 31 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode 'LK1CjPt9' \
    --namespace $AB_NAMESPACE \
    --userId '3utbMkpU' \
    > test.out 2>&1
eval_tap $? 31 'GetUserVisibilityStatusV2' test.out

#- 32 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode 'HT0fL9q9' \
    --namespace $AB_NAMESPACE \
    --userId 'SMNAUQVo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'SetUserLeaderboardVisibilityStatusV2' test.out

#- 33 SetUserVisibilityStatusV2
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityStatusV2 \
    --namespace $AB_NAMESPACE \
    --userId 'QtSQC2kN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'SetUserVisibilityStatusV2' test.out

#- 34 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '88' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 34 'GetLeaderboardConfigurationsPublicV2' test.out

#- 35 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'mT0d2aBG' \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '53' \
    > test.out 2>&1
eval_tap $? 35 'GetAllTimeLeaderboardRankingPublicV2' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE