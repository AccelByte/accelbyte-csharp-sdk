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
echo "1..35"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetLeaderboardConfigurationsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'false' \
    --isDeleted 'true' \
    --limit '34' \
    --offset '74' \
    > test.out 2>&1
eval_tap $? 2 'GetLeaderboardConfigurationsAdminV1' test.out

#- 3 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "lnnGxgHy"}, "descending": true, "iconURL": "8rHMVfq4", "leaderboardCode": "DLjSKEXb", "monthly": {"resetDate": 82, "resetTime": "GJb3H2H0"}, "name": "w30oexey", "seasonPeriod": 77, "startTime": "fc0nsJhE", "statCode": "WdFTHTaL", "weekly": {"resetDay": 82, "resetTime": "HuKHApwJ"}}' > $TEMP_JSON_INPUT
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
    --slug 'nl1jJmIq' \
    --leaderboardCodes '4ZFW14VM' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetArchivedLeaderboardRankingDataV1Handler' test.out

#- 5 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["VIEvDKea", "n4u9pmqv", "CY5WU68J"], "limit": 68, "slug": "H2CoVMca"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateArchivedLeaderboardRankingDataV1Handler' test.out

#- 6 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["opB8C8j9", "F8e63APB", "QQowBORE"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'GCT8xG11' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetLeaderboardConfigurationAdminV1' test.out

#- 8 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "cBkLhqOd"}, "descending": true, "iconURL": "5puvPbkw", "monthly": {"resetDate": 22, "resetTime": "UqaBiqmr"}, "name": "TjxW1u3q", "seasonPeriod": 37, "startTime": "XGgn3N6c", "statCode": "T6zBzf91", "weekly": {"resetDay": 35, "resetTime": "4ZE4rIy7"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'is0ACW2k' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateLeaderboardConfigurationAdminV1' test.out

#- 9 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'AK7uD68i' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteLeaderboardConfigurationAdminV1' test.out

#- 10 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode '8SHimR1k' \
    --namespace $AB_NAMESPACE \
    --limit '35' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 10 'GetAllTimeLeaderboardRankingAdminV1' test.out

#- 11 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode '8UEm58Ku' \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --offset '97' \
    > test.out 2>&1
eval_tap $? 11 'GetCurrentMonthLeaderboardRankingAdminV1' test.out

#- 12 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'ueXTS4HB' \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '40' \
    > test.out 2>&1
eval_tap $? 12 'GetCurrentSeasonLeaderboardRankingAdminV1' test.out

#- 13 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'izxanFD9' \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 13 'GetTodayLeaderboardRankingAdminV1' test.out

#- 14 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode 'uoOIFEqn' \
    --namespace $AB_NAMESPACE \
    --userId 'PT6U02wL' \
    > test.out 2>&1
eval_tap $? 14 'GetUserRankingAdminV1' test.out

#- 15 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.6979350793234111, "latestValue": 0.07441969049361341}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'bFwiRawg' \
    --namespace $AB_NAMESPACE \
    --userId 'bL5Uysd3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdateUserPointAdminV1' test.out

#- 16 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode '7bV32swn' \
    --namespace $AB_NAMESPACE \
    --userId 'PSkXFVxP' \
    > test.out 2>&1
eval_tap $? 16 'DeleteUserRankingAdminV1' test.out

#- 17 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 'dh90NCk7' \
    --namespace $AB_NAMESPACE \
    --limit '44' \
    --offset '13' \
    > test.out 2>&1
eval_tap $? 17 'GetCurrentWeekLeaderboardRankingAdminV1' test.out

#- 18 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId '2Ge3icrV' \
    --leaderboardCode '["rCth3ato", "oVc4quJz", "kiRGlJup"]' \
    > test.out 2>&1
eval_tap $? 18 'DeleteUserRankingsAdminV1' test.out

#- 19 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Fhy3RsOc' \
    --limit '33' \
    --offset '27' \
    > test.out 2>&1
eval_tap $? 19 'GetUserLeaderboardRankingsAdminV1' test.out

#- 20 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'true' \
    --isDeleted 'false' \
    --limit '12' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 20 'GetLeaderboardConfigurationsPublicV1' test.out

#- 21 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "vX9d6q4H"}, "descending": true, "iconURL": "gXaILH1M", "leaderboardCode": "Bdp0u60o", "monthly": {"resetDate": 36, "resetTime": "yU0JNk56"}, "name": "A7OB5OSo", "seasonPeriod": 76, "startTime": "oS5ida57", "statCode": "P35KIM8d", "weekly": {"resetDay": 7, "resetTime": "ZpIIcJpw"}}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'fJrDzSOL' \
    --namespace $AB_NAMESPACE \
    --limit '64' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 22 'GetAllTimeLeaderboardRankingPublicV1' test.out

#- 23 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode 'AmuBtLjA' \
    --namespace $AB_NAMESPACE \
    --slug 'V775Ywek' \
    --leaderboardCodes '8Ls74O0x' \
    > test.out 2>&1
eval_tap $? 23 'GetArchivedLeaderboardRankingDataV1Handler' test.out

#- 24 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'oQuPYqQB' \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '32' \
    > test.out 2>&1
eval_tap $? 24 'GetCurrentMonthLeaderboardRankingPublicV1' test.out

#- 25 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode 'Scgz4SID' \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 25 'GetCurrentSeasonLeaderboardRankingPublicV1' test.out

#- 26 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'X8QADX7C' \
    --namespace $AB_NAMESPACE \
    --limit '41' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 26 'GetTodayLeaderboardRankingPublicV1' test.out

#- 27 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'E1CZz2ry' \
    --namespace $AB_NAMESPACE \
    --userId 'DteCepLh' \
    > test.out 2>&1
eval_tap $? 27 'GetUserRankingPublicV1' test.out

#- 28 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode 'z2aSVeZp' \
    --namespace $AB_NAMESPACE \
    --userId 'DLo4oQCh' \
    > test.out 2>&1
eval_tap $? 28 'DeleteUserRankingPublicV1' test.out

#- 29 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'iKgYzxlH' \
    --namespace $AB_NAMESPACE \
    --limit '11' \
    --offset '5' \
    > test.out 2>&1
eval_tap $? 29 'GetCurrentWeekLeaderboardRankingPublicV1' test.out

#- 30 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'OvntQ025' \
    --namespace $AB_NAMESPACE \
    --limit '82' \
    --offset '100' \
    > test.out 2>&1
eval_tap $? 30 'GetHiddenUsersV2' test.out

#- 31 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode 'eKadZKtR' \
    --namespace $AB_NAMESPACE \
    --userId 'DRTwrB9Y' \
    > test.out 2>&1
eval_tap $? 31 'GetUserVisibilityStatusV2' test.out

#- 32 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode '0BgjLv3I' \
    --namespace $AB_NAMESPACE \
    --userId '5nvgb8Co' \
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
    --userId 'i5tC5gEt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'SetUserVisibilityStatusV2' test.out

#- 34 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '98' \
    > test.out 2>&1
eval_tap $? 34 'GetLeaderboardConfigurationsPublicV2' test.out

#- 35 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'aOkdjPN9' \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 35 'GetAllTimeLeaderboardRankingPublicV2' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE