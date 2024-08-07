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
echo "1..25"

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
echo '{"activeGoalsPerRotation": 76, "assignmentRule": "UNSCHEDULED", "code": "qpQwkRRHkaiKsmIi", "description": "RLR3IlNJKxhPfWV6", "endAfter": 7, "endDate": "1988-01-01T00:00:00Z", "goalsVisibility": "PERIODONLY", "name": "X1LxkZs4233oQWoX", "randomizedPerRotation": false, "repeatAfter": 8, "resetConfig": {"resetDate": 45, "resetDay": 34, "resetTime": "KvzESbhpxlDdEs4i"}, "rotation": "DAILY", "startDate": "1979-01-26T00:00:00Z"}' > $TEMP_JSON_INPUT
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
    --challengeCode 'E3r5AQUBqS8KtTYZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetChallenge' test.out

#- 5 AdminUpdateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 77, "assignmentRule": "FIXED", "description": "J58QqcV3IcuNs9MF", "endAfter": 57, "endDate": "1975-01-05T00:00:00Z", "goalsVisibility": "SHOWALL", "name": "KD18yrWorpC65VJh", "randomizedPerRotation": false, "repeatAfter": 33, "resetConfig": {"resetDate": 63, "resetDay": 51, "resetTime": "SU1MO8XnVaEyjmif"}, "rotation": "NONE", "startDate": "1986-01-02T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateChallenge \
    --challengeCode '4TsbQsxYFxGGHrfQ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminUpdateChallenge' test.out

#- 6 AdminDeleteChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteChallenge \
    --challengeCode 'kgXkiA5IZPqCqp9v' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminDeleteChallenge' test.out

#- 7 AdminGetGoals
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoals \
    --challengeCode 'cyt67WAfWXfUfwGB' \
    --namespace $AB_NAMESPACE \
    --limit '13' \
    --offset '41' \
    --sortBy '67xodwuG14ID5l5w' \
    > test.out 2>&1
eval_tap $? 7 'AdminGetGoals' test.out

#- 8 AdminCreateGoal
# body param: body
echo '{"code": "j6K2wEMnckjlW6By", "description": "wsSSZTGlubsmhjXc", "isActive": true, "name": "cOUvrjJBO7tbkTGY", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "LESS_THAN_EQUAL", "parameterName": "MSTisP0MrSdaFy0p", "parameterType": "USERACCOUNT", "statCycleId": "sb4FvWFIHPIbOjpl", "targetValue": 0.30512117428512475}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "BZTYc5BsdSSVaAzz", "parameterType": "ENTITLEMENT", "statCycleId": "T9oXVandercf1nq4", "targetValue": 0.5328565839344236}, {"matcher": "EQUAL", "parameterName": "HXs8PlOBlfUOqv7W", "parameterType": "ENTITLEMENT", "statCycleId": "w9KUW0py8KrcQfuc", "targetValue": 0.7217004984864689}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN_EQUAL", "parameterName": "8gFuJORk4j04YfnX", "parameterType": "STATISTIC", "statCycleId": "anddzgwxYdQc5hEf", "targetValue": 0.07836187803255401}, {"matcher": "EQUAL", "parameterName": "GeQCahcox63cyDxA", "parameterType": "STATISTIC_CYCLE", "statCycleId": "7vg3osbh0fL2h7eJ", "targetValue": 0.3405995529330489}, {"matcher": "LESS_THAN", "parameterName": "NmbfoW8bDq5jPqzh", "parameterType": "USERACCOUNT", "statCycleId": "0YdGSrA9LXRwU6WL", "targetValue": 0.09837806167215624}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "E9nXzhBC0uyMR4Xf", "parameterType": "ENTITLEMENT", "statCycleId": "rdZaFeacGT2x6o28", "targetValue": 0.6309910075963361}, {"matcher": "GREATER_THAN", "parameterName": "LiBwpNJornrCQpMJ", "parameterType": "ENTITLEMENT", "statCycleId": "95Z5XDLBN9YGVPtk", "targetValue": 0.1610851375176816}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "cyAy4drHlPcXGGl0", "parameterType": "ENTITLEMENT", "statCycleId": "w3veBfrpCrnbaxhE", "targetValue": 0.34331884558149073}]}], "rewards": [{"itemId": "n3SGqcH91fC3aJEo", "itemName": "qWaFAGD6PRg95m07", "qty": 0.18005737946743272, "type": "ENTITLEMENT"}, {"itemId": "vtlMFzeiMRkcOr1L", "itemName": "0TMIczbYilOziwG8", "qty": 0.4596686608621954, "type": "STATISTIC"}, {"itemId": "LOzSZm9K3cMY617H", "itemName": "SCYZaL46I3PgCcQ0", "qty": 0.003938455008325015, "type": "STATISTIC"}], "schedule": {"endTime": "1977-01-09T00:00:00Z", "order": 99, "startTime": "1985-04-20T00:00:00Z"}, "tags": ["9UqYdYrdxNnuMcAw", "rSzYnrcetxObeisZ", "elKuD0iJ6fs3zL9H"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateGoal \
    --challengeCode '4WxGWRH7fz4BdPhL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminCreateGoal' test.out

#- 9 AdminGetGoal
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoal \
    --challengeCode 'tHRJOImSq37aeAaG' \
    --code 'q0NIj53gXkmrayvc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminGetGoal' test.out

#- 10 AdminUpdateGoals
# body param: body
echo '{"description": "IYiWxIAxfvLzSpDF", "isActive": false, "name": "dU8VceYQ9erPYQ5y", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "io5UyvuFv5z6wosJ", "parameterType": "USERACCOUNT", "statCycleId": "BcQUNPHN8YZT0yJJ", "targetValue": 0.8509801843530669}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "Suj6DjUw36GtZ83J", "parameterType": "ENTITLEMENT", "statCycleId": "TCSxjAqg9oGVEdC8", "targetValue": 0.205510173178725}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "ir1Af0G6OrPH6Zsj", "parameterType": "ENTITLEMENT", "statCycleId": "u27iwplLJdzYS9K0", "targetValue": 0.7649975098050489}]}, {"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "wE6MAqPc8lGIYWTw", "parameterType": "STATISTIC_CYCLE", "statCycleId": "XSTItt35OJTfJBZX", "targetValue": 0.9409299562969582}, {"matcher": "LESS_THAN", "parameterName": "HTnmFrl3gYx6Xmv1", "parameterType": "STATISTIC_CYCLE", "statCycleId": "ERxV0UTaiSzfi0Fn", "targetValue": 0.43739203474514743}, {"matcher": "LESS_THAN", "parameterName": "TYM95e4aa8xOJu7r", "parameterType": "STATISTIC_CYCLE", "statCycleId": "dygfKmUkzj9mHFpf", "targetValue": 0.08789687245160571}]}, {"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "Dkz68zorEgcExv9n", "parameterType": "USERACCOUNT", "statCycleId": "UoXvfU4qMIpfgxw2", "targetValue": 0.08954505301490867}, {"matcher": "EQUAL", "parameterName": "SMm8kDi3Rwubq7wt", "parameterType": "USERACCOUNT", "statCycleId": "GdT447Oa51m6VLfj", "targetValue": 0.2940570156329285}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "Krm8UuNlT86N9yO0", "parameterType": "STATISTIC", "statCycleId": "Bn8Lsf2qSAtizV9h", "targetValue": 0.4059957948220967}]}], "rewards": [{"itemId": "sVbpJLtEZjuyFhvb", "itemName": "xX2DNbknfVv4nm70", "qty": 0.7413028138573634, "type": "STATISTIC"}, {"itemId": "jK81t2V9TVauFcGk", "itemName": "PgQ0hb2tLrsMeoZi", "qty": 0.7079868421200729, "type": "STATISTIC"}, {"itemId": "kbhEM1zTNY3lpinc", "itemName": "uf5d5saQvKfFRqBa", "qty": 0.20038498761907597, "type": "ENTITLEMENT"}], "schedule": {"endTime": "1985-12-10T00:00:00Z", "order": 5, "startTime": "1981-10-27T00:00:00Z"}, "tags": ["bpIHEWQMmCkIqwqp", "oTVCNrcaVozsjIXO", "2EUsAfBvo6Llcalk"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateGoals \
    --challengeCode 's2R3VMtipTVxXAF8' \
    --code 'KhOKqbrECijFxOpO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateGoals' test.out

#- 11 AdminDeleteGoal
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteGoal \
    --challengeCode 'zxeTLJQsZcTEzXaX' \
    --code 'UzpsAV6ct6XITL0Q' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminDeleteGoal' test.out

#- 12 AdminGetPeriods
$CLI_EXE \
    --sn challenge \
    --op AdminGetPeriods \
    --challengeCode 'EkadMSQluAoED9oY' \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '92' \
    > test.out 2>&1
eval_tap $? 12 'AdminGetPeriods' test.out

#- 13 AdminRandomizeChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminRandomizeChallenge \
    --challengeCode 'E1X9ecBBhRAYjR7c' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminRandomizeChallenge' test.out

#- 14 AdminDeleteTiedChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteTiedChallenge \
    --challengeCode '4x5bIk8pVpxdUWOP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteTiedChallenge' test.out

#- 15 AdminEvaluateProgress
# body param: body
echo '{"userIds": ["el3TiwTycqpVdINX", "zvkSp0WbvxQWI0QG", "COx7eICkauWbFrSn"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminEvaluateProgress \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminEvaluateProgress' test.out

#- 16 AdminClaimUsersRewards
# body param: body
echo '[{"rewardIds": ["U7d1BuhdwliTSDdm", "GVfegiD3mrVQaUr3", "oT88Dfc7114QFGwT"], "userId": "zBVDg5v71kGCEt7h"}, {"rewardIds": ["1mVwIQCJmQkvWbQr", "n2W0VkOF0pQOY0UC", "cViiFKNjkT5hcONC"], "userId": "aOyATBFgqLeAzvdc"}, {"rewardIds": ["UEhWRo6ROvbuPQwl", "9dVfJQGkDR00ofXs", "bnEzHiRs0NmGhxv1"], "userId": "vuN7Xv6OuG6RR1jP"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUsersRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminClaimUsersRewards' test.out

#- 17 AdminGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'h8RblvnfNiABRf1g' \
    --limit '7' \
    --offset '41' \
    --sortBy 'XM7QlAlnjAfgxOdZ' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetUserRewards' test.out

#- 18 AdminClaimUserRewards
# body param: body
echo '{"rewardIDs": ["bas2CAlSxxVhDR9h", "laznetBUGcQz2Wvd", "iclkYGDL2ckC9cdz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'aLnajQ8GnJpALidd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminClaimUserRewards' test.out

#- 19 GetChallenges
$CLI_EXE \
    --sn challenge \
    --op GetChallenges \
    --namespace $AB_NAMESPACE \
    --limit '45' \
    --offset '74' \
    --sortBy '9UUtG1tEECsm8xaD' \
    --status 'TIED' \
    > test.out 2>&1
eval_tap $? 19 'GetChallenges' test.out

#- 20 PublicGetScheduledGoals
$CLI_EXE \
    --sn challenge \
    --op PublicGetScheduledGoals \
    --challengeCode 'ALaiplJgRhedl5Ew' \
    --namespace $AB_NAMESPACE \
    --limit '15' \
    --offset '85' \
    --tags '["3jDayYStUiBB1yz3", "iP8gH88UenlMVzIO", "P8NOf91LsD7cWWOg"]' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetScheduledGoals' test.out

#- 21 EvaluateMyProgress
$CLI_EXE \
    --sn challenge \
    --op EvaluateMyProgress \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'EvaluateMyProgress' test.out

#- 22 PublicGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserProgression \
    --challengeCode 'As8ThMpAGIapYftY' \
    --namespace $AB_NAMESPACE \
    --dateTime '1997-03-29T00:00:00Z' \
    --goalCode 'kBXiEhdiS41VBAEU' \
    --limit '44' \
    --offset '14' \
    --tags '["oBlbH02bobxtljIf", "HBgjP9onbxFcxS2O", "ZZfXO3HkJTOPscPA"]' \
    > test.out 2>&1
eval_tap $? 22 'PublicGetUserProgression' test.out

#- 23 PublicGetPastUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetPastUserProgression \
    --challengeCode '2n25C1zEnAMGmFy7' \
    --index '46' \
    --namespace $AB_NAMESPACE \
    --goalCode 'ivgC4mJ5OHuNEVQK' \
    --limit '49' \
    --offset '79' \
    --tags '["m68w7s9RMx2hc45Q", "X234xnqlbRAPFQsc", "a6n9vGZTCCXQ2Lf7"]' \
    > test.out 2>&1
eval_tap $? 23 'PublicGetPastUserProgression' test.out

#- 24 PublicGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserRewards \
    --namespace $AB_NAMESPACE \
    --limit '19' \
    --offset '32' \
    --sortBy 'texB613cbiJEUePV' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 24 'PublicGetUserRewards' test.out

#- 25 PublicClaimUserRewards
# body param: body
echo '{"rewardIDs": ["QaoEY2zrpLuvrx96", "OOz45vMiR3QYZJKV", "NlK8PTaIXRWFTyA9"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicClaimUserRewards' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE