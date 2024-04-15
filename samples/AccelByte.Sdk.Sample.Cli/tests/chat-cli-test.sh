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
    --upload file $TEMP_FILE_UPLOAD \
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
echo '{"enabled": true, "expiresIn": 11, "hook": {"driver": "UsAfBvo6Llcalks2", "params": {"R3VMtipTVxXAF8Kh": {}, "OKqbrECijFxOpOzx": {}, "eTLJQsZcTEzXaXUz": {}}}, "jsonSchema": {"psAV6ct6XITL0QEk": {}, "adMSQluAoED9oYwS": {}, "8oLyErKvRtHFGJRo": {}}, "name": "GW7VBG1VB2sp2x9m", "saveInbox": true, "sendNotification": false}' > $TEMP_JSON_INPUT
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
    --category 'zGGoyhGZAzt2OVBT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteInboxCategory' test.out

#- 39 AdminUpdateInboxCategory
# body param: body
echo '{"enabled": false, "expiresIn": 47, "hook": {"driver": "Sp0WbvxQWI0QGCOx", "params": {"7eICkauWbFrSnU7d": {}, "1BuhdwliTSDdmGVf": {}, "egiD3mrVQaUr3oT8": {}}}, "jsonSchema": {"8Dfc7114QFGwTzBV": {}, "Dg5v71kGCEt7h1mV": {}, "wIQCJmQkvWbQrn2W": {}}, "saveInbox": false, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxCategory \
    --category 'kOF0pQOY0UCcViiF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminUpdateInboxCategory' test.out

#- 40 AdminGetCategorySchema
$CLI_EXE \
    --sn chat \
    --op AdminGetCategorySchema \
    --category 'KNjkT5hcONCaOyAT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'AdminGetCategorySchema' test.out

#- 41 AdminDeleteInboxMessage
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxMessage \
    --messageId 'BFgqLeAzvdcUEhWR' \
    --namespace $AB_NAMESPACE \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteInboxMessage' test.out

#- 42 AdminGetInboxMessages
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxMessages \
    --namespace $AB_NAMESPACE \
    --activeOnly 'false' \
    --endCreatedAt '30' \
    --limit '89' \
    --messageId '["rhVFpTRuQyMroT2h", "NfKJ7q8sifSPmYSs", "BxtyKWssEn5VEvIM"]' \
    --offset '63' \
    --order 'uG6RR1jPh8Rblvnf' \
    --scope 'NAMESPACE' \
    --startCreatedAt '16' \
    --status 'SENT' \
    --transient 'true' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetInboxMessages' test.out

#- 43 AdminSaveInboxMessage
# body param: body
echo '{"category": "s65thtnjcMSw1J42", "expiredAt": 11, "message": {"gxOdZdf9tLHO1qrN": {}, "yhmUEADczzrL31Hu": {}, "YKsCBBgwb1hGjHJg": {}}, "scope": "USER", "status": "SENT", "userIds": ["rcEvnfJqU4hCv5eg", "SQDePKSZKp6zwDQS", "1atvJrALaiplJgRh"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSaveInboxMessage \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminSaveInboxMessage' test.out

#- 44 AdminUnsendInboxMessage
# body param: body
echo '{"userIds": ["edl5Ewh3jDayYStU", "iBB1yz3iP8gH88Ue", "nlMVzIOP8NOf91Ls"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnsendInboxMessage \
    --inbox 'D7cWWOgAs8ThMpAG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminUnsendInboxMessage' test.out

#- 45 AdminGetInboxUsers
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxUsers \
    --inbox 'IapYftYZkBXiEhdi' \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '16' \
    --status 'UNREAD' \
    --userId 'VBAEUvoBlbH02bob' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetInboxUsers' test.out

#- 46 AdminUpdateInboxMessage
# body param: body
echo '{"expiredAt": 49, "message": {"yv5PoMJeTIQix1FE": {}, "vzlipE7r0vhh21v5": {}, "772AopmjI7CbY2Wu": {}}, "scope": "USER", "userIds": ["GmFy7w6eqnMeKFo7", "U8Scr9xm68w7s9RM", "x2hc45QX234xnqlb"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxMessage \
    --messageId 'RAPFQsca6n9vGZTC' \
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
    --messageId 'CXQ2Lf7jtexB613c' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminSendInboxMessage' test.out

#- 48 AdminGetInboxStats
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxStats \
    --namespace $AB_NAMESPACE \
    --messageId '["biJEUePVZQaoEY2z", "rpLuvrx96OOz45vM", "iR3QYZJKVNlK8PTa"]' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetInboxStats' test.out

#- 49 AdminGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminGetChatSnapshot \
    --chatId 'IXRWFTyA9MDnKGXq' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'AdminGetChatSnapshot' test.out

#- 50 AdminDeleteChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChatSnapshot \
    --chatId 'q7Zk705hOhenJi6d' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteChatSnapshot' test.out

#- 51 AdminProfanityQuery
$CLI_EXE \
    --sn chat \
    --op AdminProfanityQuery \
    --namespace $AB_NAMESPACE \
    --filterMask 'NVF7zwjXqlcD2Lza' \
    --includeChildren 'true' \
    --limit '44' \
    --offset '70' \
    --parentId 'qYKc56PcPSL2xmjV' \
    --startWith 'iKkKw4gHA4CaLsPq' \
    --wordType 'RsTdKzcKtkGcvn44' \
    > test.out 2>&1
eval_tap $? 51 'AdminProfanityQuery' test.out

#- 52 AdminProfanityCreate
# body param: body
echo '{"falseNegative": ["NWse6VLPkM1VTrQB", "ywhJ7lbBLw9xy1WQ", "M5qUS8baUqkzSr41"], "falsePositive": ["y6RPBHJuPjj8zDwO", "k0IgmYfUTpFzyQhP", "VhRGX9xlUKhXI8mL"], "word": "8OIhvP68xE68dzoh", "wordType": "xhbej2caIIfkXDY7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminProfanityCreate' test.out

#- 53 AdminProfanityCreateBulk
# body param: body
echo '{"dictionaries": [{"falseNegative": ["jnhp3qY6T7TUEBot", "SNIwGhia6cqoWmnh", "tuzxir12r0VUWI0k"], "falsePositive": ["JAczj5ApcsiEQ65l", "lgGnTHAsTCZa7xE4", "nwGKlbPRxfucxoRK"], "word": "FLxxcL9SyuHbvRxR", "wordType": "6LaKWgAVjZKDxiez"}, {"falseNegative": ["EbuMCz9J4dPRGzoQ", "LYIWPPZvyPupimCE", "NHEenqjRSxO9oZ0f"], "falsePositive": ["CxLR0GfjwCmDrbDR", "0Q0ixpqYtkZuhL6q", "bAhRExsnbWSH45La"], "word": "rTmOqto4OtwF9uPU", "wordType": "AxerdIqWmOoMyYp2"}, {"falseNegative": ["tSrLxpJnj9JtgjWm", "jx1WuNQq4v8FnVzd", "bNW1xuV7rVei1o9z"], "falsePositive": ["V6rhVfcQmLfEn5ZU", "GeYlOwODWBAz6skH", "Mfl4Hjw9KEnx8cNf"], "word": "DK45zWtwYhRoNPwK", "wordType": "ema6caMTOcivPAkm"}]}' > $TEMP_JSON_INPUT
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
    --limit '84' \
    --offset '55' \
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
    --showResult 'false' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'AdminProfanityImport' test.out

#- 57 AdminProfanityUpdate
# body param: body
echo '{"falseNegative": ["NT7JTRFV3FxMl5Rw", "4YeHqWkG09iEAFYW", "how1WAwCs9Y0KOem"], "falsePositive": ["hNPYUVA9mU8UvONy", "jv3GQuLHoQ6ehLLK", "5h1bE9WU6w3tjUhS"], "word": "CKySPY7yMGOuQOfx", "wordType": "6HIFfwBBqG51RaZY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityUpdate \
    --id '74CqdvfPAIaPEkCI' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminProfanityUpdate' test.out

#- 58 AdminProfanityDelete
$CLI_EXE \
    --sn chat \
    --op AdminProfanityDelete \
    --id 'XX7WQ3ytABCzYWxY' \
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
    --chatId 'bbphuiQPU0aS2OIp' \
    --namespace $AB_NAMESPACE \
    --topic '0B2FWiDu7POaotJo' \
    > test.out 2>&1
eval_tap $? 60 'PublicGetChatSnapshot' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE