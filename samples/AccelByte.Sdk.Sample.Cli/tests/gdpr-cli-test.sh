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
echo "1..21"

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
    --after 'DgzfVaOH' \
    --before 'KbtorDJp' \
    --limit '45' \
    --offset '53' \
    --requestDate 'kn4rzYR5' \
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
echo '["5iUAu82x", "IFeVRz8j", "jDAEDPQw"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op UpdateAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateAdminEmailConfiguration' test.out

#- 5 SaveAdminEmailConfiguration
# body param: body
echo '["WrXX03BA", "GZGU46RD", "VpUaLWqp"]' > $TEMP_JSON_INPUT
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
    --emails '["GyMB4sLS", "6lY2iGvk", "cFprKHzW"]' \
    > test.out 2>&1
eval_tap $? 6 'DeleteAdminEmailConfiguration' test.out

#- 7 AdminGetListPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --limit '67' \
    --offset '55' \
    --requestDate 'Fjutti0L' \
    > test.out 2>&1
eval_tap $? 7 'AdminGetListPersonalDataRequest' test.out

#- 8 AdminGetUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'bIZueD1I' \
    > test.out 2>&1
eval_tap $? 8 'AdminGetUserAccountDeletionRequest' test.out

#- 9 AdminSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'eE0ug8Mx' \
    > test.out 2>&1
eval_tap $? 9 'AdminSubmitUserAccountDeletionRequest' test.out

#- 10 AdminCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId '1xzKxhT7' \
    > test.out 2>&1
eval_tap $? 10 'AdminCancelUserAccountDeletionRequest' test.out

#- 11 AdminGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'fkQ1HTBk' \
    --limit '70' \
    --offset '7' \
    > test.out 2>&1
eval_tap $? 11 'AdminGetUserPersonalDataRequests' test.out

#- 12 AdminRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op AdminRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId '9evJNz12' \
    --password 'W7wh5UCi' \
    > test.out 2>&1
eval_tap $? 12 'AdminRequestDataRetrieval' test.out

#- 13 AdminCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'dF0JMvYe' \
    --userId 'Dvg5EzYF' \
    > test.out 2>&1
eval_tap $? 13 'AdminCancelUserPersonalDataRequest' test.out

#- 14 AdminGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op AdminGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'tv6EIo8G' \
    --userId 'wxBK4uRq' \
    --password 'FbGIEIUa' \
    > test.out 2>&1
eval_tap $? 14 'AdminGeneratePersonalDataURL' test.out

#- 15 PublicSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'uLrmsGt5' \
    --password 'bfkzJyvI' \
    > test.out 2>&1
eval_tap $? 15 'PublicSubmitUserAccountDeletionRequest' test.out

#- 16 PublicCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'DRWwP4eV' \
    > test.out 2>&1
eval_tap $? 16 'PublicCancelUserAccountDeletionRequest' test.out

#- 17 PublicGetUserAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserAccountDeletionStatus \
    --namespace $AB_NAMESPACE \
    --userId 'itKD8HGA' \
    > test.out 2>&1
eval_tap $? 17 'PublicGetUserAccountDeletionStatus' test.out

#- 18 PublicGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'V2aSuLak' \
    --limit '84' \
    --offset '68' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetUserPersonalDataRequests' test.out

#- 19 PublicRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op PublicRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'P8dm2W1V' \
    --password 'tzZaiwc1' \
    > test.out 2>&1
eval_tap $? 19 'PublicRequestDataRetrieval' test.out

#- 20 PublicCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'r85NSTvM' \
    --userId 'HMLW3tzm' \
    > test.out 2>&1
eval_tap $? 20 'PublicCancelUserPersonalDataRequest' test.out

#- 21 PublicGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op PublicGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'HhJL5mps' \
    --userId '4dz31MIP' \
    --password 'Q70gXzGS' \
    > test.out 2>&1
eval_tap $? 21 'PublicGeneratePersonalDataURL' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE