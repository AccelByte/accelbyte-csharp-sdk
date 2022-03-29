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

OPERATIONS_COUNT=296

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

#- 1 GetBansType
$CLI_EXE \
    --sn iam \
    --op GetBansType \
    >$TEMP_FILE 2>&1
update_status $? 'GetBansType'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 2 GetListBanReason
$CLI_EXE \
    --sn iam \
    --op GetListBanReason \
    >$TEMP_FILE 2>&1
update_status $? 'GetListBanReason'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 3 GetClients
update_status 0 'GetClients (skipped deprecated)'

#- 4 CreateClient
update_status 0 'CreateClient (skipped deprecated)'

#- 5 GetClient
$CLI_EXE \
    --sn iam \
    --op GetClient \
    --clientId 'b0Cjv4Ax' \
    >$TEMP_FILE 2>&1
update_status $? 'GetClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 6 UpdateClient
# body param: body
echo '{"ClientName": "7NzYkopp", "RedirectUri": "a0VgFJAh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateClient \
    --clientId 'HwTb5q01' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 7 DeleteClient
update_status 0 'DeleteClient (skipped deprecated)'

#- 8 UpdateClientPermission
# body param: body
echo '{"Permissions": [{"Action": 12, "Resource": "N2MQrbpe"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateClientPermission \
    --clientId 'RnxTlCTF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateClientPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 9 AddClientPermission
$CLI_EXE \
    --sn iam \
    --op AddClientPermission \
    --action '89' \
    --clientId 'MIbl1a2j' \
    --resource 'XLCtWmHJ' \
    >$TEMP_FILE 2>&1
update_status $? 'AddClientPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 10 DeleteClientPermission
$CLI_EXE \
    --sn iam \
    --op DeleteClientPermission \
    --action '54' \
    --clientId 'i9SoMkSE' \
    --resource '4eJelwO4' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteClientPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 11 UpdateClientSecret
# body param: body
echo '{"NewSecret": "KPMky2h8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateClientSecret \
    --clientId 'R2fIXoXP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateClientSecret'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 12 GetClientsbyNamespace
$CLI_EXE \
    --sn iam \
    --op GetClientsbyNamespace \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetClientsbyNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 13 CreateClientByNamespace
# body param: body
echo '{"ClientId": "8gd7JUab", "ClientName": "Yc3GMbxT", "ClientPermissions": [{"Action": 22, "Resource": "m1fsu6J3", "SchedAction": 57, "SchedCron": "4s5ppGR9", "SchedRange": ["XcoxYTGg"]}], "Namespace": "ewrLfwvz", "RedirectUri": "JF4TpbNh", "Secret": "Kq2xdmgE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateClientByNamespace \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateClientByNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 14 DeleteClientByNamespace
$CLI_EXE \
    --sn iam \
    --op DeleteClientByNamespace \
    --clientId 'BepFHtf6' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteClientByNamespace'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 15 CreateUser
# body param: body
echo '{"AuthType": "ZiegqdEL", "Country": "4fsM6nBz", "DisplayName": "RVuC1r7U", "LoginId": "H1Liu7UQ", "Password": "0304McK8", "PasswordMD5Sum": "73tRtr5c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUser \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 16 GetAdminUsersByRoleID
$CLI_EXE \
    --sn iam \
    --op GetAdminUsersByRoleID \
    --namespace $TEST_NAMESPACE \
    --after '11' \
    --before '97' \
    --limit '80' \
    --roleId '5JJ2c6vs' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminUsersByRoleID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 17 GetUserByLoginID
$CLI_EXE \
    --sn iam \
    --op GetUserByLoginID \
    --namespace $TEST_NAMESPACE \
    --loginId 'Ons4jNWG' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserByLoginID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 18 GetUserByPlatformUserID
$CLI_EXE \
    --sn iam \
    --op GetUserByPlatformUserID \
    --namespace $TEST_NAMESPACE \
    --platformID 'c7CiUa4w' \
    --platformUserID 'M5Eu3Vqy' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserByPlatformUserID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 19 ForgotPassword
# body param: body
echo '{"Context": "msFXporM", "LanguageTag": "qEDR8E72", "LoginID": "XMKfhl6e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op ForgotPassword \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ForgotPassword'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 20 GetUsersByLoginIds
$CLI_EXE \
    --sn iam \
    --op GetUsersByLoginIds \
    --namespace $TEST_NAMESPACE \
    --loginIds 'q2FzU3VL' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUsersByLoginIds'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 21 ResetPassword
# body param: body
echo '{"Code": "3LNmPLeZ", "LoginID": "doCXfabF", "NewPassword": "XzvjLmai"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op ResetPassword \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ResetPassword'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 22 SearchUser
update_status 0 'SearchUser (skipped deprecated)'

#- 23 GetUserByUserID
$CLI_EXE \
    --sn iam \
    --op GetUserByUserID \
    --namespace $TEST_NAMESPACE \
    --userId '7fPKvE2Z' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserByUserID'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 24 UpdateUser
# body param: body
echo '{"Country": "4a63UVtL", "DateOfBirth": "bQSWtsyz", "DisplayName": "0mGGyHHF", "LanguageTag": "IlIKsXgv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateUser \
    --namespace $TEST_NAMESPACE \
    --userId 'SrkEgTYV' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 25 DeleteUser
$CLI_EXE \
    --sn iam \
    --op DeleteUser \
    --namespace $TEST_NAMESPACE \
    --userId 'k5iRBE6z' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 26 BanUser
# body param: body
echo '{"ban": "JJ1BRHrf", "comment": "CHqqp2Gw", "endDate": "PcmzSuY8", "reason": "w9VYwBEf", "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op BanUser \
    --namespace $TEST_NAMESPACE \
    --userId 'ZLfpVFfD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'BanUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 27 GetUserBanHistory
$CLI_EXE \
    --sn iam \
    --op GetUserBanHistory \
    --namespace $TEST_NAMESPACE \
    --userId 'wjHHCW2g' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserBanHistory'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 28 DisableUserBan
$CLI_EXE \
    --sn iam \
    --op DisableUserBan \
    --banId '5u8z9yrp' \
    --namespace $TEST_NAMESPACE \
    --userId 'JdIx5vvH' \
    >$TEMP_FILE 2>&1
update_status $? 'DisableUserBan'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 29 EnableUserBan
$CLI_EXE \
    --sn iam \
    --op EnableUserBan \
    --banId 'S3d6PKPE' \
    --namespace $TEST_NAMESPACE \
    --userId '27mI6Px8' \
    >$TEMP_FILE 2>&1
update_status $? 'EnableUserBan'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 30 ListCrossNamespaceAccountLink
update_status 0 'ListCrossNamespaceAccountLink (skipped deprecated)'

#- 31 DisableUser
update_status 0 'DisableUser (skipped deprecated)'

#- 32 EnableUser
update_status 0 'EnableUser (skipped deprecated)'

#- 33 GetUserInformation
$CLI_EXE \
    --sn iam \
    --op GetUserInformation \
    --namespace $TEST_NAMESPACE \
    --userId 'jt8Lq4x0' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserInformation'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 34 DeleteUserInformation
$CLI_EXE \
    --sn iam \
    --op DeleteUserInformation \
    --namespace $TEST_NAMESPACE \
    --userId 'F7Ncocel' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserInformation'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 35 GetUserLoginHistories
$CLI_EXE \
    --sn iam \
    --op GetUserLoginHistories \
    --namespace $TEST_NAMESPACE \
    --userId 'JjtlKYu8' \
    --after '0.1327360902074043' \
    --before '0.6426606729236638' \
    --limit '26' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserLoginHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 UpdatePassword
update_status 0 'UpdatePassword (skipped deprecated)'

#- 37 SaveUserPermission
# body param: body
echo '{"Permissions": [{"Action": 47, "Resource": "0s5TzT51", "SchedAction": 28, "SchedCron": "V4HTmivm", "SchedRange": ["b6tPmCir"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SaveUserPermission \
    --namespace $TEST_NAMESPACE \
    --userId 'khYvcOUu' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SaveUserPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 AddUserPermission
# body param: body
echo '{"SchedAction": 5, "SchedCron": "jPWGwPsv", "SchedRange": ["jLK1CjPt"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddUserPermission \
    --action '40' \
    --namespace $TEST_NAMESPACE \
    --resource 'tbMkpUFH' \
    --userId 'T0fL9q9S' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddUserPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 39 DeleteUserPermission
$CLI_EXE \
    --sn iam \
    --op DeleteUserPermission \
    --action '77' \
    --namespace $TEST_NAMESPACE \
    --resource 'NAUQVoiQ' \
    --userId 'tSQC2kNS' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 40 GetUserPlatformAccounts
$CLI_EXE \
    --sn iam \
    --op GetUserPlatformAccounts \
    --namespace $TEST_NAMESPACE \
    --userId 'smT0d2aB' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserPlatformAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 41 GetUserMapping
$CLI_EXE \
    --sn iam \
    --op GetUserMapping \
    --namespace $TEST_NAMESPACE \
    --targetNamespace 'G4zA2zp1' \
    --userId 'Ls0bD6dG' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserMapping'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 42 GetUserJusticePlatformAccount
update_status 0 'GetUserJusticePlatformAccount (skipped deprecated)'

#- 43 PlatformLink
$CLI_EXE \
    --sn iam \
    --op PlatformLink \
    --namespace $TEST_NAMESPACE \
    --platformId 'gwkYgHzK' \
    --userId 'uI2RJrbo' \
    --ticket 'P7kfpIle' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformLink'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 44 PlatformUnlink
$CLI_EXE \
    --sn iam \
    --op PlatformUnlink \
    --namespace $TEST_NAMESPACE \
    --platformId 'tXrCK1UV' \
    --userId 'O0jcs7nC' \
    --platform_namespace 'qsodoTFT' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformUnlink'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 45 GetPublisherUser
$CLI_EXE \
    --sn iam \
    --op GetPublisherUser \
    --namespace $TEST_NAMESPACE \
    --userId 'cWlaIBJA' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublisherUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 SaveUserRoles
# body param: body
echo '["AknU6Hob"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SaveUserRoles \
    --namespace $TEST_NAMESPACE \
    --userId 'ZgWlaLne' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SaveUserRoles'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 47 AddUserRole
$CLI_EXE \
    --sn iam \
    --op AddUserRole \
    --namespace $TEST_NAMESPACE \
    --roleId 'dDfasTc8' \
    --userId 'gr2znWqD' \
    >$TEMP_FILE 2>&1
update_status $? 'AddUserRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 48 DeleteUserRole
$CLI_EXE \
    --sn iam \
    --op DeleteUserRole \
    --namespace $TEST_NAMESPACE \
    --roleId '6tIcfI5Z' \
    --userId '4tUNQ7mQ' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 UpgradeHeadlessAccount
# body param: body
echo '{"LoginID": "PjCalZgF", "Password": "VEQyqav0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpgradeHeadlessAccount \
    --namespace $TEST_NAMESPACE \
    --userId '9OYmxCvM' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpgradeHeadlessAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 UpgradeHeadlessAccountWithVerificationCode
# body param: body
echo '{"Code": "qVcXs2Oq", "Password": "Nz8ZLBsn", "loginId": "cbRrf6uE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpgradeHeadlessAccountWithVerificationCode \
    --namespace $TEST_NAMESPACE \
    --userId 'djUnr04W' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpgradeHeadlessAccountWithVerificationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 UserVerification
# body param: body
echo '{"Code": "ZNhgEGvq", "ContactType": "KWQTkE65", "LanguageTag": "j6186p0W", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UserVerification \
    --namespace $TEST_NAMESPACE \
    --userId 'snWZuUPs' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UserVerification'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 52 SendVerificationCode
# body param: body
echo '{"Context": "aRnVdrdB", "LanguageTag": "A2hXwYyz", "LoginID": "ZMdlR4cL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SendVerificationCode \
    --namespace $TEST_NAMESPACE \
    --userId '76hnFDgT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SendVerificationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 53 Authorization
$CLI_EXE \
    --sn iam \
    --op Authorization \
    --login 'fofHdfoS' \
    --password 'qDcaFhOc' \
    --scope '1oKxI8f5' \
    --state 'ocfy4EIx' \
    --client_id 'wBiB90vd' \
    --redirect_uri 'gS5YpKsd' \
    --response_type 'code' \
    >$TEMP_FILE 2>&1
update_status $? 'Authorization'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 54 GetJWKS
$CLI_EXE \
    --sn iam \
    --op GetJWKS \
    >$TEMP_FILE 2>&1
update_status $? 'GetJWKS'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 55 PlatformTokenRequestHandler
update_status 0 'PlatformTokenRequestHandler (skipped deprecated)'

#- 56 RevokeUser
$CLI_EXE \
    --sn iam \
    --op RevokeUser \
    --namespace $TEST_NAMESPACE \
    --userId 'piU2UfyM' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 57 GetRevocationList
$CLI_EXE \
    --sn iam \
    --op GetRevocationList \
    >$TEMP_FILE 2>&1
update_status $? 'GetRevocationList'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 58 RevokeToken
update_status 0 'RevokeToken (skipped deprecated)'

#- 59 RevokeAUser
update_status 0 'RevokeAUser (skipped deprecated)'

#- 60 TokenGrant
$CLI_EXE \
    --sn iam \
    --op TokenGrant \
    --code 'O4DhL9fB' \
    --extend_exp 'True' \
    --namespace 'jBOUn3bY' \
    --password 'f5ouXqkb' \
    --redirect_uri 'iExqT6Dk' \
    --refresh_token '9QFqaAjh' \
    --username 'wOI1P04d' \
    --grant_type 'authorization_code' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenGrant'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 61 VerifyToken
$CLI_EXE \
    --sn iam \
    --op VerifyToken \
    --token 'TwrxBRfM' \
    >$TEMP_FILE 2>&1
update_status $? 'VerifyToken'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 62 GetRoles
$CLI_EXE \
    --sn iam \
    --op GetRoles \
    --isWildcard 'xZrSfx3V' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRoles'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 63 CreateRole
# body param: body
echo '{"AdminRole": false, "Managers": [{"DisplayName": "Mng7p2Sy", "Namespace": "FDEnmYQz", "UserId": "ehPBqD12"}], "Members": [{"DisplayName": "DvvzNNZS", "Namespace": "u5zZVgY3", "UserId": "Zosfd01v"}], "Permissions": [{"Action": 0, "Resource": "OGweHacv", "SchedAction": 66, "SchedCron": "RV345xB8", "SchedRange": ["hos4yaOB"]}], "RoleName": "jMxizCxx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateRole \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 64 GetRole
$CLI_EXE \
    --sn iam \
    --op GetRole \
    --roleId '9qTOIKlp' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 65 UpdateRole
# body param: body
echo '{"RoleName": "drqo2smD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateRole \
    --roleId '9RPpjOWK' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 66 DeleteRole
$CLI_EXE \
    --sn iam \
    --op DeleteRole \
    --roleId '0k76i1g7' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 67 GetRoleAdminStatus
$CLI_EXE \
    --sn iam \
    --op GetRoleAdminStatus \
    --roleId 'rYaEuNCy' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRoleAdminStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 68 SetRoleAsAdmin
$CLI_EXE \
    --sn iam \
    --op SetRoleAsAdmin \
    --roleId 'PoQ0oHYX' \
    >$TEMP_FILE 2>&1
update_status $? 'SetRoleAsAdmin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 69 RemoveRoleAdmin
$CLI_EXE \
    --sn iam \
    --op RemoveRoleAdmin \
    --roleId 'UQdtIkAk' \
    >$TEMP_FILE 2>&1
update_status $? 'RemoveRoleAdmin'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 70 GetRoleManagers
$CLI_EXE \
    --sn iam \
    --op GetRoleManagers \
    --roleId 'ltd1zQBz' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRoleManagers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 71 AddRoleManagers
# body param: body
echo '{"Managers": [{"DisplayName": "zC6ldKri", "Namespace": "I6lTRbc1", "UserId": "Z1HJHzl3"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddRoleManagers \
    --roleId '23Ynwf5P' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddRoleManagers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 72 RemoveRoleManagers
# body param: body
echo '{"Managers": [{"DisplayName": "vGejCDgA", "Namespace": "r1pXDcsH", "UserId": "nobnaYxG"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op RemoveRoleManagers \
    --roleId 'h3FovBnr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RemoveRoleManagers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 73 GetRoleMembers
$CLI_EXE \
    --sn iam \
    --op GetRoleMembers \
    --roleId '5VUOHGqE' \
    >$TEMP_FILE 2>&1
update_status $? 'GetRoleMembers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 74 AddRoleMembers
# body param: body
echo '{"Members": [{"DisplayName": "cuJYo3Yf", "Namespace": "MDw4PaBK", "UserId": "sFXorxY0"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddRoleMembers \
    --roleId 'ahG5AgHr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddRoleMembers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 75 RemoveRoleMembers
# body param: body
echo '{"Members": [{"DisplayName": "E98qQTSX", "Namespace": "h1W7MnK2", "UserId": "i8Ely255"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op RemoveRoleMembers \
    --roleId 'awvulbNG' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'RemoveRoleMembers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 76 UpdateRolePermissions
# body param: body
echo '{"Permissions": [{"Action": 88, "Resource": "AjeiiANE", "SchedAction": 90, "SchedCron": "lkncKPmr", "SchedRange": ["i36MY2aV"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateRolePermissions \
    --roleId 'CNUJgcpA' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateRolePermissions'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 77 AddRolePermission
# body param: body
echo '{"SchedAction": 3, "SchedCron": "j0fidlWP", "SchedRange": ["SAIjaw5H"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddRolePermission \
    --action '89' \
    --resource 'yDsQqMUP' \
    --roleId 'rAxUd1bm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddRolePermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 78 DeleteRolePermission
$CLI_EXE \
    --sn iam \
    --op DeleteRolePermission \
    --action '94' \
    --resource 'SM44scgN' \
    --roleId 'AZf7a3R9' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteRolePermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 79 AdminGetAgeRestrictionStatusV2
$CLI_EXE \
    --sn iam \
    --op AdminGetAgeRestrictionStatusV2 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAgeRestrictionStatusV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 80 AdminUpdateAgeRestrictionConfigV2
# body param: body
echo '{"AgeRestriction": 35, "Enable": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAgeRestrictionConfigV2 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAgeRestrictionConfigV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 81 GetListCountryAgeRestriction
$CLI_EXE \
    --sn iam \
    --op GetListCountryAgeRestriction \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetListCountryAgeRestriction'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 82 UpdateCountryAgeRestriction
# body param: body
echo '{"AgeRestriction": 58}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateCountryAgeRestriction \
    --countryCode 'XZ1fahMp' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateCountryAgeRestriction'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 83 AdminSearchUsersV2
$CLI_EXE \
    --sn iam \
    --op AdminSearchUsersV2 \
    --namespace $TEST_NAMESPACE \
    --after '688Jv5wQ' \
    --before '3hbDlcGR' \
    --displayName 'x2aExmVb' \
    --limit '99' \
    --loginId 'DomWyrFZ' \
    --platformUserId 'ZdM00sSd' \
    --roleId 'UypOvoMv' \
    --userId 'IN7cRBRx' \
    --platformId 'FsCUQz0k' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchUsersV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 84 AdminGetUserByUserIdV2
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByUserIdV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'oUsUcGfj' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByUserIdV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 85 AdminUpdateUserV2
# body param: body
echo '{"Country": "tfyuPNb5", "DateOfBirth": "exiRtR1Q", "DisplayName": "e0mxLnvZ", "LanguageTag": "EG2biyKS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId '8vfIsZ5E' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 86 AdminBanUserV2
# body param: body
echo '{"ban": "ADM0xJp6", "comment": "HXexnHAX", "endDate": "YShIg82f", "reason": "fzx6WCUd", "skipNotif": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'QnivM1tf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminBanUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 87 AdminGetUserBanV2
$CLI_EXE \
    --sn iam \
    --op AdminGetUserBanV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'IoSsKaP5' \
    --activeOnly 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserBanV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 88 AdminDisableUserV2
# body param: body
echo '{"Reason": "0UGr95D9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDisableUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'VatfxBoa' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDisableUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 89 AdminEnableUserV2
$CLI_EXE \
    --sn iam \
    --op AdminEnableUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'kHUqz2uO' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminEnableUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 90 AdminResetPasswordV2
# body param: body
echo '{"LanguageTag": "KJVjX7j5", "NewPassword": "MgRZ3kPm", "OldPassword": "SrNaFzJw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminResetPasswordV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'BceJQ0vi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminResetPasswordV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 91 AdminDeletePlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op AdminDeletePlatformLinkV2 \
    --namespace $TEST_NAMESPACE \
    --platformId 'EYQy4JxB' \
    --userId 'kyXfgwzM' \
    --platform_namespace 'TAlT2q2E' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeletePlatformLinkV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 92 AdminPutUserRolesV2
# body param: body
echo '["bG4Z95Sl"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPutUserRolesV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'dyWe2X8c' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPutUserRolesV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 93 AdminCreateUserRolesV2
# body param: body
echo '["Les0TRTA"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateUserRolesV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'ekrfR30I' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateUserRolesV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 94 PublicGetCountryAgeRestriction
$CLI_EXE \
    --sn iam \
    --op PublicGetCountryAgeRestriction \
    --countryCode 'RA6CzcXF' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCountryAgeRestriction'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 95 PublicCreateUserV2
# body param: body
echo '{"AuthType": "cjRpu7wV", "Country": "EzbwHvOG", "DisplayName": "qwb7FAI8", "LoginId": "lxDoRtwK", "Password": "NHCncWRy", "PasswordMD5Sum": "VDPNRFIb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateUserV2 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 96 PublicForgotPasswordV2
# body param: body
echo '{"Context": "OIi021vV", "LanguageTag": "F26yEKnK", "LoginID": "L26vTDvj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicForgotPasswordV2 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicForgotPasswordV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 97 PublicResetPasswordV2
# body param: body
echo '{"Code": "jj8aEPjD", "LoginID": "WSwW548h", "NewPassword": "HTuJ1jV4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicResetPasswordV2 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicResetPasswordV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 98 PublicGetUserByUserIDV2
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIDV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'EKppV4Df' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByUserIDV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 99 PublicUpdateUserV2
# body param: body
echo '{"Country": "Txfj3AGr", "DateOfBirth": "DhoJooH5", "DisplayName": "WNF4d6DE", "LanguageTag": "LnHRwigr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId '039B7fw1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 100 PublicGetUserBan
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBan \
    --namespace $TEST_NAMESPACE \
    --userId 'zHG7KQTr' \
    --activeOnly 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserBan'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 101 PublicUpdatePasswordV2
# body param: body
echo '{"LanguageTag": "Iv8R1CtN", "NewPassword": "kXpuQ4g9", "OldPassword": "IiLxJpTl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdatePasswordV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'IMuKCdAt' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdatePasswordV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 102 GetListJusticePlatformAccounts
$CLI_EXE \
    --sn iam \
    --op GetListJusticePlatformAccounts \
    --namespace $TEST_NAMESPACE \
    --userId '0XTdLLO1' \
    >$TEMP_FILE 2>&1
update_status $? 'GetListJusticePlatformAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 103 PublicPlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV2 \
    --namespace $TEST_NAMESPACE \
    --platformId 'WSvdw7FI' \
    --userId '8mOSB2rv' \
    --ticket 'QkdnYlPH' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformLinkV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 104 PublicDeletePlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op PublicDeletePlatformLinkV2 \
    --namespace $TEST_NAMESPACE \
    --platformId '6J70BXWV' \
    --userId 'txOyZzUr' \
    --platform_namespace 'VRKRtJuZ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeletePlatformLinkV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 105 AdminGetBansTypeV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBansTypeV3 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBansTypeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 106 AdminGetListBanReasonV3
$CLI_EXE \
    --sn iam \
    --op AdminGetListBanReasonV3 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListBanReasonV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 107 AdminGetInputValidations
$CLI_EXE \
    --sn iam \
    --op AdminGetInputValidations \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 108 AdminUpdateInputValidations
# body param: body
echo '[{"field": "5W7nPrKt", "validation": {"allowDigit": false, "allowLetter": false, "allowSpace": true, "allowUnicode": true, "description": [{"language": "31jYv883", "message": ["2yIJUngm"]}], "isCustomRegex": true, "letterCase": "Elr5mgz0", "maxLength": 86, "maxRepeatingAlphaNum": 48, "maxRepeatingSpecialCharacter": 65, "minCharType": 88, "minLength": 25, "regex": "nOvu24EF", "specialCharacterLocation": "zSQyIXv2", "specialCharacters": ["yW4Uka5j"]}}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateInputValidations \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 109 AdminResetInputValidations
$CLI_EXE \
    --sn iam \
    --op AdminResetInputValidations \
    --field 'sUlAifni' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminResetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 110 ListAdminsV3
$CLI_EXE \
    --sn iam \
    --op ListAdminsV3 \
    --namespace $TEST_NAMESPACE \
    --after '52mGYo0B' \
    --before 'jFUSZeNr' \
    --limit '82' \
    >$TEMP_FILE 2>&1
update_status $? 'ListAdminsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 111 AdminGetAgeRestrictionStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetAgeRestrictionStatusV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAgeRestrictionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 112 AdminUpdateAgeRestrictionConfigV3
# body param: body
echo '{"ageRestriction": 9, "enable": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAgeRestrictionConfigV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAgeRestrictionConfigV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 113 AdminGetListCountryAgeRestrictionV3
$CLI_EXE \
    --sn iam \
    --op AdminGetListCountryAgeRestrictionV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListCountryAgeRestrictionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 114 AdminUpdateCountryAgeRestrictionV3
# body param: body
echo '{"ageRestriction": 93}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateCountryAgeRestrictionV3 \
    --countryCode 'a0UxaP0K' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateCountryAgeRestrictionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 115 AdminGetBannedUsersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBannedUsersV3 \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --banType 'v68OsqOU' \
    --limit '90' \
    --offset '82' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBannedUsersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 116 AdminGetBansTypeWithNamespaceV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBansTypeWithNamespaceV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBansTypeWithNamespaceV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 117 AdminGetClientsByNamespaceV3
$CLI_EXE \
    --sn iam \
    --op AdminGetClientsByNamespaceV3 \
    --namespace $TEST_NAMESPACE \
    --limit '98' \
    --offset '51' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetClientsByNamespaceV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 118 AdminCreateClientV3
# body param: body
echo '{"audiences": ["elychmgj"], "baseUri": "LvnOWOk5", "clientId": "AekVVmTI", "clientName": "EG2ppf1f", "clientPermissions": [{"action": 66, "resource": "3NwfEQkd", "schedAction": 51, "schedCron": "I8JQzAp0", "schedRange": ["rF8gvdnF"]}], "deletable": true, "namespace": "MvoXLWNo", "oauthClientType": "QZhvPg7V", "redirectUri": "X5rUNWJa", "secret": "q1fjgDyp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateClientV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateClientV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 119 AdminGetClientsbyNamespacebyIDV3
$CLI_EXE \
    --sn iam \
    --op AdminGetClientsbyNamespacebyIDV3 \
    --clientId 'xO4ufKfU' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetClientsbyNamespacebyIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 120 AdminDeleteClientV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteClientV3 \
    --clientId '7OumxSk0' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteClientV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 121 AdminUpdateClientV3
# body param: body
echo '{"audiences": ["Ebju4dSL"], "baseUri": "x4vsb6rx", "clientName": "9Xxsu8TJ", "clientPermissions": [{"action": 66, "resource": "pdZVC6y6", "schedAction": 2, "schedCron": "9fQpa7b3", "schedRange": ["6my8LWzM"]}], "deletable": false, "namespace": "njwsIxM4", "redirectUri": "s9m2qWNv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateClientV3 \
    --clientId 'mPPlRULr' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateClientV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 122 AdminUpdateClientPermissionV3
# body param: body
echo '{"permissions": [{"action": 31, "resource": "PFCzbPX1"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateClientPermissionV3 \
    --clientId 'wwBznD7N' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateClientPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 123 AdminAddClientPermissionsV3
# body param: body
echo '{"permissions": [{"action": 74, "resource": "s7fb4sqW"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddClientPermissionsV3 \
    --clientId 'UpB4t2ie' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddClientPermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 124 AdminDeleteClientPermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteClientPermissionV3 \
    --action '52' \
    --clientId '8XRPhVzk' \
    --namespace $TEST_NAMESPACE \
    --resource 'tsWibnpB' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteClientPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 125 RetrieveAllThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 126 RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllActiveThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 127 RetrieveAllSSOLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllSSOLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --limit '72' \
    --offset '98' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllSSOLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 128 RetrieveThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'MWuoFv0q' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 129 AddThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "jBvBzZGO", "AWSCognitoRegion": "hAwcbpyb", "AWSCognitoUserPool": "Zn4ZE5Om", "AppId": "bNkHnefZ", "ClientId": "WDwi6anY", "Environment": "nQ92kVBD", "FederationMetadataURL": "kaMy03Bu", "IsActive": false, "KeyID": "4GW3V0WC", "OrganizationId": "bxvTGycc", "RedirectUri": "HSkFQzgV", "Secret": "R72Dhxbr", "TeamID": "4HtKMGr8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'tnOEeip5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 130 DeleteThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '05iJTzZu' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 131 UpdateThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "ksb4hREc", "AWSCognitoRegion": "Ox3mATUs", "AWSCognitoUserPool": "OS0e5Tma", "AppId": "pkimopcl", "ClientId": "vfm7fdu7", "Environment": "isKaWRcv", "FederationMetadataURL": "kLtfmGyS", "IsActive": true, "KeyID": "ACKa0mWW", "OrganizationId": "kDRcuLbI", "RedirectUri": "pVJnIAFp", "Secret": "X2SKNmnc", "TeamID": "DRknJort"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'wVqipgpX' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 132 UpdateThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"affectedClientIDs": ["VyWoDjOH"], "assignedNamespaces": ["rGczaXWi"], "domain": "pcAHtRkB", "roleId": "JXZwQ443"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'FfWtsTAA' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformDomainV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 133 DeleteThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"domain": "gtCnvDp2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '8TMvlTcB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteThirdPartyLoginPlatformDomainV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 134 RetrieveSSOLoginPlatformCredential
$CLI_EXE \
    --sn iam \
    --op RetrieveSSOLoginPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'aljk3sB4' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSSOLoginPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 AddSSOLoginPlatformCredential
# body param: body
echo '{"acsUrl": "LS44hWON", "apiKey": "XuXihqBV", "appId": "EXSyrZKB", "federationMetadataUrl": "vGa0Lshf", "isActive": true, "redirectUri": "rZcSsGFD", "secret": "DAiSjXH3", "ssoUrl": "ypQaqFPM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddSSOLoginPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'Ajx7edUx' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddSSOLoginPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 136 DeleteSSOLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op DeleteSSOLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'N5KMSLs2' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSSOLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 137 UpdateSSOPlatformCredential
# body param: body
echo '{"acsUrl": "1gdQU0Fh", "apiKey": "AQYQaHZ7", "appId": "WtAApJtf", "federationMetadataUrl": "B0Xt8Zcp", "isActive": true, "redirectUri": "z7BY3JPV", "secret": "nMt1HRDF", "ssoUrl": "xkSaTdIN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateSSOPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'JTdRQmMv' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSSOPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 138 AdminGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByPlatformUserIDV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'xBjpVFnE' \
    --platformUserId 'gsovZbx4' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByPlatformUserIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 139 GetAdminUsersByRoleIdV3
$CLI_EXE \
    --sn iam \
    --op GetAdminUsersByRoleIdV3 \
    --namespace $TEST_NAMESPACE \
    --roleId 'UF3pYMze' \
    --after '62' \
    --before '5' \
    --limit '37' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminUsersByRoleIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 140 AdminGetUserByEmailAddressV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByEmailAddressV3 \
    --namespace $TEST_NAMESPACE \
    --emailAddress 'BLCwhTSt' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByEmailAddressV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 141 AdminListUserIDByUserIDsV3
# body param: body
echo '{"userIds": ["BJZGkISL"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminListUserIDByUserIDsV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUserIDByUserIDsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 142 AdminInviteUserV3
# body param: body
echo '{"emailAddresses": ["9Sco6HxX"], "isAdmin": false, "roles": ["WJClH3pX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminInviteUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 143 AdminListUsersV3
$CLI_EXE \
    --sn iam \
    --op AdminListUsersV3 \
    --namespace $TEST_NAMESPACE \
    --limit '97' \
    --offset '57' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUsersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 144 AdminSearchUserV3
$CLI_EXE \
    --sn iam \
    --op AdminSearchUserV3 \
    --namespace $TEST_NAMESPACE \
    --by 'q3ysdpW3' \
    --endDate 'XyQQmftm' \
    --limit '52' \
    --offset '67' \
    --platformBy 'UHioxzVh' \
    --platformId 'zHc1rBqA' \
    --query 'Xud4JQOW' \
    --startDate 'ZBzUvNkx' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 145 AdminGetBulkUserByEmailAddressV3
# body param: body
echo '{"listEmailAddressRequest": ["TUqI2Xhb"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminGetBulkUserByEmailAddressV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBulkUserByEmailAddressV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 146 AdminGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByUserIdV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'YwTxVSXp' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 147 AdminUpdateUserV3
# body param: body
echo '{"country": "Jb2JSuHH", "dateOfBirth": "CRP9xW9V", "displayName": "eYJCDikI", "languageTag": "apumYwba", "userName": "GfsJTgob"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'WG93dH2M' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 148 AdminGetUserBanV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserBanV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'CGvohrdR' \
    --activeOnly 'True' \
    --after '6lVi7UcT' \
    --before 'mEwe9mWH' \
    --limit '98' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 149 AdminBanUserV3
# body param: body
echo '{"ban": "VfyejgTi", "comment": "2E85VnFs", "endDate": "oXaREa1W", "reason": "psZ5PoXU", "skipNotif": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'pZEPfic3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminBanUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 150 AdminUpdateUserBanV3
# body param: body
echo '{"enabled": false, "skipNotif": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserBanV3 \
    --banId '3a6kRuGq' \
    --namespace $TEST_NAMESPACE \
    --userId 'HcwZVjAQ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 151 AdminSendVerificationCodeV3
# body param: body
echo '{"context": "CkWjE3gJ", "emailAddress": "6AwW953N", "languageTag": "lFHpDCFu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSendVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --userId 't39Jhj3l' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSendVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 152 AdminVerifyAccountV3
# body param: body
echo '{"Code": "mfXJxKJN", "ContactType": "RD3KumRj", "LanguageTag": "k3wZYVb3", "validateOnly": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminVerifyAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'ssnx4JYy' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyAccountV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 153 GetUserVerificationCode
$CLI_EXE \
    --sn iam \
    --op GetUserVerificationCode \
    --namespace $TEST_NAMESPACE \
    --userId '1kXakVQo' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserVerificationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 154 AdminGetUserDeletionStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserDeletionStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'G01upsR2' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 155 AdminUpdateUserDeletionStatusV3
# body param: body
echo '{"enabled": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserDeletionStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId '2oWaCZcC' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 156 AdminUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "X2iLiQGT", "country": "L6OYjLlX", "dateOfBirth": "UV78i8cs", "displayName": "QIO0DRag", "emailAddress": "PXzsBfUh", "password": "CoGFgird", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpgradeHeadlessAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'xA5zJvQd' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpgradeHeadlessAccountV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 157 AdminDeleteUserInformationV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserInformationV3 \
    --namespace $TEST_NAMESPACE \
    --userId '2cOVXFoi' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserInformationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 158 AdminGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserLoginHistoriesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'aYaSoog7' \
    --after '0.2343848474114556' \
    --before '0.28864031030190385' \
    --limit '15' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 159 AdminUpdateUserPermissionV3
# body param: body
echo '{"Permissions": [{"Action": 43, "Resource": "XbGvqRVS", "SchedAction": 89, "SchedCron": "wvlRzdNX", "SchedRange": ["rfoKVR4H"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserPermissionV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'hlPEfSM2' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 160 AdminAddUserPermissionsV3
# body param: body
echo '{"Permissions": [{"Action": 72, "Resource": "29oqfZss", "SchedAction": 17, "SchedCron": "bgoTFQAm", "SchedRange": ["IZiTSstC"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserPermissionsV3 \
    --namespace $TEST_NAMESPACE \
    --userId '2yOumzHM' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserPermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 161 AdminDeleteUserPermissionBulkV3
# body param: body
echo '[{"Action": 15, "Resource": "Xysws3Fw"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionBulkV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'nu7OX9FZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserPermissionBulkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 162 AdminDeleteUserPermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionV3 \
    --action '43' \
    --namespace $TEST_NAMESPACE \
    --resource 'wJ8OQFuC' \
    --userId 'H68pTmT6' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 163 AdminGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserPlatformAccountsV3 \
    --namespace $TEST_NAMESPACE \
    --userId '32j8QfhN' \
    --after 'DTHb8lFv' \
    --before 'Bolf9Pdi' \
    --limit '55' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserPlatformAccountsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 164 AdminGetListJusticePlatformAccounts
$CLI_EXE \
    --sn iam \
    --op AdminGetListJusticePlatformAccounts \
    --namespace $TEST_NAMESPACE \
    --userId 'LCsT8g72' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListJusticePlatformAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 165 AdminCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op AdminCreateJusticeUser \
    --namespace $TEST_NAMESPACE \
    --targetNamespace 'thhduZnN' \
    --userId 'j9cRNlTB' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 AdminLinkPlatformAccount
# body param: body
echo '{"platformId": "xl3nKj6B", "platformUserId": "4ffgtxiP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'LdV0odbf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 AdminPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "ast4NDIB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'Ql3Uryry' \
    --userId 'OWzhhEmS' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPlatformUnlinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 168 AdminPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op AdminPlatformLinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'VFhAlEac' \
    --userId 'AAoAfsuM' \
    --ticket 'B4W3HIcv' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 AdminDeleteUserRolesV3
# body param: body
echo '["S0AL4tYC"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRolesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'wCdCigcx' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 AdminSaveUserRoleV3
# body param: body
echo '[{"namespace": "lbl30hHH", "roleId": "EjMI4Lcg"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSaveUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'kyDsccFd' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSaveUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 171 AdminAddUserRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --roleId 'vzoafMLo' \
    --userId 'raVj5RiD' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 172 AdminDeleteUserRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --roleId 'Hvo7Kepg' \
    --userId 'BTMRiEde' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 AdminUpdateUserStatusV3
# body param: body
echo '{"enabled": false, "reason": "QwLUW0VL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'upH83Aux' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 174 AdminVerifyUserWithoutVerificationCodeV3
$CLI_EXE \
    --sn iam \
    --op AdminVerifyUserWithoutVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'FEFRDTt2' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyUserWithoutVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 175 AdminGetRolesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV3 \
    --after 'mauywaKE' \
    --before 'sPBAM1au' \
    --isWildcard 'False' \
    --limit '78' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 176 AdminCreateRoleV3
# body param: body
echo '{"adminRole": true, "deletable": false, "isWildcard": false, "managers": [{"displayName": "pKGhvTKi", "namespace": "XeZepm7t", "userId": "F1wKhQ4H"}], "members": [{"displayName": "jEcagyjZ", "namespace": "ITRuoWjI", "userId": "CoCN3Nyz"}], "permissions": [{"action": 52, "resource": "V4niQQVj", "schedAction": 12, "schedCron": "DJE12W5e", "schedRange": ["oplrOXwA"]}], "roleName": "SJ1PtQux"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV3 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 177 AdminGetRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV3 \
    --roleId 'OJQKgor2' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 178 AdminDeleteRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV3 \
    --roleId 'UMJt4EJ9' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 179 AdminUpdateRoleV3
# body param: body
echo '{"deletable": false, "isWildcard": false, "roleName": "YTYxPTgp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV3 \
    --roleId 'BNsUvUKh' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 180 AdminGetRoleAdminStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleAdminStatusV3 \
    --roleId 'ANjquBEH' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleAdminStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 AdminUpdateAdminRoleStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAdminRoleStatusV3 \
    --roleId 'OJbaQpz0' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAdminRoleStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 182 AdminRemoveRoleAdminV3
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleAdminV3 \
    --roleId 'dfiuv051' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleAdminV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 183 AdminGetRoleManagersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleManagersV3 \
    --roleId 'lkPCaZsj' \
    --after 'vFvhZdwi' \
    --before '1Ti6V2uW' \
    --limit '41' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 184 AdminAddRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "CsB8FbVD", "namespace": "whpNCLl2", "userId": "bgIc1y49"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleManagersV3 \
    --roleId 'bqpbfyyt' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 AdminRemoveRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "wm6jQJpf", "namespace": "OIKCegUj", "userId": "KQRjoyn3"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleManagersV3 \
    --roleId 'bGyFGwcA' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 186 AdminGetRoleMembersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleMembersV3 \
    --roleId 'ylTi4qPF' \
    --after '190sf2Zw' \
    --before 'Pi5hI4k3' \
    --limit '73' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 AdminAddRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "wV7P8R9t", "namespace": "4dBRpBp4", "userId": "noj3J79D"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleMembersV3 \
    --roleId 'D3bAZF4n' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 AdminRemoveRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "YBuNxISm", "namespace": "VGVz9Jxj", "userId": "8wegrDo6"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleMembersV3 \
    --roleId 'OmeKL7GP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 AdminUpdateRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 29, "resource": "I9uWOFTW", "schedAction": 6, "schedCron": "RrL6yNmv", "schedRange": ["8k1w19Js"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV3 \
    --roleId 'HSqOByh4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 190 AdminAddRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 15, "resource": "hkcO6J7j", "schedAction": 88, "schedCron": "vYd4J5c6", "schedRange": ["ayFnSrfm"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV3 \
    --roleId 'ObFTUBRR' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 191 AdminDeleteRolePermissionsV3
# body param: body
echo '["DGCRQtMc"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV3 \
    --roleId '3an8ZoxL' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 192 AdminDeleteRolePermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionV3 \
    --action '44' \
    --resource 'XHS1oUzD' \
    --roleId 'dDcZ0Rj3' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 193 AdminGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op AdminGetMyUserV3 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetMyUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 194 UserAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op UserAuthenticationV3 \
    --client_id 'YM1fz9Cj' \
    --extend_exp 'True' \
    --redirect_uri 'tqeiyDCK' \
    --password '7C3u5GcP' \
    --request_id 'bmi5KiFD' \
    --user_name 'VpfvR2Wl' \
    >$TEMP_FILE 2>&1
update_status $? 'UserAuthenticationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 195 GetCountryLocationV3
$CLI_EXE \
    --sn iam \
    --op GetCountryLocationV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetCountryLocationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 196 Logout
$CLI_EXE \
    --sn iam \
    --op Logout \
    >$TEMP_FILE 2>&1
update_status $? 'Logout'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 197 AdminRetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op AdminRetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '0iShagpv' \
    --userId 'FuZu45zs' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRetrieveUserThirdPartyPlatformTokenV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 198 RevokeUserV3
$CLI_EXE \
    --sn iam \
    --op RevokeUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'rSpvMLvQ' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 AuthorizeV3
$CLI_EXE \
    --sn iam \
    --op AuthorizeV3 \
    --codeChallenge 'w3sPxFu8' \
    --codeChallengeMethod 'plain' \
    --redirectUri 'Aj6O7ivh' \
    --scope 'NIjVT5HS' \
    --state 'R00UKSLW' \
    --targetAuthPage 'WzOplTLw' \
    --clientId 'ZQZUMaAJ' \
    --responseType 'code' \
    >$TEMP_FILE 2>&1
update_status $? 'AuthorizeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 200 TokenIntrospectionV3
$CLI_EXE \
    --sn iam \
    --op TokenIntrospectionV3 \
    --token 'THYjGbVt' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenIntrospectionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 201 GetJWKSV3
$CLI_EXE \
    --sn iam \
    --op GetJWKSV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetJWKSV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 202 Change2faMethod
$CLI_EXE \
    --sn iam \
    --op Change2faMethod \
    --factor 'zsBTCOWE' \
    --mfaToken 'naLzHuYK' \
    >$TEMP_FILE 2>&1
update_status $? 'Change2faMethod'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 Verify2faCode
$CLI_EXE \
    --sn iam \
    --op Verify2faCode \
    --code 'rr89z0Rk' \
    --factor 'L932B7th' \
    --mfaToken 'DQ3hfVnP' \
    --rememberDevice 'False' \
    >$TEMP_FILE 2>&1
update_status $? 'Verify2faCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 204 RetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op RetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'K8cdZPnX' \
    --userId 'wGS9fAlx' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveUserThirdPartyPlatformTokenV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 AuthCodeRequestV3
$CLI_EXE \
    --sn iam \
    --op AuthCodeRequestV3 \
    --platformId 'tjeZUrqm' \
    --clientId 'Ic7El44M' \
    --redirectUri 'EAvaPTww' \
    --requestId 'JrG06Mtc' \
    >$TEMP_FILE 2>&1
update_status $? 'AuthCodeRequestV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 206 PlatformTokenGrantV3
$CLI_EXE \
    --sn iam \
    --op PlatformTokenGrantV3 \
    --platformId 'F7t8DQxc' \
    --client_id 'oQBTWMc4' \
    --device_id '1xDmUjkX' \
    --platform_token 'i2LgkALG' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformTokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 207 GetRevocationListV3
$CLI_EXE \
    --sn iam \
    --op GetRevocationListV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetRevocationListV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 208 TokenRevocationV3
$CLI_EXE \
    --sn iam \
    --op TokenRevocationV3 \
    --token 'xw6qgvIJ' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenRevocationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 209 TokenGrantV3
$CLI_EXE \
    --sn iam \
    --op TokenGrantV3 \
    --client_id 'Be6rDGbF' \
    --code 'NzsyQVqv' \
    --code_verifier 'SgtpUVdd' \
    --extend_exp 'True' \
    --password '1cTLmuKl' \
    --redirect_uri 'GHZdwwo6' \
    --refresh_token '6H6QOfYz' \
    --username 'tHev8RX4' \
    --grant_type 'refresh_token' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 210 PlatformAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticationV3 \
    --platformId 'klN13WW7' \
    --code 'U0sRVCnz' \
    --error 'Rxni0Kq9' \
    --openidAssocHandle 'Zl2b7ChM' \
    --openidClaimedId 'Cxb6xdzl' \
    --openidIdentity '2OYVRJNC' \
    --openidMode '7EruVITu' \
    --openidNs 'nbxaOWNr' \
    --openidOpEndpoint 'MkfALUDr' \
    --openidResponseNonce 'R6M3vzu8' \
    --openidReturnTo '4TNQYCZI' \
    --openidSig 'pKFvpQOj' \
    --openidSigned 'jkIYAQEc' \
    --state 'xGPTkn2N' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 211 PublicGetInputValidations
$CLI_EXE \
    --sn iam \
    --op PublicGetInputValidations \
    --defaultOnEmpty 'False' \
    --languageCode 'HmB0vflV' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 212 RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 213 PublicListUserIDByPlatformUserIDsV3
# body param: body
echo '{"platformUserIds": ["2VptGYAE"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicListUserIDByPlatformUserIDsV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'ziSthhR9' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserIDByPlatformUserIDsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 214 PublicGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByPlatformUserIDV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'WLiVTXHh' \
    --platformUserId 'ZmByxlmW' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByPlatformUserIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 215 PublicGetAsyncStatus
$CLI_EXE \
    --sn iam \
    --op PublicGetAsyncStatus \
    --namespace $TEST_NAMESPACE \
    --requestId 'BLyhgZsJ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetAsyncStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 216 PublicSearchUserV3
$CLI_EXE \
    --sn iam \
    --op PublicSearchUserV3 \
    --namespace $TEST_NAMESPACE \
    --by 'oonMpOQ9' \
    --query 'Jmh8wwQ2' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 217 PublicCreateUserV3
# body param: body
echo '{"PasswordMD5Sum": "8fmxMFN8", "acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "9fdHAHph", "policyId": "hby7hGbK", "policyVersionId": "eIkY4Fc8"}], "authType": "atJ3J4gb", "code": "k9YdEm0o", "country": "9Rjjnkhw", "dateOfBirth": "q75VqZH8", "displayName": "HUq92UFW", "emailAddress": "FC8oFuU2", "password": "OFJ6w1Hb", "reachMinimumAge": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateUserV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 218 CheckUserAvailability
$CLI_EXE \
    --sn iam \
    --op CheckUserAvailability \
    --namespace $TEST_NAMESPACE \
    --field 'oiiaZ8Uc' \
    --query '2rWpzX2m' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckUserAvailability'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 219 PublicBulkGetUsers
# body param: body
echo '{"userIds": ["goBhruuv"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicBulkGetUsers \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicBulkGetUsers'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 220 PublicSendRegistrationCode
# body param: body
echo '{"emailAddress": "EzpyRiFs", "languageTag": "63b4Pru2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicSendRegistrationCode \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSendRegistrationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 221 PublicVerifyRegistrationCode
# body param: body
echo '{"code": "pWiVBYjK", "emailAddress": "I1ZlcKXB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicVerifyRegistrationCode \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicVerifyRegistrationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 222 PublicForgotPasswordV3
# body param: body
echo '{"emailAddress": "XcPAsjW7", "languageTag": "zBxpVc8s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicForgotPasswordV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicForgotPasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 223 GetAdminInvitationV3
$CLI_EXE \
    --sn iam \
    --op GetAdminInvitationV3 \
    --invitationId 'vjiFtRe8' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 224 CreateUserFromInvitationV3
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "7amplfhu", "policyId": "HropVxIv", "policyVersionId": "BjsYUEDp"}], "authType": "1taP9py4", "country": "Fl6UoVxg", "dateOfBirth": "HJLBm3bg", "displayName": "RvSUyOgy", "password": "u9dhxaof", "reachMinimumAge": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV3 \
    --invitationId 'MYGTMXy4' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 225 UpdateUserV3
# body param: body
echo '{"country": "ypcIN4uU", "dateOfBirth": "IzvUI5b1", "displayName": "wxS2yBTD", "languageTag": "8uNeauLe", "userName": "XNgQBnXZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateUserV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 226 PublicUpdateUserV3
# body param: body
echo '{"country": "kQ06LUEg", "dateOfBirth": "yyiBeJAR", "displayName": "FVbUvLNt", "languageTag": "DdAntKI6", "userName": "vd3QdSHH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 227 PublicSendVerificationCodeV3
# body param: body
echo '{"context": "2AvosR9N", "emailAddress": "k0JJYXMR", "languageTag": "cQg1Lwgz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicSendVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSendVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 228 PublicUserVerificationV3
# body param: body
echo '{"code": "WRu5q2i8", "contactType": "ntDdFSOE", "languageTag": "IqFse4oc", "validateOnly": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUserVerificationV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUserVerificationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 229 PublicUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "qjWTbUay", "country": "IP8oO0z1", "dateOfBirth": "VffDHyFM", "displayName": "7T2H6g4j", "emailAddress": "bxDDxngE", "password": "qsAbWEfT", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpgradeHeadlessAccountV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpgradeHeadlessAccountV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 230 PublicVerifyHeadlessAccountV3
# body param: body
echo '{"emailAddress": "2nSU2Sij", "password": "ySpnqX01"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicVerifyHeadlessAccountV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicVerifyHeadlessAccountV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 231 PublicUpdatePasswordV3
# body param: body
echo '{"languageTag": "uDkQ1tv3", "newPassword": "iMMW8aqV", "oldPassword": "bwArhGSa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdatePasswordV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdatePasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 232 PublicCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op PublicCreateJusticeUser \
    --namespace $TEST_NAMESPACE \
    --targetNamespace 'FxyAsPnf' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 233 PublicPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'bHX5TpIV' \
    --redirectUri '6e7dMKaA' \
    --ticket 'r2VSmtP8' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 PublicPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "qxtNo76o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'PRuvxUGN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformUnlinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 235 PublicWebLinkPlatform
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatform \
    --namespace $TEST_NAMESPACE \
    --platformId 'JvDRuWXB' \
    --clientId 'zyWeusWd' \
    --redirectUri 'EJnqhXgm' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatform'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 236 PublicWebLinkPlatformEstablish
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatformEstablish \
    --namespace $TEST_NAMESPACE \
    --platformId 'VQHoZNPy' \
    --state '0Wqu4qtx' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatformEstablish'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 237 ResetPasswordV3
# body param: body
echo '{"code": "TyrvNhyp", "emailAddress": "NLporjcA", "newPassword": "KSuvgVjd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op ResetPasswordV3 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'ResetPasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 238 PublicGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIdV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'XMn2juyP' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 239 PublicGetUserBanHistoryV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBanHistoryV3 \
    --namespace $TEST_NAMESPACE \
    --userId '3WX3u1OL' \
    --activeOnly 'True' \
    --after 'Z6vwIqGn' \
    --before 'oqXXAZd7' \
    --limit '3' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserBanHistoryV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 240 PublicGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserLoginHistoriesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'vO6Xg2xx' \
    --after '0.9041650096392843' \
    --before '0.8054130134905093' \
    --limit '56' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 241 PublicGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserPlatformAccountsV3 \
    --namespace $TEST_NAMESPACE \
    --userId '9YsEXEe9' \
    --after 'iC3Hp95A' \
    --before 'tWE8drEi' \
    --limit '30' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserPlatformAccountsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 242 PublicLinkPlatformAccount
# body param: body
echo '{"platformId": "XZfocCS9", "platformUserId": "nGM6fYF1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'o77M1VVg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 243 PublicValidateUserByUserIDAndPasswordV3
$CLI_EXE \
    --sn iam \
    --op PublicValidateUserByUserIDAndPasswordV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'HHeL0flE' \
    --password 'PUxHPhE4' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicValidateUserByUserIDAndPasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 244 PublicGetRolesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRolesV3 \
    --after 'YwCRBGAR' \
    --before '8TtZlDIj' \
    --isWildcard 'False' \
    --limit '100' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 245 PublicGetRoleV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRoleV3 \
    --roleId 'lF5jISj4' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 246 PublicGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op PublicGetMyUserV3 \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 247 PlatformAuthenticateSAMLV3Handler
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticateSAMLV3Handler \
    --platformId 'wwqLpFnn' \
    --code 'NydTcPOt' \
    --error 'fkEyLh6l' \
    --state '74AQY5ul' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticateSAMLV3Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 248 LoginSSOClient
$CLI_EXE \
    --sn iam \
    --op LoginSSOClient \
    --platformId 'xH0lioSo' \
    --payload 'ooPhQ9xl' \
    >$TEMP_FILE 2>&1
update_status $? 'LoginSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 LogoutSSOClient
$CLI_EXE \
    --sn iam \
    --op LogoutSSOClient \
    --platformId 'LMe7ma8Q' \
    >$TEMP_FILE 2>&1
update_status $? 'LogoutSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 AdminBulkCheckValidUserIDV4
# body param: body
echo '{"userIds": ["c9aGN5UJ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBulkCheckValidUserIDV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminBulkCheckValidUserIDV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 251 AdminUpdateUserV4
# body param: body
echo '{"country": "PLchiivO", "dateOfBirth": "QdByk3mW", "displayName": "Q93BxbP1", "languageTag": "VP8rKuVw", "userName": "TTGSX5rG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV4 \
    --namespace $TEST_NAMESPACE \
    --userId '8ymO7ml7' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 252 AdminUpdateUserEmailAddressV4
# body param: body
echo '{"code": "SCwM6RZN", "emailAddress": "erJQroYU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserEmailAddressV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'kvHx2dAj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserEmailAddressV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 253 AdminListUserRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminListUserRolesV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'FF0BBGwZ' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUserRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 254 AdminUpdateUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["7XWhdoYx"], "roleId": "127YYBox"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'SCFsBbZL' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 255 AdminAddUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["16L2P8eN"], "roleId": "mOi4OPQ8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'ZEV8XzBc' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 256 AdminRemoveUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["AniVuoW6"], "roleId": "wPQlP1zg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'kxv25ZHa' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 257 AdminGetRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV4 \
    --adminRole 'True' \
    --isWildcard 'True' \
    --limit '76' \
    --offset '14' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 AdminCreateRoleV4
# body param: body
echo '{"adminRole": false, "deletable": false, "isWildcard": false, "roleName": "RB8XeZhA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 AdminGetRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV4 \
    --roleId 'M4MAL57r' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 260 AdminDeleteRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV4 \
    --roleId 'iU2QbQFR' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 AdminUpdateRoleV4
# body param: body
echo '{"adminRole": true, "deletable": true, "isWildcard": true, "roleName": "t5vtTkIW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV4 \
    --roleId 'biHTUDDL' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 262 AdminUpdateRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 49, "resource": "zTnQv0e9", "schedAction": 51, "schedCron": "YNkH6Puv", "schedRange": ["ERGP7fmy"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV4 \
    --roleId 'd8aJkJYG' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 263 AdminAddRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 73, "resource": "f4wBCsCL", "schedAction": 34, "schedCron": "fH6V3fTR", "schedRange": ["ar0UZS96"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV4 \
    --roleId 'wD9rgdYv' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 264 AdminDeleteRolePermissionsV4
# body param: body
echo '["yfGQvBMJ"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV4 \
    --roleId 'Ga0RWFil' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 265 AdminListAssignedUsersV4
$CLI_EXE \
    --sn iam \
    --op AdminListAssignedUsersV4 \
    --roleId 'SDbJxY0Y' \
    --after 'R9wXVRz5' \
    --before 'ayquoA8C' \
    --limit '65' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListAssignedUsersV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 266 AdminAssignUserToRoleV4
# body param: body
echo '{"assignedNamespaces": ["DmAN0yX8"], "namespace": "xu01b0bU", "userId": "qDheu9id"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAssignUserToRoleV4 \
    --roleId 'RvQ8V1Ca' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAssignUserToRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 267 AdminRevokeUserFromRoleV4
# body param: body
echo '{"namespace": "eT74VP6K", "userId": "qpZ2JC53"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRevokeUserFromRoleV4 \
    --roleId 'CGQXzjGE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRevokeUserFromRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 268 AdminUpdateMyUserV4
# body param: body
echo '{"country": "vvr9VR6Q", "dateOfBirth": "qaoAupKS", "displayName": "o0RHRzXM", "languageTag": "L3VcaDWE", "userName": "zPCi2tWP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateMyUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateMyUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 269 AdminDisableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableMyAuthenticatorV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDisableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 270 AdminEnableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op AdminEnableMyAuthenticatorV4 \
    --code 'zhrjLFLL' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminEnableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 271 AdminGenerateMyAuthenticatorKeyV4
$CLI_EXE \
    --sn iam \
    --op AdminGenerateMyAuthenticatorKeyV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGenerateMyAuthenticatorKeyV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 272 AdminGetMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 273 AdminGenerateMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminGenerateMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGenerateMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 274 AdminDisableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDisableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 275 AdminDownloadMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminDownloadMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDownloadMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 276 AdminEnableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminEnableMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminEnableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 277 AdminGetMyEnabledFactorsV4
$CLI_EXE \
    --sn iam \
    --op AdminGetMyEnabledFactorsV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetMyEnabledFactorsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 278 AdminMakeFactorMyDefaultV4
$CLI_EXE \
    --sn iam \
    --op AdminMakeFactorMyDefaultV4 \
    --factor 'uGlXInVk' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminMakeFactorMyDefaultV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 279 AdminInviteUserV4
# body param: body
echo '{"assignedNamespaces": ["n9ojnppi"], "emailAddresses": ["U7rYU098"], "isAdmin": true, "roleId": "1JzPmaRk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminInviteUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 280 PublicCreateTestUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "YX8U71w0", "policyId": "9mTap7y9", "policyVersionId": "0X88qbd2"}], "authType": "vRMUmqoG", "country": "BqBaxLbp", "dateOfBirth": "DekuIzTO", "displayName": "DQZkNg9X", "emailAddress": "scMV2DnO", "password": "o9PaoBSJ", "passwordMD5Sum": "JGgg8epT", "username": "Uehn6Izq", "verified": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateTestUserV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateTestUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 281 PublicCreateUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "eu4pU694", "policyId": "ex0bxtkv", "policyVersionId": "XIrbCB52"}], "authType": "HlTeFVmp", "code": "XnrWDCij", "country": "8S73sQDN", "dateOfBirth": "y12G1PiT", "displayName": "JwxV0rwM", "emailAddress": "M7HsMJnU", "password": "BZ6Gyhfc", "passwordMD5Sum": "rddeIOhx", "reachMinimumAge": false, "username": "B13f1obT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicCreateUserV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 282 CreateUserFromInvitationV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "wFXC2Op2", "policyId": "yXEIOAJh", "policyVersionId": "6XNWtHWd"}], "authType": "mibqDeNi", "country": "c565hvy1", "dateOfBirth": "VY2365rU", "displayName": "HkxwwpNw", "password": "FJyOBelg", "reachMinimumAge": false, "username": "T04uRmAe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV4 \
    --invitationId 'OhTeibSq' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 283 PublicUpdateUserV4
# body param: body
echo '{"country": "4H7xDe1j", "dateOfBirth": "h7clQulg", "displayName": "jFzOE2zP", "languageTag": "DGQYK5uG", "userName": "sklKEj2c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 284 PublicUpdateUserEmailAddressV4
# body param: body
echo '{"code": "ImuLS8rr", "emailAddress": "BfOaAENF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserEmailAddressV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserEmailAddressV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 285 PublicUpgradeHeadlessAccountWithVerificationCodeV4
# body param: body
echo '{"code": "CnYbIQID", "country": "kTf41ag7", "dateOfBirth": "CX8oWPut", "displayName": "7xraYvae", "emailAddress": "aiep5aTd", "password": "bjoDWOL2", "reachMinimumAge": false, "username": "mjDt1rOz", "validateOnly": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpgradeHeadlessAccountWithVerificationCodeV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpgradeHeadlessAccountWithVerificationCodeV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 286 PublicUpgradeHeadlessAccountV4
# body param: body
echo '{"emailAddress": "T1Axwhim", "password": "0K97ZlRo", "username": "mBcUU86i"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpgradeHeadlessAccountV4 \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpgradeHeadlessAccountV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 287 PublicDisableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op PublicDisableMyAuthenticatorV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDisableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 288 PublicEnableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op PublicEnableMyAuthenticatorV4 \
    --namespace $TEST_NAMESPACE \
    --code '9DJulX4a' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicEnableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 289 PublicGenerateMyAuthenticatorKeyV4
$CLI_EXE \
    --sn iam \
    --op PublicGenerateMyAuthenticatorKeyV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGenerateMyAuthenticatorKeyV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 290 PublicGetMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicGetMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 291 PublicGenerateMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicGenerateMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGenerateMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 292 PublicDisableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicDisableMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDisableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 293 PublicDownloadMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicDownloadMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDownloadMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 294 PublicEnableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicEnableMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicEnableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 295 PublicGetMyEnabledFactorsV4
$CLI_EXE \
    --sn iam \
    --op PublicGetMyEnabledFactorsV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyEnabledFactorsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 296 PublicMakeFactorMyDefaultV4
$CLI_EXE \
    --sn iam \
    --op PublicMakeFactorMyDefaultV4 \
    --namespace $TEST_NAMESPACE \
    --factor 'R8w6Q4Pk' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicMakeFactorMyDefaultV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT