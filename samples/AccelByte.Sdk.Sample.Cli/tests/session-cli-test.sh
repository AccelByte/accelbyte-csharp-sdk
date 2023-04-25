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
echo "1..48"

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

#- 4 AdminGetDSMCConfigurationDefault
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfigurationDefault \
    > test.out 2>&1
eval_tap $? 4 'AdminGetDSMCConfigurationDefault' test.out

#- 5 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 2, "SessionTitle": "Yi3wMWnoZgIhwb8Y", "XboxServiceConfigID": "YMLqpQwkRRHkaiKs", "XboxSessionTemplateName": "mIiRLR3IlNJKxhPf"}, "clientVersion": "WV6dIabcFbSmeuIB", "deployment": "roF7bwRgwKvzESbh", "inactiveTimeout": 32, "inviteTimeout": 47, "joinability": "cgAoGfXepE3r5AQU", "maxPlayers": 56, "minPlayers": 34, "name": "5GZi5P12c61ts3fM", "persistent": false, "requestedRegions": ["4rm2jUc9iav3tTql", "E9oLDPD0Lfle8ESU", "1MO8XnVaEyjmifJD"], "textChat": false, "type": "4TsbQsxYFxGGHrfQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminCreateConfigurationTemplateV1' test.out

#- 6 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '21' \
    --offset '60' \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAllConfigurationTemplatesV1' test.out

#- 7 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'gXkiA5IZPqCqp9vc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminGetConfigurationTemplateV1' test.out

#- 8 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 50, "SessionTitle": "RWvUvDPnKoECjGUg", "XboxServiceConfigID": "867xodwuG14ID5l5", "XboxSessionTemplateName": "wj6K2wEMnckjlW6B"}, "clientVersion": "ywsSSZTGlubsmhjX", "deployment": "cScOUvrjJBO7tbkT", "inactiveTimeout": 67, "inviteTimeout": 90, "joinability": "YKqRMSTisP0MrSda", "maxPlayers": 64, "minPlayers": 50, "name": "zyZsb4FvWFIHPIbO", "persistent": false, "requestedRegions": ["fHdWqJTNjrmpnnEc", "kHH8kT9oXVanderc", "f1nq4Hf32SL5PjaY"], "textChat": true, "type": "UOqv7WmCuqcsNM7Y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'Anbq4DjmYUMhD9qU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminUpdateConfigurationTemplateV1' test.out

#- 9 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name '89D356pVsUtNandd' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminDeleteConfigurationTemplateV1' test.out

#- 10 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetDSMCConfiguration' test.out

#- 11 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminSyncDSMCConfiguration' test.out

#- 12 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'zgwxYdQc5hEfefdo' \
    --dsPodName 'pcEM0JHfof2Hwi7v' \
    --fromTime 'g3osbh0fL2h7eJvA' \
    --gameMode 'S2W4uqkhwSC7Eajw' \
    --isPersistent 'HO3LfvwPewrf19Nj' \
    --isSoftDeleted 'm50xCDlPeNq0CvMX' \
    --joinability 'tyUWXrdZaFeacGT2' \
    --limit '47' \
    --matchPool 'AhsxaALiBwpNJorn' \
    --memberID 'rCQpMJj5igqat8xn' \
    --offset '85' \
    --order 'YGVPtkjt0OyBlJi4' \
    --orderBy 'RbZ0Iy11mfOFjCzZ' \
    --sessionID 'VcGomWF1oAqUNFDt' \
    --status 'XnXLvOAsW8wYh4gq' \
    --statusV2 '7pRVZVLJiDx3au9b' \
    --toTime '9QjhzDlnJmi4XaBT' \
    > test.out 2>&1
eval_tap $? 12 'AdminQueryGameSessions' test.out

#- 13 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["goXjfdUQHa3RxspS", "qwdbTR2sgzfaQrUC", "W9fgo69uv1bkFx8D"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminDeleteBulkGameSessions' test.out

#- 14 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'mbC9UqYdYrdxNnuM' \
    --namespace $AB_NAMESPACE \
    --sessionId 'cAwrSzYnrcetxObe' \
    --statusType 'isZelKuD0iJ6fs3z' \
    > test.out 2>&1
eval_tap $? 14 'AdminUpdateGameSessionMember' test.out

#- 15 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'L9H4WxGWRH7fz4Bd' \
    --key 'PhLtHRJOImSq37ae' \
    --leaderID 'AaGq0NIj53gXkmra' \
    --limit '50' \
    --memberID 'IAePvDO2xkVgyRk1' \
    --memberStatus '0b27RdU8VceYQ9er' \
    --offset '86' \
    --order '2HzBcEio5UyvuFv5' \
    --orderBy 'z6wosJGnUyCMEbHh' \
    --value '1uE4DmJ4Suj6DjUw' \
    > test.out 2>&1
eval_tap $? 15 'AdminQueryParties' test.out

#- 16 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users '36GtZ83Jp2f9f1FC' \
    > test.out 2>&1
eval_tap $? 16 'AdminQueryPlayerAttributes' test.out

#- 17 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'oIo3L24DKGwgZ85v' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetPlayerAttributes' test.out

#- 18 CreateGameSession
# body param: body
echo '{"attributes": {"yFJR8euQBLVu27iw": {}, "plLJdzYS9K0VvwE6": {}, "MAqPc8lGIYWTwxyq": {}}, "backfillTicketID": "QQIXVmrtRlq1jv60", "clientVersion": "HTnmFrl3gYx6Xmv1", "configurationName": "DzPHux3k3skhn3mW", "deployment": "ZjTYM95e4aa8xOJu", "inactiveTimeout": 80, "inviteTimeout": 36, "joinability": "qSNylcljuNM3eUUS", "matchPool": "D1pZGMfPdGIOAZ86", "maxPlayers": 42, "minPlayers": 6, "requestedRegions": ["n0L98WUoXvfU4qMI", "pfgxw2ff5twRYbtd", "K2r4wWs6IpYBxafo"], "serverName": "9b4xJyNnvHKrm8Uu", "teams": [{"UserIDs": ["NlT86N9yO0vyD6J5", "brVo20e6POTjrinA", "VVovpAAXNzcpbmX3"], "parties": [{"partyID": "lLFeXCiaXP8jBjK8", "userIDs": ["1t2V9TVauFcGkPgQ", "0hb2tLrsMeoZiRYk", "bhEM1zTNY3lpincu"]}, {"partyID": "f5d5saQvKfFRqBam", "userIDs": ["8jPtKHTmzo0JmcQm", "nsUigVynjGFyVicG", "QAVv32ftRAsmC0Ru"]}, {"partyID": "RA8j1AJ3hNWWhADR", "userIDs": ["qJvaZrf2qXQFCzRV", "1paELj5dw3LK0gPY", "hPPG5sAIfYtYozA2"]}]}, {"UserIDs": ["OntGCwQSHHdPLwjT", "ngrvb2E1X9ecBBhR", "AYjR7c4x5bIk8pVp"], "parties": [{"partyID": "xdUWOPel3TiwTycq", "userIDs": ["pVdINXzvkSp0Wbvx", "QWI0QGCOx7eICkau", "WbFrSnU7d1Buhdwl"]}, {"partyID": "iTSDdmGVfegiD3mr", "userIDs": ["VQaUr3oT88Dfc711", "4QFGwTzBVDg5v71k", "GCEt7h1mVwIQCJmQ"]}, {"partyID": "kvWbQrn2W0VkOF0p", "userIDs": ["QOY0UCcViiFKNjkT", "5hcONCaOyATBFgqL", "eAzvdcUEhWRo6ROv"]}]}, {"UserIDs": ["buPQwl9dVfJQGkDR", "00ofXsbnEzHiRs0N", "mGhxv1vuN7Xv6OuG"], "parties": [{"partyID": "6RR1jPh8RblvnfNi", "userIDs": ["ABRf1gdXM7QlAlnj", "AfgxOdZdf9tLHO1q", "rNyhmUEADczzrL31"]}, {"partyID": "HuYKsCBBgwb1hGjH", "userIDs": ["JgxrcEvnfJqU4hCv", "5egSQDePKSZKp6zw", "DQS1atvJrALaiplJ"]}, {"partyID": "gRhedl5Ewh3jDayY", "userIDs": ["StUiBB1yz3iP8gH8", "8UenlMVzIOP8NOf9", "1LsD7cWWOgAs8ThM"]}]}], "textChat": true, "ticketIDs": ["uDNbOydiu3lOaruu", "Yw0iUuts6bChMK1g", "cx8p9fyv5PoMJeTI"], "type": "Qix1FEvzlipE7r0v"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateGameSession' test.out

#- 19 PublicQueryGameSessions
# body param: body
echo '{"hh21v5772AopmjI7": {}, "CbY2WuwRUT9IivgC": {}, "4mJ5OHuNEVQK4Mvk": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'PublicQueryGameSessions' test.out

#- 20 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName '00I9GqAhhjNIivdI' \
    > test.out 2>&1
eval_tap $? 20 'GetGameSessionByPodName' test.out

#- 21 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'caEQfNETQCBPK1mY' \
    > test.out 2>&1
eval_tap $? 21 'GetGameSession' test.out

#- 22 UpdateGameSession
# body param: body
echo '{"attributes": {"wKVQoydbYjXZyBpq": {}, "hCJBtFOm3iCpu0lh": {}, "hgutt3rQuKP1OEtK": {}}, "backfillTicketID": "FBjNihHU8GP8TRVy", "clientVersion": "pSvYXKz4BGjbsrRB", "deployment": "V8aztJ86yQK1AsC1", "inactiveTimeout": 10, "inviteTimeout": 95, "joinability": "nJi6dNVF7zwjXqlc", "matchPool": "D2LzaOwIF5tEsCwo", "maxPlayers": 55, "minPlayers": 91, "requestedRegions": ["VcZCSj80gzFvpvIe", "rFEyxTugoTd50RmJ", "FX9v4GPfyGuQ2UEl"], "teams": [{"UserIDs": ["0U5Z9UnQmZqX15hB", "b4dlNTIBDtHunwNL", "LfKCQKuu2MWXpEpN"], "parties": [{"partyID": "jHWPcFSnM7GAvk19", "userIDs": ["sXDish7KUVhmAwmA", "ygsnn8pM7l6v0elL", "MceGGgb5FJHWE6s1"]}, {"partyID": "3b7dmnPijw6U8GGp", "userIDs": ["0E886E90E4ZboiXT", "1Uy0gArtDpQE4bOt", "oiAjHXcVVOsVywU6"]}, {"partyID": "uisejapftqoxujXD", "userIDs": ["osOo2kSUfIA1guTN", "x7haejXSV2oH2uH8", "S4Zx0ACteueMOmYP"]}]}, {"UserIDs": ["4SgxAIQTTKsdmtHu", "1dG0us7kIWLcgKgU", "9406tdRDqr3cpVba"], "parties": [{"partyID": "H69NyTfGE59942bC", "userIDs": ["wgpzUfcmTQjRmV0C", "Pt1LUaTvrFaxzOfG", "3pTddIA0Rt6wM5oQ"]}, {"partyID": "vTMICtWyUtVDnhgT", "userIDs": ["GXO8Utpwxug8Mpqc", "zRvUdK1uOV1ZJTYu", "HpnpVX5u4gw4XBXD"]}, {"partyID": "D7BG73sDdDoXnB8F", "userIDs": ["5X05KUgGKfDSGh3v", "QFPSYCi8WEjR3wqp", "nMdSNskxhl3O3kGl"]}]}, {"UserIDs": ["oooh7kL598P7F3IK", "hiNdx1V7199NT7JT", "RFV3FxMl5Rw4YeHq"], "parties": [{"partyID": "WkG09iEAFYWhow1W", "userIDs": ["AwCs9Y0KOemhNPYU", "VA9mU8UvONyjv3GQ", "uLHoQ6ehLLK5h1bE"]}, {"partyID": "9WU6w3tjUhSCKySP", "userIDs": ["Y7yMGOuQOfx6HIFf", "wBBqG51RaZY74Cqd", "vfPAIaPEkCIXX7WQ"]}, {"partyID": "3ytABCzYWxYbbphu", "userIDs": ["iQPU0aS2OIp0B2FW", "iDu7POaotJoQQyL1", "bCDNisOhjEKFWmj7"]}]}], "ticketIDs": ["ioi5WZ6ZymQeVSZZ", "ma57V6b9uLloAA9K", "oetyNPkgWcTCN7aB"], "type": "IFfeRdnHpse2T7eZ", "version": 46}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'suHbA0keUomVCh68' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'UpdateGameSession' test.out

#- 23 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '1OMZFNRw8YvLGLnB' \
    > test.out 2>&1
eval_tap $? 23 'DeleteGameSession' test.out

#- 24 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"4xfqdHhPHA2ZbIvW": {}, "1oxENH4MsVlbCMc5": {}, "hx0W14SkvovINegS": {}}, "backfillTicketID": "29legebqGwej59Ok", "clientVersion": "8EM0OFW93FkJicmK", "deployment": "6qeaDEm9bPCS2a5W", "inactiveTimeout": 29, "inviteTimeout": 97, "joinability": "OtwavdioadjCN0lC", "matchPool": "0MZRZAvhZ7XQmcT5", "maxPlayers": 59, "minPlayers": 70, "requestedRegions": ["uVa643kk8gvvnsu0", "ABei0go2wsmPfpsb", "kzAIsJ06QlFCAa55"], "teams": [{"UserIDs": ["r89MdFidv2kFVXgn", "jrAfzEn26mHgxUgV", "DgnlU5H2ULa1LYls"], "parties": [{"partyID": "qYrUpXncYv2BVIS1", "userIDs": ["BtMqvdE5QQizMBWY", "PYerJ1FmKBX6U18g", "MIl7TSPm96MsoQcF"]}, {"partyID": "DfKSJymqZ5tDVsJ6", "userIDs": ["3mFWW0u95r5ylQKc", "Wi0o5zcWp7NiTBI4", "m6PVEQWCNw7DHkXx"]}, {"partyID": "8NqXaR2w60X5Vb0T", "userIDs": ["V0x3nmq9UCZbdVFY", "3WdZ6luOW977Egot", "vOrnRjb5UT6Vf5jx"]}]}, {"UserIDs": ["oBBg2lM3DQXyC3oK", "u14sRjkCeuRY0tsn", "bKAGRTCvAZKiSB7b"], "parties": [{"partyID": "YvWmbUbWlRZtcIUr", "userIDs": ["y87yJBlfjPI5tfjb", "yZkYSRLBMgcD5OJg", "p6wHynVKwWgdAibF"]}, {"partyID": "BESdI0Ab1zgjMC3h", "userIDs": ["p1s4tElQhEA9ThpS", "byAYJeBCrKDcRkI5", "LI6UqivHoIArvDT6"]}, {"partyID": "2TaGFSxd4y808Fey", "userIDs": ["8nfaGEw6BAuz1YkA", "Nj6LHaNMxGL2cjWg", "68JcPwqh2N4nelbm"]}]}, {"UserIDs": ["KVyNZY8IVtOeznPw", "NRnztP1VeNj0XYtI", "NcOQIiLdvpuYVOAU"], "parties": [{"partyID": "9uuKPGNN6m8BLNzJ", "userIDs": ["xMR9F8QPVUh3Fxn8", "VCvtdiiwNMAdIodi", "W3hcYuKSRkkKQKIV"]}, {"partyID": "OduQwwDrBnpQpIKd", "userIDs": ["lw0Q8Qm0lpTupwpI", "0MCOROWHgnYO9A4N", "tX4m0L4BGxxcKUh2"]}, {"partyID": "wepEjvh8sTPE7JfL", "userIDs": ["8ZG7IBiOpvSKRmJc", "E8fHWU8tF9Tj5DH9", "jDJgqZagf9TfKsyi"]}]}], "ticketIDs": ["aqf0VfidvwpghGz9", "2mfgwfewY0DMU8Qu", "ojVb8QgdEnIEDOXP"], "type": "qBEIQJ92jD6Oo7qD", "version": 91}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'RHhQ2uS27tXHvtxi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'PatchUpdateGameSession' test.out

#- 25 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "6EbWHrMrbpZd2bt6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'P3sZXAZkdh450P2H' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateGameSessionBackfillTicketID' test.out

#- 26 PublicGameSessionInvite
# body param: body
echo '{"platformID": "CQEysNYmCndtXXQg", "userID": "iHJgjwpCxGEBsc3H"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'VarhLlwlmf1l5Jhr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PublicGameSessionInvite' test.out

#- 27 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'QSpGlguvTECefhiK' \
    > test.out 2>&1
eval_tap $? 27 'JoinGameSession' test.out

#- 28 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Kuc8Urg4atANoOfy' \
    > test.out 2>&1
eval_tap $? 28 'LeaveGameSession' test.out

#- 29 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'CbfBoH6zLgTsYmAw' \
    > test.out 2>&1
eval_tap $? 29 'PublicGameSessionReject' test.out

#- 30 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "4mFyLcIq00Vl8sxz", "userIDs": ["C1fJxroZeNIlbxAU", "eRUjUbaPklfVic7z", "YJTjpmhWVBgTDm8I"]}, {"partyID": "GJL3sEpnq2qNgEjK", "userIDs": ["Memoxx1k2s5gW8zA", "DPqu8PVXnN0xl48R", "oZbNL7cXCVaF9U1H"]}, {"partyID": "9bQv7EybPwbHEHxS", "userIDs": ["PaGCQl5y1gekeqHn", "zZfY22Z1SmIc5NTR", "yLbOzAYD5IH4deTF"]}], "proposedTeams": [{"UserIDs": ["CDORAsuT0lseQtOo", "ohdBYhvvwspKpEPU", "Uxc2NKFB2qxCiWMN"], "parties": [{"partyID": "dvN9SDRKye6n1t8R", "userIDs": ["XF5qayS4UAMJrRrn", "NfXdTnJz7e3tD8KV", "lMU17V03QDQjU64l"]}, {"partyID": "c3oek3RWXWJhPXvS", "userIDs": ["9OmmtZ14XROPpbgq", "S9a9eP72cbSH4TvY", "6sMCkitXsNfi8EF3"]}, {"partyID": "mgABwFe1N0QNerys", "userIDs": ["sScV8w2rN40y7aLO", "JoeZqRwJzTdMg00K", "vHLdMiaje6w7YN9M"]}]}, {"UserIDs": ["WtYzurSMcK8c5xZu", "kais9TopwzyVFe9l", "NT7v5QycBCxJG7De"], "parties": [{"partyID": "hSEc6kg2UWX8dfbo", "userIDs": ["aqkOS5P8ijeU7ceE", "jsJO7xZUK7lMGDnK", "hxDxWqk0FyDBDBxA"]}, {"partyID": "znXS1mfs6uZ9OaZw", "userIDs": ["m6pPAdF5lHMHzByc", "Y7bXyRpFUts9CpuT", "ZNXAvR5mEjDGi8Z9"]}, {"partyID": "KuTHuT6IlImbAYCR", "userIDs": ["vUBIHoIhUnq8Etmz", "VPJFqDDsFmDKPixc", "JtgNHrTEQpFB5aeI"]}]}, {"UserIDs": ["MGxoyLMqSLDNxuBA", "95CXk3K2oLMyvJ6M", "0zKUQCLksfhWE1Oi"], "parties": [{"partyID": "COozFmZ3hzpayQ1y", "userIDs": ["SXmHgROq1X5e82zD", "rJtNcl4ztsaFwryl", "G42gHaf4XEHX7QBU"]}, {"partyID": "YvSupGJqpwAp0WMu", "userIDs": ["7ZUAbKsKi0fuipdv", "ULHrqNhX3eWB4hfA", "53Ibtklb9jB4Gcb0"]}, {"partyID": "L2EPZQmxEO4oKOcs", "userIDs": ["ZUbeZJJJydenJ93K", "b1pQleHG1UoswJzp", "9GPpGykMepZ0J4Uu"]}]}], "version": 72}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'WR407SE9ddXzA6F7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AppendTeamGameSession' test.out

#- 31 PublicPartyJoinCode
# body param: body
echo '{"code": "3IwV8d2jvk2NFEPF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicPartyJoinCode' test.out

#- 32 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'cj0B4pnGV0EaGDNA' \
    > test.out 2>&1
eval_tap $? 32 'PublicGetParty' test.out

#- 33 PublicUpdateParty
# body param: body
echo '{"attributes": {"oaYeee5iUyPElT7m": {}, "mAuOT58yIe9AzmsP": {}, "C0C5hWQuueyPPcbP": {}}, "inactiveTimeout": 99, "inviteTimeout": 4, "joinability": "e3xxdxVhu4rkZZo8", "maxPlayers": 12, "minPlayers": 83, "type": "Tr6agunz2XzHsONp", "version": 83}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'mc8jD3q7UouREPLD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PublicUpdateParty' test.out

#- 34 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"Nt6Bi4udSrXnIItd": {}, "uiUuy8tq9HCTgLSu": {}, "Fiv2W3x38AyIWIiW": {}}, "inactiveTimeout": 54, "inviteTimeout": 100, "joinability": "kZb55PmNf9MzOCP7", "maxPlayers": 69, "minPlayers": 29, "type": "O3NR5EmbWMmuHbWU", "version": 8}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'FdkQZDrW0M7eIDri' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'PublicPatchUpdateParty' test.out

#- 35 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'fb9ovouuoyV36gCe' \
    > test.out 2>&1
eval_tap $? 35 'PublicGeneratePartyCode' test.out

#- 36 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'hJP43Xpu5gyQ14gM' \
    > test.out 2>&1
eval_tap $? 36 'PublicRevokePartyCode' test.out

#- 37 PublicPartyInvite
# body param: body
echo '{"platformID": "P9Z4mEvMNjtERuv6", "userID": "NrO6SjBOH0izSSpV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'oq4E6CtycfHMbZoB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'PublicPartyInvite' test.out

#- 38 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "gzDSnBtqToPbBDwd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'vFVFTK8mQqqA2VoU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicPromotePartyLeader' test.out

#- 39 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'KBlsPXL4ibYVB9w0' \
    > test.out 2>&1
eval_tap $? 39 'PublicPartyJoin' test.out

#- 40 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'ETfSauutS9JWgSB3' \
    > test.out 2>&1
eval_tap $? 40 'PublicPartyLeave' test.out

#- 41 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId '9nWJ0AdErhRmHmtC' \
    > test.out 2>&1
eval_tap $? 41 'PublicPartyReject' test.out

#- 42 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'l6M85ELRv5NEe9bR' \
    --userId '9ckNLMJjsgaXBRR4' \
    > test.out 2>&1
eval_tap $? 42 'PublicPartyKick' test.out

#- 43 PublicCreateParty
# body param: body
echo '{"attributes": {"15WJviuc5vA36xYM": {}, "MPep0zplFiRg22Rp": {}, "UVtQXjItygvyTYyk": {}}, "configurationName": "vnB2kvfxE0sqbjAH", "inactiveTimeout": 64, "inviteTimeout": 95, "joinability": "9QLlS2lC0QB41qRS", "maxPlayers": 68, "members": [{"ID": "5yYg5fkChtyUjcBH", "PlatformID": "Shoy4rAmtQkeCoVH", "PlatformUserID": "Y89b92PWEF9gison"}, {"ID": "sVtIIBDDZzSa012J", "PlatformID": "2Vd3MaSmOIA08Q4P", "PlatformUserID": "e45ZkF7UCeoZEUNV"}, {"ID": "KjMQUM30waRuDKnw", "PlatformID": "63w8ZD7GzTZ0WS0Z", "PlatformUserID": "fkVqKowfa2xO5BhQ"}], "minPlayers": 41, "textChat": true, "type": "MYVHJohu8Sfs3a0o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicCreateParty' test.out

#- 44 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'PublicGetPlayerAttributes' test.out

#- 45 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "ghCkujmLLnrNNSLh", "data": {"36UQbPSJQQhceSla": {}, "9ERYYip5g4u0MAPc": {}, "VPH3gZ7BL95xBXZ4": {}}, "platforms": [{"name": "Q2kZcVEtlghVPGnq", "userID": "tFjbFAzllHBMrW7h"}, {"name": "G67ye23P8DW1ccz6", "userID": "49aMbZ9u0Okl1IHd"}, {"name": "8Q5JqhDP8ljUtdmP", "userID": "5zdR2WzZ26M7190B"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'PublicStorePlayerAttributes' test.out

#- 46 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'PublicDeletePlayerAttributes' test.out

#- 47 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'UUMJA2i5Q4vFfXwK' \
    --orderBy 'GlPrvLQjEMxmStiA' \
    --status 'YcnCKHJa29YjFCGX' \
    > test.out 2>&1
eval_tap $? 47 'PublicQueryMyGameSessions' test.out

#- 48 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'PzxvGWXSYKxZFwAJ' \
    --orderBy 'dGF5bhjI1EEc3WV5' \
    --status 'k6IPw3luGBMK9OmE' \
    > test.out 2>&1
eval_tap $? 48 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE