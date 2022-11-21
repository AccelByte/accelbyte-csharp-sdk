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
echo "1..30"

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
    --sn matchmaking \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 HandlerV3Healthz
$CLI_EXE \
    --sn matchmaking \
    --op HandlerV3Healthz \
    > test.out 2>&1
eval_tap $? 3 'HandlerV3Healthz' test.out

#- 4 GetAllChannelsHandler
$CLI_EXE \
    --sn matchmaking \
    --op GetAllChannelsHandler \
    --namespace $AB_NAMESPACE \
    --limit '55' \
    --offset '63' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "n3kEvveS", "description": "gGqoNtqo", "find_match_timeout_seconds": 54, "game_mode": "xryRCCiX", "joinable": false, "max_delay_ms": 85, "rule_set": {"alliance": {"combination": {"alliances": [{"max": 3, "min": 35, "name": "b2JGN13h"}, {"max": 17, "min": 92, "name": "xcs7pQd6"}, {"max": 14, "min": 94, "name": "O104btCb"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 62, "role_flexing_second": 53}, "max_number": 45, "min_number": 86, "player_max_number": 37, "player_min_number": 47}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 25, "min": 74, "name": "OAxyMYKu"}, {"max": 67, "min": 75, "name": "5BE9CRCt"}, {"max": 21, "min": 84, "name": "ADrWk2yL"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 9, "role_flexing_second": 85}, "duration": 36, "max_number": 46, "min_number": 30, "player_max_number": 52, "player_min_number": 53}, {"combination": {"alliances": [{"max": 14, "min": 24, "name": "IfQNdueR"}, {"max": 27, "min": 36, "name": "Iyp4K6gH"}, {"max": 79, "min": 80, "name": "Lvt5K6MT"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 35, "role_flexing_second": 83}, "duration": 10, "max_number": 52, "min_number": 76, "player_max_number": 6, "player_min_number": 63}, {"combination": {"alliances": [{"max": 93, "min": 12, "name": "b71og8B2"}, {"max": 67, "min": 61, "name": "2IQT9SsO"}, {"max": 92, "min": 28, "name": "lnn4GQ2W"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 88, "role_flexing_second": 20}, "duration": 89, "max_number": 18, "min_number": 43, "player_max_number": 15, "player_min_number": 74}], "flexing_rule": [{"attribute": "YOWjGNDj", "criteria": "DH9BsrKq", "duration": 38, "reference": 0.4057348026005566}, {"attribute": "GAqBxOWS", "criteria": "0mkcbAf0", "duration": 31, "reference": 0.9801083222406131}, {"attribute": "0hu4BNJI", "criteria": "lC2EEa36", "duration": 76, "reference": 0.5280470193253481}], "match_options": {"options": [{"name": "sibyBvNz", "type": "wWTsKC1k"}, {"name": "NSJtQh75", "type": "QnYdOvwE"}, {"name": "o8V8WWUI", "type": "5ZZi9RBp"}]}, "matching_rule": [{"attribute": "Dgzxo44x", "criteria": "1zpsiKTE", "reference": 0.4883945773900442}, {"attribute": "0ZsiEJOb", "criteria": "h7ZIqdUP", "reference": 0.37434377637867267}, {"attribute": "d1BNDNYh", "criteria": "p7j0FDKr", "reference": 0.8533114612875105}], "rebalance_enable": true, "sub_game_modes": {"HP577DkE": {"alliance": {"combination": {"alliances": [{"max": 31, "min": 43, "name": "MmjLwjSn"}, {"max": 27, "min": 74, "name": "NJBisvfn"}, {"max": 57, "min": 23, "name": "lMjiLx0a"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 3, "role_flexing_second": 57}, "max_number": 65, "min_number": 79, "player_max_number": 98, "player_min_number": 52}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 66, "min": 51, "name": "nkaGGGhm"}, {"max": 72, "min": 82, "name": "W97yZb3z"}, {"max": 12, "min": 29, "name": "gZ3Ka2nK"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 8, "role_flexing_second": 97}, "duration": 54, "max_number": 87, "min_number": 70, "player_max_number": 79, "player_min_number": 100}, {"combination": {"alliances": [{"max": 14, "min": 38, "name": "HUnGhxmu"}, {"max": 38, "min": 21, "name": "mmbltZ26"}, {"max": 22, "min": 40, "name": "43hCpEJJ"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 93, "role_flexing_second": 12}, "duration": 59, "max_number": 46, "min_number": 48, "player_max_number": 28, "player_min_number": 41}, {"combination": {"alliances": [{"max": 40, "min": 94, "name": "EFKd3tIM"}, {"max": 61, "min": 78, "name": "fowyQG1V"}, {"max": 9, "min": 6, "name": "UFKyAq5r"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 98, "role_flexing_second": 11}, "duration": 23, "max_number": 47, "min_number": 56, "player_max_number": 79, "player_min_number": 81}], "name": "ckzUKFLg"}, "jIkzrHcc": {"alliance": {"combination": {"alliances": [{"max": 71, "min": 55, "name": "pR6PJ9XU"}, {"max": 54, "min": 76, "name": "wVNPyyXV"}, {"max": 87, "min": 18, "name": "WjJF0v6c"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 33, "role_flexing_second": 96}, "max_number": 97, "min_number": 49, "player_max_number": 14, "player_min_number": 32}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 56, "min": 67, "name": "kJIRHKuu"}, {"max": 61, "min": 95, "name": "ZlLc508o"}, {"max": 25, "min": 19, "name": "8NNRhpKC"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 88, "role_flexing_second": 45}, "duration": 57, "max_number": 11, "min_number": 10, "player_max_number": 56, "player_min_number": 47}, {"combination": {"alliances": [{"max": 100, "min": 15, "name": "BN6HH49Z"}, {"max": 11, "min": 36, "name": "KrM2ogYi"}, {"max": 7, "min": 38, "name": "Eq8jMoSx"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 74, "role_flexing_second": 15}, "duration": 42, "max_number": 0, "min_number": 46, "player_max_number": 20, "player_min_number": 22}, {"combination": {"alliances": [{"max": 74, "min": 41, "name": "ytDYZg2y"}, {"max": 37, "min": 29, "name": "atgUD3sw"}, {"max": 13, "min": 38, "name": "N2juKOXL"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 79, "role_flexing_second": 33}, "duration": 16, "max_number": 98, "min_number": 13, "player_max_number": 22, "player_min_number": 34}], "name": "ZsCdhVjF"}, "C7fZhBqV": {"alliance": {"combination": {"alliances": [{"max": 17, "min": 88, "name": "3pC317eo"}, {"max": 12, "min": 17, "name": "TozfM64g"}, {"max": 35, "min": 58, "name": "zyGgkSz5"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 29, "role_flexing_second": 30}, "max_number": 74, "min_number": 83, "player_max_number": 18, "player_min_number": 20}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 12, "min": 95, "name": "4ZgTtfrj"}, {"max": 5, "min": 29, "name": "eCUwnRyZ"}, {"max": 44, "min": 33, "name": "T111dgYv"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 66, "role_flexing_second": 79}, "duration": 42, "max_number": 32, "min_number": 27, "player_max_number": 25, "player_min_number": 28}, {"combination": {"alliances": [{"max": 76, "min": 77, "name": "w4heIN1Y"}, {"max": 50, "min": 6, "name": "hVn1LoeI"}, {"max": 14, "min": 58, "name": "GRea9vAB"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 3, "role_flexing_second": 41}, "duration": 49, "max_number": 98, "min_number": 40, "player_max_number": 43, "player_min_number": 86}, {"combination": {"alliances": [{"max": 52, "min": 15, "name": "UgXNnT9v"}, {"max": 98, "min": 5, "name": "OWxRKzcA"}, {"max": 46, "min": 57, "name": "H5QAHPC3"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 100, "role_flexing_second": 97}, "duration": 63, "max_number": 73, "min_number": 68, "player_max_number": 0, "player_min_number": 21}], "name": "3xkNysNJ"}}}, "session_queue_timeout_seconds": 84, "social_matchmaking": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateChannelHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateChannelHandler' test.out

#- 6 DeleteChannelHandler
$CLI_EXE \
    --sn matchmaking \
    --op DeleteChannelHandler \
    --channel 'B6PyAf5Y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "nsJnlIgE", "players": [{"results": [{"attribute": "Uhht5q4Z", "value": 0.6378041049741067}, {"attribute": "7Me490x7", "value": 0.3217726813648796}, {"attribute": "cWhDg1KL", "value": 0.6534980041883222}], "user_id": "JygCtnYh"}, {"results": [{"attribute": "romf33VJ", "value": 0.4918208438698155}, {"attribute": "hArFt3Fh", "value": 0.16902568415240637}, {"attribute": "V88kPTFG", "value": 0.6481844354374827}], "user_id": "rykAFNVZ"}, {"results": [{"attribute": "HV6pvX3L", "value": 0.38064454786485624}, {"attribute": "toKhKcx2", "value": 0.8798476830404951}, {"attribute": "8yD0XK1r", "value": 0.03248835794645799}], "user_id": "zzXxz5BT"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 Rebalance
# body param: body
echo '{"match_id": "70Enywg4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'Rebalance' test.out

#- 9 QueueSessionHandler
# body param: body
echo '{"channel": "XojoN7bt", "client_version": "nYPN4aFS", "deployment": "AEJJr5hq", "error_code": 75, "error_message": "OIOP1BSL", "game_mode": "xhwPvOyO", "joinable": false, "match_id": "EnG23L5w", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 60, "party_attributes": {"FWROaRRf": {}, "fLTXUAGf": {}, "cg1rXKNZ": {}}, "party_id": "swpCW3mm", "party_members": [{"extra_attributes": {"pj5ggo6y": {}, "eRZgQULY": {}, "kvfSFEMp": {}}, "user_id": "oJv4kVgU"}, {"extra_attributes": {"4Ov3hTxD": {}, "fE8IDyEY": {}, "Ouf6Kd0L": {}}, "user_id": "7fPIdqks"}, {"extra_attributes": {"cVvLGiIF": {}, "feqe4vBR": {}, "zuN1gUqp": {}}, "user_id": "38s71nBX"}], "ticket_id": "Sgxkn1LR"}, {"first_ticket_created_at": 8, "party_attributes": {"VvTOTuPY": {}, "vxNtf45V": {}, "34tYSyWc": {}}, "party_id": "M7mt3zDH", "party_members": [{"extra_attributes": {"vXSiPkbJ": {}, "pCyrjYEm": {}, "8QuZEXMr": {}}, "user_id": "CuNgf25y"}, {"extra_attributes": {"VkFbJxLR": {}, "CQMFuntL": {}, "1n9xXzmk": {}}, "user_id": "yIfizmWx"}, {"extra_attributes": {"J6IMBzaQ": {}, "gKoCca6N": {}, "UsFBtP2B": {}}, "user_id": "Hmw6mYaC"}], "ticket_id": "HUpXUmm9"}, {"first_ticket_created_at": 95, "party_attributes": {"BULOZZ3M": {}, "ZEn0iN5m": {}, "azrCfQCD": {}}, "party_id": "ruVaNVDB", "party_members": [{"extra_attributes": {"XNLJGQNP": {}, "z0eKXThd": {}, "Cace4eVH": {}}, "user_id": "QdEwM3Ox"}, {"extra_attributes": {"a7hrdEPk": {}, "QXaie7LR": {}, "UeKGUPXA": {}}, "user_id": "Fq9NpUo0"}, {"extra_attributes": {"K75Jx6Pd": {}, "cnLTWDxm": {}, "rqQexoHq": {}}, "user_id": "VX9hLVPZ"}], "ticket_id": "oWIRtrMQ"}]}, {"matching_parties": [{"first_ticket_created_at": 19, "party_attributes": {"XekNnQAl": {}, "IXzC64A0": {}, "9bKFV8JB": {}}, "party_id": "POG949BF", "party_members": [{"extra_attributes": {"QRIscV6g": {}, "SZFjuysm": {}, "jf3WPdAh": {}}, "user_id": "X0TrzWsJ"}, {"extra_attributes": {"6JVCo0br": {}, "QVdKAi3O": {}, "gFj5hZqC": {}}, "user_id": "KoevrAyY"}, {"extra_attributes": {"6GyMwUmw": {}, "pwnKGxZI": {}, "UQDlNdIE": {}}, "user_id": "4NPwUCtp"}], "ticket_id": "UwEl6CkH"}, {"first_ticket_created_at": 34, "party_attributes": {"Uib9SKeg": {}, "oxMrQTfa": {}, "oEO2SSCm": {}}, "party_id": "lSXiPnYK", "party_members": [{"extra_attributes": {"40SDL1bg": {}, "wLo4PgK6": {}, "8Lc5rauM": {}}, "user_id": "OPje7P2z"}, {"extra_attributes": {"rVbXeSNZ": {}, "GOw8UhWy": {}, "7JAroUsH": {}}, "user_id": "tlcrDFK8"}, {"extra_attributes": {"5H1SZLMR": {}, "i5qUekii": {}, "e88p9wV4": {}}, "user_id": "pXz39q01"}], "ticket_id": "KQb0nDW2"}, {"first_ticket_created_at": 89, "party_attributes": {"2KrZVR1h": {}, "2zgD3Kd7": {}, "g7lUcjh9": {}}, "party_id": "IHPzhFkl", "party_members": [{"extra_attributes": {"Z13yZxwd": {}, "EESPO54O": {}, "JSJRZw32": {}}, "user_id": "HTcPprkG"}, {"extra_attributes": {"hC6HLlyS": {}, "yozjoGqp": {}, "sOPfJaMb": {}}, "user_id": "Q2Zv83yL"}, {"extra_attributes": {"JNka3hZv": {}, "bOmMGWU2": {}, "1jIuZSyf": {}}, "user_id": "uFCakaO5"}], "ticket_id": "JIY13IZO"}]}, {"matching_parties": [{"first_ticket_created_at": 71, "party_attributes": {"D2vgQck9": {}, "gvdp0RtQ": {}, "XgFyPJKZ": {}}, "party_id": "HNmHiaAf", "party_members": [{"extra_attributes": {"XyvEdnly": {}, "n0CGZWk1": {}, "wfknRNTe": {}}, "user_id": "8DrTXnpP"}, {"extra_attributes": {"wSuzgWY5": {}, "cXmltclO": {}, "16Q5sQf2": {}}, "user_id": "w2ZihXBY"}, {"extra_attributes": {"qyJ614oF": {}, "nQdDsNVJ": {}, "XCOk9kcm": {}}, "user_id": "MspFEM0x"}], "ticket_id": "k1JY1Qol"}, {"first_ticket_created_at": 33, "party_attributes": {"HH2qV3go": {}, "KenmjsIQ": {}, "JB0DAFAm": {}}, "party_id": "8tNlevdg", "party_members": [{"extra_attributes": {"jrn6pXFc": {}, "wdswXkmt": {}, "nszHWqW7": {}}, "user_id": "9ppNa5J3"}, {"extra_attributes": {"z4TISrem": {}, "MRfOIdGp": {}, "6cah42KG": {}}, "user_id": "EXD7pv1X"}, {"extra_attributes": {"xJ7q6i6c": {}, "ZawZwHxZ": {}, "7EYrySBa": {}}, "user_id": "wxjD6bTc"}], "ticket_id": "ddCfTBNq"}, {"first_ticket_created_at": 88, "party_attributes": {"wcfruGH3": {}, "dgsPF7mT": {}, "JHj71PMP": {}}, "party_id": "T8jnG1y8", "party_members": [{"extra_attributes": {"SmTsOKAm": {}, "I1KLHgJp": {}, "KzyQSFFy": {}}, "user_id": "PcF3oqug"}, {"extra_attributes": {"6YyPSHwm": {}, "wHNxF0XZ": {}, "I0Iiwxgb": {}}, "user_id": "JDsf0vbP"}, {"extra_attributes": {"TzVtnoEb": {}, "yFqaxQoK": {}, "ZZGATAUi": {}}, "user_id": "gY7OIV0g"}], "ticket_id": "geRhImfL"}]}], "namespace": "TQCGnn5n", "party_attributes": {"nDL4XQGv": {}, "xIOmbkbP": {}, "ArlzY8K2": {}}, "party_id": "HQZCdfqJ", "queued_at": 88, "region": "kRwCi6cu", "server_name": "knEGKh7F", "status": "LWvE1qh4", "ticket_id": "W497vTKl", "updated_at": "1979-11-12T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'QueueSessionHandler' test.out

#- 10 DequeueSessionHandler
# body param: body
echo '{"match_id": "CBKxoA8Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op DequeueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'DequeueSessionHandler' test.out

#- 11 QuerySessionHandler
$CLI_EXE \
    --sn matchmaking \
    --op QuerySessionHandler \
    --matchID 'p7SerQQs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'QuerySessionHandler' test.out

#- 12 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 26, "userID": "1nP5Hrup", "weight": 0.36709766291561796}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdatePlayTimeWeight \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdatePlayTimeWeight' test.out

#- 13 GetAllPartyInAllChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInAllChannel \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetAllPartyInAllChannel' test.out

#- 14 BulkGetSessions
$CLI_EXE \
    --sn matchmaking \
    --op BulkGetSessions \
    --namespace $AB_NAMESPACE \
    --matchIDs 'yIXKosaq' \
    > test.out 2>&1
eval_tap $? 14 'BulkGetSessions' test.out

#- 15 ExportChannels
$CLI_EXE \
    --sn matchmaking \
    --op ExportChannels \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'ExportChannels' test.out

#- 16 ImportChannels
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn matchmaking \
    --op ImportChannels \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --strategy 'HWMv7HQB' \
    > test.out 2>&1
eval_tap $? 16 'ImportChannels' test.out

#- 17 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'mvugpE3I' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetSingleMatchmakingChannel' test.out

#- 18 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "mhX4rc8Q", "description": "fvKVFDjR", "findMatchTimeoutSeconds": 12, "joinable": false, "max_delay_ms": 47, "ruleSet": {"alliance": {"combination": {"alliances": [{"max": 85, "min": 33, "name": "ttjmw6wn"}, {"max": 55, "min": 9, "name": "l03AmP5d"}, {"max": 52, "min": 24, "name": "VHrok5Uj"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 99, "role_flexing_second": 74}, "maxNumber": 83, "minNumber": 8, "playerMaxNumber": 43, "playerMinNumber": 75}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 22, "min": 4, "name": "TeOoFGlx"}, {"max": 21, "min": 24, "name": "p8FT9Zps"}, {"max": 75, "min": 4, "name": "KWfS0mXx"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 30, "role_flexing_second": 9}, "duration": 75, "max_number": 78, "min_number": 33, "player_max_number": 75, "player_min_number": 1}, {"combination": {"alliances": [{"max": 0, "min": 56, "name": "Wit3mFVG"}, {"max": 92, "min": 71, "name": "0U3qIImM"}, {"max": 99, "min": 92, "name": "kUWQY93A"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 50, "role_flexing_second": 28}, "duration": 5, "max_number": 22, "min_number": 15, "player_max_number": 17, "player_min_number": 68}, {"combination": {"alliances": [{"max": 80, "min": 78, "name": "mo8rGkuB"}, {"max": 75, "min": 46, "name": "sfwuQsen"}, {"max": 48, "min": 0, "name": "I91oUgfy"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 88, "role_flexing_second": 92}, "duration": 79, "max_number": 37, "min_number": 95, "player_max_number": 82, "player_min_number": 24}], "flexingRules": [{"attribute": "NQcLjyPp", "criteria": "bEkLg6wV", "duration": 17, "reference": 0.3702434637093447}, {"attribute": "bUK6xY5V", "criteria": "lQRQj8YC", "duration": 65, "reference": 0.07862924904899216}, {"attribute": "mznxPRHy", "criteria": "rrd8nvgL", "duration": 17, "reference": 0.04586847752830814}], "match_options": {"options": [{"name": "kUKgmSI9", "type": "fpIjI4wM"}, {"name": "v9SrcY61", "type": "ks5PmuKT"}, {"name": "5IYx6Wt9", "type": "yFzGq9xx"}]}, "matchingRules": [{"attribute": "zm3h5HcR", "criteria": "uxo3Rypt", "reference": 0.07952090529461531}, {"attribute": "IyP6fVZ9", "criteria": "ZWXRVOyZ", "reference": 0.18914627320947575}, {"attribute": "1LYWzNSr", "criteria": "rypDPb8O", "reference": 0.15825642465209477}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 63, "socialMatchmaking": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'P92tCVMJ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchmakingChannel' test.out

#- 19 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'rWP4EpKM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllPartyInChannel' test.out

#- 20 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'ArkhxKAx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetAllSessionsInChannel' test.out

#- 21 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["7lymyqiu", "3T93lsQG", "Z2q2Eyeo"], "party_id": "qB0FYhZ6", "user_id": "pKrqlJXr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'wv4QEWrr' \
    --matchID 'mGIdGw4E' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AddUserIntoSessionInChannel' test.out

#- 22 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'D4vQSen8' \
    --matchID 'RPRPWhif' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'DeleteSessionInChannel' test.out

#- 23 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'CfQ0q4yS' \
    --matchID 'r5QwsHqq' \
    --namespace $AB_NAMESPACE \
    --userID 'GDA6zsyE' \
    > test.out 2>&1
eval_tap $? 23 'DeleteUserFromSessionInChannel' test.out

#- 24 SearchSessions
eval_tap 0 24 'SearchSessions # SKIP deprecated' test.out

#- 25 GetSessionHistoryDetailed
eval_tap 0 25 'GetSessionHistoryDetailed # SKIP deprecated' test.out

#- 26 PublicGetMessages
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 26 'PublicGetMessages' test.out

#- 27 PublicGetAllMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetAllMatchmakingChannel \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'PublicGetAllMatchmakingChannel' test.out

#- 28 PublicGetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetSingleMatchmakingChannel \
    --channelName '1imvsNK2' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'PublicGetSingleMatchmakingChannel' test.out

#- 29 SearchSessionsV2
eval_tap 0 29 'SearchSessionsV2 # SKIP deprecated' test.out

#- 30 VersionCheckHandler
$CLI_EXE \
    --sn matchmaking \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 30 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE