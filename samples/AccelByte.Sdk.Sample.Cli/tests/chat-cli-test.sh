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
echo "1..60"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminChatHistory
$CLI_EXE \
    --sn chat \
    --op AdminChatHistory \
    --namespace $AB_NAMESPACE \
    --chatId '["bBuz5zkoaUEzGS3q", "Zf0PbemSBELbZ0VB", "UGA7nkDeev2Oj060"]' \
    --endCreatedAt '69' \
    --keyword 'WV6dIabcFbSmeuIB' \
    --limit '36' \
    --offset '30' \
    --order 'oQWoXFeqeuI2oMJ0' \
    --senderUserId 'cgAoGfXepE3r5AQU' \
    --shardId 'BqS8KtTYZLJ58Qqc' \
    --startCreatedAt '97' \
    --topic '["MI04rm2jUc9iav3t", "TqlE9oLDPD0Lfle8", "ESU1MO8XnVaEyjmi"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminChatHistory' test.out

#- 3 AdminCreateNamespaceTopic
# body param: body
echo '{"description": "fJDYa1TJPUszmFGE", "name": "kJVvqDSU3PDyIAGf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateNamespaceTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateNamespaceTopic' test.out

#- 4 AdminTopicList
$CLI_EXE \
    --sn chat \
    --op AdminTopicList \
    --namespace $AB_NAMESPACE \
    --limit '66' \
    --offset '33' \
    --topicType 'q1FNmRWvUvDPnKoE' \
    > test.out 2>&1
eval_tap $? 4 'AdminTopicList' test.out

#- 5 AdminCreateTopic
# body param: body
echo '{"admins": ["CjGUg867xodwuG14", "ID5l5wj6K2wEMnck", "jlW6BywsSSZTGlub"], "description": "smhjXcScOUvrjJBO", "isChannel": true, "isJoinable": true, "members": ["bkTGYKqRMSTisP0M", "rSdaFy0pJYCdfkfy", "t09ro5fHdWqJTNjr"], "name": "mpnnEckHH8kT9oXV", "shardLimit": 0, "type": "KeCaS6qyUCscHXs8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminCreateTopic' test.out

#- 6 AdminChannelTopicList
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicList \
    --namespace $AB_NAMESPACE \
    --limit '85' \
    --offset '24' \
    --topicName 'PjaYEDxaYN8w9KUW' \
    > test.out 2>&1
eval_tap $? 6 'AdminChannelTopicList' test.out

#- 7 AdminChannelTopicSummary
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicSummary \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminChannelTopicSummary' test.out

#- 8 AdminQueryTopicLog
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopicLog \
    --namespace $AB_NAMESPACE \
    --endCreatedAt '81' \
    --limit '32' \
    --offset '79' \
    --senderUserId 'y8KrcQfucSq2X8gF' \
    --startCreatedAt '43' \
    --topicId 'qU89D356pVsUtNan' \
    --topicIds '["ddzgwxYdQc5hEfef", "dopcEM0JHfof2Hwi", "7vg3osbh0fL2h7eJ"]' \
    --userId 'vAS2W4uqkhwSC7Ea' \
    > test.out 2>&1
eval_tap $? 8 'AdminQueryTopicLog' test.out

#- 9 AdminUpdateTopic
# body param: body
echo '{"description": "jwHO3LfvwPewrf19", "isJoinable": false, "name": "LgpQE9nXzhBC0uyM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateTopic \
    --namespace $AB_NAMESPACE \
    --topic 'R4Xf2nfYvNvG8uQ1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateTopic' test.out

#- 10 AdminDeleteTopic
$CLI_EXE \
    --sn chat \
    --op AdminDeleteTopic \
    --namespace $AB_NAMESPACE \
    --topic '4AhsxaALiBwpNJor' \
    > test.out 2>&1
eval_tap $? 10 'AdminDeleteTopic' test.out

#- 11 AdminBanTopicMembers
# body param: body
echo '{"userIds": ["nrCQpMJj5igqat8x", "nPoWTdHAkcyAy4dr", "HlPcXGGl0Xw3veBf"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'rpCrnbaxhEvn3SGq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminBanTopicMembers' test.out

#- 12 AdminChannelTopicInfo
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicInfo \
    --namespace $AB_NAMESPACE \
    --topic 'cH91fC3aJEoqWaFA' \
    > test.out 2>&1
eval_tap $? 12 'AdminChannelTopicInfo' test.out

#- 13 AdminTopicChatHistory
eval_tap 0 13 'AdminTopicChatHistory # SKIP deprecated' test.out

#- 14 AdminSendChat
# body param: body
echo '{"message": "GD6PRg95m07l03vt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendChat \
    --namespace $AB_NAMESPACE \
    --topic 'lMFzeiMRkcOr1L0T' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminSendChat' test.out

#- 15 AdminDeleteChat
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChat \
    --chatId 'MIczbYilOziwG8CP' \
    --namespace $AB_NAMESPACE \
    --topic 'LOzSZm9K3cMY617H' \
    > test.out 2>&1
eval_tap $? 15 'AdminDeleteChat' test.out

#- 16 AdminTopicMembers
$CLI_EXE \
    --sn chat \
    --op AdminTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'SCYZaL46I3PgCcQ0' \
    --isBanned 'false' \
    --isModerator 'true' \
    --limit '47' \
    --offset '25' \
    --shardId 'TWnmyEYLZQTpvLH6' \
    > test.out 2>&1
eval_tap $? 16 'AdminTopicMembers' test.out

#- 17 AdminTopicShards
$CLI_EXE \
    --sn chat \
    --op AdminTopicShards \
    --namespace $AB_NAMESPACE \
    --topic 'QPEBP8kSSFjeuL3w' \
    > test.out 2>&1
eval_tap $? 17 'AdminTopicShards' test.out

#- 18 AdminUnbanTopicMembers
# body param: body
echo '{"userIds": ["QQPYwmYFbxRvHYDC", "YwoGdmzXgf1ewUTv", "nu0ensa3MZF7DTsw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'nkSyuJTVjKQ1ORLE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUnbanTopicMembers' test.out

#- 19 AdminAddTopicMember
# body param: body
echo '{"isAdmin": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'AePvDO2xkVgyRk10' \
    --userId 'b27RdU8VceYQ9erP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminAddTopicMember' test.out

#- 20 AdminRemoveTopicMember
$CLI_EXE \
    --sn chat \
    --op AdminRemoveTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'YQ5yVcQuvDbGMqbE' \
    --userId 'HkCQwMBcQUNPHN8Y' \
    > test.out 2>&1
eval_tap $? 20 'AdminRemoveTopicMember' test.out

#- 21 AdminQueryTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopic \
    --namespace $AB_NAMESPACE \
    --includeMembers 'true' \
    --includePastMembers 'true' \
    --includePastTopics 'true' \
    --limit '61' \
    --offset '73' \
    --topic '["mJ4Suj6DjUw36GtZ", "83Jp2f9f1FCoIo3L", "24DKGwgZ85vyFJR8"]' \
    --topicSubType 'CLAN' \
    --topicType 'PERSONAL' \
    --userId '6ZsjpPgHKISHtB8t' \
    > test.out 2>&1
eval_tap $? 21 'AdminQueryTopic' test.out

#- 22 AdminQueryUsersTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryUsersTopic \
    --namespace $AB_NAMESPACE \
    --userId 'WdJM9Qc5HmR0vknX' \
    --includePastTopics 'true' \
    --limit '99' \
    --offset '96' \
    --topicSubType 'NORMAL' \
    --topicType 'PERSONAL' \
    > test.out 2>&1
eval_tap $? 22 'AdminQueryUsersTopic' test.out

#- 23 PublicGetMutedTopics
$CLI_EXE \
    --sn chat \
    --op PublicGetMutedTopics \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'PublicGetMutedTopics' test.out

#- 24 PublicTopicList
$CLI_EXE \
    --sn chat \
    --op PublicTopicList \
    --namespace $AB_NAMESPACE \
    --limit '81' \
    --offset '49' \
    --topicType 'XSTItt35OJTfJBZX' \
    > test.out 2>&1
eval_tap $? 24 'PublicTopicList' test.out

#- 25 PublicBanTopicMembers
# body param: body
echo '{"userIDs": ["62yI9g5RDrlzPFQm", "Nu3ERxV0UTaiSzfi", "0FnBERe8qNYRTYSa"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'Zw4NqSNylcljuNM3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicBanTopicMembers' test.out

#- 26 PublicChatHistory
$CLI_EXE \
    --sn chat \
    --op PublicChatHistory \
    --namespace $AB_NAMESPACE \
    --topic 'eUUSD1pZGMfPdGIO' \
    --limit '53' \
    --order 'orEgcExv9nKMOgO5' \
    --startCreatedAt '99' \
    > test.out 2>&1
eval_tap $? 26 'PublicChatHistory' test.out

#- 27 PublicDeleteChat
$CLI_EXE \
    --sn chat \
    --op PublicDeleteChat \
    --chatId '4qMIpfgxw2ff5twR' \
    --namespace $AB_NAMESPACE \
    --topic 'YbtdK2r4wWs6IpYB' \
    > test.out 2>&1
eval_tap $? 27 'PublicDeleteChat' test.out

#- 28 PublicMuteUser
# body param: body
echo '{"duration": 49, "userId": "47Oa51m6VLfjsw27"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicMuteUser \
    --namespace $AB_NAMESPACE \
    --topic '0pMmOQJrpEBbVvBn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PublicMuteUser' test.out

#- 29 PublicUnbanTopicMembers
# body param: body
echo '{"userIDs": ["8Lsf2qSAtizV9hzs", "VbpJLtEZjuyFhvbx", "X2DNbknfVv4nm70T"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'CayYAkF18YBwRxcR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'PublicUnbanTopicMembers' test.out

#- 30 PublicUnmuteUser
# body param: body
echo '{"userId": "EyU5CwqGJF6nDi33"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnmuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'Iztr2QcwlRrReRaj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicUnmuteUser' test.out

#- 31 AdminGetAllConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 31 'AdminGetAllConfigV1' test.out

#- 32 AdminGetConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'AdminGetConfigV1' test.out

#- 33 AdminUpdateConfigV1
# body param: body
echo '{"chatRateLimitBurst": 24, "chatRateLimitDuration": 28, "concurrentUsersLimit": 31, "enableClanChat": false, "enableManualTopicCreation": false, "enableProfanityFilter": true, "filterAppName": "8lfuiJVcktlx9zJZ", "filterParam": "VVCc9bpIHEWQMmCk", "filterType": "IqwqpoTVCNrcaVoz", "generalRateLimitBurst": 39, "generalRateLimitDuration": 87, "shardCapacityLimit": 20, "shardDefaultLimit": 54, "shardHardLimit": 71, "spamChatBurst": 98, "spamChatDuration": 45, "spamMuteDuration": 84}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AdminUpdateConfigV1' test.out

#- 34 ExportConfig
$CLI_EXE \
    --sn chat \
    --op ExportConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'ExportConfig' test.out

#- 35 ImportConfig
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op ImportConfig \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 35 'ImportConfig' test.out

#- 36 AdminGetInboxCategories
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxCategories \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'AdminGetInboxCategories' test.out

#- 37 AdminAddInboxCategory
# body param: body
echo '{"enabled": true, "expiresIn": 11, "hook": {"driver": "KAFKA", "params": "sAfBvo6Llcalks2R"}, "jsonSchema": {"3VMtipTVxXAF8KhO": {}, "KqbrECijFxOpOzxe": {}, "TLJQsZcTEzXaXUzp": {}}, "name": "sAV6ct6XITL0QEka", "saveInbox": false, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddInboxCategory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminAddInboxCategory' test.out

#- 38 AdminDeleteInboxCategory
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxCategory \
    --category 'QluAoED9oYwS8oLy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteInboxCategory' test.out

#- 39 AdminUpdateInboxCategory
# body param: body
echo '{"enabled": true, "expiresIn": 5, "hook": {"driver": "KAFKA", "params": "BBhRAYjR7c4x5bIk"}, "jsonSchema": {"8pVpxdUWOPel3Tiw": {}, "TycqpVdINXzvkSp0": {}, "WbvxQWI0QGCOx7eI": {}}, "saveInbox": true, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxCategory \
    --category 'kauWbFrSnU7d1Buh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminUpdateInboxCategory' test.out

#- 40 AdminGetCategorySchema
$CLI_EXE \
    --sn chat \
    --op AdminGetCategorySchema \
    --category 'dwliTSDdmGVfegiD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'AdminGetCategorySchema' test.out

#- 41 AdminDeleteInboxMessage
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxMessage \
    --messageId '3mrVQaUr3oT88Dfc' \
    --namespace $AB_NAMESPACE \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteInboxMessage' test.out

#- 42 AdminGetInboxMessages
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxMessages \
    --namespace $AB_NAMESPACE \
    --activeOnly 'true' \
    --endCreatedAt '1' \
    --limit '20' \
    --messageId '["QFGwTzBVDg5v71kG", "CEt7h1mVwIQCJmQk", "vWbQrn2W0VkOF0pQ"]' \
    --offset '83' \
    --order 'YDnaXB0JOS4XKVT6' \
    --scope 'NAMESPACE' \
    --startCreatedAt '37' \
    --status 'UNSENT' \
    --transient 'true' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetInboxMessages' test.out

#- 43 AdminSaveInboxMessage
# body param: body
echo '{"category": "PgVsfhoEidKw4IP0", "expiredAt": 81, "message": {"UEhWRo6ROvbuPQwl": {}, "9dVfJQGkDR00ofXs": {}, "bnEzHiRs0NmGhxv1": {}}, "scope": "USER", "status": "DRAFT", "userIds": ["uN7Xv6OuG6RR1jPh", "8RblvnfNiABRf1gd", "XM7QlAlnjAfgxOdZ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSaveInboxMessage \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminSaveInboxMessage' test.out

#- 44 AdminUnsendInboxMessage
# body param: body
echo '{"userIds": ["df9tLHO1qrNyhmUE", "ADczzrL31HuYKsCB", "Bgwb1hGjHJgxrcEv"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnsendInboxMessage \
    --inbox 'nfJqU4hCv5egSQDe' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminUnsendInboxMessage' test.out

#- 45 AdminGetInboxUsers
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxUsers \
    --inbox 'PKSZKp6zwDQS1atv' \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    --offset '61' \
    --status 'UNREAD' \
    --userId 'Oz0tMlpFuJVXo9s0' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetInboxUsers' test.out

#- 46 AdminUpdateInboxMessage
# body param: body
echo '{"expiredAt": 73, "message": {"h3jDayYStUiBB1yz": {}, "3iP8gH88UenlMVzI": {}, "OP8NOf91LsD7cWWO": {}}, "scope": "NAMESPACE", "userIds": ["oMTuJziuDNbOydiu", "3lOaruuYw0iUuts6", "bChMK1gcx8p9fyv5"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxMessage \
    --messageId 'PoMJeTIQix1FEvzl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminUpdateInboxMessage' test.out

#- 47 AdminSendInboxMessage
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendInboxMessage \
    --messageId 'ipE7r0vhh21v5772' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminSendInboxMessage' test.out

#- 48 AdminGetInboxStats
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxStats \
    --namespace $AB_NAMESPACE \
    --messageId '["AopmjI7CbY2WuwRU", "T9IivgC4mJ5OHuNE", "VQK4Mvk00I9GqAhh"]' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetInboxStats' test.out

#- 49 AdminGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminGetChatSnapshot \
    --chatId 'jNIivdIcaEQfNETQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'AdminGetChatSnapshot' test.out

#- 50 AdminDeleteChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChatSnapshot \
    --chatId 'CBPK1mYwKVQoydbY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteChatSnapshot' test.out

#- 51 AdminProfanityQuery
$CLI_EXE \
    --sn chat \
    --op AdminProfanityQuery \
    --namespace $AB_NAMESPACE \
    --filterMask 'jXZyBpqhCJBtFOm3' \
    --includeChildren 'false' \
    --limit '63' \
    --offset '59' \
    --parentId 'UePVZQaoEY2zrpLu' \
    --startWith 'vrx96OOz45vMiR3Q' \
    --wordType 'YZJKVNlK8PTaIXRW' \
    > test.out 2>&1
eval_tap $? 51 'AdminProfanityQuery' test.out

#- 52 AdminProfanityCreate
# body param: body
echo '{"falseNegative": ["FTyA9MDnKGXqq7Zk", "705hOhenJi6dNVF7", "zwjXqlcD2LzaOwIF"], "falsePositive": ["5tEsCwoAVcZCSj80", "gzFvpvIerFEyxTug", "oTd50RmJFX9v4GPf"], "word": "yGuQ2UEl0U5Z9UnQ", "wordType": "mZqX15hBb4dlNTIB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminProfanityCreate' test.out

#- 53 AdminProfanityCreateBulk
# body param: body
echo '{"dictionaries": [{"falseNegative": ["DtHunwNLLfKCQKuu", "2MWXpEpNjHWPcFSn", "M7GAvk19sXDish7K"], "falsePositive": ["UVhmAwmAygsnn8pM", "7l6v0elLMceGGgb5", "FJHWE6s13b7dmnPi"], "word": "jw6U8GGp0E886E90", "wordType": "E4ZboiXT1Uy0gArt"}, {"falseNegative": ["DpQE4bOtoiAjHXcV", "VOsVywU6uisejapf", "tqoxujXDosOo2kSU"], "falsePositive": ["fIA1guTNx7haejXS", "V2oH2uH8S4Zx0ACt", "eueMOmYP4SgxAIQT"], "word": "TKsdmtHu1dG0us7k", "wordType": "IWLcgKgU9406tdRD"}, {"falseNegative": ["qr3cpVbaH69NyTfG", "E59942bCwgpzUfcm", "TQjRmV0CPt1LUaTv"], "falsePositive": ["rFaxzOfG3pTddIA0", "Rt6wM5oQvTMICtWy", "UtVDnhgTGXO8Utpw"], "word": "xug8MpqczRvUdK1u", "wordType": "OV1ZJTYuHpnpVX5u"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreateBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminProfanityCreateBulk' test.out

#- 54 AdminProfanityExport
$CLI_EXE \
    --sn chat \
    --op AdminProfanityExport \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 54 'AdminProfanityExport' test.out

#- 55 AdminProfanityGroup
$CLI_EXE \
    --sn chat \
    --op AdminProfanityGroup \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '13' \
    > test.out 2>&1
eval_tap $? 55 'AdminProfanityGroup' test.out

#- 56 AdminProfanityImport
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op AdminProfanityImport \
    --namespace $AB_NAMESPACE \
    --action 'LEAVEOUT' \
    --showResult 'true' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'AdminProfanityImport' test.out

#- 57 AdminProfanityUpdate
# body param: body
echo '{"falseNegative": ["4XBXDD7BG73sDdDo", "XnB8F5X05KUgGKfD", "SGh3vQFPSYCi8WEj"], "falsePositive": ["R3wqpnMdSNskxhl3", "O3kGloooh7kL598P", "7F3IKhiNdx1V7199"], "word": "NT7JTRFV3FxMl5Rw", "wordType": "4YeHqWkG09iEAFYW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityUpdate \
    --id 'how1WAwCs9Y0KOem' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminProfanityUpdate' test.out

#- 58 AdminProfanityDelete
$CLI_EXE \
    --sn chat \
    --op AdminProfanityDelete \
    --id 'hNPYUVA9mU8UvONy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'AdminProfanityDelete' test.out

#- 59 PublicGetMessages
$CLI_EXE \
    --sn chat \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 59 'PublicGetMessages' test.out

#- 60 PublicGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op PublicGetChatSnapshot \
    --chatId 'jv3GQuLHoQ6ehLLK' \
    --namespace $AB_NAMESPACE \
    --topic '5h1bE9WU6w3tjUhS' \
    > test.out 2>&1
eval_tap $? 60 'PublicGetChatSnapshot' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE