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
    --limit '91' \
    --offset '52' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "vCYtCQFi", "description": "ImslK3AP", "find_match_timeout_seconds": 100, "game_mode": "fWbPoDZU", "joinable": false, "max_delay_ms": 74, "rule_set": {"alliance": {"combination": {"alliances": [{"max": 50, "min": 60, "name": "weAM51EB"}, {"max": 79, "min": 24, "name": "jjDNDxEw"}, {"max": 53, "min": 81, "name": "Fpso6MOd"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 89, "role_flexing_second": 9}, "max_number": 65, "min_number": 84, "player_max_number": 40, "player_min_number": 95}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 99, "min": 6, "name": "lMgnmBtn"}, {"max": 99, "min": 41, "name": "0SgZY1uu"}, {"max": 39, "min": 22, "name": "KX1JMOJ6"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 87, "role_flexing_second": 54}, "duration": 66, "max_number": 19, "min_number": 24, "player_max_number": 3, "player_min_number": 94}, {"combination": {"alliances": [{"max": 22, "min": 6, "name": "BFsVu2Fr"}, {"max": 79, "min": 40, "name": "HX7BRnQV"}, {"max": 56, "min": 99, "name": "QB8k4bWR"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 69, "role_flexing_second": 11}, "duration": 8, "max_number": 44, "min_number": 67, "player_max_number": 70, "player_min_number": 78}, {"combination": {"alliances": [{"max": 76, "min": 96, "name": "l4qI3UbW"}, {"max": 83, "min": 9, "name": "ITkNhEml"}, {"max": 59, "min": 53, "name": "UXZml1Bh"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 79, "role_flexing_second": 9}, "duration": 53, "max_number": 54, "min_number": 67, "player_max_number": 63, "player_min_number": 83}], "flexing_rule": [{"attribute": "IMZweqQb", "criteria": "TnrSmJ0y", "duration": 47, "reference": 0.06997727617748195}, {"attribute": "h1qzIPcb", "criteria": "FWLC7J4a", "duration": 81, "reference": 0.8827746542480864}, {"attribute": "RnBVMoLh", "criteria": "n1zvrqsh", "duration": 64, "reference": 0.9301998139511357}], "match_options": {"options": [{"name": "a9h8cMpd", "type": "aI8sCsCp"}, {"name": "ijed70n9", "type": "pJSJHQeW"}, {"name": "gKSERVeR", "type": "ANBbD2ja"}]}, "matching_rule": [{"attribute": "tPZU7lSt", "criteria": "nCLEVc2B", "reference": 0.09411209014718547}, {"attribute": "6vLXH3Ij", "criteria": "uzyRnJv3", "reference": 0.22077273230859917}, {"attribute": "KsCaHxQT", "criteria": "2NoXCLBr", "reference": 0.06293424951384108}], "rebalance_enable": true, "sub_game_modes": {"uXQWDvrd": {"alliance": {"combination": {"alliances": [{"max": 79, "min": 26, "name": "PfFu7jCb"}, {"max": 53, "min": 92, "name": "5Oy65ftu"}, {"max": 71, "min": 30, "name": "evUexorL"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 48, "role_flexing_second": 58}, "max_number": 62, "min_number": 99, "player_max_number": 5, "player_min_number": 32}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 90, "min": 44, "name": "IexoiQSy"}, {"max": 91, "min": 86, "name": "Bp9Vl457"}, {"max": 87, "min": 24, "name": "aEuqeDzK"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 37, "role_flexing_second": 8}, "duration": 94, "max_number": 55, "min_number": 29, "player_max_number": 70, "player_min_number": 20}, {"combination": {"alliances": [{"max": 11, "min": 58, "name": "Q4V4Oyov"}, {"max": 73, "min": 19, "name": "H0mmfNeh"}, {"max": 58, "min": 59, "name": "lx2FWppH"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 81, "role_flexing_second": 87}, "duration": 44, "max_number": 53, "min_number": 53, "player_max_number": 91, "player_min_number": 53}, {"combination": {"alliances": [{"max": 42, "min": 66, "name": "GVy1vnzL"}, {"max": 88, "min": 20, "name": "arUSHMe1"}, {"max": 55, "min": 10, "name": "M4wI7GV8"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 20, "role_flexing_second": 19}, "duration": 92, "max_number": 10, "min_number": 15, "player_max_number": 29, "player_min_number": 56}], "name": "KkieMhwC"}, "adcOgpIj": {"alliance": {"combination": {"alliances": [{"max": 23, "min": 7, "name": "ekYDCSLZ"}, {"max": 45, "min": 90, "name": "N3caFuai"}, {"max": 15, "min": 68, "name": "wDHJ1ixi"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 34, "role_flexing_second": 35}, "max_number": 68, "min_number": 8, "player_max_number": 79, "player_min_number": 71}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 27, "min": 83, "name": "7GaiCaqI"}, {"max": 56, "min": 41, "name": "kZ0QqZsc"}, {"max": 47, "min": 14, "name": "zoJcyYI7"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 94, "role_flexing_second": 81}, "duration": 59, "max_number": 58, "min_number": 87, "player_max_number": 18, "player_min_number": 92}, {"combination": {"alliances": [{"max": 21, "min": 80, "name": "nmvv11hD"}, {"max": 66, "min": 69, "name": "CpbdCecG"}, {"max": 50, "min": 42, "name": "sOO0q5AJ"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 41, "role_flexing_second": 23}, "duration": 15, "max_number": 4, "min_number": 95, "player_max_number": 5, "player_min_number": 36}, {"combination": {"alliances": [{"max": 64, "min": 32, "name": "AzzFpbSM"}, {"max": 26, "min": 70, "name": "xt5xsIgE"}, {"max": 58, "min": 11, "name": "xaewI3bU"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 99, "role_flexing_second": 44}, "duration": 20, "max_number": 52, "min_number": 17, "player_max_number": 91, "player_min_number": 97}], "name": "nu9A19R9"}, "CiaN6oam": {"alliance": {"combination": {"alliances": [{"max": 1, "min": 94, "name": "pto4vQA3"}, {"max": 45, "min": 63, "name": "M2G1jxKi"}, {"max": 13, "min": 7, "name": "3RobJ6uS"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 27, "role_flexing_second": 92}, "max_number": 10, "min_number": 46, "player_max_number": 53, "player_min_number": 99}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 12, "min": 84, "name": "5BpqpQQz"}, {"max": 1, "min": 25, "name": "OTR7qGjt"}, {"max": 60, "min": 32, "name": "v90hijUs"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 79, "role_flexing_second": 75}, "duration": 68, "max_number": 66, "min_number": 61, "player_max_number": 60, "player_min_number": 71}, {"combination": {"alliances": [{"max": 79, "min": 20, "name": "xZq4N9Xn"}, {"max": 58, "min": 30, "name": "u9dwFkOj"}, {"max": 59, "min": 6, "name": "qG3wagv7"}], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 55, "role_flexing_second": 65}, "duration": 98, "max_number": 76, "min_number": 99, "player_max_number": 32, "player_min_number": 42}, {"combination": {"alliances": [{"max": 36, "min": 44, "name": "oFR3lqM5"}, {"max": 38, "min": 61, "name": "XpWrwtqm"}, {"max": 36, "min": 18, "name": "tfhQtklH"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 69, "role_flexing_second": 40}, "duration": 83, "max_number": 11, "min_number": 34, "player_max_number": 54, "player_min_number": 89}], "name": "Xzl2k0eG"}}}, "session_queue_timeout_seconds": 34, "social_matchmaking": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
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
    --channel 'MvMJ6FBG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "Tzs7EBQT", "players": [{"results": [{"attribute": "r0cs4P3p", "value": 0.04564060710673823}, {"attribute": "nyKen6dz", "value": 0.4197613155569526}, {"attribute": "P7iBPlnF", "value": 0.016574803037950003}], "user_id": "DnzbSvoK"}, {"results": [{"attribute": "I51PlF4L", "value": 0.47790612828008483}, {"attribute": "MfMnEPwP", "value": 0.3515628283188873}, {"attribute": "OjFCtSeX", "value": 0.07663398643376795}], "user_id": "2uJp9XOs"}, {"results": [{"attribute": "cfGHHl1V", "value": 0.4745582832953641}, {"attribute": "B8QJEbS7", "value": 0.3584879071476471}, {"attribute": "63gSQiDo", "value": 0.27429909719544276}], "user_id": "02jOtWny"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 Rebalance
# body param: body
echo '{"match_id": "pV2M01Yi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'Rebalance' test.out

#- 9 QueueSessionHandler
# body param: body
echo '{"channel": "WEisng2x", "client_version": "T7XeaKIC", "deployment": "uY4iYijt", "error_code": 92, "error_message": "fx2COe8E", "game_mode": "ByoDvVy0", "joinable": true, "match_id": "txVsRUWe", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 37, "party_attributes": {"UhWgYo6T": {}, "AedZarZa": {}, "Y8N4AmI2": {}}, "party_id": "bZAU5oIr", "party_members": [{"extra_attributes": {"OrbdCYao": {}, "1DcbLytG": {}, "Ns9IA4SY": {}}, "user_id": "z1YZDFpI"}, {"extra_attributes": {"i2S8a0pd": {}, "WdCBkRkd": {}, "URuXY1Sb": {}}, "user_id": "YtG59AD7"}, {"extra_attributes": {"VCYyg4hO": {}, "r7ZHUCmB": {}, "cMHkwtvX": {}}, "user_id": "RcOEof7k"}], "ticket_id": "JoN5h0SU"}, {"first_ticket_created_at": 84, "party_attributes": {"6UOxIAkb": {}, "f6rGSm7l": {}, "jaMl0LWx": {}}, "party_id": "0gJLU06y", "party_members": [{"extra_attributes": {"vE1Y6Vfu": {}, "96gJilUD": {}, "dPx8lGut": {}}, "user_id": "Bj5hMl3B"}, {"extra_attributes": {"qpL0AyrK": {}, "ma10hpnm": {}, "RGO36UNV": {}}, "user_id": "ubdUSluj"}, {"extra_attributes": {"98HjwjDq": {}, "4KqdrDJg": {}, "sQj5cn4A": {}}, "user_id": "6W2ZodU7"}], "ticket_id": "z2iouEv3"}, {"first_ticket_created_at": 57, "party_attributes": {"savolG2e": {}, "xnnrx7xw": {}, "tWu6K94e": {}}, "party_id": "TnRzV7Za", "party_members": [{"extra_attributes": {"Bcme3XiF": {}, "dngiZm2t": {}, "U4RvdAmt": {}}, "user_id": "V7UK7tfT"}, {"extra_attributes": {"Njk0rcrC": {}, "leTQppdY": {}, "jdwdojtc": {}}, "user_id": "q4IeYtJb"}, {"extra_attributes": {"dWTMU9Fq": {}, "zjshyBe9": {}, "gO3ViYge": {}}, "user_id": "DVZtyXkN"}], "ticket_id": "DpVOK0Bb"}]}, {"matching_parties": [{"first_ticket_created_at": 11, "party_attributes": {"OKkyk8PS": {}, "GvJLrSiR": {}, "h2T1ohdi": {}}, "party_id": "Hd96kgur", "party_members": [{"extra_attributes": {"Zl0GPIJs": {}, "tRjIrDXh": {}, "Q0B8r3tC": {}}, "user_id": "xCy5VzgU"}, {"extra_attributes": {"wDMpoTbr": {}, "Gkgwltr3": {}, "sfPGtBqQ": {}}, "user_id": "NGuKKt7N"}, {"extra_attributes": {"aWmCpBsj": {}, "JMEi1Evh": {}, "cd4sLgNu": {}}, "user_id": "nMbsD5xV"}], "ticket_id": "CfhSYc3f"}, {"first_ticket_created_at": 55, "party_attributes": {"CBQoViwb": {}, "6btqEyHe": {}, "ZI9jK6ML": {}}, "party_id": "NI5QJOJS", "party_members": [{"extra_attributes": {"LMMxGmtt": {}, "TJuAhi81": {}, "GqBgWSHK": {}}, "user_id": "taqcOFO3"}, {"extra_attributes": {"qELxPx73": {}, "7m7eXJUw": {}, "7COAOhwK": {}}, "user_id": "g6dbZyoq"}, {"extra_attributes": {"TU0FaLaI": {}, "YE7Mn28x": {}, "J8WbqTwo": {}}, "user_id": "mwTZYheK"}], "ticket_id": "SzybQfys"}, {"first_ticket_created_at": 56, "party_attributes": {"vHafgt9N": {}, "uIfRhP8G": {}, "MskoDvxN": {}}, "party_id": "yIktGLKQ", "party_members": [{"extra_attributes": {"FM4ZHfV1": {}, "69WURn77": {}, "13bijNB7": {}}, "user_id": "rD2n7mDL"}, {"extra_attributes": {"3pMWp31x": {}, "NdcGfoYM": {}, "3ZSyqhKX": {}}, "user_id": "IF294bk5"}, {"extra_attributes": {"5VgRPmdd": {}, "2Bom76JY": {}, "YOcHID67": {}}, "user_id": "f27SETLl"}], "ticket_id": "Xj7Q65oz"}]}, {"matching_parties": [{"first_ticket_created_at": 47, "party_attributes": {"tZARhmtf": {}, "oe522bQf": {}, "Fb8DSqk3": {}}, "party_id": "rbjKZSBO", "party_members": [{"extra_attributes": {"HiekWlmc": {}, "rWJURPQe": {}, "v3mD0oSx": {}}, "user_id": "SRr3Q85E"}, {"extra_attributes": {"47vSV6el": {}, "btGupI3j": {}, "vLtQh4Dj": {}}, "user_id": "vfkajJWa"}, {"extra_attributes": {"4ap6iwSa": {}, "1ocoL7y2": {}, "p7QnEDYe": {}}, "user_id": "aAKM8SEr"}], "ticket_id": "DjI7at4F"}, {"first_ticket_created_at": 34, "party_attributes": {"eSJqsfuZ": {}, "CkmBPF0m": {}, "ki5EVCkd": {}}, "party_id": "rPriURbp", "party_members": [{"extra_attributes": {"6DIujm3s": {}, "fgbuFRUG": {}, "3sjMY0mp": {}}, "user_id": "rEnA2uaX"}, {"extra_attributes": {"FYQugBS7": {}, "YogcI0Gq": {}, "Lwj6cPk7": {}}, "user_id": "fJjZaZof"}, {"extra_attributes": {"y14qoiLZ": {}, "JswLzdYP": {}, "AWdEOae3": {}}, "user_id": "m4xpHEpG"}], "ticket_id": "DZkA1pk9"}, {"first_ticket_created_at": 79, "party_attributes": {"tDVTtjx3": {}, "Ft73Qss9": {}, "MlAKAutm": {}}, "party_id": "EGx0CHZf", "party_members": [{"extra_attributes": {"m70zomLp": {}, "vzsjVYj5": {}, "AFfNhe5I": {}}, "user_id": "aloaN5MQ"}, {"extra_attributes": {"jwDFpoM8": {}, "cL69jWgw": {}, "VUgQWBCB": {}}, "user_id": "kj7ger5S"}, {"extra_attributes": {"OUy88Kyy": {}, "WUSvxPr2": {}, "4ZkYIxdA": {}}, "user_id": "FjqJ1p4a"}], "ticket_id": "MJ5VkkIJ"}]}], "namespace": "lRCfGalP", "party_attributes": {"Kv21QOUr": {}, "vxGDgrmS": {}, "xJoAOSif": {}}, "party_id": "loTEAq6E", "queued_at": 52, "region": "BmwESxgd", "server_name": "V1c0u7Vx", "status": "SjEQ55Rw", "ticket_id": "w1m45Xuv", "updated_at": "1983-07-07T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'QueueSessionHandler' test.out

#- 10 DequeueSessionHandler
# body param: body
echo '{"match_id": "yDeacY8f"}' > $TEMP_JSON_INPUT
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
    --matchID 'KwXRWd5p' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'QuerySessionHandler' test.out

#- 12 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 74, "userID": "s4mRTQub", "weight": 0.9858813573542572}' > $TEMP_JSON_INPUT
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
    --matchIDs 'cUtXA1yR' \
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
    --strategy 'CtBsFhDe' \
    > test.out 2>&1
eval_tap $? 16 'ImportChannels' test.out

#- 17 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'H2mm4ujh' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetSingleMatchmakingChannel' test.out

#- 18 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "fpbtLmPc", "description": "A9FYqWlF", "findMatchTimeoutSeconds": 20, "joinable": true, "max_delay_ms": 39, "ruleSet": {"alliance": {"combination": {"alliances": [{"max": 27, "min": 37, "name": "B936aBG2"}, {"max": 9, "min": 38, "name": "c0wvsr1K"}, {"max": 37, "min": 62, "name": "Jkw4duoX"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 76, "role_flexing_second": 19}, "maxNumber": 73, "minNumber": 99, "playerMaxNumber": 20, "playerMinNumber": 27}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 27, "min": 94, "name": "ULCHkLpX"}, {"max": 51, "min": 70, "name": "KT0YjtLR"}, {"max": 4, "min": 59, "name": "USMUW5uB"}], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 75, "role_flexing_second": 26}, "duration": 33, "max_number": 3, "min_number": 18, "player_max_number": 88, "player_min_number": 63}, {"combination": {"alliances": [{"max": 31, "min": 79, "name": "Y9RpIMqq"}, {"max": 3, "min": 78, "name": "993FbJ2X"}, {"max": 48, "min": 28, "name": "45jjbJy4"}], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 29, "role_flexing_second": 30}, "duration": 0, "max_number": 53, "min_number": 90, "player_max_number": 15, "player_min_number": 57}, {"combination": {"alliances": [{"max": 13, "min": 41, "name": "ZaQSOTqW"}, {"max": 12, "min": 24, "name": "FmcwFuyc"}, {"max": 66, "min": 28, "name": "avZiMxSb"}], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 58, "role_flexing_second": 35}, "duration": 86, "max_number": 20, "min_number": 88, "player_max_number": 67, "player_min_number": 23}], "flexingRules": [{"attribute": "G6abqGRn", "criteria": "681DIKqY", "duration": 85, "reference": 0.968795231090732}, {"attribute": "Gaj5A7jd", "criteria": "Nl1vLBWi", "duration": 87, "reference": 0.13556893688289473}, {"attribute": "kiD1mVP8", "criteria": "DPUXeJVQ", "duration": 23, "reference": 0.9513856055771895}], "match_options": {"options": [{"name": "VfbBqv23", "type": "u8pfjMcV"}, {"name": "OfQ3mjyb", "type": "T85TOCnb"}, {"name": "g9cn3dru", "type": "mYEIdVJu"}]}, "matchingRules": [{"attribute": "KoM1LWbh", "criteria": "izsWrNil", "reference": 0.7614243336527274}, {"attribute": "qEqzmyZF", "criteria": "SUcUNBF3", "reference": 0.5103758671948115}, {"attribute": "oPM1vb73", "criteria": "kiYrRfda", "reference": 0.22195303533429045}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 26, "socialMatchmaking": false, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName '3f1pRNWs' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchmakingChannel' test.out

#- 19 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'JeWNBTGL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllPartyInChannel' test.out

#- 20 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'YPFpQWL6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetAllSessionsInChannel' test.out

#- 21 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["iwU4lB35", "RNn3ugSG", "5ZZbjGtr"], "party_id": "Uugt7kw5", "user_id": "YTFVVV4m"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'jBDj8wNQ' \
    --matchID 'sDm52028' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AddUserIntoSessionInChannel' test.out

#- 22 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'dNpJgiQL' \
    --matchID '4PA6tdAI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'DeleteSessionInChannel' test.out

#- 23 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'AC9Cm5lV' \
    --matchID 'adFy6ekv' \
    --namespace $AB_NAMESPACE \
    --userID 'A255uhpO' \
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
    --channelName 'MutWCwL8' \
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