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
echo "1..66"

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

#- 5 AdminListEnvironmentVariables
$CLI_EXE \
    --sn session \
    --op AdminListEnvironmentVariables \
    > test.out 2>&1
eval_tap $? 5 'AdminListEnvironmentVariables' test.out

#- 6 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetConfigurationAlertV1' test.out

#- 7 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 2}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateConfigurationAlertV1' test.out

#- 8 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminCreateConfigurationAlertV1' test.out

#- 9 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminDeleteConfigurationAlertV1' test.out

#- 10 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 18, "PSNSupportedPlatforms": ["uz5zkoaUEzGS3qZf", "0PbemSBELbZ0VBUG", "A7nkDeev2Oj060Hn"], "SessionTitle": "Of5S8X1LxkZs4233", "ShouldSync": false, "XboxServiceConfigID": "F7bwRgwKvzESbhpx", "XboxSessionTemplateName": "lDdEs4igdKeLmy8t", "localizedSessionName": {"Z5GZi5P12c61ts3f": {}, "MI04rm2jUc9iav3t": {}, "TqlE9oLDPD0Lfle8": {}}}, "PSNBaseUrl": "ESU1MO8XnVaEyjmi", "autoJoin": false, "clientVersion": "Ou124TsbQsxYFxGG", "deployment": "HrfQkgXkiA5IZPqC", "dsSource": "qp9vcyt67WAfWXfU", "fallbackClaimKeys": ["fwGB03tz8qIH4uRd", "NO08HN6s9p8Y5c9e", "ItJtiNmY3y3n2Rim"], "immutableStorage": true, "inactiveTimeout": 82, "inviteTimeout": 25, "joinability": "BqhuNtj8FOvKZjs1", "maxActiveSessions": 39, "maxPlayers": 2, "minPlayers": 76, "name": "kTGYKqRMSTisP0Mr", "persistent": false, "preferredClaimKeys": ["0A2zyZsb4FvWFIHP", "IbOjpls9BZTYc5Bs", "dSSVaAzzn4GbgkKe"], "requestedRegions": ["CaS6qyUCscHXs8Pl", "OBlfUOqv7WmCuqcs", "NM7YAnbq4DjmYUMh"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "qU89D356pVsUtNan"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminCreateConfigurationTemplateV1' test.out

#- 11 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --name 'rA0WWyKl2K5mCSoG' \
    --offset '10' \
    --order 'opcEM0JHfof2Hwi7' \
    --orderBy 'vg3osbh0fL2h7eJv' \
    > test.out 2>&1
eval_tap $? 11 'AdminGetAllConfigurationTemplatesV1' test.out

#- 12 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'AS2W4uqkhwSC7Eaj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminGetConfigurationTemplateV1' test.out

#- 13 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 45, "PSNSupportedPlatforms": ["N0YdGSrA9LXRwU6W", "LgpQE9nXzhBC0uyM", "R4Xf2nfYvNvG8uQ1"], "SessionTitle": "4AhsxaALiBwpNJor", "ShouldSync": false, "XboxServiceConfigID": "0m7NjUZ95Z5XDLBN", "XboxSessionTemplateName": "9YGVPtkjt0OyBlJi", "localizedSessionName": {"4RbZ0Iy11mfOFjCz": {}, "ZVcGomWF1oAqUNFD": {}, "tXnXLvOAsW8wYh4g": {}}}, "PSNBaseUrl": "q7pRVZVLJiDx3au9", "autoJoin": false, "clientVersion": "MFzeiMRkcOr1L0TM", "deployment": "IczbYilOziwG8CPL", "dsSource": "OzSZm9K3cMY617HS", "fallbackClaimKeys": ["CYZaL46I3PgCcQ0a", "xTWnmyEYLZQTpvLH", "6QPEBP8kSSFjeuL3"], "immutableStorage": true, "inactiveTimeout": 17, "inviteTimeout": 87, "joinability": "sZelKuD0iJ6fs3zL", "maxActiveSessions": 47, "maxPlayers": 70, "minPlayers": 30, "name": "4WxGWRH7fz4BdPhL", "persistent": true, "preferredClaimKeys": ["ensa3MZF7DTswnkS", "yuJTVjKQ1ORLEIAe", "PvDO2xkVgyRk10b2"], "requestedRegions": ["7RdU8VceYQ9erPYQ", "5yVcQuvDbGMqbEHk", "CQwMBcQUNPHN8YZT"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "JJ0uCjjaNCRV3hSI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'iTEoTCSxjAqg9oGV' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminUpdateConfigurationTemplateV1' test.out

#- 14 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'EdC8mQir1Af0G6Or' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteConfigurationTemplateV1' test.out

#- 15 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminGetDSMCConfiguration' test.out

#- 16 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminSyncDSMCConfiguration' test.out

#- 17 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'PH6ZsjpPgHKISHtB' \
    --dsPodName '8tWdJM9Qc5HmR0vk' \
    --fromTime 'nXO45AUtNXSTItt3' \
    --gameMode '5OJTfJBZX62yI9g5' \
    --isPersistent 'RDrlzPFQmNu3ERxV' \
    --isSoftDeleted '0UTaiSzfi0FnBERe' \
    --joinability '8qNYRTYSaZw4NqSN' \
    --limit '51' \
    --matchPool 'dygfKmUkzj9mHFpf' \
    --memberID 'f2vDkz68zorEgcEx' \
    --offset '43' \
    --order '98WUoXvfU4qMIpfg' \
    --orderBy 'xw2ff5twRYbtdK2r' \
    --sessionID '4wWs6IpYBxafo9b4' \
    --status 'xJyNnvHKrm8UuNlT' \
    --statusV2 '86N9yO0vyD6J5brV' \
    --toTime 'o20e6POTjrinAVVo' \
    > test.out 2>&1
eval_tap $? 17 'AdminQueryGameSessions' test.out

#- 18 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["vpAAXNzcpbmX3lLF", "eXCiaXP8jBjK81t2", "V9TVauFcGkPgQ0hb"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteBulkGameSessions' test.out

#- 19 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId '2tLrsMeoZiRYkbhE' \
    --namespace $AB_NAMESPACE \
    --sessionId 'M1zTNY3lpincuf5d' \
    --statusType '5saQvKfFRqBam8jP' \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateGameSessionMember' test.out

#- 20 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'tKHTmzo0JmcQmnsU' \
    --key 'igVynjGFyVicGQAV' \
    --leaderID 'v32ftRAsmC0RuRA8' \
    --limit '18' \
    --memberID 'ks2R3VMtipTVxXAF' \
    --memberStatus '8KhOKqbrECijFxOp' \
    --offset '83' \
    --order 'Lj5dw3LK0gPYhPPG' \
    --orderBy '5sAIfYtYozA2OntG' \
    --partyID 'CwQSHHdPLwjTngrv' \
    --value 'b2E1X9ecBBhRAYjR' \
    > test.out 2>&1
eval_tap $? 20 'AdminQueryParties' test.out

#- 21 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminGetPlatformCredentials' test.out

#- 22 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "7c4x5bIk8pVpxdUW", "clientSecret": "OPel3TiwTycqpVdI", "scope": "NXzvkSp0WbvxQWI0"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminUpdatePlatformCredentials' test.out

#- 23 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminDeletePlatformCredentials' test.out

#- 24 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'QGCOx7eICkauWbFr' \
    > test.out 2>&1
eval_tap $? 24 'AdminReadSessionStorage' test.out

#- 25 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'SnU7d1BuhdwliTSD' \
    > test.out 2>&1
eval_tap $? 25 'AdminDeleteUserSessionStorage' test.out

#- 26 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'dmGVfegiD3mrVQaU' \
    --userId 'r3oT88Dfc7114QFG' \
    > test.out 2>&1
eval_tap $? 26 'AdminReadUserSessionStorage' test.out

#- 27 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'wTzBVDg5v71kGCEt' \
    > test.out 2>&1
eval_tap $? 27 'AdminQueryPlayerAttributes' test.out

#- 28 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId '7h1mVwIQCJmQkvWb' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetPlayerAttributes' test.out

#- 29 CreateGameSession
# body param: body
echo '{"attributes": {"Qrn2W0VkOF0pQOY0": {}, "UCcViiFKNjkT5hcO": {}, "NCaOyATBFgqLeAzv": {}}, "autoJoin": false, "backfillTicketID": "0NVnaangorhVFpTR", "clientVersion": "uQyMroT2hNfKJ7q8", "configurationName": "sifSPmYSsBxtyKWs", "deployment": "sEn5VEvIMEB4pl50", "dsSource": "6fLCG6EAl7d3Ks65", "fallbackClaimKeys": ["thtnjcMSw1J42fth", "KUobas2CAlSxxVhD", "R9hlaznetBUGcQz2"], "inactiveTimeout": 100, "inviteTimeout": 57, "joinability": "vdiclkYGDL2ckC9c", "matchPool": "dzaLnajQ8GnJpALi", "maxPlayers": 7, "minPlayers": 9, "preferredClaimKeys": ["dv9UUtG1tEECsm8x", "aDOz0tMlpFuJVXo9", "s0JPG8cgjHQo9HoL"], "requestedRegions": ["LyUnPTiCD0038or8", "wR0tuwIJnrSI2IFc", "RwSoMTuJziuDNbOy"], "serverName": "diu3lOaruuYw0iUu", "teams": [{"UserIDs": ["ts6bChMK1gcx8p9f", "yv5PoMJeTIQix1FE", "vzlipE7r0vhh21v5"], "parties": [{"partyID": "772AopmjI7CbY2Wu", "userIDs": ["wRUT9IivgC4mJ5OH", "uNEVQK4Mvk00I9Gq", "AhhjNIivdIcaEQfN"]}, {"partyID": "ETQCBPK1mYwKVQoy", "userIDs": ["dbYjXZyBpqhCJBtF", "Om3iCpu0lhhgutt3", "rQuKP1OEtKFBjNih"]}, {"partyID": "HU8GP8TRVypSvYXK", "userIDs": ["z4BGjbsrRBV8aztJ", "86yQK1AsC18UO6Jc", "XmwQfkseTpH6l2Dv"]}]}, {"UserIDs": ["8SvqYKc56PcPSL2x", "mjViKkKw4gHA4CaL", "sPqRsTdKzcKtkGcv"], "parties": [{"partyID": "n44NWse6VLPkM1VT", "userIDs": ["rQBywhJ7lbBLw9xy", "1WQM5qUS8baUqkzS", "r41y6RPBHJuPjj8z"]}, {"partyID": "DwOk0IgmYfUTpFzy", "userIDs": ["QhPVhRGX9xlUKhXI", "8mL8OIhvP68xE68d", "zohxhbej2caIIfkX"]}, {"partyID": "DY7jnhp3qY6T7TUE", "userIDs": ["BotSNIwGhia6cqoW", "mnhtuzxir12r0VUW", "I0kJAczj5ApcsiEQ"]}]}, {"UserIDs": ["65llgGnTHAsTCZa7", "xE4nwGKlbPRxfucx", "oRKFLxxcL9SyuHbv"], "parties": [{"partyID": "RxR6LaKWgAVjZKDx", "userIDs": ["iezEbuMCz9J4dPRG", "zoQLYIWPPZvyPupi", "mCENHEenqjRSxO9o"]}, {"partyID": "Z0fCxLR0GfjwCmDr", "userIDs": ["bDR0Q0ixpqYtkZuh", "L6qbAhRExsnbWSH4", "5LarTmOqto4OtwF9"]}, {"partyID": "uPUAxerdIqWmOoMy", "userIDs": ["Yp2tSrLxpJnj9Jtg", "jWmjx1WuNQq4v8Fn", "VzdbNW1xuV7rVei1"]}]}], "textChat": false, "ticketIDs": ["73sDdDoXnB8F5X05", "KUgGKfDSGh3vQFPS", "YCi8WEjR3wqpnMdS"], "tieTeamsSessionLifetime": true, "type": "fDK45zWtwYhRoNPw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateGameSession' test.out

#- 30 PublicQueryGameSessions
# body param: body
echo '{"Kema6caMTOcivPAk": {}, "mP8Awb0NqtvSR9q6": {}, "l5k9BLQMrPoTuxdz": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicQueryGameSessions' test.out

#- 31 PublicSessionJoinCode
# body param: body
echo '{"code": "EYAw5VdW05WnQEAb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicSessionJoinCode' test.out

#- 32 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'K416LN2N6D6yczit' \
    > test.out 2>&1
eval_tap $? 32 'GetGameSessionByPodName' test.out

#- 33 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'n4OkZfx0Xa6sgegA' \
    > test.out 2>&1
eval_tap $? 33 'GetGameSession' test.out

#- 34 UpdateGameSession
# body param: body
echo '{"attributes": {"WYz2z4qSPPQBDFQs": {}, "vRHbGTC2ynue7Xk4": {}, "uDF5mdakWJ2AsKf8": {}}, "backfillTicketID": "UfQqTQ8v7gXyFuLF", "clientVersion": "ZViQbxYQvUyapo6F", "deployment": "mMy6tZYSCe7du68C", "fallbackClaimKeys": ["e6T4pYH3BPyFurT4", "p8zoRYG8WKTaUyB0", "UyrKKulHUnompTrS"], "inactiveTimeout": 61, "inviteTimeout": 71, "joinability": "ymQeVSZZma57V6b9", "matchPool": "uLloAA9KoetyNPkg", "maxPlayers": 99, "minPlayers": 37, "preferredClaimKeys": ["cTCN7aBIFfeRdnHp", "se2T7eZwkVrB3GSE", "mVq8CjR5rCx0ZiHw"], "requestedRegions": ["UqL5rITYFhcdeNwL", "mZenRqEBM0VGzhVV", "Gdipdi33u9U14rGw"], "teams": [{"UserIDs": ["vMExAllZtPzNRiR3", "5CZhclugjyDzCPI8", "tslD0HuRrAMzMB9X"], "parties": [{"partyID": "HHkfZgB6Vt5qWaae", "userIDs": ["3SboVKgjsryC98wh", "mI5koBT6iCuVa643", "kk8gvvnsu0ABei0g"]}, {"partyID": "o2wsmPfpsbkzAIsJ", "userIDs": ["06QlFCAa55r89MdF", "idv2kFVXgnjrAfzE", "n26mHgxUgVDgnlU5"]}, {"partyID": "H2ULa1LYlsqYrUpX", "userIDs": ["ncYv2BVIS1BtMqvd", "E5QQizMBWYPYerJ1", "FmKBX6U18gMIl7TS"]}]}, {"UserIDs": ["Pm96MsoQcFDfKSJy", "mqZ5tDVsJ63mFWW0", "u95r5ylQKcWi0o5z"], "parties": [{"partyID": "cWp7NiTBI4m6PVEQ", "userIDs": ["WCNw7DHkXx8NqXaR", "2w60X5Vb0TV0x3nm", "q9UCZbdVFY3WdZ6l"]}, {"partyID": "uOW977EgotvOrnRj", "userIDs": ["b5UT6Vf5jxoBBg2l", "M3DQXyC3oKu14sRj", "kCeuRY0tsnbKAGRT"]}, {"partyID": "CvAZKiSB7bYvWmbU", "userIDs": ["bWlRZtcIUry87yJB", "lfjPI5tfjbyZkYSR", "LBMgcD5OJgp6wHyn"]}]}, {"UserIDs": ["VKwWgdAibFBESdI0", "Ab1zgjMC3hp1s4tE", "lQhEA9ThpSbyAYJe"], "parties": [{"partyID": "BCrKDcRkI5LI6Uqi", "userIDs": ["vHoIArvDT62TaGFS", "xd4y808Fey8nfaGE", "w6BAuz1YkANj6LHa"]}, {"partyID": "NMxGL2cjWg68JcPw", "userIDs": ["qh2N4nelbmKVyNZY", "8IVtOeznPwNRnztP", "1VeNj0XYtINcOQIi"]}, {"partyID": "LdvpuYVOAU9uuKPG", "userIDs": ["NN6m8BLNzJxMR9F8", "QPVUh3Fxn8VCvtdi", "iwNMAdIodiW3hcYu"]}]}], "ticketIDs": ["KSRkkKQKIVOduQww", "DrBnpQpIKdlw0Q8Q", "m0lpTupwpI0MCORO"], "tieTeamsSessionLifetime": false, "type": "gnYO9A4NtX4m0L4B", "version": 67}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'J8hey5JmuUDlojEc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGameSession' test.out

#- 35 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '712JEhS1VFA1Eo4R' \
    > test.out 2>&1
eval_tap $? 35 'DeleteGameSession' test.out

#- 36 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"xcnq5DtzSaifByaj": {}, "u2TY0QdHndDWB60e": {}, "GxKadAf6UL9MkkVf": {}}, "backfillTicketID": "8dHJYJF19NcUSJgQ", "clientVersion": "SBwkX1FU71K0CzXz", "deployment": "dQIWh5PSp024SIhn", "fallbackClaimKeys": ["u3h3uK1jRHhQ2uS2", "7tXHvtxi6EbWHrMr", "bpZd2bt6P3sZXAZk"], "inactiveTimeout": 6, "inviteTimeout": 7, "joinability": "h450P2HCQEysNYmC", "matchPool": "ndtXXQgiHJgjwpCx", "maxPlayers": 67, "minPlayers": 4, "preferredClaimKeys": ["EBsc3HVarhLlwlmf", "1l5JhrQSpGlguvTE", "CefhiKKuc8Urg4at"], "requestedRegions": ["ANoOfyCbfBoH6zLg", "TsYmAw4mFyLcIq00", "Vl8sxzC1fJxroZeN"], "teams": [{"UserIDs": ["IlbxAUeRUjUbaPkl", "fVic7zYJTjpmhWVB", "gTDm8IGJL3sEpnq2"], "parties": [{"partyID": "qNgEjKMemoxx1k2s", "userIDs": ["5gW8zADPqu8PVXnN", "0xl48RoZbNL7cXCV", "aF9U1H9bQv7EybPw"]}, {"partyID": "bHEHxSPaGCQl5y1g", "userIDs": ["ekeqHnzZfY22Z1Sm", "Ic5NTRyLbOzAYD5I", "H4deTFCDORAsuT0l"]}, {"partyID": "seQtOoohdBYhvvws", "userIDs": ["pKpEPUUxc2NKFB2q", "xCiWMNdvN9SDRKye", "6n1t8RXF5qayS4UA"]}]}, {"UserIDs": ["MJrRrnNfXdTnJz7e", "3tD8KVlMU17V03QD", "QjU64lc3oek3RWXW"], "parties": [{"partyID": "JhPXvS9OmmtZ14XR", "userIDs": ["OPpbgqS9a9eP72cb", "SH4TvY6sMCkitXsN", "fi8EF3mgABwFe1N0"]}, {"partyID": "QNeryssScV8w2rN4", "userIDs": ["0y7aLOJoeZqRwJzT", "dMg00KvHLdMiaje6", "w7YN9MWtYzurSMcK"]}, {"partyID": "8c5xZukais9Topwz", "userIDs": ["yVFe9lNT7v5QycBC", "xJG7DehSEc6kg2UW", "X8dfboaqkOS5P8ij"]}]}, {"UserIDs": ["eU7ceEjsJO7xZUK7", "lMGDnKhxDxWqk0Fy", "DBDBxAznXS1mfs6u"], "parties": [{"partyID": "Z9OaZwm6pPAdF5lH", "userIDs": ["MHzBycY7bXyRpFUt", "s9CpuTZNXAvR5mEj", "DGi8Z9KuTHuT6IlI"]}, {"partyID": "mbAYCRvUBIHoIhUn", "userIDs": ["q8EtmzVPJFqDDsFm", "DKPixcJtgNHrTEQp", "FB5aeIMGxoyLMqSL"]}, {"partyID": "DNxuBA95CXk3K2oL", "userIDs": ["MyvJ6M0zKUQCLksf", "hWE1OiCOozFmZ3hz", "payQ1ySXmHgROq1X"]}]}], "ticketIDs": ["5e82zDrJtNcl4zts", "aFwrylG42gHaf4XE", "HX7QBUYvSupGJqpw"], "tieTeamsSessionLifetime": true, "type": "dqP6c448AniKDjnb", "version": 43}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'cFYyJtzDcKD3CR18' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PatchUpdateGameSession' test.out

#- 37 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "eggGJVXROWQLNP4J"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId '0I2wDjuMHSknrvHs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateGameSessionBackfillTicketID' test.out

#- 38 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'arToh01sSaePBAWr' \
    > test.out 2>&1
eval_tap $? 38 'GameSessionGenerateCode' test.out

#- 39 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'nMRr0i4i3znplxZV' \
    > test.out 2>&1
eval_tap $? 39 'PublicRevokeGameSessionCode' test.out

#- 40 PublicGameSessionInvite
# body param: body
echo '{"platformID": "kkzCuWXN0pi9oHwF", "userID": "FSWlYJSaX14Onxc8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId '2WUAqFNlxPL5ZjWv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PublicGameSessionInvite' test.out

#- 41 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'AiWvl12EyddbFelm' \
    > test.out 2>&1
eval_tap $? 41 'JoinGameSession' test.out

#- 42 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "B60OEQrMIsKCf8Gs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'PEl1i9RQ9tNv9ZoF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicPromoteGameSessionLeader' test.out

#- 43 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'goU8geQqTHsgesxU' \
    > test.out 2>&1
eval_tap $? 43 'LeaveGameSession' test.out

#- 44 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'deb2FJbsqzkOO5Tg' \
    > test.out 2>&1
eval_tap $? 44 'PublicGameSessionReject' test.out

#- 45 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "Vxhorx7Olr6yZsG5", "userIDs": ["AHeXjxQCmc8jD3q7", "UouREPLDNt6Bi4ud", "SrXnIItduiUuy8tq"]}, {"partyID": "9HCTgLSuFiv2W3x3", "userIDs": ["8AyIWIiWAkZb55Pm", "Nf9MzOCP7HO3NR5E", "mbWMmuHbWUeXEPRF"]}, {"partyID": "6TjBh6iQOGSqSf29", "userIDs": ["O4OCHr6PHDU3g8gw", "rRCGr34cRXz9Jsaz", "gdXDoGshLr8yn7Ao"]}], "proposedTeams": [{"UserIDs": ["XGMgLGDEgjGR3AjE", "TQmuBhxdl2hmyNHx", "2EwggD6ThfKbveaN"], "parties": [{"partyID": "PadM954Klf9ScyQ3", "userIDs": ["BkdgTB8XsRpozxyz", "QjkAwoiKpqCxRaxD", "64vrtLT4cBalVmLr"]}, {"partyID": "DPUnoL1yIqAGPGIM", "userIDs": ["Ns07P35ZIntLvl9D", "QDCBJjs12pGhuGLD", "6vHktU3ynqJffmZN"]}, {"partyID": "fIZBEmg9ppW9kqHg", "userIDs": ["6qWRr5OGM3cUFnnf", "4mVneUyBHCEsHoUz", "3vp9jpSUMWJyDVld"]}]}, {"UserIDs": ["aDNtR0AXW63sbPYT", "KP8EQupMajWTKw5F", "eR8ri3yXrzd1ieTR"], "parties": [{"partyID": "urPzBSUlLhIUZaqD", "userIDs": ["R1n6aKcCVL5Fd1b8", "wgnlhP7Pg5lC7Ea2", "70WU05apXkWulzfN"]}, {"partyID": "ESEwZkxwcIoptsiG", "userIDs": ["0JEo50u4dtDARQgh", "CkujmLLnrNNSLh36", "UQbPSJQQhceSla9E"]}, {"partyID": "RYYip5g4u0MAPcVP", "userIDs": ["H3gZ7BL95xBXZ4Q2", "kZcVEtlghVPGnqtF", "jbFAzllHBMrW7hG6"]}]}, {"UserIDs": ["7ye23P8DW1ccz649", "aMbZ9u0Okl1IHd8Q", "5JqhDP8ljUtdmP5z"], "parties": [{"partyID": "dR2WzZ26M7190BUU", "userIDs": ["MJA2i5Q4vFfXwKGl", "PrvLQjEMxmStiAYc", "nCKHJa29YjFCGXPz"]}, {"partyID": "xvGWXSYKxZFwAJdG", "userIDs": ["F5bhjI1EEc3WV5k6", "IPw3luGBMK9OmEmy", "tZjYEiOxHZltYdZO"]}, {"partyID": "iBafLm9cc3OUVUdC", "userIDs": ["6vEQ0Fb0fOzSwVrT", "e2Pix8IgOyJOxbfi", "uUDdzfJOveiGttir"]}]}], "version": 85}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'MIqwXxAtcjA062eW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'AppendTeamGameSession' test.out

#- 46 PublicPartyJoinCode
# body param: body
echo '{"code": "YCE2BZKl6Ks6ND0e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'PublicPartyJoinCode' test.out

#- 47 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'vlW05Ize0EKI1ogo' \
    > test.out 2>&1
eval_tap $? 47 'PublicGetParty' test.out

#- 48 PublicUpdateParty
# body param: body
echo '{"attributes": {"fwrtjPjSrjvrgKMZ": {}, "79d1xh7UR0UxrnZ5": {}, "OMXgRDRM3gg9nVFQ": {}}, "inactiveTimeout": 42, "inviteTimeout": 89, "joinability": "xaksqHEV6l9c1J0Y", "maxPlayers": 98, "minPlayers": 37, "type": "SAUWFWpU4iAd1zlF", "version": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'TMfmV8RpXci3oXtK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicUpdateParty' test.out

#- 49 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"eXlMfYcKvIDQryhq": {}, "RPwaSbAakeTI3GtL": {}, "p33o0hY1hJyjnnZK": {}}, "inactiveTimeout": 6, "inviteTimeout": 36, "joinability": "SiFaVEfxNwD82Tyg", "maxPlayers": 69, "minPlayers": 21, "type": "qJCY44tteOU73MUi", "version": 1}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId '3xKDRbcNco2qPofs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PublicPatchUpdateParty' test.out

#- 50 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'hHt88ZrOopYOMqbJ' \
    > test.out 2>&1
eval_tap $? 50 'PublicGeneratePartyCode' test.out

#- 51 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'Vfyl0ssL0Nn5BZz9' \
    > test.out 2>&1
eval_tap $? 51 'PublicRevokePartyCode' test.out

#- 52 PublicPartyInvite
# body param: body
echo '{"platformID": "qxx7lz9uMrrT54dK", "userID": "xRwFRslFsKiWo4at"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'NdaNIXOzCVa9CaE9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'PublicPartyInvite' test.out

#- 53 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "mVJJqgitULlhI9rK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'PyF7ytpQiDiCAh2l' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'PublicPromotePartyLeader' test.out

#- 54 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'kPXOOJp91w7ACgmr' \
    > test.out 2>&1
eval_tap $? 54 'PublicPartyJoin' test.out

#- 55 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'ezLCJKLPrwjeYeJi' \
    > test.out 2>&1
eval_tap $? 55 'PublicPartyLeave' test.out

#- 56 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId '9q4KUgzZZ6zaaAvv' \
    > test.out 2>&1
eval_tap $? 56 'PublicPartyReject' test.out

#- 57 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'Ki9jeErSpDVNGzTI' \
    --userId 'FbOjIMnvbwCSAfTU' \
    > test.out 2>&1
eval_tap $? 57 'PublicPartyKick' test.out

#- 58 PublicCreateParty
# body param: body
echo '{"attributes": {"y9Iqsv2Y3W67ojKl": {}, "GpC6ngrWr5beUGEW": {}, "4t5eLuFOuGciip6l": {}}, "configurationName": "hOAT59629Ly5GJfa", "inactiveTimeout": 89, "inviteTimeout": 7, "joinability": "lZeRpPnJNyrwdMhl", "maxPlayers": 51, "members": [{"ID": "RLet6qHFzUAAIA1y", "PlatformID": "ZDTGyGcJrX2a98is", "PlatformUserID": "rEnWec7CnvrRTjVF"}, {"ID": "QkVvDYodu7iPq7Dz", "PlatformID": "yrwyqgey4TDsTGVc", "PlatformUserID": "n6u2Y8kRSlfFVNtT"}, {"ID": "CFUDbhXFUMPgIsF2", "PlatformID": "FaJmavnpwvlN5bxb", "PlatformUserID": "3zVGiVgmTiYRqChq"}], "minPlayers": 24, "textChat": false, "type": "wszlQrWl9mqTkN4I"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicCreateParty' test.out

#- 59 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"EuQISWdQ728o1qcl": {}, "vhlm929zMAdlyXyq": {}, "tmIwkhB1niuOHHkE": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'MM2LdYulOoouVLyY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'PublicUpdateInsertSessionStorageLeader' test.out

#- 60 PublicUpdateInsertSessionStorage
# body param: body
echo '{"5l3zat0SbuB1wMD5": {}, "1VeGbfpAAYyBbEy0": {}, "fEmRKPynE1Ulth6W": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'UsfyOIdVfGOJIPb5' \
    --userId 'iLNRM7JFauJ3tVse' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicUpdateInsertSessionStorage' test.out

#- 61 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["tZATTbB1ZGFmU24Z", "5anp1Fr9PhX008zk", "RCTEr3CbX1jCvt8S"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 62 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 62 'PublicGetPlayerAttributes' test.out

#- 63 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "VAQVTEjLxRXXw1Ba", "data": {"3BCLDK9EHH019Qef": {}, "K1Zmj8WfGj2nDHeE": {}, "HT96WiKFqOEuv5vi": {}}, "platforms": [{"name": "mn63Casxqy2jZLzE", "userID": "1twcaIT8fi9jXsmt"}, {"name": "xDfayxSlb89FR48V", "userID": "T5BKwgRAIQHZN92V"}, {"name": "P4rbnVQ2wDVZFHDm", "userID": "lKMyosJXwZbP6pG2"}], "roles": ["cmQhEgLUgzcFvsZ7", "ws7IsSADlM888Xt8", "E5iE51ruSZ153e9f"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'PublicStorePlayerAttributes' test.out

#- 64 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'PublicDeletePlayerAttributes' test.out

#- 65 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'Db7M4vfe4FykMi3Y' \
    --orderBy '9S70xe8Wk0MBFmL9' \
    --status 'yc68k3c9GJsynFlh' \
    > test.out 2>&1
eval_tap $? 65 'PublicQueryMyGameSessions' test.out

#- 66 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'TJoB9DVDzdKc96qC' \
    --orderBy 'UqhMuZYAzHXsCOpj' \
    --status 'W3CTUUFdOJRHv7ar' \
    > test.out 2>&1
eval_tap $? 66 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE