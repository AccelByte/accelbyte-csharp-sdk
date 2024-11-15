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
echo "1..104"

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
    --tags '["MLqpQwkRRHkaiKsm", "IiRLR3IlNJKxhPfW", "V6dIabcFbSmeuIBr"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAdminGameRecordV1' test.out

#- 3 AdminBulkGetAdminGameRecordV1
# body param: body
echo '{"keys": ["oF7bwRgwKvzESbhp", "xlDdEs4igdKeLmy8", "tZ5GZi5P12c61ts3"]}' > $TEMP_JSON_INPUT
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
    --key 'fMI04rm2jUc9iav3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetAdminGameRecordV1' test.out

#- 5 AdminPutAdminGameRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordV1 \
    --key 'tTqlE9oLDPD0Lfle' \
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
    --key '8ESU1MO8XnVaEyjm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostAdminGameRecordV1' test.out

#- 7 AdminDeleteAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminGameRecordV1 \
    --key 'ifJDYa1TJPUszmFG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteAdminGameRecordV1' test.out

#- 8 AdminListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '62' \
    --offset '68' \
    --query 'kJVvqDSU3PDyIAGf' \
    --tags '["Gq1FNmRWvUvDPnKo", "ECjGUg867xodwuG1", "4ID5l5wj6K2wEMnc"]' \
    > test.out 2>&1
eval_tap $? 8 'AdminListGameBinaryRecordsV1' test.out

#- 9 AdminPostGameBinaryRecordV1
# body param: body
echo '{"file_type": "kjlW6BywsSSZTGlu", "key": "bsmhjXcScOUvrjJB", "set_by": "SERVER", "ttl_config": {"action": "DELETE", "expires_at": "1980-01-11T00:00:00Z"}}' > $TEMP_JSON_INPUT
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
    --key 'LpERf77LzPoORBkR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetGameBinaryRecordV1' test.out

#- 11 AdminPutGameBinaryRecordV1
# body param: body
echo '{"content_type": "mZ0A2zyZsb4FvWFI", "file_location": "HPIbOjpls9BZTYc5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecordV1 \
    --key 'BsdSSVaAzzn4Gbgk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminPutGameBinaryRecordV1' test.out

#- 12 AdminDeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameBinaryRecordV1 \
    --key 'KeCaS6qyUCscHXs8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteGameBinaryRecordV1' test.out

#- 13 AdminPutGameBinaryRecorMetadataV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["PjaYEDxaYN8w9KUW", "0py8KrcQfucSq2X8", "gFuJORk4j04YfnXT"], "ttl_config": {"action": "DELETE", "expires_at": "1971-12-19T00:00:00Z"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecorMetadataV1 \
    --key 'nddzgwxYdQc5hEfe' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminPutGameBinaryRecorMetadataV1' test.out

#- 14 AdminPostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "fdopcEM0JHfof2Hw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryPresignedURLV1 \
    --key 'i7vg3osbh0fL2h7e' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPostGameBinaryPresignedURLV1' test.out

#- 15 DeleteGameBinaryRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordTTLConfig \
    --key 'JvAS2W4uqkhwSC7E' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DeleteGameBinaryRecordTTLConfig' test.out

#- 16 AdminPutAdminGameRecordConcurrentHandlerV1
# body param: body
echo '{"tags": ["ajwHO3LfvwPewrf1", "9Njm50xCDlPeNq0C", "vMXtyUWXrdZaFeac"], "updatedAt": "1987-12-12T00:00:00Z", "value": {"T2x6o28Njxyw7RHl": {}, "dq0m7NjUZ95Z5XDL": {}, "BN9YGVPtkjt0OyBl": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordConcurrentHandlerV1 \
    --key 'Ji4RbZ0Iy11mfOFj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminPutAdminGameRecordConcurrentHandlerV1' test.out

#- 17 AdminPutGameRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "SERVER", "tags": ["frpCrnbaxhEvn3SG", "qcH91fC3aJEoqWaF", "AGD6PRg95m07l03v"], "ttl_config": {"action": "DELETE", "expires_at": "1976-01-11T00:00:00Z"}, "updatedAt": "1990-09-10T00:00:00Z", "value": {"QjhzDlnJmi4XaBTg": {}, "oXjfdUQHa3RxspSq": {}, "wdbTR2sgzfaQrUCW": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key '9fgo69uv1bkFx8Dm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 18 GetPluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op GetPluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetPluginConfig' test.out

#- 19 CreatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "bC9UqYdYrdxNnuMc"}, "customConfig": {"GRPCAddress": "AwrSzYnrcetxObei"}, "customFunction": {"afterBulkReadGameBinaryRecord": true, "afterBulkReadGameRecord": false, "afterBulkReadPlayerBinaryRecord": false, "afterBulkReadPlayerRecord": true, "afterReadGameBinaryRecord": false, "afterReadGameRecord": true, "afterReadPlayerBinaryRecord": true, "afterReadPlayerRecord": false, "beforeWriteAdminGameRecord": false, "beforeWriteAdminPlayerRecord": true, "beforeWriteGameBinaryRecord": true, "beforeWriteGameRecord": false, "beforeWritePlayerBinaryRecord": true, "beforeWritePlayerRecord": true}, "extendType": "CUSTOM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op CreatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'CreatePluginConfig' test.out

#- 20 DeletePluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeletePluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'DeletePluginConfig' test.out

#- 21 UpdatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "CYwoGdmzXgf1ewUT"}, "customConfig": {"GRPCAddress": "vnu0ensa3MZF7DTs"}, "customFunction": {"afterBulkReadGameBinaryRecord": true, "afterBulkReadGameRecord": true, "afterBulkReadPlayerBinaryRecord": false, "afterBulkReadPlayerRecord": false, "afterReadGameBinaryRecord": false, "afterReadGameRecord": true, "afterReadPlayerBinaryRecord": true, "afterReadPlayerRecord": true, "beforeWriteAdminGameRecord": false, "beforeWriteAdminPlayerRecord": false, "beforeWriteGameBinaryRecord": false, "beforeWriteGameRecord": false, "beforeWritePlayerBinaryRecord": false, "beforeWritePlayerRecord": true}, "extendType": "APP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op UpdatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdatePluginConfig' test.out

#- 22 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query 'EIAePvDO2xkVgyRk' \
    --tags '["10b27RdU8VceYQ9e", "rPYQ5yVcQuvDbGMq", "bEHkCQwMBcQUNPHN"]' \
    --limit '16' \
    --offset '42' \
    > test.out 2>&1
eval_tap $? 22 'ListGameRecordsHandlerV1' test.out

#- 23 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'T0yJJ0uCjjaNCRV3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminGetGameRecordHandlerV1' test.out

#- 24 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'hSIiTEoTCSxjAqg9' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminPutGameRecordHandlerV1' test.out

#- 25 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'oGVEdC8mQir1Af0G' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminPostGameRecordHandlerV1' test.out

#- 26 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key '6OrPH6ZsjpPgHKIS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'AdminDeleteGameRecordHandlerV1' test.out

#- 27 DeleteGameRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordTTLConfig \
    --key 'HtB8tWdJM9Qc5HmR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'DeleteGameRecordTTLConfig' test.out

#- 28 AdminListTagsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListTagsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --limit '34' \
    --offset '43' \
    > test.out 2>&1
eval_tap $? 28 'AdminListTagsHandlerV1' test.out

#- 29 AdminPostTagHandlerV1
# body param: body
echo '{"tag": "Pc8lGIYWTwxyqQQI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostTagHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminPostTagHandlerV1' test.out

#- 30 AdminDeleteTagHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteTagHandlerV1 \
    --namespace $AB_NAMESPACE \
    --tag 'XVmrtRlq1jv60HTn' \
    > test.out 2>&1
eval_tap $? 30 'AdminDeleteTagHandlerV1' test.out

#- 31 BulkGetAdminPlayerRecordByUserIdsV1
# body param: body
echo '{"userIds": ["mFrl3gYx6Xmv1DzP", "Hux3k3skhn3mWZjT", "YM95e4aa8xOJu7rN"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetAdminPlayerRecordByUserIdsV1 \
    --key 'RVdygfKmUkzj9mHF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'BulkGetAdminPlayerRecordByUserIdsV1' test.out

#- 32 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["pff2vDkz68zorEgc", "Exv9nKMOgO5W8SUa", "ZjCpNtJSMm8kDi3R"], "user_id": "wubq7wtRGdT447Oa"}, {"keys": ["51m6VLfjsw270pMm", "OQJrpEBbVvBn8Lsf", "2qSAtizV9hzsVbpJ"], "user_id": "LtEZjuyFhvbxX2DN"}, {"keys": ["bknfVv4nm70TCayY", "AkF18YBwRxcREyU5", "CwqGJF6nDi33Iztr"], "user_id": "2QcwlRrReRajlpk8"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerRecordSizeHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'BulkGetPlayerRecordSizeHandlerV1' test.out

#- 33 ListPlayerRecordHandlerV1
eval_tap 0 33 'ListPlayerRecordHandlerV1 # SKIP deprecated' test.out

#- 34 AdminBulkPutPlayerRecordsByKeyHandlerV1
# body param: body
echo '{"data": [{"user_id": "lfuiJVcktlx9zJZV", "value": {"VCc9bpIHEWQMmCkI": {}, "qwqpoTVCNrcaVozs": {}, "jIXO2EUsAfBvo6Ll": {}}}, {"user_id": "calks2R3VMtipTVx", "value": {"XAF8KhOKqbrECijF": {}, "xOpOzxeTLJQsZcTE": {}, "zXaXUzpsAV6ct6XI": {}}}, {"user_id": "TL0QEkadMSQluAoE", "value": {"D9oYwS8oLyErKvRt": {}, "HFGJRoGW7VBG1VB2": {}, "sp2x9mszGGoyhGZA": {}}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkPutPlayerRecordsByKeyHandlerV1 \
    --key 'zt2OVBTLwSH8hWRU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminBulkPutPlayerRecordsByKeyHandlerV1' test.out

#- 35 AdminBulkGetPlayerRecordsByUserIDsHandlerV1
# body param: body
echo '{"userIds": ["9pbItGQ7VUWBhGol", "wafIfbF1GLFnrQ4T", "5cmw7U1TxiS06UEo"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetPlayerRecordsByUserIDsHandlerV1 \
    --key 'aDZpXOWzpXOi2cpa' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'AdminBulkGetPlayerRecordsByUserIDsHandlerV1' test.out

#- 36 AdminListAdminUserRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListAdminUserRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'jtqcXjPkj2IzU3ME' \
    --limit '31' \
    --offset '59' \
    --query 'Ct1IjlfHJM92t9j1' \
    --tags '["XT2ErwIxkaTnYtr1", "YDnaXB0JOS4XKVT6", "6sHYPgVsfhoEidKw"]' \
    > test.out 2>&1
eval_tap $? 36 'AdminListAdminUserRecordsV1' test.out

#- 37 AdminBulkGetAdminPlayerRecordV1
# body param: body
echo '{"keys": ["4IP0NVnaangorhVF", "pTRuQyMroT2hNfKJ", "7q8sifSPmYSsBxty"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetAdminPlayerRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'KWssEn5VEvIMEB4p' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminBulkGetAdminPlayerRecordV1' test.out

#- 38 AdminGetAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetAdminPlayerRecordV1 \
    --key 'l506fLCG6EAl7d3K' \
    --namespace $AB_NAMESPACE \
    --userId 's65thtnjcMSw1J42' \
    > test.out 2>&1
eval_tap $? 38 'AdminGetAdminPlayerRecordV1' test.out

#- 39 AdminPutAdminPlayerRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordV1 \
    --key 'fthKUobas2CAlSxx' \
    --namespace $AB_NAMESPACE \
    --userId 'VhDR9hlaznetBUGc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminPutAdminPlayerRecordV1' test.out

#- 40 AdminPostPlayerAdminRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerAdminRecordV1 \
    --key 'Qz2WvdiclkYGDL2c' \
    --namespace $AB_NAMESPACE \
    --userId 'kC9cdzaLnajQ8GnJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminPostPlayerAdminRecordV1' test.out

#- 41 AdminDeleteAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminPlayerRecordV1 \
    --key 'pALiddv9UUtG1tEE' \
    --namespace $AB_NAMESPACE \
    --userId 'Csm8xaDOz0tMlpFu' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteAdminPlayerRecordV1' test.out

#- 42 AdminListPlayerBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListPlayerBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'JVXo9s0JPG8cgjHQ' \
    --limit '29' \
    --offset '96' \
    --query '9HoLLyUnPTiCD003' \
    --tags '["8or8wR0tuwIJnrSI", "2IFcRwSoMTuJziuD", "NbOydiu3lOaruuYw"]' \
    > test.out 2>&1
eval_tap $? 42 'AdminListPlayerBinaryRecordsV1' test.out

#- 43 AdminPostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "0iUuts6bChMK1gcx", "is_public": false, "key": "p9fyv5PoMJeTIQix", "set_by": "CLIENT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'FEvzlipE7r0vhh21' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminPostPlayerBinaryRecordV1' test.out

#- 44 AdminGetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerBinaryRecordV1 \
    --key 'v5772AopmjI7CbY2' \
    --namespace $AB_NAMESPACE \
    --userId 'WuwRUT9IivgC4mJ5' \
    > test.out 2>&1
eval_tap $? 44 'AdminGetPlayerBinaryRecordV1' test.out

#- 45 AdminPutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "OHuNEVQK4Mvk00I9", "file_location": "GqAhhjNIivdIcaEQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecordV1 \
    --key 'fNETQCBPK1mYwKVQ' \
    --namespace $AB_NAMESPACE \
    --userId 'oydbYjXZyBpqhCJB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'AdminPutPlayerBinaryRecordV1' test.out

#- 46 AdminDeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerBinaryRecordV1 \
    --key 'tFOm3iCpu0lhhgut' \
    --namespace $AB_NAMESPACE \
    --userId 't3rQuKP1OEtKFBjN' \
    > test.out 2>&1
eval_tap $? 46 'AdminDeletePlayerBinaryRecordV1' test.out

#- 47 AdminPutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": false, "set_by": "SERVER", "tags": ["hHU8GP8TRVypSvYX", "Kz4BGjbsrRBV8azt", "J86yQK1AsC18UO6J"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecorMetadataV1 \
    --key 'cXmwQfkseTpH6l2D' \
    --namespace $AB_NAMESPACE \
    --userId 'v8SvqYKc56PcPSL2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminPutPlayerBinaryRecorMetadataV1' test.out

#- 48 AdminPostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "xmjViKkKw4gHA4Ca"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryPresignedURLV1 \
    --key 'LsPqRsTdKzcKtkGc' \
    --namespace $AB_NAMESPACE \
    --userId 'vn44NWse6VLPkM1V' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'AdminPostPlayerBinaryPresignedURLV1' test.out

#- 49 AdminPutAdminPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"tags": ["TrQBywhJ7lbBLw9x", "y1WQM5qUS8baUqkz", "Sr41y6RPBHJuPjj8"], "updatedAt": "1984-12-03T00:00:00Z", "value": {"DwOk0IgmYfUTpFzy": {}, "QhPVhRGX9xlUKhXI": {}, "8mL8OIhvP68xE68d": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordConcurrentHandlerV1 \
    --key 'zohxhbej2caIIfkX' \
    --namespace $AB_NAMESPACE \
    --userId 'DY7jnhp3qY6T7TUE' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'AdminPutAdminPlayerRecordConcurrentHandlerV1' test.out

#- 50 AdminPutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["E90E4ZboiXT1Uy0g", "ArtDpQE4bOtoiAjH", "XcVVOsVywU6uisej"], "ttl_config": {"action": "DELETE", "expires_at": "1977-05-04T00:00:00Z"}, "updatedAt": "1976-02-16T00:00:00Z", "value": {"gGnTHAsTCZa7xE4n": {}, "wGKlbPRxfucxoRKF": {}, "LxxcL9SyuHbvRxR6": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key 'LaKWgAVjZKDxiezE' \
    --namespace $AB_NAMESPACE \
    --userId 'buMCz9J4dPRGzoQL' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 51 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["ZvyPupimCENHEenq", "jRSxO9oZ0fCxLR0G", "fjwCmDrbDR0Q0ixp"], "ttl_config": {"action": "DELETE", "expires_at": "1995-06-09T00:00:00Z"}, "updatedAt": "1985-03-23T00:00:00Z", "value": {"Pt1LUaTvrFaxzOfG": {}, "3pTddIA0Rt6wM5oQ": {}, "vTMICtWyUtVDnhgT": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'GXO8Utpwxug8Mpqc' \
    --namespace $AB_NAMESPACE \
    --userId 'zRvUdK1uOV1ZJTYu' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 52 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'FnVzdbNW1xuV7rVe' \
    --limit '16' \
    --offset '57' \
    --query '1o9zV6rhVfcQmLfE' \
    --tags '["n5ZUGeYlOwODWBAz", "6skHMfl4Hjw9KEnx", "8cNfDK45zWtwYhRo"]' \
    > test.out 2>&1
eval_tap $? 52 'AdminRetrievePlayerRecords' test.out

#- 53 AdminPutPlayerRecordsHandlerV1
# body param: body
echo '{"data": [{"key": "NPwKema6caMTOciv", "value": {"PAkmP8Awb0NqtvSR": {}, "9q6l5k9BLQMrPoTu": {}, "xdzEYAw5VdW05WnQ": {}}}, {"key": "EAbK416LN2N6D6yc", "value": {"zitn4OkZfx0Xa6sg": {}, "egAWYz2z4qSPPQBD": {}, "FQsvRHbGTC2ynue7": {}}}, {"key": "Xk4uDF5mdakWJ2As", "value": {"Kf8UfQqTQ8v7gXyF": {}, "uLFZViQbxYQvUyap": {}, "o6FmMy6tZYSCe7du": {}}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId '68Ce6T4pYH3BPyFu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminPutPlayerRecordsHandlerV1' test.out

#- 54 AdminGetPlayerRecordsHandlerV1
# body param: body
echo '{"keys": ["rT4p8zoRYG8WKTaU", "yB0UyrKKulHUnomp", "TrS7DIOakX65w7Rp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'xY6pd1QTpFpaxbCj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AdminGetPlayerRecordsHandlerV1' test.out

#- 55 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key 'HSCXM7sL1nnOoRIg' \
    --namespace $AB_NAMESPACE \
    --userId '7oSh4yVttp53wasu' \
    > test.out 2>&1
eval_tap $? 55 'AdminGetPlayerRecordHandlerV1' test.out

#- 56 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'HbA0keUomVCh681O' \
    --namespace $AB_NAMESPACE \
    --userId 'MZFNRw8YvLGLnB4x' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'AdminPutPlayerRecordHandlerV1' test.out

#- 57 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'fqdHhPHA2ZbIvW1o' \
    --namespace $AB_NAMESPACE \
    --userId 'xENH4MsVlbCMc5hx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminPostPlayerRecordHandlerV1' test.out

#- 58 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key '0W14SkvovINegS29' \
    --namespace $AB_NAMESPACE \
    --userId 'legebqGwej59Ok8E' \
    > test.out 2>&1
eval_tap $? 58 'AdminDeletePlayerRecordHandlerV1' test.out

#- 59 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'M0OFW93FkJicmK6q' \
    --namespace $AB_NAMESPACE \
    --userId 'eaDEm9bPCS2a5WoO' \
    > test.out 2>&1
eval_tap $? 59 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 60 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key 'twavdioadjCN0lC0' \
    --namespace $AB_NAMESPACE \
    --userId 'MZRZAvhZ7XQmcT57' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 61 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'Hl2PvPOKvc25nnSL' \
    --namespace $AB_NAMESPACE \
    --userId 'nEnv4ipAVJzPHM6k' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 62 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'Twfu1vSD9gROMknw' \
    --namespace $AB_NAMESPACE \
    --userId 'VRJfXHGB1r66lbNc' \
    > test.out 2>&1
eval_tap $? 62 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 63 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key 'bMIJEY0BmpF215jJ' \
    --namespace $AB_NAMESPACE \
    --userId 'ycJcSyXLzU9Uqk07' \
    > test.out 2>&1
eval_tap $? 63 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 64 ListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '34' \
    --offset '42' \
    --query 'YrUpXncYv2BVIS1B' \
    --tags '["tMqvdE5QQizMBWYP", "YerJ1FmKBX6U18gM", "Il7TSPm96MsoQcFD"]' \
    > test.out 2>&1
eval_tap $? 64 'ListGameBinaryRecordsV1' test.out

#- 65 PostGameBinaryRecordV1
# body param: body
echo '{"file_type": "fKSJymqZ5tDVsJ63", "key": "mFWW0u95r5ylQKcW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PostGameBinaryRecordV1' test.out

#- 66 BulkGetGameBinaryRecordV1
# body param: body
echo '{"keys": ["i0o5zcWp7NiTBI4m", "6PVEQWCNw7DHkXx8", "NqXaR2w60X5Vb0TV"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'BulkGetGameBinaryRecordV1' test.out

#- 67 GetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameBinaryRecordV1 \
    --key '0x3nmq9UCZbdVFY3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetGameBinaryRecordV1' test.out

#- 68 PutGameBinaryRecordV1
# body param: body
echo '{"content_type": "WdZ6luOW977Egotv", "file_location": "OrnRjb5UT6Vf5jxo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameBinaryRecordV1 \
    --key 'BBg2lM3DQXyC3oKu' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PutGameBinaryRecordV1' test.out

#- 69 DeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordV1 \
    --key '14sRjkCeuRY0tsnb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'DeleteGameBinaryRecordV1' test.out

#- 70 PostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "KAGRTCvAZKiSB7bY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryPresignedURLV1 \
    --key 'vWmbUbWlRZtcIUry' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PostGameBinaryPresignedURLV1' test.out

#- 71 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "1977-07-17T00:00:00Z", "value": {"iAxHczgRu4VYjQq4": {}, "VIVFUqNPuW223zuU": {}, "v8ShbYBe9hLKcN6m": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'yFUWf7IuLG63jl9r' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PutGameRecordConcurrentHandlerV1' test.out

#- 72 GetGameRecordsBulk
# body param: body
echo '{"keys": ["YXaEFcUySnsIREQU", "lwDt2XB6DgoJm4dq", "rLVSBWToF03dQYi0"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordsBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'GetGameRecordsBulk' test.out

#- 73 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'OxI4DZZd2V80fjN9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'GetGameRecordHandlerV1' test.out

#- 74 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key 'CwM4qNT3awIjWoFC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'PutGameRecordHandlerV1' test.out

#- 75 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'W5BTW9laFjsd7gSF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PostGameRecordHandlerV1' test.out

#- 76 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'kIVGnXJLeUdD8XNx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 76 'DeleteGameRecordHandlerV1' test.out

#- 77 PublicListTagsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicListTagsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --limit '55' \
    --offset '20' \
    > test.out 2>&1
eval_tap $? 77 'PublicListTagsHandlerV1' test.out

#- 78 BulkGetPlayerPublicBinaryRecordsV1
# body param: body
echo '{"userIds": ["Y8IVtOeznPwNRnzt", "P1VeNj0XYtINcOQI", "iLdvpuYVOAU9uuKP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicBinaryRecordsV1 \
    --key 'GNN6m8BLNzJxMR9F' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'BulkGetPlayerPublicBinaryRecordsV1' test.out

#- 79 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["8QPVUh3Fxn8VCvtd", "iiwNMAdIodiW3hcY", "uKSRkkKQKIVOduQw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'wDrBnpQpIKdlw0Q8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 80 ListMyBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListMyBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '88' \
    --offset '54' \
    --query 'm0lpTupwpI0MCORO' \
    --tags '["WHgnYO9A4NtX4m0L", "4BGxxcKUh2wepEjv", "h8sTPE7JfL8ZG7IB"]' \
    > test.out 2>&1
eval_tap $? 80 'ListMyBinaryRecordsV1' test.out

#- 81 BulkGetMyBinaryRecordV1
# body param: body
echo '{"keys": ["iOpvSKRmJcE8fHWU", "8tF9Tj5DH9jDJgqZ", "agf9TfKsyiaqf0Vf"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetMyBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkGetMyBinaryRecordV1' test.out

#- 82 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --offset '97' \
    --tags '["dvwpghGz92mfgwfe", "wY0DMU8QuojVb8Qg", "dEnIEDOXPqBEIQJ9"]' \
    > test.out 2>&1
eval_tap $? 82 'RetrievePlayerRecords' test.out

#- 83 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["2jD6Oo7qDSKsqbeu", "vGhaO0uibTsnrycs", "u5Q9BFGk7WCNwFDv"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordsBulkHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'GetPlayerRecordsBulkHandlerV1' test.out

#- 84 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key 'Ihdx6Z0l07ceeKMs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 84 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 85 PostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "QFyZCXx6V8vj07Wk", "is_public": true, "key": "CxGEBsc3HVarhLlw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'lmf1l5JhrQSpGlgu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PostPlayerBinaryRecordV1' test.out

#- 86 ListOtherPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'vTECefhiKKuc8Urg' \
    --limit '57' \
    --offset '2' \
    --tags '["3AI1r9iOvxo4sO2v", "2SBoI1cMTFoDvnFj", "F7PyPSihYagCDowX"]' \
    > test.out 2>&1
eval_tap $? 86 'ListOtherPlayerPublicBinaryRecordsV1' test.out

#- 87 BulkGetOtherPlayerPublicBinaryRecordsV1
# body param: body
echo '{"keys": ["pzPB56b3OlkJK0TM", "s61QJU3NQDgVJljn", "vyeys0Kd9lSy4dXR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'irNN1XTVbZINAYTf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'BulkGetOtherPlayerPublicBinaryRecordsV1' test.out

#- 88 GetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerBinaryRecordV1 \
    --key 'mDdnbfKLdllLcrgG' \
    --namespace $AB_NAMESPACE \
    --userId '7MUCvBQxDMKfZnQU' \
    > test.out 2>&1
eval_tap $? 88 'GetPlayerBinaryRecordV1' test.out

#- 89 PutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "HzroRILUYE0mbvUd", "file_location": "fY0BqpFwpFSBitpr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecordV1 \
    --key 'tx35PWwBW4wLASmN' \
    --namespace $AB_NAMESPACE \
    --userId 'zxcUMh0SvR4rhLLv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'PutPlayerBinaryRecordV1' test.out

#- 90 DeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerBinaryRecordV1 \
    --key 'UwAWnj9yPsgbHDua' \
    --namespace $AB_NAMESPACE \
    --userId 'BMlhmWv2CjjBQfnF' \
    > test.out 2>&1
eval_tap $? 90 'DeletePlayerBinaryRecordV1' test.out

#- 91 PutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecorMetadataV1 \
    --key 'spKpEPUUxc2NKFB2' \
    --namespace $AB_NAMESPACE \
    --userId 'qxCiWMNdvN9SDRKy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'PutPlayerBinaryRecorMetadataV1' test.out

#- 92 PostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "e6n1t8RXF5qayS4U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryPresignedURLV1 \
    --key 'AMJrRrnNfXdTnJz7' \
    --namespace $AB_NAMESPACE \
    --userId 'e3tD8KVlMU17V03Q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'PostPlayerBinaryPresignedURLV1' test.out

#- 93 GetPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicBinaryRecordsV1 \
    --key 'DQjU64lc3oek3RWX' \
    --namespace $AB_NAMESPACE \
    --userId 'WJhPXvS9OmmtZ14X' \
    > test.out 2>&1
eval_tap $? 93 'GetPlayerPublicBinaryRecordsV1' test.out

#- 94 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "1993-11-27T00:00:00Z", "value": {"yZTqfCi5CJgLU0r1": {}, "txp0vdRA0J8eLCZr": {}, "cT7EO7zBX353qlmB": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key 'OmzDZoLl4yLZgHla' \
    --namespace $AB_NAMESPACE \
    --userId 'tL7nbsrfkzQM5RtM' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 95 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "1990-08-20T00:00:00Z", "value": {"g00KvHLdMiaje6w7": {}, "YN9MWtYzurSMcK8c": {}, "5xZukais9TopwzyV": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'Fe9lNT7v5QycBCxJ' \
    --namespace $AB_NAMESPACE \
    --userId 'G7DehSEc6kg2UWX8' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 96 GetOtherPlayerPublicRecordKeyHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordKeyHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'PboGcBp08H0whjTC' \
    --limit '4' \
    --offset '87' \
    --tags '["eEjsJO7xZUK7lMGD", "nKhxDxWqk0FyDBDB", "xAznXS1mfs6uZ9Oa"]' \
    > test.out 2>&1
eval_tap $? 96 'GetOtherPlayerPublicRecordKeyHandlerV1' test.out

#- 97 GetOtherPlayerPublicRecordHandlerV1
# body param: body
echo '{"keys": ["Zwm6pPAdF5lHMHzB", "ycY7bXyRpFUts9Cp", "uTZNXAvR5mEjDGi8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Z9KuTHuT6IlImbAY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'GetOtherPlayerPublicRecordHandlerV1' test.out

#- 98 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'CRvUBIHoIhUnq8Et' \
    --namespace $AB_NAMESPACE \
    --userId 'mzVPJFqDDsFmDKPi' \
    > test.out 2>&1
eval_tap $? 98 'GetPlayerRecordHandlerV1' test.out

#- 99 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'xcJtgNHrTEQpFB5a' \
    --namespace $AB_NAMESPACE \
    --userId 'eIMGxoyLMqSLDNxu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'PutPlayerRecordHandlerV1' test.out

#- 100 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'BA95CXk3K2oLMyvJ' \
    --namespace $AB_NAMESPACE \
    --userId '6M0zKUQCLksfhWE1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 100 'PostPlayerRecordHandlerV1' test.out

#- 101 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'OiCOozFmZ3hzpayQ' \
    --namespace $AB_NAMESPACE \
    --userId '1ySXmHgROq1X5e82' \
    > test.out 2>&1
eval_tap $? 101 'DeletePlayerRecordHandlerV1' test.out

#- 102 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'zDrJtNcl4ztsaFwr' \
    --namespace $AB_NAMESPACE \
    --userId 'ylG42gHaf4XEHX7Q' \
    > test.out 2>&1
eval_tap $? 102 'GetPlayerPublicRecordHandlerV1' test.out

#- 103 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'BUYvSupGJqpwAp0W' \
    --namespace $AB_NAMESPACE \
    --userId 'Mu7ZUAbKsKi0fuip' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 103 'PutPlayerPublicRecordHandlerV1' test.out

#- 104 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'dvULHrqNhX3eWB4h' \
    --namespace $AB_NAMESPACE \
    --userId 'fA53Ibtklb9jB4Gc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 104 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE