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
    --limit '5' \
    --offset '67' \
    > test.out 2>&1
eval_tap $? 2 'SingleAdminGetChannel' test.out

#- 3 AdminCreateChannel
# body param: body
echo '{"name": "MlMIL5xm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateChannel \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChannel' test.out

#- 4 SingleAdminUpdateChannel
# body param: body
echo '{"name": "Y4cvDAZh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateChannel \
    --channelId '9yoKtY7O' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'SingleAdminUpdateChannel' test.out

#- 5 SingleAdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteChannel \
    --channelId 'ctOhZJCM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'SingleAdminDeleteChannel' test.out

#- 6 AdminUploadContentDirect
eval_tap 0 6 'AdminUploadContentDirect # SKIP deprecated' test.out

#- 7 AdminUploadContentS3
# body param: body
echo '{"contentType": "HLFtDBkO", "fileExtension": "50vXP7IA", "name": "XKB2xmcx", "preview": "mbm9fxP3", "previewMetadata": {"previewContentType": "zvC6v2tH", "previewFileExtension": "QEJ0YPG3"}, "subType": "1oXoQpMv", "tags": ["BTZEv3QD", "hLMvFl8g", "hwq6zwU7"], "type": "nPCX2pPu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentS3 \
    --channelId 'POqiEV1Z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUploadContentS3' test.out

#- 8 SingleAdminUpdateContentS3
# body param: body
echo '{"contentType": "06LSRbTx", "fileExtension": "IPGQHBvb", "name": "p4EDNyhe", "preview": "x0zQocqc", "previewMetadata": {"previewContentType": "IONNQNZy", "previewFileExtension": "V89uYXLH"}, "subType": "Gle58KGi", "tags": ["mRQ5veRl", "s5yVNkbu", "84cb1xKC"], "type": "A1mr0Gsr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateContentS3 \
    --channelId 'k10GqYZ0' \
    --contentId 'jCCjJvSM' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'SingleAdminUpdateContentS3' test.out

#- 9 AdminSearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchChannelSpecificContent \
    --channelId 'S3Ml9Icp' \
    --namespace $AB_NAMESPACE \
    --creator '8r51YoGa' \
    --isofficial '4bZEP2H6' \
    --limit '11' \
    --name 'yp6gg3aL' \
    --offset '45' \
    --orderby '5M2aM1hr' \
    --sortby 'm5Mc6Vhg' \
    --subtype 'uwAtQu8X' \
    --tags '["iLRC9mWf", "vPS80SbG", "p2GqtBE4"]' \
    --type 'W9lbGsa9' \
    --userId 'L9meBIDQ' \
    > test.out 2>&1
eval_tap $? 9 'AdminSearchChannelSpecificContent' test.out

#- 10 SingleAdminUpdateContentDirect
eval_tap 0 10 'SingleAdminUpdateContentDirect # SKIP deprecated' test.out

#- 11 SingleAdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteContent \
    --channelId 'H0lgBmu0' \
    --contentId 'wfVw90lv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'SingleAdminDeleteContent' test.out

#- 12 SingleAdminGetContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetContent \
    --namespace $AB_NAMESPACE \
    --limit '69' \
    --offset '76' \
    > test.out 2>&1
eval_tap $? 12 'SingleAdminGetContent' test.out

#- 13 AdminSearchContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'WtXFOxib' \
    --isofficial 'PqWjs0Bd' \
    --limit '47' \
    --name '6MJXkCXD' \
    --offset '38' \
    --orderby 'LLhE9PqP' \
    --sortby 'BkBEoGJa' \
    --subtype 'OiZqfuxo' \
    --tags '["I35GiQ5z", "4vjT7Z1h", "hkEiyAaE"]' \
    --type 'AduvEc5B' \
    --userId 's7T4A3Pb' \
    > test.out 2>&1
eval_tap $? 13 'AdminSearchContent' test.out

#- 14 AdminGetUserContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op AdminGetUserContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode '7fWP2iUY' \
    > test.out 2>&1
eval_tap $? 14 'AdminGetUserContentByShareCode' test.out

#- 15 AdminGetSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetSpecificContent \
    --contentId 'LUbKkrg1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminGetSpecificContent' test.out

#- 16 AdminDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op AdminDownloadContentPreview \
    --contentId 'WftbEL60' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminDownloadContentPreview' test.out

#- 17 AdminUpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "tOjDYkqh", "screenshotId": "kRobiCY7"}, {"description": "kofSxif2", "screenshotId": "I9wnGFat"}, {"description": "HJ5gvDlR", "screenshotId": "VeXLiNF0"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateScreenshots \
    --contentId 'GdjuESvO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateScreenshots' test.out

#- 18 AdminUploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "WZkoNOwr", "description": "zNB4fO4Z", "fileExtension": "pjp"}, {"contentType": "fQzC5yWR", "description": "6bsVWG6x", "fileExtension": "png"}, {"contentType": "GRl33qPi", "description": "aKXrJaN3", "fileExtension": "pjp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentScreenshot \
    --contentId 'DgVHhW9K' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUploadContentScreenshot' test.out

#- 19 AdminDeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContentScreenshot \
    --contentId 'Pc9X1qSQ' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'xA2O9Zlz' \
    > test.out 2>&1
eval_tap $? 19 'AdminDeleteContentScreenshot' test.out

#- 20 SingleAdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --limit '93' \
    --offset '91' \
    > test.out 2>&1
eval_tap $? 20 'SingleAdminGetAllGroups' test.out

#- 21 AdminCreateGroup
# body param: body
echo '{"contents": ["rA5HZKer", "46p4dJr3", "MEqwffHB"], "name": "DGX2gijB"}' > $TEMP_JSON_INPUT
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
    --groupId 'lrOmBUyp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'SingleAdminGetGroup' test.out

#- 23 SingleAdminUpdateGroup
# body param: body
echo '{"contents": ["yBzdEGjO", "3IyWWzab", "gYqJ7zvJ"], "name": "d5PXgJdT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateGroup \
    --groupId 'HgS0UbjD' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'SingleAdminUpdateGroup' test.out

#- 24 SingleAdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteGroup \
    --groupId '8xulGFcI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'SingleAdminDeleteGroup' test.out

#- 25 SingleAdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroupContents \
    --groupId '8P1xsHW4' \
    --namespace $AB_NAMESPACE \
    --limit '22' \
    --offset '54' \
    > test.out 2>&1
eval_tap $? 25 'SingleAdminGetGroupContents' test.out

#- 26 AdminGetTag
$CLI_EXE \
    --sn ugc \
    --op AdminGetTag \
    --namespace $AB_NAMESPACE \
    --limit '82' \
    --offset '23' \
    > test.out 2>&1
eval_tap $? 26 'AdminGetTag' test.out

#- 27 AdminCreateTag
# body param: body
echo '{"tag": "01Jto6ip"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminCreateTag' test.out

#- 28 AdminUpdateTag
# body param: body
echo '{"tag": "EsfeQiks"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateTag \
    --namespace $AB_NAMESPACE \
    --tagId 'z3637LCJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminUpdateTag' test.out

#- 29 AdminDeleteTag
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagId 'jvlMOB2r' \
    > test.out 2>&1
eval_tap $? 29 'AdminDeleteTag' test.out

#- 30 AdminGetType
$CLI_EXE \
    --sn ugc \
    --op AdminGetType \
    --namespace $AB_NAMESPACE \
    --limit '94' \
    --offset '14' \
    > test.out 2>&1
eval_tap $? 30 'AdminGetType' test.out

#- 31 AdminCreateType
# body param: body
echo '{"subtype": ["DG1lKr22", "IFAU3ul5", "hMoxBbRK"], "type": "esGwVI5x"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminCreateType' test.out

#- 32 AdminUpdateType
# body param: body
echo '{"subtype": ["ywphQkfl", "VEvJQIw5", "401eypx0"], "type": "qWm19f5Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateType \
    --namespace $AB_NAMESPACE \
    --typeId 'o7YN3Jzf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AdminUpdateType' test.out

#- 33 AdminDeleteType
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteType \
    --namespace $AB_NAMESPACE \
    --typeId 'hYQCgjW2' \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteType' test.out

#- 34 AdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op AdminGetChannel \
    --namespace $AB_NAMESPACE \
    --userId '3iA0RCDv' \
    --limit '59' \
    --offset '68' \
    > test.out 2>&1
eval_tap $? 34 'AdminGetChannel' test.out

#- 35 AdminDeleteAllUserChannels
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserChannels \
    --namespace $AB_NAMESPACE \
    --userId 'n4xvnfed' \
    > test.out 2>&1
eval_tap $? 35 'AdminDeleteAllUserChannels' test.out

#- 36 AdminUpdateChannel
# body param: body
echo '{"name": "IbgVA3se"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateChannel \
    --channelId 'WSZJ0oli' \
    --namespace $AB_NAMESPACE \
    --userId 'VHVDAbrV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AdminUpdateChannel' test.out

#- 37 AdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteChannel \
    --channelId '5ZGtXfPf' \
    --namespace $AB_NAMESPACE \
    --userId 'mpFZZYDt' \
    > test.out 2>&1
eval_tap $? 37 'AdminDeleteChannel' test.out

#- 38 AdminUpdateContentS3
# body param: body
echo '{"contentType": "62sjzogG", "fileExtension": "CqB9w0WE", "name": "ugyXihwH", "preview": "wkapJkM3", "previewMetadata": {"previewContentType": "i8Ck1hjv", "previewFileExtension": "2eD5WOzA"}, "subType": "d00zdSHe", "tags": ["iykJ9p6q", "ptrP6MRf", "5MXgmcES"], "type": "rcmPzinw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateContentS3 \
    --channelId 'cvFKDhms' \
    --contentId 'sYpmKUEh' \
    --namespace $AB_NAMESPACE \
    --userId 'Xin1JYFO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'AdminUpdateContentS3' test.out

#- 39 AdminUpdateContentDirect
eval_tap 0 39 'AdminUpdateContentDirect # SKIP deprecated' test.out

#- 40 AdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContent \
    --channelId 'ol9Vduv7' \
    --contentId 'Pyyi379o' \
    --namespace $AB_NAMESPACE \
    --userId 'qIw38n7S' \
    > test.out 2>&1
eval_tap $? 40 'AdminDeleteContent' test.out

#- 41 AdminGetContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetContent \
    --namespace $AB_NAMESPACE \
    --userId 'KjDlqlKr' \
    --limit '46' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 41 'AdminGetContent' test.out

#- 42 AdminDeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId 'I5E6n1mX' \
    > test.out 2>&1
eval_tap $? 42 'AdminDeleteAllUserContents' test.out

#- 43 AdminHideUserContent
# body param: body
echo '{"isHidden": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminHideUserContent \
    --contentId '6Fh4jaMr' \
    --namespace $AB_NAMESPACE \
    --userId 'ydDNfV3n' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminHideUserContent' test.out

#- 44 AdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op AdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --userId 'VEm9NnO1' \
    --limit '95' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 44 'AdminGetAllGroups' test.out

#- 45 AdminDeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'bfkyzlUD' \
    > test.out 2>&1
eval_tap $? 45 'AdminDeleteAllUserGroup' test.out

#- 46 AdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroup \
    --groupId 'UI8VKaqP' \
    --namespace $AB_NAMESPACE \
    --userId '40IEdILN' \
    > test.out 2>&1
eval_tap $? 46 'AdminGetGroup' test.out

#- 47 AdminUpdateGroup
# body param: body
echo '{"contents": ["6d65oih7", "nPdtX1F1", "qXWIsa2R"], "name": "R27Ma074"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateGroup \
    --groupId 'RACBt9ya' \
    --namespace $AB_NAMESPACE \
    --userId 'QdwIFJnY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminUpdateGroup' test.out

#- 48 AdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteGroup \
    --groupId 'xVAJdzJy' \
    --namespace $AB_NAMESPACE \
    --userId 'LhuPbmN6' \
    > test.out 2>&1
eval_tap $? 48 'AdminDeleteGroup' test.out

#- 49 AdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroupContents \
    --groupId 'yKpCmjoV' \
    --namespace $AB_NAMESPACE \
    --userId 'ur9mPOGZ' \
    --limit '39' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 49 'AdminGetGroupContents' test.out

#- 50 AdminDeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'Sw5aSNKn' \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteAllUserStates' test.out

#- 51 SearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op SearchChannelSpecificContent \
    --channelId '2q0eUbMG' \
    --namespace $AB_NAMESPACE \
    --creator 'juudh81w' \
    --isofficial 'JY0RJPsL' \
    --limit '75' \
    --name 'X2g3lBhj' \
    --offset '91' \
    --orderby '1OcrVD85' \
    --sortby 'iuLWd0bo' \
    --subtype 'b3vUWktu' \
    --tags '["bIZjpspi", "3nrmnY2K", "zQuliRSW"]' \
    --type 'xXQxuqfA' \
    --userId 'DjuAC0ZW' \
    > test.out 2>&1
eval_tap $? 51 'SearchChannelSpecificContent' test.out

#- 52 PublicSearchContent
$CLI_EXE \
    --sn ugc \
    --op PublicSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'egQibvcN' \
    --isofficial 'ctE7zKcL' \
    --limit '12' \
    --name 'zu3H0TuU' \
    --offset '9' \
    --orderby 'jCxGHodb' \
    --sortby 'ZbeZ6kZ0' \
    --subtype 'BF1ysMpO' \
    --tags '["OqN2cvBa", "DS1R7afy", "KtWyrtPF"]' \
    --type 'zoX2OeLy' \
    --userId 'uPCP7UVA' \
    > test.out 2>&1
eval_tap $? 52 'PublicSearchContent' test.out

#- 53 PublicGetContentBulk
# body param: body
echo '{"contentIds": ["3R46AtG8", "nKhkqHes", "chk79ZaM"]}' > $TEMP_JSON_INPUT
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
    --limit '40' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 54 'GetFollowedContent' test.out

#- 55 GetLikedContent
$CLI_EXE \
    --sn ugc \
    --op GetLikedContent \
    --namespace $AB_NAMESPACE \
    --isofficial 'true' \
    --limit '80' \
    --name 'E2HfmEA3' \
    --offset '21' \
    --orderby 'qxWnEgqI' \
    --sortby '2GkJ5phA' \
    --subtype 'RpkR5S8e' \
    --tags '["jscY1BVl", "GlDPzU2z", "IZoJVyfP"]' \
    --type 'bCdWKFvy' \
    > test.out 2>&1
eval_tap $? 55 'GetLikedContent' test.out

#- 56 PublicDownloadContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'pu1ypq6H' \
    > test.out 2>&1
eval_tap $? 56 'PublicDownloadContentByShareCode' test.out

#- 57 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId 'cnVpEjCV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'PublicDownloadContentByContentID' test.out

#- 58 AddDownloadCount
$CLI_EXE \
    --sn ugc \
    --op AddDownloadCount \
    --contentId '9DeSii41' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'AddDownloadCount' test.out

#- 59 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId 'vUtvLH9z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'UpdateContentLikeStatus' test.out

#- 60 PublicDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentPreview \
    --contentId 'foQ1bGsD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'PublicDownloadContentPreview' test.out

#- 61 GetTag
$CLI_EXE \
    --sn ugc \
    --op GetTag \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 61 'GetTag' test.out

#- 62 GetType
$CLI_EXE \
    --sn ugc \
    --op GetType \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '15' \
    > test.out 2>&1
eval_tap $? 62 'GetType' test.out

#- 63 PublicSearchCreator
$CLI_EXE \
    --sn ugc \
    --op PublicSearchCreator \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '52' \
    --orderby 'DWkQ6wi4' \
    --sortby 'HRRZLyFz' \
    > test.out 2>&1
eval_tap $? 63 'PublicSearchCreator' test.out

#- 64 GetFollowedUsers
$CLI_EXE \
    --sn ugc \
    --op GetFollowedUsers \
    --namespace $AB_NAMESPACE \
    --limit '77' \
    --offset '54' \
    > test.out 2>&1
eval_tap $? 64 'GetFollowedUsers' test.out

#- 65 PublicGetCreator
$CLI_EXE \
    --sn ugc \
    --op PublicGetCreator \
    --namespace $AB_NAMESPACE \
    --userId 'ERYWcnM0' \
    > test.out 2>&1
eval_tap $? 65 'PublicGetCreator' test.out

#- 66 GetChannels
$CLI_EXE \
    --sn ugc \
    --op GetChannels \
    --namespace $AB_NAMESPACE \
    --userId 'TptbFMNZ' \
    --limit '74' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 66 'GetChannels' test.out

#- 67 CreateChannel
# body param: body
echo '{"name": "zECoSm9Y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateChannel \
    --namespace $AB_NAMESPACE \
    --userId 'q19C7LMz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'CreateChannel' test.out

#- 68 DeleteAllUserChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserChannel \
    --namespace $AB_NAMESPACE \
    --userId 'snnmNqLC' \
    > test.out 2>&1
eval_tap $? 68 'DeleteAllUserChannel' test.out

#- 69 UpdateChannel
# body param: body
echo '{"name": "bUVNDgeo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId 'DD0dBJrC' \
    --namespace $AB_NAMESPACE \
    --userId 'IoodNfg8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'UpdateChannel' test.out

#- 70 DeleteChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteChannel \
    --channelId 'dBrZ5nvI' \
    --namespace $AB_NAMESPACE \
    --userId 'MEHiH3cq' \
    > test.out 2>&1
eval_tap $? 70 'DeleteChannel' test.out

#- 71 CreateContentDirect
eval_tap 0 71 'CreateContentDirect # SKIP deprecated' test.out

#- 72 CreateContentS3
# body param: body
echo '{"contentType": "DePL9m5h", "fileExtension": "w5BARWjm", "name": "PGVXHSrw", "preview": "SNawrsg3", "previewMetadata": {"previewContentType": "MQb1YmFh", "previewFileExtension": "aLcgk4VZ"}, "subType": "REmVu7gh", "tags": ["FAQacu7r", "Z5uwQdaQ", "6xXRHnpP"], "type": "dXiQMA3r"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId 'VrArq2vB' \
    --namespace $AB_NAMESPACE \
    --userId 'JtSTTPCA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'CreateContentS3' test.out

#- 73 UpdateContentS3
# body param: body
echo '{"contentType": "AW5WQjU1", "fileExtension": "mGIytxuU", "name": "fVVMXn8q", "preview": "rtyQ5rMG", "previewMetadata": {"previewContentType": "04lczvVU", "previewFileExtension": "ea5syLyY"}, "subType": "5IhmPjG3", "tags": ["XivuCT43", "B90O7AxA", "k13rr9p1"], "type": "fo9s80zg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId 'zGIHYQRu' \
    --contentId 'ITOTPsMu' \
    --namespace $AB_NAMESPACE \
    --userId 'Eq88LnXi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'UpdateContentS3' test.out

#- 74 UpdateContentDirect
eval_tap 0 74 'UpdateContentDirect # SKIP deprecated' test.out

#- 75 DeleteContent
$CLI_EXE \
    --sn ugc \
    --op DeleteContent \
    --channelId '3e7UuCoz' \
    --contentId 'fb4TYioQ' \
    --namespace $AB_NAMESPACE \
    --userId 'wwPpRE0v' \
    > test.out 2>&1
eval_tap $? 75 'DeleteContent' test.out

#- 76 PublicGetUserContent
$CLI_EXE \
    --sn ugc \
    --op PublicGetUserContent \
    --namespace $AB_NAMESPACE \
    --userId 'DojjlJFm' \
    --limit '84' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 76 'PublicGetUserContent' test.out

#- 77 DeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId 'qf7vfjDv' \
    > test.out 2>&1
eval_tap $? 77 'DeleteAllUserContents' test.out

#- 78 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "SQ4xT9GM", "screenshotId": "uYaMz59B"}, {"description": "1t7De6oU", "screenshotId": "3A1RW3UF"}, {"description": "yv5Uzm0U", "screenshotId": "V5YuCNv9"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId 'vg9Z3pPB' \
    --namespace $AB_NAMESPACE \
    --userId 'qoxBT6Ze' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'UpdateScreenshots' test.out

#- 79 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "nGRRWECI", "description": "FGkDuEYO", "fileExtension": "jpg"}, {"contentType": "kjF3fq6z", "description": "XLuK3gf0", "fileExtension": "jfif"}, {"contentType": "tiIJqXry", "description": "d47QGYAc", "fileExtension": "bmp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId 'G60dc6yf' \
    --namespace $AB_NAMESPACE \
    --userId 'wdUHJJKm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'UploadContentScreenshot' test.out

#- 80 DeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op DeleteContentScreenshot \
    --contentId 'V6bEqddZ' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'mPsDsM8N' \
    --userId 'fpGaDodu' \
    > test.out 2>&1
eval_tap $? 80 'DeleteContentScreenshot' test.out

#- 81 UpdateUserFollowStatus
# body param: body
echo '{"followStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateUserFollowStatus \
    --namespace $AB_NAMESPACE \
    --userId 'nmx9onmq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'UpdateUserFollowStatus' test.out

#- 82 GetPublicFollowers
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowers \
    --namespace $AB_NAMESPACE \
    --userId 'tKu1L8vg' \
    --limit '96' \
    --offset '71' \
    > test.out 2>&1
eval_tap $? 82 'GetPublicFollowers' test.out

#- 83 GetPublicFollowing
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowing \
    --namespace $AB_NAMESPACE \
    --userId 'ZUlXVNEU' \
    --limit '27' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 83 'GetPublicFollowing' test.out

#- 84 GetGroups
$CLI_EXE \
    --sn ugc \
    --op GetGroups \
    --namespace $AB_NAMESPACE \
    --userId 'JuODZf4I' \
    --limit '0' \
    --offset '43' \
    > test.out 2>&1
eval_tap $? 84 'GetGroups' test.out

#- 85 CreateGroup
# body param: body
echo '{"contents": ["xOicvrXq", "EkwBuoj4", "Sm5lHa5P"], "name": "jALTOYIB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $AB_NAMESPACE \
    --userId 'kFemyZNH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'CreateGroup' test.out

#- 86 DeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'yJiTZ3zV' \
    > test.out 2>&1
eval_tap $? 86 'DeleteAllUserGroup' test.out

#- 87 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId 'zX8ImAwK' \
    --namespace $AB_NAMESPACE \
    --userId 'Dh6mahij' \
    > test.out 2>&1
eval_tap $? 87 'GetGroup' test.out

#- 88 UpdateGroup
# body param: body
echo '{"contents": ["PRL57Tdo", "sLeZ7Aby", "zooL1GBz"], "name": "H9FdcGBr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId 'jKKhHknf' \
    --namespace $AB_NAMESPACE \
    --userId 'qlK2NhTl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'UpdateGroup' test.out

#- 89 DeleteGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteGroup \
    --groupId '8QZ7NZ2w' \
    --namespace $AB_NAMESPACE \
    --userId 'o0RUsaCs' \
    > test.out 2>&1
eval_tap $? 89 'DeleteGroup' test.out

#- 90 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId 'JhEu5Uy2' \
    --namespace $AB_NAMESPACE \
    --userId 'edYO3ExA' \
    --limit '65' \
    --offset '2' \
    > test.out 2>&1
eval_tap $? 90 'GetGroupContent' test.out

#- 91 DeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'DrnPclFW' \
    > test.out 2>&1
eval_tap $? 91 'DeleteAllUserStates' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE