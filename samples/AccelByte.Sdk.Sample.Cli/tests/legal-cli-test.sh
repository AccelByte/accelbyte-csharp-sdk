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
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "fDewD7vv", "policyId": "k0ec8mMn", "policyVersionId": "0ncaOZzM"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "yjtWpipY", "policyId": "JrSuLCgK", "policyVersionId": "XSLVQ0ZP"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "AFGyNcXB", "policyId": "aBISEwzb", "policyVersionId": "ccHgmPgm"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $AB_NAMESPACE \
    --userId '8mYkngcu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'ChangePreferenceConsent' test.out

#- 3 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId '1j72RECg' \
    > test.out 2>&1
eval_tap $? 3 'RetrieveAcceptedAgreements' test.out

#- 4 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword 'D3AMqnFE' \
    --limit '92' \
    --offset '68' \
    --policyVersionId 'JUEnZMFB' \
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
echo '{"affectedClientIds": ["k666NvDZ", "7JnmXZ3B", "YMNwaTa6"], "affectedCountries": ["VFzfzpK3", "yVUTmh5A", "bBiQwjCS"], "basePolicyName": "pbFYCrIp", "description": "IqbjLi43", "namespace": "MpTVWEz3", "tags": ["g9dQVBSR", "zCHlM6VL", "PjLUG9Dn"], "typeId": "Tm0QmKgl"}' > $TEMP_JSON_INPUT
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
    --basePolicyId 'GjWKGPKG' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["3FdvpCGb", "inaqQZci", "CamYHJtm"], "affectedCountries": ["1wmWwddJ", "ND9pqavx", "22Sc1Evm"], "basePolicyName": "96vIQ6aF", "description": "j9n2eGPf", "namespace": "ubwDGnyj", "tags": ["sVUVJthL", "eUAPKM5M", "CUsE1R3k"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId 'vF2ef5UF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId '3P0hyznm' \
    --countryCode 'L7jpFrs7' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId 'wXNgWTJO' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "lNdQqkQL", "description": "GZn9KsOH", "localeCode": "7P88GmEV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'SnlfDQ5E' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'h4UtPO2P' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "AmfKrrRU", "attachmentLocation": "LRFYqnUE", "attachmentVersionIdentifier": "gfw5baMx", "contentType": "64ho0IND", "description": "jz1wkC0o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'kPlFXeSL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "DRZZ3SSF", "contentType": "sKeFZVqw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId 'jcFh5Krq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'Rak2EM8h' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "4OrG7kvi", "policyId": "xHgAgHLA", "policyVersionId": "oCFJWvzw"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "edpYUGEZ", "policyId": "5OHh2LR8", "policyVersionId": "YLDEu28S"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "K4zqjqE2", "policyId": "Dxwf7EwI", "policyVersionId": "Hd8VhFfp"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId 'dwjNIdKS' \
    --publisherUserId 'RFxWi5gC' \
    --clientId 'upIZQv4D' \
    --countryCode 'z0ogjLwp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'IndirectBulkAcceptVersionedPolicy' test.out

#- 17 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'jBfawR2g' \
    --publisherUserId 'BSyFodR6' \
    --clientId 'EEswrPqD' \
    --countryCode '0oblx5CW' \
    > test.out 2>&1
eval_tap $? 17 'AdminRetrieveEligibilities' test.out

#- 18 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'wOOUtdwe' \
    > test.out 2>&1
eval_tap $? 18 'RetrievePolicies' test.out

#- 19 UpdatePolicyVersion
# body param: body
echo '{"description": "XPs7TSyv", "displayVersion": "xCyFH2ib", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 'Yr0l3kYc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdatePolicyVersion' test.out

#- 20 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId '5xJf1C8Z' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 20 'PublishPolicyVersion' test.out

#- 21 UpdatePolicy
# body param: body
echo '{"description": "5pbOhlSC", "isDefaultOpted": true, "isMandatory": false, "policyName": "DYROPkfW", "readableId": "2eOwFh2I", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId 'zTMCw6Vv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdatePolicy' test.out

#- 22 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --policyId 'MfP1th2V' \
    > test.out 2>&1
eval_tap $? 22 'SetDefaultPolicy1' test.out

#- 23 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'uvJLj28N' \
    --versionId 'T7b0qBQ2' \
    > test.out 2>&1
eval_tap $? 23 'RetrieveSinglePolicyVersion' test.out

#- 24 CreatePolicyVersion
# body param: body
echo '{"description": "EmGfcMwQ", "displayVersion": "FlVSFPNd", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'EgwIS1U8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreatePolicyVersion' test.out

#- 25 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '4' \
    --limit '69' \
    > test.out 2>&1
eval_tap $? 25 'RetrieveAllPolicyTypes' test.out

#- 26 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces 'OC2Uk4q8' \
    > test.out 2>&1
eval_tap $? 26 'GetUserInfoStatus' test.out

#- 27 SyncUserInfo
$CLI_EXE \
    --sn legal \
    --op SyncUserInfo \
    --namespace_ 'nJSXWipC' \
    > test.out 2>&1
eval_tap $? 27 'SyncUserInfo' test.out

#- 28 InvalidateUserInfoCache
$CLI_EXE \
    --sn legal \
    --op InvalidateUserInfoCache \
    --namespace_ 'hlGUy866' \
    > test.out 2>&1
eval_tap $? 28 'InvalidateUserInfoCache' test.out

#- 29 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId 'NMmJMTOD' \
    > test.out 2>&1
eval_tap $? 29 'AnonymizeUserAgreement' test.out

#- 30 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "cWcxEeV2", "policyId": "Ria9oYvr", "policyVersionId": "2H4oD60W"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "Qvi91bqE", "policyId": "gxh9j0ue", "policyVersionId": "xU96Dsxx"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "vFX0CKzY", "policyId": "PVwCJtkz", "policyVersionId": "Dlyxhdfg"}]' > $TEMP_JSON_INPUT
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
    --localizedPolicyVersionId 'ig6iENVn' \
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
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "YRZVsaGX", "policyId": "76Kras6F", "policyVersionId": "aitmkY8L"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "pq5Colx6", "policyId": "Qn6Yc3C8", "policyVersionId": "C5Fml7gE"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "T1d79XIh", "policyId": "l7ZrsZMc", "policyVersionId": "MmQOdBy0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'BulkAcceptVersionedPolicy' test.out

#- 34 IndirectBulkAcceptVersionedPolicyV2
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "czxfW9Xp", "policyId": "ON09Qkyo", "policyVersionId": "Los18VID"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "L27as0bI", "policyId": "91mMUBqr", "policyVersionId": "u3SxwsGE"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "3hGpNoPI", "policyId": "DncfeWiH", "policyVersionId": "Xn3zkb6q"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicyV2 \
    --clientId 'dUodkfBq' \
    --countryCode '4U9Ofq9g' \
    --namespace $AB_NAMESPACE \
    --userId 'PzHTazY3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'IndirectBulkAcceptVersionedPolicyV2' test.out

#- 35 IndirectBulkAcceptVersionedPolicy1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "yc5bdq7w", "policyId": "MYEO2w8E", "policyVersionId": "4GpfSQB5"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "DX71azhl", "policyId": "boTVTXpw", "policyVersionId": "O4K4yQzS"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "W59EGhLF", "policyId": "7sUEl0yy", "policyVersionId": "ziaZwLSP"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy1 \
    --userId '2SZdhuWo' \
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
    --clientId 'iw7oplYx' \
    --countryCode 'bAvBymKG' \
    --namespace $AB_NAMESPACE \
    --userId '7DClqN1H' \
    > test.out 2>&1
eval_tap $? 37 'RetrieveEligibilitiesPublicIndirect' test.out

#- 38 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId '0zrAuNy6' \
    > test.out 2>&1
eval_tap $? 38 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 39 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'mVBUVytM' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'BLZOV0oq' \
    > test.out 2>&1
eval_tap $? 39 'RetrieveLatestPolicies' test.out

#- 40 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'gZ0FUXkc' \
    > test.out 2>&1
eval_tap $? 40 'RetrieveLatestPoliciesPublic' test.out

#- 41 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'dMxVpWrR' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags '9L470ife' \
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