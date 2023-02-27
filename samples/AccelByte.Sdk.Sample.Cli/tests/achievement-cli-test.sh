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
echo "1..27"

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
    --global 'false' \
    --limit '76' \
    --offset '66' \
    --sortBy 'updatedAt:desc' \
    --tags '["q5ArHFn6", "03zFSf3O", "95c2AleS"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAchievements' test.out

#- 3 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "YiyEDlRr", "defaultLanguage": "5rBWx99Y", "description": {"ISjihx7D": "7VC3cuuj", "KSgWOKfw": "rq80YspV", "9UA5942v": "Y5GY7L9S"}, "global": true, "goalValue": 0.8863888714210474, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "azlmZQ0B", "url": "5wXCXRdp"}, {"slug": "qPYmvErv", "url": "mCtt2R6o"}, {"slug": "E0UDyLQu", "url": "2UIbf5Rx"}], "name": {"cmqiGTSo": "naKfgbN2", "AkGynBsi": "o70FXwNi", "MH7NjCAy": "h4eq6ih1"}, "statCode": "sfc8iVc0", "tags": ["njReMfox", "nV36a2If", "NowL8DSO"], "unlockedIcons": [{"slug": "Nyahabzh", "url": "03SYqhu9"}, {"slug": "UNwsmVPy", "url": "dnKMs0On"}, {"slug": "KHYLtS7T", "url": "6IyoTDOs"}]}' > $TEMP_JSON_INPUT
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
    --tags '["GbGWwsGK", "wUn2YBzj", "gPeC42iX"]' \
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
    --strategy 'qmGiAprP' \
    > test.out 2>&1
eval_tap $? 5 'ImportAchievements' test.out

#- 6 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode 'vlMtsBWE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAchievement' test.out

#- 7 AdminUpdateAchievement
# body param: body
echo '{"defaultLanguage": "TtCRULrs", "description": {"HF0QU9OS": "9BAxjcKN", "TcMBY8Zs": "UeBIu8x5", "bmQUpSVE": "okVY4uiM"}, "global": true, "goalValue": 0.9127728684777668, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "I5LDCn7Y", "url": "xXdLKrsP"}, {"slug": "vLnBnNfy", "url": "jUPjePac"}, {"slug": "fmg42TaE", "url": "5whbwtHM"}], "name": {"aXxSjgOW": "o3hR4UG7", "wEUYB5nO": "VB1pWOkL", "XWnhmbOV": "3xY60EvJ"}, "statCode": "fdjCPmu8", "tags": ["uQqA1Jew", "pEVB8Zo6", "AVpBpqDA"], "unlockedIcons": [{"slug": "myvqGkss", "url": "FYzg6pGz"}, {"slug": "rhWO2VuS", "url": "0k262w1a"}, {"slug": "px9ubmTd", "url": "RSpuKZLe"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode 'R0RZSmg9' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateAchievement' test.out

#- 8 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode 'QBjqIfw0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteAchievement' test.out

#- 9 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 64}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode '5U5592v1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateAchievementListOrder' test.out

#- 10 AdminListGlobalAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListGlobalAchievements \
    --namespace $AB_NAMESPACE \
    --achievementCodes 'WKOPgnMl' \
    --limit '58' \
    --offset '64' \
    --sortBy 'ViDgYSxp' \
    --status 'CMzahm1M' \
    --tags '["6ujUz6am", "iTNk0AcF", "tC3bKID4"]' \
    > test.out 2>&1
eval_tap $? 10 'AdminListGlobalAchievements' test.out

#- 11 AdminListGlobalAchievementContributors
$CLI_EXE \
    --sn achievement \
    --op AdminListGlobalAchievementContributors \
    --achievementCode 'snuQHQwg' \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --offset '13' \
    --sortBy 'opsx4OVP' \
    > test.out 2>&1
eval_tap $? 11 'AdminListGlobalAchievementContributors' test.out

#- 12 ResetGlobalAchievement
$CLI_EXE \
    --sn achievement \
    --op ResetGlobalAchievement \
    --achievementCode 'wgauM5l7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ResetGlobalAchievement' test.out

#- 13 AdminListTags
$CLI_EXE \
    --sn achievement \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '95' \
    --name 'ESvg8t13' \
    --offset '55' \
    --sortBy 'qV2aDdpd' \
    > test.out 2>&1
eval_tap $? 13 'AdminListTags' test.out

#- 14 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId '0cRyzJBV' \
    --limit '95' \
    --offset '56' \
    --preferUnlocked 'true' \
    --sortBy 'wmDuOjDH' \
    --tags '["Zgnl3OJM", "tl5xpjad", "m2lR2wrz"]' \
    > test.out 2>&1
eval_tap $? 14 'AdminListUserAchievements' test.out

#- 15 AdminResetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminResetAchievement \
    --achievementCode 'lKxYrZET' \
    --namespace $AB_NAMESPACE \
    --userId 'sw8hEWMy' \
    > test.out 2>&1
eval_tap $? 15 'AdminResetAchievement' test.out

#- 16 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'ngbn9piJ' \
    --namespace $AB_NAMESPACE \
    --userId 'uhE7esBF' \
    > test.out 2>&1
eval_tap $? 16 'AdminUnlockAchievement' test.out

#- 17 AdminAnonymizeUserAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminAnonymizeUserAchievement \
    --namespace $AB_NAMESPACE \
    --userId 'sL2xbAYb' \
    > test.out 2>&1
eval_tap $? 17 'AdminAnonymizeUserAchievement' test.out

#- 18 AdminListUserContributions
$CLI_EXE \
    --sn achievement \
    --op AdminListUserContributions \
    --namespace $AB_NAMESPACE \
    --userId 'Bv15aNzU' \
    --achievementCodes 'a7HT47Fd' \
    --limit '3' \
    --offset '47' \
    --sortBy '9WXHb2SM' \
    --tags '["B1SGDZis", "PoGEL4Ty", "WkXuoOBA"]' \
    > test.out 2>&1
eval_tap $? 18 'AdminListUserContributions' test.out

#- 19 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $AB_NAMESPACE \
    --global 'false' \
    --limit '52' \
    --offset '56' \
    --sortBy 'updatedAt' \
    --tags '["9NHriV5d", "qEhhElYD", "wuLri8IM"]' \
    --language 'BpPUyRVj' \
    > test.out 2>&1
eval_tap $? 19 'PublicListAchievements' test.out

#- 20 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode 'iizBohJ7' \
    --namespace $AB_NAMESPACE \
    --language 'brQ5UPxv' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetAchievement' test.out

#- 21 PublicListGlobalAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListGlobalAchievements \
    --namespace $AB_NAMESPACE \
    --achievementCodes 'SIGTMIjq' \
    --limit '99' \
    --offset '89' \
    --sortBy '9XUA6P6K' \
    --status 'eNRAFrPL' \
    --tags '["Z2nxhtNq", "5JwxFDeF", "BnucIDW9"]' \
    > test.out 2>&1
eval_tap $? 21 'PublicListGlobalAchievements' test.out

#- 22 ListGlobalAchievementContributors
$CLI_EXE \
    --sn achievement \
    --op ListGlobalAchievementContributors \
    --achievementCode 'fsS2Dyru' \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '54' \
    --sortBy 'jT0MnyKz' \
    > test.out 2>&1
eval_tap $? 22 'ListGlobalAchievementContributors' test.out

#- 23 PublicListTags
$CLI_EXE \
    --sn achievement \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '100' \
    --name 'iLnPye1L' \
    --offset '46' \
    --sortBy '7xNNekC4' \
    > test.out 2>&1
eval_tap $? 23 'PublicListTags' test.out

#- 24 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'MZVz8iM4' \
    --limit '90' \
    --offset '53' \
    --preferUnlocked 'false' \
    --sortBy 'vyVlOGg0' \
    --tags '["GODLHA0N", "zJF1idD0", "owKdoTwE"]' \
    > test.out 2>&1
eval_tap $? 24 'PublicListUserAchievements' test.out

#- 25 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'ME7A3MeL' \
    --namespace $AB_NAMESPACE \
    --userId 'uxMxLkoo' \
    > test.out 2>&1
eval_tap $? 25 'PublicUnlockAchievement' test.out

#- 26 ListUserContributions
$CLI_EXE \
    --sn achievement \
    --op ListUserContributions \
    --namespace $AB_NAMESPACE \
    --userId 'TtDshPXq' \
    --achievementCodes 'kCrFME7a' \
    --limit '2' \
    --offset '34' \
    --sortBy 'khMVeAZx' \
    --tags '["QIEwqfEA", "L9l4CnjV", "PfPJ4SeS"]' \
    > test.out 2>&1
eval_tap $? 26 'ListUserContributions' test.out

#- 27 ClaimGlobalAchievementReward
$CLI_EXE \
    --sn achievement \
    --op ClaimGlobalAchievementReward \
    --achievementCode 'HeqCQlTX' \
    --namespace $AB_NAMESPACE \
    --userId 'YWXnsMeB' \
    > test.out 2>&1
eval_tap $? 27 'ClaimGlobalAchievementReward' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE