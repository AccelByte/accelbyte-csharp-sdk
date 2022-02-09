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

OPERATIONS_COUNT=316

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

#- 1 ListFulfillmentScripts
$CLI_EXE \
    --sn platform \
    --op ListFulfillmentScripts \
    >$TEMP_FILE 2>&1
update_status $? 'ListFulfillmentScripts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 TestFulfillmentScriptEval
# body param: body
echo '{"context": {"item": {"appId": "b0Cjv4Ax", "appType": "DEMO", "baseAppId": "Ykoppa0V", "boothName": "gFJAhHwT", "boundItemIds": ["b5q010gN"], "categoryPath": "2MQrbpeR", "clazz": "nxTlCTFS", "createdAt": "1990-09-30T00:00:00Z", "description": "bl1a2jXL", "displayOrder": 57, "entitlementType": "CONSUMABLE", "ext": {"WmHJBi9S": {}}, "features": ["oMkSE4eJ"], "images": [{"as": "elwO4KPM", "caption": "ky2h8R2f", "height": 69, "imageUrl": "XoXP8gd7", "smallImageUrl": "JUabYc3G", "width": 77}], "itemId": "bxTlm1fs", "itemIds": ["u6J3C4s5"], "itemQty": {"ppGR9Xco": 46}, "itemType": "COINS", "language": "ewrLfwvz", "listable": true, "localExt": {"4TpbNhKq": {}}, "longDescription": "2xdmgEBe", "maxCount": 30, "maxCountPerUser": 62, "name": "Htf6Zieg", "namespace": "qdEL4fsM", "purchasable": false, "recurring": {"cycle": "YEARLY", "fixedFreeDays": 50, "fixedTrialCycles": 87, "graceDays": 95}, "region": "uC1r7UH1", "regionData": [{"currencyCode": "Liu7UQ03", "currencyNamespace": "04McK873", "currencyType": "VIRTUAL", "discountAmount": 87, "discountExpireAt": "1980-05-17T00:00:00Z", "discountPercentage": 4, "discountPurchaseAt": "1973-11-17T00:00:00Z", "discountedPrice": 71, "expireAt": "1988-01-18T00:00:00Z", "price": 42, "purchaseAt": "1980-11-18T00:00:00Z", "trialPrice": 26}], "seasonType": "TIER", "sku": "4jNWGc7C", "stackable": false, "status": "ACTIVE", "tags": ["4wM5Eu3V"], "targetCurrencyCode": "qymsFXpo", "targetItemId": "rMqEDR8E", "targetNamespace": "72XMKfhl", "thumbnailUrl": "6eq2FzU3", "title": "VL3LNmPL", "updatedAt": "1973-01-28T00:00:00Z", "useCount": 28}, "namespace": "CXfabFXz", "order": {"currency": {"currencyCode": "vjLmai7f", "currencySymbol": "PKvE2Z4a", "currencyType": "VIRTUAL", "decimals": 74, "namespace": "bQSWtsyz"}, "ext": {"0mGGyHHF": {}}, "free": false}, "source": "DLC"}, "script": "KsXgvSrk", "type": "grantDays"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestFulfillmentScriptEval \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestFulfillmentScriptEval'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetFulfillmentScript
$CLI_EXE \
    --sn platform \
    --op GetFulfillmentScript \
    --id 'gTYVk5iR' \
    >$TEMP_FILE 2>&1
update_status $? 'GetFulfillmentScript'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 CreateFulfillmentScript
# body param: body
echo '{"grantDays": "BE6zJJ1B"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateFulfillmentScript \
    --id 'RHrfCHqq' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateFulfillmentScript'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 DeleteFulfillmentScript
$CLI_EXE \
    --sn platform \
    --op DeleteFulfillmentScript \
    --id 'p2GwPcmz' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteFulfillmentScript'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 UpdateFulfillmentScript
# body param: body
echo '{"grantDays": "SuY8w9VY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateFulfillmentScript \
    --id 'wBEfRXoZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateFulfillmentScript'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 QueryCampaigns
$CLI_EXE \
    --sn platform \
    --op QueryCampaigns \
    --namespace $TEST_NAMESPACE \
    --limit '75' \
    --name 'fpVFfDwj' \
    --offset '66' \
    --tag 'HCW2g5u8' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryCampaigns'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 CreateCampaign
# body param: body
echo '{"description": "z9yrpJdI", "items": [{"extraSubscriptionDays": 46, "itemId": "5vvHS3d6", "itemName": "PKPE27mI", "quantity": 82}], "maxRedeemCountPerCampaignPerUser": 46, "maxRedeemCountPerCode": 19, "maxRedeemCountPerCodePerUser": 38, "maxSaleCount": 74, "name": "q4x0F7Nc", "redeemEnd": "1978-01-21T00:00:00Z", "redeemStart": "1973-03-31T00:00:00Z", "redeemType": "ITEM", "status": "INACTIVE", "tags": ["lKYu8iCP"], "type": "REDEMPTION"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCampaign \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateCampaign'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 GetCampaign
$CLI_EXE \
    --sn platform \
    --op GetCampaign \
    --campaignId 'nx0s5TzT' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetCampaign'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 UpdateCampaign
# body param: body
echo '{"description": "51oV4HTm", "items": [{"extraSubscriptionDays": 17, "itemId": "vmb6tPmC", "itemName": "irkhYvcO", "quantity": 92}], "maxRedeemCountPerCampaignPerUser": 40, "maxRedeemCountPerCode": 5, "maxRedeemCountPerCodePerUser": 19, "maxSaleCount": 83, "name": "WGwPsvjL", "redeemEnd": "1989-08-16T00:00:00Z", "redeemStart": "1975-12-01T00:00:00Z", "redeemType": "ITEM", "status": "INACTIVE", "tags": ["tbMkpUFH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCampaign \
    --campaignId 'T0fL9q9S' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCampaign'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 GetCampaignDynamic
$CLI_EXE \
    --sn platform \
    --op GetCampaignDynamic \
    --campaignId 'MNAUQVoi' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetCampaignDynamic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetRootCategories
$CLI_EXE \
    --sn platform \
    --op GetRootCategories \
    --namespace $TEST_NAMESPACE \
    --storeId 'QtSQC2kN' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRootCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 CreateCategory
# body param: body
echo '{"categoryPath": "SsmT0d2a", "localizationDisplayNames": {"BG4zA2zp": "1Ls0bD6d"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCategory \
    --namespace $TEST_NAMESPACE \
    --storeId 'GgwkYgHz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 ListCategoriesBasic
$CLI_EXE \
    --sn platform \
    --op ListCategoriesBasic \
    --namespace $TEST_NAMESPACE \
    --storeId 'KuI2RJrb' \
    >$TEMP_FILE 2>&1
update_status $? 'ListCategoriesBasic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 GetCategory
$CLI_EXE \
    --sn platform \
    --op GetCategory \
    --categoryPath 'oP7kfpIl' \
    --namespace $TEST_NAMESPACE \
    --storeId 'etXrCK1U' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 UpdateCategory
# body param: body
echo '{"localizationDisplayNames": {"VO0jcs7n": "CqsodoTF"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCategory \
    --categoryPath 'TcWlaIBJ' \
    --namespace $TEST_NAMESPACE \
    --storeId 'AAknU6Ho' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 DeleteCategory
$CLI_EXE \
    --sn platform \
    --op DeleteCategory \
    --categoryPath 'bZgWlaLn' \
    --namespace $TEST_NAMESPACE \
    --storeId 'edDfasTc' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 GetChildCategories
$CLI_EXE \
    --sn platform \
    --op GetChildCategories \
    --categoryPath '8gr2znWq' \
    --namespace $TEST_NAMESPACE \
    --storeId 'D6tIcfI5' \
    >$TEMP_FILE 2>&1
update_status $? 'GetChildCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 GetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op GetDescendantCategories \
    --categoryPath 'Z4tUNQ7m' \
    --namespace $TEST_NAMESPACE \
    --storeId 'QPjCalZg' \
    >$TEMP_FILE 2>&1
update_status $? 'GetDescendantCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 QueryCodes
$CLI_EXE \
    --sn platform \
    --op QueryCodes \
    --campaignId 'FVEQyqav' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --batchNo '46' \
    --code 'CvMqVcXs' \
    --limit '81' \
    --offset '32' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryCodes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 CreateCodes
# body param: body
echo '{"quantity": 79}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCodes \
    --campaignId 'z8ZLBsnc' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateCodes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 Download
$CLI_EXE \
    --sn platform \
    --op Download \
    --campaignId 'bRrf6uEd' \
    --namespace $TEST_NAMESPACE \
    --batchNo '19' \
    >$TEMP_FILE 2>&1
update_status $? 'Download'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 BulkDisableCodes
$CLI_EXE \
    --sn platform \
    --op BulkDisableCodes \
    --campaignId 'Unr04WZN' \
    --namespace $TEST_NAMESPACE \
    --batchNo '14' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkDisableCodes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 BulkEnableCodes
$CLI_EXE \
    --sn platform \
    --op BulkEnableCodes \
    --campaignId 'gEGvqKWQ' \
    --namespace $TEST_NAMESPACE \
    --batchNo '90' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkEnableCodes'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 QueryRedeemHistory
$CLI_EXE \
    --sn platform \
    --op QueryRedeemHistory \
    --campaignId 'kE65j618' \
    --namespace $TEST_NAMESPACE \
    --code '6p0WfsnW' \
    --limit '40' \
    --offset '92' \
    --userId 'PsaRnVdr' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRedeemHistory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GetCode
$CLI_EXE \
    --sn platform \
    --op GetCode \
    --code 'dBA2hXwY' \
    --namespace $TEST_NAMESPACE \
    --redeemable 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 DisableCode
$CLI_EXE \
    --sn platform \
    --op DisableCode \
    --code 'zZMdlR4c' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DisableCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 EnableCode
$CLI_EXE \
    --sn platform \
    --op EnableCode \
    --code 'L76hnFDg' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'EnableCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 ListCurrencies
$CLI_EXE \
    --sn platform \
    --op ListCurrencies \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ListCurrencies'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 CreateCurrency
# body param: body
echo '{"currencyCode": "TfofHdfo", "currencySymbol": "SqDcaFhO", "currencyType": "REAL", "decimals": 29, "localizationDescriptions": {"KxI8f5oc": "fy4EIxwB"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateCurrency \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateCurrency'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 UpdateCurrency
# body param: body
echo '{"localizationDescriptions": {"iB90vdgS": "5YpKsdbp"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCurrency \
    --currencyCode 'iU2UfyMO' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCurrency'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 DeleteCurrency
$CLI_EXE \
    --sn platform \
    --op DeleteCurrency \
    --currencyCode '4DhL9fBK' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteCurrency'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 GetCurrencyConfig
$CLI_EXE \
    --sn platform \
    --op GetCurrencyConfig \
    --currencyCode 'JvjBOUn3' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrencyConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 GetCurrencySummary
$CLI_EXE \
    --sn platform \
    --op GetCurrencySummary \
    --currencyCode 'bYf5ouXq' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetCurrencySummary'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 GetDLCItemConfig
$CLI_EXE \
    --sn platform \
    --op GetDLCItemConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetDLCItemConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 UpdateDLCItemConfig
# body param: body
echo '{"data": [{"id": "kbiExqT6", "rewards": [{"currency": {"currencyCode": "Dk9QFqaA", "namespace": "jhwOI1P0"}, "item": {"itemId": "4dMHfTwr", "itemSku": "xBRfMxZr", "itemType": "Sfx3V8OX"}, "quantity": 20, "type": "ITEM"}]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateDLCItemConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateDLCItemConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 DeleteDLCItemConfig
$CLI_EXE \
    --sn platform \
    --op DeleteDLCItemConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteDLCItemConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 GetPlatformDLCConfig
$CLI_EXE \
    --sn platform \
    --op GetPlatformDLCConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPlatformDLCConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 UpdatePlatformDLCConfig
# body param: body
echo '{"data": [{"platform": "PSN", "platformDlcIdMap": {"7p2SyFDE": "nmYQzehP"}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePlatformDLCConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePlatformDLCConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 DeletePlatformDLCConfig
$CLI_EXE \
    --sn platform \
    --op DeletePlatformDLCConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePlatformDLCConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 QueryEntitlements
$CLI_EXE \
    --sn platform \
    --op QueryEntitlements \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --appType 'GAME' \
    --entitlementClazz 'MEDIA' \
    --entitlementName '12DvvzNN' \
    --itemId '["ZSu5zZVg"]' \
    --limit '100' \
    --offset '28' \
    --userId 'sfd01vaO' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 GetEntitlement
$CLI_EXE \
    --sn platform \
    --op GetEntitlement \
    --entitlementId 'GweHacvH' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 QueryFulfillmentHistories
$CLI_EXE \
    --sn platform \
    --op QueryFulfillmentHistories \
    --namespace $TEST_NAMESPACE \
    --limit '87' \
    --offset '94' \
    --status 'SUCCESS' \
    --userId 'B8hos4ya' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryFulfillmentHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 GetAppleIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetAppleIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAppleIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 UpdateAppleIAPConfig
# body param: body
echo '{"bundleId": "OBjMxizC", "password": "xx9qTOIK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAppleIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateAppleIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 DeleteAppleIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteAppleIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteAppleIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 GetEpicGamesIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetEpicGamesIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetEpicGamesIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 UpdateEpicGamesIAPConfig
# body param: body
echo '{"sandboxId": "lpdrqo2s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateEpicGamesIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateEpicGamesIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 DeleteEpicGamesIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteEpicGamesIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteEpicGamesIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 GetGoogleIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetGoogleIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetGoogleIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 UpdateGoogleIAPConfig
# body param: body
echo '{"applicationName": "mD9RPpjO", "serviceAccountId": "WK0k76i1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateGoogleIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGoogleIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 DeleteGoogleIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteGoogleIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteGoogleIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 UpdateGoogleP12File
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateGoogleP12File \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateGoogleP12File'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 GetIAPItemConfig
$CLI_EXE \
    --sn platform \
    --op GetIAPItemConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetIAPItemConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 UpdateIAPItemConfig
# body param: body
echo '{"data": [{"itemIdentity": "g7rYaEuN", "platformProductIdMap": {"CyPoQ0oH": "YXUQdtIk"}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateIAPItemConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateIAPItemConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 DeleteIAPItemConfig
$CLI_EXE \
    --sn platform \
    --op DeleteIAPItemConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteIAPItemConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 GetPlayStationIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetPlayStationIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPlayStationIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 58 UpdatePlaystationIAPConfig
# body param: body
echo '{"environment": "Akltd1zQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePlaystationIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePlaystationIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 59 DeletePlaystationIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeletePlaystationIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePlaystationIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 60 GetStadiaIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetStadiaIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetStadiaIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 DeleteStadiaIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteStadiaIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteStadiaIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 UpdateStadiaJsonConfigFile
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateStadiaJsonConfigFile \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateStadiaJsonConfigFile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 GetSteamIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetSteamIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetSteamIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 UpdateSteamIAPConfig
# body param: body
echo '{"publisherAuthenticationKey": "BzzC6ldK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateSteamIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSteamIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 65 DeleteSteamIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteSteamIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSteamIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 GetXblIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetXblIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetXblIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 67 UpdateXblIAPConfig
# body param: body
echo '{"relyingPartyCert": "riI6lTRb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXblIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXblIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 DeleteXblAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteXblAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteXblAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 69 UpdateXblBPCertFile
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateXblBPCertFile \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --password 'c1Z1HJHz' \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXblBPCertFile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 70 SyncInGameItem
# body param: body
echo '{"categoryPath": "l323Ynwf", "targetItemId": "5PvGejCD", "targetNamespace": "gAr1pXDc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncInGameItem \
    --namespace $TEST_NAMESPACE \
    --storeId 'sHnobnaY' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncInGameItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 71 CreateItem
# body param: body
echo '{"appId": "xGh3FovB", "appType": "SOFTWARE", "baseAppId": "r5VUOHGq", "boothName": "EcuJYo3Y", "categoryPath": "fMDw4PaB", "clazz": "KsFXorxY", "displayOrder": 0, "entitlementType": "DURABLE", "ext": {"G5AgHrE9": {}}, "features": ["8qQTSXh1"], "images": [{"as": "W7MnK2i8", "caption": "Ely255aw", "height": 43, "imageUrl": "ulbNGSAj", "smallImageUrl": "eiiANETl", "width": 21}], "itemIds": ["ncKPmri3"], "itemQty": {"6MY2aVCN": 93}, "itemType": "COINS", "listable": false, "localizations": {"pAYbj0fi": {"description": "dlWPSAIj", "localExt": {"aw5HSyDs": {}}, "longDescription": "QqMUPrAx", "title": "Ud1bmVSM"}}, "maxCount": 37, "maxCountPerUser": 5, "name": "gNAZf7a3", "purchasable": true, "recurring": {"cycle": "YEARLY", "fixedFreeDays": 58, "fixedTrialCycles": 99, "graceDays": 11}, "regionData": {"ahMp688J": [{"currencyCode": "v5wQ3hbD", "currencyNamespace": "lcGRx2aE", "currencyType": "VIRTUAL", "discountAmount": 25, "discountExpireAt": "1994-01-05T00:00:00Z", "discountPercentage": 99, "discountPurchaseAt": "1985-04-20T00:00:00Z", "discountedPrice": 25, "expireAt": "1995-07-14T00:00:00Z", "price": 34, "purchaseAt": "1986-01-23T00:00:00Z", "trialPrice": 77}]}, "seasonType": "TIER", "sku": "SdUypOvo", "stackable": true, "status": "ACTIVE", "tags": ["RBRxFsCU"], "targetCurrencyCode": "Qz0koUsU", "targetNamespace": "cGfjtfyu", "thumbnailUrl": "PNb5exiR", "useCount": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateItem \
    --namespace $TEST_NAMESPACE \
    --storeId 'R1Qe0mxL' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 72 GetItemByAppId
$CLI_EXE \
    --sn platform \
    --op GetItemByAppId \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --storeId 'vZEG2biy' \
    --appId 'KS8vfIsZ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 QueryItems
$CLI_EXE \
    --sn platform \
    --op QueryItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --appType 'SOFTWARE' \
    --availableDate 'DM0xJp6H' \
    --baseAppId 'XexnHAXY' \
    --categoryPath 'ShIg82ff' \
    --features 'zx6WCUdw' \
    --itemType 'COINS' \
    --limit '16' \
    --offset '42' \
    --region 'M1tfIoSs' \
    --sortBy 'KaP5KNn0' \
    --storeId 'UGr95D9V' \
    --tags 'atfxBoak' \
    --targetNamespace 'HUqz2uOK' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 ListBasicItemsByFeatures
$CLI_EXE \
    --sn platform \
    --op ListBasicItemsByFeatures \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --features '["X7j5MgRZ"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ListBasicItemsByFeatures'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 75 GetItemBySku
$CLI_EXE \
    --sn platform \
    --op GetItemBySku \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --storeId 'PmSrNaFz' \
    --sku 'JwBceJQ0' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 76 GetLocaleItemBySku
$CLI_EXE \
    --sn platform \
    --op GetLocaleItemBySku \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --language 'iEYQy4Jx' \
    --populateBundle 'True' \
    --region 'kyXfgwzM' \
    --storeId 'TAlT2q2E' \
    --sku 'bG4Z95Sl' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLocaleItemBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 77 GetItemIdBySku
$CLI_EXE \
    --sn platform \
    --op GetItemIdBySku \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --storeId 'yWe2X8cL' \
    --sku 'es0TRTAe' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemIdBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 78 BulkGetLocaleItems
$CLI_EXE \
    --sn platform \
    --op BulkGetLocaleItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --language 'rfR30IRA' \
    --region '6CzcXFcj' \
    --storeId 'Rpu7wVEz' \
    --itemIds 'bwHvOGqw' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkGetLocaleItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 79 SearchItems
$CLI_EXE \
    --sn platform \
    --op SearchItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --limit '63' \
    --offset '52' \
    --storeId 'I8lxDoRt' \
    --keyword 'wKNHCncW' \
    --language 'RyVDPNRF' \
    >$TEMP_FILE 2>&1
update_status $? 'SearchItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 80 QueryUncategorizedItems
$CLI_EXE \
    --sn platform \
    --op QueryUncategorizedItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --limit '81' \
    --offset '69' \
    --sortBy 'i021vVF2' \
    --storeId '6yEKnKL2' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUncategorizedItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 81 GetItem
$CLI_EXE \
    --sn platform \
    --op GetItem \
    --itemId '6vTDvjjj' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --storeId 'EPjDWSwW' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 82 UpdateItem
# body param: body
echo '{"appId": "548hHTuJ", "appType": "SOFTWARE", "baseAppId": "V4EKppV4", "boothName": "DfTxfj3A", "categoryPath": "GrDhoJoo", "clazz": "H5WNF4d6", "displayOrder": 58, "entitlementType": "CONSUMABLE", "ext": {"LnHRwigr": {}}, "features": ["039B7fw1"], "images": [{"as": "zHG7KQTr", "caption": "QeIv8R1C", "height": 38, "imageUrl": "NkXpuQ4g", "smallImageUrl": "9IiLxJpT", "width": 23}], "itemIds": ["IMuKCdAt"], "itemQty": {"0XTdLLO1": 97}, "itemType": "SUBSCRIPTION", "listable": false, "localizations": {"w7FI8mOS": {"description": "B2rvQkdn", "localExt": {"YlPH6J70": {}}, "longDescription": "BXWVtxOy", "title": "ZzUrVRKR"}}, "maxCount": 39, "maxCountPerUser": 71, "name": "uZ5W7nPr", "purchasable": true, "recurring": {"cycle": "WEEKLY", "fixedFreeDays": 22, "fixedTrialCycles": 72, "graceDays": 33}, "regionData": {"C31jYv88": [{"currencyCode": "32yIJUng", "currencyNamespace": "m7GSrElr", "currencyType": "REAL", "discountAmount": 12, "discountExpireAt": "1983-12-11T00:00:00Z", "discountPercentage": 48, "discountPurchaseAt": "1987-12-16T00:00:00Z", "discountedPrice": 25, "expireAt": "1977-11-20T00:00:00Z", "price": 43, "purchaseAt": "1981-08-28T00:00:00Z", "trialPrice": 62}]}, "seasonType": "TIER", "sku": "SQyIXv2y", "stackable": false, "status": "ACTIVE", "tags": ["5jsUlAif"], "targetCurrencyCode": "ni52mGYo", "targetNamespace": "0BjFUSZe", "thumbnailUrl": "Nr7PeZ5S", "useCount": 0}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateItem \
    --itemId 'Ua0UxaP0' \
    --namespace $TEST_NAMESPACE \
    --storeId 'Kwv68Osq' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 83 DeleteItem
$CLI_EXE \
    --sn platform \
    --op DeleteItem \
    --itemId 'OUTPXzel' \
    --namespace $TEST_NAMESPACE \
    --storeId 'ychmgjLv' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 84 AcquireItem
# body param: body
echo '{"count": 26, "orderNo": "OWOk5Aek"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireItem \
    --itemId 'VVmTIEG2' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AcquireItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 85 GetApp
$CLI_EXE \
    --sn platform \
    --op GetApp \
    --itemId 'ppf1fH3N' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --storeId 'fEQkdzI8' \
    >$TEMP_FILE 2>&1
update_status $? 'GetApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 86 UpdateApp
# body param: body
echo '{"carousel": [{"alt": "JQzAp0rF", "previewUrl": "8gvdnF1y", "thumbnailUrl": "MvoXLWNo", "type": "image", "url": "vPg7VX5r", "videoSource": "vimeo"}], "developer": "NWJaq1fj", "forumUrl": "gDypxO4u", "genres": ["Adventure"], "localizations": {"KfU7Oumx": {"announcement": "Sk0Ebju4", "slogan": "dSLx4vsb"}}, "platformRequirements": {"6rx9Xxsu": [{"additionals": "8TJHpdZV", "directXVersion": "C6y6b9fQ", "diskSpace": "pa7b36my", "graphics": "8LWzMOfn", "label": "jwsIxM4s", "osVersion": "9m2qWNvm", "processor": "PPlRULr7", "ram": "pPFCzbPX", "soundCard": "1wwBznD7"}]}, "platforms": ["Android"], "players": ["Coop"], "primaryGenre": "Indie", "publisher": "7fb4sqWU", "releaseDate": "1978-08-07T00:00:00Z", "websiteUrl": "4t2ieA8X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateApp \
    --itemId 'RPhVzkts' \
    --namespace $TEST_NAMESPACE \
    --storeId 'WibnpBKX' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 87 DisableItem
$CLI_EXE \
    --sn platform \
    --op DisableItem \
    --itemId 'MWuoFv0q' \
    --namespace $TEST_NAMESPACE \
    --storeId 'jBvBzZGO' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 88 GetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op GetItemDynamicData \
    --itemId 'hAwcbpyb' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemDynamicData'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 89 EnableItem
$CLI_EXE \
    --sn platform \
    --op EnableItem \
    --itemId 'Zn4ZE5Om' \
    --namespace $TEST_NAMESPACE \
    --storeId 'bNkHnefZ' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 90 FeatureItem
$CLI_EXE \
    --sn platform \
    --op FeatureItem \
    --feature 'WDwi6anY' \
    --itemId 'nQ92kVBD' \
    --namespace $TEST_NAMESPACE \
    --storeId 'kaMy03Bu' \
    >$TEMP_FILE 2>&1
update_status $? 'FeatureItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 91 DefeatureItem
$CLI_EXE \
    --sn platform \
    --op DefeatureItem \
    --feature 'l4GW3V0W' \
    --itemId 'CbxvTGyc' \
    --namespace $TEST_NAMESPACE \
    --storeId 'cHSkFQzg' \
    >$TEMP_FILE 2>&1
update_status $? 'DefeatureItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 92 GetLocaleItem
$CLI_EXE \
    --sn platform \
    --op GetLocaleItem \
    --itemId 'VR72Dhxb' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --language '4HtKMGr8' \
    --populateBundle 'True' \
    --region 'nOEeip50' \
    --storeId '5iJTzZuk' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLocaleItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 93 ReturnItem
# body param: body
echo '{"orderNo": "sb4hREcO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ReturnItem \
    --itemId 'x3mATUsO' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ReturnItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 94 QueryKeyGroups
$CLI_EXE \
    --sn platform \
    --op QueryKeyGroups \
    --namespace $TEST_NAMESPACE \
    --limit '89' \
    --name '0e5Tmapk' \
    --offset '17' \
    --tag 'mopclvfm' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryKeyGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 95 CreateKeyGroup
# body param: body
echo '{"description": "7fdu7isK", "name": "aWRcvkLt", "status": "ACTIVE", "tags": ["mGySrACK"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateKeyGroup \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateKeyGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 96 GetKeyGroup
$CLI_EXE \
    --sn platform \
    --op GetKeyGroup \
    --keyGroupId 'a0mWWkDR' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetKeyGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 97 UpdateKeyGroup
# body param: body
echo '{"description": "cuLbIpVJ", "name": "nIAFpX2S", "status": "ACTIVE", "tags": ["ncDRknJo"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateKeyGroup \
    --keyGroupId 'rtwVqipg' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateKeyGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 98 GetKeyGroupDynamic
$CLI_EXE \
    --sn platform \
    --op GetKeyGroupDynamic \
    --keyGroupId 'pXVyWoDj' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetKeyGroupDynamic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 99 ListKeys
$CLI_EXE \
    --sn platform \
    --op ListKeys \
    --keyGroupId 'OHrGczaX' \
    --namespace $TEST_NAMESPACE \
    --limit '97' \
    --offset '16' \
    --status 'ACQUIRED' \
    >$TEMP_FILE 2>&1
update_status $? 'ListKeys'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 100 UploadKeys
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UploadKeys \
    --keyGroupId 'cAHtRkBJ' \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UploadKeys'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 101 QueryOrders
$CLI_EXE \
    --sn platform \
    --op QueryOrders \
    --namespace $TEST_NAMESPACE \
    --endTime 'XZwQ443F' \
    --limit '11' \
    --offset '96' \
    --orderNos '["tsTAAgtC"]' \
    --sortBy 'nvDp28TM' \
    --startTime 'vlTcBalj' \
    --status 'CHARGED' \
    --withTotal 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 102 GetOrderStatistics
$CLI_EXE \
    --sn platform \
    --op GetOrderStatistics \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetOrderStatistics'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 103 GetOrder
$CLI_EXE \
    --sn platform \
    --op GetOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'B4LS44hW' \
    >$TEMP_FILE 2>&1
update_status $? 'GetOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 104 RefundOrder
# body param: body
echo '{"description": "ONXuXihq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'BVEXSyrZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 105 GetPaymentCallbackConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentCallbackConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentCallbackConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 106 UpdatePaymentCallbackConfig
# body param: body
echo '{"dryRun": true, "notifyUrl": "vGa0Lshf", "privateKey": "P3LqrZcS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentCallbackConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePaymentCallbackConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 107 QueryPaymentNotifications
$CLI_EXE \
    --sn platform \
    --op QueryPaymentNotifications \
    --namespace $TEST_NAMESPACE \
    --endDate 'sGFDDAiS' \
    --externalId 'jXH3ypQa' \
    --limit '32' \
    --notificationSource 'XSOLLA' \
    --notificationType 'PMAjx7ed' \
    --offset '93' \
    --paymentOrderNo 'xN5KMSLs' \
    --startDate '21gdQU0F' \
    --status 'ERROR' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentNotifications'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 108 QueryPaymentOrders
$CLI_EXE \
    --sn platform \
    --op QueryPaymentOrders \
    --namespace $TEST_NAMESPACE \
    --channel 'INTERNAL' \
    --extTxId 'QYQaHZ7W' \
    --limit '38' \
    --offset '52' \
    --status 'DELETED' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 109 CreatePaymentOrderByDedicated
# body param: body
echo '{"currencyCode": "pJtfB0Xt", "currencyNamespace": "8Zcpuz7B", "customParameters": {"Y3JPVnMt": {}}, "description": "1HRDFxkS", "extOrderNo": "aTdINJTd", "extUserId": "RQmMvxBj", "itemType": "BUNDLE", "language": "VFnEgsov", "metadata": {"Zbx4UF3p": "YMzeFcsB"}, "notifyUrl": "LCwhTStB", "omitNotification": false, "price": 68, "recurringPaymentOrderNo": "SL9Sco6H", "region": "xX79bWJC", "returnUrl": "lH3pXWCq", "sandbox": true, "sku": "sdpW3XyQ", "subscriptionId": "QmftmA5H", "targetNamespace": "UHioxzVh", "targetUserId": "zHc1rBqA", "title": "Xud4JQOW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreatePaymentOrderByDedicated \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePaymentOrderByDedicated'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 110 ListExtOrderNoByExtTxId
$CLI_EXE \
    --sn platform \
    --op ListExtOrderNoByExtTxId \
    --namespace $TEST_NAMESPACE \
    --extTxId 'ZBzUvNkx' \
    >$TEMP_FILE 2>&1
update_status $? 'ListExtOrderNoByExtTxId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 111 GetPaymentOrder
$CLI_EXE \
    --sn platform \
    --op GetPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'TUqI2Xhb' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 112 ChargePaymentOrder
# body param: body
echo '{"extTxId": "YwTxVSXp", "paymentMethod": "Jb2JSuHH", "paymentProvider": "PAYPAL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ChargePaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'RP9xW9Ve' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ChargePaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 113 RefundPaymentOrderByDedicated
# body param: body
echo '{"description": "YJCDikIa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundPaymentOrderByDedicated \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'pumYwbaG' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundPaymentOrderByDedicated'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 114 SimulatePaymentOrderNotification
# body param: body
echo '{"amount": 11, "currencyCode": "sJTgobWG", "notifyType": "CHARGE", "paymentProvider": "PAYPAL", "salesTax": 64, "vat": 42}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SimulatePaymentOrderNotification \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'ohrdRx6l' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SimulatePaymentOrderNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 115 GetPaymentOrderChargeStatus
$CLI_EXE \
    --sn platform \
    --op GetPaymentOrderChargeStatus \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'Vi7UcTmE' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentOrderChargeStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 116 CreateReward
# body param: body
echo '{"description": "we9mWH3X", "eventTopic": "VfyejgTi", "maxAwarded": 60, "maxAwardedPerUser": 95, "rewardCode": "nFsoXaRE", "rewardConditions": [{"condition": "a1WpsZ5P", "conditionName": "oXUApZEP", "eventName": "fic39c2q", "rewardItems": [{"duration": 1, "itemId": "6kRuGqHc", "quantity": 45}]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateReward \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 117 QueryRewards
$CLI_EXE \
    --sn platform \
    --op QueryRewards \
    --namespace $TEST_NAMESPACE \
    --eventTopic 'ZVjAQCkW' \
    --limit '19' \
    --offset '60' \
    --sortBy '3gJ6AwW9' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 118 ExportRewards
$CLI_EXE \
    --sn platform \
    --op ExportRewards \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 119 ImportRewards
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op ImportRewards \
    --namespace $TEST_NAMESPACE \
    --replaceExisting 'False' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ImportRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 120 GetReward
$CLI_EXE \
    --sn platform \
    --op GetReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'FHpDCFut' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 121 UpdateReward
# body param: body
echo '{"description": "39Jhj3lm", "eventTopic": "fXJxKJNR", "maxAwarded": 59, "maxAwardedPerUser": 73, "rewardCode": "umRjk3wZ", "rewardConditions": [{"condition": "YVb3SFss", "conditionName": "nx4JYy1k", "eventName": "XakVQoG0", "rewardItems": [{"duration": 40, "itemId": "psR2PZ0E", "quantity": 28}]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'WaCZcCX2' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 122 DeleteReward
$CLI_EXE \
    --sn platform \
    --op DeleteReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'iLiQGTL6' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 123 CheckEventCondition
# body param: body
echo '{"payload": {"OYjLlXUV": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CheckEventCondition \
    --namespace $TEST_NAMESPACE \
    --rewardId '78i8csQI' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CheckEventCondition'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 124 ListStores
$CLI_EXE \
    --sn platform \
    --op ListStores \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ListStores'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 125 CreateStore
# body param: body
echo '{"defaultLanguage": "O0DRagPX", "defaultRegion": "zsBfUhCo", "description": "GFgirdML", "supportedLanguages": ["exA5zJvQ"], "supportedRegions": ["d2cOVXFo"], "title": "iaYaSoog"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateStore \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 126 ImportStore
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op ImportStore \
    --namespace $TEST_NAMESPACE \
    --storeId '7pSsQhvX' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ImportStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 127 GetPublishedStore
$CLI_EXE \
    --sn platform \
    --op GetPublishedStore \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublishedStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 128 DeletePublishedStore
$CLI_EXE \
    --sn platform \
    --op DeletePublishedStore \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePublishedStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 129 GetPublishedStoreBackup
$CLI_EXE \
    --sn platform \
    --op GetPublishedStoreBackup \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublishedStoreBackup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 130 RollbackPublishedStore
$CLI_EXE \
    --sn platform \
    --op RollbackPublishedStore \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RollbackPublishedStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 131 GetStore
$CLI_EXE \
    --sn platform \
    --op GetStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'bGvqRVSS' \
    >$TEMP_FILE 2>&1
update_status $? 'GetStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 132 UpdateStore
# body param: body
echo '{"defaultLanguage": "wvlRzdNX", "defaultRegion": "rfoKVR4H", "description": "hlPEfSM2", "supportedLanguages": ["K29oqfZs"], "supportedRegions": ["sibgoTFQ"], "title": "AmIZiTSs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'tC2yOumz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 133 DeleteStore
$CLI_EXE \
    --sn platform \
    --op DeleteStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'HMhXysws' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 134 CloneStore
$CLI_EXE \
    --sn platform \
    --op CloneStore \
    --namespace $TEST_NAMESPACE \
    --storeId '3Fwnu7OX' \
    --targetStoreId '9FZvwJ8O' \
    >$TEMP_FILE 2>&1
update_status $? 'CloneStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 ExportStore
$CLI_EXE \
    --sn platform \
    --op ExportStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'QFuCH68p' \
    >$TEMP_FILE 2>&1
update_status $? 'ExportStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 136 QuerySubscriptions
$CLI_EXE \
    --sn platform \
    --op QuerySubscriptions \
    --namespace $TEST_NAMESPACE \
    --chargeStatus 'CHARGE_FAILED' \
    --itemId 'T632j8Qf' \
    --limit '15' \
    --offset '78' \
    --sku 'DTHb8lFv' \
    --status 'INIT' \
    --subscribedBy 'PLATFORM' \
    --userId 'lf9Pdi5B' \
    >$TEMP_FILE 2>&1
update_status $? 'QuerySubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 137 RecurringChargeSubscription
$CLI_EXE \
    --sn platform \
    --op RecurringChargeSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'LCsT8g72' \
    >$TEMP_FILE 2>&1
update_status $? 'RecurringChargeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 138 GetTicketDynamic
$CLI_EXE \
    --sn platform \
    --op GetTicketDynamic \
    --boothName 'thhduZnN' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTicketDynamic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 139 DecreaseTicketSale
# body param: body
echo '{"orderNo": "j9cRNlTB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DecreaseTicketSale \
    --boothName 'xl3nKj6B' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DecreaseTicketSale'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 140 GetTicketBoothID
$CLI_EXE \
    --sn platform \
    --op GetTicketBoothID \
    --boothName '4ffgtxiP' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTicketBoothID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 141 IncreaseTicketSale
# body param: body
echo '{"count": 75, "orderNo": "dV0odbfa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op IncreaseTicketSale \
    --boothName 'st4NDIBQ' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'IncreaseTicketSale'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 142 AnonymizeCampaign
$CLI_EXE \
    --sn platform \
    --op AnonymizeCampaign \
    --namespace $TEST_NAMESPACE \
    --userId 'l3UryryO' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeCampaign'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 143 AnonymizeEntitlement
$CLI_EXE \
    --sn platform \
    --op AnonymizeEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'WzhhEmSV' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 144 AnonymizeFulfillment
$CLI_EXE \
    --sn platform \
    --op AnonymizeFulfillment \
    --namespace $TEST_NAMESPACE \
    --userId 'FhAlEacA' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeFulfillment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 145 AnonymizeIntegration
$CLI_EXE \
    --sn platform \
    --op AnonymizeIntegration \
    --namespace $TEST_NAMESPACE \
    --userId 'AoAfsuMB' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeIntegration'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 146 AnonymizeOrder
$CLI_EXE \
    --sn platform \
    --op AnonymizeOrder \
    --namespace $TEST_NAMESPACE \
    --userId '4W3HIcvS' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 147 AnonymizePayment
$CLI_EXE \
    --sn platform \
    --op AnonymizePayment \
    --namespace $TEST_NAMESPACE \
    --userId '0AL4tYCw' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizePayment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 148 AnonymizeSubscription
$CLI_EXE \
    --sn platform \
    --op AnonymizeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'CdCigcxl' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 149 AnonymizeWallet
$CLI_EXE \
    --sn platform \
    --op AnonymizeWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'bl30hHHE' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 150 QueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlements \
    --namespace $TEST_NAMESPACE \
    --userId 'jMI4Lcgk' \
    --activeOnly 'True' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'ENTITLEMENT' \
    --entitlementName 'ccFdvzoa' \
    --itemId '["fMLoraVj"]' \
    --limit '87' \
    --offset '16' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 151 GrantUserEntitlement
# body param: body
echo '[{"endDate": "1985-09-25T00:00:00Z", "grantedCode": "vo7KepgB", "itemId": "TMRiEdee", "itemNamespace": "QwLUW0VL", "language": "upH83Aux", "quantity": 63, "region": "EFRDTt2m", "source": "PURCHASE", "startDate": "1981-07-11T00:00:00Z", "storeId": "waKEsPBA"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantUserEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'M1aujNql' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 152 GetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'mpKGhvTK' \
    --activeOnly 'False' \
    --appId 'XeZepm7t' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserAppEntitlementByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 153 QueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlementsByAppType \
    --namespace $TEST_NAMESPACE \
    --userId 'F1wKhQ4H' \
    --activeOnly 'False' \
    --limit '60' \
    --offset '4' \
    --appType 'DEMO' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserEntitlementsByAppType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 154 GetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'gyjZITRu' \
    --activeOnly 'False' \
    --entitlementClazz 'CODE' \
    --itemId 'ICoCN3Ny' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 155 GetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'zAV4niQQ' \
    --activeOnly 'False' \
    --entitlementClazz 'APP' \
    --sku 'DJE12W5e' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 156 ExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'oplrOXwA' \
    --appIds '["SJ1PtQux"]' \
    --itemIds '["OJQKgor2"]' \
    --skus '["UMJt4EJ9"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ExistsAnyUserActiveEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 157 ExistsAnyUserActiveEntitlementByItemIds
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlementByItemIds \
    --namespace $TEST_NAMESPACE \
    --userId 'GccYTYxP' \
    --itemIds '["TgpBNsUv"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ExistsAnyUserActiveEntitlementByItemIds'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 158 GetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementOwnershipByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'UKhANjqu' \
    --appId 'BEHOJbaQ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserAppEntitlementOwnershipByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 159 GetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'pz0dfiuv' \
    --entitlementClazz 'CODE' \
    --itemId 'kPCaZsjv' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementOwnershipByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 160 GetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'FvhZdwi1' \
    --entitlementClazz 'CODE' \
    --sku '6V2uWuCs' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 161 RevokeUserEntitlements
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlements \
    --namespace $TEST_NAMESPACE \
    --userId 'B8FbVDwh' \
    --entitlementIds 'pNCLl2bg' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 162 GetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlement \
    --entitlementId 'Ic1y49bq' \
    --namespace $TEST_NAMESPACE \
    --userId 'pbfyytwm' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 163 UpdateUserEntitlement
# body param: body
echo '{"endDate": "1975-12-08T00:00:00Z", "nullFieldList": ["JpfOIKCe"], "startDate": "1974-03-17T00:00:00Z", "status": "INACTIVE", "useCount": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserEntitlement \
    --entitlementId 'yn3bGyFG' \
    --namespace $TEST_NAMESPACE \
    --userId 'wcAylTi4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 164 ConsumeUserEntitlement
# body param: body
echo '{"useCount": 32}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ConsumeUserEntitlement \
    --entitlementId 'PF190sf2' \
    --namespace $TEST_NAMESPACE \
    --userId 'ZwPi5hI4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ConsumeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 165 DisableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op DisableUserEntitlement \
    --entitlementId 'k3KwV7P8' \
    --namespace $TEST_NAMESPACE \
    --userId 'R9t4dBRp' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 EnableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op EnableUserEntitlement \
    --entitlementId 'Bp4noj3J' \
    --namespace $TEST_NAMESPACE \
    --userId '79DD3bAZ' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 GetUserEntitlementHistories
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementHistories \
    --entitlementId 'F4nYBuNx' \
    --namespace $TEST_NAMESPACE \
    --userId 'ISmVGVz9' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 168 RevokeUserEntitlement
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlement \
    --entitlementId 'Jxj8wegr' \
    --namespace $TEST_NAMESPACE \
    --userId 'Do6OmeKL' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 FulfillItem
# body param: body
echo '{"duration": 64, "endDate": "1991-04-25T00:00:00Z", "itemId": "I9uWOFTW", "itemSku": "dRrL6yNm", "language": "v8k1w19J", "order": {"currency": {"currencyCode": "sHSqOByh", "currencySymbol": "4hhkcO6J", "currencyType": "REAL", "decimals": 88, "namespace": "vYd4J5c6"}, "ext": {"ayFnSrfm": {}}, "free": false}, "orderNo": "FTUBRRDG", "quantity": 56, "region": "RQtMc3an", "source": "ACHIEVEMENT", "startDate": "1982-10-27T00:00:00Z", "storeId": "wXHS1oUz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillItem \
    --namespace $TEST_NAMESPACE \
    --userId 'DdDcZ0Rj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 RedeemCode
# body param: body
echo '{"code": "3YM1fz9C", "language": "jqtqeiyD", "region": "CK7C3u5G"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RedeemCode \
    --namespace $TEST_NAMESPACE \
    --userId 'cPbmi5Ki' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RedeemCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 171 FulfillRewards
# body param: body
echo '{"rewards": [{"currency": {"currencyCode": "FDVpfvR2", "namespace": "Wl0iShag"}, "item": {"itemId": "pvFuZu45", "itemSku": "zsrSpvML", "itemType": "vQw3sPxF"}, "quantity": 40, "type": "CURRENCY"}], "source": "REWARD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillRewards \
    --namespace $TEST_NAMESPACE \
    --userId 'j6O7ivhN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 172 QueryUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserIAPOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'IjVT5HSR' \
    --endTime '00UKSLWW' \
    --limit '51' \
    --offset '80' \
    --productId 'plTLwZQZ' \
    --startTime 'UMaAJ6ZB' \
    --status 'VERIFIED' \
    --type 'STADIA' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserIAPOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 QueryAllUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryAllUserIAPOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'YjGbVtzs' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryAllUserIAPOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 174 MockFulfillIAPItem
# body param: body
echo '{"language": "BTCOWEna", "productId": "LzHuYKrr", "region": "89z0RkL9", "type": "EPICGAMES"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op MockFulfillIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId '2B7thDQ3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'MockFulfillIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 175 QueryUserOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'hfVnPK8i' \
    --itemId 'K8cdZPnX' \
    --limit '45' \
    --offset '64' \
    --status 'CHARGEBACK_REVERSED' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 176 CountOfPurchasedItem
$CLI_EXE \
    --sn platform \
    --op CountOfPurchasedItem \
    --namespace $TEST_NAMESPACE \
    --userId 'AlxtjeZU' \
    --itemId 'rqmIc7El' \
    >$TEMP_FILE 2>&1
update_status $? 'CountOfPurchasedItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 177 GetUserOrder
$CLI_EXE \
    --sn platform \
    --op GetUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo '44MEAvaP' \
    --userId 'TwwJrG06' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 178 UpdateUserOrderStatus
# body param: body
echo '{"status": "CLOSED", "statusReason": "tcF7t8DQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserOrderStatus \
    --namespace $TEST_NAMESPACE \
    --orderNo 'xcoQBTWM' \
    --userId 'c41xDmUj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserOrderStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 179 FulfillUserOrder
$CLI_EXE \
    --sn platform \
    --op FulfillUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'kXi2LgkA' \
    --userId 'LGxw6qgv' \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 180 GetUserOrderGrant
$CLI_EXE \
    --sn platform \
    --op GetUserOrderGrant \
    --namespace $TEST_NAMESPACE \
    --orderNo 'IJBe6rDG' \
    --userId 'bFNzsyQV' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrderGrant'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 GetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op GetUserOrderHistories \
    --namespace $TEST_NAMESPACE \
    --orderNo 'qvSgtpUV' \
    --userId 'ddL6A1cT' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrderHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 182 ProcessUserOrderNotification
# body param: body
echo '{"additionalData": {"cardSummary": "LmuKlGHZ"}, "authorisedTime": "1972-06-29T00:00:00Z", "chargebackReversedTime": "1982-04-21T00:00:00Z", "chargebackTime": "1987-12-06T00:00:00Z", "chargedTime": "1991-02-10T00:00:00Z", "createdTime": "1996-07-14T00:00:00Z", "currency": {"currencyCode": "tHev8RX4", "currencySymbol": "MWRFklN1", "currencyType": "VIRTUAL", "decimals": 87, "namespace": "VCnzRxni"}, "customParameters": {"0Kq9Zl2b": {}}, "extOrderNo": "7ChMCxb6", "extTxId": "xdzl2OYV", "extUserId": "RJNC7Eru", "issuedAt": "1994-09-26T00:00:00Z", "metadata": {"TunbxaOW": "NrMkfALU"}, "namespace": "DrR6M3vz", "nonceStr": "u84TNQYC", "paymentMethod": "ZIpKFvpQ", "paymentMethodFee": 81, "paymentOrderNo": "jjkIYAQE", "paymentProvider": "WALLET", "paymentProviderFee": 46, "paymentStationUrl": "GPTkn2NJ", "price": 12, "refundedTime": "1987-04-07T00:00:00Z", "salesTax": 55, "sandbox": true, "sku": "flV2VptG", "status": "DELETED", "statusReason": "AEziSthh", "subscriptionId": "R9WLiVTX", "subtotalPrice": 67, "targetNamespace": "hZmByxlm", "targetUserId": "WBLyhgZs", "tax": 70, "totalPrice": 28, "totalTax": 28, "txEndTime": "1977-11-06T00:00:00Z", "type": "pOQ9Jmh8", "userId": "wwQ28fmx", "vat": 77}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserOrderNotification \
    --namespace $TEST_NAMESPACE \
    --orderNo 'FN8d9fdH' \
    --userId 'AHphhby7' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ProcessUserOrderNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 183 DownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op DownloadUserOrderReceipt \
    --namespace $TEST_NAMESPACE \
    --orderNo 'hGbKeIkY' \
    --userId '4Fc8atJ3' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadUserOrderReceipt'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 184 CreateUserPaymentOrder
# body param: body
echo '{"currencyCode": "J4gbk9Yd", "currencyNamespace": "Em0o9Rjj", "customParameters": {"nkhwq75V": {}}, "description": "qZH8HUq9", "extOrderNo": "2UFWFC8o", "extUserId": "FuU2OFJ6", "itemType": "SUBSCRIPTION", "language": "1Hbioiia", "metadata": {"Z8Uc2rWp": "zX2mgoBh"}, "notifyUrl": "ruuvEzpy", "omitNotification": false, "price": 63, "recurringPaymentOrderNo": "s63b4Pru", "region": "2pWiVBYj", "returnUrl": "KI1ZlcKX", "sandbox": true, "sku": "XcPAsjW7", "subscriptionId": "zBxpVc8s", "title": "vjiFtRe8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateUserPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --userId 'k7amplfh' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 RefundUserPaymentOrder
# body param: body
echo '{"description": "uHropVxI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundUserPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'vBjsYUED' \
    --userId 'p1taP9py' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundUserPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 186 ApplyUserRedemption
# body param: body
echo '{"code": "4Fl6UoVx", "orderNo": "gHJLBm3b"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ApplyUserRedemption \
    --namespace $TEST_NAMESPACE \
    --userId 'gRvSUyOg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ApplyUserRedemption'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 QueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op QueryUserSubscriptions \
    --namespace $TEST_NAMESPACE \
    --userId 'yu9dhxao' \
    --chargeStatus 'CHARGED' \
    --itemId 'TjMYGTMX' \
    --limit '48' \
    --offset '49' \
    --sku 'pcIN4uUI' \
    --status 'INIT' \
    --subscribedBy 'USER' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserSubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 GetUserSubscriptionActivities
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionActivities \
    --namespace $TEST_NAMESPACE \
    --userId 'UI5b1wxS' \
    --excludeSystem 'True' \
    --limit '55' \
    --offset '90' \
    --subscriptionId 'D8uNeauL' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscriptionActivities'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 PlatformSubscribeSubscription
# body param: body
echo '{"grantDays": 9, "itemId": "XNgQBnXZ", "language": "kQ06LUEg", "reason": "yyiBeJAR", "region": "FVbUvLNt", "source": "DdAntKI6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PlatformSubscribeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'vd3QdSHH' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformSubscribeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 190 CheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op CheckUserSubscriptionSubscribableByItemId \
    --namespace $TEST_NAMESPACE \
    --userId '2AvosR9N' \
    --itemId 'k0JJYXMR' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckUserSubscriptionSubscribableByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 191 GetUserSubscription
$CLI_EXE \
    --sn platform \
    --op GetUserSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'cQg1Lwgz' \
    --userId 'WRu5q2i8' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 192 DeleteUserSubscription
$CLI_EXE \
    --sn platform \
    --op DeleteUserSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'ntDdFSOE' \
    --userId 'IqFse4oc' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 193 CancelSubscription
# body param: body
echo '{"immediate": true, "reason": "qjWTbUay"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CancelSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'IP8oO0z1' \
    --userId 'VffDHyFM' \
    --force 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CancelSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 194 GrantDaysToSubscription
# body param: body
echo '{"grantDays": 19, "reason": "bxDDxngE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantDaysToSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'qsAbWEfT' \
    --userId 'c2nSU2Si' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantDaysToSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 195 GetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionBillingHistories \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'jySpnqX0' \
    --userId '1uDkQ1tv' \
    --excludeFree 'False' \
    --limit '76' \
    --offset '77' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscriptionBillingHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 196 ProcessUserSubscriptionNotification
# body param: body
echo '{"additionalData": {"cardSummary": "W8aqVbwA"}, "authorisedTime": "1979-03-01T00:00:00Z", "chargebackReversedTime": "1987-12-22T00:00:00Z", "chargebackTime": "1971-09-13T00:00:00Z", "chargedTime": "1982-07-13T00:00:00Z", "createdTime": "1984-05-28T00:00:00Z", "currency": {"currencyCode": "PnfbHX5T", "currencySymbol": "pIV6e7dM", "currencyType": "REAL", "decimals": 53, "namespace": "r2VSmtP8"}, "customParameters": {"qxtNo76o": {}}, "extOrderNo": "PRuvxUGN", "extTxId": "JvDRuWXB", "extUserId": "zyWeusWd", "issuedAt": "1986-10-11T00:00:00Z", "metadata": {"nqhXgmVQ": "HoZNPy0W"}, "namespace": "qu4qtxTy", "nonceStr": "rvNhypNL", "paymentMethod": "porjcAKS", "paymentMethodFee": 40, "paymentOrderNo": "vgVjdXMn", "paymentProvider": "ADYEN", "paymentProviderFee": 41, "paymentStationUrl": "yP3WX3u1", "price": 81, "refundedTime": "1989-12-13T00:00:00Z", "salesTax": 93, "sandbox": true, "sku": "Z6vwIqGn", "status": "CHARGED", "statusReason": "qXXAZd7b", "subscriptionId": "vO6Xg2xx", "subtotalPrice": 42, "targetNamespace": "ZXC9YsEX", "targetUserId": "Ee9iC3Hp", "tax": 52, "totalPrice": 38, "totalTax": 97, "txEndTime": "1986-01-27T00:00:00Z", "type": "rEipXZfo", "userId": "cCS9nGM6", "vat": 11}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserSubscriptionNotification \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'YF1o77M1' \
    --userId 'VVgHHeL0' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ProcessUserSubscriptionNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 197 AcquireUserTicket
# body param: body
echo '{"count": 11, "orderNo": "lEPUxHPh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireUserTicket \
    --boothName 'E4YwCRBG' \
    --namespace $TEST_NAMESPACE \
    --userId 'AR8TtZlD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AcquireUserTicket'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 198 CheckWallet
$CLI_EXE \
    --sn platform \
    --op CheckWallet \
    --currencyCode 'IjOfYlF5' \
    --namespace $TEST_NAMESPACE \
    --userId 'jISj4wwq' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 CreditUserWallet
# body param: body
echo '{"amount": 74, "reason": "pFnnNydT", "source": "PURCHASE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreditUserWallet \
    --currencyCode 'POtfkEyL' \
    --namespace $TEST_NAMESPACE \
    --userId 'h6l74AQY' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreditUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 200 PayWithUserWallet
# body param: body
echo '{"amount": 40}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PayWithUserWallet \
    --currencyCode 'lxH0lioS' \
    --namespace $TEST_NAMESPACE \
    --userId 'oooPhQ9x' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PayWithUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 201 GetUserWallet
$CLI_EXE \
    --sn platform \
    --op GetUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'lLMe7ma8' \
    --walletId 'Qc9aGN5U' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 202 DebitUserWallet
# body param: body
echo '{"amount": 70, "reason": "PLchiivO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DebitUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'QdByk3mW' \
    --walletId 'Q93BxbP1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DebitUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 DisableUserWallet
$CLI_EXE \
    --sn platform \
    --op DisableUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'VP8rKuVw' \
    --walletId 'TTGSX5rG' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 204 EnableUserWallet
$CLI_EXE \
    --sn platform \
    --op EnableUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId '8ymO7ml7' \
    --walletId 'SCwM6RZN' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 ListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op ListUserWalletTransactions \
    --namespace $TEST_NAMESPACE \
    --userId 'erJQroYU' \
    --walletId 'kvHx2dAj' \
    --limit '63' \
    --offset '62' \
    >$TEMP_FILE 2>&1
update_status $? 'ListUserWalletTransactions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 206 QueryWallets
$CLI_EXE \
    --sn platform \
    --op QueryWallets \
    --namespace $TEST_NAMESPACE \
    --currencyCode '0BBGwZ7X' \
    --limit '97' \
    --offset '14' \
    --userId 'doYx127Y' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryWallets'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 207 GetWallet
$CLI_EXE \
    --sn platform \
    --op GetWallet \
    --namespace $TEST_NAMESPACE \
    --walletId 'YBoxSCFs' \
    >$TEMP_FILE 2>&1
update_status $? 'GetWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 208 SyncOrders
$CLI_EXE \
    --sn platform \
    --op SyncOrders \
    --nextEvaluatedKey 'BbZL16L2' \
    --end 'P8eNmOi4' \
    --start 'OPQ8ZEV8' \
    >$TEMP_FILE 2>&1
update_status $? 'SyncOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 209 TestAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["XzBcAniV"], "apiKey": "uoW6wPQl", "authoriseAsCapture": true, "blockedPaymentMethods": ["gkxv25ZH"], "liveEndpointUrlPrefix": "aR8vsMhI", "merchantAccount": "fogRB8Xe", "notificationHmacKey": "ZhAM4MAL", "notificationPassword": "57riU2Qb", "notificationUsername": "QFRCXEWG", "returnUrl": "8Sxt5vtT", "settings": "kIWbiHTU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestAdyenConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 210 TestAliPayConfig
# body param: body
echo '{"appId": "DL4yzTnQ", "privateKey": "v0e99zYN", "publicKey": "kH6PuvER", "returnUrl": "GP7fmyd8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfig \
    --sandbox 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestAliPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 211 TestCheckoutConfig
# body param: body
echo '{"publicKey": "JkJYGKf4", "secretKey": "wBCsCLrf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfig \
    --sandbox 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestCheckoutConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 212 DebugMatchedPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentMerchantConfig \
    --namespace_ 'TRar0UZS' \
    --region '96wD9rgd' \
    >$TEMP_FILE 2>&1
update_status $? 'DebugMatchedPaymentMerchantConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 213 TestPayPalConfig
# body param: body
echo '{"clientID": "YvyfGQvB", "clientSecret": "MJGa0RWF", "returnUrl": "ilSDbJxY", "webHookId": "0YR9wXVR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestPayPalConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 214 TestStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["5ayquoA8"], "publishableKey": "CGDmAN0y", "secretKey": "X8xu01b0", "webhookSecret": "bUqDheu9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestStripeConfig \
    --sandbox 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestStripeConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 215 TestWxPayConfig
# body param: body
echo '{"appId": "dRvQ8V1C", "key": "aeT74VP6", "mchid": "KqpZ2JC5", "returnUrl": "3CGQXzjG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestWxPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 216 TestXsollaConfig
# body param: body
echo '{"apiKey": "Evvr9VR6", "flowCompletionUrl": "QqaoAupK", "merchantId": 88, "projectId": 29, "projectSecretKey": "0RHRzXML"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestXsollaConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 217 GetPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentMerchantConfig \
    --id '3VcaDWEz' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentMerchantConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 218 UpdateAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["PCi2tWPz"], "apiKey": "hrjLFLLu", "authoriseAsCapture": false, "blockedPaymentMethods": ["XInVkn9o"], "liveEndpointUrlPrefix": "jnppiU7r", "merchantAccount": "YU098E1J", "notificationHmacKey": "zPmaRkeY", "notificationPassword": "X8U71w09", "notificationUsername": "mTap7y90", "returnUrl": "X88qbd2v", "settings": "RMUmqoGB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAdyenConfig \
    --id 'qBaxLbpD' \
    --sandbox 'False' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateAdyenConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 219 TestAdyenConfigById
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfigById \
    --id 'uIzTODQZ' \
    --sandbox 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'TestAdyenConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 220 UpdateAliPayConfig
# body param: body
echo '{"appId": "Ng9XscMV", "privateKey": "2DnOo9Pa", "publicKey": "oBSJJGgg", "returnUrl": "8epTUehn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAliPayConfig \
    --id '6IzqXste' \
    --sandbox 'True' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateAliPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 221 TestAliPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfigById \
    --id 'U694ex0b' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestAliPayConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 222 UpdateCheckoutConfig
# body param: body
echo '{"publicKey": "tkvXIrbC", "secretKey": "B52HlTeF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCheckoutConfig \
    --id 'VmpXnrWD' \
    --sandbox 'True' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCheckoutConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 223 TestCheckoutConfigById
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfigById \
    --id 'j8S73sQD' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestCheckoutConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 224 UpdatePayPalConfig
# body param: body
echo '{"clientID": "12G1PiTJ", "clientSecret": "wxV0rwMM", "returnUrl": "7HsMJnUB", "webHookId": "Z6Gyhfcr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePayPalConfig \
    --id 'ddeIOhxQ' \
    --sandbox 'False' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePayPalConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 225 TestPayPalConfigById
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfigById \
    --id '13f1obTK' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestPayPalConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 226 UpdateStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["wFXC2Op2"], "publishableKey": "yXEIOAJh", "secretKey": "6XNWtHWd", "webhookSecret": "mibqDeNi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStripeConfig \
    --id 'c565hvy1' \
    --sandbox 'True' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateStripeConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 227 TestStripeConfigById
$CLI_EXE \
    --sn platform \
    --op TestStripeConfigById \
    --id 'xwwpNwFJ' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestStripeConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 228 UpdateWxPayConfig
# body param: body
echo '{"appId": "OBelglT0", "key": "4uRmAeOh", "mchid": "TeibSq4H", "returnUrl": "7xDe1jh7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfig \
    --id 'clQulgjF' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateWxPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 229 UpdateWxPayConfigCert
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfigCert \
    --id 'OE2zPDGQ' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateWxPayConfigCert'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 230 TestWxPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfigById \
    --id 'YK5uGskl' \
    >$TEMP_FILE 2>&1
update_status $? 'TestWxPayConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 231 UpdateXsollaConfig
# body param: body
echo '{"apiKey": "KEj2cImu", "flowCompletionUrl": "LS8rrBfO", "merchantId": 0, "projectId": 52, "projectSecretKey": "ENFCnYbI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaConfig \
    --id 'QIDkTf41' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXsollaConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 232 TestXsollaConfigById
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfigById \
    --id 'g7CX8oWP' \
    >$TEMP_FILE 2>&1
update_status $? 'TestXsollaConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 233 UpdateXsollaUIConfig
# body param: body
echo '{"device": "MOBILE", "showCloseButton": true, "size": "MEDIUM", "theme": "DARK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaUIConfig \
    --id 'aYvaeaie' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXsollaUIConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 QueryPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op QueryPaymentProviderConfig \
    --limit '30' \
    --namespace_ '5aTdbjoD' \
    --offset '97' \
    --region 'OL2gmjDt' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 235 CreatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "Oz0DT1Ax", "region": "whim0K97", "sandboxTaxJarApiToken": "ZlRomBcU", "specials": ["ADYEN"], "taxJarApiToken": "9DJulX4a", "taxJarEnabled": true, "useGlobalTaxJarApiToken": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreatePaymentProviderConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 236 GetAggregatePaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetAggregatePaymentProviders \
    >$TEMP_FILE 2>&1
update_status $? 'GetAggregatePaymentProviders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 237 DebugMatchedPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentProviderConfig \
    --namespace_ 'Lkwcg4w7' \
    --region 'voonsTuM' \
    >$TEMP_FILE 2>&1
update_status $? 'DebugMatchedPaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 238 GetSpecialPaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetSpecialPaymentProviders \
    >$TEMP_FILE 2>&1
update_status $? 'GetSpecialPaymentProviders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 239 UpdatePaymentProviderConfig
# body param: body
echo '{"aggregate": "XSOLLA", "namespace": "BECnfwi6", "region": "1igqpB4W", "sandboxTaxJarApiToken": "wKtAnQQI", "specials": ["XSOLLA"], "taxJarApiToken": "Nq8tkbUl", "taxJarEnabled": true, "useGlobalTaxJarApiToken": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentProviderConfig \
    --id 'fBvJ3twK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 240 DeletePaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DeletePaymentProviderConfig \
    --id 'U1E8SglS' \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 241 GetPaymentTaxConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxConfig \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentTaxConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 242 UpdatePaymentTaxConfig
# body param: body
echo '{"sandboxTaxJarApiToken": "HPDOBkao", "taxJarApiToken": "6x7WrSKf", "taxJarEnabled": false, "taxJarProductCodesMapping": {"IGHiCd3v": "s48k8GmW"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentTaxConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePaymentTaxConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 243 SyncPaymentOrders
$CLI_EXE \
    --sn platform \
    --op SyncPaymentOrders \
    --nextEvaluatedKey 'bZOgcnbk' \
    --end 'NsJBKfFA' \
    --start 'ZF2oC4m8' \
    >$TEMP_FILE 2>&1
update_status $? 'SyncPaymentOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 244 PublicGetRootCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetRootCategories \
    --namespace $TEST_NAMESPACE \
    --language 'qmGI4g3x' \
    --storeId '7VkgLXzE' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRootCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 245 DownloadCategories
$CLI_EXE \
    --sn platform \
    --op DownloadCategories \
    --namespace $TEST_NAMESPACE \
    --language 'cgKnclUW' \
    --storeId 'y7ZJN4AV' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 246 PublicGetCategory
$CLI_EXE \
    --sn platform \
    --op PublicGetCategory \
    --categoryPath 'WNaW2qMk' \
    --namespace $TEST_NAMESPACE \
    --language 'Z2m9trvZ' \
    --storeId 'isCVMqlZ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 247 PublicGetChildCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetChildCategories \
    --categoryPath '6nzcA05v' \
    --namespace $TEST_NAMESPACE \
    --language '44SCrWkK' \
    --storeId 'PTz20CUu' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetChildCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 248 PublicGetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetDescendantCategories \
    --categoryPath 'ON0qlw6d' \
    --namespace $TEST_NAMESPACE \
    --language 'AFv7zSES' \
    --storeId 'iUAVN1Cw' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetDescendantCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 PublicListCurrencies
$CLI_EXE \
    --sn platform \
    --op PublicListCurrencies \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListCurrencies'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 PublicGetItemByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetItemByAppId \
    --namespace $TEST_NAMESPACE \
    --language 'X4ZMRG0G' \
    --region 'f1rfLs27' \
    --storeId 'GUn4LXB9' \
    --appId 'YV8FW73Y' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItemByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 251 PublicQueryItems
$CLI_EXE \
    --sn platform \
    --op PublicQueryItems \
    --namespace $TEST_NAMESPACE \
    --appType 'DEMO' \
    --baseAppId 'gpNcJMlA' \
    --categoryPath '9wUgUsQ5' \
    --features 'njC8VO4s' \
    --itemType 'BUNDLE' \
    --language 'oRFcoG9E' \
    --limit '42' \
    --offset '12' \
    --region 'BLbT6LIz' \
    --sortBy 'nmery1q7' \
    --storeId 'Ru0EPX2t' \
    --tags '5Kl8G5Sm' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 252 PublicGetItemBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetItemBySku \
    --namespace $TEST_NAMESPACE \
    --language '4GZYuYJ1' \
    --region 'bv2f6vrf' \
    --storeId '7yzKmiSo' \
    --sku 'LdcKYGij' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItemBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 253 PublicBulkGetItems
$CLI_EXE \
    --sn platform \
    --op PublicBulkGetItems \
    --namespace $TEST_NAMESPACE \
    --language '2Fob7nz3' \
    --region 'cBYTpN9B' \
    --storeId 'OiieVeCI' \
    --itemIds 'Jp60mv88' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkGetItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 254 PublicSearchItems
$CLI_EXE \
    --sn platform \
    --op PublicSearchItems \
    --namespace $TEST_NAMESPACE \
    --limit '85' \
    --offset '100' \
    --region 'WnFYRXnD' \
    --storeId 'SOYxR9xE' \
    --keyword 'cI7ktZgy' \
    --language 'Q1PcqgZn' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 255 PublicGetApp
$CLI_EXE \
    --sn platform \
    --op PublicGetApp \
    --itemId 'aDTm4WwM' \
    --namespace $TEST_NAMESPACE \
    --language '8q1mZu6X' \
    --region 'W6by2jUj' \
    --storeId 'Xr2YyM5h' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 256 PublicGetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op PublicGetItemDynamicData \
    --itemId 'o1nPrfkW' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItemDynamicData'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 257 PublicGetItem
$CLI_EXE \
    --sn platform \
    --op PublicGetItem \
    --itemId 'pDz1gbwd' \
    --namespace $TEST_NAMESPACE \
    --language 'SWEGD0k5' \
    --populateBundle 'False' \
    --region 'do1D8HlE' \
    --storeId 'uQQfYbi9' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 GetPaymentCustomization
$CLI_EXE \
    --sn platform \
    --op GetPaymentCustomization \
    --namespace $TEST_NAMESPACE \
    --sandbox 'False' \
    --paymentProvider 'XSOLLA' \
    --region 'CgRp7uEw' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentCustomization'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 PublicGetPaymentUrl
# body param: body
echo '{"paymentOrderNo": "OPWrKnAS", "paymentProvider": "XSOLLA", "returnUrl": "jfbB7kWE", "ui": "U28xX2fI", "zipCode": "68kSyNp7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentUrl \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPaymentUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 260 PublicGetPaymentMethods
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentMethods \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'CBCtgT4n' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPaymentMethods'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 PublicGetUnpaidPaymentOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUnpaidPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'lpO5aE9R' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUnpaidPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 262 Pay
# body param: body
echo '{"token": "qY1zhD25"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op Pay \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'toALOug3' \
    --paymentProvider 'XSOLLA' \
    --zipCode '6sySWjGk' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'Pay'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 263 PublicCheckPaymentOrderPaidStatus
$CLI_EXE \
    --sn platform \
    --op PublicCheckPaymentOrderPaidStatus \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'mDxeIvWS' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCheckPaymentOrderPaidStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 264 GetPaymentPublicConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentPublicConfig \
    --namespace $TEST_NAMESPACE \
    --sandbox 'False' \
    --paymentProvider 'STRIPE' \
    --region 'OsAoob5L' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentPublicConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 265 PublicGetQRCode
$CLI_EXE \
    --sn platform \
    --op PublicGetQRCode \
    --namespace $TEST_NAMESPACE \
    --code 'sBHH7TRU' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetQRCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 266 PublicNormalizePaymentReturnUrl
$CLI_EXE \
    --sn platform \
    --op PublicNormalizePaymentReturnUrl \
    --namespace $TEST_NAMESPACE \
    --payerID '7DSv4Bl1' \
    --foreinginvoice 'JLViUnCf' \
    --invoiceId '9br0AwrY' \
    --payload 'ymvbyVtb' \
    --resultCode 'yXglS0dt' \
    --status 'EcGJ3Vfs' \
    --token 'szE68nyi' \
    --type 'KBCylIgc' \
    --userId 'jAQgJS7u' \
    --orderNo 't6fWj0bj' \
    --paymentOrderNo 'zR1qk50W' \
    --paymentProvider 'XSOLLA' \
    --returnUrl 'WOqgPcQE' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicNormalizePaymentReturnUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 267 GetPaymentTaxValue
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxValue \
    --namespace $TEST_NAMESPACE \
    --zipCode 'u7XP4K3h' \
    --paymentOrderNo '5qA8vxWI' \
    --paymentProvider 'WALLET' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentTaxValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 268 GetRewardByCode
$CLI_EXE \
    --sn platform \
    --op GetRewardByCode \
    --namespace $TEST_NAMESPACE \
    --rewardCode 'znTWhLbx' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRewardByCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 269 QueryRewards1
$CLI_EXE \
    --sn platform \
    --op QueryRewards1 \
    --namespace $TEST_NAMESPACE \
    --eventTopic 'ZXBhedBi' \
    --limit '17' \
    --offset '77' \
    --sortBy 'bLGcBOF8' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRewards1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 270 GetReward1
$CLI_EXE \
    --sn platform \
    --op GetReward1 \
    --namespace $TEST_NAMESPACE \
    --rewardId 'UnezJG2V' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 271 PublicListStores
$CLI_EXE \
    --sn platform \
    --op PublicListStores \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListStores'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 272 PublicExistsAnyMyActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyMyActiveEntitlement \
    --namespace $TEST_NAMESPACE \
    --appIds '["BYcf39AK"]' \
    --itemIds '["gvjNNHD8"]' \
    --skus '["55hjpm3s"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicExistsAnyMyActiveEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 273 PublicGetMyAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyAppEntitlementOwnershipByAppId \
    --namespace $TEST_NAMESPACE \
    --appId 's60uZFam' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyAppEntitlementOwnershipByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 274 PublicGetMyEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipByItemId \
    --namespace $TEST_NAMESPACE \
    --entitlementClazz 'MEDIA' \
    --itemId 'RGicFWBz' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyEntitlementOwnershipByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 275 PublicGetMyEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipBySku \
    --namespace $TEST_NAMESPACE \
    --entitlementClazz 'CODE' \
    --sku 'htqJUSbF' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 276 PublicGetEntitlementOwnershipToken
$CLI_EXE \
    --sn platform \
    --op PublicGetEntitlementOwnershipToken \
    --namespace $TEST_NAMESPACE \
    --appIds '["zSBVZmKw"]' \
    --itemIds '["eECuD3sZ"]' \
    --skus '["MCE8dESg"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetEntitlementOwnershipToken'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 277 PublicGetMyWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetMyWallet \
    --currencyCode 'loJK7nM6' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 278 PublicSyncPsnDlcInventory
# body param: body
echo '{"serviceLabel": 71}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSyncPsnDlcInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'e8rVsrMi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSyncPsnDlcInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 279 SyncSteamDLC
# body param: body
echo '{"appId": "XvUICpXJ", "steamId": "UBosGv2E"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamDLC \
    --namespace $TEST_NAMESPACE \
    --userId '5Ud8R40V' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncSteamDLC'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 280 SyncXboxDLC
# body param: body
echo '{"xstsToken": "ia1HQGyT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxDLC \
    --namespace $TEST_NAMESPACE \
    --userId 'Jx6eE61z' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncXboxDLC'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 281 PublicQueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlements \
    --namespace $TEST_NAMESPACE \
    --userId '1d23WGf1' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'APP' \
    --entitlementName 'jnOgbDHx' \
    --itemId '["FOx68rBO"]' \
    --limit '55' \
    --offset '94' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 282 PublicGetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'v5za3wZK' \
    --appId 'kkBXOpjG' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserAppEntitlementByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 283 PublicQueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlementsByAppType \
    --namespace $TEST_NAMESPACE \
    --userId '8DMYI7aC' \
    --limit '82' \
    --offset '94' \
    --appType 'SOFTWARE' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserEntitlementsByAppType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 284 PublicGetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'HlMa4Gck' \
    --entitlementClazz 'CODE' \
    --itemId 'tYeg98gT' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 285 PublicGetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'KGckRJxW' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'Hhn4YOK6' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 286 PublicExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyUserActiveEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'MnfeVldb' \
    --appIds '["EnLYWOzy"]' \
    --itemIds '["OB0kZoeJ"]' \
    --skus '["IWku1PBe"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicExistsAnyUserActiveEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 287 PublicGetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementOwnershipByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'ZzonuQzx' \
    --appId 'LODS8nTA' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserAppEntitlementOwnershipByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 288 PublicGetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'ouPR62RX' \
    --entitlementClazz 'APP' \
    --itemId 'ekOPk51s' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementOwnershipByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 289 PublicGetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'Yy0IuLJP' \
    --entitlementClazz 'SUBSCRIPTION' \
    --sku 'clQgSBJr' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 290 PublicGetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlement \
    --entitlementId 'jtMtdov0' \
    --namespace $TEST_NAMESPACE \
    --userId 'qluMZwWF' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 291 PublicConsumeUserEntitlement
# body param: body
echo '{"useCount": 84}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicConsumeUserEntitlement \
    --entitlementId 'cBAVMLvA' \
    --namespace $TEST_NAMESPACE \
    --userId 'vzLjQSHw' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicConsumeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 292 PublicRedeemCode
# body param: body
echo '{"code": "PO48On3g", "language": "CbMHOoAw", "region": "KRyMNCSp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicRedeemCode \
    --namespace $TEST_NAMESPACE \
    --userId 'YGZ9RvQU' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicRedeemCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 293 PublicFulfillAppleIAPItem
# body param: body
echo '{"excludeOldTransactions": false, "language": "WQhh5iGh", "productId": "yoneUWbD", "receiptData": "yvutndgi", "region": "cjax7ONn", "transactionId": "A3dvJOoc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillAppleIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'dyisYR5y' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicFulfillAppleIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 294 SyncEpicGamesInventory
# body param: body
echo '{"epicGamesJwtToken": "hrcsZyvb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncEpicGamesInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'LMUUSwl9' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncEpicGamesInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 295 PublicFulfillGoogleIAPItem
# body param: body
echo '{"language": "luLGR0MZ", "orderId": "KdWXP7dH", "packageName": "vzRSx4xn", "productId": "EwseCMo1", "purchaseTime": 32, "purchaseToken": "FRoqmJUL", "region": "DdelYwV2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillGoogleIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'DRZfSBnT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicFulfillGoogleIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 296 PublicReconcilePlayStationStore
# body param: body
echo '{"currencyCode": "2Vlyq5VW", "price": 0.32724185949433404, "productId": "pLxrqfJr", "serviceLabel": 30}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicReconcilePlayStationStore \
    --namespace $TEST_NAMESPACE \
    --userId 'N0CiQ7Ty' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicReconcilePlayStationStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 297 SyncStadiaEntitlement
# body param: body
echo '{"appId": "PiYIIigS", "language": "nJZPieAS", "region": "6Ozt9Y76", "stadiaPlayerId": "Cmi2xN66"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncStadiaEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'qCLHLyxh' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncStadiaEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 298 SyncSteamInventory
# body param: body
echo '{"appId": "ceLzV7iL", "currencyCode": "4mwueWqE", "language": "FljovjiF", "price": 0.9828462455300272, "productId": "s9U3Q4FL", "region": "9FKhfTM3", "steamId": "X1GHB92J"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'FCpi6PSp' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncSteamInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 299 SyncXboxInventory
# body param: body
echo '{"currencyCode": "yvcTnMqT", "price": 0.9280383229359838, "productId": "ELucAFTa", "xstsToken": "fjIfXCWz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'atjGv4UV' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncXboxInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 300 PublicQueryUserOrders
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'j072ERId' \
    --itemId 'IjnEdKEg' \
    --limit '100' \
    --offset '34' \
    --status 'INIT' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 301 PublicCreateUserOrder
# body param: body
echo '{"currencyCode": "08a2gefH", "discountedPrice": 48, "ext": {"ULfaLdtB": {}}, "itemId": "zfi8aWrM", "language": "f1NWlgli", "price": 97, "quantity": 7, "region": "gwwepIgK", "returnUrl": "h0HKAG34"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCreateUserOrder \
    --namespace $TEST_NAMESPACE \
    --userId 'nOfcgWxT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 302 PublicGetUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'fKegxR0U' \
    --userId '2CExNlVZ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 303 PublicCancelUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicCancelUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo '2RGvVo9j' \
    --userId '2WLb2CSA' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCancelUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 304 PublicGetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrderHistories \
    --namespace $TEST_NAMESPACE \
    --orderNo 'gZdAFdnS' \
    --userId 'JJFXEhP7' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserOrderHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 305 PublicDownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op PublicDownloadUserOrderReceipt \
    --namespace $TEST_NAMESPACE \
    --orderNo 'ZQQTrpC1' \
    --userId 'F4J6RUKJ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDownloadUserOrderReceipt'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 306 PublicGetPaymentAccounts
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentAccounts \
    --namespace $TEST_NAMESPACE \
    --userId 'h4njvE58' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPaymentAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 307 PublicDeletePaymentAccount
$CLI_EXE \
    --sn platform \
    --op PublicDeletePaymentAccount \
    --id 'hP4ov9Lr' \
    --namespace $TEST_NAMESPACE \
    --type 'paypal' \
    --userId 'kTSLIshq' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeletePaymentAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 308 PublicQueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserSubscriptions \
    --namespace $TEST_NAMESPACE \
    --userId 'Sb4fuvTw' \
    --chargeStatus 'SETUP' \
    --itemId '9hubYPI2' \
    --limit '43' \
    --offset '42' \
    --sku 'uiybjU8t' \
    --status 'INIT' \
    --subscribedBy 'PLATFORM' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserSubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 309 PublicSubscribeSubscription
# body param: body
echo '{"currencyCode": "bsYzIcst", "itemId": "Ous7bRp1", "language": "CdG3Hblu", "region": "98YQD4Ot", "returnUrl": "x1GZEBw1", "source": "Jkhddhy6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSubscribeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId '86121Qm4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSubscribeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 310 PublicCheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op PublicCheckUserSubscriptionSubscribableByItemId \
    --namespace $TEST_NAMESPACE \
    --userId '2I9DcReF' \
    --itemId 'eyLtNOt0' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCheckUserSubscriptionSubscribableByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 311 PublicGetUserSubscription
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'SmGDzo1d' \
    --userId 'DuZYxY8R' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 312 PublicChangeSubscriptionBillingAccount
$CLI_EXE \
    --sn platform \
    --op PublicChangeSubscriptionBillingAccount \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'WgiwIjK2' \
    --userId 'g9kYwlqr' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicChangeSubscriptionBillingAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 313 PublicCancelSubscription
# body param: body
echo '{"immediate": true, "reason": "fyjHcFVC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCancelSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'YsZcY5pJ' \
    --userId 'fXaaUskh' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCancelSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 314 PublicGetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscriptionBillingHistories \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'gMZlpxmj' \
    --userId 'm9f23Llr' \
    --excludeFree 'False' \
    --limit '14' \
    --offset '85' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSubscriptionBillingHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 315 PublicGetWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetWallet \
    --currencyCode 'rdRvUcqA' \
    --namespace $TEST_NAMESPACE \
    --userId 'HelKgovo' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 316 PublicListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op PublicListUserWalletTransactions \
    --currencyCode 'wPUtF6DL' \
    --namespace $TEST_NAMESPACE \
    --userId 'evfnhWi0' \
    --limit '75' \
    --offset '88' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserWalletTransactions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT