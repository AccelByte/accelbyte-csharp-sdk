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

#- 2 GetHealthcheckInfo
$CLI_EXE \
    --sn sessionhistory \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 GetHealthcheckInfoV1
$CLI_EXE \
    --sn sessionhistory \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 3 'GetHealthcheckInfoV1' test.out

#- 4 AdminGetEnvConfig
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetEnvConfig \
    > test.out 2>&1
eval_tap $? 4 'AdminGetEnvConfig' test.out

#- 5 AdminPatchUpdateEnvConfig
# body param: body
echo '{"SESSION_DELETION_GRACE_PERIOD": 2}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionhistory \
    --op AdminPatchUpdateEnvConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateEnvConfig' test.out

#- 6 AdminGetLogConfig
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 6 'AdminGetLogConfig' test.out

#- 7 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "warning"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionhistory \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminPatchUpdateLogConfig' test.out

#- 8 AdminQueryGameSessionDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryGameSessionDetail \
    --namespace $AB_NAMESPACE \
    --completedOnly 'Buz5zkoaUEzGS3qZ' \
    --configurationName 'f0PbemSBELbZ0VBU' \
    --dsPodName 'GA7nkDeev2Oj060H' \
    --endDate 'nOf5S8X1LxkZs423' \
    --gameSessionID '3oQWoXFeqeuI2oMJ' \
    --isPersistent '0cgAoGfXepE3r5AQ' \
    --joinability 'UBqS8KtTYZLJ58Qq' \
    --limit '4' \
    --matchPool 'fMI04rm2jUc9iav3' \
    --offset '41' \
    --order '18yrWorpC65VJh4q' \
    --orderBy '1z1KJmKedBfbWvKa' \
    --startDate '5Ou124TsbQsxYFxG' \
    --statusV2 'GHrfQkgXkiA5IZPq' \
    --userID 'Cqp9vcyt67WAfWXf' \
    > test.out 2>&1
eval_tap $? 8 'AdminQueryGameSessionDetail' test.out

#- 9 GetGameSessionDetail
$CLI_EXE \
    --sn sessionhistory \
    --op GetGameSessionDetail \
    --namespace $AB_NAMESPACE \
    --sessionId 'UfwGB03tz8qIH4uR' \
    > test.out 2>&1
eval_tap $? 9 'GetGameSessionDetail' test.out

#- 10 AdminQueryMatchmakingDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryMatchmakingDetail \
    --namespace $AB_NAMESPACE \
    --gameSessionID 'dNO08HN6s9p8Y5c9' \
    --limit '8' \
    --offset '22' \
    --order 'ItJtiNmY3y3n2Rim' \
    --orderBy '4NBqhuNtj8FOvKZj' \
    --ticketID 's1tLpERf77LzPoOR' \
    --userID 'BkRmZ0A2zyZsb4Fv' \
    > test.out 2>&1
eval_tap $? 10 'AdminQueryMatchmakingDetail' test.out

#- 11 AdminGetMatchmakingDetailBySessionID
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetMatchmakingDetailBySessionID \
    --namespace $AB_NAMESPACE \
    --sessionId 'WFIHPIbOjpls9BZT' \
    > test.out 2>&1
eval_tap $? 11 'AdminGetMatchmakingDetailBySessionID' test.out

#- 12 AdminGetMatchmakingDetailByTicketID
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetMatchmakingDetailByTicketID \
    --namespace $AB_NAMESPACE \
    --ticketId 'Yc5BsdSSVaAzzn4G' \
    > test.out 2>&1
eval_tap $? 12 'AdminGetMatchmakingDetailByTicketID' test.out

#- 13 AdminQueryPartyDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryPartyDetail \
    --namespace $AB_NAMESPACE \
    --endDate 'bgkKeCaS6qyUCscH' \
    --joinability 'Xs8PlOBlfUOqv7Wm' \
    --leaderID 'CuqcsNM7YAnbq4Dj' \
    --limit '26' \
    --offset '34' \
    --order 'YUMhD9qU89D356pV' \
    --orderBy 'sUtNanddzgwxYdQc' \
    --partyID '5hEfefdopcEM0JHf' \
    --startDate 'of2Hwi7vg3osbh0f' \
    --userID 'L2h7eJvAS2W4uqkh' \
    > test.out 2>&1
eval_tap $? 13 'AdminQueryPartyDetail' test.out

#- 14 GetPartyDetail
$CLI_EXE \
    --sn sessionhistory \
    --op GetPartyDetail \
    --namespace $AB_NAMESPACE \
    --sessionId 'wSC7EajwHO3LfvwP' \
    > test.out 2>&1
eval_tap $? 14 'GetPartyDetail' test.out

#- 15 AdminQueryTicketDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryTicketDetail \
    --namespace $AB_NAMESPACE \
    --endDate 'ewrf19Njm50xCDlP' \
    --gameMode 'eNq0CvMXtyUWXrdZ' \
    --limit '0' \
    --offset '81' \
    --order 'FeacGT2x6o28Njxy' \
    --partyID 'w7RHldq0m7NjUZ95' \
    --region 'Z5XDLBN9YGVPtkjt' \
    --startDate '0OyBlJi4RbZ0Iy11' \
    --userIDs 'mfOFjCzZVcGomWF1' \
    > test.out 2>&1
eval_tap $? 15 'AdminQueryTicketDetail' test.out

#- 16 AdminTicketDetailGetByTicketID
$CLI_EXE \
    --sn sessionhistory \
    --op AdminTicketDetailGetByTicketID \
    --namespace $AB_NAMESPACE \
    --ticketId 'oAqUNFDtXnXLvOAs' \
    > test.out 2>&1
eval_tap $? 16 'AdminTicketDetailGetByTicketID' test.out

#- 17 PublicQueryGameSessionMe
$CLI_EXE \
    --sn sessionhistory \
    --op PublicQueryGameSessionMe \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '29' \
    --order '8wYh4gq7pRVZVLJi' \
    > test.out 2>&1
eval_tap $? 17 'PublicQueryGameSessionMe' test.out

#- 18 QueryXrayMatchPool
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayMatchPool \
    --namespace $AB_NAMESPACE \
    --poolName '["Dx3au9b9QjhzDlnJ", "mi4XaBTgoXjfdUQH", "a3RxspSqwdbTR2sg"]' \
    --endDate 'zfaQrUCW9fgo69uv' \
    --startDate '1bkFx8DmbC9UqYdY' \
    > test.out 2>&1
eval_tap $? 18 'QueryXrayMatchPool' test.out

#- 19 QueryDetailTickMatchPool
$CLI_EXE \
    --sn sessionhistory \
    --op QueryDetailTickMatchPool \
    --namespace $AB_NAMESPACE \
    --podName 'rdxNnuMcAwrSzYnr' \
    --poolName 'cetxObeisZelKuD0' \
    --all 'false' \
    --limit '49' \
    --offset '72' \
    --endDate 'RvHYDCYwoGdmzXgf' \
    --startDate '1ewUTvnu0ensa3MZ' \
    > test.out 2>&1
eval_tap $? 19 'QueryDetailTickMatchPool' test.out

#- 20 QueryDetailTickMatchPoolMatches
$CLI_EXE \
    --sn sessionhistory \
    --op QueryDetailTickMatchPoolMatches \
    --namespace $AB_NAMESPACE \
    --podName 'F7DTswnkSyuJTVjK' \
    --poolName 'Q1ORLEIAePvDO2xk' \
    --tickId 'VgyRk10b27RdU8Vc' \
    > test.out 2>&1
eval_tap $? 20 'QueryDetailTickMatchPoolMatches' test.out

#- 21 QueryDetailTickMatchPoolTicket
$CLI_EXE \
    --sn sessionhistory \
    --op QueryDetailTickMatchPoolTicket \
    --namespace $AB_NAMESPACE \
    --podName 'eYQ9erPYQ5yVcQuv' \
    --poolName 'DbGMqbEHkCQwMBcQ' \
    --tickId 'UNPHN8YZT0yJJ0uC' \
    > test.out 2>&1
eval_tap $? 21 'QueryDetailTickMatchPoolTicket' test.out

#- 22 QueryMatchHistories
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchHistories \
    --matchId 'jjaNCRV3hSIiTEoT' \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '11' \
    > test.out 2>&1
eval_tap $? 22 'QueryMatchHistories' test.out

#- 23 QueryMatchTicketHistories
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchTicketHistories \
    --matchId 'SxjAqg9oGVEdC8mQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'QueryMatchTicketHistories' test.out

#- 24 QueryXrayMatch
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayMatch \
    --matchId 'ir1Af0G6OrPH6Zsj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'QueryXrayMatch' test.out

#- 25 QueryAcquiringDS
$CLI_EXE \
    --sn sessionhistory \
    --op QueryAcquiringDS \
    --namespace $AB_NAMESPACE \
    --matchPool '["pPgHKISHtB8tWdJM", "9Qc5HmR0vknXO45A", "UtNXSTItt35OJTfJ"]' \
    --endDate 'BZX62yI9g5RDrlzP' \
    --startDate 'FQmNu3ERxV0UTaiS' \
    > test.out 2>&1
eval_tap $? 25 'QueryAcquiringDS' test.out

#- 26 QueryAcquiringDSWaitTimeAvg
$CLI_EXE \
    --sn sessionhistory \
    --op QueryAcquiringDSWaitTimeAvg \
    --namespace $AB_NAMESPACE \
    --matchPool '["zfi0FnBERe8qNYRT", "YSaZw4NqSNylclju", "NM3eUUSD1pZGMfPd"]' \
    --endDate 'GIOAZ86un0L98WUo' \
    --startDate 'XvfU4qMIpfgxw2ff' \
    > test.out 2>&1
eval_tap $? 26 'QueryAcquiringDSWaitTimeAvg' test.out

#- 27 QueryMatchLengthDurationpAvg
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchLengthDurationpAvg \
    --namespace $AB_NAMESPACE \
    --matchPool '["5twRYbtdK2r4wWs6", "IpYBxafo9b4xJyNn", "vHKrm8UuNlT86N9y"]' \
    --endDate 'O0vyD6J5brVo20e6' \
    --startDate 'POTjrinAVVovpAAX' \
    > test.out 2>&1
eval_tap $? 27 'QueryMatchLengthDurationpAvg' test.out

#- 28 QueryMatchLengthDurationp99
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchLengthDurationp99 \
    --namespace $AB_NAMESPACE \
    --matchPool '["NzcpbmX3lLFeXCia", "XP8jBjK81t2V9TVa", "uFcGkPgQ0hb2tLrs"]' \
    --endDate 'MeoZiRYkbhEM1zTN' \
    --startDate 'Y3lpincuf5d5saQv' \
    > test.out 2>&1
eval_tap $? 28 'QueryMatchLengthDurationp99' test.out

#- 29 QueryTotalActiveSession
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalActiveSession \
    --namespace $AB_NAMESPACE \
    --matchPool '["KfFRqBam8jPtKHTm", "zo0JmcQmnsUigVyn", "jGFyVicGQAVv32ft"]' \
    --region 'RAsmC0RuRA8j1AJ3' \
    --endDate 'hNWWhADRqJvaZrf2' \
    --startDate 'qXQFCzRV1paELj5d' \
    > test.out 2>&1
eval_tap $? 29 'QueryTotalActiveSession' test.out

#- 30 QueryTotalMatchmakingMatch
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingMatch \
    --namespace $AB_NAMESPACE \
    --matchPool '["w3LK0gPYhPPG5sAI", "fYtYozA2OntGCwQS", "HHdPLwjTngrvb2E1"]' \
    --endDate 'X9ecBBhRAYjR7c4x' \
    --startDate '5bIk8pVpxdUWOPel' \
    > test.out 2>&1
eval_tap $? 30 'QueryTotalMatchmakingMatch' test.out

#- 31 QueryTotalPlayerPersession
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalPlayerPersession \
    --namespace $AB_NAMESPACE \
    --matchPool '["3TiwTycqpVdINXzv", "kSp0WbvxQWI0QGCO", "x7eICkauWbFrSnU7"]' \
    --endDate 'd1BuhdwliTSDdmGV' \
    --startDate 'fegiD3mrVQaUr3oT' \
    > test.out 2>&1
eval_tap $? 31 'QueryTotalPlayerPersession' test.out

#- 32 QueryTotalMatchmakingCanceled
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingCanceled \
    --namespace $AB_NAMESPACE \
    --matchPool '["88Dfc7114QFGwTzB", "VDg5v71kGCEt7h1m", "VwIQCJmQkvWbQrn2"]' \
    --endDate 'W0VkOF0pQOY0UCcV' \
    --startDate 'iiFKNjkT5hcONCaO' \
    > test.out 2>&1
eval_tap $? 32 'QueryTotalMatchmakingCanceled' test.out

#- 33 QueryTotalMatchmakingCreated
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingCreated \
    --namespace $AB_NAMESPACE \
    --matchPool '["yATBFgqLeAzvdcUE", "hWRo6ROvbuPQwl9d", "VfJQGkDR00ofXsbn"]' \
    --endDate 'EzHiRs0NmGhxv1vu' \
    --startDate 'N7Xv6OuG6RR1jPh8' \
    > test.out 2>&1
eval_tap $? 33 'QueryTotalMatchmakingCreated' test.out

#- 34 QueryTotalMatchmakingExpired
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingExpired \
    --namespace $AB_NAMESPACE \
    --matchPool '["RblvnfNiABRf1gdX", "M7QlAlnjAfgxOdZd", "f9tLHO1qrNyhmUEA"]' \
    --endDate 'DczzrL31HuYKsCBB' \
    --startDate 'gwb1hGjHJgxrcEvn' \
    > test.out 2>&1
eval_tap $? 34 'QueryTotalMatchmakingExpired' test.out

#- 35 QueryTotalMatchmakingMatchTicket
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingMatchTicket \
    --namespace $AB_NAMESPACE \
    --matchPool '["fJqU4hCv5egSQDeP", "KSZKp6zwDQS1atvJ", "rALaiplJgRhedl5E"]' \
    --endDate 'wh3jDayYStUiBB1y' \
    --startDate 'z3iP8gH88UenlMVz' \
    > test.out 2>&1
eval_tap $? 35 'QueryTotalMatchmakingMatchTicket' test.out

#- 36 CreateXrayTicketObservability
# body param: body
echo '{"action": "IOP8NOf91LsD7cWW", "activeAllianceRule": {"max_number": 83, "min_number": 91, "player_max_number": 13, "player_min_number": 30}, "activeMatchingRule": [{"attribute": "As8ThMpAGIapYftY", "criteria": "ZkBXiEhdiS41VBAE", "reference": 0.7460710067600284}, {"attribute": "voBlbH02bobxtljI", "criteria": "fHBgjP9onbxFcxS2", "reference": 0.6531359366084184}, {"attribute": "ZZfXO3HkJTOPscPA", "criteria": "2n25C1zEnAMGmFy7", "reference": 0.3666669066505911}], "function": "6eqnMeKFo7U8Scr9", "gameMode": "xm68w7s9RMx2hc45", "isBackfillMatch": true, "isRuleSetFlexed": false, "iteration": 70, "matchID": "34xnqlbRAPFQsca6", "namespace": "n9vGZTCCXQ2Lf7jt", "remainingPlayersPerTicket": [9, 16, 48], "remainingTickets": 58, "sessionTickID": "B613cbiJEUePVZQa", "tickID": 30, "ticketID": "utt3rQuKP1OEtKFB", "timeToMatchSec": 0.14623492141809358, "timestamp": "1991-03-06T00:00:00Z", "unbackfillReason": "vMiR3QYZJKVNlK8P", "unmatchReason": "TaIXRWFTyA9MDnKG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionhistory \
    --op CreateXrayTicketObservability \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'CreateXrayTicketObservability' test.out

#- 37 CreateXrayBulkTicketObservability
# body param: body
echo '{"ticketObservabilities": [{"action": "Xqq7Zk705hOhenJi", "activeAllianceRule": {"max_number": 5, "min_number": 7, "player_max_number": 82, "player_min_number": 26}, "activeMatchingRule": [{"attribute": "VF7zwjXqlcD2LzaO", "criteria": "wIF5tEsCwoAVcZCS", "reference": 0.15955200621118992}, {"attribute": "80gzFvpvIerFEyxT", "criteria": "ugoTd50RmJFX9v4G", "reference": 0.6697896542569026}, {"attribute": "fyGuQ2UEl0U5Z9Un", "criteria": "QmZqX15hBb4dlNTI", "reference": 0.4471600423089622}], "function": "DtHunwNLLfKCQKuu", "gameMode": "2MWXpEpNjHWPcFSn", "isBackfillMatch": false, "isRuleSetFlexed": false, "iteration": 55, "matchID": "YfUTpFzyQhPVhRGX", "namespace": "9xlUKhXI8mL8OIhv", "remainingPlayersPerTicket": [85, 10, 24], "remainingTickets": 47, "sessionTickID": "LMceGGgb5FJHWE6s", "tickID": 70, "ticketID": "3b7dmnPijw6U8GGp", "timeToMatchSec": 0.8459909687230133, "timestamp": "1986-09-04T00:00:00Z", "unbackfillReason": "86E90E4ZboiXT1Uy", "unmatchReason": "0gArtDpQE4bOtoiA"}, {"action": "jHXcVVOsVywU6uis", "activeAllianceRule": {"max_number": 9, "min_number": 20, "player_max_number": 1, "player_min_number": 24}, "activeMatchingRule": [{"attribute": "pftqoxujXDosOo2k", "criteria": "SUfIA1guTNx7haej", "reference": 0.7937111593788841}, {"attribute": "SV2oH2uH8S4Zx0AC", "criteria": "teueMOmYP4SgxAIQ", "reference": 0.7364853697022741}, {"attribute": "TKsdmtHu1dG0us7k", "criteria": "IWLcgKgU9406tdRD", "reference": 0.2647004760563171}], "function": "r3cpVbaH69NyTfGE", "gameMode": "59942bCwgpzUfcmT", "isBackfillMatch": false, "isRuleSetFlexed": false, "iteration": 48, "matchID": "RmV0CPt1LUaTvrFa", "namespace": "xzOfG3pTddIA0Rt6", "remainingPlayersPerTicket": [47, 39, 79], "remainingTickets": 29, "sessionTickID": "5oQvTMICtWyUtVDn", "tickID": 14, "ticketID": "WmOoMyYp2tSrLxpJ", "timeToMatchSec": 0.21955879234231113, "timestamp": "1975-01-20T00:00:00Z", "unbackfillReason": "9JtgjWmjx1WuNQq4", "unmatchReason": "v8FnVzdbNW1xuV7r"}, {"action": "Vei1o9zV6rhVfcQm", "activeAllianceRule": {"max_number": 77, "min_number": 11, "player_max_number": 62, "player_min_number": 28}, "activeMatchingRule": [{"attribute": "5KUgGKfDSGh3vQFP", "criteria": "SYCi8WEjR3wqpnMd", "reference": 0.7174368950712362}, {"attribute": "Nskxhl3O3kGloooh", "criteria": "7kL598P7F3IKhiNd", "reference": 0.38354720296610123}, {"attribute": "1V7199NT7JTRFV3F", "criteria": "xMl5Rw4YeHqWkG09", "reference": 0.14317059888506045}], "function": "EAFYWhow1WAwCs9Y", "gameMode": "0KOemhNPYUVA9mU8", "isBackfillMatch": true, "isRuleSetFlexed": false, "iteration": 82, "matchID": "Zfx0Xa6sgegAWYz2", "namespace": "z4qSPPQBDFQsvRHb", "remainingPlayersPerTicket": [67, 91, 93], "remainingTickets": 59, "sessionTickID": "C2ynue7Xk4uDF5md", "tickID": 1, "ticketID": "HIFfwBBqG51RaZY7", "timeToMatchSec": 0.9084708493303569, "timestamp": "1985-05-16T00:00:00Z", "unbackfillReason": "gXyFuLFZViQbxYQv", "unmatchReason": "Uyapo6FmMy6tZYSC"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionhistory \
    --op CreateXrayBulkTicketObservability \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'CreateXrayBulkTicketObservability' test.out

#- 38 QueryXrayTimelineByTicketID
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayTimelineByTicketID \
    --namespace $AB_NAMESPACE \
    --ticketId 'e7du68Ce6T4pYH3B' \
    --limit '85' \
    --offset '99' \
    --endDate 'yFurT4p8zoRYG8WK' \
    --startDate 'TaUyB0UyrKKulHUn' \
    > test.out 2>&1
eval_tap $? 38 'QueryXrayTimelineByTicketID' test.out

#- 39 QueryXrayTimelineByUserID
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayTimelineByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'ompTrS7DIOakX65w' \
    --limit '25' \
    --offset '90' \
    --order 'a57V6b9uLloAA9Ko' \
    --orderBy 'etyNPkgWcTCN7aBI' \
    --endDate 'FfeRdnHpse2T7eZw' \
    --startDate 'kVrB3GSEmVq8CjR5' \
    > test.out 2>&1
eval_tap $? 39 'QueryXrayTimelineByUserID' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE