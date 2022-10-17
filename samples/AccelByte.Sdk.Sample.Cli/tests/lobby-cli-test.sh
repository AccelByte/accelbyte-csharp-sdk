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
echo "1..92"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetUserFriendsUpdated
$CLI_EXE \
    --sn lobby \
    --op GetUserFriendsUpdated \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --offset '10' \
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
echo '{"friendId": "5ksB1Lyp", "friendPublicId": "PB6bSJJd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRequestFriend \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'UserRequestFriend' test.out

#- 6 UserAcceptFriendRequest
# body param: body
echo '{"friendId": "AbLOQOyV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserAcceptFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'UserAcceptFriendRequest' test.out

#- 7 UserCancelFriendRequest
# body param: body
echo '{"friendId": "cm53zcVP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserCancelFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UserCancelFriendRequest' test.out

#- 8 UserRejectFriendRequest
# body param: body
echo '{"friendId": "UzWjO2dB"}' > $TEMP_JSON_INPUT
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
    --friendId 'fcbgqDBH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'UserGetFriendshipStatus' test.out

#- 10 UserUnfriendRequest
# body param: body
echo '{"friendId": "bwRvFZ05"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserUnfriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'UserUnfriendRequest' test.out

#- 11 AddFriendsWithoutConfirmation
# body param: body
echo '{"friendIds": ["HrE30SzM", "reiDNnFD", "Py0GQ8Ky"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AddFriendsWithoutConfirmation \
    --namespace $AB_NAMESPACE \
    --userId 'JCcf6aYm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AddFriendsWithoutConfirmation' test.out

#- 12 PersonalChatHistory
$CLI_EXE \
    --sn lobby \
    --op PersonalChatHistory \
    --friendId 'xqglQVU9' \
    --namespace $AB_NAMESPACE \
    --userId 'ACjiSdcT' \
    > test.out 2>&1
eval_tap $? 12 'PersonalChatHistory' test.out

#- 13 AdminChatHistory
$CLI_EXE \
    --sn lobby \
    --op AdminChatHistory \
    --friendId 'WXMIfD9Z' \
    --namespace $AB_NAMESPACE \
    --userId 'DKVcauBa' \
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
echo '{"allowInviteNonConnectedUser": false, "allowJoinPartyDuringMatchmaking": false, "autoKickOnDisconnect": true, "autoKickOnDisconnectDelay": 52, "cancelTicketOnDisconnect": false, "chatRateLimitBurst": 57, "chatRateLimitDuration": 29, "concurrentUsersLimit": 72, "disableInvitationOnJoinParty": false, "enableChat": true, "entitlementCheck": false, "entitlementItemID": "YbQDTYl5", "generalRateLimitBurst": 37, "generalRateLimitDuration": 14, "keepPresenceActivityOnDisconnect": true, "maxDSWaitTime": 29, "maxPartyMember": 13, "profanityFilter": false, "readyConsentTimeout": 64}' > $TEMP_JSON_INPUT
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
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn lobby \
    --op AdminImportConfigV1 \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 18 'AdminImportConfigV1' test.out

#- 19 GetListOfFriends
$CLI_EXE \
    --sn lobby \
    --op GetListOfFriends \
    --namespace $AB_NAMESPACE \
    --userId 'SfMrXZPY' \
    --limit '46' \
    --offset '58' \
    > test.out 2>&1
eval_tap $? 19 'GetListOfFriends' test.out

#- 20 SendMultipleUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "GmGGeGn0", "topicName": "BSsVIAmr", "userIds": ["IftsswDm", "OIP2AR3P", "xryCBgJK"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendMultipleUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'SendMultipleUsersFreeformNotificationV1Admin' test.out

#- 21 SendUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "xaxfNOLj", "topicName": "fCfucQXH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'SendUsersFreeformNotificationV1Admin' test.out

#- 22 SendPartyFreeformNotificationV1Admin
# body param: body
echo '{"message": "8oglQHyA", "topicName": "tKPGwg1c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'YCJ9TSG6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'SendPartyFreeformNotificationV1Admin' test.out

#- 23 SendPartyTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"F4OCLUCi": "7ByFr0Hw", "zMdXmp8q": "yJ65pBoQ", "W5vV23fy": "FutMzYoE"}, "templateLanguage": "MD4O5sbt", "templateSlug": "IpKJo6xA", "topicName": "Eg2yLnTR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'bmcGpWlu' \
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
echo '{"templateContent": "u805naMk", "templateLanguage": "4gdoaRjF", "templateSlug": "oEQzvHAz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateNotificationTemplateV1Admin' test.out

#- 26 SendUsersTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"3bMkOqPG": "VkO9EuQa", "KwIhNZ5C": "HHoWeAXV", "0kr9cYXB": "BJA7G3QO"}, "templateLanguage": "QMiFibDs", "templateSlug": "9OMp3oVm", "topicName": "jwiDdsjQ"}' > $TEMP_JSON_INPUT
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
    --templateSlug '1PetmCSB' \
    --after 'VnDms23c' \
    --before 'qjlJm2MY' \
    --limit '14' \
    > test.out 2>&1
eval_tap $? 27 'GetTemplateSlugLocalizationsTemplateV1Admin' test.out

#- 28 DeleteNotificationTemplateSlugV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTemplateSlugV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'hmUGsQrh' \
    > test.out 2>&1
eval_tap $? 28 'DeleteNotificationTemplateSlugV1Admin' test.out

#- 29 GetSingleTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetSingleTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'xTQLglgY' \
    --templateSlug '5QLZbApE' \
    > test.out 2>&1
eval_tap $? 29 'GetSingleTemplateLocalizationV1Admin' test.out

#- 30 UpdateTemplateLocalizationV1Admin
# body param: body
echo '{"templateContent": "2g798hXD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'nfU8aV6y' \
    --templateSlug 'L51UxQZK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateTemplateLocalizationV1Admin' test.out

#- 31 DeleteTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'ohgAWXKE' \
    --templateSlug 'YilSwpNj' \
    > test.out 2>&1
eval_tap $? 31 'DeleteTemplateLocalizationV1Admin' test.out

#- 32 PublishTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op PublishTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage '4i12O77y' \
    --templateSlug 'OUsKKBdN' \
    > test.out 2>&1
eval_tap $? 32 'PublishTemplateLocalizationV1Admin' test.out

#- 33 GetAllNotificationTopicsV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTopicsV1Admin \
    --namespace $AB_NAMESPACE \
    --after 'IYg3EdKj' \
    --before '4mtWaUi2' \
    --limit '62' \
    > test.out 2>&1
eval_tap $? 33 'GetAllNotificationTopicsV1Admin' test.out

#- 34 CreateNotificationTopicV1Admin
# body param: body
echo '{"description": "HgA37aGI", "topicName": "mvrUgeYZ"}' > $TEMP_JSON_INPUT
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
    --topicName '5qhGRRez' \
    > test.out 2>&1
eval_tap $? 35 'GetNotificationTopicV1Admin' test.out

#- 36 UpdateNotificationTopicV1Admin
# body param: body
echo '{"description": "MiwebSUI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName '7mFIpv2X' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'UpdateNotificationTopicV1Admin' test.out

#- 37 DeleteNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'cszfcV7F' \
    > test.out 2>&1
eval_tap $? 37 'DeleteNotificationTopicV1Admin' test.out

#- 38 SendSpecificUserFreeformNotificationV1Admin
# body param: body
echo '{"message": "9X2Vt3Gl", "topicName": "za4kgliO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'Nc90M9Ij' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'SendSpecificUserFreeformNotificationV1Admin' test.out

#- 39 SendSpecificUserTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"Fi9olOF9": "rje8dmC0", "yxFFoZqu": "G4UnJq4a", "vJwfziu7": "jQKzEn9B"}, "templateLanguage": "LCTwy8Zk", "templateSlug": "DbgjShYi", "topicName": "V9kTQXfL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'xoSp43In' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'SendSpecificUserTemplatedNotificationV1Admin' test.out

#- 40 AdminGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId '2o9iKW7L' \
    > test.out 2>&1
eval_tap $? 40 'AdminGetPartyDataV1' test.out

#- 41 AdminUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"FkYnHYMO": {}, "A0RTrztf": {}, "r7EBkIRo": {}}, "updatedAt": 44}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'JzttAiyL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'AdminUpdatePartyAttributesV1' test.out

#- 42 AdminJoinPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminJoinPartyV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'y81vZWNQ' \
    --userId '0KEtbhu2' \
    > test.out 2>&1
eval_tap $? 42 'AdminJoinPartyV1' test.out

#- 43 AdminGetUserPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetUserPartyV1 \
    --namespace $AB_NAMESPACE \
    --userId 'rkZ6Lu9S' \
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
    --userId 'wveXOtCy' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetAllPlayerSessionAttribute' test.out

#- 46 AdminSetPlayerSessionAttribute
# body param: body
echo '{"attributes": {"waDR1Bhh": "yv5B84bo", "nrK1KN2x": "exvtVT4m", "4e5iVW8z": "f6rv0SBr"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'G535RdwV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminSetPlayerSessionAttribute' test.out

#- 47 AdminGetPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerSessionAttribute \
    --attribute 'k3y4IxRp' \
    --namespace $AB_NAMESPACE \
    --userId 'tkiMBH86' \
    > test.out 2>&1
eval_tap $? 47 'AdminGetPlayerSessionAttribute' test.out

#- 48 AdminGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'tec2E8jR' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetPlayerBlockedPlayersV1' test.out

#- 49 AdminGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'S3MyzEER' \
    > test.out 2>&1
eval_tap $? 49 'AdminGetPlayerBlockedByPlayersV1' test.out

#- 50 AdminBulkBlockPlayersV1
# body param: body
echo '{"listBlockedUserId": ["HGBbYUK3", "lBkGjUSq", "svBbZKUo"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminBulkBlockPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'urntgE7K' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminBulkBlockPlayersV1' test.out

#- 51 AdminDebugProfanityFilters
# body param: body
echo '{"text": "oA62nYzd"}' > $TEMP_JSON_INPUT
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
    --list 'P7quMhhK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'AdminGetProfanityListFiltersV1' test.out

#- 53 AdminAddProfanityFilterIntoList
# body param: body
echo '{"filter": "ziV757N6", "note": "EVheCEu1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilterIntoList \
    --list '5pAFe35B' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminAddProfanityFilterIntoList' test.out

#- 54 AdminAddProfanityFilters
# body param: body
echo '{"filters": [{"filter": "j8IEWekE", "note": "bx9MKvEl"}, {"filter": "DeJuLdRg", "note": "iyxmm1zH"}, {"filter": "ZE5trIIt", "note": "xackLdaE"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilters \
    --list '5zVuDNQ7' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AdminAddProfanityFilters' test.out

#- 55 AdminImportProfanityFiltersFromFile
# body param: body
echo '[41, 34, 5]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminImportProfanityFiltersFromFile \
    --list '4Qb0o9Sv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'AdminImportProfanityFiltersFromFile' test.out

#- 56 AdminDeleteProfanityFilter
# body param: body
echo '{"filter": "sqowJE7E"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityFilter \
    --list 'sQTPAQiV' \
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
echo '{"isEnabled": false, "isMandatory": true, "name": "svyPtSoK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateProfanityList \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'AdminCreateProfanityList' test.out

#- 59 AdminUpdateProfanityList
# body param: body
echo '{"isEnabled": true, "isMandatory": true, "newName": "RymueXG3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateProfanityList \
    --list '2Pi6nI87' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'AdminUpdateProfanityList' test.out

#- 60 AdminDeleteProfanityList
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityList \
    --list 'mpBOOO3c' \
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
echo '{"rule": "iItrI4oH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetProfanityRuleForNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'AdminSetProfanityRuleForNamespace' test.out

#- 63 AdminVerifyMessageProfanityResponse
# body param: body
echo '{"message": "MwXaLXAR", "profanityLevel": "oEubfD3w"}' > $TEMP_JSON_INPUT
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
echo '{"apiKey": "19pQDfkA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'AdminUpdateThirdPartyConfig' test.out

#- 66 AdminCreateThirdPartyConfig
# body param: body
echo '{"apiKey": "EBYVfy0L"}' > $TEMP_JSON_INPUT
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
    --friendId 'dMZOdiBC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'GetPersonalChatHistoryV1Public' test.out

#- 70 PublicGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'RQJ7VOYG' \
    > test.out 2>&1
eval_tap $? 70 'PublicGetPartyDataV1' test.out

#- 71 PublicUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"oKsjJEVp": {}, "vjk95I3L": {}, "JMTc9o6t": {}}, "updatedAt": 58}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId '1p1awt6e' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicUpdatePartyAttributesV1' test.out

#- 72 PublicSetPartyLimitV1
# body param: body
echo '{"limit": 79}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicSetPartyLimitV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'w2J4Q12U' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicSetPartyLimitV1' test.out

#- 73 PublicGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'PublicGetPlayerBlockedPlayersV1' test.out

#- 74 PublicGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 74 'PublicGetPlayerBlockedByPlayersV1' test.out

#- 75 UsersPresenceHandlerV1
$CLI_EXE \
    --sn lobby \
    --op UsersPresenceHandlerV1 \
    --namespace $AB_NAMESPACE \
    --countOnly 'false' \
    --userIds 'kCjS2xel' \
    > test.out 2>&1
eval_tap $? 75 'UsersPresenceHandlerV1' test.out

#- 76 FreeFormNotification
# body param: body
echo '{"message": "Ug97cK0s", "topic": "I3CRy2M3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotification \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'FreeFormNotification' test.out

#- 77 NotificationWithTemplate
# body param: body
echo '{"templateContext": {"TqUJOxIr": "FDzb9d2l", "xZajDqEG": "qoWMVkeb", "G6zqpEqt": "Nrqh5JO5"}, "templateLanguage": "Fwegalbg", "templateSlug": "7wNpW2Zq", "topic": "eem1QqGI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'NotificationWithTemplate' test.out

#- 78 GetGameTemplate
$CLI_EXE \
    --sn lobby \
    --op GetGameTemplate \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 78 'GetGameTemplate' test.out

#- 79 CreateTemplate
# body param: body
echo '{"templateContent": "hXOMVmjH", "templateLanguage": "pLmqUgCf", "templateSlug": "96E5kwTf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'CreateTemplate' test.out

#- 80 GetSlugTemplate
$CLI_EXE \
    --sn lobby \
    --op GetSlugTemplate \
    --namespace $AB_NAMESPACE \
    --templateSlug 'H614jV1q' \
    --after '8Iqh5fTl' \
    --before 'mzvqKW6t' \
    --limit '98' \
    > test.out 2>&1
eval_tap $? 80 'GetSlugTemplate' test.out

#- 81 DeleteTemplateSlug
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateSlug \
    --namespace $AB_NAMESPACE \
    --templateSlug '8vnItEks' \
    > test.out 2>&1
eval_tap $? 81 'DeleteTemplateSlug' test.out

#- 82 GetLocalizationTemplate
$CLI_EXE \
    --sn lobby \
    --op GetLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'xH5yxUDg' \
    --templateSlug '0pv7xJkX' \
    > test.out 2>&1
eval_tap $? 82 'GetLocalizationTemplate' test.out

#- 83 UpdateLocalizationTemplate
# body param: body
echo '{"templateContent": "Q1D1DGXD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'V3rMAl2j' \
    --templateSlug '3EK4d86q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'UpdateLocalizationTemplate' test.out

#- 84 DeleteTemplateLocalization
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalization \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'MR25GK0J' \
    --templateSlug 'eoSEYymS' \
    > test.out 2>&1
eval_tap $? 84 'DeleteTemplateLocalization' test.out

#- 85 PublishTemplate
$CLI_EXE \
    --sn lobby \
    --op PublishTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'hR0kPvIg' \
    --templateSlug 'TZ7mcjae' \
    > test.out 2>&1
eval_tap $? 85 'PublishTemplate' test.out

#- 86 GetTopicByNamespace
$CLI_EXE \
    --sn lobby \
    --op GetTopicByNamespace \
    --namespace $AB_NAMESPACE \
    --after 'p9XhizZe' \
    --before 'yMmA2oel' \
    --limit '38' \
    > test.out 2>&1
eval_tap $? 86 'GetTopicByNamespace' test.out

#- 87 CreateTopic
# body param: body
echo '{"description": "WOgEdDeH", "topic": "PbVH9bzI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'CreateTopic' test.out

#- 88 GetTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op GetTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'FX2UMlUb' \
    > test.out 2>&1
eval_tap $? 88 'GetTopicByTopicName' test.out

#- 89 UpdateTopicByTopicName
# body param: body
echo '{"description": "j7E1Kn9i"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'chbDaYGM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'UpdateTopicByTopicName' test.out

#- 90 DeleteTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op DeleteTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'blNctmpF' \
    > test.out 2>&1
eval_tap $? 90 'DeleteTopicByTopicName' test.out

#- 91 FreeFormNotificationByUserID
# body param: body
echo '{"message": "wAU2V0DC", "topic": "zaONkjOj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotificationByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'Fsqgw0zL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'FreeFormNotificationByUserID' test.out

#- 92 NotificationWithTemplateByUserID
# body param: body
echo '{"templateContext": {"99P8om0B": "RWdEYJzY", "rXQsRuQT": "8NiWkddF", "DLTaOUCr": "bL7cxYFI"}, "templateLanguage": "kbYB6YWN", "templateSlug": "pZAI6jXv", "topic": "Zl5SohnK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplateByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'SpJCK1oh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'NotificationWithTemplateByUserID' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE