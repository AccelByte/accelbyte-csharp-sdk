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
echo "1..44"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 QuerySeasons
$CLI_EXE \
    --sn seasonpass \
    --op QuerySeasons \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '88' \
    --status '["PUBLISHED", "DRAFT", "DRAFT"]' \
    > test.out 2>&1
eval_tap $? 2 'QuerySeasons' test.out

#- 3 CreateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "Mes98US7", "defaultRequiredExp": 3, "draftStoreId": "jngUqFYK", "end": "1992-03-21T00:00:00Z", "excessStrategy": {"currency": "ogprrTCO", "method": "NONE", "percentPerExp": 78}, "images": [{"as": "dnTwLQVL", "caption": "qCSCKZQb", "height": 76, "imageUrl": "AV1jBmwm", "smallImageUrl": "QXBw320z", "width": 36}, {"as": "iKsHpEpf", "caption": "4fcXUuZv", "height": 33, "imageUrl": "V97eKCV4", "smallImageUrl": "rdaxCHcG", "width": 15}, {"as": "Gz0NRxS6", "caption": "OS77AL5n", "height": 47, "imageUrl": "Aw0YoCrf", "smallImageUrl": "3dJFl8fF", "width": 50}], "localizations": {"rGCzV5YU": {"description": "4uZyVF64", "title": "JXx8uEFN"}, "8I5PCq3J": {"description": "Xrk7dVQY", "title": "E78gR9aC"}, "afjXXgoy": {"description": "EkHFEPxQ", "title": "UER2kodi"}}, "name": "bXVAcfeo", "start": "1999-08-12T00:00:00Z", "tierItemId": "9KJfYp8A"}' > $TEMP_JSON_INPUT
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

#- 5 BulkGetUserSeasonProgression
# body param: body
echo '{"userIds": ["e4kiieTM", "dQS0bHZP", "7tDxEPfN"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op BulkGetUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'BulkGetUserSeasonProgression' test.out

#- 6 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '7ZwcTO8r' \
    > test.out 2>&1
eval_tap $? 6 'GetSeason' test.out

#- 7 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'kieJ3alz' \
    > test.out 2>&1
eval_tap $? 7 'DeleteSeason' test.out

#- 8 UpdateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "39sCsQX7", "defaultRequiredExp": 20, "draftStoreId": "D0IzhKrN", "end": "1972-04-16T00:00:00Z", "excessStrategy": {"currency": "O8VEyawj", "method": "CURRENCY", "percentPerExp": 22}, "images": [{"as": "KaN82ykc", "caption": "fb0QZ3fd", "height": 63, "imageUrl": "CyfO1Ja8", "smallImageUrl": "X5u7YmT5", "width": 7}, {"as": "h69yXptV", "caption": "XXUAiYKm", "height": 59, "imageUrl": "5og2UUl9", "smallImageUrl": "d5mdvIas", "width": 70}, {"as": "UljJPYO1", "caption": "BYGz514i", "height": 45, "imageUrl": "GMn2A7LH", "smallImageUrl": "YsA7Fx5t", "width": 53}], "localizations": {"JkHZm4BK": {"description": "cL5fgfDI", "title": "jc5GCLfw"}, "7urXBelP": {"description": "bdtjYIT8", "title": "FLrskdG2"}, "Ve5JQjsu": {"description": "fZsI9sUm", "title": "qyzrdD4k"}}, "name": "EUSBrRA5", "start": "1997-11-13T00:00:00Z", "tierItemId": "k7NQGWm0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'w6648JrM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateSeason' test.out

#- 9 CloneSeason
# body param: body
echo '{"end": "1999-05-02T00:00:00Z", "name": "ZrrvdSsg", "start": "1983-02-20T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'SuiMvyJF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'CloneSeason' test.out

#- 10 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'DcA4IOJW' \
    > test.out 2>&1
eval_tap $? 10 'GetFullSeason' test.out

#- 11 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'ntkpsoe8' \
    > test.out 2>&1
eval_tap $? 11 'QueryPasses' test.out

#- 12 CreatePass
# body param: body
echo '{"autoEnroll": true, "code": "xYRm9OZT", "displayOrder": 12, "images": [{"as": "QU3FowKU", "caption": "mSqFqXSM", "height": 5, "imageUrl": "DXwA5Hhg", "smallImageUrl": "1dia28DV", "width": 31}, {"as": "1UkLdyS0", "caption": "tYc8lUmu", "height": 75, "imageUrl": "Y5UpCbgh", "smallImageUrl": "PZHa6e93", "width": 32}, {"as": "9SFfxjQP", "caption": "BVRzrslJ", "height": 70, "imageUrl": "r36OwtVZ", "smallImageUrl": "nKVfCmmB", "width": 7}], "localizations": {"W24X5kNa": {"description": "r26cWkvh", "title": "qoLErxK4"}, "g1o7iy5e": {"description": "uIGbqQyd", "title": "kX24I06r"}, "F7voC4p8": {"description": "d0PlB9eY", "title": "VpmrcIki"}}, "passItemId": "YemUEWXI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'ISlNhqUl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'CreatePass' test.out

#- 13 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'UjQMRRAC' \
    --namespace $AB_NAMESPACE \
    --seasonId 'H8S4LVOG' \
    > test.out 2>&1
eval_tap $? 13 'GetPass' test.out

#- 14 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'giabiwgU' \
    --namespace $AB_NAMESPACE \
    --seasonId 'uBkCqWiQ' \
    > test.out 2>&1
eval_tap $? 14 'DeletePass' test.out

#- 15 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 91, "images": [{"as": "UUTRzfDV", "caption": "vav0hbrh", "height": 8, "imageUrl": "68BL9pXE", "smallImageUrl": "2phGilbI", "width": 52}, {"as": "jexsvZ6E", "caption": "yb3PXTw4", "height": 3, "imageUrl": "4Z5tj9By", "smallImageUrl": "CkafHGeY", "width": 8}, {"as": "OZKCLniK", "caption": "MxJAKGXZ", "height": 13, "imageUrl": "bjhNBFNs", "smallImageUrl": "5RXdgza0", "width": 1}], "localizations": {"vK6FLA5I": {"description": "05sh9Ggl", "title": "8W57Pn0u"}, "RNPcf2mh": {"description": "f3qlrJzJ", "title": "CNXtF8hd"}, "B5Qlimnl": {"description": "eEsYrbCe", "title": "Q61ErAY4"}}, "passItemId": "GoO3e098"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'E0ODnMvn' \
    --namespace $AB_NAMESPACE \
    --seasonId 'vD9wbBEX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdatePass' test.out

#- 16 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '0egWQVs5' \
    > test.out 2>&1
eval_tap $? 16 'PublishSeason' test.out

#- 17 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'boMPf55m' \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 17 'RetireSeason' test.out

#- 18 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId 'ZkTWF1As' \
    --q 'kISNwn5B' \
    > test.out 2>&1
eval_tap $? 18 'QueryRewards' test.out

#- 19 CreateReward
# body param: body
echo '{"code": "brd7KwWC", "currency": {"currencyCode": "uQW81SPj", "namespace": "Q4zK8dsR"}, "image": {"as": "3zahZgna", "caption": "rUV0ay84", "height": 27, "imageUrl": "SaJrKvp3", "smallImageUrl": "dVNhcfga", "width": 25}, "itemId": "YPAm300f", "quantity": 47, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId 'eFj2QAiS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'CreateReward' test.out

#- 20 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'mHRCzTLm' \
    --namespace $AB_NAMESPACE \
    --seasonId 'ID5kM9L0' \
    > test.out 2>&1
eval_tap $? 20 'GetReward' test.out

#- 21 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'Eac3AoTU' \
    --namespace $AB_NAMESPACE \
    --seasonId 'TbeDW3dD' \
    > test.out 2>&1
eval_tap $? 21 'DeleteReward' test.out

#- 22 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "HZbENqTf", "namespace": "ZauwApD1"}, "image": {"as": "NR1fd6nv", "caption": "uUA18EM3", "height": 87, "imageUrl": "nqLnevgm", "smallImageUrl": "EQK70VEv", "width": 85}, "itemId": "B2zqUuok", "nullFields": ["4xlLrLUt", "da0dRyrd", "aZ2JcxLc"], "quantity": 87, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'EtSWwmzm' \
    --namespace $AB_NAMESPACE \
    --seasonId 'dlubzZKo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'UpdateReward' test.out

#- 23 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId '0wFtxIFI' \
    --limit '50' \
    --offset '80' \
    > test.out 2>&1
eval_tap $? 23 'QueryTiers' test.out

#- 24 CreateTier
# body param: body
echo '{"index": 2, "quantity": 36, "tier": {"requiredExp": 64, "rewards": {"K54tsc6D": ["NNvIBcmm", "mTXmgHqq", "ZYAKoGCJ"], "9LLwPG5p": ["28R3T1Vq", "qBQDywMj", "YWBHJXJp"], "M5LWre1x": ["B39UjLUR", "6WDh4way", "JXFDir54"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'PxwSYWK7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateTier' test.out

#- 25 UpdateTier
# body param: body
echo '{"requiredExp": 49, "rewards": {"XCUIYjAv": ["NAnaCMF8", "wJtagiRY", "yor1sKZz"], "mj9hFsNT": ["GDFMEiLL", "rUpVLeqa", "VCjW2IJ7"], "UIe7NBAn": ["GGqO2TWM", "G88mdSPu", "CZCp6HOL"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'bPGmueMA' \
    --namespace $AB_NAMESPACE \
    --seasonId 'e1D2YhJ4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateTier' test.out

#- 26 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'tWnRM512' \
    --namespace $AB_NAMESPACE \
    --seasonId 'm2arTeIk' \
    > test.out 2>&1
eval_tap $? 26 'DeleteTier' test.out

#- 27 ReorderTier
# body param: body
echo '{"newIndex": 92}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 's9gHejgG' \
    --namespace $AB_NAMESPACE \
    --seasonId 'nV3GT1bT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'ReorderTier' test.out

#- 28 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'MwJa7bKe' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 28 'UnpublishSeason' test.out

#- 29 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'Y6Wd4ceS' \
    --limit '64' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 29 'GetUserParticipatedSeasons' test.out

#- 30 GrantUserExp
# body param: body
echo '{"exp": 68, "source": "PAID_FOR", "tags": ["S1dSFpIT", "MXmIfSuG", "jtrukF9t"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'dQjPvDtm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'GrantUserExp' test.out

#- 31 GrantUserPass
# body param: body
echo '{"passCode": "bimZ3APH", "passItemId": "lEUdDOFE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'uUIBr5Qu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'GrantUserPass' test.out

#- 32 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'AU895wlk' \
    --passCodes '["z6FvMiWd", "ql2kX8ki", "v8aykzjq"]' \
    > test.out 2>&1
eval_tap $? 32 'ExistsAnyPassByPassCodes' test.out

#- 33 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'bWKtsnod' \
    > test.out 2>&1
eval_tap $? 33 'GetCurrentUserSeasonProgression' test.out

#- 34 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "V88BZctG", "tierItemCount": 5, "tierItemId": "puIlC7rp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'bm519pT7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'CheckSeasonPurchasable' test.out

#- 35 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'DYLKMthR' \
    > test.out 2>&1
eval_tap $? 35 'ResetUserSeason' test.out

#- 36 GrantUserTier
# body param: body
echo '{"count": 0, "source": "SWEAT", "tags": ["c4CJhLDF", "41hborFs", "YS6VoKxo"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId 'zLeeOid5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'GrantUserTier' test.out

#- 37 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId '6XygaLlv' \
    --from 'YhBuGKu8' \
    --limit '85' \
    --offset '42' \
    --seasonId 'Y2bJyN5C' \
    --source 'SWEAT' \
    --tags '["vWZkkzDQ", "ACoi1QTU", "Ih13rapq"]' \
    --to '8hNUFBqJ' \
    > test.out 2>&1
eval_tap $? 37 'QueryUserExpGrantHistory' test.out

#- 38 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId 'VYBlWUah' \
    --seasonId 'TWIeAkR7' \
    > test.out 2>&1
eval_tap $? 38 'QueryUserExpGrantHistoryTag' test.out

#- 39 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'DmVkvJ1v' \
    --userId 'wRzCjitw' \
    > test.out 2>&1
eval_tap $? 39 'GetUserSeason' test.out

#- 40 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'RiqZSNvV' \
    > test.out 2>&1
eval_tap $? 40 'PublicGetCurrentSeason' test.out

#- 41 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'iCQR85Yv' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCurrentUserSeason' test.out

#- 42 PublicClaimUserReward
# body param: body
echo '{"passCode": "ilE0pxet", "rewardCode": "ICjMrg0I", "tierIndex": 86}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId '48cKiXo8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicClaimUserReward' test.out

#- 43 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'Zh3S7Klo' \
    > test.out 2>&1
eval_tap $? 43 'PublicBulkClaimUserRewards' test.out

#- 44 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'YWh7xD69' \
    --userId 'CH2kc6Ry' \
    > test.out 2>&1
eval_tap $? 44 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE