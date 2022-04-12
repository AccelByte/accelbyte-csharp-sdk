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
echo "1..15"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminListAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListAchievements \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '56' \
    --sortBy 'jv4Ax7Nz' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAchievements' test.out

#- 3 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "Ykoppa0V", "defaultLanguage": "gFJAhHwT", "description": {"b5q010gN": "2MQrbpeR"}, "goalValue": 0.20816307040117976, "hidden": false, "incremental": true, "lockedIcons": [{"slug": "TFSMIbl1", "url": "a2jXLCtW"}], "name": {"mHJBi9So": "MkSE4eJe"}, "statCode": "lwO4KPMk", "tags": ["y2h8R2fI"], "unlockedIcons": [{"slug": "XoXP8gd7", "url": "JUabYc3G"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminCreateNewAchievement \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateNewAchievement' test.out

#- 4 ExportAchievements
$CLI_EXE \
    --sn achievement \
    --op ExportAchievements \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'ExportAchievements' test.out

#- 5 ImportAchievements
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn achievement \
    --op ImportAchievements \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --strategy 'MbxTlm1f' \
    > test.out 2>&1
eval_tap $? 5 'ImportAchievements' test.out

#- 6 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode 'su6J3C4s' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAchievement' test.out

#- 7 AdminUpdateAchievement
# body param: body
echo '{"defaultLanguage": "5ppGR9Xc", "description": {"oxYTGgew": "rLfwvzJF"}, "goalValue": 0.886609202013211, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "NhKq2xdm", "url": "gEBepFHt"}], "name": {"f6Ziegqd": "EL4fsM6n"}, "statCode": "BzRVuC1r", "tags": ["7UH1Liu7"], "unlockedIcons": [{"slug": "UQ0304Mc", "url": "K873tRtr"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode '5cfWO5JJ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateAchievement' test.out

#- 8 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode '2c6vsOns' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteAchievement' test.out

#- 9 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode 'NWGc7CiU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateAchievementListOrder' test.out

#- 10 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'a4wM5Eu3' \
    --limit '94' \
    --offset '33' \
    --preferUnlocked 'True' \
    > test.out 2>&1
eval_tap $? 10 'AdminListUserAchievements' test.out

#- 11 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'msFXporM' \
    --namespace $AB_NAMESPACE \
    --userId 'qEDR8E72' \
    > test.out 2>&1
eval_tap $? 11 'AdminUnlockAchievement' test.out

#- 12 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '76' \
    --sortBy 'Kfhl6eq2' \
    --language 'FzU3VL3L' \
    > test.out 2>&1
eval_tap $? 12 'PublicListAchievements' test.out

#- 13 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode 'NmPLeZdo' \
    --namespace $AB_NAMESPACE \
    --language 'CXfabFXz' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetAchievement' test.out

#- 14 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'vjLmai7f' \
    --limit '82' \
    --offset '72' \
    --preferUnlocked 'True' \
    > test.out 2>&1
eval_tap $? 14 'PublicListUserAchievements' test.out

#- 15 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'E2Z4a63U' \
    --namespace $AB_NAMESPACE \
    --userId 'VtLbQSWt' \
    > test.out 2>&1
eval_tap $? 15 'PublicUnlockAchievement' test.out


rm -f "$CLI_TOKEN_FILE"

exit $EXIT_CODE