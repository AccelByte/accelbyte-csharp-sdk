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
    --limit '12' \
    --offset '34' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAchievements' test.out

#- 3 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "32q9ssKU", "defaultLanguage": "McTFJgwc", "description": {"PJHiYgAA": "bJNU900D", "fn4nfFMu": "hSheXgKN", "bkEeDmQt": "JzgYz3KW"}, "goalValue": 0.5671386897285937, "hidden": true, "incremental": true, "lockedIcons": [{"slug": "MWk7G1RX", "url": "FxHMGgp4"}, {"slug": "x232V91A", "url": "RNtQOuY2"}, {"slug": "yBJNFlok", "url": "3KlUuFoV"}], "name": {"zBvqdhF2": "QUbs7ZqI", "ZyhZ8kzA": "bNc1IYiP", "61om7SbR": "HjAkf64s"}, "statCode": "D6ssSwk4", "tags": ["Te1oe334", "uyIlN2Pm", "GcZfjDHF"], "unlockedIcons": [{"slug": "MlK7IGgm", "url": "U2M3f6WB"}, {"slug": "rSGwlYcT", "url": "ck7bnZDT"}, {"slug": "DCO7EqRe", "url": "Rj6RuaMC"}]}' > $TEMP_JSON_INPUT
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
    --strategy 'RwoFdWZI' \
    > test.out 2>&1
eval_tap $? 5 'ImportAchievements' test.out

#- 6 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode '34PrDVDZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAchievement' test.out

#- 7 AdminUpdateAchievement
# body param: body
echo '{"defaultLanguage": "ASGvpGyM", "description": {"oJzaJNQu": "DoUsttjX", "LfE5rFnD": "wn0SmhMh", "kCPRKabT": "9KFQ6bML"}, "goalValue": 0.2899116535451699, "hidden": false, "incremental": true, "lockedIcons": [{"slug": "RkqFBppK", "url": "VXymoWyd"}, {"slug": "YhwCBVCX", "url": "34qDjhFS"}, {"slug": "eHf7QrZE", "url": "MVHtf7t0"}], "name": {"nRUgDIjQ": "c6EIXhH0", "UusPpE81": "77IAMqrC", "TVzx3Msp": "OgWhTak3"}, "statCode": "GMoX8V1i", "tags": ["2r0K1uBQ", "ONIEbkLA", "2kunipUp"], "unlockedIcons": [{"slug": "m05DlKSi", "url": "1W3R3O3l"}, {"slug": "lCmiln99", "url": "zzbWiQTw"}, {"slug": "zR3AxdC6", "url": "rmgDKllP"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode 'Y5NicZQK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateAchievement' test.out

#- 8 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode 'dtYntMbX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteAchievement' test.out

#- 9 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode 'iooXGCmo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateAchievementListOrder' test.out

#- 10 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'jS6JdcUJ' \
    --limit '23' \
    --offset '66' \
    --preferUnlocked 'false' \
    > test.out 2>&1
eval_tap $? 10 'AdminListUserAchievements' test.out

#- 11 AdminResetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminResetAchievement \
    --achievementCode '9y0lKqO7' \
    --namespace $AB_NAMESPACE \
    --userId 'UmQ80F7A' \
    > test.out 2>&1
eval_tap $? 11 'AdminResetAchievement' test.out

#- 12 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'pmboukYx' \
    --namespace $AB_NAMESPACE \
    --userId 'Rab2Tly6' \
    > test.out 2>&1
eval_tap $? 12 'AdminUnlockAchievement' test.out

#- 13 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '4' \
    --sortBy 'updatedAt:desc' \
    --language 'jSLBByTX' \
    > test.out 2>&1
eval_tap $? 13 'PublicListAchievements' test.out

#- 14 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode 'eXSzsGP9' \
    --namespace $AB_NAMESPACE \
    --language '4MI988Z6' \
    > test.out 2>&1
eval_tap $? 14 'PublicGetAchievement' test.out

#- 15 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId '9Z4kkqsz' \
    --limit '11' \
    --offset '58' \
    --preferUnlocked 'true' \
    > test.out 2>&1
eval_tap $? 15 'PublicListUserAchievements' test.out

#- 16 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'ukWQvitr' \
    --namespace $AB_NAMESPACE \
    --userId 'e7rr61PQ' \
    > test.out 2>&1
eval_tap $? 16 'PublicUnlockAchievement' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE