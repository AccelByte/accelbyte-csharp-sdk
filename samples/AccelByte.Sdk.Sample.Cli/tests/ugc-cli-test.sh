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
echo "1..91"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 SingleAdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetChannel \
    --namespace $AB_NAMESPACE \
    --limit '0' \
    --offset '22' \
    > test.out 2>&1
eval_tap $? 2 'SingleAdminGetChannel' test.out

#- 3 AdminCreateChannel
# body param: body
echo '{"name": "dtaM5ROz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateChannel \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChannel' test.out

#- 4 SingleAdminUpdateChannel
# body param: body
echo '{"name": "5ku6tGbA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateChannel \
    --channelId 'AifIYJ9p' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'SingleAdminUpdateChannel' test.out

#- 5 SingleAdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteChannel \
    --channelId 'oSIlSzLb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'SingleAdminDeleteChannel' test.out

#- 6 AdminUploadContentDirect
eval_tap 0 6 'AdminUploadContentDirect # SKIP deprecated' test.out

#- 7 AdminUploadContentS3
# body param: body
echo '{"contentType": "HifXLTuc", "fileExtension": "GGNG2Bus", "name": "j91RTzvT", "preview": "07jBwONu", "previewMetadata": {"previewContentType": "z5KUv5JU", "previewFileExtension": "xdfRYdqq"}, "subType": "L7FnrqS5", "tags": ["kxqpk494", "1DK24s4l", "Ls4QYH6y"], "type": "JlS82cpL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentS3 \
    --channelId 'KMw2m3qU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUploadContentS3' test.out

#- 8 SingleAdminUpdateContentS3
# body param: body
echo '{"contentType": "piTgyt2K", "fileExtension": "qGqkUbL6", "name": "YnwO0354", "preview": "7yknuCnJ", "previewMetadata": {"previewContentType": "4w0bX1iQ", "previewFileExtension": "5YPuFeUc"}, "subType": "bkgdt2Ue", "tags": ["0Xo3zXGU", "mt7Pf0nv", "XejWJodF"], "type": "mFkwNFca"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateContentS3 \
    --channelId 'v3BfaZG1' \
    --contentId 'z138UcvV' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'SingleAdminUpdateContentS3' test.out

#- 9 AdminSearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchChannelSpecificContent \
    --channelId 'zU5sev7L' \
    --namespace $AB_NAMESPACE \
    --creator 'iCDdQY6u' \
    --isofficial 'OFl0zomA' \
    --limit '48' \
    --name 'RkFrjPxJ' \
    --offset '11' \
    --orderby 'MtuKiesD' \
    --sortby 'LnW2D2mA' \
    --subtype 'YKfys3Yv' \
    --tags '["F53q74vT", "ntYXgyL1", "26sBinmu"]' \
    --type '3Z0AbRXd' \
    --userId 'kAopebcd' \
    > test.out 2>&1
eval_tap $? 9 'AdminSearchChannelSpecificContent' test.out

#- 10 SingleAdminUpdateContentDirect
eval_tap 0 10 'SingleAdminUpdateContentDirect # SKIP deprecated' test.out

#- 11 SingleAdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteContent \
    --channelId 'dzD8tPiM' \
    --contentId 'z5o82KmF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'SingleAdminDeleteContent' test.out

#- 12 SingleAdminGetContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetContent \
    --namespace $AB_NAMESPACE \
    --limit '59' \
    --offset '61' \
    > test.out 2>&1
eval_tap $? 12 'SingleAdminGetContent' test.out

#- 13 AdminSearchContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'gNNx2roF' \
    --isofficial 'GZibFnYQ' \
    --limit '87' \
    --name 'PC0BpAYy' \
    --offset '17' \
    --orderby 'jokzV7ya' \
    --sortby 'DNMk7l7B' \
    --subtype 'x8Dp58dC' \
    --tags '["w8IF7yOx", "Cu1BwBIb", "qBBISCVl"]' \
    --type 'nxO3bQJ8' \
    --userId 'uaiXyrKZ' \
    > test.out 2>&1
eval_tap $? 13 'AdminSearchContent' test.out

#- 14 AdminGetUserContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op AdminGetUserContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'yMDZd13R' \
    > test.out 2>&1
eval_tap $? 14 'AdminGetUserContentByShareCode' test.out

#- 15 AdminGetSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetSpecificContent \
    --contentId 'UfaZczFs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminGetSpecificContent' test.out

#- 16 AdminDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op AdminDownloadContentPreview \
    --contentId '8keIaaEN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminDownloadContentPreview' test.out

#- 17 AdminUpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "R7f9Atsb", "screenshotId": "jXxWbEMK"}, {"description": "w9JgycrR", "screenshotId": "H2bzWs9M"}, {"description": "EQjqFLXy", "screenshotId": "bm5WgFDp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateScreenshots \
    --contentId 't8HgOwdr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateScreenshots' test.out

#- 18 AdminUploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "Xzcw1DB6", "description": "UgEBE8TK", "fileExtension": "pjp"}, {"contentType": "KTzCiUnj", "description": "1B1LdAMg", "fileExtension": "png"}, {"contentType": "JC8pMqXF", "description": "HiGdTc6x", "fileExtension": "pjp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentScreenshot \
    --contentId 'CLRJXC5I' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUploadContentScreenshot' test.out

#- 19 AdminDeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContentScreenshot \
    --contentId 'AhX2vD3F' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'QCtvv64g' \
    > test.out 2>&1
eval_tap $? 19 'AdminDeleteContentScreenshot' test.out

#- 20 SingleAdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --limit '17' \
    --offset '80' \
    > test.out 2>&1
eval_tap $? 20 'SingleAdminGetAllGroups' test.out

#- 21 AdminCreateGroup
# body param: body
echo '{"contents": ["Xje0huW2", "rn3tmaC4", "qPdTw14G"], "name": "IJSyJNgZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminCreateGroup' test.out

#- 22 SingleAdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroup \
    --groupId 'JmADfSI6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'SingleAdminGetGroup' test.out

#- 23 SingleAdminUpdateGroup
# body param: body
echo '{"contents": ["9grRWmaH", "1U1As7BD", "i1FreZlO"], "name": "AA2VzDdJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateGroup \
    --groupId 'HqFyPwn1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'SingleAdminUpdateGroup' test.out

#- 24 SingleAdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteGroup \
    --groupId 'h3UNjsr0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'SingleAdminDeleteGroup' test.out

#- 25 SingleAdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroupContents \
    --groupId '1AMb7FwL' \
    --namespace $AB_NAMESPACE \
    --limit '84' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 25 'SingleAdminGetGroupContents' test.out

#- 26 AdminGetTag
$CLI_EXE \
    --sn ugc \
    --op AdminGetTag \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    --offset '25' \
    > test.out 2>&1
eval_tap $? 26 'AdminGetTag' test.out

#- 27 AdminCreateTag
# body param: body
echo '{"tag": "nmIV6Zne"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminCreateTag' test.out

#- 28 AdminUpdateTag
# body param: body
echo '{"tag": "Aivy26i5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateTag \
    --namespace $AB_NAMESPACE \
    --tagId 'DxbHGDZL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminUpdateTag' test.out

#- 29 AdminDeleteTag
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagId '2r1lIIh6' \
    > test.out 2>&1
eval_tap $? 29 'AdminDeleteTag' test.out

#- 30 AdminGetType
$CLI_EXE \
    --sn ugc \
    --op AdminGetType \
    --namespace $AB_NAMESPACE \
    --limit '97' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 30 'AdminGetType' test.out

#- 31 AdminCreateType
# body param: body
echo '{"subtype": ["Ymh0Vo2N", "k3feF27I", "F4V785vu"], "type": "pw736724"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminCreateType' test.out

#- 32 AdminUpdateType
# body param: body
echo '{"subtype": ["PWc3528s", "YwZs8bie", "I90pdmjU"], "type": "WuEzleFQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateType \
    --namespace $AB_NAMESPACE \
    --typeId 'bYRKLbAH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AdminUpdateType' test.out

#- 33 AdminDeleteType
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteType \
    --namespace $AB_NAMESPACE \
    --typeId 'no7COIQt' \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteType' test.out

#- 34 AdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op AdminGetChannel \
    --namespace $AB_NAMESPACE \
    --userId '6FMI7tli' \
    --limit '82' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 34 'AdminGetChannel' test.out

#- 35 AdminDeleteAllUserChannels
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserChannels \
    --namespace $AB_NAMESPACE \
    --userId 'u1JEwJuH' \
    > test.out 2>&1
eval_tap $? 35 'AdminDeleteAllUserChannels' test.out

#- 36 AdminUpdateChannel
# body param: body
echo '{"name": "JJ4NaIZD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateChannel \
    --channelId 'fFPY9O0T' \
    --namespace $AB_NAMESPACE \
    --userId 'sFJ62oWe' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AdminUpdateChannel' test.out

#- 37 AdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteChannel \
    --channelId 'uLS9qSTd' \
    --namespace $AB_NAMESPACE \
    --userId 'UQJg3Hon' \
    > test.out 2>&1
eval_tap $? 37 'AdminDeleteChannel' test.out

#- 38 AdminUpdateContentS3
# body param: body
echo '{"contentType": "522tqsVd", "fileExtension": "qpavJ23s", "name": "hRZ6jYfg", "preview": "DNj363nW", "previewMetadata": {"previewContentType": "Vp31oqsl", "previewFileExtension": "wnNUt904"}, "subType": "phRuzjuy", "tags": ["oYwciJWs", "degwIZQd", "khZQgoDX"], "type": "tkEnMESf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateContentS3 \
    --channelId 'SVpJ9nTz' \
    --contentId 'KkdpXLJe' \
    --namespace $AB_NAMESPACE \
    --userId 'LiyTzwhT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'AdminUpdateContentS3' test.out

#- 39 AdminUpdateContentDirect
eval_tap 0 39 'AdminUpdateContentDirect # SKIP deprecated' test.out

#- 40 AdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContent \
    --channelId '9hjNGKuS' \
    --contentId 'qpZ1tygl' \
    --namespace $AB_NAMESPACE \
    --userId 'Xvt2yVAj' \
    > test.out 2>&1
eval_tap $? 40 'AdminDeleteContent' test.out

#- 41 AdminGetContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetContent \
    --namespace $AB_NAMESPACE \
    --userId 'O3fM8EV5' \
    --limit '63' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 41 'AdminGetContent' test.out

#- 42 AdminDeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId 'eNTQXWXs' \
    > test.out 2>&1
eval_tap $? 42 'AdminDeleteAllUserContents' test.out

#- 43 AdminHideUserContent
# body param: body
echo '{"isHidden": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminHideUserContent \
    --contentId 'xe74jk5q' \
    --namespace $AB_NAMESPACE \
    --userId 'IkPDgvp5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminHideUserContent' test.out

#- 44 AdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op AdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --userId 'UndH9bCx' \
    --limit '55' \
    --offset '86' \
    > test.out 2>&1
eval_tap $? 44 'AdminGetAllGroups' test.out

#- 45 AdminDeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId '2Aa2dLlf' \
    > test.out 2>&1
eval_tap $? 45 'AdminDeleteAllUserGroup' test.out

#- 46 AdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroup \
    --groupId '0bKijsVP' \
    --namespace $AB_NAMESPACE \
    --userId 'hteUm2NC' \
    > test.out 2>&1
eval_tap $? 46 'AdminGetGroup' test.out

#- 47 AdminUpdateGroup
# body param: body
echo '{"contents": ["tpQOZctQ", "k9013oeK", "i9uXsoxd"], "name": "d1jUOjLr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateGroup \
    --groupId 'xrErxJYM' \
    --namespace $AB_NAMESPACE \
    --userId '622bIFW9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminUpdateGroup' test.out

#- 48 AdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteGroup \
    --groupId 'Qq744bR6' \
    --namespace $AB_NAMESPACE \
    --userId 'bPm4wjMg' \
    > test.out 2>&1
eval_tap $? 48 'AdminDeleteGroup' test.out

#- 49 AdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroupContents \
    --groupId 'WPPANdaM' \
    --namespace $AB_NAMESPACE \
    --userId 'bv7uhFp3' \
    --limit '24' \
    --offset '62' \
    > test.out 2>&1
eval_tap $? 49 'AdminGetGroupContents' test.out

#- 50 AdminDeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId '24PIu5dd' \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteAllUserStates' test.out

#- 51 SearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op SearchChannelSpecificContent \
    --channelId 'Ig30bZG2' \
    --namespace $AB_NAMESPACE \
    --creator '7YhJMnpN' \
    --isofficial 'jHN2TGRl' \
    --limit '99' \
    --name 'pNoSDqBc' \
    --offset '27' \
    --orderby 'p6JFbSpL' \
    --sortby 'mp8A2iOW' \
    --subtype 'isqGxAPa' \
    --tags '["R4AsLSXc", "MH1MGL4k", "Jdl06orD"]' \
    --type 'l7rpt62D' \
    --userId 'RhtM5mrl' \
    > test.out 2>&1
eval_tap $? 51 'SearchChannelSpecificContent' test.out

#- 52 PublicSearchContent
$CLI_EXE \
    --sn ugc \
    --op PublicSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'qQkLQXbY' \
    --isofficial 'TC6WWvDD' \
    --limit '4' \
    --name 'fQj6aaTz' \
    --offset '86' \
    --orderby 'FCzpH4KJ' \
    --sortby '2vTclKzU' \
    --subtype 'FNvmBn1X' \
    --tags '["abZgciaW", "wRqRXycw", "oEgfJDyZ"]' \
    --type '4nWsxDus' \
    --userId 'UuMJBqD9' \
    > test.out 2>&1
eval_tap $? 52 'PublicSearchContent' test.out

#- 53 PublicGetContentBulk
# body param: body
echo '{"contentIds": ["tbV7obxn", "hSP50oUd", "So1r9Lvi"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op PublicGetContentBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'PublicGetContentBulk' test.out

#- 54 GetFollowedContent
$CLI_EXE \
    --sn ugc \
    --op GetFollowedContent \
    --namespace $AB_NAMESPACE \
    --limit '70' \
    --offset '40' \
    > test.out 2>&1
eval_tap $? 54 'GetFollowedContent' test.out

#- 55 GetLikedContent
$CLI_EXE \
    --sn ugc \
    --op GetLikedContent \
    --namespace $AB_NAMESPACE \
    --isofficial 'false' \
    --limit '7' \
    --name 'zwJUFudI' \
    --offset '59' \
    --orderby 'lXqg75mE' \
    --sortby 'bG3TjVYI' \
    --subtype 'YYaaYlXF' \
    --tags '["bYNjReAa", "e3RvPQ1m", "HeLbVCkA"]' \
    --type 'W01Ly3xx' \
    > test.out 2>&1
eval_tap $? 55 'GetLikedContent' test.out

#- 56 PublicDownloadContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'DCler0YC' \
    > test.out 2>&1
eval_tap $? 56 'PublicDownloadContentByShareCode' test.out

#- 57 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId 'chLhBVCR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'PublicDownloadContentByContentID' test.out

#- 58 AddDownloadCount
$CLI_EXE \
    --sn ugc \
    --op AddDownloadCount \
    --contentId 'gj9qrf7B' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'AddDownloadCount' test.out

#- 59 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId 'SFw62QF4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'UpdateContentLikeStatus' test.out

#- 60 PublicDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentPreview \
    --contentId 'v6XjMm0y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'PublicDownloadContentPreview' test.out

#- 61 GetTag
$CLI_EXE \
    --sn ugc \
    --op GetTag \
    --namespace $AB_NAMESPACE \
    --limit '54' \
    --offset '49' \
    > test.out 2>&1
eval_tap $? 61 'GetTag' test.out

#- 62 GetType
$CLI_EXE \
    --sn ugc \
    --op GetType \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 62 'GetType' test.out

#- 63 PublicSearchCreator
$CLI_EXE \
    --sn ugc \
    --op PublicSearchCreator \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '8' \
    --orderby '5sR4ny38' \
    --sortby 'FgD25lpN' \
    > test.out 2>&1
eval_tap $? 63 'PublicSearchCreator' test.out

#- 64 GetFollowedUsers
$CLI_EXE \
    --sn ugc \
    --op GetFollowedUsers \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 64 'GetFollowedUsers' test.out

#- 65 PublicGetCreator
$CLI_EXE \
    --sn ugc \
    --op PublicGetCreator \
    --namespace $AB_NAMESPACE \
    --userId 'ZEDwtHhk' \
    > test.out 2>&1
eval_tap $? 65 'PublicGetCreator' test.out

#- 66 GetChannels
$CLI_EXE \
    --sn ugc \
    --op GetChannels \
    --namespace $AB_NAMESPACE \
    --userId 'oUMLVN3V' \
    --limit '98' \
    --offset '3' \
    > test.out 2>&1
eval_tap $? 66 'GetChannels' test.out

#- 67 CreateChannel
# body param: body
echo '{"name": "WrKvD8xY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateChannel \
    --namespace $AB_NAMESPACE \
    --userId 'WQsFTaPS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'CreateChannel' test.out

#- 68 DeleteAllUserChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserChannel \
    --namespace $AB_NAMESPACE \
    --userId 'UJTMYdoT' \
    > test.out 2>&1
eval_tap $? 68 'DeleteAllUserChannel' test.out

#- 69 UpdateChannel
# body param: body
echo '{"name": "oNiPRZpm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId '066vGNbL' \
    --namespace $AB_NAMESPACE \
    --userId 'PlCVw7SS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'UpdateChannel' test.out

#- 70 DeleteChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteChannel \
    --channelId 'lVyZVNdt' \
    --namespace $AB_NAMESPACE \
    --userId 'MAl7MPRK' \
    > test.out 2>&1
eval_tap $? 70 'DeleteChannel' test.out

#- 71 CreateContentDirect
eval_tap 0 71 'CreateContentDirect # SKIP deprecated' test.out

#- 72 CreateContentS3
# body param: body
echo '{"contentType": "AsuAd7lE", "fileExtension": "Y7CqEyHj", "name": "J68oKSsc", "preview": "U99hRkhO", "previewMetadata": {"previewContentType": "w9AkdCLH", "previewFileExtension": "Z3ZCNljN"}, "subType": "VwVXRr3A", "tags": ["o555W7z9", "lwHviTkH", "ATQahIJ2"], "type": "dhQDpyjv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId 'UxS54TsT' \
    --namespace $AB_NAMESPACE \
    --userId 'R8ihYF0b' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'CreateContentS3' test.out

#- 73 UpdateContentS3
# body param: body
echo '{"contentType": "FSK2WeUa", "fileExtension": "FyzXzZKB", "name": "3SuhlWlf", "preview": "nKTqL9vQ", "previewMetadata": {"previewContentType": "5C0HYqVR", "previewFileExtension": "2ugEJNHV"}, "subType": "hQaxzyXD", "tags": ["YJSvH1K2", "m08i1uQZ", "m6kQjExR"], "type": "XOZjmq9O"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId 'ZieClJOX' \
    --contentId 'TdEa3PGE' \
    --namespace $AB_NAMESPACE \
    --userId 'J3H9fua9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'UpdateContentS3' test.out

#- 74 UpdateContentDirect
eval_tap 0 74 'UpdateContentDirect # SKIP deprecated' test.out

#- 75 DeleteContent
$CLI_EXE \
    --sn ugc \
    --op DeleteContent \
    --channelId 'PpvmfGbX' \
    --contentId 'DTlJmsLD' \
    --namespace $AB_NAMESPACE \
    --userId '07jbOXXd' \
    > test.out 2>&1
eval_tap $? 75 'DeleteContent' test.out

#- 76 PublicGetUserContent
$CLI_EXE \
    --sn ugc \
    --op PublicGetUserContent \
    --namespace $AB_NAMESPACE \
    --userId 'cRAwwlgv' \
    --limit '63' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 76 'PublicGetUserContent' test.out

#- 77 DeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId '6Cu4tU8j' \
    > test.out 2>&1
eval_tap $? 77 'DeleteAllUserContents' test.out

#- 78 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "ERrYuSxP", "screenshotId": "l6AFkopv"}, {"description": "3MH93Krz", "screenshotId": "6X381lml"}, {"description": "g6Z9UOnD", "screenshotId": "dE5PHuLN"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId '2BxqUpJt' \
    --namespace $AB_NAMESPACE \
    --userId 'Gv98yMzB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'UpdateScreenshots' test.out

#- 79 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "4Y36KaKz", "description": "79ynbZKD", "fileExtension": "bmp"}, {"contentType": "dwA7etU0", "description": "PmMA04M7", "fileExtension": "jfif"}, {"contentType": "z6xZ2nPH", "description": "hvsSYr5E", "fileExtension": "jfif"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId '4nl2nFgl' \
    --namespace $AB_NAMESPACE \
    --userId 'pGSCp7Ze' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'UploadContentScreenshot' test.out

#- 80 DeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op DeleteContentScreenshot \
    --contentId 'TYSBahmW' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'NbKhEFp0' \
    --userId 'U3JI6IgF' \
    > test.out 2>&1
eval_tap $? 80 'DeleteContentScreenshot' test.out

#- 81 UpdateUserFollowStatus
# body param: body
echo '{"followStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateUserFollowStatus \
    --namespace $AB_NAMESPACE \
    --userId 'FnTZ9khv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'UpdateUserFollowStatus' test.out

#- 82 GetPublicFollowers
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowers \
    --namespace $AB_NAMESPACE \
    --userId 'egIpitnt' \
    --limit '68' \
    --offset '89' \
    > test.out 2>&1
eval_tap $? 82 'GetPublicFollowers' test.out

#- 83 GetPublicFollowing
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowing \
    --namespace $AB_NAMESPACE \
    --userId 'JXLnAKyy' \
    --limit '14' \
    --offset '78' \
    > test.out 2>&1
eval_tap $? 83 'GetPublicFollowing' test.out

#- 84 GetGroups
$CLI_EXE \
    --sn ugc \
    --op GetGroups \
    --namespace $AB_NAMESPACE \
    --userId 'q3pWqL8o' \
    --limit '96' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 84 'GetGroups' test.out

#- 85 CreateGroup
# body param: body
echo '{"contents": ["OwsKd5nj", "KW53rJ6Z", "y6p9n97B"], "name": "EbuQRrj9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $AB_NAMESPACE \
    --userId 'I5zaONZh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'CreateGroup' test.out

#- 86 DeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'BnNAVyGz' \
    > test.out 2>&1
eval_tap $? 86 'DeleteAllUserGroup' test.out

#- 87 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId 'SVFPUQMB' \
    --namespace $AB_NAMESPACE \
    --userId 'Rk6IMwGC' \
    > test.out 2>&1
eval_tap $? 87 'GetGroup' test.out

#- 88 UpdateGroup
# body param: body
echo '{"contents": ["xR1fnkAT", "oGbs2aXv", "MR1hS0S8"], "name": "1oyeKIIY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId '7cGAcgHT' \
    --namespace $AB_NAMESPACE \
    --userId 'xcHw8dr1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'UpdateGroup' test.out

#- 89 DeleteGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteGroup \
    --groupId 'M3SxRGAz' \
    --namespace $AB_NAMESPACE \
    --userId 'D1L2xe3v' \
    > test.out 2>&1
eval_tap $? 89 'DeleteGroup' test.out

#- 90 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId 'V64of0Mn' \
    --namespace $AB_NAMESPACE \
    --userId 'OPusD4cC' \
    --limit '81' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 90 'GetGroupContent' test.out

#- 91 DeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'eDhHRmWK' \
    > test.out 2>&1
eval_tap $? 91 'DeleteAllUserStates' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE