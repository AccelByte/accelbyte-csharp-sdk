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
echo "1..97"

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
    --limit '2' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 2 'GetUserFriendsUpdated' test.out

#- 3 GetUserIncomingFriends
$CLI_EXE \
    --sn lobby \
    --op GetUserIncomingFriends \
    --namespace $AB_NAMESPACE \
    --limit '18' \
    --offset '42' \
    > test.out 2>&1
eval_tap $? 3 'GetUserIncomingFriends' test.out

#- 4 GetUserIncomingFriendsWithTime
$CLI_EXE \
    --sn lobby \
    --op GetUserIncomingFriendsWithTime \
    --namespace $AB_NAMESPACE \
    --limit '52' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 4 'GetUserIncomingFriendsWithTime' test.out

#- 5 GetUserOutgoingFriends
$CLI_EXE \
    --sn lobby \
    --op GetUserOutgoingFriends \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 5 'GetUserOutgoingFriends' test.out

#- 6 GetUserOutgoingFriendsWithTime
$CLI_EXE \
    --sn lobby \
    --op GetUserOutgoingFriendsWithTime \
    --namespace $AB_NAMESPACE \
    --limit '100' \
    --offset '21' \
    > test.out 2>&1
eval_tap $? 6 'GetUserOutgoingFriendsWithTime' test.out

#- 7 GetUserFriendsWithPlatform
$CLI_EXE \
    --sn lobby \
    --op GetUserFriendsWithPlatform \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '30' \
    > test.out 2>&1
eval_tap $? 7 'GetUserFriendsWithPlatform' test.out

#- 8 UserRequestFriend
# body param: body
echo '{"friendId": "oZgIhwb8YYMLqpQw", "friendPublicId": "kRRHkaiKsmIiRLR3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRequestFriend \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UserRequestFriend' test.out

#- 9 UserAcceptFriendRequest
# body param: body
echo '{"friendId": "IlNJKxhPfWV6dIab"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserAcceptFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UserAcceptFriendRequest' test.out

#- 10 UserCancelFriendRequest
# body param: body
echo '{"friendId": "cFbSmeuIBroF7bwR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserCancelFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'UserCancelFriendRequest' test.out

#- 11 UserRejectFriendRequest
# body param: body
echo '{"friendId": "gwKvzESbhpxlDdEs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserRejectFriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UserRejectFriendRequest' test.out

#- 12 UserGetFriendshipStatus
$CLI_EXE \
    --sn lobby \
    --op UserGetFriendshipStatus \
    --friendId '4igdKeLmy8tZ5GZi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'UserGetFriendshipStatus' test.out

#- 13 UserUnfriendRequest
# body param: body
echo '{"friendId": "5P12c61ts3fMI04r"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UserUnfriendRequest \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UserUnfriendRequest' test.out

#- 14 AddFriendsWithoutConfirmation
# body param: body
echo '{"friendIds": ["m2jUc9iav3tTqlE9", "oLDPD0Lfle8ESU1M", "O8XnVaEyjmifJDYa"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AddFriendsWithoutConfirmation \
    --namespace $AB_NAMESPACE \
    --userId '1TJPUszmFGEkJVvq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AddFriendsWithoutConfirmation' test.out

#- 15 BulkDeleteFriends
# body param: body
echo '{"friendIds": ["DSU3PDyIAGfGq1FN", "mRWvUvDPnKoECjGU", "g867xodwuG14ID5l"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op BulkDeleteFriends \
    --namespace $AB_NAMESPACE \
    --userId '5wj6K2wEMnckjlW6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'BulkDeleteFriends' test.out

#- 16 SyncNativeFriends
# body param: body
echo '[{"isLogin": true, "platformId": "NmY3y3n2Rim4NBqh", "platformToken": "uNtj8FOvKZjs1tLp", "psnEnv": "ERf77LzPoORBkRmZ"}, {"isLogin": false, "platformId": "A2zyZsb4FvWFIHPI", "platformToken": "bOjpls9BZTYc5Bsd", "psnEnv": "SSVaAzzn4GbgkKeC"}, {"isLogin": false, "platformId": "rcf1nq4Hf32SL5Pj", "platformToken": "aYEDxaYN8w9KUW0p", "psnEnv": "y8KrcQfucSq2X8gF"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SyncNativeFriends \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'SyncNativeFriends' test.out

#- 17 AdminGetAllConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 17 'AdminGetAllConfigV1' test.out

#- 18 AdminGetConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminGetConfigV1' test.out

#- 19 AdminUpdateConfigV1
# body param: body
echo '{"allowInviteNonConnectedUser": true, "allowJoinPartyDuringMatchmaking": true, "autoKickOnDisconnect": false, "autoKickOnDisconnectDelay": 60, "cancelTicketOnDisconnect": false, "chatRateLimitBurst": 31, "chatRateLimitDuration": 97, "concurrentUsersLimit": 11, "disableInvitationOnJoinParty": true, "enableChat": false, "entitlementCheck": true, "entitlementItemID": "TsQUrA0WWyKl2K5m", "generalRateLimitBurst": 59, "generalRateLimitDuration": 12, "keepPresenceActivityOnDisconnect": false, "maxDSWaitTime": 29, "maxFriendsLimit": 10, "maxPartyMember": 66, "profanityFilter": false, "readyConsentTimeout": 10, "unregisterDelay": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateConfigV1' test.out

#- 20 AdminExportConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminExportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminExportConfigV1' test.out

#- 21 AdminImportConfigV1
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn lobby \
    --op AdminImportConfigV1 \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'AdminImportConfigV1' test.out

#- 22 GetListOfFriends
$CLI_EXE \
    --sn lobby \
    --op GetListOfFriends \
    --namespace $AB_NAMESPACE \
    --userId 'QCahcox63cyDxAAY' \
    --friendId 'cRXJdoSTxNCK9AIj' \
    --limit '81' \
    --offset '92' \
    > test.out 2>&1
eval_tap $? 22 'GetListOfFriends' test.out

#- 23 GetIncomingFriendRequests
$CLI_EXE \
    --sn lobby \
    --op GetIncomingFriendRequests \
    --namespace $AB_NAMESPACE \
    --userId 'mbfoW8bDq5jPqzhN' \
    --friendId '0YdGSrA9LXRwU6WL' \
    --limit '12' \
    --offset '31' \
    > test.out 2>&1
eval_tap $? 23 'GetIncomingFriendRequests' test.out

#- 24 GetOutgoingFriendRequests
$CLI_EXE \
    --sn lobby \
    --op GetOutgoingFriendRequests \
    --namespace $AB_NAMESPACE \
    --userId '0xCDlPeNq0CvMXty' \
    --limit '95' \
    --offset '12' \
    > test.out 2>&1
eval_tap $? 24 'GetOutgoingFriendRequests' test.out

#- 25 SendMultipleUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "WXrdZaFeacGT2x6o", "topicName": "28Njxyw7RHldq0m7", "userIds": ["NjUZ95Z5XDLBN9YG", "VPtkjt0OyBlJi4Rb", "Z0Iy11mfOFjCzZVc"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendMultipleUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'SendMultipleUsersFreeformNotificationV1Admin' test.out

#- 26 SendUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "GomWF1oAqUNFDtXn", "topicName": "XLvOAsW8wYh4gq7p"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'SendUsersFreeformNotificationV1Admin' test.out

#- 27 SendPartyFreeformNotificationV1Admin
# body param: body
echo '{"message": "RVZVLJiDx3au9b9Q", "topicName": "jhzDlnJmi4XaBTgo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'XjfdUQHa3RxspSqw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'SendPartyFreeformNotificationV1Admin' test.out

#- 28 SendPartyTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"dbTR2sgzfaQrUCW9": "fgo69uv1bkFx8Dmb", "C9UqYdYrdxNnuMcA": "wrSzYnrcetxObeis", "ZelKuD0iJ6fs3zL9": "H4WxGWRH7fz4BdPh"}, "templateLanguage": "LtHRJOImSq37aeAa", "templateSlug": "Gq0NIj53gXkmrayv", "topicName": "cIYiWxIAxfvLzSpD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'FY3lxe16KsSRzkf2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'SendPartyTemplatedNotificationV1Admin' test.out

#- 29 GetAllNotificationTemplatesV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTemplatesV1Admin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'GetAllNotificationTemplatesV1Admin' test.out

#- 30 CreateNotificationTemplateV1Admin
# body param: body
echo '{"templateContent": "HzBcEio5UyvuFv5z", "templateLanguage": "6wosJGnUyCMEbHh1", "templateSlug": "uE4DmJ4Suj6DjUw3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'CreateNotificationTemplateV1Admin' test.out

#- 31 SendUsersTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"6GtZ83Jp2f9f1FCo": "Io3L24DKGwgZ85vy", "FJR8euQBLVu27iwp": "lLJdzYS9K0VvwE6M", "AqPc8lGIYWTwxyqQ": "QIXVmrtRlq1jv60H"}, "templateLanguage": "TnmFrl3gYx6Xmv1D", "templateSlug": "zPHux3k3skhn3mWZ", "topicName": "jTYM95e4aa8xOJu7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'SendUsersTemplatedNotificationV1Admin' test.out

#- 32 GetTemplateSlugLocalizationsTemplateV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetTemplateSlugLocalizationsTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'rNRVdygfKmUkzj9m' \
    --after 'HFpff2vDkz68zorE' \
    --before 'gcExv9nKMOgO5W8S' \
    --limit '96' \
    > test.out 2>&1
eval_tap $? 32 'GetTemplateSlugLocalizationsTemplateV1Admin' test.out

#- 33 DeleteNotificationTemplateSlugV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTemplateSlugV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'Ipfgxw2ff5twRYbt' \
    > test.out 2>&1
eval_tap $? 33 'DeleteNotificationTemplateSlugV1Admin' test.out

#- 34 GetSingleTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetSingleTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'dK2r4wWs6IpYBxaf' \
    --templateSlug 'o9b4xJyNnvHKrm8U' \
    > test.out 2>&1
eval_tap $? 34 'GetSingleTemplateLocalizationV1Admin' test.out

#- 35 UpdateTemplateLocalizationV1Admin
# body param: body
echo '{"templateContent": "uNlT86N9yO0vyD6J"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage '5brVo20e6POTjrin' \
    --templateSlug 'AVVovpAAXNzcpbmX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdateTemplateLocalizationV1Admin' test.out

#- 36 DeleteTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage '3lLFeXCiaXP8jBjK' \
    --templateSlug '81t2V9TVauFcGkPg' \
    > test.out 2>&1
eval_tap $? 36 'DeleteTemplateLocalizationV1Admin' test.out

#- 37 PublishTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op PublishTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'Q0hb2tLrsMeoZiRY' \
    --templateSlug 'kbhEM1zTNY3lpinc' \
    > test.out 2>&1
eval_tap $? 37 'PublishTemplateLocalizationV1Admin' test.out

#- 38 GetAllNotificationTopicsV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTopicsV1Admin \
    --namespace $AB_NAMESPACE \
    --after 'uf5d5saQvKfFRqBa' \
    --before 'm8jPtKHTmzo0JmcQ' \
    --limit '26' \
    > test.out 2>&1
eval_tap $? 38 'GetAllNotificationTopicsV1Admin' test.out

#- 39 CreateNotificationTopicV1Admin
# body param: body
echo '{"description": "IqwqpoTVCNrcaVoz", "topicName": "sjIXO2EUsAfBvo6L"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'CreateNotificationTopicV1Admin' test.out

#- 40 GetNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'lcalks2R3VMtipTV' \
    > test.out 2>&1
eval_tap $? 40 'GetNotificationTopicV1Admin' test.out

#- 41 UpdateNotificationTopicV1Admin
# body param: body
echo '{"description": "xXAF8KhOKqbrECij"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'FxOpOzxeTLJQsZcT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'UpdateNotificationTopicV1Admin' test.out

#- 42 DeleteNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'EzXaXUzpsAV6ct6X' \
    > test.out 2>&1
eval_tap $? 42 'DeleteNotificationTopicV1Admin' test.out

#- 43 SendSpecificUserFreeformNotificationV1Admin
# body param: body
echo '{"message": "ITL0QEkadMSQluAo", "topicName": "ED9oYwS8oLyErKvR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'tHFGJRoGW7VBG1VB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'SendSpecificUserFreeformNotificationV1Admin' test.out

#- 44 SendSpecificUserTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"2sp2x9mszGGoyhGZ": "Azt2OVBTLwSH8hWR", "U9pbItGQ7VUWBhGo": "lwafIfbF1GLFnrQ4", "T5cmw7U1TxiS06UE": "oaDZpXOWzpXOi2cp"}, "templateLanguage": "ajtqcXjPkj2IzU3M", "templateSlug": "EpCt1IjlfHJM92t9", "topicName": "j1XT2ErwIxkaTnYt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'r1YDnaXB0JOS4XKV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'SendSpecificUserTemplatedNotificationV1Admin' test.out

#- 45 AdminGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'T66sHYPgVsfhoEid' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetPartyDataV1' test.out

#- 46 AdminUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"Kw4IP0NVnaangorh": {}, "VFpTRuQyMroT2hNf": {}, "KJ7q8sifSPmYSsBx": {}}, "updatedAt": 40}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'mGhxv1vuN7Xv6OuG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminUpdatePartyAttributesV1' test.out

#- 47 AdminJoinPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminJoinPartyV1 \
    --namespace $AB_NAMESPACE \
    --partyId '6RR1jPh8RblvnfNi' \
    --userId 'ABRf1gdXM7QlAlnj' \
    > test.out 2>&1
eval_tap $? 47 'AdminJoinPartyV1' test.out

#- 48 AdminGetUserPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetUserPartyV1 \
    --namespace $AB_NAMESPACE \
    --userId 'AfgxOdZdf9tLHO1q' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetUserPartyV1' test.out

#- 49 AdminGetLobbyCCU
$CLI_EXE \
    --sn lobby \
    --op AdminGetLobbyCCU \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'AdminGetLobbyCCU' test.out

#- 50 AdminGetBulkPlayerBlockedPlayersV1
# body param: body
echo '{"listBlockedUserId": ["rNyhmUEADczzrL31", "HuYKsCBBgwb1hGjH", "JgxrcEvnfJqU4hCv"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminGetBulkPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminGetBulkPlayerBlockedPlayersV1' test.out

#- 51 AdminGetAllPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId '5egSQDePKSZKp6zw' \
    > test.out 2>&1
eval_tap $? 51 'AdminGetAllPlayerSessionAttribute' test.out

#- 52 AdminSetPlayerSessionAttribute
# body param: body
echo '{"attributes": {"DQS1atvJrALaiplJ": "gRhedl5Ewh3jDayY", "StUiBB1yz3iP8gH8": "8UenlMVzIOP8NOf9", "1LsD7cWWOgAs8ThM": "pAGIapYftYZkBXiE"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'hdiS41VBAEUvoBlb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminSetPlayerSessionAttribute' test.out

#- 53 AdminGetPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerSessionAttribute \
    --attribute 'H02bobxtljIfHBgj' \
    --namespace $AB_NAMESPACE \
    --userId 'P9onbxFcxS2OZZfX' \
    > test.out 2>&1
eval_tap $? 53 'AdminGetPlayerSessionAttribute' test.out

#- 54 AdminGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'O3HkJTOPscPA2n25' \
    > test.out 2>&1
eval_tap $? 54 'AdminGetPlayerBlockedPlayersV1' test.out

#- 55 AdminGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'C1zEnAMGmFy7w6eq' \
    > test.out 2>&1
eval_tap $? 55 'AdminGetPlayerBlockedByPlayersV1' test.out

#- 56 AdminBulkBlockPlayersV1
# body param: body
echo '{"listBlockedUserId": ["nMeKFo7U8Scr9xm6", "8w7s9RMx2hc45QX2", "34xnqlbRAPFQsca6"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminBulkBlockPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'n9vGZTCCXQ2Lf7jt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'AdminBulkBlockPlayersV1' test.out

#- 57 AdminDebugProfanityFilters
# body param: body
echo '{"text": "exB613cbiJEUePVZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDebugProfanityFilters \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminDebugProfanityFilters' test.out

#- 58 AdminGetProfanityListFiltersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityListFiltersV1 \
    --list 'QaoEY2zrpLuvrx96' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'AdminGetProfanityListFiltersV1' test.out

#- 59 AdminAddProfanityFilterIntoList
# body param: body
echo '{"filter": "OOz45vMiR3QYZJKV", "note": "NlK8PTaIXRWFTyA9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilterIntoList \
    --list 'MDnKGXqq7Zk705hO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'AdminAddProfanityFilterIntoList' test.out

#- 60 AdminAddProfanityFilters
# body param: body
echo '{"filters": [{"filter": "henJi6dNVF7zwjXq", "note": "lcD2LzaOwIF5tEsC"}, {"filter": "woAVcZCSj80gzFvp", "note": "vIerFEyxTugoTd50"}, {"filter": "RmJFX9v4GPfyGuQ2", "note": "UEl0U5Z9UnQmZqX1"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilters \
    --list '5hBb4dlNTIBDtHun' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'AdminAddProfanityFilters' test.out

#- 61 AdminImportProfanityFiltersFromFile
# body param: body
echo '[47, 0, 81]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminImportProfanityFiltersFromFile \
    --list 'UqkzSr41y6RPBHJu' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'AdminImportProfanityFiltersFromFile' test.out

#- 62 AdminDeleteProfanityFilter
# body param: body
echo '{"filter": "Pjj8zDwOk0IgmYfU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityFilter \
    --list 'TpFzyQhPVhRGX9xl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'AdminDeleteProfanityFilter' test.out

#- 63 AdminGetProfanityLists
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityLists \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'AdminGetProfanityLists' test.out

#- 64 AdminCreateProfanityList
# body param: body
echo '{"isEnabled": true, "isMandatory": true, "name": "hXI8mL8OIhvP68xE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateProfanityList \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'AdminCreateProfanityList' test.out

#- 65 AdminUpdateProfanityList
# body param: body
echo '{"isEnabled": false, "isMandatory": false, "newName": "dzohxhbej2caIIfk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateProfanityList \
    --list 'XDY7jnhp3qY6T7TU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'AdminUpdateProfanityList' test.out

#- 66 AdminDeleteProfanityList
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityList \
    --list 'EBotSNIwGhia6cqo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'AdminDeleteProfanityList' test.out

#- 67 AdminGetProfanityRule
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityRule \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'AdminGetProfanityRule' test.out

#- 68 AdminSetProfanityRuleForNamespace
# body param: body
echo '{"rule": "Wmnhtuzxir12r0VU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetProfanityRuleForNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'AdminSetProfanityRuleForNamespace' test.out

#- 69 AdminVerifyMessageProfanityResponse
# body param: body
echo '{"message": "WI0kJAczj5ApcsiE", "profanityLevel": "Q65llgGnTHAsTCZa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminVerifyMessageProfanityResponse \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'AdminVerifyMessageProfanityResponse' test.out

#- 70 AdminGetThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 70 'AdminGetThirdPartyConfig' test.out

#- 71 AdminUpdateThirdPartyConfig
# body param: body
echo '{"apiKey": "7xE4nwGKlbPRxfuc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'AdminUpdateThirdPartyConfig' test.out

#- 72 AdminCreateThirdPartyConfig
# body param: body
echo '{"apiKey": "xoRKFLxxcL9SyuHb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'AdminCreateThirdPartyConfig' test.out

#- 73 AdminDeleteThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'AdminDeleteThirdPartyConfig' test.out

#- 74 PublicGetMessages
$CLI_EXE \
    --sn lobby \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 74 'PublicGetMessages' test.out

#- 75 PublicGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'vRxR6LaKWgAVjZKD' \
    > test.out 2>&1
eval_tap $? 75 'PublicGetPartyDataV1' test.out

#- 76 PublicUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"xiezEbuMCz9J4dPR": {}, "GzoQLYIWPPZvyPup": {}, "imCENHEenqjRSxO9": {}}, "updatedAt": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'NyTfGE59942bCwgp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'PublicUpdatePartyAttributesV1' test.out

#- 77 PublicSetPartyLimitV1
# body param: body
echo '{"limit": 53}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicSetPartyLimitV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'bDR0Q0ixpqYtkZuh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'PublicSetPartyLimitV1' test.out

#- 78 PublicGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 78 'PublicGetPlayerBlockedPlayersV1' test.out

#- 79 PublicGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 79 'PublicGetPlayerBlockedByPlayersV1' test.out

#- 80 UsersPresenceHandlerV1
$CLI_EXE \
    --sn lobby \
    --op UsersPresenceHandlerV1 \
    --namespace $AB_NAMESPACE \
    --countOnly 'false' \
    --userIds 'qbAhRExsnbWSH45L' \
    > test.out 2>&1
eval_tap $? 80 'UsersPresenceHandlerV1' test.out

#- 81 FreeFormNotification
# body param: body
echo '{"message": "arTmOqto4OtwF9uP", "topic": "UAxerdIqWmOoMyYp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotification \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'FreeFormNotification' test.out

#- 82 NotificationWithTemplate
# body param: body
echo '{"templateContext": {"2tSrLxpJnj9JtgjW": "mjx1WuNQq4v8FnVz", "dbNW1xuV7rVei1o9": "zV6rhVfcQmLfEn5Z", "UGeYlOwODWBAz6sk": "HMfl4Hjw9KEnx8cN"}, "templateLanguage": "fDK45zWtwYhRoNPw", "templateSlug": "Kema6caMTOcivPAk", "topic": "mP8Awb0NqtvSR9q6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'NotificationWithTemplate' test.out

#- 83 GetGameTemplate
$CLI_EXE \
    --sn lobby \
    --op GetGameTemplate \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 83 'GetGameTemplate' test.out

#- 84 CreateTemplate
# body param: body
echo '{"templateContent": "l5k9BLQMrPoTuxdz", "templateLanguage": "EYAw5VdW05WnQEAb", "templateSlug": "K416LN2N6D6yczit"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'CreateTemplate' test.out

#- 85 GetSlugTemplate
$CLI_EXE \
    --sn lobby \
    --op GetSlugTemplate \
    --namespace $AB_NAMESPACE \
    --templateSlug 'n4OkZfx0Xa6sgegA' \
    --after 'WYz2z4qSPPQBDFQs' \
    --before 'vRHbGTC2ynue7Xk4' \
    --limit '41' \
    > test.out 2>&1
eval_tap $? 85 'GetSlugTemplate' test.out

#- 86 DeleteTemplateSlug
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateSlug \
    --namespace $AB_NAMESPACE \
    --templateSlug 'uQOfx6HIFfwBBqG5' \
    > test.out 2>&1
eval_tap $? 86 'DeleteTemplateSlug' test.out

#- 87 GetLocalizationTemplate
$CLI_EXE \
    --sn lobby \
    --op GetLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage '1RaZY74CqdvfPAIa' \
    --templateSlug 'PEkCIXX7WQ3ytABC' \
    > test.out 2>&1
eval_tap $? 87 'GetLocalizationTemplate' test.out

#- 88 UpdateLocalizationTemplate
# body param: body
echo '{"templateContent": "zYWxYbbphuiQPU0a"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'S2OIp0B2FWiDu7PO' \
    --templateSlug 'aotJoQQyL1bCDNis' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'UpdateLocalizationTemplate' test.out

#- 89 DeleteTemplateLocalization
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalization \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'OhjEKFWmj7ioi5WZ' \
    --templateSlug '6ZymQeVSZZma57V6' \
    > test.out 2>&1
eval_tap $? 89 'DeleteTemplateLocalization' test.out

#- 90 PublishTemplate
$CLI_EXE \
    --sn lobby \
    --op PublishTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'b9uLloAA9KoetyNP' \
    --templateSlug 'kgWcTCN7aBIFfeRd' \
    > test.out 2>&1
eval_tap $? 90 'PublishTemplate' test.out

#- 91 GetTopicByNamespace
$CLI_EXE \
    --sn lobby \
    --op GetTopicByNamespace \
    --namespace $AB_NAMESPACE \
    --after 'nHpse2T7eZwkVrB3' \
    --before 'GSEmVq8CjR5rCx0Z' \
    --limit '16' \
    > test.out 2>&1
eval_tap $? 91 'GetTopicByNamespace' test.out

#- 92 CreateTopic
# body param: body
echo '{"description": "Rw8YvLGLnB4xfqdH", "topic": "hPHA2ZbIvW1oxENH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'CreateTopic' test.out

#- 93 GetTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op GetTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic '4MsVlbCMc5hx0W14' \
    > test.out 2>&1
eval_tap $? 93 'GetTopicByTopicName' test.out

#- 94 UpdateTopicByTopicName
# body param: body
echo '{"description": "SkvovINegS29lege"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'bqGwej59Ok8EM0OF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'UpdateTopicByTopicName' test.out

#- 95 DeleteTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op DeleteTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'W93FkJicmK6qeaDE' \
    > test.out 2>&1
eval_tap $? 95 'DeleteTopicByTopicName' test.out

#- 96 FreeFormNotificationByUserID
# body param: body
echo '{"message": "m9bPCS2a5WoOtwav", "topic": "dioadjCN0lC0MZRZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotificationByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'AvhZ7XQmcT57Hl2P' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 96 'FreeFormNotificationByUserID' test.out

#- 97 NotificationWithTemplateByUserID
# body param: body
echo '{"templateContext": {"vPOKvc25nnSLnEnv": "4ipAVJzPHM6kTwfu", "1vSD9gROMknwVRJf": "XHGB1r66lbNcbMIJ", "EY0BmpF215jJycJc": "SyXLzU9Uqk079uhB"}, "templateLanguage": "Ll4yz32RqkNzYSNY", "templateSlug": "l4zvyD8SUZv2LFFZ", "topic": "er6T3W7TE5WdocKz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplateByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'vgr3jBU2g8Eo7uAb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'NotificationWithTemplateByUserID' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE