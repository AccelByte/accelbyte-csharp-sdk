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

OPERATIONS_COUNT=273

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
    --limit 'XDomWyrF' \
    --loginId 'ZZdM00sS' \
    --platformUserId 'dUypOvoM' \
    --roleId 'vIN7cRBR' \
    --userId 'xFsCUQz0' \
    --platformId 'koUsUcGf' \
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
    --userId 'jtfyuPNb' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByUserIdV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 85 AdminUpdateUserV2
# body param: body
echo '{"Country": "5exiRtR1", "DateOfBirth": "Qe0mxLnv", "DisplayName": "ZEG2biyK", "LanguageTag": "S8vfIsZ5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'EADM0xJp' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 86 AdminBanUserV2
# body param: body
echo '{"ban": "6HXexnHA", "comment": "XYShIg82", "endDate": "ffzx6WCU", "reason": "dwQnivM1", "skipNotif": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'fIoSsKaP' \
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
    --userId '5KNn0UGr' \
    --activeOnly 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserBanV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 88 AdminDisableUserV2
# body param: body
echo '{"Reason": "9VatfxBo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDisableUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'akHUqz2u' \
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
    --userId 'OKJVjX7j' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminEnableUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 90 AdminResetPasswordV2
# body param: body
echo '{"LanguageTag": "5MgRZ3kP", "NewPassword": "mSrNaFzJ", "OldPassword": "wBceJQ0v"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminResetPasswordV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'iEYQy4Jx' \
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
    --platformId 'BkyXfgwz' \
    --userId 'MTAlT2q2' \
    --platform_namespace 'EbG4Z95S' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeletePlatformLinkV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 92 AdminPutUserRolesV2
# body param: body
echo '["ldyWe2X8"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPutUserRolesV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'cLes0TRT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPutUserRolesV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 93 AdminCreateUserRolesV2
# body param: body
echo '["AekrfR30"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateUserRolesV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'IRA6CzcX' \
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
    --countryCode 'FcjRpu7w' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetCountryAgeRestriction'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 95 PublicCreateUserV2
# body param: body
echo '{"AuthType": "VEzbwHvO", "Country": "Gqwb7FAI", "DisplayName": "8lxDoRtw", "LoginId": "KNHCncWR", "Password": "yVDPNRFI", "PasswordMD5Sum": "bOIi021v"}' > $TEMP_JSON_INPUT
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
echo '{"Context": "VF26yEKn", "LanguageTag": "KL26vTDv", "LoginID": "jjj8aEPj"}' > $TEMP_JSON_INPUT
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
echo '{"Code": "DWSwW548", "LoginID": "hHTuJ1jV", "NewPassword": "4EKppV4D"}' > $TEMP_JSON_INPUT
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
    --userId 'fTxfj3AG' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByUserIDV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 99 PublicUpdateUserV2
# body param: body
echo '{"Country": "rDhoJooH", "DateOfBirth": "5WNF4d6D", "DisplayName": "ELnHRwig", "LanguageTag": "r039B7fw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId '1zHG7KQT' \
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
    --userId 'rQeIv8R1' \
    --activeOnly 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserBan'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 101 PublicUpdatePasswordV2
# body param: body
echo '{"LanguageTag": "tNkXpuQ4", "NewPassword": "g9IiLxJp", "OldPassword": "TlIMuKCd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdatePasswordV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'At0XTdLL' \
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
    --userId 'O1WSvdw7' \
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
    --platformId 'FI8mOSB2' \
    --userId 'rvQkdnYl' \
    --ticket 'PH6J70BX' \
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
    --platformId 'WVtxOyZz' \
    --userId 'UrVRKRtJ' \
    --platform_namespace 'uZ5W7nPr' \
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
echo '[{"field": "KtUSflKq", "validation": {"allowDigit": true, "allowLetter": false, "allowSpace": true, "allowUnicode": true, "description": [{"language": "IJUngm7G", "message": ["SrElr5mg"]}], "isCustomRegex": true, "letterCase": "0RyG8SZm", "maxLength": 26, "maxRepeatingAlphaNum": 81, "maxRepeatingSpecialCharacter": 43, "minCharType": 41, "minLength": 60, "regex": "FzSQyIXv", "specialCharacterLocation": "2yW4Uka5", "specialCharacters": ["jsUlAifn"]}}]' > $TEMP_JSON_INPUT
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
    --field 'i52mGYo0' \
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
    --after 'BjFUSZeN' \
    --before 'r7PeZ5Sa' \
    --limit '93' \
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
echo '{"ageRestriction": 1, "enable": true}' > $TEMP_JSON_INPUT
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
echo '{"ageRestriction": 0}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateCountryAgeRestrictionV3 \
    --countryCode 'P0Kwv68O' \
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
    --banType 'qOUTPXze' \
    --limit '23' \
    --offset '49' \
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
    --limit '5' \
    --offset 'hmgjLvnO' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetClientsByNamespaceV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 118 AdminCreateClientV3
# body param: body
echo '{"audiences": ["WOk5AekV"], "baseUri": "VmTIEG2p", "clientId": "pf1fH3Nw", "clientName": "fEQkdzI8", "clientPermissions": [{"action": 70, "resource": "QzAp0rF8", "schedAction": 12, "schedCron": "vdnF1yMv", "schedRange": ["oXLWNoQZ"]}], "deletable": false, "namespace": "vPg7VX5r", "oauthClientType": "UNWJaq1f", "redirectUri": "jgDypxO4", "secret": "ufKfU7Ou"}' > $TEMP_JSON_INPUT
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
    --clientId 'mxSk0Ebj' \
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
    --clientId 'u4dSLx4v' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteClientV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 121 AdminUpdateClientV3
# body param: body
echo '{"audiences": ["sb6rx9Xx"], "baseUri": "su8TJHpd", "clientName": "ZVC6y6b9", "clientPermissions": [{"action": 11, "resource": "Qpa7b36m", "schedAction": 48, "schedCron": "8LWzMOfn", "schedRange": ["jwsIxM4s"]}], "deletable": false, "namespace": "2qWNvmPP", "redirectUri": "lRULr7pP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateClientV3 \
    --clientId 'FCzbPX1w' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateClientV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 122 AdminUpdateClientPermissionV3
# body param: body
echo '{"permissions": [{"action": 44, "resource": "BznD7NLs"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateClientPermissionV3 \
    --clientId '7fb4sqWU' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateClientPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 123 AdminAddClientPermissionsV3
# body param: body
echo '{"permissions": [{"action": 30, "resource": "B4t2ieA8"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddClientPermissionsV3 \
    --clientId 'XRPhVzkt' \
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
    --action '36' \
    --clientId 'WibnpBKX' \
    --namespace $TEST_NAMESPACE \
    --resource 'MWuoFv0q' \
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
    --limit '19' \
    --offset 'BvBzZGOh' \
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
    --platformId 'AwcbpybZ' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 129 AddThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "n4ZE5Omb", "AWSCognitoRegion": "NkHnefZW", "AWSCognitoUserPool": "Dwi6anYn", "AppId": "Q92kVBDk", "ClientId": "aMy03Bul", "Environment": "4GW3V0WC", "FederationMetadataURL": "bxvTGycc", "IsActive": false, "KeyID": "FQzgVR72", "OrganizationId": "Dhxbr4Ht", "RedirectUri": "KMGr8tnO", "Secret": "Eeip505i", "TeamID": "JTzZuksb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '4hREcOx3' \
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
    --platformId 'mATUsOS0' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 131 UpdateThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "e5Tmapki", "AWSCognitoRegion": "mopclvfm", "AWSCognitoUserPool": "7fdu7isK", "AppId": "aWRcvkLt", "ClientId": "fmGySrAC", "Environment": "Ka0mWWkD", "FederationMetadataURL": "RcuLbIpV", "IsActive": false, "KeyID": "IAFpX2SK", "OrganizationId": "NmncDRkn", "RedirectUri": "JortwVqi", "Secret": "pgpXVyWo", "TeamID": "DjOHrGcz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'aXWipcAH' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 132 UpdateThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"affectedClientIDs": ["tRkBJXZw"], "assignedNamespaces": ["Q443FfWt"], "domain": "sTAAgtCn", "roleId": "vDp28TMv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'lTcBaljk' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformDomainV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 133 DeleteThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"domain": "3sB4LS44"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'hWONXuXi' \
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
    --platformId 'hqBVEXSy' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSSOLoginPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 AddSSOLoginPlatformCredential
# body param: body
echo '{"acsUrl": "rZKBvGa0", "apiKey": "LshfP3Lq", "appId": "rZcSsGFD", "federationMetadataUrl": "DAiSjXH3", "isActive": true, "redirectUri": "pQaqFPMA", "secret": "jx7edUxN", "ssoUrl": "5KMSLs21"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddSSOLoginPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'gdQU0FhA' \
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
    --platformId 'QYQaHZ7W' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSSOLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 137 UpdateSSOPlatformCredential
# body param: body
echo '{"acsUrl": "tAApJtfB", "apiKey": "0Xt8Zcpu", "appId": "z7BY3JPV", "federationMetadataUrl": "nMt1HRDF", "isActive": true, "redirectUri": "kSaTdINJ", "secret": "TdRQmMvx", "ssoUrl": "BjpVFnEg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateSSOPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'sovZbx4U' \
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
    --platformId 'F3pYMzeF' \
    --platformUserId 'csBLCwhT' \
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
    --roleId 'StBJZGkI' \
    --after '89' \
    --before '74' \
    --limit '89' \
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
    --emailAddress 'co6HxX79' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByEmailAddressV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 141 AdminListUserIDByUserIDsV3
# body param: body
echo '{"userIds": ["bWJClH3p"]}' > $TEMP_JSON_INPUT
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
echo '{"emailAddresses": ["XWCq3ysd"], "isAdmin": false, "roles": ["W3XyQQmf"]}' > $TEMP_JSON_INPUT
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
    --limit '38' \
    --offset '24' \
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
    --by 'A5HUHiox' \
    --endDate 'zVhzHc1r' \
    --limit '55' \
    --offset 'qAXud4JQ' \
    --platformBy 'OWZBzUvN' \
    --platformId 'kxTUqI2X' \
    --query 'hbYwTxVS' \
    --startDate 'XpJb2JSu' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 145 AdminGetBulkUserByEmailAddressV3
# body param: body
echo '{"listEmailAddressRequest": ["HHCRP9xW"]}' > $TEMP_JSON_INPUT
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
    --userId '9VeYJCDi' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 147 AdminUpdateUserV3
# body param: body
echo '{"country": "kIapumYw", "dateOfBirth": "baGfsJTg", "displayName": "obWG93dH", "languageTag": "2MCGvohr", "userName": "dRx6lVi7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'UcTmEwe9' \
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
    --userId 'mWH3XVfy' \
    --activeOnly 'False' \
    --after 'jgTi2E85' \
    --before 'VnFsoXaR' \
    --limit '60' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 149 AdminBanUserV3
# body param: body
echo '{"ban": "a1WpsZ5P", "comment": "oXUApZEP", "endDate": "fic39c2q", "reason": "3a6kRuGq", "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'wZVjAQCk' \
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
    --banId '3gJ6AwW9' \
    --namespace $TEST_NAMESPACE \
    --userId '53NlFHpD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 151 AdminSendVerificationCodeV3
# body param: body
echo '{"context": "CFut39Jh", "emailAddress": "j3lmfXJx", "languageTag": "KJNRD3Ku"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSendVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'mRjk3wZY' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSendVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 152 AdminVerifyAccountV3
# body param: body
echo '{"Code": "Vb3SFssn", "ContactType": "x4JYy1kX", "LanguageTag": "akVQoG01", "validateOnly": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminVerifyAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'psR2PZ0E' \
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
    --userId '2oWaCZcC' \
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
    --userId 'X2iLiQGT' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 155 AdminUpdateUserDeletionStatusV3
# body param: body
echo '{"enabled": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserDeletionStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'LlXUV78i' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 156 AdminUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "8csQIO0D", "country": "RagPXzsB", "dateOfBirth": "fUhCoGFg", "displayName": "irdMLexA", "emailAddress": "5zJvQd2c", "password": "OVXFoiaY", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpgradeHeadlessAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'Soog7pSs' \
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
    --userId 'QhvXbGvq' \
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
    --userId 'RVSSwvlR' \
    --after '0.9924464254927992' \
    --before '0.05247258860037207' \
    --limit '98' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 159 AdminUpdateUserPermissionV3
# body param: body
echo '{"Permissions": [{"Action": 35, "Resource": "foKVR4Hh", "SchedAction": 22, "SchedCron": "PEfSM2K2", "SchedRange": ["9oqfZssi"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserPermissionV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'bgoTFQAm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 160 AdminAddUserPermissionsV3
# body param: body
echo '{"Permissions": [{"Action": 69, "Resource": "ZiTSstC2", "SchedAction": 48, "SchedCron": "OumzHMhX", "SchedRange": ["ysws3Fwn"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserPermissionsV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'u7OX9FZv' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserPermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 161 AdminDeleteUserPermissionBulkV3
# body param: body
echo '[{"Action": 44, "Resource": "J8OQFuCH"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionBulkV3 \
    --namespace $TEST_NAMESPACE \
    --userId '68pTmT63' \
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
    --action '19' \
    --namespace $TEST_NAMESPACE \
    --resource '8QfhNDTH' \
    --userId 'b8lFvBol' \
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
    --userId 'f9Pdi5BL' \
    --after 'CsT8g72t' \
    --before 'hhduZnNj' \
    --limit '5' \
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
    --userId 'RNlTBxl3' \
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
    --targetNamespace 'nKj6B4ff' \
    --userId 'gtxiPLdV' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 AdminLinkPlatformAccount
# body param: body
echo '{"platformId": "0odbfast", "platformUserId": "4NDIBQl3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'UryryOWz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 AdminPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "hhEmSVFh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'AlEacAAo' \
    --userId 'AfsuMB4W' \
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
    --platformId '3HIcvS0A' \
    --userId 'L4tYCwCd' \
    --ticket 'Cigcxlbl' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 AdminDeleteUserRolesV3
# body param: body
echo '["30hHHEjM"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRolesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'I4LcgkyD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 AdminSaveUserRoleV3
# body param: body
echo '[{"namespace": "sccFdvzo", "roleId": "afMLoraV"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSaveUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'j5RiDHvo' \
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
    --roleId '7KepgBTM' \
    --userId 'RiEdeeQw' \
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
    --roleId 'LUW0VLup' \
    --userId 'H83AuxFE' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 AdminUpdateUserStatusV3
# body param: body
echo '{"enabled": true, "reason": "RDTt2mau"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'ywaKEsPB' \
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
    --userId 'AM1aujNq' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyUserWithoutVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 175 AdminGetRolesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV3 \
    --after 'lmpKGhvT' \
    --before 'KiXeZepm' \
    --isWildcard 'True' \
    --limit '63' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 176 AdminCreateRoleV3
# body param: body
echo '{"adminRole": true, "deletable": false, "isWildcard": false, "managers": [{"displayName": "EcagyjZI", "namespace": "TRuoWjIC", "userId": "oCN3NyzA"}], "members": [{"displayName": "V4niQQVj", "namespace": "gDJE12W5", "userId": "eoplrOXw"}], "permissions": [{"action": 52, "resource": "SJ1PtQux", "schedAction": 81, "schedCron": "JQKgor2U", "schedRange": ["MJt4EJ9G"]}], "roleName": "ccYTYxPT"}' > $TEMP_JSON_INPUT
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
    --roleId 'gpBNsUvU' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 178 AdminDeleteRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV3 \
    --roleId 'KhANjquB' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 179 AdminUpdateRoleV3
# body param: body
echo '{"deletable": true, "isWildcard": false, "roleName": "aQpz0dfi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV3 \
    --roleId 'uv051lkP' \
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
    --roleId 'CaZsjvFv' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleAdminStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 AdminUpdateAdminRoleStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAdminRoleStatusV3 \
    --roleId 'hZdwi1Ti' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAdminRoleStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 182 AdminRemoveRoleAdminV3
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleAdminV3 \
    --roleId '6V2uWuCs' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleAdminV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 183 AdminGetRoleManagersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleManagersV3 \
    --roleId 'B8FbVDwh' \
    --after 'pNCLl2bg' \
    --before 'Ic1y49bq' \
    --limit '30' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 184 AdminAddRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "bfyytwm6", "namespace": "jQJpfOIK", "userId": "CegUjKQR"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleManagersV3 \
    --roleId 'joyn3bGy' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 AdminRemoveRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "FGwcAylT", "namespace": "i4qPF190", "userId": "sf2ZwPi5"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleManagersV3 \
    --roleId 'hI4k3KwV' \
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
    --roleId '7P8R9t4d' \
    --after 'BRpBp4no' \
    --before 'j3J79DD3' \
    --limit '2' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 AdminAddRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "AZF4nYBu", "namespace": "NxISmVGV", "userId": "z9Jxj8we"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleMembersV3 \
    --roleId 'grDo6Ome' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 AdminRemoveRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "KL7GPoI9", "namespace": "uWOFTWdR", "userId": "rL6yNmv8"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleMembersV3 \
    --roleId 'k1w19JsH' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 AdminUpdateRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 89, "resource": "qOByh4hh", "schedAction": 20, "schedCron": "cO6J7jSv", "schedRange": ["Yd4J5c6a"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV3 \
    --roleId 'yFnSrfmO' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 190 AdminAddRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 2, "resource": "FTUBRRDG", "schedAction": 56, "schedCron": "RQtMc3an", "schedRange": ["8ZoxLwXH"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV3 \
    --roleId 'S1oUzDdD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 191 AdminDeleteRolePermissionsV3
# body param: body
echo '["cZ0Rj3YM"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV3 \
    --roleId '1fz9Cjqt' \
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
    --action '33' \
    --resource 'eiyDCK7C' \
    --roleId '3u5GcPbm' \
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
    --client_id 'i5KiFDVp' \
    --extend_exp 'False' \
    --redirect_uri 'vR2Wl0iS' \
    --password 'hagpvFuZ' \
    --request_id 'u45zsrSp' \
    --user_name 'vMLvQw3s' \
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
    --platformId 'PxFu8LQG' \
    --userId 'QCAj6O7i' \
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
    --userId 'vhNIjVT5' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 AuthorizeV3
$CLI_EXE \
    --sn iam \
    --op AuthorizeV3 \
    --codeChallenge 'HSR00UKS' \
    --codeChallengeMethod 'plain' \
    --redirectUri 'OplTLwZQ' \
    --scope 'ZUMaAJ6Z' \
    --state 'BTHYjGbV' \
    --targetAuthPage 'tzsBTCOW' \
    --clientId 'EnaLzHuY' \
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
    --token 'r89z0RkL' \
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

#- 202 RetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op RetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '932B7thD' \
    --userId 'Q3hfVnPK' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveUserThirdPartyPlatformTokenV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 AuthCodeRequestV3
$CLI_EXE \
    --sn iam \
    --op AuthCodeRequestV3 \
    --platformId '8iK8cdZP' \
    --clientId 'nXwGS9fA' \
    --redirectUri 'lxtjeZUr' \
    --requestId 'qmIc7El4' \
    >$TEMP_FILE 2>&1
update_status $? 'AuthCodeRequestV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 204 PlatformTokenGrantV3
$CLI_EXE \
    --sn iam \
    --op PlatformTokenGrantV3 \
    --platformId '4MEAvaPT' \
    --client_id 'wwJrG06M' \
    --device_id 'tcF7t8DQ' \
    --platform_token 'xcoQBTWM' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformTokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 GetRevocationListV3
$CLI_EXE \
    --sn iam \
    --op GetRevocationListV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetRevocationListV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 206 TokenRevocationV3
$CLI_EXE \
    --sn iam \
    --op TokenRevocationV3 \
    --token 'c41xDmUj' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenRevocationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 207 TokenGrantV3
$CLI_EXE \
    --sn iam \
    --op TokenGrantV3 \
    --client_id 'kXi2LgkA' \
    --code 'LGxw6qgv' \
    --code_verifier 'IJBe6rDG' \
    --extend_exp 'False' \
    --password 'FNzsyQVq' \
    --redirect_uri 'vSgtpUVd' \
    --refresh_token 'dL6A1cTL' \
    --username 'muKlGHZd' \
    --grant_type 'password' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 208 PlatformAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticationV3 \
    --platformId 'wo66H6QO' \
    --code 'fYztHev8' \
    --error 'RX4MWRFk' \
    --openidAssocHandle 'lN13WW7U' \
    --openidClaimedId '0sRVCnzR' \
    --openidIdentity 'xni0Kq9Z' \
    --openidMode 'l2b7ChMC' \
    --openidNs 'xb6xdzl2' \
    --openidOpEndpoint 'OYVRJNC7' \
    --openidResponseNonce 'EruVITun' \
    --openidReturnTo 'bxaOWNrM' \
    --openidSig 'kfALUDrR' \
    --openidSigned '6M3vzu84' \
    --state 'TNQYCZIp' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 209 PublicGetInputValidations
$CLI_EXE \
    --sn iam \
    --op PublicGetInputValidations \
    --defaultOnEmpty 'True' \
    --languageCode 'vpQOjjkI' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 210 RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 211 PublicListUserIDByPlatformUserIDsV3
# body param: body
echo '{"platformUserIds": ["YAQEcxGP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicListUserIDByPlatformUserIDsV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'Tkn2NJ9g' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserIDByPlatformUserIDsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 212 PublicGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByPlatformUserIDV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'HmB0vflV' \
    --platformUserId '2VptGYAE' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByPlatformUserIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 213 PublicGetAsyncStatus
$CLI_EXE \
    --sn iam \
    --op PublicGetAsyncStatus \
    --namespace $TEST_NAMESPACE \
    --requestId 'ziSthhR9' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetAsyncStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 214 PublicSearchUserV3
$CLI_EXE \
    --sn iam \
    --op PublicSearchUserV3 \
    --namespace $TEST_NAMESPACE \
    --by 'WLiVTXHh' \
    --query 'ZmByxlmW' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 215 PublicCreateUserV3
# body param: body
echo '{"PasswordMD5Sum": "BLyhgZsJ", "acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "onMpOQ9J", "policyId": "mh8wwQ28", "policyVersionId": "fmxMFN8d"}], "authType": "9fdHAHph", "code": "hby7hGbK", "country": "eIkY4Fc8", "dateOfBirth": "atJ3J4gb", "displayName": "k9YdEm0o", "emailAddress": "9Rjjnkhw", "password": "q75VqZH8", "reachMinimumAge": true}' > $TEMP_JSON_INPUT
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

#- 216 CheckUserAvailability
$CLI_EXE \
    --sn iam \
    --op CheckUserAvailability \
    --namespace $TEST_NAMESPACE \
    --field '92UFWFC8' \
    --query 'oFuU2OFJ' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckUserAvailability'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 217 PublicBulkGetUsers
# body param: body
echo '{"userIds": ["6w1Hbioi"]}' > $TEMP_JSON_INPUT
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

#- 218 PublicSendRegistrationCode
# body param: body
echo '{"emailAddress": "iaZ8Uc2r", "languageTag": "WpzX2mgo"}' > $TEMP_JSON_INPUT
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

#- 219 PublicVerifyRegistrationCode
# body param: body
echo '{"code": "BhruuvEz", "emailAddress": "pyRiFs63"}' > $TEMP_JSON_INPUT
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

#- 220 PublicForgotPasswordV3
# body param: body
echo '{"emailAddress": "b4Pru2pW", "languageTag": "iVBYjKI1"}' > $TEMP_JSON_INPUT
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

#- 221 GetAdminInvitationV3
$CLI_EXE \
    --sn iam \
    --op GetAdminInvitationV3 \
    --invitationId 'ZlcKXBXc' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 222 CreateUserFromInvitationV3
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "sjW7zBxp", "policyId": "Vc8svjiF", "policyVersionId": "tRe8k7am"}], "authType": "plfhuHro", "country": "pVxIvBjs", "dateOfBirth": "YUEDp1ta", "displayName": "P9py4Fl6", "password": "UoVxgHJL", "reachMinimumAge": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV3 \
    --invitationId 'm3bgRvSU' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 223 UpdateUserV3
# body param: body
echo '{"country": "yOgyu9dh", "dateOfBirth": "xaofTjMY", "displayName": "GTMXy4yp", "languageTag": "cIN4uUIz", "userName": "vUI5b1wx"}' > $TEMP_JSON_INPUT
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

#- 224 PublicUpdateUserV3
# body param: body
echo '{"country": "S2yBTD8u", "dateOfBirth": "NeauLeXN", "displayName": "gQBnXZkQ", "languageTag": "06LUEgyy", "userName": "iBeJARFV"}' > $TEMP_JSON_INPUT
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

#- 225 PublicSendVerificationCodeV3
# body param: body
echo '{"context": "bUvLNtDd", "emailAddress": "AntKI6vd", "languageTag": "3QdSHH2A"}' > $TEMP_JSON_INPUT
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

#- 226 PublicUserVerificationV3
# body param: body
echo '{"code": "vosR9Nk0", "contactType": "JJYXMRcQ", "languageTag": "g1LwgzWR", "validateOnly": true}' > $TEMP_JSON_INPUT
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

#- 227 PublicUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "5q2i8ntD", "country": "dFSOEIqF", "dateOfBirth": "se4ocrqj", "displayName": "WTbUayIP", "emailAddress": "8oO0z1Vf", "password": "fDHyFM7T", "validateOnly": false}' > $TEMP_JSON_INPUT
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

#- 228 PublicVerifyHeadlessAccountV3
# body param: body
echo '{"emailAddress": "4jbxDDxn", "password": "gEqsAbWE"}' > $TEMP_JSON_INPUT
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

#- 229 PublicUpdatePasswordV3
# body param: body
echo '{"languageTag": "fTc2nSU2", "newPassword": "SijySpnq", "oldPassword": "X01uDkQ1"}' > $TEMP_JSON_INPUT
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

#- 230 PublicCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op PublicCreateJusticeUser \
    --namespace $TEST_NAMESPACE \
    --targetNamespace 'tv3iMMW8' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 231 PublicPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'aqVbwArh' \
    --redirectUri 'GSaFxyAs' \
    --ticket 'PnfbHX5T' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 232 PublicPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "pIV6e7dM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'KaAr2VSm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformUnlinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 233 PublicWebLinkPlatform
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatform \
    --namespace $TEST_NAMESPACE \
    --platformId 'tP8qxtNo' \
    --clientId '76oPRuvx' \
    --redirectUri 'UGNJvDRu' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatform'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 PublicWebLinkPlatformEstablish
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatformEstablish \
    --namespace $TEST_NAMESPACE \
    --platformId 'WXBzyWeu' \
    --state 'sWdEJnqh' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatformEstablish'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 235 ResetPasswordV3
# body param: body
echo '{"code": "XgmVQHoZ", "emailAddress": "NPy0Wqu4", "newPassword": "qtxTyrvN"}' > $TEMP_JSON_INPUT
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

#- 236 PublicGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIdV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'hypNLpor' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 237 PublicGetUserBanHistoryV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBanHistoryV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'jcAKSuvg' \
    --activeOnly 'False' \
    --after 'dXMn2juy' \
    --before 'P3WX3u1O' \
    --limit '74' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserBanHistoryV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 238 PublicGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserLoginHistoriesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'RUrZ6vwI' \
    --after '0.9734392259505031' \
    --before '0.5093316973323931' \
    --limit '28' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 239 PublicGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserPlatformAccountsV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'qXXAZd7b' \
    --after 'vO6Xg2xx' \
    --before '5vZXC9Ys' \
    --limit '61' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserPlatformAccountsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 240 PublicLinkPlatformAccount
# body param: body
echo '{"platformId": "XEe9iC3H", "platformUserId": "p95AtWE8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'drEipXZf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 241 PublicValidateUserByUserIDAndPasswordV3
$CLI_EXE \
    --sn iam \
    --op PublicValidateUserByUserIDAndPasswordV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'ocCS9nGM' \
    --password '6fYF1o77' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicValidateUserByUserIDAndPasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 242 PublicGetRolesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRolesV3 \
    --after 'M1VVgHHe' \
    --before 'L0flEPUx' \
    --isWildcard 'False' \
    --limit '60' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 243 PublicGetRoleV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRoleV3 \
    --roleId '4YwCRBGA' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 244 PublicGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op PublicGetMyUserV3 \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 245 PlatformAuthenticateSAMLV3Handler
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticateSAMLV3Handler \
    --platformId 'R8TtZlDI' \
    --code 'jOfYlF5j' \
    --error 'ISj4wwqL' \
    --state 'pFnnNydT' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticateSAMLV3Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 246 LoginSSOClient
$CLI_EXE \
    --sn iam \
    --op LoginSSOClient \
    --platformId 'cPOtfkEy' \
    --payload 'Lh6l74AQ' \
    >$TEMP_FILE 2>&1
update_status $? 'LoginSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 247 LogoutSSOClient
$CLI_EXE \
    --sn iam \
    --op LogoutSSOClient \
    --platformId 'Y5ulxH0l' \
    >$TEMP_FILE 2>&1
update_status $? 'LogoutSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 248 AdminUpdateUserV4
# body param: body
echo '{"country": "ioSoooPh", "dateOfBirth": "Q9xlLMe7", "displayName": "ma8Qc9aG", "languageTag": "N5UJPLch", "userName": "iivOQdBy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'k3mWQ93B' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 AdminUpdateUserEmailAddressV4
# body param: body
echo '{"code": "xbP1VP8r", "emailAddress": "KuVwTTGS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserEmailAddressV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'X5rG8ymO' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserEmailAddressV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 AdminListUserRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminListUserRolesV4 \
    --namespace $TEST_NAMESPACE \
    --userId '7ml7SCwM' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUserRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 251 AdminUpdateUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["6RZNerJQ"], "roleId": "roYUkvHx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId '2dAjFF0B' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 252 AdminAddUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["BGwZ7XWh"], "roleId": "doYx127Y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'YBoxSCFs' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 253 AdminRemoveUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["BbZL16L2"], "roleId": "P8eNmOi4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'OPQ8ZEV8' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 254 AdminGetRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV4 \
    --adminRole 'True' \
    --isWildcard 'True' \
    --limit '4' \
    --offset '52' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 255 AdminCreateRoleV4
# body param: body
echo '{"adminRole": false, "deletable": false, "isWildcard": true, "roleName": "oW6wPQlP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 256 AdminGetRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV4 \
    --roleId '1zgkxv25' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 257 AdminDeleteRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV4 \
    --roleId 'ZHaR8vsM' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 AdminUpdateRoleV4
# body param: body
echo '{"adminRole": false, "deletable": false, "isWildcard": false, "roleName": "gRB8XeZh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV4 \
    --roleId 'AM4MAL57' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 AdminUpdateRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 34, "resource": "iU2QbQFR", "schedAction": 56, "schedCron": "XEWG8Sxt", "schedRange": ["5vtTkIWb"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV4 \
    --roleId 'iHTUDDL4' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 260 AdminAddRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 49, "resource": "zTnQv0e9", "schedAction": 51, "schedCron": "YNkH6Puv", "schedRange": ["ERGP7fmy"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV4 \
    --roleId 'd8aJkJYG' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 AdminDeleteRolePermissionsV4
# body param: body
echo '["Kf4wBCsC"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV4 \
    --roleId 'LrfH6V3f' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 262 AdminListAssignedUsersV4
$CLI_EXE \
    --sn iam \
    --op AdminListAssignedUsersV4 \
    --roleId 'TRar0UZS' \
    --after '96wD9rgd' \
    --before 'YvyfGQvB' \
    --limit '76' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListAssignedUsersV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 263 AdminAssignUserToRoleV4
# body param: body
echo '{"assignedNamespaces": ["JGa0RWFi"], "namespace": "lSDbJxY0", "userId": "YR9wXVRz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAssignUserToRoleV4 \
    --roleId '5ayquoA8' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAssignUserToRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 264 AdminRevokeUserFromRoleV4
# body param: body
echo '{"namespace": "CGDmAN0y", "userId": "X8xu01b0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRevokeUserFromRoleV4 \
    --roleId 'bUqDheu9' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRevokeUserFromRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 265 AdminUpdateMyUserV4
# body param: body
echo '{"country": "idRvQ8V1", "dateOfBirth": "CaeT74VP", "displayName": "6KqpZ2JC", "languageTag": "53CGQXzj", "userName": "GEvvr9VR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateMyUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateMyUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 266 AdminInviteUserV4
# body param: body
echo '{"assignedNamespaces": ["6QqaoAup"], "emailAddresses": ["KSo0RHRz"], "isAdmin": false, "roleId": "aDWEzPCi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminInviteUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 267 PublicCreateTestUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "WPzhrjLF", "policyId": "LLuGlXIn", "policyVersionId": "Vkn9ojnp"}], "authType": "piU7rYU0", "country": "98E1JzPm", "dateOfBirth": "aRkeYX8U", "displayName": "71w09mTa", "emailAddress": "p7y90X88", "password": "qbd2vRMU", "passwordMD5Sum": "mqoGBqBa", "username": "xLbpDeku", "verified": true}' > $TEMP_JSON_INPUT
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

#- 268 PublicCreateUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "QZkNg9Xs", "policyId": "cMV2DnOo", "policyVersionId": "9PaoBSJJ"}], "authType": "Ggg8epTU", "code": "ehn6IzqX", "country": "steu4pU6", "dateOfBirth": "94ex0bxt", "displayName": "kvXIrbCB", "emailAddress": "52HlTeFV", "password": "mpXnrWDC", "passwordMD5Sum": "ij8S73sQ", "reachMinimumAge": true, "username": "Ny12G1Pi"}' > $TEMP_JSON_INPUT
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

#- 269 CreateUserFromInvitationV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "xV0rwMM7", "policyId": "HsMJnUBZ", "policyVersionId": "6Gyhfcrd"}], "authType": "deIOhxQM", "country": "ImB13f1o", "dateOfBirth": "bTKrwFXC", "displayName": "2Op2yXEI", "password": "OAJh6XNW", "reachMinimumAge": true, "username": "HWdmibqD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV4 \
    --invitationId 'eNic565h' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 270 PublicUpdateUserV4
# body param: body
echo '{"country": "vy1VY236", "dateOfBirth": "5rUHkxww", "displayName": "pNwFJyOB", "languageTag": "elglT04u", "userName": "RmAeOhTe"}' > $TEMP_JSON_INPUT
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

#- 271 PublicUpdateUserEmailAddressV4
# body param: body
echo '{"code": "ibSq4H7x", "emailAddress": "De1jh7cl"}' > $TEMP_JSON_INPUT
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

#- 272 PublicUpgradeHeadlessAccountWithVerificationCodeV4
# body param: body
echo '{"code": "QulgjFzO", "country": "E2zPDGQY", "dateOfBirth": "K5uGsklK", "displayName": "Ej2cImuL", "emailAddress": "S8rrBfOa", "password": "AENFCnYb", "reachMinimumAge": true, "username": "kTf41ag7", "validateOnly": true}' > $TEMP_JSON_INPUT
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

#- 273 PublicUpgradeHeadlessAccountV4
# body param: body
echo '{"emailAddress": "X8oWPut7", "password": "xraYvaea", "username": "iep5aTdb"}' > $TEMP_JSON_INPUT
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

delete_file $TEMP_FILE

exit $FAILED_COUNT