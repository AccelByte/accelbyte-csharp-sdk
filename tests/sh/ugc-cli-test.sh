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
echo "1..88"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 SingleAdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetChannel \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 2 'SingleAdminGetChannel' test.out

#- 3 AdminCreateChannel
# body param: body
echo '{"name": "jv4Ax7Nz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateChannel \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChannel' test.out

#- 4 SingleAdminUpdateChannel
# body param: body
echo '{"name": "Ykoppa0V"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateChannel \
    --channelId 'gFJAhHwT' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'SingleAdminUpdateChannel' test.out

#- 5 SingleAdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteChannel \
    --channelId 'b5q010gN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'SingleAdminDeleteChannel' test.out

#- 6 AdminUploadContentDirect
eval_tap 0 6 'AdminUploadContentDirect # SKIP deprecated' test.out

#- 7 AdminUploadContentS3
# body param: body
echo '{"contentType": "2MQrbpeR", "fileExtension": "nxTlCTFS", "name": "MIbl1a2j", "preview": "XLCtWmHJ", "subType": "Bi9SoMkS", "tags": ["E4eJelwO"], "type": "4KPMky2h"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentS3 \
    --channelId '8R2fIXoX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUploadContentS3' test.out

#- 8 SingleAdminUpdateContentS3
# body param: body
echo '{"contentType": "P8gd7JUa", "fileExtension": "bYc3GMbx", "name": "Tlm1fsu6", "preview": "J3C4s5pp", "subType": "GR9XcoxY", "tags": ["TGgewrLf"], "type": "wvzJF4Tp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateContentS3 \
    --channelId 'bNhKq2xd' \
    --contentId 'mgEBepFH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'SingleAdminUpdateContentS3' test.out

#- 9 AdminSearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchChannelSpecificContent \
    --channelId 'tf6Ziegq' \
    --namespace $AB_NAMESPACE \
    --creator 'dEL4fsM6' \
    --isofficial 'nBzRVuC1' \
    --limit '34' \
    --name '7UH1Liu7' \
    --offset '93' \
    --orderby 'Q0304McK' \
    --sortby '873tRtr5' \
    --subtype 'cfWO5JJ2' \
    --tags 'c6vsOns4' \
    --type 'jNWGc7Ci' \
    --userId 'Ua4wM5Eu' \
    > test.out 2>&1
eval_tap $? 9 'AdminSearchChannelSpecificContent' test.out

#- 10 SingleAdminUpdateContentDirect
eval_tap 0 10 'SingleAdminUpdateContentDirect # SKIP deprecated' test.out

#- 11 SingleAdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteContent \
    --channelId '3VqymsFX' \
    --contentId 'porMqEDR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'SingleAdminDeleteContent' test.out

#- 12 SingleAdminGetContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetContent \
    --namespace $AB_NAMESPACE \
    --limit '60' \
    --offset '99' \
    > test.out 2>&1
eval_tap $? 12 'SingleAdminGetContent' test.out

#- 13 AdminSearchContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'MKfhl6eq' \
    --isofficial '2FzU3VL3' \
    --limit '74' \
    --name 'NmPLeZdo' \
    --offset '56' \
    --orderby 'XfabFXzv' \
    --sortby 'jLmai7fP' \
    --subtype 'KvE2Z4a6' \
    --tags '3UVtLbQS' \
    --type 'Wtsyz0mG' \
    --userId 'GyHHFIlI' \
    > test.out 2>&1
eval_tap $? 13 'AdminSearchContent' test.out

#- 14 AdminGetSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetSpecificContent \
    --contentId 'KsXgvSrk' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminGetSpecificContent' test.out

#- 15 AdminDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op AdminDownloadContentPreview \
    --contentId 'EgTYVk5i' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminDownloadContentPreview' test.out

#- 16 AdminUpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "RBE6zJJ1", "screenshotId": "BRHrfCHq"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateScreenshots \
    --contentId 'qp2GwPcm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminUpdateScreenshots' test.out

#- 17 AdminUploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "zSuY8w9V", "description": "YwBEfRXo", "fileExtension": "bmp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentScreenshot \
    --contentId 'fpVFfDwj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUploadContentScreenshot' test.out

#- 18 AdminDeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContentScreenshot \
    --contentId 'HHCW2g5u' \
    --namespace $AB_NAMESPACE \
    --screenshotId '8z9yrpJd' \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteContentScreenshot' test.out

#- 19 SingleAdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 19 'SingleAdminGetAllGroups' test.out

#- 20 AdminCreateGroup
# body param: body
echo '{"contents": ["5vvHS3d6"], "name": "PKPE27mI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminCreateGroup' test.out

#- 21 SingleAdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroup \
    --groupId '6Px8jt8L' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'SingleAdminGetGroup' test.out

#- 22 SingleAdminUpdateGroup
# body param: body
echo '{"contents": ["q4x0F7Nc"], "name": "ocelJjtl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateGroup \
    --groupId 'KYu8iCPz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'SingleAdminUpdateGroup' test.out

#- 23 SingleAdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteGroup \
    --groupId 'nx0s5TzT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'SingleAdminDeleteGroup' test.out

#- 24 SingleAdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroupContents \
    --groupId '51oV4HTm' \
    --namespace $AB_NAMESPACE \
    --limit '17' \
    --offset '42' \
    > test.out 2>&1
eval_tap $? 24 'SingleAdminGetGroupContents' test.out

#- 25 AdminGetTag
$CLI_EXE \
    --sn ugc \
    --op AdminGetTag \
    --namespace $AB_NAMESPACE \
    --limit '25' \
    --offset '2' \
    > test.out 2>&1
eval_tap $? 25 'AdminGetTag' test.out

#- 26 AdminCreateTag
# body param: body
echo '{"tag": "6tPmCirk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminCreateTag' test.out

#- 27 AdminUpdateTag
# body param: body
echo '{"tag": "hYvcOUuc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateTag \
    --namespace $AB_NAMESPACE \
    --tagId 'jPWGwPsv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminUpdateTag' test.out

#- 28 AdminDeleteTag
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagId 'jLK1CjPt' \
    > test.out 2>&1
eval_tap $? 28 'AdminDeleteTag' test.out

#- 29 AdminGetType
$CLI_EXE \
    --sn ugc \
    --op AdminGetType \
    --namespace $AB_NAMESPACE \
    --limit '40' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 29 'AdminGetType' test.out

#- 30 AdminCreateType
# body param: body
echo '{"subtype": ["bMkpUFHT"], "type": "0fL9q9SM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminCreateType' test.out

#- 31 AdminUpdateType
# body param: body
echo '{"subtype": ["NAUQVoiQ"], "type": "tSQC2kNS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateType \
    --namespace $AB_NAMESPACE \
    --typeId 'smT0d2aB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminUpdateType' test.out

#- 32 AdminDeleteType
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteType \
    --namespace $AB_NAMESPACE \
    --typeId 'G4zA2zp1' \
    > test.out 2>&1
eval_tap $? 32 'AdminDeleteType' test.out

#- 33 AdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op AdminGetChannel \
    --namespace $AB_NAMESPACE \
    --userId 'Ls0bD6dG' \
    --limit '12' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 33 'AdminGetChannel' test.out

#- 34 AdminDeleteAllUserChannels
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserChannels \
    --namespace $AB_NAMESPACE \
    --userId 'kYgHzKuI' \
    > test.out 2>&1
eval_tap $? 34 'AdminDeleteAllUserChannels' test.out

#- 35 AdminUpdateChannel
# body param: body
echo '{"name": "2RJrboP7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateChannel \
    --channelId 'kfpIletX' \
    --namespace $AB_NAMESPACE \
    --userId 'rCK1UVO0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'AdminUpdateChannel' test.out

#- 36 AdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteChannel \
    --channelId 'jcs7nCqs' \
    --namespace $AB_NAMESPACE \
    --userId 'odoTFTcW' \
    > test.out 2>&1
eval_tap $? 36 'AdminDeleteChannel' test.out

#- 37 AdminUpdateContentS3
# body param: body
echo '{"contentType": "laIBJAAk", "fileExtension": "nU6HobZg", "name": "WlaLnedD", "preview": "fasTc8gr", "subType": "2znWqD6t", "tags": ["IcfI5Z4t"], "type": "UNQ7mQPj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateContentS3 \
    --channelId 'CalZgFVE' \
    --contentId 'Qyqav09O' \
    --namespace $AB_NAMESPACE \
    --userId 'YmxCvMqV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminUpdateContentS3' test.out

#- 38 AdminUpdateContentDirect
eval_tap 0 38 'AdminUpdateContentDirect # SKIP deprecated' test.out

#- 39 AdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContent \
    --channelId 'cXs2OqNz' \
    --contentId '8ZLBsncb' \
    --namespace $AB_NAMESPACE \
    --userId 'Rrf6uEdj' \
    > test.out 2>&1
eval_tap $? 39 'AdminDeleteContent' test.out

#- 40 AdminGetContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetContent \
    --namespace $AB_NAMESPACE \
    --userId 'Unr04WZN' \
    --limit '14' \
    --offset '13' \
    > test.out 2>&1
eval_tap $? 40 'AdminGetContent' test.out

#- 41 AdminDeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId 'EGvqKWQT' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteAllUserContents' test.out

#- 42 AdminHideUserContent
# body param: body
echo '{"isHidden": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminHideUserContent \
    --contentId 'E65j6186' \
    --namespace $AB_NAMESPACE \
    --userId 'p0WfsnWZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'AdminHideUserContent' test.out

#- 43 AdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op AdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --userId 'uUPsaRnV' \
    --limit '7' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 43 'AdminGetAllGroups' test.out

#- 44 AdminDeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'dBA2hXwY' \
    > test.out 2>&1
eval_tap $? 44 'AdminDeleteAllUserGroup' test.out

#- 45 AdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroup \
    --groupId 'yzZMdlR4' \
    --namespace $AB_NAMESPACE \
    --userId 'cL76hnFD' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetGroup' test.out

#- 46 AdminUpdateGroup
# body param: body
echo '{"contents": ["gTfofHdf"], "name": "oSqDcaFh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateGroup \
    --groupId 'Oc1oKxI8' \
    --namespace $AB_NAMESPACE \
    --userId 'f5ocfy4E' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminUpdateGroup' test.out

#- 47 AdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteGroup \
    --groupId 'IxwBiB90' \
    --namespace $AB_NAMESPACE \
    --userId 'vdgS5YpK' \
    > test.out 2>&1
eval_tap $? 47 'AdminDeleteGroup' test.out

#- 48 AdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroupContents \
    --groupId 'sdbpiU2U' \
    --namespace $AB_NAMESPACE \
    --userId 'fyMO4DhL' \
    --limit '10' \
    --offset '55' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetGroupContents' test.out

#- 49 AdminDeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'KJvjBOUn' \
    > test.out 2>&1
eval_tap $? 49 'AdminDeleteAllUserStates' test.out

#- 50 SearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op SearchChannelSpecificContent \
    --channelId '3bYf5ouX' \
    --namespace $AB_NAMESPACE \
    --creator 'qkbiExqT' \
    --isofficial '6Dk9QFqa' \
    --limit '53' \
    --name 'jhwOI1P0' \
    --offset '7' \
    --orderby 'MHfTwrxB' \
    --sortby 'RfMxZrSf' \
    --subtype 'x3V8OXkM' \
    --tags 'ng7p2SyF' \
    --type 'DEnmYQze' \
    --userId 'hPBqD12D' \
    > test.out 2>&1
eval_tap $? 50 'SearchChannelSpecificContent' test.out

#- 51 PublicSearchContent
$CLI_EXE \
    --sn ugc \
    --op PublicSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'vvzNNZSu' \
    --isofficial '5zZVgY3Z' \
    --limit '28' \
    --name 'sfd01vaO' \
    --offset '65' \
    --orderby 'weHacvHR' \
    --sortby 'V345xB8h' \
    --subtype 'os4yaOBj' \
    --tags 'MxizCxx9' \
    --type 'qTOIKlpd' \
    --userId 'rqo2smD9' \
    > test.out 2>&1
eval_tap $? 51 'PublicSearchContent' test.out

#- 52 GetFollowedContent
$CLI_EXE \
    --sn ugc \
    --op GetFollowedContent \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 52 'GetFollowedContent' test.out

#- 53 GetLikedContent
$CLI_EXE \
    --sn ugc \
    --op GetLikedContent \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '19' \
    > test.out 2>&1
eval_tap $? 53 'GetLikedContent' test.out

#- 54 DownloadContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op DownloadContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'OWK0k76i' \
    > test.out 2>&1
eval_tap $? 54 'DownloadContentByShareCode' test.out

#- 55 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId '1g7rYaEu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'PublicDownloadContentByContentID' test.out

#- 56 AddDownloadCount
$CLI_EXE \
    --sn ugc \
    --op AddDownloadCount \
    --contentId 'NCyPoQ0o' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'AddDownloadCount' test.out

#- 57 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId 'tIkAkltd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'UpdateContentLikeStatus' test.out

#- 58 PublicDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentPreview \
    --contentId '1zQBzzC6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'PublicDownloadContentPreview' test.out

#- 59 GetTag
$CLI_EXE \
    --sn ugc \
    --op GetTag \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '6' \
    > test.out 2>&1
eval_tap $? 59 'GetTag' test.out

#- 60 GetType
$CLI_EXE \
    --sn ugc \
    --op GetType \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 60 'GetType' test.out

#- 61 GetFollowedUsers
$CLI_EXE \
    --sn ugc \
    --op GetFollowedUsers \
    --namespace $AB_NAMESPACE \
    --limit '17' \
    --offset '68' \
    > test.out 2>&1
eval_tap $? 61 'GetFollowedUsers' test.out

#- 62 GetCreator
$CLI_EXE \
    --sn ugc \
    --op GetCreator \
    --namespace $AB_NAMESPACE \
    --userId '6lTRbc1Z' \
    > test.out 2>&1
eval_tap $? 62 'GetCreator' test.out

#- 63 GetChannels
$CLI_EXE \
    --sn ugc \
    --op GetChannels \
    --namespace $AB_NAMESPACE \
    --userId '1HJHzl32' \
    --limit '26' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 63 'GetChannels' test.out

#- 64 CreateChannel
# body param: body
echo '{"name": "f5PvGejC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateChannel \
    --namespace $AB_NAMESPACE \
    --userId 'DgAr1pXD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'CreateChannel' test.out

#- 65 DeleteAllUserChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserChannel \
    --namespace $AB_NAMESPACE \
    --userId 'csHnobna' \
    > test.out 2>&1
eval_tap $? 65 'DeleteAllUserChannel' test.out

#- 66 UpdateChannel
# body param: body
echo '{"name": "YxGh3Fov"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId 'Bnr5VUOH' \
    --namespace $AB_NAMESPACE \
    --userId 'GqEcuJYo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'UpdateChannel' test.out

#- 67 DeleteChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteChannel \
    --channelId '3YfMDw4P' \
    --namespace $AB_NAMESPACE \
    --userId 'aBKsFXor' \
    > test.out 2>&1
eval_tap $? 67 'DeleteChannel' test.out

#- 68 CreateContentDirect
eval_tap 0 68 'CreateContentDirect # SKIP deprecated' test.out

#- 69 CreateContentS3
# body param: body
echo '{"contentType": "xY0ahG5A", "fileExtension": "gHrE98qQ", "name": "TSXh1W7M", "preview": "nK2i8Ely", "subType": "255awvul", "tags": ["bNGSAjei"], "type": "iANETlkn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId 'cKPmri36' \
    --namespace $AB_NAMESPACE \
    --userId 'MY2aVCNU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'CreateContentS3' test.out

#- 70 UpdateContentS3
# body param: body
echo '{"contentType": "JgcpAYbj", "fileExtension": "0fidlWPS", "name": "AIjaw5HS", "preview": "yDsQqMUP", "subType": "rAxUd1bm", "tags": ["VSM44scg"], "type": "NAZf7a3R"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId '9rIVTDDX' \
    --contentId 'Z1fahMp6' \
    --namespace $AB_NAMESPACE \
    --userId '88Jv5wQ3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'UpdateContentS3' test.out

#- 71 UpdateContentDirect
eval_tap 0 71 'UpdateContentDirect # SKIP deprecated' test.out

#- 72 DeleteContent
$CLI_EXE \
    --sn ugc \
    --op DeleteContent \
    --channelId 'hbDlcGRx' \
    --contentId '2aExmVbX' \
    --namespace $AB_NAMESPACE \
    --userId 'DomWyrFZ' \
    > test.out 2>&1
eval_tap $? 72 'DeleteContent' test.out

#- 73 PublicGetUserContent
$CLI_EXE \
    --sn ugc \
    --op PublicGetUserContent \
    --namespace $AB_NAMESPACE \
    --userId 'ZdM00sSd' \
    --limit '93' \
    --offset '48' \
    > test.out 2>&1
eval_tap $? 73 'PublicGetUserContent' test.out

#- 74 DeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId 'pOvoMvIN' \
    > test.out 2>&1
eval_tap $? 74 'DeleteAllUserContents' test.out

#- 75 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "7cRBRxFs", "screenshotId": "CUQz0koU"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId 'sUcGfjtf' \
    --namespace $AB_NAMESPACE \
    --userId 'yuPNb5ex' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'UpdateScreenshots' test.out

#- 76 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "iRtR1Qe0", "description": "mxLnvZEG", "fileExtension": "pjp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId 'iyKS8vfI' \
    --namespace $AB_NAMESPACE \
    --userId 'sZ5EADM0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'UploadContentScreenshot' test.out

#- 77 DeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op DeleteContentScreenshot \
    --contentId 'xJp6HXex' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'nHAXYShI' \
    --userId 'g82ffzx6' \
    > test.out 2>&1
eval_tap $? 77 'DeleteContentScreenshot' test.out

#- 78 UpdateUserFollowStatus
# body param: body
echo '{"followStatus": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateUserFollowStatus \
    --namespace $AB_NAMESPACE \
    --userId 'UdwQnivM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'UpdateUserFollowStatus' test.out

#- 79 GetPublicFollowers
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowers \
    --namespace $AB_NAMESPACE \
    --userId '1tfIoSsK' \
    --limit 'aP5KNn0U' \
    --offset 'Gr95D9Va' \
    > test.out 2>&1
eval_tap $? 79 'GetPublicFollowers' test.out

#- 80 GetPublicFollowing
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowing \
    --namespace $AB_NAMESPACE \
    --userId 'tfxBoakH' \
    --limit 'Uqz2uOKJ' \
    --offset 'VjX7j5Mg' \
    > test.out 2>&1
eval_tap $? 80 'GetPublicFollowing' test.out

#- 81 GetGroups
$CLI_EXE \
    --sn ugc \
    --op GetGroups \
    --namespace $AB_NAMESPACE \
    --userId 'RZ3kPmSr' \
    --limit '78' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 81 'GetGroups' test.out

#- 82 CreateGroup
# body param: body
echo '{"contents": ["FzJwBceJ"], "name": "Q0viEYQy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $AB_NAMESPACE \
    --userId '4JxBkyXf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'CreateGroup' test.out

#- 83 DeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'gwzMTAlT' \
    > test.out 2>&1
eval_tap $? 83 'DeleteAllUserGroup' test.out

#- 84 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId '2q2EbG4Z' \
    --namespace $AB_NAMESPACE \
    --userId '95SldyWe' \
    > test.out 2>&1
eval_tap $? 84 'GetGroup' test.out

#- 85 UpdateGroup
# body param: body
echo '{"contents": ["2X8cLes0"], "name": "TRTAekrf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId 'R30IRA6C' \
    --namespace $AB_NAMESPACE \
    --userId 'zcXFcjRp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'UpdateGroup' test.out

#- 86 DeleteGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteGroup \
    --groupId 'u7wVEzbw' \
    --namespace $AB_NAMESPACE \
    --userId 'HvOGqwb7' \
    > test.out 2>&1
eval_tap $? 86 'DeleteGroup' test.out

#- 87 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId 'FAI8lxDo' \
    --namespace $AB_NAMESPACE \
    --userId 'RtwKNHCn' \
    --limit '4' \
    --offset '96' \
    > test.out 2>&1
eval_tap $? 87 'GetGroupContent' test.out

#- 88 DeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'RyVDPNRF' \
    > test.out 2>&1
eval_tap $? 88 'DeleteAllUserStates' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE