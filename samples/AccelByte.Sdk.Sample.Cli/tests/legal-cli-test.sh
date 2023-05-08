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
echo "1..64"

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
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "i3wMWnoZgIhwb8YY", "policyId": "MLqpQwkRRHkaiKsm", "policyVersionId": "IiRLR3IlNJKxhPfW"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "5S8X1LxkZs4233oQ", "policyId": "WoXFeqeuI2oMJ0cg", "policyVersionId": "AoGfXepE3r5AQUBq"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "5P12c61ts3fMI04r", "policyId": "m2jUc9iav3tTqlE9", "policyVersionId": "oLDPD0Lfle8ESU1M"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $AB_NAMESPACE \
    --userId 'O8XnVaEyjmifJDYa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'ChangePreferenceConsent' test.out

#- 3 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId '1TJPUszmFGEkJVvq' \
    > test.out 2>&1
eval_tap $? 3 'RetrieveAcceptedAgreements' test.out

#- 4 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword 'DSU3PDyIAGfGq1FN' \
    --limit '25' \
    --offset '50' \
    --policyVersionId 'RWvUvDPnKoECjGUg' \
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
echo '{"affectedClientIds": ["wj6K2wEMnckjlW6B", "ywsSSZTGlubsmhjX", "867xodwuG14ID5l5"], "affectedCountries": ["cScOUvrjJBO7tbkT", "GYKqRMSTisP0MrSd", "aFy0pJYCdfkfyt09"], "basePolicyName": "ro5fHdWqJTNjrmpn", "description": "nEckHH8kT9oXVand", "namespace": "ercf1nq4Hf32SL5P", "tags": ["FuJORk4j04YfnXTs", "py8KrcQfucSq2X8g", "jaYEDxaYN8w9KUW0"], "typeId": "QUrA0WWyKl2K5mCS"}' > $TEMP_JSON_INPUT
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
    --basePolicyId 'oGeQCahcox63cyDx' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["AIjNmbfoW8bDq5jP", "AAYcRXJdoSTxNCK9", "qzhN0YdGSrA9LXRw"], "affectedCountries": ["U6WLgpQE9nXzhBC0", "uyMR4Xf2nfYvNvG8", "uQ14AhsxaALiBwpN"], "basePolicyName": "JornrCQpMJj5igqa", "description": "t8xnPoWTdHAkcyAy", "namespace": "4drHlPcXGGl0Xw3v", "tags": ["eBfrpCrnbaxhEvn3", "SGqcH91fC3aJEoqW", "aFAGD6PRg95m07l0"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId '3vtlMFzeiMRkcOr1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId 'L0TMIczbYilOziwG' \
    --countryCode '8CPLOzSZm9K3cMY6' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId '17HSCYZaL46I3PgC' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "cQ0axTWnmyEYLZQT", "description": "pvLH6QPEBP8kSSFj", "localeCode": "euL3wQQPYwmYFbxR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'vHYDCYwoGdmzXgf1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'ewUTvnu0ensa3MZF' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "7DTswnkSyuJTVjKQ", "attachmentLocation": "1ORLEIAePvDO2xkV", "attachmentVersionIdentifier": "gyRk10b27RdU8Vce", "contentType": "YQ9erPYQ5yVcQuvD", "description": "bGMqbEHkCQwMBcQU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'NPHN8YZT0yJJ0uCj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "jaNCRV3hSIiTEoTC", "contentType": "SxjAqg9oGVEdC8mQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId 'ir1Af0G6OrPH6Zsj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'pPgHKISHtB8tWdJM' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 RetrieveAcceptedAgreementsForMultiUsers
# body param: body
echo '{"currentPublishedOnly": true, "userIds": ["X62yI9g5RDrlzPFQ", "NXSTItt35OJTfJBZ", "c5HmR0vknXO45AUt"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreementsForMultiUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'RetrieveAcceptedAgreementsForMultiUsers' test.out

#- 17 RetrieveAcceptedAgreements1
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements1 \
    --namespace $AB_NAMESPACE \
    --userId 'mNu3ERxV0UTaiSzf' \
    > test.out 2>&1
eval_tap $? 17 'RetrieveAcceptedAgreements1' test.out

#- 18 RetrieveAllUsersByPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --keyword 'i0FnBERe8qNYRTYS' \
    --limit '0' \
    --offset '83' \
    --policyVersionId 'Zw4NqSNylcljuNM3' \
    > test.out 2>&1
eval_tap $? 18 'RetrieveAllUsersByPolicyVersion1' test.out

#- 19 RetrieveAllLegalPoliciesByNamespace
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPoliciesByNamespace \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'RetrieveAllLegalPoliciesByNamespace' test.out

#- 20 CreatePolicy1
# body param: body
echo '{"affectedClientIds": ["AZ86un0L98WUoXvf", "U4qMIpfgxw2ff5tw", "eUUSD1pZGMfPdGIO"], "affectedCountries": ["rm8UuNlT86N9yO0v", "Bxafo9b4xJyNnvHK", "RYbtdK2r4wWs6IpY"], "basePolicyName": "yD6J5brVo20e6POT", "description": "jrinAVVovpAAXNzc", "tags": ["pbmX3lLFeXCiaXP8", "GkPgQ0hb2tLrsMeo", "jBjK81t2V9TVauFc"], "typeId": "ZiRYkbhEM1zTNY3l"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreatePolicy1' test.out

#- 21 RetrieveSinglePolicy1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy1 \
    --basePolicyId 'pincuf5d5saQvKfF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'RetrieveSinglePolicy1' test.out

#- 22 PartialUpdatePolicy1
# body param: body
echo '{"affectedClientIds": ["yVicGQAVv32ftRAs", "JmcQmnsUigVynjGF", "RqBam8jPtKHTmzo0"], "affectedCountries": ["WhADRqJvaZrf2qXQ", "FCzRV1paELj5dw3L", "mC0RuRA8j1AJ3hNW"], "basePolicyName": "K0gPYhPPG5sAIfYt", "description": "YozA2OntGCwQSHHd", "tags": ["cBBhRAYjR7c4x5bI", "k8pVpxdUWOPel3Ti", "PLwjTngrvb2E1X9e"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy1 \
    --basePolicyId 'wTycqpVdINXzvkSp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PartialUpdatePolicy1' test.out

#- 23 RetrievePolicyCountry1
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry1 \
    --basePolicyId '0WbvxQWI0QGCOx7e' \
    --countryCode 'ICkauWbFrSnU7d1B' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'RetrievePolicyCountry1' test.out

#- 24 RetrieveLocalizedPolicyVersions1
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'uhdwliTSDdmGVfeg' \
    > test.out 2>&1
eval_tap $? 24 'RetrieveLocalizedPolicyVersions1' test.out

#- 25 CreateLocalizedPolicyVersion1
# body param: body
echo '{"contentType": "iD3mrVQaUr3oT88D", "description": "fc7114QFGwTzBVDg", "localeCode": "5v71kGCEt7h1mVwI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'QCJmQkvWbQrn2W0V' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateLocalizedPolicyVersion1' test.out

#- 26 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'kOF0pQOY0UCcViiF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 27 UpdateLocalizedPolicyVersion1
# body param: body
echo '{"attachmentChecksum": "KNjkT5hcONCaOyAT", "attachmentLocation": "BFgqLeAzvdcUEhWR", "attachmentVersionIdentifier": "o6ROvbuPQwl9dVfJ", "contentType": "QGkDR00ofXsbnEzH", "description": "iRs0NmGhxv1vuN7X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'v6OuG6RR1jPh8Rbl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateLocalizedPolicyVersion1' test.out

#- 28 RequestPresignedURL1
# body param: body
echo '{"contentMD5": "vnfNiABRf1gdXM7Q", "contentType": "lAlnjAfgxOdZdf9t"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL1 \
    --localizedPolicyVersionId 'LHO1qrNyhmUEADcz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'RequestPresignedURL1' test.out

#- 29 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --localizedPolicyVersionId 'zrL31HuYKsCBBgwb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'SetDefaultPolicy1' test.out

#- 30 UpdatePolicyVersion1
# body param: body
echo '{"description": "1hGjHJgxrcEvnfJq", "displayVersion": "U4hCv5egSQDePKSZ", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'p6zwDQS1atvJrALa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdatePolicyVersion1' test.out

#- 31 PublishPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'iplJgRhedl5Ewh3j' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 31 'PublishPolicyVersion1' test.out

#- 32 UpdatePolicy1
# body param: body
echo '{"description": "cgjHQo9HoLLyUnPT", "isDefaultOpted": false, "isMandatory": false, "policyName": "CD0038or8wR0tuwI", "readableId": "JnrSI2IFcRwSoMTu", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy1 \
    --namespace $AB_NAMESPACE \
    --policyId 'ziuDNbOydiu3lOar' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'UpdatePolicy1' test.out

#- 33 SetDefaultPolicy3
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy3 \
    --namespace $AB_NAMESPACE \
    --policyId 'uuYw0iUuts6bChMK' \
    > test.out 2>&1
eval_tap $? 33 'SetDefaultPolicy3' test.out

#- 34 RetrieveSinglePolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId '1gcx8p9fyv5PoMJe' \
    --versionId 'TIQix1FEvzlipE7r' \
    > test.out 2>&1
eval_tap $? 34 'RetrieveSinglePolicyVersion1' test.out

#- 35 CreatePolicyVersion1
# body param: body
echo '{"description": "0vhh21v5772Aopmj", "displayVersion": "I7CbY2WuwRUT9Iiv", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'qnMeKFo7U8Scr9xm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CreatePolicyVersion1' test.out

#- 36 RetrieveAllPolicyTypes1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes1 \
    --namespace $AB_NAMESPACE \
    --offset '20' \
    --limit '45' \
    > test.out 2>&1
eval_tap $? 36 'RetrieveAllPolicyTypes1' test.out

#- 37 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "Mx2hc45QX234xnql", "policyId": "bRAPFQsca6n9vGZT", "policyVersionId": "CCXQ2Lf7jtexB613"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "m3iCpu0lhhgutt3r", "policyId": "QuKP1OEtKFBjNihH", "policyVersionId": "U8GP8TRVypSvYXKz"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "FTyA9MDnKGXqq7Zk", "policyId": "705hOhenJi6dNVF7", "policyVersionId": "zwjXqlcD2LzaOwIF"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId '5tEsCwoAVcZCSj80' \
    --publisherUserId 'gzFvpvIerFEyxTug' \
    --clientId 'oTd50RmJFX9v4GPf' \
    --countryCode 'yGuQ2UEl0U5Z9UnQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'IndirectBulkAcceptVersionedPolicy' test.out

#- 38 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'mZqX15hBb4dlNTIB' \
    --publisherUserId 'DtHunwNLLfKCQKuu' \
    --clientId '2MWXpEpNjHWPcFSn' \
    --countryCode 'M7GAvk19sXDish7K' \
    > test.out 2>&1
eval_tap $? 38 'AdminRetrieveEligibilities' test.out

#- 39 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'UVhmAwmAygsnn8pM' \
    > test.out 2>&1
eval_tap $? 39 'RetrievePolicies' test.out

#- 40 UpdatePolicyVersion
# body param: body
echo '{"description": "7l6v0elLMceGGgb5", "displayVersion": "FJHWE6s13b7dmnPi", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 'hp3qY6T7TUEBotSN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'UpdatePolicyVersion' test.out

#- 41 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'IwGhia6cqoWmnhtu' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 41 'PublishPolicyVersion' test.out

#- 42 UpdatePolicy
# body param: body
echo '{"description": "pQE4bOtoiAjHXcVV", "isDefaultOpted": true, "isMandatory": true, "policyName": "j5ApcsiEQ65llgGn", "readableId": "THAsTCZa7xE4nwGK", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId '1guTNx7haejXSV2o' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdatePolicy' test.out

#- 43 SetDefaultPolicy2
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy2 \
    --policyId 'H2uH8S4Zx0ACteue' \
    > test.out 2>&1
eval_tap $? 43 'SetDefaultPolicy2' test.out

#- 44 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'MOmYP4SgxAIQTTKs' \
    --versionId 'dmtHu1dG0us7kIWL' \
    > test.out 2>&1
eval_tap $? 44 'RetrieveSinglePolicyVersion' test.out

#- 45 CreatePolicyVersion
# body param: body
echo '{"description": "cgKgU9406tdRDqr3", "displayVersion": "cpVbaH69NyTfGE59", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId '2bCwgpzUfcmTQjRm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'CreatePolicyVersion' test.out

#- 46 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '98' \
    --limit '41' \
    > test.out 2>&1
eval_tap $? 46 'RetrieveAllPolicyTypes' test.out

#- 47 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces 'CPt1LUaTvrFaxzOf' \
    > test.out 2>&1
eval_tap $? 47 'GetUserInfoStatus' test.out

#- 48 SyncUserInfo
$CLI_EXE \
    --sn legal \
    --op SyncUserInfo \
    --namespace_ 'G3pTddIA0Rt6wM5o' \
    > test.out 2>&1
eval_tap $? 48 'SyncUserInfo' test.out

#- 49 InvalidateUserInfoCache
$CLI_EXE \
    --sn legal \
    --op InvalidateUserInfoCache \
    --namespace_ 'QvTMICtWyUtVDnhg' \
    > test.out 2>&1
eval_tap $? 49 'InvalidateUserInfoCache' test.out

#- 50 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId 'TGXO8Utpwxug8Mpq' \
    > test.out 2>&1
eval_tap $? 50 'AnonymizeUserAgreement' test.out

#- 51 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "JtgjWmjx1WuNQq4v", "policyId": "8FnVzdbNW1xuV7rV", "policyVersionId": "ei1o9zV6rhVfcQmL"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "05KUgGKfDSGh3vQF", "policyId": "PSYCi8WEjR3wqpnM", "policyVersionId": "dSNskxhl3O3kGloo"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "PwKema6caMTOcivP", "policyId": "AkmP8Awb0NqtvSR9", "policyVersionId": "q6l5k9BLQMrPoTux"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent1 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'ChangePreferenceConsent1' test.out

#- 52 AcceptVersionedPolicy
$CLI_EXE \
    --sn legal \
    --op AcceptVersionedPolicy \
    --localizedPolicyVersionId 'dzEYAw5VdW05WnQE' \
    > test.out 2>&1
eval_tap $? 52 'AcceptVersionedPolicy' test.out

#- 53 RetrieveAgreementsPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveAgreementsPublic \
    > test.out 2>&1
eval_tap $? 53 'RetrieveAgreementsPublic' test.out

#- 54 BulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "Y0KOemhNPYUVA9mU", "policyId": "8UvONyjv3GQuLHoQ", "policyVersionId": "6ehLLK5h1bE9WU6w"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "RHbGTC2ynue7Xk4u", "policyId": "DF5mdakWJ2AsKf8U", "policyVersionId": "fQqTQ8v7gXyFuLFZ"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "kCIXX7WQ3ytABCzY", "policyId": "WxYbbphuiQPU0aS2", "policyVersionId": "OIp0B2FWiDu7POao"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'BulkAcceptVersionedPolicy' test.out

#- 55 IndirectBulkAcceptVersionedPolicyV2
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "JoQQyL1bCDNisOhj", "policyId": "EKFWmj7ioi5WZ6Zy", "policyVersionId": "mQeVSZZma57V6b9u"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "oAA9KoetyNPkgWcT", "policyId": "CN7aBIFfeRdnHpse", "policyVersionId": "2T7eZwkVrB3GSEmV"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "CjR5rCx0ZiHwUqL5", "policyId": "rITYFhcdeNwLmZen", "policyVersionId": "RqEBM0VGzhVVGdip"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicyV2 \
    --clientId 'di33u9U14rGwvMEx' \
    --countryCode 'AllZtPzNRiR35CZh' \
    --namespace $AB_NAMESPACE \
    --userId 'clugjyDzCPI8tslD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'IndirectBulkAcceptVersionedPolicyV2' test.out

#- 56 IndirectBulkAcceptVersionedPolicy1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "uRrAMzMB9XHHkfZg", "policyId": "B6Vt5qWaae3SboVK", "policyVersionId": "gjsryC98whmI5koB"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "Hl2PvPOKvc25nnSL", "policyId": "nEnv4ipAVJzPHM6k", "policyVersionId": "Twfu1vSD9gROMknw"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "MdFidv2kFVXgnjrA", "policyId": "fzEn26mHgxUgVDgn", "policyVersionId": "lU5H2ULa1LYlsqYr"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy1 \
    --userId 'UpXncYv2BVIS1BtM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'IndirectBulkAcceptVersionedPolicy1' test.out

#- 57 RetrieveEligibilitiesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublic \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'RetrieveEligibilitiesPublic' test.out

#- 58 RetrieveEligibilitiesPublicIndirect
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublicIndirect \
    --clientId 'qvdE5QQizMBWYPYe' \
    --countryCode 'rJ1FmKBX6U18gMIl' \
    --namespace $AB_NAMESPACE \
    --userId '7TSPm96MsoQcFDfK' \
    > test.out 2>&1
eval_tap $? 58 'RetrieveEligibilitiesPublicIndirect' test.out

#- 59 RetrieveSingleLocalizedPolicyVersion2
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion2 \
    --localizedPolicyVersionId 'SJymqZ5tDVsJ63mF' \
    > test.out 2>&1
eval_tap $? 59 'RetrieveSingleLocalizedPolicyVersion2' test.out

#- 60 RetrieveSingleLocalizedPolicyVersion3
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion3 \
    --localizedPolicyVersionId 'WW0u95r5ylQKcWi0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'RetrieveSingleLocalizedPolicyVersion3' test.out

#- 61 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'o5zcWp7NiTBI4m6P' \
    --defaultOnEmpty 'false' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'W9mRXQwc5sfOZbgn' \
    > test.out 2>&1
eval_tap $? 61 'RetrieveLatestPolicies' test.out

#- 62 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'false' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'LqltV5xjjrXKhZOe' \
    > test.out 2>&1
eval_tap $? 62 'RetrieveLatestPoliciesPublic' test.out

#- 63 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'kpygvRDCk0koCGDP' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags '77EgotvOrnRjb5UT' \
    > test.out 2>&1
eval_tap $? 63 'RetrieveLatestPoliciesByNamespaceAndCountryPublic' test.out

#- 64 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    > test.out 2>&1
eval_tap $? 64 'CheckReadiness' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE