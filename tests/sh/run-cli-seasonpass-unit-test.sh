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

OPERATIONS_COUNT=39

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

#- 1 QuerySeasons
$CLI_EXE \
    --sn seasonpass \
    --op QuerySeasons \
    --namespace $TEST_NAMESPACE \
    --limit '2' \
    --offset '56' \
    --status '["DRAFT"]' \
    >$TEMP_FILE 2>&1
update_status $? 'QuerySeasons'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 CreateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "4Ax7NzYk", "defaultRequiredExp": 28, "draftStoreId": "ppa0VgFJ", "end": "1984-03-02T00:00:00Z", "excessStrategy": {"currency": "HwTb5q01", "method": "NONE", "percentPerExp": 79}, "images": [{"as": "2MQrbpeR", "caption": "nxTlCTFS", "height": 76, "imageUrl": "Ibl1a2jX", "smallImageUrl": "LCtWmHJB", "width": 17}], "localizations": {"9SoMkSE4": {"description": "eJelwO4K", "title": "PMky2h8R"}}, "name": "2fIXoXP8", "start": "1974-01-30T00:00:00Z", "tierItemId": "7JUabYc3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateSeason \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentSeason \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'GMbxTlm1' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'fsu6J3C4' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 UpdateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "5ppGR9Xc", "defaultRequiredExp": 29, "draftStoreId": "xYTGgewr", "end": "1989-02-07T00:00:00Z", "excessStrategy": {"currency": "wvzJF4Tp", "method": "NONE", "percentPerExp": 79}, "images": [{"as": "hKq2xdmg", "caption": "EBepFHtf", "height": 17, "imageUrl": "egqdEL4f", "smallImageUrl": "sM6nBzRV", "width": 40}], "localizations": {"C1r7UH1L": {"description": "iu7UQ030", "title": "4McK873t"}}, "name": "Rtr5cfWO", "start": "1999-10-09T00:00:00Z", "tierItemId": "J2c6vsOn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 's4jNWGc7' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 CloneSeason
# body param: body
echo '{"end": "1985-03-08T00:00:00Z", "name": "Ua4wM5Eu", "start": "1998-05-09T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'ymsFXpor' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CloneSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $TEST_NAMESPACE \
    --seasonId 'MqEDR8E7' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPasses'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 CreatePass
# body param: body
echo '{"autoEnroll": false, "code": "hl6eq2Fz", "displayOrder": 92, "images": [{"as": "3VL3LNmP", "caption": "LeZdoCXf", "height": 1, "imageUrl": "bFXzvjLm", "smallImageUrl": "ai7fPKvE", "width": 1}], "localizations": {"63UVtLbQ": {"description": "SWtsyz0m", "title": "GGyHHFIl"}}, "passItemId": "IKsXgvSr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $TEST_NAMESPACE \
    --seasonId 'kEgTYVk5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'iRBE6zJJ' \
    --namespace $TEST_NAMESPACE \
    --seasonId '1BRHrfCH' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'qqp2GwPc' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'mzSuY8w9' \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 54, "images": [{"as": "EfRXoZLf", "caption": "pVFfDwjH", "height": 66, "imageUrl": "CW2g5u8z", "smallImageUrl": "9yrpJdIx", "width": 42}], "localizations": {"vHS3d6PK": {"description": "PE27mI6P", "title": "x8jt8Lq4"}}, "passItemId": "x0F7Ncoc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'elJjtlKY' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'u8iCPznx' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId '0s5TzT51' \
    >$TEMP_FILE 2>&1
update_status $? 'PublishSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'oV4HTmiv' \
    --force 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'RetireSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $TEST_NAMESPACE \
    --seasonId 'b6tPmCir' \
    --q 'khYvcOUu' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 CreateReward
# body param: body
echo '{"code": "cjPWGwPs", "currency": {"currencyCode": "vjLK1CjP", "namespace": "t93utbMk"}, "image": {"as": "pUFHT0fL", "caption": "9q9SMNAU", "height": 85, "imageUrl": "VoiQtSQC", "smallImageUrl": "2kNSsmT0", "width": 6}, "itemId": "2aBG4zA2", "quantity": 51, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $TEST_NAMESPACE \
    --seasonId '1Ls0bD6d' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'GgwkYgHz' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'KuI2RJrb' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'oP7kfpIl' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'etXrCK1U' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "VO0jcs7n", "namespace": "CqsodoTF"}, "image": {"as": "TcWlaIBJ", "caption": "AAknU6Ho", "height": 2, "imageUrl": "ZgWlaLne", "smallImageUrl": "dDfasTc8", "width": 12}, "itemId": "r2znWqD6", "nullFields": ["tIcfI5Z4"], "quantity": 38, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'QPjCalZg' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'FVEQyqav' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $TEST_NAMESPACE \
    --seasonId '09OYmxCv' \
    --limit '76' \
    --offset '33' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryTiers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 CreateTier
# body param: body
echo '{"index": 95, "quantity": 5, "tier": {"requiredExp": 99, "rewards": {"s2OqNz8Z": ["LBsncbRr"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $TEST_NAMESPACE \
    --seasonId 'f6uEdjUn' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 UpdateTier
# body param: body
echo '{"requiredExp": 34, "rewards": {"04WZNhgE": ["GvqKWQTk"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'E65j6186' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'p0WfsnWZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'uUPsaRnV' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'drdBA2hX' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 ReorderTier
# body param: body
echo '{"newIndex": 45}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'YyzZMdlR' \
    --namespace $TEST_NAMESPACE \
    --seasonId '4cL76hnF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ReorderTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'DgTfofHd' \
    --force 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'UnpublishSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $TEST_NAMESPACE \
    --userId 'oSqDcaFh' \
    --limit '80' \
    --offset '4' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserParticipatedSeasons'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 GrantUserExp
# body param: body
echo '{"exp": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $TEST_NAMESPACE \
    --userId 'KxI8f5oc' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserExp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 GrantUserPass
# body param: body
echo '{"passCode": "fy4EIxwB", "passItemId": "iB90vdgS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $TEST_NAMESPACE \
    --userId '5YpKsdbp' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserPass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $TEST_NAMESPACE \
    --userId 'iU2UfyMO' \
    --passCodes '["4DhL9fBK"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ExistsAnyPassByPassCodes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $TEST_NAMESPACE \
    --userId 'JvjBOUn3' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentUserSeasonProgression'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "bYf5ouXq", "tierItemCount": 21, "tierItemId": "biExqT6D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $TEST_NAMESPACE \
    --userId 'k9QFqaAj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CheckSeasonPurchasable'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $TEST_NAMESPACE \
    --userId 'hwOI1P04' \
    >$TEMP_FILE 2>&1
update_status $? 'ResetUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 GrantUserTier
# body param: body
echo '{"count": 7}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $TEST_NAMESPACE \
    --userId 'MHfTwrxB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'RfMxZrSf' \
    --userId 'x3V8OXkM' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $TEST_NAMESPACE \
    --language 'ng7p2SyF' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCurrentSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $TEST_NAMESPACE \
    --userId 'DEnmYQze' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCurrentUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 PublicClaimUserReward
# body param: body
echo '{"passCode": "hPBqD12D", "rewardCode": "vvzNNZSu", "tierIndex": 51}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $TEST_NAMESPACE \
    --userId 'ZVgY3Zos' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicClaimUserReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $TEST_NAMESPACE \
    --userId 'fd01vaOG' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkClaimUserRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'weHacvHR' \
    --userId 'V345xB8h' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT