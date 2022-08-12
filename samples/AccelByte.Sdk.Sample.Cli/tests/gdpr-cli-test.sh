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
    --after 'S12g4Xk0' \
    --before 'LOEIQt9i' \
    --limit '29' \
    --offset '31' \
    --requestDate 'MVdR7bvH' \
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
echo '["Jubq56Xc", "u48V8P0L", "WBdixURy"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op UpdateAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateAdminEmailConfiguration' test.out

#- 5 SaveAdminEmailConfiguration
# body param: body
echo '["CzbRmt98", "dnTZMlQo", "f4rL7LZU"]' > $TEMP_JSON_INPUT
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
    --emails '["tV0l1O8f", "ylqczm8Y", "AWYEgpkA"]' \
    > test.out 2>&1
eval_tap $? 6 'DeleteAdminEmailConfiguration' test.out

#- 7 AdminGetListPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --offset '35' \
    --requestDate 'QCaP8dHo' \
    > test.out 2>&1
eval_tap $? 7 'AdminGetListPersonalDataRequest' test.out

#- 8 AdminGetUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'kM9x10eW' \
    > test.out 2>&1
eval_tap $? 8 'AdminGetUserAccountDeletionRequest' test.out

#- 9 AdminSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'h7K9BuBV' \
    > test.out 2>&1
eval_tap $? 9 'AdminSubmitUserAccountDeletionRequest' test.out

#- 10 AdminCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId '8l6aRDTT' \
    > test.out 2>&1
eval_tap $? 10 'AdminCancelUserAccountDeletionRequest' test.out

#- 11 AdminGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'PE27E5BG' \
    --limit '80' \
    --offset '24' \
    > test.out 2>&1
eval_tap $? 11 'AdminGetUserPersonalDataRequests' test.out

#- 12 AdminRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op AdminRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'r2XOc9vE' \
    --password 'lcKIqSW2' \
    > test.out 2>&1
eval_tap $? 12 'AdminRequestDataRetrieval' test.out

#- 13 AdminCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'LpPyhKWj' \
    --userId 'LhF7DkzZ' \
    > test.out 2>&1
eval_tap $? 13 'AdminCancelUserPersonalDataRequest' test.out

#- 14 AdminGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op AdminGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate '9HGpBBoz' \
    --userId '0Y2kk0Nu' \
    --password 'XtGd1GdX' \
    > test.out 2>&1
eval_tap $? 14 'AdminGeneratePersonalDataURL' test.out

#- 15 PublicSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'X8OdDj3F' \
    --password '5NDAJXz7' \
    > test.out 2>&1
eval_tap $? 15 'PublicSubmitUserAccountDeletionRequest' test.out

#- 16 PublicCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId '6705nyZe' \
    > test.out 2>&1
eval_tap $? 16 'PublicCancelUserAccountDeletionRequest' test.out

#- 17 PublicGetUserAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserAccountDeletionStatus \
    --namespace $AB_NAMESPACE \
    --userId 'o4Qu3BXg' \
    > test.out 2>&1
eval_tap $? 17 'PublicGetUserAccountDeletionStatus' test.out

#- 18 PublicGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'PHctSxpp' \
    --limit '1' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetUserPersonalDataRequests' test.out

#- 19 PublicRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op PublicRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'cqjQR7qE' \
    --password 'fg97nXgP' \
    > test.out 2>&1
eval_tap $? 19 'PublicRequestDataRetrieval' test.out

#- 20 PublicCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'YoMIw0C2' \
    --userId 'ChkeqrgU' \
    > test.out 2>&1
eval_tap $? 20 'PublicCancelUserPersonalDataRequest' test.out

#- 21 PublicGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op PublicGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'VrKW3WZY' \
    --userId 'Fz5CnE9l' \
    --password 'RNyYiLZz' \
    > test.out 2>&1
eval_tap $? 21 'PublicGeneratePersonalDataURL' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE