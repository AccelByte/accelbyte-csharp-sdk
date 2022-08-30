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
echo "1..45"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op ListGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '60' \
    --offset '18' \
    > test.out 2>&1
eval_tap $? 2 'ListGroupConfigurationAdminV1' test.out

#- 3 CreateGroupConfigurationAdminV1
# body param: body
echo '{"configurationCode": "QYSzUjni", "description": "DHAyMFTI", "globalRules": [{"allowedAction": "c5KnxahX", "ruleDetail": [{"ruleAttribute": "ENLJdrvu", "ruleCriteria": "MAXIMUM", "ruleValue": 0.6502971796019917}, {"ruleAttribute": "BSKlRVEd", "ruleCriteria": "EQUAL", "ruleValue": 0.7706520280543081}, {"ruleAttribute": "XxrmryDF", "ruleCriteria": "EQUAL", "ruleValue": 0.19639009613254454}]}, {"allowedAction": "OTje0xOc", "ruleDetail": [{"ruleAttribute": "McgfHKGf", "ruleCriteria": "MAXIMUM", "ruleValue": 0.5315526472882596}, {"ruleAttribute": "vmh3Xz5i", "ruleCriteria": "MAXIMUM", "ruleValue": 0.7266526573653499}, {"ruleAttribute": "xh2MOlGP", "ruleCriteria": "MAXIMUM", "ruleValue": 0.5469281399275027}]}, {"allowedAction": "jVvKyJi6", "ruleDetail": [{"ruleAttribute": "0leWmEG7", "ruleCriteria": "MINIMUM", "ruleValue": 0.3973854682840525}, {"ruleAttribute": "zqJ0O4R2", "ruleCriteria": "MAXIMUM", "ruleValue": 0.264141607675924}, {"ruleAttribute": "bOmtUTMz", "ruleCriteria": "MAXIMUM", "ruleValue": 0.059075131411622905}]}], "groupAdminRoleId": "unod7AKG", "groupMaxMember": 88, "groupMemberRoleId": "DFjzGJ69", "name": "BmAvETmO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateGroupConfigurationAdminV1' test.out

#- 4 InitiateGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op InitiateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'InitiateGroupConfigurationAdminV1' test.out

#- 5 GetGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupConfigurationAdminV1 \
    --configurationCode 'KQQ3sq8C' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'GetGroupConfigurationAdminV1' test.out

#- 6 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'NDrABI2B' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteGroupConfigurationV1' test.out

#- 7 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "VMaOntoV", "groupMaxMember": 60, "name": "xPArlNRs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode 'SpSitwXl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateGroupConfigurationAdminV1' test.out

#- 8 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "fYCP6Kov", "ruleCriteria": "MINIMUM", "ruleValue": 0.005439460468144808}, {"ruleAttribute": "1dvR8uEy", "ruleCriteria": "MINIMUM", "ruleValue": 0.39166797980642365}, {"ruleAttribute": "055HozqA", "ruleCriteria": "MAXIMUM", "ruleValue": 0.6682775856226918}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'bXRsGTcr' \
    --configurationCode 'YPnEKpxN' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateGroupConfigurationGlobalRuleAdminV1' test.out

#- 9 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'iuvPbKwa' \
    --configurationCode 'YGCnwN51' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteGroupConfigurationGlobalRuleAdminV1' test.out

#- 10 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $AB_NAMESPACE \
    --configurationCode 'zRjaepfW' \
    --groupName 'gkMOB7hz' \
    --groupRegion 'RsnAyHwX' \
    --limit '67' \
    --offset '98' \
    > test.out 2>&1
eval_tap $? 10 'GetGroupListAdminV1' test.out

#- 11 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId 'IVIGhV8l' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'GetSingleGroupAdminV1' test.out

#- 12 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId 'HmnsKGHP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'DeleteGroupAdminV1' test.out

#- 13 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId 'zZHyR4c7' \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '90' \
    --order 'WJpgoHa4' \
    > test.out 2>&1
eval_tap $? 13 'GetGroupMembersListAdminV1' test.out

#- 14 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 14 'GetMemberRolesListAdminV1' test.out

#- 15 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "lXRGzND7", "memberRolePermissions": [{"action": 91, "resourceName": "1VtolHkR"}, {"action": 59, "resourceName": "x3ovMwoS"}, {"action": 13, "resourceName": "GZhSc0Il"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateMemberRoleAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'CreateMemberRoleAdminV1' test.out

#- 16 GetSingleMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleMemberRoleAdminV1 \
    --memberRoleId 'TShyUTeX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'GetSingleMemberRoleAdminV1' test.out

#- 17 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId 'shimpQ46' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteMemberRoleAdminV1' test.out

#- 18 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "bp6GTF9M"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId '6vXNzsfx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMemberRoleAdminV1' test.out

#- 19 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 34, "resourceName": "DeBaAal8"}, {"action": 13, "resourceName": "X0gNZzHa"}, {"action": 0, "resourceName": "3OH5W4VW"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId 'hS6dXmpl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMemberRolePermissionAdminV1' test.out

#- 20 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $AB_NAMESPACE \
    --groupName 'iEV0dBoZ' \
    --groupRegion 'HnPu3Ahb' \
    --limit '20' \
    --offset '32' \
    > test.out 2>&1
eval_tap $? 20 'GetGroupListPublicV1' test.out

#- 21 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "fr3VEgbn", "customAttributes": {"W6jyiMBK": {}, "lMIyrnMe": {}, "K3mipmqR": {}}, "groupDescription": "0ZLMSN9d", "groupIcon": "PMYnmxEk", "groupMaxMember": 58, "groupName": "MCUKioJU", "groupRegion": "yLPEiFQD", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "q3IRnK20", "ruleDetail": [{"ruleAttribute": "ZEsGbsAe", "ruleCriteria": "MINIMUM", "ruleValue": 0.5759033067765741}, {"ruleAttribute": "Zump6uHR", "ruleCriteria": "MINIMUM", "ruleValue": 0.6587594067181428}, {"ruleAttribute": "aVtVyUM0", "ruleCriteria": "MINIMUM", "ruleValue": 0.9728187413196646}]}, {"allowedAction": "7uktStjk", "ruleDetail": [{"ruleAttribute": "dqKTHbLK", "ruleCriteria": "EQUAL", "ruleValue": 0.8930760061072066}, {"ruleAttribute": "e8gJJrA7", "ruleCriteria": "MINIMUM", "ruleValue": 0.2972783304258584}, {"ruleAttribute": "jZtFd7uU", "ruleCriteria": "MINIMUM", "ruleValue": 0.3269277712569689}]}, {"allowedAction": "ZMGycqbx", "ruleDetail": [{"ruleAttribute": "cV2y9gll", "ruleCriteria": "EQUAL", "ruleValue": 0.31875451204824956}, {"ruleAttribute": "Jv8uXN9v", "ruleCriteria": "EQUAL", "ruleValue": 0.7894802159610955}, {"ruleAttribute": "dLVKzOxe", "ruleCriteria": "EQUAL", "ruleValue": 0.7513789881957312}]}]}, "groupType": "YKcam2kL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateNewGroupPublicV1' test.out

#- 22 GetSingleGroupPublicV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupPublicV1 \
    --groupId 'FLPeJFkf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'GetSingleGroupPublicV1' test.out

#- 23 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "oZKp4YEO", "groupIcon": "F6yUz6eM", "groupName": "MQMHZmVW", "groupRegion": "7Xg9NFPd", "groupType": "7O4ZDiR2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId 'YkxjWCdF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateSingleGroupV1' test.out

#- 24 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'gMrHAdEk' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'DeleteGroupPublicV1' test.out

#- 25 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "v9YQ6t4T", "groupIcon": "4dq9RSdY", "groupName": "2J7adIIM", "groupRegion": "XgGxlVoq", "groupType": "ACD17iDM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId 'UyvUWZE2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdatePatchSingleGroupPublicV1' test.out

#- 26 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"smtvTjYO": {}, "AM6b3TFQ": {}, "vPvM3uAg": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'DfYEFGQL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateGroupCustomAttributesPublicV1' test.out

#- 27 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId 'oPdgyOKx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'AcceptGroupInvitationPublicV1' test.out

#- 28 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId 'tJAEo2xd' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'RejectGroupInvitationPublicV1' test.out

#- 29 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'cGURBIEB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'JoinGroupV1' test.out

#- 30 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'l9peG3o1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'CancelGroupJoinRequestV1' test.out

#- 31 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId '6IRC4QzE' \
    --namespace $AB_NAMESPACE \
    --limit '33' \
    --offset '28' \
    > test.out 2>&1
eval_tap $? 31 'GetGroupJoinRequestPublicV1' test.out

#- 32 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId 'tDoARMSD' \
    --namespace $AB_NAMESPACE \
    --limit '84' \
    --offset '44' \
    --order 'aB4GF58K' \
    > test.out 2>&1
eval_tap $? 32 'GetGroupMembersListPublicV1' test.out

#- 33 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"tlwsfxNj": {}, "IBtEW7gS": {}, "2WlCwo3k": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'IGTeuleO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateGroupCustomRulePublicV1' test.out

#- 34 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "MpQzyhMN", "ruleCriteria": "MAXIMUM", "ruleValue": 0.1931919900404041}, {"ruleAttribute": "puPmy0Zz", "ruleCriteria": "EQUAL", "ruleValue": 0.6295768210406704}, {"ruleAttribute": "gyNomEnR", "ruleCriteria": "EQUAL", "ruleValue": 0.042087813978852306}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction 'VEwrnvVm' \
    --groupId 'vNbW9nE3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGroupPredefinedRulePublicV1' test.out

#- 35 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction 'RhBABvow' \
    --groupId 'jYhFRKgW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteGroupPredefinedRulePublicV1' test.out

#- 36 LeaveGroupPublicV1
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'LeaveGroupPublicV1' test.out

#- 37 GetMemberRolesListPublicV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '8' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 37 'GetMemberRolesListPublicV1' test.out

#- 38 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "eU3GLzv5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'ERT577xc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateMemberRolePublicV1' test.out

#- 39 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "aKlQyddP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'kNNtWD94' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'DeleteMemberRolePublicV1' test.out

#- 40 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '68' \
    > test.out 2>&1
eval_tap $? 40 'GetGroupInvitationRequestPublicV1' test.out

#- 41 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'gua4NEbF' \
    > test.out 2>&1
eval_tap $? 41 'GetUserGroupInformationPublicV1' test.out

#- 42 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'JjQ35mZb' \
    > test.out 2>&1
eval_tap $? 42 'InviteGroupPublicV1' test.out

#- 43 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Nn657Vzr' \
    > test.out 2>&1
eval_tap $? 43 'AcceptGroupJoinRequestPublicV1' test.out

#- 44 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'DV78zMzi' \
    > test.out 2>&1
eval_tap $? 44 'RejectGroupJoinRequestPublicV1' test.out

#- 45 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '6qDvpdFY' \
    > test.out 2>&1
eval_tap $? 45 'KickGroupMemberPublicV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE