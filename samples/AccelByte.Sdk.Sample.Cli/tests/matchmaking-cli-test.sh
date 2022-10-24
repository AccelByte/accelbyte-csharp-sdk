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
    --limit '27' \
    --offset '24' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "IfF4628y", "description": "wFoH1hxL", "find_match_timeout_seconds": 40, "game_mode": "pfAFLlcH", "joinable": true, "max_delay_ms": 32, "rule_set": {"alliance": {"combination": {"alliances": [{"max": 44, "min": 38, "name": "T5THa4Hj"}, {"max": 35, "min": 11, "name": "SlB9uOSJ"}, {"max": 11, "min": 6, "name": "WsMfpgjX"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 88, "role_flexing_second": 20}, "max_number": 16, "min_number": 33, "player_max_number": 46, "player_min_number": 69}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 42, "min": 28, "name": "bVyWxdWL"}, {"max": 22, "min": 14, "name": "Td5nA20y"}, {"max": 90, "min": 36, "name": "QQBNA5TC"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 85, "role_flexing_second": 18}, "duration": 93, "max_number": 29, "min_number": 89, "player_max_number": 94, "player_min_number": 41}, {"combination": {"alliances": [{"max": 55, "min": 43, "name": "1QfYmAHM"}, {"max": 56, "min": 74, "name": "5paRcXrS"}, {"max": 39, "min": 57, "name": "g7rLCAcB"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 1, "role_flexing_second": 12}, "duration": 38, "max_number": 8, "min_number": 68, "player_max_number": 19, "player_min_number": 95}, {"combination": {"alliances": [{"max": 19, "min": 68, "name": "MezOvnIB"}, {"max": 7, "min": 73, "name": "GkJQb5mC"}, {"max": 60, "min": 59, "name": "nYCofb2d"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 35, "role_flexing_second": 26}, "duration": 7, "max_number": 36, "min_number": 97, "player_max_number": 34, "player_min_number": 98}], "flexing_rule": [{"attribute": "aRRgYBae", "criteria": "gpSnIhg1", "duration": 78, "reference": 0.028509147541968982}, {"attribute": "E3v50TfF", "criteria": "u9gzJ5as", "duration": 88, "reference": 0.34021460238008217}, {"attribute": "GfhKIVNG", "criteria": "189HUPch", "duration": 81, "reference": 0.5295529983745366}], "match_options": {"options": [{"name": "mWxjVH6C", "type": "uWtBpCLl"}, {"name": "N9H2Ic38", "type": "ISTEaRtg"}, {"name": "E6d3Jpy1", "type": "Il1WMEKg"}]}, "matching_rule": [{"attribute": "uNogs1FO", "criteria": "fzLbKjfS", "reference": 0.17903874551223686}, {"attribute": "3ndT5YW5", "criteria": "SbnDagCr", "reference": 0.7106672472579365}, {"attribute": "vttn0TZw", "criteria": "lQQkFn7n", "reference": 0.7922629524382894}], "rebalance_enable": false, "sub_game_modes": {"qs4rU5XE": {"alliance": {"combination": {"alliances": [{"max": 65, "min": 58, "name": "pDCUSGcT"}, {"max": 89, "min": 76, "name": "ks2sXjT1"}, {"max": 93, "min": 61, "name": "xiPILM0X"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 89, "role_flexing_second": 28}, "max_number": 51, "min_number": 9, "player_max_number": 54, "player_min_number": 40}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 58, "min": 68, "name": "mWfUPDcL"}, {"max": 6, "min": 49, "name": "BtwTVEbF"}, {"max": 58, "min": 56, "name": "zHoZUUpR"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 0, "role_flexing_second": 95}, "duration": 67, "max_number": 22, "min_number": 40, "player_max_number": 87, "player_min_number": 53}, {"combination": {"alliances": [{"max": 97, "min": 63, "name": "PvayEBiZ"}, {"max": 68, "min": 51, "name": "fJwcX1vp"}, {"max": 4, "min": 61, "name": "3b2ag9yx"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 56, "role_flexing_second": 35}, "duration": 11, "max_number": 60, "min_number": 84, "player_max_number": 36, "player_min_number": 54}, {"combination": {"alliances": [{"max": 70, "min": 11, "name": "An91fKvb"}, {"max": 5, "min": 84, "name": "h3gytdyx"}, {"max": 3, "min": 62, "name": "ZSIFYGKo"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 44, "role_flexing_second": 93}, "duration": 89, "max_number": 63, "min_number": 46, "player_max_number": 61, "player_min_number": 32}], "name": "apf7qSzi"}, "GGxzNfGt": {"alliance": {"combination": {"alliances": [{"max": 44, "min": 41, "name": "n1yu9ABn"}, {"max": 47, "min": 51, "name": "FgFbyV3i"}, {"max": 42, "min": 15, "name": "UY8de5Fu"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 81, "role_flexing_second": 25}, "max_number": 14, "min_number": 29, "player_max_number": 96, "player_min_number": 32}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 25, "min": 10, "name": "tG9s3HNs"}, {"max": 68, "min": 75, "name": "Lo88dRsK"}, {"max": 18, "min": 7, "name": "8pxbFcPS"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 25, "role_flexing_second": 14}, "duration": 55, "max_number": 72, "min_number": 94, "player_max_number": 78, "player_min_number": 81}, {"combination": {"alliances": [{"max": 6, "min": 59, "name": "5s8jxsLM"}, {"max": 52, "min": 75, "name": "OW0DlWDi"}, {"max": 18, "min": 19, "name": "0qSD88aE"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 87, "role_flexing_second": 21}, "duration": 59, "max_number": 97, "min_number": 90, "player_max_number": 46, "player_min_number": 6}, {"combination": {"alliances": [{"max": 8, "min": 77, "name": "ZMPJrhDW"}, {"max": 6, "min": 46, "name": "upHTrhQs"}, {"max": 65, "min": 38, "name": "TeYPYln8"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 55, "role_flexing_second": 49}, "duration": 19, "max_number": 86, "min_number": 31, "player_max_number": 67, "player_min_number": 29}], "name": "pZS3Q4xB"}, "ibnfBW89": {"alliance": {"combination": {"alliances": [{"max": 43, "min": 73, "name": "bpEp68Dh"}, {"max": 35, "min": 6, "name": "urmjLLdD"}, {"max": 10, "min": 25, "name": "IFLFzYMf"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 91, "role_flexing_second": 31}, "max_number": 60, "min_number": 78, "player_max_number": 51, "player_min_number": 86}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 83, "min": 88, "name": "iN4e0FMg"}, {"max": 5, "min": 59, "name": "Ukt40oQ3"}, {"max": 100, "min": 54, "name": "0hmBb9SJ"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 32, "role_flexing_second": 18}, "duration": 69, "max_number": 55, "min_number": 92, "player_max_number": 66, "player_min_number": 97}, {"combination": {"alliances": [{"max": 92, "min": 69, "name": "jltsPPjn"}, {"max": 77, "min": 76, "name": "qNG4qpKe"}, {"max": 59, "min": 66, "name": "elTWvP44"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 24, "role_flexing_second": 19}, "duration": 22, "max_number": 99, "min_number": 64, "player_max_number": 86, "player_min_number": 32}, {"combination": {"alliances": [{"max": 54, "min": 18, "name": "2qjTLViB"}, {"max": 93, "min": 54, "name": "WfjzO9X8"}, {"max": 86, "min": 44, "name": "CNG8GYwX"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 49, "role_flexing_second": 21}, "duration": 60, "max_number": 9, "min_number": 36, "player_max_number": 87, "player_min_number": 28}], "name": "hCl791yF"}}}, "session_queue_timeout_seconds": 43, "social_matchmaking": true, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
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
    --channel 'DQHuXMr1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "nSIBdTMx", "players": [{"results": [{"attribute": "0Xl7cYwj", "value": 0.11889602338165539}, {"attribute": "6KTNJKBT", "value": 0.41929495467678035}, {"attribute": "BBYhEB4q", "value": 0.5423192338791645}], "user_id": "sshVQWge"}, {"results": [{"attribute": "0DdEIYrM", "value": 0.8956510033197571}, {"attribute": "CbGb0bzl", "value": 0.8471837061968461}, {"attribute": "LQw75H9a", "value": 0.46063519334326997}], "user_id": "CakJo3dU"}, {"results": [{"attribute": "doEnCjtv", "value": 0.2280504724422494}, {"attribute": "CahPMoO9", "value": 0.40558102882177116}, {"attribute": "tMbTCFH9", "value": 0.255311914208849}], "user_id": "go55uDwV"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 Rebalance
# body param: body
echo '{"match_id": "mQK3Mo9b"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'Rebalance' test.out

#- 9 QueueSessionHandler
# body param: body
echo '{"channel": "3BaVMz88", "client_version": "quconrCT", "deployment": "SnHsVkkE", "error_code": 50, "error_message": "f7vKwjyN", "game_mode": "mj0pKRd7", "joinable": true, "match_id": "TqSk5Oa0", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 83, "party_attributes": {"fgcKSTDQ": {}, "Pk2g8Aon": {}, "Skx3cRS2": {}}, "party_id": "1zJ6AABh", "party_members": [{"extra_attributes": {"919tqstT": {}, "zCXWSZfH": {}, "hkqVYxnn": {}}, "user_id": "APYavcam"}, {"extra_attributes": {"QufgQfJR": {}, "Pi6dkGYQ": {}, "d4XRFG5q": {}}, "user_id": "XsQpWkDA"}, {"extra_attributes": {"VhaKYrKz": {}, "894yuHKf": {}, "9xXBycWq": {}}, "user_id": "O65FDYX2"}], "ticket_id": "mZ14VZ1j"}, {"first_ticket_created_at": 30, "party_attributes": {"LuCl6LR4": {}, "f7Cf88hy": {}, "58Ydykpc": {}}, "party_id": "m18vp045", "party_members": [{"extra_attributes": {"MGtW0Flo": {}, "5PZI9uxu": {}, "ibGMD0O8": {}}, "user_id": "4WdKD5OV"}, {"extra_attributes": {"Xp6aKSdc": {}, "xz684XVv": {}, "XOjGA2OM": {}}, "user_id": "VmcVvVF5"}, {"extra_attributes": {"1AfAzkO2": {}, "Y7zxQAQX": {}, "vrBJnJbP": {}}, "user_id": "ncpKJALc"}], "ticket_id": "L4jxzYrp"}, {"first_ticket_created_at": 14, "party_attributes": {"gGHZjLF4": {}, "p9cMuy0H": {}, "XPAe5h7H": {}}, "party_id": "4lLCUKlH", "party_members": [{"extra_attributes": {"x7eAfrpi": {}, "mXMXHNx6": {}, "WyfnnSDM": {}}, "user_id": "qfVMYe3Z"}, {"extra_attributes": {"Hkyd8gnO": {}, "9LFlnFH0": {}, "VTd7J4hz": {}}, "user_id": "WOIm69NY"}, {"extra_attributes": {"WO7Kzbby": {}, "5f6Xol4z": {}, "Y2AKPOR8": {}}, "user_id": "4gwprl7s"}], "ticket_id": "emVvZBfI"}]}, {"matching_parties": [{"first_ticket_created_at": 100, "party_attributes": {"uX4YRzlC": {}, "4EGsgQsr": {}, "dU0dixcN": {}}, "party_id": "2X7t2xq8", "party_members": [{"extra_attributes": {"XcEnvH0M": {}, "Swpd81jS": {}, "hgY6Doq9": {}}, "user_id": "SYCeD8T9"}, {"extra_attributes": {"yZX4pMlO": {}, "Pce3rXpt": {}, "7v5XuKc1": {}}, "user_id": "TJnSyMnN"}, {"extra_attributes": {"CXdHqvQu": {}, "y2BLIXBy": {}, "C61qIU2T": {}}, "user_id": "pl56WvHU"}], "ticket_id": "zrMcKGos"}, {"first_ticket_created_at": 2, "party_attributes": {"j7e70Q1r": {}, "ITVoc3Ep": {}, "0dQgCNoS": {}}, "party_id": "OKrBg19K", "party_members": [{"extra_attributes": {"EuPWzUmh": {}, "0TahoGWU": {}, "PtXgunsb": {}}, "user_id": "L1VqWWmh"}, {"extra_attributes": {"8AqHuXfk": {}, "597qSyZ1": {}, "LoZ7wqHJ": {}}, "user_id": "grJztag5"}, {"extra_attributes": {"ABebIL2J": {}, "sj3vthfn": {}, "yv9ZVRSQ": {}}, "user_id": "sUrALoKu"}], "ticket_id": "lV3jF8OR"}, {"first_ticket_created_at": 99, "party_attributes": {"KjKWPF3L": {}, "zdfym5XC": {}, "iMuJlnWn": {}}, "party_id": "28eKTsHm", "party_members": [{"extra_attributes": {"J26HPBi6": {}, "sTG4wmnZ": {}, "fL6cfh8u": {}}, "user_id": "Mm37j358"}, {"extra_attributes": {"YbPn4zc5": {}, "KC27y7aQ": {}, "d12KZbFo": {}}, "user_id": "94rHsfjw"}, {"extra_attributes": {"wosqZ674": {}, "ggrrFylh": {}, "VMSygL3u": {}}, "user_id": "RBQTdoUr"}], "ticket_id": "CaTAgQhb"}]}, {"matching_parties": [{"first_ticket_created_at": 49, "party_attributes": {"QdIYZu8J": {}, "i38x5hDb": {}, "GVJnkifa": {}}, "party_id": "PX9zrgeR", "party_members": [{"extra_attributes": {"l5UU80O0": {}, "mSgsllJZ": {}, "S7lZ2jyb": {}}, "user_id": "5HL1jD7C"}, {"extra_attributes": {"h4OMo6jH": {}, "hVJou8lv": {}, "CCA1ow1c": {}}, "user_id": "AGfhFnnO"}, {"extra_attributes": {"dGECHagl": {}, "7EAMn1JI": {}, "Mt0L0xrI": {}}, "user_id": "q2wBI0WB"}], "ticket_id": "f7VNYsc3"}, {"first_ticket_created_at": 28, "party_attributes": {"MoSWgBfy": {}, "iaIrQ6Tg": {}, "WSRRdwfI": {}}, "party_id": "dAsLd2sn", "party_members": [{"extra_attributes": {"x4EQOtTO": {}, "0w0GlqKv": {}, "WpbMrQwt": {}}, "user_id": "6EgmtU0T"}, {"extra_attributes": {"mcJGqDcZ": {}, "nvrbIpn2": {}, "YRcWvVX4": {}}, "user_id": "npZ5e7xH"}, {"extra_attributes": {"ETLzZRAN": {}, "sViDG7Bt": {}, "s0mRvGc5": {}}, "user_id": "FWlNn6al"}], "ticket_id": "81HFlzIS"}, {"first_ticket_created_at": 81, "party_attributes": {"iNutdexP": {}, "neXRdiO4": {}, "5yoOY9yv": {}}, "party_id": "n6wgkxAU", "party_members": [{"extra_attributes": {"G8yGHF1N": {}, "QBNvL0ao": {}, "0X5Gsxwd": {}}, "user_id": "cHY7UaJx"}, {"extra_attributes": {"cJs2TB0W": {}, "9dESFsp6": {}, "0giIzHcS": {}}, "user_id": "uFViiQGJ"}, {"extra_attributes": {"Jo4mt456": {}, "FybRX9LB": {}, "s0GOCKyN": {}}, "user_id": "FtBT3BBr"}], "ticket_id": "G9yI5wxq"}]}], "namespace": "dp0fKCQg", "party_attributes": {"T3soBkHg": {}, "EEz5kwbo": {}, "y56ktVRW": {}}, "party_id": "agIVzfs4", "queued_at": 27, "region": "h6cdLc6D", "server_name": "fjuxTtss", "status": "M0pDP37J", "ticket_id": "kpqMelhf", "updated_at": "1971-10-23T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'QueueSessionHandler' test.out

#- 10 DequeueSessionHandler
# body param: body
echo '{"match_id": "kaBFAuYO"}' > $TEMP_JSON_INPUT
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
    --matchID 'd5upzKv5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'QuerySessionHandler' test.out

#- 12 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 73, "userID": "30SZuN4R", "weight": 0.9012176917201975}' > $TEMP_JSON_INPUT
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
    --matchIDs 'qmG8FyVR' \
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
    --strategy 'Zn8Pc6fm' \
    > test.out 2>&1
eval_tap $? 16 'ImportChannels' test.out

#- 17 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'ygXx08OD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetSingleMatchmakingChannel' test.out

#- 18 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "CCcGcx7o", "description": "n9NoQ0JK", "findMatchTimeoutSeconds": 91, "joinable": true, "max_delay_ms": 82, "ruleSet": {"alliance": {"combination": {"alliances": [{"max": 13, "min": 74, "name": "bS3ukeMq"}, {"max": 79, "min": 98, "name": "7bNSwupf"}, {"max": 29, "min": 71, "name": "xdJpCOmb"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 35, "role_flexing_second": 99}, "maxNumber": 46, "minNumber": 94, "playerMaxNumber": 65, "playerMinNumber": 43}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 85, "min": 14, "name": "bfgo485z"}, {"max": 67, "min": 55, "name": "UQQeC5Is"}, {"max": 54, "min": 53, "name": "HHLKoBsp"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 47, "role_flexing_second": 26}, "duration": 93, "max_number": 62, "min_number": 0, "player_max_number": 70, "player_min_number": 99}, {"combination": {"alliances": [{"max": 6, "min": 46, "name": "6CbUyqhL"}, {"max": 39, "min": 17, "name": "K5oPrECh"}, {"max": 13, "min": 14, "name": "t4kQMNcJ"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 32, "role_flexing_second": 98}, "duration": 28, "max_number": 85, "min_number": 63, "player_max_number": 96, "player_min_number": 92}, {"combination": {"alliances": [{"max": 47, "min": 29, "name": "bUkzYMbJ"}, {"max": 47, "min": 70, "name": "tk8LFAna"}, {"max": 28, "min": 83, "name": "hSwUaMeS"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 81, "role_flexing_second": 61}, "duration": 29, "max_number": 60, "min_number": 76, "player_max_number": 79, "player_min_number": 80}], "flexingRules": [{"attribute": "bhuLkNvT", "criteria": "S4pTcLyQ", "duration": 7, "reference": 0.5466592706623212}, {"attribute": "UzpZoyl1", "criteria": "0zGzI2VQ", "duration": 64, "reference": 0.3477824779618096}, {"attribute": "0cMpV3sL", "criteria": "F9XoL75d", "duration": 84, "reference": 0.1207916412519433}], "match_options": {"options": [{"name": "pL16k1ZY", "type": "VMQpzIpJ"}, {"name": "mzddO3PD", "type": "WUtjGyEW"}, {"name": "MliBXvvV", "type": "t2d0l5HO"}]}, "matchingRules": [{"attribute": "uTftvdgB", "criteria": "WYOaoQ92", "reference": 0.8413038809330343}, {"attribute": "qDLhKzfq", "criteria": "cUH8rlKR", "reference": 0.7755933458627657}, {"attribute": "HTrktArE", "criteria": "OHkf3c9N", "reference": 0.5114153667995068}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 92, "socialMatchmaking": false, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'hdLatMMR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchmakingChannel' test.out

#- 19 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'Mb46QQNY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllPartyInChannel' test.out

#- 20 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'qcLbbevQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetAllSessionsInChannel' test.out

#- 21 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["j1oMqRrw", "rjjq33IU", "mCAMTKnG"], "party_id": "DMoGg29D", "user_id": "EzN6exQk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'h4dGaavx' \
    --matchID 'BstcXJkG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AddUserIntoSessionInChannel' test.out

#- 22 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName '5Lk8khOz' \
    --matchID 'xVPe50bD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'DeleteSessionInChannel' test.out

#- 23 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'rH0PCwEL' \
    --matchID 'ctZXXTkN' \
    --namespace $AB_NAMESPACE \
    --userID '75oST0cE' \
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
    --channelName 'x539R4Ww' \
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