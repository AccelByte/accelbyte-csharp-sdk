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
echo "1..62"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminFilterChatMessage
# body param: body
echo '{"message": "bBuz5zkoaUEzGS3q", "timestamp": 12, "topicId": "MLqpQwkRRHkaiKsm", "topicType": "PERSONAL", "userId": "iRLR3IlNJKxhPfWV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminFilterChatMessage \
    --namespace $AB_NAMESPACE \
    --detail 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminFilterChatMessage' test.out

#- 3 AdminChatHistory
$CLI_EXE \
    --sn chat \
    --op AdminChatHistory \
    --namespace $AB_NAMESPACE \
    --chatId '["dIabcFbSmeuIBroF", "7bwRgwKvzESbhpxl", "DdEs4igdKeLmy8tZ"]' \
    --endCreatedAt '92' \
    --keyword 'GZi5P12c61ts3fMI' \
    --limit '5' \
    --offset '42' \
    --order 'rm2jUc9iav3tTqlE' \
    --senderUserId '9oLDPD0Lfle8ESU1' \
    --shardId 'MO8XnVaEyjmifJDY' \
    --startCreatedAt '1' \
    --topic '["4TsbQsxYFxGGHrfQ", "kgXkiA5IZPqCqp9v", "cyt67WAfWXfUfwGB"]' \
    > test.out 2>&1
eval_tap $? 3 'AdminChatHistory' test.out

#- 4 AdminCreateNamespaceTopic
# body param: body
echo '{"description": "03tz8qIH4uRdNO08", "name": "HN6s9p8Y5c9eItJt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateNamespaceTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AdminCreateNamespaceTopic' test.out

#- 5 AdminTopicList
$CLI_EXE \
    --sn chat \
    --op AdminTopicList \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --offset '57' \
    --topicType 'NmY3y3n2Rim4NBqh' \
    > test.out 2>&1
eval_tap $? 5 'AdminTopicList' test.out

#- 6 AdminCreateTopic
# body param: body
echo '{"admins": ["uNtj8FOvKZjs1tLp", "ERf77LzPoORBkRmZ", "0A2zyZsb4FvWFIHP"], "description": "IbOjpls9BZTYc5Bs", "isChannel": false, "isJoinable": false, "members": ["SSVaAzzn4GbgkKeC", "aS6qyUCscHXs8PlO", "BlfUOqv7WmCuqcsN"], "name": "M7YAnbq4DjmYUMhD", "shardLimit": 43, "type": "qU89D356pVsUtNan"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminCreateTopic' test.out

#- 7 AdminChannelTopicList
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicList \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --offset '35' \
    --topicName 'dzgwxYdQc5hEfefd' \
    > test.out 2>&1
eval_tap $? 7 'AdminChannelTopicList' test.out

#- 8 AdminChannelTopicSummary
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicSummary \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminChannelTopicSummary' test.out

#- 9 AdminQueryTopicLog
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopicLog \
    --namespace $AB_NAMESPACE \
    --endCreatedAt '29' \
    --limit '88' \
    --offset '32' \
    --senderUserId 'Cahcox63cyDxAAYc' \
    --startCreatedAt '89' \
    --topicId '3osbh0fL2h7eJvAS' \
    --topicIds '["2W4uqkhwSC7EajwH", "O3LfvwPewrf19Njm", "50xCDlPeNq0CvMXt"]' \
    --userId 'yUWXrdZaFeacGT2x' \
    > test.out 2>&1
eval_tap $? 9 'AdminQueryTopicLog' test.out

#- 10 AdminUpdateTopic
# body param: body
echo '{"description": "6o28Njxyw7RHldq0", "isJoinable": false, "name": "CQpMJj5igqat8xnP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateTopic \
    --namespace $AB_NAMESPACE \
    --topic 'oWTdHAkcyAy4drHl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateTopic' test.out

#- 11 AdminDeleteTopic
$CLI_EXE \
    --sn chat \
    --op AdminDeleteTopic \
    --namespace $AB_NAMESPACE \
    --topic 'PcXGGl0Xw3veBfrp' \
    > test.out 2>&1
eval_tap $? 11 'AdminDeleteTopic' test.out

#- 12 AdminBanTopicMembers
# body param: body
echo '{"userIds": ["CrnbaxhEvn3SGqcH", "91fC3aJEoqWaFAGD", "6PRg95m07l03vtlM"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'FzeiMRkcOr1L0TMI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminBanTopicMembers' test.out

#- 13 AdminChannelTopicInfo
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicInfo \
    --namespace $AB_NAMESPACE \
    --topic 'czbYilOziwG8CPLO' \
    > test.out 2>&1
eval_tap $? 13 'AdminChannelTopicInfo' test.out

#- 14 AdminTopicChatHistory
eval_tap 0 14 'AdminTopicChatHistory # SKIP deprecated' test.out

#- 15 AdminSendChat
# body param: body
echo '{"message": "zSZm9K3cMY617HSC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendChat \
    --namespace $AB_NAMESPACE \
    --topic 'YZaL46I3PgCcQ0ax' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminSendChat' test.out

#- 16 AdminDeleteChat
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChat \
    --chatId 'TWnmyEYLZQTpvLH6' \
    --namespace $AB_NAMESPACE \
    --topic 'QPEBP8kSSFjeuL3w' \
    > test.out 2>&1
eval_tap $? 16 'AdminDeleteChat' test.out

#- 17 AdminTopicMembers
$CLI_EXE \
    --sn chat \
    --op AdminTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'QQPYwmYFbxRvHYDC' \
    --isBanned 'true' \
    --isModerator 'false' \
    --limit '67' \
    --offset '99' \
    --shardId 'dmzXgf1ewUTvnu0e' \
    > test.out 2>&1
eval_tap $? 17 'AdminTopicMembers' test.out

#- 18 AdminTopicShards
$CLI_EXE \
    --sn chat \
    --op AdminTopicShards \
    --namespace $AB_NAMESPACE \
    --topic 'nsa3MZF7DTswnkSy' \
    > test.out 2>&1
eval_tap $? 18 'AdminTopicShards' test.out

#- 19 AdminUnbanTopicMembers
# body param: body
echo '{"userIds": ["uJTVjKQ1ORLEIAeP", "vDO2xkVgyRk10b27", "RdU8VceYQ9erPYQ5"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'yVcQuvDbGMqbEHkC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUnbanTopicMembers' test.out

#- 20 AdminAddTopicMember
# body param: body
echo '{"isAdmin": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'wMBcQUNPHN8YZT0y' \
    --userId 'JJ0uCjjaNCRV3hSI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminAddTopicMember' test.out

#- 21 AdminRemoveTopicMember
$CLI_EXE \
    --sn chat \
    --op AdminRemoveTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'iTEoTCSxjAqg9oGV' \
    --userId 'EdC8mQir1Af0G6Or' \
    > test.out 2>&1
eval_tap $? 21 'AdminRemoveTopicMember' test.out

#- 22 AdminQueryTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopic \
    --namespace $AB_NAMESPACE \
    --includeMembers 'false' \
    --includePastMembers 'true' \
    --includePastTopics 'true' \
    --limit '38' \
    --offset '78' \
    --topic '["jpPgHKISHtB8tWdJ", "M9Qc5HmR0vknXO45", "AUtNXSTItt35OJTf"]' \
    --topicSubType 'SESSION' \
    --topicType 'PERSONAL' \
    --userId 'BZX62yI9g5RDrlzP' \
    > test.out 2>&1
eval_tap $? 22 'AdminQueryTopic' test.out

#- 23 AdminQueryUsersTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryUsersTopic \
    --namespace $AB_NAMESPACE \
    --userId 'FQmNu3ERxV0UTaiS' \
    --includePastTopics 'true' \
    --limit '16' \
    --offset '10' \
    --topicSubType 'NAMESPACE' \
    --topicType 'GROUP' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryUsersTopic' test.out

#- 24 PublicGetMutedTopics
$CLI_EXE \
    --sn chat \
    --op PublicGetMutedTopics \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'PublicGetMutedTopics' test.out

#- 25 PublicTopicList
$CLI_EXE \
    --sn chat \
    --op PublicTopicList \
    --namespace $AB_NAMESPACE \
    --limit '25' \
    --offset '64' \
    --topicType 'WZjTYM95e4aa8xOJ' \
    > test.out 2>&1
eval_tap $? 25 'PublicTopicList' test.out

#- 26 PublicBanTopicMembers
# body param: body
echo '{"userIDs": ["u7rNRVdygfKmUkzj", "9mHFpff2vDkz68zo", "rEgcExv9nKMOgO5W"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic '8SUaZjCpNtJSMm8k' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PublicBanTopicMembers' test.out

#- 27 PublicChatHistory
$CLI_EXE \
    --sn chat \
    --op PublicChatHistory \
    --namespace $AB_NAMESPACE \
    --topic 'Di3Rwubq7wtRGdT4' \
    --limit '2' \
    --order '7Oa51m6VLfjsw270' \
    --startCreatedAt '32' \
    > test.out 2>&1
eval_tap $? 27 'PublicChatHistory' test.out

#- 28 PublicDeleteChat
$CLI_EXE \
    --sn chat \
    --op PublicDeleteChat \
    --chatId 'UuNlT86N9yO0vyD6' \
    --namespace $AB_NAMESPACE \
    --topic 'J5brVo20e6POTjri' \
    > test.out 2>&1
eval_tap $? 28 'PublicDeleteChat' test.out

#- 29 PublicMuteUser
# body param: body
echo '{"duration": 27, "userId": "pJLtEZjuyFhvbxX2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicMuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'DNbknfVv4nm70TCa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'PublicMuteUser' test.out

#- 30 PublicUnbanTopicMembers
# body param: body
echo '{"userIDs": ["yYAkF18YBwRxcREy", "U5CwqGJF6nDi33Iz", "tr2QcwlRrReRajlp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'k8lfuiJVcktlx9zJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicUnbanTopicMembers' test.out

#- 31 PublicUnmuteUser
# body param: body
echo '{"userId": "ZVVCc9bpIHEWQMmC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnmuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'kIqwqpoTVCNrcaVo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicUnmuteUser' test.out

#- 32 AdminGetAllConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 32 'AdminGetAllConfigV1' test.out

#- 33 AdminGetConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'AdminGetConfigV1' test.out

#- 34 AdminUpdateConfigV1
# body param: body
echo '{"chatRateLimitBurst": 52, "chatRateLimitDuration": 66, "concurrentUsersLimit": 39, "enableClanChat": false, "enableManualTopicCreation": true, "enableProfanityFilter": true, "filterAppName": "O2EUsAfBvo6Llcal", "filterParam": "ks2R3VMtipTVxXAF", "filterType": "8KhOKqbrECijFxOp", "generalRateLimitBurst": 83, "generalRateLimitDuration": 77, "maxChatMessageLength": 52, "shardCapacityLimit": 18, "shardDefaultLimit": 47, "shardHardLimit": 9, "spamChatBurst": 6, "spamChatDuration": 93, "spamMuteDuration": 46}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminUpdateConfigV1' test.out

#- 35 ExportConfig
$CLI_EXE \
    --sn chat \
    --op ExportConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'ExportConfig' test.out

#- 36 ImportConfig
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op ImportConfig \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 36 'ImportConfig' test.out

#- 37 AdminGetInboxCategories
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxCategories \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'AdminGetInboxCategories' test.out

#- 38 AdminAddInboxCategory
# body param: body
echo '{"enabled": true, "expiresIn": 13, "hook": {"driver": "cTEzXaXUzpsAV6ct", "params": {"6XITL0QEkadMSQlu": {}, "AoED9oYwS8oLyErK": {}, "vRtHFGJRoGW7VBG1": {}}}, "jsonSchema": {"VB2sp2x9mszGGoyh": {}, "GZAzt2OVBTLwSH8h": {}, "WRU9pbItGQ7VUWBh": {}}, "name": "GolwafIfbF1GLFnr", "saveInbox": true, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddInboxCategory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'AdminAddInboxCategory' test.out

#- 39 AdminDeleteInboxCategory
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxCategory \
    --category 'T5cmw7U1TxiS06UE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'AdminDeleteInboxCategory' test.out

#- 40 AdminUpdateInboxCategory
# body param: body
echo '{"enabled": false, "expiresIn": 98, "hook": {"driver": "aDZpXOWzpXOi2cpa", "params": {"jtqcXjPkj2IzU3ME": {}, "pCt1IjlfHJM92t9j": {}, "1XT2ErwIxkaTnYtr": {}}}, "jsonSchema": {"1YDnaXB0JOS4XKVT": {}, "66sHYPgVsfhoEidK": {}, "w4IP0NVnaangorhV": {}}, "saveInbox": true, "sendNotification": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxCategory \
    --category 'PQwl9dVfJQGkDR00' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminUpdateInboxCategory' test.out

#- 41 AdminGetCategorySchema
$CLI_EXE \
    --sn chat \
    --op AdminGetCategorySchema \
    --category 'ofXsbnEzHiRs0NmG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 41 'AdminGetCategorySchema' test.out

#- 42 AdminDeleteInboxMessage
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxMessage \
    --messageId 'hxv1vuN7Xv6OuG6R' \
    --namespace $AB_NAMESPACE \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 42 'AdminDeleteInboxMessage' test.out

#- 43 AdminGetInboxMessages
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxMessages \
    --namespace $AB_NAMESPACE \
    --activeOnly 'false' \
    --endCreatedAt '15' \
    --limit '78' \
    --messageId '["8RblvnfNiABRf1gd", "XM7QlAlnjAfgxOdZ", "df9tLHO1qrNyhmUE"]' \
    --offset '53' \
    --order 'laznetBUGcQz2Wvd' \
    --scope 'NAMESPACE' \
    --startCreatedAt '13' \
    --status 'DRAFT' \
    --transient 'true' \
    > test.out 2>&1
eval_tap $? 43 'AdminGetInboxMessages' test.out

#- 44 AdminSaveInboxMessage
# body param: body
echo '{"category": "lkYGDL2ckC9cdzaL", "expiredAt": 28, "message": {"qU4hCv5egSQDePKS": {}, "ZKp6zwDQS1atvJrA": {}, "LaiplJgRhedl5Ewh": {}}, "scope": "NAMESPACE", "status": "SENT", "userIds": ["cgjHQo9HoLLyUnPT", "iCD0038or8wR0tuw", "IJnrSI2IFcRwSoMT"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSaveInboxMessage \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminSaveInboxMessage' test.out

#- 45 AdminUnsendInboxMessage
# body param: body
echo '{"userIds": ["uJziuDNbOydiu3lO", "aruuYw0iUuts6bCh", "MK1gcx8p9fyv5PoM"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnsendInboxMessage \
    --inbox 'JeTIQix1FEvzlipE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'AdminUnsendInboxMessage' test.out

#- 46 AdminGetInboxUsers
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxUsers \
    --inbox '7r0vhh21v5772Aop' \
    --namespace $AB_NAMESPACE \
    --limit '26' \
    --offset '28' \
    --status 'READ' \
    --userId '25C1zEnAMGmFy7w6' \
    > test.out 2>&1
eval_tap $? 46 'AdminGetInboxUsers' test.out

#- 47 AdminUpdateInboxMessage
# body param: body
echo '{"expiredAt": 9, "message": {"gC4mJ5OHuNEVQK4M": {}, "vk00I9GqAhhjNIiv": {}, "dIcaEQfNETQCBPK1": {}}, "scope": "NAMESPACE", "userIds": ["6n9vGZTCCXQ2Lf7j", "texB613cbiJEUePV", "ZQaoEY2zrpLuvrx9"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxMessage \
    --messageId '6OOz45vMiR3QYZJK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminUpdateInboxMessage' test.out

#- 48 AdminSendInboxMessage
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendInboxMessage \
    --messageId 'VNlK8PTaIXRWFTyA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'AdminSendInboxMessage' test.out

#- 49 AdminGetInboxStats
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxStats \
    --namespace $AB_NAMESPACE \
    --messageId '["9MDnKGXqq7Zk705h", "OhenJi6dNVF7zwjX", "qlcD2LzaOwIF5tEs"]' \
    > test.out 2>&1
eval_tap $? 49 'AdminGetInboxStats' test.out

#- 50 AdminGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminGetChatSnapshot \
    --chatId 'CwoAVcZCSj80gzFv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'AdminGetChatSnapshot' test.out

#- 51 AdminDeleteChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChatSnapshot \
    --chatId 'pvIerFEyxTugoTd5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'AdminDeleteChatSnapshot' test.out

#- 52 AdminProfanityQuery
$CLI_EXE \
    --sn chat \
    --op AdminProfanityQuery \
    --namespace $AB_NAMESPACE \
    --filterMask '0RmJFX9v4GPfyGuQ' \
    --includeChildren 'true' \
    --limit '21' \
    --offset '23' \
    --parentId 'M1VTrQBywhJ7lbBL' \
    --startWith 'w9xy1WQM5qUS8baU' \
    --wordType 'qkzSr41y6RPBHJuP' \
    > test.out 2>&1
eval_tap $? 52 'AdminProfanityQuery' test.out

#- 53 AdminProfanityCreate
# body param: body
echo '{"falseNegative": ["jj8zDwOk0IgmYfUT", "pFzyQhPVhRGX9xlU", "KhXI8mL8OIhvP68x"], "falsePositive": ["E68dzohxhbej2caI", "IfkXDY7jnhp3qY6T", "7TUEBotSNIwGhia6"], "word": "cqoWmnhtuzxir12r", "wordType": "0VUWI0kJAczj5Apc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminProfanityCreate' test.out

#- 54 AdminProfanityCreateBulk
# body param: body
echo '{"dictionaries": [{"falseNegative": ["siEQ65llgGnTHAsT", "CZa7xE4nwGKlbPRx", "fucxoRKFLxxcL9Sy"], "falsePositive": ["uHbvRxR6LaKWgAVj", "ZKDxiezEbuMCz9J4", "dPRGzoQLYIWPPZvy"], "word": "PupimCENHEenqjRS", "wordType": "xO9oZ0fCxLR0Gfjw"}, {"falseNegative": ["CmDrbDR0Q0ixpqYt", "kZuhL6qbAhRExsnb", "WSH45LarTmOqto4O"], "falsePositive": ["twF9uPUAxerdIqWm", "OoMyYp2tSrLxpJnj", "9JtgjWmjx1WuNQq4"], "word": "v8FnVzdbNW1xuV7r", "wordType": "Vei1o9zV6rhVfcQm"}, {"falseNegative": ["LfEn5ZUGeYlOwODW", "BAz6skHMfl4Hjw9K", "Enx8cNfDK45zWtwY"], "falsePositive": ["hRoNPwKema6caMTO", "civPAkmP8Awb0Nqt", "vSR9q6l5k9BLQMrP"], "word": "oTuxdzEYAw5VdW05", "wordType": "WnQEAbK416LN2N6D"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreateBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AdminProfanityCreateBulk' test.out

#- 55 AdminProfanityExport
$CLI_EXE \
    --sn chat \
    --op AdminProfanityExport \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'AdminProfanityExport' test.out

#- 56 AdminProfanityGroup
$CLI_EXE \
    --sn chat \
    --op AdminProfanityGroup \
    --namespace $AB_NAMESPACE \
    --limit '98' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 56 'AdminProfanityGroup' test.out

#- 57 AdminProfanityImport
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
eval_tap $? 57 'AdminProfanityImport' test.out

#- 58 AdminProfanityUpdate
# body param: body
echo '{"falseNegative": ["9mU8UvONyjv3GQuL", "HoQ6ehLLK5h1bE9W", "U6w3tjUhSCKySPY7"], "falsePositive": ["yMGOuQOfx6HIFfwB", "BqG51RaZY74Cqdvf", "PAIaPEkCIXX7WQ3y"], "word": "tABCzYWxYbbphuiQ", "wordType": "PU0aS2OIp0B2FWiD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityUpdate \
    --id 'u7POaotJoQQyL1bC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'AdminProfanityUpdate' test.out

#- 59 AdminProfanityDelete
$CLI_EXE \
    --sn chat \
    --op AdminProfanityDelete \
    --id 'DNisOhjEKFWmj7io' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 59 'AdminProfanityDelete' test.out

#- 60 PublicGetMessages
$CLI_EXE \
    --sn chat \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 60 'PublicGetMessages' test.out

#- 61 PublicGetConfigV1
$CLI_EXE \
    --sn chat \
    --op PublicGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'PublicGetConfigV1' test.out

#- 62 PublicGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op PublicGetChatSnapshot \
    --chatId 'i5WZ6ZymQeVSZZma' \
    --namespace $AB_NAMESPACE \
    --topic '57V6b9uLloAA9Koe' \
    > test.out 2>&1
eval_tap $? 62 'PublicGetChatSnapshot' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE