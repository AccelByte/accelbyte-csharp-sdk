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

#- 7 AdminAccountLink
# body param: body
echo '{"token": "Zf0PbemSBELbZ0VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AdminAccountLink \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminAccountLink' test.out

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
    --sortBy 'TqlE9oLDPD0Lfle8' \
    --sortDirection 'desc' \
    --startDate 'z1KJmKedBfbWvKa5' \
    --status 'Ou124TsbQsxYFxGG' \
    > test.out 2>&1
eval_tap $? 8 'ArtifactGet' test.out

#- 9 ArtifactBulkDelete
$CLI_EXE \
    --sn ams \
    --op ArtifactBulkDelete \
    --namespace $AB_NAMESPACE \
    --artifactType 'HrfQkgXkiA5IZPqC' \
    --fleetId 'qp9vcyt67WAfWXfU' \
    --uploadedBefore '1973-08-23' \
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
    --artifactID 'wGB03tz8qIH4uRdN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'ArtifactDelete' test.out

#- 12 ArtifactGetURL
$CLI_EXE \
    --sn ams \
    --op ArtifactGetURL \
    --artifactID 'O08HN6s9p8Y5c9eI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ArtifactGetURL' test.out

#- 13 DevelopmentServerConfigurationList
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationList \
    --namespace $AB_NAMESPACE \
    --count '167' \
    --offset '23' \
    > test.out 2>&1
eval_tap $? 13 'DevelopmentServerConfigurationList' test.out

#- 14 DevelopmentServerConfigurationCreate
# body param: body
echo '{"commandLineArguments": "JtiNmY3y3n2Rim4N", "expiresAt": "1985-03-03T00:00:00Z", "imageId": "qhuNtj8FOvKZjs1t", "name": "LpERf77LzPoORBkR"}' > $TEMP_JSON_INPUT
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
    --developmentServerConfigID 'mZ0A2zyZsb4FvWFI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DevelopmentServerConfigurationGet' test.out

#- 16 DevelopmentServerConfigurationDelete
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationDelete \
    --developmentServerConfigID 'HPIbOjpls9BZTYc5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DevelopmentServerConfigurationDelete' test.out

#- 17 FleetList
$CLI_EXE \
    --sn ams \
    --op FleetList \
    --namespace $AB_NAMESPACE \
    --active 'true' \
    --name 'pnnEckHH8kT9oXVa' \
    --region 'ndercf1nq4Hf32SL' \
    > test.out 2>&1
eval_tap $? 17 'FleetList' test.out

#- 18 FleetCreate
# body param: body
echo '{"active": false, "claimKeys": ["PjaYEDxaYN8w9KUW", "0py8KrcQfucSq2X8", "gFuJORk4j04YfnXT"], "dsHostConfiguration": {"instanceId": "sQUrA0WWyKl2K5mC", "serversPerVm": 90}, "imageDeploymentProfile": {"commandLine": "efdopcEM0JHfof2H", "imageId": "wi7vg3osbh0fL2h7", "portConfigurations": [{"name": "eJvAS2W4uqkhwSC7", "protocol": "EajwHO3LfvwPewrf"}, {"name": "19Njm50xCDlPeNq0", "protocol": "CvMXtyUWXrdZaFea"}, {"name": "cGT2x6o28Njxyw7R", "protocol": "Hldq0m7NjUZ95Z5X"}], "timeout": {"claim": 61, "creation": 41, "drain": 78, "session": 56, "unresponsive": 48}}, "name": "N9YGVPtkjt0OyBlJ", "onDemand": false, "regions": [{"bufferSize": 68, "dynamicBuffer": false, "maxServerCount": 90, "minServerCount": 86, "region": "bZ0Iy11mfOFjCzZV"}, {"bufferSize": 4, "dynamicBuffer": true, "maxServerCount": 67, "minServerCount": 26, "region": "omWF1oAqUNFDtXnX"}, {"bufferSize": 77, "dynamicBuffer": true, "maxServerCount": 44, "minServerCount": 82, "region": "aJEoqWaFAGD6PRg9"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 73}}, "logs": {"crashed": {"collect": false, "percentage": 60}, "success": {"collect": false, "percentage": 48}, "unclaimed": {"collect": false, "percentage": 44}}}}' > $TEMP_JSON_INPUT
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
    --fleetID 'u9b9QjhzDlnJmi4X' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'FleetGet' test.out

#- 20 FleetUpdate
# body param: body
echo '{"active": false, "claimKeys": ["TMIczbYilOziwG8C", "PLOzSZm9K3cMY617", "HSCYZaL46I3PgCcQ"], "dsHostConfiguration": {"instanceId": "0axTWnmyEYLZQTpv", "serversPerVm": 77}, "imageDeploymentProfile": {"commandLine": "uMcAwrSzYnrcetxO", "imageId": "beisZelKuD0iJ6fs", "portConfigurations": [{"name": "3zL9H4WxGWRH7fz4", "protocol": "BdPhLtHRJOImSq37"}, {"name": "aeAaGq0NIj53gXkm", "protocol": "rayvcIYiWxIAxfvL"}, {"name": "zSpDFY3lxe16KsSR", "protocol": "zkf2HzBcEio5Uyvu"}], "timeout": {"claim": 65, "creation": 33, "drain": 44, "session": 3, "unresponsive": 63}}, "name": "z6wosJGnUyCMEbHh", "onDemand": true, "regions": [{"bufferSize": 94, "dynamicBuffer": true, "maxServerCount": 49, "minServerCount": 61, "region": "JJ0uCjjaNCRV3hSI"}, {"bufferSize": 18, "dynamicBuffer": true, "maxServerCount": 72, "minServerCount": 30, "region": "p2f9f1FCoIo3L24D"}, {"bufferSize": 75, "dynamicBuffer": false, "maxServerCount": 67, "minServerCount": 87, "region": "wgZ85vyFJR8euQBL"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 41}}, "logs": {"crashed": {"collect": false, "percentage": 69}, "success": {"collect": false, "percentage": 74}, "unclaimed": {"collect": true, "percentage": 71}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'plLJdzYS9K0VvwE6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'FleetUpdate' test.out

#- 21 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'MAqPc8lGIYWTwxyq' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'FleetDelete' test.out

#- 22 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID 'QQIXVmrtRlq1jv60' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'FleetArtifactSamplingRulesGet' test.out

#- 23 FleetArtifactSamplingRulesSet
# body param: body
echo '{"coredumps": {"crashed": {"collect": false, "percentage": 12}}, "logs": {"crashed": {"collect": false, "percentage": 64}, "success": {"collect": true, "percentage": 60}, "unclaimed": {"collect": false, "percentage": 35}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesSet \
    --fleetID '3gYx6Xmv1DzPHux3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'FleetArtifactSamplingRulesSet' test.out

#- 24 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID 'k3skhn3mWZjTYM95' \
    --namespace $AB_NAMESPACE \
    --count '9' \
    --offset '89' \
    --region 'aa8xOJu7rNRVdygf' \
    --serverId 'KmUkzj9mHFpff2vD' \
    --sortBy 'kz68zorEgcExv9nK' \
    --sortDirection 'asc' \
    --status 'ready' \
    > test.out 2>&1
eval_tap $? 24 'FleetServers' test.out

#- 25 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID 'XvfU4qMIpfgxw2ff' \
    --namespace $AB_NAMESPACE \
    --count '80' \
    --offset '40' \
    --reason 'm8kDi3Rwubq7wtRG' \
    --region 'dT447Oa51m6VLfjs' \
    --serverId 'w270pMmOQJrpEBbV' \
    --sortDirection 'vBn8Lsf2qSAtizV9' \
    --status 'hzsVbpJLtEZjuyFh' \
    > test.out 2>&1
eval_tap $? 25 'FleetServerHistory' test.out

#- 26 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    --count '45' \
    --inUse 'cpbmX3lLFeXCiaXP' \
    --isProtected 'false' \
    --name 'TCayYAkF18YBwRxc' \
    --offset '88' \
    --sortBy 'kPgQ0hb2tLrsMeoZ' \
    --sortDirection 'iRYkbhEM1zTNY3lp' \
    --status 'incuf5d5saQvKfFR' \
    --tag 'qBam8jPtKHTmzo0J' \
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
    --imageID 'mcQmnsUigVynjGFy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'ImageGet' test.out

#- 29 ImageMarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageMarkForDeletion \
    --imageID 'VicGQAVv32ftRAsm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'ImageMarkForDeletion' test.out

#- 30 ImagePatch
# body param: body
echo '{"addedTags": ["C0RuRA8j1AJ3hNWW", "hADRqJvaZrf2qXQF", "CzRV1paELj5dw3LK"], "isProtected": false, "name": "cTEzXaXUzpsAV6ct", "removedTags": ["6XITL0QEkadMSQlu", "AoED9oYwS8oLyErK", "vRtHFGJRoGW7VBG1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID 'VB2sp2x9mszGGoyh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'ImagePatch' test.out

#- 31 ImageUnmarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageUnmarkForDeletion \
    --imageID 'GZAzt2OVBTLwSH8h' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ImageUnmarkForDeletion' test.out

#- 32 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'WRU9pbItGQ7VUWBh' \
    > test.out 2>&1
eval_tap $? 32 'QoSRegionsGet' test.out

#- 33 QoSRegionsUpdate
# body param: body
echo '{"status": "GolwafIfbF1GLFnr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'Q4T5cmw7U1TxiS06' \
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
    --serverID 'UEoaDZpXOWzpXOi2' \
    > test.out 2>&1
eval_tap $? 35 'FleetServerInfo' test.out

#- 36 FleetServerConnectionInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerConnectionInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'cpajtqcXjPkj2IzU' \
    > test.out 2>&1
eval_tap $? 36 'FleetServerConnectionInfo' test.out

#- 37 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID '3MEpCt1IjlfHJM92' \
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
echo '{"region": "t9j1XT2ErwIxkaTn", "sessionId": "Ytr1YDnaXB0JOS4X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'KVT66sHYPgVsfhoE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'FleetClaimByID' test.out

#- 41 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'idKw4IP0NVnaango' \
    > test.out 2>&1
eval_tap $? 41 'LocalWatchdogConnect' test.out

#- 42 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["rhVFpTRuQyMroT2h", "NfKJ7q8sifSPmYSs", "BxtyKWssEn5VEvIM"], "regions": ["EB4pl506fLCG6EAl", "7d3Ks65thtnjcMSw", "1J42fthKUobas2CA"], "sessionId": "lSxxVhDR9hlaznet"}' > $TEMP_JSON_INPUT
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
    --watchdogID 'BUGcQz2WvdiclkYG' \
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