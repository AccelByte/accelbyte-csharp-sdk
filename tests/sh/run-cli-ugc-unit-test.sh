#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=84

FINISHED_COUNT=0
SUCCESS_COUNT=0
FAILED_COUNT=0

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_APP_NAME="UnitTest"
export AB_NAMESPACE=$TEST_NAMESPACE

get_current_year() { echo $(date +'%Y'); }
get_adult_birthday() { echo "$(( $(get_current_year) - 22))-01-01"; }

get_random_int() { echo $(( $1 + ( RANDOM % (($2 - $1)) ) )); }
get_random_bool() { ( (( (RANDOM % 2) == 1)) && echo "true" ) || ( echo "false" ) }
get_random_element() { declare -a a=("$@"); r=$((RANDOM % ${#a[@]})); echo ${a[$r]}; }

create_file() {
    touch $1
}

delete_file() {
    [ ! -e $1 ] || rm $1
}

update_status() {
    return_code=$1
    operation_name=$2

    FINISHED_COUNT=$(( $FINISHED_COUNT + 1 ))

    if [ $return_code == 0 ]
    then
        SUCCESS_COUNT=$(( $SUCCESS_COUNT + 1 ))
        echo "ok $FINISHED_COUNT $operation_name"
    else
        FAILED_COUNT=$(( $FAILED_COUNT + 1 ))
        echo "not ok $FINISHED_COUNT - $operation_name"
        echo '  ---'
        echo '  error: |-'
        while read line; do
          echo "    $line" | tr '\n' ' '
        echo $line
        done < $TEMP_FILE
    fi
}

touch $TEMP_FILE

$CLI_EXE --op login --lt user --user user --pass user
rm -f $CLI_TOKEN_FILE
echo "foo" >> $CLI_TOKEN_FILE

echo 'TAP version 13'
echo "1..$OPERATIONS_COUNT"

#- 1 SingleAdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetChannel \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '56' \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 AdminCreateChannel
# body param: body
echo '{"name": "jv4Ax7Nz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateChannel \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 SingleAdminUpdateChannel
# body param: body
echo '{"name": "Ykoppa0V"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateChannel \
    --channelId 'gFJAhHwT' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminUpdateChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 SingleAdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteChannel \
    --channelId 'b5q010gN' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminDeleteChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 AdminUploadContentDirect
update_status 0 'AdminUploadContentDirect (skipped deprecated)'

#- 6 AdminUploadContentS3
# body param: body
echo '{"contentType": "2MQrbpeR", "fileExtension": "nxTlCTFS", "name": "MIbl1a2j", "preview": "XLCtWmHJ", "subType": "Bi9SoMkS", "tags": ["E4eJelwO"], "type": "4KPMky2h"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentS3 \
    --channelId '8R2fIXoX' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUploadContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 SingleAdminUpdateContentS3
# body param: body
echo '{"contentType": "P8gd7JUa", "fileExtension": "bYc3GMbx", "name": "Tlm1fsu6", "preview": "J3C4s5pp", "subType": "GR9XcoxY", "tags": ["TGgewrLf"], "type": "wvzJF4Tp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateContentS3 \
    --channelId 'bNhKq2xd' \
    --contentId 'mgEBepFH' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminUpdateContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 AdminSearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchChannelSpecificContent \
    --channelId 'tf6Ziegq' \
    --namespace $TEST_NAMESPACE \
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
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchChannelSpecificContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 SingleAdminUpdateContentDirect
update_status 0 'SingleAdminUpdateContentDirect (skipped deprecated)'

#- 10 SingleAdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteContent \
    --channelId '3VqymsFX' \
    --contentId 'porMqEDR' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminDeleteContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 SingleAdminGetContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetContent \
    --namespace $TEST_NAMESPACE \
    --limit '60' \
    --offset '99' \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 AdminSearchContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchContent \
    --namespace $TEST_NAMESPACE \
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
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 AdminGetSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetSpecificContent \
    --contentId 'KsXgvSrk' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetSpecificContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 AdminDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op AdminDownloadContentPreview \
    --contentId 'EgTYVk5i' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDownloadContentPreview'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 AdminUpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "RBE6zJJ1", "screenshotId": "BRHrfCHq"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateScreenshots \
    --contentId 'qp2GwPcm' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateScreenshots'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 AdminUploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "zSuY8w9V", "description": "YwBEfRXo", "fileExtension": "bmp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentScreenshot \
    --contentId 'fpVFfDwj' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUploadContentScreenshot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 AdminDeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContentScreenshot \
    --contentId 'HHCW2g5u' \
    --namespace $TEST_NAMESPACE \
    --screenshotId '8z9yrpJd' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteContentScreenshot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 SingleAdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetAllGroups \
    --namespace $TEST_NAMESPACE \
    --limit '68' \
    --offset '46' \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetAllGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 AdminCreateGroup
# body param: body
echo '{"contents": ["5vvHS3d6"], "name": "PKPE27mI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateGroup \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 SingleAdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroup \
    --groupId '6Px8jt8L' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 SingleAdminUpdateGroup
# body param: body
echo '{"contents": ["q4x0F7Nc"], "name": "ocelJjtl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateGroup \
    --groupId 'KYu8iCPz' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminUpdateGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 SingleAdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteGroup \
    --groupId 'nx0s5TzT' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminDeleteGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 SingleAdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroupContents \
    --groupId '51oV4HTm' \
    --namespace $TEST_NAMESPACE \
    --limit '17' \
    --offset '42' \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetGroupContents'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 AdminGetTag
$CLI_EXE \
    --sn ugc \
    --op AdminGetTag \
    --namespace $TEST_NAMESPACE \
    --limit '25' \
    --offset '2' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetTag'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 AdminCreateTag
# body param: body
echo '{"tag": "6tPmCirk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateTag \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateTag'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 AdminUpdateTag
# body param: body
echo '{"tag": "hYvcOUuc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateTag \
    --namespace $TEST_NAMESPACE \
    --tagId 'jPWGwPsv' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateTag'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 AdminDeleteTag
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteTag \
    --namespace $TEST_NAMESPACE \
    --tagId 'jLK1CjPt' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteTag'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 AdminGetType
$CLI_EXE \
    --sn ugc \
    --op AdminGetType \
    --namespace $TEST_NAMESPACE \
    --limit '40' \
    --offset '39' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 AdminCreateType
# body param: body
echo '{"subtype": ["bMkpUFHT"], "type": "0fL9q9SM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateType \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 AdminUpdateType
# body param: body
echo '{"subtype": ["NAUQVoiQ"], "type": "tSQC2kNS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateType \
    --namespace $TEST_NAMESPACE \
    --typeId 'smT0d2aB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 AdminDeleteType
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteType \
    --namespace $TEST_NAMESPACE \
    --typeId 'G4zA2zp1' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 AdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op AdminGetChannel \
    --namespace $TEST_NAMESPACE \
    --userId 'Ls0bD6dG' \
    --limit '12' \
    --offset '45' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 AdminDeleteAllUserChannels
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserChannels \
    --namespace $TEST_NAMESPACE \
    --userId 'kYgHzKuI' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserChannels'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 AdminUpdateChannel
# body param: body
echo '{"name": "2RJrboP7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateChannel \
    --channelId 'kfpIletX' \
    --namespace $TEST_NAMESPACE \
    --userId 'rCK1UVO0' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 AdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteChannel \
    --channelId 'jcs7nCqs' \
    --namespace $TEST_NAMESPACE \
    --userId 'odoTFTcW' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 AdminUpdateContentS3
# body param: body
echo '{"contentType": "laIBJAAk", "fileExtension": "nU6HobZg", "name": "WlaLnedD", "preview": "fasTc8gr", "subType": "2znWqD6t", "tags": ["IcfI5Z4t"], "type": "UNQ7mQPj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateContentS3 \
    --channelId 'CalZgFVE' \
    --contentId 'Qyqav09O' \
    --namespace $TEST_NAMESPACE \
    --userId 'YmxCvMqV' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 AdminUpdateContentDirect
update_status 0 'AdminUpdateContentDirect (skipped deprecated)'

#- 38 AdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContent \
    --channelId 'cXs2OqNz' \
    --contentId '8ZLBsncb' \
    --namespace $TEST_NAMESPACE \
    --userId 'Rrf6uEdj' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 AdminGetContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetContent \
    --namespace $TEST_NAMESPACE \
    --userId 'Unr04WZN' \
    --limit '14' \
    --offset '13' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 AdminDeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserContents \
    --namespace $TEST_NAMESPACE \
    --userId 'EGvqKWQT' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserContents'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 AdminHideUserContent
# body param: body
echo '{"isHidden": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminHideUserContent \
    --contentId 'E65j6186' \
    --namespace $TEST_NAMESPACE \
    --userId 'p0WfsnWZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminHideUserContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 AdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op AdminGetAllGroups \
    --namespace $TEST_NAMESPACE \
    --userId 'uUPsaRnV' \
    --limit '7' \
    --offset '35' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAllGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 AdminDeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserGroup \
    --namespace $TEST_NAMESPACE \
    --userId 'dBA2hXwY' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 AdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroup \
    --groupId 'yzZMdlR4' \
    --namespace $TEST_NAMESPACE \
    --userId 'cL76hnFD' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 AdminUpdateGroup
# body param: body
echo '{"contents": ["gTfofHdf"], "name": "oSqDcaFh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateGroup \
    --groupId 'Oc1oKxI8' \
    --namespace $TEST_NAMESPACE \
    --userId 'f5ocfy4E' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 AdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteGroup \
    --groupId 'IxwBiB90' \
    --namespace $TEST_NAMESPACE \
    --userId 'vdgS5YpK' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 AdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroupContents \
    --groupId 'sdbpiU2U' \
    --namespace $TEST_NAMESPACE \
    --userId 'fyMO4DhL' \
    --limit '10' \
    --offset '55' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetGroupContents'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 AdminDeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserStates \
    --namespace $TEST_NAMESPACE \
    --userId 'KJvjBOUn' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserStates'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 SearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op SearchChannelSpecificContent \
    --channelId '3bYf5ouX' \
    --namespace $TEST_NAMESPACE \
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
    >$TEMP_FILE 2>&1
update_status $? 'SearchChannelSpecificContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 PublicSearchContent
$CLI_EXE \
    --sn ugc \
    --op PublicSearchContent \
    --namespace $TEST_NAMESPACE \
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
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 GetFollowedContent
$CLI_EXE \
    --sn ugc \
    --op GetFollowedContent \
    --namespace $TEST_NAMESPACE \
    --limit '87' \
    --offset '82' \
    >$TEMP_FILE 2>&1
update_status $? 'GetFollowedContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 GetLikedContent
$CLI_EXE \
    --sn ugc \
    --op GetLikedContent \
    --namespace $TEST_NAMESPACE \
    --limit '31' \
    --offset '19' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLikedContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 DownloadContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op DownloadContentByShareCode \
    --namespace $TEST_NAMESPACE \
    --shareCode 'OWK0k76i' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadContentByShareCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId '1g7rYaEu' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDownloadContentByContentID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 AddDownloadCount
$CLI_EXE \
    --sn ugc \
    --op AddDownloadCount \
    --contentId 'NCyPoQ0o' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AddDownloadCount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId 'tIkAkltd' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateContentLikeStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 PublicDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentPreview \
    --contentId '1zQBzzC6' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDownloadContentPreview'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 58 GetTag
$CLI_EXE \
    --sn ugc \
    --op GetTag \
    --namespace $TEST_NAMESPACE \
    --limit '23' \
    --offset '6' \
    >$TEMP_FILE 2>&1
update_status $? 'GetTag'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 59 GetType
$CLI_EXE \
    --sn ugc \
    --op GetType \
    --namespace $TEST_NAMESPACE \
    --limit '73' \
    --offset '35' \
    >$TEMP_FILE 2>&1
update_status $? 'GetType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 60 GetFollowedUsers
$CLI_EXE \
    --sn ugc \
    --op GetFollowedUsers \
    --namespace $TEST_NAMESPACE \
    --limit '17' \
    --offset '68' \
    >$TEMP_FILE 2>&1
update_status $? 'GetFollowedUsers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 GetChannels
$CLI_EXE \
    --sn ugc \
    --op GetChannels \
    --namespace $TEST_NAMESPACE \
    --userId '6lTRbc1Z' \
    --limit '66' \
    --offset '70' \
    >$TEMP_FILE 2>&1
update_status $? 'GetChannels'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 CreateChannel
# body param: body
echo '{"name": "Hzl323Yn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateChannel \
    --namespace $TEST_NAMESPACE \
    --userId 'wf5PvGej' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 DeleteAllUserChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserChannel \
    --namespace $TEST_NAMESPACE \
    --userId 'CDgAr1pX' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 UpdateChannel
# body param: body
echo '{"name": "DcsHnobn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId 'aYxGh3Fo' \
    --namespace $TEST_NAMESPACE \
    --userId 'vBnr5VUO' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 65 DeleteChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteChannel \
    --channelId 'HGqEcuJY' \
    --namespace $TEST_NAMESPACE \
    --userId 'o3YfMDw4' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 CreateContentDirect
update_status 0 'CreateContentDirect (skipped deprecated)'

#- 67 CreateContentS3
# body param: body
echo '{"contentType": "PaBKsFXo", "fileExtension": "rxY0ahG5", "name": "AgHrE98q", "preview": "QTSXh1W7", "subType": "MnK2i8El", "tags": ["y255awvu"], "type": "lbNGSAje"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId 'iiANETlk' \
    --namespace $TEST_NAMESPACE \
    --userId 'ncKPmri3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 UpdateContentS3
# body param: body
echo '{"contentType": "6MY2aVCN", "fileExtension": "UJgcpAYb", "name": "j0fidlWP", "preview": "SAIjaw5H", "subType": "SyDsQqMU", "tags": ["PrAxUd1b"], "type": "mVSM44sc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId 'gNAZf7a3' \
    --contentId 'R9rIVTDD' \
    --namespace $TEST_NAMESPACE \
    --userId 'XZ1fahMp' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 69 UpdateContentDirect
update_status 0 'UpdateContentDirect (skipped deprecated)'

#- 70 DeleteContent
$CLI_EXE \
    --sn ugc \
    --op DeleteContent \
    --channelId '688Jv5wQ' \
    --contentId '3hbDlcGR' \
    --namespace $TEST_NAMESPACE \
    --userId 'x2aExmVb' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 71 PublicGetUserContent
$CLI_EXE \
    --sn ugc \
    --op PublicGetUserContent \
    --namespace $TEST_NAMESPACE \
    --userId 'XDomWyrF' \
    --limit '6' \
    --offset '77' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 72 DeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserContents \
    --namespace $TEST_NAMESPACE \
    --userId '00sSdUyp' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserContents'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "OvoMvIN7", "screenshotId": "cRBRxFsC"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId 'UQz0koUs' \
    --namespace $TEST_NAMESPACE \
    --userId 'UcGfjtfy' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateScreenshots'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "uPNb5exi", "description": "RtR1Qe0m", "fileExtension": "jpeg"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId 'LnvZEG2b' \
    --namespace $TEST_NAMESPACE \
    --userId 'iyKS8vfI' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UploadContentScreenshot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 75 DeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op DeleteContentScreenshot \
    --contentId 'sZ5EADM0' \
    --namespace $TEST_NAMESPACE \
    --screenshotId 'xJp6HXex' \
    --userId 'nHAXYShI' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteContentScreenshot'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 76 UpdateUserFollowStatus
# body param: body
echo '{"followStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateUserFollowStatus \
    --namespace $TEST_NAMESPACE \
    --userId '82ffzx6W' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserFollowStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 77 GetGroups
$CLI_EXE \
    --sn ugc \
    --op GetGroups \
    --namespace $TEST_NAMESPACE \
    --userId 'CUdwQniv' \
    --limit '77' \
    --offset '39' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 78 CreateGroup
# body param: body
echo '{"contents": ["fIoSsKaP"], "name": "5KNn0UGr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $TEST_NAMESPACE \
    --userId '95D9Vatf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 79 DeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserGroup \
    --namespace $TEST_NAMESPACE \
    --userId 'xBoakHUq' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 80 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId 'z2uOKJVj' \
    --namespace $TEST_NAMESPACE \
    --userId 'X7j5MgRZ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 81 UpdateGroup
# body param: body
echo '{"contents": ["3kPmSrNa"], "name": "FzJwBceJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId 'Q0viEYQy' \
    --namespace $TEST_NAMESPACE \
    --userId '4JxBkyXf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 82 DeleteGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteGroup \
    --groupId 'gwzMTAlT' \
    --namespace $TEST_NAMESPACE \
    --userId '2q2EbG4Z' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 83 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId '95SldyWe' \
    --namespace $TEST_NAMESPACE \
    --userId '2X8cLes0' \
    --limit '91' \
    --offset '87' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroupContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 84 DeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserStates \
    --namespace $TEST_NAMESPACE \
    --userId 'TAekrfR3' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserStates'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT