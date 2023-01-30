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
    --limit '86' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "3fk620Cw", "description": "xIVWubjh", "find_match_timeout_seconds": 44, "game_mode": "sHxljpX0", "joinable": true, "max_delay_ms": 51, "rule_set": {"alliance": {"combination": {"alliances": [{"max": 42, "min": 62, "name": "j74PxMd8"}, {"max": 38, "min": 56, "name": "nYy0XnZg"}, {"max": 12, "min": 77, "name": "0yKWXAWb"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 84, "role_flexing_second": 44}, "max_number": 59, "min_number": 3, "player_max_number": 79, "player_min_number": 61}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 2, "min": 38, "name": "pJ7KhO6m"}, {"max": 59, "min": 99, "name": "y9ctWirF"}, {"max": 40, "min": 95, "name": "OcGLvTDE"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 53, "role_flexing_second": 52}, "duration": 47, "max_number": 45, "min_number": 71, "player_max_number": 87, "player_min_number": 53}, {"combination": {"alliances": [{"max": 8, "min": 78, "name": "ZkKfFTt9"}, {"max": 5, "min": 66, "name": "wR5OjBkh"}, {"max": 0, "min": 81, "name": "O50QMlYD"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 93, "role_flexing_second": 79}, "duration": 25, "max_number": 85, "min_number": 79, "player_max_number": 12, "player_min_number": 11}, {"combination": {"alliances": [{"max": 48, "min": 87, "name": "XbTQ2uKe"}, {"max": 6, "min": 57, "name": "HkhvAbjM"}, {"max": 41, "min": 1, "name": "i4rakL7e"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 81, "role_flexing_second": 93}, "duration": 60, "max_number": 40, "min_number": 26, "player_max_number": 98, "player_min_number": 0}], "flexing_rule": [{"attribute": "HWWVRaQW", "criteria": "u556YrhP", "duration": 29, "reference": 0.7426510104491592}, {"attribute": "vz2OizTe", "criteria": "RbeA0wlX", "duration": 74, "reference": 0.17189056910094846}, {"attribute": "Kay9qWzU", "criteria": "uBxmCqqh", "duration": 76, "reference": 0.7992036270573867}], "match_options": {"options": [{"name": "6aR1DN84", "type": "ss2kvt8a"}, {"name": "FdtfGmJ2", "type": "6ge8euSl"}, {"name": "e3wNWj4z", "type": "tf0dwS9Z"}]}, "matching_rule": [{"attribute": "iRrL36Ms", "criteria": "wH5WnpUa", "reference": 0.6460908745432322}, {"attribute": "OOfQA4SM", "criteria": "tHbuo82l", "reference": 0.10826737934979813}, {"attribute": "iaZoo3UB", "criteria": "IyGZrQ8k", "reference": 0.6281626652858312}], "rebalance_enable": true, "sub_game_modes": {"fvThxmln": {"alliance": {"combination": {"alliances": [{"max": 60, "min": 70, "name": "wCHrAstQ"}, {"max": 45, "min": 67, "name": "32oxIvMc"}, {"max": 3, "min": 78, "name": "GnEU0Pj4"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 0, "role_flexing_second": 57}, "max_number": 93, "min_number": 20, "player_max_number": 46, "player_min_number": 54}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 68, "min": 84, "name": "7iR1zz3Q"}, {"max": 40, "min": 33, "name": "qI2GKjUz"}, {"max": 23, "min": 0, "name": "Esd2MJ8z"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 45, "role_flexing_second": 69}, "duration": 26, "max_number": 18, "min_number": 24, "player_max_number": 42, "player_min_number": 40}, {"combination": {"alliances": [{"max": 13, "min": 66, "name": "g6Xf4PO7"}, {"max": 50, "min": 40, "name": "8mFs56G0"}, {"max": 91, "min": 37, "name": "gk6kEvcs"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 90, "role_flexing_second": 98}, "duration": 90, "max_number": 93, "min_number": 95, "player_max_number": 93, "player_min_number": 29}, {"combination": {"alliances": [{"max": 91, "min": 62, "name": "BcNJb0rY"}, {"max": 48, "min": 55, "name": "kQwftOjs"}, {"max": 45, "min": 8, "name": "ozj5ZNCx"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 95, "role_flexing_second": 14}, "duration": 48, "max_number": 16, "min_number": 63, "player_max_number": 70, "player_min_number": 43}], "name": "swxCn3Sc"}, "u62I2usl": {"alliance": {"combination": {"alliances": [{"max": 80, "min": 81, "name": "jFNxvS0S"}, {"max": 83, "min": 14, "name": "b8WaBEt9"}, {"max": 29, "min": 21, "name": "MZ0tHsma"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 94, "role_flexing_second": 11}, "max_number": 44, "min_number": 83, "player_max_number": 29, "player_min_number": 50}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 95, "min": 32, "name": "7xIlynQD"}, {"max": 55, "min": 27, "name": "MfLzAurl"}, {"max": 13, "min": 42, "name": "7U4JwL4u"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 84, "role_flexing_second": 35}, "duration": 82, "max_number": 76, "min_number": 57, "player_max_number": 40, "player_min_number": 76}, {"combination": {"alliances": [{"max": 63, "min": 43, "name": "trJhZ2qP"}, {"max": 38, "min": 25, "name": "8JLMOQ3c"}, {"max": 30, "min": 80, "name": "SwLHTXo7"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 53, "role_flexing_second": 86}, "duration": 16, "max_number": 2, "min_number": 71, "player_max_number": 19, "player_min_number": 44}, {"combination": {"alliances": [{"max": 40, "min": 47, "name": "jFO3kB6b"}, {"max": 98, "min": 55, "name": "U3Lbi88d"}, {"max": 52, "min": 10, "name": "gdHFZoQy"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 7, "role_flexing_second": 98}, "duration": 82, "max_number": 68, "min_number": 51, "player_max_number": 28, "player_min_number": 3}], "name": "e4qoLCFG"}, "WabweXYD": {"alliance": {"combination": {"alliances": [{"max": 77, "min": 6, "name": "pjWkSFPu"}, {"max": 16, "min": 44, "name": "E4NyOcEO"}, {"max": 98, "min": 97, "name": "0NIcwDiz"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 32, "role_flexing_second": 81}, "max_number": 80, "min_number": 97, "player_max_number": 63, "player_min_number": 2}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 99, "min": 65, "name": "qRfnEUuc"}, {"max": 31, "min": 0, "name": "AEmqs3Hj"}, {"max": 61, "min": 68, "name": "oyQdHTst"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 9, "role_flexing_second": 69}, "duration": 94, "max_number": 36, "min_number": 67, "player_max_number": 98, "player_min_number": 9}, {"combination": {"alliances": [{"max": 35, "min": 94, "name": "zXIRbvjK"}, {"max": 16, "min": 64, "name": "FVqIYvkd"}, {"max": 19, "min": 43, "name": "rtbhLKNj"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 98, "role_flexing_second": 10}, "duration": 2, "max_number": 78, "min_number": 30, "player_max_number": 16, "player_min_number": 30}, {"combination": {"alliances": [{"max": 24, "min": 50, "name": "2sTYfx3w"}, {"max": 29, "min": 24, "name": "t4rR40jD"}, {"max": 19, "min": 50, "name": "EjcHxMhM"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 37, "role_flexing_second": 17}, "duration": 70, "max_number": 93, "min_number": 42, "player_max_number": 90, "player_min_number": 38}], "name": "9TG2jdqZ"}}}, "session_queue_timeout_seconds": 45, "social_matchmaking": false, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
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
    --channel 'sZK37NZb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "PL950KZm", "players": [{"results": [{"attribute": "UO5kDHJD", "value": 0.43122357347722806}, {"attribute": "yTJlmyC3", "value": 0.5019439097401669}, {"attribute": "rKABwfg7", "value": 0.6383613750859642}], "user_id": "wdCJzIUP"}, {"results": [{"attribute": "CHICcaRT", "value": 0.7907867576804449}, {"attribute": "dKSsNH9u", "value": 0.5989660386857687}, {"attribute": "myiBClms", "value": 0.5634700632438764}], "user_id": "zOv7IQSV"}, {"results": [{"attribute": "ykQtaNP4", "value": 0.4209131260919571}, {"attribute": "h9YuAXJ9", "value": 0.7431429382255141}, {"attribute": "OSQtuBNW", "value": 0.2805370905529444}], "user_id": "18nE7Oh5"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 Rebalance
# body param: body
echo '{"match_id": "gJWyVtI3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'Rebalance' test.out

#- 9 QueueSessionHandler
# body param: body
echo '{"channel": "xVrLoSWG", "client_version": "a2loDtmD", "deployment": "qVHTTa9L", "error_code": 62, "error_message": "vG3lvFFl", "game_mode": "Y5uinY8n", "joinable": false, "match_id": "lh7LJrTE", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 81, "party_attributes": {"dJqPNr4V": {}, "FUzl7LpZ": {}, "hCqaOOC2": {}}, "party_id": "3LOnox3w", "party_members": [{"extra_attributes": {"vb15rqpu": {}, "KfRHnyBr": {}, "4l2HPmyb": {}}, "user_id": "dZC9qLi9"}, {"extra_attributes": {"A2UXEx7k": {}, "yhf1Tdud": {}, "5DteeiO2": {}}, "user_id": "CZfpN6to"}, {"extra_attributes": {"3pWXBAzA": {}, "gEQksaFF": {}, "URKcANHg": {}}, "user_id": "6idIxTBX"}], "ticket_id": "4yldOsLI"}, {"first_ticket_created_at": 19, "party_attributes": {"CSwzFSsa": {}, "XUwno4gl": {}, "c67iIfie": {}}, "party_id": "4v5NuDtP", "party_members": [{"extra_attributes": {"XJFBboAv": {}, "HOzzoxjK": {}, "988hw9a9": {}}, "user_id": "Ovo8sgGf"}, {"extra_attributes": {"9hGKLsnu": {}, "aSCoiqwj": {}, "62HEAHUP": {}}, "user_id": "DzvRiiNM"}, {"extra_attributes": {"wjW2rUGk": {}, "ilblEwjE": {}, "XQw0sAw4": {}}, "user_id": "FTxbqvf8"}], "ticket_id": "lKXMzu5q"}, {"first_ticket_created_at": 77, "party_attributes": {"L5XufBXb": {}, "OwvwLZrK": {}, "zckwgA2h": {}}, "party_id": "TGK7bc6W", "party_members": [{"extra_attributes": {"IU35N8XT": {}, "uj2nL4eG": {}, "pd4kIzWU": {}}, "user_id": "qCoGS5sA"}, {"extra_attributes": {"ekuzseDu": {}, "ZKBfJ05q": {}, "apUceaQy": {}}, "user_id": "LaP8kFqw"}, {"extra_attributes": {"S99T46qr": {}, "1SmSrmIa": {}, "dk99Xrsn": {}}, "user_id": "BbenAtlq"}], "ticket_id": "4sMi613F"}]}, {"matching_parties": [{"first_ticket_created_at": 77, "party_attributes": {"Ud8X6fOj": {}, "zZ6ojaqh": {}, "Yh6AU2uR": {}}, "party_id": "3RovDtnn", "party_members": [{"extra_attributes": {"r8dnaiB4": {}, "50kGdksy": {}, "mCh1Mba8": {}}, "user_id": "uvDPS5sj"}, {"extra_attributes": {"k0qQyxfZ": {}, "FOUi9OVB": {}, "FcrgfZ3a": {}}, "user_id": "7DJPtldx"}, {"extra_attributes": {"N83Jg0Cg": {}, "GnEasqRa": {}, "t2ArUKUl": {}}, "user_id": "fTuDzeHZ"}], "ticket_id": "uGC4TPzR"}, {"first_ticket_created_at": 100, "party_attributes": {"Ftxbj9C6": {}, "UjpmhWs5": {}, "IUWQebvq": {}}, "party_id": "ufBP5sML", "party_members": [{"extra_attributes": {"pFUud5Sr": {}, "yciF9FTz": {}, "Kx09RZiw": {}}, "user_id": "nL3uqwbC"}, {"extra_attributes": {"WEIIT1kr": {}, "KgB7e71d": {}, "AemHlHrh": {}}, "user_id": "ySo34ztf"}, {"extra_attributes": {"YPSryX4d": {}, "hPff4wZ8": {}, "Xg9ZbuiI": {}}, "user_id": "t5KETFjT"}], "ticket_id": "NAuMaxXV"}, {"first_ticket_created_at": 30, "party_attributes": {"UThfmDxB": {}, "6KJ7dxx5": {}, "nOtDPQYj": {}}, "party_id": "BQiISWjb", "party_members": [{"extra_attributes": {"ZlLJyOox": {}, "vN5gSwHx": {}, "Zt6n6MNm": {}}, "user_id": "77okn0PW"}, {"extra_attributes": {"OMBRK131": {}, "BKaLadFD": {}, "BOES3MLd": {}}, "user_id": "lwdufGK6"}, {"extra_attributes": {"Q2NazQMv": {}, "dBSPboQc": {}, "7rAhPhdg": {}}, "user_id": "peBuriaA"}], "ticket_id": "fPUC45VF"}]}, {"matching_parties": [{"first_ticket_created_at": 88, "party_attributes": {"oFvFrN09": {}, "wCJ68AKH": {}, "4yq2rxS5": {}}, "party_id": "rIn7tIFw", "party_members": [{"extra_attributes": {"Pm744beZ": {}, "Hcb2bXEK": {}, "pXTR2nCf": {}}, "user_id": "tkhEtTRG"}, {"extra_attributes": {"lffVJ5Jm": {}, "idNwgEkJ": {}, "O7nC3szF": {}}, "user_id": "lX8ij7tj"}, {"extra_attributes": {"A2EM2Vbn": {}, "yaWvXXaY": {}, "HvllavR7": {}}, "user_id": "xWranNFQ"}], "ticket_id": "iv5vi62l"}, {"first_ticket_created_at": 30, "party_attributes": {"9C1693Vk": {}, "LTYjhQEj": {}, "x07SZnbk": {}}, "party_id": "e7hjKyWg", "party_members": [{"extra_attributes": {"eXNJUSgy": {}, "NLnftxIA": {}, "uds5jyvD": {}}, "user_id": "po4IEofr"}, {"extra_attributes": {"vzwmz8kU": {}, "REyRUhQU": {}, "YQRL3s2U": {}}, "user_id": "K840IbMv"}, {"extra_attributes": {"EpRGCdcB": {}, "FmuAHmVw": {}, "aHjqgeHY": {}}, "user_id": "qhyeAGuR"}], "ticket_id": "E37NypnZ"}, {"first_ticket_created_at": 11, "party_attributes": {"loolMsYm": {}, "5fu8SZiL": {}, "nQLXqgMO": {}}, "party_id": "IHhORBdK", "party_members": [{"extra_attributes": {"jD86H7aS": {}, "PBS3l9kX": {}, "UxBdsZTv": {}}, "user_id": "y2xTkc7J"}, {"extra_attributes": {"xxBw3khJ": {}, "N6vfDknG": {}, "7FIzNDvn": {}}, "user_id": "BGQxHAvp"}, {"extra_attributes": {"bkrTWI82": {}, "CNIbkeFb": {}, "HOcZ9s3k": {}}, "user_id": "0PRUog5U"}], "ticket_id": "afIPQlYw"}]}], "namespace": "6h5J90Jr", "party_attributes": {"EhpPrW1R": {}, "QDpgg5nQ": {}, "LmBnjsvN": {}}, "party_id": "XbmgmrTT", "queued_at": 81, "region": "FCLMXnCy", "server_name": "dZfn1TvP", "status": "SNALgcoL", "ticket_id": "cDuYBTNc", "updated_at": "1987-10-05T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'QueueSessionHandler' test.out

#- 10 DequeueSessionHandler
# body param: body
echo '{"match_id": "uHeAFKfr"}' > $TEMP_JSON_INPUT
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
    --matchID 'cofrn92E' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'QuerySessionHandler' test.out

#- 12 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 91, "userID": "yHGDbFdf", "weight": 0.7750596239000579}' > $TEMP_JSON_INPUT
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
    --matchIDs 'Tfbyorxr' \
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
    --strategy 'AA9D0SUb' \
    > test.out 2>&1
eval_tap $? 16 'ImportChannels' test.out

#- 17 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'geTVgYdj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetSingleMatchmakingChannel' test.out

#- 18 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "Bj6f6da6", "description": "c2KRaaTs", "findMatchTimeoutSeconds": 56, "joinable": true, "max_delay_ms": 94, "ruleSet": {"alliance": {"combination": {"alliances": [{"max": 41, "min": 92, "name": "fHIaqJZD"}, {"max": 85, "min": 61, "name": "Uac1SYI5"}, {"max": 81, "min": 14, "name": "zNkwPGy8"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 71, "role_flexing_second": 58}, "maxNumber": 86, "minNumber": 45, "playerMaxNumber": 100, "playerMinNumber": 16}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 44, "min": 57, "name": "PfNZgxAU"}, {"max": 35, "min": 51, "name": "qhEuZmmn"}, {"max": 58, "min": 32, "name": "A3ez2XIb"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 89, "role_flexing_second": 48}, "duration": 55, "max_number": 34, "min_number": 31, "player_max_number": 26, "player_min_number": 74}, {"combination": {"alliances": [{"max": 31, "min": 22, "name": "6FYqNzYB"}, {"max": 86, "min": 32, "name": "GOXvOmC0"}, {"max": 22, "min": 30, "name": "zOXBkVuh"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 18, "role_flexing_second": 36}, "duration": 37, "max_number": 20, "min_number": 42, "player_max_number": 68, "player_min_number": 23}, {"combination": {"alliances": [{"max": 97, "min": 83, "name": "NrrjXdX2"}, {"max": 69, "min": 10, "name": "zc2mB8Bj"}, {"max": 59, "min": 96, "name": "X41m9HfD"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 41, "role_flexing_second": 31}, "duration": 70, "max_number": 16, "min_number": 72, "player_max_number": 57, "player_min_number": 97}], "flexingRules": [{"attribute": "yPqGY9PY", "criteria": "qwt0V9Di", "duration": 3, "reference": 0.7561416099688475}, {"attribute": "Ea7rlmaN", "criteria": "gxD2OAkB", "duration": 73, "reference": 0.273437372821832}, {"attribute": "vxDBmsfz", "criteria": "n5lBxOnH", "duration": 67, "reference": 0.5483818770471829}], "match_options": {"options": [{"name": "ppNBn3G8", "type": "fIntjhNc"}, {"name": "1cdNuRvK", "type": "hbHkLkxV"}, {"name": "A2KgAJcv", "type": "d5DB7Qo4"}]}, "matchingRules": [{"attribute": "7H0wuSVW", "criteria": "Q2YuEDpp", "reference": 0.21824256956796173}, {"attribute": "c3et6xLm", "criteria": "sMnG4WGv", "reference": 0.3941167398937119}, {"attribute": "EATzJarK", "criteria": "7YcFmI3c", "reference": 0.3369445790477523}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 54, "socialMatchmaking": false, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'yUh6oEfJ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchmakingChannel' test.out

#- 19 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'dPGSaou6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllPartyInChannel' test.out

#- 20 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'bE4bFrdH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetAllSessionsInChannel' test.out

#- 21 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["ubgcunq7", "ScCglkr7", "sQz0ZwL7"], "party_id": "qhwFLgnl", "user_id": "Q7P0sICj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'gOBmn5kV' \
    --matchID 'QtH1g2Fa' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AddUserIntoSessionInChannel' test.out

#- 22 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'jOOwBM7p' \
    --matchID 'xWYATy0H' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'DeleteSessionInChannel' test.out

#- 23 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName '6lSOiDM2' \
    --matchID 'o9qm9rhy' \
    --namespace $AB_NAMESPACE \
    --userID 'k2i5776b' \
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
    --channelName 'uElsyjp9' \
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