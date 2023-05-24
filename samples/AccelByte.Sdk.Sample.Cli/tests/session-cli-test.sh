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
echo "1..53"

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

#- 5 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AdminGetConfigurationAlertV1' test.out

#- 6 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 2}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateConfigurationAlertV1' test.out

#- 7 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminCreateConfigurationAlertV1' test.out

#- 8 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteConfigurationAlertV1' test.out

#- 9 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 18, "PSNSupportedPlatforms": ["uz5zkoaUEzGS3qZf", "0PbemSBELbZ0VBUG", "A7nkDeev2Oj060Hn"], "SessionTitle": "Of5S8X1LxkZs4233", "ShouldSync": false, "XboxServiceConfigID": "F7bwRgwKvzESbhpx", "XboxSessionTemplateName": "lDdEs4igdKeLmy8t"}, "clientVersion": "Z5GZi5P12c61ts3f", "deployment": "MI04rm2jUc9iav3t", "dsSource": "TqlE9oLDPD0Lfle8", "fallbackClaimKeys": ["ESU1MO8XnVaEyjmi", "fJDYa1TJPUszmFGE", "kJVvqDSU3PDyIAGf"], "inactiveTimeout": 66, "inviteTimeout": 33, "joinability": "q1FNmRWvUvDPnKoE", "maxPlayers": 58, "minPlayers": 45, "name": "jGUg867xodwuG14I", "persistent": true, "preferredClaimKeys": ["08HN6s9p8Y5c9eIt", "JtiNmY3y3n2Rim4N", "BqhuNtj8FOvKZjs1"], "requestedRegions": ["tLpERf77LzPoORBk", "RmZ0A2zyZsb4FvWF", "IHPIbOjpls9BZTYc"], "textChat": false, "type": "BsdSSVaAzzn4Gbgk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminCreateConfigurationTemplateV1' test.out

#- 10 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --offset '27' \
    > test.out 2>&1
eval_tap $? 10 'AdminGetAllConfigurationTemplatesV1' test.out

#- 11 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'eCaS6qyUCscHXs8P' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetConfigurationTemplateV1' test.out

#- 12 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 24, "PSNSupportedPlatforms": ["PjaYEDxaYN8w9KUW", "0py8KrcQfucSq2X8", "gFuJORk4j04YfnXT"], "SessionTitle": "sQUrA0WWyKl2K5mC", "ShouldSync": false, "XboxServiceConfigID": "oGeQCahcox63cyDx", "XboxSessionTemplateName": "AAYcRXJdoSTxNCK9"}, "clientVersion": "AIjNmbfoW8bDq5jP", "deployment": "qzhN0YdGSrA9LXRw", "dsSource": "U6WLgpQE9nXzhBC0", "fallbackClaimKeys": ["uyMR4Xf2nfYvNvG8", "uQ14AhsxaALiBwpN", "JornrCQpMJj5igqa"], "inactiveTimeout": 41, "inviteTimeout": 78, "joinability": "8xnPoWTdHAkcyAy4", "maxPlayers": 6, "minPlayers": 73, "name": "rHlPcXGGl0Xw3veB", "persistent": false, "preferredClaimKeys": ["zZVcGomWF1oAqUNF", "DtXnXLvOAsW8wYh4", "gq7pRVZVLJiDx3au"], "requestedRegions": ["9b9QjhzDlnJmi4Xa", "BTgoXjfdUQHa3Rxs", "pSqwdbTR2sgzfaQr"], "textChat": true, "type": "CYZaL46I3PgCcQ0a"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'xTWnmyEYLZQTpvLH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateConfigurationTemplateV1' test.out

#- 13 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name '6QPEBP8kSSFjeuL3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminDeleteConfigurationTemplateV1' test.out

#- 14 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminGetDSMCConfiguration' test.out

#- 15 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminSyncDSMCConfiguration' test.out

#- 16 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'wQQPYwmYFbxRvHYD' \
    --dsPodName 'CYwoGdmzXgf1ewUT' \
    --fromTime 'vnu0ensa3MZF7DTs' \
    --gameMode 'wnkSyuJTVjKQ1ORL' \
    --isPersistent 'EIAePvDO2xkVgyRk' \
    --isSoftDeleted '10b27RdU8VceYQ9e' \
    --joinability 'rPYQ5yVcQuvDbGMq' \
    --limit '3' \
    --matchPool '5z6wosJGnUyCMEbH' \
    --memberID 'h1uE4DmJ4Suj6DjU' \
    --offset '45' \
    --order 'V3hSIiTEoTCSxjAq' \
    --orderBy 'g9oGVEdC8mQir1Af' \
    --sessionID '0G6OrPH6ZsjpPgHK' \
    --status 'ISHtB8tWdJM9Qc5H' \
    --statusV2 'mR0vknXO45AUtNXS' \
    --toTime 'TItt35OJTfJBZX62' \
    > test.out 2>&1
eval_tap $? 16 'AdminQueryGameSessions' test.out

#- 17 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["yI9g5RDrlzPFQmNu", "3ERxV0UTaiSzfi0F", "nBERe8qNYRTYSaZw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminDeleteBulkGameSessions' test.out

#- 18 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId '4NqSNylcljuNM3eU' \
    --namespace $AB_NAMESPACE \
    --sessionId 'USD1pZGMfPdGIOAZ' \
    --statusType '86un0L98WUoXvfU4' \
    > test.out 2>&1
eval_tap $? 18 'AdminUpdateGameSessionMember' test.out

#- 19 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'qMIpfgxw2ff5twRY' \
    --key 'btdK2r4wWs6IpYBx' \
    --leaderID 'afo9b4xJyNnvHKrm' \
    --limit '32' \
    --memberID 'UuNlT86N9yO0vyD6' \
    --memberStatus 'J5brVo20e6POTjri' \
    --offset '27' \
    --order 'pJLtEZjuyFhvbxX2' \
    --orderBy 'DNbknfVv4nm70TCa' \
    --partyID 'yYAkF18YBwRxcREy' \
    --value 'U5CwqGJF6nDi33Iz' \
    > test.out 2>&1
eval_tap $? 19 'AdminQueryParties' test.out

#- 20 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'tr2QcwlRrReRajlp' \
    > test.out 2>&1
eval_tap $? 20 'AdminQueryPlayerAttributes' test.out

#- 21 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'k8lfuiJVcktlx9zJ' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetPlayerAttributes' test.out

#- 22 CreateGameSession
# body param: body
echo '{"attributes": {"ZVVCc9bpIHEWQMmC": {}, "kIqwqpoTVCNrcaVo": {}, "zsjIXO2EUsAfBvo6": {}}, "backfillTicketID": "Llcalks2R3VMtipT", "clientVersion": "VxXAF8KhOKqbrECi", "configurationName": "jFxOpOzxeTLJQsZc", "deployment": "TEzXaXUzpsAV6ct6", "dsSource": "XITL0QEkadMSQluA", "fallbackClaimKeys": ["oED9oYwS8oLyErKv", "RtHFGJRoGW7VBG1V", "B2sp2x9mszGGoyhG"], "inactiveTimeout": 35, "inviteTimeout": 55, "joinability": "pVdINXzvkSp0Wbvx", "matchPool": "QWI0QGCOx7eICkau", "maxPlayers": 100, "minPlayers": 45, "preferredClaimKeys": ["bFrSnU7d1Buhdwli", "TSDdmGVfegiD3mrV", "QaUr3oT88Dfc7114"], "requestedRegions": ["QFGwTzBVDg5v71kG", "CEt7h1mVwIQCJmQk", "vWbQrn2W0VkOF0pQ"], "serverName": "OY0UCcViiFKNjkT5", "teams": [{"UserIDs": ["hcONCaOyATBFgqLe", "AzvdcUEhWRo6ROvb", "uPQwl9dVfJQGkDR0"], "parties": [{"partyID": "0ofXsbnEzHiRs0Nm", "userIDs": ["Ghxv1vuN7Xv6OuG6", "RR1jPh8RblvnfNiA", "BRf1gdXM7QlAlnjA"]}, {"partyID": "fgxOdZdf9tLHO1qr", "userIDs": ["NyhmUEADczzrL31H", "uYKsCBBgwb1hGjHJ", "gxrcEvnfJqU4hCv5"]}, {"partyID": "egSQDePKSZKp6zwD", "userIDs": ["QS1atvJrALaiplJg", "Rhedl5Ewh3jDayYS", "tUiBB1yz3iP8gH88"]}]}, {"UserIDs": ["UenlMVzIOP8NOf91", "LsD7cWWOgAs8ThMp", "AGIapYftYZkBXiEh"], "parties": [{"partyID": "diS41VBAEUvoBlbH", "userIDs": ["02bobxtljIfHBgjP", "9onbxFcxS2OZZfXO", "3HkJTOPscPA2n25C"]}, {"partyID": "1zEnAMGmFy7w6eqn", "userIDs": ["MeKFo7U8Scr9xm68", "w7s9RMx2hc45QX23", "4xnqlbRAPFQsca6n"]}, {"partyID": "9vGZTCCXQ2Lf7jte", "userIDs": ["xB613cbiJEUePVZQ", "aoEY2zrpLuvrx96O", "Oz45vMiR3QYZJKVN"]}]}, {"UserIDs": ["lK8PTaIXRWFTyA9M", "DnKGXqq7Zk705hOh", "enJi6dNVF7zwjXql"], "parties": [{"partyID": "cD2LzaOwIF5tEsCw", "userIDs": ["oAVcZCSj80gzFvpv", "IerFEyxTugoTd50R", "mJFX9v4GPfyGuQ2U"]}, {"partyID": "El0U5Z9UnQmZqX15", "userIDs": ["hBb4dlNTIBDtHunw", "NLLfKCQKuu2MWXpE", "pNjHWPcFSnM7GAvk"]}, {"partyID": "19sXDish7KUVhmAw", "userIDs": ["mAygsnn8pM7l6v0e", "lLMceGGgb5FJHWE6", "s13b7dmnPijw6U8G"]}]}], "textChat": true, "ticketIDs": ["7TUEBotSNIwGhia6", "cqoWmnhtuzxir12r", "0VUWI0kJAczj5Apc"], "type": "siEQ65llgGnTHAsT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreateGameSession' test.out

#- 23 PublicQueryGameSessions
# body param: body
echo '{"CZa7xE4nwGKlbPRx": {}, "fucxoRKFLxxcL9Sy": {}, "uHbvRxR6LaKWgAVj": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'PublicQueryGameSessions' test.out

#- 24 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'ZKDxiezEbuMCz9J4' \
    > test.out 2>&1
eval_tap $? 24 'GetGameSessionByPodName' test.out

#- 25 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'dPRGzoQLYIWPPZvy' \
    > test.out 2>&1
eval_tap $? 25 'GetGameSession' test.out

#- 26 UpdateGameSession
# body param: body
echo '{"attributes": {"PupimCENHEenqjRS": {}, "xO9oZ0fCxLR0Gfjw": {}, "CmDrbDR0Q0ixpqYt": {}}, "backfillTicketID": "kZuhL6qbAhRExsnb", "clientVersion": "WSH45LarTmOqto4O", "deployment": "twF9uPUAxerdIqWm", "fallbackClaimKeys": ["OoMyYp2tSrLxpJnj", "9JtgjWmjx1WuNQq4", "v8FnVzdbNW1xuV7r"], "inactiveTimeout": 98, "inviteTimeout": 61, "joinability": "ei1o9zV6rhVfcQmL", "matchPool": "fEn5ZUGeYlOwODWB", "maxPlayers": 54, "minPlayers": 65, "preferredClaimKeys": ["z6skHMfl4Hjw9KEn", "x8cNfDK45zWtwYhR", "oNPwKema6caMTOci"], "requestedRegions": ["vPAkmP8Awb0NqtvS", "R9q6l5k9BLQMrPoT", "uxdzEYAw5VdW05Wn"], "teams": [{"UserIDs": ["QEAbK416LN2N6D6y", "czitn4OkZfx0Xa6s", "gegAWYz2z4qSPPQB"], "parties": [{"partyID": "DFQsvRHbGTC2ynue", "userIDs": ["7Xk4uDF5mdakWJ2A", "sKf8UfQqTQ8v7gXy", "FuLFZViQbxYQvUya"]}, {"partyID": "po6FmMy6tZYSCe7d", "userIDs": ["u68Ce6T4pYH3BPyF", "urT4p8zoRYG8WKTa", "UyB0UyrKKulHUnom"]}, {"partyID": "pTrS7DIOakX65w7R", "userIDs": ["pxY6pd1QTpFpaxbC", "jHSCXM7sL1nnOoRI", "g7oSh4yVttp53was"]}]}, {"UserIDs": ["uHbA0keUomVCh681", "OMZFNRw8YvLGLnB4", "xfqdHhPHA2ZbIvW1"], "parties": [{"partyID": "oxENH4MsVlbCMc5h", "userIDs": ["x0W14SkvovINegS2", "9legebqGwej59Ok8", "EM0OFW93FkJicmK6"]}, {"partyID": "qeaDEm9bPCS2a5Wo", "userIDs": ["OtwavdioadjCN0lC", "0MZRZAvhZ7XQmcT5", "7Hl2PvPOKvc25nnS"]}, {"partyID": "LnEnv4ipAVJzPHM6", "userIDs": ["kTwfu1vSD9gROMkn", "wVRJfXHGB1r66lbN", "cbMIJEY0BmpF215j"]}]}, {"UserIDs": ["JycJcSyXLzU9Uqk0", "79uhBLl4yz32RqkN", "zYSNYl4zvyD8SUZv"], "parties": [{"partyID": "2LFFZer6T3W7TE5W", "userIDs": ["docKzvgr3jBU2g8E", "o7uAb4HndxqQYO14", "lFR2YtIb1fufxJio"]}, {"partyID": "dJFjEbn1ASMAiedH", "userIDs": ["oYv6WmW9mRXQwc5s", "fOZbgnCmULqltV5x", "jjrXKhZOekpygvRD"]}, {"partyID": "Ck0koCGDPfbiGdBQ", "userIDs": ["5DNVJAgfAkD0w0H6", "QM5AsRnp9a7p0g0s", "zNgC8yVFlwGULKeM"]}]}], "ticketIDs": ["zn4sG6P5R2lHU9mf", "9rzrxuxtxg98cDF1", "fsD5miAxHczgRu4V"], "type": "YjQq4VIVFUqNPuW2", "version": 14}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '3zuUv8ShbYBe9hLK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateGameSession' test.out

#- 27 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'cN6myFUWf7IuLG63' \
    > test.out 2>&1
eval_tap $? 27 'DeleteGameSession' test.out

#- 28 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"jl9rYXaEFcUySnsI": {}, "REQUlwDt2XB6DgoJ": {}, "m4dqrLVSBWToF03d": {}}, "backfillTicketID": "QYi0OxI4DZZd2V80", "clientVersion": "fjN9CwM4qNT3awIj", "deployment": "WoFCW5BTW9laFjsd", "fallbackClaimKeys": ["7gSFkIVGnXJLeUdD", "8XNxAkoeHk0BXouy", "KC6RnO4PckO3syHJ"], "inactiveTimeout": 82, "inviteTimeout": 82, "joinability": "MlgAqtsnZlLvEczK", "matchPool": "KAyiQv93N1fbGovP", "maxPlayers": 77, "minPlayers": 78, "preferredClaimKeys": ["BpXX8vScPhhhoeTb", "xungca58m1uNcxsQ", "xrsxbLSv7uFZXdW5"], "requestedRegions": ["GyQ2mveLZEnmSCeW", "TCXfARUx3U3Krfqo", "Zi5xiHiQI9ieQ8y7"], "teams": [{"UserIDs": ["5Biw4pKJ8hey5Jmu", "UDlojEc712JEhS1V", "FA1Eo4Rxcnq5DtzS"], "parties": [{"partyID": "aifByaju2TY0QdHn", "userIDs": ["dDWB60eGxKadAf6U", "L9MkkVf8dHJYJF19", "NcUSJgQSBwkX1FU7"]}, {"partyID": "1K0CzXzdQIWh5PSp", "userIDs": ["024SIhnu3h3uK1jR", "HhQ2uS27tXHvtxi6", "EbWHrMrbpZd2bt6P"]}, {"partyID": "3sZXAZkdh450P2HC", "userIDs": ["QEysNYmCndtXXQgi", "HJgjwpCxGEBsc3HV", "arhLlwlmf1l5JhrQ"]}]}, {"UserIDs": ["SpGlguvTECefhiKK", "uc8Urg4atANoOfyC", "bfBoH6zLgTsYmAw4"], "parties": [{"partyID": "mFyLcIq00Vl8sxzC", "userIDs": ["1fJxroZeNIlbxAUe", "RUjUbaPklfVic7zY", "JTjpmhWVBgTDm8IG"]}, {"partyID": "JL3sEpnq2qNgEjKM", "userIDs": ["emoxx1k2s5gW8zAD", "Pqu8PVXnN0xl48Ro", "ZbNL7cXCVaF9U1H9"]}, {"partyID": "bQv7EybPwbHEHxSP", "userIDs": ["aGCQl5y1gekeqHnz", "ZfY22Z1SmIc5NTRy", "LbOzAYD5IH4deTFC"]}]}, {"UserIDs": ["DORAsuT0lseQtOoo", "hdBYhvvwspKpEPUU", "xc2NKFB2qxCiWMNd"], "parties": [{"partyID": "vN9SDRKye6n1t8RX", "userIDs": ["F5qayS4UAMJrRrnN", "fXdTnJz7e3tD8KVl", "MU17V03QDQjU64lc"]}, {"partyID": "3oek3RWXWJhPXvS9", "userIDs": ["OmmtZ14XROPpbgqS", "9a9eP72cbSH4TvY6", "sMCkitXsNfi8EF3m"]}, {"partyID": "gABwFe1N0QNeryss", "userIDs": ["ScV8w2rN40y7aLOJ", "oeZqRwJzTdMg00Kv", "HLdMiaje6w7YN9MW"]}]}], "ticketIDs": ["tYzurSMcK8c5xZuk", "ais9TopwzyVFe9lN", "T7v5QycBCxJG7Deh"], "type": "SEc6kg2UWX8dfboa", "version": 34}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Bp08H0whjTC8Q254' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PatchUpdateGameSession' test.out

#- 29 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "CIig93OcDTSDDbtG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId '4kbF7EcYPAe3TKjW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateGameSessionBackfillTicketID' test.out

#- 30 PublicGameSessionInvite
# body param: body
echo '{"platformID": "JizZ73YhEdqt8LYH", "userID": "7I8lYD68ZI9yJ2Fm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'Hnprty5BQCd5sVLr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicGameSessionInvite' test.out

#- 31 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '7TlnKnQhYH2PkwSP' \
    > test.out 2>&1
eval_tap $? 31 'JoinGameSession' test.out

#- 32 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'XdYk0YxFNno9WQq9' \
    > test.out 2>&1
eval_tap $? 32 'LeaveGameSession' test.out

#- 33 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'ZHHjrwqKsa8Zqhez' \
    > test.out 2>&1
eval_tap $? 33 'PublicGameSessionReject' test.out

#- 34 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "PIlBtGhWc8fY9HfU", "userIDs": ["sEaPxVM4cVRtjpUe", "qucPWZP6mJ5k9QPU", "VO9elCnXCnhXRiCB"]}, {"partyID": "S6wONO7EzD1HwKEg", "userIDs": ["Gh6MctPOqg2vfaFi", "XbkyxYVJYoECX5Zk", "7zrqRFfKg2QLfgPk"]}, {"partyID": "y92H0SjmRKLX0YyN", "userIDs": ["LgOIbDguxdqP6c44", "8AniKDjnb5cFYyJt", "zDcKD3CR18eggGJV"]}], "proposedTeams": [{"UserIDs": ["XROWQLNP4J0I2wDj", "uMHSknrvHsarToh0", "1sSaePBAWrnMRr0i"], "parties": [{"partyID": "4i3znplxZVkkzCuW", "userIDs": ["XN0pi9oHwFFSWlYJ", "SaX14Onxc82WUAqF", "NlxPL5ZjWvAiWvl1"]}, {"partyID": "2EyddbFelmB60OEQ", "userIDs": ["rMIsKCf8GsPEl1i9", "RQ9tNv9ZoFgoU8ge", "QqTHsgesxUdeb2FJ"]}, {"partyID": "bsqzkOO5TgVxhorx", "userIDs": ["7Olr6yZsG5AHeXjx", "QCmc8jD3q7UouREP", "LDNt6Bi4udSrXnII"]}]}, {"UserIDs": ["tduiUuy8tq9HCTgL", "SuFiv2W3x38AyIWI", "iWAkZb55PmNf9MzO"], "parties": [{"partyID": "CP7HO3NR5EmbWMmu", "userIDs": ["HbWUeXEPRF6TjBh6", "iQOGSqSf29O4OCHr", "6PHDU3g8gwrRCGr3"]}, {"partyID": "4cRXz9JsazgdXDoG", "userIDs": ["shLr8yn7AoXGMgLG", "DEgjGR3AjETQmuBh", "xdl2hmyNHx2EwggD"]}, {"partyID": "6ThfKbveaNPadM95", "userIDs": ["4Klf9ScyQ3BkdgTB", "8XsRpozxyzQjkAwo", "iKpqCxRaxD64vrtL"]}]}, {"UserIDs": ["T4cBalVmLrDPUnoL", "1yIqAGPGIMNs07P3", "5ZIntLvl9DQDCBJj"], "parties": [{"partyID": "s12pGhuGLD6vHktU", "userIDs": ["3ynqJffmZNfIZBEm", "g9ppW9kqHg6qWRr5", "OGM3cUFnnf4mVneU"]}, {"partyID": "yBHCEsHoUz3vp9jp", "userIDs": ["SUMWJyDVldaDNtR0", "AXW63sbPYTKP8EQu", "pMajWTKw5FeR8ri3"]}, {"partyID": "yXrzd1ieTRurPzBS", "userIDs": ["UlLhIUZaqDR1n6aK", "cCVL5Fd1b8wgnlhP", "7Pg5lC7Ea270WU05"]}]}], "version": 1}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Z0WS0ZfkVqKowfa2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AppendTeamGameSession' test.out

#- 35 PublicPartyJoinCode
# body param: body
echo '{"code": "xO5BhQtMYVHJohu8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'PublicPartyJoinCode' test.out

#- 36 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Sfs3a0odaQ1HgT2W' \
    > test.out 2>&1
eval_tap $? 36 'PublicGetParty' test.out

#- 37 PublicUpdateParty
# body param: body
echo '{"attributes": {"npHkT1LxGYzolfxv": {}, "Dyx6IAAOUeURiiiE": {}, "gBQnBdCORXu3yYfZ": {}}, "inactiveTimeout": 32, "inviteTimeout": 49, "joinability": "HsVODk8yYxP6eRLW", "maxPlayers": 69, "minPlayers": 86, "type": "719H0S96d6o92O9J", "version": 93}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'W7hG67ye23P8DW1c' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'PublicUpdateParty' test.out

#- 38 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"cz649aMbZ9u0Okl1": {}, "IHd8Q5JqhDP8ljUt": {}, "dmP5zdR2WzZ26M71": {}}, "inactiveTimeout": 57, "inviteTimeout": 69, "joinability": "UUMJA2i5Q4vFfXwK", "maxPlayers": 66, "minPlayers": 23, "type": "KOF1FPASWEGLvHi2", "version": 50}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'nCKHJa29YjFCGXPz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicPatchUpdateParty' test.out

#- 39 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'xvGWXSYKxZFwAJdG' \
    > test.out 2>&1
eval_tap $? 39 'PublicGeneratePartyCode' test.out

#- 40 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'F5bhjI1EEc3WV5k6' \
    > test.out 2>&1
eval_tap $? 40 'PublicRevokePartyCode' test.out

#- 41 PublicPartyInvite
# body param: body
echo '{"platformID": "IPw3luGBMK9OmEmy", "userID": "tZjYEiOxHZltYdZO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'iBafLm9cc3OUVUdC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'PublicPartyInvite' test.out

#- 42 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "6vEQ0Fb0fOzSwVrT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'e2Pix8IgOyJOxbfi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicPromotePartyLeader' test.out

#- 43 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'uUDdzfJOveiGttir' \
    > test.out 2>&1
eval_tap $? 43 'PublicPartyJoin' test.out

#- 44 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'Pw49eDkkTlieINXi' \
    > test.out 2>&1
eval_tap $? 44 'PublicPartyLeave' test.out

#- 45 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'ZneSGu4x8wWgDhy2' \
    > test.out 2>&1
eval_tap $? 45 'PublicPartyReject' test.out

#- 46 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'xaMbK98KZuPAGpzW' \
    --userId '8YEovlYXMD76ZVrj' \
    > test.out 2>&1
eval_tap $? 46 'PublicPartyKick' test.out

#- 47 PublicCreateParty
# body param: body
echo '{"attributes": {"TwBhG6PxRbXyacvJ": {}, "KvH2fI227sFhXEPp": {}, "ERr10WrTTWC1vHxS": {}}, "configurationName": "Vm1rRLDUorN8n8OK", "inactiveTimeout": 40, "inviteTimeout": 52, "joinability": "3ebTMfmV8RpXci3o", "maxPlayers": 1, "members": [{"ID": "tKeXlMfYcKvIDQry", "PlatformID": "hqRPwaSbAakeTI3G", "PlatformUserID": "tLp33o0hY1hJyjnn"}, {"ID": "ZKdSiFaVEfxNwD82", "PlatformID": "TygHqJCY44tteOU7", "PlatformUserID": "3MUia86OHeEezPfP"}, {"ID": "VoLzuailZgh0VftM", "PlatformID": "4duhPOP3T7IILgTK", "PlatformUserID": "DtEBnyydnlmrax9H"}], "minPlayers": 21, "textChat": false, "type": "4dKxRwFRslFsKiWo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'PublicCreateParty' test.out

#- 48 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["4atNdaNIXOzCVa9C", "aE9mVJJqgitULlhI", "9rKPyF7ytpQiDiCA"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 49 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'PublicGetPlayerAttributes' test.out

#- 50 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "j6IM6yC2yo6eKkz3", "data": {"So92LmNHqeozPTvT": {}, "yjHzkSDJwI3p6udT": {}, "5ywNYrZ3noFX2D35": {}}, "platforms": [{"name": "kjfYLmyJHWVmJhvz", "userID": "YUD7tt15VYMNdywy"}, {"name": "SdXRVEBpthoAfzvX", "userID": "P7hfNyBM3W7FEjbI"}, {"name": "46oLZUugcyZei70c", "userID": "PKSdQKPk36TgDFyR"}], "roles": ["pEbkRLet6qHFzUAA", "IA1yZDTGyGcJrX2a", "98isrEnWec7CnvrR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicStorePlayerAttributes' test.out

#- 51 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'PublicDeletePlayerAttributes' test.out

#- 52 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'TjVFQkVvDYodu7iP' \
    --orderBy 'q7Dzyrwyqgey4TDs' \
    --status 'TGVcn6u2Y8kRSlfF' \
    > test.out 2>&1
eval_tap $? 52 'PublicQueryMyGameSessions' test.out

#- 53 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'VNtTCFUDbhXFUMPg' \
    --orderBy 'IsF2FaJmavnpwvlN' \
    --status '5bxb3zVGiVgmTiYR' \
    > test.out 2>&1
eval_tap $? 53 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE