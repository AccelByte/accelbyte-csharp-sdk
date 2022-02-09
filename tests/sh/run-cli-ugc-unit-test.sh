#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="dotnet ../../AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/AccelByte.Sdk.Sample.Cli.dll"
CLI_TOKEN_FILE="../../AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/token.txt"

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
    --limit 'b0Cjv4Ax' \
    --offset '7NzYkopp' \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 AdminCreateChannel
# body param: body
echo '{"name": "a0VgFJAh"}' > $TEMP_JSON_INPUT
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
echo '{"name": "HwTb5q01"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateChannel \
    --channelId '0gN2MQrb' \
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
    --channelId 'peRnxTlC' \
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
echo '{"contentType": "TFSMIbl1", "fileExtension": "a2jXLCtW", "name": "mHJBi9So", "preview": "MkSE4eJe", "subType": "lwO4KPMk", "tags": ["y2h8R2fI"], "type": "XoXP8gd7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentS3 \
    --channelId 'JUabYc3G' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUploadContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 SingleAdminUpdateContentS3
# body param: body
echo '{"contentType": "MbxTlm1f", "fileExtension": "su6J3C4s", "name": "5ppGR9Xc", "preview": "oxYTGgew", "subType": "rLfwvzJF", "tags": ["4TpbNhKq"], "type": "2xdmgEBe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateContentS3 \
    --channelId 'pFHtf6Zi' \
    --contentId 'egqdEL4f' \
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
    --channelId 'sM6nBzRV' \
    --namespace $TEST_NAMESPACE \
    --creator 'uC1r7UH1' \
    --isofficial 'Liu7UQ03' \
    --limit '04McK873' \
    --name 'tRtr5cfW' \
    --offset 'O5JJ2c6v' \
    --orderby 'sOns4jNW' \
    --sortby 'Gc7CiUa4' \
    --subtype 'wM5Eu3Vq' \
    --tags 'ymsFXpor' \
    --type 'MqEDR8E7' \
    --userId '2XMKfhl6' \
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
    --channelId 'eq2FzU3V' \
    --contentId 'L3LNmPLe' \
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
    --limit 'ZdoCXfab' \
    --offset 'FXzvjLma' \
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
    --creator 'i7fPKvE2' \
    --isofficial 'Z4a63UVt' \
    --limit 'LbQSWtsy' \
    --name 'z0mGGyHH' \
    --offset 'FIlIKsXg' \
    --orderby 'vSrkEgTY' \
    --sortby 'Vk5iRBE6' \
    --subtype 'zJJ1BRHr' \
    --tags 'fCHqqp2G' \
    --type 'wPcmzSuY' \
    --userId '8w9VYwBE' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchContent'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 AdminGetSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetSpecificContent \
    --contentId 'fRXoZLfp' \
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
    --contentId 'VFfDwjHH' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDownloadContentPreview'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 AdminUpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "CW2g5u8z", "screenshotId": "9yrpJdIx"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateScreenshots \
    --contentId '5vvHS3d6' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateScreenshots'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 AdminUploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "PKPE27mI", "description": "6Px8jt8L", "fileExtension": "jpeg"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentScreenshot \
    --contentId '4x0F7Nco' \
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
    --contentId 'celJjtlK' \
    --namespace $TEST_NAMESPACE \
    --screenshotId 'Yu8iCPzn' \
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
    --limit 'x0s5TzT5' \
    --offset '1oV4HTmi' \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetAllGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 AdminCreateGroup
# body param: body
echo '{"contents": ["vmb6tPmC"], "name": "irkhYvcO"}' > $TEMP_JSON_INPUT
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
    --groupId 'UucjPWGw' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'SingleAdminGetGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 SingleAdminUpdateGroup
# body param: body
echo '{"contents": ["PsvjLK1C"], "name": "jPt93utb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateGroup \
    --groupId 'MkpUFHT0' \
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
    --groupId 'fL9q9SMN' \
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
    --groupId 'AUQVoiQt' \
    --namespace $TEST_NAMESPACE \
    --limit 'SQC2kNSs' \
    --offset 'mT0d2aBG' \
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
    --limit '4zA2zp1L' \
    --offset 's0bD6dGg' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetTag'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 AdminCreateTag
# body param: body
echo '{"tag": "wkYgHzKu"}' > $TEMP_JSON_INPUT
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
echo '{"tag": "I2RJrboP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateTag \
    --namespace $TEST_NAMESPACE \
    --tagId '7kfpIlet' \
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
    --tagId 'XrCK1UVO' \
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
    --limit '0jcs7nCq' \
    --offset 'sodoTFTc' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 AdminCreateType
# body param: body
echo '{"subtype": ["WlaIBJAA"], "type": "knU6HobZ"}' > $TEMP_JSON_INPUT
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
echo '{"subtype": ["gWlaLned"], "type": "DfasTc8g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateType \
    --namespace $TEST_NAMESPACE \
    --typeId 'r2znWqD6' \
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
    --typeId 'tIcfI5Z4' \
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
    --userId 'tUNQ7mQP' \
    --limit 'jCalZgFV' \
    --offset 'EQyqav09' \
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
    --userId 'OYmxCvMq' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserChannels'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 AdminUpdateChannel
# body param: body
echo '{"name": "VcXs2OqN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateChannel \
    --channelId 'z8ZLBsnc' \
    --namespace $TEST_NAMESPACE \
    --userId 'bRrf6uEd' \
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
    --channelId 'jUnr04WZ' \
    --namespace $TEST_NAMESPACE \
    --userId 'NhgEGvqK' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 AdminUpdateContentS3
# body param: body
echo '{"contentType": "WQTkE65j", "fileExtension": "6186p0Wf", "name": "snWZuUPs", "preview": "aRnVdrdB", "subType": "A2hXwYyz", "tags": ["ZMdlR4cL"], "type": "76hnFDgT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateContentS3 \
    --channelId 'fofHdfoS' \
    --contentId 'qDcaFhOc' \
    --namespace $TEST_NAMESPACE \
    --userId '1oKxI8f5' \
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
    --channelId 'ocfy4EIx' \
    --contentId 'wBiB90vd' \
    --namespace $TEST_NAMESPACE \
    --userId 'gS5YpKsd' \
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
    --userId 'bpiU2Ufy' \
    --limit 'MO4DhL9f' \
    --offset 'BKJvjBOU' \
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
    --userId 'n3bYf5ou' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserContents'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 AdminHideUserContent
# body param: body
echo '{"isHidden": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminHideUserContent \
    --contentId 'kbiExqT6' \
    --namespace $TEST_NAMESPACE \
    --userId 'Dk9QFqaA' \
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
    --userId 'jhwOI1P0' \
    --limit '4dMHfTwr' \
    --offset 'xBRfMxZr' \
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
    --userId 'Sfx3V8OX' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 AdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroup \
    --groupId 'kMng7p2S' \
    --namespace $TEST_NAMESPACE \
    --userId 'yFDEnmYQ' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 AdminUpdateGroup
# body param: body
echo '{"contents": ["zehPBqD1"], "name": "2DvvzNNZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateGroup \
    --groupId 'Su5zZVgY' \
    --namespace $TEST_NAMESPACE \
    --userId '3Zosfd01' \
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
    --groupId 'vaOGweHa' \
    --namespace $TEST_NAMESPACE \
    --userId 'cvHRV345' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 AdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroupContents \
    --groupId 'xB8hos4y' \
    --namespace $TEST_NAMESPACE \
    --userId 'aOBjMxiz' \
    --limit 'Cxx9qTOI' \
    --offset 'Klpdrqo2' \
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
    --userId 'smD9RPpj' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteAllUserStates'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 SearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op SearchChannelSpecificContent \
    --channelId 'OWK0k76i' \
    --namespace $TEST_NAMESPACE \
    --creator '1g7rYaEu' \
    --isofficial 'NCyPoQ0o' \
    --limit 'HYXUQdtI' \
    --name 'kAkltd1z' \
    --offset 'QBzzC6ld' \
    --orderby 'KriI6lTR' \
    --sortby 'bc1Z1HJH' \
    --subtype 'zl323Ynw' \
    --tags 'f5PvGejC' \
    --type 'DgAr1pXD' \
    --userId 'csHnobna' \
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
    --creator 'YxGh3Fov' \
    --isofficial 'Bnr5VUOH' \
    --limit 'GqEcuJYo' \
    --name '3YfMDw4P' \
    --offset 'aBKsFXor' \
    --orderby 'xY0ahG5A' \
    --sortby 'gHrE98qQ' \
    --subtype 'TSXh1W7M' \
    --tags 'nK2i8Ely' \
    --type '255awvul' \
    --userId 'bNGSAjei' \
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
    --limit 'iANETlkn' \
    --offset 'cKPmri36' \
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
    --limit 'MY2aVCNU' \
    --offset 'JgcpAYbj' \
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
    --shareCode '0fidlWPS' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadContentByShareCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId 'AIjaw5HS' \
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
    --contentId 'yDsQqMUP' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AddDownloadCount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId 'AxUd1bmV' \
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
    --contentId 'SM44scgN' \
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
    --limit 'AZf7a3R9' \
    --offset 'rIVTDDXZ' \
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
    --limit '1fahMp68' \
    --offset '8Jv5wQ3h' \
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
    --limit 'bDlcGRx2' \
    --offset 'aExmVbXD' \
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
    --userId 'omWyrFZZ' \
    --limit 'dM00sSdU' \
    --offset 'ypOvoMvI' \
    >$TEMP_FILE 2>&1
update_status $? 'GetChannels'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 CreateChannel
# body param: body
echo '{"name": "N7cRBRxF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateChannel \
    --namespace $TEST_NAMESPACE \
    --userId 'sCUQz0ko' \
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
    --userId 'UsUcGfjt' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 UpdateChannel
# body param: body
echo '{"name": "fyuPNb5e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId 'xiRtR1Qe' \
    --namespace $TEST_NAMESPACE \
    --userId '0mxLnvZE' \
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
    --channelId 'G2biyKS8' \
    --namespace $TEST_NAMESPACE \
    --userId 'vfIsZ5EA' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteChannel'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 CreateContentDirect
update_status 0 'CreateContentDirect (skipped deprecated)'

#- 67 CreateContentS3
# body param: body
echo '{"contentType": "DM0xJp6H", "fileExtension": "XexnHAXY", "name": "ShIg82ff", "preview": "zx6WCUdw", "subType": "QnivM1tf", "tags": ["IoSsKaP5"], "type": "KNn0UGr9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId '5D9Vatfx' \
    --namespace $TEST_NAMESPACE \
    --userId 'BoakHUqz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateContentS3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 UpdateContentS3
# body param: body
echo '{"contentType": "2uOKJVjX", "fileExtension": "7j5MgRZ3", "name": "kPmSrNaF", "preview": "zJwBceJQ", "subType": "0viEYQy4", "tags": ["JxBkyXfg"], "type": "wzMTAlT2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId 'q2EbG4Z9' \
    --contentId '5SldyWe2' \
    --namespace $TEST_NAMESPACE \
    --userId 'X8cLes0T' \
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
    --channelId 'RTAekrfR' \
    --contentId '30IRA6Cz' \
    --namespace $TEST_NAMESPACE \
    --userId 'cXFcjRpu' \
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
    --userId '7wVEzbwH' \
    --limit 'vOGqwb7F' \
    --offset 'AI8lxDoR' \
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
    --userId 'twKNHCnc' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserContents'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "WRyVDPNR", "screenshotId": "FIbOIi02"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId '1vVF26yE' \
    --namespace $TEST_NAMESPACE \
    --userId 'KnKL26vT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateScreenshots'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "Dvjjj8aE", "description": "PjDWSwW5", "fileExtension": "pjp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId 'HTuJ1jV4' \
    --namespace $TEST_NAMESPACE \
    --userId 'EKppV4Df' \
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
    --contentId 'Txfj3AGr' \
    --namespace $TEST_NAMESPACE \
    --screenshotId 'DhoJooH5' \
    --userId 'WNF4d6DE' \
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
    --userId 'HRwigr03' \
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
    --userId '9B7fw1zH' \
    --limit 'G7KQTrQe' \
    --offset 'Iv8R1CtN' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 78 CreateGroup
# body param: body
echo '{"contents": ["kXpuQ4g9"], "name": "IiLxJpTl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $TEST_NAMESPACE \
    --userId 'IMuKCdAt' \
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
    --userId '0XTdLLO1' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 80 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId 'WSvdw7FI' \
    --namespace $TEST_NAMESPACE \
    --userId '8mOSB2rv' \
    >$TEMP_FILE 2>&1
update_status $? 'GetGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 81 UpdateGroup
# body param: body
echo '{"contents": ["QkdnYlPH"], "name": "6J70BXWV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId 'txOyZzUr' \
    --namespace $TEST_NAMESPACE \
    --userId 'VRKRtJuZ' \
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
    --groupId '5W7nPrKt' \
    --namespace $TEST_NAMESPACE \
    --userId 'USflKqC3' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 83 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId '1jYv8832' \
    --namespace $TEST_NAMESPACE \
    --userId 'yIJUngm7' \
    --limit 'GSrElr5m' \
    --offset 'gz0RyG8S' \
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
    --userId 'ZmnOvu24' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAllUserStates'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT