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
echo "1..16"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminListAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListAchievements \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --offset '53' \
    --sortBy 'listOrder:asc' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAchievements' test.out

#- 3 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "0y5yONkU", "defaultLanguage": "QCRfxkf1", "description": {"lmqB6ky4": "1Ggi3iQ2", "sZ0xBXz7": "R6O8pvkP", "q0oim0Zc": "7BRE2fG2"}, "goalValue": 0.5598912479991168, "hidden": false, "incremental": true, "lockedIcons": [{"slug": "ywU2xjPd", "url": "BQJym2bj"}, {"slug": "LwGy8QBv", "url": "llQIHOX3"}, {"slug": "mr2Eturu", "url": "r6d6wtng"}], "name": {"olKrTZYa": "zGTKiHEU", "kdPpYc6A": "GP3IvAYo", "7MZTZKzN": "dpKZWu7z"}, "statCode": "1IG6Nrm8", "tags": ["DxViy1eX", "w4XQZouz", "SrHVn1uw"], "unlockedIcons": [{"slug": "Fr4xnpzB", "url": "NlrEoHvf"}, {"slug": "dFEg2XT8", "url": "BtZiITbk"}, {"slug": "qj8Ytogu", "url": "TxUYHdof"}]}' > $TEMP_JSON_INPUT
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
    --strategy '6BNjFxMe' \
    > test.out 2>&1
eval_tap $? 5 'ImportAchievements' test.out

#- 6 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode 'HttYu6J8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAchievement' test.out

#- 7 AdminUpdateAchievement
# body param: body
echo '{"defaultLanguage": "QL92OdWd", "description": {"hHmaaRd5": "RsCAEh2q", "OBVOzFi8": "eb7qvnjM", "y85ztQOg": "EO9OLvCR"}, "goalValue": 0.10578045284397608, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "94989aKW", "url": "mVB7CmRU"}, {"slug": "az9LI6jx", "url": "0E8EoGQi"}, {"slug": "Au9ZrJiB", "url": "t36R5lqn"}], "name": {"Hrs0wc10": "azxFe0H3", "6M9ikKUT": "f5d5Fx0e", "wjA76Rvu": "rb75eNrA"}, "statCode": "kkXmEFoE", "tags": ["xqBezKFy", "uYGfWxFx", "FIf1u31x"], "unlockedIcons": [{"slug": "rxxtUed9", "url": "7xcuI5dA"}, {"slug": "NUpb3mSO", "url": "TTEN3G4w"}, {"slug": "kgQ3wFiX", "url": "NnOONPwg"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode 'EZajwXlv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateAchievement' test.out

#- 8 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode 'mEM0FCiu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteAchievement' test.out

#- 9 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 92}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode 'Uflapqe3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateAchievementListOrder' test.out

#- 10 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'ZqVUtbQK' \
    --limit '94' \
    --offset '64' \
    --preferUnlocked 'false' \
    > test.out 2>&1
eval_tap $? 10 'AdminListUserAchievements' test.out

#- 11 AdminResetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminResetAchievement \
    --achievementCode 'kxQb3lIj' \
    --namespace $AB_NAMESPACE \
    --userId '2VEZOCvT' \
    > test.out 2>&1
eval_tap $? 11 'AdminResetAchievement' test.out

#- 12 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'MG7WUzuS' \
    --namespace $AB_NAMESPACE \
    --userId 'gaJBiwbW' \
    > test.out 2>&1
eval_tap $? 12 'AdminUnlockAchievement' test.out

#- 13 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $AB_NAMESPACE \
    --limit '93' \
    --offset '23' \
    --sortBy 'listOrder:desc' \
    --language 'Oe2pn9lN' \
    > test.out 2>&1
eval_tap $? 13 'PublicListAchievements' test.out

#- 14 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode '0y1X9s8x' \
    --namespace $AB_NAMESPACE \
    --language 'Ljvcsd9H' \
    > test.out 2>&1
eval_tap $? 14 'PublicGetAchievement' test.out

#- 15 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'dWiWVgPT' \
    --limit '7' \
    --offset '58' \
    --preferUnlocked 'true' \
    > test.out 2>&1
eval_tap $? 15 'PublicListUserAchievements' test.out

#- 16 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'WujwcHOI' \
    --namespace $AB_NAMESPACE \
    --userId 'sTNp9VSj' \
    > test.out 2>&1
eval_tap $? 16 'PublicUnlockAchievement' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE