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

OPERATIONS_COUNT=320

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

#- 66 GetTwitchIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetTwitchIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTwitchIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 67 UpdateTwitchIAPConfig
# body param: body
echo '{"clientId": "riI6lTRb", "clientSecret": "c1Z1HJHz", "organizationId": "l323Ynwf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateTwitchIAPConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateTwitchIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 DeleteTwitchIAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteTwitchIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteTwitchIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 69 GetXblIAPConfig
$CLI_EXE \
    --sn platform \
    --op GetXblIAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetXblIAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 70 UpdateXblIAPConfig
# body param: body
echo '{"relyingPartyCert": "5PvGejCD"}' > $TEMP_JSON_INPUT
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

#- 71 DeleteXblAPConfig
$CLI_EXE \
    --sn platform \
    --op DeleteXblAPConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteXblAPConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 72 UpdateXblBPCertFile
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateXblBPCertFile \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --password 'gAr1pXDc' \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXblBPCertFile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 SyncInGameItem
# body param: body
echo '{"categoryPath": "sHnobnaY", "targetItemId": "xGh3FovB", "targetNamespace": "nr5VUOHG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncInGameItem \
    --namespace $TEST_NAMESPACE \
    --storeId 'qEcuJYo3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncInGameItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 CreateItem
# body param: body
echo '{"appId": "YfMDw4Pa", "appType": "DEMO", "baseAppId": "KsFXorxY", "boothName": "0ahG5AgH", "categoryPath": "rE98qQTS", "clazz": "Xh1W7MnK", "displayOrder": 16, "entitlementType": "CONSUMABLE", "ext": {"ly255awv": {}}, "features": ["ulbNGSAj"], "images": [{"as": "eiiANETl", "caption": "kncKPmri", "height": 77, "imageUrl": "Y2aVCNUJ", "smallImageUrl": "gcpAYbj0", "width": 11}], "itemIds": ["idlWPSAI"], "itemQty": {"jaw5HSyD": 37}, "itemType": "CODE", "listable": true, "localizations": {"AxUd1bmV": {"description": "SM44scgN", "localExt": {"AZf7a3R9": {}}, "longDescription": "rIVTDDXZ", "title": "1fahMp68"}}, "maxCount": 70, "maxCountPerUser": 43, "name": "5wQ3hbDl", "purchasable": false, "recurring": {"cycle": "QUARTERLY", "fixedFreeDays": 0, "fixedTrialCycles": 61, "graceDays": 47}, "regionData": {"mVbXDomW": [{"currencyCode": "yrFZZdM0", "currencyNamespace": "0sSdUypO", "currencyType": "VIRTUAL", "discountAmount": 28, "discountExpireAt": "1990-06-15T00:00:00Z", "discountPercentage": 68, "discountPurchaseAt": "1990-01-16T00:00:00Z", "discountedPrice": 86, "expireAt": "1984-12-09T00:00:00Z", "price": 46, "purchaseAt": "1986-05-23T00:00:00Z", "trialPrice": 56}]}, "seasonType": "TIER", "sku": "0koUsUcG", "stackable": false, "status": "ACTIVE", "tags": ["tfyuPNb5"], "targetCurrencyCode": "exiRtR1Q", "targetNamespace": "e0mxLnvZ", "thumbnailUrl": "EG2biyKS", "useCount": 43}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateItem \
    --namespace $TEST_NAMESPACE \
    --storeId 'fIsZ5EAD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 75 GetItemByAppId
$CLI_EXE \
    --sn platform \
    --op GetItemByAppId \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --storeId 'Jp6HXexn' \
    --appId 'HAXYShIg' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 76 QueryItems
$CLI_EXE \
    --sn platform \
    --op QueryItems \
    --namespace $TEST_NAMESPACE \
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
    >$TEMP_FILE 2>&1
update_status $? 'QueryItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 77 ListBasicItemsByFeatures
$CLI_EXE \
    --sn platform \
    --op ListBasicItemsByFeatures \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --features '["JQ0viEYQ"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ListBasicItemsByFeatures'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 78 GetItemBySku
$CLI_EXE \
    --sn platform \
    --op GetItemBySku \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --storeId '4JxBkyXf' \
    --sku 'gwzMTAlT' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 79 GetLocaleItemBySku
$CLI_EXE \
    --sn platform \
    --op GetLocaleItemBySku \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --language '2EbG4Z95' \
    --populateBundle 'False' \
    --region 'dyWe2X8c' \
    --storeId 'Les0TRTA' \
    --sku 'ekrfR30I' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLocaleItemBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 80 GetItemIdBySku
$CLI_EXE \
    --sn platform \
    --op GetItemIdBySku \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --storeId '6CzcXFcj' \
    --sku 'Rpu7wVEz' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemIdBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 81 BulkGetLocaleItems
$CLI_EXE \
    --sn platform \
    --op BulkGetLocaleItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --language 'wHvOGqwb' \
    --region '7FAI8lxD' \
    --storeId 'oRtwKNHC' \
    --itemIds 'ncWRyVDP' \
    >$TEMP_FILE 2>&1
update_status $? 'BulkGetLocaleItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 82 SearchItems
$CLI_EXE \
    --sn platform \
    --op SearchItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --limit '68' \
    --offset '3' \
    --storeId 'OIi021vV' \
    --keyword 'F26yEKnK' \
    --language 'L26vTDvj' \
    >$TEMP_FILE 2>&1
update_status $? 'SearchItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 83 QueryUncategorizedItems
$CLI_EXE \
    --sn platform \
    --op QueryUncategorizedItems \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --limit '19' \
    --offset '0' \
    --sortBy 'EPjDWSwW' \
    --storeId '548hHTuJ' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUncategorizedItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 84 GetItem
$CLI_EXE \
    --sn platform \
    --op GetItem \
    --itemId '1jV4EKpp' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --storeId 'fTxfj3AG' \
    >$TEMP_FILE 2>&1
update_status $? 'GetItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 85 UpdateItem
# body param: body
echo '{"appId": "rDhoJooH", "appType": "DEMO", "baseAppId": "4d6DELnH", "boothName": "Rwigr039", "categoryPath": "B7fw1zHG", "clazz": "7KQTrQeI", "displayOrder": 43, "entitlementType": "CONSUMABLE", "ext": {"tNkXpuQ4": {}}, "features": ["g9IiLxJp"], "images": [{"as": "TlIMuKCd", "caption": "At0XTdLL", "height": 80, "imageUrl": "1WSvdw7F", "smallImageUrl": "I8mOSB2r", "width": 43}], "itemIds": ["QkdnYlPH"], "itemQty": {"6J70BXWV": 39}, "itemType": "SUBSCRIPTION", "listable": true, "localizations": {"ZzUrVRKR": {"description": "tJuZ5W7n", "localExt": {"PrKtUSfl": {}}, "longDescription": "KqC31jYv", "title": "8832yIJU"}}, "maxCount": 27, "maxCountPerUser": 12, "name": "m7GSrElr", "purchasable": false, "recurring": {"cycle": "WEEKLY", "fixedFreeDays": 51, "fixedTrialCycles": 86, "graceDays": 48}, "regionData": {"G8SZmnOv": [{"currencyCode": "u24EFzSQ", "currencyNamespace": "yIXv2yW4", "currencyType": "REAL", "discountAmount": 0, "discountExpireAt": "1999-03-08T00:00:00Z", "discountPercentage": 37, "discountPurchaseAt": "1994-03-25T00:00:00Z", "discountedPrice": 52, "expireAt": "1975-02-12T00:00:00Z", "price": 27, "purchaseAt": "1975-04-13T00:00:00Z", "trialPrice": 64}]}, "seasonType": "PASS", "sku": "0BjFUSZe", "stackable": true, "status": "ACTIVE", "tags": ["Z5SaUa0U"], "targetCurrencyCode": "xaP0Kwv6", "targetNamespace": "8OsqOUTP", "thumbnailUrl": "Xzelychm", "useCount": 12}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateItem \
    --itemId 'jLvnOWOk' \
    --namespace $TEST_NAMESPACE \
    --storeId '5AekVVmT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 86 DeleteItem
$CLI_EXE \
    --sn platform \
    --op DeleteItem \
    --itemId 'IEG2ppf1' \
    --namespace $TEST_NAMESPACE \
    --storeId 'fH3NwfEQ' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 87 AcquireItem
# body param: body
echo '{"count": 20, "orderNo": "dzI8JQzA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireItem \
    --itemId 'p0rF8gvd' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AcquireItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 88 GetApp
$CLI_EXE \
    --sn platform \
    --op GetApp \
    --itemId 'nF1yMvoX' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --storeId 'QZhvPg7V' \
    >$TEMP_FILE 2>&1
update_status $? 'GetApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 89 UpdateApp
# body param: body
echo '{"carousel": [{"alt": "X5rUNWJa", "previewUrl": "q1fjgDyp", "thumbnailUrl": "xO4ufKfU", "type": "video", "url": "mxSk0Ebj", "videoSource": "youtube"}], "developer": "4dSLx4vs", "forumUrl": "b6rx9Xxs", "genres": ["MassivelyMultiplayer"], "localizations": {"8TJHpdZV": {"announcement": "C6y6b9fQ", "slogan": "pa7b36my"}}, "platformRequirements": {"8LWzMOfn": [{"additionals": "jwsIxM4s", "directXVersion": "9m2qWNvm", "diskSpace": "PPlRULr7", "graphics": "pPFCzbPX", "label": "1wwBznD7", "osVersion": "NLs7fb4s", "processor": "qWUpB4t2", "ram": "ieA8XRPh", "soundCard": "VzktsWib"}]}, "platforms": ["MacOS"], "players": ["Multi"], "primaryGenre": "Racing", "publisher": "KXMWuoFv", "releaseDate": "1997-05-03T00:00:00Z", "websiteUrl": "jBvBzZGO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateApp \
    --itemId 'hAwcbpyb' \
    --namespace $TEST_NAMESPACE \
    --storeId 'Zn4ZE5Om' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 90 DisableItem
$CLI_EXE \
    --sn platform \
    --op DisableItem \
    --itemId 'bNkHnefZ' \
    --namespace $TEST_NAMESPACE \
    --storeId 'WDwi6anY' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 91 GetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op GetItemDynamicData \
    --itemId 'nQ92kVBD' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetItemDynamicData'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 92 EnableItem
$CLI_EXE \
    --sn platform \
    --op EnableItem \
    --itemId 'kaMy03Bu' \
    --namespace $TEST_NAMESPACE \
    --storeId 'l4GW3V0W' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 93 FeatureItem
$CLI_EXE \
    --sn platform \
    --op FeatureItem \
    --feature 'CbxvTGyc' \
    --itemId 'cHSkFQzg' \
    --namespace $TEST_NAMESPACE \
    --storeId 'VR72Dhxb' \
    >$TEMP_FILE 2>&1
update_status $? 'FeatureItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 94 DefeatureItem
$CLI_EXE \
    --sn platform \
    --op DefeatureItem \
    --feature 'r4HtKMGr' \
    --itemId '8tnOEeip' \
    --namespace $TEST_NAMESPACE \
    --storeId '505iJTzZ' \
    >$TEMP_FILE 2>&1
update_status $? 'DefeatureItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 95 GetLocaleItem
$CLI_EXE \
    --sn platform \
    --op GetLocaleItem \
    --itemId 'uksb4hRE' \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    --language 'Ox3mATUs' \
    --populateBundle 'False' \
    --region '5Tmapkim' \
    --storeId 'opclvfm7' \
    >$TEMP_FILE 2>&1
update_status $? 'GetLocaleItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 96 ReturnItem
# body param: body
echo '{"orderNo": "fdu7isKa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ReturnItem \
    --itemId 'WRcvkLtf' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ReturnItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 97 QueryKeyGroups
$CLI_EXE \
    --sn platform \
    --op QueryKeyGroups \
    --namespace $TEST_NAMESPACE \
    --limit '24' \
    --name 'GySrACKa' \
    --offset '25' \
    --tag 'WWkDRcuL' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryKeyGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 98 CreateKeyGroup
# body param: body
echo '{"description": "bIpVJnIA", "name": "FpX2SKNm", "status": "ACTIVE", "tags": ["cDRknJor"]}' > $TEMP_JSON_INPUT
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

#- 99 GetKeyGroup
$CLI_EXE \
    --sn platform \
    --op GetKeyGroup \
    --keyGroupId 'twVqipgp' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetKeyGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 100 UpdateKeyGroup
# body param: body
echo '{"description": "XVyWoDjO", "name": "HrGczaXW", "status": "ACTIVE", "tags": ["pcAHtRkB"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateKeyGroup \
    --keyGroupId 'JXZwQ443' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateKeyGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 101 GetKeyGroupDynamic
$CLI_EXE \
    --sn platform \
    --op GetKeyGroupDynamic \
    --keyGroupId 'FfWtsTAA' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetKeyGroupDynamic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 102 ListKeys
$CLI_EXE \
    --sn platform \
    --op ListKeys \
    --keyGroupId 'gtCnvDp2' \
    --namespace $TEST_NAMESPACE \
    --limit '90' \
    --offset '77' \
    --status 'ACTIVE' \
    >$TEMP_FILE 2>&1
update_status $? 'ListKeys'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 103 UploadKeys
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UploadKeys \
    --keyGroupId 'lTcBaljk' \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UploadKeys'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 104 QueryOrders
$CLI_EXE \
    --sn platform \
    --op QueryOrders \
    --namespace $TEST_NAMESPACE \
    --endTime '3sB4LS44' \
    --limit '14' \
    --offset '97' \
    --orderNos '["ONXuXihq"]' \
    --sortBy 'BVEXSyrZ' \
    --startTime 'KBvGa0Ls' \
    --status 'CHARGEBACK_REVERSED' \
    --withTotal 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 105 GetOrderStatistics
$CLI_EXE \
    --sn platform \
    --op GetOrderStatistics \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetOrderStatistics'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 106 GetOrder
$CLI_EXE \
    --sn platform \
    --op GetOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'P3LqrZcS' \
    >$TEMP_FILE 2>&1
update_status $? 'GetOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 107 RefundOrder
# body param: body
echo '{"description": "sGFDDAiS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'jXH3ypQa' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 108 GetPaymentCallbackConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentCallbackConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentCallbackConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 109 UpdatePaymentCallbackConfig
# body param: body
echo '{"dryRun": true, "notifyUrl": "FPMAjx7e", "privateKey": "dUxN5KMS"}' > $TEMP_JSON_INPUT
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

#- 110 QueryPaymentNotifications
$CLI_EXE \
    --sn platform \
    --op QueryPaymentNotifications \
    --namespace $TEST_NAMESPACE \
    --endDate 'Ls21gdQU' \
    --externalId '0FhAQYQa' \
    --limit '66' \
    --notificationSource 'STRIPE' \
    --notificationType 'AApJtfB0' \
    --offset '98' \
    --paymentOrderNo 't8Zcpuz7' \
    --startDate 'BY3JPVnM' \
    --status 'PROCESSED' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentNotifications'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 111 QueryPaymentOrders
$CLI_EXE \
    --sn platform \
    --op QueryPaymentOrders \
    --namespace $TEST_NAMESPACE \
    --channel 'INTERNAL' \
    --extTxId 'FxkSaTdI' \
    --limit '79' \
    --offset '70' \
    --status 'REFUND_FAILED' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 112 CreatePaymentOrderByDedicated
# body param: body
echo '{"currencyCode": "dRQmMvxB", "currencyNamespace": "jpVFnEgs", "customParameters": {"ovZbx4UF": {}}, "description": "3pYMzeFc", "extOrderNo": "sBLCwhTS", "extUserId": "tBJZGkIS", "itemType": "APP", "language": "o6HxX79b", "metadata": {"WJClH3pX": "WCq3ysdp"}, "notifyUrl": "W3XyQQmf", "omitNotification": true, "price": 24, "recurringPaymentOrderNo": "A5HUHiox", "region": "zVhzHc1r", "returnUrl": "BqAXud4J", "sandbox": true, "sku": "zUvNkxTU", "subscriptionId": "qI2XhbYw", "targetNamespace": "TxVSXpJb", "targetUserId": "2JSuHHCR", "title": "P9xW9VeY"}' > $TEMP_JSON_INPUT
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

#- 113 ListExtOrderNoByExtTxId
$CLI_EXE \
    --sn platform \
    --op ListExtOrderNoByExtTxId \
    --namespace $TEST_NAMESPACE \
    --extTxId 'JCDikIap' \
    >$TEMP_FILE 2>&1
update_status $? 'ListExtOrderNoByExtTxId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 114 GetPaymentOrder
$CLI_EXE \
    --sn platform \
    --op GetPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'umYwbaGf' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 115 ChargePaymentOrder
# body param: body
echo '{"extTxId": "sJTgobWG", "paymentMethod": "93dH2MCG", "paymentProvider": "ALIPAY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ChargePaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'ohrdRx6l' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ChargePaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 116 RefundPaymentOrderByDedicated
# body param: body
echo '{"description": "Vi7UcTmE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundPaymentOrderByDedicated \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'we9mWH3X' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundPaymentOrderByDedicated'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 117 SimulatePaymentOrderNotification
# body param: body
echo '{"amount": 94, "currencyCode": "fyejgTi2", "notifyType": "REFUND", "paymentProvider": "STRIPE", "salesTax": 63, "vat": 36}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SimulatePaymentOrderNotification \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'oXaREa1W' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SimulatePaymentOrderNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 118 GetPaymentOrderChargeStatus
$CLI_EXE \
    --sn platform \
    --op GetPaymentOrderChargeStatus \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'psZ5PoXU' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentOrderChargeStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 119 CreateReward
# body param: body
echo '{"description": "ApZEPfic", "eventTopic": "39c2q3a6", "maxAwarded": 20, "maxAwardedPerUser": 87, "namespaceExpression": "uGqHcwZV", "rewardCode": "jAQCkWjE", "rewardConditions": [{"condition": "3gJ6AwW9", "conditionName": "53NlFHpD", "eventName": "CFut39Jh", "rewardItems": [{"duration": 18, "itemId": "3lmfXJxK", "quantity": 71}]}], "userIdExpression": "NRD3KumR"}' > $TEMP_JSON_INPUT
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

#- 120 QueryRewards
$CLI_EXE \
    --sn platform \
    --op QueryRewards \
    --namespace $TEST_NAMESPACE \
    --eventTopic 'jk3wZYVb' \
    --limit '88' \
    --offset '63' \
    --sortBy 'ssnx4JYy' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 121 ExportRewards
$CLI_EXE \
    --sn platform \
    --op ExportRewards \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 122 ImportRewards
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

#- 123 GetReward
$CLI_EXE \
    --sn platform \
    --op GetReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'XakVQoG0' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 124 UpdateReward
# body param: body
echo '{"description": "1upsR2PZ", "eventTopic": "0E2oWaCZ", "maxAwarded": 4, "maxAwardedPerUser": 57, "namespaceExpression": "X2iLiQGT", "rewardCode": "L6OYjLlX", "rewardConditions": [{"condition": "UV78i8cs", "conditionName": "QIO0DRag", "eventName": "PXzsBfUh", "rewardItems": [{"duration": 56, "itemId": "oGFgirdM", "quantity": 74}]}], "userIdExpression": "exA5zJvQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'd2cOVXFo' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 125 DeleteReward
$CLI_EXE \
    --sn platform \
    --op DeleteReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'iaYaSoog' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 126 CheckEventCondition
# body param: body
echo '{"payload": {"7pSsQhvX": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CheckEventCondition \
    --namespace $TEST_NAMESPACE \
    --rewardId 'bGvqRVSS' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CheckEventCondition'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 127 ListStores
$CLI_EXE \
    --sn platform \
    --op ListStores \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ListStores'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 128 CreateStore
# body param: body
echo '{"defaultLanguage": "wvlRzdNX", "defaultRegion": "rfoKVR4H", "description": "hlPEfSM2", "supportedLanguages": ["K29oqfZs"], "supportedRegions": ["sibgoTFQ"], "title": "AmIZiTSs"}' > $TEMP_JSON_INPUT
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

#- 129 ImportStore
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op ImportStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'tC2yOumz' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ImportStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 130 GetPublishedStore
$CLI_EXE \
    --sn platform \
    --op GetPublishedStore \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublishedStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 131 DeletePublishedStore
$CLI_EXE \
    --sn platform \
    --op DeletePublishedStore \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePublishedStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 132 GetPublishedStoreBackup
$CLI_EXE \
    --sn platform \
    --op GetPublishedStoreBackup \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublishedStoreBackup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 133 RollbackPublishedStore
$CLI_EXE \
    --sn platform \
    --op RollbackPublishedStore \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RollbackPublishedStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 134 GetStore
$CLI_EXE \
    --sn platform \
    --op GetStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'HMhXysws' \
    >$TEMP_FILE 2>&1
update_status $? 'GetStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 UpdateStore
# body param: body
echo '{"defaultLanguage": "3Fwnu7OX", "defaultRegion": "9FZvwJ8O", "description": "QFuCH68p", "supportedLanguages": ["TmT632j8"], "supportedRegions": ["QfhNDTHb"], "title": "8lFvBolf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStore \
    --namespace $TEST_NAMESPACE \
    --storeId '9Pdi5BLC' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 136 DeleteStore
$CLI_EXE \
    --sn platform \
    --op DeleteStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'sT8g72th' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 137 CloneStore
$CLI_EXE \
    --sn platform \
    --op CloneStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'hduZnNj9' \
    --targetStoreId 'cRNlTBxl' \
    >$TEMP_FILE 2>&1
update_status $? 'CloneStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 138 ExportStore
$CLI_EXE \
    --sn platform \
    --op ExportStore \
    --namespace $TEST_NAMESPACE \
    --storeId '3nKj6B4f' \
    >$TEMP_FILE 2>&1
update_status $? 'ExportStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 139 QuerySubscriptions
$CLI_EXE \
    --sn platform \
    --op QuerySubscriptions \
    --namespace $TEST_NAMESPACE \
    --chargeStatus 'CHARGED' \
    --itemId 'gtxiPLdV' \
    --limit '29' \
    --offset '6' \
    --sku 'bfast4ND' \
    --status 'INIT' \
    --subscribedBy 'PLATFORM' \
    --userId '3UryryOW' \
    >$TEMP_FILE 2>&1
update_status $? 'QuerySubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 140 RecurringChargeSubscription
$CLI_EXE \
    --sn platform \
    --op RecurringChargeSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'zhhEmSVF' \
    >$TEMP_FILE 2>&1
update_status $? 'RecurringChargeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 141 GetTicketDynamic
$CLI_EXE \
    --sn platform \
    --op GetTicketDynamic \
    --boothName 'hAlEacAA' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTicketDynamic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 142 DecreaseTicketSale
# body param: body
echo '{"orderNo": "oAfsuMB4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DecreaseTicketSale \
    --boothName 'W3HIcvS0' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DecreaseTicketSale'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 143 GetTicketBoothID
$CLI_EXE \
    --sn platform \
    --op GetTicketBoothID \
    --boothName 'AL4tYCwC' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTicketBoothID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 144 IncreaseTicketSale
# body param: body
echo '{"count": 7, "orderNo": "Cigcxlbl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op IncreaseTicketSale \
    --boothName '30hHHEjM' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'IncreaseTicketSale'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 145 AnonymizeCampaign
$CLI_EXE \
    --sn platform \
    --op AnonymizeCampaign \
    --namespace $TEST_NAMESPACE \
    --userId 'I4LcgkyD' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeCampaign'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 146 AnonymizeEntitlement
$CLI_EXE \
    --sn platform \
    --op AnonymizeEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'sccFdvzo' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 147 AnonymizeFulfillment
$CLI_EXE \
    --sn platform \
    --op AnonymizeFulfillment \
    --namespace $TEST_NAMESPACE \
    --userId 'afMLoraV' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeFulfillment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 148 AnonymizeIntegration
$CLI_EXE \
    --sn platform \
    --op AnonymizeIntegration \
    --namespace $TEST_NAMESPACE \
    --userId 'j5RiDHvo' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeIntegration'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 149 AnonymizeOrder
$CLI_EXE \
    --sn platform \
    --op AnonymizeOrder \
    --namespace $TEST_NAMESPACE \
    --userId '7KepgBTM' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 150 AnonymizePayment
$CLI_EXE \
    --sn platform \
    --op AnonymizePayment \
    --namespace $TEST_NAMESPACE \
    --userId 'RiEdeeQw' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizePayment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 151 AnonymizeSubscription
$CLI_EXE \
    --sn platform \
    --op AnonymizeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'LUW0VLup' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 152 AnonymizeWallet
$CLI_EXE \
    --sn platform \
    --op AnonymizeWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'H83AuxFE' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 153 QueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlements \
    --namespace $TEST_NAMESPACE \
    --userId 'FRDTt2ma' \
    --activeOnly 'True' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'ENTITLEMENT' \
    --entitlementName 'aKEsPBAM' \
    --itemId '["1aujNqlm"]' \
    --limit '31' \
    --offset '72' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 154 GrantUserEntitlement
# body param: body
echo '[{"endDate": "1987-02-23T00:00:00Z", "grantedCode": "vTKiXeZe", "itemId": "pm7tF1wK", "itemNamespace": "hQ4HjEca", "language": "gyjZITRu", "quantity": 29, "region": "WjICoCN3", "source": "REWARD", "startDate": "1983-07-27T00:00:00Z", "storeId": "V4niQQVj"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantUserEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'gDJE12W5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 155 GetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'eoplrOXw' \
    --activeOnly 'True' \
    --appId 'SJ1PtQux' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserAppEntitlementByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 156 QueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op QueryUserEntitlementsByAppType \
    --namespace $TEST_NAMESPACE \
    --userId 'OJQKgor2' \
    --activeOnly 'True' \
    --limit '61' \
    --offset '71' \
    --appType 'DEMO' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserEntitlementsByAppType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 157 GetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'cYTYxPTg' \
    --activeOnly 'False' \
    --entitlementClazz 'MEDIA' \
    --itemId 'NsUvUKhA' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 158 GetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'NjquBEHO' \
    --activeOnly 'False' \
    --entitlementClazz 'APP' \
    --sku 'Qpz0dfiu' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 159 ExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'v051lkPC' \
    --appIds '["aZsjvFvh"]' \
    --itemIds '["Zdwi1Ti6"]' \
    --skus '["V2uWuCsB"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ExistsAnyUserActiveEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 160 ExistsAnyUserActiveEntitlementByItemIds
$CLI_EXE \
    --sn platform \
    --op ExistsAnyUserActiveEntitlementByItemIds \
    --namespace $TEST_NAMESPACE \
    --userId '8FbVDwhp' \
    --itemIds '["NCLl2bgI"]' \
    >$TEMP_FILE 2>&1
update_status $? 'ExistsAnyUserActiveEntitlementByItemIds'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 161 GetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op GetUserAppEntitlementOwnershipByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'c1y49bqp' \
    --appId 'bfyytwm6' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserAppEntitlementOwnershipByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 162 GetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'jQJpfOIK' \
    --entitlementClazz 'MEDIA' \
    --itemId 'egUjKQRj' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementOwnershipByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 163 GetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementOwnershipBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'oyn3bGyF' \
    --entitlementClazz 'SUBSCRIPTION' \
    --sku 'wcAylTi4' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 164 RevokeUserEntitlements
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlements \
    --namespace $TEST_NAMESPACE \
    --userId 'qPF190sf' \
    --entitlementIds '2ZwPi5hI' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 165 GetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlement \
    --entitlementId '4k3KwV7P' \
    --namespace $TEST_NAMESPACE \
    --userId '8R9t4dBR' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 UpdateUserEntitlement
# body param: body
echo '{"endDate": "1978-08-04T00:00:00Z", "nullFieldList": ["p4noj3J7"], "startDate": "1985-08-23T00:00:00Z", "status": "ACTIVE", "useCount": 52}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserEntitlement \
    --entitlementId 'ZF4nYBuN' \
    --namespace $TEST_NAMESPACE \
    --userId 'xISmVGVz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 ConsumeUserEntitlement
# body param: body
echo '{"useCount": 70}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ConsumeUserEntitlement \
    --entitlementId 'xj8wegrD' \
    --namespace $TEST_NAMESPACE \
    --userId 'o6OmeKL7' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ConsumeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 168 DisableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op DisableUserEntitlement \
    --entitlementId 'GPoI9uWO' \
    --namespace $TEST_NAMESPACE \
    --userId 'FTWdRrL6' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 EnableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op EnableUserEntitlement \
    --entitlementId 'yNmv8k1w' \
    --namespace $TEST_NAMESPACE \
    --userId '19JsHSqO' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 GetUserEntitlementHistories
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementHistories \
    --entitlementId 'Byh4hhkc' \
    --namespace $TEST_NAMESPACE \
    --userId 'O6J7jSvY' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 171 RevokeUserEntitlement
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlement \
    --entitlementId 'd4J5c6ay' \
    --namespace $TEST_NAMESPACE \
    --userId 'FnSrfmOb' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 172 FulfillItem
# body param: body
echo '{"duration": 62, "endDate": "1993-07-31T00:00:00Z", "itemId": "RRDGCRQt", "itemSku": "Mc3an8Zo", "language": "xLwXHS1o", "order": {"currency": {"currencyCode": "UzDdDcZ0", "currencySymbol": "Rj3YM1fz", "currencyType": "VIRTUAL", "decimals": 19, "namespace": "qtqeiyDC"}, "ext": {"K7C3u5Gc": {}}, "free": false}, "orderNo": "mi5KiFDV", "quantity": 31, "region": "fvR2Wl0i", "source": "IAP", "startDate": "1971-02-22T00:00:00Z", "storeId": "pvFuZu45"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillItem \
    --namespace $TEST_NAMESPACE \
    --userId 'zsrSpvML' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 RedeemCode
# body param: body
echo '{"code": "vQw3sPxF", "language": "u8LQGQCA", "region": "j6O7ivhN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RedeemCode \
    --namespace $TEST_NAMESPACE \
    --userId 'IjVT5HSR' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RedeemCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 174 FulfillRewards
# body param: body
echo '{"rewards": [{"currency": {"currencyCode": "00UKSLWW", "namespace": "zOplTLwZ"}, "item": {"itemId": "QZUMaAJ6", "itemSku": "ZBTHYjGb", "itemType": "VtzsBTCO"}, "quantity": 97, "type": "CURRENCY"}], "source": "ACHIEVEMENT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillRewards \
    --namespace $TEST_NAMESPACE \
    --userId 'aLzHuYKr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillRewards'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 175 QueryUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserIAPOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'r89z0RkL' \
    --endTime '932B7thD' \
    --limit '84' \
    --offset '15' \
    --productId 'fVnPK8iK' \
    --startTime '8cdZPnXw' \
    --status 'VERIFIED' \
    --type 'EPICGAMES' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserIAPOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 176 QueryAllUserIAPOrders
$CLI_EXE \
    --sn platform \
    --op QueryAllUserIAPOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'AlxtjeZU' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryAllUserIAPOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 177 MockFulfillIAPItem
# body param: body
echo '{"language": "rqmIc7El", "productId": "44MEAvaP", "region": "TwwJrG06", "type": "XBOX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op MockFulfillIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'cF7t8DQx' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'MockFulfillIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 178 QueryUserOrders
$CLI_EXE \
    --sn platform \
    --op QueryUserOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'coQBTWMc' \
    --itemId '41xDmUjk' \
    --limit '98' \
    --offset '17' \
    --status 'REFUNDING' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 179 CountOfPurchasedItem
$CLI_EXE \
    --sn platform \
    --op CountOfPurchasedItem \
    --namespace $TEST_NAMESPACE \
    --userId 'gkALGxw6' \
    --itemId 'qgvIJBe6' \
    >$TEMP_FILE 2>&1
update_status $? 'CountOfPurchasedItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 180 GetUserOrder
$CLI_EXE \
    --sn platform \
    --op GetUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'rDGbFNzs' \
    --userId 'yQVqvSgt' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 UpdateUserOrderStatus
# body param: body
echo '{"status": "CHARGEBACK_REVERSED", "statusReason": "UVddL6A1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserOrderStatus \
    --namespace $TEST_NAMESPACE \
    --orderNo 'cTLmuKlG' \
    --userId 'HZdwwo66' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserOrderStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 182 FulfillUserOrder
$CLI_EXE \
    --sn platform \
    --op FulfillUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'H6QOfYzt' \
    --userId 'Hev8RX4M' \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 183 GetUserOrderGrant
$CLI_EXE \
    --sn platform \
    --op GetUserOrderGrant \
    --namespace $TEST_NAMESPACE \
    --orderNo 'WRFklN13' \
    --userId 'WW7U0sRV' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrderGrant'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 184 GetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op GetUserOrderHistories \
    --namespace $TEST_NAMESPACE \
    --orderNo 'CnzRxni0' \
    --userId 'Kq9Zl2b7' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrderHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 ProcessUserOrderNotification
# body param: body
echo '{"additionalData": {"cardSummary": "ChMCxb6x"}, "authorisedTime": "1972-07-20T00:00:00Z", "chargebackReversedTime": "1976-11-23T00:00:00Z", "chargebackTime": "1996-12-09T00:00:00Z", "chargedTime": "1988-11-12T00:00:00Z", "createdTime": "1985-08-28T00:00:00Z", "currency": {"currencyCode": "ruVITunb", "currencySymbol": "xaOWNrMk", "currencyType": "REAL", "decimals": 53, "namespace": "LUDrR6M3"}, "customParameters": {"vzu84TNQ": {}}, "extOrderNo": "YCZIpKFv", "extTxId": "pQOjjkIY", "extUserId": "AQEcxGPT", "issuedAt": "1976-04-18T00:00:00Z", "metadata": {"2NJ9gHmB": "0vflV2Vp"}, "namespace": "tGYAEziS", "nonceStr": "thhR9WLi", "paymentMethod": "VTXHhZmB", "paymentMethodFee": 49, "paymentOrderNo": "xlmWBLyh", "paymentProvider": "XSOLLA", "paymentProviderFee": 37, "paymentStationUrl": "JoonMpOQ", "price": 71, "refundedTime": "1977-02-28T00:00:00Z", "salesTax": 44, "sandbox": true, "sku": "Q28fmxMF", "status": "REFUNDING", "statusReason": "8d9fdHAH", "subscriptionId": "phhby7hG", "subtotalPrice": 2, "targetNamespace": "KeIkY4Fc", "targetUserId": "8atJ3J4g", "tax": 2, "totalPrice": 21, "totalTax": 6, "txEndTime": "1986-04-11T00:00:00Z", "type": "0o9Rjjnk", "userId": "hwq75VqZ", "vat": 66}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserOrderNotification \
    --namespace $TEST_NAMESPACE \
    --orderNo '8HUq92UF' \
    --userId 'WFC8oFuU' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ProcessUserOrderNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 186 DownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op DownloadUserOrderReceipt \
    --namespace $TEST_NAMESPACE \
    --orderNo '2OFJ6w1H' \
    --userId 'bioiiaZ8' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadUserOrderReceipt'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 CreateUserPaymentOrder
# body param: body
echo '{"currencyCode": "Uc2rWpzX", "currencyNamespace": "2mgoBhru", "customParameters": {"uvEzpyRi": {}}, "description": "Fs63b4Pr", "extOrderNo": "u2pWiVBY", "extUserId": "jKI1ZlcK", "itemType": "SEASON", "language": "XcPAsjW7", "metadata": {"zBxpVc8s": "vjiFtRe8"}, "notifyUrl": "k7amplfh", "omitNotification": true, "price": 67, "recurringPaymentOrderNo": "ropVxIvB", "region": "jsYUEDp1", "returnUrl": "taP9py4F", "sandbox": false, "sku": "6UoVxgHJ", "subscriptionId": "LBm3bgRv", "title": "SUyOgyu9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateUserPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --userId 'dhxaofTj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 RefundUserPaymentOrder
# body param: body
echo '{"description": "MYGTMXy4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundUserPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'ypcIN4uU' \
    --userId 'IzvUI5b1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundUserPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 ApplyUserRedemption
# body param: body
echo '{"code": "wxS2yBTD", "orderNo": "8uNeauLe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ApplyUserRedemption \
    --namespace $TEST_NAMESPACE \
    --userId 'XNgQBnXZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ApplyUserRedemption'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 190 QueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op QueryUserSubscriptions \
    --namespace $TEST_NAMESPACE \
    --userId 'kQ06LUEg' \
    --chargeStatus 'RECURRING_CHARGING' \
    --itemId 'yiBeJARF' \
    --limit '94' \
    --offset '3' \
    --sku 'UvLNtDdA' \
    --status 'CANCELLED' \
    --subscribedBy 'USER' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserSubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 191 GetUserSubscriptionActivities
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionActivities \
    --namespace $TEST_NAMESPACE \
    --userId 'KI6vd3Qd' \
    --excludeSystem 'True' \
    --limit '42' \
    --offset '29' \
    --subscriptionId 'sR9Nk0JJ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscriptionActivities'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 192 PlatformSubscribeSubscription
# body param: body
echo '{"grantDays": 100, "itemId": "XMRcQg1L", "language": "wgzWRu5q", "reason": "2i8ntDdF", "region": "SOEIqFse", "source": "4ocrqjWT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PlatformSubscribeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'bUayIP8o' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformSubscribeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 193 CheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op CheckUserSubscriptionSubscribableByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'O0z1VffD' \
    --itemId 'HyFM7T2H' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckUserSubscriptionSubscribableByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 194 GetUserSubscription
$CLI_EXE \
    --sn platform \
    --op GetUserSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId '6g4jbxDD' \
    --userId 'xngEqsAb' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 195 DeleteUserSubscription
$CLI_EXE \
    --sn platform \
    --op DeleteUserSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'WEfTc2nS' \
    --userId 'U2SijySp' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 196 CancelSubscription
# body param: body
echo '{"immediate": false, "reason": "qX01uDkQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CancelSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId '1tv3iMMW' \
    --userId '8aqVbwAr' \
    --force 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CancelSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 197 GrantDaysToSubscription
# body param: body
echo '{"grantDays": 65, "reason": "SaFxyAsP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantDaysToSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'nfbHX5Tp' \
    --userId 'IV6e7dMK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'GrantDaysToSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 198 GetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op GetUserSubscriptionBillingHistories \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'aAr2VSmt' \
    --userId 'P8qxtNo7' \
    --excludeFree 'False' \
    --limit '83' \
    --offset '87' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscriptionBillingHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 ProcessUserSubscriptionNotification
# body param: body
echo '{"additionalData": {"cardSummary": "uvxUGNJv"}, "authorisedTime": "1985-12-08T00:00:00Z", "chargebackReversedTime": "1981-08-07T00:00:00Z", "chargebackTime": "1983-07-14T00:00:00Z", "chargedTime": "1995-02-04T00:00:00Z", "createdTime": "1981-05-25T00:00:00Z", "currency": {"currencyCode": "WdEJnqhX", "currencySymbol": "gmVQHoZN", "currencyType": "VIRTUAL", "decimals": 96, "namespace": "qu4qtxTy"}, "customParameters": {"rvNhypNL": {}}, "extOrderNo": "porjcAKS", "extTxId": "uvgVjdXM", "extUserId": "n2juyP3W", "issuedAt": "1995-06-11T00:00:00Z", "metadata": {"1OLRUrZ6": "vwIqGnoq"}, "namespace": "XXAZd7bv", "nonceStr": "O6Xg2xx5", "paymentMethod": "vZXC9YsE", "paymentMethodFee": 98, "paymentOrderNo": "Ee9iC3Hp", "paymentProvider": "WXPAY", "paymentProviderFee": 38, "paymentStationUrl": "WE8drEip", "price": 98, "refundedTime": "1996-02-12T00:00:00Z", "salesTax": 28, "sandbox": false, "sku": "CS9nGM6f", "status": "DELETED", "statusReason": "F1o77M1V", "subscriptionId": "VgHHeL0f", "subtotalPrice": 22, "targetNamespace": "EPUxHPhE", "targetUserId": "4YwCRBGA", "tax": 86, "totalPrice": 90, "totalTax": 38, "txEndTime": "1996-03-26T00:00:00Z", "type": "DIjOfYlF", "userId": "5jISj4ww", "vat": 33}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserSubscriptionNotification \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'LpFnnNyd' \
    --userId 'TcPOtfkE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ProcessUserSubscriptionNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 200 AcquireUserTicket
# body param: body
echo '{"count": 48, "orderNo": "Lh6l74AQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireUserTicket \
    --boothName 'Y5ulxH0l' \
    --namespace $TEST_NAMESPACE \
    --userId 'ioSoooPh' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AcquireUserTicket'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 201 CheckWallet
$CLI_EXE \
    --sn platform \
    --op CheckWallet \
    --currencyCode 'Q9xlLMe7' \
    --namespace $TEST_NAMESPACE \
    --userId 'ma8Qc9aG' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 202 CreditUserWallet
# body param: body
echo '{"amount": 78, "reason": "5UJPLchi", "source": "PROMOTION"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreditUserWallet \
    --currencyCode 'vOQdByk3' \
    --namespace $TEST_NAMESPACE \
    --userId 'mWQ93Bxb' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreditUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 PayWithUserWallet
# body param: body
echo '{"amount": 82}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PayWithUserWallet \
    --currencyCode '1VP8rKuV' \
    --namespace $TEST_NAMESPACE \
    --userId 'wTTGSX5r' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PayWithUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 204 GetUserWallet
$CLI_EXE \
    --sn platform \
    --op GetUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'G8ymO7ml' \
    --walletId '7SCwM6RZ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 DebitUserWallet
# body param: body
echo '{"amount": 79, "reason": "erJQroYU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DebitUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'kvHx2dAj' \
    --walletId 'FF0BBGwZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DebitUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 206 DisableUserWallet
$CLI_EXE \
    --sn platform \
    --op DisableUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId '7XWhdoYx' \
    --walletId '127YYBox' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 207 EnableUserWallet
$CLI_EXE \
    --sn platform \
    --op EnableUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'SCFsBbZL' \
    --walletId '16L2P8eN' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 208 ListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op ListUserWalletTransactions \
    --namespace $TEST_NAMESPACE \
    --userId 'mOi4OPQ8' \
    --walletId 'ZEV8XzBc' \
    --limit '52' \
    --offset '26' \
    >$TEMP_FILE 2>&1
update_status $? 'ListUserWalletTransactions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 209 QueryWallets
$CLI_EXE \
    --sn platform \
    --op QueryWallets \
    --namespace $TEST_NAMESPACE \
    --currencyCode 'iVuoW6wP' \
    --limit '84' \
    --offset '22' \
    --userId 'P1zgkxv2' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryWallets'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 210 GetWallet
$CLI_EXE \
    --sn platform \
    --op GetWallet \
    --namespace $TEST_NAMESPACE \
    --walletId '5ZHaR8vs' \
    >$TEMP_FILE 2>&1
update_status $? 'GetWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 211 SyncOrders
$CLI_EXE \
    --sn platform \
    --op SyncOrders \
    --nextEvaluatedKey 'MhIfogRB' \
    --end '8XeZhAM4' \
    --start 'MAL57riU' \
    >$TEMP_FILE 2>&1
update_status $? 'SyncOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 212 TestAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["2QbQFRCX"], "apiKey": "EWG8Sxt5", "authoriseAsCapture": true, "blockedPaymentMethods": ["tTkIWbiH"], "liveEndpointUrlPrefix": "TUDDL4yz", "merchantAccount": "TnQv0e99", "notificationHmacKey": "zYNkH6Pu", "notificationPassword": "vERGP7fm", "notificationUsername": "yd8aJkJY", "returnUrl": "GKf4wBCs", "settings": "CLrfH6V3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfig \
    --sandbox 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestAdyenConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 213 TestAliPayConfig
# body param: body
echo '{"appId": "TRar0UZS", "privateKey": "96wD9rgd", "publicKey": "YvyfGQvB", "returnUrl": "MJGa0RWF"}' > $TEMP_JSON_INPUT
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

#- 214 TestCheckoutConfig
# body param: body
echo '{"publicKey": "lSDbJxY0", "secretKey": "YR9wXVRz"}' > $TEMP_JSON_INPUT
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

#- 215 DebugMatchedPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentMerchantConfig \
    --namespace_ 'yquoA8CG' \
    --region 'DmAN0yX8' \
    >$TEMP_FILE 2>&1
update_status $? 'DebugMatchedPaymentMerchantConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 216 TestPayPalConfig
# body param: body
echo '{"clientID": "xu01b0bU", "clientSecret": "qDheu9id", "returnUrl": "RvQ8V1Ca", "webHookId": "eT74VP6K"}' > $TEMP_JSON_INPUT
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

#- 217 TestStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["pZ2JC53C"], "publishableKey": "GQXzjGEv", "secretKey": "vr9VR6Qq", "webhookSecret": "aoAupKSo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestStripeConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestStripeConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 218 TestWxPayConfig
# body param: body
echo '{"appId": "XML3VcaD", "key": "WEzPCi2t", "mchid": "WPzhrjLF", "returnUrl": "LLuGlXIn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestWxPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 219 TestXsollaConfig
# body param: body
echo '{"apiKey": "Vkn9ojnp", "flowCompletionUrl": "piU7rYU0", "merchantId": 61, "projectId": 71, "projectSecretKey": "zPmaRkeY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestXsollaConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 220 GetPaymentMerchantConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentMerchantConfig \
    --id 'X8U71w09' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentMerchantConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 221 UpdateAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["mTap7y90"], "apiKey": "X88qbd2v", "authoriseAsCapture": false, "blockedPaymentMethods": ["qoGBqBax"], "liveEndpointUrlPrefix": "LbpDekuI", "merchantAccount": "zTODQZkN", "notificationHmacKey": "g9XscMV2", "notificationPassword": "DnOo9Pao", "notificationUsername": "BSJJGgg8", "returnUrl": "epTUehn6", "settings": "IzqXsteu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAdyenConfig \
    --id '4pU694ex' \
    --sandbox 'False' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateAdyenConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 222 TestAdyenConfigById
$CLI_EXE \
    --sn platform \
    --op TestAdyenConfigById \
    --id 'tkvXIrbC' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestAdyenConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 223 UpdateAliPayConfig
# body param: body
echo '{"appId": "52HlTeFV", "privateKey": "mpXnrWDC", "publicKey": "ij8S73sQ", "returnUrl": "DNy12G1P"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAliPayConfig \
    --id 'iTJwxV0r' \
    --sandbox 'True' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateAliPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 224 TestAliPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfigById \
    --id 'MJnUBZ6G' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestAliPayConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 225 UpdateCheckoutConfig
# body param: body
echo '{"publicKey": "hfcrddeI", "secretKey": "OhxQMImB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCheckoutConfig \
    --id '13f1obTK' \
    --sandbox 'True' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCheckoutConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 226 TestCheckoutConfigById
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfigById \
    --id 'FXC2Op2y' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestCheckoutConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 227 UpdatePayPalConfig
# body param: body
echo '{"clientID": "IOAJh6XN", "clientSecret": "WtHWdmib", "returnUrl": "qDeNic56", "webHookId": "5hvy1VY2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePayPalConfig \
    --id '365rUHkx' \
    --sandbox 'True' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePayPalConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 228 TestPayPalConfigById
$CLI_EXE \
    --sn platform \
    --op TestPayPalConfigById \
    --id 'pNwFJyOB' \
    --sandbox 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'TestPayPalConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 229 UpdateStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["lglT04uR"], "publishableKey": "mAeOhTei", "secretKey": "bSq4H7xD", "webhookSecret": "e1jh7clQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStripeConfig \
    --id 'ulgjFzOE' \
    --sandbox 'True' \
    --validate 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateStripeConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 230 TestStripeConfigById
$CLI_EXE \
    --sn platform \
    --op TestStripeConfigById \
    --id 'GQYK5uGs' \
    --sandbox 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'TestStripeConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 231 UpdateWxPayConfig
# body param: body
echo '{"appId": "lKEj2cIm", "key": "uLS8rrBf", "mchid": "OaAENFCn", "returnUrl": "YbIQIDkT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfig \
    --id 'f41ag7CX' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateWxPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 232 UpdateWxPayConfigCert
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfigCert \
    --id 'WPut7xra' \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateWxPayConfigCert'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 233 TestWxPayConfigById
$CLI_EXE \
    --sn platform \
    --op TestWxPayConfigById \
    --id 'Yvaeaiep' \
    >$TEMP_FILE 2>&1
update_status $? 'TestWxPayConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 UpdateXsollaConfig
# body param: body
echo '{"apiKey": "5aTdbjoD", "flowCompletionUrl": "WOL2gmjD", "merchantId": 38, "projectId": 35, "projectSecretKey": "Oz0DT1Ax"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaConfig \
    --id 'whim0K97' \
    --validate 'False' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXsollaConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 235 TestXsollaConfigById
$CLI_EXE \
    --sn platform \
    --op TestXsollaConfigById \
    --id 'RomBcUU8' \
    >$TEMP_FILE 2>&1
update_status $? 'TestXsollaConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 236 UpdateXsollaUIConfig
# body param: body
echo '{"device": "DESKTOP", "showCloseButton": true, "size": "LARGE", "theme": "DARK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaUIConfig \
    --id 'lX4aR8w6' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXsollaUIConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 237 QueryPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op QueryPaymentProviderConfig \
    --limit '85' \
    --namespace_ '4PkLkwcg' \
    --offset '44' \
    --region '7voonsTu' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 238 CreatePaymentProviderConfig
# body param: body
echo '{"aggregate": "XSOLLA", "namespace": "BECnfwi6", "region": "1igqpB4W", "sandboxTaxJarApiToken": "wKtAnQQI", "specials": ["XSOLLA"], "taxJarApiToken": "Nq8tkbUl", "taxJarEnabled": true, "useGlobalTaxJarApiToken": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreatePaymentProviderConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 239 GetAggregatePaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetAggregatePaymentProviders \
    >$TEMP_FILE 2>&1
update_status $? 'GetAggregatePaymentProviders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 240 DebugMatchedPaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DebugMatchedPaymentProviderConfig \
    --namespace_ 'fBvJ3twK' \
    --region 'U1E8SglS' \
    >$TEMP_FILE 2>&1
update_status $? 'DebugMatchedPaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 241 GetSpecialPaymentProviders
$CLI_EXE \
    --sn platform \
    --op GetSpecialPaymentProviders \
    >$TEMP_FILE 2>&1
update_status $? 'GetSpecialPaymentProviders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 242 UpdatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "OBkao6x7", "region": "WrSKfNZd", "sandboxTaxJarApiToken": "IGHiCd3v", "specials": ["CHECKOUT"], "taxJarApiToken": "48k8GmWb", "taxJarEnabled": false, "useGlobalTaxJarApiToken": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentProviderConfig \
    --id 'nbkNsJBK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 243 DeletePaymentProviderConfig
$CLI_EXE \
    --sn platform \
    --op DeletePaymentProviderConfig \
    --id 'fFAZF2oC' \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 244 GetPaymentTaxConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxConfig \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentTaxConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 245 UpdatePaymentTaxConfig
# body param: body
echo '{"sandboxTaxJarApiToken": "4m8qmGI4", "taxJarApiToken": "g3x7VkgL", "taxJarEnabled": true, "taxJarProductCodesMapping": {"EcgKnclU": "Wy7ZJN4A"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentTaxConfig \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePaymentTaxConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 246 SyncPaymentOrders
$CLI_EXE \
    --sn platform \
    --op SyncPaymentOrders \
    --nextEvaluatedKey 'VWNaW2qM' \
    --end 'kZ2m9trv' \
    --start 'ZisCVMql' \
    >$TEMP_FILE 2>&1
update_status $? 'SyncPaymentOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 247 PublicGetRootCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetRootCategories \
    --namespace $TEST_NAMESPACE \
    --language 'Z6nzcA05' \
    --storeId 'v44SCrWk' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRootCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 248 DownloadCategories
$CLI_EXE \
    --sn platform \
    --op DownloadCategories \
    --namespace $TEST_NAMESPACE \
    --language 'KPTz20CU' \
    --storeId 'uON0qlw6' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 PublicGetCategory
$CLI_EXE \
    --sn platform \
    --op PublicGetCategory \
    --categoryPath 'dAFv7zSE' \
    --namespace $TEST_NAMESPACE \
    --language 'SiUAVN1C' \
    --storeId 'wX4ZMRG0' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 PublicGetChildCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetChildCategories \
    --categoryPath 'Gf1rfLs2' \
    --namespace $TEST_NAMESPACE \
    --language '7GUn4LXB' \
    --storeId '9YV8FW73' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetChildCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 251 PublicGetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetDescendantCategories \
    --categoryPath 'YegpNcJM' \
    --namespace $TEST_NAMESPACE \
    --language 'lA9wUgUs' \
    --storeId 'Q5njC8VO' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetDescendantCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 252 PublicListCurrencies
$CLI_EXE \
    --sn platform \
    --op PublicListCurrencies \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListCurrencies'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 253 PublicGetItemByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetItemByAppId \
    --namespace $TEST_NAMESPACE \
    --language '4sgoRFco' \
    --region 'G9EvgBLb' \
    --storeId 'T6LIznme' \
    --appId 'ry1q7Ru0' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItemByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 254 PublicQueryItems
$CLI_EXE \
    --sn platform \
    --op PublicQueryItems \
    --namespace $TEST_NAMESPACE \
    --appType 'SOFTWARE' \
    --baseAppId 'PX2t5Kl8' \
    --categoryPath 'G5Sm4GZY' \
    --features 'uYJ1bv2f' \
    --itemType 'MEDIA' \
    --language 'rf7yzKmi' \
    --limit '88' \
    --offset '29' \
    --region 'LdcKYGij' \
    --sortBy '2Fob7nz3' \
    --storeId 'cBYTpN9B' \
    --tags 'OiieVeCI' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 255 PublicGetItemBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetItemBySku \
    --namespace $TEST_NAMESPACE \
    --language 'Jp60mv88' \
    --region 'QYWnFYRX' \
    --storeId 'nDSOYxR9' \
    --sku 'xEcI7ktZ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItemBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 256 PublicBulkGetItems
$CLI_EXE \
    --sn platform \
    --op PublicBulkGetItems \
    --namespace $TEST_NAMESPACE \
    --language 'gyQ1Pcqg' \
    --region 'ZnaDTm4W' \
    --storeId 'wM8q1mZu' \
    --itemIds '6XW6by2j' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkGetItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 257 PublicSearchItems
$CLI_EXE \
    --sn platform \
    --op PublicSearchItems \
    --namespace $TEST_NAMESPACE \
    --limit '93' \
    --offset '19' \
    --region 'Xr2YyM5h' \
    --storeId 'o1nPrfkW' \
    --keyword 'pDz1gbwd' \
    --language 'SWEGD0k5' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 PublicGetApp
$CLI_EXE \
    --sn platform \
    --op PublicGetApp \
    --itemId '2Xldo1D8' \
    --namespace $TEST_NAMESPACE \
    --language 'HlEuQQfY' \
    --region 'bi9H9dFC' \
    --storeId 'gRp7uEwO' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 PublicGetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op PublicGetItemDynamicData \
    --itemId 'PWrKnASg' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItemDynamicData'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 260 PublicGetItem
$CLI_EXE \
    --sn platform \
    --op PublicGetItem \
    --itemId 'jfbB7kWE' \
    --namespace $TEST_NAMESPACE \
    --language 'U28xX2fI' \
    --populateBundle 'False' \
    --region 'SyNp7CBC' \
    --storeId 'tgT4nlpO' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 GetPaymentCustomization
$CLI_EXE \
    --sn platform \
    --op GetPaymentCustomization \
    --namespace $TEST_NAMESPACE \
    --sandbox 'False' \
    --paymentProvider 'XSOLLA' \
    --region '9RqY1zhD' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentCustomization'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 262 PublicGetPaymentUrl
# body param: body
echo '{"paymentOrderNo": "25toALOu", "paymentProvider": "XSOLLA", "returnUrl": "3D6sySWj", "ui": "GkmDxeIv", "zipCode": "WSM0L1et"}' > $TEMP_JSON_INPUT
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

#- 263 PublicGetPaymentMethods
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentMethods \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'OsAoob5L' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPaymentMethods'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 264 PublicGetUnpaidPaymentOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUnpaidPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'sBHH7TRU' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUnpaidPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 265 Pay
# body param: body
echo '{"token": "7DSv4Bl1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op Pay \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'JLViUnCf' \
    --paymentProvider 'ADYEN' \
    --zipCode 'r0AwrYym' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'Pay'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 266 PublicCheckPaymentOrderPaidStatus
$CLI_EXE \
    --sn platform \
    --op PublicCheckPaymentOrderPaidStatus \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'vbyVtbyX' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCheckPaymentOrderPaidStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 267 GetPaymentPublicConfig
$CLI_EXE \
    --sn platform \
    --op GetPaymentPublicConfig \
    --namespace $TEST_NAMESPACE \
    --sandbox 'False' \
    --paymentProvider 'CHECKOUT' \
    --region 'S0dtEcGJ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentPublicConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 268 PublicGetQRCode
$CLI_EXE \
    --sn platform \
    --op PublicGetQRCode \
    --namespace $TEST_NAMESPACE \
    --code '3VfsszE6' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetQRCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 269 PublicNormalizePaymentReturnUrl
$CLI_EXE \
    --sn platform \
    --op PublicNormalizePaymentReturnUrl \
    --namespace $TEST_NAMESPACE \
    --payerID '8nyiKBCy' \
    --foreinginvoice 'lIgcjAQg' \
    --invoiceId 'JS7ut6fW' \
    --payload 'j0bjzR1q' \
    --resultCode 'k50WTJSW' \
    --status 'MGCWOqgP' \
    --token 'cQEu7XP4' \
    --type 'K3h5qA8v' \
    --userId 'xWIwznTW' \
    --orderNo 'hLbxZXBh' \
    --paymentOrderNo 'edBiiMbL' \
    --paymentProvider 'ADYEN' \
    --returnUrl 'BOF8Unez' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicNormalizePaymentReturnUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 270 GetPaymentTaxValue
$CLI_EXE \
    --sn platform \
    --op GetPaymentTaxValue \
    --namespace $TEST_NAMESPACE \
    --zipCode 'JG2VBYcf' \
    --paymentOrderNo '39AKgvjN' \
    --paymentProvider 'XSOLLA' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentTaxValue'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 271 GetRewardByCode
$CLI_EXE \
    --sn platform \
    --op GetRewardByCode \
    --namespace $TEST_NAMESPACE \
    --rewardCode '855hjpm3' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRewardByCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 272 QueryRewards1
$CLI_EXE \
    --sn platform \
    --op QueryRewards1 \
    --namespace $TEST_NAMESPACE \
    --eventTopic 'ss60uZFa' \
    --limit '24' \
    --offset '62' \
    --sortBy 'RGicFWBz' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryRewards1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 273 GetReward1
$CLI_EXE \
    --sn platform \
    --op GetReward1 \
    --namespace $TEST_NAMESPACE \
    --rewardId 'TUohtqJU' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 274 PublicListStores
$CLI_EXE \
    --sn platform \
    --op PublicListStores \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListStores'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 275 PublicExistsAnyMyActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyMyActiveEntitlement \
    --namespace $TEST_NAMESPACE \
    --appIds '["SbFzSBVZ"]' \
    --itemIds '["mKweECuD"]' \
    --skus '["3sZMCE8d"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicExistsAnyMyActiveEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 276 PublicGetMyAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyAppEntitlementOwnershipByAppId \
    --namespace $TEST_NAMESPACE \
    --appId 'ESgloJK7' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyAppEntitlementOwnershipByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 277 PublicGetMyEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipByItemId \
    --namespace $TEST_NAMESPACE \
    --entitlementClazz 'CODE' \
    --itemId 'M6Je8rVs' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyEntitlementOwnershipByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 278 PublicGetMyEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetMyEntitlementOwnershipBySku \
    --namespace $TEST_NAMESPACE \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'MiXvUICp' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 279 PublicGetEntitlementOwnershipToken
$CLI_EXE \
    --sn platform \
    --op PublicGetEntitlementOwnershipToken \
    --namespace $TEST_NAMESPACE \
    --appIds '["XJUBosGv"]' \
    --itemIds '["2E5Ud8R4"]' \
    --skus '["0Via1HQG"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetEntitlementOwnershipToken'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 280 PublicGetMyWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetMyWallet \
    --currencyCode 'yTJx6eE6' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 281 PublicSyncPsnDlcInventory
# body param: body
echo '{"serviceLabel": 51}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSyncPsnDlcInventory \
    --namespace $TEST_NAMESPACE \
    --userId '1d23WGf1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSyncPsnDlcInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 282 SyncSteamDLC
# body param: body
echo '{"appId": "zfjnOgbD", "steamId": "HxFOx68r"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamDLC \
    --namespace $TEST_NAMESPACE \
    --userId 'BOBVv5za' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncSteamDLC'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 283 SyncXboxDLC
# body param: body
echo '{"xstsToken": "3wZKkkBX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxDLC \
    --namespace $TEST_NAMESPACE \
    --userId 'OpjG8DMY' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncXboxDLC'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 284 PublicQueryUserEntitlements
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlements \
    --namespace $TEST_NAMESPACE \
    --userId 'I7aCPVOX' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'SUBSCRIPTION' \
    --entitlementName 'lMa4Gckk' \
    --itemId '["tYeg98gT"]' \
    --limit '73' \
    --offset '65' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 285 PublicGetUserAppEntitlementByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'ckRJxWrH' \
    --appId 'hn4YOK6M' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserAppEntitlementByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 286 PublicQueryUserEntitlementsByAppType
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserEntitlementsByAppType \
    --namespace $TEST_NAMESPACE \
    --userId 'nfeVldbE' \
    --limit '26' \
    --offset '75' \
    --appType 'SOFTWARE' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserEntitlementsByAppType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 287 PublicGetUserEntitlementByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'yOB0kZoe' \
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId 'IWku1PBe' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 288 PublicGetUserEntitlementBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'ZzonuQzx' \
    --entitlementClazz 'SUBSCRIPTION' \
    --sku 'ODS8nTAo' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 289 PublicExistsAnyUserActiveEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicExistsAnyUserActiveEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'uPR62RXc' \
    --appIds '["ekOPk51s"]' \
    --itemIds '["Yy0IuLJP"]' \
    --skus '["PNclQgSB"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicExistsAnyUserActiveEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 290 PublicGetUserAppEntitlementOwnershipByAppId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserAppEntitlementOwnershipByAppId \
    --namespace $TEST_NAMESPACE \
    --userId 'JrjtMtdo' \
    --appId 'v0qluMZw' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserAppEntitlementOwnershipByAppId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 291 PublicGetUserEntitlementOwnershipByItemId
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'WFQcBAVM' \
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId 'vAvzLjQS' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementOwnershipByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 292 PublicGetUserEntitlementOwnershipBySku
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlementOwnershipBySku \
    --namespace $TEST_NAMESPACE \
    --userId 'HwPO48On' \
    --entitlementClazz 'APP' \
    --sku 'CbMHOoAw' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 293 PublicGetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlement \
    --entitlementId 'KRyMNCSp' \
    --namespace $TEST_NAMESPACE \
    --userId 'YGZ9RvQU' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 294 PublicConsumeUserEntitlement
# body param: body
echo '{"useCount": 98}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicConsumeUserEntitlement \
    --entitlementId 'cWQhh5iG' \
    --namespace $TEST_NAMESPACE \
    --userId 'hyoneUWb' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicConsumeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 295 PublicRedeemCode
# body param: body
echo '{"code": "Dyvutndg", "language": "icjax7ON", "region": "nA3dvJOo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicRedeemCode \
    --namespace $TEST_NAMESPACE \
    --userId 'cdyisYR5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicRedeemCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 296 PublicFulfillAppleIAPItem
# body param: body
echo '{"excludeOldTransactions": true, "language": "hrcsZyvb", "productId": "LMUUSwl9", "receiptData": "luLGR0MZ", "region": "KdWXP7dH", "transactionId": "vzRSx4xn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillAppleIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'EwseCMo1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicFulfillAppleIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 297 SyncEpicGamesInventory
# body param: body
echo '{"epicGamesJwtToken": "qFRoqmJU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncEpicGamesInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'LDdelYwV' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncEpicGamesInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 298 PublicFulfillGoogleIAPItem
# body param: body
echo '{"language": "2DRZfSBn", "orderId": "T2Vlyq5V", "packageName": "Wu4pLxrq", "productId": "fJr2pN0C", "purchaseTime": 17, "purchaseToken": "Q7TyPiYI", "region": "IigSnJZP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillGoogleIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'ieAS6Ozt' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicFulfillGoogleIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 299 PublicReconcilePlayStationStore
# body param: body
echo '{"currencyCode": "9Y76Cmi2", "price": 0.3653036476093975, "productId": "66qCLHLy", "serviceLabel": 47}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicReconcilePlayStationStore \
    --namespace $TEST_NAMESPACE \
    --userId 'hceLzV7i' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicReconcilePlayStationStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 300 SyncStadiaEntitlement
# body param: body
echo '{"appId": "L4mwueWq", "language": "EFljovji", "region": "Fds9U3Q4", "stadiaPlayerId": "FL9FKhfT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncStadiaEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'M3X1GHB9' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncStadiaEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 301 SyncSteamInventory
# body param: body
echo '{"appId": "2JFCpi6P", "currencyCode": "SpyvcTnM", "language": "qT7mELuc", "price": 0.40843844032299714, "productId": "TafjIfXC", "region": "WzatjGv4", "steamId": "UVj072ER"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'IdIjnEdK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncSteamInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 302 SyncTwitchDropsEntitlement
# body param: body
echo '{"gameId": "EgYrC08a", "language": "2gefHyUL", "region": "faLdtBzf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncTwitchDropsEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'i8aWrMf1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncTwitchDropsEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 303 SyncXboxInventory
# body param: body
echo '{"currencyCode": "NWlgliWd", "price": 0.0942740987948607, "productId": "wepIgKh0", "xstsToken": "HKAG34nO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'fcgWxTfK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncXboxInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 304 PublicQueryUserOrders
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserOrders \
    --namespace $TEST_NAMESPACE \
    --userId 'egxR0U2C' \
    --itemId 'ExNlVZ2R' \
    --limit '64' \
    --offset '42' \
    --status 'CLOSED' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 305 PublicCreateUserOrder
# body param: body
echo '{"currencyCode": "9j2WLb2C", "discountedPrice": 88, "ext": {"AgZdAFdn": {}}, "itemId": "SJJFXEhP", "language": "7ZQQTrpC", "price": 63, "quantity": 70, "region": "6RUKJh4n", "returnUrl": "jvE58hP4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCreateUserOrder \
    --namespace $TEST_NAMESPACE \
    --userId 'ov9Lr3Ek' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 306 PublicGetUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'TSLIshqS' \
    --userId 'b4fuvTw4' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 307 PublicCancelUserOrder
$CLI_EXE \
    --sn platform \
    --op PublicCancelUserOrder \
    --namespace $TEST_NAMESPACE \
    --orderNo 'H9hubYPI' \
    --userId '2vvuiybj' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCancelUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 308 PublicGetUserOrderHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserOrderHistories \
    --namespace $TEST_NAMESPACE \
    --orderNo 'U8tFnbsY' \
    --userId 'zIcstOus' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserOrderHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 309 PublicDownloadUserOrderReceipt
$CLI_EXE \
    --sn platform \
    --op PublicDownloadUserOrderReceipt \
    --namespace $TEST_NAMESPACE \
    --orderNo '7bRp1CdG' \
    --userId '3Hblu98Y' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDownloadUserOrderReceipt'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 310 PublicGetPaymentAccounts
$CLI_EXE \
    --sn platform \
    --op PublicGetPaymentAccounts \
    --namespace $TEST_NAMESPACE \
    --userId 'QD4Otx1G' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPaymentAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 311 PublicDeletePaymentAccount
$CLI_EXE \
    --sn platform \
    --op PublicDeletePaymentAccount \
    --id 'ZEBw1Jkh' \
    --namespace $TEST_NAMESPACE \
    --type 'card' \
    --userId 'dhy68612' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeletePaymentAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 312 PublicQueryUserSubscriptions
$CLI_EXE \
    --sn platform \
    --op PublicQueryUserSubscriptions \
    --namespace $TEST_NAMESPACE \
    --userId '1Qm42I9D' \
    --chargeStatus 'CHARGED' \
    --itemId 'ReFeyLtN' \
    --limit '81' \
    --offset '38' \
    --sku '0SmGDzo1' \
    --status 'ACTIVE' \
    --subscribedBy 'USER' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserSubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 313 PublicSubscribeSubscription
# body param: body
echo '{"currencyCode": "uZYxY8RW", "itemId": "giwIjK2g", "language": "9kYwlqrD", "region": "fyjHcFVC", "returnUrl": "YsZcY5pJ", "source": "fXaaUskh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSubscribeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'gMZlpxmj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSubscribeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 314 PublicCheckUserSubscriptionSubscribableByItemId
$CLI_EXE \
    --sn platform \
    --op PublicCheckUserSubscriptionSubscribableByItemId \
    --namespace $TEST_NAMESPACE \
    --userId 'm9f23Llr' \
    --itemId '7WKchQrd' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCheckUserSubscriptionSubscribableByItemId'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 315 PublicGetUserSubscription
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'RvUcqAHe' \
    --userId 'lKgovowP' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 316 PublicChangeSubscriptionBillingAccount
$CLI_EXE \
    --sn platform \
    --op PublicChangeSubscriptionBillingAccount \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'UtF6DLev' \
    --userId 'fnhWi0LS' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicChangeSubscriptionBillingAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 317 PublicCancelSubscription
# body param: body
echo '{"immediate": true, "reason": "WcjaWpr1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCancelSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'gk6Cb5tA' \
    --userId 'BJO3orPf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCancelSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 318 PublicGetUserSubscriptionBillingHistories
$CLI_EXE \
    --sn platform \
    --op PublicGetUserSubscriptionBillingHistories \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'izPDwbyf' \
    --userId 'oC6otIQ8' \
    --excludeFree 'True' \
    --limit '44' \
    --offset '77' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSubscriptionBillingHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 319 PublicGetWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetWallet \
    --currencyCode '4gUVBsp0' \
    --namespace $TEST_NAMESPACE \
    --userId 'Jn3BcxN6' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 320 PublicListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op PublicListUserWalletTransactions \
    --currencyCode 'VmGGpzEM' \
    --namespace $TEST_NAMESPACE \
    --userId 'vcnJGqj2' \
    --limit '65' \
    --offset '98' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserWalletTransactions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT