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
echo "1..323"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListFulfillmentScripts
$CLI_EXE \
    --sn platform \
    --op ListFulfillmentScripts \
    > test.out 2>&1
eval_tap $? 2 'ListFulfillmentScripts' test.out

#- 3 TestFulfillmentScriptEval
# body param: body
echo '{"context": {"item": {"appId": "b0Cjv4Ax", "appType": "DEMO", "baseAppId": "Ykoppa0V", "boothName": "gFJAhHwT", "boundItemIds": ["b5q010gN"], "categoryPath": "2MQrbpeR", "clazz": "nxTlCTFS", "createdAt": "1990-09-30T00:00:00Z", "description": "bl1a2jXL", "displayOrder": 57, "entitlementType": "CONSUMABLE", "ext": {"WmHJBi9S": {}}, "features": ["oMkSE4eJ"], "images": [{"as": "elwO4KPM", "caption": "ky2h8R2f", "height": 69, "imageUrl": "XoXP8gd7", "smallImageUrl": "JUabYc3G", "width": 77}], "itemId": "bxTlm1fs", "itemIds": ["u6J3C4s5"], "itemQty": {"ppGR9Xco": 46}, "itemType": "COINS", "language": "ewrLfwvz", "listable": true, "localExt": {"4TpbNhKq": {}}, "longDescription": "2xdmgEBe", "maxCount": 30, "maxCountPerUser": 62, "name": "Htf6Zieg", "namespace": "qdEL4fsM", "purchasable": false, "recurring": {"cycle": "YEARLY", "fixedFreeDays": 50, "fixedTrialCycles": 87, "graceDays": 95}, "region": "uC1r7UH1", "regionData": [{"currencyCode": "Liu7UQ03", "currencyNamespace": "04McK873", "currencyType": "VIRTUAL", "discountAmount": 87, "discountExpireAt": "1980-05-17T00:00:00Z", "discountPercentage": 4, "discountPurchaseAt": "1973-11-17T00:00:00Z", "discountedPrice": 71, "expireAt": "1988-01-18T00:00:00Z", "price": 42, "purchaseAt": "1980-11-18T00:00:00Z", "trialPrice": 26}], "seasonType": "TIER", "sku": "4jNWGc7C", "stackable": false, "status": "ACTIVE", "tags": ["4wM5Eu3V"], "targetCurrencyCode": "qymsFXpo", "targetItemId": "rMqEDR8E", "targetNamespace": "72XMKfhl", "thumbnailUrl": "6eq2FzU3", "title": "VL3LNmPL", "updatedAt": "1973-01-28T00:00:00Z", "useCount": 28}, "namespace": "CXfabFXz", "order": {"currency": {"currencyCode": "vjLmai7f", "currencySymbol": "PKvE2Z4a", "currencyType": "VIRTUAL", "decimals": 74, "namespace": "bQSWtsyz"}, "ext": {"0mGGyHHF": {}}, "free": false}, "source": "DLC"}, "script": "KsXgvSrk", "type": "grantDays"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestFulfillmentScriptEval \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'TestFulfillmentScriptEval' test.out

#- 4 GetFulfillmentScript
$CLI_EXE \
    --sn platform \
    --op GetFulfillmentScript \
    --id 'gTYVk5iR' \
    > test.out 2>&1
eval_tap $? 4 'GetFulfillmentScript' test.out

#- 5 CreateFulfillmentScript
# body param: body
echo '{"grantDays": "BE6zJJ1B"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateFulfillmentScript \
    --id 'RHrfCHqq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateFulfillmentScript' test.out

#- 6 DeleteFulfillmentScript
$CLI_EXE \
    --sn platform \
    --op DeleteFulfillmentScript \
    --id 'p2GwPcmz' \
    > test.out 2>&1
eval_tap $? 6 'DeleteFulfillmentScript' test.out

#- 7 UpdateFulfillmentScript
# body param: body
echo '{"grantDays": "SuY8w9VY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateFulfillmentScript \
    --id 'wBEfRXoZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateFulfillmentScript' test.out

#- 8 QueryCampaigns
$CLI_EXE \
    --sn platform \
    --op QueryCampaigns \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --name 'fpVFfDwj' \
    --offset '66' \
    --tag 'HCW2g5u8' \
    > test.out 2>&1
eval_tap $? 8 'QueryCampaigns' test.out

#- 9 CreateCampaign
# body param: body
echo '{"description": "z9yrpJdI", "items": [{"extraSubscriptionDays": 46, "itemId": "5vvHS3d6", "itemName": "PKPE27mI", "quantity": 82}], "maxRedeemCountPerCampaignPerUser": 46, "maxRedeemCountPerCode": 19, "maxRedeemCountPerCodePerUser": 38, "maxSaleCount": 74, "name": "q4x0F7Nc", "redeemEnd": "1978-01-21T00:00:00Z", "redeemStart": "1973-03-31T00:00:00Z", "redeemType": "ITEM", "status": "INACTIVE", "tags": ["lKYu8iCP"], "type": "REDEMPTION"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCampaign \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'CreateCampaign' test.out

#- 10 GetCampaign
$CLI_EXE \
    --sn platform \
    --op GetCampaign \
    --campaignId 'nx0s5TzT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'GetCampaign' test.out

#- 11 UpdateCampaign
# body param: body
echo '{"description": "51oV4HTm", "items": [{"extraSubscriptionDays": 17, "itemId": "vmb6tPmC", "itemName": "irkhYvcO", "quantity": 92}], "maxRedeemCountPerCampaignPerUser": 40, "maxRedeemCountPerCode": 5, "maxRedeemCountPerCodePerUser": 19, "maxSaleCount": 83, "name": "WGwPsvjL", "redeemEnd": "1989-08-16T00:00:00Z", "redeemStart": "1975-12-01T00:00:00Z", "redeemType": "ITEM", "status": "INACTIVE", "tags": ["tbMkpUFH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCampaign \
    --campaignId 'T0fL9q9S' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UpdateCampaign' test.out

#- 12 GetCampaignDynamic
$CLI_EXE \
    --sn platform \
    --op GetCampaignDynamic \
    --campaignId 'MNAUQVoi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'GetCampaignDynamic' test.out

#- 13 GetRootCategories
$CLI_EXE \
    --sn platform \
    --op GetRootCategories \
    --namespace $AB_NAMESPACE \
    --storeId 'QtSQC2kN' \
    > test.out 2>&1
eval_tap $? 13 'GetRootCategories' test.out

#- 14 CreateCategory
# body param: body
echo '{"categoryPath": "SsmT0d2a", "localizationDisplayNames": {"BG4zA2zp": "1Ls0bD6d"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCategory \
    --namespace $AB_NAMESPACE \
    --storeId 'GgwkYgHz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreateCategory' test.out

#- 15 ListCategoriesBasic
$CLI_EXE \
    --sn platform \
    --op ListCategoriesBasic \
    --namespace $AB_NAMESPACE \
    --storeId 'KuI2RJrb' \
    > test.out 2>&1
eval_tap $? 15 'ListCategoriesBasic' test.out

#- 16 GetCategory
$CLI_EXE \
    --sn platform \
    --op GetCategory \
    --categoryPath 'oP7kfpIl' \
    --namespace $AB_NAMESPACE \
    --storeId 'etXrCK1U' \
    > test.out 2>&1
eval_tap $? 16 'GetCategory' test.out

#- 17 UpdateCategory
# body param: body
echo '{"localizationDisplayNames": {"VO0jcs7n": "CqsodoTF"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCategory \
    --categoryPath 'TcWlaIBJ' \
    --namespace $AB_NAMESPACE \
    --storeId 'AAknU6Ho' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateCategory' test.out

#- 18 DeleteCategory
$CLI_EXE \
    --sn platform \
    --op DeleteCategory \
    --categoryPath 'bZgWlaLn' \
    --namespace $AB_NAMESPACE \
    --storeId 'edDfasTc' \
    > test.out 2>&1
eval_tap $? 18 'DeleteCategory' test.out

#- 19 GetChildCategories
$CLI_EXE \
    --sn platform \
    --op GetChildCategories \
    --categoryPath '8gr2znWq' \
    --namespace $AB_NAMESPACE \
    --storeId 'D6tIcfI5' \
    > test.out 2>&1
eval_tap $? 19 'GetChildCategories' test.out

#- 20 GetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op GetDescendantCategories \
    --categoryPath 'Z4tUNQ7m' \
    --namespace $AB_NAMESPACE \
    --storeId 'QPjCalZg' \
    > test.out 2>&1
eval_tap $? 20 'GetDescendantCategories' test.out

#- 21 QueryCodes
$CLI_EXE \
    --sn platform \
    --op QueryCodes \
    --campaignId 'FVEQyqav' \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --batchNo '46' \
    --code 'CvMqVcXs' \
    --limit '81' \
    --offset '32' \
    > test.out 2>&1
eval_tap $? 21 'QueryCodes' test.out

#- 22 CreateCodes
# body param: body
echo '{"quantity": 79}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCodes \
    --campaignId 'z8ZLBsnc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreateCodes' test.out

#- 23 Download
$CLI_EXE \
    --sn platform \
    --op Download \
    --campaignId 'bRrf6uEd' \
    --namespace $AB_NAMESPACE \
    --batchNo '19' \
    > test.out 2>&1
eval_tap $? 23 'Download' test.out

#- 24 BulkDisableCodes
$CLI_EXE \
    --sn platform \
    --op BulkDisableCodes \
    --campaignId 'Unr04WZN' \
    --namespace $AB_NAMESPACE \
    --batchNo '14' \
    > test.out 2>&1
eval_tap $? 24 'BulkDisableCodes' test.out

#- 25 BulkEnableCodes
$CLI_EXE \
    --sn platform \
    --op BulkEnableCodes \
    --campaignId 'gEGvqKWQ' \
    --namespace $AB_NAMESPACE \
    --batchNo '90' \
    > test.out 2>&1
eval_tap $? 25 'BulkEnableCodes' test.out

#- 26 QueryRedeemHistory
$CLI_EXE \
    --sn platform \
    --op QueryRedeemHistory \
    --campaignId 'kE65j618' \
    --namespace $AB_NAMESPACE \
    --code '6p0WfsnW' \
    --limit '40' \
    --offset '92' \
    --userId 'PsaRnVdr' \
    > test.out 2>&1
eval_tap $? 26 'QueryRedeemHistory' test.out

#- 27 GetCode
$CLI_EXE \
    --sn platform \
    --op GetCode \
    --code 'dBA2hXwY' \
    --namespace $AB_NAMESPACE \
    --redeemable 'True' \
    > test.out 2>&1
eval_tap $? 27 'GetCode' test.out

#- 28 DisableCode
$CLI_EXE \
    --sn platform \
    --op DisableCode \
    --code 'zZMdlR4c' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'DisableCode' test.out

#- 29 EnableCode
$CLI_EXE \
    --sn platform \
    --op EnableCode \
    --code 'L76hnFDg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'EnableCode' test.out

#- 30 ListCurrencies
$CLI_EXE \
    --sn platform \
    --op ListCurrencies \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'ListCurrencies' test.out

#- 31 CreateCurrency
# body param: body
echo '{"currencyCode": "TfofHdfo", "currencySymbol": "SqDcaFhO", "currencyType": "REAL", "decimals": 29, "localizationDescriptions": {"KxI8f5oc": "fy4EIxwB"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCurrency \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'CreateCurrency' test.out

#- 32 UpdateCurrency
# body param: body
echo '{"localizationDescriptions": {"iB90vdgS": "5YpKsdbp"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCurrency \
    --currencyCode 'iU2UfyMO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'UpdateCurrency' test.out

#- 33 DeleteCurrency
$CLI_EXE \
    --sn platform \
    --op DeleteCurrency \
    --currencyCode '4DhL9fBK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'DeleteCurrency' test.out

#- 34 GetCurrencyConfig
$CLI_EXE \
    --sn platform \
    --op GetCurrencyConfig \
    --currencyCode 'JvjBOUn3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'GetCurrencyConfig' test.out

#- 35 GetCurrencySummary
$CLI_EXE \
    --sn platform \
    --op GetCurrencySummary \
    --currencyCode 'bYf5ouXq' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'GetCurrencySummary' test.out

#- 36 GetDLCItemConfig
$CLI_EXE \
    --sn platform \
    --op GetDLCItemConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'GetDLCItemConfig' test.out

#- 37 UpdateDLCItemConfig
# body param: body
echo '{"data": [{"id": "kbiExqT6", "rewards": [{"currency": {"currencyCode": "Dk9QFqaA", "namespace": "jhwOI1P0"}, "item": {"itemId": "4dMHfTwr", "itemSku": "xBRfMxZr", "itemType": "Sfx3V8OX"}, "quantity": 20, "type": "ITEM"}]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateDLCItemConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateDLCItemConfig' test.out

#- 38 DeleteDLCItemConfig
$CLI_EXE \
    --sn platform \
    --op DeleteDLCItemConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'DeleteDLCItemConfig' test.out

#- 39 GetPlatformDLCConfig
$CLI_EXE \
    --sn platform \
    --op GetPlatformDLCConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'GetPlatformDLCConfig' test.out

#- 40 UpdatePlatformDLCConfig
# body param: body
echo '{"data": [{"platform": "PSN", "platformDlcIdMap": {"7p2SyFDE": "nmYQzehP"}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePlatformDLCConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'UpdatePlatformDLCConfig' test.out

#- 41 DeletePlatformDLCConfig
$CLI_EXE \
    --sn platform \
    --op DeletePlatformDLCConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 41 'DeletePlatformDLCConfig' test.out

#- 42 QueryEntitlements
$CLI_EXE \
    --sn platform \
    --op QueryEntitlements \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --appType 'GAME' \
    --entitlementClazz 'MEDIA' \
    --entitlementName '12DvvzNN' \
    --itemId '["ZSu5zZVg"]' \
    --limit '100' \
    --offset '28' \
    --userId 'sfd01vaO' \
    > test.out 2>&1
eval_tap $? 42 'QueryEntitlements' test.out

#- 43 GetEntitlement
$CLI_EXE \
    --sn platform \
    --op GetEntitlement \
    --entitlementId 'GweHacvH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'GetEntitlement' test.out

#- 44 QueryFulfillmentHistories
$CLI_EXE \
    --sn platform \
    --op QueryFulfillmentHistories \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '94' \
    --status 'SUCCESS' \
    --userId 'B8hos4ya' \
    > test.out 2>&1
eval_tap $? 44 'QueryFulfillmentHistories' test.out

#- 45 GetAppleIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetAppleIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 45 'GetAppleIAPConfig' test.out

#- 46 UpdateAppleIAPConfig
# body param: body
echo '{"bundleId": "OBjMxizC", "password": "xx9qTOIK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAppleIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'UpdateAppleIAPConfig' test.out

#- 47 DeleteAppleIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteAppleIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'DeleteAppleIAPConfig' test.out

#- 48 GetEpicGamesIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetEpicGamesIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'GetEpicGamesIAPConfig' test.out

#- 49 UpdateEpicGamesIAPConfig
# body param: body
echo '{"sandboxId": "lpdrqo2s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateEpicGamesIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'UpdateEpicGamesIAPConfig' test.out

#- 50 DeleteEpicGamesIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteEpicGamesIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'DeleteEpicGamesIAPConfig' test.out

#- 51 GetGoogleIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetGoogleIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'GetGoogleIAPConfig' test.out

#- 52 UpdateGoogleIAPConfig
# body param: body
echo '{"applicationName": "mD9RPpjO", "serviceAccountId": "WK0k76i1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateGoogleIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'UpdateGoogleIAPConfig' test.out

#- 53 DeleteGoogleIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteGoogleIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 53 'DeleteGoogleIAPConfig' test.out

#- 54 UpdateGoogleP12File
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateGoogleP12File \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 54 'UpdateGoogleP12File' test.out

#- 55 GetIAPItemConfig
$CLI_EXE \
    --sn platform \
    --op GetIAPItemConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'GetIAPItemConfig' test.out

#- 56 UpdateIAPItemConfig
# body param: body
echo '{"data": [{"itemIdentity": "g7rYaEuN", "itemIdentityType": "ITEM_SKU", "platformProductIdMap": {"yPoQ0oHY": "XUQdtIkA"}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateIAPItemConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'UpdateIAPItemConfig' test.out

#- 57 DeleteIAPItemConfig
$CLI_EXE \
    --sn platform \
    --op DeleteIAPItemConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'DeleteIAPItemConfig' test.out

#- 58 GetPlayStationIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetPlayStationIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'GetPlayStationIAPConfig' test.out

#- 59 UpdatePlaystationIAPConfig
# body param: body
echo '{"environment": "kltd1zQB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePlaystationIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'UpdatePlaystationIAPConfig' test.out

#- 60 DeletePlaystationIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeletePlaystationIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'DeletePlaystationIAPConfig' test.out

#- 61 GetStadiaIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetStadiaIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'GetStadiaIAPConfig' test.out

#- 62 DeleteStadiaIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteStadiaIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 62 'DeleteStadiaIAPConfig' test.out

#- 63 UpdateStadiaJsonConfigFile
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateStadiaJsonConfigFile \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 63 'UpdateStadiaJsonConfigFile' test.out

#- 64 GetSteamIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetSteamIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'GetSteamIAPConfig' test.out

#- 65 UpdateSteamIAPConfig
# body param: body
echo '{"publisherAuthenticationKey": "zzC6ldKr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateSteamIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'UpdateSteamIAPConfig' test.out

#- 66 DeleteSteamIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteSteamIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'DeleteSteamIAPConfig' test.out

#- 67 GetTwitchIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetTwitchIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetTwitchIAPConfig' test.out

#- 68 UpdateTwitchIAPConfig
# body param: body
echo '{"clientId": "iI6lTRbc", "clientSecret": "1Z1HJHzl", "organizationId": "323Ynwf5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateTwitchIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'UpdateTwitchIAPConfig' test.out

#- 69 DeleteTwitchIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteTwitchIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'DeleteTwitchIAPConfig' test.out

#- 70 GetXblIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetXblIAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 70 'GetXblIAPConfig' test.out

#- 71 UpdateXblIAPConfig
# body param: body
echo '{"relyingPartyCert": "PvGejCDg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXblIAPConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'UpdateXblIAPConfig' test.out

#- 72 DeleteXblAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteXblAPConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 72 'DeleteXblAPConfig' test.out

#- 73 UpdateXblBPCertFile
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateXblBPCertFile \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --password 'Ar1pXDcs' \
    > test.out 2>&1
eval_tap $? 73 'UpdateXblBPCertFile' test.out

#- 74 SyncInGameItem
# body param: body
echo '{"categoryPath": "HnobnaYx", "targetItemId": "Gh3FovBn", "targetNamespace": "r5VUOHGq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncInGameItem \
    --namespace $AB_NAMESPACE \
    --storeId 'EcuJYo3Y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'SyncInGameItem' test.out

#- 75 CreateItem
# body param: body
echo '{"appId": "fMDw4PaB", "appType": "DLC", "baseAppId": "FXorxY0a", "boothName": "hG5AgHrE", "categoryPath": "98qQTSXh", "clazz": "1W7MnK2i", "displayOrder": 60, "entitlementType": "DURABLE", "ext": {"y255awvu": {}}, "features": ["lbNGSAje"], "images": [{"as": "iiANETlk", "caption": "ncKPmri3", "height": 77, "imageUrl": "Y2aVCNUJ", "smallImageUrl": "gcpAYbj0", "width": 11}], "itemIds": ["idlWPSAI"], "itemQty": {"jaw5HSyD": 37}, "itemType": "CODE", "listable": true, "localizations": {"AxUd1bmV": {"description": "SM44scgN", "localExt": {"AZf7a3R9": {}}, "longDescription": "rIVTDDXZ", "title": "1fahMp68"}}, "maxCount": 70, "maxCountPerUser": 43, "name": "5wQ3hbDl", "purchasable": false, "recurring": {"cycle": "QUARTERLY", "fixedFreeDays": 0, "fixedTrialCycles": 61, "graceDays": 47}, "regionData": {"mVbXDomW": [{"currencyCode": "yrFZZdM0", "currencyNamespace": "0sSdUypO", "currencyType": "VIRTUAL", "discountAmount": 28, "discountExpireAt": "1990-06-15T00:00:00Z", "discountPercentage": 68, "discountPurchaseAt": "1990-01-16T00:00:00Z", "discountedPrice": 86, "expireAt": "1984-12-09T00:00:00Z", "price": 46, "purchaseAt": "1986-05-23T00:00:00Z", "trialPrice": 56}]}, "seasonType": "TIER", "sku": "0koUsUcG", "stackable": false, "status": "ACTIVE", "tags": ["tfyuPNb5"], "targetCurrencyCode": "exiRtR1Q", "targetNamespace": "e0mxLnvZ", "thumbnailUrl": "EG2biyKS", "useCount": 43}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateItem \
    --namespace $AB_NAMESPACE \
    --storeId 'fIsZ5EAD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'CreateItem' test.out

#- 76 GetItemByAppId
$CLI_EXE \
    --sn platform \
    --op GetItemByAppId \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --storeId 'Jp6HXexn' \
    --appId 'HAXYShIg' \
    > test.out 2>&1
eval_tap $? 76 'GetItemByAppId' test.out

#- 77 QueryItems
$CLI_EXE \
    --sn platform \
    --op QueryItems \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --appType 'DEMO' \
    --availableDate 'zx6WCUdw' \
    --baseAppId 'QnivM1tf' \
    --categoryPath 'IoSsKaP5' \
    --features 'KNn0UGr9' \
    --itemType 'SUBSCRIPTION' \
    --limit '94' \
    --offset '0' \
    --region 'tfxBoakH' \
    --sortBy 'Uqz2uOKJ' \
    --storeId 'VjX7j5Mg' \
    --tags 'RZ3kPmSr' \
    --targetNamespace 'NaFzJwBc' \
    > test.out 2>&1
eval_tap $? 77 'QueryItems' test.out

#- 78 ListBasicItemsByFeatures
$CLI_EXE \
    --sn platform \
    --op ListBasicItemsByFeatures \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --features '["JQ0viEYQ"]' \
    > test.out 2>&1
eval_tap $? 78 'ListBasicItemsByFeatures' test.out

#- 79 GetItemBySku
$CLI_EXE \
    --sn platform \
    --op GetItemBySku \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --storeId '4JxBkyXf' \
    --sku 'gwzMTAlT' \
    > test.out 2>&1
eval_tap $? 79 'GetItemBySku' test.out

#- 80 GetLocaleItemBySku
$CLI_EXE \
    --sn platform \
    --op GetLocaleItemBySku \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --language '2EbG4Z95' \
    --populateBundle 'False' \
    --region 'dyWe2X8c' \
    --storeId 'Les0TRTA' \
    --sku 'ekrfR30I' \
    > test.out 2>&1
eval_tap $? 80 'GetLocaleItemBySku' test.out

#- 81 GetItemIdBySku
$CLI_EXE \
    --sn platform \
    --op GetItemIdBySku \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --storeId '6CzcXFcj' \
    --sku 'Rpu7wVEz' \
    > test.out 2>&1
eval_tap $? 81 'GetItemIdBySku' test.out

#- 82 BulkGetLocaleItems
$CLI_EXE \
    --sn platform \
    --op BulkGetLocaleItems \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --language 'wHvOGqwb' \
    --region '7FAI8lxD' \
    --storeId 'oRtwKNHC' \
    --itemIds 'ncWRyVDP' \
    > test.out 2>&1
eval_tap $? 82 'BulkGetLocaleItems' test.out

#- 83 SearchItems
$CLI_EXE \
    --sn platform \
    --op SearchItems \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --limit '68' \
    --offset '3' \
    --storeId 'OIi021vV' \
    --keyword 'F26yEKnK' \
    --language 'L26vTDvj' \
    > test.out 2>&1
eval_tap $? 83 'SearchItems' test.out

#- 84 QueryUncategorizedItems
$CLI_EXE \
    --sn platform \
    --op QueryUncategorizedItems \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --limit '19' \
    --offset '0' \
    --sortBy 'EPjDWSwW' \
    --storeId '548hHTuJ' \
    > test.out 2>&1
eval_tap $? 84 'QueryUncategorizedItems' test.out

#- 85 GetItem
$CLI_EXE \
    --sn platform \
    --op GetItem \
    --itemId '1jV4EKpp' \
    --namespace $AB_NAMESPACE \
    --activeOnly 'True' \
    --storeId 'fTxfj3AG' \
    > test.out 2>&1
eval_tap $? 85 'GetItem' test.out

#- 86 UpdateItem
# body param: body
echo '{"appId": "rDhoJooH", "appType": "DEMO", "baseAppId": "4d6DELnH", "boothName": "Rwigr039", "categoryPath": "B7fw1zHG", "clazz": "7KQTrQeI", "displayOrder": 43, "entitlementType": "CONSUMABLE", "ext": {"tNkXpuQ4": {}}, "features": ["g9IiLxJp"], "images": [{"as": "TlIMuKCd", "caption": "At0XTdLL", "height": 80, "imageUrl": "1WSvdw7F", "smallImageUrl": "I8mOSB2r", "width": 43}], "itemIds": ["QkdnYlPH"], "itemQty": {"6J70BXWV": 39}, "itemType": "SUBSCRIPTION", "listable": true, "localizations": {"ZzUrVRKR": {"description": "tJuZ5W7n", "localExt": {"PrKtUSfl": {}}, "longDescription": "KqC31jYv", "title": "8832yIJU"}}, "maxCount": 27, "maxCountPerUser": 12, "name": "m7GSrElr", "purchasable": false, "recurring": {"cycle": "WEEKLY", "fixedFreeDays": 51, "fixedTrialCycles": 86, "graceDays": 48}, "regionData": {"G8SZmnOv": [{"currencyCode": "u24EFzSQ", "currencyNamespace": "yIXv2yW4", "currencyType": "REAL", "discountAmount": 0, "discountExpireAt": "1999-03-08T00:00:00Z", "discountPercentage": 37, "discountPurchaseAt": "1994-03-25T00:00:00Z", "discountedPrice": 52, "expireAt": "1975-02-12T00:00:00Z", "price": 27, "purchaseAt": "1975-04-13T00:00:00Z", "trialPrice": 64}]}, "seasonType": "PASS", "sku": "0BjFUSZe", "stackable": true, "status": "ACTIVE", "tags": ["Z5SaUa0U"], "targetCurrencyCode": "xaP0Kwv6", "targetNamespace": "8OsqOUTP", "thumbnailUrl": "Xzelychm", "useCount": 12}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateItem \
    --itemId 'jLvnOWOk' \
    --namespace $AB_NAMESPACE \
    --storeId '5AekVVmT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'UpdateItem' test.out

#- 87 DeleteItem
$CLI_EXE \
    --sn platform \
    --op DeleteItem \
    --itemId 'IEG2ppf1' \
    --namespace $AB_NAMESPACE \
    --storeId 'fH3NwfEQ' \
    > test.out 2>&1
eval_tap $? 87 'DeleteItem' test.out

#- 88 AcquireItem
# body param: body
echo '{"count": 20, "orderNo": "dzI8JQzA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireItem \
    --itemId 'p0rF8gvd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'AcquireItem' test.out

#- 89 GetApp
$CLI_EXE \
    --sn platform \
    --op GetApp \
    --itemId 'nF1yMvoX' \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --storeId 'QZhvPg7V' \
    > test.out 2>&1
eval_tap $? 89 'GetApp' test.out

#- 90 UpdateApp
# body param: body
echo '{"carousel": [{"alt": "X5rUNWJa", "previewUrl": "q1fjgDyp", "thumbnailUrl": "xO4ufKfU", "type": "video", "url": "mxSk0Ebj", "videoSource": "youtube"}], "developer": "4dSLx4vs", "forumUrl": "b6rx9Xxs", "genres": ["MassivelyMultiplayer"], "localizations": {"8TJHpdZV": {"announcement": "C6y6b9fQ", "slogan": "pa7b36my"}}, "platformRequirements": {"8LWzMOfn": [{"additionals": "jwsIxM4s", "directXVersion": "9m2qWNvm", "diskSpace": "PPlRULr7", "graphics": "pPFCzbPX", "label": "1wwBznD7", "osVersion": "NLs7fb4s", "processor": "qWUpB4t2", "ram": "ieA8XRPh", "soundCard": "VzktsWib"}]}, "platforms": ["MacOS"], "players": ["Multi"], "primaryGenre": "Racing", "publisher": "KXMWuoFv", "releaseDate": "1997-05-03T00:00:00Z", "websiteUrl": "jBvBzZGO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateApp \
    --itemId 'hAwcbpyb' \
    --namespace $AB_NAMESPACE \
    --storeId 'Zn4ZE5Om' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 90 'UpdateApp' test.out

#- 91 DisableItem
$CLI_EXE \
    --sn platform \
    --op DisableItem \
    --itemId 'bNkHnefZ' \
    --namespace $AB_NAMESPACE \
    --storeId 'WDwi6anY' \
    > test.out 2>&1
eval_tap $? 91 'DisableItem' test.out

#- 92 GetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op GetItemDynamicData \
    --itemId 'nQ92kVBD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 92 'GetItemDynamicData' test.out

#- 93 EnableItem
$CLI_EXE \
    --sn platform \
    --op EnableItem \
    --itemId 'kaMy03Bu' \
    --namespace $AB_NAMESPACE \
    --storeId 'l4GW3V0W' \
    > test.out 2>&1
eval_tap $? 93 'EnableItem' test.out

#- 94 FeatureItem
$CLI_EXE \
    --sn platform \
    --op FeatureItem \
    --feature 'CbxvTGyc' \
    --itemId 'cHSkFQzg' \
    --namespace $AB_NAMESPACE \
    --storeId 'VR72Dhxb' \
    > test.out 2>&1
eval_tap $? 94 'FeatureItem' test.out

#- 95 DefeatureItem
$CLI_EXE \
    --sn platform \
    --op DefeatureItem \
    --feature 'r4HtKMGr' \
    --itemId '8tnOEeip' \
    --namespace $AB_NAMESPACE \
    --storeId '505iJTzZ' \
    > test.out 2>&1
eval_tap $? 95 'DefeatureItem' test.out

#- 96 GetLocaleItem
$CLI_EXE \
    --sn platform \
    --op GetLocaleItem \
    --itemId 'uksb4hRE' \
    --namespace $AB_NAMESPACE \
    --activeOnly 'False' \
    --language 'Ox3mATUs' \
    --populateBundle 'False' \
    --region '5Tmapkim' \
    --storeId 'opclvfm7' \
    > test.out 2>&1
eval_tap $? 96 'GetLocaleItem' test.out

#- 97 ReturnItem
# body param: body
echo '{"orderNo": "fdu7isKa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ReturnItem \
    --itemId 'WRcvkLtf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'ReturnItem' test.out

#- 98 QueryKeyGroups
$CLI_EXE \
    --sn platform \
    --op QueryKeyGroups \
    --namespace $AB_NAMESPACE \
    --limit '24' \
    --name 'GySrACKa' \
    --offset '25' \
    --tag 'WWkDRcuL' \
    > test.out 2>&1
eval_tap $? 98 'QueryKeyGroups' test.out

#- 99 CreateKeyGroup
# body param: body
echo '{"description": "bIpVJnIA", "name": "FpX2SKNm", "status": "ACTIVE", "tags": ["cDRknJor"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateKeyGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'CreateKeyGroup' test.out

#- 100 GetKeyGroup
$CLI_EXE \
    --sn platform \
    --op GetKeyGroup \
    --keyGroupId 'twVqipgp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 100 'GetKeyGroup' test.out

#- 101 UpdateKeyGroup
# body param: body
echo '{"description": "XVyWoDjO", "name": "HrGczaXW", "status": "ACTIVE", "tags": ["pcAHtRkB"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateKeyGroup \
    --keyGroupId 'JXZwQ443' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 101 'UpdateKeyGroup' test.out

#- 102 GetKeyGroupDynamic
$CLI_EXE \
    --sn platform \
    --op GetKeyGroupDynamic \
    --keyGroupId 'FfWtsTAA' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 102 'GetKeyGroupDynamic' test.out

#- 103 ListKeys
$CLI_EXE \
    --sn platform \
    --op ListKeys \
    --keyGroupId 'gtCnvDp2' \
    --namespace $AB_NAMESPACE \
    --limit '90' \
    --offset '77' \
    --status 'ACTIVE' \
    > test.out 2>&1
eval_tap $? 103 'ListKeys' test.out

#- 104 UploadKeys
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UploadKeys \
    --keyGroupId 'lTcBaljk' \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 104 'UploadKeys' test.out

#- 105 QueryOrders
$CLI_EXE \
    --sn platform \
    --op QueryOrders \
    --namespace $AB_NAMESPACE \
    --endTime '3sB4LS44' \
    --limit '14' \
    --offset '97' \
    --orderNos '["ONXuXihq"]' \
    --sortBy 'BVEXSyrZ' \
    --startTime 'KBvGa0Ls' \
    --status 'CHARGEBACK_REVERSED' \
    --withTotal 'False' \
    > test.out 2>&1
eval_tap $? 105 'QueryOrders' test.out

#- 106 GetOrderStatistics
$CLI_EXE \
    --sn platform \
    --op GetOrderStatistics \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 106 'GetOrderStatistics' test.out

#- 107 GetOrder
$CLI_EXE \
    --sn platform \
    --op GetOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'P3LqrZcS' \
    > test.out 2>&1
eval_tap $? 107 'GetOrder' test.out

#- 108 RefundOrder
# body param: body
echo '{"description": "sGFDDAiS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'jXH3ypQa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 108 'RefundOrder' test.out

#- 109 GetPaymentCallbackConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentCallbackConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 109 'GetPaymentCallbackConfig' test.out

#- 110 UpdatePaymentCallbackConfig
# body param: body
echo '{"dryRun": true, "notifyUrl": "FPMAjx7e", "privateKey": "dUxN5KMS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentCallbackConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 110 'UpdatePaymentCallbackConfig' test.out

#- 111 QueryPaymentNotifications
$CLI_EXE \
    --sn platform \
    --op QueryPaymentNotifications \
    --namespace $AB_NAMESPACE \
    --endDate 'Ls21gdQU' \
    --externalId '0FhAQYQa' \
    --limit '66' \
    --notificationSource 'STRIPE' \
    --notificationType 'AApJtfB0' \
    --offset '98' \
    --paymentOrderNo 't8Zcpuz7' \
    --startDate 'BY3JPVnM' \
    --status 'PROCESSED' \
    > test.out 2>&1
eval_tap $? 111 'QueryPaymentNotifications' test.out

#- 112 QueryPaymentOrders
$CLI_EXE \
    --sn platform \
    --op QueryPaymentOrders \
    --namespace $AB_NAMESPACE \
    --channel 'INTERNAL' \
    --extTxId 'FxkSaTdI' \
    --limit '79' \
    --offset '70' \
    --status 'REFUND_FAILED' \
    > test.out 2>&1
eval_tap $? 112 'QueryPaymentOrders' test.out

#- 113 CreatePaymentOrderByDedicated
# body param: body
echo '{"currencyCode": "dRQmMvxB", "currencyNamespace": "jpVFnEgs", "customParameters": {"ovZbx4UF": {}}, "description": "3pYMzeFc", "extOrderNo": "sBLCwhTS", "extUserId": "tBJZGkIS", "itemType": "APP", "language": "hX_QY", "metadata": {"sdpW3XyQ": "QmftmA5H"}, "notifyUrl": "UHioxzVh", "omitNotification": true, "price": 67, "recurringPaymentOrderNo": "c1rBqAXu", "region": "d4JQOWZB", "returnUrl": "zUvNkxTU", "sandbox": true, "sku": "I2XhbYwT", "subscriptionId": "xVSXpJb2", "targetNamespace": "JSuHHCRP", "targetUserId": "9xW9VeYJ", "title": "CDikIapu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreatePaymentOrderByDedicated \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 113 'CreatePaymentOrderByDedicated' test.out

#- 114 ListExtOrderNoByExtTxId
$CLI_EXE \
    --sn platform \
    --op ListExtOrderNoByExtTxId \
    --namespace $AB_NAMESPACE \
    --extTxId 'mYwbaGfs' \
    > test.out 2>&1
eval_tap $? 114 'ListExtOrderNoByExtTxId' test.out

#- 115 GetPaymentOrder
$CLI_EXE \
    --sn platform \
    --op GetPaymentOrder \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'JTgobWG9' \
    > test.out 2>&1
eval_tap $? 115 'GetPaymentOrder' test.out

#- 116 ChargePaymentOrder
# body param: body
echo '{"extTxId": "3dH2MCGv", "paymentMethod": "ohrdRx6l", "paymentProvider": "ADYEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ChargePaymentOrder \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo '7UcTmEwe' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 116 'ChargePaymentOrder' test.out

#- 117 RefundPaymentOrderByDedicated
# body param: body
echo '{"description": "9mWH3XVf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundPaymentOrderByDedicated \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'yejgTi2E' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 117 'RefundPaymentOrderByDedicated' test.out

#- 118 SimulatePaymentOrderNotification
# body param: body
echo '{"amount": 95, "currencyCode": "nFsoXaRE", "notifyType": "CHARGE", "paymentProvider": "STRIPE", "salesTax": 36, "vat": 83}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SimulatePaymentOrderNotification \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'oXUApZEP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 118 'SimulatePaymentOrderNotification' test.out

#- 119 GetPaymentOrderChargeStatus
$CLI_EXE \
    --sn platform \
    --op GetPaymentOrderChargeStatus \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'fic39c2q' \
    > test.out 2>&1
eval_tap $? 119 'GetPaymentOrderChargeStatus' test.out

#- 120 CreateReward
# body param: body
echo '{"description": "3a6kRuGq", "eventTopic": "HcwZVjAQ", "maxAwarded": 56, "maxAwardedPerUser": 21, "namespaceExpression": "WjE3gJ6A", "rewardCode": "wW953NlF", "rewardConditions": [{"condition": "HpDCFut3", "conditionName": "9Jhj3lmf", "eventName": "XJxKJNRD", "rewardItems": [{"duration": 73, "itemId": "umRjk3wZ", "quantity": 100}]}], "userIdExpression": "Vb3SFssn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 120 'CreateReward' test.out

#- 121 QueryRewards
$CLI_EXE \
    --sn platform \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --eventTopic 'x4JYy1kX' \
    --limit '1' \
    --offset '21' \
    --sortBy 'VQoG01up' \
    > test.out 2>&1
eval_tap $? 121 'QueryRewards' test.out

#- 122 ExportRewards
$CLI_EXE \
    --sn platform \
    --op ExportRewards \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 122 'ExportRewards' test.out

#- 123 ImportRewards
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op ImportRewards \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'True' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 123 'ImportRewards' test.out

#- 124 GetReward
$CLI_EXE \
    --sn platform \
    --op GetReward \
    --namespace $AB_NAMESPACE \
    --rewardId 'R2PZ0E2o' \
    > test.out 2>&1
eval_tap $? 124 'GetReward' test.out

#- 125 UpdateReward
# body param: body
echo '{"description": "WaCZcCX2", "eventTopic": "iLiQGTL6", "maxAwarded": 81, "maxAwardedPerUser": 19, "namespaceExpression": "LlXUV78i", "rewardCode": "8csQIO0D", "rewardConditions": [{"condition": "RagPXzsB", "conditionName": "fUhCoGFg", "eventName": "irdMLexA", "rewardItems": [{"duration": 51, "itemId": "JvQd2cOV", "quantity": 98}]}], "userIdExpression": "FoiaYaSo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateReward \
    --namespace $AB_NAMESPACE \
    --rewardId 'og7pSsQh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 125 'UpdateReward' test.out

#- 126 DeleteReward
$CLI_EXE \
    --sn platform \
    --op DeleteReward \
    --namespace $AB_NAMESPACE \
    --rewardId 'vXbGvqRV' \
    > test.out 2>&1
eval_tap $? 126 'DeleteReward' test.out

#- 127 CheckEventCondition
# body param: body
echo '{"payload": {"SSwvlRzd": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CheckEventCondition \
    --namespace $AB_NAMESPACE \
    --rewardId 'NXrfoKVR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 127 'CheckEventCondition' test.out

#- 128 ListStores
$CLI_EXE \
    --sn platform \
    --op ListStores \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 128 'ListStores' test.out

#- 129 CreateStore
# body param: body
echo '{"defaultLanguage": "4HhlPEfS", "defaultRegion": "M2K29oqf", "description": "ZssibgoT", "supportedLanguages": ["FQAmIZiT"], "supportedRegions": ["SstC2yOu"], "title": "mzHMhXys"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateStore \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 129 'CreateStore' test.out

#- 130 ImportStore
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op ImportStore \
    --namespace $AB_NAMESPACE \
    --storeId 'ws3Fwnu7' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 130 'ImportStore' test.out

#- 131 GetPublishedStore
$CLI_EXE \
    --sn platform \
    --op GetPublishedStore \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 131 'GetPublishedStore' test.out

#- 132 DeletePublishedStore
$CLI_EXE \
    --sn platform \
    --op DeletePublishedStore \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 132 'DeletePublishedStore' test.out

#- 133 GetPublishedStoreBackup
$CLI_EXE \
    --sn platform \
    --op GetPublishedStoreBackup \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 133 'GetPublishedStoreBackup' test.out

#- 134 RollbackPublishedStore
$CLI_EXE \
    --sn platform \
    --op RollbackPublishedStore \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 134 'RollbackPublishedStore' test.out

#- 135 GetStore
$CLI_EXE \
    --sn platform \
    --op GetStore \
    --namespace $AB_NAMESPACE \
    --storeId 'OX9FZvwJ' \
    > test.out 2>&1
eval_tap $? 135 'GetStore' test.out

#- 136 UpdateStore
# body param: body
echo '{"defaultLanguage": "8OQFuCH6", "defaultRegion": "8pTmT632", "description": "j8QfhNDT", "supportedLanguages": ["Hb8lFvBo"], "supportedRegions": ["lf9Pdi5B"], "title": "LCsT8g72"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStore \
    --namespace $AB_NAMESPACE \
    --storeId 'thhduZnN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 136 'UpdateStore' test.out

#- 137 DeleteStore
$CLI_EXE \
    --sn platform \
    --op DeleteStore \
    --namespace $AB_NAMESPACE \
    --storeId 'j9cRNlTB' \
    > test.out 2>&1
eval_tap $? 137 'DeleteStore' test.out

#- 138 QueryChanges
$CLI_EXE \
    --sn platform \
    --op QueryChanges \
    --namespace $AB_NAMESPACE \
    --storeId 'xl3nKj6B' \
    --action 'CREATE' \
    --itemType 'BUNDLE' \
    --limit '12' \
    --offset '39' \
    --sortBy 'xiPLdV0o' \
    --status 'PUBLISHED' \
    --type 'CATEGORY' \
    --updatedAtEnd 'fast4NDI' \
    --updatedAtStart 'BQl3Uryr' \
    > test.out 2>&1
eval_tap $? 138 'QueryChanges' test.out

#- 139 PublishAll
$CLI_EXE \
    --sn platform \
    --op PublishAll \
    --namespace $AB_NAMESPACE \
    --storeId 'yOWzhhEm' \
    > test.out 2>&1
eval_tap $? 139 'PublishAll' test.out

#- 140 CloneStore
$CLI_EXE \
    --sn platform \
    --op CloneStore \
    --namespace $AB_NAMESPACE \
    --storeId 'SVFhAlEa' \
    --targetStoreId 'cAAoAfsu' \
    > test.out 2>&1
eval_tap $? 140 'CloneStore' test.out

#- 141 ExportStore
$CLI_EXE \
    --sn platform \
    --op ExportStore \
    --namespace $AB_NAMESPACE \
    --storeId 'MB4W3HIc' \
    > test.out 2>&1
eval_tap $? 141 'ExportStore' test.out

#- 142 QuerySubscriptions
$CLI_EXE \
    --sn platform \
    --op QuerySubscriptions \
    --namespace $AB_NAMESPACE \
    --chargeStatus 'NEVER' \
    --itemId 'S0AL4tYC' \
    --limit '44' \
    --offset '57' \
    --sku 'dCigcxlb' \
    --status 'CANCELLED' \
    --subscribedBy 'PLATFORM' \
    --userId 'HHEjMI4L' \
    > test.out 2>&1
eval_tap $? 142 'QuerySubscriptions' test.out

#- 143 RecurringChargeSubscription
$CLI_EXE \
    --sn platform \
    --op RecurringChargeSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'cgkyDscc' \
    > test.out 2>&1
eval_tap $? 143 'RecurringChargeSubscription' test.out

#- 144 GetTicketDynamic
$CLI_EXE \
    --sn platform \
    --op GetTicketDynamic \
    --boothName 'FdvzoafM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 144 'GetTicketDynamic' test.out

#- 145 DecreaseTicketSale
# body param: body
echo '{"orderNo": "LoraVj5R"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DecreaseTicketSale \
    --boothName 'iDHvo7Ke' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 145 'DecreaseTicketSale' test.out

#- 146 GetTicketBoothID
$CLI_EXE \
    --sn platform \
    --op GetTicketBoothID \
    --boothName 'pgBTMRiE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 146 'GetTicketBoothID' test.out

#- 147 IncreaseTicketSale
# body param: body
echo '{"count": 7, "orderNo": "eeQwLUW0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op IncreaseTicketSale \
    --boothName 'VLupH83A' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 147 'IncreaseTicketSale' test.out

#- 148 AnonymizeCampaign
$CLI_EXE \
    --sn platform \
    --op AnonymizeCampaign \
    --namespace $AB_NAMESPACE \
    --userId 'uxFEFRDT' \
    > test.out 2>&1
eval_tap $? 148 'AnonymizeCampaign' test.out

#- 149 AnonymizeEntitlement
$CLI_EXE \
    --sn platform \
    --op AnonymizeEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 't2mauywa' \
    > test.out 2>&1
eval_tap $? 149 'AnonymizeEntitlement' test.out

#- 150 AnonymizeFulfillment
$CLI_EXE \
    --sn platform \
    --op AnonymizeFulfillment \
    --namespace $AB_NAMESPACE \
    --userId 'KEsPBAM1' \
    > test.out 2>&1
eval_tap $? 150 'AnonymizeFulfillment' test.out

#- 151 AnonymizeIntegration
$CLI_EXE \
    --sn platform \
    --op AnonymizeIntegration \
    --namespace $AB_NAMESPACE \
    --userId 'aujNqlmp' \
    > test.out 2>&1
eval_tap $? 151 'AnonymizeIntegration' test.out

#- 152 AnonymizeOrder
$CLI_EXE \
    --sn platform \
    --op AnonymizeOrder \
    --namespace $AB_NAMESPACE \
    --userId 'KGhvTKiX' \
    > test.out 2>&1
eval_tap $? 152 'AnonymizeOrder' test.out

#- 153 AnonymizePayment
$CLI_EXE \
    --sn platform \
    --op AnonymizePayment \
    --namespace $AB_NAMESPACE \
    --userId 'eZepm7tF' \
    > test.out 2>&1
eval_tap $? 153 'AnonymizePayment' test.out

#- 154 AnonymizeSubscription
$CLI_EXE \
    --sn platform \
    --op AnonymizeSubscription \
    --namespace $AB_NAMESPACE \
    --userId '1wKhQ4Hj' \
    > test.out 2>&1
eval_tap $? 154 'AnonymizeSubscription' test.out

#- 155 AnonymizeWallet
$CLI_EXE \
    --sn platform \
    --op AnonymizeWallet \
    --namespace $AB_NAMESPACE \
    --userId 'EcagyjZI' \
    > test.out 2>&1
eval_tap $? 155 'AnonymizeWallet' test.out

#- 156 QueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'TRuoWjIC' \
    --activeOnly 'False' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'SUBSCRIPTION' \
    --entitlementName '3NyzAV4n' \
    --itemId '["iQQVjgDJ"]' \
    --limit '60' \
    --offset '96' \
    > test.out 2>&1
eval_tap $? 156 'QueryUserEntitlements' test.out

#- 157 GrantUserEntitlement
# body param: body
echo '[{"endDate": "1999-02-01T00:00:00Z", "grantedCode": "oplrOXwA", "itemId": "SJ1PtQux", "itemNamespace": "OJQKgor2", "language": "mjTe", "quantity": 100, "region": "TYxPTgpB", "source": "REFERRAL_BONUS", "startDate": "1994-06-18T00:00:00Z", "storeId": "UKhANjqu"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantUserEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'BEHOJbaQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 157 'GrantUserEntitlement' test.out

#- 158 GetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'pz0dfiuv' \
    --activeOnly 'False' \
    --appId 'kPCaZsjv' \
    > test.out 2>&1
eval_tap $? 158 'GetUserAppEntitlementByAppId' test.out

#- 159 QueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlementsByAppType \
    --namespace $AB_NAMESPACE \
    --userId 'FvhZdwi1' \
    --activeOnly 'False' \
    --limit '95' \
    --offset '41' \
    --appType 'GAME' \
    > test.out 2>&1
eval_tap $? 159 'QueryUserEntitlementsByAppType' test.out

#- 160 GetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'CsB8FbVD' \
    --activeOnly 'True' \
    --entitlementClazz 'APP' \
    --itemId 'pNCLl2bg' \
    > test.out 2>&1
eval_tap $? 160 'GetUserEntitlementByItemId' test.out

#- 161 GetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementBySku \
    --namespace $AB_NAMESPACE \
    --userId 'Ic1y49bq' \
    --activeOnly 'False' \
    --entitlementClazz 'APP' \
    --sku 'fyytwm6j' \
    > test.out 2>&1
eval_tap $? 161 'GetUserEntitlementBySku' test.out

#- 162 ExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'QJpfOIKC' \
    --appIds '["egUjKQRj"]' \
    --itemIds '["oyn3bGyF"]' \
    --skus '["GwcAylTi"]' \
    > test.out 2>&1
eval_tap $? 162 'ExistsAnyUserActiveEntitlement' test.out

#- 163 ExistsAnyUserActiveEntitlementByItemIds
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlementByItemIds \
    --namespace $AB_NAMESPACE \
    --userId '4qPF190s' \
    --itemIds '["f2ZwPi5h"]' \
    > test.out 2>&1
eval_tap $? 163 'ExistsAnyUserActiveEntitlementByItemIds' test.out

#- 164 GetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementOwnershipByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'I4k3KwV7' \
    --appId 'P8R9t4dB' \
    > test.out 2>&1
eval_tap $? 164 'GetUserAppEntitlementOwnershipByAppId' test.out

#- 165 GetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'RpBp4noj' \
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId '79DD3bAZ' \
    > test.out 2>&1
eval_tap $? 165 'GetUserEntitlementOwnershipByItemId' test.out

#- 166 GetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipBySku \
    --namespace $AB_NAMESPACE \
    --userId 'F4nYBuNx' \
    --entitlementClazz 'SUBSCRIPTION' \
    --sku 'SmVGVz9J' \
    > test.out 2>&1
eval_tap $? 166 'GetUserEntitlementOwnershipBySku' test.out

#- 167 RevokeUserEntitlements
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'xj8wegrD' \
    --entitlementIds 'o6OmeKL7' \
    > test.out 2>&1
eval_tap $? 167 'RevokeUserEntitlements' test.out

#- 168 GetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlement \
    --entitlementId 'GPoI9uWO' \
    --namespace $AB_NAMESPACE \
    --userId 'FTWdRrL6' \
    > test.out 2>&1
eval_tap $? 168 'GetUserEntitlement' test.out

#- 169 UpdateUserEntitlement
# body param: body
echo '{"endDate": "1983-11-14T00:00:00Z", "nullFieldList": ["mv8k1w19"], "startDate": "1988-05-27T00:00:00Z", "status": "CONSUMED", "useCount": 80}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserEntitlement \
    --entitlementId 'Byh4hhkc' \
    --namespace $AB_NAMESPACE \
    --userId 'O6J7jSvY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 169 'UpdateUserEntitlement' test.out

#- 170 ConsumeUserEntitlement
# body param: body
echo '{"useCount": 7}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ConsumeUserEntitlement \
    --entitlementId '4J5c6ayF' \
    --namespace $AB_NAMESPACE \
    --userId 'nSrfmObF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 170 'ConsumeUserEntitlement' test.out

#- 171 DisableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op DisableUserEntitlement \
    --entitlementId 'TUBRRDGC' \
    --namespace $AB_NAMESPACE \
    --userId 'RQtMc3an' \
    > test.out 2>&1
eval_tap $? 171 'DisableUserEntitlement' test.out

#- 172 EnableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op EnableUserEntitlement \
    --entitlementId '8ZoxLwXH' \
    --namespace $AB_NAMESPACE \
    --userId 'S1oUzDdD' \
    > test.out 2>&1
eval_tap $? 172 'EnableUserEntitlement' test.out

#- 173 GetUserEntitlementHistories
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementHistories \
    --entitlementId 'cZ0Rj3YM' \
    --namespace $AB_NAMESPACE \
    --userId '1fz9Cjqt' \
    > test.out 2>&1
eval_tap $? 173 'GetUserEntitlementHistories' test.out

#- 174 RevokeUserEntitlement
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlement \
    --entitlementId 'qeiyDCK7' \
    --namespace $AB_NAMESPACE \
    --userId 'C3u5GcPb' \
    > test.out 2>&1
eval_tap $? 174 'RevokeUserEntitlement' test.out

#- 175 FulfillItem
# body param: body
echo '{"duration": 25, "endDate": "1975-10-20T00:00:00Z", "itemId": "iFDVpfvR", "itemSku": "2Wl0iSha", "language": "gpvFuZu4", "order": {"currency": {"currencyCode": "5zsrSpvM", "currencySymbol": "LvQw3sPx", "currencyType": "VIRTUAL", "decimals": 40, "namespace": "8LQGQCAj"}, "ext": {"6O7ivhNI": {}}, "free": false}, "orderNo": "VT5HSR00", "quantity": 93, "region": "KSLWWzOp", "source": "PROMOTION", "startDate": "1993-10-23T00:00:00Z", "storeId": "wZQZUMaA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillItem \
    --namespace $AB_NAMESPACE \
    --userId 'J6ZBTHYj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 175 'FulfillItem' test.out

#- 176 RedeemCode
# body param: body
echo '{"code": "GbVtzsBT", "language": "owe", "region": "LzHuYKrr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RedeemCode \
    --namespace $AB_NAMESPACE \
    --userId '89z0RkL9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 176 'RedeemCode' test.out

#- 177 FulfillRewards
# body param: body
echo '{"rewards": [{"currency": {"currencyCode": "32B7thDQ", "namespace": "3hfVnPK8"}, "item": {"itemId": "iK8cdZPn", "itemSku": "XwGS9fAl", "itemType": "xtjeZUrq"}, "quantity": 24, "type": "ITEM"}], "source": "GIFT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillRewards \
    --namespace $AB_NAMESPACE \
    --userId 'l44MEAva' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 177 'FulfillRewards' test.out

#- 178 QueryUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserIAPOrders \
    --namespace $AB_NAMESPACE \
    --userId 'PTwwJrG0' \
    --endTime '6MtcF7t8' \
    --limit '59' \
    --offset '85' \
    --productId 'xcoQBTWM' \
    --startTime 'c41xDmUj' \
    --status 'FAILED' \
    --type 'GOOGLE' \
    > test.out 2>&1
eval_tap $? 178 'QueryUserIAPOrders' test.out

#- 179 QueryAllUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryAllUserIAPOrders \
    --namespace $AB_NAMESPACE \
    --userId '2LgkALGx' \
    > test.out 2>&1
eval_tap $? 179 'QueryAllUserIAPOrders' test.out

#- 180 MockFulfillIAPItem
# body param: body
echo '{"itemIdentityType": "ITEM_SKU", "language": "GVi_dgBf-514", "productId": "pUVddL6A", "region": "1cTLmuKl", "type": "APPLE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op MockFulfillIAPItem \
    --namespace $AB_NAMESPACE \
    --userId 'wwo66H6Q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 180 'MockFulfillIAPItem' test.out

#- 181 QueryUserOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserOrders \
    --namespace $AB_NAMESPACE \
    --userId 'OfYztHev' \
    --itemId '8RX4MWRF' \
    --limit '21' \
    --offset '23' \
    --status 'REFUNDING' \
    > test.out 2>&1
eval_tap $? 181 'QueryUserOrders' test.out

#- 182 CountOfPurchasedItem
$CLI_EXE \
    --sn platform \
    --op CountOfPurchasedItem \
    --namespace $AB_NAMESPACE \
    --userId '13WW7U0s' \
    --itemId 'RVCnzRxn' \
    > test.out 2>&1
eval_tap $? 182 'CountOfPurchasedItem' test.out

#- 183 GetUserOrder
$CLI_EXE \
    --sn platform \
    --op GetUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'i0Kq9Zl2' \
    --userId 'b7ChMCxb' \
    > test.out 2>&1
eval_tap $? 183 'GetUserOrder' test.out

#- 184 UpdateUserOrderStatus
# body param: body
echo '{"status": "FULFILL_FAILED", "statusReason": "dzl2OYVR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserOrderStatus \
    --namespace $AB_NAMESPACE \
    --orderNo 'JNC7EruV' \
    --userId 'ITunbxaO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 184 'UpdateUserOrderStatus' test.out

#- 185 FulfillUserOrder
$CLI_EXE \
    --sn platform \
    --op FulfillUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'WNrMkfAL' \
    --userId 'UDrR6M3v' \
    > test.out 2>&1
eval_tap $? 185 'FulfillUserOrder' test.out

#- 186 GetUserOrderGrant
$CLI_EXE \
    --sn platform \
    --op GetUserOrderGrant \
    --namespace $AB_NAMESPACE \
    --orderNo 'zu84TNQY' \
    --userId 'CZIpKFvp' \
    > test.out 2>&1
eval_tap $? 186 'GetUserOrderGrant' test.out

#- 187 GetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op GetUserOrderHistories \
    --namespace $AB_NAMESPACE \
    --orderNo 'QOjjkIYA' \
    --userId 'QEcxGPTk' \
    > test.out 2>&1
eval_tap $? 187 'GetUserOrderHistories' test.out

#- 188 ProcessUserOrderNotification
# body param: body
echo '{"additionalData": {"cardSummary": "n2NJ9gHm"}, "authorisedTime": "1984-06-21T00:00:00Z", "chargebackReversedTime": "1973-04-01T00:00:00Z", "chargebackTime": "1994-04-29T00:00:00Z", "chargedTime": "1980-09-17T00:00:00Z", "createdTime": "1996-07-24T00:00:00Z", "currency": {"currencyCode": "EziSthhR", "currencySymbol": "9WLiVTXH", "currencyType": "REAL", "decimals": 25, "namespace": "ByxlmWBL"}, "customParameters": {"yhgZsJoo": {}}, "extOrderNo": "nMpOQ9Jm", "extTxId": "h8wwQ28f", "extUserId": "mxMFN8d9", "issuedAt": "1973-01-26T00:00:00Z", "metadata": {"HAHphhby": "7hGbKeIk"}, "namespace": "Y4Fc8atJ", "nonceStr": "3J4gbk9Y", "paymentMethod": "dEm0o9Rj", "paymentMethodFee": 18, "paymentOrderNo": "nkhwq75V", "paymentProvider": "CHECKOUT", "paymentProviderFee": 66, "paymentStationUrl": "8HUq92UF", "price": 96, "refundedTime": "1986-08-14T00:00:00Z", "salesTax": 28, "sandbox": true, "sku": "uU2OFJ6w", "status": "CHARGEBACK_REVERSED", "statusReason": "bioiiaZ8", "subscriptionId": "Uc2rWpzX", "subtotalPrice": 25, "targetNamespace": "goBhruuv", "targetUserId": "EzpyRiFs", "tax": 2, "totalPrice": 82, "totalTax": 35, "txEndTime": "1981-04-29T00:00:00Z", "type": "WiVBYjKI", "userId": "1ZlcKXBX", "vat": 5}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserOrderNotification \
    --namespace $AB_NAMESPACE \
    --orderNo 'PAsjW7zB' \
    --userId 'xpVc8svj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 188 'ProcessUserOrderNotification' test.out

#- 189 DownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op DownloadUserOrderReceipt \
    --namespace $AB_NAMESPACE \
    --orderNo 'iFtRe8k7' \
    --userId 'amplfhuH' \
    > test.out 2>&1
eval_tap $? 189 'DownloadUserOrderReceipt' test.out

#- 190 CreateUserPaymentOrder
# body param: body
echo '{"currencyCode": "ropVxIvB", "currencyNamespace": "jsYUEDp1", "customParameters": {"taP9py4F": {}}, "description": "l6UoVxgH", "extOrderNo": "JLBm3bgR", "extUserId": "vSUyOgyu", "itemType": "APP", "language": "XA", "metadata": {"TjMYGTMX": "y4ypcIN4"}, "notifyUrl": "uUIzvUI5", "omitNotification": false, "price": 44, "recurringPaymentOrderNo": "xS2yBTD8", "region": "uNeauLeX", "returnUrl": "NgQBnXZk", "sandbox": true, "sku": "gyyiBeJA", "subscriptionId": "RFVbUvLN", "title": "tDdAntKI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateUserPaymentOrder \
    --namespace $AB_NAMESPACE \
    --userId '6vd3QdSH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 190 'CreateUserPaymentOrder' test.out

#- 191 RefundUserPaymentOrder
# body param: body
echo '{"description": "H2AvosR9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundUserPaymentOrder \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'Nk0JJYXM' \
    --userId 'RcQg1Lwg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 191 'RefundUserPaymentOrder' test.out

#- 192 ApplyUserRedemption
# body param: body
echo '{"code": "zWRu5q2i", "orderNo": "8ntDdFSO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ApplyUserRedemption \
    --namespace $AB_NAMESPACE \
    --userId 'EIqFse4o' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 192 'ApplyUserRedemption' test.out

#- 193 QueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op QueryUserSubscriptions \
    --namespace $AB_NAMESPACE \
    --userId 'crqjWTbU' \
    --chargeStatus 'CHARGED' \
    --itemId 'yIP8oO0z' \
    --limit '94' \
    --offset '11' \
    --sku 'fDHyFM7T' \
    --status 'ACTIVE' \
    --subscribedBy 'PLATFORM' \
    > test.out 2>&1
eval_tap $? 193 'QueryUserSubscriptions' test.out

#- 194 GetUserSubscriptionActivities
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionActivities \
    --namespace $AB_NAMESPACE \
    --userId 'bxDDxngE' \
    --excludeSystem 'True' \
    --limit '36' \
    --offset '53' \
    --subscriptionId 'bWEfTc2n' \
    > test.out 2>&1
eval_tap $? 194 'GetUserSubscriptionActivities' test.out

#- 195 PlatformSubscribeSubscription
# body param: body
echo '{"grantDays": 88, "itemId": "U2SijySp", "language": "nqX01uDk", "reason": "Q1tv3iMM", "region": "W8aqVbwA", "source": "rhGSaFxy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PlatformSubscribeSubscription \
    --namespace $AB_NAMESPACE \
    --userId 'AsPnfbHX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 195 'PlatformSubscribeSubscription' test.out

#- 196 CheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op CheckUserSubscriptionSubscribableByItemId \
    --namespace $AB_NAMESPACE \
    --userId '5TpIV6e7' \
    --itemId 'dMKaAr2V' \
    > test.out 2>&1
eval_tap $? 196 'CheckUserSubscriptionSubscribableByItemId' test.out

#- 197 GetUserSubscription
$CLI_EXE \
    --sn platform \
    --op GetUserSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'SmtP8qxt' \
    --userId 'No76oPRu' \
    > test.out 2>&1
eval_tap $? 197 'GetUserSubscription' test.out

#- 198 DeleteUserSubscription
$CLI_EXE \
    --sn platform \
    --op DeleteUserSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'vxUGNJvD' \
    --userId 'RuWXBzyW' \
    > test.out 2>&1
eval_tap $? 198 'DeleteUserSubscription' test.out

#- 199 CancelSubscription
# body param: body
echo '{"immediate": false, "reason": "usWdEJnq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CancelSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'hXgmVQHo' \
    --userId 'ZNPy0Wqu' \
    --force 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 199 'CancelSubscription' test.out

#- 200 GrantDaysToSubscription
# body param: body
echo '{"grantDays": 39, "reason": "xTyrvNhy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantDaysToSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'pNLporjc' \
    --userId 'AKSuvgVj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 200 'GrantDaysToSubscription' test.out

#- 201 GetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionBillingHistories \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'dXMn2juy' \
    --userId 'P3WX3u1O' \
    --excludeFree 'True' \
    --limit '43' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 201 'GetUserSubscriptionBillingHistories' test.out

#- 202 ProcessUserSubscriptionNotification
# body param: body
echo '{"additionalData": {"cardSummary": "IqGnoqXX"}, "authorisedTime": "1984-01-27T00:00:00Z", "chargebackReversedTime": "1971-06-19T00:00:00Z", "chargebackTime": "1991-02-19T00:00:00Z", "chargedTime": "1998-06-28T00:00:00Z", "createdTime": "1982-06-17T00:00:00Z", "currency": {"currencyCode": "ZXC9YsEX", "currencySymbol": "Ee9iC3Hp", "currencyType": "VIRTUAL", "decimals": 38, "namespace": "WE8drEip"}, "customParameters": {"XZfocCS9": {}}, "extOrderNo": "nGM6fYF1", "extTxId": "o77M1VVg", "extUserId": "HHeL0flE", "issuedAt": "1991-07-01T00:00:00Z", "metadata": {"HPhE4YwC": "RBGAR8Tt"}, "namespace": "ZlDIjOfY", "nonceStr": "lF5jISj4", "paymentMethod": "wwqLpFnn", "paymentMethodFee": 78, "paymentOrderNo": "ydTcPOtf", "paymentProvider": "ADYEN", "paymentProviderFee": 60, "paymentStationUrl": "yLh6l74A", "price": 84, "refundedTime": "1996-06-04T00:00:00Z", "salesTax": 22, "sandbox": true, "sku": "H0lioSoo", "status": "CHARGED", "statusReason": "PhQ9xlLM", "subscriptionId": "e7ma8Qc9", "subtotalPrice": 1, "targetNamespace": "GN5UJPLc", "targetUserId": "hiivOQdB", "tax": 49, "totalPrice": 20, "totalTax": 24, "txEndTime": "1995-12-01T00:00:00Z", "type": "93BxbP1V", "userId": "P8rKuVwT", "vat": 91}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserSubscriptionNotification \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'GSX5rG8y' \
    --userId 'mO7ml7SC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 202 'ProcessUserSubscriptionNotification' test.out

#- 203 AcquireUserTicket
# body param: body
echo '{"count": 45, "orderNo": "M6RZNerJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireUserTicket \
    --boothName 'QroYUkvH' \
    --namespace $AB_NAMESPACE \
    --userId 'x2dAjFF0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 203 'AcquireUserTicket' test.out

#- 204 CheckWallet
$CLI_EXE \
    --sn platform \
    --op CheckWallet \
    --currencyCode 'BBGwZ7XW' \
    --namespace $AB_NAMESPACE \
    --userId 'hdoYx127' \
    > test.out 2>&1
eval_tap $? 204 'CheckWallet' test.out

#- 205 CreditUserWallet
# body param: body
echo '{"amount": 100, "reason": "YBoxSCFs", "source": "REWARD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreditUserWallet \
    --currencyCode 'bZL16L2P' \
    --namespace $AB_NAMESPACE \
    --userId '8eNmOi4O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 205 'CreditUserWallet' test.out

#- 206 PayWithUserWallet
# body param: body
echo '{"amount": 82}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PayWithUserWallet \
    --currencyCode 'Q8ZEV8Xz' \
    --namespace $AB_NAMESPACE \
    --userId 'BcAniVuo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 206 'PayWithUserWallet' test.out

#- 207 GetUserWallet
$CLI_EXE \
    --sn platform \
    --op GetUserWallet \
    --namespace $AB_NAMESPACE \
    --userId 'W6wPQlP1' \
    --walletId 'zgkxv25Z' \
    > test.out 2>&1
eval_tap $? 207 'GetUserWallet' test.out

#- 208 DebitUserWallet
# body param: body
echo '{"amount": 67, "reason": "aR8vsMhI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DebitUserWallet \
    --namespace $AB_NAMESPACE \
    --userId 'fogRB8Xe' \
    --walletId 'ZhAM4MAL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 208 'DebitUserWallet' test.out

#- 209 DisableUserWallet
$CLI_EXE \
    --sn platform \
    --op DisableUserWallet \
    --namespace $AB_NAMESPACE \
    --userId '57riU2Qb' \
    --walletId 'QFRCXEWG' \
    > test.out 2>&1
eval_tap $? 209 'DisableUserWallet' test.out

#- 210 EnableUserWallet
$CLI_EXE \
    --sn platform \
    --op EnableUserWallet \
    --namespace $AB_NAMESPACE \
    --userId '8Sxt5vtT' \
    --walletId 'kIWbiHTU' \
    > test.out 2>&1
eval_tap $? 210 'EnableUserWallet' test.out

#- 211 ListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op ListUserWalletTransactions \
    --namespace $AB_NAMESPACE \
    --userId 'DDL4yzTn' \
    --walletId 'Qv0e99zY' \
    --limit '79' \
    --offset '21' \
    > test.out 2>&1
eval_tap $? 211 'ListUserWalletTransactions' test.out

#- 212 QueryWallets
$CLI_EXE \
    --sn platform \
    --op QueryWallets \
    --namespace $AB_NAMESPACE \
    --currencyCode 'H6PuvERG' \
    --limit '83' \
    --offset '10' \
    --userId 'myd8aJkJ' \
    > test.out 2>&1
eval_tap $? 212 'QueryWallets' test.out

#- 213 GetWallet
$CLI_EXE \
    --sn platform \
    --op GetWallet \
    --namespace $AB_NAMESPACE \
    --walletId 'YGKf4wBC' \
    > test.out 2>&1
eval_tap $? 213 'GetWallet' test.out

#- 214 SyncOrders
$CLI_EXE \
    --sn platform \
    --op SyncOrders \
    --nextEvaluatedKey 'sCLrfH6V' \
    --end '3fTRar0U' \
    --start 'ZS96wD9r' \
    > test.out 2>&1
eval_tap $? 214 'SyncOrders' test.out

#- 215 TestAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["gdYvyfGQ"], "apiKey": "vBMJGa0R", "authoriseAsCapture": true, "blockedPaymentMethods": ["ilSDbJxY"], "clientKey": "0YR9wXVR", "dropInSettings": "z5ayquoA", "liveEndpointUrlPrefix": "8CGDmAN0", "merchantAccount": "yX8xu01b", "notificationHmacKey": "0bUqDheu", "notificationPassword": "9idRvQ8V", "notificationUsername": "1CaeT74V", "returnUrl": "P6KqpZ2J", "settings": "C53CGQXz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfig \
    --sandbox 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 215 'TestAdyenConfig' test.out

#- 216 TestAliPayConfig
# body param: body
echo '{"appId": "GEvvr9VR", "privateKey": "6QqaoAup", "publicKey": "KSo0RHRz", "returnUrl": "XML3VcaD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 216 'TestAliPayConfig' test.out

#- 217 TestCheckoutConfig
# body param: body
echo '{"publicKey": "zPCi2tWP", "secretKey": "zhrjLFLL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 217 'TestCheckoutConfig' test.out

#- 218 DebugMatchedPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentMerchantConfig \
    --namespace_ 'GlXInVkn' \
    --region '9ojnppiU' \
    > test.out 2>&1
eval_tap $? 218 'DebugMatchedPaymentMerchantConfig' test.out

#- 219 TestPayPalConfig
# body param: body
echo '{"clientID": "7rYU098E", "clientSecret": "1JzPmaRk", "returnUrl": "eYX8U71w", "webHookId": "09mTap7y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 219 'TestPayPalConfig' test.out

#- 220 TestStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["bd2vRMUm"], "publishableKey": "qoGBqBax", "secretKey": "LbpDekuI", "webhookSecret": "zTODQZkN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestStripeConfig \
    --sandbox 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 220 'TestStripeConfig' test.out

#- 221 TestWxPayConfig
# body param: body
echo '{"appId": "9XscMV2D", "key": "nOo9PaoB", "mchid": "SJJGgg8e", "returnUrl": "pTUehn6I"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 221 'TestWxPayConfig' test.out

#- 222 TestXsollaConfig
# body param: body
echo '{"apiKey": "zqXsteu4", "flowCompletionUrl": "pU694ex0", "merchantId": 2, "projectId": 46, "projectSecretKey": "tkvXIrbC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 222 'TestXsollaConfig' test.out

#- 223 GetPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentMerchantConfig \
    --id 'B52HlTeF' \
    > test.out 2>&1
eval_tap $? 223 'GetPaymentMerchantConfig' test.out

#- 224 UpdateAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["VmpXnrWD"], "apiKey": "Cij8S73s", "authoriseAsCapture": true, "blockedPaymentMethods": ["Ny12G1Pi"], "clientKey": "TJwxV0rw", "dropInSettings": "MM7HsMJn", "liveEndpointUrlPrefix": "UBZ6Gyhf", "merchantAccount": "crddeIOh", "notificationHmacKey": "xQMImB13", "notificationPassword": "f1obTKrw", "notificationUsername": "FXC2Op2y", "returnUrl": "XEIOAJh6", "settings": "XNWtHWdm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAdyenConfig \
    --id 'ibqDeNic' \
    --sandbox 'False' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 224 'UpdateAdyenConfig' test.out

#- 225 TestAdyenConfigById
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfigById \
    --id 'y1VY2365' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 225 'TestAdyenConfigById' test.out

#- 226 UpdateAliPayConfig
# body param: body
echo '{"appId": "UHkxwwpN", "privateKey": "wFJyOBel", "publicKey": "glT04uRm", "returnUrl": "AeOhTeib"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAliPayConfig \
    --id 'Sq4H7xDe' \
    --sandbox 'False' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 226 'UpdateAliPayConfig' test.out

#- 227 TestAliPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfigById \
    --id '7clQulgj' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 227 'TestAliPayConfigById' test.out

#- 228 UpdateCheckoutConfig
# body param: body
echo '{"publicKey": "zOE2zPDG", "secretKey": "QYK5uGsk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCheckoutConfig \
    --id 'lKEj2cIm' \
    --sandbox 'True' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 228 'UpdateCheckoutConfig' test.out

#- 229 TestCheckoutConfigById
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfigById \
    --id 'rBfOaAEN' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 229 'TestCheckoutConfigById' test.out

#- 230 UpdatePayPalConfig
# body param: body
echo '{"clientID": "CnYbIQID", "clientSecret": "kTf41ag7", "returnUrl": "CX8oWPut", "webHookId": "7xraYvae"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePayPalConfig \
    --id 'aiep5aTd' \
    --sandbox 'False' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 230 'UpdatePayPalConfig' test.out

#- 231 TestPayPalConfigById
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfigById \
    --id 'oDWOL2gm' \
    --sandbox 'False' \
    > test.out 2>&1
eval_tap $? 231 'TestPayPalConfigById' test.out

#- 232 UpdateStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["Dt1rOz0D"], "publishableKey": "T1Axwhim", "secretKey": "0K97ZlRo", "webhookSecret": "mBcUU86i"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStripeConfig \
    --id '9DJulX4a' \
    --sandbox 'True' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 232 'UpdateStripeConfig' test.out

#- 233 TestStripeConfigById
$CLI_EXE \
    --sn platform \
    --op TestStripeConfigById \
    --id 'Lkwcg4w7' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 233 'TestStripeConfigById' test.out

#- 234 UpdateWxPayConfig
# body param: body
echo '{"appId": "oonsTuM2", "key": "oBECnfwi", "mchid": "61igqpB4", "returnUrl": "WwKtAnQQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfig \
    --id 'IfNq8tkb' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 234 'UpdateWxPayConfig' test.out

#- 235 UpdateWxPayConfigCert
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfigCert \
    --id 'xAfBvJ3t' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 235 'UpdateWxPayConfigCert' test.out

#- 236 TestWxPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfigById \
    --id 'wKU1E8Sg' \
    > test.out 2>&1
eval_tap $? 236 'TestWxPayConfigById' test.out

#- 237 UpdateXsollaConfig
# body param: body
echo '{"apiKey": "lSHPDOBk", "flowCompletionUrl": "ao6x7WrS", "merchantId": 73, "projectId": 11, "projectSecretKey": "NZdIGHiC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaConfig \
    --id 'd3vs48k8' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 237 'UpdateXsollaConfig' test.out

#- 238 TestXsollaConfigById
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfigById \
    --id 'WbZOgcnb' \
    > test.out 2>&1
eval_tap $? 238 'TestXsollaConfigById' test.out

#- 239 UpdateXsollaUIConfig
# body param: body
echo '{"device": "DESKTOP", "showCloseButton": true, "size": "LARGE", "theme": "DARK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaUIConfig \
    --id 'KfFAZF2o' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 239 'UpdateXsollaUIConfig' test.out

#- 240 QueryPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op QueryPaymentProviderConfig \
    --limit '56' \
    --namespace_ '4m8qmGI4' \
    --offset '13' \
    --region '3x7VkgLX' \
    > test.out 2>&1
eval_tap $? 240 'QueryPaymentProviderConfig' test.out

#- 241 CreatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "EcgKnclU", "region": "Wy7ZJN4A", "sandboxTaxJarApiToken": "VWNaW2qM", "specials": ["ADYEN"], "taxJarApiToken": "Z2m9trvZ", "taxJarEnabled": false, "useGlobalTaxJarApiToken": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreatePaymentProviderConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 241 'CreatePaymentProviderConfig' test.out

#- 242 GetAggregatePaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetAggregatePaymentProviders \
    > test.out 2>&1
eval_tap $? 242 'GetAggregatePaymentProviders' test.out

#- 243 DebugMatchedPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentProviderConfig \
    --namespace_ 'CVMqlZ6n' \
    --region 'zcA05v44' \
    > test.out 2>&1
eval_tap $? 243 'DebugMatchedPaymentProviderConfig' test.out

#- 244 GetSpecialPaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetSpecialPaymentProviders \
    > test.out 2>&1
eval_tap $? 244 'GetSpecialPaymentProviders' test.out

#- 245 UpdatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "rWkKPTz2", "region": "0CUuON0q", "sandboxTaxJarApiToken": "lw6dAFv7", "specials": ["WXPAY"], "taxJarApiToken": "SESiUAVN", "taxJarEnabled": true, "useGlobalTaxJarApiToken": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentProviderConfig \
    --id 'X4ZMRG0G' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 245 'UpdatePaymentProviderConfig' test.out

#- 246 DeletePaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DeletePaymentProviderConfig \
    --id 'f1rfLs27' \
    > test.out 2>&1
eval_tap $? 246 'DeletePaymentProviderConfig' test.out

#- 247 GetPaymentTaxConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxConfig \
    > test.out 2>&1
eval_tap $? 247 'GetPaymentTaxConfig' test.out

#- 248 UpdatePaymentTaxConfig
# body param: body
echo '{"sandboxTaxJarApiToken": "GUn4LXB9", "taxJarApiToken": "YV8FW73Y", "taxJarEnabled": false, "taxJarProductCodesMapping": {"gpNcJMlA": "9wUgUsQ5"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentTaxConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 248 'UpdatePaymentTaxConfig' test.out

#- 249 SyncPaymentOrders
$CLI_EXE \
    --sn platform \
    --op SyncPaymentOrders \
    --nextEvaluatedKey 'njC8VO4s' \
    --end 'goRFcoG9' \
    --start 'EvgBLbT6' \
    > test.out 2>&1
eval_tap $? 249 'SyncPaymentOrders' test.out

#- 250 PublicGetRootCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetRootCategories \
    --namespace $AB_NAMESPACE \
    --language 'LIznmery' \
    --storeId '1q7Ru0EP' \
    > test.out 2>&1
eval_tap $? 250 'PublicGetRootCategories' test.out

#- 251 DownloadCategories
$CLI_EXE \
    --sn platform \
    --op DownloadCategories \
    --namespace $AB_NAMESPACE \
    --language 'X2t5Kl8G' \
    --storeId '5Sm4GZYu' \
    > test.out 2>&1
eval_tap $? 251 'DownloadCategories' test.out

#- 252 PublicGetCategory
$CLI_EXE \
    --sn platform \
    --op PublicGetCategory \
    --categoryPath 'YJ1bv2f6' \
    --namespace $AB_NAMESPACE \
    --language 'vrf7yzKm' \
    --storeId 'iSoLdcKY' \
    > test.out 2>&1
eval_tap $? 252 'PublicGetCategory' test.out

#- 253 PublicGetChildCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetChildCategories \
    --categoryPath 'Gij2Fob7' \
    --namespace $AB_NAMESPACE \
    --language 'nz3cBYTp' \
    --storeId 'N9BOiieV' \
    > test.out 2>&1
eval_tap $? 253 'PublicGetChildCategories' test.out

#- 254 PublicGetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetDescendantCategories \
    --categoryPath 'eCIJp60m' \
    --namespace $AB_NAMESPACE \
    --language 'v88QYWnF' \
    --storeId 'YRXnDSOY' \
    > test.out 2>&1
eval_tap $? 254 'PublicGetDescendantCategories' test.out

#- 255 PublicListCurrencies
$CLI_EXE \
    --sn platform \
    --op PublicListCurrencies \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 255 'PublicListCurrencies' test.out

#- 256 PublicGetItemByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetItemByAppId \
    --namespace $AB_NAMESPACE \
    --language 'xR9xEcI7' \
    --region 'ktZgyQ1P' \
    --storeId 'cqgZnaDT' \
    --appId 'm4WwM8q1' \
    > test.out 2>&1
eval_tap $? 256 'PublicGetItemByAppId' test.out

#- 257 PublicQueryItems
$CLI_EXE \
    --sn platform \
    --op PublicQueryItems \
    --namespace $AB_NAMESPACE \
    --appType 'DLC' \
    --baseAppId 'Zu6XW6by' \
    --categoryPath '2jUjXr2Y' \
    --features 'yM5ho1nP' \
    --itemType 'INGAMEITEM' \
    --language 'fkWpDz1g' \
    --limit '2' \
    --offset '44' \
    --region 'dSWEGD0k' \
    --sortBy '52Xldo1D' \
    --storeId '8HlEuQQf' \
    --tags 'Ybi9H9dF' \
    > test.out 2>&1
eval_tap $? 257 'PublicQueryItems' test.out

#- 258 PublicGetItemBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetItemBySku \
    --namespace $AB_NAMESPACE \
    --language 'CgRp7uEw' \
    --region 'OPWrKnAS' \
    --storeId 'gjfbB7kW' \
    --sku 'EU28xX2f' \
    > test.out 2>&1
eval_tap $? 258 'PublicGetItemBySku' test.out

#- 259 PublicBulkGetItems
$CLI_EXE \
    --sn platform \
    --op PublicBulkGetItems \
    --namespace $AB_NAMESPACE \
    --language 'I68kSyNp' \
    --region '7CBCtgT4' \
    --storeId 'nlpO5aE9' \
    --itemIds 'RqY1zhD2' \
    > test.out 2>&1
eval_tap $? 259 'PublicBulkGetItems' test.out

#- 260 PublicSearchItems
$CLI_EXE \
    --sn platform \
    --op PublicSearchItems \
    --namespace $AB_NAMESPACE \
    --limit '38' \
    --offset '28' \
    --region 'ALOug3D6' \
    --storeId 'sySWjGkm' \
    --keyword 'DxeIvWSM' \
    --language '0L1etOsA' \
    > test.out 2>&1
eval_tap $? 260 'PublicSearchItems' test.out

#- 261 PublicGetApp
$CLI_EXE \
    --sn platform \
    --op PublicGetApp \
    --itemId 'oob5LsBH' \
    --namespace $AB_NAMESPACE \
    --language 'H7TRU7DS' \
    --region 'v4Bl1JLV' \
    --storeId 'iUnCf9br' \
    > test.out 2>&1
eval_tap $? 261 'PublicGetApp' test.out

#- 262 PublicGetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op PublicGetItemDynamicData \
    --itemId '0AwrYymv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 262 'PublicGetItemDynamicData' test.out

#- 263 PublicGetItem
$CLI_EXE \
    --sn platform \
    --op PublicGetItem \
    --itemId 'byVtbyXg' \
    --namespace $AB_NAMESPACE \
    --language 'lS0dtEcG' \
    --populateBundle 'False' \
    --region 'sszE68ny' \
    --storeId 'iKBCylIg' \
    > test.out 2>&1
eval_tap $? 263 'PublicGetItem' test.out

#- 264 GetPaymentCustomization
eval_tap 0 264 'GetPaymentCustomization # SKIP deprecated' test.out

#- 265 PublicGetPaymentUrl
# body param: body
echo '{"paymentOrderNo": "cjAQgJS7", "paymentProvider": "ALIPAY", "returnUrl": "t6fWj0bj", "ui": "zR1qk50W", "zipCode": "TJSWMGCW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentUrl \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 265 'PublicGetPaymentUrl' test.out

#- 266 PublicGetPaymentMethods
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentMethods \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'OqgPcQEu' \
    > test.out 2>&1
eval_tap $? 266 'PublicGetPaymentMethods' test.out

#- 267 PublicGetUnpaidPaymentOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUnpaidPaymentOrder \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo '7XP4K3h5' \
    > test.out 2>&1
eval_tap $? 267 'PublicGetUnpaidPaymentOrder' test.out

#- 268 Pay
# body param: body
echo '{"token": "qA8vxWIw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op Pay \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'znTWhLbx' \
    --paymentProvider 'WXPAY' \
    --zipCode 'hedBiiMb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 268 'Pay' test.out

#- 269 PublicCheckPaymentOrderPaidStatus
$CLI_EXE \
    --sn platform \
    --op PublicCheckPaymentOrderPaidStatus \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'LGcBOF8U' \
    > test.out 2>&1
eval_tap $? 269 'PublicCheckPaymentOrderPaidStatus' test.out

#- 270 GetPaymentPublicConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentPublicConfig \
    --namespace $AB_NAMESPACE \
    --sandbox 'False' \
    --paymentProvider 'ALIPAY' \
    --region 'zJG2VBYc' \
    > test.out 2>&1
eval_tap $? 270 'GetPaymentPublicConfig' test.out

#- 271 PublicGetQRCode
$CLI_EXE \
    --sn platform \
    --op PublicGetQRCode \
    --namespace $AB_NAMESPACE \
    --code 'f39AKgvj' \
    > test.out 2>&1
eval_tap $? 271 'PublicGetQRCode' test.out

#- 272 PublicNormalizePaymentReturnUrl
$CLI_EXE \
    --sn platform \
    --op PublicNormalizePaymentReturnUrl \
    --namespace $AB_NAMESPACE \
    --payerID 'NNHD855h' \
    --foreinginvoice 'jpm3ss60' \
    --invoiceId 'uZFamFRG' \
    --payload 'icFWBzTU' \
    --redirectResult 'ohtqJUSb' \
    --resultCode 'FzSBVZmK' \
    --sessionId 'weECuD3s' \
    --status 'ZMCE8dES' \
    --token 'gloJK7nM' \
    --type '6Je8rVsr' \
    --userId 'MiXvUICp' \
    --orderNo 'XJUBosGv' \
    --paymentOrderNo '2E5Ud8R4' \
    --paymentProvider 'CHECKOUT' \
    --returnUrl 'a1HQGyTJ' \
    > test.out 2>&1
eval_tap $? 272 'PublicNormalizePaymentReturnUrl' test.out

#- 273 GetPaymentTaxValue
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxValue \
    --namespace $AB_NAMESPACE \
    --zipCode 'x6eE61z1' \
    --paymentOrderNo 'd23WGf1z' \
    --paymentProvider 'ALIPAY' \
    > test.out 2>&1
eval_tap $? 273 'GetPaymentTaxValue' test.out

#- 274 GetRewardByCode
$CLI_EXE \
    --sn platform \
    --op GetRewardByCode \
    --namespace $AB_NAMESPACE \
    --rewardCode 'jnOgbDHx' \
    > test.out 2>&1
eval_tap $? 274 'GetRewardByCode' test.out

#- 275 QueryRewards1
$CLI_EXE \
    --sn platform \
    --op QueryRewards1 \
    --namespace $AB_NAMESPACE \
    --eventTopic 'FOx68rBO' \
    --limit '55' \
    --offset '94' \
    --sortBy 'v5za3wZK' \
    > test.out 2>&1
eval_tap $? 275 'QueryRewards1' test.out

#- 276 GetReward1
$CLI_EXE \
    --sn platform \
    --op GetReward1 \
    --namespace $AB_NAMESPACE \
    --rewardId 'kkBXOpjG' \
    > test.out 2>&1
eval_tap $? 276 'GetReward1' test.out

#- 277 PublicListStores
$CLI_EXE \
    --sn platform \
    --op PublicListStores \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 277 'PublicListStores' test.out

#- 278 PublicExistsAnyMyActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyMyActiveEntitlement \
    --namespace $AB_NAMESPACE \
    --appIds '["8DMYI7aC"]' \
    --itemIds '["PVOXyHlM"]' \
    --skus '["a4GckktY"]' \
    > test.out 2>&1
eval_tap $? 278 'PublicExistsAnyMyActiveEntitlement' test.out

#- 279 PublicGetMyAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyAppEntitlementOwnershipByAppId \
    --namespace $AB_NAMESPACE \
    --appId 'eg98gTKG' \
    > test.out 2>&1
eval_tap $? 279 'PublicGetMyAppEntitlementOwnershipByAppId' test.out

#- 280 PublicGetMyEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipByItemId \
    --namespace $AB_NAMESPACE \
    --entitlementClazz 'APP' \
    --itemId 'kRJxWrHh' \
    > test.out 2>&1
eval_tap $? 280 'PublicGetMyEntitlementOwnershipByItemId' test.out

#- 281 PublicGetMyEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipBySku \
    --namespace $AB_NAMESPACE \
    --entitlementClazz 'CODE' \
    --sku '4YOK6Mnf' \
    > test.out 2>&1
eval_tap $? 281 'PublicGetMyEntitlementOwnershipBySku' test.out

#- 282 PublicGetEntitlementOwnershipToken
$CLI_EXE \
    --sn platform \
    --op PublicGetEntitlementOwnershipToken \
    --namespace $AB_NAMESPACE \
    --appIds '["eVldbEnL"]' \
    --itemIds '["YWOzyOB0"]' \
    --skus '["kZoeJIWk"]' \
    > test.out 2>&1
eval_tap $? 282 'PublicGetEntitlementOwnershipToken' test.out

#- 283 PublicGetMyWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetMyWallet \
    --currencyCode 'u1PBeZzo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 283 'PublicGetMyWallet' test.out

#- 284 PublicSyncPsnDlcInventory
# body param: body
echo '{"serviceLabel": 27}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSyncPsnDlcInventory \
    --namespace $AB_NAMESPACE \
    --userId 'uQzxLODS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 284 'PublicSyncPsnDlcInventory' test.out

#- 285 SyncSteamDLC
# body param: body
echo '{"appId": "8nTAouPR", "steamId": "62RXcekO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamDLC \
    --namespace $AB_NAMESPACE \
    --userId 'Pk51sYy0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 285 'SyncSteamDLC' test.out

#- 286 SyncXboxDLC
# body param: body
echo '{"xstsToken": "IuLJPPNc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxDLC \
    --namespace $AB_NAMESPACE \
    --userId 'lQgSBJrj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 286 'SyncXboxDLC' test.out

#- 287 PublicQueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'tMtdov0q' \
    --appType 'DLC' \
    --entitlementClazz 'ENTITLEMENT' \
    --entitlementName 'MZwWFQcB' \
    --itemId '["AVMLvAvz"]' \
    --limit '74' \
    --offset '18' \
    > test.out 2>&1
eval_tap $? 287 'PublicQueryUserEntitlements' test.out

#- 288 PublicGetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'QSHwPO48' \
    --appId 'On3gCbMH' \
    > test.out 2>&1
eval_tap $? 288 'PublicGetUserAppEntitlementByAppId' test.out

#- 289 PublicQueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlementsByAppType \
    --namespace $AB_NAMESPACE \
    --userId 'OoAwKRyM' \
    --limit '78' \
    --offset '56' \
    --appType 'DLC' \
    > test.out 2>&1
eval_tap $? 289 'PublicQueryUserEntitlementsByAppType' test.out

#- 290 PublicGetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'YGZ9RvQU' \
    --entitlementClazz 'APP' \
    --itemId 'WQhh5iGh' \
    > test.out 2>&1
eval_tap $? 290 'PublicGetUserEntitlementByItemId' test.out

#- 291 PublicGetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementBySku \
    --namespace $AB_NAMESPACE \
    --userId 'yoneUWbD' \
    --entitlementClazz 'MEDIA' \
    --sku 'vutndgic' \
    > test.out 2>&1
eval_tap $? 291 'PublicGetUserEntitlementBySku' test.out

#- 292 PublicExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyUserActiveEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'jax7ONnA' \
    --appIds '["3dvJOocd"]' \
    --itemIds '["yisYR5yh"]' \
    --skus '["rcsZyvbL"]' \
    > test.out 2>&1
eval_tap $? 292 'PublicExistsAnyUserActiveEntitlement' test.out

#- 293 PublicGetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementOwnershipByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'MUUSwl9l' \
    --appId 'uLGR0MZK' \
    > test.out 2>&1
eval_tap $? 293 'PublicGetUserAppEntitlementOwnershipByAppId' test.out

#- 294 PublicGetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'dWXP7dHv' \
    --entitlementClazz 'MEDIA' \
    --itemId 'RSx4xnEw' \
    > test.out 2>&1
eval_tap $? 294 'PublicGetUserEntitlementOwnershipByItemId' test.out

#- 295 PublicGetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipBySku \
    --namespace $AB_NAMESPACE \
    --userId 'seCMo1qF' \
    --entitlementClazz 'CODE' \
    --sku 'qmJULDde' \
    > test.out 2>&1
eval_tap $? 295 'PublicGetUserEntitlementOwnershipBySku' test.out

#- 296 PublicGetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlement \
    --entitlementId 'lYwV2DRZ' \
    --namespace $AB_NAMESPACE \
    --userId 'fSBnT2Vl' \
    > test.out 2>&1
eval_tap $? 296 'PublicGetUserEntitlement' test.out

#- 297 PublicConsumeUserEntitlement
# body param: body
echo '{"useCount": 49}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicConsumeUserEntitlement \
    --entitlementId 'q5VWu4pL' \
    --namespace $AB_NAMESPACE \
    --userId 'xrqfJr2p' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 297 'PublicConsumeUserEntitlement' test.out

#- 298 PublicRedeemCode
# body param: body
echo '{"code": "N0CiQ7Ty", "language": "Iyii", "region": "SnJZPieA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicRedeemCode \
    --namespace $AB_NAMESPACE \
    --userId 'S6Ozt9Y7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 298 'PublicRedeemCode' test.out

#- 299 PublicFulfillAppleIAPItem
# body param: body
echo '{"excludeOldTransactions": true, "language": "IX-XHCE_UE", "productId": "WqEFljov", "receiptData": "jiFds9U3", "region": "Q4FL9FKh", "transactionId": "fTM3X1GH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillAppleIAPItem \
    --namespace $AB_NAMESPACE \
    --userId 'B92JFCpi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 299 'PublicFulfillAppleIAPItem' test.out

#- 300 SyncEpicGamesInventory
# body param: body
echo '{"epicGamesJwtToken": "6PSpyvcT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncEpicGamesInventory \
    --namespace $AB_NAMESPACE \
    --userId 'nMqT7mEL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 300 'SyncEpicGamesInventory' test.out

#- 301 PublicFulfillGoogleIAPItem
# body param: body
echo '{"autoAck": true, "language": "af", "orderId": "jIfXCWza", "packageName": "tjGv4UVj", "productId": "072ERIdI", "purchaseTime": 19, "purchaseToken": "nEdKEgYr", "region": "C08a2gef"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillGoogleIAPItem \
    --namespace $AB_NAMESPACE \
    --userId 'HyULfaLd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 301 'PublicFulfillGoogleIAPItem' test.out

#- 302 PublicReconcilePlayStationStore
# body param: body
echo '{"currencyCode": "tBzfi8aW", "price": 0.2660114810280835, "productId": "f1NWlgli", "serviceLabel": 97}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicReconcilePlayStationStore \
    --namespace $AB_NAMESPACE \
    --userId 'dgwwepIg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 302 'PublicReconcilePlayStationStore' test.out

#- 303 SyncStadiaEntitlement
# body param: body
echo '{"appId": "Kh0HKAG3", "language": "oF", "region": "WxTfKegx", "stadiaPlayerId": "R0U2CExN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncStadiaEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'lVZ2RGvV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 303 'SyncStadiaEntitlement' test.out

#- 304 SyncSteamInventory
# body param: body
echo '{"appId": "o9j2WLb2", "currencyCode": "CSAgZdAF", "language": "Ns-pzqq_898", "price": 0.9903583311660245, "productId": "4njvE58h", "region": "P4ov9Lr3", "steamId": "EkTSLIsh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamInventory \
    --namespace $AB_NAMESPACE \
    --userId 'qSb4fuvT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 304 'SyncSteamInventory' test.out

#- 305 SyncTwitchDropsEntitlement
# body param: body
echo '{"gameId": "w4H9hubY", "language": "iVVU_fN", "region": "bsYzIcst"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncTwitchDropsEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'Ous7bRp1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 305 'SyncTwitchDropsEntitlement' test.out

#- 306 SyncXboxInventory
# body param: body
echo '{"currencyCode": "CdG3Hblu", "price": 0.9650787558445256, "productId": "YQD4Otx1", "xstsToken": "GZEBw1Jk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxInventory \
    --namespace $AB_NAMESPACE \
    --userId 'hddhy686' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 306 'SyncXboxInventory' test.out

#- 307 PublicQueryUserOrders
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserOrders \
    --namespace $AB_NAMESPACE \
    --userId '121Qm42I' \
    --itemId '9DcReFey' \
    --limit '74' \
    --offset '38' \
    --status 'REFUNDING' \
    > test.out 2>&1
eval_tap $? 307 'PublicQueryUserOrders' test.out

#- 308 PublicCreateUserOrder
# body param: body
echo '{"currencyCode": "Ot0SmGDz", "discountedPrice": 28, "ext": {"1dDuZYxY": {}}, "itemId": "8RWgiwIj", "language": "GKyW-628", "price": 4, "quantity": 62, "region": "VCYsZcY5", "returnUrl": "pJfXaaUs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCreateUserOrder \
    --namespace $AB_NAMESPACE \
    --userId 'khgMZlpx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 308 'PublicCreateUserOrder' test.out

#- 309 PublicGetUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'mjm9f23L' \
    --userId 'lr7WKchQ' \
    > test.out 2>&1
eval_tap $? 309 'PublicGetUserOrder' test.out

#- 310 PublicCancelUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicCancelUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'rdRvUcqA' \
    --userId 'HelKgovo' \
    > test.out 2>&1
eval_tap $? 310 'PublicCancelUserOrder' test.out

#- 311 PublicGetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrderHistories \
    --namespace $AB_NAMESPACE \
    --orderNo 'wPUtF6DL' \
    --userId 'evfnhWi0' \
    > test.out 2>&1
eval_tap $? 311 'PublicGetUserOrderHistories' test.out

#- 312 PublicDownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op PublicDownloadUserOrderReceipt \
    --namespace $AB_NAMESPACE \
    --orderNo 'LSLOvWcj' \
    --userId 'aWpr1gk6' \
    > test.out 2>&1
eval_tap $? 312 'PublicDownloadUserOrderReceipt' test.out

#- 313 PublicGetPaymentAccounts
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentAccounts \
    --namespace $AB_NAMESPACE \
    --userId 'Cb5tABJO' \
    > test.out 2>&1
eval_tap $? 313 'PublicGetPaymentAccounts' test.out

#- 314 PublicDeletePaymentAccount
$CLI_EXE \
    --sn platform \
    --op PublicDeletePaymentAccount \
    --id '3orPfizP' \
    --namespace $AB_NAMESPACE \
    --type 'paypal' \
    --userId 'wbyfoC6o' \
    > test.out 2>&1
eval_tap $? 314 'PublicDeletePaymentAccount' test.out

#- 315 PublicQueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserSubscriptions \
    --namespace $AB_NAMESPACE \
    --userId 'tIQ84AwM' \
    --chargeStatus 'CHARGED' \
    --itemId 'UVBsp0Jn' \
    --limit '55' \
    --offset '5' \
    --sku 'xN6VmGGp' \
    --status 'INIT' \
    --subscribedBy 'USER' \
    > test.out 2>&1
eval_tap $? 315 'PublicQueryUserSubscriptions' test.out

#- 316 PublicSubscribeSubscription
# body param: body
echo '{"currencyCode": "MvcnJGqj", "itemId": "2G28XQmz", "language": "TtYJ_BFGk-335", "region": "1ZepOAJR", "returnUrl": "lCb7x8Bb", "source": "V5fQSmVl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSubscribeSubscription \
    --namespace $AB_NAMESPACE \
    --userId 'jKVLc1aV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 316 'PublicSubscribeSubscription' test.out

#- 317 PublicCheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op PublicCheckUserSubscriptionSubscribableByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'QNlsm8f2' \
    --itemId 'XRjKcW95' \
    > test.out 2>&1
eval_tap $? 317 'PublicCheckUserSubscriptionSubscribableByItemId' test.out

#- 318 PublicGetUserSubscription
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'AO0RLEUg' \
    --userId 'kXqKmlhk' \
    > test.out 2>&1
eval_tap $? 318 'PublicGetUserSubscription' test.out

#- 319 PublicChangeSubscriptionBillingAccount
$CLI_EXE \
    --sn platform \
    --op PublicChangeSubscriptionBillingAccount \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'XoXwCzge' \
    --userId 'VyEsm1LK' \
    > test.out 2>&1
eval_tap $? 319 'PublicChangeSubscriptionBillingAccount' test.out

#- 320 PublicCancelSubscription
# body param: body
echo '{"immediate": false, "reason": "HKmMU5zt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCancelSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId '6FeqZnSr' \
    --userId 'j4rqOPOg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 320 'PublicCancelSubscription' test.out

#- 321 PublicGetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscriptionBillingHistories \
    --namespace $AB_NAMESPACE \
    --subscriptionId '3FZjVLWN' \
    --userId 'be1nKpOx' \
    --excludeFree 'True' \
    --limit '48' \
    --offset '93' \
    > test.out 2>&1
eval_tap $? 321 'PublicGetUserSubscriptionBillingHistories' test.out

#- 322 PublicGetWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetWallet \
    --currencyCode 'kf4msE7d' \
    --namespace $AB_NAMESPACE \
    --userId 'goYbfALB' \
    > test.out 2>&1
eval_tap $? 322 'PublicGetWallet' test.out

#- 323 PublicListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op PublicListUserWalletTransactions \
    --currencyCode 'MEdRlqlv' \
    --namespace $AB_NAMESPACE \
    --userId 'MdQrXgZH' \
    --limit '27' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 323 'PublicListUserWalletTransactions' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE