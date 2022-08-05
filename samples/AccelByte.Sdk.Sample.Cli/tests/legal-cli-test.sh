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
echo "1..42"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ChangePreferenceConsent
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "amrsfxiN", "policyId": "DLKFHJKx", "policyVersionId": "ks2nOXgy"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "0xIPg2SV", "policyId": "5Ej0d8Fw", "policyVersionId": "XGxlGxDg"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "CH5qYsUE", "policyId": "pzSu15nt", "policyVersionId": "rfkD2Xo0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $AB_NAMESPACE \
    --userId 'DtfyrDFl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'ChangePreferenceConsent' test.out

#- 3 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId 'ts9Y69t1' \
    > test.out 2>&1
eval_tap $? 3 'RetrieveAcceptedAgreements' test.out

#- 4 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword 'CkJCqmvX' \
    --limit '97' \
    --offset '61' \
    --policyVersionId 'abgJoTRW' \
    > test.out 2>&1
eval_tap $? 4 'RetrieveAllUsersByPolicyVersion' test.out

#- 5 RetrieveAllLegalPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPolicies \
    > test.out 2>&1
eval_tap $? 5 'RetrieveAllLegalPolicies' test.out

#- 6 CreatePolicy
# body param: body
echo '{"affectedClientIds": ["BVmbqGHm", "nXkJ6a99", "UW4pkKSh"], "affectedCountries": ["qAf1ePjm", "qGGCJCRe", "HFq5EYnM"], "basePolicyName": "woQDIf8u", "description": "oOuOYrL2", "namespace": "OFQJd7U6", "tags": ["s6YUgp8X", "Nq45zcFt", "YBIDTio8"], "typeId": "Nt3qgMxX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'CreatePolicy' test.out

#- 7 RetrieveSinglePolicy
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy \
    --basePolicyId 'L7V4RFAh' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["JWYDRjRN", "9C0xxqGX", "ikLj8JMJ"], "affectedCountries": ["sX8njFM0", "moYWrxPQ", "XR89LqKt"], "basePolicyName": "vgNGSjEK", "description": "b2BQeAz9", "namespace": "4v03SCaY", "tags": ["Wh1kU3u4", "5hzBU1TO", "f6yvIRYz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId '5ltSfCM5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId '8G45nRea' \
    --countryCode '5AeR0PJM' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId '1wED7FBw' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "6rBMsc43", "description": "ALM5wTzo", "localeCode": "QkPZecMM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'iV138raN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'deMFRdkv' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "sWVXNiqw", "attachmentLocation": "pd16Ox5F", "attachmentVersionIdentifier": "C39M8pro", "contentType": "2RM02Xml", "description": "zUuT1IZ8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'SlkpfeI3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "nARtynms", "contentType": "oXkPeFvy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId '07tujWl3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'ie1SdwKc' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "flFmIAeP", "policyId": "9o1YKC6n", "policyVersionId": "GrBW49k4"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "EXTpcTnO", "policyId": "HLS2SPfr", "policyVersionId": "aGG2roFE"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "nLsumiVP", "policyId": "LGQR05RO", "policyVersionId": "1sSfbs0z"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId 'NFQW4PDb' \
    --publisherUserId 'rVZ1McDF' \
    --clientId 'jZ5FJLvq' \
    --countryCode 'iLHHQoSm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'IndirectBulkAcceptVersionedPolicy' test.out

#- 17 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'SI7hQKNo' \
    --publisherUserId 'L9BGY8Iw' \
    --clientId 'OQ32P0ir' \
    --countryCode 'N3iFYIFa' \
    > test.out 2>&1
eval_tap $? 17 'AdminRetrieveEligibilities' test.out

#- 18 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'fGF0ZFqc' \
    > test.out 2>&1
eval_tap $? 18 'RetrievePolicies' test.out

#- 19 UpdatePolicyVersion
# body param: body
echo '{"description": "gqJqInLK", "displayVersion": "ZplowrQ1", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 't3Qx0VRf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdatePolicyVersion' test.out

#- 20 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'SXyFLg0s' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 20 'PublishPolicyVersion' test.out

#- 21 UpdatePolicy
# body param: body
echo '{"description": "aF0G3CPP", "isDefaultOpted": true, "isMandatory": false, "policyName": "0wUd2hfu", "readableId": "BRzqfKmC", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId 'RP4oVPea' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdatePolicy' test.out

#- 22 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --policyId 'yLqiC2wg' \
    > test.out 2>&1
eval_tap $? 22 'SetDefaultPolicy1' test.out

#- 23 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'Ymv79oyt' \
    --versionId 'hFhHebec' \
    > test.out 2>&1
eval_tap $? 23 'RetrieveSinglePolicyVersion' test.out

#- 24 CreatePolicyVersion
# body param: body
echo '{"description": "unOjboF8", "displayVersion": "Q9mg3IH4", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'DxZ3Lg3m' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreatePolicyVersion' test.out

#- 25 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '45' \
    --limit '0' \
    > test.out 2>&1
eval_tap $? 25 'RetrieveAllPolicyTypes' test.out

#- 26 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces 'EM5A1rSW' \
    > test.out 2>&1
eval_tap $? 26 'GetUserInfoStatus' test.out

#- 27 SyncUserInfo
$CLI_EXE \
    --sn legal \
    --op SyncUserInfo \
    --namespace_ 'VITSUmuF' \
    > test.out 2>&1
eval_tap $? 27 'SyncUserInfo' test.out

#- 28 InvalidateUserInfoCache
$CLI_EXE \
    --sn legal \
    --op InvalidateUserInfoCache \
    --namespace_ 'GF8v1ZIr' \
    > test.out 2>&1
eval_tap $? 28 'InvalidateUserInfoCache' test.out

#- 29 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId 'fDTkrHTM' \
    > test.out 2>&1
eval_tap $? 29 'AnonymizeUserAgreement' test.out

#- 30 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "cES40B2a", "policyId": "Cvze54zH", "policyVersionId": "ZG2wl3Cu"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "OGycJuv2", "policyId": "YrFzxznB", "policyVersionId": "W8HOrxUf"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "y4o1j3ia", "policyId": "xPkz5N48", "policyVersionId": "iOfOD4sD"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent1 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'ChangePreferenceConsent1' test.out

#- 31 AcceptVersionedPolicy
$CLI_EXE \
    --sn legal \
    --op AcceptVersionedPolicy \
    --localizedPolicyVersionId 'VeiRL3rT' \
    > test.out 2>&1
eval_tap $? 31 'AcceptVersionedPolicy' test.out

#- 32 RetrieveAgreementsPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveAgreementsPublic \
    > test.out 2>&1
eval_tap $? 32 'RetrieveAgreementsPublic' test.out

#- 33 BulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "WAgZbf3q", "policyId": "mosrzsx5", "policyVersionId": "NzFPD3T4"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "yPwSFPbB", "policyId": "34o24Ali", "policyVersionId": "QXEIGMOc"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "EKtWFgcs", "policyId": "5wjdaTfA", "policyVersionId": "bv3Yp7oq"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'BulkAcceptVersionedPolicy' test.out

#- 34 IndirectBulkAcceptVersionedPolicyV2
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "dd74iAjH", "policyId": "mdffA3YP", "policyVersionId": "cuMe7mtV"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "t2ahLhdy", "policyId": "DkJgQWh3", "policyVersionId": "9uRRnbbW"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "YHB6lxuA", "policyId": "oqSzjx3W", "policyVersionId": "1SUI6Gup"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicyV2 \
    --clientId 'IPuLefV1' \
    --countryCode 'pfI47lxU' \
    --namespace $AB_NAMESPACE \
    --userId 'cJAvpGh6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'IndirectBulkAcceptVersionedPolicyV2' test.out

#- 35 IndirectBulkAcceptVersionedPolicy1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "OIhttO0d", "policyId": "CPhxf8l8", "policyVersionId": "e2Hk8crA"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "QOrCCFlL", "policyId": "shLxirNK", "policyVersionId": "baChLJ8Z"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "g0wFeSWr", "policyId": "TSteBHUv", "policyVersionId": "wyDHAwLG"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy1 \
    --userId 'XbFhgK7p' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'IndirectBulkAcceptVersionedPolicy1' test.out

#- 36 RetrieveEligibilitiesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublic \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'RetrieveEligibilitiesPublic' test.out

#- 37 RetrieveEligibilitiesPublicIndirect
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublicIndirect \
    --clientId 'cdRc6UP9' \
    --countryCode 'IyL3lFbb' \
    --namespace $AB_NAMESPACE \
    --userId 'kYSJy23Y' \
    > test.out 2>&1
eval_tap $? 37 'RetrieveEligibilitiesPublicIndirect' test.out

#- 38 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'y21fT0aD' \
    > test.out 2>&1
eval_tap $? 38 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 39 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'B8gpETdr' \
    --defaultOnEmpty 'true' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'uYlWC9zW' \
    > test.out 2>&1
eval_tap $? 39 'RetrieveLatestPolicies' test.out

#- 40 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'JF4ILZbs' \
    > test.out 2>&1
eval_tap $? 40 'RetrieveLatestPoliciesPublic' test.out

#- 41 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'SeSyKRHI' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'false' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags '3YItTBHL' \
    > test.out 2>&1
eval_tap $? 41 'RetrieveLatestPoliciesByNamespaceAndCountryPublic' test.out

#- 42 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    > test.out 2>&1
eval_tap $? 42 'CheckReadiness' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE