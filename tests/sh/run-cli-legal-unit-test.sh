#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=42

FINISHED_COUNT=0
SUCCESS_COUNT=0
FAILED_COUNT=0

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_APP_NAME="UnitTest"
export AB_NAMESPACE=$TEST_NAMESPACE

get_current_year() { echo $(date +'%Y'); }
get_adult_birthday() { echo "$(( $(get_current_year) - 22))-01-01"; }

get_random_int() { echo $(( $1 + ( RANDOM % (($2 - $1)) ) )); }
get_random_bool() { ( (( (RANDOM % 2) == 1)) && echo "true" ) || ( echo "false" ) }
get_random_element() { declare -a a=("$@"); r=$((RANDOM % ${#a[@]})); echo ${a[$r]}; }

create_file() {
    touch $1
}

delete_file() {
    [ ! -e $1 ] || rm $1
}

update_status() {
    return_code=$1
    operation_name=$2

    FINISHED_COUNT=$(( $FINISHED_COUNT + 1 ))

    if [ $return_code == 0 ]
    then
        SUCCESS_COUNT=$(( $SUCCESS_COUNT + 1 ))
        echo "ok $FINISHED_COUNT $operation_name"
    else
        FAILED_COUNT=$(( $FAILED_COUNT + 1 ))
        echo "not ok $FINISHED_COUNT - $operation_name"
        echo '  ---'
        echo '  error: |-'
        while read line; do
          echo "    $line" | tr '\n' ' '
        echo $line
        done < $TEMP_FILE
    fi
}

touch $TEMP_FILE

$CLI_EXE --op login --lt user --user user --pass user
rm -f $CLI_TOKEN_FILE
echo "foo" >> $CLI_TOKEN_FILE

echo 'TAP version 13'
echo "1..$OPERATIONS_COUNT"

#- 1 ChangePreferenceConsent
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "jv4Ax7Nz", "policyId": "Ykoppa0V", "policyVersionId": "gFJAhHwT"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $TEST_NAMESPACE \
    --userId 'b5q010gN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ChangePreferenceConsent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId '2MQrbpeR' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAcceptedAgreements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword 'nxTlCTFS' \
    --limit '76' \
    --offset '69' \
    --policyVersionId 'bl1a2jXL' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllUsersByPolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 RetrieveAllLegalPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPolicies \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllLegalPolicies'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 CreatePolicy
# body param: body
echo '{"affectedClientIds": ["CtWmHJBi"], "affectedCountries": ["9SoMkSE4"], "basePolicyName": "eJelwO4K", "description": "PMky2h8R", "namespace": "2fIXoXP8", "tags": ["gd7JUabY"], "typeId": "c3GMbxTl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 RetrieveSinglePolicy
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy \
    --basePolicyId 'm1fsu6J3' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSinglePolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["C4s5ppGR"], "affectedCountries": ["9XcoxYTG"], "basePolicyName": "gewrLfwv", "description": "zJF4TpbN", "namespace": "hKq2xdmg", "tags": ["EBepFHtf"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId '6ZiegqdE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PartialUpdatePolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId 'L4fsM6nB' \
    --countryCode 'zRVuC1r7' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrievePolicyCountry'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId 'UH1Liu7U' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveLocalizedPolicyVersions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "Q0304McK", "description": "873tRtr5", "localeCode": "cfWO5JJ2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'c6vsOns4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateLocalizedPolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'jNWGc7Ci' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSingleLocalizedPolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "Ua4wM5Eu", "attachmentLocation": "3VqymsFX", "attachmentVersionIdentifier": "porMqEDR", "contentType": "8E72XMKf", "description": "hl6eq2Fz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'U3VL3LNm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateLocalizedPolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 RequestPresignedURL
# body param: body
echo '{"contentMD5": "PLeZdoCX", "contentType": "fabFXzvj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId 'Lmai7fPK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RequestPresignedURL'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'vE2Z4a63' \
    >$TEMP_FILE 2>&1
update_status $? 'SetDefaultPolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "QSWtsyz0", "policyId": "mGGyHHFI", "policyVersionId": "lIKsXgvS"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $TEST_NAMESPACE \
    --userId 'rkEgTYVk' \
    --publisherUserId '5iRBE6zJ' \
    --clientId 'J1BRHrfC' \
    --countryCode 'Hqqp2GwP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'IndirectBulkAcceptVersionedPolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $TEST_NAMESPACE \
    --userId 'cmzSuY8w' \
    --publisherUserId '9VYwBEfR' \
    --clientId 'XoZLfpVF' \
    --countryCode 'fDwjHHCW' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRetrieveEligibilities'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode '2g5u8z9y' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrievePolicies'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 UpdatePolicyVersion
# body param: body
echo '{"description": "rpJdIx5v", "displayVersion": "vHS3d6PK", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId '27mI6Px8' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'jt8Lq4x0' \
    --shouldNotify 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'PublishPolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 UpdatePolicy
# body param: body
echo '{"description": "7NcocelJ", "isDefaultOpted": false, "isMandatory": true, "policyName": "lKYu8iCP", "readableId": "znx0s5Tz", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId 'V4HTmivm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --policyId 'b6tPmCir' \
    >$TEMP_FILE 2>&1
update_status $? 'SetDefaultPolicy1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'khYvcOUu' \
    --versionId 'cjPWGwPs' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSinglePolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 CreatePolicyVersion
# body param: body
echo '{"description": "vjLK1CjP", "displayVersion": "t93utbMk", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'UFHT0fL9' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePolicyVersion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '33' \
    --limit '89' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllPolicyTypes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces 'MNAUQVoi' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserInfoStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 SyncUserInfo
$CLI_EXE \
    --sn legal \
    --op SyncUserInfo \
    --namespace_ 'QtSQC2kN' \
    >$TEMP_FILE 2>&1
update_status $? 'SyncUserInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 InvalidateUserInfoCache
$CLI_EXE \
    --sn legal \
    --op InvalidateUserInfoCache \
    --namespace_ 'SsmT0d2a' \
    >$TEMP_FILE 2>&1
update_status $? 'InvalidateUserInfoCache'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId 'BG4zA2zp' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeUserAgreement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "D6dGgwkY", "policyId": "gHzKuI2R", "policyVersionId": "JrboP7kf"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent1 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ChangePreferenceConsent1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 AcceptVersionedPolicy
$CLI_EXE \
    --sn legal \
    --op AcceptVersionedPolicy \
    --localizedPolicyVersionId 'pIletXrC' \
    >$TEMP_FILE 2>&1
update_status $? 'AcceptVersionedPolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 RetrieveAgreementsPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveAgreementsPublic \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAgreementsPublic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 BulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "s7nCqsod", "policyId": "oTFTcWla", "policyVersionId": "IBJAAknU"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BulkAcceptVersionedPolicy'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 IndirectBulkAcceptVersionedPolicyV2
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "ZgWlaLne", "policyId": "dDfasTc8", "policyVersionId": "gr2znWqD"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicyV2 \
    --clientId '6tIcfI5Z' \
    --countryCode '4tUNQ7mQ' \
    --namespace $TEST_NAMESPACE \
    --userId 'PjCalZgF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'IndirectBulkAcceptVersionedPolicyV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 IndirectBulkAcceptVersionedPolicy1
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "qav09OYm", "policyId": "xCvMqVcX", "policyVersionId": "s2OqNz8Z"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy1 \
    --userId 'LBsncbRr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'IndirectBulkAcceptVersionedPolicy1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 RetrieveEligibilitiesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublic \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveEligibilitiesPublic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 RetrieveEligibilitiesPublicIndirect
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublicIndirect \
    --clientId 'f6uEdjUn' \
    --countryCode 'r04WZNhg' \
    --namespace $TEST_NAMESPACE \
    --userId 'EGvqKWQT' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveEligibilitiesPublicIndirect'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'kE65j618' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSingleLocalizedPolicyVersion1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 RetrievePolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyVersions \
    --basePolicyId '6p0WfsnW' \
    --localeId 'ZuUPsaRn' \
    --namespace_ 'VdrdBA2h' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrievePolicyVersions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'XwYyzZMd' \
    --defaultOnEmpty 'False' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'L76hnFDg' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveLatestPolicies'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $TEST_NAMESPACE \
    --alwaysIncludeDefault 'False' \
    --defaultOnEmpty 'False' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'HdfoSqDc' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveLatestPoliciesPublic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'aFhOc1oK' \
    --namespace $TEST_NAMESPACE \
    --alwaysIncludeDefault 'True' \
    --defaultOnEmpty 'False' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'cfy4EIxw' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveLatestPoliciesByNamespaceAndCountryPublic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    >$TEMP_FILE 2>&1
update_status $? 'CheckReadiness'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT