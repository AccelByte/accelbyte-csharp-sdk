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

OPERATIONS_COUNT=90

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

#- 1 GetUserFriendsUpdated
$CLI_EXE \
    --sn lobby \
    --op GetUserFriendsUpdated \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '56' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserFriendsUpdated'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 GetUserIncomingFriends
$CLI_EXE \
    --sn lobby \
    --op GetUserIncomingFriends \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserIncomingFriends'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetUserOutgoingFriends
$CLI_EXE \
    --sn lobby \
    --op GetUserOutgoingFriends \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOutgoingFriends'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 UserRequestFriend
# body param: body
echo '{"friendId": "jv4Ax7Nz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRequestFriend \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UserRequestFriend'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 UserAcceptFriendRequest
# body param: body
echo '{"friendId": "Ykoppa0V"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserAcceptFriendRequest \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UserAcceptFriendRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 UserCancelFriendRequest
# body param: body
echo '{"friendId": "gFJAhHwT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserCancelFriendRequest \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UserCancelFriendRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 UserRejectFriendRequest
# body param: body
echo '{"friendId": "b5q010gN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRejectFriendRequest \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UserRejectFriendRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 UserGetFriendshipStatus
$CLI_EXE \
    --sn lobby \
    --op UserGetFriendshipStatus \
    --friendId '2MQrbpeR' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'UserGetFriendshipStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 UserUnfriendRequest
# body param: body
echo '{"friendId": "nxTlCTFS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserUnfriendRequest \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UserUnfriendRequest'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 AddFriendsWithoutConfirmation
# body param: body
echo '{"friendIds": ["MIbl1a2j"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AddFriendsWithoutConfirmation \
    --namespace $TEST_NAMESPACE \
    --userId 'XLCtWmHJ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddFriendsWithoutConfirmation'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 PersonalChatHistory
$CLI_EXE \
    --sn lobby \
    --op PersonalChatHistory \
    --friendId 'Bi9SoMkS' \
    --namespace $TEST_NAMESPACE \
    --userId 'E4eJelwO' \
    >$TEMP_FILE 2>&1
update_status $? 'PersonalChatHistory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 AdminChatHistory
$CLI_EXE \
    --sn lobby \
    --op AdminChatHistory \
    --friendId '4KPMky2h' \
    --namespace $TEST_NAMESPACE \
    --userId '8R2fIXoX' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminChatHistory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 AdminGetAllConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllConfigV1 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAllConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 AdminGetConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetConfigV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 AdminUpdateConfigV1
# body param: body
echo '{"allowInviteNonConnectedUser": false, "allowJoinPartyDuringMatchmaking": false, "autoKickOnDisconnect": false, "autoKickOnDisconnectDelay": 3, "cancelTicketOnDisconnect": false, "chatRateLimitBurst": 65, "chatRateLimitDuration": 77, "concurrentUsersLimit": 2, "disableInvitationOnJoinParty": true, "enableChat": false, "entitlementCheck": false, "entitlementItemID": "1fsu6J3C", "generalRateLimitBurst": 36, "generalRateLimitDuration": 30, "keepPresenceActivityOnDisconnect": false, "maxPartyMember": 64, "profanityFilter": false, "readyConsentTimeout": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateConfigV1 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 AdminExportConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminExportConfigV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminExportConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 AdminImportConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminImportConfigV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminImportConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 GetListOfFriends
$CLI_EXE \
    --sn lobby \
    --op GetListOfFriends \
    --namespace $TEST_NAMESPACE \
    --userId 'xYTGgewr' \
    --limit '75' \
    --offset '10' \
    >$TEMP_FILE 2>&1
update_status $? 'GetListOfFriends'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 SendMultipleUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "wvzJF4Tp", "topicName": "bNhKq2xd", "userIds": ["mgEBepFH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendMultipleUsersFreeformNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendMultipleUsersFreeformNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 SendUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "tf6Ziegq", "topicName": "dEL4fsM6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersFreeformNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendUsersFreeformNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 SendPartyFreeformNotificationV1Admin
# body param: body
echo '{"message": "nBzRVuC1", "topicName": "r7UH1Liu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyFreeformNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --partyId '7UQ0304M' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendPartyFreeformNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 SendPartyTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"cK873tRt": "r5cfWO5J"}, "templateLanguage": "J2c6vsOn", "templateSlug": "s4jNWGc7", "topicName": "CiUa4wM5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyTemplatedNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --partyId 'Eu3Vqyms' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendPartyTemplatedNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 GetAllNotificationTemplatesV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTemplatesV1Admin \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllNotificationTemplatesV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 CreateNotificationTemplateV1Admin
# body param: body
echo '{"templateContent": "FXporMqE", "templateLanguage": "DR8E72XM", "templateSlug": "Kfhl6eq2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTemplateV1Admin \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateNotificationTemplateV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 SendUsersTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"FzU3VL3L": "NmPLeZdo"}, "templateLanguage": "CXfabFXz", "templateSlug": "vjLmai7f", "topicName": "PKvE2Z4a"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersTemplatedNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendUsersTemplatedNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GetTemplateSlugLocalizationsTemplateV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetTemplateSlugLocalizationsTemplateV1Admin \
    --namespace $TEST_NAMESPACE \
    --templateSlug '63UVtLbQ' \
    --after 'SWtsyz0m' \
    --before 'GGyHHFIl' \
    --limit '68' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTemplateSlugLocalizationsTemplateV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 DeleteNotificationTemplateSlugV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTemplateSlugV1Admin \
    --namespace $TEST_NAMESPACE \
    --templateSlug 'KsXgvSrk' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteNotificationTemplateSlugV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 GetSingleTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetSingleTemplateLocalizationV1Admin \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'EgTYVk5i' \
    --templateSlug 'RBE6zJJ1' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSingleTemplateLocalizationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 UpdateTemplateLocalizationV1Admin
# body param: body
echo '{"templateContent": "BRHrfCHq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTemplateLocalizationV1Admin \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'qp2GwPcm' \
    --templateSlug 'zSuY8w9V' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateTemplateLocalizationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 DeleteTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalizationV1Admin \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'YwBEfRXo' \
    --templateSlug 'ZLfpVFfD' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTemplateLocalizationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 PublishTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op PublishTemplateLocalizationV1Admin \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'wjHHCW2g' \
    --templateSlug '5u8z9yrp' \
    >$TEMP_FILE 2>&1
update_status $? 'PublishTemplateLocalizationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 GetAllNotificationTopicsV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTopicsV1Admin \
    --namespace $TEST_NAMESPACE \
    --after 'JdIx5vvH' \
    --before 'S3d6PKPE' \
    --limit '24' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllNotificationTopicsV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 CreateNotificationTopicV1Admin
# body param: body
echo '{"description": "I6Px8jt8", "topicName": "Lq4x0F7N"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTopicV1Admin \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateNotificationTopicV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 GetNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetNotificationTopicV1Admin \
    --namespace $TEST_NAMESPACE \
    --topicName 'cocelJjt' \
    >$TEMP_FILE 2>&1
update_status $? 'GetNotificationTopicV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 UpdateNotificationTopicV1Admin
# body param: body
echo '{"description": "lKYu8iCP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateNotificationTopicV1Admin \
    --namespace $TEST_NAMESPACE \
    --topicName 'znx0s5Tz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateNotificationTopicV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 DeleteNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTopicV1Admin \
    --namespace $TEST_NAMESPACE \
    --topicName 'T51oV4HT' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteNotificationTopicV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 SendSpecificUserFreeformNotificationV1Admin
# body param: body
echo '{"message": "mivmb6tP", "topicName": "mCirkhYv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserFreeformNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --userId 'cOUucjPW' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendSpecificUserFreeformNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 SendSpecificUserTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"GwPsvjLK": "1CjPt93u"}, "templateLanguage": "tbMkpUFH", "templateSlug": "T0fL9q9S", "topicName": "MNAUQVoi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserTemplatedNotificationV1Admin \
    --namespace $TEST_NAMESPACE \
    --userId 'QtSQC2kN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendSpecificUserTemplatedNotificationV1Admin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 AdminGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPartyDataV1 \
    --namespace $TEST_NAMESPACE \
    --partyId 'SsmT0d2a' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetPartyDataV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 AdminUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"BG4zA2zp": {}}, "updatedAt": 74}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdatePartyAttributesV1 \
    --namespace $TEST_NAMESPACE \
    --partyId 's0bD6dGg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdatePartyAttributesV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 AdminJoinPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminJoinPartyV1 \
    --namespace $TEST_NAMESPACE \
    --partyId 'wkYgHzKu' \
    --userId 'I2RJrboP' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminJoinPartyV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 AdminGetUserPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetUserPartyV1 \
    --namespace $TEST_NAMESPACE \
    --userId '7kfpIlet' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserPartyV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 AdminGetLobbyCCU
$CLI_EXE \
    --sn lobby \
    --op AdminGetLobbyCCU \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetLobbyCCU'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 AdminGetAllPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllPlayerSessionAttribute \
    --namespace $TEST_NAMESPACE \
    --userId 'XrCK1UVO' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAllPlayerSessionAttribute'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 AdminSetPlayerSessionAttribute
# body param: body
echo '{"attributes": {"0jcs7nCq": "sodoTFTc"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetPlayerSessionAttribute \
    --namespace $TEST_NAMESPACE \
    --userId 'WlaIBJAA' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSetPlayerSessionAttribute'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 AdminGetPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerSessionAttribute \
    --attribute 'knU6HobZ' \
    --namespace $TEST_NAMESPACE \
    --userId 'gWlaLned' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetPlayerSessionAttribute'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 AdminGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedPlayersV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'DfasTc8g' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetPlayerBlockedPlayersV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 AdminGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedByPlayersV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'r2znWqD6' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetPlayerBlockedByPlayersV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 AdminBulkBlockPlayersV1
# body param: body
echo '{"listBlockedUserId": ["tIcfI5Z4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminBulkBlockPlayersV1 \
    --namespace $TEST_NAMESPACE \
    --userId 'tUNQ7mQP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminBulkBlockPlayersV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 AdminDebugProfanityFilters
# body param: body
echo '{"text": "jCalZgFV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDebugProfanityFilters \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDebugProfanityFilters'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 AdminGetProfanityListFiltersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityListFiltersV1 \
    --list 'EQyqav09' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetProfanityListFiltersV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 AdminAddProfanityFilterIntoList
# body param: body
echo '{"filter": "OYmxCvMq", "note": "VcXs2OqN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilterIntoList \
    --list 'z8ZLBsnc' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddProfanityFilterIntoList'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 AdminAddProfanityFilters
# body param: body
echo '{"filters": [{"filter": "bRrf6uEd", "note": "jUnr04WZ"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilters \
    --list 'NhgEGvqK' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddProfanityFilters'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 AdminImportProfanityFiltersFromFile
# body param: body
echo '[96]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminImportProfanityFiltersFromFile \
    --list 'QTkE65j6' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminImportProfanityFiltersFromFile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 AdminDeleteProfanityFilter
# body param: body
echo '{"filter": "186p0Wfs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityFilter \
    --list 'nWZuUPsa' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteProfanityFilter'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 AdminGetProfanityLists
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityLists \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetProfanityLists'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 AdminCreateProfanityList
# body param: body
echo '{"isEnabled": false, "isMandatory": false, "name": "rdBA2hXw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateProfanityList \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateProfanityList'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 58 AdminUpdateProfanityList
# body param: body
echo '{"isEnabled": true, "isMandatory": true, "newName": "ZMdlR4cL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateProfanityList \
    --list '76hnFDgT' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateProfanityList'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 59 AdminDeleteProfanityList
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityList \
    --list 'fofHdfoS' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteProfanityList'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 60 AdminGetProfanityRule
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityRule \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetProfanityRule'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 AdminSetProfanityRuleForNamespace
# body param: body
echo '{"rule": "qDcaFhOc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetProfanityRuleForNamespace \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSetProfanityRuleForNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 AdminVerifyMessageProfanityResponse
# body param: body
echo '{"message": "1oKxI8f5", "profanityLevel": "ocfy4EIx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminVerifyMessageProfanityResponse \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyMessageProfanityResponse'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 AdminGetThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetThirdPartyConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetThirdPartyConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 AdminUpdateThirdPartyConfig
# body param: body
echo '{"apiKey": "wBiB90vd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateThirdPartyConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateThirdPartyConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 65 AdminCreateThirdPartyConfig
# body param: body
echo '{"apiKey": "gS5YpKsd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateThirdPartyConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateThirdPartyConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 AdminDeleteThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteThirdPartyConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteThirdPartyConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 67 PublicGetMessages
$CLI_EXE \
    --sn lobby \
    --op PublicGetMessages \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMessages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 GetPersonalChatHistoryV1Public
$CLI_EXE \
    --sn lobby \
    --op GetPersonalChatHistoryV1Public \
    --friendId 'bpiU2Ufy' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPersonalChatHistoryV1Public'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 69 PublicGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPartyDataV1 \
    --namespace $TEST_NAMESPACE \
    --partyId 'MO4DhL9f' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPartyDataV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 70 PublicUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"BKJvjBOU": {}}, "updatedAt": 26}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUpdatePartyAttributesV1 \
    --namespace $TEST_NAMESPACE \
    --partyId '3bYf5ouX' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdatePartyAttributesV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 71 PublicGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedPlayersV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPlayerBlockedPlayersV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 72 PublicGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedByPlayersV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPlayerBlockedByPlayersV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 UsersPresenceHandlerV1
$CLI_EXE \
    --sn lobby \
    --op UsersPresenceHandlerV1 \
    --namespace $TEST_NAMESPACE \
    --countOnly 'True' \
    --userIds 'kbiExqT6' \
    >$TEMP_FILE 2>&1
update_status $? 'UsersPresenceHandlerV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 FreeFormNotification
# body param: body
echo '{"message": "Dk9QFqaA", "topic": "jhwOI1P0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotification \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FreeFormNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 75 NotificationWithTemplate
# body param: body
echo '{"templateContext": {"4dMHfTwr": "xBRfMxZr"}, "templateLanguage": "Sfx3V8OX", "templateSlug": "kMng7p2S", "topic": "yFDEnmYQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplate \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'NotificationWithTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 76 GetGameTemplate
$CLI_EXE \
    --sn lobby \
    --op GetGameTemplate \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetGameTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 77 CreateTemplate
# body param: body
echo '{"templateContent": "zehPBqD1", "templateLanguage": "2DvvzNNZ", "templateSlug": "Su5zZVgY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTemplate \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 78 GetSlugTemplate
$CLI_EXE \
    --sn lobby \
    --op GetSlugTemplate \
    --namespace $TEST_NAMESPACE \
    --templateSlug '3Zosfd01' \
    --after 'vaOGweHa' \
    --before 'cvHRV345' \
    --limit '47' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSlugTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 79 DeleteTemplateSlug
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateSlug \
    --namespace $TEST_NAMESPACE \
    --templateSlug 'B8hos4ya' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTemplateSlug'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 80 GetLocalizationTemplate
$CLI_EXE \
    --sn lobby \
    --op GetLocalizationTemplate \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'OBjMxizC' \
    --templateSlug 'xx9qTOIK' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLocalizationTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 81 UpdateLocalizationTemplate
# body param: body
echo '{"templateContent": "lpdrqo2s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateLocalizationTemplate \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'mD9RPpjO' \
    --templateSlug 'WK0k76i1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateLocalizationTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 82 DeleteTemplateLocalization
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalization \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'g7rYaEuN' \
    --templateSlug 'CyPoQ0oH' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTemplateLocalization'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 83 PublishTemplate
$CLI_EXE \
    --sn lobby \
    --op PublishTemplate \
    --namespace $TEST_NAMESPACE \
    --templateLanguage 'YXUQdtIk' \
    --templateSlug 'Akltd1zQ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublishTemplate'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 84 GetTopicByNamespace
$CLI_EXE \
    --sn lobby \
    --op GetTopicByNamespace \
    --namespace $TEST_NAMESPACE \
    --after 'BzzC6ldK' \
    --before 'riI6lTRb' \
    --limit '5' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTopicByNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 85 CreateTopic
# body param: body
echo '{"description": "1Z1HJHzl", "topic": "323Ynwf5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTopic \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateTopic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 86 GetTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op GetTopicByTopicName \
    --namespace $TEST_NAMESPACE \
    --topic 'PvGejCDg' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTopicByTopicName'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 87 UpdateTopicByTopicName
# body param: body
echo '{"description": "Ar1pXDcs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTopicByTopicName \
    --namespace $TEST_NAMESPACE \
    --topic 'HnobnaYx' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateTopicByTopicName'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 88 DeleteTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op DeleteTopicByTopicName \
    --namespace $TEST_NAMESPACE \
    --topic 'Gh3FovBn' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTopicByTopicName'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 89 FreeFormNotificationByUserID
# body param: body
echo '{"message": "r5VUOHGq", "topic": "EcuJYo3Y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotificationByUserID \
    --namespace $TEST_NAMESPACE \
    --userId 'fMDw4PaB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FreeFormNotificationByUserID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 90 NotificationWithTemplateByUserID
# body param: body
echo '{"templateContext": {"KsFXorxY": "0ahG5AgH"}, "templateLanguage": "rE98qQTS", "templateSlug": "Xh1W7MnK", "topic": "2i8Ely25"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplateByUserID \
    --namespace $TEST_NAMESPACE \
    --userId '5awvulbN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'NotificationWithTemplateByUserID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT