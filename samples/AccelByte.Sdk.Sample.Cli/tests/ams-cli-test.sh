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
echo "1..46"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AuthCheck
$CLI_EXE \
    --sn ams \
    --op AuthCheck \
    > test.out 2>&1
eval_tap $? 2 'AuthCheck' test.out

#- 3 PortalHealthCheck
$CLI_EXE \
    --sn ams \
    --op PortalHealthCheck \
    > test.out 2>&1
eval_tap $? 3 'PortalHealthCheck' test.out

#- 4 AdminAccountGet
$CLI_EXE \
    --sn ams \
    --op AdminAccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminAccountGet' test.out

#- 5 AdminAccountCreate
# body param: body
echo '{"name": "bBuz5zkoaUEzGS3q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AdminAccountCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminAccountCreate' test.out

#- 6 AdminAccountLinkTokenGet
$CLI_EXE \
    --sn ams \
    --op AdminAccountLinkTokenGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminAccountLinkTokenGet' test.out

#- 7 AdminAccountLinkTokenPost
# body param: body
echo '{"token": "Zf0PbemSBELbZ0VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AdminAccountLinkTokenPost \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminAccountLinkTokenPost' test.out

#- 8 ArtifactGet
$CLI_EXE \
    --sn ams \
    --op ArtifactGet \
    --namespace $AB_NAMESPACE \
    --artifactType 'UGA7nkDeev2Oj060' \
    --count '277' \
    --endDate 'WV6dIabcFbSmeuIB' \
    --fleetID 'roF7bwRgwKvzESbh' \
    --imageID 'pxlDdEs4igdKeLmy' \
    --maxSize '95' \
    --minSize '40' \
    --offset '56' \
    --region 'Z5GZi5P12c61ts3f' \
    --serverId 'MI04rm2jUc9iav3t' \
    --startDate 'TqlE9oLDPD0Lfle8' \
    --status 'ESU1MO8XnVaEyjmi' \
    > test.out 2>&1
eval_tap $? 8 'ArtifactGet' test.out

#- 9 ArtifactBulkDelete
$CLI_EXE \
    --sn ams \
    --op ArtifactBulkDelete \
    --namespace $AB_NAMESPACE \
    --artifactType 'fJDYa1TJPUszmFGE' \
    --fleetId 'kJVvqDSU3PDyIAGf' \
    --uploadedBefore '1987-05-13' \
    > test.out 2>&1
eval_tap $? 9 'ArtifactBulkDelete' test.out

#- 10 ArtifactUsageGet
$CLI_EXE \
    --sn ams \
    --op ArtifactUsageGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'ArtifactUsageGet' test.out

#- 11 ArtifactDelete
$CLI_EXE \
    --sn ams \
    --op ArtifactDelete \
    --artifactID 'q1FNmRWvUvDPnKoE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'ArtifactDelete' test.out

#- 12 ArtifactGetURL
$CLI_EXE \
    --sn ams \
    --op ArtifactGetURL \
    --artifactID 'CjGUg867xodwuG14' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ArtifactGetURL' test.out

#- 13 DevelopmentServerConfigurationList
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationList \
    --namespace $AB_NAMESPACE \
    --count '298' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 13 'DevelopmentServerConfigurationList' test.out

#- 14 DevelopmentServerConfigurationCreate
# body param: body
echo '{"commandLineArguments": "D5l5wj6K2wEMnckj", "imageId": "lW6BywsSSZTGlubs", "name": "mhjXcScOUvrjJBO7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'DevelopmentServerConfigurationCreate' test.out

#- 15 DevelopmentServerConfigurationGet
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationGet \
    --developmentServerConfigID 'tbkTGYKqRMSTisP0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DevelopmentServerConfigurationGet' test.out

#- 16 DevelopmentServerConfigurationDelete
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationDelete \
    --developmentServerConfigID 'MrSdaFy0pJYCdfkf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DevelopmentServerConfigurationDelete' test.out

#- 17 FleetList
$CLI_EXE \
    --sn ams \
    --op FleetList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'FleetList' test.out

#- 18 FleetCreate
# body param: body
echo '{"active": true, "claimKeys": ["IHPIbOjpls9BZTYc", "5BsdSSVaAzzn4Gbg", "kKeCaS6qyUCscHXs"], "dsHostConfiguration": {"instanceId": "8PlOBlfUOqv7WmCu", "instanceType": "qcsNM7YAnbq4DjmY", "serversPerVm": 96}, "imageDeploymentProfile": {"commandLine": "X8gFuJORk4j04Yfn", "imageId": "XTsQUrA0WWyKl2K5", "portConfigurations": [{"name": "mCSoGeQCahcox63c", "protocol": "yDxAAYcRXJdoSTxN"}, {"name": "CK9AIjNmbfoW8bDq", "protocol": "5jPqzhN0YdGSrA9L"}, {"name": "XRwU6WLgpQE9nXzh", "protocol": "BC0uyMR4Xf2nfYvN"}], "timeout": {"creation": 44, "drain": 8, "session": 67, "unresponsive": 1}}, "name": "8uQ14AhsxaALiBwp", "onDemand": false, "regions": [{"bufferSize": 30, "dynamicBuffer": false, "maxServerCount": 35, "minServerCount": 33, "region": "nrCQpMJj5igqat8x"}, {"bufferSize": 28, "dynamicBuffer": false, "maxServerCount": 66, "minServerCount": 100, "region": "VPtkjt0OyBlJi4Rb"}, {"bufferSize": 66, "dynamicBuffer": true, "maxServerCount": 23, "minServerCount": 26, "region": "w3veBfrpCrnbaxhE"}], "samplingRules": {"coredumps": {"crashed": {"collect": true, "percentage": 55}, "success": {"collect": false, "percentage": 34}}, "logs": {"crashed": {"collect": true, "percentage": 61}, "success": {"collect": false, "percentage": 40}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'FleetCreate' test.out

#- 19 FleetGet
$CLI_EXE \
    --sn ams \
    --op FleetGet \
    --fleetID 'H91fC3aJEoqWaFAG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'FleetGet' test.out

#- 20 FleetUpdate
# body param: body
echo '{"active": true, "claimKeys": ["7pRVZVLJiDx3au9b", "9QjhzDlnJmi4XaBT", "goXjfdUQHa3RxspS"], "dsHostConfiguration": {"instanceId": "qwdbTR2sgzfaQrUC", "instanceType": "W9fgo69uv1bkFx8D", "serversPerVm": 25}, "imageDeploymentProfile": {"commandLine": "TWnmyEYLZQTpvLH6", "imageId": "QPEBP8kSSFjeuL3w", "portConfigurations": [{"name": "QQPYwmYFbxRvHYDC", "protocol": "YwoGdmzXgf1ewUTv"}, {"name": "nu0ensa3MZF7DTsw", "protocol": "nkSyuJTVjKQ1ORLE"}, {"name": "IAePvDO2xkVgyRk1", "protocol": "0b27RdU8VceYQ9er"}], "timeout": {"creation": 86, "drain": 69, "session": 87, "unresponsive": 53}}, "name": "5yVcQuvDbGMqbEHk", "onDemand": true, "regions": [{"bufferSize": 29, "dynamicBuffer": true, "maxServerCount": 45, "minServerCount": 72, "region": "MBcQUNPHN8YZT0yJ"}, {"bufferSize": 72, "dynamicBuffer": true, "maxServerCount": 91, "minServerCount": 58, "region": "uj6DjUw36GtZ83Jp"}, {"bufferSize": 58, "dynamicBuffer": false, "maxServerCount": 91, "minServerCount": 47, "region": "f1FCoIo3L24DKGwg"}], "samplingRules": {"coredumps": {"crashed": {"collect": true, "percentage": 10}, "success": {"collect": true, "percentage": 51}}, "logs": {"crashed": {"collect": true, "percentage": 84}, "success": {"collect": false, "percentage": 68}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'uQBLVu27iwplLJdz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'FleetUpdate' test.out

#- 21 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'YS9K0VvwE6MAqPc8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'FleetDelete' test.out

#- 22 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID 'lGIYWTwxyqQQIXVm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'FleetArtifactSamplingRulesGet' test.out

#- 23 FleetArtifactSamplingRulesSet
# body param: body
echo '{"coredumps": {"crashed": {"collect": true, "percentage": 73}, "success": {"collect": true, "percentage": 93}}, "logs": {"crashed": {"collect": false, "percentage": 22}, "success": {"collect": true, "percentage": 56}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesSet \
    --fleetID '1jv60HTnmFrl3gYx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'FleetArtifactSamplingRulesSet' test.out

#- 24 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID '6Xmv1DzPHux3k3sk' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'FleetServers' test.out

#- 25 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID 'hn3mWZjTYM95e4aa' \
    --namespace $AB_NAMESPACE \
    --count '92' \
    --offset '47' \
    --reason 'aZw4NqSNylcljuNM' \
    --region '3eUUSD1pZGMfPdGI' \
    --serverId 'OAZ86un0L98WUoXv' \
    --sortDirection 'fU4qMIpfgxw2ff5t' \
    --status 'wRYbtdK2r4wWs6Ip' \
    > test.out 2>&1
eval_tap $? 25 'FleetServerHistory' test.out

#- 26 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'ImageList' test.out

#- 27 ImagesStorage
$CLI_EXE \
    --sn ams \
    --op ImagesStorage \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'ImagesStorage' test.out

#- 28 ImageGet
$CLI_EXE \
    --sn ams \
    --op ImageGet \
    --imageID 'YBxafo9b4xJyNnvH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'ImageGet' test.out

#- 29 ImageMarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageMarkForDeletion \
    --imageID 'Krm8UuNlT86N9yO0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'ImageMarkForDeletion' test.out

#- 30 ImagePatch
# body param: body
echo '{"addedTags": ["vyD6J5brVo20e6PO", "TjrinAVVovpAAXNz", "cpbmX3lLFeXCiaXP"], "isProtected": false, "name": "TCayYAkF18YBwRxc", "removedTags": ["REyU5CwqGJF6nDi3", "3Iztr2QcwlRrReRa", "jlpk8lfuiJVcktlx"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID '9zJZVVCc9bpIHEWQ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'ImagePatch' test.out

#- 31 ImageUnmarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageUnmarkForDeletion \
    --imageID 'MmCkIqwqpoTVCNrc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ImageUnmarkForDeletion' test.out

#- 32 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'aVozsjIXO2EUsAfB' \
    > test.out 2>&1
eval_tap $? 32 'QoSRegionsGet' test.out

#- 33 QoSRegionsUpdate
# body param: body
echo '{"status": "vo6Llcalks2R3VMt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'ipTVxXAF8KhOKqbr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'QoSRegionsUpdate' test.out

#- 34 InfoRegions
$CLI_EXE \
    --sn ams \
    --op InfoRegions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'InfoRegions' test.out

#- 35 FleetServerInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'ECijFxOpOzxeTLJQ' \
    > test.out 2>&1
eval_tap $? 35 'FleetServerInfo' test.out

#- 36 FleetServerConnectionInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerConnectionInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'sZcTEzXaXUzpsAV6' \
    > test.out 2>&1
eval_tap $? 36 'FleetServerConnectionInfo' test.out

#- 37 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'ct6XITL0QEkadMSQ' \
    > test.out 2>&1
eval_tap $? 37 'ServerHistory' test.out

#- 38 InfoSupportedInstances
$CLI_EXE \
    --sn ams \
    --op InfoSupportedInstances \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'InfoSupportedInstances' test.out

#- 39 AccountGet
$CLI_EXE \
    --sn ams \
    --op AccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'AccountGet' test.out

#- 40 FleetClaimByID
# body param: body
echo '{"region": "luAoED9oYwS8oLyE", "sessionId": "rKvRtHFGJRoGW7VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'G1VB2sp2x9mszGGo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'FleetClaimByID' test.out

#- 41 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'yhGZAzt2OVBTLwSH' \
    > test.out 2>&1
eval_tap $? 41 'LocalWatchdogConnect' test.out

#- 42 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["8hWRU9pbItGQ7VUW", "BhGolwafIfbF1GLF", "nrQ4T5cmw7U1TxiS"], "regions": ["06UEoaDZpXOWzpXO", "i2cpajtqcXjPkj2I", "zU3MEpCt1IjlfHJM"], "sessionId": "92t9j1XT2ErwIxka"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByKeys \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'FleetClaimByKeys' test.out

#- 43 WatchdogConnect
$CLI_EXE \
    --sn ams \
    --op WatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'TnYtr1YDnaXB0JOS' \
    > test.out 2>&1
eval_tap $? 43 'WatchdogConnect' test.out

#- 44 UploadURLGet
$CLI_EXE \
    --sn ams \
    --op UploadURLGet \
    > test.out 2>&1
eval_tap $? 44 'UploadURLGet' test.out

#- 45 Func1
$CLI_EXE \
    --sn ams \
    --op Func1 \
    > test.out 2>&1
eval_tap $? 45 'Func1' test.out

#- 46 BasicHealthCheck
$CLI_EXE \
    --sn ams \
    --op BasicHealthCheck \
    > test.out 2>&1
eval_tap $? 46 'BasicHealthCheck' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE