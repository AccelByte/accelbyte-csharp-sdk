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
echo "1..16"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListNodesIPAddress
$CLI_EXE \
    --sn dsartifact \
    --op ListNodesIPAddress \
    --limit '2' \
    --next 'Yi3wMWnoZgIhwb8Y' \
    --nodeIP 'YMLqpQwkRRHkaiKs' \
    --previous 'mIiRLR3IlNJKxhPf' \
    > test.out 2>&1
eval_tap $? 2 'ListNodesIPAddress' test.out

#- 3 DeleteNodeByID
$CLI_EXE \
    --sn dsartifact \
    --op DeleteNodeByID \
    --nodeIP 'WV6dIabcFbSmeuIB' \
    --podName 'roF7bwRgwKvzESbh' \
    > test.out 2>&1
eval_tap $? 3 'DeleteNodeByID' test.out

#- 4 ListQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListQueue \
    --limit '32' \
    --next '0cgAoGfXepE3r5AQ' \
    --previous 'UBqS8KtTYZLJ58Qq' \
    --nodeIP 'cV3IcuNs9MF5BT2K' \
    > test.out 2>&1
eval_tap $? 4 'ListQueue' test.out

#- 5 GetActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op GetActiveQueue \
    --nodeIP 'D18yrWorpC65VJh4' \
    > test.out 2>&1
eval_tap $? 5 'GetActiveQueue' test.out

#- 6 SetActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op SetActiveQueue \
    --nodeIP 'q1z1KJmKedBfbWvK' \
    --podName 'a5Ou124TsbQsxYFx' \
    > test.out 2>&1
eval_tap $? 6 'SetActiveQueue' test.out

#- 7 DeleteActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op DeleteActiveQueue \
    --nodeIP 'GGHrfQkgXkiA5IZP' \
    > test.out 2>&1
eval_tap $? 7 'DeleteActiveQueue' test.out

#- 8 ReportFailedUpload
$CLI_EXE \
    --sn dsartifact \
    --op ReportFailedUpload \
    --nodeIP 'qCqp9vcyt67WAfWX' \
    --podName 'fUfwGB03tz8qIH4u' \
    > test.out 2>&1
eval_tap $? 8 'ReportFailedUpload' test.out

#- 9 DeleteQueue
$CLI_EXE \
    --sn dsartifact \
    --op DeleteQueue \
    --namespace $AB_NAMESPACE \
    --nodeIP 'RdNO08HN6s9p8Y5c' \
    --podName '9eItJtiNmY3y3n2R' \
    > test.out 2>&1
eval_tap $? 9 'DeleteQueue' test.out

#- 10 ListAllActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListAllActiveQueue \
    --namespace $AB_NAMESPACE \
    --limit '17' \
    --next 'ubsmhjXcScOUvrjJ' \
    --nodeIP 'BO7tbkTGYKqRMSTi' \
    --podName 'sP0MrSdaFy0pJYCd' \
    --previous 'fkfyt09ro5fHdWqJ' \
    > test.out 2>&1
eval_tap $? 10 'ListAllActiveQueue' test.out

#- 11 ListAllQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListAllQueue \
    --namespace $AB_NAMESPACE \
    --excludeUploading 'false' \
    --limit '5' \
    --next 'rmpnnEckHH8kT9oX' \
    --nodeIP 'Vandercf1nq4Hf32' \
    --order 'SL5PjaYEDxaYN8w9' \
    --podName 'KUW0py8KrcQfucSq' \
    --previous '2X8gFuJORk4j04Yf' \
    > test.out 2>&1
eval_tap $? 11 'ListAllQueue' test.out

#- 12 ListTerminatedServersWithNamespace
$CLI_EXE \
    --sn dsartifact \
    --op ListTerminatedServersWithNamespace \
    --namespace $AB_NAMESPACE \
    --deployment 'nXTsQUrA0WWyKl2K' \
    --gameMode '5mCSoGeQCahcox63' \
    --limit '4' \
    --next 'f2Hwi7vg3osbh0fL' \
    --partyId '2h7eJvAS2W4uqkhw' \
    --podName 'SC7EajwHO3LfvwPe' \
    --previous 'wrf19Njm50xCDlPe' \
    --provider 'Nq0CvMXtyUWXrdZa' \
    --region 'FeacGT2x6o28Njxy' \
    --sessionId 'w7RHldq0m7NjUZ95' \
    --userId 'Z5XDLBN9YGVPtkjt' \
    > test.out 2>&1
eval_tap $? 12 'ListTerminatedServersWithNamespace' test.out

#- 13 DownloadServerArtifacts
$CLI_EXE \
    --sn dsartifact \
    --op DownloadServerArtifacts \
    --namespace $AB_NAMESPACE \
    --podName '0OyBlJi4RbZ0Iy11' \
    > test.out 2>&1
eval_tap $? 13 'DownloadServerArtifacts' test.out

#- 14 CheckServerArtifact
$CLI_EXE \
    --sn dsartifact \
    --op CheckServerArtifact \
    --namespace $AB_NAMESPACE \
    --podName 'mfOFjCzZVcGomWF1' \
    > test.out 2>&1
eval_tap $? 14 'CheckServerArtifact' test.out

#- 15 ListTerminatedServers
$CLI_EXE \
    --sn dsartifact \
    --op ListTerminatedServers \
    --deployment 'oAqUNFDtXnXLvOAs' \
    --gameMode 'W8wYh4gq7pRVZVLJ' \
    --limit '16' \
    --next '7l03vtlMFzeiMRkc' \
    --partyId 'Or1L0TMIczbYilOz' \
    --podName 'iwG8CPLOzSZm9K3c' \
    --previous 'MY617HSCYZaL46I3' \
    --provider 'PgCcQ0axTWnmyEYL' \
    --region 'ZQTpvLH6QPEBP8kS' \
    --sessionId 'SFjeuL3wQQPYwmYF' \
    --userId 'bxRvHYDCYwoGdmzX' \
    > test.out 2>&1
eval_tap $? 15 'ListTerminatedServers' test.out

#- 16 PublicGetMessages
$CLI_EXE \
    --sn dsartifact \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 16 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE