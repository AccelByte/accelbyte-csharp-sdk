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

OPERATIONS_COUNT=44

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

#- 1 ListGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op ListGroupConfigurationAdminV1 \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '56' \
    >$TEMP_FILE 2>&1
update_status $? 'ListGroupConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 CreateGroupConfigurationAdminV1
# body param: body
echo '{"configurationCode": "jv4Ax7Nz", "description": "Ykoppa0V", "globalRules": [{"allowedAction": "gFJAhHwT", "ruleDetail": [{"ruleAttribute": "b5q010gN", "ruleCriteria": "MAXIMUM", "ruleValue": 0.6659805943942503}]}], "groupAdminRoleId": "bpeRnxTl", "groupMaxMember": 57, "groupMemberRoleId": "TFSMIbl1", "name": "a2jXLCtW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateGroupConfigurationAdminV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateGroupConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 InitiateGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op InitiateGroupConfigurationAdminV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'InitiateGroupConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 GetGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupConfigurationAdminV1 \
    --configurationCode 'mHJBi9So' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'MkSE4eJe' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroupConfigurationV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "lwO4KPMk", "groupMaxMember": 48, "name": "2h8R2fIX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode 'oXP8gd7J' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGroupConfigurationAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "UabYc3GM", "ruleCriteria": "EQUAL", "ruleValue": 0.37114583485030817}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'lm1fsu6J' \
    --configurationCode '3C4s5ppG' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGroupConfigurationGlobalRuleAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'R9XcoxYT' \
    --configurationCode 'GgewrLfw' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroupConfigurationGlobalRuleAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $TEST_NAMESPACE \
    --configurationCode 'vzJF4Tpb' \
    --groupName 'NhKq2xdm' \
    --groupRegion 'gEBepFHt' \
    --limit '10' \
    --offset '17' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupListAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId 'egqdEL4f' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetSingleGroupAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId 'sM6nBzRV' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroupAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId 'uC1r7UH1' \
    --namespace $TEST_NAMESPACE \
    --limit '75' \
    --offset '16' \
    --order 'u7UQ0304' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupMembersListAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $TEST_NAMESPACE \
    --limit '77' \
    --offset '4' \
    >$TEMP_FILE 2>&1
update_status $? 'GetMemberRolesListAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "K873tRtr", "memberRolePermissions": [{"action": 4, "resourceName": "fWO5JJ2c"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateMemberRoleAdminV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateMemberRoleAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 GetSingleMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleMemberRoleAdminV1 \
    --memberRoleId '6vsOns4j' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetSingleMemberRoleAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId 'NWGc7CiU' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteMemberRoleAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "a4wM5Eu3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId 'VqymsFXp' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateMemberRoleAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 29, "resourceName": "rMqEDR8E"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId '72XMKfhl' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateMemberRolePermissionAdminV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $TEST_NAMESPACE \
    --groupName '6eq2FzU3' \
    --groupRegion 'VL3LNmPL' \
    --limit '9' \
    --offset '6' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupListPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "oCXfabFX", "customAttributes": {"zvjLmai7": {}}, "groupDescription": "fPKvE2Z4", "groupIcon": "a63UVtLb", "groupMaxMember": 85, "groupName": "SWtsyz0m", "groupRegion": "GGyHHFIl", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "IKsXgvSr", "ruleDetail": [{"ruleAttribute": "kEgTYVk5", "ruleCriteria": "EQUAL", "ruleValue": 0.6740426303865813}]}]}, "groupType": "E6zJJ1BR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateNewGroupPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 GetSingleGroupPublicV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupPublicV1 \
    --groupId 'HrfCHqqp' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetSingleGroupPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "2GwPcmzS", "groupIcon": "uY8w9VYw", "groupName": "BEfRXoZL", "groupRegion": "fpVFfDwj", "groupType": "HHCW2g5u"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId '8z9yrpJd' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSingleGroupV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'Ix5vvHS3' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroupPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "d6PKPE27", "groupIcon": "mI6Px8jt", "groupName": "8Lq4x0F7", "groupRegion": "NcocelJj", "groupType": "tlKYu8iC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId 'Pznx0s5T' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePatchSingleGroupPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"zT51oV4H": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'Tmivmb6t' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGroupCustomAttributesPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId 'PmCirkhY' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AcceptGroupInvitationPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId 'vcOUucjP' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RejectGroupInvitationPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'WGwPsvjL' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'JoinGroupV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'K1CjPt93' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'CancelGroupJoinRequestV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId 'utbMkpUF' \
    --namespace $TEST_NAMESPACE \
    --limit '67' \
    --offset '90' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupJoinRequestPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId '0fL9q9SM' \
    --namespace $TEST_NAMESPACE \
    --limit '79' \
    --offset '52' \
    --order 'UQVoiQtS' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupMembersListPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"QC2kNSsm": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'T0d2aBG4' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGroupCustomRulePublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "zA2zp1Ls", "ruleCriteria": "EQUAL", "ruleValue": 0.4548686363401978}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction 'dGgwkYgH' \
    --groupId 'zKuI2RJr' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGroupPredefinedRulePublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction 'boP7kfpI' \
    --groupId 'letXrCK1' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroupPredefinedRulePublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 LeaveGroupPublicV1
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'LeaveGroupPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 GetMemberRolesListPublicV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV1 \
    --namespace $TEST_NAMESPACE \
    --limit '93' \
    --offset '94' \
    >$TEMP_FILE 2>&1
update_status $? 'GetMemberRolesListPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "O0jcs7nC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'qsodoTFT' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateMemberRolePublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "cWlaIBJA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'AknU6Hob' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteMemberRolePublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $TEST_NAMESPACE \
    --limit '13' \
    --offset '97' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupInvitationRequestPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'laLnedDf' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserGroupInformationPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'asTc8gr2' \
    >$TEMP_FILE 2>&1
update_status $? 'InviteGroupPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'znWqD6tI' \
    >$TEMP_FILE 2>&1
update_status $? 'AcceptGroupJoinRequestPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'cfI5Z4tU' \
    >$TEMP_FILE 2>&1
update_status $? 'RejectGroupJoinRequestPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'NQ7mQPjC' \
    >$TEMP_FILE 2>&1
update_status $? 'KickGroupMemberPublicV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT