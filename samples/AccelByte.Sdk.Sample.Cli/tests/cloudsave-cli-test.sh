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
echo "1..40"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminPutGameRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "91aPkZFr", "updatedAt": "EhkGu0xI", "value": {"LRWw4jUm": {}, "0b7ZlBMO": {}, "PlSiu1NR": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key 'vACHXLWd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 3 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query 'Z9DSbgQp' \
    --limit '28' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 3 'ListGameRecordsHandlerV1' test.out

#- 4 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'fcmFlDxn' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetGameRecordHandlerV1' test.out

#- 5 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'EB2F5vN0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPutGameRecordHandlerV1' test.out

#- 6 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'SMdz4zq6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostGameRecordHandlerV1' test.out

#- 7 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key '1ZUi77ug' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteGameRecordHandlerV1' test.out

#- 8 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["3fpz74fU", "iUi8tIu0", "cSTEK2bD"], "user_id": "6QYJQ6dU"}, {"keys": ["XL9fBeSX", "ZdPXLa6L", "xnRkiFlq"], "user_id": "CocGGgJF"}, {"keys": ["4NN0NZTR", "JD80dhwm", "i1YAwTNp"], "user_id": "Et7FIrB3"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerRecordSizeHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'BulkGetPlayerRecordSizeHandlerV1' test.out

#- 9 ListPlayerRecordHandlerV1
eval_tap 0 9 'ListPlayerRecordHandlerV1 # SKIP deprecated' test.out

#- 10 AdminPutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "OQfnv3i0", "updatedAt": "nHAs9MN9", "value": {"HhfYabHS": {}, "5fj5nDgX": {}, "dH4HR4hy": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key 'E3dWgxhE' \
    --namespace $AB_NAMESPACE \
    --userId 'WFGSukS6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 11 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "FgliRi8c", "updatedAt": "Yx5aVSyV", "value": {"qy0va9Bb": {}, "ObDNJ8A0": {}, "87e6O4vc": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key '00moFzp8' \
    --namespace $AB_NAMESPACE \
    --userId 'zlToT6jc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 12 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'QbsC17CD' \
    --limit '73' \
    --offset '78' \
    > test.out 2>&1
eval_tap $? 12 'AdminRetrievePlayerRecords' test.out

#- 13 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key 'wyjvLOnx' \
    --namespace $AB_NAMESPACE \
    --userId 'lG1Gw7tG' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetPlayerRecordHandlerV1' test.out

#- 14 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'ofLM7fqq' \
    --namespace $AB_NAMESPACE \
    --userId '7c5jxyKQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPutPlayerRecordHandlerV1' test.out

#- 15 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'WJFxkU8k' \
    --namespace $AB_NAMESPACE \
    --userId 'colwiRvH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminPostPlayerRecordHandlerV1' test.out

#- 16 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key 'a9c50I1F' \
    --namespace $AB_NAMESPACE \
    --userId 'pnIKJcgb' \
    > test.out 2>&1
eval_tap $? 16 'AdminDeletePlayerRecordHandlerV1' test.out

#- 17 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key '8gxa8sKy' \
    --namespace $AB_NAMESPACE \
    --userId 'R06MASdV' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 18 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key 'IIR5JDgg' \
    --namespace $AB_NAMESPACE \
    --userId '5uszfYNA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 19 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'tB4SCcRg' \
    --namespace $AB_NAMESPACE \
    --userId 'gpbXZ2MS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 20 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'g5FnJZHj' \
    --namespace $AB_NAMESPACE \
    --userId 'LHY3iRmQ' \
    > test.out 2>&1
eval_tap $? 20 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 21 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key 'TTyp6o85' \
    --namespace $AB_NAMESPACE \
    --userId 'anNSB0gj' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 22 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "hsuLbCdN", "value": {"HmtaIbEm": {}, "2PPuvRUu": {}, "UcihfUsy": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'BmLLXSQK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PutGameRecordConcurrentHandlerV1' test.out

#- 23 GetGameRecordsBulk
# body param: body
echo '{"keys": ["78Yi6t6w", "Ol35Fwsu", "miGSQj8n"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordsBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'GetGameRecordsBulk' test.out

#- 24 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'W9U63p76' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetGameRecordHandlerV1' test.out

#- 25 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key 'BQyGDCFz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PutGameRecordHandlerV1' test.out

#- 26 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'oZx8ictP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PostGameRecordHandlerV1' test.out

#- 27 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'USOucZSA' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'DeleteGameRecordHandlerV1' test.out

#- 28 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["3dL0SGhk", "4TYQWtFw", "FphB8B9b"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'hwCLLIdw' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 29 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --offset '40' \
    > test.out 2>&1
eval_tap $? 29 'RetrievePlayerRecords' test.out

#- 30 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["gGj9pz5T", "Z5D6lNvk", "FFe7SzMM"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordsBulkHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'GetPlayerRecordsBulkHandlerV1' test.out

#- 31 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key '45MNhI2u' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 32 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "bxdvzD06", "value": {"xBp5x79I": {}, "dIQ553D5": {}, "DJ6uzV77": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key 'NCAszmgG' \
    --namespace $AB_NAMESPACE \
    --userId 'CVDsGKgL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 33 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "SPrFSSaY", "value": {"du6XU9x5": {}, "q33M5MOM": {}, "sW1ExMPg": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'eQUDCcQI' \
    --namespace $AB_NAMESPACE \
    --userId 'KhOAVk4d' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 34 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'WHUYyvXj' \
    --namespace $AB_NAMESPACE \
    --userId 'BhEoRMcg' \
    > test.out 2>&1
eval_tap $? 34 'GetPlayerRecordHandlerV1' test.out

#- 35 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'b8hZ3wnx' \
    --namespace $AB_NAMESPACE \
    --userId 'MxDFvpU6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'PutPlayerRecordHandlerV1' test.out

#- 36 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'u0T7lEol' \
    --namespace $AB_NAMESPACE \
    --userId 'Adjp3CqC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PostPlayerRecordHandlerV1' test.out

#- 37 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'sCmEJTuK' \
    --namespace $AB_NAMESPACE \
    --userId 'WQYdDHsT' \
    > test.out 2>&1
eval_tap $? 37 'DeletePlayerRecordHandlerV1' test.out

#- 38 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'mwRMUgWY' \
    --namespace $AB_NAMESPACE \
    --userId 'VXDqUGNZ' \
    > test.out 2>&1
eval_tap $? 38 'GetPlayerPublicRecordHandlerV1' test.out

#- 39 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'Tj4MvRhX' \
    --namespace $AB_NAMESPACE \
    --userId '0NyMFKx9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PutPlayerPublicRecordHandlerV1' test.out

#- 40 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key '01jjsbum' \
    --namespace $AB_NAMESPACE \
    --userId 'tnVNx0Ce' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE