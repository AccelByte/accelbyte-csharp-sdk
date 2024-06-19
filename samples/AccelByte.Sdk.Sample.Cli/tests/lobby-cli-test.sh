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
echo "1..107"

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

#- 17 SyncNativeBlockedUser
# body param: body
echo '[{"platformId": "uJORk4j04YfnXTsQ", "psnEnv": "UrA0WWyKl2K5mCSo"}, {"platformId": "GeQCahcox63cyDxA", "psnEnv": "AYcRXJdoSTxNCK9A"}, {"platformId": "IjNmbfoW8bDq5jPq", "psnEnv": "zhN0YdGSrA9LXRwU"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SyncNativeBlockedUser \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'SyncNativeBlockedUser' test.out

#- 18 AdminGetAllConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 18 'AdminGetAllConfigV1' test.out

#- 19 AdminGetLogConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 19 'AdminGetLogConfig' test.out

#- 20 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "trace", "socketLogEnabled": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminPatchUpdateLogConfig' test.out

#- 21 AdminGetConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminGetConfigV1' test.out

#- 22 AdminUpdateConfigV1
# body param: body
echo '{"allowInviteNonConnectedUser": false, "allowJoinPartyDuringMatchmaking": false, "autoKickOnDisconnect": false, "autoKickOnDisconnectDelay": 88, "cancelTicketOnDisconnect": true, "chatRateLimitBurst": 62, "chatRateLimitDuration": 59, "concurrentUsersLimit": 60, "disableInvitationOnJoinParty": false, "enableChat": false, "entitlementCheck": true, "entitlementItemID": "eNq0CvMXtyUWXrdZ", "generalRateLimitBurst": 0, "generalRateLimitDuration": 81, "keepPresenceActivityOnDisconnect": true, "maxDSWaitTime": 8, "maxFriendsLimit": 67, "maxPartyMember": 1, "profanityFilter": false, "readyConsentTimeout": 42, "unregisterDelay": 66}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminUpdateConfigV1' test.out

#- 23 AdminExportConfigV1
$CLI_EXE \
    --sn lobby \
    --op AdminExportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminExportConfigV1' test.out

#- 24 AdminImportConfigV1
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn lobby \
    --op AdminImportConfigV1 \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 24 'AdminImportConfigV1' test.out

#- 25 GetListOfFriends
$CLI_EXE \
    --sn lobby \
    --op GetListOfFriends \
    --namespace $AB_NAMESPACE \
    --userId 'Q14AhsxaALiBwpNJ' \
    --friendId 'ornrCQpMJj5igqat' \
    --friendIds '["8xnPoWTdHAkcyAy4", "drHlPcXGGl0Xw3ve", "BfrpCrnbaxhEvn3S"]' \
    --limit '67' \
    --offset '64' \
    > test.out 2>&1
eval_tap $? 25 'GetListOfFriends' test.out

#- 26 GetIncomingFriendRequests
$CLI_EXE \
    --sn lobby \
    --op GetIncomingFriendRequests \
    --namespace $AB_NAMESPACE \
    --userId 'qcH91fC3aJEoqWaF' \
    --friendId 'AGD6PRg95m07l03v' \
    --limit '40' \
    --offset '22' \
    > test.out 2>&1
eval_tap $? 26 'GetIncomingFriendRequests' test.out

#- 27 AdminListFriendsOfFriends
$CLI_EXE \
    --sn lobby \
    --op AdminListFriendsOfFriends \
    --namespace $AB_NAMESPACE \
    --userId 'b9QjhzDlnJmi4XaB' \
    --friendId 'TgoXjfdUQHa3Rxsp' \
    --limit '92' \
    --nopaging 'true' \
    --offset '52' \
    > test.out 2>&1
eval_tap $? 27 'AdminListFriendsOfFriends' test.out

#- 28 GetOutgoingFriendRequests
$CLI_EXE \
    --sn lobby \
    --op GetOutgoingFriendRequests \
    --namespace $AB_NAMESPACE \
    --userId 'wdbTR2sgzfaQrUCW' \
    --limit '11' \
    --offset '1' \
    > test.out 2>&1
eval_tap $? 28 'GetOutgoingFriendRequests' test.out

#- 29 AdminGetGlobalConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetGlobalConfig \
    > test.out 2>&1
eval_tap $? 29 'AdminGetGlobalConfig' test.out

#- 30 AdminUpdateGlobalConfig
# body param: body
echo '{"regionRetryMapping": {"go69uv1bkFx8DmbC": ["9UqYdYrdxNnuMcAw", "rSzYnrcetxObeisZ", "elKuD0iJ6fs3zL9H"], "4WxGWRH7fz4BdPhL": ["tHRJOImSq37aeAaG", "q0NIj53gXkmrayvc", "IYiWxIAxfvLzSpDF"], "Y3lxe16KsSRzkf2H": ["zBcEio5UyvuFv5z6", "wosJGnUyCMEbHh1u", "E4DmJ4Suj6DjUw36"]}, "regionURLMapping": ["GtZ83Jp2f9f1FCoI", "o3L24DKGwgZ85vyF", "JR8euQBLVu27iwpl"], "testGameMode": "LJdzYS9K0VvwE6MA", "testRegionURLMapping": ["qPc8lGIYWTwxyqQQ", "IXVmrtRlq1jv60HT", "nmFrl3gYx6Xmv1Dz"], "testTargetUserIDs": ["PHux3k3skhn3mWZj", "TYM95e4aa8xOJu7r", "NRVdygfKmUkzj9mH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateGlobalConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminUpdateGlobalConfig' test.out

#- 31 AdminDeleteGlobalConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteGlobalConfig \
    > test.out 2>&1
eval_tap $? 31 'AdminDeleteGlobalConfig' test.out

#- 32 SendMultipleUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "Fpff2vDkz68zorEg", "topicName": "cExv9nKMOgO5W8SU", "userIds": ["aZjCpNtJSMm8kDi3", "Rwubq7wtRGdT447O", "a51m6VLfjsw270pM"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendMultipleUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'SendMultipleUsersFreeformNotificationV1Admin' test.out

#- 33 SendUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "mOQJrpEBbVvBn8Ls", "topicName": "f2qSAtizV9hzsVbp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'SendUsersFreeformNotificationV1Admin' test.out

#- 34 SendPartyFreeformNotificationV1Admin
# body param: body
echo '{"message": "JLtEZjuyFhvbxX2D", "topicName": "NbknfVv4nm70TCay"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'YAkF18YBwRxcREyU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'SendPartyFreeformNotificationV1Admin' test.out

#- 35 SendPartyTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"5CwqGJF6nDi33Izt": "r2QcwlRrReRajlpk", "8lfuiJVcktlx9zJZ": "VVCc9bpIHEWQMmCk", "IqwqpoTVCNrcaVoz": "sjIXO2EUsAfBvo6L"}, "templateLanguage": "lcalks2R3VMtipTV", "templateSlug": "xXAF8KhOKqbrECij", "topicName": "FxOpOzxeTLJQsZcT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'EzXaXUzpsAV6ct6X' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'SendPartyTemplatedNotificationV1Admin' test.out

#- 36 GetAllNotificationTemplatesV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTemplatesV1Admin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'GetAllNotificationTemplatesV1Admin' test.out

#- 37 CreateNotificationTemplateV1Admin
# body param: body
echo '{"templateContent": "ITL0QEkadMSQluAo", "templateLanguage": "ED9oYwS8oLyErKvR", "templateSlug": "tHFGJRoGW7VBG1VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'CreateNotificationTemplateV1Admin' test.out

#- 38 SendUsersTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"2sp2x9mszGGoyhGZ": "Azt2OVBTLwSH8hWR", "U9pbItGQ7VUWBhGo": "lwafIfbF1GLFnrQ4", "T5cmw7U1TxiS06UE": "oaDZpXOWzpXOi2cp"}, "templateLanguage": "ajtqcXjPkj2IzU3M", "templateSlug": "EpCt1IjlfHJM92t9", "topicName": "j1XT2ErwIxkaTnYt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'SendUsersTemplatedNotificationV1Admin' test.out

#- 39 GetTemplateSlugLocalizationsTemplateV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetTemplateSlugLocalizationsTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'r1YDnaXB0JOS4XKV' \
    --after 'T66sHYPgVsfhoEid' \
    --before 'Kw4IP0NVnaangorh' \
    --limit '98' \
    > test.out 2>&1
eval_tap $? 39 'GetTemplateSlugLocalizationsTemplateV1Admin' test.out

#- 40 DeleteNotificationTemplateSlugV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTemplateSlugV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'buPQwl9dVfJQGkDR' \
    > test.out 2>&1
eval_tap $? 40 'DeleteNotificationTemplateSlugV1Admin' test.out

#- 41 GetSingleTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetSingleTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage '00ofXsbnEzHiRs0N' \
    --templateSlug 'mGhxv1vuN7Xv6OuG' \
    > test.out 2>&1
eval_tap $? 41 'GetSingleTemplateLocalizationV1Admin' test.out

#- 42 UpdateTemplateLocalizationV1Admin
# body param: body
echo '{"templateContent": "6RR1jPh8RblvnfNi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'ABRf1gdXM7QlAlnj' \
    --templateSlug 'AfgxOdZdf9tLHO1q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateTemplateLocalizationV1Admin' test.out

#- 43 DeleteTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'rNyhmUEADczzrL31' \
    --templateSlug 'HuYKsCBBgwb1hGjH' \
    > test.out 2>&1
eval_tap $? 43 'DeleteTemplateLocalizationV1Admin' test.out

#- 44 PublishTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op PublishTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'JgxrcEvnfJqU4hCv' \
    --templateSlug '5egSQDePKSZKp6zw' \
    > test.out 2>&1
eval_tap $? 44 'PublishTemplateLocalizationV1Admin' test.out

#- 45 GetAllNotificationTopicsV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTopicsV1Admin \
    --namespace $AB_NAMESPACE \
    --after 'DQS1atvJrALaiplJ' \
    --before 'gRhedl5Ewh3jDayY' \
    --limit '91' \
    > test.out 2>&1
eval_tap $? 45 'GetAllNotificationTopicsV1Admin' test.out

#- 46 CreateNotificationTopicV1Admin
# body param: body
echo '{"description": "Qo9HoLLyUnPTiCD0", "topicName": "038or8wR0tuwIJnr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'CreateNotificationTopicV1Admin' test.out

#- 47 GetNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'SI2IFcRwSoMTuJzi' \
    > test.out 2>&1
eval_tap $? 47 'GetNotificationTopicV1Admin' test.out

#- 48 UpdateNotificationTopicV1Admin
# body param: body
echo '{"description": "uDNbOydiu3lOaruu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'Yw0iUuts6bChMK1g' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'UpdateNotificationTopicV1Admin' test.out

#- 49 DeleteNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'cx8p9fyv5PoMJeTI' \
    > test.out 2>&1
eval_tap $? 49 'DeleteNotificationTopicV1Admin' test.out

#- 50 SendSpecificUserFreeformNotificationV1Admin
# body param: body
echo '{"message": "Qix1FEvzlipE7r0v", "topicName": "hh21v5772AopmjI7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'CbY2WuwRUT9IivgC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'SendSpecificUserFreeformNotificationV1Admin' test.out

#- 51 SendSpecificUserTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"4mJ5OHuNEVQK4Mvk": "00I9GqAhhjNIivdI", "caEQfNETQCBPK1mY": "wKVQoydbYjXZyBpq", "hCJBtFOm3iCpu0lh": "hgutt3rQuKP1OEtK"}, "templateLanguage": "FBjNihHU8GP8TRVy", "templateSlug": "pSvYXKz4BGjbsrRB", "topicName": "V8aztJ86yQK1AsC1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId '8UO6JcXmwQfkseTp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'SendSpecificUserTemplatedNotificationV1Admin' test.out

#- 52 AdminGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'H6l2Dv8SvqYKc56P' \
    > test.out 2>&1
eval_tap $? 52 'AdminGetPartyDataV1' test.out

#- 53 AdminUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"cPSL2xmjViKkKw4g": {}, "HA4CaLsPqRsTdKzc": {}, "KtkGcvn44NWse6VL": {}}, "updatedAt": 86}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'El0U5Z9UnQmZqX15' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminUpdatePartyAttributesV1' test.out

#- 54 AdminJoinPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminJoinPartyV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'hBb4dlNTIBDtHunw' \
    --userId 'NLLfKCQKuu2MWXpE' \
    > test.out 2>&1
eval_tap $? 54 'AdminJoinPartyV1' test.out

#- 55 AdminGetUserPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetUserPartyV1 \
    --namespace $AB_NAMESPACE \
    --userId 'pNjHWPcFSnM7GAvk' \
    > test.out 2>&1
eval_tap $? 55 'AdminGetUserPartyV1' test.out

#- 56 AdminGetLobbyCCU
$CLI_EXE \
    --sn lobby \
    --op AdminGetLobbyCCU \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'AdminGetLobbyCCU' test.out

#- 57 AdminGetBulkPlayerBlockedPlayersV1
# body param: body
echo '{"listBlockedUserId": ["19sXDish7KUVhmAw", "mAygsnn8pM7l6v0e", "lLMceGGgb5FJHWE6"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminGetBulkPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminGetBulkPlayerBlockedPlayersV1' test.out

#- 58 AdminGetAllPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 's13b7dmnPijw6U8G' \
    > test.out 2>&1
eval_tap $? 58 'AdminGetAllPlayerSessionAttribute' test.out

#- 59 AdminSetPlayerSessionAttribute
# body param: body
echo '{"attributes": {"Gp0E886E90E4Zboi": "XT1Uy0gArtDpQE4b", "OtoiAjHXcVVOsVyw": "U6uisejapftqoxuj", "XDosOo2kSUfIA1gu": "TNx7haejXSV2oH2u"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'H8S4Zx0ACteueMOm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'AdminSetPlayerSessionAttribute' test.out

#- 60 AdminGetPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerSessionAttribute \
    --attribute 'YP4SgxAIQTTKsdmt' \
    --namespace $AB_NAMESPACE \
    --userId 'Hu1dG0us7kIWLcgK' \
    > test.out 2>&1
eval_tap $? 60 'AdminGetPlayerSessionAttribute' test.out

#- 61 AdminGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'gU9406tdRDqr3cpV' \
    > test.out 2>&1
eval_tap $? 61 'AdminGetPlayerBlockedPlayersV1' test.out

#- 62 AdminGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'baH69NyTfGE59942' \
    > test.out 2>&1
eval_tap $? 62 'AdminGetPlayerBlockedByPlayersV1' test.out

#- 63 AdminBulkBlockPlayersV1
# body param: body
echo '{"listBlockedUserId": ["bCwgpzUfcmTQjRmV", "0CPt1LUaTvrFaxzO", "fG3pTddIA0Rt6wM5"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminBulkBlockPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'oQvTMICtWyUtVDnh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'AdminBulkBlockPlayersV1' test.out

#- 64 AdminDebugProfanityFilters
# body param: body
echo '{"text": "gTGXO8Utpwxug8Mp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDebugProfanityFilters \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'AdminDebugProfanityFilters' test.out

#- 65 AdminGetProfanityListFiltersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityListFiltersV1 \
    --list 'qczRvUdK1uOV1ZJT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 65 'AdminGetProfanityListFiltersV1' test.out

#- 66 AdminAddProfanityFilterIntoList
# body param: body
echo '{"filter": "YuHpnpVX5u4gw4XB", "note": "XDD7BG73sDdDoXnB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilterIntoList \
    --list '8F5X05KUgGKfDSGh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'AdminAddProfanityFilterIntoList' test.out

#- 67 AdminAddProfanityFilters
# body param: body
echo '{"filters": [{"filter": "3vQFPSYCi8WEjR3w", "note": "qpnMdSNskxhl3O3k"}, {"filter": "Gloooh7kL598P7F3", "note": "IKhiNdx1V7199NT7"}, {"filter": "JTRFV3FxMl5Rw4Ye", "note": "HqWkG09iEAFYWhow"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilters \
    --list '1WAwCs9Y0KOemhNP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'AdminAddProfanityFilters' test.out

#- 68 AdminImportProfanityFiltersFromFile
# body param: body
echo '[60, 95, 98]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminImportProfanityFiltersFromFile \
    --list 'yczitn4OkZfx0Xa6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'AdminImportProfanityFiltersFromFile' test.out

#- 69 AdminDeleteProfanityFilter
# body param: body
echo '{"filter": "sgegAWYz2z4qSPPQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityFilter \
    --list 'BDFQsvRHbGTC2ynu' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'AdminDeleteProfanityFilter' test.out

#- 70 AdminGetProfanityLists
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityLists \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 70 'AdminGetProfanityLists' test.out

#- 71 AdminCreateProfanityList
# body param: body
echo '{"isEnabled": false, "isMandatory": true, "name": "Xk4uDF5mdakWJ2As"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateProfanityList \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'AdminCreateProfanityList' test.out

#- 72 AdminUpdateProfanityList
# body param: body
echo '{"isEnabled": true, "isMandatory": false, "newName": "G51RaZY74CqdvfPA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateProfanityList \
    --list 'IaPEkCIXX7WQ3ytA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'AdminUpdateProfanityList' test.out

#- 73 AdminDeleteProfanityList
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityList \
    --list 'BCzYWxYbbphuiQPU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'AdminDeleteProfanityList' test.out

#- 74 AdminGetProfanityRule
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityRule \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 74 'AdminGetProfanityRule' test.out

#- 75 AdminSetProfanityRuleForNamespace
# body param: body
echo '{"rule": "0aS2OIp0B2FWiDu7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetProfanityRuleForNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'AdminSetProfanityRuleForNamespace' test.out

#- 76 AdminVerifyMessageProfanityResponse
# body param: body
echo '{"message": "POaotJoQQyL1bCDN", "profanityLevel": "isOhjEKFWmj7ioi5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminVerifyMessageProfanityResponse \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'AdminVerifyMessageProfanityResponse' test.out

#- 77 AdminGetThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 77 'AdminGetThirdPartyConfig' test.out

#- 78 AdminUpdateThirdPartyConfig
# body param: body
echo '{"apiKey": "WZ6ZymQeVSZZma57"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'AdminUpdateThirdPartyConfig' test.out

#- 79 AdminCreateThirdPartyConfig
# body param: body
echo '{"apiKey": "V6b9uLloAA9Koety"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'AdminCreateThirdPartyConfig' test.out

#- 80 AdminDeleteThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 80 'AdminDeleteThirdPartyConfig' test.out

#- 81 PublicGetMessages
$CLI_EXE \
    --sn lobby \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 81 'PublicGetMessages' test.out

#- 82 PublicGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'NPkgWcTCN7aBIFfe' \
    > test.out 2>&1
eval_tap $? 82 'PublicGetPartyDataV1' test.out

#- 83 PublicUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"RdnHpse2T7eZwkVr": {}, "B3GSEmVq8CjR5rCx": {}, "0ZiHwUqL5rITYFhc": {}}, "updatedAt": 6}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'dHhPHA2ZbIvW1oxE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'PublicUpdatePartyAttributesV1' test.out

#- 84 PublicSetPartyLimitV1
# body param: body
echo '{"limit": 80}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicSetPartyLimitV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'zhVVGdipdi33u9U1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'PublicSetPartyLimitV1' test.out

#- 85 PublicPlayerBlockPlayersV1
# body param: body
echo '{"blockedUserId": "4rGwvMExAllZtPzN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicPlayerBlockPlayersV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicPlayerBlockPlayersV1' test.out

#- 86 PublicGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 86 'PublicGetPlayerBlockedPlayersV1' test.out

#- 87 PublicGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 87 'PublicGetPlayerBlockedByPlayersV1' test.out

#- 88 PublicUnblockPlayerV1
# body param: body
echo '{"userId": "RiR35CZhclugjyDz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUnblockPlayerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'PublicUnblockPlayerV1' test.out

#- 89 UsersPresenceHandlerV1
$CLI_EXE \
    --sn lobby \
    --op UsersPresenceHandlerV1 \
    --namespace $AB_NAMESPACE \
    --countOnly 'true' \
    --userIds 'FW93FkJicmK6qeaD' \
    > test.out 2>&1
eval_tap $? 89 'UsersPresenceHandlerV1' test.out

#- 90 FreeFormNotification
# body param: body
echo '{"message": "Em9bPCS2a5WoOtwa", "topic": "vdioadjCN0lC0MZR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotification \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 90 'FreeFormNotification' test.out

#- 91 GetMyNotifications
$CLI_EXE \
    --sn lobby \
    --op GetMyNotifications \
    --namespace $AB_NAMESPACE \
    --endTime '53' \
    --limit '47' \
    --offset '44' \
    --startTime '15' \
    > test.out 2>&1
eval_tap $? 91 'GetMyNotifications' test.out

#- 92 NotificationWithTemplate
# body param: body
echo '{"templateContext": {"hZ7XQmcT57Hl2PvP": "OKvc25nnSLnEnv4i", "pAVJzPHM6kTwfu1v": "SD9gROMknwVRJfXH", "GB1r66lbNcbMIJEY": "0BmpF215jJycJcSy"}, "templateLanguage": "XLzU9Uqk079uhBLl", "templateSlug": "4yz32RqkNzYSNYl4", "topic": "zvyD8SUZv2LFFZer"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'NotificationWithTemplate' test.out

#- 93 GetGameTemplate
$CLI_EXE \
    --sn lobby \
    --op GetGameTemplate \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 93 'GetGameTemplate' test.out

#- 94 CreateTemplate
# body param: body
echo '{"templateContent": "6T3W7TE5WdocKzvg", "templateLanguage": "r3jBU2g8Eo7uAb4H", "templateSlug": "ndxqQYO14lFR2YtI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'CreateTemplate' test.out

#- 95 GetSlugTemplate
$CLI_EXE \
    --sn lobby \
    --op GetSlugTemplate \
    --namespace $AB_NAMESPACE \
    --templateSlug 'b1fufxJiodJFjEbn' \
    --after '1ASMAiedHoYv6WmW' \
    --before '9mRXQwc5sfOZbgnC' \
    --limit '25' \
    > test.out 2>&1
eval_tap $? 95 'GetSlugTemplate' test.out

#- 96 DeleteTemplateSlug
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateSlug \
    --namespace $AB_NAMESPACE \
    --templateSlug '2w60X5Vb0TV0x3nm' \
    > test.out 2>&1
eval_tap $? 96 'DeleteTemplateSlug' test.out

#- 97 GetLocalizationTemplate
$CLI_EXE \
    --sn lobby \
    --op GetLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'q9UCZbdVFY3WdZ6l' \
    --templateSlug 'uOW977EgotvOrnRj' \
    > test.out 2>&1
eval_tap $? 97 'GetLocalizationTemplate' test.out

#- 98 UpdateLocalizationTemplate
# body param: body
echo '{"templateContent": "b5UT6Vf5jxoBBg2l"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'M3DQXyC3oKu14sRj' \
    --templateSlug 'kCeuRY0tsnbKAGRT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'UpdateLocalizationTemplate' test.out

#- 99 DeleteTemplateLocalization
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalization \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'CvAZKiSB7bYvWmbU' \
    --templateSlug 'bWlRZtcIUry87yJB' \
    > test.out 2>&1
eval_tap $? 99 'DeleteTemplateLocalization' test.out

#- 100 PublishTemplate
$CLI_EXE \
    --sn lobby \
    --op PublishTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'lfjPI5tfjbyZkYSR' \
    --templateSlug 'LBMgcD5OJgp6wHyn' \
    > test.out 2>&1
eval_tap $? 100 'PublishTemplate' test.out

#- 101 GetTopicByNamespace
$CLI_EXE \
    --sn lobby \
    --op GetTopicByNamespace \
    --namespace $AB_NAMESPACE \
    --after 'VKwWgdAibFBESdI0' \
    --before 'Ab1zgjMC3hp1s4tE' \
    --limit '24' \
    > test.out 2>&1
eval_tap $? 101 'GetTopicByNamespace' test.out

#- 102 CreateTopic
# body param: body
echo '{"description": "EFcUySnsIREQUlwD", "topic": "t2XB6DgoJm4dqrLV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 102 'CreateTopic' test.out

#- 103 GetTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op GetTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'SBWToF03dQYi0OxI' \
    > test.out 2>&1
eval_tap $? 103 'GetTopicByTopicName' test.out

#- 104 UpdateTopicByTopicName
# body param: body
echo '{"description": "4DZZd2V80fjN9CwM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic '4qNT3awIjWoFCW5B' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 104 'UpdateTopicByTopicName' test.out

#- 105 DeleteTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op DeleteTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'TW9laFjsd7gSFkIV' \
    > test.out 2>&1
eval_tap $? 105 'DeleteTopicByTopicName' test.out

#- 106 FreeFormNotificationByUserID
# body param: body
echo '{"message": "GnXJLeUdD8XNxAko", "topic": "eHk0BXouyKC6RnO4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotificationByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'PckO3syHJOMlgAqt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 106 'FreeFormNotificationByUserID' test.out

#- 107 NotificationWithTemplateByUserID
# body param: body
echo '{"templateContext": {"snZlLvEczKKAyiQv": "93N1fbGovPLBpXX8", "vScPhhhoeTbxungc": "a58m1uNcxsQxrsxb", "LSv7uFZXdW5GyQ2m": "veLZEnmSCeWTCXfA"}, "templateLanguage": "RUx3U3KrfqoZi5xi", "templateSlug": "HiQI9ieQ8y75Biw4", "topic": "pKJ8hey5JmuUDloj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplateByUserID \
    --namespace $AB_NAMESPACE \
    --userId 'Ec712JEhS1VFA1Eo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 107 'NotificationWithTemplateByUserID' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE