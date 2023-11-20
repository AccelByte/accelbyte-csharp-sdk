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
echo "1..32"

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

#- 4 EnvironmentVariableList
$CLI_EXE \
    --sn match2 \
    --op EnvironmentVariableList \
    > test.out 2>&1
eval_tap $? 4 'EnvironmentVariableList' test.out

#- 5 CreateBackfill
# body param: body
echo '{"matchPool": "bBuz5zkoaUEzGS3q", "sessionId": "Zf0PbemSBELbZ0VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateBackfill' test.out

#- 6 GetBackfillProposal
$CLI_EXE \
    --sn match2 \
    --op GetBackfillProposal \
    --namespace $AB_NAMESPACE \
    --sessionID 'UGA7nkDeev2Oj060' \
    > test.out 2>&1
eval_tap $? 6 'GetBackfillProposal' test.out

#- 7 GetBackfill
$CLI_EXE \
    --sn match2 \
    --op GetBackfill \
    --backfillID 'HnOf5S8X1LxkZs42' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetBackfill' test.out

#- 8 DeleteBackfill
$CLI_EXE \
    --sn match2 \
    --op DeleteBackfill \
    --backfillID '33oQWoXFeqeuI2oM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'DeleteBackfill' test.out

#- 9 AcceptBackfill
# body param: body
echo '{"proposalId": "J0cgAoGfXepE3r5A", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID 'BqS8KtTYZLJ58Qqc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AcceptBackfill' test.out

#- 10 RejectBackfill
# body param: body
echo '{"proposalId": "V3IcuNs9MF5BT2KD", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID 'yrWorpC65VJh4q1z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'RejectBackfill' test.out

#- 11 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '95' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 11 'MatchFunctionList' test.out

#- 12 CreateMatchFunction
# body param: body
echo '{"match_function": "1MO8XnVaEyjmifJD", "serviceAppName": "Ya1TJPUszmFGEkJV", "url": "vqDSU3PDyIAGfGq1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'CreateMatchFunction' test.out

#- 13 UpdateMatchFunction
# body param: body
echo '{"match_function": "FNmRWvUvDPnKoECj", "serviceAppName": "GUg867xodwuG14ID", "url": "5l5wj6K2wEMnckjl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchFunction \
    --name 'W6BywsSSZTGlubsm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateMatchFunction' test.out

#- 14 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name 'hjXcScOUvrjJBO7t' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteMatchFunction' test.out

#- 15 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --name 'LpERf77LzPoORBkR' \
    --offset '25' \
    > test.out 2>&1
eval_tap $? 15 'MatchPoolList' test.out

#- 16 CreateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 0, "backfill_ticket_expiration_seconds": 55, "match_function": "Fy0pJYCdfkfyt09r", "match_function_override": {"backfill_matches": "o5fHdWqJTNjrmpnn", "enrichment": ["EckHH8kT9oXVande", "rcf1nq4Hf32SL5Pj", "aYEDxaYN8w9KUW0p"], "make_matches": "y8KrcQfucSq2X8gF", "stat_codes": ["uJORk4j04YfnXTsQ", "UrA0WWyKl2K5mCSo", "GeQCahcox63cyDxA"], "validation": ["AYcRXJdoSTxNCK9A", "IjNmbfoW8bDq5jPq", "zhN0YdGSrA9LXRwU"]}, "name": "6WLgpQE9nXzhBC0u", "rule_set": "yMR4Xf2nfYvNvG8u", "session_template": "Q14AhsxaALiBwpNJ", "ticket_expiration_seconds": 30}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'CreateMatchPool' test.out

#- 17 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool 'dq0m7NjUZ95Z5XDL' \
    > test.out 2>&1
eval_tap $? 17 'MatchPoolDetails' test.out

#- 18 UpdateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": true, "backfill_proposal_expiration_seconds": 48, "backfill_ticket_expiration_seconds": 82, "match_function": "nPoWTdHAkcyAy4dr", "match_function_override": {"backfill_matches": "HlPcXGGl0Xw3veBf", "enrichment": ["rpCrnbaxhEvn3SGq", "cH91fC3aJEoqWaFA", "GD6PRg95m07l03vt"], "make_matches": "lMFzeiMRkcOr1L0T", "stat_codes": ["MIczbYilOziwG8CP", "LOzSZm9K3cMY617H", "SCYZaL46I3PgCcQ0"], "validation": ["axTWnmyEYLZQTpvL", "H6QPEBP8kSSFjeuL", "3wQQPYwmYFbxRvHY"]}, "rule_set": "DCYwoGdmzXgf1ewU", "session_template": "Tvnu0ensa3MZF7DT", "ticket_expiration_seconds": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'eAaGq0NIj53gXkmr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchPool' test.out

#- 19 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'ayvcIYiWxIAxfvLz' \
    > test.out 2>&1
eval_tap $? 19 'DeleteMatchPool' test.out

#- 20 MatchPoolMetric
$CLI_EXE \
    --sn match2 \
    --op MatchPoolMetric \
    --namespace $AB_NAMESPACE \
    --pool 'SpDFY3lxe16KsSRz' \
    > test.out 2>&1
eval_tap $? 20 'MatchPoolMetric' test.out

#- 21 GetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op GetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'kf2HzBcEio5UyvuF' \
    > test.out 2>&1
eval_tap $? 21 'GetPlayerMetric' test.out

#- 22 AdminGetMatchPoolTickets
$CLI_EXE \
    --sn match2 \
    --op AdminGetMatchPoolTickets \
    --namespace $AB_NAMESPACE \
    --pool 'v5z6wosJGnUyCMEb' \
    --limit '69' \
    --offset '16' \
    > test.out 2>&1
eval_tap $? 22 'AdminGetMatchPoolTickets' test.out

#- 23 CreateMatchTicket
# body param: body
echo '{"attributes": {"YZT0yJJ0uCjjaNCR": {}, "V3hSIiTEoTCSxjAq": {}, "g9oGVEdC8mQir1Af": {}}, "latencies": {"0G6OrPH6ZsjpPgHK": 71, "plLJdzYS9K0VvwE6": 80, "R0vknXO45AUtNXST": 72}, "matchPool": "QIXVmrtRlq1jv60H", "sessionID": "TnmFrl3gYx6Xmv1D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'CreateMatchTicket' test.out

#- 24 GetMyMatchTickets
$CLI_EXE \
    --sn match2 \
    --op GetMyMatchTickets \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --matchPool 'RxV0UTaiSzfi0FnB' \
    --offset '63' \
    > test.out 2>&1
eval_tap $? 24 'GetMyMatchTickets' test.out

#- 25 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'TYM95e4aa8xOJu7r' \
    > test.out 2>&1
eval_tap $? 25 'MatchTicketDetails' test.out

#- 26 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid 'NRVdygfKmUkzj9mH' \
    > test.out 2>&1
eval_tap $? 26 'DeleteMatchTicket' test.out

#- 27 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '65' \
    --name '1pZGMfPdGIOAZ86u' \
    --offset '27' \
    > test.out 2>&1
eval_tap $? 27 'RuleSetList' test.out

#- 28 CreateRuleSet
# body param: body
echo '{"data": {"Exv9nKMOgO5W8SUa": {}, "ZjCpNtJSMm8kDi3R": {}, "wubq7wtRGdT447Oa": {}}, "enable_custom_match_function": false, "name": "1m6VLfjsw270pMmO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'CreateRuleSet' test.out

#- 29 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset 'QJrpEBbVvBn8Lsf2' \
    > test.out 2>&1
eval_tap $? 29 'RuleSetDetails' test.out

#- 30 UpdateRuleSet
# body param: body
echo '{"data": {"qSAtizV9hzsVbpJL": {}, "tEZjuyFhvbxX2DNb": {}, "knfVv4nm70TCayYA": {}}, "enable_custom_match_function": false, "name": "2V9TVauFcGkPgQ0h"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'b2tLrsMeoZiRYkbh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateRuleSet' test.out

#- 31 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'EM1zTNY3lpincuf5' \
    > test.out 2>&1
eval_tap $? 31 'DeleteRuleSet' test.out

#- 32 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 32 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE