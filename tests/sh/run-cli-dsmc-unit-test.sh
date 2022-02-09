#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="dotnet ../../samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/AccelByte.Sdk.Sample.Cli.dll"
CLI_TOKEN_FILE="../../samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=63

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

#- 6 GetConfig
$CLI_EXE \
    --sn dsmc \
    --op GetConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 CreateConfig
# body param: body
echo '{"claim_timeout": 9, "creation_timeout": 71, "default_version": "elwO4KPM", "port": 20, "ports": {"y2h8R2fI": 99}, "protocol": "oXP8gd7J", "providers": ["UabYc3GM"], "session_timeout": 2, "unreachable_timeout": 47}' > $TEMP_JSON_INPUT
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

#- 8 DeleteConfig
$CLI_EXE \
    --sn dsmc \
    --op DeleteConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 UpdateConfig
# body param: body
echo '{"claim_timeout": 90, "creation_timeout": 22, "default_version": "m1fsu6J3", "port": 57, "protocol": "4s5ppGR9", "providers": ["XcoxYTGg"], "session_timeout": 8, "unreachable_timeout": 45}' > $TEMP_JSON_INPUT
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

#- 10 ClearCache
$CLI_EXE \
    --sn dsmc \
    --op ClearCache \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ClearCache'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 GetAllDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeployment \
    --namespace $TEST_NAMESPACE \
    --count '34' \
    --offset '75' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment 'fwvzJF4T' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 CreateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 3, "buffer_percent": 79, "configuration": "hKq2xdmg", "enable_region_overrides": true, "game_version": "BepFHtf6", "max_count": 17, "min_count": 8, "overrides": {"gqdEL4fs": {"buffer_count": 76, "buffer_percent": 26, "configuration": "BzRVuC1r", "enable_region_overrides": false, "game_version": "u7UQ0304", "max_count": 77, "min_count": 4, "name": "K873tRtr", "region_overrides": {"5cfWO5JJ": {"buffer_count": 5, "buffer_percent": 42, "max_count": 36, "min_count": 80, "name": "ns4jNWGc", "use_buffer_percent": true}}, "regions": ["iUa4wM5E"], "use_buffer_percent": true}}, "region_overrides": {"3VqymsFX": {"buffer_count": 30, "buffer_percent": 29, "max_count": 35, "min_count": 77, "name": "qEDR8E72", "use_buffer_percent": false}}, "regions": ["hl6eq2Fz"], "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'PLeZdoCX' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment 'fabFXzvj' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 UpdateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 1, "buffer_percent": 16, "configuration": "7fPKvE2Z", "enable_region_overrides": false, "game_version": "63UVtLbQ", "max_count": 88, "min_count": 96, "regions": ["tsyz0mGG"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'HHFIlIKs' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateDeployment'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 98, "buffer_percent": 12, "max_count": 43, "min_count": 88, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment 'kEgTYVk5' \
    --namespace $TEST_NAMESPACE \
    --region 'iRBE6zJJ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateRootRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment '1BRHrfCH' \
    --namespace $TEST_NAMESPACE \
    --region 'qqp2GwPc' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteRootRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 25, "buffer_percent": 50, "max_count": 89, "min_count": 40, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment '9VYwBEfR' \
    --namespace $TEST_NAMESPACE \
    --region 'XoZLfpVF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateRootRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 11, "buffer_percent": 58, "configuration": "wjHHCW2g", "enable_region_overrides": true, "game_version": "8z9yrpJd", "max_count": 68, "min_count": 46, "region_overrides": {"5vvHS3d6": {"buffer_count": 82, "buffer_percent": 72, "max_count": 83, "min_count": 60, "name": "27mI6Px8", "use_buffer_percent": false}}, "regions": ["t8Lq4x0F"], "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'ocelJjtl' \
    --namespace $TEST_NAMESPACE \
    --version 'KYu8iCPz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateDeploymentOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment 'nx0s5TzT' \
    --namespace $TEST_NAMESPACE \
    --version '51oV4HTm' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteDeploymentOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 17, "buffer_percent": 42, "configuration": "mb6tPmCi", "enable_region_overrides": true, "game_version": "khYvcOUu", "max_count": 5, "min_count": 19, "regions": ["PWGwPsvj"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment 'jPt93utb' \
    --namespace $TEST_NAMESPACE \
    --version 'MkpUFHT0' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateDeploymentOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 10, "buffer_percent": 75, "max_count": 33, "min_count": 89, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment 'UQVoiQtS' \
    --namespace $TEST_NAMESPACE \
    --region 'QC2kNSsm' \
    --version 'T0d2aBG4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateOverrideRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'zA2zp1Ls' \
    --namespace $TEST_NAMESPACE \
    --region '0bD6dGgw' \
    --version 'kYgHzKuI' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteOverrideRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 86, "buffer_percent": 70, "max_count": 35, "min_count": 3, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'P7kfpIle' \
    --namespace $TEST_NAMESPACE \
    --region 'tXrCK1UV' \
    --version 'O0jcs7nC' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateOverrideRegionOverride'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $TEST_NAMESPACE \
    --count '32' \
    --offset '37' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllPodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'odoTFTcW' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetPodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 CreatePodConfig
# body param: body
echo '{"cpu_limit": 22, "mem_limit": 0, "params": "IBJAAknU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name '6HobZgWl' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreatePodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'aLnedDfa' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 36, "mem_limit": 91, "name": "c8gr2znW", "params": "qD6tIcfI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name '5Z4tUNQ7' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePodConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 AddPort
# body param: body
echo '{"port": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'QPjCalZg' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddPort'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'FVEQyqav' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeletePort'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 UpdatePort
# body param: body
echo '{"name": "09OYmxCv", "port": 76}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name 'qVcXs2Oq' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePort'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $TEST_NAMESPACE \
    --count '79' \
    --offset '51' \
    --q '8ZLBsncb' \
    --sortBy 'version' \
    --sortDirection 'desc' \
    >$TEMP_FILE 2>&1
update_status $? 'ListImages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $TEST_NAMESPACE \
    --imageURI 'f6uEdjUn' \
    --version 'r04WZNhg' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteImage'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 ExportImages
$CLI_EXE \
    --sn dsmc \
    --op ExportImages \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportImages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 GetImageLimit
$CLI_EXE \
    --sn dsmc \
    --op GetImageLimit \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetImageLimit'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $TEST_NAMESPACE \
    --version 'EGvqKWQT' \
    >$TEMP_FILE 2>&1
update_status $? 'GetImageDetail'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 ListServer
$CLI_EXE \
    --sn dsmc \
    --op ListServer \
    --namespace $TEST_NAMESPACE \
    --count '21' \
    --offset '60' \
    --region '65j6186p' \
    >$TEMP_FILE 2>&1
update_status $? 'ListServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 CountServer
$CLI_EXE \
    --sn dsmc \
    --op CountServer \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'CountServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 CountServerDetailed
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailed \
    --namespace $TEST_NAMESPACE \
    --region '0WfsnWZu' \
    >$TEMP_FILE 2>&1
update_status $? 'CountServerDetailed'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 ListLocalServer
$CLI_EXE \
    --sn dsmc \
    --op ListLocalServer \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ListLocalServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 DeleteLocalServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteLocalServer \
    --name 'UPsaRnVd' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteLocalServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $TEST_NAMESPACE \
    --podName 'rdBA2hXw' \
    >$TEMP_FILE 2>&1
update_status $? 'GetServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $TEST_NAMESPACE \
    --podName 'YyzZMdlR' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteServer'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 GetServerLogs
$CLI_EXE \
    --sn dsmc \
    --op GetServerLogs \
    --namespace $TEST_NAMESPACE \
    --podName '4cL76hnF' \
    >$TEMP_FILE 2>&1
update_status $? 'GetServerLogs'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $TEST_NAMESPACE \
    --count '59' \
    --offset '12' \
    --region 'TfofHdfo' \
    --withServer 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'ListSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $TEST_NAMESPACE \
    --region 'DcaFhOc1' \
    >$TEMP_FILE 2>&1
update_status $? 'CountSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'oKxI8f5o' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 ExportConfigV1
$CLI_EXE \
    --sn dsmc \
    --op ExportConfigV1 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'ExportConfigV1'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 ImportConfigV1
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

#- 51 ImageDetailClient
$CLI_EXE \
    --sn dsmc \
    --op ImageDetailClient \
    --namespace $TEST_NAMESPACE \
    --version 'cfy4EIxw' \
    >$TEMP_FILE 2>&1
update_status $? 'ImageDetailClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 DeregisterLocalServer
# body param: body
echo '{"name": "BiB90vdg"}' > $TEMP_JSON_INPUT
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

#- 53 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "S5YpKsdb", "ip": "piU2UfyM", "name": "O4DhL9fB", "port": 73}' > $TEMP_JSON_INPUT
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

#- 54 RegisterServer
# body param: body
echo '{"custom_attribute": "JvjBOUn3", "pod_name": "bYf5ouXq"}' > $TEMP_JSON_INPUT
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

#- 55 ShutdownServer
# body param: body
echo '{"kill_me": false, "pod_name": "biExqT6D"}' > $TEMP_JSON_INPUT
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

#- 56 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $TEST_NAMESPACE \
    --podName 'k9QFqaAj' \
    >$TEMP_FILE 2>&1
update_status $? 'GetServerSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 CreateSession
# body param: body
echo '{"client_version": "hwOI1P04", "configuration": "dMHfTwrx", "deployment": "BRfMxZrS", "game_mode": "fx3V8OXk", "matching_allies": [{"matching_parties": [{"party_attributes": {"Mng7p2Sy": {}}, "party_id": "FDEnmYQz", "party_members": [{"user_id": "ehPBqD12"}]}]}], "namespace": "DvvzNNZS", "pod_name": "u5zZVgY3", "region": "Zosfd01v", "session_id": "aOGweHac"}' > $TEMP_JSON_INPUT
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

#- 58 ClaimServer
# body param: body
echo '{"session_id": "vHRV345x"}' > $TEMP_JSON_INPUT
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

#- 59 GetSession
$CLI_EXE \
    --sn dsmc \
    --op GetSession \
    --namespace $TEST_NAMESPACE \
    --sessionID 'B8hos4ya' \
    >$TEMP_FILE 2>&1
update_status $? 'GetSession'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 60 GetDefaultProvider
$CLI_EXE \
    --sn dsmc \
    --op GetDefaultProvider \
    >$TEMP_FILE 2>&1
update_status $? 'GetDefaultProvider'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 ListProviders
$CLI_EXE \
    --sn dsmc \
    --op ListProviders \
    >$TEMP_FILE 2>&1
update_status $? 'ListProviders'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 ListProvidersByRegion
$CLI_EXE \
    --sn dsmc \
    --op ListProvidersByRegion \
    --region 'OBjMxizC' \
    >$TEMP_FILE 2>&1
update_status $? 'ListProvidersByRegion'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 PublicGetMessages
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