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
echo "1..38"

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
    --sortBy 'createdAt:asc' \
    --status 'RETIRED' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetChallenges' test.out

#- 3 AdminCreateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 52, "assignmentRule": "RANDOMIZED", "code": "5zkoaUEzGS3qZf0P", "description": "bemSBELbZ0VBUGA7", "endAfter": 28, "endDate": "1990-03-22T00:00:00Z", "goalsVisibility": "SHOWALL", "name": "3IlNJKxhPfWV6dIa", "randomizedPerRotation": false, "repeatAfter": 5, "resetConfig": {"resetDate": 65, "resetDay": 77, "resetTime": "bSmeuIBroF7bwRgw"}, "rotation": "DAILY", "startDate": "1982-06-16T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateChallenge \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChallenge' test.out

#- 4 AdminGetActiveChallenges
$CLI_EXE \
    --sn challenge \
    --op AdminGetActiveChallenges \
    --namespace $AB_NAMESPACE \
    --userId 'zESbhpxlDdEs4igd' \
    --limit '74' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetActiveChallenges' test.out

#- 5 AdminGetChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminGetChallenge \
    --challengeCode 'r5AQUBqS8KtTYZLJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AdminGetChallenge' test.out

#- 6 AdminUpdateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 39, "assignmentRule": "RANDOMIZED", "description": "qcV3IcuNs9MF5BT2", "endAfter": 76, "endDate": "1999-08-25T00:00:00Z", "goalsVisibility": "SHOWALL", "name": "18yrWorpC65VJh4q", "randomizedPerRotation": true, "repeatAfter": 51, "resetConfig": {"resetDate": 92, "resetDay": 95, "resetTime": "KJmKedBfbWvKa5Ou"}, "rotation": "DAILY", "startDate": "1998-05-30T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateChallenge \
    --challengeCode 'JPUszmFGEkJVvqDS' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateChallenge' test.out

#- 7 AdminDeleteChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteChallenge \
    --challengeCode 'U3PDyIAGfGq1FNmR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteChallenge' test.out

#- 8 AdminGetGoals
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoals \
    --challengeCode 'WvUvDPnKoECjGUg8' \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --offset '48' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 8 'AdminGetGoals' test.out

#- 9 AdminCreateGoal
# body param: body
echo '{"code": "odwuG14ID5l5wj6K", "description": "2wEMnckjlW6BywsS", "isActive": false, "name": "TGlubsmhjXcScOUv", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "GREATER_THAN_EQUAL", "parameterName": "jJBO7tbkTGYKqRMS", "parameterType": "ENTITLEMENT", "statCycleId": "isP0MrSdaFy0pJYC", "targetValue": 0.048973929224151336}, {"matcher": "EQUAL", "parameterName": "vWFIHPIbOjpls9BZ", "parameterType": "ENTITLEMENT", "statCycleId": "c5BsdSSVaAzzn4Gb", "targetValue": 0.10815231324779506}, {"matcher": "GREATER_THAN", "parameterName": "andercf1nq4Hf32S", "parameterType": "USERACCOUNT", "statCycleId": "PlOBlfUOqv7WmCuq", "targetValue": 0.03933192622838544}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN_EQUAL", "parameterName": "M7YAnbq4DjmYUMhD", "parameterType": "STATISTIC", "statCycleId": "qU89D356pVsUtNan", "targetValue": 0.05833209515324955}, {"matcher": "EQUAL", "parameterName": "A0WWyKl2K5mCSoGe", "parameterType": "STATISTIC", "statCycleId": "Cahcox63cyDxAAYc", "targetValue": 0.6982944152832695}, {"matcher": "GREATER_THAN", "parameterName": "JdoSTxNCK9AIjNmb", "parameterType": "ACHIEVEMENT", "statCycleId": "4uqkhwSC7EajwHO3", "targetValue": 0.6087342316499267}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN_EQUAL", "parameterName": "rA9LXRwU6WLgpQE9", "parameterType": "ENTITLEMENT", "statCycleId": "lPeNq0CvMXtyUWXr", "targetValue": 0.05567635463488718}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "aFeacGT2x6o28Njx", "parameterType": "STATISTIC_CYCLE", "statCycleId": "BwpNJornrCQpMJj5", "targetValue": 0.13605370994091803}, {"matcher": "EQUAL", "parameterName": "5XDLBN9YGVPtkjt0", "parameterType": "STATISTIC_CYCLE", "statCycleId": "yBlJi4RbZ0Iy11mf", "targetValue": 0.6460349287280815}]}], "rewards": [{"itemId": "FjCzZVcGomWF1oAq", "itemName": "UNFDtXnXLvOAsW8w", "qty": 0.8178696185912635, "type": "ENTITLEMENT"}, {"itemId": "FAGD6PRg95m07l03", "itemName": "vtlMFzeiMRkcOr1L", "qty": 0.8482699246211621, "type": "STATISTIC"}, {"itemId": "MIczbYilOziwG8CP", "itemName": "LOzSZm9K3cMY617H", "qty": 0.717248189920533, "type": "STATISTIC"}], "schedule": {"endTime": "1995-02-10T00:00:00Z", "order": 1, "startTime": "1974-11-07T00:00:00Z"}, "tags": ["o69uv1bkFx8DmbC9", "UqYdYrdxNnuMcAwr", "SzYnrcetxObeisZe"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateGoal \
    --challengeCode 'lKuD0iJ6fs3zL9H4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminCreateGoal' test.out

#- 10 AdminGetGoal
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoal \
    --challengeCode 'WxGWRH7fz4BdPhLt' \
    --code 'HRJOImSq37aeAaGq' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetGoal' test.out

#- 11 AdminUpdateGoals
# body param: body
echo '{"description": "0NIj53gXkmrayvcI", "isActive": true, "name": "iWxIAxfvLzSpDFY3", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "xe16KsSRzkf2HzBc", "parameterType": "STATISTIC_CYCLE", "statCycleId": "cQuvDbGMqbEHkCQw", "targetValue": 0.6163871550617591}, {"matcher": "LESS_THAN", "parameterName": "nUyCMEbHh1uE4DmJ", "parameterType": "STATISTIC", "statCycleId": "Suj6DjUw36GtZ83J", "targetValue": 0.24636651379515517}, {"matcher": "LESS_THAN", "parameterName": "f9f1FCoIo3L24DKG", "parameterType": "STATISTIC", "statCycleId": "ir1Af0G6OrPH6Zsj", "targetValue": 0.24561874064049827}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN_EQUAL", "parameterName": "iwplLJdzYS9K0Vvw", "parameterType": "STATISTIC_CYCLE", "statCycleId": "HmR0vknXO45AUtNX", "targetValue": 0.7194194664891509}, {"matcher": "LESS_THAN_EQUAL", "parameterName": "QIXVmrtRlq1jv60H", "parameterType": "ENTITLEMENT", "statCycleId": "g5RDrlzPFQmNu3ER", "targetValue": 0.3853904570962776}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "0UTaiSzfi0FnBERe", "parameterType": "STATISTIC", "statCycleId": "5e4aa8xOJu7rNRVd", "targetValue": 0.3904556113989719}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN", "parameterName": "fKmUkzj9mHFpff2v", "parameterType": "STATISTIC_CYCLE", "statCycleId": "PdGIOAZ86un0L98W", "targetValue": 0.7566609428974114}, {"matcher": "GREATER_THAN", "parameterName": "OgO5W8SUaZjCpNtJ", "parameterType": "STATISTIC", "statCycleId": "m8kDi3Rwubq7wtRG", "targetValue": 0.057224503208639144}, {"matcher": "LESS_THAN", "parameterName": "447Oa51m6VLfjsw2", "parameterType": "ENTITLEMENT", "statCycleId": "0pMmOQJrpEBbVvBn", "targetValue": 0.976246855686885}]}], "rewards": [{"itemId": "Lsf2qSAtizV9hzsV", "itemName": "bpJLtEZjuyFhvbxX", "qty": 0.8823663801085505, "type": "STATISTIC"}, {"itemId": "3lLFeXCiaXP8jBjK", "itemName": "81t2V9TVauFcGkPg", "qty": 0.6825236822121037, "type": "STATISTIC"}, {"itemId": "hb2tLrsMeoZiRYkb", "itemName": "hEM1zTNY3lpincuf", "qty": 0.9281957975519792, "type": "ENTITLEMENT"}], "schedule": {"endTime": "1981-03-07T00:00:00Z", "order": 37, "startTime": "1988-12-30T00:00:00Z"}, "tags": ["Vcktlx9zJZVVCc9b", "pIHEWQMmCkIqwqpo", "TVCNrcaVozsjIXO2"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateGoals \
    --challengeCode 'EUsAfBvo6Llcalks' \
    --code '2R3VMtipTVxXAF8K' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminUpdateGoals' test.out

#- 12 AdminDeleteGoal
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteGoal \
    --challengeCode 'hOKqbrECijFxOpOz' \
    --code 'xeTLJQsZcTEzXaXU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteGoal' test.out

#- 13 AdminListSchedulesByGoal
$CLI_EXE \
    --sn challenge \
    --op AdminListSchedulesByGoal \
    --challengeCode 'zpsAV6ct6XITL0QE' \
    --code 'kadMSQluAoED9oYw' \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '62' \
    --userId '8oLyErKvRtHFGJRo' \
    > test.out 2>&1
eval_tap $? 13 'AdminListSchedulesByGoal' test.out

#- 14 AdminGetPeriods
$CLI_EXE \
    --sn challenge \
    --op AdminGetPeriods \
    --challengeCode 'GW7VBG1VB2sp2x9m' \
    --namespace $AB_NAMESPACE \
    --limit '38' \
    --offset '24' \
    > test.out 2>&1
eval_tap $? 14 'AdminGetPeriods' test.out

#- 15 AdminRandomizeChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminRandomizeChallenge \
    --challengeCode 'zGGoyhGZAzt2OVBT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminRandomizeChallenge' test.out

#- 16 AdminListSchedules
$CLI_EXE \
    --sn challenge \
    --op AdminListSchedules \
    --challengeCode 'LwSH8hWRU9pbItGQ' \
    --namespace $AB_NAMESPACE \
    --dateTime '1982-02-01T00:00:00Z' \
    --limit '100' \
    --offset '71' \
    --userId 'BhGolwafIfbF1GLF' \
    > test.out 2>&1
eval_tap $? 16 'AdminListSchedules' test.out

#- 17 AdminDeleteTiedChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteTiedChallenge \
    --challengeCode 'nrQ4T5cmw7U1TxiS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'AdminDeleteTiedChallenge' test.out

#- 18 AdminUpdateTiedChallengeSchedule
# body param: body
echo '{"action": "STOP", "endDate": "1999-04-11T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateTiedChallengeSchedule \
    --challengeCode 'EoaDZpXOWzpXOi2c' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUpdateTiedChallengeSchedule' test.out

#- 19 AdminGetAssignmentPlugin
$CLI_EXE \
    --sn challenge \
    --op AdminGetAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'AdminGetAssignmentPlugin' test.out

#- 20 AdminUpdateAssignmentPlugin
# body param: body
echo '{"appName": "pajtqcXjPkj2IzU3", "extendType": "APP", "grpcServerAddress": "EpCt1IjlfHJM92t9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminUpdateAssignmentPlugin' test.out

#- 21 AdminCreateAssignmentPlugin
# body param: body
echo '{"appName": "j1XT2ErwIxkaTnYt", "extendType": "CUSTOM", "grpcServerAddress": "QOY0UCcViiFKNjkT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminCreateAssignmentPlugin' test.out

#- 22 AdminDeleteAssignmentPlugin
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminDeleteAssignmentPlugin' test.out

#- 23 AdminEvaluateProgress
# body param: body
echo '{"userIds": ["5hcONCaOyATBFgqL", "eAzvdcUEhWRo6ROv", "buPQwl9dVfJQGkDR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminEvaluateProgress \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminEvaluateProgress' test.out

#- 24 AdminClaimUsersRewards
# body param: body
echo '[{"rewardIds": ["00ofXsbnEzHiRs0N", "mGhxv1vuN7Xv6OuG", "6RR1jPh8RblvnfNi"], "userId": "ABRf1gdXM7QlAlnj"}, {"rewardIds": ["AfgxOdZdf9tLHO1q", "rNyhmUEADczzrL31", "HuYKsCBBgwb1hGjH"], "userId": "JgxrcEvnfJqU4hCv"}, {"rewardIds": ["5egSQDePKSZKp6zw", "DQS1atvJrALaiplJ", "gRhedl5Ewh3jDayY"], "userId": "StUiBB1yz3iP8gH8"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUsersRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminClaimUsersRewards' test.out

#- 25 AdminClaimUserRewardsByGoalCode
# body param: body
echo '{"goalCode": "8UenlMVzIOP8NOf9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewardsByGoalCode \
    --challengeCode '1LsD7cWWOgAs8ThM' \
    --namespace $AB_NAMESPACE \
    --userId 'pAGIapYftYZkBXiE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminClaimUserRewardsByGoalCode' test.out

#- 26 AdminGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserProgression \
    --challengeCode 'hdiS41VBAEUvoBlb' \
    --namespace $AB_NAMESPACE \
    --userId 'H02bobxtljIfHBgj' \
    --dateTime '1992-12-13T00:00:00Z' \
    --goalCode '9onbxFcxS2OZZfXO' \
    --limit '15' \
    --offset '69' \
    --tags '["21v5772AopmjI7Cb", "Y2WuwRUT9IivgC4m", "J5OHuNEVQK4Mvk00"]' \
    > test.out 2>&1
eval_tap $? 26 'AdminGetUserProgression' test.out

#- 27 AdminGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'I9GqAhhjNIivdIca' \
    --challengeCode 'EQfNETQCBPK1mYwK' \
    --goalProgressionId 'VQoydbYjXZyBpqhC' \
    --limit '73' \
    --offset '56' \
    --sortBy 'createdAt:desc' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 27 'AdminGetUserRewards' test.out

#- 28 AdminClaimUserRewards
# body param: body
echo '{"rewardIDs": ["Om3iCpu0lhhgutt3", "rQuKP1OEtKFBjNih", "HU8GP8TRVypSvYXK"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'z4BGjbsrRBV8aztJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminClaimUserRewards' test.out

#- 29 GetChallenges
$CLI_EXE \
    --sn challenge \
    --op GetChallenges \
    --namespace $AB_NAMESPACE \
    --limit '35' \
    --offset '51' \
    --sortBy 'updatedAt:desc' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 29 'GetChallenges' test.out

#- 30 PublicGetScheduledGoals
$CLI_EXE \
    --sn challenge \
    --op PublicGetScheduledGoals \
    --challengeCode 'K1AsC18UO6JcXmwQ' \
    --namespace $AB_NAMESPACE \
    --limit '11' \
    --offset '53' \
    --tags '["kseTpH6l2Dv8SvqY", "Kc56PcPSL2xmjViK", "kKw4gHA4CaLsPqRs"]' \
    > test.out 2>&1
eval_tap $? 30 'PublicGetScheduledGoals' test.out

#- 31 PublicListSchedulesByGoal
$CLI_EXE \
    --sn challenge \
    --op PublicListSchedulesByGoal \
    --challengeCode 'TdKzcKtkGcvn44NW' \
    --code 'se6VLPkM1VTrQByw' \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --offset '72' \
    > test.out 2>&1
eval_tap $? 31 'PublicListSchedulesByGoal' test.out

#- 32 PublicListSchedules
$CLI_EXE \
    --sn challenge \
    --op PublicListSchedules \
    --challengeCode 'qX15hBb4dlNTIBDt' \
    --namespace $AB_NAMESPACE \
    --dateTime '1988-06-13T00:00:00Z' \
    --limit '27' \
    --offset '2' \
    > test.out 2>&1
eval_tap $? 32 'PublicListSchedules' test.out

#- 33 PublicClaimUserRewardsByGoalCode
# body param: body
echo '{"goalCode": "wNLLfKCQKuu2MWXp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewardsByGoalCode \
    --challengeCode 'EpNjHWPcFSnM7GAv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PublicClaimUserRewardsByGoalCode' test.out

#- 34 EvaluateMyProgress
$CLI_EXE \
    --sn challenge \
    --op EvaluateMyProgress \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'EvaluateMyProgress' test.out

#- 35 PublicGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserProgression \
    --challengeCode 'k19sXDish7KUVhmA' \
    --namespace $AB_NAMESPACE \
    --dateTime '1982-04-03T00:00:00Z' \
    --goalCode 'mAygsnn8pM7l6v0e' \
    --limit '24' \
    --offset '47' \
    --tags '["LMceGGgb5FJHWE6s", "13b7dmnPijw6U8GG", "p0E886E90E4ZboiX"]' \
    > test.out 2>&1
eval_tap $? 35 'PublicGetUserProgression' test.out

#- 36 PublicGetPastUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetPastUserProgression \
    --challengeCode 'T1Uy0gArtDpQE4bO' \
    --index '40' \
    --namespace $AB_NAMESPACE \
    --goalCode '0VUWI0kJAczj5Apc' \
    --limit '37' \
    --offset '42' \
    --tags '["iEQ65llgGnTHAsTC", "Za7xE4nwGKlbPRxf", "ucxoRKFLxxcL9Syu"]' \
    > test.out 2>&1
eval_tap $? 36 'PublicGetPastUserProgression' test.out

#- 37 PublicGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserRewards \
    --namespace $AB_NAMESPACE \
    --challengeCode 'HbvRxR6LaKWgAVjZ' \
    --goalProgressionId 'KDxiezEbuMCz9J4d' \
    --limit '85' \
    --offset '6' \
    --sortBy 'updatedAt:desc' \
    --status 'UNCLAIMED' \
    > test.out 2>&1
eval_tap $? 37 'PublicGetUserRewards' test.out

#- 38 PublicClaimUserRewards
# body param: body
echo '{"rewardIDs": ["us7kIWLcgKgU9406", "tdRDqr3cpVbaH69N", "yTfGE59942bCwgpz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicClaimUserRewards' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE