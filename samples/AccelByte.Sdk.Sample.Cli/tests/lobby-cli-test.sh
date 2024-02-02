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
echo "1..100"

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
    --upload file $TEMP_FILE_UPLOAD \
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

#- 25 AdminGetGlobalConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetGlobalConfig \
    > test.out 2>&1
eval_tap $? 25 'AdminGetGlobalConfig' test.out

#- 26 AdminUpdateGlobalConfig
# body param: body
echo '{"regionRetryMapping": {"WXrdZaFeacGT2x6o": ["28Njxyw7RHldq0m7", "NjUZ95Z5XDLBN9YG", "VPtkjt0OyBlJi4Rb"], "Z0Iy11mfOFjCzZVc": ["GomWF1oAqUNFDtXn", "XLvOAsW8wYh4gq7p", "RVZVLJiDx3au9b9Q"], "jhzDlnJmi4XaBTgo": ["XjfdUQHa3RxspSqw", "dbTR2sgzfaQrUCW9", "fgo69uv1bkFx8Dmb"]}, "regionURLMapping": ["C9UqYdYrdxNnuMcA", "wrSzYnrcetxObeis", "ZelKuD0iJ6fs3zL9"], "testGameMode": "H4WxGWRH7fz4BdPh", "testRegionURLMapping": ["LtHRJOImSq37aeAa", "Gq0NIj53gXkmrayv", "cIYiWxIAxfvLzSpD"], "testTargetUserIDs": ["FY3lxe16KsSRzkf2", "HzBcEio5UyvuFv5z", "6wosJGnUyCMEbHh1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateGlobalConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminUpdateGlobalConfig' test.out

#- 27 AdminDeleteGlobalConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteGlobalConfig \
    > test.out 2>&1
eval_tap $? 27 'AdminDeleteGlobalConfig' test.out

#- 28 SendMultipleUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "uE4DmJ4Suj6DjUw3", "topicName": "6GtZ83Jp2f9f1FCo", "userIds": ["Io3L24DKGwgZ85vy", "FJR8euQBLVu27iwp", "lLJdzYS9K0VvwE6M"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendMultipleUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'SendMultipleUsersFreeformNotificationV1Admin' test.out

#- 29 SendUsersFreeformNotificationV1Admin
# body param: body
echo '{"message": "AqPc8lGIYWTwxyqQ", "topicName": "QIXVmrtRlq1jv60H"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'SendUsersFreeformNotificationV1Admin' test.out

#- 30 SendPartyFreeformNotificationV1Admin
# body param: body
echo '{"message": "TnmFrl3gYx6Xmv1D", "topicName": "zPHux3k3skhn3mWZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'jTYM95e4aa8xOJu7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'SendPartyFreeformNotificationV1Admin' test.out

#- 31 SendPartyTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"rNRVdygfKmUkzj9m": "HFpff2vDkz68zorE", "gcExv9nKMOgO5W8S": "UaZjCpNtJSMm8kDi", "3Rwubq7wtRGdT447": "Oa51m6VLfjsw270p"}, "templateLanguage": "MmOQJrpEBbVvBn8L", "templateSlug": "sf2qSAtizV9hzsVb", "topicName": "pJLtEZjuyFhvbxX2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendPartyTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --partyId 'DNbknfVv4nm70TCa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'SendPartyTemplatedNotificationV1Admin' test.out

#- 32 GetAllNotificationTemplatesV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTemplatesV1Admin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'GetAllNotificationTemplatesV1Admin' test.out

#- 33 CreateNotificationTemplateV1Admin
# body param: body
echo '{"templateContent": "yYAkF18YBwRxcREy", "templateLanguage": "U5CwqGJF6nDi33Iz", "templateSlug": "tr2QcwlRrReRajlp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'CreateNotificationTemplateV1Admin' test.out

#- 34 SendUsersTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"k8lfuiJVcktlx9zJ": "ZVVCc9bpIHEWQMmC", "kIqwqpoTVCNrcaVo": "zsjIXO2EUsAfBvo6", "Llcalks2R3VMtipT": "VxXAF8KhOKqbrECi"}, "templateLanguage": "jFxOpOzxeTLJQsZc", "templateSlug": "TEzXaXUzpsAV6ct6", "topicName": "XITL0QEkadMSQluA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendUsersTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'SendUsersTemplatedNotificationV1Admin' test.out

#- 35 GetTemplateSlugLocalizationsTemplateV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetTemplateSlugLocalizationsTemplateV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'oED9oYwS8oLyErKv' \
    --after 'RtHFGJRoGW7VBG1V' \
    --before 'B2sp2x9mszGGoyhG' \
    --limit '35' \
    > test.out 2>&1
eval_tap $? 35 'GetTemplateSlugLocalizationsTemplateV1Admin' test.out

#- 36 DeleteNotificationTemplateSlugV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTemplateSlugV1Admin \
    --namespace $AB_NAMESPACE \
    --templateSlug 'Azt2OVBTLwSH8hWR' \
    > test.out 2>&1
eval_tap $? 36 'DeleteNotificationTemplateSlugV1Admin' test.out

#- 37 GetSingleTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetSingleTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'U9pbItGQ7VUWBhGo' \
    --templateSlug 'lwafIfbF1GLFnrQ4' \
    > test.out 2>&1
eval_tap $? 37 'GetSingleTemplateLocalizationV1Admin' test.out

#- 38 UpdateTemplateLocalizationV1Admin
# body param: body
echo '{"templateContent": "T5cmw7U1TxiS06UE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'oaDZpXOWzpXOi2cp' \
    --templateSlug 'ajtqcXjPkj2IzU3M' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateTemplateLocalizationV1Admin' test.out

#- 39 DeleteTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'EpCt1IjlfHJM92t9' \
    --templateSlug 'j1XT2ErwIxkaTnYt' \
    > test.out 2>&1
eval_tap $? 39 'DeleteTemplateLocalizationV1Admin' test.out

#- 40 PublishTemplateLocalizationV1Admin
$CLI_EXE \
    --sn lobby \
    --op PublishTemplateLocalizationV1Admin \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'r1YDnaXB0JOS4XKV' \
    --templateSlug 'T66sHYPgVsfhoEid' \
    > test.out 2>&1
eval_tap $? 40 'PublishTemplateLocalizationV1Admin' test.out

#- 41 GetAllNotificationTopicsV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetAllNotificationTopicsV1Admin \
    --namespace $AB_NAMESPACE \
    --after 'Kw4IP0NVnaangorh' \
    --before 'VFpTRuQyMroT2hNf' \
    --limit '76' \
    > test.out 2>&1
eval_tap $? 41 'GetAllNotificationTopicsV1Admin' test.out

#- 42 CreateNotificationTopicV1Admin
# body param: body
echo '{"description": "00ofXsbnEzHiRs0N", "topicName": "mGhxv1vuN7Xv6OuG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'CreateNotificationTopicV1Admin' test.out

#- 43 GetNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op GetNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName '6RR1jPh8RblvnfNi' \
    > test.out 2>&1
eval_tap $? 43 'GetNotificationTopicV1Admin' test.out

#- 44 UpdateNotificationTopicV1Admin
# body param: body
echo '{"description": "ABRf1gdXM7QlAlnj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'AfgxOdZdf9tLHO1q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'UpdateNotificationTopicV1Admin' test.out

#- 45 DeleteNotificationTopicV1Admin
$CLI_EXE \
    --sn lobby \
    --op DeleteNotificationTopicV1Admin \
    --namespace $AB_NAMESPACE \
    --topicName 'rNyhmUEADczzrL31' \
    > test.out 2>&1
eval_tap $? 45 'DeleteNotificationTopicV1Admin' test.out

#- 46 SendSpecificUserFreeformNotificationV1Admin
# body param: body
echo '{"message": "HuYKsCBBgwb1hGjH", "topicName": "JgxrcEvnfJqU4hCv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserFreeformNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId '5egSQDePKSZKp6zw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'SendSpecificUserFreeformNotificationV1Admin' test.out

#- 47 SendSpecificUserTemplatedNotificationV1Admin
# body param: body
echo '{"templateContext": {"DQS1atvJrALaiplJ": "gRhedl5Ewh3jDayY", "StUiBB1yz3iP8gH8": "8UenlMVzIOP8NOf9", "1LsD7cWWOgAs8ThM": "pAGIapYftYZkBXiE"}, "templateLanguage": "hdiS41VBAEUvoBlb", "templateSlug": "H02bobxtljIfHBgj", "topicName": "P9onbxFcxS2OZZfX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op SendSpecificUserTemplatedNotificationV1Admin \
    --namespace $AB_NAMESPACE \
    --userId 'O3HkJTOPscPA2n25' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'SendSpecificUserTemplatedNotificationV1Admin' test.out

#- 48 AdminGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'C1zEnAMGmFy7w6eq' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetPartyDataV1' test.out

#- 49 AdminUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"nMeKFo7U8Scr9xm6": {}, "8w7s9RMx2hc45QX2": {}, "34xnqlbRAPFQsca6": {}}, "updatedAt": 28}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'wKVQoydbYjXZyBpq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'AdminUpdatePartyAttributesV1' test.out

#- 50 AdminJoinPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminJoinPartyV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'hCJBtFOm3iCpu0lh' \
    --userId 'hgutt3rQuKP1OEtK' \
    > test.out 2>&1
eval_tap $? 50 'AdminJoinPartyV1' test.out

#- 51 AdminGetUserPartyV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetUserPartyV1 \
    --namespace $AB_NAMESPACE \
    --userId 'FBjNihHU8GP8TRVy' \
    > test.out 2>&1
eval_tap $? 51 'AdminGetUserPartyV1' test.out

#- 52 AdminGetLobbyCCU
$CLI_EXE \
    --sn lobby \
    --op AdminGetLobbyCCU \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'AdminGetLobbyCCU' test.out

#- 53 AdminGetBulkPlayerBlockedPlayersV1
# body param: body
echo '{"listBlockedUserId": ["pSvYXKz4BGjbsrRB", "V8aztJ86yQK1AsC1", "8UO6JcXmwQfkseTp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminGetBulkPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminGetBulkPlayerBlockedPlayersV1' test.out

#- 54 AdminGetAllPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetAllPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'H6l2Dv8SvqYKc56P' \
    > test.out 2>&1
eval_tap $? 54 'AdminGetAllPlayerSessionAttribute' test.out

#- 55 AdminSetPlayerSessionAttribute
# body param: body
echo '{"attributes": {"cPSL2xmjViKkKw4g": "HA4CaLsPqRsTdKzc", "KtkGcvn44NWse6VL": "PkM1VTrQBywhJ7lb", "BLw9xy1WQM5qUS8b": "aUqkzSr41y6RPBHJ"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetPlayerSessionAttribute \
    --namespace $AB_NAMESPACE \
    --userId 'uPjj8zDwOk0IgmYf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'AdminSetPlayerSessionAttribute' test.out

#- 56 AdminGetPlayerSessionAttribute
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerSessionAttribute \
    --attribute 'UTpFzyQhPVhRGX9x' \
    --namespace $AB_NAMESPACE \
    --userId 'lUKhXI8mL8OIhvP6' \
    > test.out 2>&1
eval_tap $? 56 'AdminGetPlayerSessionAttribute' test.out

#- 57 AdminGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId '8xE68dzohxhbej2c' \
    > test.out 2>&1
eval_tap $? 57 'AdminGetPlayerBlockedPlayersV1' test.out

#- 58 AdminGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'aIIfkXDY7jnhp3qY' \
    > test.out 2>&1
eval_tap $? 58 'AdminGetPlayerBlockedByPlayersV1' test.out

#- 59 AdminBulkBlockPlayersV1
# body param: body
echo '{"listBlockedUserId": ["6T7TUEBotSNIwGhi", "a6cqoWmnhtuzxir1", "2r0VUWI0kJAczj5A"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminBulkBlockPlayersV1 \
    --namespace $AB_NAMESPACE \
    --userId 'pcsiEQ65llgGnTHA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'AdminBulkBlockPlayersV1' test.out

#- 60 AdminDebugProfanityFilters
# body param: body
echo '{"text": "sTCZa7xE4nwGKlbP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDebugProfanityFilters \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'AdminDebugProfanityFilters' test.out

#- 61 AdminGetProfanityListFiltersV1
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityListFiltersV1 \
    --list 'RxfucxoRKFLxxcL9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'AdminGetProfanityListFiltersV1' test.out

#- 62 AdminAddProfanityFilterIntoList
# body param: body
echo '{"filter": "SyuHbvRxR6LaKWgA", "note": "VjZKDxiezEbuMCz9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilterIntoList \
    --list 'J4dPRGzoQLYIWPPZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'AdminAddProfanityFilterIntoList' test.out

#- 63 AdminAddProfanityFilters
# body param: body
echo '{"filters": [{"filter": "vyPupimCENHEenqj", "note": "RSxO9oZ0fCxLR0Gf"}, {"filter": "jwCmDrbDR0Q0ixpq", "note": "YtkZuhL6qbAhRExs"}, {"filter": "nbWSH45LarTmOqto", "note": "4OtwF9uPUAxerdIq"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminAddProfanityFilters \
    --list 'WmOoMyYp2tSrLxpJ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'AdminAddProfanityFilters' test.out

#- 64 AdminImportProfanityFiltersFromFile
# body param: body
echo '[28, 34, 18]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminImportProfanityFiltersFromFile \
    --list 'czRvUdK1uOV1ZJTY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'AdminImportProfanityFiltersFromFile' test.out

#- 65 AdminDeleteProfanityFilter
# body param: body
echo '{"filter": "uHpnpVX5u4gw4XBX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityFilter \
    --list 'DD7BG73sDdDoXnB8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'AdminDeleteProfanityFilter' test.out

#- 66 AdminGetProfanityLists
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityLists \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'AdminGetProfanityLists' test.out

#- 67 AdminCreateProfanityList
# body param: body
echo '{"isEnabled": false, "isMandatory": true, "name": "05KUgGKfDSGh3vQF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateProfanityList \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'AdminCreateProfanityList' test.out

#- 68 AdminUpdateProfanityList
# body param: body
echo '{"isEnabled": true, "isMandatory": false, "newName": "Ci8WEjR3wqpnMdSN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateProfanityList \
    --list 'skxhl3O3kGloooh7' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'AdminUpdateProfanityList' test.out

#- 69 AdminDeleteProfanityList
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteProfanityList \
    --list 'kL598P7F3IKhiNdx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'AdminDeleteProfanityList' test.out

#- 70 AdminGetProfanityRule
$CLI_EXE \
    --sn lobby \
    --op AdminGetProfanityRule \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 70 'AdminGetProfanityRule' test.out

#- 71 AdminSetProfanityRuleForNamespace
# body param: body
echo '{"rule": "1V7199NT7JTRFV3F"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminSetProfanityRuleForNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'AdminSetProfanityRuleForNamespace' test.out

#- 72 AdminVerifyMessageProfanityResponse
# body param: body
echo '{"message": "xMl5Rw4YeHqWkG09", "profanityLevel": "iEAFYWhow1WAwCs9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminVerifyMessageProfanityResponse \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'AdminVerifyMessageProfanityResponse' test.out

#- 73 AdminGetThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminGetThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'AdminGetThirdPartyConfig' test.out

#- 74 AdminUpdateThirdPartyConfig
# body param: body
echo '{"apiKey": "Y0KOemhNPYUVA9mU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminUpdateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'AdminUpdateThirdPartyConfig' test.out

#- 75 AdminCreateThirdPartyConfig
# body param: body
echo '{"apiKey": "8UvONyjv3GQuLHoQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op AdminCreateThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'AdminCreateThirdPartyConfig' test.out

#- 76 AdminDeleteThirdPartyConfig
$CLI_EXE \
    --sn lobby \
    --op AdminDeleteThirdPartyConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 76 'AdminDeleteThirdPartyConfig' test.out

#- 77 PublicGetMessages
$CLI_EXE \
    --sn lobby \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 77 'PublicGetMessages' test.out

#- 78 PublicGetPartyDataV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPartyDataV1 \
    --namespace $AB_NAMESPACE \
    --partyId '6ehLLK5h1bE9WU6w' \
    > test.out 2>&1
eval_tap $? 78 'PublicGetPartyDataV1' test.out

#- 79 PublicUpdatePartyAttributesV1
# body param: body
echo '{"custom_attribute": {"3tjUhSCKySPY7yMG": {}, "OuQOfx6HIFfwBBqG": {}, "51RaZY74CqdvfPAI": {}}, "updatedAt": 0}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicUpdatePartyAttributesV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'ZViQbxYQvUyapo6F' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'PublicUpdatePartyAttributesV1' test.out

#- 80 PublicSetPartyLimitV1
# body param: body
echo '{"limit": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op PublicSetPartyLimitV1 \
    --namespace $AB_NAMESPACE \
    --partyId 'zYWxYbbphuiQPU0a' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicSetPartyLimitV1' test.out

#- 81 PublicGetPlayerBlockedPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 81 'PublicGetPlayerBlockedPlayersV1' test.out

#- 82 PublicGetPlayerBlockedByPlayersV1
$CLI_EXE \
    --sn lobby \
    --op PublicGetPlayerBlockedByPlayersV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 82 'PublicGetPlayerBlockedByPlayersV1' test.out

#- 83 UsersPresenceHandlerV1
$CLI_EXE \
    --sn lobby \
    --op UsersPresenceHandlerV1 \
    --namespace $AB_NAMESPACE \
    --countOnly 'true' \
    --userIds 'p0B2FWiDu7POaotJ' \
    > test.out 2>&1
eval_tap $? 83 'UsersPresenceHandlerV1' test.out

#- 84 FreeFormNotification
# body param: body
echo '{"message": "oQQyL1bCDNisOhjE", "topic": "KFWmj7ioi5WZ6Zym"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotification \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'FreeFormNotification' test.out

#- 85 NotificationWithTemplate
# body param: body
echo '{"templateContext": {"QeVSZZma57V6b9uL": "loAA9KoetyNPkgWc", "TCN7aBIFfeRdnHps": "e2T7eZwkVrB3GSEm", "Vq8CjR5rCx0ZiHwU": "qL5rITYFhcdeNwLm"}, "templateLanguage": "ZenRqEBM0VGzhVVG", "templateSlug": "dipdi33u9U14rGwv", "topic": "MExAllZtPzNRiR35"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'NotificationWithTemplate' test.out

#- 86 GetGameTemplate
$CLI_EXE \
    --sn lobby \
    --op GetGameTemplate \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 86 'GetGameTemplate' test.out

#- 87 CreateTemplate
# body param: body
echo '{"templateContent": "CZhclugjyDzCPI8t", "templateLanguage": "slD0HuRrAMzMB9XH", "templateSlug": "HkfZgB6Vt5qWaae3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTemplate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'CreateTemplate' test.out

#- 88 GetSlugTemplate
$CLI_EXE \
    --sn lobby \
    --op GetSlugTemplate \
    --namespace $AB_NAMESPACE \
    --templateSlug 'SboVKgjsryC98whm' \
    --after 'I5koBT6iCuVa643k' \
    --before 'k8gvvnsu0ABei0go' \
    --limit '97' \
    > test.out 2>&1
eval_tap $? 88 'GetSlugTemplate' test.out

#- 89 DeleteTemplateSlug
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateSlug \
    --namespace $AB_NAMESPACE \
    --templateSlug 'wsmPfpsbkzAIsJ06' \
    > test.out 2>&1
eval_tap $? 89 'DeleteTemplateSlug' test.out

#- 90 GetLocalizationTemplate
$CLI_EXE \
    --sn lobby \
    --op GetLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'QlFCAa55r89MdFid' \
    --templateSlug 'v2kFVXgnjrAfzEn2' \
    > test.out 2>&1
eval_tap $? 90 'GetLocalizationTemplate' test.out

#- 91 UpdateLocalizationTemplate
# body param: body
echo '{"templateContent": "6mHgxUgVDgnlU5H2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateLocalizationTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'ULa1LYlsqYrUpXnc' \
    --templateSlug 'Yv2BVIS1BtMqvdE5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'UpdateLocalizationTemplate' test.out

#- 92 DeleteTemplateLocalization
$CLI_EXE \
    --sn lobby \
    --op DeleteTemplateLocalization \
    --namespace $AB_NAMESPACE \
    --templateLanguage 'QQizMBWYPYerJ1Fm' \
    --templateSlug 'KBX6U18gMIl7TSPm' \
    > test.out 2>&1
eval_tap $? 92 'DeleteTemplateLocalization' test.out

#- 93 PublishTemplate
$CLI_EXE \
    --sn lobby \
    --op PublishTemplate \
    --namespace $AB_NAMESPACE \
    --templateLanguage '96MsoQcFDfKSJymq' \
    --templateSlug 'Z5tDVsJ63mFWW0u9' \
    > test.out 2>&1
eval_tap $? 93 'PublishTemplate' test.out

#- 94 GetTopicByNamespace
$CLI_EXE \
    --sn lobby \
    --op GetTopicByNamespace \
    --namespace $AB_NAMESPACE \
    --after '5r5ylQKcWi0o5zcW' \
    --before 'p7NiTBI4m6PVEQWC' \
    --limit '81' \
    > test.out 2>&1
eval_tap $? 94 'GetTopicByNamespace' test.out

#- 95 CreateTopic
# body param: body
echo '{"description": "XQwc5sfOZbgnCmUL", "topic": "qltV5xjjrXKhZOek"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op CreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'CreateTopic' test.out

#- 96 GetTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op GetTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'pygvRDCk0koCGDPf' \
    > test.out 2>&1
eval_tap $? 96 'GetTopicByTopicName' test.out

#- 97 UpdateTopicByTopicName
# body param: body
echo '{"description": "biGdBQ5DNVJAgfAk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op UpdateTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic 'D0w0H6QM5AsRnp9a' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'UpdateTopicByTopicName' test.out

#- 98 DeleteTopicByTopicName
$CLI_EXE \
    --sn lobby \
    --op DeleteTopicByTopicName \
    --namespace $AB_NAMESPACE \
    --topic '7p0g0szNgC8yVFlw' \
    > test.out 2>&1
eval_tap $? 98 'DeleteTopicByTopicName' test.out

#- 99 FreeFormNotificationByUserID
# body param: body
echo '{"message": "GULKeMzn4sG6P5R2", "topic": "lHU9mf9rzrxuxtxg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op FreeFormNotificationByUserID \
    --namespace $AB_NAMESPACE \
    --userId '98cDF1fsD5miAxHc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'FreeFormNotificationByUserID' test.out

#- 100 NotificationWithTemplateByUserID
# body param: body
echo '{"templateContext": {"zgRu4VYjQq4VIVFU": "qNPuW223zuUv8Shb", "YBe9hLKcN6myFUWf": "7IuLG63jl9rYXaEF", "cUySnsIREQUlwDt2": "XB6DgoJm4dqrLVSB"}, "templateLanguage": "WToF03dQYi0OxI4D", "templateSlug": "ZZd2V80fjN9CwM4q", "topic": "NT3awIjWoFCW5BTW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn lobby \
    --op NotificationWithTemplateByUserID \
    --namespace $AB_NAMESPACE \
    --userId '9laFjsd7gSFkIVGn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 100 'NotificationWithTemplateByUserID' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE