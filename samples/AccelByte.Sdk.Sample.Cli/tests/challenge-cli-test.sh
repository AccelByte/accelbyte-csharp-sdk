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
echo "1..22"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminGetChallenges
$CLI_EXE \
    --sn challenge \
    --op AdminGetChallenges \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    --sortBy 'i3wMWnoZgIhwb8YY' \
    --status 'TIED' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetChallenges' test.out

#- 3 AdminCreateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 76, "assignmentRule": "UNSCHEDULED", "code": "qpQwkRRHkaiKsmIi", "description": "RLR3IlNJKxhPfWV6", "endAfter": 7, "endDate": "1988-01-01T00:00:00Z", "goalsVisibility": "PERIODONLY", "name": "X1LxkZs4233oQWoX", "repeatAfter": 65, "rotation": "DAILY", "startDate": "1973-07-03T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateChallenge \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChallenge' test.out

#- 4 AdminGetChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminGetChallenge \
    --challengeCode 'qeuI2oMJ0cgAoGfX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetChallenge' test.out

#- 5 AdminUpdateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 8, "assignmentRule": "FIXED", "description": "pE3r5AQUBqS8KtTY", "endAfter": 77, "endDate": "1972-10-23T00:00:00Z", "goalsVisibility": "SHOWALL", "name": "QqcV3IcuNs9MF5BT", "repeatAfter": 44, "rotation": "WEEKLY", "startDate": "1981-05-13T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateChallenge \
    --challengeCode 'yrWorpC65VJh4q1z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminUpdateChallenge' test.out

#- 6 AdminDeleteChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteChallenge \
    --challengeCode '1KJmKedBfbWvKa5O' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminDeleteChallenge' test.out

#- 7 AdminGetGoals
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoals \
    --challengeCode 'u124TsbQsxYFxGGH' \
    --namespace $AB_NAMESPACE \
    --limit '37' \
    --offset '98' \
    --sortBy 'fQkgXkiA5IZPqCqp' \
    > test.out 2>&1
eval_tap $? 7 'AdminGetGoals' test.out

#- 8 AdminCreateGoal
# body param: body
echo '{"code": "9vcyt67WAfWXfUfw", "description": "GB03tz8qIH4uRdNO", "isActive": false, "name": "HN6s9p8Y5c9eItJt", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "NmY3y3n2Rim4NBqh", "parameterType": "STATISTIC_CYCLE", "statCycleId": "cScOUvrjJBO7tbkT", "targetValue": 0.524319005818073}, {"matcher": "EQUAL", "parameterName": "KqRMSTisP0MrSdaF", "parameterType": "USERACCOUNT", "statCycleId": "zyZsb4FvWFIHPIbO", "targetValue": 0.15942482713964934}, {"matcher": "GREATER_THAN", "parameterName": "HdWqJTNjrmpnnEck", "parameterType": "USERACCOUNT", "statCycleId": "H8kT9oXVandercf1", "targetValue": 0.2151312437509162}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "4Hf32SL5PjaYEDxa", "parameterType": "STATISTIC", "statCycleId": "w9KUW0py8KrcQfuc", "targetValue": 0.7217004984864689}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "YUMhD9qU89D356pV", "parameterType": "STATISTIC_CYCLE", "statCycleId": "nXTsQUrA0WWyKl2K", "targetValue": 0.9206572333329603}, {"matcher": "GREATER_THAN", "parameterName": "EfefdopcEM0JHfof", "parameterType": "USERACCOUNT", "statCycleId": "Hwi7vg3osbh0fL2h", "targetValue": 0.9555319249188895}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "JvAS2W4uqkhwSC7E", "parameterType": "ACHIEVEMENT", "statCycleId": "zhN0YdGSrA9LXRwU", "targetValue": 0.9426029371691769}, {"matcher": "GREATER_THAN", "parameterName": "LgpQE9nXzhBC0uyM", "parameterType": "STATISTIC_CYCLE", "statCycleId": "4Xf2nfYvNvG8uQ14", "targetValue": 0.4271998251978737}, {"matcher": "EQUAL", "parameterName": "o28Njxyw7RHldq0m", "parameterType": "STATISTIC", "statCycleId": "jUZ95Z5XDLBN9YGV", "targetValue": 0.6696890746088731}]}], "rewards": [{"itemId": "tkjt0OyBlJi4RbZ0", "itemName": "Iy11mfOFjCzZVcGo", "qty": 0.20918548862613284, "type": "STATISTIC"}, {"itemId": "F1oAqUNFDtXnXLvO", "itemName": "AsW8wYh4gq7pRVZV", "qty": 0.6031496465517044, "type": "ENTITLEMENT"}, {"itemId": "7l03vtlMFzeiMRkc", "itemName": "Or1L0TMIczbYilOz", "qty": 0.1411052495931986, "type": "STATISTIC"}], "schedule": {"endTime": "1999-09-18T00:00:00Z", "order": 89, "startTime": "1983-08-22T00:00:00Z"}, "tags": ["spSqwdbTR2sgzfaQ", "rUCW9fgo69uv1bkF", "x8DmbC9UqYdYrdxN"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateGoal \
    --challengeCode 'nuMcAwrSzYnrcetx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminCreateGoal' test.out

#- 9 AdminGetGoal
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoal \
    --challengeCode 'ObeisZelKuD0iJ6f' \
    --code 's3zL9H4WxGWRH7fz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminGetGoal' test.out

#- 10 AdminUpdateGoals
# body param: body
echo '{"description": "4BdPhLtHRJOImSq3", "isActive": false, "name": "swnkSyuJTVjKQ1OR", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "yvcIYiWxIAxfvLzS", "parameterType": "STATISTIC_CYCLE", "statCycleId": "0b27RdU8VceYQ9er", "targetValue": 0.6732005393027989}, {"matcher": "LESS_THAN_EQUAL", "parameterName": "Q5yVcQuvDbGMqbEH", "parameterType": "STATISTIC", "statCycleId": "wosJGnUyCMEbHh1u", "targetValue": 0.49268081673296227}, {"matcher": "LESS_THAN", "parameterName": "DmJ4Suj6DjUw36Gt", "parameterType": "STATISTIC", "statCycleId": "83Jp2f9f1FCoIo3L", "targetValue": 0.8824018691522659}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "8mQir1Af0G6OrPH6", "parameterType": "USERACCOUNT", "statCycleId": "sjpPgHKISHtB8tWd", "targetValue": 0.5782156630719524}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "c5HmR0vknXO45AUt", "parameterType": "USERACCOUNT", "statCycleId": "XSTItt35OJTfJBZX", "targetValue": 0.9409299562969582}, {"matcher": "LESS_THAN", "parameterName": "HTnmFrl3gYx6Xmv1", "parameterType": "USERACCOUNT", "statCycleId": "ERxV0UTaiSzfi0Fn", "targetValue": 0.43739203474514743}]}, {"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "M95e4aa8xOJu7rNR", "parameterType": "USERACCOUNT", "statCycleId": "dygfKmUkzj9mHFpf", "targetValue": 0.08789687245160571}, {"matcher": "LESS_THAN_EQUAL", "parameterName": "vDkz68zorEgcExv9", "parameterType": "STATISTIC", "statCycleId": "WUoXvfU4qMIpfgxw", "targetValue": 0.8821531557761855}, {"matcher": "EQUAL", "parameterName": "JSMm8kDi3Rwubq7w", "parameterType": "STATISTIC_CYCLE", "statCycleId": "6IpYBxafo9b4xJyN", "targetValue": 0.2097446333523585}]}], "rewards": [{"itemId": "vHKrm8UuNlT86N9y", "itemName": "O0vyD6J5brVo20e6", "qty": 0.6743501797088559, "type": "ENTITLEMENT"}, {"itemId": "TjrinAVVovpAAXNz", "itemName": "cpbmX3lLFeXCiaXP", "qty": 0.972869238641037, "type": "ENTITLEMENT"}, {"itemId": "TCayYAkF18YBwRxc", "itemName": "REyU5CwqGJF6nDi3", "qty": 0.9023392657290454, "type": "STATISTIC"}], "schedule": {"endTime": "1996-06-05T00:00:00Z", "order": 21, "startTime": "1980-01-10T00:00:00Z"}, "tags": ["2QcwlRrReRajlpk8", "lfuiJVcktlx9zJZV", "VCc9bpIHEWQMmCkI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateGoals \
    --challengeCode 'qwqpoTVCNrcaVozs' \
    --code 'jIXO2EUsAfBvo6Ll' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateGoals' test.out

#- 11 AdminDeleteGoal
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteGoal \
    --challengeCode 'calks2R3VMtipTVx' \
    --code 'XAF8KhOKqbrECijF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminDeleteGoal' test.out

#- 12 AdminGetPeriods
$CLI_EXE \
    --sn challenge \
    --op AdminGetPeriods \
    --challengeCode 'xOpOzxeTLJQsZcTE' \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --offset '85' \
    > test.out 2>&1
eval_tap $? 12 'AdminGetPeriods' test.out

#- 13 AdminRandomizeChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminRandomizeChallenge \
    --challengeCode 'XaXUzpsAV6ct6XIT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminRandomizeChallenge' test.out

#- 14 AdminDeleteTiedChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteTiedChallenge \
    --challengeCode 'L0QEkadMSQluAoED' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteTiedChallenge' test.out

#- 15 AdminEvaluateProgress
# body param: body
echo '{"userIds": ["9oYwS8oLyErKvRtH", "FGJRoGW7VBG1VB2s", "p2x9mszGGoyhGZAz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminEvaluateProgress \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminEvaluateProgress' test.out

#- 16 AdminGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 't2OVBTLwSH8hWRU9' \
    --limit '31' \
    --offset '71' \
    --sortBy 'bItGQ7VUWBhGolwa' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 16 'AdminGetUserRewards' test.out

#- 17 GetChallenges
$CLI_EXE \
    --sn challenge \
    --op GetChallenges \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    --offset '70' \
    --sortBy 'SnU7d1BuhdwliTSD' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 17 'GetChallenges' test.out

#- 18 PublicGetScheduledGoals
$CLI_EXE \
    --sn challenge \
    --op PublicGetScheduledGoals \
    --challengeCode '7U1TxiS06UEoaDZp' \
    --namespace $AB_NAMESPACE \
    --limit '83' \
    --offset '29' \
    --tags '["WzpXOi2cpajtqcXj", "Pkj2IzU3MEpCt1Ij", "lfHJM92t9j1XT2Er"]' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetScheduledGoals' test.out

#- 19 EvaluateMyProgress
$CLI_EXE \
    --sn challenge \
    --op EvaluateMyProgress \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'EvaluateMyProgress' test.out

#- 20 PublicGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserProgression \
    --challengeCode 'wIxkaTnYtr1YDnaX' \
    --namespace $AB_NAMESPACE \
    --goalCode 'B0JOS4XKVT66sHYP' \
    --limit '13' \
    --offset '83' \
    --tags '["VsfhoEidKw4IP0NV", "naangorhVFpTRuQy", "MroT2hNfKJ7q8sif"]' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetUserProgression' test.out

#- 21 PublicGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserRewards \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '62' \
    --sortBy 'PmYSsBxtyKWssEn5' \
    --status 'UNCLAIMED' \
    > test.out 2>&1
eval_tap $? 21 'PublicGetUserRewards' test.out

#- 22 PublicClaimUserRewards
# body param: body
echo '{"rewardIDs": ["Xv6OuG6RR1jPh8Rb", "lvnfNiABRf1gdXM7", "QlAlnjAfgxOdZdf9"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PublicClaimUserRewards' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE