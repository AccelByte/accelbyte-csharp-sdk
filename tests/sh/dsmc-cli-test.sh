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
echo "1..68"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListConfig
$CLI_EXE \
    --sn dsmc \
    --op ListConfig \
    > test.out 2>&1
eval_tap $? 2 'ListConfig' test.out

#- 3 SaveConfig
eval_tap 0 3 'SaveConfig # SKIP deprecated' test.out

#- 4 UpdateImage
# body param: body
echo '{"artifactPath": "b0Cjv4Ax", "image": "7NzYkopp", "namespace": "a0VgFJAh", "persistent": true, "version": "Tb5q010g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateImage' test.out

#- 5 CreateImage
# body param: body
echo '{"artifactPath": "N2MQrbpe", "dockerPath": "RnxTlCTF", "image": "SMIbl1a2", "namespace": "jXLCtWmH", "persistent": true, "version": "i9SoMkSE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateImage' test.out

#- 6 ImportImages
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportImages \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 6 'ImportImages' test.out

#- 7 CreateImagePatch
# body param: body
echo '{"artifactPath": "4eJelwO4", "dockerPath": "KPMky2h8", "image": "R2fIXoXP", "namespace": "8gd7JUab", "patchVersion": "Yc3GMbxT", "persistent": false, "version": "m1fsu6J3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImagePatch \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'CreateImagePatch' test.out

#- 8 GetConfig
$CLI_EXE \
    --sn dsmc \
    --op GetConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'GetConfig' test.out

#- 9 CreateConfig
# body param: body
echo '{"claim_timeout": 57, "creation_timeout": 36, "default_version": "5ppGR9Xc", "port": 29, "ports": {"xYTGgewr": 75}, "protocol": "fwvzJF4T", "providers": ["pbNhKq2x"], "session_timeout": 6, "unreachable_timeout": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'CreateConfig' test.out

#- 10 DeleteConfig
$CLI_EXE \
    --sn dsmc \
    --op DeleteConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'DeleteConfig' test.out

#- 11 UpdateConfig
# body param: body
echo '{"claim_timeout": 13, "creation_timeout": 60, "default_version": "BepFHtf6", "port": 17, "protocol": "egqdEL4f", "providers": ["sM6nBzRV"], "session_timeout": 40, "unreachable_timeout": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UpdateConfig' test.out

#- 12 ClearCache
$CLI_EXE \
    --sn dsmc \
    --op ClearCache \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ClearCache' test.out

#- 13 GetAllDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeployment \
    --namespace $AB_NAMESPACE \
    --count '34' \
    --name '7UH1Liu7' \
    --offset '93' \
    > test.out 2>&1
eval_tap $? 13 'GetAllDeployment' test.out

#- 14 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment 'Q0304McK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'GetDeployment' test.out

#- 15 CreateDeployment
# body param: body
echo '{"allow_version_override": true, "buffer_count": 87, "buffer_percent": 38, "configuration": "r5cfWO5J", "enable_region_overrides": false, "game_version": "6vsOns4j", "max_count": 79, "min_count": 97, "overrides": {"Gc7CiUa4": {"buffer_count": 44, "buffer_percent": 76, "configuration": "5Eu3Vqym", "enable_region_overrides": true, "game_version": "FXporMqE", "max_count": 59, "min_count": 86, "name": "8E72XMKf", "region_overrides": {"hl6eq2Fz": {"buffer_count": 92, "buffer_percent": 95, "max_count": 75, "min_count": 74, "name": "NmPLeZdo", "use_buffer_percent": true}}, "regions": ["XfabFXzv"], "use_buffer_percent": false}}, "region_overrides": {"Lmai7fPK": {"buffer_count": 42, "buffer_percent": 60, "max_count": 1, "min_count": 93, "name": "VtLbQSWt", "use_buffer_percent": true}}, "regions": ["yz0mGGyH"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'IlIKsXgv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'CreateDeployment' test.out

#- 16 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment 'SrkEgTYV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DeleteDeployment' test.out

#- 17 UpdateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 17, "buffer_percent": 86, "configuration": "BE6zJJ1B", "enable_region_overrides": true, "game_version": "fCHqqp2G", "max_count": 44, "min_count": 82, "regions": ["cmzSuY8w"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'BEfRXoZL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateDeployment' test.out

#- 18 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 11, "buffer_percent": 30, "max_count": 95, "min_count": 62, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment 'DwjHHCW2' \
    --namespace $AB_NAMESPACE \
    --region 'g5u8z9yr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateRootRegionOverride' test.out

#- 19 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment 'pJdIx5vv' \
    --namespace $AB_NAMESPACE \
    --region 'HS3d6PKP' \
    > test.out 2>&1
eval_tap $? 19 'DeleteRootRegionOverride' test.out

#- 20 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 60, "buffer_percent": 24, "max_count": 68, "min_count": 82, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment '8jt8Lq4x' \
    --namespace $AB_NAMESPACE \
    --region '0F7Ncoce' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateRootRegionOverride' test.out

#- 21 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 22, "buffer_percent": 71, "configuration": "jtlKYu8i", "enable_region_overrides": true, "game_version": "Pznx0s5T", "max_count": 50, "min_count": 91, "region_overrides": {"51oV4HTm": {"buffer_count": 17, "buffer_percent": 42, "max_count": 25, "min_count": 2, "name": "6tPmCirk", "use_buffer_percent": false}}, "regions": ["YvcOUucj"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'PsvjLK1C' \
    --namespace $AB_NAMESPACE \
    --version 'jPt93utb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateDeploymentOverride' test.out

#- 22 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment 'MkpUFHT0' \
    --namespace $AB_NAMESPACE \
    --version 'fL9q9SMN' \
    > test.out 2>&1
eval_tap $? 22 'DeleteDeploymentOverride' test.out

#- 23 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 52, "buffer_percent": 92, "configuration": "QVoiQtSQ", "enable_region_overrides": true, "game_version": "2kNSsmT0", "max_count": 6, "min_count": 0, "regions": ["BG4zA2zp"], "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment '0bD6dGgw' \
    --namespace $AB_NAMESPACE \
    --version 'kYgHzKuI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateDeploymentOverride' test.out

#- 24 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 86, "buffer_percent": 70, "max_count": 35, "min_count": 3, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment 'P7kfpIle' \
    --namespace $AB_NAMESPACE \
    --region 'tXrCK1UV' \
    --version 'O0jcs7nC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateOverrideRegionOverride' test.out

#- 25 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'qsodoTFT' \
    --namespace $AB_NAMESPACE \
    --region 'cWlaIBJA' \
    --version 'AknU6Hob' \
    > test.out 2>&1
eval_tap $? 25 'DeleteOverrideRegionOverride' test.out

#- 26 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 13, "buffer_percent": 97, "max_count": 22, "min_count": 0, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'edDfasTc' \
    --namespace $AB_NAMESPACE \
    --region '8gr2znWq' \
    --version 'D6tIcfI5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateOverrideRegionOverride' test.out

#- 27 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $AB_NAMESPACE \
    --count '38' \
    --offset '92' \
    > test.out 2>&1
eval_tap $? 27 'GetAllPodConfig' test.out

#- 28 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'NQ7mQPjC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'GetPodConfig' test.out

#- 29 CreatePodConfig
# body param: body
echo '{"cpu_limit": 1, "mem_limit": 23, "params": "ZgFVEQyq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'av09OYmx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreatePodConfig' test.out

#- 30 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'CvMqVcXs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'DeletePodConfig' test.out

#- 31 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 81, "mem_limit": 32, "name": "Nz8ZLBsn", "params": "cbRrf6uE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'djUnr04W' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'UpdatePodConfig' test.out

#- 32 AddPort
# body param: body
echo '{"port": 78}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'hgEGvqKW' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AddPort' test.out

#- 33 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'QTkE65j6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'DeletePort' test.out

#- 34 UpdatePort
# body param: body
echo '{"name": "186p0Wfs", "port": 27}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name 'WZuUPsaR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdatePort' test.out

#- 35 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $AB_NAMESPACE \
    --count '27' \
    --offset '95' \
    --q 'drdBA2hX' \
    --sortBy 'updatedAt' \
    --sortDirection 'desc' \
    > test.out 2>&1
eval_tap $? 35 'ListImages' test.out

#- 36 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $AB_NAMESPACE \
    --imageURI 'zZMdlR4c' \
    --version 'L76hnFDg' \
    > test.out 2>&1
eval_tap $? 36 'DeleteImage' test.out

#- 37 ExportImages
$CLI_EXE \
    --sn dsmc \
    --op ExportImages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'ExportImages' test.out

#- 38 GetImageLimit
$CLI_EXE \
    --sn dsmc \
    --op GetImageLimit \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'GetImageLimit' test.out

#- 39 DeleteImagePatch
$CLI_EXE \
    --sn dsmc \
    --op DeleteImagePatch \
    --namespace $AB_NAMESPACE \
    --imageURI 'TfofHdfo' \
    --version 'SqDcaFhO' \
    --versionPatch 'c1oKxI8f' \
    > test.out 2>&1
eval_tap $? 39 'DeleteImagePatch' test.out

#- 40 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $AB_NAMESPACE \
    --version '5ocfy4EI' \
    > test.out 2>&1
eval_tap $? 40 'GetImageDetail' test.out

#- 41 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $AB_NAMESPACE \
    --version 'xwBiB90v' \
    > test.out 2>&1
eval_tap $? 41 'GetImagePatches' test.out

#- 42 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $AB_NAMESPACE \
    --version 'dgS5YpKs' \
    --versionPatch 'dbpiU2Uf' \
    > test.out 2>&1
eval_tap $? 42 'GetImagePatchDetail' test.out

#- 43 ListServer
$CLI_EXE \
    --sn dsmc \
    --op ListServer \
    --namespace $AB_NAMESPACE \
    --count '48' \
    --offset '76' \
    --region 'O4DhL9fB' \
    > test.out 2>&1
eval_tap $? 43 'ListServer' test.out

#- 44 CountServer
$CLI_EXE \
    --sn dsmc \
    --op CountServer \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'CountServer' test.out

#- 45 CountServerDetailed
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailed \
    --namespace $AB_NAMESPACE \
    --region 'KJvjBOUn' \
    > test.out 2>&1
eval_tap $? 45 'CountServerDetailed' test.out

#- 46 ListLocalServer
$CLI_EXE \
    --sn dsmc \
    --op ListLocalServer \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'ListLocalServer' test.out

#- 47 DeleteLocalServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteLocalServer \
    --name '3bYf5ouX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'DeleteLocalServer' test.out

#- 48 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $AB_NAMESPACE \
    --podName 'qkbiExqT' \
    > test.out 2>&1
eval_tap $? 48 'GetServer' test.out

#- 49 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $AB_NAMESPACE \
    --podName '6Dk9QFqa' \
    > test.out 2>&1
eval_tap $? 49 'DeleteServer' test.out

#- 50 GetServerLogs
$CLI_EXE \
    --sn dsmc \
    --op GetServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'AjhwOI1P' \
    > test.out 2>&1
eval_tap $? 50 'GetServerLogs' test.out

#- 51 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $AB_NAMESPACE \
    --count '7' \
    --offset '77' \
    --region 'HfTwrxBR' \
    --withServer 'False' \
    > test.out 2>&1
eval_tap $? 51 'ListSession' test.out

#- 52 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $AB_NAMESPACE \
    --region 'MxZrSfx3' \
    > test.out 2>&1
eval_tap $? 52 'CountSession' test.out

#- 53 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'V8OXkMng' \
    > test.out 2>&1
eval_tap $? 53 'DeleteSession' test.out

#- 54 ExportConfigV1
$CLI_EXE \
    --sn dsmc \
    --op ExportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 54 'ExportConfigV1' test.out

#- 55 ImportConfigV1
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportConfigV1 \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 55 'ImportConfigV1' test.out

#- 56 ImageDetailClient
$CLI_EXE \
    --sn dsmc \
    --op ImageDetailClient \
    --namespace $AB_NAMESPACE \
    --version '7p2SyFDE' \
    > test.out 2>&1
eval_tap $? 56 'ImageDetailClient' test.out

#- 57 DeregisterLocalServer
# body param: body
echo '{"name": "nmYQzehP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'DeregisterLocalServer' test.out

#- 58 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "BqD12Dvv", "ip": "zNNZSu5z", "name": "ZVgY3Zos", "port": 11}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'RegisterLocalServer' test.out

#- 59 RegisterServer
# body param: body
echo '{"custom_attribute": "d01vaOGw", "pod_name": "eHacvHRV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'RegisterServer' test.out

#- 60 ShutdownServer
# body param: body
echo '{"kill_me": true, "pod_name": "B8hos4ya"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ShutdownServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'ShutdownServer' test.out

#- 61 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $AB_NAMESPACE \
    --podName 'OBjMxizC' \
    > test.out 2>&1
eval_tap $? 61 'GetServerSession' test.out

#- 62 CreateSession
# body param: body
echo '{"client_version": "xx9qTOIK", "configuration": "lpdrqo2s", "deployment": "mD9RPpjO", "game_mode": "WK0k76i1", "matching_allies": [{"matching_parties": [{"party_attributes": {"g7rYaEuN": {}}, "party_id": "CyPoQ0oH", "party_members": [{"user_id": "YXUQdtIk"}]}]}], "namespace": "Akltd1zQ", "notification_payload": {}, "pod_name": "BzzC6ldK", "region": "riI6lTRb", "session_id": "c1Z1HJHz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'CreateSession' test.out

#- 63 ClaimServer
# body param: body
echo '{"session_id": "l323Ynwf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ClaimServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'ClaimServer' test.out

#- 64 GetSession
$CLI_EXE \
    --sn dsmc \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID '5PvGejCD' \
    > test.out 2>&1
eval_tap $? 64 'GetSession' test.out

#- 65 GetDefaultProvider
$CLI_EXE \
    --sn dsmc \
    --op GetDefaultProvider \
    > test.out 2>&1
eval_tap $? 65 'GetDefaultProvider' test.out

#- 66 ListProviders
$CLI_EXE \
    --sn dsmc \
    --op ListProviders \
    > test.out 2>&1
eval_tap $? 66 'ListProviders' test.out

#- 67 ListProvidersByRegion
$CLI_EXE \
    --sn dsmc \
    --op ListProvidersByRegion \
    --region 'gAr1pXDc' \
    > test.out 2>&1
eval_tap $? 67 'ListProvidersByRegion' test.out

#- 68 PublicGetMessages
$CLI_EXE \
    --sn dsmc \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 68 'PublicGetMessages' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE