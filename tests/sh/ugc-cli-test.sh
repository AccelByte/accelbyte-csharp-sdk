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
echo "1..89"

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

#- 52 PublicGetContentBulk
# body param: body
echo '{"contentIds": ["RPpjOWK0"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op PublicGetContentBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'PublicGetContentBulk' test.out

#- 53 GetFollowedContent
$CLI_EXE \
    --sn ugc \
    --op GetFollowedContent \
    --namespace $AB_NAMESPACE \
    --limit '20' \
    --offset '17' \
    > test.out 2>&1
eval_tap $? 53 'GetFollowedContent' test.out

#- 54 GetLikedContent
$CLI_EXE \
    --sn ugc \
    --op GetLikedContent \
    --namespace $AB_NAMESPACE \
    --limit '12' \
    --offset '34' \
    > test.out 2>&1
eval_tap $? 54 'GetLikedContent' test.out

#- 55 DownloadContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op DownloadContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'YaEuNCyP' \
    > test.out 2>&1
eval_tap $? 55 'DownloadContentByShareCode' test.out

#- 56 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId 'oQ0oHYXU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'PublicDownloadContentByContentID' test.out

#- 57 AddDownloadCount
$CLI_EXE \
    --sn ugc \
    --op AddDownloadCount \
    --contentId 'QdtIkAkl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'AddDownloadCount' test.out

#- 58 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId 'd1zQBzzC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'UpdateContentLikeStatus' test.out

#- 59 PublicDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentPreview \
    --contentId '6ldKriI6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 59 'PublicDownloadContentPreview' test.out

#- 60 GetTag
$CLI_EXE \
    --sn ugc \
    --op GetTag \
    --namespace $AB_NAMESPACE \
    --limit '22' \
    --offset '90' \
    > test.out 2>&1
eval_tap $? 60 'GetTag' test.out

#- 61 GetType
$CLI_EXE \
    --sn ugc \
    --op GetType \
    --namespace $AB_NAMESPACE \
    --limit '86' \
    --offset '3' \
    > test.out 2>&1
eval_tap $? 61 'GetType' test.out

#- 62 GetFollowedUsers
$CLI_EXE \
    --sn ugc \
    --op GetFollowedUsers \
    --namespace $AB_NAMESPACE \
    --limit '5' \
    --offset '66' \
    > test.out 2>&1
eval_tap $? 62 'GetFollowedUsers' test.out

#- 63 GetCreator
$CLI_EXE \
    --sn ugc \
    --op GetCreator \
    --namespace $AB_NAMESPACE \
    --userId 'JHzl323Y' \
    > test.out 2>&1
eval_tap $? 63 'GetCreator' test.out

#- 64 GetChannels
$CLI_EXE \
    --sn ugc \
    --op GetChannels \
    --namespace $AB_NAMESPACE \
    --userId 'nwf5PvGe' \
    --limit '18' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 64 'GetChannels' test.out

#- 65 CreateChannel
# body param: body
echo '{"name": "DgAr1pXD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateChannel \
    --namespace $AB_NAMESPACE \
    --userId 'csHnobna' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'CreateChannel' test.out

#- 66 DeleteAllUserChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserChannel \
    --namespace $AB_NAMESPACE \
    --userId 'YxGh3Fov' \
    > test.out 2>&1
eval_tap $? 66 'DeleteAllUserChannel' test.out

#- 67 UpdateChannel
# body param: body
echo '{"name": "Bnr5VUOH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId 'GqEcuJYo' \
    --namespace $AB_NAMESPACE \
    --userId '3YfMDw4P' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'UpdateChannel' test.out

#- 68 DeleteChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteChannel \
    --channelId 'aBKsFXor' \
    --namespace $AB_NAMESPACE \
    --userId 'xY0ahG5A' \
    > test.out 2>&1
eval_tap $? 68 'DeleteChannel' test.out

#- 69 CreateContentDirect
eval_tap 0 69 'CreateContentDirect # SKIP deprecated' test.out

#- 70 CreateContentS3
# body param: body
echo '{"contentType": "gHrE98qQ", "fileExtension": "TSXh1W7M", "name": "nK2i8Ely", "preview": "255awvul", "subType": "bNGSAjei", "tags": ["iANETlkn"], "type": "cKPmri36"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId 'MY2aVCNU' \
    --namespace $AB_NAMESPACE \
    --userId 'JgcpAYbj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'CreateContentS3' test.out

#- 71 UpdateContentS3
# body param: body
echo '{"contentType": "0fidlWPS", "fileExtension": "AIjaw5HS", "name": "yDsQqMUP", "preview": "rAxUd1bm", "subType": "VSM44scg", "tags": ["NAZf7a3R"], "type": "9rIVTDDX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId 'Z1fahMp6' \
    --contentId '88Jv5wQ3' \
    --namespace $AB_NAMESPACE \
    --userId 'hbDlcGRx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'UpdateContentS3' test.out

#- 72 UpdateContentDirect
eval_tap 0 72 'UpdateContentDirect # SKIP deprecated' test.out

#- 73 DeleteContent
$CLI_EXE \
    --sn ugc \
    --op DeleteContent \
    --channelId '2aExmVbX' \
    --contentId 'DomWyrFZ' \
    --namespace $AB_NAMESPACE \
    --userId 'ZdM00sSd' \
    > test.out 2>&1
eval_tap $? 73 'DeleteContent' test.out

#- 74 PublicGetUserContent
$CLI_EXE \
    --sn ugc \
    --op PublicGetUserContent \
    --namespace $AB_NAMESPACE \
    --userId 'UypOvoMv' \
    --limit '68' \
    --offset '78' \
    > test.out 2>&1
eval_tap $? 74 'PublicGetUserContent' test.out

#- 75 DeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId '7cRBRxFs' \
    > test.out 2>&1
eval_tap $? 75 'DeleteAllUserContents' test.out

#- 76 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "CUQz0koU", "screenshotId": "sUcGfjtf"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId 'yuPNb5ex' \
    --namespace $AB_NAMESPACE \
    --userId 'iRtR1Qe0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'UpdateScreenshots' test.out

#- 77 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "mxLnvZEG", "description": "2biyKS8v", "fileExtension": "pjp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId 'IsZ5EADM' \
    --namespace $AB_NAMESPACE \
    --userId '0xJp6HXe' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'UploadContentScreenshot' test.out

#- 78 DeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op DeleteContentScreenshot \
    --contentId 'xnHAXYSh' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'Ig82ffzx' \
    --userId '6WCUdwQn' \
    > test.out 2>&1
eval_tap $? 78 'DeleteContentScreenshot' test.out

#- 79 UpdateUserFollowStatus
# body param: body
echo '{"followStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateUserFollowStatus \
    --namespace $AB_NAMESPACE \
    --userId 'vM1tfIoS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'UpdateUserFollowStatus' test.out

#- 80 GetPublicFollowers
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowers \
    --namespace $AB_NAMESPACE \
    --userId 'sKaP5KNn' \
    --limit '0UGr95D9' \
    --offset 'VatfxBoa' \
    > test.out 2>&1
eval_tap $? 80 'GetPublicFollowers' test.out

#- 81 GetPublicFollowing
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowing \
    --namespace $AB_NAMESPACE \
    --userId 'kHUqz2uO' \
    --limit 'KJVjX7j5' \
    --offset 'MgRZ3kPm' \
    > test.out 2>&1
eval_tap $? 81 'GetPublicFollowing' test.out

#- 82 GetGroups
$CLI_EXE \
    --sn ugc \
    --op GetGroups \
    --namespace $AB_NAMESPACE \
    --userId 'SrNaFzJw' \
    --limit '54' \
    --offset '5' \
    > test.out 2>&1
eval_tap $? 82 'GetGroups' test.out

#- 83 CreateGroup
# body param: body
echo '{"contents": ["eJQ0viEY"], "name": "Qy4JxBky"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $AB_NAMESPACE \
    --userId 'XfgwzMTA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'CreateGroup' test.out

#- 84 DeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'lT2q2EbG' \
    > test.out 2>&1
eval_tap $? 84 'DeleteAllUserGroup' test.out

#- 85 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId '4Z95Sldy' \
    --namespace $AB_NAMESPACE \
    --userId 'We2X8cLe' \
    > test.out 2>&1
eval_tap $? 85 'GetGroup' test.out

#- 86 UpdateGroup
# body param: body
echo '{"contents": ["s0TRTAek"], "name": "rfR30IRA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId '6CzcXFcj' \
    --namespace $AB_NAMESPACE \
    --userId 'Rpu7wVEz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'UpdateGroup' test.out

#- 87 DeleteGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteGroup \
    --groupId 'bwHvOGqw' \
    --namespace $AB_NAMESPACE \
    --userId 'b7FAI8lx' \
    > test.out 2>&1
eval_tap $? 87 'DeleteGroup' test.out

#- 88 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId 'DoRtwKNH' \
    --namespace $AB_NAMESPACE \
    --userId 'CncWRyVD' \
    --limit '82' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 88 'GetGroupContent' test.out

#- 89 DeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'RFIbOIi0' \
    > test.out 2>&1
eval_tap $? 89 'DeleteAllUserStates' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE