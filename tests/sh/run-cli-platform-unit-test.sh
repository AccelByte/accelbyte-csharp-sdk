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
echo '{"data": [{"itemIdentity": "g7rYaEuN", "itemIdentityType": "ITEM_SKU", "platformProductIdMap": {"yPoQ0oHY": "XUQdtIkA"}}]}' > $TEMP_JSON_INPUT
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
echo '{"environment": "kltd1zQB"}' > $TEMP_JSON_INPUT
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
echo '{"publisherAuthenticationKey": "zzC6ldKr"}' > $TEMP_JSON_INPUT
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
echo '{"clientId": "iI6lTRbc", "clientSecret": "1Z1HJHzl", "organizationId": "323Ynwf5"}' > $TEMP_JSON_INPUT
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
echo '{"relyingPartyCert": "PvGejCDg"}' > $TEMP_JSON_INPUT
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
    --password 'Ar1pXDcs' \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateXblBPCertFile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 SyncInGameItem
# body param: body
echo '{"categoryPath": "HnobnaYx", "targetItemId": "Gh3FovBn", "targetNamespace": "r5VUOHGq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncInGameItem \
    --namespace $TEST_NAMESPACE \
    --storeId 'EcuJYo3Y' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncInGameItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 CreateItem
# body param: body
echo '{"appId": "fMDw4PaB", "appType": "DLC", "baseAppId": "FXorxY0a", "boothName": "hG5AgHrE", "categoryPath": "98qQTSXh", "clazz": "1W7MnK2i", "displayOrder": 60, "entitlementType": "DURABLE", "ext": {"y255awvu": {}}, "features": ["lbNGSAje"], "images": [{"as": "iiANETlk", "caption": "ncKPmri3", "height": 77, "imageUrl": "Y2aVCNUJ", "smallImageUrl": "gcpAYbj0", "width": 11}], "itemIds": ["idlWPSAI"], "itemQty": {"jaw5HSyD": 37}, "itemType": "CODE", "listable": true, "localizations": {"AxUd1bmV": {"description": "SM44scgN", "localExt": {"AZf7a3R9": {}}, "longDescription": "rIVTDDXZ", "title": "1fahMp68"}}, "maxCount": 70, "maxCountPerUser": 43, "name": "5wQ3hbDl", "purchasable": false, "recurring": {"cycle": "QUARTERLY", "fixedFreeDays": 0, "fixedTrialCycles": 61, "graceDays": 47}, "regionData": {"mVbXDomW": [{"currencyCode": "yrFZZdM0", "currencyNamespace": "0sSdUypO", "currencyType": "VIRTUAL", "discountAmount": 28, "discountExpireAt": "1990-06-15T00:00:00Z", "discountPercentage": 68, "discountPurchaseAt": "1990-01-16T00:00:00Z", "discountedPrice": 86, "expireAt": "1984-12-09T00:00:00Z", "price": 46, "purchaseAt": "1986-05-23T00:00:00Z", "trialPrice": 56}]}, "seasonType": "TIER", "sku": "0koUsUcG", "stackable": false, "status": "ACTIVE", "tags": ["tfyuPNb5"], "targetCurrencyCode": "exiRtR1Q", "targetNamespace": "e0mxLnvZ", "thumbnailUrl": "EG2biyKS", "useCount": 43}' > $TEMP_JSON_INPUT
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
echo '{"currencyCode": "dRQmMvxB", "currencyNamespace": "jpVFnEgs", "customParameters": {"ovZbx4UF": {}}, "description": "3pYMzeFc", "extOrderNo": "sBLCwhTS", "extUserId": "tBJZGkIS", "itemType": "APP", "language": "hX_QY", "metadata": {"sdpW3XyQ": "QmftmA5H"}, "notifyUrl": "UHioxzVh", "omitNotification": true, "price": 67, "recurringPaymentOrderNo": "c1rBqAXu", "region": "d4JQOWZB", "returnUrl": "zUvNkxTU", "sandbox": true, "sku": "I2XhbYwT", "subscriptionId": "xVSXpJb2", "targetNamespace": "JSuHHCRP", "targetUserId": "9xW9VeYJ", "title": "CDikIapu"}' > $TEMP_JSON_INPUT
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
    --extTxId 'mYwbaGfs' \
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
    --paymentOrderNo 'JTgobWG9' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 115 ChargePaymentOrder
# body param: body
echo '{"extTxId": "3dH2MCGv", "paymentMethod": "ohrdRx6l", "paymentProvider": "ADYEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ChargePaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo '7UcTmEwe' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ChargePaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 116 RefundPaymentOrderByDedicated
# body param: body
echo '{"description": "9mWH3XVf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundPaymentOrderByDedicated \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'yejgTi2E' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundPaymentOrderByDedicated'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 117 SimulatePaymentOrderNotification
# body param: body
echo '{"amount": 95, "currencyCode": "nFsoXaRE", "notifyType": "CHARGE", "paymentProvider": "STRIPE", "salesTax": 36, "vat": 83}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SimulatePaymentOrderNotification \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'oXUApZEP' \
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
    --paymentOrderNo 'fic39c2q' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentOrderChargeStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 119 CreateReward
# body param: body
echo '{"description": "3a6kRuGq", "eventTopic": "HcwZVjAQ", "maxAwarded": 56, "maxAwardedPerUser": 21, "namespaceExpression": "WjE3gJ6A", "rewardCode": "wW953NlF", "rewardConditions": [{"condition": "HpDCFut3", "conditionName": "9Jhj3lmf", "eventName": "XJxKJNRD", "rewardItems": [{"duration": 73, "itemId": "umRjk3wZ", "quantity": 100}]}], "userIdExpression": "Vb3SFssn"}' > $TEMP_JSON_INPUT
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
    --eventTopic 'x4JYy1kX' \
    --limit '1' \
    --offset '21' \
    --sortBy 'VQoG01up' \
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
    --replaceExisting 'True' \
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
    --rewardId 'R2PZ0E2o' \
    >$TEMP_FILE 2>&1
update_status $? 'GetReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 124 UpdateReward
# body param: body
echo '{"description": "WaCZcCX2", "eventTopic": "iLiQGTL6", "maxAwarded": 81, "maxAwardedPerUser": 19, "namespaceExpression": "LlXUV78i", "rewardCode": "8csQIO0D", "rewardConditions": [{"condition": "RagPXzsB", "conditionName": "fUhCoGFg", "eventName": "irdMLexA", "rewardItems": [{"duration": 51, "itemId": "JvQd2cOV", "quantity": 98}]}], "userIdExpression": "FoiaYaSo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateReward \
    --namespace $TEST_NAMESPACE \
    --rewardId 'og7pSsQh' \
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
    --rewardId 'vXbGvqRV' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteReward'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 126 CheckEventCondition
# body param: body
echo '{"payload": {"SSwvlRzd": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CheckEventCondition \
    --namespace $TEST_NAMESPACE \
    --rewardId 'NXrfoKVR' \
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
echo '{"defaultLanguage": "4HhlPEfS", "defaultRegion": "M2K29oqf", "description": "ZssibgoT", "supportedLanguages": ["FQAmIZiT"], "supportedRegions": ["SstC2yOu"], "title": "mzHMhXys"}' > $TEMP_JSON_INPUT
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
    --storeId 'ws3Fwnu7' \
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
    --storeId 'OX9FZvwJ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 UpdateStore
# body param: body
echo '{"defaultLanguage": "8OQFuCH6", "defaultRegion": "8pTmT632", "description": "j8QfhNDT", "supportedLanguages": ["Hb8lFvBo"], "supportedRegions": ["lf9Pdi5B"], "title": "LCsT8g72"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStore \
    --namespace $TEST_NAMESPACE \
    --storeId 'thhduZnN' \
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
    --storeId 'j9cRNlTB' \
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
    --storeId 'xl3nKj6B' \
    --targetStoreId '4ffgtxiP' \
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
    --storeId 'LdV0odbf' \
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
    --itemId 'st4NDIBQ' \
    --limit '23' \
    --offset '92' \
    --sku 'ryryOWzh' \
    --status 'ACTIVE' \
    --subscribedBy 'USER' \
    --userId 'mSVFhAlE' \
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
    --subscriptionId 'acAAoAfs' \
    >$TEMP_FILE 2>&1
update_status $? 'RecurringChargeSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 141 GetTicketDynamic
$CLI_EXE \
    --sn platform \
    --op GetTicketDynamic \
    --boothName 'uMB4W3HI' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTicketDynamic'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 142 DecreaseTicketSale
# body param: body
echo '{"orderNo": "cvS0AL4t"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DecreaseTicketSale \
    --boothName 'YCwCdCig' \
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
    --boothName 'cxlbl30h' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTicketBoothID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 144 IncreaseTicketSale
# body param: body
echo '{"count": 67, "orderNo": "HEjMI4Lc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op IncreaseTicketSale \
    --boothName 'gkyDsccF' \
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
    --userId 'dvzoafML' \
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
    --userId 'oraVj5Ri' \
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
    --userId 'DHvo7Kep' \
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
    --userId 'gBTMRiEd' \
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
    --userId 'eeQwLUW0' \
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
    --userId 'VLupH83A' \
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
    --userId 'uxFEFRDT' \
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
    --userId 't2mauywa' \
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
    --userId 'KEsPBAM1' \
    --activeOnly 'False' \
    --appType 'GAME' \
    --entitlementClazz 'CODE' \
    --entitlementName 'NqlmpKGh' \
    --itemId '["vTKiXeZe"]' \
    --limit '30' \
    --offset '24' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 154 GrantUserEntitlement
# body param: body
echo '[{"endDate": "1980-09-10T00:00:00Z", "grantedCode": "1wKhQ4Hj", "itemId": "EcagyjZI", "itemNamespace": "TRuoWjIC", "language": "cn-vNIq", "quantity": 12, "region": "DJE12W5e", "source": "ACHIEVEMENT", "startDate": "1978-04-05T00:00:00Z", "storeId": "rOXwASJ1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantUserEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'PtQuxOJQ' \
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
    --userId 'Kgor2UMJ' \
    --activeOnly 'True' \
    --appId '4EJ9GccY' \
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
    --userId 'TYxPTgpB' \
    --activeOnly 'True' \
    --limit '93' \
    --offset '43' \
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
    --userId 'ANjquBEH' \
    --activeOnly 'False' \
    --entitlementClazz 'APP' \
    --itemId 'Qpz0dfiu' \
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
    --userId 'v051lkPC' \
    --activeOnly 'False' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'jvFvhZdw' \
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
    --userId 'i1Ti6V2u' \
    --appIds '["WuCsB8Fb"]' \
    --itemIds '["VDwhpNCL"]' \
    --skus '["l2bgIc1y"]' \
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
    --userId '49bqpbfy' \
    --itemIds '["ytwm6jQJ"]' \
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
    --userId 'pfOIKCeg' \
    --appId 'UjKQRjoy' \
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
    --userId 'n3bGyFGw' \
    --entitlementClazz 'APP' \
    --itemId 'AylTi4qP' \
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
    --userId 'F190sf2Z' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'Pi5hI4k3' \
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
    --userId 'KwV7P8R9' \
    --entitlementIds 't4dBRpBp' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserEntitlements'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 165 GetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlement \
    --entitlementId '4noj3J79' \
    --namespace $TEST_NAMESPACE \
    --userId 'DD3bAZF4' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 UpdateUserEntitlement
# body param: body
echo '{"endDate": "1977-08-08T00:00:00Z", "nullFieldList": ["uNxISmVG"], "startDate": "1994-07-20T00:00:00Z", "status": "CONSUMED", "useCount": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserEntitlement \
    --entitlementId '8wegrDo6' \
    --namespace $TEST_NAMESPACE \
    --userId 'OmeKL7GP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 ConsumeUserEntitlement
# body param: body
echo '{"useCount": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ConsumeUserEntitlement \
    --entitlementId 'I9uWOFTW' \
    --namespace $TEST_NAMESPACE \
    --userId 'dRrL6yNm' \
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
    --entitlementId 'v8k1w19J' \
    --namespace $TEST_NAMESPACE \
    --userId 'sHSqOByh' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 EnableUserEntitlement
$CLI_EXE \
    --sn platform \
    --op EnableUserEntitlement \
    --entitlementId '4hhkcO6J' \
    --namespace $TEST_NAMESPACE \
    --userId '7jSvYd4J' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 GetUserEntitlementHistories
$CLI_EXE \
    --sn platform \
    --op GetUserEntitlementHistories \
    --entitlementId '5c6ayFnS' \
    --namespace $TEST_NAMESPACE \
    --userId 'rfmObFTU' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserEntitlementHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 171 RevokeUserEntitlement
$CLI_EXE \
    --sn platform \
    --op RevokeUserEntitlement \
    --entitlementId 'BRRDGCRQ' \
    --namespace $TEST_NAMESPACE \
    --userId 'tMc3an8Z' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 172 FulfillItem
# body param: body
echo '{"duration": 28, "endDate": "1982-10-27T00:00:00Z", "itemId": "wXHS1oUz", "itemSku": "DdDcZ0Rj", "language": "3YM1fz9C", "order": {"currency": {"currencyCode": "jqtqeiyD", "currencySymbol": "CK7C3u5G", "currencyType": "REAL", "decimals": 83, "namespace": "bmi5KiFD"}, "ext": {"VpfvR2Wl": {}}, "free": false}, "orderNo": "ShagpvFu", "quantity": 41, "region": "45zsrSpv", "source": "OTHER", "startDate": "1989-06-16T00:00:00Z", "storeId": "Qw3sPxFu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillItem \
    --namespace $TEST_NAMESPACE \
    --userId '8LQGQCAj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'FulfillItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 RedeemCode
# body param: body
echo '{"code": "6O7ivhNI", "language": "vt_tlWz", "region": "AJ6ZBTHY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RedeemCode \
    --namespace $TEST_NAMESPACE \
    --userId 'jGbVtzsB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RedeemCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 174 FulfillRewards
# body param: body
echo '{"rewards": [{"currency": {"currencyCode": "TCOWEnaL", "namespace": "zHuYKrr8"}, "item": {"itemId": "9z0RkL93", "itemSku": "2B7thDQ3", "itemType": "hfVnPK8i"}, "quantity": 72, "type": "ITEM"}], "source": "PURCHASE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op FulfillRewards \
    --namespace $TEST_NAMESPACE \
    --userId 'ZPnXwGS9' \
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
    --userId 'fAlxtjeZ' \
    --endTime 'UrqmIc7E' \
    --limit '23' \
    --offset '77' \
    --productId 'EAvaPTww' \
    --startTime 'JrG06Mtc' \
    --status 'FULFILLED' \
    --type 'STADIA' \
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
    --userId '8DQxcoQB' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryAllUserIAPOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 177 MockFulfillIAPItem
# body param: body
echo '{"itemIdentityType": "ITEM_ID", "language": "dMu", "productId": "Xi2LgkAL", "region": "Gxw6qgvI", "type": "EPICGAMES"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op MockFulfillIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'e6rDGbFN' \
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
    --userId 'zsyQVqvS' \
    --itemId 'gtpUVddL' \
    --limit '52' \
    --offset '4' \
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
    --userId 'muKlGHZd' \
    --itemId 'wwo66H6Q' \
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
    --orderNo 'OfYztHev' \
    --userId '8RX4MWRF' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 UpdateUserOrderStatus
# body param: body
echo '{"status": "CHARGEBACK", "statusReason": "lN13WW7U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateUserOrderStatus \
    --namespace $TEST_NAMESPACE \
    --orderNo '0sRVCnzR' \
    --userId 'xni0Kq9Z' \
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
    --orderNo 'l2b7ChMC' \
    --userId 'xb6xdzl2' \
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
    --orderNo 'OYVRJNC7' \
    --userId 'EruVITun' \
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
    --orderNo 'bxaOWNrM' \
    --userId 'kfALUDrR' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserOrderHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 ProcessUserOrderNotification
# body param: body
echo '{"additionalData": {"cardSummary": "6M3vzu84"}, "authorisedTime": "1993-11-07T00:00:00Z", "chargebackReversedTime": "1992-08-14T00:00:00Z", "chargebackTime": "1996-09-30T00:00:00Z", "chargedTime": "1978-10-21T00:00:00Z", "createdTime": "1986-06-15T00:00:00Z", "currency": {"currencyCode": "pQOjjkIY", "currencySymbol": "AQEcxGPT", "currencyType": "REAL", "decimals": 27, "namespace": "2NJ9gHmB"}, "customParameters": {"0vflV2Vp": {}}, "extOrderNo": "tGYAEziS", "extTxId": "thhR9WLi", "extUserId": "VTXHhZmB", "issuedAt": "1983-07-03T00:00:00Z", "metadata": {"lmWBLyhg": "ZsJoonMp"}, "namespace": "OQ9Jmh8w", "nonceStr": "wQ28fmxM", "paymentMethod": "FN8d9fdH", "paymentMethodFee": 52, "paymentOrderNo": "Hphhby7h", "paymentProvider": "WALLET", "paymentProviderFee": 72, "paymentStationUrl": "eIkY4Fc8", "price": 0, "refundedTime": "1980-10-13T00:00:00Z", "salesTax": 70, "sandbox": false, "sku": "bk9YdEm0", "status": "CHARGED", "statusReason": "9Rjjnkhw", "subscriptionId": "q75VqZH8", "subtotalPrice": 67, "targetNamespace": "Uq92UFWF", "targetUserId": "C8oFuU2O", "tax": 62, "totalPrice": 70, "totalTax": 45, "txEndTime": "1997-09-17T00:00:00Z", "type": "bioiiaZ8", "userId": "Uc2rWpzX", "vat": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserOrderNotification \
    --namespace $TEST_NAMESPACE \
    --orderNo 'goBhruuv' \
    --userId 'EzpyRiFs' \
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
    --orderNo '63b4Pru2' \
    --userId 'pWiVBYjK' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadUserOrderReceipt'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 CreateUserPaymentOrder
# body param: body
echo '{"currencyCode": "I1ZlcKXB", "currencyNamespace": "XcPAsjW7", "customParameters": {"zBxpVc8s": {}}, "description": "vjiFtRe8", "extOrderNo": "k7amplfh", "extUserId": "uHropVxI", "itemType": "SUBSCRIPTION", "language": "JSy-TApP-vX", "metadata": {"gHJLBm3b": "gRvSUyOg"}, "notifyUrl": "yu9dhxao", "omitNotification": false, "price": 90, "recurringPaymentOrderNo": "jMYGTMXy", "region": "4ypcIN4u", "returnUrl": "UIzvUI5b", "sandbox": true, "sku": "xS2yBTD8", "subscriptionId": "uNeauLeX", "title": "NgQBnXZk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreateUserPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --userId 'Q06LUEgy' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 RefundUserPaymentOrder
# body param: body
echo '{"description": "yiBeJARF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op RefundUserPaymentOrder \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'VbUvLNtD' \
    --userId 'dAntKI6v' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RefundUserPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 ApplyUserRedemption
# body param: body
echo '{"code": "d3QdSHH2", "orderNo": "AvosR9Nk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ApplyUserRedemption \
    --namespace $TEST_NAMESPACE \
    --userId '0JJYXMRc' \
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
    --userId 'Qg1LwgzW' \
    --chargeStatus 'NEVER' \
    --itemId '5q2i8ntD' \
    --limit '7' \
    --offset '63' \
    --sku 'SOEIqFse' \
    --status 'CANCELLED' \
    --subscribedBy 'PLATFORM' \
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
    --userId 'rqjWTbUa' \
    --excludeSystem 'True' \
    --limit '68' \
    --offset '82' \
    --subscriptionId '8oO0z1Vf' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscriptionActivities'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 192 PlatformSubscribeSubscription
# body param: body
echo '{"grantDays": 11, "itemId": "DHyFM7T2", "language": "H6g4jbxD", "reason": "DxngEqsA", "region": "bWEfTc2n", "source": "SU2SijyS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PlatformSubscribeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'pnqX01uD' \
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
    --userId 'kQ1tv3iM' \
    --itemId 'MW8aqVbw' \
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
    --subscriptionId 'ArhGSaFx' \
    --userId 'yAsPnfbH' \
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
    --subscriptionId 'X5TpIV6e' \
    --userId '7dMKaAr2' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 196 CancelSubscription
# body param: body
echo '{"immediate": false, "reason": "tP8qxtNo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CancelSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId '76oPRuvx' \
    --userId 'UGNJvDRu' \
    --force 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CancelSubscription'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 197 GrantDaysToSubscription
# body param: body
echo '{"grantDays": 51, "reason": "yWeusWdE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op GrantDaysToSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'JnqhXgmV' \
    --userId 'QHoZNPy0' \
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
    --subscriptionId 'Wqu4qtxT' \
    --userId 'yrvNhypN' \
    --excludeFree 'False' \
    --limit '28' \
    --offset '34' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserSubscriptionBillingHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 ProcessUserSubscriptionNotification
# body param: body
echo '{"additionalData": {"cardSummary": "jcAKSuvg"}, "authorisedTime": "1994-03-14T00:00:00Z", "chargebackReversedTime": "1972-11-01T00:00:00Z", "chargebackTime": "1977-03-16T00:00:00Z", "chargedTime": "1981-07-12T00:00:00Z", "createdTime": "1991-06-12T00:00:00Z", "currency": {"currencyCode": "1OLRUrZ6", "currencySymbol": "vwIqGnoq", "currencyType": "VIRTUAL", "decimals": 7, "namespace": "7bvO6Xg2"}, "customParameters": {"xx5vZXC9": {}}, "extOrderNo": "YsEXEe9i", "extTxId": "C3Hp95At", "extUserId": "WE8drEip", "issuedAt": "1995-02-12T00:00:00Z", "metadata": {"ocCS9nGM": "6fYF1o77"}, "namespace": "M1VVgHHe", "nonceStr": "L0flEPUx", "paymentMethod": "HPhE4YwC", "paymentMethodFee": 87, "paymentOrderNo": "BGAR8TtZ", "paymentProvider": "ADYEN", "paymentProviderFee": 58, "paymentStationUrl": "IjOfYlF5", "price": 19, "refundedTime": "1988-12-21T00:00:00Z", "salesTax": 18, "sandbox": true, "sku": "wqLpFnnN", "status": "REQUEST_FOR_INFORMATION", "statusReason": "dTcPOtfk", "subscriptionId": "EyLh6l74", "subtotalPrice": 52, "targetNamespace": "QY5ulxH0", "targetUserId": "lioSoooP", "tax": 15, "totalPrice": 85, "totalTax": 47, "txEndTime": "1976-10-27T00:00:00Z", "type": "Me7ma8Qc", "userId": "9aGN5UJP", "vat": 75}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op ProcessUserSubscriptionNotification \
    --namespace $TEST_NAMESPACE \
    --subscriptionId 'chiivOQd' \
    --userId 'Byk3mWQ9' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ProcessUserSubscriptionNotification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 200 AcquireUserTicket
# body param: body
echo '{"count": 55, "orderNo": "xbP1VP8r"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op AcquireUserTicket \
    --boothName 'KuVwTTGS' \
    --namespace $TEST_NAMESPACE \
    --userId 'X5rG8ymO' \
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
    --currencyCode '7ml7SCwM' \
    --namespace $TEST_NAMESPACE \
    --userId '6RZNerJQ' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 202 CreditUserWallet
# body param: body
echo '{"amount": 34, "reason": "oYUkvHx2", "source": "PURCHASE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op CreditUserWallet \
    --currencyCode 'AjFF0BBG' \
    --namespace $TEST_NAMESPACE \
    --userId 'wZ7XWhdo' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreditUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 PayWithUserWallet
# body param: body
echo '{"amount": 100}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PayWithUserWallet \
    --currencyCode 'x127YYBo' \
    --namespace $TEST_NAMESPACE \
    --userId 'xSCFsBbZ' \
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
    --userId 'L16L2P8e' \
    --walletId 'NmOi4OPQ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 DebitUserWallet
# body param: body
echo '{"amount": 60, "reason": "V8XzBcAn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op DebitUserWallet \
    --namespace $TEST_NAMESPACE \
    --userId 'iVuoW6wP' \
    --walletId 'QlP1zgkx' \
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
    --userId 'v25ZHaR8' \
    --walletId 'vsMhIfog' \
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
    --userId 'RB8XeZhA' \
    --walletId 'M4MAL57r' \
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
    --userId 'iU2QbQFR' \
    --walletId 'CXEWG8Sx' \
    --limit '38' \
    --offset '43' \
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
    --currencyCode 'tTkIWbiH' \
    --limit '91' \
    --offset '93' \
    --userId 'DDL4yzTn' \
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
    --walletId 'Qv0e99zY' \
    >$TEMP_FILE 2>&1
update_status $? 'GetWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 211 SyncOrders
$CLI_EXE \
    --sn platform \
    --op SyncOrders \
    --nextEvaluatedKey 'NkH6PuvE' \
    --end 'RGP7fmyd' \
    --start '8aJkJYGK' \
    >$TEMP_FILE 2>&1
update_status $? 'SyncOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 212 TestAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["f4wBCsCL"], "apiKey": "rfH6V3fT", "authoriseAsCapture": false, "blockedPaymentMethods": ["r0UZS96w"], "clientKey": "D9rgdYvy", "dropInSettings": "fGQvBMJG", "liveEndpointUrlPrefix": "a0RWFilS", "merchantAccount": "DbJxY0YR", "notificationHmacKey": "9wXVRz5a", "notificationPassword": "yquoA8CG", "notificationUsername": "DmAN0yX8", "returnUrl": "xu01b0bU", "settings": "qDheu9id"}' > $TEMP_JSON_INPUT
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

#- 213 TestAliPayConfig
# body param: body
echo '{"appId": "Q8V1CaeT", "privateKey": "74VP6Kqp", "publicKey": "Z2JC53CG", "returnUrl": "QXzjGEvv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestAliPayConfig \
    --sandbox 'True' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'TestAliPayConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 214 TestCheckoutConfig
# body param: body
echo '{"publicKey": "9VR6Qqao", "secretKey": "AupKSo0R"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op TestCheckoutConfig \
    --sandbox 'True' \
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
    --namespace_ 'XML3VcaD' \
    --region 'WEzPCi2t' \
    >$TEMP_FILE 2>&1
update_status $? 'DebugMatchedPaymentMerchantConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 216 TestPayPalConfig
# body param: body
echo '{"clientID": "WPzhrjLF", "clientSecret": "LLuGlXIn", "returnUrl": "Vkn9ojnp", "webHookId": "piU7rYU0"}' > $TEMP_JSON_INPUT
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
echo '{"allowedPaymentMethodTypes": ["1JzPmaRk"], "publishableKey": "eYX8U71w", "secretKey": "09mTap7y", "webhookSecret": "90X88qbd"}' > $TEMP_JSON_INPUT
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
echo '{"appId": "RMUmqoGB", "key": "qBaxLbpD", "mchid": "ekuIzTOD", "returnUrl": "QZkNg9Xs"}' > $TEMP_JSON_INPUT
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
echo '{"apiKey": "cMV2DnOo", "flowCompletionUrl": "9PaoBSJJ", "merchantId": 64, "projectId": 12, "projectSecretKey": "g8epTUeh"}' > $TEMP_JSON_INPUT
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
    --id 'n6IzqXst' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPaymentMerchantConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 221 UpdateAdyenConfig
# body param: body
echo '{"allowedPaymentMethods": ["eu4pU694"], "apiKey": "ex0bxtkv", "authoriseAsCapture": true, "blockedPaymentMethods": ["bCB52HlT"], "clientKey": "eFVmpXnr", "dropInSettings": "WDCij8S7", "liveEndpointUrlPrefix": "3sQDNy12", "merchantAccount": "G1PiTJwx", "notificationHmacKey": "V0rwMM7H", "notificationPassword": "sMJnUBZ6", "notificationUsername": "Gyhfcrdd", "returnUrl": "eIOhxQMI", "settings": "mB13f1ob"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAdyenConfig \
    --id 'TKrwFXC2' \
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
    --id 'XEIOAJh6' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestAdyenConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 223 UpdateAliPayConfig
# body param: body
echo '{"appId": "HWdmibqD", "privateKey": "eNic565h", "publicKey": "vy1VY236", "returnUrl": "5rUHkxww"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateAliPayConfig \
    --id 'pNwFJyOB' \
    --sandbox 'False' \
    --validate 'False' \
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
    --id 'glT04uRm' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestAliPayConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 225 UpdateCheckoutConfig
# body param: body
echo '{"publicKey": "eOhTeibS", "secretKey": "q4H7xDe1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateCheckoutConfig \
    --id 'jh7clQul' \
    --sandbox 'False' \
    --validate 'False' \
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
    --id 'FzOE2zPD' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestCheckoutConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 227 UpdatePayPalConfig
# body param: body
echo '{"clientID": "GsklKEj2", "clientSecret": "cImuLS8r", "returnUrl": "rBfOaAEN", "webHookId": "FCnYbIQI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePayPalConfig \
    --id 'DkTf41ag' \
    --sandbox 'True' \
    --validate 'False' \
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
    --id 'WPut7xra' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestPayPalConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 229 UpdateStripeConfig
# body param: body
echo '{"allowedPaymentMethodTypes": ["aeaiep5a"], "publishableKey": "TdbjoDWO", "secretKey": "L2gmjDt1", "webhookSecret": "rOz0DT1A"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateStripeConfig \
    --id 'xwhim0K9' \
    --sandbox 'False' \
    --validate 'False' \
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
    --id 'mBcUU86i' \
    --sandbox 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'TestStripeConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 231 UpdateWxPayConfig
# body param: body
echo '{"appId": "JulX4aR8", "key": "w6Q4PkLk", "mchid": "wcg4w7vo", "returnUrl": "onsTuM2o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateWxPayConfig \
    --id 'BECnfwi6' \
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
    --id 'gqpB4WwK' \
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
    --id 'tAnQQIfN' \
    >$TEMP_FILE 2>&1
update_status $? 'TestWxPayConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 UpdateXsollaConfig
# body param: body
echo '{"apiKey": "q8tkbUlx", "flowCompletionUrl": "AfBvJ3tw", "merchantId": 73, "projectId": 92, "projectSecretKey": "1E8SglSH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaConfig \
    --id 'PDOBkao6' \
    --validate 'True' \
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
    --id '7WrSKfNZ' \
    >$TEMP_FILE 2>&1
update_status $? 'TestXsollaConfigById'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 236 UpdateXsollaUIConfig
# body param: body
echo '{"device": "DESKTOP", "showCloseButton": false, "size": "MEDIUM", "theme": "DEFAULT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdateXsollaUIConfig \
    --id '3vs48k8G' \
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
    --limit '24' \
    --namespace_ 'WbZOgcnb' \
    --offset '20' \
    --region 'NsJBKfFA' \
    >$TEMP_FILE 2>&1
update_status $? 'QueryPaymentProviderConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 238 CreatePaymentProviderConfig
# body param: body
echo '{"aggregate": "ADYEN", "namespace": "2oC4m8qm", "region": "GI4g3x7V", "sandboxTaxJarApiToken": "kgLXzEcg", "specials": ["STRIPE"], "taxJarApiToken": "clUWy7ZJ", "taxJarEnabled": true, "useGlobalTaxJarApiToken": false}' > $TEMP_JSON_INPUT
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
    --namespace_ 'W2qMkZ2m' \
    --region '9trvZisC' \
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
echo '{"aggregate": "ADYEN", "namespace": "lZ6nzcA0", "region": "5v44SCrW", "sandboxTaxJarApiToken": "kKPTz20C", "specials": ["ALIPAY"], "taxJarApiToken": "ON0qlw6d", "taxJarEnabled": true, "useGlobalTaxJarApiToken": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op UpdatePaymentProviderConfig \
    --id 'v7zSESiU' \
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
    --id 'AVN1CwX4' \
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
echo '{"sandboxTaxJarApiToken": "ZMRG0Gf1", "taxJarApiToken": "rfLs27GU", "taxJarEnabled": false, "taxJarProductCodesMapping": {"4LXB9YV8": "FW73Yegp"}}' > $TEMP_JSON_INPUT
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
    --nextEvaluatedKey 'NcJMlA9w' \
    --end 'UgUsQ5nj' \
    --start 'C8VO4sgo' \
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
    --language 'RFcoG9Ev' \
    --storeId 'gBLbT6LI' \
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
    --language 'znmery1q' \
    --storeId '7Ru0EPX2' \
    >$TEMP_FILE 2>&1
update_status $? 'DownloadCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 PublicGetCategory
$CLI_EXE \
    --sn platform \
    --op PublicGetCategory \
    --categoryPath 't5Kl8G5S' \
    --namespace $TEST_NAMESPACE \
    --language 'm4GZYuYJ' \
    --storeId '1bv2f6vr' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCategory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 PublicGetChildCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetChildCategories \
    --categoryPath 'f7yzKmiS' \
    --namespace $TEST_NAMESPACE \
    --language 'oLdcKYGi' \
    --storeId 'j2Fob7nz' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetChildCategories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 251 PublicGetDescendantCategories
$CLI_EXE \
    --sn platform \
    --op PublicGetDescendantCategories \
    --categoryPath '3cBYTpN9' \
    --namespace $TEST_NAMESPACE \
    --language 'BOiieVeC' \
    --storeId 'IJp60mv8' \
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
    --language '8QYWnFYR' \
    --region 'XnDSOYxR' \
    --storeId '9xEcI7kt' \
    --appId 'ZgyQ1Pcq' \
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
    --language 'uQQfYbi9' \
    --region 'H9dFCgRp' \
    --storeId '7uEwOPWr' \
    --sku 'KnASgjfb' \
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
    --language 'B7kWEU28' \
    --region 'xX2fI68k' \
    --storeId 'SyNp7CBC' \
    --itemIds 'tgT4nlpO' \
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
    --limit '1' \
    --offset '61' \
    --region '9RqY1zhD' \
    --storeId '25toALOu' \
    --keyword 'g3D6sySW' \
    --language 'jGkmDxeI' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchItems'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 PublicGetApp
$CLI_EXE \
    --sn platform \
    --op PublicGetApp \
    --itemId 'vWSM0L1e' \
    --namespace $TEST_NAMESPACE \
    --language 'tOsAoob5' \
    --region 'LsBHH7TR' \
    --storeId 'U7DSv4Bl' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetApp'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 PublicGetItemDynamicData
$CLI_EXE \
    --sn platform \
    --op PublicGetItemDynamicData \
    --itemId '1JLViUnC' \
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
    --itemId 'f9br0Awr' \
    --namespace $TEST_NAMESPACE \
    --language 'YymvbyVt' \
    --populateBundle 'False' \
    --region 'yXglS0dt' \
    --storeId 'EcGJ3Vfs' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 GetPaymentCustomization
update_status 0 'GetPaymentCustomization (skipped deprecated)'

#- 262 PublicGetPaymentUrl
# body param: body
echo '{"paymentOrderNo": "szE68nyi", "paymentProvider": "WXPAY", "returnUrl": "CylIgcjA", "ui": "QgJS7ut6", "zipCode": "fWj0bjzR"}' > $TEMP_JSON_INPUT
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
    --paymentOrderNo '1qk50WTJ' \
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
    --paymentOrderNo 'SWMGCWOq' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUnpaidPaymentOrder'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 265 Pay
# body param: body
echo '{"token": "gPcQEu7X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op Pay \
    --namespace $TEST_NAMESPACE \
    --paymentOrderNo 'P4K3h5qA' \
    --paymentProvider 'WALLET' \
    --zipCode 'xWIwznTW' \
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
    --paymentOrderNo 'hLbxZXBh' \
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
    --paymentProvider 'ADYEN' \
    --region 'BiiMbLGc' \
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
    --code 'BOF8Unez' \
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
    --zipCode 'd8R40Via' \
    --paymentOrderNo '1HQGyTJx' \
    --paymentProvider 'ALIPAY' \
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
    --rewardCode 'E61z1d23' \
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
    --eventTopic 'WGf1zfjn' \
    --limit '81' \
    --offset '12' \
    --sortBy 'bDHxFOx6' \
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
    --rewardId '8rBOBVv5' \
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
    --appIds '["za3wZKkk"]' \
    --itemIds '["BXOpjG8D"]' \
    --skus '["MYI7aCPV"]' \
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
    --appId 'OXyHlMa4' \
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
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId 'ckktYeg9' \
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
    --entitlementClazz 'APP' \
    --sku 'TKGckRJx' \
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
    --appIds '["WrHhn4YO"]' \
    --itemIds '["K6MnfeVl"]' \
    --skus '["dbEnLYWO"]' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetEntitlementOwnershipToken'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 280 PublicGetMyWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetMyWallet \
    --currencyCode 'zyOB0kZo' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 281 PublicSyncPsnDlcInventory
# body param: body
echo '{"serviceLabel": 9}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSyncPsnDlcInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'JIWku1PB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSyncPsnDlcInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 282 SyncSteamDLC
# body param: body
echo '{"appId": "eZzonuQz", "steamId": "xLODS8nT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamDLC \
    --namespace $TEST_NAMESPACE \
    --userId 'AouPR62R' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncSteamDLC'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 283 SyncXboxDLC
# body param: body
echo '{"xstsToken": "XcekOPk5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxDLC \
    --namespace $TEST_NAMESPACE \
    --userId '1sYy0IuL' \
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
    --userId 'JPPNclQg' \
    --appType 'SOFTWARE' \
    --entitlementClazz 'SUBSCRIPTION' \
    --entitlementName 'rjtMtdov' \
    --itemId '["0qluMZwW"]' \
    --limit '62' \
    --offset '84' \
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
    --userId 'cBAVMLvA' \
    --appId 'vzLjQSHw' \
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
    --userId 'PO48On3g' \
    --limit '57' \
    --offset '3' \
    --appType 'DLC' \
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
    --userId 'AwKRyMNC' \
    --entitlementClazz 'CODE' \
    --itemId 'YGZ9RvQU' \
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
    --userId 'XcWQhh5i' \
    --entitlementClazz 'SUBSCRIPTION' \
    --sku 'hyoneUWb' \
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
    --userId 'Dyvutndg' \
    --appIds '["icjax7ON"]' \
    --itemIds '["nA3dvJOo"]' \
    --skus '["cdyisYR5"]' \
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
    --userId 'yhrcsZyv' \
    --appId 'bLMUUSwl' \
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
    --userId '9luLGR0M' \
    --entitlementClazz 'SUBSCRIPTION' \
    --itemId 'dWXP7dHv' \
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
    --userId 'zRSx4xnE' \
    --entitlementClazz 'ENTITLEMENT' \
    --sku 'seCMo1qF' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlementOwnershipBySku'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 293 PublicGetUserEntitlement
$CLI_EXE \
    --sn platform \
    --op PublicGetUserEntitlement \
    --entitlementId 'RoqmJULD' \
    --namespace $TEST_NAMESPACE \
    --userId 'delYwV2D' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 294 PublicConsumeUserEntitlement
# body param: body
echo '{"useCount": 87}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicConsumeUserEntitlement \
    --entitlementId 'ZfSBnT2V' \
    --namespace $TEST_NAMESPACE \
    --userId 'lyq5VWu4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicConsumeUserEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 295 PublicRedeemCode
# body param: body
echo '{"code": "pLxrqfJr", "language": "nc_sN", "region": "JZPieAS6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicRedeemCode \
    --namespace $TEST_NAMESPACE \
    --userId 'Ozt9Y76C' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicRedeemCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 296 PublicFulfillAppleIAPItem
# body param: body
echo '{"excludeOldTransactions": false, "language": "Xn-XHCE_UE", "productId": "WqEFljov", "receiptData": "jiFds9U3", "region": "Q4FL9FKh", "transactionId": "fTM3X1GH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillAppleIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'B92JFCpi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicFulfillAppleIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 297 SyncEpicGamesInventory
# body param: body
echo '{"epicGamesJwtToken": "6PSpyvcT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncEpicGamesInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'nMqT7mEL' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncEpicGamesInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 298 PublicFulfillGoogleIAPItem
# body param: body
echo '{"autoAck": true, "language": "af", "orderId": "jIfXCWza", "packageName": "tjGv4UVj", "productId": "072ERIdI", "purchaseTime": 19, "purchaseToken": "nEdKEgYr", "region": "C08a2gef"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicFulfillGoogleIAPItem \
    --namespace $TEST_NAMESPACE \
    --userId 'HyULfaLd' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicFulfillGoogleIAPItem'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 299 PublicReconcilePlayStationStore
# body param: body
echo '{"currencyCode": "tBzfi8aW", "price": 0.2660114810280835, "productId": "f1NWlgli", "serviceLabel": 97}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicReconcilePlayStationStore \
    --namespace $TEST_NAMESPACE \
    --userId 'dgwwepIg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicReconcilePlayStationStore'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 300 SyncStadiaEntitlement
# body param: body
echo '{"appId": "Kh0HKAG3", "language": "oF", "region": "WxTfKegx", "stadiaPlayerId": "R0U2CExN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncStadiaEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'lVZ2RGvV' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncStadiaEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 301 SyncSteamInventory
# body param: body
echo '{"appId": "o9j2WLb2", "currencyCode": "CSAgZdAF", "language": "Ns-pzqq_898", "price": 0.9903583311660245, "productId": "4njvE58h", "region": "P4ov9Lr3", "steamId": "EkTSLIsh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncSteamInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'qSb4fuvT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncSteamInventory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 302 SyncTwitchDropsEntitlement
# body param: body
echo '{"gameId": "w4H9hubY", "language": "iVVU_fN", "region": "bsYzIcst"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncTwitchDropsEntitlement \
    --namespace $TEST_NAMESPACE \
    --userId 'Ous7bRp1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SyncTwitchDropsEntitlement'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 303 SyncXboxInventory
# body param: body
echo '{"currencyCode": "CdG3Hblu", "price": 0.9650787558445256, "productId": "YQD4Otx1", "xstsToken": "GZEBw1Jk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op SyncXboxInventory \
    --namespace $TEST_NAMESPACE \
    --userId 'hddhy686' \
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
    --userId '121Qm42I' \
    --itemId '9DcReFey' \
    --limit '74' \
    --offset '38' \
    --status 'REFUNDING' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserOrders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 305 PublicCreateUserOrder
# body param: body
echo '{"currencyCode": "Ot0SmGDz", "discountedPrice": 28, "ext": {"1dDuZYxY": {}}, "itemId": "8RWgiwIj", "language": "GKyW-628", "price": 4, "quantity": 62, "region": "VCYsZcY5", "returnUrl": "pJfXaaUs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCreateUserOrder \
    --namespace $TEST_NAMESPACE \
    --userId 'khgMZlpx' \
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
    --orderNo 'mjm9f23L' \
    --userId 'lr7WKchQ' \
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
    --orderNo 'rdRvUcqA' \
    --userId 'HelKgovo' \
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
    --orderNo 'wPUtF6DL' \
    --userId 'evfnhWi0' \
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
    --orderNo 'LSLOvWcj' \
    --userId 'aWpr1gk6' \
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
    --userId 'Cb5tABJO' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetPaymentAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 311 PublicDeletePaymentAccount
$CLI_EXE \
    --sn platform \
    --op PublicDeletePaymentAccount \
    --id '3orPfizP' \
    --namespace $TEST_NAMESPACE \
    --type 'paypal' \
    --userId 'wbyfoC6o' \
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
    --userId 'tIQ84AwM' \
    --chargeStatus 'CHARGED' \
    --itemId 'UVBsp0Jn' \
    --limit '55' \
    --offset '5' \
    --sku 'xN6VmGGp' \
    --status 'INIT' \
    --subscribedBy 'USER' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicQueryUserSubscriptions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 313 PublicSubscribeSubscription
# body param: body
echo '{"currencyCode": "MvcnJGqj", "itemId": "2G28XQmz", "language": "TtYJ_BFGk-335", "region": "1ZepOAJR", "returnUrl": "lCb7x8Bb", "source": "V5fQSmVl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicSubscribeSubscription \
    --namespace $TEST_NAMESPACE \
    --userId 'jKVLc1aV' \
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
    --userId 'QNlsm8f2' \
    --itemId 'XRjKcW95' \
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
    --subscriptionId 'AO0RLEUg' \
    --userId 'kXqKmlhk' \
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
    --subscriptionId 'XoXwCzge' \
    --userId 'VyEsm1LK' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicChangeSubscriptionBillingAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 317 PublicCancelSubscription
# body param: body
echo '{"immediate": false, "reason": "HKmMU5zt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn platform \
    --op PublicCancelSubscription \
    --namespace $TEST_NAMESPACE \
    --subscriptionId '6FeqZnSr' \
    --userId 'j4rqOPOg' \
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
    --subscriptionId '3FZjVLWN' \
    --userId 'be1nKpOx' \
    --excludeFree 'True' \
    --limit '48' \
    --offset '93' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserSubscriptionBillingHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 319 PublicGetWallet
$CLI_EXE \
    --sn platform \
    --op PublicGetWallet \
    --currencyCode 'kf4msE7d' \
    --namespace $TEST_NAMESPACE \
    --userId 'goYbfALB' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetWallet'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 320 PublicListUserWalletTransactions
$CLI_EXE \
    --sn platform \
    --op PublicListUserWalletTransactions \
    --currencyCode 'MEdRlqlv' \
    --namespace $TEST_NAMESPACE \
    --userId 'MdQrXgZH' \
    --limit '27' \
    --offset '81' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserWalletTransactions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT