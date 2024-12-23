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
echo "1..90"

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
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfigurationDefault \
    > test.out 2>&1
eval_tap $? 6 'AdminGetDSMCConfigurationDefault' test.out

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
echo '{"NativeSessionSetting": {"PSNServiceLabel": 11, "PSNSupportedPlatforms": ["sUtNanddzgwxYdQc", "5hEfefdopcEM0JHf", "of2Hwi7vg3osbh0f"], "SessionTitle": "L2h7eJvAS2W4uqkh", "ShouldSync": true, "XboxAllowCrossPlatform": true, "XboxSandboxID": "SC7EajwHO3LfvwPe", "XboxServiceConfigID": "wrf19Njm50xCDlPe", "XboxSessionTemplateName": "Nq0CvMXtyUWXrdZa", "XboxTitleID": "FeacGT2x6o28Njxy", "localizedSessionName": {"w7RHldq0m7NjUZ95": {}, "Z5XDLBN9YGVPtkjt": {}, "0OyBlJi4RbZ0Iy11": {}}}, "PSNBaseUrl": "mfOFjCzZVcGomWF1", "appName": "oAqUNFDtXnXLvOAs", "attributes": {"W8wYh4gq7pRVZVLJ": {}, "iDx3au9b9QjhzDln": {}, "Jmi4XaBTgoXjfdUQ": {}}, "autoJoin": false, "autoLeaveSession": false, "clientVersion": "wG8CPLOzSZm9K3cM", "customURLGRPC": "Y617HSCYZaL46I3P", "deployment": "gCcQ0axTWnmyEYLZ", "disableCodeGeneration": false, "disableResendInvite": true, "dsManualSetReady": false, "dsSource": "NnuMcAwrSzYnrcet", "enableSecret": true, "fallbackClaimKeys": ["uL3wQQPYwmYFbxRv", "HYDCYwoGdmzXgf1e", "wUTvnu0ensa3MZF7"], "grpcSessionConfig": {"appName": "DTswnkSyuJTVjKQ1", "customURL": "ORLEIAePvDO2xkVg", "functionFlag": 50}, "immutableStorage": true, "inactiveTimeout": 22, "inviteTimeout": 91, "joinability": "10b27RdU8VceYQ9e", "leaderElectionGracePeriod": 35, "manualRejoin": false, "maxActiveSessions": 86, "maxPlayers": 69, "minPlayers": 87, "name": "zBcEio5UyvuFv5z6", "persistent": true, "preferredClaimKeys": ["CQwMBcQUNPHN8YZT", "0yJJ0uCjjaNCRV3h", "SIiTEoTCSxjAqg9o"], "requestedRegions": ["GVEdC8mQir1Af0G6", "OrPH6ZsjpPgHKISH", "tB8tWdJM9Qc5HmR0"], "textChat": true, "tieTeamsSessionLifetime": false, "type": "c8lGIYWTwxyqQQIX"}' > $TEMP_JSON_INPUT
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
    --limit '97' \
    --name '5OJTfJBZX62yI9g5' \
    --offset '89' \
    --order 'rl3gYx6Xmv1DzPHu' \
    --orderBy 'x3k3skhn3mWZjTYM' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetAllConfigurationTemplatesV1' test.out

#- 18 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name '95e4aa8xOJu7rNRV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminGetConfigurationTemplateV1' test.out

#- 19 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 8, "PSNSupportedPlatforms": ["lcljuNM3eUUSD1pZ", "GMfPdGIOAZ86un0L", "98WUoXvfU4qMIpfg"], "SessionTitle": "xw2ff5twRYbtdK2r", "ShouldSync": true, "XboxAllowCrossPlatform": true, "XboxSandboxID": "7wtRGdT447Oa51m6", "XboxServiceConfigID": "VLfjsw270pMmOQJr", "XboxSessionTemplateName": "pEBbVvBn8Lsf2qSA", "XboxTitleID": "tizV9hzsVbpJLtEZ", "localizedSessionName": {"juyFhvbxX2DNbknf": {}, "Vv4nm70TCayYAkF1": {}, "8YBwRxcREyU5CwqG": {}}}, "PSNBaseUrl": "JF6nDi33Iztr2Qcw", "appName": "lRrReRajlpk8lfui", "attributes": {"JVcktlx9zJZVVCc9": {}, "bpIHEWQMmCkIqwqp": {}, "oTVCNrcaVozsjIXO": {}}, "autoJoin": true, "autoLeaveSession": false, "clientVersion": "UsAfBvo6Llcalks2", "customURLGRPC": "R3VMtipTVxXAF8Kh", "deployment": "OKqbrECijFxOpOzx", "disableCodeGeneration": false, "disableResendInvite": false, "dsManualSetReady": true, "dsSource": "LJQsZcTEzXaXUzps", "enableSecret": true, "fallbackClaimKeys": ["YtYozA2OntGCwQSH", "HdPLwjTngrvb2E1X", "9ecBBhRAYjR7c4x5"], "grpcSessionConfig": {"appName": "bIk8pVpxdUWOPel3", "customURL": "TiwTycqpVdINXzvk", "functionFlag": 91}, "immutableStorage": true, "inactiveTimeout": 69, "inviteTimeout": 99, "joinability": "hWRU9pbItGQ7VUWB", "leaderElectionGracePeriod": 16, "manualRejoin": false, "maxActiveSessions": 68, "maxPlayers": 1, "minPlayers": 30, "name": "uWbFrSnU7d1Buhdw", "persistent": false, "preferredClaimKeys": ["T5cmw7U1TxiS06UE", "oaDZpXOWzpXOi2cp", "ajtqcXjPkj2IzU3M"], "requestedRegions": ["EpCt1IjlfHJM92t9", "j1XT2ErwIxkaTnYt", "r1YDnaXB0JOS4XKV"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "sHYPgVsfhoEidKw4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'IP0NVnaangorhVFp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateConfigurationTemplateV1' test.out

#- 20 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'TRuQyMroT2hNfKJ7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminDeleteConfigurationTemplateV1' test.out

#- 21 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'q8sifSPmYSsBxtyK' \
    --namespace $AB_NAMESPACE \
    --userId 'WssEn5VEvIMEB4pl' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetMemberActiveSession' test.out

#- 22 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "506fLCG6EAl7d3Ks"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name '65thtnjcMSw1J42f' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminReconcileMaxActiveSession' test.out

#- 23 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminGetDSMCConfiguration' test.out

#- 24 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'AdminSyncDSMCConfiguration' test.out

#- 25 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'thKUobas2CAlSxxV' \
    --dsPodName 'hDR9hlaznetBUGcQ' \
    --fromTime 'z2WvdiclkYGDL2ck' \
    --gameMode 'C9cdzaLnajQ8GnJp' \
    --isPersistent 'ALiddv9UUtG1tEEC' \
    --isSoftDeleted 'sm8xaDOz0tMlpFuJ' \
    --joinability 'VXo9s0JPG8cgjHQo' \
    --limit '18' \
    --matchPool 'HoLLyUnPTiCD0038' \
    --memberID 'or8wR0tuwIJnrSI2' \
    --offset '71' \
    --order '7cWWOgAs8ThMpAGI' \
    --orderBy 'apYftYZkBXiEhdiS' \
    --sessionID '41VBAEUvoBlbH02b' \
    --status 'obxtljIfHBgjP9on' \
    --statusV2 'bxFcxS2OZZfXO3Hk' \
    --toTime 'JTOPscPA2n25C1zE' \
    > test.out 2>&1
eval_tap $? 25 'AdminQueryGameSessions' test.out

#- 26 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"nAMGmFy7w6eqnMeK": {}, "Fo7U8Scr9xm68w7s": {}, "9RMx2hc45QX234xn": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminQueryGameSessionsByAttributes' test.out

#- 27 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["qlbRAPFQsca6n9vG", "ZTCCXQ2Lf7jtexB6", "13cbiJEUePVZQaoE"]}' > $TEMP_JSON_INPUT
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
    --sessionId '2zrpLuvrx96OOz45' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminSetDSReady' test.out

#- 29 AdminKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminKickGameSessionMember \
    --memberId 'vMiR3QYZJKVNlK8P' \
    --namespace $AB_NAMESPACE \
    --sessionId 'TaIXRWFTyA9MDnKG' \
    > test.out 2>&1
eval_tap $? 29 'AdminKickGameSessionMember' test.out

#- 30 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'Xqq7Zk705hOhenJi' \
    --namespace $AB_NAMESPACE \
    --sessionId '6dNVF7zwjXqlcD2L' \
    --statusType 'zaOwIF5tEsCwoAVc' \
    > test.out 2>&1
eval_tap $? 30 'AdminUpdateGameSessionMember' test.out

#- 31 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '59' \
    --order 'mjViKkKw4gHA4CaL' \
    > test.out 2>&1
eval_tap $? 31 'AdminGetListNativeSession' test.out

#- 32 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --isSoftDeleted 'sPqRsTdKzcKtkGcv' \
    --joinability 'n44NWse6VLPkM1VT' \
    --key 'rQBywhJ7lbBLw9xy' \
    --leaderID '1WQM5qUS8baUqkzS' \
    --limit '35' \
    --memberID 'QKuu2MWXpEpNjHWP' \
    --memberStatus 'cFSnM7GAvk19sXDi' \
    --offset '39' \
    --order 'hPVhRGX9xlUKhXI8' \
    --orderBy 'mL8OIhvP68xE68dz' \
    --partyID 'ohxhbej2caIIfkXD' \
    --value 'Y7jnhp3qY6T7TUEB' \
    > test.out 2>&1
eval_tap $? 32 'AdminQueryParties' test.out

#- 33 AdminDeleteBulkParties
# body param: body
echo '{"ids": ["otSNIwGhia6cqoWm", "nhtuzxir12r0VUWI", "0kJAczj5ApcsiEQ6"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkParties \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteBulkParties' test.out

#- 34 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'AdminGetPlatformCredentials' test.out

#- 35 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "5llgGnTHAsTCZa7x", "clientSecret": "E4nwGKlbPRxfucxo", "scope": "RKFLxxcL9SyuHbvR"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'AdminUpdatePlatformCredentials' test.out

#- 36 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'AdminDeletePlatformCredentials' test.out

#- 37 AdminDeletePlatformCredentialsByPlatformId
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentialsByPlatformId \
    --namespace $AB_NAMESPACE \
    --platformId 'XBOX' \
    > test.out 2>&1
eval_tap $? 37 'AdminDeletePlatformCredentialsByPlatformId' test.out

#- 38 AdminSyncPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminSyncPlatformCredentials \
    --namespace $AB_NAMESPACE \
    --platformId 'XBOX' \
    > test.out 2>&1
eval_tap $? 38 'AdminSyncPlatformCredentials' test.out

#- 39 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '90' \
    --userId 'CteueMOmYP4SgxAI' \
    > test.out 2>&1
eval_tap $? 39 'AdminGetRecentPlayer' test.out

#- 40 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --userId 'EbuMCz9J4dPRGzoQ' \
    > test.out 2>&1
eval_tap $? 40 'AdminGetRecentTeamPlayer' test.out

#- 41 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'LYIWPPZvyPupimCE' \
    > test.out 2>&1
eval_tap $? 41 'AdminReadSessionStorage' test.out

#- 42 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'NHEenqjRSxO9oZ0f' \
    > test.out 2>&1
eval_tap $? 42 'AdminDeleteUserSessionStorage' test.out

#- 43 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'CxLR0GfjwCmDrbDR' \
    --userId '0Q0ixpqYtkZuhL6q' \
    > test.out 2>&1
eval_tap $? 43 'AdminReadUserSessionStorage' test.out

#- 44 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'bAhRExsnbWSH45La' \
    > test.out 2>&1
eval_tap $? 44 'AdminQueryPlayerAttributes' test.out

#- 45 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'rTmOqto4OtwF9uPU' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetPlayerAttributes' test.out

#- 46 AdminSyncNativeSession
$CLI_EXE \
    --sn session \
    --op AdminSyncNativeSession \
    --namespace $AB_NAMESPACE \
    --userId 'AxerdIqWmOoMyYp2' \
    > test.out 2>&1
eval_tap $? 46 'AdminSyncNativeSession' test.out

#- 47 CreateGameSession
# body param: body
echo '{"appName": "tSrLxpJnj9JtgjWm", "attributes": {"jx1WuNQq4v8FnVzd": {}, "bNW1xuV7rVei1o9z": {}, "V6rhVfcQmLfEn5ZU": {}}, "autoJoin": false, "backfillTicketID": "KfDSGh3vQFPSYCi8", "clientVersion": "WEjR3wqpnMdSNskx", "configurationName": "hl3O3kGloooh7kL5", "customURLGRPC": "98P7F3IKhiNdx1V7", "deployment": "199NT7JTRFV3FxMl", "dsSource": "5Rw4YeHqWkG09iEA", "fallbackClaimKeys": ["FYWhow1WAwCs9Y0K", "OemhNPYUVA9mU8Uv", "ONyjv3GQuLHoQ6eh"], "inactiveTimeout": 76, "inviteTimeout": 76, "joinability": "z4qSPPQBDFQsvRHb", "matchPool": "GTC2ynue7Xk4uDF5", "maxPlayers": 25, "minPlayers": 48, "preferredClaimKeys": ["dakWJ2AsKf8UfQqT", "Q8v7gXyFuLFZViQb", "xYQvUyapo6FmMy6t"], "requestedRegions": ["ZYSCe7du68Ce6T4p", "YH3BPyFurT4p8zoR", "YG8WKTaUyB0UyrKK"], "serverName": "ulHUnompTrS7DIOa", "storage": {"leader": {"kX65w7RpxY6pd1QT": {}, "pFpaxbCjHSCXM7sL": {}, "1nnOoRIg7oSh4yVt": {}}}, "teams": [{"parties": [{"partyID": "tp53wasuHbA0keUo", "userIDs": ["mVCh681OMZFNRw8Y", "vLGLnB4xfqdHhPHA", "2ZbIvW1oxENH4MsV"]}, {"partyID": "lbCMc5hx0W14Skvo", "userIDs": ["vINegS29legebqGw", "ej59Ok8EM0OFW93F", "kJicmK6qeaDEm9bP"]}, {"partyID": "CS2a5WoOtwavdioa", "userIDs": ["djCN0lC0MZRZAvhZ", "7XQmcT57Hl2PvPOK", "vc25nnSLnEnv4ipA"]}], "userIDs": ["VJzPHM6kTwfu1vSD", "9gROMknwVRJfXHGB", "1r66lbNcbMIJEY0B"]}, {"parties": [{"partyID": "mpF215jJycJcSyXL", "userIDs": ["zU9Uqk079uhBLl4y", "z32RqkNzYSNYl4zv", "yD8SUZv2LFFZer6T"]}, {"partyID": "3W7TE5WdocKzvgr3", "userIDs": ["jBU2g8Eo7uAb4Hnd", "xqQYO14lFR2YtIb1", "fufxJiodJFjEbn1A"]}, {"partyID": "SMAiedHoYv6WmW9m", "userIDs": ["RXQwc5sfOZbgnCmU", "LqltV5xjjrXKhZOe", "kpygvRDCk0koCGDP"]}], "userIDs": ["fbiGdBQ5DNVJAgfA", "kD0w0H6QM5AsRnp9", "a7p0g0szNgC8yVFl"]}, {"parties": [{"partyID": "wGULKeMzn4sG6P5R", "userIDs": ["2lHU9mf9rzrxuxtx", "g98cDF1fsD5miAxH", "czgRu4VYjQq4VIVF"]}, {"partyID": "UqNPuW223zuUv8Sh", "userIDs": ["bYBe9hLKcN6myFUW", "f7IuLG63jl9rYXaE", "FcUySnsIREQUlwDt"]}, {"partyID": "2XB6DgoJm4dqrLVS", "userIDs": ["BWToF03dQYi0OxI4", "DZZd2V80fjN9CwM4", "qNT3awIjWoFCW5BT"]}], "userIDs": ["W9laFjsd7gSFkIVG", "nXJLeUdD8XNxAkoe", "Hk0BXouyKC6RnO4P"]}], "textChat": false, "ticketIDs": ["eNj0XYtINcOQIiLd", "vpuYVOAU9uuKPGNN", "6m8BLNzJxMR9F8QP"], "tieTeamsSessionLifetime": false, "type": "Uh3Fxn8VCvtdiiwN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'CreateGameSession' test.out

#- 48 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"MAdIodiW3hcYuKSR": {}, "kkKQKIVOduQwwDrB": {}, "npQpIKdlw0Q8Qm0l": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicQueryGameSessionsByAttributes' test.out

#- 49 PublicSessionJoinCode
# body param: body
echo '{"code": "pTupwpI0MCOROWHg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PublicSessionJoinCode' test.out

#- 50 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'nYO9A4NtX4m0L4BG' \
    > test.out 2>&1
eval_tap $? 50 'GetGameSessionByPodName' test.out

#- 51 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'xxcKUh2wepEjvh8s' \
    > test.out 2>&1
eval_tap $? 51 'GetGameSession' test.out

#- 52 UpdateGameSession
# body param: body
echo '{"attributes": {"TPE7JfL8ZG7IBiOp": {}, "vSKRmJcE8fHWU8tF": {}, "9Tj5DH9jDJgqZagf": {}}, "backfillTicketID": "9TfKsyiaqf0Vfidv", "clientVersion": "wpghGz92mfgwfewY", "deployment": "0DMU8QuojVb8QgdE", "fallbackClaimKeys": ["nIEDOXPqBEIQJ92j", "D6Oo7qDSKsqbeuvG", "haO0uibTsnrycsu5"], "inactiveTimeout": 87, "inviteTimeout": 31, "joinability": "9BFGk7WCNwFDvIhd", "matchPool": "x6Z0l07ceeKMsQFy", "maxPlayers": 6, "minPlayers": 59, "preferredClaimKeys": ["tXXQgiHJgjwpCxGE", "Bsc3HVarhLlwlmf1", "l5JhrQSpGlguvTEC"], "requestedRegions": ["efhiKKuc8Urg4atA", "NoOfyCbfBoH6zLgT", "sYmAw4mFyLcIq00V"], "teams": [{"parties": [{"partyID": "l8sxzC1fJxroZeNI", "userIDs": ["lbxAUeRUjUbaPklf", "Vic7zYJTjpmhWVBg", "TDm8IGJL3sEpnq2q"]}, {"partyID": "NgEjKMemoxx1k2s5", "userIDs": ["gW8zADPqu8PVXnN0", "xl48RoZbNL7cXCVa", "F9U1H9bQv7EybPwb"]}, {"partyID": "HEHxSPaGCQl5y1ge", "userIDs": ["keqHnzZfY22Z1SmI", "c5NTRyLbOzAYD5IH", "4deTFCDORAsuT0ls"]}], "userIDs": ["eQtOoohdBYhvvwsp", "KpEPUUxc2NKFB2qx", "CiWMNdvN9SDRKye6"]}, {"parties": [{"partyID": "n1t8RXF5qayS4UAM", "userIDs": ["JrRrnNfXdTnJz7e3", "tD8KVlMU17V03QDQ", "jU64lc3oek3RWXWJ"]}, {"partyID": "hPXvS9OmmtZ14XRO", "userIDs": ["PpbgqS9a9eP72cbS", "H4TvY6sMCkitXsNf", "i8EF3mgABwFe1N0Q"]}, {"partyID": "NeryssScV8w2rN40", "userIDs": ["y7aLOJoeZqRwJzTd", "Mg00KvHLdMiaje6w", "7YN9MWtYzurSMcK8"]}], "userIDs": ["c5xZukais9Topwzy", "VFe9lNT7v5QycBCx", "JG7DehSEc6kg2UWX"]}, {"parties": [{"partyID": "8dfboaqkOS5P8ije", "userIDs": ["U7ceEjsJO7xZUK7l", "MGDnKhxDxWqk0FyD", "BDBxAznXS1mfs6uZ"]}, {"partyID": "9OaZwm6pPAdF5lHM", "userIDs": ["HzBycY7bXyRpFUts", "9CpuTZNXAvR5mEjD", "Gi8Z9KuTHuT6IlIm"]}, {"partyID": "bAYCRvUBIHoIhUnq", "userIDs": ["8EtmzVPJFqDDsFmD", "KPixcJtgNHrTEQpF", "B5aeIMGxoyLMqSLD"]}], "userIDs": ["NxuBA95CXk3K2oLM", "yvJ6M0zKUQCLksfh", "WE1OiCOozFmZ3hzp"]}], "ticketIDs": ["ayQ1ySXmHgROq1X5", "e82zDrJtNcl4ztsa", "FwrylG42gHaf4XEH"], "tieTeamsSessionLifetime": true, "type": "YyNLgOIbDguxdqP6", "version": 4}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'u7ZUAbKsKi0fuipd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'UpdateGameSession' test.out

#- 53 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'vULHrqNhX3eWB4hf' \
    > test.out 2>&1
eval_tap $? 53 'DeleteGameSession' test.out

#- 54 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"A53Ibtklb9jB4Gcb": {}, "0L2EPZQmxEO4oKOc": {}, "sZUbeZJJJydenJ93": {}}, "backfillTicketID": "Kb1pQleHG1UoswJz", "clientVersion": "p9GPpGykMepZ0J4U", "deployment": "uZWR407SE9ddXzA6", "fallbackClaimKeys": ["F73IwV8d2jvk2NFE", "PFcj0B4pnGV0EaGD", "NAoaYeee5iUyPElT"], "inactiveTimeout": 17, "inviteTimeout": 25, "joinability": "9RQ9tNv9ZoFgoU8g", "matchPool": "eQqTHsgesxUdeb2F", "maxPlayers": 72, "minPlayers": 99, "preferredClaimKeys": ["bsqzkOO5TgVxhorx", "7Olr6yZsG5AHeXjx", "QCmc8jD3q7UouREP"], "requestedRegions": ["LDNt6Bi4udSrXnII", "tduiUuy8tq9HCTgL", "SuFiv2W3x38AyIWI"], "teams": [{"parties": [{"partyID": "iWAkZb55PmNf9MzO", "userIDs": ["CP7HO3NR5EmbWMmu", "HbWUeXEPRF6TjBh6", "iQOGSqSf29O4OCHr"]}, {"partyID": "6PHDU3g8gwrRCGr3", "userIDs": ["4cRXz9JsazgdXDoG", "shLr8yn7AoXGMgLG", "DEgjGR3AjETQmuBh"]}, {"partyID": "xdl2hmyNHx2EwggD", "userIDs": ["6ThfKbveaNPadM95", "4Klf9ScyQ3BkdgTB", "8XsRpozxyzQjkAwo"]}], "userIDs": ["iKpqCxRaxD64vrtL", "T4cBalVmLrDPUnoL", "1yIqAGPGIMNs07P3"]}, {"parties": [{"partyID": "5ZIntLvl9DQDCBJj", "userIDs": ["s12pGhuGLD6vHktU", "3ynqJffmZNfIZBEm", "g9ppW9kqHg6qWRr5"]}, {"partyID": "OGM3cUFnnf4mVneU", "userIDs": ["yBHCEsHoUz3vp9jp", "SUMWJyDVldaDNtR0", "AXW63sbPYTKP8EQu"]}, {"partyID": "pMajWTKw5FeR8ri3", "userIDs": ["yXrzd1ieTRurPzBS", "UlLhIUZaqDR1n6aK", "cCVL5Fd1b8wgnlhP"]}], "userIDs": ["7Pg5lC7Ea270WU05", "apXkWulzfNESEwZk", "xwcIoptsiG0JEo50"]}, {"parties": [{"partyID": "u4dtDARQghCkujmL", "userIDs": ["LnrNNSLh36UQbPSJ", "QQhceSla9ERYYip5", "g4u0MAPcVPH3gZ7B"]}, {"partyID": "L95xBXZ4Q2kZcVEt", "userIDs": ["lghVPGnqtFjbFAzl", "lHBMrW7hG67ye23P", "8DW1ccz649aMbZ9u"]}, {"partyID": "0Okl1IHd8Q5JqhDP", "userIDs": ["8ljUtdmP5zdR2WzZ", "26M7190BUUMJA2i5", "Q4vFfXwKGlPrvLQj"]}], "userIDs": ["EMxmStiAYcnCKHJa", "29YjFCGXPzxvGWXS", "YKxZFwAJdGF5bhjI"]}], "ticketIDs": ["1EEc3WV5k6IPw3lu", "GBMK9OmEmytZjYEi", "OxHZltYdZOiBafLm"], "tieTeamsSessionLifetime": true, "type": "cc3OUVUdC6vEQ0Fb", "version": 5}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'fOzSwVrTe2Pix8Ig' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'PatchUpdateGameSession' test.out

#- 55 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "OyJOxbfiuUDdzfJO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'veiGttirPw49eDkk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'UpdateGameSessionBackfillTicketID' test.out

#- 56 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'TlieINXiZneSGu4x' \
    > test.out 2>&1
eval_tap $? 56 'GameSessionGenerateCode' test.out

#- 57 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId '8wWgDhy2xaMbK98K' \
    > test.out 2>&1
eval_tap $? 57 'PublicRevokeGameSessionCode' test.out

#- 58 PublicGameSessionInvite
# body param: body
echo '{"metadata": {"ZuPAGpzW8YEovlYX": "MD76ZVrjTwBhG6Px", "RbXyacvJKvH2fI22": "7sFhXEPpERr10WrT", "TWC1vHxSVm1rRLDU": "orN8n8OKt3ebTMfm"}, "platformID": "V8RpXci3oXtKeXlM", "userID": "fYcKvIDQryhqRPwa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'SbAakeTI3GtLp33o' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicGameSessionInvite' test.out

#- 59 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '0hY1hJyjnnZKdSiF' \
    > test.out 2>&1
eval_tap $? 59 'JoinGameSession' test.out

#- 60 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "aVEfxNwD82TygHqJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'CY44tteOU73MUia8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicPromoteGameSessionLeader' test.out

#- 61 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '6OHeEezPfPVoLzua' \
    > test.out 2>&1
eval_tap $? 61 'LeaveGameSession' test.out

#- 62 PublicKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op PublicKickGameSessionMember \
    --memberId 'ilZgh0VftM4duhPO' \
    --namespace $AB_NAMESPACE \
    --sessionId 'P3T7IILgTKDtEBny' \
    > test.out 2>&1
eval_tap $? 62 'PublicKickGameSessionMember' test.out

#- 63 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'ydnlmrax9HkcVJkc' \
    > test.out 2>&1
eval_tap $? 63 'PublicGameSessionReject' test.out

#- 64 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'KNqoctZZip2UOwEp' \
    > test.out 2>&1
eval_tap $? 64 'GetSessionServerSecret' test.out

#- 65 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "VOojiniOJfBmQBpv", "userIDs": ["pDw5KbvwvhRu00Z9", "kQ6CfVEKuBGQj6IM", "6yC2yo6eKkz3So92"]}, {"partyID": "LmNHqeozPTvTyjHz", "userIDs": ["kSDJwI3p6udT5ywN", "YrZ3noFX2D35kjfY", "LmyJHWVmJhvzYUD7"]}, {"partyID": "tt15VYMNdywySdXR", "userIDs": ["VEBpthoAfzvXP7hf", "NyBM3W7FEjbI46oL", "ZUugcyZei70cPKSd"]}], "proposedTeams": [{"parties": [{"partyID": "QKPk36TgDFyRpEbk", "userIDs": ["RLet6qHFzUAAIA1y", "ZDTGyGcJrX2a98is", "rEnWec7CnvrRTjVF"]}, {"partyID": "QkVvDYodu7iPq7Dz", "userIDs": ["yrwyqgey4TDsTGVc", "n6u2Y8kRSlfFVNtT", "CFUDbhXFUMPgIsF2"]}, {"partyID": "FaJmavnpwvlN5bxb", "userIDs": ["3zVGiVgmTiYRqChq", "mGwszlQrWl9mqTkN", "4IEuQISWdQ728o1q"]}], "userIDs": ["clvhlm929zMAdlyX", "yqtmIwkhB1niuOHH", "kEMM2LdYulOoouVL"]}, {"parties": [{"partyID": "yY5l3zat0SbuB1wM", "userIDs": ["D51VeGbfpAAYyBbE", "y0fEmRKPynE1Ulth", "6WUsfyOIdVfGOJIP"]}, {"partyID": "b5iLNRM7JFauJ3tV", "userIDs": ["setZATTbB1ZGFmU2", "4Z5anp1Fr9PhX008", "zkRCTEr3CbX1jCvt"]}, {"partyID": "8SZQVAQVTEjLxRXX", "userIDs": ["w1Ba3BCLDK9EHH01", "9QefK1Zmj8WfGj2n", "DHeEHT96WiKFqOEu"]}], "userIDs": ["v5vimn63Casxqy2j", "ZLzE1twcaIT8fi9j", "XsmtxDfayxSlb89F"]}, {"parties": [{"partyID": "R48VT5BKwgRAIQHZ", "userIDs": ["N92VP4rbnVQ2wDVZ", "FHDmlKMyosJXwZbP", "6pG2cmQhEgLUgzcF"]}, {"partyID": "vsZ7ws7IsSADlM88", "userIDs": ["8Xt8E5iE51ruSZ15", "3e9fDb7M4vfe4Fyk", "Mi3Y9S70xe8Wk0MB"]}, {"partyID": "FmL9yc68k3c9GJsy", "userIDs": ["nFlhTJoB9DVDzdKc", "96qCUqhMuZYAzHXs", "COpjW3CTUUFdOJRH"]}], "userIDs": ["v7are1QWJddDrhoA", "aGO0c6aXoFM9JtzY", "ynQYA8i8PGEVFtDM"]}], "version": 80}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'GmUXScgZStYmu7rs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'AppendTeamGameSession' test.out

#- 66 PublicGameSessionCancel
$CLI_EXE \
    --sn session \
    --op PublicGameSessionCancel \
    --namespace $AB_NAMESPACE \
    --sessionId 'mI2iz8iDqES2enp5' \
    --userId 'QsuU2SzC5jPZ753V' \
    > test.out 2>&1
eval_tap $? 66 'PublicGameSessionCancel' test.out

#- 67 PublicPartyJoinCode
# body param: body
echo '{"code": "QLK9K4e0w5qc4U4Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicPartyJoinCode' test.out

#- 68 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'oFCFoWEdyIcgWElo' \
    > test.out 2>&1
eval_tap $? 68 'PublicGetParty' test.out

#- 69 PublicUpdateParty
# body param: body
echo '{"attributes": {"qldQTXf1RjwLWiMZ": {}, "tnXi3eLkvnj2FHRR": {}, "u0umwsxpdZ1WWgZK": {}}, "inactiveTimeout": 24, "inviteTimeout": 16, "joinability": "uL2AcsKLs4xA7pgT", "maxPlayers": 28, "minPlayers": 12, "type": "AOS7ZVDYbaZdRyWB", "version": 35}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'rjEfLoBc63d2CjPS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicUpdateParty' test.out

#- 70 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"t7u9HWKXy95GCrxr": {}, "JkGMw7ZL0l1KamHk": {}, "jtv5cJwGEcC7aGI9": {}}, "inactiveTimeout": 90, "inviteTimeout": 75, "joinability": "taa4kc8IEXb91iFI", "maxPlayers": 29, "minPlayers": 22, "type": "IbxIl5dUFT7bJ07W", "version": 74}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'dHNmowMhMKGNED5y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicPatchUpdateParty' test.out

#- 71 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'gPVLMM3usQQXneBG' \
    > test.out 2>&1
eval_tap $? 71 'PublicGeneratePartyCode' test.out

#- 72 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'j9AjnpSvpMEa0Lvq' \
    > test.out 2>&1
eval_tap $? 72 'PublicRevokePartyCode' test.out

#- 73 PublicPartyInvite
# body param: body
echo '{"metadata": {"2wnqyklrvhee7EeS": "qy9kO3ZjWNov1zjW", "KMDhaV2fsQ3DlrWT": "mYVuz6shya81WnWL", "IEMQX6yIuvLV2SAA": "8KoDH2te6X3S3HwJ"}, "platformID": "UMVxEYAqoGebWDx1", "userID": "rIY7YgqLazmwaTdH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId '4Cz8G7R8H7IL8v5O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'PublicPartyInvite' test.out

#- 74 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "1r7P5inUTEQGSKH2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'wQE3rMpBR96V4wCG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'PublicPromotePartyLeader' test.out

#- 75 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'hThbt8E3jI5UoWvq' \
    > test.out 2>&1
eval_tap $? 75 'PublicPartyJoin' test.out

#- 76 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'FZQoL3OUkQDJft6r' \
    > test.out 2>&1
eval_tap $? 76 'PublicPartyLeave' test.out

#- 77 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId '5a3gptbNLX0aELOa' \
    > test.out 2>&1
eval_tap $? 77 'PublicPartyReject' test.out

#- 78 PublicPartyCancel
$CLI_EXE \
    --sn session \
    --op PublicPartyCancel \
    --namespace $AB_NAMESPACE \
    --partyId '6N75cogVkZy2V8uO' \
    --userId 'MXE5zaiqfUuDbogZ' \
    > test.out 2>&1
eval_tap $? 78 'PublicPartyCancel' test.out

#- 79 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'iwydwzfWPCVvLLFN' \
    --userId 'SKl79V2ucJ4eDQyH' \
    > test.out 2>&1
eval_tap $? 79 'PublicPartyKick' test.out

#- 80 PublicCreateParty
# body param: body
echo '{"attributes": {"46uQbTHK5X3o94hU": {}, "U3uq7jQcfShtEtVr": {}, "2SVT1NiSinLANULf": {}}, "configurationName": "gmYSJIzEBkXmc2Fh", "inactiveTimeout": 36, "inviteTimeout": 47, "joinability": "y5W0iCFQFClD4Stf", "maxPlayers": 3, "members": [{"ID": "p7AU8haiJAyCejYV", "PlatformID": "pU1pdEtrpKrbVk9u", "PlatformUserID": "7GLgME7wGiU2biCX"}, {"ID": "BTngfX2J8YqvfwTh", "PlatformID": "Z7F6KgWP0pCW1LZj", "PlatformUserID": "ascU9sDwKvowvGWW"}, {"ID": "tzd8NYVjEQMiQNEK", "PlatformID": "qmY3Qc7Gush1JYbd", "PlatformUserID": "03QSrNZ2SbLcxoEq"}], "minPlayers": 18, "textChat": false, "type": "dEtbYSFJ0DhVUMO4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicCreateParty' test.out

#- 81 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '59' \
    > test.out 2>&1
eval_tap $? 81 'PublicGetRecentPlayer' test.out

#- 82 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    > test.out 2>&1
eval_tap $? 82 'PublicGetRecentTeamPlayer' test.out

#- 83 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"nFHrMfRpBHOax7TN": {}, "LzgW5GMdrZOdIXAH": {}, "BSS6r5wDG76qXHaJ": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'MuVALb1k6C0bGXPh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'PublicUpdateInsertSessionStorageLeader' test.out

#- 84 PublicUpdateInsertSessionStorage
# body param: body
echo '{"uWzOj8rGsEOgAyIS": {}, "0fMWqAlHrdUBriyI": {}, "rHLfx3OGuC3ijRNX": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'XURQ3ZzgpA1SdFF4' \
    --userId 'nsya3UXahzCQJ1Wd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'PublicUpdateInsertSessionStorage' test.out

#- 85 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["bN8PkJy1ez6rJd8R", "YLZhBzMFVvnbGszj", "KvFIRVDVtPCh4eQZ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 86 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 86 'PublicGetPlayerAttributes' test.out

#- 87 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "dxoJQJ6MzJyO3qDm", "data": {"tY3fCWcnjvSFQknk": {}, "XxhNoW5mCsWgJYsu": {}, "Rmy56HZgI5RRTsXQ": {}}, "platforms": [{"name": "nMWiRJCR1RHyZbcf", "userID": "k8YG7nYGowF23P0W"}, {"name": "Hgh0pChv4BAqsdhb", "userID": "bnkYPp9i7jjBIxJ1"}, {"name": "4Hmr0ApsK8SHyhul", "userID": "a1Q38F5Rpl7trQdm"}], "roles": ["2EdQlGL0OD4NuF1A", "Lr0GCUjtdTgD8swT", "LL8aCMo5By5GEOeZ"], "simultaneousPlatform": "EFaSvKATkfxrqTKl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'PublicStorePlayerAttributes' test.out

#- 88 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 88 'PublicDeletePlayerAttributes' test.out

#- 89 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'oycgLrjGXXeGSNb6' \
    --orderBy 'AefzMWkNyXXrlu7I' \
    --status 'TMZYSib8tq3AY6Fu' \
    > test.out 2>&1
eval_tap $? 89 'PublicQueryMyGameSessions' test.out

#- 90 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'ZYEssL3bB0tBK6SB' \
    --orderBy 'oElIIIpwn6hgBTwx' \
    --status 'Kcx0X8Lcx6NhMffZ' \
    > test.out 2>&1
eval_tap $? 90 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE