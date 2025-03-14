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
    --name 'sdSSVaAzzn4GbgkK' \
    --offset '9' \
    --region 'dercf1nq4Hf32SL5' \
    --sortBy 'active' \
    --sortDirection 'desc' \
    > test.out 2>&1
eval_tap $? 17 'FleetList' test.out

#- 18 FleetCreate
# body param: body
echo '{"active": false, "claimKeys": ["lfUOqv7WmCuqcsNM", "7YAnbq4DjmYUMhD9", "qU89D356pVsUtNan"], "dsHostConfiguration": {"instanceId": "ddzgwxYdQc5hEfef", "serversPerVm": 6}, "fallbackFleet": "eQCahcox63cyDxAA", "imageDeploymentProfile": {"commandLine": "YcRXJdoSTxNCK9AI", "imageId": "jNmbfoW8bDq5jPqz", "portConfigurations": [{"name": "hN0YdGSrA9LXRwU6", "protocol": "WLgpQE9nXzhBC0uy"}, {"name": "MR4Xf2nfYvNvG8uQ", "protocol": "14AhsxaALiBwpNJo"}, {"name": "rnrCQpMJj5igqat8", "protocol": "xnPoWTdHAkcyAy4d"}], "timeout": {"claim": 35, "creation": 17, "drain": 68, "session": 22, "unresponsive": 90}}, "name": "PcXGGl0Xw3veBfrp", "onDemand": true, "regions": [{"bufferSize": 4, "dynamicBuffer": true, "maxServerCount": 67, "minServerCount": 26, "region": "omWF1oAqUNFDtXnX"}, {"bufferSize": 77, "dynamicBuffer": true, "maxServerCount": 44, "minServerCount": 82, "region": "aJEoqWaFAGD6PRg9"}, {"bufferSize": 77, "dynamicBuffer": false, "maxServerCount": 73, "minServerCount": 16, "region": "7l03vtlMFzeiMRkc"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 35}}, "logs": {"crashed": {"collect": false, "percentage": 77}, "success": {"collect": false, "percentage": 94}, "unclaimed": {"collect": true, "percentage": 79}}}}' > $TEMP_JSON_INPUT
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
    --fleetID 'TgoXjfdUQHa3Rxsp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'FleetGet' test.out

#- 20 FleetUpdate
# body param: body
echo '{"active": true, "claimKeys": ["zSZm9K3cMY617HSC", "YZaL46I3PgCcQ0ax", "TWnmyEYLZQTpvLH6"], "dsHostConfiguration": {"instanceId": "QPEBP8kSSFjeuL3w", "serversPerVm": 87}, "fallbackFleet": "sZelKuD0iJ6fs3zL", "imageDeploymentProfile": {"commandLine": "9H4WxGWRH7fz4BdP", "imageId": "hLtHRJOImSq37aeA", "portConfigurations": [{"name": "aGq0NIj53gXkmray", "protocol": "vcIYiWxIAxfvLzSp"}, {"name": "DFY3lxe16KsSRzkf", "protocol": "2HzBcEio5UyvuFv5"}, {"name": "z6wosJGnUyCMEbHh", "protocol": "1uE4DmJ4Suj6DjUw"}], "timeout": {"claim": 14, "creation": 67, "drain": 91, "session": 40, "unresponsive": 71}}, "name": "Z83Jp2f9f1FCoIo3", "onDemand": true, "regions": [{"bufferSize": 7, "dynamicBuffer": true, "maxServerCount": 61, "minServerCount": 75, "region": "mQir1Af0G6OrPH6Z"}, {"bufferSize": 38, "dynamicBuffer": false, "maxServerCount": 98, "minServerCount": 31, "region": "u27iwplLJdzYS9K0"}, {"bufferSize": 97, "dynamicBuffer": true, "maxServerCount": 6, "minServerCount": 45, "region": "5HmR0vknXO45AUtN"}], "samplingRules": {"coredumps": {"crashed": {"collect": true, "percentage": 92}}, "logs": {"crashed": {"collect": true, "percentage": 94}, "success": {"collect": true, "percentage": 71}, "unclaimed": {"collect": true, "percentage": 97}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID '5OJTfJBZX62yI9g5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'FleetUpdate' test.out

#- 21 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'RDrlzPFQmNu3ERxV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'FleetDelete' test.out

#- 22 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID '0UTaiSzfi0FnBERe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'FleetArtifactSamplingRulesGet' test.out

#- 23 FleetArtifactSamplingRulesSet
# body param: body
echo '{"coredumps": {"crashed": {"collect": true, "percentage": 82}}, "logs": {"crashed": {"collect": false, "percentage": 89}, "success": {"collect": false, "percentage": 93}, "unclaimed": {"collect": false, "percentage": 92}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesSet \
    --fleetID 'xOJu7rNRVdygfKmU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'FleetArtifactSamplingRulesSet' test.out

#- 24 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID 'kzj9mHFpff2vDkz6' \
    --namespace $AB_NAMESPACE \
    --count '84' \
    --offset '51' \
    --region 'AZ86un0L98WUoXvf' \
    --serverId 'U4qMIpfgxw2ff5tw' \
    --sortBy 'RYbtdK2r4wWs6IpY' \
    --sortDirection 'desc' \
    --status 'creating' \
    > test.out 2>&1
eval_tap $? 24 'FleetServers' test.out

#- 25 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID '47Oa51m6VLfjsw27' \
    --namespace $AB_NAMESPACE \
    --count '32' \
    --offset '96' \
    --reason 'MmOQJrpEBbVvBn8L' \
    --region 'sf2qSAtizV9hzsVb' \
    --serverId 'pJLtEZjuyFhvbxX2' \
    --sortDirection 'DNbknfVv4nm70TCa' \
    --status 'yYAkF18YBwRxcREy' \
    > test.out 2>&1
eval_tap $? 25 'FleetServerHistory' test.out

#- 26 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    --count '95' \
    --inUse 'Q0hb2tLrsMeoZiRY' \
    --isProtected 'false' \
    --name 'r2QcwlRrReRajlpk' \
    --offset '10' \
    --sortBy 'lfuiJVcktlx9zJZV' \
    --sortDirection 'VCc9bpIHEWQMmCkI' \
    --status 'qwqpoTVCNrcaVozs' \
    --tag 'jIXO2EUsAfBvo6Ll' \
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
    --imageID 'calks2R3VMtipTVx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'ImageGet' test.out

#- 29 ImageMarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageMarkForDeletion \
    --imageID 'XAF8KhOKqbrECijF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'ImageMarkForDeletion' test.out

#- 30 ImagePatch
# body param: body
echo '{"addedTags": ["xOpOzxeTLJQsZcTE", "zXaXUzpsAV6ct6XI", "TL0QEkadMSQluAoE"], "isProtected": true, "name": "grvb2E1X9ecBBhRA", "removedTags": ["YjR7c4x5bIk8pVpx", "dUWOPel3TiwTycqp", "VdINXzvkSp0WbvxQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID 'WI0QGCOx7eICkauW' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'ImagePatch' test.out

#- 31 ImageUnmarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageUnmarkForDeletion \
    --imageID 'bFrSnU7d1Buhdwli' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ImageUnmarkForDeletion' test.out

#- 32 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'TSDdmGVfegiD3mrV' \
    > test.out 2>&1
eval_tap $? 32 'QoSRegionsGet' test.out

#- 33 QoSRegionsUpdate
# body param: body
echo '{"status": "QaUr3oT88Dfc7114"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'QFGwTzBVDg5v71kG' \
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
    --serverID 'CEt7h1mVwIQCJmQk' \
    > test.out 2>&1
eval_tap $? 35 'FleetServerInfo' test.out

#- 36 FleetServerConnectionInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerConnectionInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'vWbQrn2W0VkOF0pQ' \
    > test.out 2>&1
eval_tap $? 36 'FleetServerConnectionInfo' test.out

#- 37 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'OY0UCcViiFKNjkT5' \
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
echo '{"region": "hcONCaOyATBFgqLe", "sessionId": "AzvdcUEhWRo6ROvb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'uPQwl9dVfJQGkDR0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'FleetClaimByID' test.out

#- 41 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID '0ofXsbnEzHiRs0Nm' \
    > test.out 2>&1
eval_tap $? 41 'LocalWatchdogConnect' test.out

#- 42 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["Ghxv1vuN7Xv6OuG6", "RR1jPh8RblvnfNiA", "BRf1gdXM7QlAlnjA"], "regions": ["fgxOdZdf9tLHO1qr", "NyhmUEADczzrL31H", "uYKsCBBgwb1hGjHJ"], "sessionId": "gxrcEvnfJqU4hCv5"}' > $TEMP_JSON_INPUT
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
    --watchdogID 'egSQDePKSZKp6zwD' \
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