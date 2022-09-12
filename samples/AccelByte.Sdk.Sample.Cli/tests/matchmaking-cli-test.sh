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
    --limit '8' \
    --offset '86' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "JtBXUCV3", "description": "Kk3GOeaB", "find_match_timeout_seconds": 63, "game_mode": "bhQmNstW", "joinable": false, "max_delay_ms": 34, "rule_set": {"alliance": {"combination": {"alliances": [{"max": 26, "min": 76, "name": "lPbHrz2n"}, {"max": 64, "min": 22, "name": "HLgtDyP2"}, {"max": 52, "min": 74, "name": "YycpnMVV"}], "has_combination": true}, "max_number": 32, "min_number": 83, "player_max_number": 28, "player_min_number": 79}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 15, "min": 60, "name": "HKbYHTPy"}, {"max": 94, "min": 80, "name": "zKEtiLeb"}, {"max": 93, "min": 2, "name": "0VhQZeUf"}], "has_combination": true}, "duration": 35, "max_number": 87, "min_number": 51, "player_max_number": 8, "player_min_number": 59}, {"combination": {"alliances": [{"max": 33, "min": 62, "name": "VwY7Dgk1"}, {"max": 64, "min": 63, "name": "wOtgD0cg"}, {"max": 88, "min": 61, "name": "LMyaqqwM"}], "has_combination": false}, "duration": 10, "max_number": 1, "min_number": 53, "player_max_number": 74, "player_min_number": 83}, {"combination": {"alliances": [{"max": 17, "min": 0, "name": "caysxxAD"}, {"max": 53, "min": 22, "name": "DVN96qXi"}, {"max": 89, "min": 16, "name": "rtplz2BY"}], "has_combination": true}, "duration": 98, "max_number": 93, "min_number": 84, "player_max_number": 44, "player_min_number": 99}], "flexing_rule": [{"attribute": "9KKk5beU", "criteria": "CR3wm3gH", "duration": 51, "reference": 0.531543605093181}, {"attribute": "C0py2T0D", "criteria": "ZL5LFP3v", "duration": 42, "reference": 0.39186693315778454}, {"attribute": "9e1o3pCj", "criteria": "KR7buRS8", "duration": 60, "reference": 0.6552800481669759}], "match_options": {"options": [{"name": "h1JSqhGA", "type": "xAuwqFGn"}, {"name": "wbSbBmgx", "type": "a429xN8R"}, {"name": "dwBjgUbb", "type": "NoaBxzQR"}]}, "matching_rule": [{"attribute": "6JvWNcjA", "criteria": "bEYqhfxO", "reference": 0.41531529671879985}, {"attribute": "KjtxQ3Nv", "criteria": "rdE9unQs", "reference": 0.6803946667740469}, {"attribute": "afiXp2mL", "criteria": "pbRX0End", "reference": 0.6764327739604009}], "sub_game_modes": {"QnpSBLXk": {"alliance": {"combination": {"alliances": [{"max": 69, "min": 66, "name": "7WqDfvfs"}, {"max": 38, "min": 19, "name": "yYx7ODuF"}, {"max": 19, "min": 46, "name": "QP2ZoFjk"}], "has_combination": false}, "max_number": 79, "min_number": 55, "player_max_number": 8, "player_min_number": 15}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 62, "min": 63, "name": "Tb3DLSGB"}, {"max": 14, "min": 58, "name": "npEU8zUZ"}, {"max": 88, "min": 68, "name": "VQe1RFRH"}], "has_combination": true}, "duration": 35, "max_number": 30, "min_number": 74, "player_max_number": 38, "player_min_number": 57}, {"combination": {"alliances": [{"max": 94, "min": 66, "name": "u95t7vgW"}, {"max": 27, "min": 49, "name": "iyq3Eme8"}, {"max": 40, "min": 12, "name": "JU3wFFqe"}], "has_combination": false}, "duration": 31, "max_number": 52, "min_number": 3, "player_max_number": 21, "player_min_number": 27}, {"combination": {"alliances": [{"max": 79, "min": 49, "name": "7Q76YscX"}, {"max": 54, "min": 0, "name": "5aGklK58"}, {"max": 73, "min": 70, "name": "llAheU6Q"}], "has_combination": false}, "duration": 18, "max_number": 67, "min_number": 76, "player_max_number": 71, "player_min_number": 34}], "name": "lGuG5xdx"}, "Jx9ODpvf": {"alliance": {"combination": {"alliances": [{"max": 81, "min": 94, "name": "CszETgwd"}, {"max": 60, "min": 25, "name": "N0FamowF"}, {"max": 67, "min": 20, "name": "zjwAFckP"}], "has_combination": false}, "max_number": 41, "min_number": 91, "player_max_number": 70, "player_min_number": 6}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 94, "min": 15, "name": "PM0oP3fP"}, {"max": 17, "min": 52, "name": "nYoxwdOT"}, {"max": 0, "min": 0, "name": "rgwgOohN"}], "has_combination": false}, "duration": 22, "max_number": 49, "min_number": 90, "player_max_number": 37, "player_min_number": 73}, {"combination": {"alliances": [{"max": 35, "min": 78, "name": "ynqoh9We"}, {"max": 84, "min": 68, "name": "XAZktqJv"}, {"max": 74, "min": 45, "name": "2HyeE6YV"}], "has_combination": true}, "duration": 93, "max_number": 22, "min_number": 60, "player_max_number": 78, "player_min_number": 40}, {"combination": {"alliances": [{"max": 12, "min": 34, "name": "hRAUBTRX"}, {"max": 27, "min": 79, "name": "BeeHPCXY"}, {"max": 31, "min": 82, "name": "xd73Y6CP"}], "has_combination": true}, "duration": 30, "max_number": 88, "min_number": 32, "player_max_number": 18, "player_min_number": 6}], "name": "BeokNiyr"}, "JvvAlXt6": {"alliance": {"combination": {"alliances": [{"max": 50, "min": 95, "name": "eFaLsssI"}, {"max": 90, "min": 66, "name": "anO5WVNr"}, {"max": 89, "min": 90, "name": "t1uNZyz1"}], "has_combination": true}, "max_number": 3, "min_number": 20, "player_max_number": 10, "player_min_number": 28}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 22, "min": 63, "name": "cYp2fsRC"}, {"max": 3, "min": 38, "name": "co1gHKCx"}, {"max": 55, "min": 38, "name": "89KQhEnn"}], "has_combination": false}, "duration": 67, "max_number": 1, "min_number": 93, "player_max_number": 85, "player_min_number": 93}, {"combination": {"alliances": [{"max": 96, "min": 2, "name": "QpNjNhkw"}, {"max": 85, "min": 99, "name": "sSVz7zUa"}, {"max": 48, "min": 13, "name": "vbSaMCLF"}], "has_combination": true}, "duration": 56, "max_number": 42, "min_number": 49, "player_max_number": 65, "player_min_number": 84}, {"combination": {"alliances": [{"max": 77, "min": 12, "name": "WVtLxiJ4"}, {"max": 71, "min": 94, "name": "jJHS9XFI"}, {"max": 96, "min": 63, "name": "bt4vCbHb"}], "has_combination": true}, "duration": 73, "max_number": 95, "min_number": 32, "player_max_number": 14, "player_min_number": 28}], "name": "7zO6EvcS"}}}, "session_queue_timeout_seconds": 16, "social_matchmaking": false, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
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
    --channel 'WZSV5ocp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteChannelHandler' test.out

#- 7 StoreMatchResults
# body param: body
echo '{"match_id": "0ng29AH1", "players": [{"results": [{"attribute": "v4mkUwYz", "value": 0.6634145185500161}, {"attribute": "lJr3Ei2d", "value": 0.26812562608787316}, {"attribute": "TiLSAHEU", "value": 0.6506810169823853}], "user_id": "hbfSp7nU"}, {"results": [{"attribute": "5VhxcSzu", "value": 0.9719736923725733}, {"attribute": "VJltTj9Y", "value": 0.4159666688660226}, {"attribute": "qKDszdZo", "value": 0.636746463595955}], "user_id": "fdqP7gyM"}, {"results": [{"attribute": "HeoI8Aaf", "value": 0.4978464452654815}, {"attribute": "odVoj4ul", "value": 0.8613166836580665}, {"attribute": "wNwt4j7c", "value": 0.49191499155286267}], "user_id": "ltyGTSMd"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'StoreMatchResults' test.out

#- 8 Rebalance
# body param: body
echo '{"match_id": "l7jPVvfs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'Rebalance' test.out

#- 9 QueueSessionHandler
# body param: body
echo '{"channel": "djuq6Lno", "client_version": "klS2mGZp", "deployment": "02qCutEZ", "game_mode": "wIJTOZBd", "joinable": true, "match_id": "fgAYiT1L", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 72, "party_attributes": {"MutswtjK": {}, "D5hNj8Zq": {}, "EUGdLYEW": {}}, "party_id": "wqcgf3AN", "party_members": [{"extra_attributes": {"po88LQ7z": {}, "lP81l8iN": {}, "ijwzixna": {}}, "user_id": "YjDObLjJ"}, {"extra_attributes": {"OblF7QS8": {}, "PIkkDeDc": {}, "8aaWLL3z": {}}, "user_id": "vDfMVHdW"}, {"extra_attributes": {"BfLXllAt": {}, "bfcc8VCf": {}, "oiFq9MVs": {}}, "user_id": "Dvwzy2Bf"}]}, {"first_ticket_created_at": 40, "party_attributes": {"GG0Aru3U": {}, "oyhF88fN": {}, "hWt94V8l": {}}, "party_id": "XL59bt5l", "party_members": [{"extra_attributes": {"QpB9GVKD": {}, "gvsR4hTC": {}, "AN9IyTNU": {}}, "user_id": "73BTrhlV"}, {"extra_attributes": {"NfYxXuVZ": {}, "A4yaNPUo": {}, "y8ecQehN": {}}, "user_id": "m7hZImwl"}, {"extra_attributes": {"WJkR0aVS": {}, "H73ITp13": {}, "IUikBBi5": {}}, "user_id": "uZhYefOZ"}]}, {"first_ticket_created_at": 75, "party_attributes": {"VygatGJz": {}, "Yr0FHghx": {}, "25YEfM4q": {}}, "party_id": "fyod01wF", "party_members": [{"extra_attributes": {"HzoXOln0": {}, "aoouIFDW": {}, "1AjKhJuX": {}}, "user_id": "lJdqw0Vv"}, {"extra_attributes": {"G16AJTMJ": {}, "UxexHG39": {}, "xBbCNOYf": {}}, "user_id": "qDgOAXio"}, {"extra_attributes": {"xQERIBYP": {}, "uAsBHhwg": {}, "mRP7pvd4": {}}, "user_id": "IM37P9yo"}]}]}, {"matching_parties": [{"first_ticket_created_at": 96, "party_attributes": {"V1jIa6mh": {}, "pa0OUlpm": {}, "PpTVTpZW": {}}, "party_id": "8NWcJfqE", "party_members": [{"extra_attributes": {"aL6qIFHv": {}, "BEQBkp2C": {}, "5rC2XFfV": {}}, "user_id": "z103IppD"}, {"extra_attributes": {"BvE5QOap": {}, "m90Gs7oF": {}, "i6NjemPx": {}}, "user_id": "AwNYtV7j"}, {"extra_attributes": {"xVaLJp0H": {}, "1U3y2oZ5": {}, "J1sSLyPV": {}}, "user_id": "ybJ8W3Tq"}]}, {"first_ticket_created_at": 26, "party_attributes": {"V4njakvV": {}, "tYKCNTsn": {}, "ngWHKSVR": {}}, "party_id": "cV6mDh4y", "party_members": [{"extra_attributes": {"kHQpk5ZF": {}, "hdqR6SN7": {}, "w1OIsFsx": {}}, "user_id": "cWgIQION"}, {"extra_attributes": {"SofhvDfP": {}, "rdVuO8hI": {}, "JdBi6sfj": {}}, "user_id": "xfj9qonx"}, {"extra_attributes": {"YAYQ7373": {}, "NTY4Y5JI": {}, "S1ZIR7Su": {}}, "user_id": "oRNX3lvY"}]}, {"first_ticket_created_at": 15, "party_attributes": {"NBPeUFhd": {}, "kmtrtogB": {}, "gERAFes3": {}}, "party_id": "Zm7p71kz", "party_members": [{"extra_attributes": {"6foTiGD7": {}, "XNIChDe4": {}, "uMPqPfph": {}}, "user_id": "erg6rrH8"}, {"extra_attributes": {"yFZCtZ2F": {}, "1EIHg1pw": {}, "ymIn9fRT": {}}, "user_id": "MTcIcION"}, {"extra_attributes": {"ksQnxpPs": {}, "iMJrA9c0": {}, "A0az9pn2": {}}, "user_id": "pocjWSZz"}]}]}, {"matching_parties": [{"first_ticket_created_at": 65, "party_attributes": {"oU2GgeiW": {}, "VwuAzWb5": {}, "DG7LZcDi": {}}, "party_id": "Fsp6xPXG", "party_members": [{"extra_attributes": {"9putQFuu": {}, "sQgDHHh5": {}, "TOUrTbbQ": {}}, "user_id": "Rxfz9ZVh"}, {"extra_attributes": {"Lowlus1o": {}, "gxeWRFrB": {}, "cuWSWw1T": {}}, "user_id": "SoWqYyne"}, {"extra_attributes": {"ibFGAaus": {}, "BuB3RDBV": {}, "vW6B6Riu": {}}, "user_id": "kiKMP7r7"}]}, {"first_ticket_created_at": 62, "party_attributes": {"rRraJgUV": {}, "NIwz04H3": {}, "5ILa55cy": {}}, "party_id": "Jv3ehivQ", "party_members": [{"extra_attributes": {"dLyyTiPK": {}, "hsI1sE9Y": {}, "2xQzpU0A": {}}, "user_id": "latbBHzH"}, {"extra_attributes": {"VE0Salh6": {}, "nlabC821": {}, "tPaG7L0X": {}}, "user_id": "pzrJaYAE"}, {"extra_attributes": {"FVk9Ho5v": {}, "hx2txb33": {}, "DRzTdQEO": {}}, "user_id": "QMns2xvz"}]}, {"first_ticket_created_at": 24, "party_attributes": {"kI9byAxj": {}, "rNgXuHed": {}, "tJKh69yu": {}}, "party_id": "EUES5Npt", "party_members": [{"extra_attributes": {"N6yQyoP4": {}, "x77j48G9": {}, "DUWLvk0U": {}}, "user_id": "rxLTZ5hc"}, {"extra_attributes": {"6QTN26Yo": {}, "QgET85vO": {}, "qUSbESPt": {}}, "user_id": "FFoEGwPB"}, {"extra_attributes": {"S4VWPFjN": {}, "PCBkact3": {}, "im0RtJ8g": {}}, "user_id": "YgwmpHjz"}]}]}], "namespace": "93uOiZlj", "party_attributes": {"vThj3CS2": {}, "Txy6hb8M": {}, "gHPXPniE": {}}, "party_id": "8Jf2fzQo", "queued_at": 81, "region": "I2hYIJR4", "server_name": "iwxHzMrZ", "status": "Uf3MmBlM", "updated_at": "1997-11-10T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'QueueSessionHandler' test.out

#- 10 DequeueSessionHandler
# body param: body
echo '{"match_id": "gPdAYmyn"}' > $TEMP_JSON_INPUT
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
    --matchID 'ByWHid26' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'QuerySessionHandler' test.out

#- 12 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 5, "userID": "vVYHJhsJ", "weight": 0.09628995493292536}' > $TEMP_JSON_INPUT
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
    --matchIDs 'GDBsxD6a' \
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
    --strategy 'QGxOjhfF' \
    > test.out 2>&1
eval_tap $? 16 'ImportChannels' test.out

#- 17 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'sOUpdzWN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetSingleMatchmakingChannel' test.out

#- 18 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "PXjCrLaS", "description": "GBCCg3a6", "findMatchTimeoutSeconds": 70, "joinable": false, "max_delay_ms": 4, "ruleSet": {"alliance": {"combination": {"alliances": [{"max": 58, "min": 60, "name": "2iEPmhxc"}, {"max": 94, "min": 15, "name": "KNQ6H1n0"}, {"max": 21, "min": 41, "name": "FYlrUmec"}], "has_combination": true}, "maxNumber": 31, "minNumber": 51, "playerMaxNumber": 39, "playerMinNumber": 4}, "alliance_flexing_rule": [{"combination": {"alliances": [{"max": 88, "min": 71, "name": "3JoF8GC1"}, {"max": 67, "min": 6, "name": "EJR09poB"}, {"max": 4, "min": 50, "name": "jknZwfAW"}], "has_combination": false}, "duration": 99, "max_number": 48, "min_number": 63, "player_max_number": 79, "player_min_number": 85}, {"combination": {"alliances": [{"max": 18, "min": 76, "name": "BQxzxCO9"}, {"max": 87, "min": 54, "name": "qz4kDoxB"}, {"max": 66, "min": 16, "name": "Ls9JbKfi"}], "has_combination": true}, "duration": 83, "max_number": 74, "min_number": 90, "player_max_number": 71, "player_min_number": 44}, {"combination": {"alliances": [{"max": 7, "min": 19, "name": "gUqizAd5"}, {"max": 69, "min": 46, "name": "bumDFGTK"}, {"max": 18, "min": 88, "name": "qL4273Vz"}], "has_combination": true}, "duration": 3, "max_number": 33, "min_number": 1, "player_max_number": 66, "player_min_number": 13}], "flexingRules": [{"attribute": "y3JGUmDz", "criteria": "Xsp4LkPg", "duration": 76, "reference": 0.48251781011324113}, {"attribute": "UxWmWbj1", "criteria": "66Um4oAi", "duration": 7, "reference": 0.0916005625336147}, {"attribute": "F16sPhB5", "criteria": "iXEel2Ol", "duration": 89, "reference": 0.7647012796215149}], "match_options": {"options": [{"name": "zLTabKio", "type": "FZAjap9Y"}, {"name": "vUtaWJHE", "type": "06FKjLBg"}, {"name": "9zQPGNrc", "type": "9zbRHr9a"}]}, "matchingRules": [{"attribute": "R6gtj0rc", "criteria": "vupI7M54", "reference": 0.6788145175577948}, {"attribute": "m9x8Vc9A", "criteria": "3W7qhqHl", "reference": 0.5259292333517612}, {"attribute": "EytC6r8W", "criteria": "f0blbvGU", "reference": 0.5125712515198163}], "sub_game_modes": {}}, "sessionQueueTimeoutSeconds": 11, "socialMatchmaking": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'jt8uPA8S' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchmakingChannel' test.out

#- 19 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'SW7nR5vi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetAllPartyInChannel' test.out

#- 20 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName '6XphCh99' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetAllSessionsInChannel' test.out

#- 21 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["SRycDW5f", "XOSqGj62", "65AVsNZN"], "party_id": "gWsNWFEI", "user_id": "RaSAu02L"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'i1T8ZEWy' \
    --matchID 'zd9ovV88' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AddUserIntoSessionInChannel' test.out

#- 22 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'w58fHGPl' \
    --matchID 'KyxVKqQ8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'DeleteSessionInChannel' test.out

#- 23 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName '78JxAjcR' \
    --matchID '5ZHF2XQM' \
    --namespace $AB_NAMESPACE \
    --userID 'ZmNRGczu' \
    > test.out 2>&1
eval_tap $? 23 'DeleteUserFromSessionInChannel' test.out

#- 24 SearchSessions
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessions \
    --namespace $AB_NAMESPACE \
    --channel 'mNCImoOV' \
    --deleted 'false' \
    --matchID 'q3nF9gpk' \
    --partyID 'qNhynwV4' \
    --userID '8UP77Xs9' \
    --limit '69' \
    --offset '63' \
    > test.out 2>&1
eval_tap $? 24 'SearchSessions' test.out

#- 25 GetSessionHistoryDetailed
$CLI_EXE \
    --sn matchmaking \
    --op GetSessionHistoryDetailed \
    --matchID 'oqNfGCwL' \
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
    --channelName 'cjdRuBc0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'PublicGetSingleMatchmakingChannel' test.out

#- 29 SearchSessionsV2
$CLI_EXE \
    --sn matchmaking \
    --op SearchSessionsV2 \
    --namespace $AB_NAMESPACE \
    --channel 'uL0ZgtDJ' \
    --deleted 'true' \
    --matchID 'Wn5u7lZU' \
    --partyID 'm5IRmGJd' \
    --userID 'F0UEPkmp' \
    --limit '37' \
    --offset '96' \
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