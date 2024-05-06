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
echo "1..80"

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

#- 6 AdminListGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminListGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 6 'AdminListGlobalConfiguration' test.out

#- 7 AdminUpdateGlobalConfiguration
# body param: body
echo '{"regionRetryMapping": {"bBuz5zkoaUEzGS3q": ["Zf0PbemSBELbZ0VB", "UGA7nkDeev2Oj060", "HnOf5S8X1LxkZs42"], "33oQWoXFeqeuI2oM": ["J0cgAoGfXepE3r5A", "QUBqS8KtTYZLJ58Q", "qcV3IcuNs9MF5BT2"], "KD18yrWorpC65VJh": ["4q1z1KJmKedBfbWv", "Ka5Ou124TsbQsxYF", "xGGHrfQkgXkiA5IZ"]}, "regionURLMapping": ["PqCqp9vcyt67WAfW", "XfUfwGB03tz8qIH4", "uRdNO08HN6s9p8Y5"], "testGameMode": "c9eItJtiNmY3y3n2", "testRegionURLMapping": ["Rim4NBqhuNtj8FOv", "KZjs1tLpERf77LzP", "oORBkRmZ0A2zyZsb"], "testTargetUserIDs": ["4FvWFIHPIbOjpls9", "BZTYc5BsdSSVaAzz", "n4GbgkKeCaS6qyUC"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateGlobalConfiguration \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateGlobalConfiguration' test.out

#- 8 AdminDeleteGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminDeleteGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteGlobalConfiguration' test.out

#- 9 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminGetConfigurationAlertV1' test.out

#- 10 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateConfigurationAlertV1' test.out

#- 11 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 68}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminCreateConfigurationAlertV1' test.out

#- 12 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteConfigurationAlertV1' test.out

#- 13 HandleUploadXboxPFXCertificate
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn session \
    --op HandleUploadXboxPFXCertificate \
    --namespace $AB_NAMESPACE \
    --description 'cHXs8PlOBlfUOqv7' \
    --certname 'WmCuqcsNM7YAnbq4' \
    --upload file $TEMP_FILE_UPLOAD \
    --password 'DjmYUMhD9qU89D35' \
    > test.out 2>&1
eval_tap $? 13 'HandleUploadXboxPFXCertificate' test.out

#- 14 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 31, "PSNSupportedPlatforms": ["YfnXTsQUrA0WWyKl", "2K5mCSoGeQCahcox", "63cyDxAAYcRXJdoS"], "SessionTitle": "TxNCK9AIjNmbfoW8", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "Dq5jPqzhN0YdGSrA", "XboxServiceConfigID": "9LXRwU6WLgpQE9nX", "XboxSessionTemplateName": "zhBC0uyMR4Xf2nfY", "XboxTitleID": "vNvG8uQ14AhsxaAL", "localizedSessionName": {"iBwpNJornrCQpMJj": {}, "5igqat8xnPoWTdHA": {}, "kcyAy4drHlPcXGGl": {}}}, "PSNBaseUrl": "0Xw3veBfrpCrnbax", "attributes": {"hEvn3SGqcH91fC3a": {}, "JEoqWaFAGD6PRg95": {}, "m07l03vtlMFzeiMR": {}}, "autoJoin": false, "autoLeaveSession": false, "clientVersion": "cOr1L0TMIczbYilO", "deployment": "ziwG8CPLOzSZm9K3", "disableCodeGeneration": false, "dsManualSetReady": false, "dsSource": "MY617HSCYZaL46I3", "enableSecret": false, "fallbackClaimKeys": ["bkFx8DmbC9UqYdYr", "dxNnuMcAwrSzYnrc", "etxObeisZelKuD0i"], "immutableStorage": true, "inactiveTimeout": 10, "inviteTimeout": 68, "joinability": "s3zL9H4WxGWRH7fz", "leaderElectionGracePeriod": 96, "manualRejoin": true, "maxActiveSessions": 93, "maxPlayers": 6, "minPlayers": 44, "name": "PhLtHRJOImSq37ae", "persistent": true, "preferredClaimKeys": ["nkSyuJTVjKQ1ORLE", "IAePvDO2xkVgyRk1", "0b27RdU8VceYQ9er"], "requestedRegions": ["PYQ5yVcQuvDbGMqb", "EHkCQwMBcQUNPHN8", "YZT0yJJ0uCjjaNCR"], "textChat": false, "tieTeamsSessionLifetime": true, "type": "IiTEoTCSxjAqg9oG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminCreateConfigurationTemplateV1' test.out

#- 15 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '97' \
    --name 'L24DKGwgZ85vyFJR' \
    --offset '84' \
    --order 'euQBLVu27iwplLJd' \
    --orderBy 'zYS9K0VvwE6MAqPc' \
    > test.out 2>&1
eval_tap $? 15 'AdminGetAllConfigurationTemplatesV1' test.out

#- 16 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name '8lGIYWTwxyqQQIXV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetConfigurationTemplateV1' test.out

#- 17 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 26, "PSNSupportedPlatforms": ["OJTfJBZX62yI9g5R", "DrlzPFQmNu3ERxV0", "UTaiSzfi0FnBERe8"], "SessionTitle": "qNYRTYSaZw4NqSNy", "ShouldSync": false, "XboxAllowCrossPlatform": true, "XboxSandboxID": "cljuNM3eUUSD1pZG", "XboxServiceConfigID": "MfPdGIOAZ86un0L9", "XboxSessionTemplateName": "8WUoXvfU4qMIpfgx", "XboxTitleID": "w2ff5twRYbtdK2r4", "localizedSessionName": {"wWs6IpYBxafo9b4x": {}, "JyNnvHKrm8UuNlT8": {}, "6N9yO0vyD6J5brVo": {}}}, "PSNBaseUrl": "20e6POTjrinAVVov", "attributes": {"pAAXNzcpbmX3lLFe": {}, "XCiaXP8jBjK81t2V": {}, "9TVauFcGkPgQ0hb2": {}}, "autoJoin": true, "autoLeaveSession": true, "clientVersion": "6nDi33Iztr2QcwlR", "deployment": "rReRajlpk8lfuiJV", "disableCodeGeneration": false, "dsManualSetReady": true, "dsSource": "ktlx9zJZVVCc9bpI", "enableSecret": true, "fallbackClaimKeys": ["EWQMmCkIqwqpoTVC", "NrcaVozsjIXO2EUs", "AfBvo6Llcalks2R3"], "immutableStorage": true, "inactiveTimeout": 99, "inviteTimeout": 17, "joinability": "hADRqJvaZrf2qXQF", "leaderElectionGracePeriod": 58, "manualRejoin": true, "maxActiveSessions": 52, "maxPlayers": 17, "minPlayers": 89, "name": "jFxOpOzxeTLJQsZc", "persistent": true, "preferredClaimKeys": ["hPPG5sAIfYtYozA2", "OntGCwQSHHdPLwjT", "ngrvb2E1X9ecBBhR"], "requestedRegions": ["AYjR7c4x5bIk8pVp", "xdUWOPel3TiwTycq", "pVdINXzvkSp0Wbvx"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "0QGCOx7eICkauWbF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'rSnU7d1BuhdwliTS' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateConfigurationTemplateV1' test.out

#- 18 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'DdmGVfegiD3mrVQa' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteConfigurationTemplateV1' test.out

#- 19 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'Ur3oT88Dfc7114QF' \
    --namespace $AB_NAMESPACE \
    --userId 'GwTzBVDg5v71kGCE' \
    > test.out 2>&1
eval_tap $? 19 'AdminGetMemberActiveSession' test.out

#- 20 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "t7h1mVwIQCJmQkvW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'bQrn2W0VkOF0pQOY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminReconcileMaxActiveSession' test.out

#- 21 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminGetDSMCConfiguration' test.out

#- 22 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminSyncDSMCConfiguration' test.out

#- 23 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName '0UCcViiFKNjkT5hc' \
    --dsPodName 'ONCaOyATBFgqLeAz' \
    --fromTime 'vdcUEhWRo6ROvbuP' \
    --gameMode 'Qwl9dVfJQGkDR00o' \
    --isPersistent 'fXsbnEzHiRs0NmGh' \
    --isSoftDeleted 'xv1vuN7Xv6OuG6RR' \
    --joinability '1jPh8RblvnfNiABR' \
    --limit '12' \
    --matchPool '5thtnjcMSw1J42ft' \
    --memberID 'hKUobas2CAlSxxVh' \
    --offset '61' \
    --order 'mUEADczzrL31HuYK' \
    --orderBy 'sCBBgwb1hGjHJgxr' \
    --sessionID 'cEvnfJqU4hCv5egS' \
    --status 'QDePKSZKp6zwDQS1' \
    --statusV2 'atvJrALaiplJgRhe' \
    --toTime 'dl5Ewh3jDayYStUi' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryGameSessions' test.out

#- 24 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"BB1yz3iP8gH88Uen": {}, "lMVzIOP8NOf91LsD": {}, "7cWWOgAs8ThMpAGI": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminQueryGameSessionsByAttributes' test.out

#- 25 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["apYftYZkBXiEhdiS", "41VBAEUvoBlbH02b", "obxtljIfHBgjP9on"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminDeleteBulkGameSessions' test.out

#- 26 AdminSetDSReady
# body param: body
echo '{"ready": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminSetDSReady \
    --namespace $AB_NAMESPACE \
    --sessionId 'FEvzlipE7r0vhh21' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminSetDSReady' test.out

#- 27 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'v5772AopmjI7CbY2' \
    --namespace $AB_NAMESPACE \
    --sessionId 'WuwRUT9IivgC4mJ5' \
    --statusType 'OHuNEVQK4Mvk00I9' \
    > test.out 2>&1
eval_tap $? 27 'AdminUpdateGameSessionMember' test.out

#- 28 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '67' \
    --offset '89' \
    --order 'qAhhjNIivdIcaEQf' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetListNativeSession' test.out

#- 29 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --isSoftDeleted 'NETQCBPK1mYwKVQo' \
    --joinability 'ydbYjXZyBpqhCJBt' \
    --key 'FOm3iCpu0lhhgutt' \
    --leaderID '3rQuKP1OEtKFBjNi' \
    --limit '15' \
    --memberID 'MiR3QYZJKVNlK8PT' \
    --memberStatus 'aIXRWFTyA9MDnKGX' \
    --offset '34' \
    --order '86yQK1AsC18UO6Jc' \
    --orderBy 'XmwQfkseTpH6l2Dv' \
    --partyID '8SvqYKc56PcPSL2x' \
    --value 'mjViKkKw4gHA4CaL' \
    > test.out 2>&1
eval_tap $? 29 'AdminQueryParties' test.out

#- 30 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'AdminGetPlatformCredentials' test.out

#- 31 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "sPqRsTdKzcKtkGcv", "clientSecret": "n44NWse6VLPkM1VT", "scope": "rQBywhJ7lbBLw9xy"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminUpdatePlatformCredentials' test.out

#- 32 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'AdminDeletePlatformCredentials' test.out

#- 33 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '81' \
    --userId 'WQM5qUS8baUqkzSr' \
    > test.out 2>&1
eval_tap $? 33 'AdminGetRecentPlayer' test.out

#- 34 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '76' \
    --userId '1y6RPBHJuPjj8zDw' \
    > test.out 2>&1
eval_tap $? 34 'AdminGetRecentTeamPlayer' test.out

#- 35 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'Ok0IgmYfUTpFzyQh' \
    > test.out 2>&1
eval_tap $? 35 'AdminReadSessionStorage' test.out

#- 36 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'PVhRGX9xlUKhXI8m' \
    > test.out 2>&1
eval_tap $? 36 'AdminDeleteUserSessionStorage' test.out

#- 37 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'L8OIhvP68xE68dzo' \
    --userId 'hxhbej2caIIfkXDY' \
    > test.out 2>&1
eval_tap $? 37 'AdminReadUserSessionStorage' test.out

#- 38 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users '7jnhp3qY6T7TUEBo' \
    > test.out 2>&1
eval_tap $? 38 'AdminQueryPlayerAttributes' test.out

#- 39 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'tSNIwGhia6cqoWmn' \
    > test.out 2>&1
eval_tap $? 39 'AdminGetPlayerAttributes' test.out

#- 40 CreateGameSession
# body param: body
echo '{"attributes": {"htuzxir12r0VUWI0": {}, "kJAczj5ApcsiEQ65": {}, "llgGnTHAsTCZa7xE": {}}, "autoJoin": false, "backfillTicketID": "UfIA1guTNx7haejX", "clientVersion": "SV2oH2uH8S4Zx0AC", "configurationName": "teueMOmYP4SgxAIQ", "deployment": "TTKsdmtHu1dG0us7", "dsSource": "kIWLcgKgU9406tdR", "fallbackClaimKeys": ["Dqr3cpVbaH69NyTf", "GE59942bCwgpzUfc", "mTQjRmV0CPt1LUaT"], "inactiveTimeout": 44, "inviteTimeout": 53, "joinability": "rFaxzOfG3pTddIA0", "matchPool": "Rt6wM5oQvTMICtWy", "maxPlayers": 96, "minPlayers": 9, "preferredClaimKeys": ["tVDnhgTGXO8Utpwx", "ug8MpqczRvUdK1uO", "V1ZJTYuHpnpVX5u4"], "requestedRegions": ["gw4XBXDD7BG73sDd", "DoXnB8F5X05KUgGK", "fDSGh3vQFPSYCi8W"], "serverName": "EjR3wqpnMdSNskxh", "teams": [{"UserIDs": ["l3O3kGloooh7kL59", "8P7F3IKhiNdx1V71", "99NT7JTRFV3FxMl5"], "parties": [{"partyID": "Rw4YeHqWkG09iEAF", "userIDs": ["YWhow1WAwCs9Y0KO", "emhNPYUVA9mU8UvO", "Nyjv3GQuLHoQ6ehL"]}, {"partyID": "LK5h1bE9WU6w3tjU", "userIDs": ["hSCKySPY7yMGOuQO", "fx6HIFfwBBqG51Ra", "ZY74CqdvfPAIaPEk"]}, {"partyID": "CIXX7WQ3ytABCzYW", "userIDs": ["xYbbphuiQPU0aS2O", "Ip0B2FWiDu7POaot", "JoQQyL1bCDNisOhj"]}]}, {"UserIDs": ["EKFWmj7ioi5WZ6Zy", "mQeVSZZma57V6b9u", "LloAA9KoetyNPkgW"], "parties": [{"partyID": "cTCN7aBIFfeRdnHp", "userIDs": ["se2T7eZwkVrB3GSE", "mVq8CjR5rCx0ZiHw", "UqL5rITYFhcdeNwL"]}, {"partyID": "mZenRqEBM0VGzhVV", "userIDs": ["Gdipdi33u9U14rGw", "vMExAllZtPzNRiR3", "5CZhclugjyDzCPI8"]}, {"partyID": "tslD0HuRrAMzMB9X", "userIDs": ["HHkfZgB6Vt5qWaae", "3SboVKgjsryC98wh", "mI5koBT6iCuVa643"]}]}, {"UserIDs": ["kk8gvvnsu0ABei0g", "o2wsmPfpsbkzAIsJ", "06QlFCAa55r89MdF"], "parties": [{"partyID": "idv2kFVXgnjrAfzE", "userIDs": ["n26mHgxUgVDgnlU5", "H2ULa1LYlsqYrUpX", "ncYv2BVIS1BtMqvd"]}, {"partyID": "E5QQizMBWYPYerJ1", "userIDs": ["FmKBX6U18gMIl7TS", "Pm96MsoQcFDfKSJy", "mqZ5tDVsJ63mFWW0"]}, {"partyID": "u95r5ylQKcWi0o5z", "userIDs": ["cWp7NiTBI4m6PVEQ", "WCNw7DHkXx8NqXaR", "2w60X5Vb0TV0x3nm"]}]}], "textChat": true, "ticketIDs": ["ekpygvRDCk0koCGD", "PfbiGdBQ5DNVJAgf", "AkD0w0H6QM5AsRnp"], "tieTeamsSessionLifetime": false, "type": "DQXyC3oKu14sRjkC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'CreateGameSession' test.out

#- 41 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"euRY0tsnbKAGRTCv": {}, "AZKiSB7bYvWmbUbW": {}, "lRZtcIUry87yJBlf": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'PublicQueryGameSessionsByAttributes' test.out

#- 42 PublicSessionJoinCode
# body param: body
echo '{"code": "jPI5tfjbyZkYSRLB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicSessionJoinCode' test.out

#- 43 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'MgcD5OJgp6wHynVK' \
    > test.out 2>&1
eval_tap $? 43 'GetGameSessionByPodName' test.out

#- 44 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'wWgdAibFBESdI0Ab' \
    > test.out 2>&1
eval_tap $? 44 'GetGameSession' test.out

#- 45 UpdateGameSession
# body param: body
echo '{"attributes": {"1zgjMC3hp1s4tElQ": {}, "hEA9ThpSbyAYJeBC": {}, "rKDcRkI5LI6UqivH": {}}, "backfillTicketID": "oIArvDT62TaGFSxd", "clientVersion": "4y808Fey8nfaGEw6", "deployment": "BAuz1YkANj6LHaNM", "fallbackClaimKeys": ["xGL2cjWg68JcPwqh", "2N4nelbmKVyNZY8I", "VtOeznPwNRnztP1V"], "inactiveTimeout": 9, "inviteTimeout": 20, "joinability": "Nj0XYtINcOQIiLdv", "matchPool": "puYVOAU9uuKPGNN6", "maxPlayers": 26, "minPlayers": 12, "preferredClaimKeys": ["BLNzJxMR9F8QPVUh", "3Fxn8VCvtdiiwNMA", "dIodiW3hcYuKSRkk"], "requestedRegions": ["KQKIVOduQwwDrBnp", "QpIKdlw0Q8Qm0lpT", "upwpI0MCOROWHgnY"], "teams": [{"UserIDs": ["O9A4NtX4m0L4BGxx", "cKUh2wepEjvh8sTP", "E7JfL8ZG7IBiOpvS"], "parties": [{"partyID": "KRmJcE8fHWU8tF9T", "userIDs": ["j5DH9jDJgqZagf9T", "fKsyiaqf0Vfidvwp", "ghGz92mfgwfewY0D"]}, {"partyID": "MU8QuojVb8QgdEnI", "userIDs": ["EDOXPqBEIQJ92jD6", "Oo7qDSKsqbeuvGha", "O0uibTsnrycsu5Q9"]}, {"partyID": "BFGk7WCNwFDvIhdx", "userIDs": ["6Z0l07ceeKMsQFyZ", "CXx6V8vj07Wkqfic", "TXXWpfaSkgXo8j70"]}]}, {"UserIDs": ["KrUcPducAeJonNs4", "KunUYQNVjaoZkB3A", "I1r9iOvxo4sO2v2S"], "parties": [{"partyID": "BoI1cMTFoDvnFjF7", "userIDs": ["PyPSihYagCDowXpz", "PB56b3OlkJK0TMs6", "1QJU3NQDgVJljnvy"]}, {"partyID": "eys0Kd9lSy4dXRir", "userIDs": ["NN1XTVbZINAYTfmD", "dnbfKLdllLcrgG7M", "UCvBQxDMKfZnQUHz"]}, {"partyID": "roRILUYE0mbvUdfY", "userIDs": ["0BqpFwpFSBitprtx", "35PWwBW4wLASmNzx", "cUMh0SvR4rhLLvUw"]}]}, {"UserIDs": ["AWnj9yPsgbHDuaBM", "lhmWv2CjjBQfnFyR", "j8oJlSSFh8ZLYsKN"], "parties": [{"partyID": "sz83B3uSAH6QCBcz", "userIDs": ["exoUjGKIDYp3uk6S", "Y3LbL8Ij6Hou1skD", "80rM9MH0bGReYems"]}, {"partyID": "eR492ILQLV79lT8s", "userIDs": ["ZwaopSrf16qAbt38", "yZTqfCi5CJgLU0r1", "txp0vdRA0J8eLCZr"]}, {"partyID": "cT7EO7zBX353qlmB", "userIDs": ["OmzDZoLl4yLZgHla", "tL7nbsrfkzQM5RtM", "qCRiYe7QxHteM0Qs"]}]}], "ticketIDs": ["fB4cKcpv0nqsAzwh", "iinZMK2PQePnMgPL", "2upEuzGkAuUgSs7K"], "tieTeamsSessionLifetime": false, "type": "JG7DehSEc6kg2UWX", "version": 86}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'dfboaqkOS5P8ijeU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'UpdateGameSession' test.out

#- 46 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '7ceEjsJO7xZUK7lM' \
    > test.out 2>&1
eval_tap $? 46 'DeleteGameSession' test.out

#- 47 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"GDnKhxDxWqk0FyDB": {}, "DBxAznXS1mfs6uZ9": {}, "OaZwm6pPAdF5lHMH": {}}, "backfillTicketID": "zBycY7bXyRpFUts9", "clientVersion": "CpuTZNXAvR5mEjDG", "deployment": "i8Z9KuTHuT6IlImb", "fallbackClaimKeys": ["AYCRvUBIHoIhUnq8", "EtmzVPJFqDDsFmDK", "PixcJtgNHrTEQpFB"], "inactiveTimeout": 40, "inviteTimeout": 1, "joinability": "jpUequcPWZP6mJ5k", "matchPool": "9QPUVO9elCnXCnhX", "maxPlayers": 90, "minPlayers": 16, "preferredClaimKeys": ["M0zKUQCLksfhWE1O", "iCOozFmZ3hzpayQ1", "ySXmHgROq1X5e82z"], "requestedRegions": ["DrJtNcl4ztsaFwry", "lG42gHaf4XEHX7QB", "UYvSupGJqpwAp0WM"], "teams": [{"UserIDs": ["u7ZUAbKsKi0fuipd", "vULHrqNhX3eWB4hf", "A53Ibtklb9jB4Gcb"], "parties": [{"partyID": "0L2EPZQmxEO4oKOc", "userIDs": ["sZUbeZJJJydenJ93", "Kb1pQleHG1UoswJz", "p9GPpGykMepZ0J4U"]}, {"partyID": "uZWR407SE9ddXzA6", "userIDs": ["F73IwV8d2jvk2NFE", "PFcj0B4pnGV0EaGD", "NAoaYeee5iUyPElT"]}, {"partyID": "7mmAuOT58yIe9Azm", "userIDs": ["sPC0C5hWQuueyPPc", "bPVe3xxdxVhu4rkZ", "Zo8fTr6agunz2XzH"]}]}, {"UserIDs": ["sONpORaUZ573WSpm", "tV8p2sf0f3uCNxJI", "MiWHlRKeE5RKhreF"], "parties": [{"partyID": "D6wFvnLOEQR2tp6q", "userIDs": ["9pPGaWcS02LciOGb", "TW0UOPodtVEAHUTP", "JcWSRPDFdkQZDrW0"]}, {"partyID": "M7eIDrifb9ovouuo", "userIDs": ["yV36gCehJP43Xpu5", "gyQ14gMP9Z4mEvMN", "jtERuv6NrO6SjBOH"]}, {"partyID": "0izSSpVoq4E6Ctyc", "userIDs": ["fHMbZoBgzDSnBtqT", "oPbBDwdvFVFTK8mQ", "qqA2VoUKBlsPXL4i"]}]}, {"UserIDs": ["bYVB9w0ETfSauutS", "9JWgSB39nWJ0AdEr", "hRmHmtCl6M85ELRv"], "parties": [{"partyID": "5NEe9bR9ckNLMJjs", "userIDs": ["gaXBRR415WJviuc5", "vA36xYMMPep0zplF", "iRg22RpUVtQXjIty"]}, {"partyID": "gvyTYykvnB2kvfxE", "userIDs": ["0sqbjAHF9QLlS2lC", "0QB41qRS25yYg5fk", "ChtyUjcBHShoy4rA"]}, {"partyID": "mtQkeCoVHY89b92P", "userIDs": ["WEF9gisonsVtIIBD", "DZzSa012J2Vd3MaS", "mOIA08Q4Pe45ZkF7"]}]}], "ticketIDs": ["UCeoZEUNVKjMQUM3", "0waRuDKnw63w8ZD7", "GzTZ0WS0ZfkVqKow"], "tieTeamsSessionLifetime": false, "type": "ZkxwcIoptsiG0JEo", "version": 42}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '0u4dtDARQghCkujm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'PatchUpdateGameSession' test.out

#- 48 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "LLnrNNSLh36UQbPS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'JQQhceSla9ERYYip' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'UpdateGameSessionBackfillTicketID' test.out

#- 49 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId '5g4u0MAPcVPH3gZ7' \
    > test.out 2>&1
eval_tap $? 49 'GameSessionGenerateCode' test.out

#- 50 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'BL95xBXZ4Q2kZcVE' \
    > test.out 2>&1
eval_tap $? 50 'PublicRevokeGameSessionCode' test.out

#- 51 PublicGameSessionInvite
# body param: body
echo '{"platformID": "tlghVPGnqtFjbFAz", "userID": "llHBMrW7hG67ye23"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'P8DW1ccz649aMbZ9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'PublicGameSessionInvite' test.out

#- 52 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'u0Okl1IHd8Q5JqhD' \
    > test.out 2>&1
eval_tap $? 52 'JoinGameSession' test.out

#- 53 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "P8ljUtdmP5zdR2Wz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'Z26M7190BUUMJA2i' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'PublicPromoteGameSessionLeader' test.out

#- 54 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '5Q4vFfXwKGlPrvLQ' \
    > test.out 2>&1
eval_tap $? 54 'LeaveGameSession' test.out

#- 55 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'jEMxmStiAYcnCKHJ' \
    > test.out 2>&1
eval_tap $? 55 'PublicGameSessionReject' test.out

#- 56 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'a29YjFCGXPzxvGWX' \
    > test.out 2>&1
eval_tap $? 56 'GetSessionServerSecret' test.out

#- 57 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "SYKxZFwAJdGF5bhj", "userIDs": ["I1EEc3WV5k6IPw3l", "uGBMK9OmEmytZjYE", "iOxHZltYdZOiBafL"]}, {"partyID": "m9cc3OUVUdC6vEQ0", "userIDs": ["Fb0fOzSwVrTe2Pix", "8IgOyJOxbfiuUDdz", "fJOveiGttirPw49e"]}, {"partyID": "DkkTlieINXiZneSG", "userIDs": ["u4x8wWgDhy2xaMbK", "98KZuPAGpzW8YEov", "lYXMD76ZVrjTwBhG"]}], "proposedTeams": [{"UserIDs": ["6PxRbXyacvJKvH2f", "I227sFhXEPpERr10", "WrTTWC1vHxSVm1rR"], "parties": [{"partyID": "LDUorN8n8OKt3ebT", "userIDs": ["MfmV8RpXci3oXtKe", "XlMfYcKvIDQryhqR", "PwaSbAakeTI3GtLp"]}, {"partyID": "33o0hY1hJyjnnZKd", "userIDs": ["SiFaVEfxNwD82Tyg", "HqJCY44tteOU73MU", "ia86OHeEezPfPVoL"]}, {"partyID": "zuailZgh0VftM4du", "userIDs": ["hPOP3T7IILgTKDtE", "Bnyydnlmrax9HkcV", "JkcKNqoctZZip2UO"]}]}, {"UserIDs": ["wEpVOojiniOJfBmQ", "BpvpDw5KbvwvhRu0", "0Z9kQ6CfVEKuBGQj"], "parties": [{"partyID": "6IM6yC2yo6eKkz3S", "userIDs": ["o92LmNHqeozPTvTy", "jHzkSDJwI3p6udT5", "ywNYrZ3noFX2D35k"]}, {"partyID": "jfYLmyJHWVmJhvzY", "userIDs": ["UD7tt15VYMNdywyS", "dXRVEBpthoAfzvXP", "7hfNyBM3W7FEjbI4"]}, {"partyID": "6oLZUugcyZei70cP", "userIDs": ["KSdQKPk36TgDFyRp", "EbkRLet6qHFzUAAI", "A1yZDTGyGcJrX2a9"]}]}, {"UserIDs": ["8isrEnWec7CnvrRT", "jVFQkVvDYodu7iPq", "7Dzyrwyqgey4TDsT"], "parties": [{"partyID": "GVcn6u2Y8kRSlfFV", "userIDs": ["NtTCFUDbhXFUMPgI", "sF2FaJmavnpwvlN5", "bxb3zVGiVgmTiYRq"]}, {"partyID": "ChqmGwszlQrWl9mq", "userIDs": ["TkN4IEuQISWdQ728", "o1qclvhlm929zMAd", "lyXyqtmIwkhB1niu"]}, {"partyID": "OHHkEMM2LdYulOoo", "userIDs": ["uVLyY5l3zat0SbuB", "1wMD51VeGbfpAAYy", "BbEy0fEmRKPynE1U"]}]}], "version": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'KS5yUS265k6o7P49' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AppendTeamGameSession' test.out

#- 58 PublicPartyJoinCode
# body param: body
echo '{"code": "D2nLcCMvTgskvERP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicPartyJoinCode' test.out

#- 59 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'zKX3k2xmrmuw7Xo6' \
    > test.out 2>&1
eval_tap $? 59 'PublicGetParty' test.out

#- 60 PublicUpdateParty
# body param: body
echo '{"attributes": {"c48Bsc3cv7u2wN8c": {}, "1Kpu4lqYfwmcvvAU": {}, "S6PzOOwSik7CwUa7": {}}, "inactiveTimeout": 78, "inviteTimeout": 49, "joinability": "Xw1Ba3BCLDK9EHH0", "maxPlayers": 33, "minPlayers": 32, "type": "QefK1Zmj8WfGj2nD", "version": 69}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Y3mMswJSdKiaNMrg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicUpdateParty' test.out

#- 61 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"J4VqWXNo76z7J1NW": {}, "0IoTP97wPaRfkXyL": {}, "S86H3ub7hu9Mf6Qe": {}}, "inactiveTimeout": 50, "inviteTimeout": 42, "joinability": "VT5BKwgRAIQHZN92", "maxPlayers": 98, "minPlayers": 7, "type": "P4rbnVQ2wDVZFHDm", "version": 22}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'vYkRH723c57BNNjQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicPatchUpdateParty' test.out

#- 62 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'J7TXsOwwby9OOnup' \
    > test.out 2>&1
eval_tap $? 62 'PublicGeneratePartyCode' test.out

#- 63 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'hq96OvBp28vxdZ0s' \
    > test.out 2>&1
eval_tap $? 63 'PublicRevokePartyCode' test.out

#- 64 PublicPartyInvite
# body param: body
echo '{"platformID": "US14l56FKfjkcB2S", "userID": "iFscU2TIptCl7Mr5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'hH9GexcdbT8v3UhV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'PublicPartyInvite' test.out

#- 65 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "tgg8kRaAVvE6mqqe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'oTT0uNoVVn7ItFFS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PublicPromotePartyLeader' test.out

#- 66 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'EoUy7DgmV5mD3u0J' \
    > test.out 2>&1
eval_tap $? 66 'PublicPartyJoin' test.out

#- 67 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'WhmI5cbJHxH87DGH' \
    > test.out 2>&1
eval_tap $? 67 'PublicPartyLeave' test.out

#- 68 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'Tswv6V7PYLXBxOdM' \
    > test.out 2>&1
eval_tap $? 68 'PublicPartyReject' test.out

#- 69 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId '9zl6FELMoLSWz6oS' \
    --userId 'QsOH1Xbs430fGmUX' \
    > test.out 2>&1
eval_tap $? 69 'PublicPartyKick' test.out

#- 70 PublicCreateParty
# body param: body
echo '{"attributes": {"ScgZStYmu7rsmI2i": {}, "z8iDqES2enp5QsuU": {}, "2SzC5jPZ753VQLK9": {}}, "configurationName": "K4e0w5qc4U4ZoFCF", "inactiveTimeout": 30, "inviteTimeout": 48, "joinability": "WEdyIcgWEloqldQT", "maxPlayers": 2, "members": [{"ID": "f1RjwLWiMZtnXi3e", "PlatformID": "Lkvnj2FHRRu0umws", "PlatformUserID": "xpdZ1WWgZKluL2Ac"}, {"ID": "sKLs4xA7pgTnAOS7", "PlatformID": "ZVDYbaZdRyWBXrjE", "PlatformUserID": "fLoBc63d2CjPSt7u"}, {"ID": "9HWKXy95GCrxrJkG", "PlatformID": "Mw7ZL0l1KamHkjtv", "PlatformUserID": "5cJwGEcC7aGI9Sta"}], "minPlayers": 1, "textChat": true, "type": "4kc8IEXb91iFIok1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicCreateParty' test.out

#- 71 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '21' \
    > test.out 2>&1
eval_tap $? 71 'PublicGetRecentPlayer' test.out

#- 72 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    > test.out 2>&1
eval_tap $? 72 'PublicGetRecentTeamPlayer' test.out

#- 73 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"MM49oWBLBOtyL1dH": {}, "NmowMhMKGNED5ygP": {}, "VLMM3usQQXneBGj9": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'AjnpSvpMEa0Lvq2w' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'PublicUpdateInsertSessionStorageLeader' test.out

#- 74 PublicUpdateInsertSessionStorage
# body param: body
echo '{"nqyklrvhee7EeSqy": {}, "9kO3ZjWNov1zjWKM": {}, "DhaV2fsQ3DlrWTmY": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'Vuz6shya81WnWLIE' \
    --userId 'MQX6yIuvLV2SAA8K' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'PublicUpdateInsertSessionStorage' test.out

#- 75 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["oDH2te6X3S3HwJUM", "VxEYAqoGebWDx1rI", "Y7YgqLazmwaTdH4C"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 76 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 76 'PublicGetPlayerAttributes' test.out

#- 77 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "eNzo6AVZOaKsluos", "data": {"iGaKd0wHfEbWYu5t": {}, "q42y9tPQEz6JWsYi": {}, "QT5QSZtlA4KQeFg6": {}}, "platforms": [{"name": "EMZQcwbAhRNgXXGY", "userID": "KIuGGriMXJaukjQp"}, {"name": "rS6CmcUjDbwPW4iY", "userID": "qSZFO9EQt4SdrkfJ"}, {"name": "D71OE4nmvUcjS4yL", "userID": "7G8PAD8A91XiYV8o"}], "roles": ["m2lFtO185fesSBan", "CCZXDbHiemt24RYV", "xvOizOsLuBOtvU0d"], "simultaneousPlatform": "ysGQ752SjQQxTA0y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'PublicStorePlayerAttributes' test.out

#- 78 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 78 'PublicDeletePlayerAttributes' test.out

#- 79 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order '5W0iCFQFClD4Stfb' \
    --orderBy 'Pz4B3LcomgS0Mvgf' \
    --status 'AJ19LgFCiF7r23sn' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryMyGameSessions' test.out

#- 80 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'bG2mmF7HlYrBpxsz' \
    --orderBy 'oG732S8YEcJvLPLm' \
    --status 'CDp2m56H6rESnZAb' \
    > test.out 2>&1
eval_tap $? 80 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE