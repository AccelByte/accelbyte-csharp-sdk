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
    --limit '13' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "QBRXAKPD", "description": "5xQsEfWR", "find_match_timeout_seconds": 39, "game_mode": "Ttlns5kW", "joinable": false, "max_delay_ms": 18, "rule_set": {"alliance": {"combination": {"alliances": [{"max": 34, "min": 23, "name": "OE0ZHPJg"}, {"max": 66, "min": 61, "name": "7F46J5UB"}, {"max": 21, "min": 34, "name": "WTxBfmec"}], "has_combination": false}, "max_number": 53, "min_number": 35, "player_max_number": 24, "player_min_number": 67}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 76, "min": 62, "name": "osspYEBy"}, {"max": 23, "min": 50, "name": "jfYxdsJ4"}, {"max": 99, "min": 28, "name": "ljrNyoHn"}], "has_combination": true}, "duration": 7, "max_number": 42, "min_number": 36, "player_max_number": 92, "player_min_number": 55}, {"combination": {"alliances": [{"max": 49, "min": 69, "name": "O3lwL9oI"}, {"max": 90, "min": 94, "name": "usJ8Indd"}, {"max": 88, "min": 47, "name": "kXTgH4n8"}], "has_combination": false}, "duration": 1, "max_number": 27, "min_number": 54, "player_max_number": 18, "player_min_number": 70}, {"combination": {"alliances": [{"max": 59, "min": 96, "name": "9BrmTXb9"}, {"max": 7, "min": 76, "name": "O5JtU8Vs"}, {"max": 26, "min": 60, "name": "1qJiVUZz"}], "has_combination": true}, "duration": 27, "max_number": 99, "min_number": 99, "player_max_number": 0, "player_min_number": 80}], "flexing_rule": [{"attribute": "nNbFI2AX", "criteria": "CweqCUSF", "duration": 22, "reference": 0.026264006802767303}, {"attribute": "4Vb6mhAZ", "criteria": "EBQh9D3C", "duration": 22, "reference": 0.6945087380624628}, {"attribute": "qkMwFQ53", "criteria": "d0g53YIn", "duration": 88, "reference": 0.7244948096463385}], "match_options": {"options": [{"name": "jPxsJn8S", "type": "re9c32RB"}, {"name": "JItP9QPy", "type": "LCy9Gxo9"}, {"name": "7nwHfMvT", "type": "CbVLHcFw"}]}, "matching_rule": [{"attribute": "NnQjmK0o", "criteria": "NMS4Pjkh", "reference": 0.8036596406676925}, {"attribute": "ZBytv75A", "criteria": "wwgsW4Sm", "reference": 0.12261248524830137}, {"attribute": "ovCXgpL8", "criteria": "QPFiJIPZ", "reference": 0.10717689599896296}], "sub_game_modes": {"dyJ5hZEs": {"alliance": {"combination": {"alliances": [{"max": 48, "min": 3, "name": "3ktY9xMm"}, {"max": 12, "min": 27, "name": "ry2Q4bYu"}, {"max": 32, "min": 2, "name": "yFCnz4Lx"}], "has_combination": false}, "max_number": 77, "min_number": 58, "player_max_number": 21, "player_min_number": 92}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 39, "min": 40, "name": "hej8XZf1"}, {"max": 69, "min": 38, "name": "zHFBOjst"}, {"max": 40, "min": 35, "name": "5J8YgQAG"}], "has_combination": false}, "duration": 76, "max_number": 76, "min_number": 52, "player_max_number": 61, "player_min_number": 34}, {"combination": {"alliances": [{"max": 82, "min": 36, "name": "kG7Czgbr"}, {"max": 11, "min": 72, "name": "J60FCpp2"}, {"max": 78, "min": 34, "name": "gSDJRrSo"}], "has_combination": true}, "duration": 0, "max_number": 89, "min_number": 47, "player_max_number": 51, "player_min_number": 71}, {"combination": {"alliances": [{"max": 21, "min": 26, "name": "jqSEvnpX"}, {"max": 32, "min": 85, "name": "efgnwUxm"}, {"max": 61, "min": 93, "name": "3AEyhWLA"}], "has_combination": false}, "duration": 65, "max_number": 62, "min_number": 14, "player_max_number": 15, "player_min_number": 24}], "name": "4I32Jsxi"}, "5TTXSFnA": {"alliance": {"combination": {"alliances": [{"max": 7, "min": 9, "name": "n4VgnQxQ"}, {"max": 50, "min": 50, "name": "PnoaF7vT"}, {"max": 63, "min": 65, "name": "T5Sh6ER1"}], "has_combination": false}, "max_number": 62, "min_number": 70, "player_max_number": 95, "player_min_number": 90}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 89, "min": 9, "name": "sI0CokYi"}, {"max": 38, "min": 1, "name": "0mal2nfA"}, {"max": 91, "min": 38, "name": "9KSh1Vdf"}], "has_combination": false}, "duration": 89, "max_number": 22, "min_number": 23, "player_max_number": 56, "player_min_number": 73}, {"combination": {"alliances": [{"max": 2, "min": 22, "name": "0kiyQaIu"}, {"max": 4, "min": 14, "name": "Ka2k90au"}, {"max": 68, "min": 8, "name": "RiwMN57N"}], "has_combination": false}, "duration": 16, "max_number": 62, "min_number": 36, "player_max_number": 42, "player_min_number": 75}, {"combination": {"alliances": [{"max": 45, "min": 17, "name": "R3WesoIO"}, {"max": 3, "min": 59, "name": "WpFoWYq7"}, {"max": 37, "min": 65, "name": "s9ipDVc8"}], "has_combination": false}, "duration": 82, "max_number": 56, "min_number": 98, "player_max_number": 50, "player_min_number": 84}], "name": "ImRmhgaj"}, "pxJxTB5L": {"alliance": {"combination": {"alliances": [{"max": 39, "min": 0, "name": "tQQUrkhx"}, {"max": 51, "min": 77, "name": "LNRguqbt"}, {"max": 46, "min": 81, "name": "Qd5CCDP8"}], "has_combination": false}, "max_number": 23, "min_number": 91, "player_max_number": 98, "player_min_number": 96}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 79, "min": 77, "name": "MzShPamG"}, {"max": 68, "min": 32, "name": "FQ7FSPGi"}, {"max": 38, "min": 21, "name": "gM62tOWe"}], "has_combination": false}, "duration": 8, "max_number": 1, "min_number": 86, "player_max_number": 3, "player_min_number": 28}, {"combination": {"alliances": [{"max": 17, "min": 100, "name": "2vPw2VyM"}, {"max": 39, "min": 22, "name": "pAqDxU8Y"}, {"max": 63, "min": 11, "name": "19jPVjq7"}], "has_combination": true}, "duration": 75, "max_number": 93, "min_number": 19, "player_max_number": 55, "player_min_number": 9}, {"combination": {"alliances": [{"max": 82, "min": 61, "name": "rfiiL81m"}, {"max": 14, "min": 61, "name": "o1Mbj7Pb"}, {"max": 4, "min": 31, "name": "EChHLOrF"}], "has_combination": true}, "duration": 56, "max_number": 79, "min_number": 30, "player_max_number": 30, "player_min_number": 94}], "name": "QatRyBiY"}}}, "session_queue_timeout_seconds": 98, "social_matchmaking": false, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
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
    --channel 'YjNlwulP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "1vhenzzf", "players": [{"results": [{"attribute": "l450yS3D", "value": 0.8224121426248365}, {"attribute": "yz1E8wwc", "value": 0.3985306345197923}, {"attribute": "WZIGDrMV", "value": 0.9760926530484992}], "user_id": "C0xbjDB3"}, {"results": [{"attribute": "0HdI7gz2", "value": 0.6684622944113355}, {"attribute": "18HdkZsU", "value": 0.9623609338054108}, {"attribute": "z18JfOBa", "value": 0.5337358569302681}], "user_id": "U6hq5S55"}, {"results": [{"attribute": "flx5JXgn", "value": 0.4362712275826064}, {"attribute": "koZ4sF9u", "value": 0.10001657791983942}, {"attribute": "goHiT8p3", "value": 0.9178849340774514}], "user_id": "NGtx1A81"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 Rebalance
# body param: body
echo '{"match_id": "jIBz3U25"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'Rebalance' test.out

#- 9 QueueSessionHandler
# body param: body
echo '{"channel": "PLfD9iwy", "client_version": "f0QIFFBp", "deployment": "h0wBpbUj", "game_mode": "hLfo0GXZ", "joinable": false, "match_id": "cDmjlsPH", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 83, "party_attributes": {"3E49WFYm": {}, "dWKsaevJ": {}, "9ulCQor7": {}}, "party_id": "7jMFFht9", "party_members": [{"extra_attributes": {"fcJPUVIm": {}, "y4Qcqc6D": {}, "R87yJ2bu": {}}, "user_id": "wdjb8M4U"}, {"extra_attributes": {"gycDKDNE": {}, "OWP4nwCQ": {}, "JzzPUPw3": {}}, "user_id": "cPXybt8S"}, {"extra_attributes": {"XclxLndd": {}, "HrzCQeJk": {}, "OQ3NNo2z": {}}, "user_id": "krWocwwA"}]}, {"first_ticket_created_at": 4, "party_attributes": {"CwmzSNUU": {}, "ePHWj6YC": {}, "PRVtol6W": {}}, "party_id": "Iw197r5X", "party_members": [{"extra_attributes": {"tuPLis0M": {}, "5U6Gkm38": {}, "jq8mIOuX": {}}, "user_id": "Uj0m7Asx"}, {"extra_attributes": {"GFg0LKwt": {}, "ujIHUaKc": {}, "KNIIuGme": {}}, "user_id": "mInn9xDy"}, {"extra_attributes": {"oyblshc3": {}, "ltUWfxP4": {}, "dWrnUOAy": {}}, "user_id": "z0EfS8Md"}]}, {"first_ticket_created_at": 70, "party_attributes": {"jpfFcVX9": {}, "TyenQt8V": {}, "G4VwXs8C": {}}, "party_id": "K6h7Bxsm", "party_members": [{"extra_attributes": {"dDNr22uH": {}, "YRqG2h33": {}, "swQq8nxO": {}}, "user_id": "ltx3i7KR"}, {"extra_attributes": {"Oey99CCV": {}, "gI1qG5up": {}, "0YIlYfbl": {}}, "user_id": "7ZUijkAj"}, {"extra_attributes": {"x5oKpgw5": {}, "GraxkYbL": {}, "4a5bjgMN": {}}, "user_id": "A7FHxsPJ"}]}]}, {"matching_parties": [{"first_ticket_created_at": 49, "party_attributes": {"Wmrqb6kn": {}, "WYm5EqCR": {}, "8mf5qKAy": {}}, "party_id": "kWa1c2T1", "party_members": [{"extra_attributes": {"YPqs3rod": {}, "jPA4OaH1": {}, "SFUHYK2g": {}}, "user_id": "2imQcHvU"}, {"extra_attributes": {"QJtZkbYd": {}, "ag87tsSv": {}, "yY4TDSyQ": {}}, "user_id": "6m4laVNp"}, {"extra_attributes": {"rsb6FvQe": {}, "lfh5JDi5": {}, "MzmtDFFP": {}}, "user_id": "u9YCWhKD"}]}, {"first_ticket_created_at": 67, "party_attributes": {"L5EjizHb": {}, "anK2gNHO": {}, "Kg71Z4df": {}}, "party_id": "eqcwGQtt", "party_members": [{"extra_attributes": {"5OdgnYuj": {}, "1rPxH4Zl": {}, "KTJDUADG": {}}, "user_id": "OanJyDOy"}, {"extra_attributes": {"YIkNGhv9": {}, "NBQhvbgD": {}, "cgfi6Ufh": {}}, "user_id": "La2TcY6M"}, {"extra_attributes": {"NiYEDysQ": {}, "gzVNuRBZ": {}, "oXaba8OQ": {}}, "user_id": "Bp81iwAP"}]}, {"first_ticket_created_at": 7, "party_attributes": {"qW41KnkZ": {}, "wT7SorJX": {}, "LWEQzJNd": {}}, "party_id": "J3waosDt", "party_members": [{"extra_attributes": {"OpmfGaw1": {}, "0lghSntL": {}, "R0gANQjG": {}}, "user_id": "W7tMK2vJ"}, {"extra_attributes": {"gxrE3gyA": {}, "qSrcDdwe": {}, "tolFTkVR": {}}, "user_id": "2azxBGXt"}, {"extra_attributes": {"pMGdWY0b": {}, "wpJWmep5": {}, "pcFvKJVh": {}}, "user_id": "qMombxfm"}]}]}, {"matching_parties": [{"first_ticket_created_at": 32, "party_attributes": {"j79o7ljY": {}, "LaaHovXb": {}, "8j7cZI3O": {}}, "party_id": "o0aYZgKe", "party_members": [{"extra_attributes": {"x00HGCDC": {}, "OaJOnvhf": {}, "pYMag7Xs": {}}, "user_id": "LA7LPGc8"}, {"extra_attributes": {"4PFATm5x": {}, "eNSEyRaX": {}, "8Y8gjpfB": {}}, "user_id": "S8AQbpfz"}, {"extra_attributes": {"Zecun1Qm": {}, "kNdMPqkT": {}, "TvDjPtKp": {}}, "user_id": "cPjs9hwX"}]}, {"first_ticket_created_at": 16, "party_attributes": {"cmhkhyDy": {}, "1yXgdwmh": {}, "PKLhXUae": {}}, "party_id": "fce7dB9b", "party_members": [{"extra_attributes": {"xW6tVHXN": {}, "4ppXK4Bh": {}, "mzM5u7gW": {}}, "user_id": "Vzdyo5Lv"}, {"extra_attributes": {"3dNZQS4n": {}, "B4FNaSXK": {}, "adnO2eg1": {}}, "user_id": "2E1b8onA"}, {"extra_attributes": {"DIpv93RY": {}, "ULAgBv1p": {}, "hZRBJSlX": {}}, "user_id": "4G48MhlJ"}]}, {"first_ticket_created_at": 39, "party_attributes": {"uzsy9M0F": {}, "eCJiZZeS": {}, "uepKwlo1": {}}, "party_id": "A5OgIOSB", "party_members": [{"extra_attributes": {"BuixNuqO": {}, "56nblfDY": {}, "8HOzeBtT": {}}, "user_id": "Ig3QaVut"}, {"extra_attributes": {"5jqtjuCS": {}, "eQfNkDkP": {}, "cUohIy5g": {}}, "user_id": "aIZ4G0I5"}, {"extra_attributes": {"D4kDgls9": {}, "2t62CtuG": {}, "M4BFZCmk": {}}, "user_id": "kYhezSLh"}]}]}], "namespace": "bBeFX8k4", "party_attributes": {"NWrWJeGX": {}, "faquhbjd": {}, "bpFDnCOc": {}}, "party_id": "2kiOC2mF", "queued_at": 54, "region": "YWlLnftk", "server_name": "JD4khYTC", "status": "55Nvq1vs", "updated_at": "1987-07-25T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'QueueSessionHandler' test.out

#- 10 DequeueSessionHandler
# body param: body
echo '{"match_id": "KQOk3Kv7"}' > $TEMP_JSON_INPUT
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
    --matchID 'jAlmRfyR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'QuerySessionHandler' test.out

#- 12 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 40, "userID": "7ZFtYMNy", "weight": 0.8563411126725077}' > $TEMP_JSON_INPUT
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
    --matchIDs 'ZZT0hqYD' \
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
    --strategy 'I9I6eOCI' \
    > test.out 2>&1
eval_tap $? 16 'ImportChannels' test.out

#- 17 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'ft45GJDU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetSingleMatchmakingChannel' test.out

#- 18 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "AdPG3uFv", "description": "NbW6Murb", "findMatchTimeoutSeconds": 25, "joinable": true, "max_delay_ms": 94, "ruleSet": {"alliance": {"combination": {"alliances": [{"max": 9, "min": 56, "name": "aply4vcb"}, {"max": 70, "min": 66, "name": "yjbssvpk"}, {"max": 26, "min": 39, "name": "CHOl1nzK"}], "has_combination": true}, "maxNumber": 90, "minNumber": 23, "playerMaxNumber": 62, "playerMinNumber": 60}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 100, "min": 12, "name": "XQwDy7iZ"}, {"max": 21, "min": 38, "name": "7VgrwKVj"}, {"max": 52, "min": 64, "name": "jUB4KJNB"}], "has_combination": false}, "duration": 73, "max_number": 58, "min_number": 26, "player_max_number": 80, "player_min_number": 26}, {"combination": {"alliances": [{"max": 27, "min": 85, "name": "ppXt3ofL"}, {"max": 50, "min": 71, "name": "YjfTMq9y"}, {"max": 13, "min": 15, "name": "ZpBVovqa"}], "has_combination": false}, "duration": 89, "max_number": 11, "min_number": 56, "player_max_number": 22, "player_min_number": 55}, {"combination": {"alliances": [{"max": 77, "min": 86, "name": "4qdVcTzG"}, {"max": 70, "min": 51, "name": "TYRNwOQV"}, {"max": 85, "min": 12, "name": "woBWd6G6"}], "has_combination": true}, "duration": 70, "max_number": 12, "min_number": 28, "player_max_number": 95, "player_min_number": 57}], "flexingRules": [{"attribute": "JXNsW7L8", "criteria": "RFMP9RwW", "duration": 19, "reference": 0.8917473362065389}, {"attribute": "uHAFNh9a", "criteria": "2XXSsnX2", "duration": 92, "reference": 0.7000865076385324}, {"attribute": "bb27kItq", "criteria": "ZQe00Zg4", "duration": 22, "reference": 0.4326291922309061}], "match_options": {"options": [{"name": "LVBQSU7X", "type": "zqnG3cAq"}, {"name": "mjH9WmIF", "type": "1qJuKGvY"}, {"name": "s1TdgfUh", "type": "ywPHgL4K"}]}, "matchingRules": [{"attribute": "1IklGMRz", "criteria": "hHJjoavW", "reference": 0.07854871060774293}, {"attribute": "Lxur5aVI", "criteria": "nz98ClU3", "reference": 0.8826093373164975}, {"attribute": "jxpSw2Rj", "criteria": "6jWTr91x", "reference": 0.6299409248047416}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 6, "socialMatchmaking": true, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'RXKqbbcL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchmakingChannel' test.out

#- 19 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName '8pJ6GoCV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllPartyInChannel' test.out

#- 20 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'OdGrob9S' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetAllSessionsInChannel' test.out

#- 21 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["jpG5f3n5", "dV2VS9p0", "zPlME1hY"], "party_id": "k2JNOua7", "user_id": "aSgsX9be"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'epOapv1t' \
    --matchID 'JetDnasX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AddUserIntoSessionInChannel' test.out

#- 22 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'oi3vD7xV' \
    --matchID 'Ihk86WxY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'DeleteSessionInChannel' test.out

#- 23 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'SwwelVDW' \
    --matchID '20qQz93N' \
    --namespace $AB_NAMESPACE \
    --userID 'Fs0ueBop' \
    > test.out 2>&1
eval_tap $? 23 'DeleteUserFromSessionInChannel' test.out

#- 24 SearchSessions
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessions \
    --namespace $AB_NAMESPACE \
    --channel 'ynvhamyo' \
    --deleted 'true' \
    --matchID 'n3NZFFEH' \
    --partyID 'd7avDOGy' \
    --userID 'I0l1ce9k' \
    --limit '25' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 24 'SearchSessions' test.out

#- 25 GetSessionHistoryDetailed
$CLI_EXE \
    --sn matchmaking \
    --op GetSessionHistoryDetailed \
    --matchID 'uZqLAfvR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'GetSessionHistoryDetailed' test.out

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
    --channelName 'I5Neef38' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'PublicGetSingleMatchmakingChannel' test.out

#- 29 SearchSessionsV2
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessionsV2 \
    --namespace $AB_NAMESPACE \
    --channel 'IQF0Tqd6' \
    --deleted 'false' \
    --matchID 'SjaO0Xsm' \
    --partyID 'CQvJiChZ' \
    --userID 'Ib9LW5AE' \
    --limit '87' \
    --offset '61' \
    > test.out 2>&1
eval_tap $? 29 'SearchSessionsV2' test.out

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