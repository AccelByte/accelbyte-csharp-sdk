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
echo "1..321"

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

#- 138 CloneStore
$CLI_EXE \
    --sn platform \
    --op CloneStore \
    --namespace $AB_NAMESPACE \
    --storeId 'xl3nKj6B' \
    --targetStoreId '4ffgtxiP' \
    > test.out 2>&1
eval_tap $? 138 'CloneStore' test.out

#- 139 ExportStore
$CLI_EXE \
    --sn platform \
    --op ExportStore \
    --namespace $AB_NAMESPACE \
    --storeId 'LdV0odbf' \
    > test.out 2>&1
eval_tap $? 139 'ExportStore' test.out

#- 140 QuerySubscriptions
$CLI_EXE \
    --sn platform \
    --op QuerySubscriptions \
    --namespace $AB_NAMESPACE \
    --chargeStatus 'CHARGED' \
    --itemId 'st4NDIBQ' \
    --limit '23' \
    --offset '92' \
    --sku 'ryryOWzh' \
    --status 'ACTIVE' \
    --subscribedBy 'USER' \
    --userId 'mSVFhAlE' \
    > test.out 2>&1
eval_tap $? 140 'QuerySubscriptions' test.out

#- 141 RecurringChargeSubscription
$CLI_EXE \
    --sn platform \
    --op RecurringChargeSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'acAAoAfs' \
    > test.out 2>&1
eval_tap $? 141 'RecurringChargeSubscription' test.out

#- 142 GetTicketDynamic
$CLI_EXE \
    --sn platform \
    --op GetTicketDynamic \
    --boothName 'uMB4W3HI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 142 'GetTicketDynamic' test.out

#- 143 DecreaseTicketSale
# body param: body
echo '{"orderNo": "cvS0AL4t"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DecreaseTicketSale \
    --boothName 'YCwCdCig' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 143 'DecreaseTicketSale' test.out

#- 144 GetTicketBoothID
$CLI_EXE \
    --sn platform \
    --op GetTicketBoothID \
    --boothName 'cxlbl30h' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 144 'GetTicketBoothID' test.out

#- 145 IncreaseTicketSale
# body param: body
echo '{"count": 67, "orderNo": "HEjMI4Lc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op IncreaseTicketSale \
    --boothName 'gkyDsccF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 145 'IncreaseTicketSale' test.out

#- 146 AnonymizeCampaign
$CLI_EXE \
    --sn platform \
    --op AnonymizeCampaign \
    --namespace $AB_NAMESPACE \
    --userId 'dvzoafML' \
    > test.out 2>&1
eval_tap $? 146 'AnonymizeCampaign' test.out

#- 147 AnonymizeEntitlement
$CLI_EXE \
    --sn platform \
    --op AnonymizeEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'oraVj5Ri' \
    > test.out 2>&1
eval_tap $? 147 'AnonymizeEntitlement' test.out

#- 148 AnonymizeFulfillment
$CLI_EXE \
    --sn platform \
    --op AnonymizeFulfillment \
    --namespace $AB_NAMESPACE \
    --userId 'DHvo7Kep' \
    > test.out 2>&1
eval_tap $? 148 'AnonymizeFulfillment' test.out

#- 149 AnonymizeIntegration
$CLI_EXE \
    --sn platform \
    --op AnonymizeIntegration \
    --namespace $AB_NAMESPACE \
    --userId 'gBTMRiEd' \
    > test.out 2>&1
eval_tap $? 149 'AnonymizeIntegration' test.out

#- 150 AnonymizeOrder
$CLI_EXE \
    --sn platform \
    --op AnonymizeOrder \
    --namespace $AB_NAMESPACE \
    --userId 'eeQwLUW0' \
    > test.out 2>&1
eval_tap $? 150 'AnonymizeOrder' test.out

#- 151 AnonymizePayment
$CLI_EXE \
    --sn platform \
    --op AnonymizePayment \
    --namespace $AB_NAMESPACE \
    --userId 'VLupH83A' \
    > test.out 2>&1
eval_tap $? 151 'AnonymizePayment' test.out

#- 152 AnonymizeSubscription
$CLI_EXE \
    --sn platform \
    --op AnonymizeSubscription \
    --namespace $AB_NAMESPACE \
    --userId 'uxFEFRDT' \
    > test.out 2>&1
eval_tap $? 152 'AnonymizeSubscription' test.out

#- 153 AnonymizeWallet
$CLI_EXE \
    --sn platform \
    --op AnonymizeWallet \
    --namespace $AB_NAMESPACE \
    --userId 't2mauywa' \
    > test.out 2>&1
eval_tap $? 153 'AnonymizeWallet' test.out

#- 154 QueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'KEsPBAM1' \
    --activeOnly 'False' \
    --appType 'GAME' \
    --entitlementClazz 'CODE' \
    --entitlementName 'NqlmpKGh' \
    --itemId '["vTKiXeZe"]' \
    --limit '30' \
    --offset '24' \
    > test.out 2>&1
eval_tap $? 154 'QueryUserEntitlements' test.out

#- 155 GrantUserEntitlement
# body param: body
echo '[{"endDate": "1980-09-10T00:00:00Z", "grantedCode": "1wKhQ4Hj", "itemId": "EcagyjZI", "itemNamespace": "TRuoWjIC", "language": "cn-vNIq", "quantity": 12, "region": "DJE12W5e", "source": "ACHIEVEMENT", "startDate": "1978-04-05T00:00:00Z", "storeId": "rOXwASJ1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantUserEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'PtQuxOJQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 155 'GrantUserEntitlement' test.out

#- 156 GetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'Kgor2UMJ' \
    --activeOnly 'True' \
    --appId '4EJ9GccY' \
    > test.out 2>&1
eval_tap $? 156 'GetUserAppEntitlementByAppId' test.out

#- 157 QueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlementsByAppType \
    --namespace $AB_NAMESPACE \
    --userId 'TYxPTgpB' \
    --activeOnly 'True' \
    --limit '93' \
    --offset '43' \
    --appType 'DEMO' \
    > test.out 2>&1
eval_tap $? 157 'QueryUserEntitlementsByAppType' test.out

#- 158 GetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'ANjquBEH' \
    --activeOnly 'False' \
    --entitlementClazz 'APP' \
    --itemId 'Qpz0dfiu' \
    > test.out 2>&1
eval_tap $? 158 'GetUserEntitlementByItemId' test.out

#- 159 GetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementBySku \
    --namespace $AB_NAMESPACE \
    --userId 'v051lkPC' \
    --activeOnly 'False' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'jvFvhZdw' \
    > test.out 2>&1
eval_tap $? 159 'GetUserEntitlementBySku' test.out

#- 160 ExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'i1Ti6V2u' \
    --appIds '["WuCsB8Fb"]' \
    --itemIds '["VDwhpNCL"]' \
    --skus '["l2bgIc1y"]' \
    > test.out 2>&1
eval_tap $? 160 'ExistsAnyUserActiveEntitlement' test.out

#- 161 ExistsAnyUserActiveEntitlementByItemIds
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlementByItemIds \
    --namespace $AB_NAMESPACE \
    --userId '49bqpbfy' \
    --itemIds '["ytwm6jQJ"]' \
    > test.out 2>&1
eval_tap $? 161 'ExistsAnyUserActiveEntitlementByItemIds' test.out

#- 162 GetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementOwnershipByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'pfOIKCeg' \
    --appId 'UjKQRjoy' \
    > test.out 2>&1
eval_tap $? 162 'GetUserAppEntitlementOwnershipByAppId' test.out

#- 163 GetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'n3bGyFGw' \
    --entitlementClazz 'APP' \
    --itemId 'AylTi4qP' \
    > test.out 2>&1
eval_tap $? 163 'GetUserEntitlementOwnershipByItemId' test.out

#- 164 GetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipBySku \
    --namespace $AB_NAMESPACE \
    --userId 'F190sf2Z' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'Pi5hI4k3' \
    > test.out 2>&1
eval_tap $? 164 'GetUserEntitlementOwnershipBySku' test.out

#- 165 RevokeUserEntitlements
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'KwV7P8R9' \
    --entitlementIds 't4dBRpBp' \
    > test.out 2>&1
eval_tap $? 165 'RevokeUserEntitlements' test.out

#- 166 GetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlement \
    --entitlementId '4noj3J79' \
    --namespace $AB_NAMESPACE \
    --userId 'DD3bAZF4' \
    > test.out 2>&1
eval_tap $? 166 'GetUserEntitlement' test.out

#- 167 UpdateUserEntitlement
# body param: body
echo '{"endDate": "1977-08-08T00:00:00Z", "nullFieldList": ["uNxISmVG"], "startDate": "1994-07-20T00:00:00Z", "status": "CONSUMED", "useCount": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserEntitlement \
    --entitlementId '8wegrDo6' \
    --namespace $AB_NAMESPACE \
    --userId 'OmeKL7GP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 167 'UpdateUserEntitlement' test.out

#- 168 ConsumeUserEntitlement
# body param: body
echo '{"useCount": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ConsumeUserEntitlement \
    --entitlementId 'I9uWOFTW' \
    --namespace $AB_NAMESPACE \
    --userId 'dRrL6yNm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 168 'ConsumeUserEntitlement' test.out

#- 169 DisableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op DisableUserEntitlement \
    --entitlementId 'v8k1w19J' \
    --namespace $AB_NAMESPACE \
    --userId 'sHSqOByh' \
    > test.out 2>&1
eval_tap $? 169 'DisableUserEntitlement' test.out

#- 170 EnableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op EnableUserEntitlement \
    --entitlementId '4hhkcO6J' \
    --namespace $AB_NAMESPACE \
    --userId '7jSvYd4J' \
    > test.out 2>&1
eval_tap $? 170 'EnableUserEntitlement' test.out

#- 171 GetUserEntitlementHistories
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementHistories \
    --entitlementId '5c6ayFnS' \
    --namespace $AB_NAMESPACE \
    --userId 'rfmObFTU' \
    > test.out 2>&1
eval_tap $? 171 'GetUserEntitlementHistories' test.out

#- 172 RevokeUserEntitlement
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlement \
    --entitlementId 'BRRDGCRQ' \
    --namespace $AB_NAMESPACE \
    --userId 'tMc3an8Z' \
    > test.out 2>&1
eval_tap $? 172 'RevokeUserEntitlement' test.out

#- 173 FulfillItem
# body param: body
echo '{"duration": 28, "endDate": "1982-10-27T00:00:00Z", "itemId": "wXHS1oUz", "itemSku": "DdDcZ0Rj", "language": "3YM1fz9C", "order": {"currency": {"currencyCode": "jqtqeiyD", "currencySymbol": "CK7C3u5G", "currencyType": "REAL", "decimals": 83, "namespace": "bmi5KiFD"}, "ext": {"VpfvR2Wl": {}}, "free": false}, "orderNo": "ShagpvFu", "quantity": 41, "region": "45zsrSpv", "source": "OTHER", "startDate": "1989-06-16T00:00:00Z", "storeId": "Qw3sPxFu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillItem \
    --namespace $AB_NAMESPACE \
    --userId '8LQGQCAj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 173 'FulfillItem' test.out

#- 174 RedeemCode
# body param: body
echo '{"code": "6O7ivhNI", "language": "vt_tlWz", "region": "AJ6ZBTHY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RedeemCode \
    --namespace $AB_NAMESPACE \
    --userId 'jGbVtzsB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 174 'RedeemCode' test.out

#- 175 FulfillRewards
# body param: body
echo '{"rewards": [{"currency": {"currencyCode": "TCOWEnaL", "namespace": "zHuYKrr8"}, "item": {"itemId": "9z0RkL93", "itemSku": "2B7thDQ3", "itemType": "hfVnPK8i"}, "quantity": 72, "type": "ITEM"}], "source": "PURCHASE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillRewards \
    --namespace $AB_NAMESPACE \
    --userId 'ZPnXwGS9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 175 'FulfillRewards' test.out

#- 176 QueryUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserIAPOrders \
    --namespace $AB_NAMESPACE \
    --userId 'fAlxtjeZ' \
    --endTime 'UrqmIc7E' \
    --limit '23' \
    --offset '77' \
    --productId 'EAvaPTww' \
    --startTime 'JrG06Mtc' \
    --status 'FULFILLED' \
    --type 'STADIA' \
    > test.out 2>&1
eval_tap $? 176 'QueryUserIAPOrders' test.out

#- 177 QueryAllUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryAllUserIAPOrders \
    --namespace $AB_NAMESPACE \
    --userId '8DQxcoQB' \
    > test.out 2>&1
eval_tap $? 177 'QueryAllUserIAPOrders' test.out

#- 178 MockFulfillIAPItem
# body param: body
echo '{"itemIdentityType": "ITEM_ID", "language": "dMu", "productId": "Xi2LgkAL", "region": "Gxw6qgvI", "type": "EPICGAMES"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op MockFulfillIAPItem \
    --namespace $AB_NAMESPACE \
    --userId 'e6rDGbFN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 178 'MockFulfillIAPItem' test.out

#- 179 QueryUserOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserOrders \
    --namespace $AB_NAMESPACE \
    --userId 'zsyQVqvS' \
    --itemId 'gtpUVddL' \
    --limit '52' \
    --offset '4' \
    --status 'REFUNDING' \
    > test.out 2>&1
eval_tap $? 179 'QueryUserOrders' test.out

#- 180 CountOfPurchasedItem
$CLI_EXE \
    --sn platform \
    --op CountOfPurchasedItem \
    --namespace $AB_NAMESPACE \
    --userId 'muKlGHZd' \
    --itemId 'wwo66H6Q' \
    > test.out 2>&1
eval_tap $? 180 'CountOfPurchasedItem' test.out

#- 181 GetUserOrder
$CLI_EXE \
    --sn platform \
    --op GetUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'OfYztHev' \
    --userId '8RX4MWRF' \
    > test.out 2>&1
eval_tap $? 181 'GetUserOrder' test.out

#- 182 UpdateUserOrderStatus
# body param: body
echo '{"status": "CHARGEBACK", "statusReason": "lN13WW7U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserOrderStatus \
    --namespace $AB_NAMESPACE \
    --orderNo '0sRVCnzR' \
    --userId 'xni0Kq9Z' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 182 'UpdateUserOrderStatus' test.out

#- 183 FulfillUserOrder
$CLI_EXE \
    --sn platform \
    --op FulfillUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'l2b7ChMC' \
    --userId 'xb6xdzl2' \
    > test.out 2>&1
eval_tap $? 183 'FulfillUserOrder' test.out

#- 184 GetUserOrderGrant
$CLI_EXE \
    --sn platform \
    --op GetUserOrderGrant \
    --namespace $AB_NAMESPACE \
    --orderNo 'OYVRJNC7' \
    --userId 'EruVITun' \
    > test.out 2>&1
eval_tap $? 184 'GetUserOrderGrant' test.out

#- 185 GetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op GetUserOrderHistories \
    --namespace $AB_NAMESPACE \
    --orderNo 'bxaOWNrM' \
    --userId 'kfALUDrR' \
    > test.out 2>&1
eval_tap $? 185 'GetUserOrderHistories' test.out

#- 186 ProcessUserOrderNotification
# body param: body
echo '{"additionalData": {"cardSummary": "6M3vzu84"}, "authorisedTime": "1993-11-07T00:00:00Z", "chargebackReversedTime": "1992-08-14T00:00:00Z", "chargebackTime": "1996-09-30T00:00:00Z", "chargedTime": "1978-10-21T00:00:00Z", "createdTime": "1986-06-15T00:00:00Z", "currency": {"currencyCode": "pQOjjkIY", "currencySymbol": "AQEcxGPT", "currencyType": "REAL", "decimals": 27, "namespace": "2NJ9gHmB"}, "customParameters": {"0vflV2Vp": {}}, "extOrderNo": "tGYAEziS", "extTxId": "thhR9WLi", "extUserId": "VTXHhZmB", "issuedAt": "1983-07-03T00:00:00Z", "metadata": {"lmWBLyhg": "ZsJoonMp"}, "namespace": "OQ9Jmh8w", "nonceStr": "wQ28fmxM", "paymentMethod": "FN8d9fdH", "paymentMethodFee": 52, "paymentOrderNo": "Hphhby7h", "paymentProvider": "WALLET", "paymentProviderFee": 72, "paymentStationUrl": "eIkY4Fc8", "price": 0, "refundedTime": "1980-10-13T00:00:00Z", "salesTax": 70, "sandbox": false, "sku": "bk9YdEm0", "status": "CHARGED", "statusReason": "9Rjjnkhw", "subscriptionId": "q75VqZH8", "subtotalPrice": 67, "targetNamespace": "Uq92UFWF", "targetUserId": "C8oFuU2O", "tax": 62, "totalPrice": 70, "totalTax": 45, "txEndTime": "1997-09-17T00:00:00Z", "type": "bioiiaZ8", "userId": "Uc2rWpzX", "vat": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserOrderNotification \
    --namespace $AB_NAMESPACE \
    --orderNo 'goBhruuv' \
    --userId 'EzpyRiFs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 186 'ProcessUserOrderNotification' test.out

#- 187 DownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op DownloadUserOrderReceipt \
    --namespace $AB_NAMESPACE \
    --orderNo '63b4Pru2' \
    --userId 'pWiVBYjK' \
    > test.out 2>&1
eval_tap $? 187 'DownloadUserOrderReceipt' test.out

#- 188 CreateUserPaymentOrder
# body param: body
echo '{"currencyCode": "I1ZlcKXB", "currencyNamespace": "XcPAsjW7", "customParameters": {"zBxpVc8s": {}}, "description": "vjiFtRe8", "extOrderNo": "k7amplfh", "extUserId": "uHropVxI", "itemType": "SUBSCRIPTION", "language": "JSy-TApP-vX", "metadata": {"gHJLBm3b": "gRvSUyOg"}, "notifyUrl": "yu9dhxao", "omitNotification": false, "price": 90, "recurringPaymentOrderNo": "jMYGTMXy", "region": "4ypcIN4u", "returnUrl": "UIzvUI5b", "sandbox": true, "sku": "xS2yBTD8", "subscriptionId": "uNeauLeX", "title": "NgQBnXZk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateUserPaymentOrder \
    --namespace $AB_NAMESPACE \
    --userId 'Q06LUEgy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 188 'CreateUserPaymentOrder' test.out

#- 189 RefundUserPaymentOrder
# body param: body
echo '{"description": "yiBeJARF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundUserPaymentOrder \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'VbUvLNtD' \
    --userId 'dAntKI6v' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 189 'RefundUserPaymentOrder' test.out

#- 190 ApplyUserRedemption
# body param: body
echo '{"code": "d3QdSHH2", "orderNo": "AvosR9Nk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ApplyUserRedemption \
    --namespace $AB_NAMESPACE \
    --userId '0JJYXMRc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 190 'ApplyUserRedemption' test.out

#- 191 QueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op QueryUserSubscriptions \
    --namespace $AB_NAMESPACE \
    --userId 'Qg1LwgzW' \
    --chargeStatus 'NEVER' \
    --itemId '5q2i8ntD' \
    --limit '7' \
    --offset '63' \
    --sku 'SOEIqFse' \
    --status 'CANCELLED' \
    --subscribedBy 'PLATFORM' \
    > test.out 2>&1
eval_tap $? 191 'QueryUserSubscriptions' test.out

#- 192 GetUserSubscriptionActivities
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionActivities \
    --namespace $AB_NAMESPACE \
    --userId 'rqjWTbUa' \
    --excludeSystem 'True' \
    --limit '68' \
    --offset '82' \
    --subscriptionId '8oO0z1Vf' \
    > test.out 2>&1
eval_tap $? 192 'GetUserSubscriptionActivities' test.out

#- 193 PlatformSubscribeSubscription
# body param: body
echo '{"grantDays": 11, "itemId": "DHyFM7T2", "language": "H6g4jbxD", "reason": "DxngEqsA", "region": "bWEfTc2n", "source": "SU2SijyS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PlatformSubscribeSubscription \
    --namespace $AB_NAMESPACE \
    --userId 'pnqX01uD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 193 'PlatformSubscribeSubscription' test.out

#- 194 CheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op CheckUserSubscriptionSubscribableByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'kQ1tv3iM' \
    --itemId 'MW8aqVbw' \
    > test.out 2>&1
eval_tap $? 194 'CheckUserSubscriptionSubscribableByItemId' test.out

#- 195 GetUserSubscription
$CLI_EXE \
    --sn platform \
    --op GetUserSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'ArhGSaFx' \
    --userId 'yAsPnfbH' \
    > test.out 2>&1
eval_tap $? 195 'GetUserSubscription' test.out

#- 196 DeleteUserSubscription
$CLI_EXE \
    --sn platform \
    --op DeleteUserSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'X5TpIV6e' \
    --userId '7dMKaAr2' \
    > test.out 2>&1
eval_tap $? 196 'DeleteUserSubscription' test.out

#- 197 CancelSubscription
# body param: body
echo '{"immediate": false, "reason": "tP8qxtNo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CancelSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId '76oPRuvx' \
    --userId 'UGNJvDRu' \
    --force 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 197 'CancelSubscription' test.out

#- 198 GrantDaysToSubscription
# body param: body
echo '{"grantDays": 51, "reason": "yWeusWdE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantDaysToSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'JnqhXgmV' \
    --userId 'QHoZNPy0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 198 'GrantDaysToSubscription' test.out

#- 199 GetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionBillingHistories \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'Wqu4qtxT' \
    --userId 'yrvNhypN' \
    --excludeFree 'False' \
    --limit '28' \
    --offset '34' \
    > test.out 2>&1
eval_tap $? 199 'GetUserSubscriptionBillingHistories' test.out

#- 200 ProcessUserSubscriptionNotification
# body param: body
echo '{"additionalData": {"cardSummary": "jcAKSuvg"}, "authorisedTime": "1994-03-14T00:00:00Z", "chargebackReversedTime": "1972-11-01T00:00:00Z", "chargebackTime": "1977-03-16T00:00:00Z", "chargedTime": "1981-07-12T00:00:00Z", "createdTime": "1991-06-12T00:00:00Z", "currency": {"currencyCode": "1OLRUrZ6", "currencySymbol": "vwIqGnoq", "currencyType": "VIRTUAL", "decimals": 7, "namespace": "7bvO6Xg2"}, "customParameters": {"xx5vZXC9": {}}, "extOrderNo": "YsEXEe9i", "extTxId": "C3Hp95At", "extUserId": "WE8drEip", "issuedAt": "1995-02-12T00:00:00Z", "metadata": {"ocCS9nGM": "6fYF1o77"}, "namespace": "M1VVgHHe", "nonceStr": "L0flEPUx", "paymentMethod": "HPhE4YwC", "paymentMethodFee": 87, "paymentOrderNo": "BGAR8TtZ", "paymentProvider": "ADYEN", "paymentProviderFee": 58, "paymentStationUrl": "IjOfYlF5", "price": 19, "refundedTime": "1988-12-21T00:00:00Z", "salesTax": 18, "sandbox": true, "sku": "wqLpFnnN", "status": "REQUEST_FOR_INFORMATION", "statusReason": "dTcPOtfk", "subscriptionId": "EyLh6l74", "subtotalPrice": 52, "targetNamespace": "QY5ulxH0", "targetUserId": "lioSoooP", "tax": 15, "totalPrice": 85, "totalTax": 47, "txEndTime": "1976-10-27T00:00:00Z", "type": "Me7ma8Qc", "userId": "9aGN5UJP", "vat": 75}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserSubscriptionNotification \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'chiivOQd' \
    --userId 'Byk3mWQ9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 200 'ProcessUserSubscriptionNotification' test.out

#- 201 AcquireUserTicket
# body param: body
echo '{"count": 55, "orderNo": "xbP1VP8r"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireUserTicket \
    --boothName 'KuVwTTGS' \
    --namespace $AB_NAMESPACE \
    --userId 'X5rG8ymO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 201 'AcquireUserTicket' test.out

#- 202 CheckWallet
$CLI_EXE \
    --sn platform \
    --op CheckWallet \
    --currencyCode '7ml7SCwM' \
    --namespace $AB_NAMESPACE \
    --userId '6RZNerJQ' \
    > test.out 2>&1
eval_tap $? 202 'CheckWallet' test.out

#- 203 CreditUserWallet
# body param: body
echo '{"amount": 34, "reason": "oYUkvHx2", "source": "PURCHASE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreditUserWallet \
    --currencyCode 'AjFF0BBG' \
    --namespace $AB_NAMESPACE \
    --userId 'wZ7XWhdo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 203 'CreditUserWallet' test.out

#- 204 PayWithUserWallet
# body param: body
echo '{"amount": 100}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PayWithUserWallet \
    --currencyCode 'x127YYBo' \
    --namespace $AB_NAMESPACE \
    --userId 'xSCFsBbZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 204 'PayWithUserWallet' test.out

#- 205 GetUserWallet
$CLI_EXE \
    --sn platform \
    --op GetUserWallet \
    --namespace $AB_NAMESPACE \
    --userId 'L16L2P8e' \
    --walletId 'NmOi4OPQ' \
    > test.out 2>&1
eval_tap $? 205 'GetUserWallet' test.out

#- 206 DebitUserWallet
# body param: body
echo '{"amount": 60, "reason": "V8XzBcAn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DebitUserWallet \
    --namespace $AB_NAMESPACE \
    --userId 'iVuoW6wP' \
    --walletId 'QlP1zgkx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 206 'DebitUserWallet' test.out

#- 207 DisableUserWallet
$CLI_EXE \
    --sn platform \
    --op DisableUserWallet \
    --namespace $AB_NAMESPACE \
    --userId 'v25ZHaR8' \
    --walletId 'vsMhIfog' \
    > test.out 2>&1
eval_tap $? 207 'DisableUserWallet' test.out

#- 208 EnableUserWallet
$CLI_EXE \
    --sn platform \
    --op EnableUserWallet \
    --namespace $AB_NAMESPACE \
    --userId 'RB8XeZhA' \
    --walletId 'M4MAL57r' \
    > test.out 2>&1
eval_tap $? 208 'EnableUserWallet' test.out

#- 209 ListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op ListUserWalletTransactions \
    --namespace $AB_NAMESPACE \
    --userId 'iU2QbQFR' \
    --walletId 'CXEWG8Sx' \
    --limit '38' \
    --offset '43' \
    > test.out 2>&1
eval_tap $? 209 'ListUserWalletTransactions' test.out

#- 210 QueryWallets
$CLI_EXE \
    --sn platform \
    --op QueryWallets \
    --namespace $AB_NAMESPACE \
    --currencyCode 'tTkIWbiH' \
    --limit '91' \
    --offset '93' \
    --userId 'DDL4yzTn' \
    > test.out 2>&1
eval_tap $? 210 'QueryWallets' test.out

#- 211 GetWallet
$CLI_EXE \
    --sn platform \
    --op GetWallet \
    --namespace $AB_NAMESPACE \
    --walletId 'Qv0e99zY' \
    > test.out 2>&1
eval_tap $? 211 'GetWallet' test.out

#- 212 SyncOrders
$CLI_EXE \
    --sn platform \
    --op SyncOrders \
    --nextEvaluatedKey 'NkH6PuvE' \
    --end 'RGP7fmyd' \
    --start '8aJkJYGK' \
    > test.out 2>&1
eval_tap $? 212 'SyncOrders' test.out

#- 213 TestAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["f4wBCsCL"], "apiKey": "rfH6V3fT", "authoriseAsCapture": false, "blockedPaymentMethods": ["r0UZS96w"], "clientKey": "D9rgdYvy", "dropInSettings": "fGQvBMJG", "liveEndpointUrlPrefix": "a0RWFilS", "merchantAccount": "DbJxY0YR", "notificationHmacKey": "9wXVRz5a", "notificationPassword": "yquoA8CG", "notificationUsername": "DmAN0yX8", "returnUrl": "xu01b0bU", "settings": "qDheu9id"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 213 'TestAdyenConfig' test.out

#- 214 TestAliPayConfig
# body param: body
echo '{"appId": "Q8V1CaeT", "privateKey": "74VP6Kqp", "publicKey": "Z2JC53CG", "returnUrl": "QXzjGEvv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 214 'TestAliPayConfig' test.out

#- 215 TestCheckoutConfig
# body param: body
echo '{"publicKey": "9VR6Qqao", "secretKey": "AupKSo0R"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 215 'TestCheckoutConfig' test.out

#- 216 DebugMatchedPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentMerchantConfig \
    --namespace_ 'XML3VcaD' \
    --region 'WEzPCi2t' \
    > test.out 2>&1
eval_tap $? 216 'DebugMatchedPaymentMerchantConfig' test.out

#- 217 TestPayPalConfig
# body param: body
echo '{"clientID": "WPzhrjLF", "clientSecret": "LLuGlXIn", "returnUrl": "Vkn9ojnp", "webHookId": "piU7rYU0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 217 'TestPayPalConfig' test.out

#- 218 TestStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["1JzPmaRk"], "publishableKey": "eYX8U71w", "secretKey": "09mTap7y", "webhookSecret": "90X88qbd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestStripeConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 218 'TestStripeConfig' test.out

#- 219 TestWxPayConfig
# body param: body
echo '{"appId": "RMUmqoGB", "key": "qBaxLbpD", "mchid": "ekuIzTOD", "returnUrl": "QZkNg9Xs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 219 'TestWxPayConfig' test.out

#- 220 TestXsollaConfig
# body param: body
echo '{"apiKey": "cMV2DnOo", "flowCompletionUrl": "9PaoBSJJ", "merchantId": 64, "projectId": 12, "projectSecretKey": "g8epTUeh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 220 'TestXsollaConfig' test.out

#- 221 GetPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentMerchantConfig \
    --id 'n6IzqXst' \
    > test.out 2>&1
eval_tap $? 221 'GetPaymentMerchantConfig' test.out

#- 222 UpdateAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["eu4pU694"], "apiKey": "ex0bxtkv", "authoriseAsCapture": true, "blockedPaymentMethods": ["bCB52HlT"], "clientKey": "eFVmpXnr", "dropInSettings": "WDCij8S7", "liveEndpointUrlPrefix": "3sQDNy12", "merchantAccount": "G1PiTJwx", "notificationHmacKey": "V0rwMM7H", "notificationPassword": "sMJnUBZ6", "notificationUsername": "Gyhfcrdd", "returnUrl": "eIOhxQMI", "settings": "mB13f1ob"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAdyenConfig \
    --id 'TKrwFXC2' \
    --sandbox 'False' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 222 'UpdateAdyenConfig' test.out

#- 223 TestAdyenConfigById
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfigById \
    --id 'XEIOAJh6' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 223 'TestAdyenConfigById' test.out

#- 224 UpdateAliPayConfig
# body param: body
echo '{"appId": "HWdmibqD", "privateKey": "eNic565h", "publicKey": "vy1VY236", "returnUrl": "5rUHkxww"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAliPayConfig \
    --id 'pNwFJyOB' \
    --sandbox 'False' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 224 'UpdateAliPayConfig' test.out

#- 225 TestAliPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfigById \
    --id 'glT04uRm' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 225 'TestAliPayConfigById' test.out

#- 226 UpdateCheckoutConfig
# body param: body
echo '{"publicKey": "eOhTeibS", "secretKey": "q4H7xDe1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCheckoutConfig \
    --id 'jh7clQul' \
    --sandbox 'False' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 226 'UpdateCheckoutConfig' test.out

#- 227 TestCheckoutConfigById
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfigById \
    --id 'FzOE2zPD' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 227 'TestCheckoutConfigById' test.out

#- 228 UpdatePayPalConfig
# body param: body
echo '{"clientID": "GsklKEj2", "clientSecret": "cImuLS8r", "returnUrl": "rBfOaAEN", "webHookId": "FCnYbIQI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePayPalConfig \
    --id 'DkTf41ag' \
    --sandbox 'True' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 228 'UpdatePayPalConfig' test.out

#- 229 TestPayPalConfigById
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfigById \
    --id 'WPut7xra' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 229 'TestPayPalConfigById' test.out

#- 230 UpdateStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["aeaiep5a"], "publishableKey": "TdbjoDWO", "secretKey": "L2gmjDt1", "webhookSecret": "rOz0DT1A"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStripeConfig \
    --id 'xwhim0K9' \
    --sandbox 'False' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 230 'UpdateStripeConfig' test.out

#- 231 TestStripeConfigById
$CLI_EXE \
    --sn platform \
    --op TestStripeConfigById \
    --id 'mBcUU86i' \
    --sandbox 'True' \
    > test.out 2>&1
eval_tap $? 231 'TestStripeConfigById' test.out

#- 232 UpdateWxPayConfig
# body param: body
echo '{"appId": "JulX4aR8", "key": "w6Q4PkLk", "mchid": "wcg4w7vo", "returnUrl": "onsTuM2o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfig \
    --id 'BECnfwi6' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 232 'UpdateWxPayConfig' test.out

#- 233 UpdateWxPayConfigCert
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfigCert \
    --id 'gqpB4WwK' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 233 'UpdateWxPayConfigCert' test.out

#- 234 TestWxPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfigById \
    --id 'tAnQQIfN' \
    > test.out 2>&1
eval_tap $? 234 'TestWxPayConfigById' test.out

#- 235 UpdateXsollaConfig
# body param: body
echo '{"apiKey": "q8tkbUlx", "flowCompletionUrl": "AfBvJ3tw", "merchantId": 73, "projectId": 92, "projectSecretKey": "1E8SglSH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaConfig \
    --id 'PDOBkao6' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 235 'UpdateXsollaConfig' test.out

#- 236 TestXsollaConfigById
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfigById \
    --id '7WrSKfNZ' \
    > test.out 2>&1
eval_tap $? 236 'TestXsollaConfigById' test.out

#- 237 UpdateXsollaUIConfig
# body param: body
echo '{"device": "DESKTOP", "showCloseButton": false, "size": "MEDIUM", "theme": "DEFAULT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaUIConfig \
    --id '3vs48k8G' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 237 'UpdateXsollaUIConfig' test.out

#- 238 QueryPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op QueryPaymentProviderConfig \
    --limit '24' \
    --namespace_ 'WbZOgcnb' \
    --offset '20' \
    --region 'NsJBKfFA' \
    > test.out 2>&1
eval_tap $? 238 'QueryPaymentProviderConfig' test.out

#- 239 CreatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "2oC4m8qm", "region": "GI4g3x7V", "sandboxTaxJarApiToken": "kgLXzEcg", "specials": ["STRIPE"], "taxJarApiToken": "clUWy7ZJ", "taxJarEnabled": true, "useGlobalTaxJarApiToken": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreatePaymentProviderConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 239 'CreatePaymentProviderConfig' test.out

#- 240 GetAggregatePaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetAggregatePaymentProviders \
    > test.out 2>&1
eval_tap $? 240 'GetAggregatePaymentProviders' test.out

#- 241 DebugMatchedPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentProviderConfig \
    --namespace_ 'W2qMkZ2m' \
    --region '9trvZisC' \
    > test.out 2>&1
eval_tap $? 241 'DebugMatchedPaymentProviderConfig' test.out

#- 242 GetSpecialPaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetSpecialPaymentProviders \
    > test.out 2>&1
eval_tap $? 242 'GetSpecialPaymentProviders' test.out

#- 243 UpdatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "lZ6nzcA0", "region": "5v44SCrW", "sandboxTaxJarApiToken": "kKPTz20C", "specials": ["ALIPAY"], "taxJarApiToken": "ON0qlw6d", "taxJarEnabled": true, "useGlobalTaxJarApiToken": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentProviderConfig \
    --id 'v7zSESiU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 243 'UpdatePaymentProviderConfig' test.out

#- 244 DeletePaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DeletePaymentProviderConfig \
    --id 'AVN1CwX4' \
    > test.out 2>&1
eval_tap $? 244 'DeletePaymentProviderConfig' test.out

#- 245 GetPaymentTaxConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxConfig \
    > test.out 2>&1
eval_tap $? 245 'GetPaymentTaxConfig' test.out

#- 246 UpdatePaymentTaxConfig
# body param: body
echo '{"sandboxTaxJarApiToken": "ZMRG0Gf1", "taxJarApiToken": "rfLs27GU", "taxJarEnabled": false, "taxJarProductCodesMapping": {"4LXB9YV8": "FW73Yegp"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentTaxConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 246 'UpdatePaymentTaxConfig' test.out

#- 247 SyncPaymentOrders
$CLI_EXE \
    --sn platform \
    --op SyncPaymentOrders \
    --nextEvaluatedKey 'NcJMlA9w' \
    --end 'UgUsQ5nj' \
    --start 'C8VO4sgo' \
    > test.out 2>&1
eval_tap $? 247 'SyncPaymentOrders' test.out

#- 248 PublicGetRootCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetRootCategories \
    --namespace $AB_NAMESPACE \
    --language 'RFcoG9Ev' \
    --storeId 'gBLbT6LI' \
    > test.out 2>&1
eval_tap $? 248 'PublicGetRootCategories' test.out

#- 249 DownloadCategories
$CLI_EXE \
    --sn platform \
    --op DownloadCategories \
    --namespace $AB_NAMESPACE \
    --language 'znmery1q' \
    --storeId '7Ru0EPX2' \
    > test.out 2>&1
eval_tap $? 249 'DownloadCategories' test.out

#- 250 PublicGetCategory
$CLI_EXE \
    --sn platform \
    --op PublicGetCategory \
    --categoryPath 't5Kl8G5S' \
    --namespace $AB_NAMESPACE \
    --language 'm4GZYuYJ' \
    --storeId '1bv2f6vr' \
    > test.out 2>&1
eval_tap $? 250 'PublicGetCategory' test.out

#- 251 PublicGetChildCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetChildCategories \
    --categoryPath 'f7yzKmiS' \
    --namespace $AB_NAMESPACE \
    --language 'oLdcKYGi' \
    --storeId 'j2Fob7nz' \
    > test.out 2>&1
eval_tap $? 251 'PublicGetChildCategories' test.out

#- 252 PublicGetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetDescendantCategories \
    --categoryPath '3cBYTpN9' \
    --namespace $AB_NAMESPACE \
    --language 'BOiieVeC' \
    --storeId 'IJp60mv8' \
    > test.out 2>&1
eval_tap $? 252 'PublicGetDescendantCategories' test.out

#- 253 PublicListCurrencies
$CLI_EXE \
    --sn platform \
    --op PublicListCurrencies \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 253 'PublicListCurrencies' test.out

#- 254 PublicGetItemByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetItemByAppId \
    --namespace $AB_NAMESPACE \
    --language '8QYWnFYR' \
    --region 'XnDSOYxR' \
    --storeId '9xEcI7kt' \
    --appId 'ZgyQ1Pcq' \
    > test.out 2>&1
eval_tap $? 254 'PublicGetItemByAppId' test.out

#- 255 PublicQueryItems
$CLI_EXE \
    --sn platform \
    --op PublicQueryItems \
    --namespace $AB_NAMESPACE \
    --appType 'DEMO' \
    --baseAppId 'ZnaDTm4W' \
    --categoryPath 'wM8q1mZu' \
    --features '6XW6by2j' \
    --itemType 'CODE' \
    --language 'Xr2YyM5h' \
    --limit '28' \
    --offset '26' \
    --region 'PrfkWpDz' \
    --sortBy '1gbwdSWE' \
    --storeId 'GD0k52Xl' \
    --tags 'do1D8HlE' \
    > test.out 2>&1
eval_tap $? 255 'PublicQueryItems' test.out

#- 256 PublicGetItemBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetItemBySku \
    --namespace $AB_NAMESPACE \
    --language 'uQQfYbi9' \
    --region 'H9dFCgRp' \
    --storeId '7uEwOPWr' \
    --sku 'KnASgjfb' \
    > test.out 2>&1
eval_tap $? 256 'PublicGetItemBySku' test.out

#- 257 PublicBulkGetItems
$CLI_EXE \
    --sn platform \
    --op PublicBulkGetItems \
    --namespace $AB_NAMESPACE \
    --language 'B7kWEU28' \
    --region 'xX2fI68k' \
    --storeId 'SyNp7CBC' \
    --itemIds 'tgT4nlpO' \
    > test.out 2>&1
eval_tap $? 257 'PublicBulkGetItems' test.out

#- 258 PublicSearchItems
$CLI_EXE \
    --sn platform \
    --op PublicSearchItems \
    --namespace $AB_NAMESPACE \
    --limit '1' \
    --offset '61' \
    --region '9RqY1zhD' \
    --storeId '25toALOu' \
    --keyword 'g3D6sySW' \
    --language 'jGkmDxeI' \
    > test.out 2>&1
eval_tap $? 258 'PublicSearchItems' test.out

#- 259 PublicGetApp
$CLI_EXE \
    --sn platform \
    --op PublicGetApp \
    --itemId 'vWSM0L1e' \
    --namespace $AB_NAMESPACE \
    --language 'tOsAoob5' \
    --region 'LsBHH7TR' \
    --storeId 'U7DSv4Bl' \
    > test.out 2>&1
eval_tap $? 259 'PublicGetApp' test.out

#- 260 PublicGetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op PublicGetItemDynamicData \
    --itemId '1JLViUnC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 260 'PublicGetItemDynamicData' test.out

#- 261 PublicGetItem
$CLI_EXE \
    --sn platform \
    --op PublicGetItem \
    --itemId 'f9br0Awr' \
    --namespace $AB_NAMESPACE \
    --language 'YymvbyVt' \
    --populateBundle 'False' \
    --region 'yXglS0dt' \
    --storeId 'EcGJ3Vfs' \
    > test.out 2>&1
eval_tap $? 261 'PublicGetItem' test.out

#- 262 GetPaymentCustomization
eval_tap 0 262 'GetPaymentCustomization # SKIP deprecated' test.out

#- 263 PublicGetPaymentUrl
# body param: body
echo '{"paymentOrderNo": "szE68nyi", "paymentProvider": "WXPAY", "returnUrl": "CylIgcjA", "ui": "QgJS7ut6", "zipCode": "fWj0bjzR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentUrl \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 263 'PublicGetPaymentUrl' test.out

#- 264 PublicGetPaymentMethods
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentMethods \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo '1qk50WTJ' \
    > test.out 2>&1
eval_tap $? 264 'PublicGetPaymentMethods' test.out

#- 265 PublicGetUnpaidPaymentOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUnpaidPaymentOrder \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'SWMGCWOq' \
    > test.out 2>&1
eval_tap $? 265 'PublicGetUnpaidPaymentOrder' test.out

#- 266 Pay
# body param: body
echo '{"token": "gPcQEu7X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op Pay \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'P4K3h5qA' \
    --paymentProvider 'WALLET' \
    --zipCode 'xWIwznTW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 266 'Pay' test.out

#- 267 PublicCheckPaymentOrderPaidStatus
$CLI_EXE \
    --sn platform \
    --op PublicCheckPaymentOrderPaidStatus \
    --namespace $AB_NAMESPACE \
    --paymentOrderNo 'hLbxZXBh' \
    > test.out 2>&1
eval_tap $? 267 'PublicCheckPaymentOrderPaidStatus' test.out

#- 268 GetPaymentPublicConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentPublicConfig \
    --namespace $AB_NAMESPACE \
    --sandbox 'False' \
    --paymentProvider 'ADYEN' \
    --region 'BiiMbLGc' \
    > test.out 2>&1
eval_tap $? 268 'GetPaymentPublicConfig' test.out

#- 269 PublicGetQRCode
$CLI_EXE \
    --sn platform \
    --op PublicGetQRCode \
    --namespace $AB_NAMESPACE \
    --code 'BOF8Unez' \
    > test.out 2>&1
eval_tap $? 269 'PublicGetQRCode' test.out

#- 270 PublicNormalizePaymentReturnUrl
$CLI_EXE \
    --sn platform \
    --op PublicNormalizePaymentReturnUrl \
    --namespace $AB_NAMESPACE \
    --payerID 'JG2VBYcf' \
    --foreinginvoice '39AKgvjN' \
    --invoiceId 'NHD855hj' \
    --payload 'pm3ss60u' \
    --redirectResult 'ZFamFRGi' \
    --resultCode 'cFWBzTUo' \
    --sessionId 'htqJUSbF' \
    --status 'zSBVZmKw' \
    --token 'eECuD3sZ' \
    --type 'MCE8dESg' \
    --userId 'loJK7nM6' \
    --orderNo 'Je8rVsrM' \
    --paymentOrderNo 'iXvUICpX' \
    --paymentProvider 'WXPAY' \
    --returnUrl 'osGv2E5U' \
    > test.out 2>&1
eval_tap $? 270 'PublicNormalizePaymentReturnUrl' test.out

#- 271 GetPaymentTaxValue
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxValue \
    --namespace $AB_NAMESPACE \
    --zipCode 'd8R40Via' \
    --paymentOrderNo '1HQGyTJx' \
    --paymentProvider 'ALIPAY' \
    > test.out 2>&1
eval_tap $? 271 'GetPaymentTaxValue' test.out

#- 272 GetRewardByCode
$CLI_EXE \
    --sn platform \
    --op GetRewardByCode \
    --namespace $AB_NAMESPACE \
    --rewardCode 'E61z1d23' \
    > test.out 2>&1
eval_tap $? 272 'GetRewardByCode' test.out

#- 273 QueryRewards1
$CLI_EXE \
    --sn platform \
    --op QueryRewards1 \
    --namespace $AB_NAMESPACE \
    --eventTopic 'WGf1zfjn' \
    --limit '81' \
    --offset '12' \
    --sortBy 'bDHxFOx6' \
    > test.out 2>&1
eval_tap $? 273 'QueryRewards1' test.out

#- 274 GetReward1
$CLI_EXE \
    --sn platform \
    --op GetReward1 \
    --namespace $AB_NAMESPACE \
    --rewardId '8rBOBVv5' \
    > test.out 2>&1
eval_tap $? 274 'GetReward1' test.out

#- 275 PublicListStores
$CLI_EXE \
    --sn platform \
    --op PublicListStores \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 275 'PublicListStores' test.out

#- 276 PublicExistsAnyMyActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyMyActiveEntitlement \
    --namespace $AB_NAMESPACE \
    --appIds '["za3wZKkk"]' \
    --itemIds '["BXOpjG8D"]' \
    --skus '["MYI7aCPV"]' \
    > test.out 2>&1
eval_tap $? 276 'PublicExistsAnyMyActiveEntitlement' test.out

#- 277 PublicGetMyAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyAppEntitlementOwnershipByAppId \
    --namespace $AB_NAMESPACE \
    --appId 'OXyHlMa4' \
    > test.out 2>&1
eval_tap $? 277 'PublicGetMyAppEntitlementOwnershipByAppId' test.out

#- 278 PublicGetMyEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipByItemId \
    --namespace $AB_NAMESPACE \
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId 'ckktYeg9' \
    > test.out 2>&1
eval_tap $? 278 'PublicGetMyEntitlementOwnershipByItemId' test.out

#- 279 PublicGetMyEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipBySku \
    --namespace $AB_NAMESPACE \
    --entitlementClazz 'APP' \
    --sku 'TKGckRJx' \
    > test.out 2>&1
eval_tap $? 279 'PublicGetMyEntitlementOwnershipBySku' test.out

#- 280 PublicGetEntitlementOwnershipToken
$CLI_EXE \
    --sn platform \
    --op PublicGetEntitlementOwnershipToken \
    --namespace $AB_NAMESPACE \
    --appIds '["WrHhn4YO"]' \
    --itemIds '["K6MnfeVl"]' \
    --skus '["dbEnLYWO"]' \
    > test.out 2>&1
eval_tap $? 280 'PublicGetEntitlementOwnershipToken' test.out

#- 281 PublicGetMyWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetMyWallet \
    --currencyCode 'zyOB0kZo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 281 'PublicGetMyWallet' test.out

#- 282 PublicSyncPsnDlcInventory
# body param: body
echo '{"serviceLabel": 9}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSyncPsnDlcInventory \
    --namespace $AB_NAMESPACE \
    --userId 'JIWku1PB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 282 'PublicSyncPsnDlcInventory' test.out

#- 283 SyncSteamDLC
# body param: body
echo '{"appId": "eZzonuQz", "steamId": "xLODS8nT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamDLC \
    --namespace $AB_NAMESPACE \
    --userId 'AouPR62R' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 283 'SyncSteamDLC' test.out

#- 284 SyncXboxDLC
# body param: body
echo '{"xstsToken": "XcekOPk5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxDLC \
    --namespace $AB_NAMESPACE \
    --userId '1sYy0IuL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 284 'SyncXboxDLC' test.out

#- 285 PublicQueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'JPPNclQg' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'SUBSCRIPTION' \
    --entitlementName 'rjtMtdov' \
    --itemId '["0qluMZwW"]' \
    --limit '62' \
    --offset '84' \
    > test.out 2>&1
eval_tap $? 285 'PublicQueryUserEntitlements' test.out

#- 286 PublicGetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'cBAVMLvA' \
    --appId 'vzLjQSHw' \
    > test.out 2>&1
eval_tap $? 286 'PublicGetUserAppEntitlementByAppId' test.out

#- 287 PublicQueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlementsByAppType \
    --namespace $AB_NAMESPACE \
    --userId 'PO48On3g' \
    --limit '57' \
    --offset '3' \
    --appType 'DLC' \
    > test.out 2>&1
eval_tap $? 287 'PublicQueryUserEntitlementsByAppType' test.out

#- 288 PublicGetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'AwKRyMNC' \
    --entitlementClazz 'CODE' \
    --itemId 'YGZ9RvQU' \
    > test.out 2>&1
eval_tap $? 288 'PublicGetUserEntitlementByItemId' test.out

#- 289 PublicGetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementBySku \
    --namespace $AB_NAMESPACE \
    --userId 'XcWQhh5i' \
    --entitlementClazz 'SUBSCRIPTION' \
    --sku 'hyoneUWb' \
    > test.out 2>&1
eval_tap $? 289 'PublicGetUserEntitlementBySku' test.out

#- 290 PublicExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyUserActiveEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'Dyvutndg' \
    --appIds '["icjax7ON"]' \
    --itemIds '["nA3dvJOo"]' \
    --skus '["cdyisYR5"]' \
    > test.out 2>&1
eval_tap $? 290 'PublicExistsAnyUserActiveEntitlement' test.out

#- 291 PublicGetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementOwnershipByAppId \
    --namespace $AB_NAMESPACE \
    --userId 'yhrcsZyv' \
    --appId 'bLMUUSwl' \
    > test.out 2>&1
eval_tap $? 291 'PublicGetUserAppEntitlementOwnershipByAppId' test.out

#- 292 PublicGetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipByItemId \
    --namespace $AB_NAMESPACE \
    --userId '9luLGR0M' \
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId 'dWXP7dHv' \
    > test.out 2>&1
eval_tap $? 292 'PublicGetUserEntitlementOwnershipByItemId' test.out

#- 293 PublicGetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipBySku \
    --namespace $AB_NAMESPACE \
    --userId 'zRSx4xnE' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'seCMo1qF' \
    > test.out 2>&1
eval_tap $? 293 'PublicGetUserEntitlementOwnershipBySku' test.out

#- 294 PublicGetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlement \
    --entitlementId 'RoqmJULD' \
    --namespace $AB_NAMESPACE \
    --userId 'delYwV2D' \
    > test.out 2>&1
eval_tap $? 294 'PublicGetUserEntitlement' test.out

#- 295 PublicConsumeUserEntitlement
# body param: body
echo '{"useCount": 87}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicConsumeUserEntitlement \
    --entitlementId 'ZfSBnT2V' \
    --namespace $AB_NAMESPACE \
    --userId 'lyq5VWu4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 295 'PublicConsumeUserEntitlement' test.out

#- 296 PublicRedeemCode
# body param: body
echo '{"code": "pLxrqfJr", "language": "nc_sN", "region": "JZPieAS6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicRedeemCode \
    --namespace $AB_NAMESPACE \
    --userId 'Ozt9Y76C' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 296 'PublicRedeemCode' test.out

#- 297 PublicFulfillAppleIAPItem
# body param: body
echo '{"excludeOldTransactions": false, "language": "Xn-XHCE_UE", "productId": "WqEFljov", "receiptData": "jiFds9U3", "region": "Q4FL9FKh", "transactionId": "fTM3X1GH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillAppleIAPItem \
    --namespace $AB_NAMESPACE \
    --userId 'B92JFCpi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 297 'PublicFulfillAppleIAPItem' test.out

#- 298 SyncEpicGamesInventory
# body param: body
echo '{"epicGamesJwtToken": "6PSpyvcT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncEpicGamesInventory \
    --namespace $AB_NAMESPACE \
    --userId 'nMqT7mEL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 298 'SyncEpicGamesInventory' test.out

#- 299 PublicFulfillGoogleIAPItem
# body param: body
echo '{"autoAck": true, "language": "af", "orderId": "jIfXCWza", "packageName": "tjGv4UVj", "productId": "072ERIdI", "purchaseTime": 19, "purchaseToken": "nEdKEgYr", "region": "C08a2gef"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillGoogleIAPItem \
    --namespace $AB_NAMESPACE \
    --userId 'HyULfaLd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 299 'PublicFulfillGoogleIAPItem' test.out

#- 300 PublicReconcilePlayStationStore
# body param: body
echo '{"currencyCode": "tBzfi8aW", "price": 0.2660114810280835, "productId": "f1NWlgli", "serviceLabel": 97}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicReconcilePlayStationStore \
    --namespace $AB_NAMESPACE \
    --userId 'dgwwepIg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 300 'PublicReconcilePlayStationStore' test.out

#- 301 SyncStadiaEntitlement
# body param: body
echo '{"appId": "Kh0HKAG3", "language": "oF", "region": "WxTfKegx", "stadiaPlayerId": "R0U2CExN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncStadiaEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'lVZ2RGvV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 301 'SyncStadiaEntitlement' test.out

#- 302 SyncSteamInventory
# body param: body
echo '{"appId": "o9j2WLb2", "currencyCode": "CSAgZdAF", "language": "Ns-pzqq_898", "price": 0.9903583311660245, "productId": "4njvE58h", "region": "P4ov9Lr3", "steamId": "EkTSLIsh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamInventory \
    --namespace $AB_NAMESPACE \
    --userId 'qSb4fuvT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 302 'SyncSteamInventory' test.out

#- 303 SyncTwitchDropsEntitlement
# body param: body
echo '{"gameId": "w4H9hubY", "language": "iVVU_fN", "region": "bsYzIcst"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncTwitchDropsEntitlement \
    --namespace $AB_NAMESPACE \
    --userId 'Ous7bRp1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 303 'SyncTwitchDropsEntitlement' test.out

#- 304 SyncXboxInventory
# body param: body
echo '{"currencyCode": "CdG3Hblu", "price": 0.9650787558445256, "productId": "YQD4Otx1", "xstsToken": "GZEBw1Jk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxInventory \
    --namespace $AB_NAMESPACE \
    --userId 'hddhy686' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 304 'SyncXboxInventory' test.out

#- 305 PublicQueryUserOrders
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
eval_tap $? 305 'PublicQueryUserOrders' test.out

#- 306 PublicCreateUserOrder
# body param: body
echo '{"currencyCode": "Ot0SmGDz", "discountedPrice": 28, "ext": {"1dDuZYxY": {}}, "itemId": "8RWgiwIj", "language": "GKyW-628", "price": 4, "quantity": 62, "region": "VCYsZcY5", "returnUrl": "pJfXaaUs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCreateUserOrder \
    --namespace $AB_NAMESPACE \
    --userId 'khgMZlpx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 306 'PublicCreateUserOrder' test.out

#- 307 PublicGetUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'mjm9f23L' \
    --userId 'lr7WKchQ' \
    > test.out 2>&1
eval_tap $? 307 'PublicGetUserOrder' test.out

#- 308 PublicCancelUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicCancelUserOrder \
    --namespace $AB_NAMESPACE \
    --orderNo 'rdRvUcqA' \
    --userId 'HelKgovo' \
    > test.out 2>&1
eval_tap $? 308 'PublicCancelUserOrder' test.out

#- 309 PublicGetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrderHistories \
    --namespace $AB_NAMESPACE \
    --orderNo 'wPUtF6DL' \
    --userId 'evfnhWi0' \
    > test.out 2>&1
eval_tap $? 309 'PublicGetUserOrderHistories' test.out

#- 310 PublicDownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op PublicDownloadUserOrderReceipt \
    --namespace $AB_NAMESPACE \
    --orderNo 'LSLOvWcj' \
    --userId 'aWpr1gk6' \
    > test.out 2>&1
eval_tap $? 310 'PublicDownloadUserOrderReceipt' test.out

#- 311 PublicGetPaymentAccounts
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentAccounts \
    --namespace $AB_NAMESPACE \
    --userId 'Cb5tABJO' \
    > test.out 2>&1
eval_tap $? 311 'PublicGetPaymentAccounts' test.out

#- 312 PublicDeletePaymentAccount
$CLI_EXE \
    --sn platform \
    --op PublicDeletePaymentAccount \
    --id '3orPfizP' \
    --namespace $AB_NAMESPACE \
    --type 'paypal' \
    --userId 'wbyfoC6o' \
    > test.out 2>&1
eval_tap $? 312 'PublicDeletePaymentAccount' test.out

#- 313 PublicQueryUserSubscriptions
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
eval_tap $? 313 'PublicQueryUserSubscriptions' test.out

#- 314 PublicSubscribeSubscription
# body param: body
echo '{"currencyCode": "MvcnJGqj", "itemId": "2G28XQmz", "language": "TtYJ_BFGk-335", "region": "1ZepOAJR", "returnUrl": "lCb7x8Bb", "source": "V5fQSmVl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSubscribeSubscription \
    --namespace $AB_NAMESPACE \
    --userId 'jKVLc1aV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 314 'PublicSubscribeSubscription' test.out

#- 315 PublicCheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op PublicCheckUserSubscriptionSubscribableByItemId \
    --namespace $AB_NAMESPACE \
    --userId 'QNlsm8f2' \
    --itemId 'XRjKcW95' \
    > test.out 2>&1
eval_tap $? 315 'PublicCheckUserSubscriptionSubscribableByItemId' test.out

#- 316 PublicGetUserSubscription
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscription \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'AO0RLEUg' \
    --userId 'kXqKmlhk' \
    > test.out 2>&1
eval_tap $? 316 'PublicGetUserSubscription' test.out

#- 317 PublicChangeSubscriptionBillingAccount
$CLI_EXE \
    --sn platform \
    --op PublicChangeSubscriptionBillingAccount \
    --namespace $AB_NAMESPACE \
    --subscriptionId 'XoXwCzge' \
    --userId 'VyEsm1LK' \
    > test.out 2>&1
eval_tap $? 317 'PublicChangeSubscriptionBillingAccount' test.out

#- 318 PublicCancelSubscription
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
eval_tap $? 318 'PublicCancelSubscription' test.out

#- 319 PublicGetUserSubscriptionBillingHistories
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
eval_tap $? 319 'PublicGetUserSubscriptionBillingHistories' test.out

#- 320 PublicGetWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetWallet \
    --currencyCode 'kf4msE7d' \
    --namespace $AB_NAMESPACE \
    --userId 'goYbfALB' \
    > test.out 2>&1
eval_tap $? 320 'PublicGetWallet' test.out

#- 321 PublicListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op PublicListUserWalletTransactions \
    --currencyCode 'MEdRlqlv' \
    --namespace $AB_NAMESPACE \
    --userId 'MdQrXgZH' \
    --limit '27' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 321 'PublicListUserWalletTransactions' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE