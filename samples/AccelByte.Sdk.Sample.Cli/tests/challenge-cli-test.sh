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
echo "1..39"

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
    --keyword 'bBuz5zkoaUEzGS3q' \
    --limit '12' \
    --offset '79' \
    --sortBy 'updatedAt:asc' \
    --status 'TIED' \
    --tags '["qpQwkRRHkaiKsmIi", "RLR3IlNJKxhPfWV6", "dIabcFbSmeuIBroF"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetChallenges' test.out

#- 3 AdminCreateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 99, "assignmentRule": "CUSTOM", "code": "oXFeqeuI2oMJ0cgA", "description": "oGfXepE3r5AQUBqS", "endAfter": 75, "endDate": "1975-06-14T00:00:00Z", "goalsVisibility": "PERIODONLY", "name": "J58QqcV3IcuNs9MF", "randomizedPerRotation": true, "repeatAfter": 17, "resetConfig": {"resetDate": 93, "resetDay": 1, "resetTime": "2KD18yrWorpC65VJ"}, "rotation": "DAILY", "startDate": "1976-02-04T00:00:00Z", "tags": ["q1z1KJmKedBfbWvK", "a5Ou124TsbQsxYFx", "GGHrfQkgXkiA5IZP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateChallenge \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChallenge' test.out

#- 4 AdminGetItemReferences
$CLI_EXE \
    --sn challenge \
    --op AdminGetItemReferences \
    --namespace $AB_NAMESPACE \
    --itemId 'qCqp9vcyt67WAfWX' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetItemReferences' test.out

#- 5 AdminGetActiveChallenges
$CLI_EXE \
    --sn challenge \
    --op AdminGetActiveChallenges \
    --namespace $AB_NAMESPACE \
    --userId 'fUfwGB03tz8qIH4u' \
    --limit '89' \
    --offset '7' \
    > test.out 2>&1
eval_tap $? 5 'AdminGetActiveChallenges' test.out

#- 6 AdminGetChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminGetChallenge \
    --challengeCode '4ID5l5wj6K2wEMnc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetChallenge' test.out

#- 7 AdminUpdateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 22, "assignmentRule": "FIXED", "description": "tJtiNmY3y3n2Rim4", "endAfter": 82, "endDate": "1977-08-15T00:00:00Z", "goalsVisibility": "PERIODONLY", "name": "qhuNtj8FOvKZjs1t", "randomizedPerRotation": false, "repeatAfter": 31, "resetConfig": {"resetDate": 93, "resetDay": 62, "resetTime": "GYKqRMSTisP0MrSd"}, "rotation": "DAILY", "startDate": "1984-09-11T00:00:00Z", "tags": ["2zyZsb4FvWFIHPIb", "Ojpls9BZTYc5BsdS", "SVaAzzn4GbgkKeCa"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateChallenge \
    --challengeCode 'S6qyUCscHXs8PlOB' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateChallenge' test.out

#- 8 AdminDeleteChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteChallenge \
    --challengeCode 'lfUOqv7WmCuqcsNM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteChallenge' test.out

#- 9 AdminGetGoals
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoals \
    --challengeCode '7YAnbq4DjmYUMhD9' \
    --namespace $AB_NAMESPACE \
    --limit '33' \
    --offset '73' \
    --sortBy 'updatedAt:desc' \
    --tags '["89D356pVsUtNandd", "zgwxYdQc5hEfefdo", "pcEM0JHfof2Hwi7v"]' \
    > test.out 2>&1
eval_tap $? 9 'AdminGetGoals' test.out

#- 10 AdminCreateGoal
# body param: body
echo '{"code": "g3osbh0fL2h7eJvA", "description": "S2W4uqkhwSC7Eajw", "isActive": false, "name": "LfvwPewrf19Njm50", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "CDlPeNq0CvMXtyUW", "parameterType": "ENTITLEMENT", "statCycleId": "rdZaFeacGT2x6o28", "targetValue": 0.6309910075963361}, {"matcher": "GREATER_THAN", "parameterName": "LiBwpNJornrCQpMJ", "parameterType": "ENTITLEMENT", "statCycleId": "95Z5XDLBN9YGVPtk", "targetValue": 0.1610851375176816}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "cyAy4drHlPcXGGl0", "parameterType": "ENTITLEMENT", "statCycleId": "w3veBfrpCrnbaxhE", "targetValue": 0.34331884558149073}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN_EQUAL", "parameterName": "3SGqcH91fC3aJEoq", "parameterType": "ACHIEVEMENT", "statCycleId": "h4gq7pRVZVLJiDx3", "targetValue": 0.013563769666111614}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "tlMFzeiMRkcOr1L0", "parameterType": "STATISTIC_CYCLE", "statCycleId": "MIczbYilOziwG8CP", "targetValue": 0.6005464622428479}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "zSZm9K3cMY617HSC", "parameterType": "ACHIEVEMENT", "statCycleId": "aL46I3PgCcQ0axTW", "targetValue": 0.21880886697211932}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN", "parameterName": "qYdYrdxNnuMcAwrS", "parameterType": "STATISTIC_CYCLE", "statCycleId": "8kSSFjeuL3wQQPYw", "targetValue": 0.20779314888388645}, {"matcher": "LESS_THAN", "parameterName": "FbxRvHYDCYwoGdmz", "parameterType": "ACHIEVEMENT", "statCycleId": "H7fz4BdPhLtHRJOI", "targetValue": 0.20805494358206367}, {"matcher": "LESS_THAN_EQUAL", "parameterName": "q37aeAaGq0NIj53g", "parameterType": "ENTITLEMENT", "statCycleId": "ORLEIAePvDO2xkVg", "targetValue": 0.39706936932337633}]}], "rewards": [{"itemId": "Rk10b27RdU8VceYQ", "itemName": "9erPYQ5yVcQuvDbG", "qty": 0.6286314018858336, "type": "STATISTIC"}, {"itemId": "v5z6wosJGnUyCMEb", "itemName": "Hh1uE4DmJ4Suj6Dj", "qty": 0.7551109619367677, "type": "STATISTIC"}, {"itemId": "V3hSIiTEoTCSxjAq", "itemName": "g9oGVEdC8mQir1Af", "qty": 0.8433614477643366, "type": "STATISTIC"}], "schedule": {"endTime": "1992-02-04T00:00:00Z", "order": 68, "startTime": "1981-12-11T00:00:00Z"}, "tags": ["ZsjpPgHKISHtB8tW", "dJM9Qc5HmR0vknXO", "45AUtNXSTItt35OJ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateGoal \
    --challengeCode 'TfJBZX62yI9g5RDr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminCreateGoal' test.out

#- 11 AdminGetGoal
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoal \
    --challengeCode 'lzPFQmNu3ERxV0UT' \
    --code 'aiSzfi0FnBERe8qN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetGoal' test.out

#- 12 AdminUpdateGoals
# body param: body
echo '{"description": "YRTYSaZw4NqSNylc", "isActive": false, "name": "fKmUkzj9mHFpff2v", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "GREATER_THAN", "parameterName": "dGIOAZ86un0L98WU", "parameterType": "ENTITLEMENT", "statCycleId": "OgO5W8SUaZjCpNtJ", "targetValue": 0.7197127858161474}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "m8kDi3Rwubq7wtRG", "parameterType": "ACHIEVEMENT", "statCycleId": "YBxafo9b4xJyNnvH", "targetValue": 0.5939747831534571}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "70pMmOQJrpEBbVvB", "parameterType": "ENTITLEMENT", "statCycleId": "D6J5brVo20e6POTj", "targetValue": 0.2862971779970339}]}, {"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "nAVVovpAAXNzcpbm", "parameterType": "STATISTIC_CYCLE", "statCycleId": "3lLFeXCiaXP8jBjK", "targetValue": 0.9786507771767404}, {"matcher": "LESS_THAN", "parameterName": "t2V9TVauFcGkPgQ0", "parameterType": "ACHIEVEMENT", "statCycleId": "wqGJF6nDi33Iztr2", "targetValue": 0.6810072323979985}, {"matcher": "EQUAL", "parameterName": "M1zTNY3lpincuf5d", "parameterType": "ENTITLEMENT", "statCycleId": "saQvKfFRqBam8jPt", "targetValue": 0.5883214326785575}]}, {"operator": "AND", "predicates": [{"matcher": "LESS_THAN_EQUAL", "parameterName": "mzo0JmcQmnsUigVy", "parameterType": "ENTITLEMENT", "statCycleId": "CNrcaVozsjIXO2EU", "targetValue": 0.2923375346077204}, {"matcher": "LESS_THAN", "parameterName": "AsmC0RuRA8j1AJ3h", "parameterType": "USERACCOUNT", "statCycleId": "WWhADRqJvaZrf2qX", "targetValue": 0.691071937111984}, {"matcher": "LESS_THAN_EQUAL", "parameterName": "ECijFxOpOzxeTLJQ", "parameterType": "STATISTIC", "statCycleId": "0gPYhPPG5sAIfYtY", "targetValue": 0.23679576308154082}]}], "rewards": [{"itemId": "zA2OntGCwQSHHdPL", "itemName": "wjTngrvb2E1X9ecB", "qty": 0.4445415239673891, "type": "ENTITLEMENT"}, {"itemId": "RtHFGJRoGW7VBG1V", "itemName": "B2sp2x9mszGGoyhG", "qty": 0.8296439444544509, "type": "STATISTIC"}, {"itemId": "pVdINXzvkSp0Wbvx", "itemName": "QWI0QGCOx7eICkau", "qty": 0.7887278002366627, "type": "ENTITLEMENT"}], "schedule": {"endTime": "1971-09-18T00:00:00Z", "order": 11, "startTime": "1980-10-07T00:00:00Z"}, "tags": ["SnU7d1BuhdwliTSD", "dmGVfegiD3mrVQaU", "r3oT88Dfc7114QFG"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateGoals \
    --challengeCode 'wTzBVDg5v71kGCEt' \
    --code '7h1mVwIQCJmQkvWb' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateGoals' test.out

#- 13 AdminDeleteGoal
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteGoal \
    --challengeCode 'Qrn2W0VkOF0pQOY0' \
    --code 'UCcViiFKNjkT5hcO' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminDeleteGoal' test.out

#- 14 AdminListSchedulesByGoal
$CLI_EXE \
    --sn challenge \
    --op AdminListSchedulesByGoal \
    --challengeCode 'NCaOyATBFgqLeAzv' \
    --code 'dcUEhWRo6ROvbuPQ' \
    --namespace $AB_NAMESPACE \
    --limit '45' \
    --offset '43' \
    --userId 'l9dVfJQGkDR00ofX' \
    > test.out 2>&1
eval_tap $? 14 'AdminListSchedulesByGoal' test.out

#- 15 AdminGetPeriods
$CLI_EXE \
    --sn challenge \
    --op AdminGetPeriods \
    --challengeCode 'sbnEzHiRs0NmGhxv' \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 15 'AdminGetPeriods' test.out

#- 16 AdminRandomizeChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminRandomizeChallenge \
    --challengeCode 'n5VEvIMEB4pl506f' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminRandomizeChallenge' test.out

#- 17 AdminListSchedules
$CLI_EXE \
    --sn challenge \
    --op AdminListSchedules \
    --challengeCode 'LCG6EAl7d3Ks65th' \
    --namespace $AB_NAMESPACE \
    --dateTime '1981-04-20T00:00:00Z' \
    --limit '79' \
    --offset '18' \
    --userId '7QlAlnjAfgxOdZdf' \
    > test.out 2>&1
eval_tap $? 17 'AdminListSchedules' test.out

#- 18 AdminDeleteTiedChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteTiedChallenge \
    --challengeCode '9tLHO1qrNyhmUEAD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteTiedChallenge' test.out

#- 19 AdminUpdateTiedChallengeSchedule
# body param: body
echo '{"action": "ACCELERATE", "endDate": "1984-07-30T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateTiedChallengeSchedule \
    --challengeCode 'netBUGcQz2Wvdicl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateTiedChallengeSchedule' test.out

#- 20 AdminGetAssignmentPlugin
$CLI_EXE \
    --sn challenge \
    --op AdminGetAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminGetAssignmentPlugin' test.out

#- 21 AdminUpdateAssignmentPlugin
# body param: body
echo '{"appName": "kYGDL2ckC9cdzaLn", "extendType": "APP", "grpcServerAddress": "U4hCv5egSQDePKSZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminUpdateAssignmentPlugin' test.out

#- 22 AdminCreateAssignmentPlugin
# body param: body
echo '{"appName": "Kp6zwDQS1atvJrAL", "extendType": "APP", "grpcServerAddress": "tMlpFuJVXo9s0JPG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminCreateAssignmentPlugin' test.out

#- 23 AdminDeleteAssignmentPlugin
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminDeleteAssignmentPlugin' test.out

#- 24 AdminEvaluateProgress
# body param: body
echo '{"userIds": ["8cgjHQo9HoLLyUnP", "TiCD0038or8wR0tu", "wIJnrSI2IFcRwSoM"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminEvaluateProgress \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminEvaluateProgress' test.out

#- 25 AdminClaimUsersRewards
# body param: body
echo '[{"rewardIds": ["TuJziuDNbOydiu3l", "OaruuYw0iUuts6bC", "hMK1gcx8p9fyv5Po"], "userId": "MJeTIQix1FEvzlip"}, {"rewardIds": ["E7r0vhh21v5772Ao", "pmjI7CbY2WuwRUT9", "IivgC4mJ5OHuNEVQ"], "userId": "K4Mvk00I9GqAhhjN"}, {"rewardIds": ["IivdIcaEQfNETQCB", "PK1mYwKVQoydbYjX", "ZyBpqhCJBtFOm3iC"], "userId": "pu0lhhgutt3rQuKP"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUsersRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminClaimUsersRewards' test.out

#- 26 AdminClaimUserRewardsByGoalCode
# body param: body
echo '{"goalCode": "1OEtKFBjNihHU8GP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewardsByGoalCode \
    --challengeCode '8TRVypSvYXKz4BGj' \
    --namespace $AB_NAMESPACE \
    --userId 'bsrRBV8aztJ86yQK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminClaimUserRewardsByGoalCode' test.out

#- 27 AdminGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserProgression \
    --challengeCode '1AsC18UO6JcXmwQf' \
    --namespace $AB_NAMESPACE \
    --userId 'kseTpH6l2Dv8SvqY' \
    --dateTime '1990-06-03T00:00:00Z' \
    --goalCode 'c56PcPSL2xmjViKk' \
    --limit '74' \
    --offset '65' \
    --tags '["w4gHA4CaLsPqRsTd", "KzcKtkGcvn44NWse", "6VLPkM1VTrQBywhJ"]' \
    > test.out 2>&1
eval_tap $? 27 'AdminGetUserProgression' test.out

#- 28 AdminGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserRewards \
    --namespace $AB_NAMESPACE \
    --userId '7lbBLw9xy1WQM5qU' \
    --challengeCode 'S8baUqkzSr41y6RP' \
    --goalProgressionId 'BHJuPjj8zDwOk0Ig' \
    --limit '24' \
    --offset '55' \
    --sortBy 'createdAt:desc' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetUserRewards' test.out

#- 29 AdminClaimUserRewards
# body param: body
echo '{"rewardIDs": ["k19sXDish7KUVhmA", "wmAygsnn8pM7l6v0", "elLMceGGgb5FJHWE"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId '6s13b7dmnPijw6U8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminClaimUserRewards' test.out

#- 30 GetChallenges
$CLI_EXE \
    --sn challenge \
    --op GetChallenges \
    --namespace $AB_NAMESPACE \
    --keyword 'GGp0E886E90E4Zbo' \
    --limit '17' \
    --offset '1' \
    --sortBy 'updatedAt:desc' \
    --status 'INIT' \
    --tags '["1Uy0gArtDpQE4bOt", "oiAjHXcVVOsVywU6", "uisejapftqoxujXD"]' \
    > test.out 2>&1
eval_tap $? 30 'GetChallenges' test.out

#- 31 PublicGetScheduledGoals
$CLI_EXE \
    --sn challenge \
    --op PublicGetScheduledGoals \
    --challengeCode 'osOo2kSUfIA1guTN' \
    --namespace $AB_NAMESPACE \
    --limit '49' \
    --offset '41' \
    --sortBy 'createdAt' \
    --tags '["haejXSV2oH2uH8S4", "Zx0ACteueMOmYP4S", "gxAIQTTKsdmtHu1d"]' \
    > test.out 2>&1
eval_tap $? 31 'PublicGetScheduledGoals' test.out

#- 32 PublicListSchedulesByGoal
$CLI_EXE \
    --sn challenge \
    --op PublicListSchedulesByGoal \
    --challengeCode 'G0us7kIWLcgKgU94' \
    --code '06tdRDqr3cpVbaH6' \
    --namespace $AB_NAMESPACE \
    --limit '29' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 32 'PublicListSchedulesByGoal' test.out

#- 33 PublicListSchedules
$CLI_EXE \
    --sn challenge \
    --op PublicListSchedules \
    --challengeCode 'Z0fCxLR0GfjwCmDr' \
    --namespace $AB_NAMESPACE \
    --dateTime '1971-09-06T00:00:00Z' \
    --limit '11' \
    --offset '90' \
    > test.out 2>&1
eval_tap $? 33 'PublicListSchedules' test.out

#- 34 PublicClaimUserRewardsByGoalCode
# body param: body
echo '{"goalCode": "cmTQjRmV0CPt1LUa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewardsByGoalCode \
    --challengeCode 'TvrFaxzOfG3pTddI' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'PublicClaimUserRewardsByGoalCode' test.out

#- 35 EvaluateMyProgress
$CLI_EXE \
    --sn challenge \
    --op EvaluateMyProgress \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'EvaluateMyProgress' test.out

#- 36 PublicGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserProgression \
    --challengeCode 'A0Rt6wM5oQvTMICt' \
    --namespace $AB_NAMESPACE \
    --dateTime '1995-08-04T00:00:00Z' \
    --goalCode 'yUtVDnhgTGXO8Utp' \
    --limit '46' \
    --offset '91' \
    --tags '["xug8MpqczRvUdK1u", "OV1ZJTYuHpnpVX5u", "4gw4XBXDD7BG73sD"]' \
    > test.out 2>&1
eval_tap $? 36 'PublicGetUserProgression' test.out

#- 37 PublicGetPastUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetPastUserProgression \
    --challengeCode 'dDoXnB8F5X05KUgG' \
    --index '75' \
    --namespace $AB_NAMESPACE \
    --goalCode 'YlOwODWBAz6skHMf' \
    --limit '23' \
    --offset '63' \
    --tags '["4Hjw9KEnx8cNfDK4", "5zWtwYhRoNPwKema", "6caMTOcivPAkmP8A"]' \
    > test.out 2>&1
eval_tap $? 37 'PublicGetPastUserProgression' test.out

#- 38 PublicGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserRewards \
    --namespace $AB_NAMESPACE \
    --challengeCode 'wb0NqtvSR9q6l5k9' \
    --goalProgressionId 'BLQMrPoTuxdzEYAw' \
    --limit '99' \
    --offset '97' \
    --sortBy 'createdAt' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 38 'PublicGetUserRewards' test.out

#- 39 PublicClaimUserRewards
# body param: body
echo '{"rewardIDs": ["ow1WAwCs9Y0KOemh", "NPYUVA9mU8UvONyj", "v3GQuLHoQ6ehLLK5"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicClaimUserRewards' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE