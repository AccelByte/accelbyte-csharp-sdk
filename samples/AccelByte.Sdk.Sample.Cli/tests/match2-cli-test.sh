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
echo "1..40"

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
    --sn match2 \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 GetHealthcheckInfoV1
$CLI_EXE \
    --sn match2 \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 3 'GetHealthcheckInfoV1' test.out

#- 4 AdminGetLogConfig
$CLI_EXE \
    --sn match2 \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 4 'AdminGetLogConfig' test.out

#- 5 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "debug"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateLogConfig' test.out

#- 6 AdminGetAllConfigV1
$CLI_EXE \
    --sn match2 \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAllConfigV1' test.out

#- 7 AdminGetConfigV1
$CLI_EXE \
    --sn match2 \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminGetConfigV1' test.out

#- 8 AdminPatchConfigV1
# body param: body
echo '{"crossPlatformNoCurrentPlatform": true, "extraPlatforms": ["i3wMWnoZgIhwb8YY", "MLqpQwkRRHkaiKsm", "IiRLR3IlNJKxhPfW"], "matchAnyCommon": false, "platformGroup": {"dIabcFbSmeuIBroF": ["7bwRgwKvzESbhpxl", "DdEs4igdKeLmy8tZ", "5GZi5P12c61ts3fM"], "I04rm2jUc9iav3tT": ["qlE9oLDPD0Lfle8E", "SU1MO8XnVaEyjmif", "JDYa1TJPUszmFGEk"], "JVvqDSU3PDyIAGfG": ["q1FNmRWvUvDPnKoE", "CjGUg867xodwuG14", "ID5l5wj6K2wEMnck"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AdminPatchConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminPatchConfigV1' test.out

#- 9 EnvironmentVariableList
$CLI_EXE \
    --sn match2 \
    --op EnvironmentVariableList \
    > test.out 2>&1
eval_tap $? 9 'EnvironmentVariableList' test.out

#- 10 AdminQueryBackfill
$CLI_EXE \
    --sn match2 \
    --op AdminQueryBackfill \
    --namespace $AB_NAMESPACE \
    --fromTime '1975-06-07T00:00:00Z' \
    --isActive 'false' \
    --limit '73' \
    --matchPool 'W6BywsSSZTGlubsm' \
    --offset '16' \
    --playerID 'qhuNtj8FOvKZjs1t' \
    --region 'LpERf77LzPoORBkR' \
    --sessionID 'mZ0A2zyZsb4FvWFI' \
    --toTime '1988-12-08T00:00:00Z' \
    > test.out 2>&1
eval_tap $? 10 'AdminQueryBackfill' test.out

#- 11 CreateBackfill
# body param: body
echo '{"matchPool": "9ro5fHdWqJTNjrmp", "sessionId": "nnEckHH8kT9oXVan"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateBackfill' test.out

#- 12 GetBackfillProposal
$CLI_EXE \
    --sn match2 \
    --op GetBackfillProposal \
    --namespace $AB_NAMESPACE \
    --sessionID 'dercf1nq4Hf32SL5' \
    > test.out 2>&1
eval_tap $? 12 'GetBackfillProposal' test.out

#- 13 GetBackfill
$CLI_EXE \
    --sn match2 \
    --op GetBackfill \
    --backfillID 'PjaYEDxaYN8w9KUW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetBackfill' test.out

#- 14 DeleteBackfill
$CLI_EXE \
    --sn match2 \
    --op DeleteBackfill \
    --backfillID '0py8KrcQfucSq2X8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteBackfill' test.out

#- 15 AcceptBackfill
# body param: body
echo '{"acceptedTicketIds": ["gFuJORk4j04YfnXT", "sQUrA0WWyKl2K5mC", "SoGeQCahcox63cyD"], "proposalId": "xAAYcRXJdoSTxNCK", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID 'AIjNmbfoW8bDq5jP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AcceptBackfill' test.out

#- 16 RejectBackfill
# body param: body
echo '{"proposalId": "qzhN0YdGSrA9LXRw", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID 'LgpQE9nXzhBC0uyM' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'RejectBackfill' test.out

#- 17 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '88' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 17 'MatchFunctionList' test.out

#- 18 CreateMatchFunction
# body param: body
echo '{"match_function": "4Xf2nfYvNvG8uQ14", "serviceAppName": "AhsxaALiBwpNJorn", "url": "rCQpMJj5igqat8xn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateMatchFunction' test.out

#- 19 UpdateMatchFunction
# body param: body
echo '{"match_function": "PoWTdHAkcyAy4drH", "serviceAppName": "lPcXGGl0Xw3veBfr", "url": "pCrnbaxhEvn3SGqc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchFunction \
    --name 'H91fC3aJEoqWaFAG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMatchFunction' test.out

#- 20 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name 'D6PRg95m07l03vtl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'DeleteMatchFunction' test.out

#- 21 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --name '9QjhzDlnJmi4XaBT' \
    --offset '13' \
    > test.out 2>&1
eval_tap $? 21 'MatchPoolList' test.out

#- 22 CreateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 30, "backfill_ticket_expiration_seconds": 52, "best_latency_calculation_method": "XjfdUQHa3RxspSqw", "crossplay_disabled": false, "match_function": "Zm9K3cMY617HSCYZ", "match_function_override": {"backfill_matches": "aL46I3PgCcQ0axTW", "enrichment": ["nmyEYLZQTpvLH6QP", "EBP8kSSFjeuL3wQQ", "PYwmYFbxRvHYDCYw"], "make_matches": "oGdmzXgf1ewUTvnu", "stat_codes": ["0ensa3MZF7DTswnk", "SyuJTVjKQ1ORLEIA", "ePvDO2xkVgyRk10b"], "validation": ["27RdU8VceYQ9erPY", "Q5yVcQuvDbGMqbEH", "kCQwMBcQUNPHN8YZ"]}, "name": "T0yJJ0uCjjaNCRV3", "platform_group_enabled": false, "rule_set": "GtZ83Jp2f9f1FCoI", "session_template": "o3L24DKGwgZ85vyF", "ticket_expiration_seconds": 73}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreateMatchPool' test.out

#- 23 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool 'OrPH6ZsjpPgHKISH' \
    > test.out 2>&1
eval_tap $? 23 'MatchPoolDetails' test.out

#- 24 UpdateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": true, "backfill_proposal_expiration_seconds": 72, "backfill_ticket_expiration_seconds": 57, "best_latency_calculation_method": "dzYS9K0VvwE6MAqP", "crossplay_disabled": false, "match_function": "nXO45AUtNXSTItt3", "match_function_override": {"backfill_matches": "5OJTfJBZX62yI9g5", "enrichment": ["RDrlzPFQmNu3ERxV", "0UTaiSzfi0FnBERe", "8qNYRTYSaZw4NqSN"], "make_matches": "ylcljuNM3eUUSD1p", "stat_codes": ["ZGMfPdGIOAZ86un0", "L98WUoXvfU4qMIpf", "gxw2ff5twRYbtdK2"], "validation": ["r4wWs6IpYBxafo9b", "4xJyNnvHKrm8UuNl", "T86N9yO0vyD6J5br"]}, "platform_group_enabled": false, "rule_set": "AtizV9hzsVbpJLtE", "session_template": "ZjuyFhvbxX2DNbkn", "ticket_expiration_seconds": 10}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'XCiaXP8jBjK81t2V' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'UpdateMatchPool' test.out

#- 25 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool '9TVauFcGkPgQ0hb2' \
    > test.out 2>&1
eval_tap $? 25 'DeleteMatchPool' test.out

#- 26 MatchPoolMetric
$CLI_EXE \
    --sn match2 \
    --op MatchPoolMetric \
    --namespace $AB_NAMESPACE \
    --pool 'tLrsMeoZiRYkbhEM' \
    > test.out 2>&1
eval_tap $? 26 'MatchPoolMetric' test.out

#- 27 PostMatchErrorMetric
# body param: body
echo '{"type": "connectDS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op PostMatchErrorMetric \
    --namespace $AB_NAMESPACE \
    --pool 'zTNY3lpincuf5d5s' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'PostMatchErrorMetric' test.out

#- 28 GetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op GetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'aQvKfFRqBam8jPtK' \
    > test.out 2>&1
eval_tap $? 28 'GetPlayerMetric' test.out

#- 29 AdminGetMatchPoolTickets
$CLI_EXE \
    --sn match2 \
    --op AdminGetMatchPoolTickets \
    --namespace $AB_NAMESPACE \
    --pool 'HTmzo0JmcQmnsUig' \
    --limit '98' \
    --offset '94' \
    > test.out 2>&1
eval_tap $? 29 'AdminGetMatchPoolTickets' test.out

#- 30 CreateMatchTicket
# body param: body
echo '{"attributes": {"ynjGFyVicGQAVv32": {}, "ftRAsmC0RuRA8j1A": {}, "J3hNWWhADRqJvaZr": {}}, "excludedSessions": ["f2qXQFCzRV1paELj", "5dw3LK0gPYhPPG5s", "AIfYtYozA2OntGCw"], "latencies": {"QSHHdPLwjTngrvb2": 62, "8oLyErKvRtHFGJRo": 67, "x5bIk8pVpxdUWOPe": 24}, "matchPool": "zGGoyhGZAzt2OVBT", "sessionID": "LwSH8hWRU9pbItGQ", "storage": {"7VUWBhGolwafIfbF": {}, "1GLFnrQ4T5cmw7U1": {}, "TxiS06UEoaDZpXOW": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'CreateMatchTicket' test.out

#- 31 GetMyMatchTickets
$CLI_EXE \
    --sn match2 \
    --op GetMyMatchTickets \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --matchPool '88Dfc7114QFGwTzB' \
    --offset '97' \
    > test.out 2>&1
eval_tap $? 31 'GetMyMatchTickets' test.out

#- 32 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'j2IzU3MEpCt1Ijlf' \
    > test.out 2>&1
eval_tap $? 32 'MatchTicketDetails' test.out

#- 33 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid 'HJM92t9j1XT2ErwI' \
    > test.out 2>&1
eval_tap $? 33 'DeleteMatchTicket' test.out

#- 34 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '49' \
    --name '0VkOF0pQOY0UCcVi' \
    --offset '16' \
    > test.out 2>&1
eval_tap $? 34 'RuleSetList' test.out

#- 35 CreateRuleSet
# body param: body
echo '{"data": {"OS4XKVT66sHYPgVs": {}, "fhoEidKw4IP0NVna": {}, "angorhVFpTRuQyMr": {}}, "enable_custom_match_function": false, "name": "JQGkDR00ofXsbnEz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CreateRuleSet' test.out

#- 36 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset 'HiRs0NmGhxv1vuN7' \
    > test.out 2>&1
eval_tap $? 36 'RuleSetDetails' test.out

#- 37 UpdateRuleSet
# body param: body
echo '{"data": {"Xv6OuG6RR1jPh8Rb": {}, "lvnfNiABRf1gdXM7": {}, "QlAlnjAfgxOdZdf9": {}}, "enable_custom_match_function": true, "name": "2CAlSxxVhDR9hlaz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'netBUGcQz2Wvdicl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateRuleSet' test.out

#- 38 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'kYGDL2ckC9cdzaLn' \
    > test.out 2>&1
eval_tap $? 38 'DeleteRuleSet' test.out

#- 39 PublicGetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op PublicGetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'ajQ8GnJpALiddv9U' \
    > test.out 2>&1
eval_tap $? 39 'PublicGetPlayerMetric' test.out

#- 40 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 40 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE