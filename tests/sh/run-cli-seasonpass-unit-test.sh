#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="/tmp/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=38

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

#- 1 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'b0Cjv4Ax' \
    --namespace $TEST_NAMESPACE \
    --seasonId '7NzYkopp' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'a0VgFJAh' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'HwTb5q01' \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 UpdatePass
# body param: body
echo '{"displayOrder": 12, "autoEnroll": true, "passItemId": "bpeRnxTl", "localizations": {"CTFSMIbl": {"title": "1a2jXLCt", "description": "WmHJBi9S"}}, "images": [{"as": "oMkSE4eJ", "caption": "elwO4KPM", "height": 20, "width": 48, "imageUrl": "2h8R2fIX", "smallImageUrl": "oXP8gd7J"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'UabYc3GM' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'bxTlm1fs' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $TEST_NAMESPACE \
    --seasonId 'u6J3C4s5' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPasses'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 CreatePass
# body param: body
echo '{"code": "ppGR9Xco", "displayOrder": 46, "autoEnroll": false, "passItemId": "ewrLfwvz", "localizations": {"JF4TpbNh": {"title": "Kq2xdmgE", "description": "BepFHtf6"}}, "images": [{"as": "ZiegqdEL", "caption": "4fsM6nBz", "height": 87, "width": 95, "imageUrl": "uC1r7UH1", "smallImageUrl": "Liu7UQ03"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $TEST_NAMESPACE \
    --seasonId '04McK873' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'tRtr5cfW' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'O5JJ2c6v' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'sOns4jNW' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'Gc7CiUa4' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 UpdateReward
# body param: body
echo '{"type": "CURRENCY", "itemId": "M5Eu3Vqy", "currency": {"namespace": "msFXporM", "currencyCode": "qEDR8E72"}, "quantity": 99, "image": {"as": "MKfhl6eq", "caption": "2FzU3VL3", "height": 74, "width": 79, "imageUrl": "mPLeZdoC", "smallImageUrl": "XfabFXzv"}, "nullFields": ["jLmai7fP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'KvE2Z4a6' \
    --namespace $TEST_NAMESPACE \
    --seasonId '3UVtLbQS' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $TEST_NAMESPACE \
    --seasonId 'Wtsyz0mG' \
    --q 'GyHHFIlI' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 CreateReward
# body param: body
echo '{"code": "KsXgvSrk", "type": "CURRENCY", "itemId": "gTYVk5iR", "currency": {"namespace": "BE6zJJ1B", "currencyCode": "RHrfCHqq"}, "quantity": 31, "image": {"as": "2GwPcmzS", "caption": "uY8w9VYw", "height": 54, "width": 60, "imageUrl": "fRXoZLfp", "smallImageUrl": "VFfDwjHH"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $TEST_NAMESPACE \
    --seasonId 'CW2g5u8z' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId '9yrpJdIx' \
    --force 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'UnpublishSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'vHS3d6PK' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'PE27mI6P' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 UpdateSeason
# body param: body
echo '{"name": "x8jt8Lq4", "start": "1982-09-08T00:00:00Z", "end": "1990-01-18T00:00:00Z", "defaultLanguage": "ocelJjtl", "defaultRequiredExp": 73, "draftStoreId": "Yu8iCPzn", "tierItemId": "x0s5TzT5", "autoClaim": false, "excessStrategy": {"method": "NONE", "currency": "ivmb6tPm", "percentPerExp": 56}, "localizations": {"irkhYvcO": {"title": "UucjPWGw", "description": "PsvjLK1C"}}, "images": [{"as": "jPt93utb", "caption": "MkpUFHT0", "height": 10, "width": 75, "imageUrl": "9q9SMNAU", "smallImageUrl": "QVoiQtSQ"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'C2kNSsmT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 CloneSeason
# body param: body
echo '{"name": "0d2aBG4z", "start": "1984-07-23T00:00:00Z", "end": "1978-10-24T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 's0bD6dGg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CloneSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 QuerySeasons
$CLI_EXE \
    --sn seasonpass \
    --op QuerySeasons \
    --namespace $TEST_NAMESPACE \
    --limit '45' \
    --offset '21' \
    --status '["DRAFT"]' \
    >$TEMP_FILE 2>&1
update_status $? 'QuerySeasons'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 CreateSeason
# body param: body
echo '{"name": "HzKuI2RJ", "start": "1979-01-12T00:00:00Z", "end": "1978-11-27T00:00:00Z", "defaultLanguage": "7kfpIlet", "defaultRequiredExp": 99, "draftStoreId": "rCK1UVO0", "tierItemId": "jcs7nCqs", "autoClaim": false, "excessStrategy": {"method": "NONE", "currency": "oTFTcWla", "percentPerExp": 68}, "localizations": {"BJAAknU6": {"title": "HobZgWla", "description": "LnedDfas"}}, "images": [{"as": "Tc8gr2zn", "caption": "WqD6tIcf", "height": 69, "width": 38, "imageUrl": "UNQ7mQPj", "smallImageUrl": "CalZgFVE"}]}' > $TEMP_JSON_INPUT
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

#- 18 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'Qyqav09O' \
    --force 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'RetireSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'xCvMqVcX' \
    >$TEMP_FILE 2>&1
update_status $? 'PublishSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 GetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentSeason \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 UpdateTier
# body param: body
echo '{"requiredExp": 37, "rewards": {"2OqNz8ZL": ["BsncbRrf"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id '6uEdjUnr' \
    --namespace $TEST_NAMESPACE \
    --seasonId '04WZNhgE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'GvqKWQTk' \
    --namespace $TEST_NAMESPACE \
    --seasonId 'E65j6186' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $TEST_NAMESPACE \
    --seasonId 'p0WfsnWZ' \
    --limit '40' \
    --offset '92' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryTiers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 CreateTier
# body param: body
echo '{"index": 82, "quantity": 37, "tier": {"requiredExp": 1, "rewards": {"RnVdrdBA": ["2hXwYyzZ"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $TEST_NAMESPACE \
    --seasonId 'MdlR4cL7' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $TEST_NAMESPACE \
    --userId '6hnFDgTf' \
    --passCodes '["ofHdfoSq"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ExistsAnyPassByPassCodes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GrantUserTier
# body param: body
echo '{"count": 59}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $TEST_NAMESPACE \
    --userId 'caFhOc1o' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserTier'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'KxI8f5oc' \
    --userId 'fy4EIxwB' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "iB90vdgS", "tierItemId": "5YpKsdbp", "tierItemCount": 16}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $TEST_NAMESPACE \
    --userId 'U2UfyMO4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CheckSeasonPurchasable'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $TEST_NAMESPACE \
    --userId 'DhL9fBKJ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrentUserSeasonProgression'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $TEST_NAMESPACE \
    --userId 'vjBOUn3b' \
    >$TEMP_FILE 2>&1
update_status $? 'ResetUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 GrantUserPass
# body param: body
echo '{"passItemId": "Yf5ouXqk", "passCode": "biExqT6D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $TEST_NAMESPACE \
    --userId 'k9QFqaAj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserPass'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $TEST_NAMESPACE \
    --userId 'hwOI1P04' \
    --limit '7' \
    --offset '77' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserParticipatedSeasons'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 GrantUserExp
# body param: body
echo '{"exp": 67}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $TEST_NAMESPACE \
    --userId 'fTwrxBRf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserExp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $TEST_NAMESPACE \
    --language 'MxZrSfx3' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCurrentSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 PublicClaimUserReward
# body param: body
echo '{"passCode": "V8OXkMng", "tierIndex": 31, "rewardCode": "2SyFDEnm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $TEST_NAMESPACE \
    --userId 'YQzehPBq' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicClaimUserReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $TEST_NAMESPACE \
    --userId 'D12DvvzN' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCurrentUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $TEST_NAMESPACE \
    --userId 'NZSu5zZV' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkClaimUserRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $TEST_NAMESPACE \
    --seasonId 'gY3Zosfd' \
    --userId '01vaOGwe' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSeason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT