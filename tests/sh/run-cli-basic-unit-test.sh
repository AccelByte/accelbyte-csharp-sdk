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

OPERATIONS_COUNT=57

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

#- 1 GetNamespaces
$CLI_EXE \
    --sn basic \
    --op GetNamespaces \
    --activeOnly 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'GetNamespaces'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 CreateNamespace
# body param: body
echo '{"displayName": "0Cjv4Ax7", "namespace": "NzYkoppa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateNamespace \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetNamespace
$CLI_EXE \
    --sn basic \
    --op GetNamespace \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'GetNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 4 DeleteNamespace
$CLI_EXE \
    --sn basic \
    --op DeleteNamespace \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 5 GetActions
$CLI_EXE \
    --sn basic \
    --op GetActions \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetActions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 BanUsers
# body param: body
echo '{"actionId": 63, "comment": "JAhHwTb5", "userIds": ["q010gN2M"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op BanUsers \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BanUsers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 GetBannedUsers
$CLI_EXE \
    --sn basic \
    --op GetBannedUsers \
    --namespace $TEST_NAMESPACE \
    --userIds '["QrbpeRnx"]' \
    >$TEMP_FILE 2>&1
update_status $? 'GetBannedUsers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 8 ReportUser
# body param: body
echo '{"category": "TlCTFSMI", "description": "bl1a2jXL", "gameSessionId": "CtWmHJBi", "subcategory": "9SoMkSE4", "userId": "eJelwO4K"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ReportUser \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ReportUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 GetUserStatus
$CLI_EXE \
    --sn basic \
    --op GetUserStatus \
    --namespace $TEST_NAMESPACE \
    --userId 'PMky2h8R' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 UnBanUsers
# body param: body
echo '{"comment": "2fIXoXP8", "userIds": ["gd7JUabY"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UnBanUsers \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UnBanUsers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 UpdateNamespace
# body param: body
echo '{"displayName": "c3GMbxTl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateNamespace \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetConfig
$CLI_EXE \
    --sn basic \
    --op GetConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 DeleteConfig
$CLI_EXE \
    --sn basic \
    --op DeleteConfig \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 UpdateConfig
# body param: body
echo '{"apiKey": "m1fsu6J3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateConfig'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 GeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUploadUrl \
    --folder 'C4s5ppGR' \
    --namespace $TEST_NAMESPACE \
    --fileType '9XcoxYTG' \
    >$TEMP_FILE 2>&1
update_status $? 'GeneratedUploadUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 GetCountries
$CLI_EXE \
    --sn basic \
    --op GetCountries \
    --namespace $TEST_NAMESPACE \
    --lang 'gewrLfwv' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCountries'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 GetCountryGroups
$CLI_EXE \
    --sn basic \
    --op GetCountryGroups \
    --namespace $TEST_NAMESPACE \
    --groupCode 'zJF4TpbN' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCountryGroups'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 AddCountryGroup
# body param: body
echo '{"countries": [{"code": "hKq2xdmg", "name": "EBepFHtf"}], "countryGroupCode": "6ZiegqdE", "countryGroupName": "L4fsM6nB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AddCountryGroup \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddCountryGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 UpdateCountryGroup
# body param: body
echo '{"countries": [{"code": "zRVuC1r7", "name": "UH1Liu7U"}], "countryGroupName": "Q0304McK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCountryGroup \
    --countryGroupCode '873tRtr5' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCountryGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 DeleteCountryGroup
$CLI_EXE \
    --sn basic \
    --op DeleteCountryGroup \
    --countryGroupCode 'cfWO5JJ2' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteCountryGroup'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 GetLanguages
$CLI_EXE \
    --sn basic \
    --op GetLanguages \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetLanguages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 GetTimeZones
$CLI_EXE \
    --sn basic \
    --op GetTimeZones \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetTimeZones'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 23 AdminGetUserProfilePublicInfoByIds
# body param: body
echo '{"userIds": ["c6vsOns4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AdminGetUserProfilePublicInfoByIds \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserProfilePublicInfoByIds'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 GetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op GetNamespacePublisher \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetNamespacePublisher'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 ChangeNamespaceStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ChangeNamespaceStatus \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ChangeNamespaceStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 AnonymizeUserProfile
$CLI_EXE \
    --sn basic \
    --op AnonymizeUserProfile \
    --namespace $TEST_NAMESPACE \
    --userId 'NWGc7CiU' \
    >$TEMP_FILE 2>&1
update_status $? 'AnonymizeUserProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 GeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUserUploadContentUrl \
    --namespace $TEST_NAMESPACE \
    --userId 'a4wM5Eu3' \
    --fileType 'VqymsFXp' \
    >$TEMP_FILE 2>&1
update_status $? 'GeneratedUserUploadContentUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 GetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfo \
    --namespace $TEST_NAMESPACE \
    --userId 'orMqEDR8' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserProfileInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 UpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "E72XMKfh", "avatarSmallUrl": "l6eq2FzU", "avatarUrl": "3VL3LNmP", "customAttributes": {"LeZdoCXf": {}}, "dateOfBirth": "1971-01-11", "firstName": "FXzvjLma", "language": "i7fPKvE2", "lastName": "Z4a63UVt", "status": "ACTIVE", "timeZone": "QSWtsyz0", "zipCode": "mGGyHHFI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfile \
    --namespace $TEST_NAMESPACE \
    --userId 'lIKsXgvS' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 DeleteUserProfile
$CLI_EXE \
    --sn basic \
    --op DeleteUserProfile \
    --namespace $TEST_NAMESPACE \
    --userId 'rkEgTYVk' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 31 GetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetCustomAttributesInfo \
    --namespace $TEST_NAMESPACE \
    --userId '5iRBE6zJ' \
    >$TEMP_FILE 2>&1
update_status $? 'GetCustomAttributesInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 32 UpdateCustomAttributesPartially
# body param: body
echo '{"J1BRHrfC": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCustomAttributesPartially \
    --namespace $TEST_NAMESPACE \
    --userId 'Hqqp2GwP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCustomAttributesPartially'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 33 GetPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetPrivateCustomAttributesInfo \
    --namespace $TEST_NAMESPACE \
    --userId 'cmzSuY8w' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPrivateCustomAttributesInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 UpdatePrivateCustomAttributesPartially
# body param: body
echo '{"9VYwBEfR": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdatePrivateCustomAttributesPartially \
    --namespace $TEST_NAMESPACE \
    --userId 'XoZLfpVF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdatePrivateCustomAttributesPartially'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 UpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfileStatus \
    --namespace $TEST_NAMESPACE \
    --userId 'DwjHHCW2' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserProfileStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 PublicGetTime
$CLI_EXE \
    --sn basic \
    --op PublicGetTime \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetTime'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 37 PublicGetNamespaces
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespaces \
    --activeOnly 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetNamespaces'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 PublicGeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUploadUrl \
    --folder '5u8z9yrp' \
    --namespace $TEST_NAMESPACE \
    --fileType 'JdIx5vvH' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGeneratedUploadUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 PublicGetCountries
$CLI_EXE \
    --sn basic \
    --op PublicGetCountries \
    --namespace $TEST_NAMESPACE \
    --lang 'S3d6PKPE' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCountries'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 PublicGetLanguages
$CLI_EXE \
    --sn basic \
    --op PublicGetLanguages \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetLanguages'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 PublicGetTimeZones
$CLI_EXE \
    --sn basic \
    --op PublicGetTimeZones \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetTimeZones'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 PublicGetUserProfilePublicInfoByIds
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfoByIds \
    --namespace $TEST_NAMESPACE \
    --userIds '27mI6Px8' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserProfilePublicInfoByIds'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 43 PublicGetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespacePublisher \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetNamespacePublisher'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 GetMyProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetMyProfileInfo \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetMyProfileInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 UpdateMyProfile
# body param: body
echo '{"avatarLargeUrl": "jt8Lq4x0", "avatarSmallUrl": "F7Ncocel", "avatarUrl": "JjtlKYu8", "customAttributes": {"iCPznx0s": {}}, "dateOfBirth": "1999-07-17", "firstName": "T51oV4HT", "language": "mivmb6tP", "lastName": "mCirkhYv", "privateCustomAttributes": {"cOUucjPW": {}}, "timeZone": "GwPsvjLK", "zipCode": "1CjPt93u"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyProfile \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateMyProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 CreateMyProfile
# body param: body
echo '{"avatarLargeUrl": "tbMkpUFH", "avatarSmallUrl": "T0fL9q9S", "avatarUrl": "MNAUQVoi", "customAttributes": {"QtSQC2kN": {}}, "dateOfBirth": "1993-05-24", "firstName": "mT0d2aBG", "language": "4zA2zp1L", "lastName": "s0bD6dGg", "privateCustomAttributes": {"wkYgHzKu": {}}, "timeZone": "I2RJrboP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateMyProfile \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateMyProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 GetMyZipCode
$CLI_EXE \
    --sn basic \
    --op GetMyZipCode \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetMyZipCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 UpdateMyZipCode
# body param: userZipCodeUpdate
echo '{"zipCode": "7kfpIlet"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyZipCode \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateMyZipCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 PublicReportUser
# body param: body
echo '{"category": "XrCK1UVO", "description": "0jcs7nCq", "gameSessionId": "sodoTFTc", "subcategory": "WlaIBJAA", "userId": "knU6HobZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicReportUser \
    --namespace $TEST_NAMESPACE \
    --userId 'gWlaLned' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicReportUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 PublicGeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUserUploadContentUrl \
    --namespace $TEST_NAMESPACE \
    --userId 'DfasTc8g' \
    --fileType 'r2znWqD6' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGeneratedUserUploadContentUrl'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 PublicGetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfo \
    --namespace $TEST_NAMESPACE \
    --userId 'tIcfI5Z4' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserProfileInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 PublicUpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "tUNQ7mQP", "avatarSmallUrl": "jCalZgFV", "avatarUrl": "EQyqav09", "customAttributes": {"OYmxCvMq": {}}, "dateOfBirth": "1994-01-16", "firstName": "Xs2OqNz8", "language": "ZLBsncbR", "lastName": "rf6uEdjU", "timeZone": "nr04WZNh", "zipCode": "gEGvqKWQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfile \
    --namespace $TEST_NAMESPACE \
    --userId 'TkE65j61' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 PublicCreateUserProfile
# body param: body
echo '{"avatarLargeUrl": "86p0Wfsn", "avatarSmallUrl": "WZuUPsaR", "avatarUrl": "nVdrdBA2", "customAttributes": {"hXwYyzZM": {}}, "dateOfBirth": "1972-04-05", "firstName": "R4cL76hn", "language": "FDgTfofH", "lastName": "dfoSqDca", "timeZone": "FhOc1oKx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicCreateUserProfile \
    --namespace $TEST_NAMESPACE \
    --userId 'I8f5ocfy' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserProfile'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 PublicGetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetCustomAttributesInfo \
    --namespace $TEST_NAMESPACE \
    --userId '4EIxwBiB' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCustomAttributesInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 PublicUpdateCustomAttributesPartially
# body param: body
echo '{"90vdgS5Y": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateCustomAttributesPartially \
    --namespace $TEST_NAMESPACE \
    --userId 'pKsdbpiU' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateCustomAttributesPartially'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 56 PublicGetUserProfilePublicInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfo \
    --namespace $TEST_NAMESPACE \
    --userId '2UfyMO4D' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserProfilePublicInfo'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 PublicUpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfileStatus \
    --namespace $TEST_NAMESPACE \
    --userId 'L9fBKJvj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserProfileStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT