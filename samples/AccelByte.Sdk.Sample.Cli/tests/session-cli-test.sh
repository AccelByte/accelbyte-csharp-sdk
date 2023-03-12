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
echo "1..43"

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
echo '{"clientVersion": "bBuz5zko", "deployment": "aUEzGS3q", "inactiveTimeout": 12, "inviteTimeout": 79, "joinability": "0PbemSBE", "maxPlayers": 76, "minPlayers": 69, "name": "bZ0VBUGA", "persistent": false, "persistentTTL": 77, "requestedRegions": ["kDeev2Oj", "060HnOf5", "S8X1LxkZ"], "textChat": true, "type": "uIBroF7b"}' > $TEMP_JSON_INPUT
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
    --name 'wRgwKvzE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetConfigurationTemplateV1' test.out

#- 7 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"clientVersion": "SbhpxlDd", "deployment": "Es4igdKe", "inactiveTimeout": 76, "inviteTimeout": 26, "joinability": "AQUBqS8K", "maxPlayers": 41, "minPlayers": 93, "name": "P12c61ts", "requestedRegions": ["3fMI04rm", "2jUc9iav", "3tTqlE9o"], "textChat": true, "type": "DPD0Lfle"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name '8ESU1MO8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateConfigurationTemplateV1' test.out

#- 8 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'XnVaEyjm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteConfigurationTemplateV1' test.out

#- 9 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'ifJDYa1T' \
    --dsPodName 'JPUszmFG' \
    --fromTime 'EkJVvqDS' \
    --gameMode 'U3PDyIAG' \
    --isSoftDeleted 'fGq1FNmR' \
    --joinability 'WvUvDPnK' \
    --limit '30' \
    --matchPool 'UfwGB03t' \
    --memberID 'z8qIH4uR' \
    --offset '7' \
    --order '4ID5l5wj' \
    --orderBy '6K2wEMnc' \
    --sessionID 'kjlW6Byw' \
    --status 'sSSZTGlu' \
    --statusV2 'bsmhjXcS' \
    --toTime 'cOUvrjJB' \
    > test.out 2>&1
eval_tap $? 9 'AdminQueryGameSessions' test.out

#- 10 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'O7tbkTGY' \
    --namespace $AB_NAMESPACE \
    --sessionId 'KqRMSTis' \
    --statusType 'P0MrSdaF' \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateGameSessionMember' test.out

#- 11 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'y0pJYCdf' \
    --key 'kfyt09ro' \
    --leaderID '5fHdWqJT' \
    --limit '81' \
    --memberID 'Yc5BsdSS' \
    --memberStatus 'VaAzzn4G' \
    --offset '2' \
    --order 'XVanderc' \
    --orderBy 'f1nq4Hf3' \
    --value '2SL5PjaY' \
    > test.out 2>&1
eval_tap $? 11 'AdminQueryParties' test.out

#- 12 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'EDxaYN8w' \
    > test.out 2>&1
eval_tap $? 12 'AdminQueryPlayerAttributes' test.out

#- 13 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId '9KUW0py8' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetPlayerAttributes' test.out

#- 14 CreateGameSession
# body param: body
echo '{"attributes": {"KrcQfucS": {}, "q2X8gFuJ": {}, "ORk4j04Y": {}}, "backfillTicketID": "fnXTsQUr", "clientVersion": "A0WWyKl2", "configurationName": "K5mCSoGe", "deployment": "QCahcox6", "inactiveTimeout": 28, "inviteTimeout": 4, "joinability": "f2Hwi7vg", "matchPool": "3osbh0fL", "maxPlayers": 58, "minPlayers": 15, "persistent": false, "persistentTTL": 55, "requestedRegions": ["JvAS2W4u", "qkhwSC7E", "ajwHO3Lf"], "serverName": "vwPewrf1", "teams": [{"UserIDs": ["9Njm50xC", "DlPeNq0C", "vMXtyUWX"], "parties": [{"partyID": "rdZaFeac", "userIDs": ["GT2x6o28", "Njxyw7RH", "ldq0m7Nj"]}, {"partyID": "UZ95Z5XD", "userIDs": ["LBN9YGVP", "tkjt0OyB", "lJi4RbZ0"]}, {"partyID": "Iy11mfOF", "userIDs": ["jCzZVcGo", "mWF1oAqU", "NFDtXnXL"]}]}, {"UserIDs": ["vOAsW8wY", "h4gq7pRV", "ZVLJiDx3"], "parties": [{"partyID": "au9b9Qjh", "userIDs": ["zDlnJmi4", "XaBTgoXj", "fdUQHa3R"]}, {"partyID": "xspSqwdb", "userIDs": ["TR2sgzfa", "QrUCW9fg", "o69uv1bk"]}, {"partyID": "Fx8DmbC9", "userIDs": ["UqYdYrdx", "NnuMcAwr", "SzYnrcet"]}]}, {"UserIDs": ["xObeisZe", "lKuD0iJ6", "fs3zL9H4"], "parties": [{"partyID": "WxGWRH7f", "userIDs": ["z4BdPhLt", "HRJOImSq", "37aeAaGq"]}, {"partyID": "0NIj53gX", "userIDs": ["kmrayvcI", "YiWxIAxf", "vLzSpDFY"]}, {"partyID": "3lxe16Ks", "userIDs": ["SRzkf2Hz", "BcEio5Uy", "vuFv5z6w"]}]}], "textChat": false, "ticketIDs": ["QwMBcQUN", "PHN8YZT0", "yJJ0uCjj"], "type": "aNCRV3hS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreateGameSession' test.out

#- 15 PublicQueryGameSessions
# body param: body
echo '{"IiTEoTCS": {}, "xjAqg9oG": {}, "VEdC8mQi": {}}' > $TEMP_JSON_INPUT
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
    --podName 'r1Af0G6O' \
    > test.out 2>&1
eval_tap $? 16 'GetGameSessionByPodName' test.out

#- 17 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'rPH6Zsjp' \
    > test.out 2>&1
eval_tap $? 17 'GetGameSession' test.out

#- 18 UpdateGameSession
# body param: body
echo '{"attributes": {"PgHKISHt": {}, "B8tWdJM9": {}, "Qc5HmR0v": {}}, "backfillTicketID": "knXO45AU", "clientVersion": "tNXSTItt", "deployment": "35OJTfJB", "inactiveTimeout": 19, "inviteTimeout": 43, "joinability": "62yI9g5R", "matchPool": "DrlzPFQm", "maxPlayers": 81, "minPlayers": 43, "requestedRegions": ["u3ERxV0U", "TaiSzfi0", "FnBERe8q"], "teams": [{"UserIDs": ["NYRTYSaZ", "w4NqSNyl", "cljuNM3e"], "parties": [{"partyID": "UUSD1pZG", "userIDs": ["MfPdGIOA", "Z86un0L9", "8WUoXvfU"]}, {"partyID": "4qMIpfgx", "userIDs": ["w2ff5twR", "YbtdK2r4", "wWs6IpYB"]}, {"partyID": "xafo9b4x", "userIDs": ["JyNnvHKr", "m8UuNlT8", "6N9yO0vy"]}]}, {"UserIDs": ["D6J5brVo", "20e6POTj", "rinAVVov"], "parties": [{"partyID": "pAAXNzcp", "userIDs": ["bmX3lLFe", "XCiaXP8j", "BjK81t2V"]}, {"partyID": "9TVauFcG", "userIDs": ["kPgQ0hb2", "tLrsMeoZ", "iRYkbhEM"]}, {"partyID": "1zTNY3lp", "userIDs": ["incuf5d5", "saQvKfFR", "qBam8jPt"]}]}, {"UserIDs": ["KHTmzo0J", "mcQmnsUi", "gVynjGFy"], "parties": [{"partyID": "VicGQAVv", "userIDs": ["32ftRAsm", "C0RuRA8j", "1AJ3hNWW"]}, {"partyID": "hADRqJva", "userIDs": ["Zrf2qXQF", "CzRV1paE", "Lj5dw3LK"]}, {"partyID": "0gPYhPPG", "userIDs": ["5sAIfYtY", "ozA2OntG", "CwQSHHdP"]}]}], "ticketIDs": ["LwjTngrv", "b2E1X9ec", "BBhRAYjR"], "type": "7c4x5bIk", "version": 30}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'VB2sp2x9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateGameSession' test.out

#- 19 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'mszGGoyh' \
    > test.out 2>&1
eval_tap $? 19 'DeleteGameSession' test.out

#- 20 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"GZAzt2OV": {}, "BTLwSH8h": {}, "WRU9pbIt": {}}, "backfillTicketID": "GQ7VUWBh", "clientVersion": "GolwafIf", "deployment": "bF1GLFnr", "inactiveTimeout": 87, "inviteTimeout": 46, "joinability": "4T5cmw7U", "matchPool": "1TxiS06U", "maxPlayers": 63, "minPlayers": 36, "requestedRegions": ["oaDZpXOW", "zpXOi2cp", "ajtqcXjP"], "teams": [{"UserIDs": ["kj2IzU3M", "EpCt1Ijl", "fHJM92t9"], "parties": [{"partyID": "j1XT2Erw", "userIDs": ["IxkaTnYt", "r1YDnaXB", "0JOS4XKV"]}, {"partyID": "T66sHYPg", "userIDs": ["VsfhoEid", "Kw4IP0NV", "naangorh"]}, {"partyID": "VFpTRuQy", "userIDs": ["MroT2hNf", "KJ7q8sif", "SPmYSsBx"]}]}, {"UserIDs": ["tyKWssEn", "5VEvIMEB", "4pl506fL"], "parties": [{"partyID": "CG6EAl7d", "userIDs": ["3Ks65tht", "njcMSw1J", "42fthKUo"]}, {"partyID": "bas2CAlS", "userIDs": ["xxVhDR9h", "laznetBU", "GcQz2Wvd"]}, {"partyID": "iclkYGDL", "userIDs": ["2ckC9cdz", "aLnajQ8G", "nJpALidd"]}]}, {"UserIDs": ["v9UUtG1t", "EECsm8xa", "DOz0tMlp"], "parties": [{"partyID": "FuJVXo9s", "userIDs": ["0JPG8cgj", "HQo9HoLL", "yUnPTiCD"]}, {"partyID": "0038or8w", "userIDs": ["R0tuwIJn", "rSI2IFcR", "wSoMTuJz"]}, {"partyID": "iuDNbOyd", "userIDs": ["iu3lOaru", "uYw0iUut", "s6bChMK1"]}]}], "ticketIDs": ["gcx8p9fy", "v5PoMJeT", "IQix1FEv"], "type": "zlipE7r0", "version": 44}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'O3HkJTOP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'PatchUpdateGameSession' test.out

#- 21 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "scPA2n25"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'C1zEnAMG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdateGameSessionBackfillTicketID' test.out

#- 22 PublicGameSessionInvite
# body param: body
echo '{"userID": "mFy7w6eq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'nMeKFo7U' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PublicGameSessionInvite' test.out

#- 23 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '8Scr9xm6' \
    > test.out 2>&1
eval_tap $? 23 'JoinGameSession' test.out

#- 24 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '8w7s9RMx' \
    > test.out 2>&1
eval_tap $? 24 'LeaveGameSession' test.out

#- 25 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId '2hc45QX2' \
    > test.out 2>&1
eval_tap $? 25 'PublicGameSessionReject' test.out

#- 26 PublicPartyJoinCode
# body param: body
echo '{"code": "34xnqlbR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PublicPartyJoinCode' test.out

#- 27 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'APFQsca6' \
    > test.out 2>&1
eval_tap $? 27 'PublicGetParty' test.out

#- 28 PublicUpdateParty
# body param: body
echo '{"attributes": {"n9vGZTCC": {}, "XQ2Lf7jt": {}, "exB613cb": {}}, "inactiveTimeout": 17, "inviteTimeout": 73, "joinability": "iCpu0lhh", "maxPlayers": 12, "minPlayers": 30, "type": "utt3rQuK", "version": 85}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'vrx96OOz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PublicUpdateParty' test.out

#- 29 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"45vMiR3Q": {}, "YZJKVNlK": {}, "8PTaIXRW": {}}, "inactiveTimeout": 65, "inviteTimeout": 2, "joinability": "TyA9MDnK", "maxPlayers": 66, "minPlayers": 40, "type": "Xqq7Zk70", "version": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'hOhenJi6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'PublicPatchUpdateParty' test.out

#- 30 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'dNVF7zwj' \
    > test.out 2>&1
eval_tap $? 30 'PublicGeneratePartyCode' test.out

#- 31 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'XqlcD2Lz' \
    > test.out 2>&1
eval_tap $? 31 'PublicRevokePartyCode' test.out

#- 32 PublicPartyInvite
# body param: body
echo '{"userID": "aOwIF5tE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'sCwoAVcZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PublicPartyInvite' test.out

#- 33 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "CSj80gzF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'vpvIerFE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PublicPromotePartyLeader' test.out

#- 34 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'yxTugoTd' \
    > test.out 2>&1
eval_tap $? 34 'PublicPartyJoin' test.out

#- 35 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId '50RmJFX9' \
    > test.out 2>&1
eval_tap $? 35 'PublicPartyLeave' test.out

#- 36 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'v4GPfyGu' \
    > test.out 2>&1
eval_tap $? 36 'PublicPartyReject' test.out

#- 37 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'Q2UEl0U5' \
    --userId 'Z9UnQmZq' \
    > test.out 2>&1
eval_tap $? 37 'PublicPartyKick' test.out

#- 38 PublicCreateParty
# body param: body
echo '{"attributes": {"X15hBb4d": {}, "lNTIBDtH": {}, "unwNLLfK": {}}, "configurationName": "CQKuu2MW", "inactiveTimeout": 69, "inviteTimeout": 31, "joinability": "JuPjj8zD", "maxPlayers": 46, "members": [{"ID": "FSnM7GAv", "PlatformID": "k19sXDis", "PlatformUserID": "h7KUVhmA"}, {"ID": "wmAygsnn", "PlatformID": "8pM7l6v0", "PlatformUserID": "elLMceGG"}, {"ID": "gb5FJHWE", "PlatformID": "6s13b7dm", "PlatformUserID": "nPijw6U8"}], "minPlayers": 66, "textChat": true, "type": "7TUEBotS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicCreateParty' test.out

#- 39 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'PublicGetPlayerAttributes' test.out

#- 40 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "data": {"IwGhia6c": {}, "qoWmnhtu": {}, "zxir12r0": {}}, "platforms": [{"name": "VUWI0kJA", "userID": "czj5Apcs"}, {"name": "iEQ65llg", "userID": "GnTHAsTC"}, {"name": "Za7xE4nw", "userID": "GKlbPRxf"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PublicStorePlayerAttributes' test.out

#- 41 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 41 'PublicDeletePlayerAttributes' test.out

#- 42 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'ucxoRKFL' \
    --orderBy 'xxcL9Syu' \
    --status 'HbvRxR6L' \
    > test.out 2>&1
eval_tap $? 42 'PublicQueryMyGameSessions' test.out

#- 43 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'aKWgAVjZ' \
    --orderBy 'KDxiezEb' \
    --status 'uMCz9J4d' \
    > test.out 2>&1
eval_tap $? 43 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE