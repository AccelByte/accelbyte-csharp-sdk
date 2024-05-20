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
echo "1..67"

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
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 5 'RetrieveAllLegalPolicies' test.out

#- 6 CreatePolicy
# body param: body
echo '{"affectedClientIds": ["j6K2wEMnckjlW6By", "67xodwuG14ID5l5w", "wsSSZTGlubsmhjXc"], "affectedCountries": ["ScOUvrjJBO7tbkTG", "YKqRMSTisP0MrSda", "Fy0pJYCdfkfyt09r"], "basePolicyName": "o5fHdWqJTNjrmpnn", "description": "EckHH8kT9oXVande", "isHidden": true, "namespace": "S6qyUCscHXs8PlOB", "tags": ["lfUOqv7WmCuqcsNM", "qU89D356pVsUtNan", "7YAnbq4DjmYUMhD9"], "typeId": "ddzgwxYdQc5hEfef"}' > $TEMP_JSON_INPUT
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
    --basePolicyId 'dopcEM0JHfof2Hwi' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["7vg3osbh0fL2h7eJ", "vAS2W4uqkhwSC7Ea", "jwHO3LfvwPewrf19"], "affectedCountries": ["Njm50xCDlPeNq0Cv", "MXtyUWXrdZaFeacG", "T2x6o28Njxyw7RHl"], "basePolicyName": "dq0m7NjUZ95Z5XDL", "description": "BN9YGVPtkjt0OyBl", "isHidden": true, "namespace": "i4RbZ0Iy11mfOFjC", "tags": ["gq7pRVZVLJiDx3au", "DtXnXLvOAsW8wYh4", "zZVcGomWF1oAqUNF"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId '9b9QjhzDlnJmi4Xa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId 'BTgoXjfdUQHa3Rxs' \
    --countryCode 'pSqwdbTR2sgzfaQr' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId 'UCW9fgo69uv1bkFx' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "8DmbC9UqYdYrdxNn", "description": "uMcAwrSzYnrcetxO", "localeCode": "beisZelKuD0iJ6fs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId '3zL9H4WxGWRH7fz4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'BdPhLtHRJOImSq37' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "aeAaGq0NIj53gXkm", "attachmentLocation": "rayvcIYiWxIAxfvL", "attachmentVersionIdentifier": "zSpDFY3lxe16KsSR", "contentType": "zkf2HzBcEio5Uyvu", "description": "Fv5z6wosJGnUyCME"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'bHh1uE4DmJ4Suj6D' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "jUw36GtZ83Jp2f9f", "contentType": "1FCoIo3L24DKGwgZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId '85vyFJR8euQBLVu2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId '7iwplLJdzYS9K0Vv' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 RetrieveAcceptedAgreementsForMultiUsers
# body param: body
echo '{"currentPublishedOnly": true, "userIds": ["XSTItt35OJTfJBZX", "5HmR0vknXO45AUtN", "62yI9g5RDrlzPFQm"]}' > $TEMP_JSON_INPUT
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
    --userId 'Nu3ERxV0UTaiSzfi' \
    --excludeOtherNamespacesPolicies 'false' \
    > test.out 2>&1
eval_tap $? 17 'RetrieveAcceptedAgreements1' test.out

#- 18 RetrieveAllUsersByPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --convertGameUserId 'false' \
    --keyword 'ZjTYM95e4aa8xOJu' \
    --limit '80' \
    --offset '36' \
    --policyVersionId 'qSNylcljuNM3eUUS' \
    > test.out 2>&1
eval_tap $? 18 'RetrieveAllUsersByPolicyVersion1' test.out

#- 19 DownloadExportedAgreementsInCSV
$CLI_EXE \
    --sn legal \
    --op DownloadExportedAgreementsInCSV \
    --namespace $AB_NAMESPACE \
    --exportId 'D1pZGMfPdGIOAZ86' \
    > test.out 2>&1
eval_tap $? 19 'DownloadExportedAgreementsInCSV' test.out

#- 20 InitiateExportAgreementsToCSV
$CLI_EXE \
    --sn legal \
    --op InitiateExportAgreementsToCSV \
    --namespace $AB_NAMESPACE \
    --end 'un0L98WUoXvfU4qM' \
    --policyVersionId 'Ipfgxw2ff5twRYbt' \
    --start 'dK2r4wWs6IpYBxaf' \
    > test.out 2>&1
eval_tap $? 20 'InitiateExportAgreementsToCSV' test.out

#- 21 RetrieveAllLegalPoliciesByNamespace
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPoliciesByNamespace \
    --namespace $AB_NAMESPACE \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 21 'RetrieveAllLegalPoliciesByNamespace' test.out

#- 22 CreatePolicy1
# body param: body
echo '{"affectedClientIds": ["a51m6VLfjsw270pM", "mOQJrpEBbVvBn8Ls", "f2qSAtizV9hzsVbp"], "affectedCountries": ["NbknfVv4nm70TCay", "YAkF18YBwRxcREyU", "JLtEZjuyFhvbxX2D"], "basePolicyName": "5CwqGJF6nDi33Izt", "description": "r2QcwlRrReRajlpk", "isHidden": false, "tags": ["qwqpoTVCNrcaVozs", "lfuiJVcktlx9zJZV", "VCc9bpIHEWQMmCkI"], "typeId": "jIXO2EUsAfBvo6Ll"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreatePolicy1' test.out

#- 23 RetrieveSinglePolicy1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy1 \
    --basePolicyId 'calks2R3VMtipTVx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'RetrieveSinglePolicy1' test.out

#- 24 PartialUpdatePolicy1
# body param: body
echo '{"affectedClientIds": ["XAF8KhOKqbrECijF", "xOpOzxeTLJQsZcTE", "zXaXUzpsAV6ct6XI"], "affectedCountries": ["HFGJRoGW7VBG1VB2", "TL0QEkadMSQluAoE", "D9oYwS8oLyErKvRt"], "basePolicyName": "sp2x9mszGGoyhGZA", "description": "zt2OVBTLwSH8hWRU", "isHidden": false, "tags": ["I0QGCOx7eICkauWb", "FrSnU7d1BuhdwliT", "SDdmGVfegiD3mrVQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy1 \
    --basePolicyId 'aUr3oT88Dfc7114Q' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'PartialUpdatePolicy1' test.out

#- 25 RetrievePolicyCountry1
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry1 \
    --basePolicyId 'FGwTzBVDg5v71kGC' \
    --countryCode 'Et7h1mVwIQCJmQkv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'RetrievePolicyCountry1' test.out

#- 26 RetrieveLocalizedPolicyVersions1
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'WbQrn2W0VkOF0pQO' \
    > test.out 2>&1
eval_tap $? 26 'RetrieveLocalizedPolicyVersions1' test.out

#- 27 CreateLocalizedPolicyVersion1
# body param: body
echo '{"contentType": "Y0UCcViiFKNjkT5h", "description": "cONCaOyATBFgqLeA", "localeCode": "zvdcUEhWRo6ROvbu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'PQwl9dVfJQGkDR00' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'CreateLocalizedPolicyVersion1' test.out

#- 28 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'ofXsbnEzHiRs0NmG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 29 UpdateLocalizedPolicyVersion1
# body param: body
echo '{"attachmentChecksum": "hxv1vuN7Xv6OuG6R", "attachmentLocation": "R1jPh8RblvnfNiAB", "attachmentVersionIdentifier": "Rf1gdXM7QlAlnjAf", "contentType": "gxOdZdf9tLHO1qrN", "description": "yhmUEADczzrL31Hu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'YKsCBBgwb1hGjHJg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateLocalizedPolicyVersion1' test.out

#- 30 RequestPresignedURL1
# body param: body
echo '{"contentMD5": "xrcEvnfJqU4hCv5e", "contentType": "gSQDePKSZKp6zwDQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL1 \
    --localizedPolicyVersionId 'S1atvJrALaiplJgR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'RequestPresignedURL1' test.out

#- 31 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --localizedPolicyVersionId 'hedl5Ewh3jDayYSt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'SetDefaultPolicy1' test.out

#- 32 UpdatePolicyVersion1
# body param: body
echo '{"description": "UiBB1yz3iP8gH88U", "displayVersion": "enlMVzIOP8NOf91L", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId '2IFcRwSoMTuJziuD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'UpdatePolicyVersion1' test.out

#- 33 PublishPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'NbOydiu3lOaruuYw' \
    --shouldNotify 'false' \
    > test.out 2>&1
eval_tap $? 33 'PublishPolicyVersion1' test.out

#- 34 UpdatePolicy1
# body param: body
echo '{"description": "41VBAEUvoBlbH02b", "isDefaultOpted": false, "isMandatory": false, "policyName": "fyv5PoMJeTIQix1F", "readableId": "EvzlipE7r0vhh21v", "shouldNotifyOnUpdate": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy1 \
    --namespace $AB_NAMESPACE \
    --policyId '2AopmjI7CbY2WuwR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdatePolicy1' test.out

#- 35 SetDefaultPolicy3
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy3 \
    --namespace $AB_NAMESPACE \
    --policyId 'UT9IivgC4mJ5OHuN' \
    > test.out 2>&1
eval_tap $? 35 'SetDefaultPolicy3' test.out

#- 36 RetrieveSinglePolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'EVQK4Mvk00I9GqAh' \
    --versionId 'hjNIivdIcaEQfNET' \
    > test.out 2>&1
eval_tap $? 36 'RetrieveSinglePolicyVersion1' test.out

#- 37 CreatePolicyVersion1
# body param: body
echo '{"description": "QCBPK1mYwKVQoydb", "displayVersion": "YjXZyBpqhCJBtFOm", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'EUePVZQaoEY2zrpL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'CreatePolicyVersion1' test.out

#- 38 RetrieveAllPolicyTypes1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes1 \
    --namespace $AB_NAMESPACE \
    --offset '42' \
    --limit '85' \
    > test.out 2>&1
eval_tap $? 38 'RetrieveAllPolicyTypes1' test.out

#- 39 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "OEtKFBjNihHU8GP8", "policyId": "TRVypSvYXKz4BGjb", "policyVersionId": "srRBV8aztJ86yQK1"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "hOhenJi6dNVF7zwj", "policyId": "XqlcD2LzaOwIF5tE", "policyVersionId": "sCwoAVcZCSj80gzF"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "gHA4CaLsPqRsTdKz", "policyId": "cKtkGcvn44NWse6V", "policyVersionId": "LPkM1VTrQBywhJ7l"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId 'bBLw9xy1WQM5qUS8' \
    --publisherUserId 'baUqkzSr41y6RPBH' \
    --clientId 'JuPjj8zDwOk0IgmY' \
    --countryCode 'fUTpFzyQhPVhRGX9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'IndirectBulkAcceptVersionedPolicy' test.out

#- 40 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'xlUKhXI8mL8OIhvP' \
    --publisherUserId '68xE68dzohxhbej2' \
    --clientId 'caIIfkXDY7jnhp3q' \
    --countryCode 'Y6T7TUEBotSNIwGh' \
    > test.out 2>&1
eval_tap $? 40 'AdminRetrieveEligibilities' test.out

#- 41 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'ia6cqoWmnhtuzxir' \
    > test.out 2>&1
eval_tap $? 41 'RetrievePolicies' test.out

#- 42 UpdatePolicyVersion
# body param: body
echo '{"description": "12r0VUWI0kJAczj5", "displayVersion": "ApcsiEQ65llgGnTH", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 'jXDosOo2kSUfIA1g' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdatePolicyVersion' test.out

#- 43 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'uTNx7haejXSV2oH2' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 43 'PublishPolicyVersion' test.out

#- 44 UpdatePolicy
# body param: body
echo '{"description": "SyuHbvRxR6LaKWgA", "isDefaultOpted": false, "isMandatory": true, "policyName": "gxAIQTTKsdmtHu1d", "readableId": "G0us7kIWLcgKgU94", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId '6tdRDqr3cpVbaH69' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'UpdatePolicy' test.out

#- 45 SetDefaultPolicy2
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy2 \
    --policyId 'NyTfGE59942bCwgp' \
    > test.out 2>&1
eval_tap $? 45 'SetDefaultPolicy2' test.out

#- 46 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'zUfcmTQjRmV0CPt1' \
    --versionId 'LUaTvrFaxzOfG3pT' \
    > test.out 2>&1
eval_tap $? 46 'RetrieveSinglePolicyVersion' test.out

#- 47 CreatePolicyVersion
# body param: body
echo '{"description": "ddIA0Rt6wM5oQvTM", "displayVersion": "ICtWyUtVDnhgTGXO", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'tpwxug8MpqczRvUd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'CreatePolicyVersion' test.out

#- 48 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '76' \
    --limit '26' \
    > test.out 2>&1
eval_tap $? 48 'RetrieveAllPolicyTypes' test.out

#- 49 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces '1uOV1ZJTYuHpnpVX' \
    > test.out 2>&1
eval_tap $? 49 'GetUserInfoStatus' test.out

#- 50 SyncUserInfo
eval_tap 0 50 'SyncUserInfo # SKIP deprecated' test.out

#- 51 InvalidateUserInfoCache
eval_tap 0 51 'InvalidateUserInfoCache # SKIP deprecated' test.out

#- 52 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId '5u4gw4XBXDD7BG73' \
    > test.out 2>&1
eval_tap $? 52 'AnonymizeUserAgreement' test.out

#- 53 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "6rhVfcQmLfEn5ZUG", "policyId": "eYlOwODWBAz6skHM", "policyVersionId": "fl4Hjw9KEnx8cNfD"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "5zWtwYhRoNPwKema", "policyId": "6caMTOcivPAkmP8A", "policyVersionId": "wb0NqtvSR9q6l5k9"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "LQMrPoTuxdzEYAw5", "policyId": "VdW05WnQEAbK416L", "policyVersionId": "N2N6D6yczitn4OkZ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent1 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'ChangePreferenceConsent1' test.out

#- 54 AcceptVersionedPolicy
$CLI_EXE \
    --sn legal \
    --op AcceptVersionedPolicy \
    --localizedPolicyVersionId 'fx0Xa6sgegAWYz2z' \
    > test.out 2>&1
eval_tap $? 54 'AcceptVersionedPolicy' test.out

#- 55 RetrieveAgreementsPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveAgreementsPublic \
    > test.out 2>&1
eval_tap $? 55 'RetrieveAgreementsPublic' test.out

#- 56 BulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "SPPQBDFQsvRHbGTC", "policyId": "2ynue7Xk4uDF5mda", "policyVersionId": "kWJ2AsKf8UfQqTQ8"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "7gXyFuLFZViQbxYQ", "policyId": "vUyapo6FmMy6tZYS", "policyVersionId": "Ce7du68Ce6T4pYH3"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "iDu7POaotJoQQyL1", "policyId": "bCDNisOhjEKFWmj7", "policyVersionId": "ioi5WZ6ZymQeVSZZ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkAcceptVersionedPolicy' test.out

#- 57 IndirectBulkAcceptVersionedPolicyV2
eval_tap 0 57 'IndirectBulkAcceptVersionedPolicyV2 # SKIP deprecated' test.out

#- 58 IndirectBulkAcceptVersionedPolicy1
eval_tap 0 58 'IndirectBulkAcceptVersionedPolicy1 # SKIP deprecated' test.out

#- 59 RetrieveEligibilitiesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublic \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 59 'RetrieveEligibilitiesPublic' test.out

#- 60 RetrieveEligibilitiesPublicIndirect
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublicIndirect \
    --clientId 'ma57V6b9uLloAA9K' \
    --countryCode 'oetyNPkgWcTCN7aB' \
    --namespace $AB_NAMESPACE \
    --userId 'IFfeRdnHpse2T7eZ' \
    > test.out 2>&1
eval_tap $? 60 'RetrieveEligibilitiesPublicIndirect' test.out

#- 61 RetrieveSingleLocalizedPolicyVersion2
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion2 \
    --localizedPolicyVersionId 'wkVrB3GSEmVq8CjR' \
    > test.out 2>&1
eval_tap $? 61 'RetrieveSingleLocalizedPolicyVersion2' test.out

#- 62 RetrieveSingleLocalizedPolicyVersion3
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion3 \
    --localizedPolicyVersionId '5rCx0ZiHwUqL5rIT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 62 'RetrieveSingleLocalizedPolicyVersion3' test.out

#- 63 RetrieveCountryListWithPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveCountryListWithPolicies \
    > test.out 2>&1
eval_tap $? 63 'RetrieveCountryListWithPolicies' test.out

#- 64 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'YFhcdeNwLmZenRqE' \
    --defaultOnEmpty 'true' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags '0VGzhVVGdipdi33u' \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 64 'RetrieveLatestPolicies' test.out

#- 65 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'true' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'vMExAllZtPzNRiR3' \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 65 'RetrieveLatestPoliciesPublic' test.out

#- 66 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'CZhclugjyDzCPI8t' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'JicmK6qeaDEm9bPC' \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 66 'RetrieveLatestPoliciesByNamespaceAndCountryPublic' test.out

#- 67 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    > test.out 2>&1
eval_tap $? 67 'CheckReadiness' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE