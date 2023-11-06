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
echo "1..30"

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

#- 4 AccountGet
$CLI_EXE \
    --sn ams \
    --op AccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AccountGet' test.out

#- 5 AccountCreate
# body param: body
echo '{"name": "bBuz5zkoaUEzGS3q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AccountCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AccountCreate' test.out

#- 6 AccountLinkTokenGet
$CLI_EXE \
    --sn ams \
    --op AccountLinkTokenGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AccountLinkTokenGet' test.out

#- 7 AccountLink
# body param: body
echo '{"token": "Zf0PbemSBELbZ0VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AccountLink \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AccountLink' test.out

#- 8 FleetList
$CLI_EXE \
    --sn ams \
    --op FleetList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'FleetList' test.out

#- 9 FleetCreate
# body param: body
echo '{"active": false, "claimKeys": ["GA7nkDeev2Oj060H", "nOf5S8X1LxkZs423", "3oQWoXFeqeuI2oMJ"], "dsHostConfiguration": {"instanceId": "0cgAoGfXepE3r5AQ", "instanceType": "UBqS8KtTYZLJ58Qq", "serversPerVm": 4}, "imageDeploymentProfile": {"commandLine": "fMI04rm2jUc9iav3", "imageId": "tTqlE9oLDPD0Lfle", "portConfigurations": [{"name": "8ESU1MO8XnVaEyjm", "protocol": "ifJDYa1TJPUszmFG"}, {"name": "EkJVvqDSU3PDyIAG", "protocol": "fGq1FNmRWvUvDPnK"}, {"name": "oECjGUg867xodwuG", "protocol": "14ID5l5wj6K2wEMn"}], "timeout": {"creation": 5, "drain": 8, "session": 22, "unresponsive": 71}}, "name": "jlW6BywsSSZTGlub", "regions": [{"bufferSize": 38, "maxServerCount": 82, "minServerCount": 25, "region": "BqhuNtj8FOvKZjs1"}, {"bufferSize": 39, "maxServerCount": 2, "minServerCount": 76, "region": "kTGYKqRMSTisP0Mr"}, {"bufferSize": 91, "maxServerCount": 6, "minServerCount": 0, "region": "A2zyZsb4FvWFIHPI"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'FleetCreate' test.out

#- 10 FleetGet
$CLI_EXE \
    --sn ams \
    --op FleetGet \
    --fleetID 'bOjpls9BZTYc5Bsd' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'FleetGet' test.out

#- 11 FleetUpdate
# body param: body
echo '{"active": true, "claimKeys": ["SVaAzzn4GbgkKeCa", "S6qyUCscHXs8PlOB", "lfUOqv7WmCuqcsNM"], "dsHostConfiguration": {"instanceId": "7YAnbq4DjmYUMhD9", "instanceType": "qU89D356pVsUtNan", "serversPerVm": 7}, "imageDeploymentProfile": {"commandLine": "rA0WWyKl2K5mCSoG", "imageId": "eQCahcox63cyDxAA", "portConfigurations": [{"name": "YcRXJdoSTxNCK9AI", "protocol": "jNmbfoW8bDq5jPqz"}, {"name": "hN0YdGSrA9LXRwU6", "protocol": "WLgpQE9nXzhBC0uy"}, {"name": "MR4Xf2nfYvNvG8uQ", "protocol": "14AhsxaALiBwpNJo"}], "timeout": {"creation": 35, "drain": 33, "session": 28, "unresponsive": 36}}, "name": "m7NjUZ95Z5XDLBN9", "regions": [{"bufferSize": 29, "maxServerCount": 66, "minServerCount": 100, "region": "VPtkjt0OyBlJi4Rb"}, {"bufferSize": 66, "maxServerCount": 70, "minServerCount": 66, "region": "y11mfOFjCzZVcGom"}, {"bufferSize": 100, "maxServerCount": 47, "minServerCount": 64, "region": "hEvn3SGqcH91fC3a"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'JEoqWaFAGD6PRg95' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'FleetUpdate' test.out

#- 12 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'm07l03vtlMFzeiMR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'FleetDelete' test.out

#- 13 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID 'kcOr1L0TMIczbYil' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'FleetArtifactSamplingRulesGet' test.out

#- 14 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID 'OziwG8CPLOzSZm9K' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'FleetServers' test.out

#- 15 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID '3cMY617HSCYZaL46' \
    --namespace $AB_NAMESPACE \
    --count '70' \
    --offset '43' \
    --reason '3PgCcQ0axTWnmyEY' \
    --region 'LZQTpvLH6QPEBP8k' \
    --serverId 'SSFjeuL3wQQPYwmY' \
    --sortDirection 'FbxRvHYDCYwoGdmz' \
    --status 'Xgf1ewUTvnu0ensa' \
    > test.out 2>&1
eval_tap $? 15 'FleetServerHistory' test.out

#- 16 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'ImageList' test.out

#- 17 ImageGet
$CLI_EXE \
    --sn ams \
    --op ImageGet \
    --imageID '3MZF7DTswnkSyuJT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'ImageGet' test.out

#- 18 ImagePatch
# body param: body
echo '{"addedTags": ["VjKQ1ORLEIAePvDO", "2xkVgyRk10b27RdU", "8VceYQ9erPYQ5yVc"], "isProtected": false, "name": "uvDbGMqbEHkCQwMB", "removedTags": ["cQUNPHN8YZT0yJJ0", "uCjjaNCRV3hSIiTE", "oTCSxjAqg9oGVEdC"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID '8mQir1Af0G6OrPH6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'ImagePatch' test.out

#- 19 QoSRegionsUpdate
# body param: body
echo '{"status": "ZsjpPgHKISHtB8tW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'dJM9Qc5HmR0vknXO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'QoSRegionsUpdate' test.out

#- 20 InfoRegions
$CLI_EXE \
    --sn ams \
    --op InfoRegions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'InfoRegions' test.out

#- 21 FleetServerInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerInfo \
    --namespace $AB_NAMESPACE \
    --serverID '45AUtNXSTItt35OJ' \
    > test.out 2>&1
eval_tap $? 21 'FleetServerInfo' test.out

#- 22 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'TfJBZX62yI9g5RDr' \
    > test.out 2>&1
eval_tap $? 22 'ServerHistory' test.out

#- 23 InfoSupportedInstances
$CLI_EXE \
    --sn ams \
    --op InfoSupportedInstances \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'InfoSupportedInstances' test.out

#- 24 FleetClaimByID
# body param: body
echo '{"region": "lzPFQmNu3ERxV0UT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'aiSzfi0FnBERe8qN' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'FleetClaimByID' test.out

#- 25 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'YRTYSaZw4NqSNylc' \
    > test.out 2>&1
eval_tap $? 25 'LocalWatchdogConnect' test.out

#- 26 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'ljuNM3eUUSD1pZGM' \
    > test.out 2>&1
eval_tap $? 26 'QoSRegionsGet' test.out

#- 27 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["fPdGIOAZ86un0L98", "WUoXvfU4qMIpfgxw", "2ff5twRYbtdK2r4w"], "regions": ["Ws6IpYBxafo9b4xJ", "yNnvHKrm8UuNlT86", "N9yO0vyD6J5brVo2"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByKeys \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'FleetClaimByKeys' test.out

#- 28 WatchdogConnect
$CLI_EXE \
    --sn ams \
    --op WatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID '0e6POTjrinAVVovp' \
    > test.out 2>&1
eval_tap $? 28 'WatchdogConnect' test.out

#- 29 Func1
$CLI_EXE \
    --sn ams \
    --op Func1 \
    > test.out 2>&1
eval_tap $? 29 'Func1' test.out

#- 30 BasicHealthCheck
$CLI_EXE \
    --sn ams \
    --op BasicHealthCheck \
    > test.out 2>&1
eval_tap $? 30 'BasicHealthCheck' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE