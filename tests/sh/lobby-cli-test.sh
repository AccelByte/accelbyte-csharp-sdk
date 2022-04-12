#!/usr/bin/env bash

# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

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
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"

echo "TAP version 13"
echo "1..91"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetUserFriendsUpdated
$CLI_EXE \
    --sn lobby \
    --op GetUserFriendsUpdated \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 2 'GetUserFriendsUpdated' test.out

#- 3 GetUserIncomingFriends
$CLI_EXE \
    --sn lobby \
    --op GetUserIncomingFriends \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 3 'GetUserIncomingFriends' test.out

#- 4 GetUserOutgoingFriends
$CLI_EXE \
    --sn lobby \
    --op GetUserOutgoingFriends \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'GetUserOutgoingFriends' test.out

#- 5 UserRequestFriend
# body param: body
echo '{"friendId": "jv4Ax7Nz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRequestFriend \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'UserRequestFriend' test.out

#- 6 UserAcceptFriendRequest
# body param: body
echo '{"friendId": "Ykoppa0V"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserAcceptFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'UserAcceptFriendRequest' test.out

#- 7 UserCancelFriendRequest
# body param: body
echo '{"friendId": "gFJAhHwT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserCancelFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UserCancelFriendRequest' test.out

#- 8 UserRejectFriendRequest
# body param: body
echo '{"friendId": "b5q010gN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRejectFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UserRejectFriendRequest' test.out

#- 9 UserGetFriendshipStatus
$CLI_EXE \
    --sn lobby \
    --op UserGetFriendshipStatus \
    --friendId '2MQrbpeR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'UserGetFriendshipStatus' test.out

#- 10 UserUnfriendRequest
# body param: body
echo '{"friendId": "nxTlCTFS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserUnfriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'UserUnfriendRequest' test.out

#- 11 AddFriendsWithoutConfirmation
# body param: body
echo '{"friendIds": ["MIbl1a2j"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AddFriendsWithoutConfirmation \
    --namespace $AB_NAMESPACE \
    --userId 'XLCtWmHJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AddFriendsWithoutConfirmation' test.out

#- 12 PersonalChatHistory
$CLI_EXE \
    --sn lobby \
    --op PersonalChatHistory \
    --friendId 'Bi9SoMkS' \
    --namespace $AB_NAMESPACE \
    --userId 'E4eJelwO' \
    > test.out 2>&1
eval_tap $? 12 'PersonalChatHistory' test.out

#- 13 AdminChatHistory
$CLI_EXE \
    --sn lobby \
    --op AdminChatHistory \
    --friendId '4KPMky2h' \
    --namespace $AB_NAMESPACE \
    --userId '8R2fIXoX' \
    > test.out 2>&1
eval_tap $? 13 'AdminChatHistory' test.out

#- 14 AdminGetAllConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 14 'AdminGetAllConfigV1' test.out

#- 15 AdminGetConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminGetConfigV1' test.out

#- 16 AdminUpdateConfigV1
# body param: body
echo '{"allowInviteNonConnectedUser": false, "allowJoinPartyDuringMatchmaking": false, "autoKickOnDisconnect": false, "autoKickOnDisconnectDelay": 3, "cancelTicketOnDisconnect": false, "chatRateLimitBurst": 65, "chatRateLimitDuration": 77, "concurrentUsersLimit": 2, "disableInvitationOnJoinParty": true, "enableChat": false, "entitlementCheck": false, "entitlementItemID": "1fsu6J3C", "generalRateLimitBurst": 36, "generalRateLimitDuration": 30, "keepPresenceActivityOnDisconnect": false, "maxPartyMember": 64, "profanityFilter": false, "readyConsentTimeout": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminUpdateConfigV1' test.out

#- 17 AdminExportConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminExportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'AdminExportConfigV1' test.out

#- 18 AdminImportConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminImportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminImportConfigV1' test.out

#- 19 GetListOfFriends
$CLI_EXE \
    --sn lobby \
    --op GetListOfFriends \
    --namespace $AB_NAMESPACE \
    --userId 'xYTGgewr' \
    --limit '75' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 19 'GetListOfFriends' test.out

#- 20 SendMultipleUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "wvzJF4Tp", "topicName": "bNhKq2xd", "userIds": ["mgEBepFH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendMultipleUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'SendMultipleUsersFreeformNotificationV1Admin' test.out

#- 21 SendUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "tf6Ziegq", "topicName": "dEL4fsM6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'SendUsersFreeformNotificationV1Admin' test.out

#- 22 SendPartyFreeformNotificationV1Admin
# body param: body
echo '{"message": "nBzRVuC1", "topicName": "r7UH1Liu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId '7UQ0304M' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'SendPartyFreeformNotificationV1Admin' test.out

#- 23 SendPartyTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"cK873tRt": "r5cfWO5J"}, "templateLanguage": "J2c6vsOn", "templateSlug": "s4jNWGc7", "topicName": "CiUa4wM5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'Eu3Vqyms' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'SendPartyTemplatedNotificationV1Admin' test.out

#- 24 GetAllNotificationTemplatesV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTemplatesV1Admin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetAllNotificationTemplatesV1Admin' test.out

#- 25 CreateNotificationTemplateV1Admin
# body param: body
echo '{"templateContent": "FXporMqE", "templateLanguage": "DR8E72XM", "templateSlug": "Kfhl6eq2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateNotificationTemplateV1Admin' test.out

#- 26 SendUsersTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"FzU3VL3L": "NmPLeZdo"}, "templateLanguage": "CXfabFXz", "templateSlug": "vjLmai7f", "topicName": "PKvE2Z4a"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'SendUsersTemplatedNotificationV1Admin' test.out

#- 27 GetTemplateSlugLocalizationsTemplateV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetTemplateSlugLocalizationsTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug '63UVtLbQ' \
    --after 'SWtsyz0m' \
    --before 'GGyHHFIl' \
    --limit '68' \
    > test.out 2>&1
eval_tap $? 27 'GetTemplateSlugLocalizationsTemplateV1Admin' test.out

#- 28 DeleteNotificationTemplateSlugV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTemplateSlugV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'KsXgvSrk' \
    > test.out 2>&1
eval_tap $? 28 'DeleteNotificationTemplateSlugV1Admin' test.out

#- 29 GetSingleTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetSingleTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'EgTYVk5i' \
    --templateSlug 'RBE6zJJ1' \
    > test.out 2>&1
eval_tap $? 29 'GetSingleTemplateLocalizationV1Admin' test.out

#- 30 UpdateTemplateLocalizationV1Admin
# body param: body
echo '{"templateContent": "BRHrfCHq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'qp2GwPcm' \
    --templateSlug 'zSuY8w9V' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateTemplateLocalizationV1Admin' test.out

#- 31 DeleteTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'YwBEfRXo' \
    --templateSlug 'ZLfpVFfD' \
    > test.out 2>&1
eval_tap $? 31 'DeleteTemplateLocalizationV1Admin' test.out

#- 32 PublishTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op PublishTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'wjHHCW2g' \
    --templateSlug '5u8z9yrp' \
    > test.out 2>&1
eval_tap $? 32 'PublishTemplateLocalizationV1Admin' test.out

#- 33 GetAllNotificationTopicsV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTopicsV1Admin \
    --namespace $AB_NAMESPACE \
    --after 'JdIx5vvH' \
    --before 'S3d6PKPE' \
    --limit '24' \
    > test.out 2>&1
eval_tap $? 33 'GetAllNotificationTopicsV1Admin' test.out

#- 34 CreateNotificationTopicV1Admin
# body param: body
echo '{"description": "I6Px8jt8", "topicName": "Lq4x0F7N"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'CreateNotificationTopicV1Admin' test.out

#- 35 GetNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'cocelJjt' \
    > test.out 2>&1
eval_tap $? 35 'GetNotificationTopicV1Admin' test.out

#- 36 UpdateNotificationTopicV1Admin
# body param: body
echo '{"description": "lKYu8iCP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'znx0s5Tz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'UpdateNotificationTopicV1Admin' test.out

#- 37 DeleteNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'T51oV4HT' \
    > test.out 2>&1
eval_tap $? 37 'DeleteNotificationTopicV1Admin' test.out

#- 38 SendSpecificUserFreeformNotificationV1Admin
# body param: body
echo '{"message": "mivmb6tP", "topicName": "mCirkhYv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'cOUucjPW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'SendSpecificUserFreeformNotificationV1Admin' test.out

#- 39 SendSpecificUserTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"GwPsvjLK": "1CjPt93u"}, "templateLanguage": "tbMkpUFH", "templateSlug": "T0fL9q9S", "topicName": "MNAUQVoi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'QtSQC2kN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'SendSpecificUserTemplatedNotificationV1Admin' test.out

#- 40 AdminGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'SsmT0d2a' \
    > test.out 2>&1
eval_tap $? 40 'AdminGetPartyDataV1' test.out

#- 41 AdminUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"BG4zA2zp": {}}, "updatedAt": 74}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 's0bD6dGg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'AdminUpdatePartyAttributesV1' test.out

#- 42 AdminJoinPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminJoinPartyV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'wkYgHzKu' \
    --userId 'I2RJrboP' \
    > test.out 2>&1
eval_tap $? 42 'AdminJoinPartyV1' test.out

#- 43 AdminGetUserPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetUserPartyV1 \
    --namespace $AB_NAMESPACE \
    --userId '7kfpIlet' \
    > test.out 2>&1
eval_tap $? 43 'AdminGetUserPartyV1' test.out

#- 44 AdminGetLobbyCCU
$CLI_EXE \
    --sn lobby \
    --op AdminGetLobbyCCU \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'AdminGetLobbyCCU' test.out

#- 45 AdminGetAllPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'XrCK1UVO' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetAllPlayerSessionAttribute' test.out

#- 46 AdminSetPlayerSessionAttribute
# body param: body
echo '{"attributes": {"0jcs7nCq": "sodoTFTc"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'WlaIBJAA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminSetPlayerSessionAttribute' test.out

#- 47 AdminGetPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerSessionAttribute \
    --attribute 'knU6HobZ' \
    --namespace $AB_NAMESPACE \
    --userId 'gWlaLned' \
    > test.out 2>&1
eval_tap $? 47 'AdminGetPlayerSessionAttribute' test.out

#- 48 AdminGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'DfasTc8g' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetPlayerBlockedPlayersV1' test.out

#- 49 AdminGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'r2znWqD6' \
    > test.out 2>&1
eval_tap $? 49 'AdminGetPlayerBlockedByPlayersV1' test.out

#- 50 AdminBulkBlockPlayersV1
# body param: body
echo '{"listBlockedUserId": ["tIcfI5Z4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminBulkBlockPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'tUNQ7mQP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminBulkBlockPlayersV1' test.out

#- 51 AdminDebugProfanityFilters
# body param: body
echo '{"text": "jCalZgFV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDebugProfanityFilters \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'AdminDebugProfanityFilters' test.out

#- 52 AdminGetProfanityListFiltersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityListFiltersV1 \
    --list 'EQyqav09' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'AdminGetProfanityListFiltersV1' test.out

#- 53 AdminAddProfanityFilterIntoList
# body param: body
echo '{"filter": "OYmxCvMq", "note": "VcXs2OqN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilterIntoList \
    --list 'z8ZLBsnc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminAddProfanityFilterIntoList' test.out

#- 54 AdminAddProfanityFilters
# body param: body
echo '{"filters": [{"filter": "bRrf6uEd", "note": "jUnr04WZ"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilters \
    --list 'NhgEGvqK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AdminAddProfanityFilters' test.out

#- 55 AdminImportProfanityFiltersFromFile
# body param: body
echo '[96]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminImportProfanityFiltersFromFile \
    --list 'QTkE65j6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'AdminImportProfanityFiltersFromFile' test.out

#- 56 AdminDeleteProfanityFilter
# body param: body
echo '{"filter": "186p0Wfs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityFilter \
    --list 'nWZuUPsa' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'AdminDeleteProfanityFilter' test.out

#- 57 AdminGetProfanityLists
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityLists \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'AdminGetProfanityLists' test.out

#- 58 AdminCreateProfanityList
# body param: body
echo '{"isEnabled": false, "isMandatory": false, "name": "rdBA2hXw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateProfanityList \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'AdminCreateProfanityList' test.out

#- 59 AdminUpdateProfanityList
# body param: body
echo '{"isEnabled": true, "isMandatory": true, "newName": "ZMdlR4cL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateProfanityList \
    --list '76hnFDgT' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'AdminUpdateProfanityList' test.out

#- 60 AdminDeleteProfanityList
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityList \
    --list 'fofHdfoS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'AdminDeleteProfanityList' test.out

#- 61 AdminGetProfanityRule
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityRule \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'AdminGetProfanityRule' test.out

#- 62 AdminSetProfanityRuleForNamespace
# body param: body
echo '{"rule": "qDcaFhOc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetProfanityRuleForNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'AdminSetProfanityRuleForNamespace' test.out

#- 63 AdminVerifyMessageProfanityResponse
# body param: body
echo '{"message": "1oKxI8f5", "profanityLevel": "ocfy4EIx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminVerifyMessageProfanityResponse \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'AdminVerifyMessageProfanityResponse' test.out

#- 64 AdminGetThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'AdminGetThirdPartyConfig' test.out

#- 65 AdminUpdateThirdPartyConfig
# body param: body
echo '{"apiKey": "wBiB90vd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'AdminUpdateThirdPartyConfig' test.out

#- 66 AdminCreateThirdPartyConfig
# body param: body
echo '{"apiKey": "gS5YpKsd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'AdminCreateThirdPartyConfig' test.out

#- 67 AdminDeleteThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'AdminDeleteThirdPartyConfig' test.out

#- 68 PublicGetMessages
$CLI_EXE \
    --sn lobby \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 68 'PublicGetMessages' test.out

#- 69 GetPersonalChatHistoryV1Public
$CLI_EXE \
    --sn lobby \
    --op GetPersonalChatHistoryV1Public \
    --friendId 'bpiU2Ufy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'GetPersonalChatHistoryV1Public' test.out

#- 70 PublicGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'MO4DhL9f' \
    > test.out 2>&1
eval_tap $? 70 'PublicGetPartyDataV1' test.out

#- 71 PublicUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"BKJvjBOU": {}}, "updatedAt": 26}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId '3bYf5ouX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicUpdatePartyAttributesV1' test.out

#- 72 PublicGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 72 'PublicGetPlayerBlockedPlayersV1' test.out

#- 73 PublicGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'PublicGetPlayerBlockedByPlayersV1' test.out

#- 74 UsersPresenceHandlerV1
$CLI_EXE \
    --sn lobby \
    --op UsersPresenceHandlerV1 \
    --namespace $AB_NAMESPACE \
    --countOnly 'True' \
    --userIds 'kbiExqT6' \
    > test.out 2>&1
eval_tap $? 74 'UsersPresenceHandlerV1' test.out

#- 75 FreeFormNotification
# body param: body
echo '{"message": "Dk9QFqaA", "topic": "jhwOI1P0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotification \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'FreeFormNotification' test.out

#- 76 NotificationWithTemplate
# body param: body
echo '{"templateContext": {"4dMHfTwr": "xBRfMxZr"}, "templateLanguage": "Sfx3V8OX", "templateSlug": "kMng7p2S", "topic": "yFDEnmYQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'NotificationWithTemplate' test.out

#- 77 GetGameTemplate
$CLI_EXE \
    --sn lobby \
    --op GetGameTemplate \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 77 'GetGameTemplate' test.out

#- 78 CreateTemplate
# body param: body
echo '{"templateContent": "zehPBqD1", "templateLanguage": "2DvvzNNZ", "templateSlug": "Su5zZVgY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'CreateTemplate' test.out

#- 79 GetSlugTemplate
$CLI_EXE \
    --sn lobby \
    --op GetSlugTemplate \
    --namespace $AB_NAMESPACE \
    --templateSlug '3Zosfd01' \
    --after 'vaOGweHa' \
    --before 'cvHRV345' \
    --limit '47' \
    > test.out 2>&1
eval_tap $? 79 'GetSlugTemplate' test.out

#- 80 DeleteTemplateSlug
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateSlug \
    --namespace $AB_NAMESPACE \
    --templateSlug 'B8hos4ya' \
    > test.out 2>&1
eval_tap $? 80 'DeleteTemplateSlug' test.out

#- 81 GetLocalizationTemplate
$CLI_EXE \
    --sn lobby \
    --op GetLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'OBjMxizC' \
    --templateSlug 'xx9qTOIK' \
    > test.out 2>&1
eval_tap $? 81 'GetLocalizationTemplate' test.out

#- 82 UpdateLocalizationTemplate
# body param: body
echo '{"templateContent": "lpdrqo2s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'mD9RPpjO' \
    --templateSlug 'WK0k76i1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'UpdateLocalizationTemplate' test.out

#- 83 DeleteTemplateLocalization
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalization \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'g7rYaEuN' \
    --templateSlug 'CyPoQ0oH' \
    > test.out 2>&1
eval_tap $? 83 'DeleteTemplateLocalization' test.out

#- 84 PublishTemplate
$CLI_EXE \
    --sn lobby \
    --op PublishTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'YXUQdtIk' \
    --templateSlug 'Akltd1zQ' \
    > test.out 2>&1
eval_tap $? 84 'PublishTemplate' test.out

#- 85 GetTopicByNamespace
$CLI_EXE \
    --sn lobby \
    --op GetTopicByNamespace \
    --namespace $AB_NAMESPACE \
    --after 'BzzC6ldK' \
    --before 'riI6lTRb' \
    --limit '5' \
    > test.out 2>&1
eval_tap $? 85 'GetTopicByNamespace' test.out

#- 86 CreateTopic
# body param: body
echo '{"description": "1Z1HJHzl", "topic": "323Ynwf5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'CreateTopic' test.out

#- 87 GetTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op GetTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'PvGejCDg' \
    > test.out 2>&1
eval_tap $? 87 'GetTopicByTopicName' test.out

#- 88 UpdateTopicByTopicName
# body param: body
echo '{"description": "Ar1pXDcs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'HnobnaYx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'UpdateTopicByTopicName' test.out

#- 89 DeleteTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op DeleteTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'Gh3FovBn' \
    > test.out 2>&1
eval_tap $? 89 'DeleteTopicByTopicName' test.out

#- 90 FreeFormNotificationByUserID
# body param: body
echo '{"message": "r5VUOHGq", "topic": "EcuJYo3Y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotificationByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'fMDw4PaB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 90 'FreeFormNotificationByUserID' test.out

#- 91 NotificationWithTemplateByUserID
# body param: body
echo '{"templateContext": {"KsFXorxY": "0ahG5AgH"}, "templateLanguage": "rE98qQTS", "templateSlug": "Xh1W7MnK", "topic": "2i8Ely25"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplateByUserID \
    --namespace $AB_NAMESPACE \
    --userId '5awvulbN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'NotificationWithTemplateByUserID' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE