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
echo "1..82"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 IndexHandler
$CLI_EXE \
    --sn group \
    --op IndexHandler \
    > test.out 2>&1
eval_tap $? 2 'IndexHandler' test.out

#- 3 BlockHandler
$CLI_EXE \
    --sn group \
    --op BlockHandler \
    > test.out 2>&1
eval_tap $? 3 'BlockHandler' test.out

#- 4 CmdlineHandler
$CLI_EXE \
    --sn group \
    --op CmdlineHandler \
    > test.out 2>&1
eval_tap $? 4 'CmdlineHandler' test.out

#- 5 GoroutineHandler
$CLI_EXE \
    --sn group \
    --op GoroutineHandler \
    > test.out 2>&1
eval_tap $? 5 'GoroutineHandler' test.out

#- 6 HeapHandler
$CLI_EXE \
    --sn group \
    --op HeapHandler \
    > test.out 2>&1
eval_tap $? 6 'HeapHandler' test.out

#- 7 Profile
$CLI_EXE \
    --sn group \
    --op Profile \
    > test.out 2>&1
eval_tap $? 7 'Profile' test.out

#- 8 SymbolHandler
$CLI_EXE \
    --sn group \
    --op SymbolHandler \
    > test.out 2>&1
eval_tap $? 8 'SymbolHandler' test.out

#- 9 ThreadcreateHandler
$CLI_EXE \
    --sn group \
    --op ThreadcreateHandler \
    > test.out 2>&1
eval_tap $? 9 'ThreadcreateHandler' test.out

#- 10 ListGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op ListGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 10 'ListGroupConfigurationAdminV1' test.out

#- 11 CreateGroupConfigurationAdminV1
# body param: body
echo '{"allowMultiple": false, "configurationCode": "uz5zkoaUEzGS3qZf", "description": "0PbemSBELbZ0VBUG", "globalRules": [{"allowedAction": "A7nkDeev2Oj060Hn", "ruleDetail": [{"ruleAttribute": "Of5S8X1LxkZs4233", "ruleCriteria": "EQUAL", "ruleValue": 0.5050385496291381}, {"ruleAttribute": "7bwRgwKvzESbhpxl", "ruleCriteria": "MAXIMUM", "ruleValue": 0.42696814286390206}, {"ruleAttribute": "oGfXepE3r5AQUBqS", "ruleCriteria": "MINIMUM", "ruleValue": 0.12945809454031565}]}, {"allowedAction": "5P12c61ts3fMI04r", "ruleDetail": [{"ruleAttribute": "m2jUc9iav3tTqlE9", "ruleCriteria": "EQUAL", "ruleValue": 0.28091031020958357}, {"ruleAttribute": "pC65VJh4q1z1KJmK", "ruleCriteria": "EQUAL", "ruleValue": 0.8040416393657845}, {"ruleAttribute": "nVaEyjmifJDYa1TJ", "ruleCriteria": "MINIMUM", "ruleValue": 0.6911512892884695}]}, {"allowedAction": "sxYFxGGHrfQkgXki", "ruleDetail": [{"ruleAttribute": "A5IZPqCqp9vcyt67", "ruleCriteria": "MAXIMUM", "ruleValue": 0.42424615822750367}, {"ruleAttribute": "fWXfUfwGB03tz8qI", "ruleCriteria": "MINIMUM", "ruleValue": 0.3594216473713968}, {"ruleAttribute": "uG14ID5l5wj6K2wE", "ruleCriteria": "MINIMUM", "ruleValue": 0.04114277079678852}]}], "groupAdminRoleId": "9eItJtiNmY3y3n2R", "groupMaxMember": 17, "groupMemberRoleId": "ubsmhjXcScOUvrjJ", "name": "BO7tbkTGYKqRMSTi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateGroupConfigurationAdminV1' test.out

#- 12 InitiateGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op InitiateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'InitiateGroupConfigurationAdminV1' test.out

#- 13 GetGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupConfigurationAdminV1 \
    --configurationCode 'sP0MrSdaFy0pJYCd' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetGroupConfigurationAdminV1' test.out

#- 14 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'fkfyt09ro5fHdWqJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteGroupConfigurationV1' test.out

#- 15 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "TNjrmpnnEckHH8kT", "groupMaxMember": 67, "name": "oXVandercf1nq4Hf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode '32SL5PjaYEDxaYN8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdateGroupConfigurationAdminV1' test.out

#- 16 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "w9KUW0py8KrcQfuc", "ruleCriteria": "MINIMUM", "ruleValue": 0.20332129500511464}, {"ruleAttribute": "YUMhD9qU89D356pV", "ruleCriteria": "MAXIMUM", "ruleValue": 0.21568767540178369}, {"ruleAttribute": "XTsQUrA0WWyKl2K5", "ruleCriteria": "EQUAL", "ruleValue": 0.4869473983736744}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'fefdopcEM0JHfof2' \
    --configurationCode 'Hwi7vg3osbh0fL2h' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdateGroupConfigurationGlobalRuleAdminV1' test.out

#- 17 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction '7eJvAS2W4uqkhwSC' \
    --configurationCode '7EajwHO3LfvwPewr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteGroupConfigurationGlobalRuleAdminV1' test.out

#- 18 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $AB_NAMESPACE \
    --configurationCode 'f19Njm50xCDlPeNq' \
    --groupName '0CvMXtyUWXrdZaFe' \
    --groupRegion 'acGT2x6o28Njxyw7' \
    --limit '90' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 18 'GetGroupListAdminV1' test.out

#- 19 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId 'Hldq0m7NjUZ95Z5X' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetSingleGroupAdminV1' test.out

#- 20 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId 'DLBN9YGVPtkjt0Oy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'DeleteGroupAdminV1' test.out

#- 21 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId 'BlJi4RbZ0Iy11mfO' \
    --namespace $AB_NAMESPACE \
    --limit '64' \
    --offset '9' \
    --order 'jCzZVcGomWF1oAqU' \
    > test.out 2>&1
eval_tap $? 21 'GetGroupMembersListAdminV1' test.out

#- 22 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '80' \
    --offset '67' \
    > test.out 2>&1
eval_tap $? 22 'GetMemberRolesListAdminV1' test.out

#- 23 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "FDtXnXLvOAsW8wYh", "memberRolePermissions": [{"action": 53, "resourceName": "gq7pRVZVLJiDx3au"}, {"action": 22, "resourceName": "b9QjhzDlnJmi4XaB"}, {"action": 93, "resourceName": "IczbYilOziwG8CPL"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateMemberRoleAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'CreateMemberRoleAdminV1' test.out

#- 24 GetSingleMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleMemberRoleAdminV1 \
    --memberRoleId 'OzSZm9K3cMY617HS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetSingleMemberRoleAdminV1' test.out

#- 25 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId 'CYZaL46I3PgCcQ0a' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'DeleteMemberRoleAdminV1' test.out

#- 26 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "xTWnmyEYLZQTpvLH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId '6QPEBP8kSSFjeuL3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateMemberRoleAdminV1' test.out

#- 27 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 47, "resourceName": "isZelKuD0iJ6fs3z"}, {"action": 77, "resourceName": "YwoGdmzXgf1ewUTv"}, {"action": 27, "resourceName": "hLtHRJOImSq37aeA"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId 'aGq0NIj53gXkmray' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateMemberRolePermissionAdminV1' test.out

#- 28 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $AB_NAMESPACE \
    --groupName 'vcIYiWxIAxfvLzSp' \
    --groupRegion 'DFY3lxe16KsSRzkf' \
    --limit '69' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 28 'GetGroupListPublicV1' test.out

#- 29 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "zBcEio5UyvuFv5z6", "customAttributes": {"wosJGnUyCMEbHh1u": {}, "E4DmJ4Suj6DjUw36": {}, "GtZ83Jp2f9f1FCoI": {}}, "groupDescription": "o3L24DKGwgZ85vyF", "groupIcon": "JR8euQBLVu27iwpl", "groupMaxMember": 76, "groupName": "tB8tWdJM9Qc5HmR0", "groupRegion": "vknXO45AUtNXSTIt", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "t35OJTfJBZX62yI9", "ruleDetail": [{"ruleAttribute": "g5RDrlzPFQmNu3ER", "ruleCriteria": "MAXIMUM", "ruleValue": 0.5443438647050215}, {"ruleAttribute": "ux3k3skhn3mWZjTY", "ruleCriteria": "MINIMUM", "ruleValue": 0.9831576570280638}, {"ruleAttribute": "qNYRTYSaZw4NqSNy", "ruleCriteria": "EQUAL", "ruleValue": 0.3904556113989719}]}, {"allowedAction": "gfKmUkzj9mHFpff2", "ruleDetail": [{"ruleAttribute": "vDkz68zorEgcExv9", "ruleCriteria": "EQUAL", "ruleValue": 0.7758569239752912}, {"ruleAttribute": "UoXvfU4qMIpfgxw2", "ruleCriteria": "EQUAL", "ruleValue": 0.5693005926015955}, {"ruleAttribute": "SMm8kDi3Rwubq7wt", "ruleCriteria": "MINIMUM", "ruleValue": 0.5497761705492296}]}, {"allowedAction": "pYBxafo9b4xJyNnv", "ruleDetail": [{"ruleAttribute": "HKrm8UuNlT86N9yO", "ruleCriteria": "MAXIMUM", "ruleValue": 0.3490511434974457}, {"ruleAttribute": "yD6J5brVo20e6POT", "ruleCriteria": "EQUAL", "ruleValue": 0.30151220624370256}, {"ruleAttribute": "VbpJLtEZjuyFhvbx", "ruleCriteria": "EQUAL", "ruleValue": 0.8823663801085505}]}]}, "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateNewGroupPublicV1' test.out

#- 30 GetSingleGroupPublicV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupPublicV1 \
    --groupId '3lLFeXCiaXP8jBjK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'GetSingleGroupPublicV1' test.out

#- 31 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "81t2V9TVauFcGkPg", "groupIcon": "Q0hb2tLrsMeoZiRY", "groupName": "kbhEM1zTNY3lpinc", "groupRegion": "uf5d5saQvKfFRqBa", "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId 'VVCc9bpIHEWQMmCk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'UpdateSingleGroupV1' test.out

#- 32 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'IqwqpoTVCNrcaVoz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'DeleteGroupPublicV1' test.out

#- 33 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "sjIXO2EUsAfBvo6L", "groupIcon": "lcalks2R3VMtipTV", "groupName": "xXAF8KhOKqbrECij", "groupRegion": "FxOpOzxeTLJQsZcT", "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId 'hPPG5sAIfYtYozA2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdatePatchSingleGroupPublicV1' test.out

#- 34 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"OntGCwQSHHdPLwjT": {}, "ngrvb2E1X9ecBBhR": {}, "AYjR7c4x5bIk8pVp": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'xdUWOPel3TiwTycq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGroupCustomAttributesPublicV1' test.out

#- 35 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId 'pVdINXzvkSp0Wbvx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'AcceptGroupInvitationPublicV1' test.out

#- 36 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId 'QWI0QGCOx7eICkau' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'RejectGroupInvitationPublicV1' test.out

#- 37 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'WbFrSnU7d1Buhdwl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'JoinGroupV1' test.out

#- 38 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'iTSDdmGVfegiD3mr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'CancelGroupJoinRequestV1' test.out

#- 39 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId 'VQaUr3oT88Dfc711' \
    --namespace $AB_NAMESPACE \
    --limit '20' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 39 'GetGroupJoinRequestPublicV1' test.out

#- 40 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId 'tqcXjPkj2IzU3MEp' \
    --namespace $AB_NAMESPACE \
    --limit '57' \
    --offset '63' \
    --order 't1IjlfHJM92t9j1X' \
    > test.out 2>&1
eval_tap $? 40 'GetGroupMembersListPublicV1' test.out

#- 41 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"T2ErwIxkaTnYtr1Y": {}, "DnaXB0JOS4XKVT66": {}, "sHYPgVsfhoEidKw4": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'IP0NVnaangorhVFp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'UpdateGroupCustomRulePublicV1' test.out

#- 42 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "TRuQyMroT2hNfKJ7", "ruleCriteria": "MAXIMUM", "ruleValue": 0.0842921582798164}, {"ruleAttribute": "XsbnEzHiRs0NmGhx", "ruleCriteria": "MAXIMUM", "ruleValue": 0.2947846417235065}, {"ruleAttribute": "En5VEvIMEB4pl506", "ruleCriteria": "EQUAL", "ruleValue": 0.11830924161328726}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction '8RblvnfNiABRf1gd' \
    --groupId 'XM7QlAlnjAfgxOdZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateGroupPredefinedRulePublicV1' test.out

#- 43 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction 'df9tLHO1qrNyhmUE' \
    --groupId 'ADczzrL31HuYKsCB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'DeleteGroupPredefinedRulePublicV1' test.out

#- 44 LeaveGroupPublicV1
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'LeaveGroupPublicV1' test.out

#- 45 GetMemberRolesListPublicV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '56' \
    --offset '17' \
    > test.out 2>&1
eval_tap $? 45 'GetMemberRolesListPublicV1' test.out

#- 46 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "gwb1hGjHJgxrcEvn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'fJqU4hCv5egSQDeP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'UpdateMemberRolePublicV1' test.out

#- 47 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "KSZKp6zwDQS1atvJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'rALaiplJgRhedl5E' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'DeleteMemberRolePublicV1' test.out

#- 48 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '45' \
    --offset '73' \
    > test.out 2>&1
eval_tap $? 48 'GetGroupInvitationRequestPublicV1' test.out

#- 49 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'h3jDayYStUiBB1yz' \
    > test.out 2>&1
eval_tap $? 49 'GetUserGroupInformationPublicV1' test.out

#- 50 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '3iP8gH88UenlMVzI' \
    > test.out 2>&1
eval_tap $? 50 'InviteGroupPublicV1' test.out

#- 51 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'OP8NOf91LsD7cWWO' \
    > test.out 2>&1
eval_tap $? 51 'AcceptGroupJoinRequestPublicV1' test.out

#- 52 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'gAs8ThMpAGIapYft' \
    > test.out 2>&1
eval_tap $? 52 'RejectGroupJoinRequestPublicV1' test.out

#- 53 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'YZkBXiEhdiS41VBA' \
    > test.out 2>&1
eval_tap $? 53 'KickGroupMemberPublicV1' test.out

#- 54 GetListGroupByIDsAdminV2
# body param: body
echo '{"groupIDs": ["EUvoBlbH02bobxtl", "jIfHBgjP9onbxFcx", "S2OZZfXO3HkJTOPs"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsAdminV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'GetListGroupByIDsAdminV2' test.out

#- 55 GetUserJoinedGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserJoinedGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --userId 'cPA2n25C1zEnAMGm' \
    --limit '65' \
    --offset '94' \
    > test.out 2>&1
eval_tap $? 55 'GetUserJoinedGroupInformationPublicV2' test.out

#- 56 AdminGetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op AdminGetUserGroupStatusInformationV2 \
    --groupId 'y7w6eqnMeKFo7U8S' \
    --namespace $AB_NAMESPACE \
    --userId 'cr9xm68w7s9RMx2h' \
    > test.out 2>&1
eval_tap $? 56 'AdminGetUserGroupStatusInformationV2' test.out

#- 57 CreateNewGroupPublicV2
# body param: body
echo '{"configurationCode": "c45QX234xnqlbRAP", "customAttributes": {"FQsca6n9vGZTCCXQ": {}, "2Lf7jtexB613cbiJ": {}, "EUePVZQaoEY2zrpL": {}}, "groupDescription": "uvrx96OOz45vMiR3", "groupIcon": "QYZJKVNlK8PTaIXR", "groupMaxMember": 100, "groupName": "jbsrRBV8aztJ86yQ", "groupRegion": "K1AsC18UO6JcXmwQ", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "fkseTpH6l2Dv8Svq", "ruleDetail": [{"ruleAttribute": "YKc56PcPSL2xmjVi", "ruleCriteria": "MINIMUM", "ruleValue": 0.10619257513009805}, {"ruleAttribute": "zFvpvIerFEyxTugo", "ruleCriteria": "MINIMUM", "ruleValue": 0.049037009915927965}, {"ruleAttribute": "KzcKtkGcvn44NWse", "ruleCriteria": "MINIMUM", "ruleValue": 0.7730005672806066}]}, {"allowedAction": "LPkM1VTrQBywhJ7l", "ruleDetail": [{"ruleAttribute": "bBLw9xy1WQM5qUS8", "ruleCriteria": "EQUAL", "ruleValue": 0.36830680074996525}, {"ruleAttribute": "NLLfKCQKuu2MWXpE", "ruleCriteria": "EQUAL", "ruleValue": 0.6664663079295797}, {"ruleAttribute": "jj8zDwOk0IgmYfUT", "ruleCriteria": "EQUAL", "ruleValue": 0.3036409207442953}]}, {"allowedAction": "XDish7KUVhmAwmAy", "ruleDetail": [{"ruleAttribute": "gsnn8pM7l6v0elLM", "ruleCriteria": "EQUAL", "ruleValue": 0.9679240888232151}, {"ruleAttribute": "dzohxhbej2caIIfk", "ruleCriteria": "EQUAL", "ruleValue": 0.4700664594904861}, {"ruleAttribute": "Y7jnhp3qY6T7TUEB", "ruleCriteria": "EQUAL", "ruleValue": 0.48500751197257075}]}]}, "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'CreateNewGroupPublicV2' test.out

#- 58 GetListGroupByIDsV2
# body param: body
echo '{"groupIDs": ["0E4ZboiXT1Uy0gAr", "tDpQE4bOtoiAjHXc", "VVOsVywU6uisejap"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'GetListGroupByIDsV2' test.out

#- 59 UpdatePutSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "ftqoxujXDosOo2kS", "groupIcon": "UfIA1guTNx7haejX", "groupName": "SV2oH2uH8S4Zx0AC", "groupRegion": "teueMOmYP4SgxAIQ", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePutSingleGroupPublicV2 \
    --groupId 'buMCz9J4dPRGzoQL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'UpdatePutSingleGroupPublicV2' test.out

#- 60 DeleteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV2 \
    --groupId 'YIWPPZvyPupimCEN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'DeleteGroupPublicV2' test.out

#- 61 UpdatePatchSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "HEenqjRSxO9oZ0fC", "groupIcon": "xLR0GfjwCmDrbDR0", "groupName": "Q0ixpqYtkZuhL6qb", "groupRegion": "AhRExsnbWSH45Lar", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV2 \
    --groupId 'Rt6wM5oQvTMICtWy' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'UpdatePatchSingleGroupPublicV2' test.out

#- 62 UpdateGroupCustomAttributesPublicV2
# body param: body
echo '{"customAttributes": {"UtVDnhgTGXO8Utpw": {}, "xug8MpqczRvUdK1u": {}, "OV1ZJTYuHpnpVX5u": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV2 \
    --groupId '4gw4XBXDD7BG73sD' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'UpdateGroupCustomAttributesPublicV2' test.out

#- 63 AcceptGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV2 \
    --groupId 'dDoXnB8F5X05KUgG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'AcceptGroupInvitationPublicV2' test.out

#- 64 RejectGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV2 \
    --groupId 'KfDSGh3vQFPSYCi8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'RejectGroupInvitationPublicV2' test.out

#- 65 GetGroupInviteRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupInviteRequestPublicV2 \
    --groupId 'WEjR3wqpnMdSNskx' \
    --namespace $AB_NAMESPACE \
    --limit '15' \
    --offset '23' \
    > test.out 2>&1
eval_tap $? 65 'GetGroupInviteRequestPublicV2' test.out

#- 66 JoinGroupV2
$CLI_EXE \
    --sn group \
    --op JoinGroupV2 \
    --groupId '5zWtwYhRoNPwKema' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'JoinGroupV2' test.out

#- 67 GetGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV2 \
    --groupId '6caMTOcivPAkmP8A' \
    --namespace $AB_NAMESPACE \
    --limit '46' \
    --offset '3' \
    > test.out 2>&1
eval_tap $? 67 'GetGroupJoinRequestPublicV2' test.out

#- 68 LeaveGroupPublicV2
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV2 \
    --groupId 'NT7JTRFV3FxMl5Rw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 68 'LeaveGroupPublicV2' test.out

#- 69 UpdateGroupCustomRulePublicV2
# body param: body
echo '{"groupCustomRule": {"4YeHqWkG09iEAFYW": {}, "how1WAwCs9Y0KOem": {}, "hNPYUVA9mU8UvONy": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV2 \
    --groupId 'jv3GQuLHoQ6ehLLK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'UpdateGroupCustomRulePublicV2' test.out

#- 70 UpdateGroupPredefinedRulePublicV2
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "5h1bE9WU6w3tjUhS", "ruleCriteria": "MAXIMUM", "ruleValue": 0.4649034111703729}, {"ruleAttribute": "2ynue7Xk4uDF5mda", "ruleCriteria": "EQUAL", "ruleValue": 0.5526173769689559}, {"ruleAttribute": "FfwBBqG51RaZY74C", "ruleCriteria": "MAXIMUM", "ruleValue": 0.10024384445315981}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV2 \
    --allowedAction 'XyFuLFZViQbxYQvU' \
    --groupId 'yapo6FmMy6tZYSCe' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'UpdateGroupPredefinedRulePublicV2' test.out

#- 71 DeleteGroupPredefinedRulePublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV2 \
    --allowedAction '7du68Ce6T4pYH3BP' \
    --groupId 'yFurT4p8zoRYG8WK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 71 'DeleteGroupPredefinedRulePublicV2' test.out

#- 72 GetMemberRolesListPublicV2
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '94' \
    --offset '4' \
    > test.out 2>&1
eval_tap $? 72 'GetMemberRolesListPublicV2' test.out

#- 73 UpdateMemberRolePublicV2
# body param: body
echo '{"userId": "aUyB0UyrKKulHUno"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV2 \
    --groupId 'mpTrS7DIOakX65w7' \
    --memberRoleId 'RpxY6pd1QTpFpaxb' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'UpdateMemberRolePublicV2' test.out

#- 74 DeleteMemberRolePublicV2
# body param: body
echo '{"userId": "CjHSCXM7sL1nnOoR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV2 \
    --groupId 'Ig7oSh4yVttp53wa' \
    --memberRoleId 'suHbA0keUomVCh68' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'DeleteMemberRolePublicV2' test.out

#- 75 GetUserGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    --offset '84' \
    > test.out 2>&1
eval_tap $? 75 'GetUserGroupInformationPublicV2' test.out

#- 76 GetMyGroupJoinRequestV2
$CLI_EXE \
    --sn group \
    --op GetMyGroupJoinRequestV2 \
    --namespace $AB_NAMESPACE \
    --limit '59' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 76 'GetMyGroupJoinRequestV2' test.out

#- 77 InviteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV2 \
    --groupId 'x0ZiHwUqL5rITYFh' \
    --namespace $AB_NAMESPACE \
    --userId 'cdeNwLmZenRqEBM0' \
    > test.out 2>&1
eval_tap $? 77 'InviteGroupPublicV2' test.out

#- 78 CancelInvitationGroupMemberV2
$CLI_EXE \
    --sn group \
    --op CancelInvitationGroupMemberV2 \
    --groupId 'VGzhVVGdipdi33u9' \
    --namespace $AB_NAMESPACE \
    --userId 'U14rGwvMExAllZtP' \
    > test.out 2>&1
eval_tap $? 78 'CancelInvitationGroupMemberV2' test.out

#- 79 AcceptGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV2 \
    --groupId 'zNRiR35CZhclugjy' \
    --namespace $AB_NAMESPACE \
    --userId 'DzCPI8tslD0HuRrA' \
    > test.out 2>&1
eval_tap $? 79 'AcceptGroupJoinRequestPublicV2' test.out

#- 80 RejectGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV2 \
    --groupId 'MzMB9XHHkfZgB6Vt' \
    --namespace $AB_NAMESPACE \
    --userId '5qWaae3SboVKgjsr' \
    > test.out 2>&1
eval_tap $? 80 'RejectGroupJoinRequestPublicV2' test.out

#- 81 KickGroupMemberPublicV2
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV2 \
    --groupId 'yC98whmI5koBT6iC' \
    --namespace $AB_NAMESPACE \
    --userId 'uVa643kk8gvvnsu0' \
    > test.out 2>&1
eval_tap $? 81 'KickGroupMemberPublicV2' test.out

#- 82 GetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupStatusInformationV2 \
    --groupId 'ABei0go2wsmPfpsb' \
    --namespace $AB_NAMESPACE \
    --userId 'kzAIsJ06QlFCAa55' \
    > test.out 2>&1
eval_tap $? 82 'GetUserGroupStatusInformationV2' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE