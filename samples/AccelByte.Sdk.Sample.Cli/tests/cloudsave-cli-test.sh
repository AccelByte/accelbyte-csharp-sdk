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

#- 2 AdminListAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListAdminGameRecordV1 \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    --query 'i3wMWnoZgIhwb8YY' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAdminGameRecordV1' test.out

#- 3 AdminBulkGetAdminGameRecordV1
# body param: body
echo '{"keys": ["MLqpQwkRRHkaiKsm", "IiRLR3IlNJKxhPfW", "V6dIabcFbSmeuIBr"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetAdminGameRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminBulkGetAdminGameRecordV1' test.out

#- 4 AdminGetAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetAdminGameRecordV1 \
    --key 'oF7bwRgwKvzESbhp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetAdminGameRecordV1' test.out

#- 5 AdminPutAdminGameRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordV1 \
    --key 'xlDdEs4igdKeLmy8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPutAdminGameRecordV1' test.out

#- 6 AdminPostAdminGameRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostAdminGameRecordV1 \
    --key 'tZ5GZi5P12c61ts3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostAdminGameRecordV1' test.out

#- 7 AdminDeleteAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminGameRecordV1 \
    --key 'fMI04rm2jUc9iav3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteAdminGameRecordV1' test.out

#- 8 AdminListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '41' \
    --offset '94' \
    --query '8yrWorpC65VJh4q1' \
    > test.out 2>&1
eval_tap $? 8 'AdminListGameBinaryRecordsV1' test.out

#- 9 AdminPostGameBinaryRecordV1
# body param: body
echo '{"file_type": "z1KJmKedBfbWvKa5", "key": "Ou124TsbQsxYFxGG", "set_by": "HrfQkgXkiA5IZPqC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminPostGameBinaryRecordV1' test.out

#- 10 AdminGetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameBinaryRecordV1 \
    --key 'qp9vcyt67WAfWXfU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetGameBinaryRecordV1' test.out

#- 11 AdminPutGameBinaryRecordV1
# body param: body
echo '{"content_type": "fwGB03tz8qIH4uRd", "file_location": "NO08HN6s9p8Y5c9e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecordV1 \
    --key 'ItJtiNmY3y3n2Rim' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminPutGameBinaryRecordV1' test.out

#- 12 AdminDeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameBinaryRecordV1 \
    --key '4NBqhuNtj8FOvKZj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteGameBinaryRecordV1' test.out

#- 13 AdminPutGameBinaryRecorMetadataV1
# body param: body
echo '{"set_by": "s1tLpERf77LzPoOR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecorMetadataV1 \
    --key 'BkRmZ0A2zyZsb4Fv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminPutGameBinaryRecorMetadataV1' test.out

#- 14 AdminPostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "WFIHPIbOjpls9BZT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryPresignedURLV1 \
    --key 'Yc5BsdSSVaAzzn4G' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPostGameBinaryPresignedURLV1' test.out

#- 15 AdminPutAdminGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "bgkKeCaS6qyUCscH", "value": {"Xs8PlOBlfUOqv7Wm": {}, "CuqcsNM7YAnbq4Dj": {}, "mYUMhD9qU89D356p": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordConcurrentHandlerV1 \
    --key 'VsUtNanddzgwxYdQ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminPutAdminGameRecordConcurrentHandlerV1' test.out

#- 16 AdminPutGameRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "c5hEfefdopcEM0JH", "updatedAt": "fof2Hwi7vg3osbh0", "value": {"fL2h7eJvAS2W4uqk": {}, "hwSC7EajwHO3Lfvw": {}, "Pewrf19Njm50xCDl": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key 'PeNq0CvMXtyUWXrd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 17 GetPluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op GetPluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetPluginConfig' test.out

#- 18 CreatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "ZaFeacGT2x6o28Nj"}, "customConfig": {"GRPCAddress": "xyw7RHldq0m7NjUZ"}, "customFunction": {"afterBulkReadGameRecord": false, "afterBulkReadPlayerRecord": false, "afterReadGameRecord": true, "afterReadPlayerRecord": false, "beforeWriteAdminGameRecord": true, "beforeWriteAdminPlayerRecord": true, "beforeWriteGameRecord": true, "beforeWritePlayerRecord": true}, "extendType": "APP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op CreatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreatePluginConfig' test.out

#- 19 DeletePluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeletePluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'DeletePluginConfig' test.out

#- 20 UpdatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "9YGVPtkjt0OyBlJi"}, "customConfig": {"GRPCAddress": "4RbZ0Iy11mfOFjCz"}, "customFunction": {"afterBulkReadGameRecord": false, "afterBulkReadPlayerRecord": true, "afterReadGameRecord": false, "afterReadPlayerRecord": true, "beforeWriteAdminGameRecord": false, "beforeWriteAdminPlayerRecord": false, "beforeWriteGameRecord": false, "beforeWritePlayerRecord": false}, "extendType": "APP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op UpdatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdatePluginConfig' test.out

#- 21 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query 'WF1oAqUNFDtXnXLv' \
    --limit '82' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 21 'ListGameRecordsHandlerV1' test.out

#- 22 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'AsW8wYh4gq7pRVZV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminGetGameRecordHandlerV1' test.out

#- 23 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'LJiDx3au9b9QjhzD' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminPutGameRecordHandlerV1' test.out

#- 24 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'lnJmi4XaBTgoXjfd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminPostGameRecordHandlerV1' test.out

#- 25 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key 'UQHa3RxspSqwdbTR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'AdminDeleteGameRecordHandlerV1' test.out

#- 26 BulkGetAdminPlayerRecordByUserIdsV1
# body param: body
echo '{"userIds": ["2sgzfaQrUCW9fgo6", "9uv1bkFx8DmbC9Uq", "YdYrdxNnuMcAwrSz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetAdminPlayerRecordByUserIdsV1 \
    --key 'YnrcetxObeisZelK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'BulkGetAdminPlayerRecordByUserIdsV1' test.out

#- 27 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["uD0iJ6fs3zL9H4Wx", "GWRH7fz4BdPhLtHR", "JOImSq37aeAaGq0N"], "user_id": "Ij53gXkmrayvcIYi"}, {"keys": ["WxIAxfvLzSpDFY3l", "xe16KsSRzkf2HzBc", "Eio5UyvuFv5z6wos"], "user_id": "JGnUyCMEbHh1uE4D"}, {"keys": ["mJ4Suj6DjUw36GtZ", "83Jp2f9f1FCoIo3L", "24DKGwgZ85vyFJR8"], "user_id": "euQBLVu27iwplLJd"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerRecordSizeHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'BulkGetPlayerRecordSizeHandlerV1' test.out

#- 28 ListPlayerRecordHandlerV1
eval_tap 0 28 'ListPlayerRecordHandlerV1 # SKIP deprecated' test.out

#- 29 AdminListAdminUserRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListAdminUserRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'zYS9K0VvwE6MAqPc' \
    --limit '23' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 29 'AdminListAdminUserRecordsV1' test.out

#- 30 AdminBulkGetAdminPlayerRecordV1
# body param: body
echo '{"keys": ["GIYWTwxyqQQIXVmr", "tRlq1jv60HTnmFrl", "3gYx6Xmv1DzPHux3"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetAdminPlayerRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'k3skhn3mWZjTYM95' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminBulkGetAdminPlayerRecordV1' test.out

#- 31 AdminGetAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetAdminPlayerRecordV1 \
    --key 'e4aa8xOJu7rNRVdy' \
    --namespace $AB_NAMESPACE \
    --userId 'gfKmUkzj9mHFpff2' \
    > test.out 2>&1
eval_tap $? 31 'AdminGetAdminPlayerRecordV1' test.out

#- 32 AdminPutAdminPlayerRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordV1 \
    --key 'vDkz68zorEgcExv9' \
    --namespace $AB_NAMESPACE \
    --userId 'nKMOgO5W8SUaZjCp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AdminPutAdminPlayerRecordV1' test.out

#- 33 AdminPostPlayerAdminRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerAdminRecordV1 \
    --key 'NtJSMm8kDi3Rwubq' \
    --namespace $AB_NAMESPACE \
    --userId '7wtRGdT447Oa51m6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AdminPostPlayerAdminRecordV1' test.out

#- 34 AdminDeleteAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminPlayerRecordV1 \
    --key 'VLfjsw270pMmOQJr' \
    --namespace $AB_NAMESPACE \
    --userId 'pEBbVvBn8Lsf2qSA' \
    > test.out 2>&1
eval_tap $? 34 'AdminDeleteAdminPlayerRecordV1' test.out

#- 35 AdminListPlayerBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListPlayerBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'tizV9hzsVbpJLtEZ' \
    --limit '19' \
    --offset '55' \
    --query 'uyFhvbxX2DNbknfV' \
    > test.out 2>&1
eval_tap $? 35 'AdminListPlayerBinaryRecordsV1' test.out

#- 36 AdminPostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "v4nm70TCayYAkF18", "is_public": true, "key": "auFcGkPgQ0hb2tLr", "set_by": "sMeoZiRYkbhEM1zT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'NY3lpincuf5d5saQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AdminPostPlayerBinaryRecordV1' test.out

#- 37 AdminGetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerBinaryRecordV1 \
    --key 'vKfFRqBam8jPtKHT' \
    --namespace $AB_NAMESPACE \
    --userId 'mzo0JmcQmnsUigVy' \
    > test.out 2>&1
eval_tap $? 37 'AdminGetPlayerBinaryRecordV1' test.out

#- 38 AdminPutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "njGFyVicGQAVv32f", "file_location": "tRAsmC0RuRA8j1AJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecordV1 \
    --key '3hNWWhADRqJvaZrf' \
    --namespace $AB_NAMESPACE \
    --userId '2qXQFCzRV1paELj5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'AdminPutPlayerBinaryRecordV1' test.out

#- 39 AdminDeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerBinaryRecordV1 \
    --key 'dw3LK0gPYhPPG5sA' \
    --namespace $AB_NAMESPACE \
    --userId 'IfYtYozA2OntGCwQ' \
    > test.out 2>&1
eval_tap $? 39 'AdminDeletePlayerBinaryRecordV1' test.out

#- 40 AdminPutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": false, "set_by": "HHdPLwjTngrvb2E1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecorMetadataV1 \
    --key 'X9ecBBhRAYjR7c4x' \
    --namespace $AB_NAMESPACE \
    --userId '5bIk8pVpxdUWOPel' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminPutPlayerBinaryRecorMetadataV1' test.out

#- 41 AdminPostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "3TiwTycqpVdINXzv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryPresignedURLV1 \
    --key 'kSp0WbvxQWI0QGCO' \
    --namespace $AB_NAMESPACE \
    --userId 'x7eICkauWbFrSnU7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'AdminPostPlayerBinaryPresignedURLV1' test.out

#- 42 AdminPutAdminPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "d1BuhdwliTSDdmGV", "value": {"fegiD3mrVQaUr3oT": {}, "88Dfc7114QFGwTzB": {}, "VDg5v71kGCEt7h1m": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordConcurrentHandlerV1 \
    --key 'VwIQCJmQkvWbQrn2' \
    --namespace $AB_NAMESPACE \
    --userId 'W0VkOF0pQOY0UCcV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'AdminPutAdminPlayerRecordConcurrentHandlerV1' test.out

#- 43 AdminPutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "iiFKNjkT5hcONCaO", "updatedAt": "yATBFgqLeAzvdcUE", "value": {"hWRo6ROvbuPQwl9d": {}, "VfJQGkDR00ofXsbn": {}, "EzHiRs0NmGhxv1vu": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key 'N7Xv6OuG6RR1jPh8' \
    --namespace $AB_NAMESPACE \
    --userId 'RblvnfNiABRf1gdX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 44 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "M7QlAlnjAfgxOdZd", "updatedAt": "f9tLHO1qrNyhmUEA", "value": {"DczzrL31HuYKsCBB": {}, "gwb1hGjHJgxrcEvn": {}, "fJqU4hCv5egSQDeP": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'KSZKp6zwDQS1atvJ' \
    --namespace $AB_NAMESPACE \
    --userId 'rALaiplJgRhedl5E' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 45 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'wh3jDayYStUiBB1y' \
    --limit '52' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 45 'AdminRetrievePlayerRecords' test.out

#- 46 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key '3iP8gH88UenlMVzI' \
    --namespace $AB_NAMESPACE \
    --userId 'OP8NOf91LsD7cWWO' \
    > test.out 2>&1
eval_tap $? 46 'AdminGetPlayerRecordHandlerV1' test.out

#- 47 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'gAs8ThMpAGIapYft' \
    --namespace $AB_NAMESPACE \
    --userId 'YZkBXiEhdiS41VBA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminPutPlayerRecordHandlerV1' test.out

#- 48 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'EUvoBlbH02bobxtl' \
    --namespace $AB_NAMESPACE \
    --userId 'jIfHBgjP9onbxFcx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'AdminPostPlayerRecordHandlerV1' test.out

#- 49 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key 'S2OZZfXO3HkJTOPs' \
    --namespace $AB_NAMESPACE \
    --userId 'cPA2n25C1zEnAMGm' \
    > test.out 2>&1
eval_tap $? 49 'AdminDeletePlayerRecordHandlerV1' test.out

#- 50 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'Fy7w6eqnMeKFo7U8' \
    --namespace $AB_NAMESPACE \
    --userId 'Scr9xm68w7s9RMx2' \
    > test.out 2>&1
eval_tap $? 50 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 51 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key 'hc45QX234xnqlbRA' \
    --namespace $AB_NAMESPACE \
    --userId 'PFQsca6n9vGZTCCX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 52 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'Q2Lf7jtexB613cbi' \
    --namespace $AB_NAMESPACE \
    --userId 'JEUePVZQaoEY2zrp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 53 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'Luvrx96OOz45vMiR' \
    --namespace $AB_NAMESPACE \
    --userId '3QYZJKVNlK8PTaIX' \
    > test.out 2>&1
eval_tap $? 53 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 54 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key 'RWFTyA9MDnKGXqq7' \
    --namespace $AB_NAMESPACE \
    --userId 'Zk705hOhenJi6dNV' \
    > test.out 2>&1
eval_tap $? 54 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 55 ListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '64' \
    --offset '88' \
    --query '7zwjXqlcD2LzaOwI' \
    > test.out 2>&1
eval_tap $? 55 'ListGameBinaryRecordsV1' test.out

#- 56 PostGameBinaryRecordV1
# body param: body
echo '{"file_type": "F5tEsCwoAVcZCSj8", "key": "0gzFvpvIerFEyxTu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PostGameBinaryRecordV1' test.out

#- 57 BulkGetGameBinaryRecordV1
# body param: body
echo '{"keys": ["goTd50RmJFX9v4GP", "fyGuQ2UEl0U5Z9Un", "QmZqX15hBb4dlNTI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkGetGameBinaryRecordV1' test.out

#- 58 GetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameBinaryRecordV1 \
    --key 'BDtHunwNLLfKCQKu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'GetGameBinaryRecordV1' test.out

#- 59 PutGameBinaryRecordV1
# body param: body
echo '{"content_type": "u2MWXpEpNjHWPcFS", "file_location": "nM7GAvk19sXDish7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameBinaryRecordV1 \
    --key 'KUVhmAwmAygsnn8p' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'PutGameBinaryRecordV1' test.out

#- 60 DeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordV1 \
    --key 'M7l6v0elLMceGGgb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'DeleteGameBinaryRecordV1' test.out

#- 61 PostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "5FJHWE6s13b7dmnP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryPresignedURLV1 \
    --key 'ijw6U8GGp0E886E9' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PostGameBinaryPresignedURLV1' test.out

#- 62 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "0E4ZboiXT1Uy0gAr", "value": {"tDpQE4bOtoiAjHXc": {}, "VVOsVywU6uisejap": {}, "ftqoxujXDosOo2kS": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'UfIA1guTNx7haejX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PutGameRecordConcurrentHandlerV1' test.out

#- 63 GetGameRecordsBulk
# body param: body
echo '{"keys": ["SV2oH2uH8S4Zx0AC", "teueMOmYP4SgxAIQ", "TTKsdmtHu1dG0us7"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordsBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'GetGameRecordsBulk' test.out

#- 64 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'kIWLcgKgU9406tdR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'GetGameRecordHandlerV1' test.out

#- 65 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key 'Dqr3cpVbaH69NyTf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PutGameRecordHandlerV1' test.out

#- 66 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'GE59942bCwgpzUfc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PostGameRecordHandlerV1' test.out

#- 67 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'mTQjRmV0CPt1LUaT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'DeleteGameRecordHandlerV1' test.out

#- 68 BulkGetPlayerPublicBinaryRecordsV1
# body param: body
echo '{"userIds": ["vrFaxzOfG3pTddIA", "0Rt6wM5oQvTMICtW", "yUtVDnhgTGXO8Utp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicBinaryRecordsV1 \
    --key 'wxug8MpqczRvUdK1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'BulkGetPlayerPublicBinaryRecordsV1' test.out

#- 69 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["uOV1ZJTYuHpnpVX5", "u4gw4XBXDD7BG73s", "DdDoXnB8F5X05KUg"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'GKfDSGh3vQFPSYCi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 70 ListMyBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListMyBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '10' \
    --offset '100' \
    --query 'l4Hjw9KEnx8cNfDK' \
    > test.out 2>&1
eval_tap $? 70 'ListMyBinaryRecordsV1' test.out

#- 71 BulkGetMyBinaryRecordV1
# body param: body
echo '{"keys": ["45zWtwYhRoNPwKem", "a6caMTOcivPAkmP8", "Awb0NqtvSR9q6l5k"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetMyBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkGetMyBinaryRecordV1' test.out

#- 72 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '89' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 72 'RetrievePlayerRecords' test.out

#- 73 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["w4YeHqWkG09iEAFY", "Whow1WAwCs9Y0KOe", "mhNPYUVA9mU8UvON"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordsBulkHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'GetPlayerRecordsBulkHandlerV1' test.out

#- 74 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key 'yjv3GQuLHoQ6ehLL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 74 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 75 PostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "K5h1bE9WU6w3tjUh", "is_public": true, "key": "C2ynue7Xk4uDF5md"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'akWJ2AsKf8UfQqTQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PostPlayerBinaryRecordV1' test.out

#- 76 ListOtherPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId '8v7gXyFuLFZViQbx' \
    --limit '87' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 76 'ListOtherPlayerPublicBinaryRecordsV1' test.out

#- 77 BulkGetOtherPlayerPublicBinaryRecordsV1
# body param: body
echo '{"keys": ["WQ3ytABCzYWxYbbp", "huiQPU0aS2OIp0B2", "FWiDu7POaotJoQQy"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'L1bCDNisOhjEKFWm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'BulkGetOtherPlayerPublicBinaryRecordsV1' test.out

#- 78 GetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerBinaryRecordV1 \
    --key 'j7ioi5WZ6ZymQeVS' \
    --namespace $AB_NAMESPACE \
    --userId 'ZZma57V6b9uLloAA' \
    > test.out 2>&1
eval_tap $? 78 'GetPlayerBinaryRecordV1' test.out

#- 79 PutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "9KoetyNPkgWcTCN7", "file_location": "aBIFfeRdnHpse2T7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecordV1 \
    --key 'eZwkVrB3GSEmVq8C' \
    --namespace $AB_NAMESPACE \
    --userId 'jR5rCx0ZiHwUqL5r' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'PutPlayerBinaryRecordV1' test.out

#- 80 DeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerBinaryRecordV1 \
    --key 'ITYFhcdeNwLmZenR' \
    --namespace $AB_NAMESPACE \
    --userId 'qEBM0VGzhVVGdipd' \
    > test.out 2>&1
eval_tap $? 80 'DeletePlayerBinaryRecordV1' test.out

#- 81 PutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecorMetadataV1 \
    --key 'c5hx0W14SkvovINe' \
    --namespace $AB_NAMESPACE \
    --userId 'gS29legebqGwej59' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'PutPlayerBinaryRecorMetadataV1' test.out

#- 82 PostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "Ok8EM0OFW93FkJic"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryPresignedURLV1 \
    --key 'mK6qeaDEm9bPCS2a' \
    --namespace $AB_NAMESPACE \
    --userId '5WoOtwavdioadjCN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'PostPlayerBinaryPresignedURLV1' test.out

#- 83 GetPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicBinaryRecordsV1 \
    --key '0lC0MZRZAvhZ7XQm' \
    --namespace $AB_NAMESPACE \
    --userId 'cT57Hl2PvPOKvc25' \
    > test.out 2>&1
eval_tap $? 83 'GetPlayerPublicBinaryRecordsV1' test.out

#- 84 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "nnSLnEnv4ipAVJzP", "value": {"HM6kTwfu1vSD9gRO": {}, "MknwVRJfXHGB1r66": {}, "lbNcbMIJEY0BmpF2": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key '15jJycJcSyXLzU9U' \
    --namespace $AB_NAMESPACE \
    --userId 'qk079uhBLl4yz32R' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 85 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "qkNzYSNYl4zvyD8S", "value": {"UZv2LFFZer6T3W7T": {}, "E5WdocKzvgr3jBU2": {}, "g8Eo7uAb4HndxqQY": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'O14lFR2YtIb1fufx' \
    --namespace $AB_NAMESPACE \
    --userId 'JiodJFjEbn1ASMAi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 86 GetOtherPlayerPublicRecordKeyHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordKeyHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'edHoYv6WmW9mRXQw' \
    --limit '4' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 86 'GetOtherPlayerPublicRecordKeyHandlerV1' test.out

#- 87 GetOtherPlayerPublicRecordHandlerV1
# body param: body
echo '{"keys": ["5sfOZbgnCmULqltV", "5xjjrXKhZOekpygv", "RDCk0koCGDPfbiGd"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'BQ5DNVJAgfAkD0w0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'GetOtherPlayerPublicRecordHandlerV1' test.out

#- 88 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'H6QM5AsRnp9a7p0g' \
    --namespace $AB_NAMESPACE \
    --userId '0szNgC8yVFlwGULK' \
    > test.out 2>&1
eval_tap $? 88 'GetPlayerRecordHandlerV1' test.out

#- 89 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'eMzn4sG6P5R2lHU9' \
    --namespace $AB_NAMESPACE \
    --userId 'mf9rzrxuxtxg98cD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'PutPlayerRecordHandlerV1' test.out

#- 90 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'F1fsD5miAxHczgRu' \
    --namespace $AB_NAMESPACE \
    --userId '4VYjQq4VIVFUqNPu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 90 'PostPlayerRecordHandlerV1' test.out

#- 91 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'W223zuUv8ShbYBe9' \
    --namespace $AB_NAMESPACE \
    --userId 'hLKcN6myFUWf7IuL' \
    > test.out 2>&1
eval_tap $? 91 'DeletePlayerRecordHandlerV1' test.out

#- 92 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'G63jl9rYXaEFcUyS' \
    --namespace $AB_NAMESPACE \
    --userId 'nsIREQUlwDt2XB6D' \
    > test.out 2>&1
eval_tap $? 92 'GetPlayerPublicRecordHandlerV1' test.out

#- 93 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'goJm4dqrLVSBWToF' \
    --namespace $AB_NAMESPACE \
    --userId '03dQYi0OxI4DZZd2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'PutPlayerPublicRecordHandlerV1' test.out

#- 94 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'V80fjN9CwM4qNT3a' \
    --namespace $AB_NAMESPACE \
    --userId 'wIjWoFCW5BTW9laF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE