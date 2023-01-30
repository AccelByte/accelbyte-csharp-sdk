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
echo "1..42"

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
    --sn session \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 GetHealthcheckInfoV1
$CLI_EXE \
    --sn session \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 3 'GetHealthcheckInfoV1' test.out

#- 4 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"clientVersion": "M2Be7EeJ", "deployment": "9vEtUHGV", "inactiveTimeout": 13, "inviteTimeout": 92, "joinability": "D7eekpWE", "maxPlayers": 43, "minPlayers": 17, "name": "tvzP0YpN", "requestedRegions": ["E9LkYdww", "mlY7df74", "1c90dRIP"], "textChat": false, "type": "UrwZSSoa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AdminCreateConfigurationTemplateV1' test.out

#- 5 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AdminGetAllConfigurationTemplatesV1' test.out

#- 6 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'Wu7tVNkw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetConfigurationTemplateV1' test.out

#- 7 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"clientVersion": "iJoKQRju", "deployment": "O4rJvDXz", "inactiveTimeout": 37, "inviteTimeout": 69, "joinability": "o87iKwa4", "maxPlayers": 31, "minPlayers": 84, "name": "EwPAlQDA", "requestedRegions": ["xwnXVBDD", "R9aiv5Zn", "ZWcpLWq9"], "textChat": true, "type": "OsW6xbK4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'PPIOk6En' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateConfigurationTemplateV1' test.out

#- 8 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'ryJqTQEE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteConfigurationTemplateV1' test.out

#- 9 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'r6Z2CLH0' \
    --dsPodName 'SXrnwpsq' \
    --fromTime 'NyEySfib' \
    --gameMode 'd2WzKvEl' \
    --isSoftDeleted 'ffBLlXdf' \
    --joinability 'YdbcG9Zr' \
    --limit '9' \
    --matchPool 'BrzmAOen' \
    --memberID 'jiCUbKPG' \
    --offset '72' \
    --order 'Ks1jdaj6' \
    --orderBy 'iFvnX1kQ' \
    --sessionID '9NLN5VTk' \
    --status 'Xl7BfTMc' \
    --statusV2 'peYS6RVl' \
    --toTime 'tBiPHLBA' \
    > test.out 2>&1
eval_tap $? 9 'AdminQueryGameSessions' test.out

#- 10 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'dO3mdInR' \
    --namespace $AB_NAMESPACE \
    --sessionId 'IgBzmj1B' \
    --statusType 'mrwd56hg' \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateGameSessionMember' test.out

#- 11 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'T1kZX33u' \
    --key 'pObVLADX' \
    --leaderID 'Ea0IlgAl' \
    --limit '79' \
    --memberID 'NZDNztqe' \
    --memberStatus '3Lsop3Wn' \
    --offset '18' \
    --order 'Nkmjxbjf' \
    --orderBy 'qII85WD0' \
    --value 'qZVY249s' \
    > test.out 2>&1
eval_tap $? 11 'AdminQueryParties' test.out

#- 12 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'p9Z52eOq' \
    > test.out 2>&1
eval_tap $? 12 'AdminQueryPlayerAttributes' test.out

#- 13 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'JUsfMHNV' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetPlayerAttributes' test.out

#- 14 CreateGameSession
# body param: body
echo '{"attributes": {"DcaLMKg1": {}, "Z7o44FcS": {}, "RzT4N415": {}}, "backfillTicketID": "qQNGaf03", "clientVersion": "HSupn9lN", "configurationName": "1FAKZGdu", "deployment": "NhHKLydu", "inactiveTimeout": 97, "inviteTimeout": 12, "joinability": "wj56Vl0P", "matchPool": "bbC9XuRq", "maxPlayers": 51, "minPlayers": 16, "requestedRegions": ["ZCqriWRx", "o2qSdamT", "QSgSdvKh"], "serverName": "NofuVckz", "teams": [{"UserIDs": ["qzrqZfYB", "BBDOdqen", "bAvMk1fa"], "parties": [{"partyID": "VimRxzX5", "userIDs": ["pWbImvZS", "HlAdhNKl", "offkgTCn"]}, {"partyID": "SQkjVOz7", "userIDs": ["gok22iML", "1LqezhfO", "xGGVLs8o"]}, {"partyID": "3DcZcw7e", "userIDs": ["fAwsGUIj", "lSMpfRrA", "BFuMUxjd"]}]}, {"UserIDs": ["WurpsbFH", "od0WmZmV", "FT9tMztK"], "parties": [{"partyID": "7j1NbzBQ", "userIDs": ["tuk3tEw3", "EqFiDkdr", "ItRbHfFV"]}, {"partyID": "SR1FvbRn", "userIDs": ["Mxdt7SrF", "g2cgVJ7p", "BtMM1jfV"]}, {"partyID": "rEbFWROI", "userIDs": ["9ivGZDMX", "r1aXw4GI", "h6I6u6FX"]}]}, {"UserIDs": ["KrXbuvmM", "agTa6DHF", "h1Tr4wim"], "parties": [{"partyID": "tHBznjvL", "userIDs": ["N4X4jcAq", "MnKt0T5t", "TxkrhLro"]}, {"partyID": "y93ZoBiQ", "userIDs": ["P2G98rRZ", "wgpNEqiG", "KnSDJmZC"]}, {"partyID": "9Yn7PtT7", "userIDs": ["RkTOLYrv", "R3LILx0J", "AFfXPOeb"]}]}], "textChat": true, "ticketIDs": ["05s701lU", "ZKZHGiEB", "rBJd6jRZ"], "type": "VTa8bDaT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreateGameSession' test.out

#- 15 PublicQueryGameSessions
# body param: body
echo '{"28pyKS3t": {}, "4CqKGdYd": {}, "taRbBLyG": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'PublicQueryGameSessions' test.out

#- 16 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName '8bKxpHhs' \
    > test.out 2>&1
eval_tap $? 16 'GetGameSessionByPodName' test.out

#- 17 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'H460aCXQ' \
    > test.out 2>&1
eval_tap $? 17 'GetGameSession' test.out

#- 18 UpdateGameSession
# body param: body
echo '{"attributes": {"yt8kNZ0d": {}, "1Ha4qtaI": {}, "muM5F2ZJ": {}}, "backfillTicketID": "72HniIY2", "clientVersion": "wigNuAes", "deployment": "hL7enBnT", "inactiveTimeout": 64, "inviteTimeout": 84, "joinability": "Sms66VoB", "matchPool": "7kLkwvz2", "maxPlayers": 92, "minPlayers": 42, "requestedRegions": ["y0vELHiY", "a6mr3GM5", "Z4tEfZZg"], "teams": [{"UserIDs": ["6tEJS6nb", "lAzpXdfV", "4eVCiN1M"], "parties": [{"partyID": "n1uv5BxK", "userIDs": ["o6pk6vqK", "tWGX1WZN", "B1I9M7dE"]}, {"partyID": "VnymRJrS", "userIDs": ["wdWoquso", "IcPivEdF", "c8G5mt3a"]}, {"partyID": "lEvxSeth", "userIDs": ["kCk11g3E", "lurd9Dn7", "4Cycw7YM"]}]}, {"UserIDs": ["TmSC9C3y", "fib0W2yE", "iLsgQvyc"], "parties": [{"partyID": "V7Eza0Th", "userIDs": ["L57OFXag", "UvPV7LQB", "uRaj4t0y"]}, {"partyID": "U0MvZoMI", "userIDs": ["Ex7WUaUa", "r9IeJXyn", "j1VevxcZ"]}, {"partyID": "oTLB9HjE", "userIDs": ["sgl6Be3d", "nMQLZpB3", "u7wAl3GH"]}]}, {"UserIDs": ["lMx1yVfg", "HyytWZ2C", "lEekce1t"], "parties": [{"partyID": "rjeZL0b3", "userIDs": ["9lYSFlko", "slZsCWj5", "FZ3G264a"]}, {"partyID": "wjFWmg4p", "userIDs": ["OXkdLTvf", "BuqmHoer", "xiieCper"]}, {"partyID": "hHDFwK6f", "userIDs": ["WQXDV0mi", "K2VKrLs1", "tAS6fTEN"]}]}], "ticketIDs": ["ui6gc1tc", "vY4nUu6b", "fjfe3Fb8"], "type": "85UQVPjA", "version": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '0848BG4L' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateGameSession' test.out

#- 19 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'C5j3uzoK' \
    > test.out 2>&1
eval_tap $? 19 'DeleteGameSession' test.out

#- 20 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"2x1PFDE9": {}, "fzyGk0X0": {}, "C6oVpjRc": {}}, "backfillTicketID": "zIq2IiOs", "clientVersion": "4I2aqSzn", "deployment": "kbSFZgii", "inactiveTimeout": 4, "inviteTimeout": 62, "joinability": "TxQ5SPuA", "matchPool": "fuEgkxGc", "maxPlayers": 62, "minPlayers": 3, "requestedRegions": ["VboDb3Zh", "rdHoLIDs", "5ZppIADz"], "teams": [{"UserIDs": ["qfAUFFAa", "EYIWADnV", "P4GpZhsg"], "parties": [{"partyID": "dBoxn0ij", "userIDs": ["y73MNsUH", "WtK28BtV", "mjl5fvOa"]}, {"partyID": "NOgp3MOQ", "userIDs": ["rdzVjzzA", "HXFGx9ie", "tiFOmx67"]}, {"partyID": "23XXiFey", "userIDs": ["E9HXeeB3", "Zeyvcwr6", "t66FojQy"]}]}, {"UserIDs": ["yNWO0oZR", "lpjnxt7H", "z49I5QuX"], "parties": [{"partyID": "DZ1O1WAQ", "userIDs": ["gT7qLdYv", "STth6hB3", "UQ0zrXPl"]}, {"partyID": "MnZbPw60", "userIDs": ["pyrbaVSE", "9wWlWrv8", "qNq9TVxA"]}, {"partyID": "yg9KtjnB", "userIDs": ["urfRGPRj", "bZTv0iJK", "gN4TkmCg"]}]}, {"UserIDs": ["qNFKQlhS", "iclscP3q", "ifeK9F0B"], "parties": [{"partyID": "jk08rxw6", "userIDs": ["1jLuLfXD", "YiTOCkvx", "rk5YDf3F"]}, {"partyID": "kCZ1JNgK", "userIDs": ["u0tq03X0", "feulDdP1", "yPVi9VSz"]}, {"partyID": "EQIZZYoU", "userIDs": ["hjHlFG1B", "g3IlUA7n", "9Ij0qhlF"]}]}], "ticketIDs": ["bkC9pcGK", "Jm7FhrNs", "7HrhCpJ7"], "type": "jgQnxUM2", "version": 81}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'lvs1N1LC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'PatchUpdateGameSession' test.out

#- 21 PublicGameSessionInvite
# body param: body
echo '{"userID": "agKJi5di"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'wDLeDBvL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'PublicGameSessionInvite' test.out

#- 22 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'SjPASK4O' \
    > test.out 2>&1
eval_tap $? 22 'JoinGameSession' test.out

#- 23 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '0dVrjF8x' \
    > test.out 2>&1
eval_tap $? 23 'LeaveGameSession' test.out

#- 24 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'RB0mLhoM' \
    > test.out 2>&1
eval_tap $? 24 'PublicGameSessionReject' test.out

#- 25 PublicPartyJoinCode
# body param: body
echo '{"code": "M20PrLRK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicPartyJoinCode' test.out

#- 26 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'YQCNzYst' \
    > test.out 2>&1
eval_tap $? 26 'PublicGetParty' test.out

#- 27 PublicUpdateParty
# body param: body
echo '{"attributes": {"Xnx6juMx": {}, "Rf2N5KR4": {}, "0o0FmuVU": {}}, "inactiveTimeout": 17, "inviteTimeout": 100, "joinability": "rAbL8DYe", "maxPlayers": 79, "minPlayers": 44, "type": "7jK07xlq", "version": 77}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId '7bXQzDsY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'PublicUpdateParty' test.out

#- 28 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"dvmAqGbo": {}, "v4IWeZTL": {}, "ZPInV7eF": {}}, "inactiveTimeout": 0, "inviteTimeout": 65, "joinability": "vWysyHf0", "maxPlayers": 2, "minPlayers": 42, "type": "v5B3mjHK", "version": 39}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'EVexTsiq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PublicPatchUpdateParty' test.out

#- 29 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'H0E8T2n1' \
    > test.out 2>&1
eval_tap $? 29 'PublicGeneratePartyCode' test.out

#- 30 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'lHqU2H5C' \
    > test.out 2>&1
eval_tap $? 30 'PublicRevokePartyCode' test.out

#- 31 PublicPartyInvite
# body param: body
echo '{"userID": "yeV9PrSj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'xxnMLZv0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicPartyInvite' test.out

#- 32 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "ICeqfRAF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId '70dXrXdC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PublicPromotePartyLeader' test.out

#- 33 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId '6IRW65kK' \
    > test.out 2>&1
eval_tap $? 33 'PublicPartyJoin' test.out

#- 34 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'iNL3FsbP' \
    > test.out 2>&1
eval_tap $? 34 'PublicPartyLeave' test.out

#- 35 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'QhjjXwHx' \
    > test.out 2>&1
eval_tap $? 35 'PublicPartyReject' test.out

#- 36 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'FaVfA9aq' \
    --userId 'f85xzvfO' \
    > test.out 2>&1
eval_tap $? 36 'PublicPartyKick' test.out

#- 37 PublicCreateParty
# body param: body
echo '{"attributes": {"CQYkc3Vg": {}, "cZqgOQ2X": {}, "3EujNMDy": {}}, "configurationName": "ZOhKGGE9", "inactiveTimeout": 86, "inviteTimeout": 60, "joinability": "4gz7IV9c", "maxPlayers": 70, "members": [{"ID": "0X9Rqckm", "PlatformID": "gqlmofuY", "PlatformUserID": "GGIzOvTM"}, {"ID": "9Rq665zA", "PlatformID": "uc98uZ2y", "PlatformUserID": "rpAPMe2j"}, {"ID": "lsnGodx8", "PlatformID": "A7HQNrsN", "PlatformUserID": "423qpZdK"}], "minPlayers": 32, "textChat": false, "type": "emvheK24"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'PublicCreateParty' test.out

#- 38 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'PublicGetPlayerAttributes' test.out

#- 39 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "data": {"BzUTiIYc": {}, "81VuUdpJ": {}, "F40DGpdN": {}}, "platforms": [{"name": "RXHpjmnA", "userID": "8HW8jkjJ"}, {"name": "rz4v9oI8", "userID": "edKK0fnL"}, {"name": "W2Af4bJA", "userID": "L5Z2UOdU"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicStorePlayerAttributes' test.out

#- 40 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'PublicDeletePlayerAttributes' test.out

#- 41 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'PvQjHcEH' \
    --orderBy 'B0ZuELgZ' \
    --status '6xkg9YIT' \
    > test.out 2>&1
eval_tap $? 41 'PublicQueryMyGameSessions' test.out

#- 42 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'TdaRh73C' \
    --orderBy 'nRGois3f' \
    --status 'xREaVZrf' \
    > test.out 2>&1
eval_tap $? 42 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE