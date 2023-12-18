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
echo "1..76"

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
    --upload $TEMP_FILE_UPLOAD \
    --password 'DjmYUMhD9qU89D35' \
    > test.out 2>&1
eval_tap $? 13 'HandleUploadXboxPFXCertificate' test.out

#- 14 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 31, "PSNSupportedPlatforms": ["YfnXTsQUrA0WWyKl", "2K5mCSoGeQCahcox", "63cyDxAAYcRXJdoS"], "SessionTitle": "TxNCK9AIjNmbfoW8", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "Dq5jPqzhN0YdGSrA", "XboxServiceConfigID": "9LXRwU6WLgpQE9nX", "XboxSessionTemplateName": "zhBC0uyMR4Xf2nfY", "XboxTitleID": "vNvG8uQ14AhsxaAL", "localizedSessionName": {"iBwpNJornrCQpMJj": {}, "5igqat8xnPoWTdHA": {}, "kcyAy4drHlPcXGGl": {}}}, "PSNBaseUrl": "0Xw3veBfrpCrnbax", "attributes": {"hEvn3SGqcH91fC3a": {}, "JEoqWaFAGD6PRg95": {}, "m07l03vtlMFzeiMR": {}}, "autoJoin": false, "clientVersion": "nJmi4XaBTgoXjfdU", "deployment": "QHa3RxspSqwdbTR2", "disableCodeGeneration": true, "dsManualSetReady": false, "dsSource": "gzfaQrUCW9fgo69u", "enableSecret": true, "fallbackClaimKeys": ["PgCcQ0axTWnmyEYL", "ZQTpvLH6QPEBP8kS", "SFjeuL3wQQPYwmYF"], "immutableStorage": false, "inactiveTimeout": 16, "inviteTimeout": 49, "joinability": "J6fs3zL9H4WxGWRH", "leaderElectionGracePeriod": 11, "maxActiveSessions": 10, "maxPlayers": 51, "minPlayers": 46, "name": "4BdPhLtHRJOImSq3", "persistent": false, "preferredClaimKeys": ["swnkSyuJTVjKQ1OR", "LEIAePvDO2xkVgyR", "k10b27RdU8VceYQ9"], "requestedRegions": ["erPYQ5yVcQuvDbGM", "qbEHkCQwMBcQUNPH", "N8YZT0yJJ0uCjjaN"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "V3hSIiTEoTCSxjAq"}' > $TEMP_JSON_INPUT
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
    --limit '14' \
    --name 'oIo3L24DKGwgZ85v' \
    --offset '51' \
    --order 'G6OrPH6ZsjpPgHKI' \
    --orderBy 'SHtB8tWdJM9Qc5Hm' \
    > test.out 2>&1
eval_tap $? 15 'AdminGetAllConfigurationTemplatesV1' test.out

#- 16 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'R0vknXO45AUtNXST' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetConfigurationTemplateV1' test.out

#- 17 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 72, "PSNSupportedPlatforms": ["QIXVmrtRlq1jv60H", "TnmFrl3gYx6Xmv1D", "zPHux3k3skhn3mWZ"], "SessionTitle": "jTYM95e4aa8xOJu7", "ShouldSync": true, "XboxAllowCrossPlatform": true, "XboxSandboxID": "NRVdygfKmUkzj9mH", "XboxServiceConfigID": "Fpff2vDkz68zorEg", "XboxSessionTemplateName": "cExv9nKMOgO5W8SU", "XboxTitleID": "aZjCpNtJSMm8kDi3", "localizedSessionName": {"Rwubq7wtRGdT447O": {}, "a51m6VLfjsw270pM": {}, "mOQJrpEBbVvBn8Ls": {}}}, "PSNBaseUrl": "f2qSAtizV9hzsVbp", "attributes": {"JLtEZjuyFhvbxX2D": {}, "NbknfVv4nm70TCay": {}, "YAkF18YBwRxcREyU": {}}, "autoJoin": true, "clientVersion": "hb2tLrsMeoZiRYkb", "deployment": "hEM1zTNY3lpincuf", "disableCodeGeneration": false, "dsManualSetReady": false, "dsSource": "uiJVcktlx9zJZVVC", "enableSecret": false, "fallbackClaimKeys": ["tKHTmzo0JmcQmnsU", "igVynjGFyVicGQAV", "v32ftRAsmC0RuRA8"], "immutableStorage": false, "inactiveTimeout": 20, "inviteTimeout": 37, "joinability": "AJ3hNWWhADRqJvaZ", "leaderElectionGracePeriod": 36, "maxActiveSessions": 15, "maxPlayers": 11, "minPlayers": 83, "name": "2qXQFCzRV1paELj5", "persistent": false, "preferredClaimKeys": ["TLJQsZcTEzXaXUzp", "sAV6ct6XITL0QEka", "dMSQluAoED9oYwS8"], "requestedRegions": ["oLyErKvRtHFGJRoG", "W7VBG1VB2sp2x9ms", "zGGoyhGZAzt2OVBT"], "textChat": false, "tieTeamsSessionLifetime": true, "type": "Sp0WbvxQWI0QGCOx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name '7eICkauWbFrSnU7d' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateConfigurationTemplateV1' test.out

#- 18 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name '1BuhdwliTSDdmGVf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteConfigurationTemplateV1' test.out

#- 19 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'egiD3mrVQaUr3oT8' \
    --namespace $AB_NAMESPACE \
    --userId '8Dfc7114QFGwTzBV' \
    > test.out 2>&1
eval_tap $? 19 'AdminGetMemberActiveSession' test.out

#- 20 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "Dg5v71kGCEt7h1mV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'wIQCJmQkvWbQrn2W' \
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
    --configurationName '0VkOF0pQOY0UCcVi' \
    --dsPodName 'iFKNjkT5hcONCaOy' \
    --fromTime 'ATBFgqLeAzvdcUEh' \
    --gameMode 'WRo6ROvbuPQwl9dV' \
    --isPersistent 'fJQGkDR00ofXsbnE' \
    --isSoftDeleted 'zHiRs0NmGhxv1vuN' \
    --joinability '7Xv6OuG6RR1jPh8R' \
    --limit '3' \
    --matchPool '6EAl7d3Ks65thtnj' \
    --memberID 'cMSw1J42fthKUoba' \
    --offset '37' \
    --order 'tLHO1qrNyhmUEADc' \
    --orderBy 'zzrL31HuYKsCBBgw' \
    --sessionID 'b1hGjHJgxrcEvnfJ' \
    --status 'qU4hCv5egSQDePKS' \
    --statusV2 'ZKp6zwDQS1atvJrA' \
    --toTime 'LaiplJgRhedl5Ewh' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryGameSessions' test.out

#- 24 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"3jDayYStUiBB1yz3": {}, "iP8gH88UenlMVzIO": {}, "P8NOf91LsD7cWWOg": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminQueryGameSessionsByAttributes' test.out

#- 25 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["As8ThMpAGIapYftY", "ZkBXiEhdiS41VBAE", "UvoBlbH02bobxtlj"]}' > $TEMP_JSON_INPUT
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
    --sessionId 'fHBgjP9onbxFcxS2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminSetDSReady' test.out

#- 27 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'OZZfXO3HkJTOPscP' \
    --namespace $AB_NAMESPACE \
    --sessionId 'A2n25C1zEnAMGmFy' \
    --statusType '7w6eqnMeKFo7U8Sc' \
    > test.out 2>&1
eval_tap $? 27 'AdminUpdateGameSessionMember' test.out

#- 28 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'r9xm68w7s9RMx2hc' \
    --key '45QX234xnqlbRAPF' \
    --leaderID 'Qsca6n9vGZTCCXQ2' \
    --limit '77' \
    --memberID 'ZyBpqhCJBtFOm3iC' \
    --memberStatus 'pu0lhhgutt3rQuKP' \
    --offset '37' \
    --order 'OEtKFBjNihHU8GP8' \
    --orderBy 'TRVypSvYXKz4BGjb' \
    --partyID 'srRBV8aztJ86yQK1' \
    --value 'AsC18UO6JcXmwQfk' \
    > test.out 2>&1
eval_tap $? 28 'AdminQueryParties' test.out

#- 29 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'AdminGetPlatformCredentials' test.out

#- 30 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "seTpH6l2Dv8SvqYK", "clientSecret": "c56PcPSL2xmjViKk", "scope": "Kw4gHA4CaLsPqRsT"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminUpdatePlatformCredentials' test.out

#- 31 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'AdminDeletePlatformCredentials' test.out

#- 32 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'dKzcKtkGcvn44NWs' \
    > test.out 2>&1
eval_tap $? 32 'AdminReadSessionStorage' test.out

#- 33 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'e6VLPkM1VTrQBywh' \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteUserSessionStorage' test.out

#- 34 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'J7lbBLw9xy1WQM5q' \
    --userId 'US8baUqkzSr41y6R' \
    > test.out 2>&1
eval_tap $? 34 'AdminReadUserSessionStorage' test.out

#- 35 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'PBHJuPjj8zDwOk0I' \
    > test.out 2>&1
eval_tap $? 35 'AdminQueryPlayerAttributes' test.out

#- 36 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'gmYfUTpFzyQhPVhR' \
    > test.out 2>&1
eval_tap $? 36 'AdminGetPlayerAttributes' test.out

#- 37 CreateGameSession
# body param: body
echo '{"attributes": {"GX9xlUKhXI8mL8OI": {}, "hvP68xE68dzohxhb": {}, "ej2caIIfkXDY7jnh": {}}, "autoJoin": true, "backfillTicketID": "6U8GGp0E886E90E4", "clientVersion": "ZboiXT1Uy0gArtDp", "configurationName": "QE4bOtoiAjHXcVVO", "deployment": "sVywU6uisejapftq", "dsSource": "oxujXDosOo2kSUfI", "fallbackClaimKeys": ["A1guTNx7haejXSV2", "oH2uH8S4Zx0ACteu", "eMOmYP4SgxAIQTTK"], "inactiveTimeout": 38, "inviteTimeout": 58, "joinability": "dmtHu1dG0us7kIWL", "matchPool": "cgKgU9406tdRDqr3", "maxPlayers": 5, "minPlayers": 34, "preferredClaimKeys": ["pVbaH69NyTfGE599", "42bCwgpzUfcmTQjR", "mV0CPt1LUaTvrFax"], "requestedRegions": ["zOfG3pTddIA0Rt6w", "M5oQvTMICtWyUtVD", "nhgTGXO8Utpwxug8"], "serverName": "MpqczRvUdK1uOV1Z", "teams": [{"UserIDs": ["JTYuHpnpVX5u4gw4", "XBXDD7BG73sDdDoX", "nB8F5X05KUgGKfDS"], "parties": [{"partyID": "Gh3vQFPSYCi8WEjR", "userIDs": ["3wqpnMdSNskxhl3O", "3kGloooh7kL598P7", "F3IKhiNdx1V7199N"]}, {"partyID": "T7JTRFV3FxMl5Rw4", "userIDs": ["YeHqWkG09iEAFYWh", "ow1WAwCs9Y0KOemh", "NPYUVA9mU8UvONyj"]}, {"partyID": "v3GQuLHoQ6ehLLK5", "userIDs": ["h1bE9WU6w3tjUhSC", "KySPY7yMGOuQOfx6", "HIFfwBBqG51RaZY7"]}]}, {"UserIDs": ["4CqdvfPAIaPEkCIX", "X7WQ3ytABCzYWxYb", "bphuiQPU0aS2OIp0"], "parties": [{"partyID": "B2FWiDu7POaotJoQ", "userIDs": ["QyL1bCDNisOhjEKF", "Wmj7ioi5WZ6ZymQe", "VSZZma57V6b9uLlo"]}, {"partyID": "AA9KoetyNPkgWcTC", "userIDs": ["N7aBIFfeRdnHpse2", "T7eZwkVrB3GSEmVq", "8CjR5rCx0ZiHwUqL"]}, {"partyID": "5rITYFhcdeNwLmZe", "userIDs": ["nRqEBM0VGzhVVGdi", "pdi33u9U14rGwvME", "xAllZtPzNRiR35CZ"]}]}, {"UserIDs": ["hclugjyDzCPI8tsl", "D0HuRrAMzMB9XHHk", "fZgB6Vt5qWaae3Sb"], "parties": [{"partyID": "oVKgjsryC98whmI5", "userIDs": ["koBT6iCuVa643kk8", "gvvnsu0ABei0go2w", "smPfpsbkzAIsJ06Q"]}, {"partyID": "lFCAa55r89MdFidv", "userIDs": ["2kFVXgnjrAfzEn26", "mHgxUgVDgnlU5H2U", "La1LYlsqYrUpXncY"]}, {"partyID": "v2BVIS1BtMqvdE5Q", "userIDs": ["QizMBWYPYerJ1FmK", "BX6U18gMIl7TSPm9", "6MsoQcFDfKSJymqZ"]}]}], "textChat": true, "ticketIDs": ["YO14lFR2YtIb1fuf", "xJiodJFjEbn1ASMA", "iedHoYv6WmW9mRXQ"], "tieTeamsSessionLifetime": true, "type": "DHkXx8NqXaR2w60X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'CreateGameSession' test.out

#- 38 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"5Vb0TV0x3nmq9UCZ": {}, "bdVFY3WdZ6luOW97": {}, "7EgotvOrnRjb5UT6": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicQueryGameSessionsByAttributes' test.out

#- 39 PublicSessionJoinCode
# body param: body
echo '{"code": "Vf5jxoBBg2lM3DQX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicSessionJoinCode' test.out

#- 40 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'yC3oKu14sRjkCeuR' \
    > test.out 2>&1
eval_tap $? 40 'GetGameSessionByPodName' test.out

#- 41 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Y0tsnbKAGRTCvAZK' \
    > test.out 2>&1
eval_tap $? 41 'GetGameSession' test.out

#- 42 UpdateGameSession
# body param: body
echo '{"attributes": {"iSB7bYvWmbUbWlRZ": {}, "tcIUry87yJBlfjPI": {}, "5tfjbyZkYSRLBMgc": {}}, "backfillTicketID": "D5OJgp6wHynVKwWg", "clientVersion": "dAibFBESdI0Ab1zg", "deployment": "jMC3hp1s4tElQhEA", "fallbackClaimKeys": ["9ThpSbyAYJeBCrKD", "cRkI5LI6UqivHoIA", "rvDT62TaGFSxd4y8"], "inactiveTimeout": 97, "inviteTimeout": 65, "joinability": "80fjN9CwM4qNT3aw", "matchPool": "IjWoFCW5BTW9laFj", "maxPlayers": 38, "minPlayers": 100, "preferredClaimKeys": ["d7gSFkIVGnXJLeUd", "D8XNxAkoeHk0BXou", "yKC6RnO4PckO3syH"], "requestedRegions": ["JOMlgAqtsnZlLvEc", "zKKAyiQv93N1fbGo", "vPLBpXX8vScPhhho"], "teams": [{"UserIDs": ["eTbxungca58m1uNc", "xsQxrsxbLSv7uFZX", "dW5GyQ2mveLZEnmS"], "parties": [{"partyID": "CeWTCXfARUx3U3Kr", "userIDs": ["fqoZi5xiHiQI9ieQ", "8y75Biw4pKJ8hey5", "JmuUDlojEc712JEh"]}, {"partyID": "S1VFA1Eo4Rxcnq5D", "userIDs": ["tzSaifByaju2TY0Q", "dHndDWB60eGxKadA", "f6UL9MkkVf8dHJYJ"]}, {"partyID": "F19NcUSJgQSBwkX1", "userIDs": ["FU71K0CzXzdQIWh5", "PSp024SIhnu3h3uK", "1jRHhQ2uS27tXHvt"]}]}, {"UserIDs": ["xi6EbWHrMrbpZd2b", "t6P3sZXAZkdh450P", "2HCQEysNYmCndtXX"], "parties": [{"partyID": "QgiHJgjwpCxGEBsc", "userIDs": ["3HVarhLlwlmf1l5J", "hrQSpGlguvTECefh", "iKKuc8Urg4atANoO"]}, {"partyID": "fyCbfBoH6zLgTsYm", "userIDs": ["Aw4mFyLcIq00Vl8s", "xzC1fJxroZeNIlbx", "AUeRUjUbaPklfVic"]}, {"partyID": "7zYJTjpmhWVBgTDm", "userIDs": ["8IGJL3sEpnq2qNgE", "jKMemoxx1k2s5gW8", "zADPqu8PVXnN0xl4"]}]}, {"UserIDs": ["8RoZbNL7cXCVaF9U", "1H9bQv7EybPwbHEH", "xSPaGCQl5y1gekeq"], "parties": [{"partyID": "HnzZfY22Z1SmIc5N", "userIDs": ["TRyLbOzAYD5IH4de", "TFCDORAsuT0lseQt", "OoohdBYhvvwspKpE"]}, {"partyID": "PUUxc2NKFB2qxCiW", "userIDs": ["MNdvN9SDRKye6n1t", "8RXF5qayS4UAMJrR", "rnNfXdTnJz7e3tD8"]}, {"partyID": "KVlMU17V03QDQjU6", "userIDs": ["4lc3oek3RWXWJhPX", "vS9OmmtZ14XROPpb", "gqS9a9eP72cbSH4T"]}]}], "ticketIDs": ["vY6sMCkitXsNfi8E", "F3mgABwFe1N0QNer", "yssScV8w2rN40y7a"], "tieTeamsSessionLifetime": false, "type": "OJoeZqRwJzTdMg00", "version": 76}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'e7QxHteM0QsfB4cK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateGameSession' test.out

#- 43 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'cpv0nqsAzwhiinZM' \
    > test.out 2>&1
eval_tap $? 43 'DeleteGameSession' test.out

#- 44 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"K2PQePnMgPL2upEu": {}, "zGkAuUgSs7KjVR3K": {}, "ElIaqQcqk3EvPPbo": {}}, "backfillTicketID": "GcBp08H0whjTC8Q2", "clientVersion": "54CIig93OcDTSDDb", "deployment": "tG4kbF7EcYPAe3TK", "fallbackClaimKeys": ["jWJizZ73YhEdqt8L", "YH7I8lYD68ZI9yJ2", "FmHnprty5BQCd5sV"], "inactiveTimeout": 77, "inviteTimeout": 36, "joinability": "NXAvR5mEjDGi8Z9K", "matchPool": "uTHuT6IlImbAYCRv", "maxPlayers": 96, "minPlayers": 57, "preferredClaimKeys": ["HHjrwqKsa8ZqhezP", "IlBtGhWc8fY9HfUs", "EaPxVM4cVRtjpUeq"], "requestedRegions": ["ucPWZP6mJ5k9QPUV", "O9elCnXCnhXRiCBS", "6wONO7EzD1HwKEgG"], "teams": [{"UserIDs": ["h6MctPOqg2vfaFiX", "bkyxYVJYoECX5Zk7", "zrqRFfKg2QLfgPky"], "parties": [{"partyID": "92H0SjmRKLX0YyNL", "userIDs": ["gOIbDguxdqP6c448", "AniKDjnb5cFYyJtz", "DcKD3CR18eggGJVX"]}, {"partyID": "ROWQLNP4J0I2wDju", "userIDs": ["MHSknrvHsarToh01", "sSaePBAWrnMRr0i4", "i3znplxZVkkzCuWX"]}, {"partyID": "N0pi9oHwFFSWlYJS", "userIDs": ["aX14Onxc82WUAqFN", "lxPL5ZjWvAiWvl12", "EyddbFelmB60OEQr"]}]}, {"UserIDs": ["MIsKCf8GsPEl1i9R", "Q9tNv9ZoFgoU8geQ", "qTHsgesxUdeb2FJb"], "parties": [{"partyID": "sqzkOO5TgVxhorx7", "userIDs": ["Olr6yZsG5AHeXjxQ", "Cmc8jD3q7UouREPL", "DNt6Bi4udSrXnIIt"]}, {"partyID": "duiUuy8tq9HCTgLS", "userIDs": ["uFiv2W3x38AyIWIi", "WAkZb55PmNf9MzOC", "P7HO3NR5EmbWMmuH"]}, {"partyID": "bWUeXEPRF6TjBh6i", "userIDs": ["QOGSqSf29O4OCHr6", "PHDU3g8gwrRCGr34", "cRXz9JsazgdXDoGs"]}]}, {"UserIDs": ["hLr8yn7AoXGMgLGD", "EgjGR3AjETQmuBhx", "dl2hmyNHx2EwggD6"], "parties": [{"partyID": "ThfKbveaNPadM954", "userIDs": ["Klf9ScyQ3BkdgTB8", "XsRpozxyzQjkAwoi", "KpqCxRaxD64vrtLT"]}, {"partyID": "4cBalVmLrDPUnoL1", "userIDs": ["yIqAGPGIMNs07P35", "ZIntLvl9DQDCBJjs", "12pGhuGLD6vHktU3"]}, {"partyID": "ynqJffmZNfIZBEmg", "userIDs": ["9ppW9kqHg6qWRr5O", "GM3cUFnnf4mVneUy", "BHCEsHoUz3vp9jpS"]}]}], "ticketIDs": ["UMWJyDVldaDNtR0A", "XW63sbPYTKP8EQup", "MajWTKw5FeR8ri3y"], "tieTeamsSessionLifetime": false, "type": "rzd1ieTRurPzBSUl", "version": 77}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '8Q4Pe45ZkF7UCeoZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PatchUpdateGameSession' test.out

#- 45 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "EUNVKjMQUM30waRu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'DKnw63w8ZD7GzTZ0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'UpdateGameSessionBackfillTicketID' test.out

#- 46 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'WS0ZfkVqKowfa2xO' \
    > test.out 2>&1
eval_tap $? 46 'GameSessionGenerateCode' test.out

#- 47 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId '5BhQtMYVHJohu8Sf' \
    > test.out 2>&1
eval_tap $? 47 'PublicRevokeGameSessionCode' test.out

#- 48 PublicGameSessionInvite
# body param: body
echo '{"platformID": "s3a0odaQ1HgT2Wnp", "userID": "HkT1LxGYzolfxvDy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'x6IAAOUeURiiiEgB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicGameSessionInvite' test.out

#- 49 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'QnBdCORXu3yYfZ5p' \
    > test.out 2>&1
eval_tap $? 49 'JoinGameSession' test.out

#- 50 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "6HsVODk8yYxP6eRL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'WH719H0S96d6o92O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicPromoteGameSessionLeader' test.out

#- 51 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '9JTphnwOfFzh20ov' \
    > test.out 2>&1
eval_tap $? 51 'LeaveGameSession' test.out

#- 52 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'T23TbEK3bM30lxx1' \
    > test.out 2>&1
eval_tap $? 52 'PublicGameSessionReject' test.out

#- 53 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'rT6fsKa4IgtUwYeP' \
    > test.out 2>&1
eval_tap $? 53 'GetSessionServerSecret' test.out

#- 54 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "FCH42h6LucfBcrN8", "userIDs": ["3Rs41H9Aya2Ugl7s", "PCMcCq8KOF1FPASW", "EGLvHi2yA6ZsXJoV"]}, {"partyID": "WUuZ6fQXMhnC8iRA", "userIDs": ["Cppkc2GjnJ6Mqoke", "FNTOal7C9QhMyKSx", "oXxGxkYjDcp3pGTM"]}, {"partyID": "JShikvBpSOkSVhuA", "userIDs": ["qkZqR3gW3GfD7Jtc", "hRl8UCypNxxUbXgF", "F9TJrlNNryir2rcf"]}], "proposedTeams": [{"UserIDs": ["zqMDXs2AMIqwXxAt", "cjA062eWYCE2BZKl", "6Ks6ND0evlW05Ize"], "parties": [{"partyID": "0EKI1ogofwrtjPjS", "userIDs": ["rjvrgKMZ79d1xh7U", "R0UxrnZ5OMXgRDRM", "3gg9nVFQuxaksqHE"]}, {"partyID": "V6l9c1J0YV5SAUWF", "userIDs": ["WpU4iAd1zlFBNJu2", "WkeGDSzlCaFt7Cu0", "JKjLegxbCcIqhcBH"]}, {"partyID": "Rl1tn7RtEGUE0zrK", "userIDs": ["Nm1qW2n5ceomro5t", "LlKiW8dBlSc2bkfx", "l91A6ODfId1vJ63x"]}]}, {"UserIDs": ["KDRbcNco2qPofshH", "t88ZrOopYOMqbJVf", "yl0ssL0Nn5BZz9qx"], "parties": [{"partyID": "x7lz9uMrrT54dKxR", "userIDs": ["wFRslFsKiWo4atNd", "aNIXOzCVa9CaE9mV", "JJqgitULlhI9rKPy"]}, {"partyID": "F7ytpQiDiCAh2lkP", "userIDs": ["XOOJp91w7ACgmrez", "LCJKLPrwjeYeJi9q", "4KUgzZZ6zaaAvvKi"]}, {"partyID": "9jeErSpDVNGzTIFb", "userIDs": ["OjIMnvbwCSAfTUy9", "Iqsv2Y3W67ojKlGp", "C6ngrWr5beUGEW4t"]}]}, {"UserIDs": ["5eLuFOuGciip6lhO", "AT59629Ly5GJfaRl", "ZeRpPnJNyrwdMhlz"], "parties": [{"partyID": "3T4PPNLrCKgoc8ql", "userIDs": ["ZTdK2TxyWH1R8xee", "ueyWn4YodSIhZNsn", "N86SsqD74VrPBlaP"]}, {"partyID": "Drv6Eb7CbB1CzxJ9", "userIDs": ["zmeLvT7VIP5dOI5J", "EsCwYwxuLPzTV7F7", "0crSgCYgV6hpjYne"]}, {"partyID": "P7VkRsz0E1TgaU2K", "userIDs": ["2n1JMpCmLAckoGMr", "fqXh9Yi9sIBQbGII", "TpsIRyQL5qeScWxF"]}]}], "version": 33}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'qtmIwkhB1niuOHHk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AppendTeamGameSession' test.out

#- 55 PublicPartyJoinCode
# body param: body
echo '{"code": "EMM2LdYulOoouVLy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'PublicPartyJoinCode' test.out

#- 56 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Y5l3zat0SbuB1wMD' \
    > test.out 2>&1
eval_tap $? 56 'PublicGetParty' test.out

#- 57 PublicUpdateParty
# body param: body
echo '{"attributes": {"51VeGbfpAAYyBbEy": {}, "0fEmRKPynE1Ulth6": {}, "WUsfyOIdVfGOJIPb": {}}, "inactiveTimeout": 4, "inviteTimeout": 17, "joinability": "CMvTgskvERPzKX3k", "maxPlayers": 49, "minPlayers": 55, "type": "mrmuw7Xo6c48Bsc3", "version": 5}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'p1Fr9PhX008zkRCT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicUpdateParty' test.out

#- 58 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"Er3CbX1jCvt8SZQV": {}, "AQVTEjLxRXXw1Ba3": {}, "BCLDK9EHH019QefK": {}}, "inactiveTimeout": 80, "inviteTimeout": 25, "joinability": "VGaGlXMirtY3mMsw", "maxPlayers": 73, "minPlayers": 100, "type": "SdKiaNMrgJ4VqWXN", "version": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'asxqy2jZLzE1twca' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicPatchUpdateParty' test.out

#- 59 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'IT8fi9jXsmtxDfay' \
    > test.out 2>&1
eval_tap $? 59 'PublicGeneratePartyCode' test.out

#- 60 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'xSlb89FR48VT5BKw' \
    > test.out 2>&1
eval_tap $? 60 'PublicRevokePartyCode' test.out

#- 61 PublicPartyInvite
# body param: body
echo '{"platformID": "gRAIQHZN92VP4rbn", "userID": "VQ2wDVZFHDmlKMyo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'sJXwZbP6pG2cmQhE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicPartyInvite' test.out

#- 62 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "gLUgzcFvsZ7ws7Is"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'SADlM888Xt8E5iE5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicPromotePartyLeader' test.out

#- 63 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId '1ruSZ153e9fDb7M4' \
    > test.out 2>&1
eval_tap $? 63 'PublicPartyJoin' test.out

#- 64 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'vfe4FykMi3Y9S70x' \
    > test.out 2>&1
eval_tap $? 64 'PublicPartyLeave' test.out

#- 65 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'e8Wk0MBFmL9yc68k' \
    > test.out 2>&1
eval_tap $? 65 'PublicPartyReject' test.out

#- 66 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId '3c9GJsynFlhTJoB9' \
    --userId 'DVDzdKc96qCUqhMu' \
    > test.out 2>&1
eval_tap $? 66 'PublicPartyKick' test.out

#- 67 PublicCreateParty
# body param: body
echo '{"attributes": {"ZYAzHXsCOpjW3CTU": {}, "UFdOJRHv7are1QWJ": {}, "ddDrhoAaGO0c6aXo": {}}, "configurationName": "FM9JtzYynQYA8i8P", "inactiveTimeout": 67, "inviteTimeout": 62, "joinability": "bs430fGmUXScgZSt", "maxPlayers": 24, "members": [{"ID": "6kO0hsIwynIAbBlo", "PlatformID": "I0YJYXW2uzKWNGYB", "PlatformUserID": "QtqkaX58cIGPaIh2"}, {"ID": "fIggFFHPcxOtLAhT", "PlatformID": "n1phglYoAkb9a7zw", "PlatformUserID": "ipvdA2x113f0Bp2v"}, {"ID": "dsCew5mf0wUYRGs6", "PlatformID": "ndQOUixZzcm2OM0B", "PlatformUserID": "7COBhqguJYsAONDG"}], "minPlayers": 46, "textChat": true, "type": "dRyWBXrjEfLoBc63"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicCreateParty' test.out

#- 68 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --userId 'd2CjPSt7u9HWKXy9' \
    --limit '39' \
    > test.out 2>&1
eval_tap $? 68 'PublicGetRecentPlayer' test.out

#- 69 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"GCrxrJkGMw7ZL0l1": {}, "KamHkjtv5cJwGEcC": {}, "7aGI9Staa4kc8IEX": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'b91iFIok1kMM49oW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicUpdateInsertSessionStorageLeader' test.out

#- 70 PublicUpdateInsertSessionStorage
# body param: body
echo '{"BLBOtyL1dHNmowMh": {}, "MKGNED5ygPVLMM3u": {}, "sQQXneBGj9AjnpSv": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'pMEa0Lvq2wnqyklr' \
    --userId 'vhee7EeSqy9kO3Zj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicUpdateInsertSessionStorage' test.out

#- 71 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["WNov1zjWKMDhaV2f", "sQ3DlrWTmYVuz6sh", "ya81WnWLIEMQX6yI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 72 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 72 'PublicGetPlayerAttributes' test.out

#- 73 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "jlm69cVOR7cJag96", "data": {"pmsOSESfYYfcqCes": {}, "MQk3ZMQPndyprDAz": {}, "JHzrLAnhMLeNzo6A": {}}, "platforms": [{"name": "VZOaKsluosiGaKd0", "userID": "wHfEbWYu5tq42y9t"}, {"name": "PQEz6JWsYiQT5QSZ", "userID": "tlA4KQeFg6EMZQcw"}, {"name": "bAhRNgXXGYKIuGGr", "userID": "iMXJaukjQprS6Cmc"}], "roles": ["UjDbwPW4iYqSZFO9", "EQt4SdrkfJD71OE4", "nmvUcjS4yL7G8PAD"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'PublicStorePlayerAttributes' test.out

#- 74 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 74 'PublicDeletePlayerAttributes' test.out

#- 75 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order '8A91XiYV8om2lFtO' \
    --orderBy '185fesSBanCCZXDb' \
    --status 'Hiemt24RYVxvOizO' \
    > test.out 2>&1
eval_tap $? 75 'PublicQueryMyGameSessions' test.out

#- 76 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'sLuBOtvU0dysGQ75' \
    --orderBy '2SjQQxTA0y5W0iCF' \
    --status 'QFClD4StfbPz4B3L' \
    > test.out 2>&1
eval_tap $? 76 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE