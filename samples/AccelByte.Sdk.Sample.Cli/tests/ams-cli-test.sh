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
echo "1..25"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 Func2
$CLI_EXE \
    --sn ams \
    --op Func2 \
    > test.out 2>&1
eval_tap $? 2 'Func2' test.out

#- 3 AccountGet
$CLI_EXE \
    --sn ams \
    --op AccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 3 'AccountGet' test.out

#- 4 AccountCreate
# body param: body
echo '{"name": "bBuz5zkoaUEzGS3q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AccountCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AccountCreate' test.out

#- 5 AccountLinkTokenGet
$CLI_EXE \
    --sn ams \
    --op AccountLinkTokenGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AccountLinkTokenGet' test.out

#- 6 AccountLink
# body param: body
echo '{"token": "Zf0PbemSBELbZ0VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AccountLink \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AccountLink' test.out

#- 7 FleetList
$CLI_EXE \
    --sn ams \
    --op FleetList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'FleetList' test.out

#- 8 FleetCreate
# body param: body
echo '{"active": false, "claimKeys": ["GA7nkDeev2Oj060H", "nOf5S8X1LxkZs423", "3oQWoXFeqeuI2oMJ"], "dsHostConfiguration": {"instanceId": "0cgAoGfXepE3r5AQ", "instanceType": "UBqS8KtTYZLJ58Qq", "serversPerVm": 4}, "imageDeploymentProfile": {"commandLine": "fMI04rm2jUc9iav3", "imageId": "tTqlE9oLDPD0Lfle", "portConfigurations": [{"name": "8ESU1MO8XnVaEyjm", "protocol": "ifJDYa1TJPUszmFG"}, {"name": "EkJVvqDSU3PDyIAG", "protocol": "fGq1FNmRWvUvDPnK"}, {"name": "oECjGUg867xodwuG", "protocol": "14ID5l5wj6K2wEMn"}], "timeout": {"creation": 5, "drain": 8, "session": 22, "unresponsive": 71}}, "name": "jlW6BywsSSZTGlub", "regions": [{"bufferSize": 38, "maxServerCount": 82, "minServerCount": 25, "region": "BqhuNtj8FOvKZjs1"}, {"bufferSize": 39, "maxServerCount": 2, "minServerCount": 76, "region": "kTGYKqRMSTisP0Mr"}, {"bufferSize": 91, "maxServerCount": 6, "minServerCount": 0, "region": "A2zyZsb4FvWFIHPI"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'FleetCreate' test.out

#- 9 FleetGet
$CLI_EXE \
    --sn ams \
    --op FleetGet \
    --fleetID 'bOjpls9BZTYc5Bsd' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'FleetGet' test.out

#- 10 FleetUpdate
# body param: body
echo '{"active": true, "claimKeys": ["SVaAzzn4GbgkKeCa", "S6qyUCscHXs8PlOB", "lfUOqv7WmCuqcsNM"], "dsHostConfiguration": {"instanceId": "7YAnbq4DjmYUMhD9", "instanceType": "qU89D356pVsUtNan", "serversPerVm": 7}, "imageDeploymentProfile": {"commandLine": "rA0WWyKl2K5mCSoG", "imageId": "eQCahcox63cyDxAA", "portConfigurations": [{"name": "YcRXJdoSTxNCK9AI", "protocol": "jNmbfoW8bDq5jPqz"}, {"name": "hN0YdGSrA9LXRwU6", "protocol": "WLgpQE9nXzhBC0uy"}, {"name": "MR4Xf2nfYvNvG8uQ", "protocol": "14AhsxaALiBwpNJo"}], "timeout": {"creation": 35, "drain": 33, "session": 28, "unresponsive": 36}}, "name": "m7NjUZ95Z5XDLBN9", "regions": [{"bufferSize": 29, "maxServerCount": 66, "minServerCount": 100, "region": "VPtkjt0OyBlJi4Rb"}, {"bufferSize": 66, "maxServerCount": 70, "minServerCount": 66, "region": "y11mfOFjCzZVcGom"}, {"bufferSize": 100, "maxServerCount": 47, "minServerCount": 64, "region": "hEvn3SGqcH91fC3a"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'JEoqWaFAGD6PRg95' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'FleetUpdate' test.out

#- 11 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'm07l03vtlMFzeiMR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'FleetDelete' test.out

#- 12 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID 'kcOr1L0TMIczbYil' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'FleetServers' test.out

#- 13 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID 'OziwG8CPLOzSZm9K' \
    --namespace $AB_NAMESPACE \
    --count '37' \
    --offset '5' \
    --reason 'gzfaQrUCW9fgo69u' \
    --region 'v1bkFx8DmbC9UqYd' \
    --serverId 'YrdxNnuMcAwrSzYn' \
    --sortDirection 'rcetxObeisZelKuD' \
    --status '0iJ6fs3zL9H4WxGW' \
    > test.out 2>&1
eval_tap $? 13 'FleetServerHistory' test.out

#- 14 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'ImageList' test.out

#- 15 ImageGet
$CLI_EXE \
    --sn ams \
    --op ImageGet \
    --imageID 'RH7fz4BdPhLtHRJO' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'ImageGet' test.out

#- 16 ImagePatch
# body param: body
echo '{"addedTags": ["ImSq37aeAaGq0NIj", "53gXkmrayvcIYiWx", "IAxfvLzSpDFY3lxe"], "isProtected": false, "name": "KsSRzkf2HzBcEio5", "removedTags": ["UyvuFv5z6wosJGnU", "yCMEbHh1uE4DmJ4S", "uj6DjUw36GtZ83Jp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID '2f9f1FCoIo3L24DK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'ImagePatch' test.out

#- 17 InfoRegions
$CLI_EXE \
    --sn ams \
    --op InfoRegions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'InfoRegions' test.out

#- 18 FleetServerInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'GwgZ85vyFJR8euQB' \
    > test.out 2>&1
eval_tap $? 18 'FleetServerInfo' test.out

#- 19 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'LVu27iwplLJdzYS9' \
    > test.out 2>&1
eval_tap $? 19 'ServerHistory' test.out

#- 20 InfoSupportedInstances
$CLI_EXE \
    --sn ams \
    --op InfoSupportedInstances \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'InfoSupportedInstances' test.out

#- 21 FleetClaimByID
# body param: body
echo '{"region": "K0VvwE6MAqPc8lGI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'YWTwxyqQQIXVmrtR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'FleetClaimByID' test.out

#- 22 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["lq1jv60HTnmFrl3g", "Yx6Xmv1DzPHux3k3", "skhn3mWZjTYM95e4"], "regions": ["aa8xOJu7rNRVdygf", "KmUkzj9mHFpff2vD", "kz68zorEgcExv9nK"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByKeys \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'FleetClaimByKeys' test.out

#- 23 WatchdogConnect
$CLI_EXE \
    --sn ams \
    --op WatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'MOgO5W8SUaZjCpNt' \
    > test.out 2>&1
eval_tap $? 23 'WatchdogConnect' test.out

#- 24 Func3
$CLI_EXE \
    --sn ams \
    --op Func3 \
    > test.out 2>&1
eval_tap $? 24 'Func3' test.out

#- 25 PortalHealthCheck
$CLI_EXE \
    --sn ams \
    --op PortalHealthCheck \
    > test.out 2>&1
eval_tap $? 25 'PortalHealthCheck' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE