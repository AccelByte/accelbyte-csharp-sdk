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
echo "1..40"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 QuerySeasons
$CLI_EXE \
    --sn seasonpass \
    --op QuerySeasons \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    --status '["DRAFT"]' \
    > test.out 2>&1
eval_tap $? 2 'QuerySeasons' test.out

#- 3 CreateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "4Ax7NzYk", "defaultRequiredExp": 28, "draftStoreId": "ppa0VgFJ", "end": "1984-03-02T00:00:00Z", "excessStrategy": {"currency": "HwTb5q01", "method": "NONE", "percentPerExp": 79}, "images": [{"as": "2MQrbpeR", "caption": "nxTlCTFS", "height": 76, "imageUrl": "Ibl1a2jX", "smallImageUrl": "LCtWmHJB", "width": 17}], "localizations": {"9SoMkSE4": {"description": "eJelwO4K", "title": "PMky2h8R"}}, "name": "2fIXoXP8", "start": "1974-01-30T00:00:00Z", "tierItemId": "7JUabYc3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateSeason \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateSeason' test.out

#- 4 GetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentSeason \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'GetCurrentSeason' test.out

#- 5 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'GMbxTlm1' \
    > test.out 2>&1
eval_tap $? 5 'GetSeason' test.out

#- 6 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'fsu6J3C4' \
    > test.out 2>&1
eval_tap $? 6 'DeleteSeason' test.out

#- 7 UpdateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "5ppGR9Xc", "defaultRequiredExp": 29, "draftStoreId": "xYTGgewr", "end": "1989-02-07T00:00:00Z", "excessStrategy": {"currency": "wvzJF4Tp", "method": "NONE", "percentPerExp": 79}, "images": [{"as": "hKq2xdmg", "caption": "EBepFHtf", "height": 17, "imageUrl": "egqdEL4f", "smallImageUrl": "sM6nBzRV", "width": 40}], "localizations": {"C1r7UH1L": {"description": "iu7UQ030", "title": "4McK873t"}}, "name": "Rtr5cfWO", "start": "1999-10-09T00:00:00Z", "tierItemId": "J2c6vsOn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 's4jNWGc7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateSeason' test.out

#- 8 CloneSeason
# body param: body
echo '{"end": "1985-03-08T00:00:00Z", "name": "Ua4wM5Eu", "start": "1998-05-09T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'ymsFXpor' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'CloneSeason' test.out

#- 9 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'MqEDR8E7' \
    > test.out 2>&1
eval_tap $? 9 'QueryPasses' test.out

#- 10 CreatePass
# body param: body
echo '{"autoEnroll": false, "code": "hl6eq2Fz", "displayOrder": 92, "images": [{"as": "3VL3LNmP", "caption": "LeZdoCXf", "height": 1, "imageUrl": "bFXzvjLm", "smallImageUrl": "ai7fPKvE", "width": 1}], "localizations": {"63UVtLbQ": {"description": "SWtsyz0m", "title": "GGyHHFIl"}}, "passItemId": "IKsXgvSr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'kEgTYVk5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CreatePass' test.out

#- 11 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'iRBE6zJJ' \
    --namespace $AB_NAMESPACE \
    --seasonId '1BRHrfCH' \
    > test.out 2>&1
eval_tap $? 11 'GetPass' test.out

#- 12 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'qqp2GwPc' \
    --namespace $AB_NAMESPACE \
    --seasonId 'mzSuY8w9' \
    > test.out 2>&1
eval_tap $? 12 'DeletePass' test.out

#- 13 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 54, "images": [{"as": "EfRXoZLf", "caption": "pVFfDwjH", "height": 66, "imageUrl": "CW2g5u8z", "smallImageUrl": "9yrpJdIx", "width": 42}], "localizations": {"vHS3d6PK": {"description": "PE27mI6P", "title": "x8jt8Lq4"}}, "passItemId": "x0F7Ncoc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'elJjtlKY' \
    --namespace $AB_NAMESPACE \
    --seasonId 'u8iCPznx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdatePass' test.out

#- 14 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '0s5TzT51' \
    > test.out 2>&1
eval_tap $? 14 'PublishSeason' test.out

#- 15 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'oV4HTmiv' \
    --force 'False' \
    > test.out 2>&1
eval_tap $? 15 'RetireSeason' test.out

#- 16 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId 'b6tPmCir' \
    --q 'khYvcOUu' \
    > test.out 2>&1
eval_tap $? 16 'QueryRewards' test.out

#- 17 CreateReward
# body param: body
echo '{"code": "cjPWGwPs", "currency": {"currencyCode": "vjLK1CjP", "namespace": "t93utbMk"}, "image": {"as": "pUFHT0fL", "caption": "9q9SMNAU", "height": 85, "imageUrl": "VoiQtSQC", "smallImageUrl": "2kNSsmT0", "width": 6}, "itemId": "2aBG4zA2", "quantity": 51, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId '1Ls0bD6d' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'CreateReward' test.out

#- 18 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'GgwkYgHz' \
    --namespace $AB_NAMESPACE \
    --seasonId 'KuI2RJrb' \
    > test.out 2>&1
eval_tap $? 18 'GetReward' test.out

#- 19 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'oP7kfpIl' \
    --namespace $AB_NAMESPACE \
    --seasonId 'etXrCK1U' \
    > test.out 2>&1
eval_tap $? 19 'DeleteReward' test.out

#- 20 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "VO0jcs7n", "namespace": "CqsodoTF"}, "image": {"as": "TcWlaIBJ", "caption": "AAknU6Ho", "height": 2, "imageUrl": "ZgWlaLne", "smallImageUrl": "dDfasTc8", "width": 12}, "itemId": "r2znWqD6", "nullFields": ["tIcfI5Z4"], "quantity": 38, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'QPjCalZg' \
    --namespace $AB_NAMESPACE \
    --seasonId 'FVEQyqav' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateReward' test.out

#- 21 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId '09OYmxCv' \
    --limit '76' \
    --offset '33' \
    > test.out 2>&1
eval_tap $? 21 'QueryTiers' test.out

#- 22 CreateTier
# body param: body
echo '{"index": 95, "quantity": 5, "tier": {"requiredExp": 99, "rewards": {"s2OqNz8Z": ["LBsncbRr"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'f6uEdjUn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreateTier' test.out

#- 23 UpdateTier
# body param: body
echo '{"requiredExp": 34, "rewards": {"04WZNhgE": ["GvqKWQTk"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'E65j6186' \
    --namespace $AB_NAMESPACE \
    --seasonId 'p0WfsnWZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateTier' test.out

#- 24 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'uUPsaRnV' \
    --namespace $AB_NAMESPACE \
    --seasonId 'drdBA2hX' \
    > test.out 2>&1
eval_tap $? 24 'DeleteTier' test.out

#- 25 ReorderTier
# body param: body
echo '{"newIndex": 45}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'YyzZMdlR' \
    --namespace $AB_NAMESPACE \
    --seasonId '4cL76hnF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'ReorderTier' test.out

#- 26 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'DgTfofHd' \
    --force 'False' \
    > test.out 2>&1
eval_tap $? 26 'UnpublishSeason' test.out

#- 27 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'oSqDcaFh' \
    --limit '80' \
    --offset '4' \
    > test.out 2>&1
eval_tap $? 27 'GetUserParticipatedSeasons' test.out

#- 28 GrantUserExp
# body param: body
echo '{"exp": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'KxI8f5oc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'GrantUserExp' test.out

#- 29 GrantUserPass
# body param: body
echo '{"passCode": "fy4EIxwB", "passItemId": "iB90vdgS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId '5YpKsdbp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'GrantUserPass' test.out

#- 30 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'iU2UfyMO' \
    --passCodes '["4DhL9fBK"]' \
    > test.out 2>&1
eval_tap $? 30 'ExistsAnyPassByPassCodes' test.out

#- 31 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'JvjBOUn3' \
    > test.out 2>&1
eval_tap $? 31 'GetCurrentUserSeasonProgression' test.out

#- 32 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "bYf5ouXq", "tierItemCount": 21, "tierItemId": "biExqT6D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'k9QFqaAj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'CheckSeasonPurchasable' test.out

#- 33 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'hwOI1P04' \
    > test.out 2>&1
eval_tap $? 33 'ResetUserSeason' test.out

#- 34 GrantUserTier
# body param: body
echo '{"count": 7}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId 'MHfTwrxB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'GrantUserTier' test.out

#- 35 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'RfMxZrSf' \
    --userId 'x3V8OXkM' \
    > test.out 2>&1
eval_tap $? 35 'GetUserSeason' test.out

#- 36 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'ng7p2SyF' \
    > test.out 2>&1
eval_tap $? 36 'PublicGetCurrentSeason' test.out

#- 37 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'DEnmYQze' \
    > test.out 2>&1
eval_tap $? 37 'PublicGetCurrentUserSeason' test.out

#- 38 PublicClaimUserReward
# body param: body
echo '{"passCode": "hPBqD12D", "rewardCode": "vvzNNZSu", "tierIndex": 51}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'ZVgY3Zos' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicClaimUserReward' test.out

#- 39 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'fd01vaOG' \
    > test.out 2>&1
eval_tap $? 39 'PublicBulkClaimUserRewards' test.out

#- 40 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'weHacvHR' \
    --userId 'V345xB8h' \
    > test.out 2>&1
eval_tap $? 40 'PublicGetUserSeason' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE