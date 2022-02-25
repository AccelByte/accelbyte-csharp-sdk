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

OPERATIONS_COUNT=67

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

#- 1 ListConfig
$CLI_EXE \
    --sn dsmc \
    --op ListConfig \
    >$TEMP_FILE 2>&1
update_status $? 'ListConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 SaveConfig
update_status 0 'SaveConfig (skipped deprecated)'

#- 3 UpdateImage
# body param: body
echo '{"artifactPath": "b0Cjv4Ax", "image": "7NzYkopp", "namespace": "a0VgFJAh", "persistent": true, "version": "Tb5q010g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateImage'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 CreateImage
# body param: body
echo '{"artifactPath": "N2MQrbpe", "dockerPath": "RnxTlCTF", "image": "SMIbl1a2", "namespace": "jXLCtWmH", "persistent": true, "version": "i9SoMkSE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImage \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateImage'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 ImportImages
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportImages \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ImportImages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 CreateImagePatch
# body param: body
echo '{"artifactPath": "4eJelwO4", "dockerPath": "KPMky2h8", "image": "R2fIXoXP", "namespace": "8gd7JUab", "patchVersion": "Yc3GMbxT", "persistent": false, "version": "m1fsu6J3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImagePatch \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateImagePatch'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 GetConfig
$CLI_EXE \
    --sn dsmc \
    --op GetConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 CreateConfig
# body param: body
echo '{"claim_timeout": 57, "creation_timeout": 36, "default_version": "5ppGR9Xc", "port": 29, "ports": {"xYTGgewr": 75}, "protocol": "fwvzJF4T", "providers": ["pbNhKq2x"], "session_timeout": 6, "unreachable_timeout": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 DeleteConfig
$CLI_EXE \
    --sn dsmc \
    --op DeleteConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 UpdateConfig
# body param: body
echo '{"claim_timeout": 13, "creation_timeout": 60, "default_version": "BepFHtf6", "port": 17, "protocol": "egqdEL4f", "providers": ["sM6nBzRV"], "session_timeout": 40, "unreachable_timeout": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 ClearCache
$CLI_EXE \
    --sn dsmc \
    --op ClearCache \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ClearCache'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetAllDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeployment \
    --namespace $TEST_NAMESPACE \
    --count '34' \
    --offset '92' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment 'H1Liu7UQ' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 CreateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 73, "buffer_percent": 39, "configuration": "Rtr5cfWO", "enable_region_overrides": false, "game_version": "6vsOns4j", "max_count": 79, "min_count": 97, "overrides": {"Gc7CiUa4": {"buffer_count": 44, "buffer_percent": 76, "configuration": "5Eu3Vqym", "enable_region_overrides": true, "game_version": "FXporMqE", "max_count": 59, "min_count": 86, "name": "8E72XMKf", "region_overrides": {"hl6eq2Fz": {"buffer_count": 92, "buffer_percent": 95, "max_count": 75, "min_count": 74, "name": "NmPLeZdo", "use_buffer_percent": true}}, "regions": ["XfabFXzv"], "use_buffer_percent": false}}, "region_overrides": {"Lmai7fPK": {"buffer_count": 42, "buffer_percent": 60, "max_count": 1, "min_count": 93, "name": "VtLbQSWt", "use_buffer_percent": true}}, "regions": ["yz0mGGyH"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'IlIKsXgv' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment 'SrkEgTYV' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 UpdateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 17, "buffer_percent": 86, "configuration": "BE6zJJ1B", "enable_region_overrides": true, "game_version": "fCHqqp2G", "max_count": 44, "min_count": 82, "regions": ["cmzSuY8w"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'BEfRXoZL' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 11, "buffer_percent": 30, "max_count": 95, "min_count": 62, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment 'DwjHHCW2' \
    --namespace $TEST_NAMESPACE \
    --region 'g5u8z9yr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateRootRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment 'pJdIx5vv' \
    --namespace $TEST_NAMESPACE \
    --region 'HS3d6PKP' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteRootRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 60, "buffer_percent": 24, "max_count": 68, "min_count": 82, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment '8jt8Lq4x' \
    --namespace $TEST_NAMESPACE \
    --region '0F7Ncoce' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateRootRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 22, "buffer_percent": 71, "configuration": "jtlKYu8i", "enable_region_overrides": true, "game_version": "Pznx0s5T", "max_count": 50, "min_count": 91, "region_overrides": {"51oV4HTm": {"buffer_count": 17, "buffer_percent": 42, "max_count": 25, "min_count": 2, "name": "6tPmCirk", "use_buffer_percent": false}}, "regions": ["YvcOUucj"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'PsvjLK1C' \
    --namespace $TEST_NAMESPACE \
    --version 'jPt93utb' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateDeploymentOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment 'MkpUFHT0' \
    --namespace $TEST_NAMESPACE \
    --version 'fL9q9SMN' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteDeploymentOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 52, "buffer_percent": 92, "configuration": "QVoiQtSQ", "enable_region_overrides": true, "game_version": "2kNSsmT0", "max_count": 6, "min_count": 0, "regions": ["BG4zA2zp"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment '0bD6dGgw' \
    --namespace $TEST_NAMESPACE \
    --version 'kYgHzKuI' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateDeploymentOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 86, "buffer_percent": 70, "max_count": 35, "min_count": 3, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment 'P7kfpIle' \
    --namespace $TEST_NAMESPACE \
    --region 'tXrCK1UV' \
    --version 'O0jcs7nC' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateOverrideRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'qsodoTFT' \
    --namespace $TEST_NAMESPACE \
    --region 'cWlaIBJA' \
    --version 'AknU6Hob' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteOverrideRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 13, "buffer_percent": 97, "max_count": 22, "min_count": 0, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'edDfasTc' \
    --namespace $TEST_NAMESPACE \
    --region '8gr2znWq' \
    --version 'D6tIcfI5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateOverrideRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $TEST_NAMESPACE \
    --count '38' \
    --offset '92' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllPodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'NQ7mQPjC' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 CreatePodConfig
# body param: body
echo '{"cpu_limit": 1, "mem_limit": 23, "params": "ZgFVEQyq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'av09OYmx' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'CvMqVcXs' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 81, "mem_limit": 32, "name": "Nz8ZLBsn", "params": "cbRrf6uE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'djUnr04W' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 AddPort
# body param: body
echo '{"port": 78}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'hgEGvqKW' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddPort'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'QTkE65j6' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePort'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 UpdatePort
# body param: body
echo '{"name": "186p0Wfs", "port": 27}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name 'WZuUPsaR' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePort'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $TEST_NAMESPACE \
    --count '27' \
    --offset '95' \
    --q 'drdBA2hX' \
    --sortBy 'updatedAt' \
    --sortDirection 'desc' \
    >$TEMP_FILE 2>&1
update_status $? 'ListImages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $TEST_NAMESPACE \
    --imageURI 'zZMdlR4c' \
    --version 'L76hnFDg' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteImage'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 ExportImages
$CLI_EXE \
    --sn dsmc \
    --op ExportImages \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportImages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 GetImageLimit
$CLI_EXE \
    --sn dsmc \
    --op GetImageLimit \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetImageLimit'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 DeleteImagePatch
$CLI_EXE \
    --sn dsmc \
    --op DeleteImagePatch \
    --namespace $TEST_NAMESPACE \
    --imageURI 'TfofHdfo' \
    --version 'SqDcaFhO' \
    --versionPatch 'c1oKxI8f' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteImagePatch'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $TEST_NAMESPACE \
    --version '5ocfy4EI' \
    >$TEMP_FILE 2>&1
update_status $? 'GetImageDetail'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $TEST_NAMESPACE \
    --version 'xwBiB90v' \
    >$TEMP_FILE 2>&1
update_status $? 'GetImagePatches'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $TEST_NAMESPACE \
    --version 'dgS5YpKs' \
    --versionPatch 'dbpiU2Uf' \
    >$TEMP_FILE 2>&1
update_status $? 'GetImagePatchDetail'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 ListServer
$CLI_EXE \
    --sn dsmc \
    --op ListServer \
    --namespace $TEST_NAMESPACE \
    --count '48' \
    --offset '76' \
    --region 'O4DhL9fB' \
    >$TEMP_FILE 2>&1
update_status $? 'ListServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 CountServer
$CLI_EXE \
    --sn dsmc \
    --op CountServer \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'CountServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 CountServerDetailed
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailed \
    --namespace $TEST_NAMESPACE \
    --region 'KJvjBOUn' \
    >$TEMP_FILE 2>&1
update_status $? 'CountServerDetailed'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 ListLocalServer
$CLI_EXE \
    --sn dsmc \
    --op ListLocalServer \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ListLocalServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 DeleteLocalServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteLocalServer \
    --name '3bYf5ouX' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteLocalServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $TEST_NAMESPACE \
    --podName 'qkbiExqT' \
    >$TEMP_FILE 2>&1
update_status $? 'GetServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $TEST_NAMESPACE \
    --podName '6Dk9QFqa' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 GetServerLogs
$CLI_EXE \
    --sn dsmc \
    --op GetServerLogs \
    --namespace $TEST_NAMESPACE \
    --podName 'AjhwOI1P' \
    >$TEMP_FILE 2>&1
update_status $? 'GetServerLogs'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $TEST_NAMESPACE \
    --count '7' \
    --offset '77' \
    --region 'HfTwrxBR' \
    --withServer 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'ListSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $TEST_NAMESPACE \
    --region 'MxZrSfx3' \
    >$TEMP_FILE 2>&1
update_status $? 'CountSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'V8OXkMng' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 ExportConfigV1
$CLI_EXE \
    --sn dsmc \
    --op ExportConfigV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 ImportConfigV1
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportConfigV1 \
    --namespace $TEST_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ImportConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 ImageDetailClient
$CLI_EXE \
    --sn dsmc \
    --op ImageDetailClient \
    --namespace $TEST_NAMESPACE \
    --version '7p2SyFDE' \
    >$TEMP_FILE 2>&1
update_status $? 'ImageDetailClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 DeregisterLocalServer
# body param: body
echo '{"name": "nmYQzehP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DeregisterLocalServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "BqD12Dvv", "ip": "zNNZSu5z", "name": "ZVgY3Zos", "port": 11}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RegisterLocalServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 58 RegisterServer
# body param: body
echo '{"custom_attribute": "d01vaOGw", "pod_name": "eHacvHRV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RegisterServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 59 ShutdownServer
# body param: body
echo '{"kill_me": true, "pod_name": "B8hos4ya"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ShutdownServer \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ShutdownServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 60 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $TEST_NAMESPACE \
    --podName 'OBjMxizC' \
    >$TEMP_FILE 2>&1
update_status $? 'GetServerSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 CreateSession
# body param: body
echo '{"client_version": "xx9qTOIK", "configuration": "lpdrqo2s", "deployment": "mD9RPpjO", "game_mode": "WK0k76i1", "matching_allies": [{"matching_parties": [{"party_attributes": {"g7rYaEuN": {}}, "party_id": "CyPoQ0oH", "party_members": [{"user_id": "YXUQdtIk"}]}]}], "namespace": "Akltd1zQ", "notification_payload": {}, "pod_name": "BzzC6ldK", "region": "riI6lTRb", "session_id": "c1Z1HJHz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 ClaimServer
# body param: body
echo '{"session_id": "l323Ynwf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ClaimServer \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ClaimServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 GetSession
$CLI_EXE \
    --sn dsmc \
    --op GetSession \
    --namespace $TEST_NAMESPACE \
    --sessionID '5PvGejCD' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 GetDefaultProvider
$CLI_EXE \
    --sn dsmc \
    --op GetDefaultProvider \
    >$TEMP_FILE 2>&1
update_status $? 'GetDefaultProvider'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 65 ListProviders
$CLI_EXE \
    --sn dsmc \
    --op ListProviders \
    >$TEMP_FILE 2>&1
update_status $? 'ListProviders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 ListProvidersByRegion
$CLI_EXE \
    --sn dsmc \
    --op ListProvidersByRegion \
    --region 'gAr1pXDc' \
    >$TEMP_FILE 2>&1
update_status $? 'ListProvidersByRegion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 67 PublicGetMessages
$CLI_EXE \
    --sn dsmc \
    --op PublicGetMessages \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMessages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT