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
echo "1..69"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

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
echo '{"artifactPath": "FiceTk7N", "image": "4t6xlhjp", "namespace": "jnxO63d2", "persistent": true, "version": "B3FGZPeI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateImage' test.out

#- 5 CreateImage
# body param: body
echo '{"artifactPath": "lgverWJs", "dockerPath": "uynapCEu", "image": "Umk3wOWm", "imageSize": 11, "namespace": "tZOJ9Btd", "persistent": false, "version": "PX74J5DP"}' > $TEMP_JSON_INPUT
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
echo '{"artifactPath": "Nq7sWE2t", "dockerPath": "Mqzl9x3t", "image": "hoXqCbOW", "imageSize": 42, "namespace": "aMVTjFIF", "patchVersion": "GMojBykA", "persistent": true, "version": "ogillfcC"}' > $TEMP_JSON_INPUT
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
echo '{"claim_timeout": 95, "creation_timeout": 51, "default_version": "6ziEfvOB", "port": 11, "ports": {"SMuRZBHw": 22, "7J0yTxsK": 45, "3mFCEweV": 13}, "protocol": "KnetDW6I", "providers": ["6Xd1mQce", "cfCm4Zb9", "Dif70s5A"], "session_timeout": 7, "unreachable_timeout": 77}' > $TEMP_JSON_INPUT
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
echo '{"claim_timeout": 30, "creation_timeout": 39, "default_version": "vn0R5z3G", "port": 35, "protocol": "Z89PjynZ", "providers": ["5MnoXIiZ", "rnc72J6y", "OWGohujM"], "session_timeout": 48, "unreachable_timeout": 74}' > $TEMP_JSON_INPUT
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
    --name 'IDh0uA8e' \
    --count '83' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 13 'GetAllDeployment' test.out

#- 14 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment 'J0DzqzvV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'GetDeployment' test.out

#- 15 CreateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 29, "buffer_percent": 19, "configuration": "L5oxYvb6", "enable_region_overrides": false, "game_version": "1PM1q06o", "max_count": 80, "min_count": 9, "overrides": {"3vxrCnd6": {"buffer_count": 51, "buffer_percent": 33, "configuration": "AIHWHXW2", "enable_region_overrides": true, "game_version": "m1R7h4gd", "max_count": 64, "min_count": 51, "name": "MUbr6v28", "region_overrides": {"qqGGM1UF": {"buffer_count": 9, "buffer_percent": 19, "max_count": 49, "min_count": 36, "name": "xY2hnMjS", "unlimited": false, "use_buffer_percent": true}, "WgdPgg0v": {"buffer_count": 51, "buffer_percent": 24, "max_count": 61, "min_count": 57, "name": "gju4cgtw", "unlimited": false, "use_buffer_percent": false}, "r5XGIn50": {"buffer_count": 64, "buffer_percent": 10, "max_count": 28, "min_count": 39, "name": "Vztew0m2", "unlimited": false, "use_buffer_percent": true}}, "regions": ["w1x0wZNO", "wpg1q5CM", "QSWeDKfv"], "session_timeout": 7, "unlimited": true, "use_buffer_percent": true}, "jDP43U24": {"buffer_count": 41, "buffer_percent": 64, "configuration": "f4aykXz2", "enable_region_overrides": true, "game_version": "WgwaJ68N", "max_count": 10, "min_count": 69, "name": "4LLjFfQp", "region_overrides": {"K9PJPlBU": {"buffer_count": 85, "buffer_percent": 41, "max_count": 97, "min_count": 4, "name": "T7BFgWny", "unlimited": false, "use_buffer_percent": true}, "toVPor2w": {"buffer_count": 84, "buffer_percent": 93, "max_count": 100, "min_count": 33, "name": "TJuUqW93", "unlimited": false, "use_buffer_percent": false}, "dzk9RwRM": {"buffer_count": 78, "buffer_percent": 30, "max_count": 8, "min_count": 85, "name": "ptx0JkSs", "unlimited": false, "use_buffer_percent": false}}, "regions": ["KLF5APGW", "i3J3DqcQ", "2iwfPDsG"], "session_timeout": 41, "unlimited": false, "use_buffer_percent": false}, "G3OUKxPV": {"buffer_count": 74, "buffer_percent": 21, "configuration": "DdHVmG8p", "enable_region_overrides": true, "game_version": "Fth8T1WJ", "max_count": 23, "min_count": 86, "name": "JKqknBzE", "region_overrides": {"WU6UUWcz": {"buffer_count": 51, "buffer_percent": 31, "max_count": 28, "min_count": 39, "name": "7giAnhhv", "unlimited": false, "use_buffer_percent": false}, "sgUNZlge": {"buffer_count": 59, "buffer_percent": 39, "max_count": 9, "min_count": 72, "name": "KwU5PQJ1", "unlimited": false, "use_buffer_percent": true}, "u443JqBM": {"buffer_count": 70, "buffer_percent": 60, "max_count": 82, "min_count": 6, "name": "k90kMGcH", "unlimited": true, "use_buffer_percent": false}}, "regions": ["dpeZgybs", "VLbHIWi6", "DgdiQ0pu"], "session_timeout": 30, "unlimited": true, "use_buffer_percent": false}}, "region_overrides": {"LxqqbJgz": {"buffer_count": 44, "buffer_percent": 41, "max_count": 76, "min_count": 63, "name": "T8BnSf2i", "unlimited": true, "use_buffer_percent": false}, "o7wAbIIY": {"buffer_count": 51, "buffer_percent": 57, "max_count": 64, "min_count": 31, "name": "BSZMxhSW", "unlimited": true, "use_buffer_percent": false}, "3L75v580": {"buffer_count": 57, "buffer_percent": 39, "max_count": 36, "min_count": 34, "name": "V6WTfJ8W", "unlimited": true, "use_buffer_percent": true}}, "regions": ["rwZb14iI", "2Yg9YPgG", "1JaMbmvd"], "session_timeout": 17, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'ickMdsTm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'CreateDeployment' test.out

#- 16 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment 'XgJrVBju' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DeleteDeployment' test.out

#- 17 UpdateDeployment
# body param: body
echo '{"allow_version_override": true, "buffer_count": 69, "buffer_percent": 42, "configuration": "lqoAR47r", "enable_region_overrides": false, "game_version": "NRfvXrgj", "max_count": 83, "min_count": 29, "regions": ["ZTxmkOlc", "KGkC7lfn", "8RYY1Bu6"], "session_timeout": 38, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'vPzYVsry' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateDeployment' test.out

#- 18 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 98, "buffer_percent": 37, "max_count": 9, "min_count": 92, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment 'kS6KcZuy' \
    --namespace $AB_NAMESPACE \
    --region 'a4Imh6GE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateRootRegionOverride' test.out

#- 19 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment '6NWfYjxv' \
    --namespace $AB_NAMESPACE \
    --region '301Ipynh' \
    > test.out 2>&1
eval_tap $? 19 'DeleteRootRegionOverride' test.out

#- 20 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 61, "buffer_percent": 40, "max_count": 69, "min_count": 52, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment 'wYxbEH6T' \
    --namespace $AB_NAMESPACE \
    --region 'c9mkij9G' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateRootRegionOverride' test.out

#- 21 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 80, "buffer_percent": 78, "configuration": "inP4pqpI", "enable_region_overrides": true, "game_version": "qGkjCXzF", "max_count": 45, "min_count": 49, "region_overrides": {"qxLNwCsb": {"buffer_count": 25, "buffer_percent": 68, "max_count": 50, "min_count": 39, "name": "ZMySrMon", "unlimited": false, "use_buffer_percent": false}, "N4kYZpzD": {"buffer_count": 21, "buffer_percent": 69, "max_count": 30, "min_count": 2, "name": "JGXk3VDU", "unlimited": false, "use_buffer_percent": true}, "aJhlNDCk": {"buffer_count": 46, "buffer_percent": 3, "max_count": 28, "min_count": 96, "name": "mH0b7Tna", "unlimited": false, "use_buffer_percent": false}}, "regions": ["j4udQ0Fe", "YT7vB0Ai", "6vmfC3vK"], "session_timeout": 94, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment '0ljRRmH0' \
    --namespace $AB_NAMESPACE \
    --version 'MMlxNPBG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateDeploymentOverride' test.out

#- 22 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment 'WNt4kqS6' \
    --namespace $AB_NAMESPACE \
    --version 'hGOERQwW' \
    > test.out 2>&1
eval_tap $? 22 'DeleteDeploymentOverride' test.out

#- 23 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 39, "buffer_percent": 7, "configuration": "mnSA7r6X", "enable_region_overrides": true, "game_version": "GlweJwRQ", "max_count": 43, "min_count": 0, "regions": ["QMRvlM8G", "qxPf6RX2", "VHydxaR0"], "session_timeout": 73, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment 'pH26L6hE' \
    --namespace $AB_NAMESPACE \
    --version 'PC1SzUDP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateDeploymentOverride' test.out

#- 24 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 54, "buffer_percent": 29, "max_count": 47, "min_count": 43, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment '9K4RX9L1' \
    --namespace $AB_NAMESPACE \
    --region 'bNVrKFPm' \
    --version 'i9DlbeJO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateOverrideRegionOverride' test.out

#- 25 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'SdkjweGs' \
    --namespace $AB_NAMESPACE \
    --region 'Rgb663QQ' \
    --version '9EWwdcRW' \
    > test.out 2>&1
eval_tap $? 25 'DeleteOverrideRegionOverride' test.out

#- 26 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 92, "buffer_percent": 52, "max_count": 26, "min_count": 64, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'beQgbAwa' \
    --namespace $AB_NAMESPACE \
    --region 'iMLCO4Tl' \
    --version 'Vhyswsth' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateOverrideRegionOverride' test.out

#- 27 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $AB_NAMESPACE \
    --count '94' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 27 'GetAllPodConfig' test.out

#- 28 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'ZU1LE5N6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'GetPodConfig' test.out

#- 29 CreatePodConfig
# body param: body
echo '{"cpu_limit": 27, "mem_limit": 27, "params": "dfgum7fP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'Q85Edber' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreatePodConfig' test.out

#- 30 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'L6TFQRQy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'DeletePodConfig' test.out

#- 31 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 82, "mem_limit": 66, "name": "hSRN6E0A", "params": "FmWO8Syk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'tzE9lM8f' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'UpdatePodConfig' test.out

#- 32 AddPort
# body param: body
echo '{"port": 30}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'TJ3NwISl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AddPort' test.out

#- 33 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'HoqBvaVL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'DeletePort' test.out

#- 34 UpdatePort
# body param: body
echo '{"name": "MWkdhywa", "port": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name '9Q0v6EVd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdatePort' test.out

#- 35 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $AB_NAMESPACE \
    --q 'qZj55v3t' \
    --sortBy 'updatedAt' \
    --sortDirection 'desc' \
    --count '95' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 35 'ListImages' test.out

#- 36 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $AB_NAMESPACE \
    --imageURI 'GV7iPcIc' \
    --version 'FgcmtXhq' \
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
    --imageURI 'ItfY18gd' \
    --version 'tvC3iUTn' \
    --versionPatch 'GDBSuxpl' \
    > test.out 2>&1
eval_tap $? 39 'DeleteImagePatch' test.out

#- 40 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $AB_NAMESPACE \
    --version 'zSWUUzX5' \
    > test.out 2>&1
eval_tap $? 40 'GetImageDetail' test.out

#- 41 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $AB_NAMESPACE \
    --version 'tWEjK0ec' \
    > test.out 2>&1
eval_tap $? 41 'GetImagePatches' test.out

#- 42 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $AB_NAMESPACE \
    --version 'oL6DrFAZ' \
    --versionPatch '16hCpTbA' \
    > test.out 2>&1
eval_tap $? 42 'GetImagePatchDetail' test.out

#- 43 ListServer
$CLI_EXE \
    --sn dsmc \
    --op ListServer \
    --namespace $AB_NAMESPACE \
    --region '2Je17sFv' \
    --count '42' \
    --offset '54' \
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
    --region 'mIrITdo3' \
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
    --name 'qzw2l5pi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'DeleteLocalServer' test.out

#- 48 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $AB_NAMESPACE \
    --podName 'uZG98zQX' \
    > test.out 2>&1
eval_tap $? 48 'GetServer' test.out

#- 49 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $AB_NAMESPACE \
    --podName 'oZs9vTRd' \
    > test.out 2>&1
eval_tap $? 49 'DeleteServer' test.out

#- 50 GetServerLogs
$CLI_EXE \
    --sn dsmc \
    --op GetServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'sCJei005' \
    > test.out 2>&1
eval_tap $? 50 'GetServerLogs' test.out

#- 51 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $AB_NAMESPACE \
    --region 'QJu7x7Ck' \
    --withServer 'false' \
    --count '4' \
    --offset '14' \
    > test.out 2>&1
eval_tap $? 51 'ListSession' test.out

#- 52 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $AB_NAMESPACE \
    --region 'RXZ1kSlA' \
    > test.out 2>&1
eval_tap $? 52 'CountSession' test.out

#- 53 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'GiEc8X19' \
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

#- 56 ImageLimitClient
$CLI_EXE \
    --sn dsmc \
    --op ImageLimitClient \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'ImageLimitClient' test.out

#- 57 ImageDetailClient
$CLI_EXE \
    --sn dsmc \
    --op ImageDetailClient \
    --namespace $AB_NAMESPACE \
    --version 'GlRwJqlX' \
    > test.out 2>&1
eval_tap $? 57 'ImageDetailClient' test.out

#- 58 DeregisterLocalServer
# body param: body
echo '{"name": "fKlcJ2ug"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'DeregisterLocalServer' test.out

#- 59 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "cRAfK3cd", "ip": "3QtEFhJ2", "name": "SZwxoHaq", "port": 66}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'RegisterLocalServer' test.out

#- 60 RegisterServer
# body param: body
echo '{"custom_attribute": "DcSXc9hj", "pod_name": "ByVvYwK6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'RegisterServer' test.out

#- 61 ShutdownServer
# body param: body
echo '{"kill_me": true, "pod_name": "sorWEFcD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ShutdownServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'ShutdownServer' test.out

#- 62 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $AB_NAMESPACE \
    --podName 'o2sOhAQ4' \
    > test.out 2>&1
eval_tap $? 62 'GetServerSession' test.out

#- 63 CreateSession
# body param: body
echo '{"client_version": "scXd62UX", "configuration": "4ptZBmzY", "deployment": "KitXquZd", "game_mode": "RiT0YCuG", "matching_allies": [{"matching_parties": [{"party_attributes": {"olOkA30W": {}, "Il2VurRb": {}, "H0S4ilvF": {}}, "party_id": "kUlawCkM", "party_members": [{"user_id": "OuOez892"}, {"user_id": "cNXdDYQs"}, {"user_id": "7fk3661y"}]}, {"party_attributes": {"es25X7E7": {}, "Gq2DBWFA": {}, "jvnmdWS8": {}}, "party_id": "Csw7zf5u", "party_members": [{"user_id": "9tawSdRI"}, {"user_id": "kowNCzeL"}, {"user_id": "3QIZ9NvO"}]}, {"party_attributes": {"hj2PL77R": {}, "Xqzuz2sE": {}, "pJRNm2wc": {}}, "party_id": "KT9CM2nC", "party_members": [{"user_id": "1n0AkQJ5"}, {"user_id": "82lhh7y9"}, {"user_id": "aJiJYaS5"}]}]}, {"matching_parties": [{"party_attributes": {"hWS7YvRr": {}, "x00AAPvr": {}, "scUaOVcU": {}}, "party_id": "o0ftPDWA", "party_members": [{"user_id": "ALubSaNO"}, {"user_id": "1qUT3LNS"}, {"user_id": "ASAcMXUL"}]}, {"party_attributes": {"NvjfqQ0K": {}, "fHEr0XA1": {}, "gObZZ4NQ": {}}, "party_id": "NzU4hyIu", "party_members": [{"user_id": "peMSPisk"}, {"user_id": "6dsSxYR9"}, {"user_id": "GLaQ9zW9"}]}, {"party_attributes": {"Dy2rvQ8b": {}, "5z32bTV5": {}, "D8mLEMAv": {}}, "party_id": "cHvEdLj8", "party_members": [{"user_id": "J4jH2g3K"}, {"user_id": "MohRb6aa"}, {"user_id": "w11FGw1y"}]}]}, {"matching_parties": [{"party_attributes": {"R7C0FcXb": {}, "P5WMal9t": {}, "l1BQrBdM": {}}, "party_id": "Uu3Tob7p", "party_members": [{"user_id": "wdrPW2Fz"}, {"user_id": "c8UzJAw1"}, {"user_id": "Lz79zUCj"}]}, {"party_attributes": {"fuezmp7Q": {}, "ky2ye42v": {}, "KzVS4TnV": {}}, "party_id": "uRs9gw1D", "party_members": [{"user_id": "hzIIQelO"}, {"user_id": "e55fVHcc"}, {"user_id": "PyFR8aHJ"}]}, {"party_attributes": {"ulzunaYd": {}, "YRJ3fHxJ": {}, "qXxRXwyL": {}}, "party_id": "V7XSUOQA", "party_members": [{"user_id": "AsqiwA2T"}, {"user_id": "ApiNFXAH"}, {"user_id": "uDUAFdr1"}]}]}], "namespace": "RIuE3LAz", "notification_payload": {}, "pod_name": "vh179vUS", "region": "in71hoNu", "session_id": "ygvLe3As"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'CreateSession' test.out

#- 64 ClaimServer
# body param: body
echo '{"session_id": "Ds9jrqfA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ClaimServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'ClaimServer' test.out

#- 65 GetSession
$CLI_EXE \
    --sn dsmc \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID '7uiBmIZZ' \
    > test.out 2>&1
eval_tap $? 65 'GetSession' test.out

#- 66 GetDefaultProvider
$CLI_EXE \
    --sn dsmc \
    --op GetDefaultProvider \
    > test.out 2>&1
eval_tap $? 66 'GetDefaultProvider' test.out

#- 67 ListProviders
$CLI_EXE \
    --sn dsmc \
    --op ListProviders \
    > test.out 2>&1
eval_tap $? 67 'ListProviders' test.out

#- 68 ListProvidersByRegion
$CLI_EXE \
    --sn dsmc \
    --op ListProvidersByRegion \
    --region 'kBXRbM8D' \
    > test.out 2>&1
eval_tap $? 68 'ListProvidersByRegion' test.out

#- 69 PublicGetMessages
$CLI_EXE \
    --sn dsmc \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 69 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE