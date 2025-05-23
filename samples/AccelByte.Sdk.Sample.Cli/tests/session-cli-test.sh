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
echo "1..94"

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

#- 4 AdminGetLogConfig
$CLI_EXE \
    --sn session \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 4 'AdminGetLogConfig' test.out

#- 5 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "debug"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateLogConfig' test.out

#- 6 AdminGetDSMCConfigurationDefault
eval_tap 0 6 'AdminGetDSMCConfigurationDefault # SKIP deprecated' test.out

#- 7 AdminListEnvironmentVariables
$CLI_EXE \
    --sn session \
    --op AdminListEnvironmentVariables \
    > test.out 2>&1
eval_tap $? 7 'AdminListEnvironmentVariables' test.out

#- 8 AdminListGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminListGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 8 'AdminListGlobalConfiguration' test.out

#- 9 AdminUpdateGlobalConfiguration
# body param: body
echo '{"metricExcludedNamespaces": ["Yi3wMWnoZgIhwb8Y", "YMLqpQwkRRHkaiKs", "mIiRLR3IlNJKxhPf"], "regionRetryMapping": {"WV6dIabcFbSmeuIB": ["roF7bwRgwKvzESbh", "pxlDdEs4igdKeLmy", "8tZ5GZi5P12c61ts"], "3fMI04rm2jUc9iav": ["3tTqlE9oLDPD0Lfl", "e8ESU1MO8XnVaEyj", "mifJDYa1TJPUszmF"], "GEkJVvqDSU3PDyIA": ["GfGq1FNmRWvUvDPn", "KoECjGUg867xodwu", "G14ID5l5wj6K2wEM"]}, "regionURLMapping": ["nckjlW6BywsSSZTG", "lubsmhjXcScOUvrj", "JBO7tbkTGYKqRMST"], "testGameMode": "isP0MrSdaFy0pJYC", "testRegionURLMapping": ["dfkfyt09ro5fHdWq", "JTNjrmpnnEckHH8k", "T9oXVandercf1nq4"], "testTargetUserIDs": ["Hf32SL5PjaYEDxaY", "N8w9KUW0py8KrcQf", "ucSq2X8gFuJORk4j"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateGlobalConfiguration \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateGlobalConfiguration' test.out

#- 10 AdminDeleteGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminDeleteGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 10 'AdminDeleteGlobalConfiguration' test.out

#- 11 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetConfigurationAlertV1' test.out

#- 12 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 31}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateConfigurationAlertV1' test.out

#- 13 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 97}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminCreateConfigurationAlertV1' test.out

#- 14 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteConfigurationAlertV1' test.out

#- 15 AdminUploadXBoxCertificate
eval_tap 0 15 'AdminUploadXBoxCertificate # SKIP deprecated' test.out

#- 16 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNDisableSystemUIMenu": ["KICK", "UPDATE_INVITABLE_USER_TYPE", "PROMOTE_TO_LEADER"], "PSNServiceLabel": 96, "PSNSupportedPlatforms": ["XTsQUrA0WWyKl2K5", "mCSoGeQCahcox63c", "yDxAAYcRXJdoSTxN"], "SessionTitle": "CK9AIjNmbfoW8bDq", "ShouldSync": true, "XboxAllowCrossPlatform": false, "XboxSandboxID": "7EajwHO3LfvwPewr", "XboxServiceConfigID": "f19Njm50xCDlPeNq", "XboxSessionTemplateName": "0CvMXtyUWXrdZaFe", "XboxTitleID": "acGT2x6o28Njxyw7", "localizedSessionName": {"RHldq0m7NjUZ95Z5": {}, "XDLBN9YGVPtkjt0O": {}, "yBlJi4RbZ0Iy11mf": {}}}, "PSNBaseUrl": "OFjCzZVcGomWF1oA", "amsClaimTimeoutMinutes": 34, "appName": "3SGqcH91fC3aJEoq", "asyncProcessDSRequest": {"async": false, "timeout": 15}, "attributes": {"FAGD6PRg95m07l03": {}, "vtlMFzeiMRkcOr1L": {}, "0TMIczbYilOziwG8": {}}, "autoJoin": true, "autoLeaveSession": true, "clientVersion": "PLOzSZm9K3cMY617", "customURLGRPC": "HSCYZaL46I3PgCcQ", "deployment": "0axTWnmyEYLZQTpv", "disableCodeGeneration": true, "disableResendInvite": false, "dsManualSetReady": true, "dsSource": "PEBP8kSSFjeuL3wQ", "enableSecret": false, "fallbackClaimKeys": ["YwmYFbxRvHYDCYwo", "GdmzXgf1ewUTvnu0", "ensa3MZF7DTswnkS"], "grpcSessionConfig": {"appName": "yuJTVjKQ1ORLEIAe", "customURL": "PvDO2xkVgyRk10b2", "functionFlag": 89}, "immutableStorage": false, "inactiveTimeout": 7, "inviteTimeout": 49, "joinability": "U8VceYQ9erPYQ5yV", "leaderElectionGracePeriod": 5, "manualRejoin": false, "maxActiveSessions": 87, "maxPlayers": 30, "minPlayers": 41, "name": "5UyvuFv5z6wosJGn", "persistent": true, "preferredClaimKeys": ["UNPHN8YZT0yJJ0uC", "jjaNCRV3hSIiTEoT", "CSxjAqg9oGVEdC8m"], "requestedRegions": ["Qir1Af0G6OrPH6Zs", "jpPgHKISHtB8tWdJ", "M9Qc5HmR0vknXO45"], "textChat": true, "textChatMode": "TEAM", "tieTeamsSessionLifetime": true, "ttlHours": 46, "type": "NXSTItt35OJTfJBZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminCreateConfigurationTemplateV1' test.out

#- 17 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '43' \
    --name '62yI9g5RDrlzPFQm' \
    --offset '81' \
    --order 'v1DzPHux3k3skhn3' \
    --orderBy 'mWZjTYM95e4aa8xO' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetAllConfigurationTemplatesV1' test.out

#- 18 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'Ju7rNRVdygfKmUkz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminGetConfigurationTemplateV1' test.out

#- 19 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNDisableSystemUIMenu": ["PROMOTE_TO_LEADER", "PROMOTE_TO_LEADER", "UPDATE_JOINABLE_USER_TYPE"], "PSNServiceLabel": 65, "PSNSupportedPlatforms": ["1pZGMfPdGIOAZ86u", "n0L98WUoXvfU4qMI", "pfgxw2ff5twRYbtd"], "SessionTitle": "K2r4wWs6IpYBxafo", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "xJyNnvHKrm8UuNlT", "XboxServiceConfigID": "86N9yO0vyD6J5brV", "XboxSessionTemplateName": "o20e6POTjrinAVVo", "XboxTitleID": "vpAAXNzcpbmX3lLF", "localizedSessionName": {"eXCiaXP8jBjK81t2": {}, "V9TVauFcGkPgQ0hb": {}, "2tLrsMeoZiRYkbhE": {}}}, "PSNBaseUrl": "M1zTNY3lpincuf5d", "amsClaimTimeoutMinutes": 16, "appName": "saQvKfFRqBam8jPt", "asyncProcessDSRequest": {"async": false, "timeout": 69}, "attributes": {"pIHEWQMmCkIqwqpo": {}, "TVCNrcaVozsjIXO2": {}, "EUsAfBvo6Llcalks": {}}, "autoJoin": false, "autoLeaveSession": true, "clientVersion": "WhADRqJvaZrf2qXQ", "customURLGRPC": "FCzRV1paELj5dw3L", "deployment": "K0gPYhPPG5sAIfYt", "disableCodeGeneration": false, "disableResendInvite": false, "dsManualSetReady": true, "dsSource": "zA2OntGCwQSHHdPL", "enableSecret": true, "fallbackClaimKeys": ["AoED9oYwS8oLyErK", "vRtHFGJRoGW7VBG1", "VB2sp2x9mszGGoyh"], "grpcSessionConfig": {"appName": "GZAzt2OVBTLwSH8h", "customURL": "WRU9pbItGQ7VUWBh", "functionFlag": 68}, "immutableStorage": false, "inactiveTimeout": 30, "inviteTimeout": 41, "joinability": "lwafIfbF1GLFnrQ4", "leaderElectionGracePeriod": 94, "manualRejoin": false, "maxActiveSessions": 93, "maxPlayers": 4, "minPlayers": 91, "name": "mw7U1TxiS06UEoaD", "persistent": false, "preferredClaimKeys": ["r3oT88Dfc7114QFG", "wTzBVDg5v71kGCEt", "7h1mVwIQCJmQkvWb"], "requestedRegions": ["Qrn2W0VkOF0pQOY0", "UCcViiFKNjkT5hcO", "NCaOyATBFgqLeAzv"], "textChat": false, "textChatMode": "GAME", "tieTeamsSessionLifetime": true, "ttlHours": 28, "type": "hWRo6ROvbuPQwl9d"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'VfJQGkDR00ofXsbn' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateConfigurationTemplateV1' test.out

#- 20 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'EzHiRs0NmGhxv1vu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminDeleteConfigurationTemplateV1' test.out

#- 21 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'N7Xv6OuG6RR1jPh8' \
    --namespace $AB_NAMESPACE \
    --userId 'RblvnfNiABRf1gdX' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetMemberActiveSession' test.out

#- 22 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "M7QlAlnjAfgxOdZd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'f9tLHO1qrNyhmUEA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminReconcileMaxActiveSession' test.out

#- 23 AdminGetDSMCConfiguration
eval_tap 0 23 'AdminGetDSMCConfiguration # SKIP deprecated' test.out

#- 24 AdminSyncDSMCConfiguration
eval_tap 0 24 'AdminSyncDSMCConfiguration # SKIP deprecated' test.out

#- 25 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'DczzrL31HuYKsCBB' \
    --dsPodName 'gwb1hGjHJgxrcEvn' \
    --fromTime 'fJqU4hCv5egSQDeP' \
    --gameMode 'KSZKp6zwDQS1atvJ' \
    --isPersistent 'rALaiplJgRhedl5E' \
    --isSoftDeleted 'wh3jDayYStUiBB1y' \
    --joinability 'z3iP8gH88UenlMVz' \
    --limit '70' \
    --matchPool '0tuwIJnrSI2IFcRw' \
    --memberID 'SoMTuJziuDNbOydi' \
    --offset '42' \
    --order 'YZkBXiEhdiS41VBA' \
    --orderBy 'EUvoBlbH02bobxtl' \
    --sessionID 'jIfHBgjP9onbxFcx' \
    --status 'S2OZZfXO3HkJTOPs' \
    --statusV2 'cPA2n25C1zEnAMGm' \
    --toTime 'Fy7w6eqnMeKFo7U8' \
    > test.out 2>&1
eval_tap $? 25 'AdminQueryGameSessions' test.out

#- 26 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"Scr9xm68w7s9RMx2": {}, "hc45QX234xnqlbRA": {}, "PFQsca6n9vGZTCCX": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminQueryGameSessionsByAttributes' test.out

#- 27 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["Q2Lf7jtexB613cbi", "JEUePVZQaoEY2zrp", "Luvrx96OOz45vMiR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminDeleteBulkGameSessions' test.out

#- 28 AdminSetDSReady
# body param: body
echo '{"ready": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminSetDSReady \
    --namespace $AB_NAMESPACE \
    --sessionId 'NlK8PTaIXRWFTyA9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminSetDSReady' test.out

#- 29 AdminUpdateDSInformation
# body param: body
echo '{"createdRegion": "MDnKGXqq7Zk705hO", "deployment": "henJi6dNVF7zwjXq", "description": "lcD2LzaOwIF5tEsC", "ip": "woAVcZCSj80gzFvp", "port": 43, "region": "HA4CaLsPqRsTdKzc", "serverId": "KtkGcvn44NWse6VL", "source": "PkM1VTrQBywhJ7lb", "status": "BLw9xy1WQM5qUS8b"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateDSInformation \
    --namespace $AB_NAMESPACE \
    --sessionId 'aUqkzSr41y6RPBHJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminUpdateDSInformation' test.out

#- 30 AdminKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminKickGameSessionMember \
    --memberId 'uPjj8zDwOk0IgmYf' \
    --namespace $AB_NAMESPACE \
    --sessionId 'UTpFzyQhPVhRGX9x' \
    > test.out 2>&1
eval_tap $? 30 'AdminKickGameSessionMember' test.out

#- 31 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'lUKhXI8mL8OIhvP6' \
    --namespace $AB_NAMESPACE \
    --sessionId '8xE68dzohxhbej2c' \
    --statusType 'aIIfkXDY7jnhp3qY' \
    > test.out 2>&1
eval_tap $? 31 'AdminUpdateGameSessionMember' test.out

#- 32 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '67' \
    --offset '93' \
    --order 'p0E886E90E4ZboiX' \
    > test.out 2>&1
eval_tap $? 32 'AdminGetListNativeSession' test.out

#- 33 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --fromTime 'T1Uy0gArtDpQE4bO' \
    --isSoftDeleted 'toiAjHXcVVOsVywU' \
    --joinability '6uisejapftqoxujX' \
    --key 'DosOo2kSUfIA1guT' \
    --leaderID 'Nx7haejXSV2oH2uH' \
    --limit '42' \
    --memberID 'S4Zx0ACteueMOmYP' \
    --memberStatus '4SgxAIQTTKsdmtHu' \
    --offset '85' \
    --order 'dG0us7kIWLcgKgU9' \
    --orderBy '406tdRDqr3cpVbaH' \
    --partyID '69NyTfGE59942bCw' \
    --toTime 'gpzUfcmTQjRmV0CP' \
    --value 't1LUaTvrFaxzOfG3' \
    > test.out 2>&1
eval_tap $? 33 'AdminQueryParties' test.out

#- 34 AdminDeleteBulkParties
# body param: body
echo '{"ids": ["pTddIA0Rt6wM5oQv", "TMICtWyUtVDnhgTG", "XO8Utpwxug8Mpqcz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkParties \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminDeleteBulkParties' test.out

#- 35 AdminReadPartySessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadPartySessionStorage \
    --namespace $AB_NAMESPACE \
    --partyId 'RvUdK1uOV1ZJTYuH' \
    > test.out 2>&1
eval_tap $? 35 'AdminReadPartySessionStorage' test.out

#- 36 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'AdminGetPlatformCredentials' test.out

#- 37 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "pnpVX5u4gw4XBXDD", "clientSecret": "7BG73sDdDoXnB8F5", "scope": "X05KUgGKfDSGh3vQ"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminUpdatePlatformCredentials' test.out

#- 38 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'AdminDeletePlatformCredentials' test.out

#- 39 AdminDeletePlatformCredentialsByPlatformId
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentialsByPlatformId \
    --namespace $AB_NAMESPACE \
    --platformId 'XBOX' \
    > test.out 2>&1
eval_tap $? 39 'AdminDeletePlatformCredentialsByPlatformId' test.out

#- 40 AdminSyncPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminSyncPlatformCredentials \
    --namespace $AB_NAMESPACE \
    --platformId 'XBOX' \
    > test.out 2>&1
eval_tap $? 40 'AdminSyncPlatformCredentials' test.out

#- 41 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '22' \
    --userId 'Ci8WEjR3wqpnMdSN' \
    > test.out 2>&1
eval_tap $? 41 'AdminGetRecentPlayer' test.out

#- 42 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '38' \
    --userId 'fDK45zWtwYhRoNPw' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetRecentTeamPlayer' test.out

#- 43 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'Kema6caMTOcivPAk' \
    > test.out 2>&1
eval_tap $? 43 'AdminReadSessionStorage' test.out

#- 44 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'mP8Awb0NqtvSR9q6' \
    > test.out 2>&1
eval_tap $? 44 'AdminDeleteUserSessionStorage' test.out

#- 45 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'l5k9BLQMrPoTuxdz' \
    --userId 'EYAw5VdW05WnQEAb' \
    > test.out 2>&1
eval_tap $? 45 'AdminReadUserSessionStorage' test.out

#- 46 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'K416LN2N6D6yczit' \
    > test.out 2>&1
eval_tap $? 46 'AdminQueryPlayerAttributes' test.out

#- 47 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'n4OkZfx0Xa6sgegA' \
    > test.out 2>&1
eval_tap $? 47 'AdminGetPlayerAttributes' test.out

#- 48 AdminSyncNativeSession
$CLI_EXE \
    --sn session \
    --op AdminSyncNativeSession \
    --namespace $AB_NAMESPACE \
    --userId 'WYz2z4qSPPQBDFQs' \
    > test.out 2>&1
eval_tap $? 48 'AdminSyncNativeSession' test.out

#- 49 CreateGameSession
# body param: body
echo '{"appName": "vRHbGTC2ynue7Xk4", "attributes": {"uDF5mdakWJ2AsKf8": {}, "UfQqTQ8v7gXyFuLF": {}, "ZViQbxYQvUyapo6F": {}}, "autoJoin": false, "backfillTicketID": "zYWxYbbphuiQPU0a", "clientVersion": "S2OIp0B2FWiDu7PO", "configurationName": "aotJoQQyL1bCDNis", "customURLGRPC": "OhjEKFWmj7ioi5WZ", "deployment": "6ZymQeVSZZma57V6", "dsSource": "b9uLloAA9KoetyNP", "fallbackClaimKeys": ["kgWcTCN7aBIFfeRd", "nHpse2T7eZwkVrB3", "GSEmVq8CjR5rCx0Z"], "inactiveTimeout": 16, "inviteTimeout": 90, "joinability": "HwUqL5rITYFhcdeN", "matchPool": "wLmZenRqEBM0VGzh", "maxPlayers": 98, "minPlayers": 79, "preferredClaimKeys": ["VGdipdi33u9U14rG", "wvMExAllZtPzNRiR", "35CZhclugjyDzCPI"], "requestedRegions": ["8tslD0HuRrAMzMB9", "XHHkfZgB6Vt5qWaa", "e3SboVKgjsryC98w"], "serverName": "hmI5koBT6iCuVa64", "storage": {"leader": {"3kk8gvvnsu0ABei0": {}, "go2wsmPfpsbkzAIs": {}, "J06QlFCAa55r89Md": {}}}, "teams": [{"parties": [{"partyID": "Fidv2kFVXgnjrAfz", "userIDs": ["En26mHgxUgVDgnlU", "5H2ULa1LYlsqYrUp", "XncYv2BVIS1BtMqv"]}, {"partyID": "dE5QQizMBWYPYerJ", "userIDs": ["1FmKBX6U18gMIl7T", "SPm96MsoQcFDfKSJ", "ymqZ5tDVsJ63mFWW"]}, {"partyID": "0u95r5ylQKcWi0o5", "userIDs": ["zcWp7NiTBI4m6PVE", "QWCNw7DHkXx8NqXa", "R2w60X5Vb0TV0x3n"]}], "teamID": "mq9UCZbdVFY3WdZ6", "userIDs": ["luOW977EgotvOrnR", "jb5UT6Vf5jxoBBg2", "lM3DQXyC3oKu14sR"]}, {"parties": [{"partyID": "jkCeuRY0tsnbKAGR", "userIDs": ["TCvAZKiSB7bYvWmb", "UbWlRZtcIUry87yJ", "BlfjPI5tfjbyZkYS"]}, {"partyID": "RLBMgcD5OJgp6wHy", "userIDs": ["nVKwWgdAibFBESdI", "0Ab1zgjMC3hp1s4t", "ElQhEA9ThpSbyAYJ"]}, {"partyID": "eBCrKDcRkI5LI6Uq", "userIDs": ["ivHoIArvDT62TaGF", "Sxd4y808Fey8nfaG", "Ew6BAuz1YkANj6LH"]}], "teamID": "aNMxGL2cjWg68JcP", "userIDs": ["wqh2N4nelbmKVyNZ", "Y8IVtOeznPwNRnzt", "P1VeNj0XYtINcOQI"]}, {"parties": [{"partyID": "iLdvpuYVOAU9uuKP", "userIDs": ["GNN6m8BLNzJxMR9F", "8QPVUh3Fxn8VCvtd", "iiwNMAdIodiW3hcY"]}, {"partyID": "uKSRkkKQKIVOduQw", "userIDs": ["wDrBnpQpIKdlw0Q8", "Qm0lpTupwpI0MCOR", "OWHgnYO9A4NtX4m0"]}, {"partyID": "L4BGxxcKUh2wepEj", "userIDs": ["vh8sTPE7JfL8ZG7I", "BiOpvSKRmJcE8fHW", "U8tF9Tj5DH9jDJgq"]}], "teamID": "Zagf9TfKsyiaqf0V", "userIDs": ["fidvwpghGz92mfgw", "fewY0DMU8QuojVb8", "QgdEnIEDOXPqBEIQ"]}], "textChat": false, "textChatMode": "GAME", "ticketIDs": ["jD6Oo7qDSKsqbeuv", "GhaO0uibTsnrycsu", "5Q9BFGk7WCNwFDvI"], "tieTeamsSessionLifetime": false, "type": "dh450P2HCQEysNYm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --resolveMaxActiveSession 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'CreateGameSession' test.out

#- 50 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"yZCXx6V8vj07Wkqf": {}, "icTXXWpfaSkgXo8j": {}, "70KrUcPducAeJonN": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicQueryGameSessionsByAttributes' test.out

#- 51 PublicSessionJoinCode
# body param: body
echo '{"code": "s4KunUYQNVjaoZkB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'PublicSessionJoinCode' test.out

#- 52 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName '3AI1r9iOvxo4sO2v' \
    > test.out 2>&1
eval_tap $? 52 'GetGameSessionByPodName' test.out

#- 53 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '2SBoI1cMTFoDvnFj' \
    > test.out 2>&1
eval_tap $? 53 'GetGameSession' test.out

#- 54 UpdateGameSession
# body param: body
echo '{"attributes": {"F7PyPSihYagCDowX": {}, "pzPB56b3OlkJK0TM": {}, "s61QJU3NQDgVJljn": {}}, "backfillTicketID": "vyeys0Kd9lSy4dXR", "clientVersion": "irNN1XTVbZINAYTf", "deployment": "mDdnbfKLdllLcrgG", "fallbackClaimKeys": ["7MUCvBQxDMKfZnQU", "HzroRILUYE0mbvUd", "fY0BqpFwpFSBitpr"], "inactiveTimeout": 39, "inviteTimeout": 14, "joinability": "x35PWwBW4wLASmNz", "matchPool": "xcUMh0SvR4rhLLvU", "maxPlayers": 47, "minPlayers": 68, "preferredClaimKeys": ["AWnj9yPsgbHDuaBM", "lhmWv2CjjBQfnFyR", "j8oJlSSFh8ZLYsKN"], "requestedRegions": ["sz83B3uSAH6QCBcz", "exoUjGKIDYp3uk6S", "Y3LbL8Ij6Hou1skD"], "teams": [{"parties": [{"partyID": "80rM9MH0bGReYems", "userIDs": ["eR492ILQLV79lT8s", "ZwaopSrf16qAbt38", "yZTqfCi5CJgLU0r1"]}, {"partyID": "txp0vdRA0J8eLCZr", "userIDs": ["cT7EO7zBX353qlmB", "OmzDZoLl4yLZgHla", "tL7nbsrfkzQM5RtM"]}, {"partyID": "qCRiYe7QxHteM0Qs", "userIDs": ["fB4cKcpv0nqsAzwh", "iinZMK2PQePnMgPL", "2upEuzGkAuUgSs7K"]}], "teamID": "jVR3KElIaqQcqk3E", "userIDs": ["vPPboGcBp08H0whj", "TC8Q254CIig93OcD", "TSDDbtG4kbF7EcYP"]}, {"parties": [{"partyID": "Ae3TKjWJizZ73YhE", "userIDs": ["dqt8LYH7I8lYD68Z", "I9yJ2FmHnprty5BQ", "Cd5sVLr7TlnKnQhY"]}, {"partyID": "H2PkwSPXdYk0YxFN", "userIDs": ["no9WQq9ZHHjrwqKs", "a8ZqhezPIlBtGhWc", "8fY9HfUsEaPxVM4c"]}, {"partyID": "VRtjpUequcPWZP6m", "userIDs": ["J5k9QPUVO9elCnXC", "nhXRiCBS6wONO7Ez", "D1HwKEgGh6MctPOq"]}], "teamID": "g2vfaFiXbkyxYVJY", "userIDs": ["oECX5Zk7zrqRFfKg", "2QLfgPky92H0SjmR", "KLX0YyNLgOIbDgux"]}, {"parties": [{"partyID": "dqP6c448AniKDjnb", "userIDs": ["5cFYyJtzDcKD3CR1", "8eggGJVXROWQLNP4", "J0I2wDjuMHSknrvH"]}, {"partyID": "sarToh01sSaePBAW", "userIDs": ["rnMRr0i4i3znplxZ", "VkkzCuWXN0pi9oHw", "FFSWlYJSaX14Onxc"]}, {"partyID": "82WUAqFNlxPL5ZjW", "userIDs": ["vAiWvl12EyddbFel", "mB60OEQrMIsKCf8G", "sPEl1i9RQ9tNv9Zo"]}], "teamID": "FgoU8geQqTHsgesx", "userIDs": ["Udeb2FJbsqzkOO5T", "gVxhorx7Olr6yZsG", "5AHeXjxQCmc8jD3q"]}], "ticketIDs": ["7UouREPLDNt6Bi4u", "dSrXnIItduiUuy8t", "q9HCTgLSuFiv2W3x"], "tieTeamsSessionLifetime": true, "type": "8AyIWIiWAkZb55Pm", "version": 81}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'OGbTW0UOPodtVEAH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'UpdateGameSession' test.out

#- 55 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'UTPJcWSRPDFdkQZD' \
    > test.out 2>&1
eval_tap $? 55 'DeleteGameSession' test.out

#- 56 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"rW0M7eIDrifb9ovo": {}, "uuoyV36gCehJP43X": {}, "pu5gyQ14gMP9Z4mE": {}}, "backfillTicketID": "vMNjtERuv6NrO6Sj", "clientVersion": "BOH0izSSpVoq4E6C", "deployment": "tycfHMbZoBgzDSnB", "fallbackClaimKeys": ["tqToPbBDwdvFVFTK", "8mQqqA2VoUKBlsPX", "L4ibYVB9w0ETfSau"], "inactiveTimeout": 42, "inviteTimeout": 19, "joinability": "tS9JWgSB39nWJ0Ad", "matchPool": "ErhRmHmtCl6M85EL", "maxPlayers": 89, "minPlayers": 95, "preferredClaimKeys": ["v5NEe9bR9ckNLMJj", "sgaXBRR415WJviuc", "5vA36xYMMPep0zpl"], "requestedRegions": ["FiRg22RpUVtQXjIt", "ygvyTYykvnB2kvfx", "E0sqbjAHF9QLlS2l"], "teams": [{"parties": [{"partyID": "C0QB41qRS25yYg5f", "userIDs": ["kChtyUjcBHShoy4r", "AmtQkeCoVHY89b92", "PWEF9gisonsVtIIB"]}, {"partyID": "DDZzSa012J2Vd3Ma", "userIDs": ["SmOIA08Q4Pe45ZkF", "7UCeoZEUNVKjMQUM", "30waRuDKnw63w8ZD"]}, {"partyID": "7GzTZ0WS0ZfkVqKo", "userIDs": ["wfa2xO5BhQtMYVHJ", "ohu8Sfs3a0odaQ1H", "gT2WnpHkT1LxGYzo"]}], "teamID": "lfxvDyx6IAAOUeUR", "userIDs": ["iiiEgBQnBdCORXu3", "yYfZ5p6HsVODk8yY", "xP6eRLWH719H0S96"]}, {"parties": [{"partyID": "d6o92O9JTphnwOfF", "userIDs": ["zh20ovT23TbEK3bM", "30lxx1rT6fsKa4Ig", "tUwYePFCH42h6Luc"]}, {"partyID": "fBcrN83Rs41H9Aya", "userIDs": ["2Ugl7sPCMcCq8KOF", "1FPASWEGLvHi2yA6", "ZsXJoVWUuZ6fQXMh"]}, {"partyID": "nC8iRACppkc2GjnJ", "userIDs": ["6MqokeFNTOal7C9Q", "hMyKSxoXxGxkYjDc", "p3pGTMJShikvBpSO"]}], "teamID": "kSVhuAqkZqR3gW3G", "userIDs": ["fD7JtchRl8UCypNx", "xUbXgFF9TJrlNNry", "ir2rcfzqMDXs2AMI"]}, {"parties": [{"partyID": "qwXxAtcjA062eWYC", "userIDs": ["E2BZKl6Ks6ND0evl", "W05Ize0EKI1ogofw", "rtjPjSrjvrgKMZ79"]}, {"partyID": "d1xh7UR0UxrnZ5OM", "userIDs": ["XgRDRM3gg9nVFQux", "aksqHEV6l9c1J0YV", "5SAUWFWpU4iAd1zl"]}, {"partyID": "FBNJu2WkeGDSzlCa", "userIDs": ["Ft7Cu0JKjLegxbCc", "IqhcBHRl1tn7RtEG", "UE0zrKNm1qW2n5ce"]}], "teamID": "omro5tLlKiW8dBlS", "userIDs": ["c2bkfxl91A6ODfId", "1vJ63xKDRbcNco2q", "PofshHt88ZrOopYO"]}], "ticketIDs": ["MqbJVfyl0ssL0Nn5", "BZz9qxx7lz9uMrrT", "54dKxRwFRslFsKiW"], "tieTeamsSessionLifetime": false, "type": "UOwEpVOojiniOJfB", "version": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'aE9mVJJqgitULlhI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PatchUpdateGameSession' test.out

#- 57 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "9rKPyF7ytpQiDiCA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'h2lkPXOOJp91w7AC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'UpdateGameSessionBackfillTicketID' test.out

#- 58 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'gmrezLCJKLPrwjeY' \
    > test.out 2>&1
eval_tap $? 58 'GameSessionGenerateCode' test.out

#- 59 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'eJi9q4KUgzZZ6zaa' \
    > test.out 2>&1
eval_tap $? 59 'PublicRevokeGameSessionCode' test.out

#- 60 PublicGameSessionInvite
# body param: body
echo '{"metadata": {"AvvKi9jeErSpDVNG": "zTIFbOjIMnvbwCSA", "fTUy9Iqsv2Y3W67o": "jKlGpC6ngrWr5beU", "GEW4t5eLuFOuGcii": "p6lhOAT59629Ly5G"}, "platformID": "JfaRlZeRpPnJNyrw", "userID": "dMhlz3T4PPNLrCKg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'oc8qlZTdK2TxyWH1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicGameSessionInvite' test.out

#- 61 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'R8xeeueyWn4YodSI' \
    > test.out 2>&1
eval_tap $? 61 'JoinGameSession' test.out

#- 62 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "hZNsnN86SsqD74Vr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'PBlaPDrv6Eb7CbB1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicPromoteGameSessionLeader' test.out

#- 63 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'CzxJ9zmeLvT7VIP5' \
    > test.out 2>&1
eval_tap $? 63 'LeaveGameSession' test.out

#- 64 PublicKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op PublicKickGameSessionMember \
    --memberId 'dOI5JEsCwYwxuLPz' \
    --namespace $AB_NAMESPACE \
    --sessionId 'TV7F70crSgCYgV6h' \
    > test.out 2>&1
eval_tap $? 64 'PublicKickGameSessionMember' test.out

#- 65 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'pjYneP7VkRsz0E1T' \
    > test.out 2>&1
eval_tap $? 65 'PublicGameSessionReject' test.out

#- 66 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'gaU2K2n1JMpCmLAc' \
    > test.out 2>&1
eval_tap $? 66 'GetSessionServerSecret' test.out

#- 67 AppendTeamGameSession
eval_tap 0 67 'AppendTeamGameSession # SKIP deprecated' test.out

#- 68 PublicGameSessionCancel
$CLI_EXE \
    --sn session \
    --op PublicGameSessionCancel \
    --namespace $AB_NAMESPACE \
    --sessionId 'koGMrfqXh9Yi9sIB' \
    --userId 'QbGIITpsIRyQL5qe' \
    > test.out 2>&1
eval_tap $? 68 'PublicGameSessionCancel' test.out

#- 69 PublicPartyJoinCode
# body param: body
echo '{"code": "ScWxFqCo2THUCSfV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicPartyJoinCode' test.out

#- 70 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Y7SEGOwWwVPMXi6T' \
    > test.out 2>&1
eval_tap $? 70 'PublicGetParty' test.out

#- 71 PublicUpdateParty
# body param: body
echo '{"attributes": {"iqSRiBbSv5Mu9psp": {}, "hB22GwYtWzihoA8U": {}, "Zno0upxwRKEKNIla": {}}, "inactiveTimeout": 34, "inviteTimeout": 96, "joinability": "2KS5yUS265k6o7P4", "maxPlayers": 73, "minPlayers": 60, "type": "IPb5iLNRM7JFauJ3", "version": 39}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'KX3k2xmrmuw7Xo6c' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicUpdateParty' test.out

#- 72 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"48Bsc3cv7u2wN8c1": {}, "Kpu4lqYfwmcvvAUS": {}, "6PzOOwSik7CwUa7L": {}}, "inactiveTimeout": 49, "inviteTimeout": 88, "joinability": "w1Ba3BCLDK9EHH01", "maxPlayers": 32, "minPlayers": 87, "type": "kJeCMYVGaGlXMirt", "version": 8}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId '3mMswJSdKiaNMrgJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicPatchUpdateParty' test.out

#- 73 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId '4VqWXNo76z7J1NW0' \
    > test.out 2>&1
eval_tap $? 73 'PublicGeneratePartyCode' test.out

#- 74 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'IoTP97wPaRfkXyLS' \
    > test.out 2>&1
eval_tap $? 74 'PublicRevokePartyCode' test.out

#- 75 PublicPartyInvite
# body param: body
echo '{"metadata": {"86H3ub7hu9Mf6Qey": "u5D0XT5fharkK0AI", "GdEbxsUwJLzvxAqx": "aBvYkRH723c57BNN", "jQJ7TXsOwwby9OOn": "uphq96OvBp28vxdZ"}, "platformID": "0sUS14l56FKfjkcB", "userID": "2SiFscU2TIptCl7M"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'r5hH9GexcdbT8v3U' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicPartyInvite' test.out

#- 76 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "hVtgg8kRaAVvE6mq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'qeoTT0uNoVVn7ItF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'PublicPromotePartyLeader' test.out

#- 77 PublicReadPartySessionStorage
$CLI_EXE \
    --sn session \
    --op PublicReadPartySessionStorage \
    --namespace $AB_NAMESPACE \
    --partyId 'FSEoUy7DgmV5mD3u' \
    > test.out 2>&1
eval_tap $? 77 'PublicReadPartySessionStorage' test.out

#- 78 PublicUpdateInsertPartySessionStorageReserved
# body param: body
echo '{"0JWhmI5cbJHxH87D": {}, "GHTswv6V7PYLXBxO": {}, "dM9zl6FELMoLSWz6": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertPartySessionStorageReserved \
    --namespace $AB_NAMESPACE \
    --partyId 'oSQsOH1Xbs430fGm' \
    --userId 'UXScgZStYmu7rsmI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicUpdateInsertPartySessionStorageReserved' test.out

#- 79 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId '2iz8iDqES2enp5Qs' \
    > test.out 2>&1
eval_tap $? 79 'PublicPartyJoin' test.out

#- 80 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'uU2SzC5jPZ753VQL' \
    > test.out 2>&1
eval_tap $? 80 'PublicPartyLeave' test.out

#- 81 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'K9K4e0w5qc4U4ZoF' \
    > test.out 2>&1
eval_tap $? 81 'PublicPartyReject' test.out

#- 82 PublicPartyCancel
$CLI_EXE \
    --sn session \
    --op PublicPartyCancel \
    --namespace $AB_NAMESPACE \
    --partyId 'CFoWEdyIcgWEloql' \
    --userId 'dQTXf1RjwLWiMZtn' \
    > test.out 2>&1
eval_tap $? 82 'PublicPartyCancel' test.out

#- 83 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'Xi3eLkvnj2FHRRu0' \
    --userId 'umwsxpdZ1WWgZKlu' \
    > test.out 2>&1
eval_tap $? 83 'PublicPartyKick' test.out

#- 84 PublicCreateParty
# body param: body
echo '{"attributes": {"L2AcsKLs4xA7pgTn": {}, "AOS7ZVDYbaZdRyWB": {}, "XrjEfLoBc63d2CjP": {}}, "configurationName": "St7u9HWKXy95GCrx", "inactiveTimeout": 35, "inviteTimeout": 79, "joinability": "JkGMw7ZL0l1KamHk", "maxPlayers": 20, "members": [{"ID": "aba9YXwFYQFr3UBe", "PlatformID": "KJ4xecZaf7owlXFB", "PlatformUserID": "z6IbxIl5dUFT7bJ0"}, {"ID": "7WKDAyNRUJsM9g7Y", "PlatformID": "DVCdVk7pAhlHOFFT", "PlatformUserID": "GckEVLOktrETc91y"}, {"ID": "du5RGfuFAmP1wOzz", "PlatformID": "LGRwbOmouZ2YIPou", "PlatformUserID": "mSJ3SzT8lUpXxkPn"}], "minPlayers": 41, "textChat": false, "type": "TmYVuz6shya81WnW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'PublicCreateParty' test.out

#- 85 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '77' \
    > test.out 2>&1
eval_tap $? 85 'PublicGetRecentPlayer' test.out

#- 86 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    > test.out 2>&1
eval_tap $? 86 'PublicGetRecentTeamPlayer' test.out

#- 87 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"IEMQX6yIuvLV2SAA": {}, "8KoDH2te6X3S3HwJ": {}, "UMVxEYAqoGebWDx1": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'rIY7YgqLazmwaTdH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'PublicUpdateInsertSessionStorageLeader' test.out

#- 88 PublicUpdateInsertSessionStorage
# body param: body
echo '{"4Cz8G7R8H7IL8v5O": {}, "1r7P5inUTEQGSKH2": {}, "wQE3rMpBR96V4wCG": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'hThbt8E3jI5UoWvq' \
    --userId 'FZQoL3OUkQDJft6r' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'PublicUpdateInsertSessionStorage' test.out

#- 89 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["5a3gptbNLX0aELOa", "6N75cogVkZy2V8uO", "MXE5zaiqfUuDbogZ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 90 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 90 'PublicGetPlayerAttributes' test.out

#- 91 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "fJD71OE4nmvUcjS4", "data": {"yL7G8PAD8A91XiYV": {}, "8om2lFtO185fesSB": {}, "anCCZXDbHiemt24R": {}}, "platforms": [{"name": "YVxvOizOsLuBOtvU", "userID": "0dysGQ752SjQQxTA"}, {"name": "0y5W0iCFQFClD4St", "userID": "fbPz4B3LcomgS0Mv"}, {"name": "gfAJ19LgFCiF7r23", "userID": "snbG2mmF7HlYrBpx"}], "roles": ["szoG732S8YEcJvLP", "LmCDp2m56H6rESnZ", "Ab49bMTsiu2Ahkyi"], "simultaneousPlatform": "hhJm1tA5U3YHEAna"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'PublicStorePlayerAttributes' test.out

#- 92 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 92 'PublicDeletePlayerAttributes' test.out

#- 93 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'S5wuVNYIq4a0PNyh' \
    --orderBy 'zEL7RV4dZ3uArJ4l' \
    --status 'i30FlwghwRVPRlUR' \
    > test.out 2>&1
eval_tap $? 93 'PublicQueryMyGameSessions' test.out

#- 94 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'fpBbB4nFHrMfRpBH' \
    --orderBy 'Oax7TNLzgW5GMdrZ' \
    --status 'OdIXAHBSS6r5wDG7' \
    > test.out 2>&1
eval_tap $? 94 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE