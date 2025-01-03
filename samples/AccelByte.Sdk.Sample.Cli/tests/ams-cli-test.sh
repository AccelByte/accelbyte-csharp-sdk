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
    --count '32' \
    --desc 'desc' \
    --name 'nnEckHH8kT9oXVan' \
    --offset '7' \
    --region 'CaS6qyUCscHXs8Pl' \
    --sortBy 'active' \
    > test.out 2>&1
eval_tap $? 17 'FleetList' test.out

#- 18 FleetCreate
# body param: body
echo '{"active": true, "claimKeys": ["aYEDxaYN8w9KUW0p", "y8KrcQfucSq2X8gF", "uJORk4j04YfnXTsQ"], "dsHostConfiguration": {"instanceId": "UrA0WWyKl2K5mCSo", "serversPerVm": 66}, "imageDeploymentProfile": {"commandLine": "dopcEM0JHfof2Hwi", "imageId": "7vg3osbh0fL2h7eJ", "portConfigurations": [{"name": "vAS2W4uqkhwSC7Ea", "protocol": "jwHO3LfvwPewrf19"}, {"name": "Njm50xCDlPeNq0Cv", "protocol": "MXtyUWXrdZaFeacG"}, {"name": "T2x6o28Njxyw7RHl", "protocol": "dq0m7NjUZ95Z5XDL"}], "timeout": {"claim": 56, "creation": 48, "drain": 82, "session": 28, "unresponsive": 85}}, "name": "YGVPtkjt0OyBlJi4", "onDemand": false, "regions": [{"bufferSize": 5, "dynamicBuffer": true, "maxServerCount": 23, "minServerCount": 26, "region": "w3veBfrpCrnbaxhE"}, {"bufferSize": 43, "dynamicBuffer": true, "maxServerCount": 27, "minServerCount": 34, "region": "3SGqcH91fC3aJEoq"}, {"bufferSize": 100, "dynamicBuffer": false, "maxServerCount": 15, "minServerCount": 64, "region": "4gq7pRVZVLJiDx3a"}], "samplingRules": {"coredumps": {"crashed": {"collect": true, "percentage": 40}}, "logs": {"crashed": {"collect": false, "percentage": 2}, "success": {"collect": true, "percentage": 19}, "unclaimed": {"collect": false, "percentage": 16}}}}' > $TEMP_JSON_INPUT
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
    --fleetID 'iMRkcOr1L0TMIczb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'FleetGet' test.out

#- 20 FleetUpdate
# body param: body
echo '{"active": false, "claimKeys": ["ilOziwG8CPLOzSZm", "9K3cMY617HSCYZaL", "46I3PgCcQ0axTWnm"], "dsHostConfiguration": {"instanceId": "yEYLZQTpvLH6QPEB", "serversPerVm": 85}, "imageDeploymentProfile": {"commandLine": "zYnrcetxObeisZel", "imageId": "KuD0iJ6fs3zL9H4W", "portConfigurations": [{"name": "xGWRH7fz4BdPhLtH", "protocol": "RJOImSq37aeAaGq0"}, {"name": "NIj53gXkmrayvcIY", "protocol": "iWxIAxfvLzSpDFY3"}, {"name": "lxe16KsSRzkf2HzB", "protocol": "cEio5UyvuFv5z6wo"}], "timeout": {"claim": 38, "creation": 45, "drain": 72, "session": 78, "unresponsive": 66}}, "name": "BcQUNPHN8YZT0yJJ", "onDemand": true, "regions": [{"bufferSize": 91, "dynamicBuffer": true, "maxServerCount": 43, "minServerCount": 18, "region": "j6DjUw36GtZ83Jp2"}, {"bufferSize": 11, "dynamicBuffer": true, "maxServerCount": 11, "minServerCount": 18, "region": "1FCoIo3L24DKGwgZ"}, {"bufferSize": 54, "dynamicBuffer": false, "maxServerCount": 45, "minServerCount": 51, "region": "G6OrPH6ZsjpPgHKI"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 68}}, "logs": {"crashed": {"collect": true, "percentage": 72}, "success": {"collect": true, "percentage": 7}, "unclaimed": {"collect": true, "percentage": 39}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'YS9K0VvwE6MAqPc8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'FleetUpdate' test.out

#- 21 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'lGIYWTwxyqQQIXVm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'FleetDelete' test.out

#- 22 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID 'rtRlq1jv60HTnmFr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'FleetArtifactSamplingRulesGet' test.out

#- 23 FleetArtifactSamplingRulesSet
# body param: body
echo '{"coredumps": {"crashed": {"collect": false, "percentage": 35}}, "logs": {"crashed": {"collect": false, "percentage": 12}, "success": {"collect": true, "percentage": 86}, "unclaimed": {"collect": true, "percentage": 65}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesSet \
    --fleetID '6Xmv1DzPHux3k3sk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'FleetArtifactSamplingRulesSet' test.out

#- 24 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID 'hn3mWZjTYM95e4aa' \
    --namespace $AB_NAMESPACE \
    --count '92' \
    --offset '47' \
    --region 'aZw4NqSNylcljuNM' \
    --serverId '3eUUSD1pZGMfPdGI' \
    --sortBy 'OAZ86un0L98WUoXv' \
    --sortDirection 'asc' \
    --status 'ready' \
    > test.out 2>&1
eval_tap $? 24 'FleetServers' test.out

#- 25 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID 'W8SUaZjCpNtJSMm8' \
    --namespace $AB_NAMESPACE \
    --count '21' \
    --offset '60' \
    --reason 'btdK2r4wWs6IpYBx' \
    --region 'afo9b4xJyNnvHKrm' \
    --serverId '8UuNlT86N9yO0vyD' \
    --sortDirection '6J5brVo20e6POTjr' \
    --status 'inAVVovpAAXNzcpb' \
    > test.out 2>&1
eval_tap $? 25 'FleetServerHistory' test.out

#- 26 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    --count '26' \
    --inUse '2DNbknfVv4nm70TC' \
    --isProtected 'false' \
    --name 'K81t2V9TVauFcGkP' \
    --offset '13' \
    --sortBy 'U5CwqGJF6nDi33Iz' \
    --sortDirection 'tr2QcwlRrReRajlp' \
    --status 'k8lfuiJVcktlx9zJ' \
    --tag 'ZVVCc9bpIHEWQMmC' \
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
    --imageID 'kIqwqpoTVCNrcaVo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'ImageGet' test.out

#- 29 ImageMarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageMarkForDeletion \
    --imageID 'zsjIXO2EUsAfBvo6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'ImageMarkForDeletion' test.out

#- 30 ImagePatch
# body param: body
echo '{"addedTags": ["Llcalks2R3VMtipT", "VxXAF8KhOKqbrECi", "jFxOpOzxeTLJQsZc"], "isProtected": true, "name": "hPPG5sAIfYtYozA2", "removedTags": ["OntGCwQSHHdPLwjT", "ngrvb2E1X9ecBBhR", "AYjR7c4x5bIk8pVp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID 'xdUWOPel3TiwTycq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'ImagePatch' test.out

#- 31 ImageUnmarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageUnmarkForDeletion \
    --imageID 'pVdINXzvkSp0Wbvx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ImageUnmarkForDeletion' test.out

#- 32 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'QWI0QGCOx7eICkau' \
    > test.out 2>&1
eval_tap $? 32 'QoSRegionsGet' test.out

#- 33 QoSRegionsUpdate
# body param: body
echo '{"status": "WbFrSnU7d1Buhdwl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'iTSDdmGVfegiD3mr' \
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
    --serverID 'VQaUr3oT88Dfc711' \
    > test.out 2>&1
eval_tap $? 35 'FleetServerInfo' test.out

#- 36 FleetServerConnectionInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerConnectionInfo \
    --namespace $AB_NAMESPACE \
    --serverID '4QFGwTzBVDg5v71k' \
    > test.out 2>&1
eval_tap $? 36 'FleetServerConnectionInfo' test.out

#- 37 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'GCEt7h1mVwIQCJmQ' \
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
echo '{"region": "kvWbQrn2W0VkOF0p", "sessionId": "QOY0UCcViiFKNjkT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID '5hcONCaOyATBFgqL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'FleetClaimByID' test.out

#- 41 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'eAzvdcUEhWRo6ROv' \
    > test.out 2>&1
eval_tap $? 41 'LocalWatchdogConnect' test.out

#- 42 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["buPQwl9dVfJQGkDR", "00ofXsbnEzHiRs0N", "mGhxv1vuN7Xv6OuG"], "regions": ["6RR1jPh8RblvnfNi", "ABRf1gdXM7QlAlnj", "AfgxOdZdf9tLHO1q"], "sessionId": "rNyhmUEADczzrL31"}' > $TEMP_JSON_INPUT
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
    --watchdogID 'HuYKsCBBgwb1hGjH' \
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