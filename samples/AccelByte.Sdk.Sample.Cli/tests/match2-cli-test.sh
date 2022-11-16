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
echo "1..23"

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

#- 4 CreateBackfill
# body param: body
echo '{"matchPool": "KjwCxr1e", "sessionId": "HaMcmk9E"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'CreateBackfill' test.out

#- 5 AcceptBackfill
# body param: body
echo '{"proposalId": "fKHq8efu", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID 'G1ArraFD' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AcceptBackfill' test.out

#- 6 RejectBackfill
# body param: body
echo '{"proposalId": "O2MSBXDv", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID 'Cke3stLC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'RejectBackfill' test.out

#- 7 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '9' \
    --offset '11' \
    > test.out 2>&1
eval_tap $? 7 'MatchFunctionList' test.out

#- 8 CreateMatchFunction
# body param: body
echo '{"match_function": "gxzZyHvC", "url": "o8sxoe7v"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'CreateMatchFunction' test.out

#- 9 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name 'fYPtidF7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteMatchFunction' test.out

#- 10 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '19' \
    --offset '13' \
    > test.out 2>&1
eval_tap $? 10 'MatchPoolList' test.out

#- 11 CreateMatchPool
# body param: body
echo '{"backfill_ticket_expiration_seconds": 13, "match_function": "y0gCcmDw", "name": "I290EPmJ", "rule_set": "PnFvHVSN", "session_template": "49LtxAX0", "ticket_expiration_seconds": 33}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateMatchPool' test.out

#- 12 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool 'pkUP0471' \
    > test.out 2>&1
eval_tap $? 12 'MatchPoolDetails' test.out

#- 13 UpdateMatchPool
# body param: body
echo '{"backfill_ticket_expiration_seconds": 73, "match_function": "qMGxlPm6", "rule_set": "xfnpqWGG", "session_template": "EqPesSuA", "ticket_expiration_seconds": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'NKr9ospi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateMatchPool' test.out

#- 14 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'GbDPfCVH' \
    > test.out 2>&1
eval_tap $? 14 'DeleteMatchPool' test.out

#- 15 CreateMatchTicket
# body param: body
echo '{"attributes": {"0P2hKpHC": {}, "CeX8BxrF": {}, "N6DBCmYo": {}}, "latencies": {"KEOu6b0n": 42, "QZVtBp9n": 72, "vNDgKoP2": 3}, "matchPool": "A3jesamH", "sessionID": "QKE8fvjo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'CreateMatchTicket' test.out

#- 16 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'GqF343yb' \
    > test.out 2>&1
eval_tap $? 16 'MatchTicketDetails' test.out

#- 17 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid 'zqOn9E2n' \
    > test.out 2>&1
eval_tap $? 17 'DeleteMatchTicket' test.out

#- 18 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '48' \
    --offset '4' \
    > test.out 2>&1
eval_tap $? 18 'RuleSetList' test.out

#- 19 CreateRuleSet
# body param: body
echo '{"data": "AMvVOuPY", "name": "tFSWAlTC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'CreateRuleSet' test.out

#- 20 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset 'Pi9cnSQp' \
    > test.out 2>&1
eval_tap $? 20 'RuleSetDetails' test.out

#- 21 UpdateRuleSet
# body param: body
echo '{"data": "5tz3g54N"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'uWUMwJLk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdateRuleSet' test.out

#- 22 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset '9DWMpuhJ' \
    > test.out 2>&1
eval_tap $? 22 'DeleteRuleSet' test.out

#- 23 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 23 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE