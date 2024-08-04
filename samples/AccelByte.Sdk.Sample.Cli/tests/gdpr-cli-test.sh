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
echo "1..39"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminGetListDeletionDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListDeletionDataRequest \
    --namespace $AB_NAMESPACE \
    --after 'bBuz5zkoaUEzGS3q' \
    --before 'Zf0PbemSBELbZ0VB' \
    --limit '96' \
    --offset '25' \
    --requestDate 'GA7nkDeev2Oj060H' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetListDeletionDataRequest' test.out

#- 3 GetAdminEmailConfiguration
$CLI_EXE \
    --sn gdpr \
    --op GetAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 3 'GetAdminEmailConfiguration' test.out

#- 4 UpdateAdminEmailConfiguration
# body param: body
echo '["nOf5S8X1LxkZs423", "3oQWoXFeqeuI2oMJ", "0cgAoGfXepE3r5AQ"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op UpdateAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateAdminEmailConfiguration' test.out

#- 5 SaveAdminEmailConfiguration
# body param: body
echo '["UBqS8KtTYZLJ58Qq", "cV3IcuNs9MF5BT2K", "D18yrWorpC65VJh4"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op SaveAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'SaveAdminEmailConfiguration' test.out

#- 6 DeleteAdminEmailConfiguration
$CLI_EXE \
    --sn gdpr \
    --op DeleteAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --emails '["q1z1KJmKedBfbWvK", "a5Ou124TsbQsxYFx", "GGHrfQkgXkiA5IZP"]' \
    > test.out 2>&1
eval_tap $? 6 'DeleteAdminEmailConfiguration' test.out

#- 7 AdminGetPlatformAccountClosureClient
$CLI_EXE \
    --sn gdpr \
    --op AdminGetPlatformAccountClosureClient \
    --namespace $AB_NAMESPACE \
    --platform 'qCqp9vcyt67WAfWX' \
    > test.out 2>&1
eval_tap $? 7 'AdminGetPlatformAccountClosureClient' test.out

#- 8 AdminUpdatePlatformAccountClosureClient
# body param: body
echo '{"clientId": "fUfwGB03tz8qIH4u", "secret": "RdNO08HN6s9p8Y5c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op AdminUpdatePlatformAccountClosureClient \
    --namespace $AB_NAMESPACE \
    --platform '9eItJtiNmY3y3n2R' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminUpdatePlatformAccountClosureClient' test.out

#- 9 AdminDeletePlatformAccountClosureClient
$CLI_EXE \
    --sn gdpr \
    --op AdminDeletePlatformAccountClosureClient \
    --namespace $AB_NAMESPACE \
    --platform 'im4NBqhuNtj8FOvK' \
    > test.out 2>&1
eval_tap $? 9 'AdminDeletePlatformAccountClosureClient' test.out

#- 10 AdminGetListPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --limit '57' \
    --offset '18' \
    --requestDate 'O7tbkTGYKqRMSTis' \
    > test.out 2>&1
eval_tap $? 10 'AdminGetListPersonalDataRequest' test.out

#- 11 AdminGetServicesConfiguration
$CLI_EXE \
    --sn gdpr \
    --op AdminGetServicesConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetServicesConfiguration' test.out

#- 12 AdminUpdateServicesConfiguration
# body param: body
echo '{"services": [{"extendConfig": {"appName": "P0MrSdaFy0pJYCdf", "namespace": "kfyt09ro5fHdWqJT"}, "id": "NjrmpnnEckHH8kT9", "serviceConfig": {"protocol": "EVENT", "skipAck": false, "url": "XVandercf1nq4Hf3"}, "type": "SERVICE"}, {"extendConfig": {"appName": "SL5PjaYEDxaYN8w9", "namespace": "KUW0py8KrcQfucSq"}, "id": "2X8gFuJORk4j04Yf", "serviceConfig": {"protocol": "EVENT", "skipAck": true, "url": "TsQUrA0WWyKl2K5m"}, "type": "SERVICE"}, {"extendConfig": {"appName": "fefdopcEM0JHfof2", "namespace": "Hwi7vg3osbh0fL2h"}, "id": "7eJvAS2W4uqkhwSC", "serviceConfig": {"protocol": "GRPC", "skipAck": true, "url": "ajwHO3LfvwPewrf1"}, "type": "EXTEND"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op AdminUpdateServicesConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateServicesConfiguration' test.out

#- 13 AdminResetServicesConfiguration
$CLI_EXE \
    --sn gdpr \
    --op AdminResetServicesConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminResetServicesConfiguration' test.out

#- 14 AdminGetPlatformAccountClosureServicesConfiguration
$CLI_EXE \
    --sn gdpr \
    --op AdminGetPlatformAccountClosureServicesConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminGetPlatformAccountClosureServicesConfiguration' test.out

#- 15 AdminUpdatePlatformAccountClosureServicesConfiguration
# body param: body
echo '{"services": [{"extendConfig": {"appName": "LgpQE9nXzhBC0uyM", "namespace": "R4Xf2nfYvNvG8uQ1"}, "id": "4AhsxaALiBwpNJor", "serviceConfig": {"protocol": "EVENT", "skipAck": true, "url": "m7NjUZ95Z5XDLBN9"}, "type": "EXTEND"}, {"extendConfig": {"appName": "GVPtkjt0OyBlJi4R", "namespace": "bZ0Iy11mfOFjCzZV"}, "id": "cGomWF1oAqUNFDtX", "serviceConfig": {"protocol": "EVENT", "skipAck": false, "url": "LvOAsW8wYh4gq7pR"}, "type": "EXTEND"}, {"extendConfig": {"appName": "ZVLJiDx3au9b9Qjh", "namespace": "zDlnJmi4XaBTgoXj"}, "id": "fdUQHa3RxspSqwdb", "serviceConfig": {"protocol": "GRPC", "skipAck": false, "url": "gzfaQrUCW9fgo69u"}, "type": "SERVICE"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op AdminUpdatePlatformAccountClosureServicesConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminUpdatePlatformAccountClosureServicesConfiguration' test.out

#- 16 AdminResetPlatformAccountClosureServicesConfiguration
$CLI_EXE \
    --sn gdpr \
    --op AdminResetPlatformAccountClosureServicesConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminResetPlatformAccountClosureServicesConfiguration' test.out

#- 17 AdminGetUserPlatformAccountClosureHistories
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserPlatformAccountClosureHistories \
    --namespace $AB_NAMESPACE \
    --limit '85' \
    --offset '14' \
    --platform 'bkFx8DmbC9UqYdYr' \
    --userId 'dxNnuMcAwrSzYnrc' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetUserPlatformAccountClosureHistories' test.out

#- 18 AdminGetUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'etxObeisZelKuD0i' \
    > test.out 2>&1
eval_tap $? 18 'AdminGetUserAccountDeletionRequest' test.out

#- 19 AdminSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'J6fs3zL9H4WxGWRH' \
    > test.out 2>&1
eval_tap $? 19 'AdminSubmitUserAccountDeletionRequest' test.out

#- 20 AdminCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId '7fz4BdPhLtHRJOIm' \
    > test.out 2>&1
eval_tap $? 20 'AdminCancelUserAccountDeletionRequest' test.out

#- 21 AdminGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'Sq37aeAaGq0NIj53' \
    --limit '12' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetUserPersonalDataRequests' test.out

#- 22 AdminRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op AdminRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'XkmrayvcIYiWxIAx' \
    --password 'fvLzSpDFY3lxe16K' \
    > test.out 2>&1
eval_tap $? 22 'AdminRequestDataRetrieval' test.out

#- 23 AdminCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'sSRzkf2HzBcEio5U' \
    --userId 'yvuFv5z6wosJGnUy' \
    > test.out 2>&1
eval_tap $? 23 'AdminCancelUserPersonalDataRequest' test.out

#- 24 AdminGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op AdminGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'CMEbHh1uE4DmJ4Su' \
    --userId 'j6DjUw36GtZ83Jp2' \
    --password 'f9f1FCoIo3L24DKG' \
    > test.out 2>&1
eval_tap $? 24 'AdminGeneratePersonalDataURL' test.out

#- 25 PublicSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'wgZ85vyFJR8euQBL' \
    --languageTag 'Vu27iwplLJdzYS9K' \
    --password '0VvwE6MAqPc8lGIY' \
    > test.out 2>&1
eval_tap $? 25 'PublicSubmitUserAccountDeletionRequest' test.out

#- 26 PublicCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'WTwxyqQQIXVmrtRl' \
    > test.out 2>&1
eval_tap $? 26 'PublicCancelUserAccountDeletionRequest' test.out

#- 27 PublicGetUserAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserAccountDeletionStatus \
    --namespace $AB_NAMESPACE \
    --userId 'q1jv60HTnmFrl3gY' \
    > test.out 2>&1
eval_tap $? 27 'PublicGetUserAccountDeletionStatus' test.out

#- 28 PublicGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'x6Xmv1DzPHux3k3s' \
    --limit '22' \
    --offset '52' \
    > test.out 2>&1
eval_tap $? 28 'PublicGetUserPersonalDataRequests' test.out

#- 29 PublicRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op PublicRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'hn3mWZjTYM95e4aa' \
    --languageTag '8xOJu7rNRVdygfKm' \
    --password 'Ukzj9mHFpff2vDkz' \
    > test.out 2>&1
eval_tap $? 29 'PublicRequestDataRetrieval' test.out

#- 30 PublicCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate '68zorEgcExv9nKMO' \
    --userId 'gO5W8SUaZjCpNtJS' \
    > test.out 2>&1
eval_tap $? 30 'PublicCancelUserPersonalDataRequest' test.out

#- 31 PublicGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op PublicGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'Mm8kDi3Rwubq7wtR' \
    --userId 'GdT447Oa51m6VLfj' \
    --password 'sw270pMmOQJrpEBb' \
    > test.out 2>&1
eval_tap $? 31 'PublicGeneratePersonalDataURL' test.out

#- 32 PublicSubmitMyAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitMyAccountDeletionRequest \
    --platformId 'VvBn8Lsf2qSAtizV' \
    --platformToken '9hzsVbpJLtEZjuyF' \
    > test.out 2>&1
eval_tap $? 32 'PublicSubmitMyAccountDeletionRequest' test.out

#- 33 PublicCancelMyAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelMyAccountDeletionRequest \
    > test.out 2>&1
eval_tap $? 33 'PublicCancelMyAccountDeletionRequest' test.out

#- 34 PublicGetMyAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetMyAccountDeletionStatus \
    > test.out 2>&1
eval_tap $? 34 'PublicGetMyAccountDeletionStatus' test.out

#- 35 S2SGetListFinishedAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op S2SGetListFinishedAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --end 'hvbxX2DNbknfVv4n' \
    --start 'm70TCayYAkF18YBw' \
    > test.out 2>&1
eval_tap $? 35 'S2SGetListFinishedAccountDeletionRequest' test.out

#- 36 S2SGetListFinishedPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op S2SGetListFinishedPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --end 'RxcREyU5CwqGJF6n' \
    --start 'Di33Iztr2QcwlRrR' \
    > test.out 2>&1
eval_tap $? 36 'S2SGetListFinishedPersonalDataRequest' test.out

#- 37 S2SSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op S2SSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'eRajlpk8lfuiJVck' \
    > test.out 2>&1
eval_tap $? 37 'S2SSubmitUserAccountDeletionRequest' test.out

#- 38 S2SRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op S2SRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'tlx9zJZVVCc9bpIH' \
    > test.out 2>&1
eval_tap $? 38 'S2SRequestDataRetrieval' test.out

#- 39 S2SGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op S2SGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'EWQMmCkIqwqpoTVC' \
    --userId 'NrcaVozsjIXO2EUs' \
    > test.out 2>&1
eval_tap $? 39 'S2SGeneratePersonalDataURL' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE