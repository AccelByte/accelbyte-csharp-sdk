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
echo "1..77"

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

#- 28 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '35' \
    --offset '74' \
    --order '9xm68w7s9RMx2hc4' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetListNativeSession' test.out

#- 29 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability '5QX234xnqlbRAPFQ' \
    --key 'sca6n9vGZTCCXQ2L' \
    --leaderID 'f7jtexB613cbiJEU' \
    --limit '10' \
    --memberID 'u0lhhgutt3rQuKP1' \
    --memberStatus 'OEtKFBjNihHU8GP8' \
    --offset '93' \
    --order 'JKVNlK8PTaIXRWFT' \
    --orderBy 'yA9MDnKGXqq7Zk70' \
    --partyID '5hOhenJi6dNVF7zw' \
    --value 'jXqlcD2LzaOwIF5t' \
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
echo '{"psn": {"clientId": "EsCwoAVcZCSj80gz", "clientSecret": "FvpvIerFEyxTugoT", "scope": "d50RmJFX9v4GPfyG"}}' > $TEMP_JSON_INPUT
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

#- 33 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'uQ2UEl0U5Z9UnQmZ' \
    > test.out 2>&1
eval_tap $? 33 'AdminReadSessionStorage' test.out

#- 34 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'qX15hBb4dlNTIBDt' \
    > test.out 2>&1
eval_tap $? 34 'AdminDeleteUserSessionStorage' test.out

#- 35 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'HunwNLLfKCQKuu2M' \
    --userId 'WXpEpNjHWPcFSnM7' \
    > test.out 2>&1
eval_tap $? 35 'AdminReadUserSessionStorage' test.out

#- 36 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'GAvk19sXDish7KUV' \
    > test.out 2>&1
eval_tap $? 36 'AdminQueryPlayerAttributes' test.out

#- 37 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'hmAwmAygsnn8pM7l' \
    > test.out 2>&1
eval_tap $? 37 'AdminGetPlayerAttributes' test.out

#- 38 CreateGameSession
# body param: body
echo '{"attributes": {"6v0elLMceGGgb5FJ": {}, "HWE6s13b7dmnPijw": {}, "6U8GGp0E886E90E4": {}}, "autoJoin": false, "backfillTicketID": "hia6cqoWmnhtuzxi", "clientVersion": "r12r0VUWI0kJAczj", "configurationName": "5ApcsiEQ65llgGnT", "deployment": "HAsTCZa7xE4nwGKl", "dsSource": "bPRxfucxoRKFLxxc", "fallbackClaimKeys": ["L9SyuHbvRxR6LaKW", "gAVjZKDxiezEbuMC", "z9J4dPRGzoQLYIWP"], "inactiveTimeout": 85, "inviteTimeout": 13, "joinability": "ZvyPupimCENHEenq", "matchPool": "jRSxO9oZ0fCxLR0G", "maxPlayers": 12, "minPlayers": 19, "preferredClaimKeys": ["bCwgpzUfcmTQjRmV", "0CPt1LUaTvrFaxzO", "fG3pTddIA0Rt6wM5"], "requestedRegions": ["oQvTMICtWyUtVDnh", "gTGXO8Utpwxug8Mp", "qczRvUdK1uOV1ZJT"], "serverName": "YuHpnpVX5u4gw4XB", "teams": [{"UserIDs": ["XDD7BG73sDdDoXnB", "8F5X05KUgGKfDSGh", "3vQFPSYCi8WEjR3w"], "parties": [{"partyID": "qpnMdSNskxhl3O3k", "userIDs": ["Gloooh7kL598P7F3", "IKhiNdx1V7199NT7", "JTRFV3FxMl5Rw4Ye"]}, {"partyID": "HqWkG09iEAFYWhow", "userIDs": ["1WAwCs9Y0KOemhNP", "YUVA9mU8UvONyjv3", "GQuLHoQ6ehLLK5h1"]}, {"partyID": "bE9WU6w3tjUhSCKy", "userIDs": ["SPY7yMGOuQOfx6HI", "FfwBBqG51RaZY74C", "qdvfPAIaPEkCIXX7"]}]}, {"UserIDs": ["WQ3ytABCzYWxYbbp", "huiQPU0aS2OIp0B2", "FWiDu7POaotJoQQy"], "parties": [{"partyID": "L1bCDNisOhjEKFWm", "userIDs": ["j7ioi5WZ6ZymQeVS", "ZZma57V6b9uLloAA", "9KoetyNPkgWcTCN7"]}, {"partyID": "aBIFfeRdnHpse2T7", "userIDs": ["eZwkVrB3GSEmVq8C", "jR5rCx0ZiHwUqL5r", "ITYFhcdeNwLmZenR"]}, {"partyID": "qEBM0VGzhVVGdipd", "userIDs": ["i33u9U14rGwvMExA", "llZtPzNRiR35CZhc", "lugjyDzCPI8tslD0"]}]}, {"UserIDs": ["HuRrAMzMB9XHHkfZ", "gB6Vt5qWaae3SboV", "KgjsryC98whmI5ko"], "parties": [{"partyID": "BT6iCuVa643kk8gv", "userIDs": ["vnsu0ABei0go2wsm", "PfpsbkzAIsJ06QlF", "CAa55r89MdFidv2k"]}, {"partyID": "FVXgnjrAfzEn26mH", "userIDs": ["gxUgVDgnlU5H2ULa", "1LYlsqYrUpXncYv2", "BVIS1BtMqvdE5QQi"]}, {"partyID": "zMBWYPYerJ1FmKBX", "userIDs": ["6U18gMIl7TSPm96M", "soQcFDfKSJymqZ5t", "DVsJ63mFWW0u95r5"]}]}], "textChat": true, "ticketIDs": ["JiodJFjEbn1ASMAi", "edHoYv6WmW9mRXQw", "c5sfOZbgnCmULqlt"], "tieTeamsSessionLifetime": false, "type": "xjjrXKhZOekpygvR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'CreateGameSession' test.out

#- 39 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"DCk0koCGDPfbiGdB": {}, "Q5DNVJAgfAkD0w0H": {}, "6QM5AsRnp9a7p0g0": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicQueryGameSessionsByAttributes' test.out

#- 40 PublicSessionJoinCode
# body param: body
echo '{"code": "szNgC8yVFlwGULKe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PublicSessionJoinCode' test.out

#- 41 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'Mzn4sG6P5R2lHU9m' \
    > test.out 2>&1
eval_tap $? 41 'GetGameSessionByPodName' test.out

#- 42 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'f9rzrxuxtxg98cDF' \
    > test.out 2>&1
eval_tap $? 42 'GetGameSession' test.out

#- 43 UpdateGameSession
# body param: body
echo '{"attributes": {"1fsD5miAxHczgRu4": {}, "VYjQq4VIVFUqNPuW": {}, "223zuUv8ShbYBe9h": {}}, "backfillTicketID": "LKcN6myFUWf7IuLG", "clientVersion": "63jl9rYXaEFcUySn", "deployment": "sIREQUlwDt2XB6Dg", "fallbackClaimKeys": ["oJm4dqrLVSBWToF0", "3dQYi0OxI4DZZd2V", "80fjN9CwM4qNT3aw"], "inactiveTimeout": 72, "inviteTimeout": 21, "joinability": "jWoFCW5BTW9laFjs", "matchPool": "d7gSFkIVGnXJLeUd", "maxPlayers": 60, "minPlayers": 26, "preferredClaimKeys": ["8XNxAkoeHk0BXouy", "KC6RnO4PckO3syHJ", "OMlgAqtsnZlLvEcz"], "requestedRegions": ["KKAyiQv93N1fbGov", "PLBpXX8vScPhhhoe", "Tbxungca58m1uNcx"], "teams": [{"UserIDs": ["sQxrsxbLSv7uFZXd", "W5GyQ2mveLZEnmSC", "eWTCXfARUx3U3Krf"], "parties": [{"partyID": "qoZi5xiHiQI9ieQ8", "userIDs": ["y75Biw4pKJ8hey5J", "muUDlojEc712JEhS", "1VFA1Eo4Rxcnq5Dt"]}, {"partyID": "zSaifByaju2TY0Qd", "userIDs": ["HndDWB60eGxKadAf", "6UL9MkkVf8dHJYJF", "19NcUSJgQSBwkX1F"]}, {"partyID": "U71K0CzXzdQIWh5P", "userIDs": ["Sp024SIhnu3h3uK1", "jRHhQ2uS27tXHvtx", "i6EbWHrMrbpZd2bt"]}]}, {"UserIDs": ["6P3sZXAZkdh450P2", "HCQEysNYmCndtXXQ", "giHJgjwpCxGEBsc3"], "parties": [{"partyID": "HVarhLlwlmf1l5Jh", "userIDs": ["rQSpGlguvTECefhi", "KKuc8Urg4atANoOf", "yCbfBoH6zLgTsYmA"]}, {"partyID": "w4mFyLcIq00Vl8sx", "userIDs": ["zC1fJxroZeNIlbxA", "UeRUjUbaPklfVic7", "zYJTjpmhWVBgTDm8"]}, {"partyID": "IGJL3sEpnq2qNgEj", "userIDs": ["KMemoxx1k2s5gW8z", "ADPqu8PVXnN0xl48", "RoZbNL7cXCVaF9U1"]}]}, {"UserIDs": ["H9bQv7EybPwbHEHx", "SPaGCQl5y1gekeqH", "nzZfY22Z1SmIc5NT"], "parties": [{"partyID": "RyLbOzAYD5IH4deT", "userIDs": ["FCDORAsuT0lseQtO", "oohdBYhvvwspKpEP", "UUxc2NKFB2qxCiWM"]}, {"partyID": "NdvN9SDRKye6n1t8", "userIDs": ["RXF5qayS4UAMJrRr", "nNfXdTnJz7e3tD8K", "VlMU17V03QDQjU64"]}, {"partyID": "lc3oek3RWXWJhPXv", "userIDs": ["S9OmmtZ14XROPpbg", "qS9a9eP72cbSH4Tv", "Y6sMCkitXsNfi8EF"]}]}], "ticketIDs": ["3mgABwFe1N0QNery", "ssScV8w2rN40y7aL", "OJoeZqRwJzTdMg00"], "tieTeamsSessionLifetime": false, "type": "vHLdMiaje6w7YN9M", "version": 100}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'pv0nqsAzwhiinZMK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'UpdateGameSession' test.out

#- 44 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '2PQePnMgPL2upEuz' \
    > test.out 2>&1
eval_tap $? 44 'DeleteGameSession' test.out

#- 45 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"GkAuUgSs7KjVR3KE": {}, "lIaqQcqk3EvPPboG": {}, "cBp08H0whjTC8Q25": {}}, "backfillTicketID": "4CIig93OcDTSDDbt", "clientVersion": "G4kbF7EcYPAe3TKj", "deployment": "WJizZ73YhEdqt8LY", "fallbackClaimKeys": ["H7I8lYD68ZI9yJ2F", "mHnprty5BQCd5sVL", "r7TlnKnQhYH2PkwS"], "inactiveTimeout": 86, "inviteTimeout": 42, "joinability": "XdYk0YxFNno9WQq9", "matchPool": "ZHHjrwqKsa8Zqhez", "maxPlayers": 86, "minPlayers": 72, "preferredClaimKeys": ["IlBtGhWc8fY9HfUs", "EaPxVM4cVRtjpUeq", "ucPWZP6mJ5k9QPUV"], "requestedRegions": ["O9elCnXCnhXRiCBS", "6wONO7EzD1HwKEgG", "h6MctPOqg2vfaFiX"], "teams": [{"UserIDs": ["bkyxYVJYoECX5Zk7", "zrqRFfKg2QLfgPky", "92H0SjmRKLX0YyNL"], "parties": [{"partyID": "gOIbDguxdqP6c448", "userIDs": ["AniKDjnb5cFYyJtz", "DcKD3CR18eggGJVX", "ROWQLNP4J0I2wDju"]}, {"partyID": "MHSknrvHsarToh01", "userIDs": ["sSaePBAWrnMRr0i4", "i3znplxZVkkzCuWX", "N0pi9oHwFFSWlYJS"]}, {"partyID": "aX14Onxc82WUAqFN", "userIDs": ["lxPL5ZjWvAiWvl12", "EyddbFelmB60OEQr", "MIsKCf8GsPEl1i9R"]}]}, {"UserIDs": ["Q9tNv9ZoFgoU8geQ", "qTHsgesxUdeb2FJb", "sqzkOO5TgVxhorx7"], "parties": [{"partyID": "Olr6yZsG5AHeXjxQ", "userIDs": ["Cmc8jD3q7UouREPL", "DNt6Bi4udSrXnIIt", "duiUuy8tq9HCTgLS"]}, {"partyID": "uFiv2W3x38AyIWIi", "userIDs": ["WAkZb55PmNf9MzOC", "P7HO3NR5EmbWMmuH", "bWUeXEPRF6TjBh6i"]}, {"partyID": "QOGSqSf29O4OCHr6", "userIDs": ["PHDU3g8gwrRCGr34", "cRXz9JsazgdXDoGs", "hLr8yn7AoXGMgLGD"]}]}, {"UserIDs": ["EgjGR3AjETQmuBhx", "dl2hmyNHx2EwggD6", "ThfKbveaNPadM954"], "parties": [{"partyID": "Klf9ScyQ3BkdgTB8", "userIDs": ["XsRpozxyzQjkAwoi", "KpqCxRaxD64vrtLT", "4cBalVmLrDPUnoL1"]}, {"partyID": "yIqAGPGIMNs07P35", "userIDs": ["ZIntLvl9DQDCBJjs", "12pGhuGLD6vHktU3", "ynqJffmZNfIZBEmg"]}, {"partyID": "9ppW9kqHg6qWRr5O", "userIDs": ["GM3cUFnnf4mVneUy", "BHCEsHoUz3vp9jpS", "UMWJyDVldaDNtR0A"]}]}], "ticketIDs": ["XW63sbPYTKP8EQup", "MajWTKw5FeR8ri3y", "Xrzd1ieTRurPzBSU"], "tieTeamsSessionLifetime": false, "type": "08Q4Pe45ZkF7UCeo", "version": 98}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'EUNVKjMQUM30waRu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'PatchUpdateGameSession' test.out

#- 46 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "DKnw63w8ZD7GzTZ0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'WS0ZfkVqKowfa2xO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'UpdateGameSessionBackfillTicketID' test.out

#- 47 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId '5BhQtMYVHJohu8Sf' \
    > test.out 2>&1
eval_tap $? 47 'GameSessionGenerateCode' test.out

#- 48 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 's3a0odaQ1HgT2Wnp' \
    > test.out 2>&1
eval_tap $? 48 'PublicRevokeGameSessionCode' test.out

#- 49 PublicGameSessionInvite
# body param: body
echo '{"platformID": "HkT1LxGYzolfxvDy", "userID": "x6IAAOUeURiiiEgB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'QnBdCORXu3yYfZ5p' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PublicGameSessionInvite' test.out

#- 50 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '6HsVODk8yYxP6eRL' \
    > test.out 2>&1
eval_tap $? 50 'JoinGameSession' test.out

#- 51 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "WH719H0S96d6o92O"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId '9JTphnwOfFzh20ov' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'PublicPromoteGameSessionLeader' test.out

#- 52 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'T23TbEK3bM30lxx1' \
    > test.out 2>&1
eval_tap $? 52 'LeaveGameSession' test.out

#- 53 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'rT6fsKa4IgtUwYeP' \
    > test.out 2>&1
eval_tap $? 53 'PublicGameSessionReject' test.out

#- 54 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'FCH42h6LucfBcrN8' \
    > test.out 2>&1
eval_tap $? 54 'GetSessionServerSecret' test.out

#- 55 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "3Rs41H9Aya2Ugl7s", "userIDs": ["PCMcCq8KOF1FPASW", "EGLvHi2yA6ZsXJoV", "WUuZ6fQXMhnC8iRA"]}, {"partyID": "Cppkc2GjnJ6Mqoke", "userIDs": ["FNTOal7C9QhMyKSx", "oXxGxkYjDcp3pGTM", "JShikvBpSOkSVhuA"]}, {"partyID": "qkZqR3gW3GfD7Jtc", "userIDs": ["hRl8UCypNxxUbXgF", "F9TJrlNNryir2rcf", "zqMDXs2AMIqwXxAt"]}], "proposedTeams": [{"UserIDs": ["cjA062eWYCE2BZKl", "6Ks6ND0evlW05Ize", "0EKI1ogofwrtjPjS"], "parties": [{"partyID": "rjvrgKMZ79d1xh7U", "userIDs": ["R0UxrnZ5OMXgRDRM", "3gg9nVFQuxaksqHE", "V6l9c1J0YV5SAUWF"]}, {"partyID": "WpU4iAd1zlFBNJu2", "userIDs": ["WkeGDSzlCaFt7Cu0", "JKjLegxbCcIqhcBH", "Rl1tn7RtEGUE0zrK"]}, {"partyID": "Nm1qW2n5ceomro5t", "userIDs": ["LlKiW8dBlSc2bkfx", "l91A6ODfId1vJ63x", "KDRbcNco2qPofshH"]}]}, {"UserIDs": ["t88ZrOopYOMqbJVf", "yl0ssL0Nn5BZz9qx", "x7lz9uMrrT54dKxR"], "parties": [{"partyID": "wFRslFsKiWo4atNd", "userIDs": ["aNIXOzCVa9CaE9mV", "JJqgitULlhI9rKPy", "F7ytpQiDiCAh2lkP"]}, {"partyID": "XOOJp91w7ACgmrez", "userIDs": ["LCJKLPrwjeYeJi9q", "4KUgzZZ6zaaAvvKi", "9jeErSpDVNGzTIFb"]}, {"partyID": "OjIMnvbwCSAfTUy9", "userIDs": ["Iqsv2Y3W67ojKlGp", "C6ngrWr5beUGEW4t", "5eLuFOuGciip6lhO"]}]}, {"UserIDs": ["AT59629Ly5GJfaRl", "ZeRpPnJNyrwdMhlz", "3T4PPNLrCKgoc8ql"], "parties": [{"partyID": "ZTdK2TxyWH1R8xee", "userIDs": ["ueyWn4YodSIhZNsn", "N86SsqD74VrPBlaP", "Drv6Eb7CbB1CzxJ9"]}, {"partyID": "zmeLvT7VIP5dOI5J", "userIDs": ["EsCwYwxuLPzTV7F7", "0crSgCYgV6hpjYne", "P7VkRsz0E1TgaU2K"]}, {"partyID": "2n1JMpCmLAckoGMr", "userIDs": ["fqXh9Yi9sIBQbGII", "TpsIRyQL5qeScWxF", "qCo2THUCSfVY7SEG"]}]}], "version": 83}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'EMM2LdYulOoouVLy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'AppendTeamGameSession' test.out

#- 56 PublicPartyJoinCode
# body param: body
echo '{"code": "Y5l3zat0SbuB1wMD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PublicPartyJoinCode' test.out

#- 57 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId '51VeGbfpAAYyBbEy' \
    > test.out 2>&1
eval_tap $? 57 'PublicGetParty' test.out

#- 58 PublicUpdateParty
# body param: body
echo '{"attributes": {"0fEmRKPynE1Ulth6": {}, "WUsfyOIdVfGOJIPb": {}, "5iLNRM7JFauJ3tVs": {}}, "inactiveTimeout": 8, "inviteTimeout": 21, "joinability": "tZATTbB1ZGFmU24Z", "maxPlayers": 5, "minPlayers": 0, "type": "3cv7u2wN8c1Kpu4l", "version": 34}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'TEr3CbX1jCvt8SZQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicUpdateParty' test.out

#- 59 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"VAQVTEjLxRXXw1Ba": {}, "3BCLDK9EHH019Qef": {}, "K1Zmj8WfGj2nDHeE": {}}, "inactiveTimeout": 69, "inviteTimeout": 79, "joinability": "T96WiKFqOEuv5vim", "maxPlayers": 26, "minPlayers": 99, "type": "63Casxqy2jZLzE1t", "version": 46}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId '97wPaRfkXyLS86H3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'PublicPatchUpdateParty' test.out

#- 60 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'ub7hu9Mf6Qeyu5D0' \
    > test.out 2>&1
eval_tap $? 60 'PublicGeneratePartyCode' test.out

#- 61 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'XT5fharkK0AIGdEb' \
    > test.out 2>&1
eval_tap $? 61 'PublicRevokePartyCode' test.out

#- 62 PublicPartyInvite
# body param: body
echo '{"platformID": "xsUwJLzvxAqxaBvY", "userID": "kRH723c57BNNjQJ7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'TXsOwwby9OOnuphq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicPartyInvite' test.out

#- 63 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "96OvBp28vxdZ0sUS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId '14l56FKfjkcB2SiF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'PublicPromotePartyLeader' test.out

#- 64 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'scU2TIptCl7Mr5hH' \
    > test.out 2>&1
eval_tap $? 64 'PublicPartyJoin' test.out

#- 65 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId '9GexcdbT8v3UhVtg' \
    > test.out 2>&1
eval_tap $? 65 'PublicPartyLeave' test.out

#- 66 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'g8kRaAVvE6mqqeoT' \
    > test.out 2>&1
eval_tap $? 66 'PublicPartyReject' test.out

#- 67 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'T0uNoVVn7ItFFSEo' \
    --userId 'Uy7DgmV5mD3u0JWh' \
    > test.out 2>&1
eval_tap $? 67 'PublicPartyKick' test.out

#- 68 PublicCreateParty
# body param: body
echo '{"attributes": {"mI5cbJHxH87DGHTs": {}, "wv6V7PYLXBxOdM9z": {}, "l6FELMoLSWz6oSQs": {}}, "configurationName": "OH1Xbs430fGmUXSc", "inactiveTimeout": 14, "inviteTimeout": 76, "joinability": "ZStYmu7rsmI2iz8i", "maxPlayers": 61, "members": [{"ID": "bBloI0YJYXW2uzKW", "PlatformID": "NGYBQtqkaX58cIGP", "PlatformUserID": "aIh2fIggFFHPcxOt"}, {"ID": "LAhTn1phglYoAkb9", "PlatformID": "a7zwipvdA2x113f0", "PlatformUserID": "Bp2vdsCew5mf0wUY"}, {"ID": "RGs6ndQOUixZzcm2", "PlatformID": "OM0B7COBhqguJYsA", "PlatformUserID": "ONDGwAOmzWmrbHeY"}], "minPlayers": 45, "textChat": false, "type": "hgN0OnEE5a4pDdwi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PublicCreateParty' test.out

#- 69 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --userId 'k56EtzesGM5rBXwL' \
    > test.out 2>&1
eval_tap $? 69 'PublicGetRecentPlayer' test.out

#- 70 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"4B1VjVn6f8aba9YX": {}, "wFYQFr3UBeKJ4xec": {}, "Zaf7owlXFBz6IbxI": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'l5dUFT7bJ07WKDAy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicUpdateInsertSessionStorageLeader' test.out

#- 71 PublicUpdateInsertSessionStorage
# body param: body
echo '{"NRUJsM9g7YDVCdVk": {}, "7pAhlHOFFTGckEVL": {}, "OktrETc91ydu5RGf": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'uFAmP1wOzzLGRwbO' \
    --userId 'mouZ2YIPoumSJ3Sz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicUpdateInsertSessionStorage' test.out

#- 72 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["T8lUpXxkPntiTrWD", "69zuVXfklxnwCn4o", "N7ReDjlm69cVOR7c"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 73 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'PublicGetPlayerAttributes' test.out

#- 74 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "2te6X3S3HwJUMVxE", "data": {"YAqoGebWDx1rIY7Y": {}, "gqLazmwaTdH4Cz8G": {}, "7R8H7IL8v5O1r7P5": {}}, "platforms": [{"name": "inUTEQGSKH2wQE3r", "userID": "MpBR96V4wCGhThbt"}, {"name": "8E3jI5UoWvqFZQoL", "userID": "3OUkQDJft6r5a3gp"}, {"name": "tbNLX0aELOa6N75c", "userID": "ogVkZy2V8uOMXE5z"}], "roles": ["aiqfUuDbogZiwydw", "zfWPCVvLLFNSKl79", "V2ucJ4eDQyH46uQb"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'PublicStorePlayerAttributes' test.out

#- 75 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 75 'PublicDeletePlayerAttributes' test.out

#- 76 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'THK5X3o94hUU3uq7' \
    --orderBy 'jQcfShtEtVr2SVT1' \
    --status 'NiSinLANULfgmYSJ' \
    > test.out 2>&1
eval_tap $? 76 'PublicQueryMyGameSessions' test.out

#- 77 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'IzEBkXmc2FhrwrUK' \
    --orderBy 't0S1mnKCBDLO5p7A' \
    --status 'U8haiJAyCejYVpU1' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE