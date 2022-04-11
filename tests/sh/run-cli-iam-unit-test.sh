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

OPERATIONS_COUNT=298

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
echo '{"ACSURL": "jBvBzZGO", "AWSCognitoRegion": "hAwcbpyb", "AWSCognitoUserPool": "Zn4ZE5Om", "AppId": "bNkHnefZ", "ClientId": "WDwi6anY", "Environment": "nQ92kVBD", "FederationMetadataURL": "kaMy03Bu", "GenericOauthFlow": false, "IsActive": true, "Issuer": "bxvTGycc", "JWKSEndpoint": "HSkFQzgV", "KeyID": "R72Dhxbr", "OrganizationId": "4HtKMGr8", "PlatformName": "tnOEeip5", "RedirectUri": "05iJTzZu", "Secret": "ksb4hREc", "TeamID": "Ox3mATUs", "TokenAuthenticationType": "OS0e5Tma", "TokenClaimsMapping": {"pkimopcl": "vfm7fdu7"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'isKaWRcv' \
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
    --platformId 'kLtfmGyS' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 131 UpdateThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "rACKa0mW", "AWSCognitoRegion": "WkDRcuLb", "AWSCognitoUserPool": "IpVJnIAF", "AppId": "pX2SKNmn", "ClientId": "cDRknJor", "Environment": "twVqipgp", "FederationMetadataURL": "XVyWoDjO", "GenericOauthFlow": true, "IsActive": false, "Issuer": "zaXWipcA", "JWKSEndpoint": "HtRkBJXZ", "KeyID": "wQ443FfW", "OrganizationId": "tsTAAgtC", "PlatformName": "nvDp28TM", "RedirectUri": "vlTcBalj", "Secret": "k3sB4LS4", "TeamID": "4hWONXuX", "TokenAuthenticationType": "ihqBVEXS", "TokenClaimsMapping": {"yrZKBvGa": "0LshfP3L"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'qrZcSsGF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 132 UpdateThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"affectedClientIDs": ["DDAiSjXH"], "assignedNamespaces": ["3ypQaqFP"], "domain": "MAjx7edU", "roleId": "xN5KMSLs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '21gdQU0F' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformDomainV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 133 DeleteThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"domain": "hAQYQaHZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '7WtAApJt' \
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
    --platformId 'fB0Xt8Zc' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSSOLoginPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 AddSSOLoginPlatformCredential
# body param: body
echo '{"acsUrl": "puz7BY3J", "apiKey": "PVnMt1HR", "appId": "DFxkSaTd", "federationMetadataUrl": "INJTdRQm", "isActive": true, "redirectUri": "xBjpVFnE", "secret": "gsovZbx4", "ssoUrl": "UF3pYMze"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddSSOLoginPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'FcsBLCwh' \
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
    --platformId 'TStBJZGk' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSSOLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 137 UpdateSSOPlatformCredential
# body param: body
echo '{"acsUrl": "ISL9Sco6", "apiKey": "HxX79bWJ", "appId": "ClH3pXWC", "federationMetadataUrl": "q3ysdpW3", "isActive": true, "redirectUri": "QQmftmA5", "secret": "HUHioxzV", "ssoUrl": "hzHc1rBq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateSSOPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'AXud4JQO' \
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
    --platformId 'WZBzUvNk' \
    --platformUserId 'xTUqI2Xh' \
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
    --roleId 'bYwTxVSX' \
    --after '31' \
    --before '71' \
    --limit '3' \
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
    --emailAddress '2JSuHHCR' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByEmailAddressV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 141 AdminListUserIDByUserIDsV3
# body param: body
echo '{"userIds": ["P9xW9VeY"]}' > $TEMP_JSON_INPUT
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
echo '{"emailAddresses": ["JCDikIap"], "isAdmin": true, "roles": ["mYwbaGfs"]}' > $TEMP_JSON_INPUT
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
    --limit '70' \
    --offset '90' \
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
    --by 'gobWG93d' \
    --endDate 'H2MCGvoh' \
    --limit '35' \
    --offset '6' \
    --platformBy 'Rx6lVi7U' \
    --platformId 'cTmEwe9m' \
    --query 'WH3XVfye' \
    --startDate 'jgTi2E85' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 145 AdminGetBulkUserByEmailAddressV3
# body param: body
echo '{"listEmailAddressRequest": ["VnFsoXaR"]}' > $TEMP_JSON_INPUT
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
    --userId 'Ea1WpsZ5' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 147 AdminUpdateUserV3
# body param: body
echo '{"country": "PoXUApZE", "dateOfBirth": "Pfic39c2", "displayName": "q3a6kRuG", "languageTag": "qHcwZVjA", "userName": "QCkWjE3g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'J6AwW953' \
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
    --userId 'NlFHpDCF' \
    --activeOnly 'True' \
    --after 't39Jhj3l' \
    --before 'mfXJxKJN' \
    --limit '87' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 149 AdminBanUserV3
# body param: body
echo '{"ban": "D3KumRjk", "comment": "3wZYVb3S", "endDate": "Fssnx4JY", "reason": "y1kXakVQ", "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'G01upsR2' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminBanUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 150 AdminUpdateUserBanV3
# body param: body
echo '{"enabled": true, "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserBanV3 \
    --banId 'WaCZcCX2' \
    --namespace $TEST_NAMESPACE \
    --userId 'iLiQGTL6' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 151 AdminSendVerificationCodeV3
# body param: body
echo '{"context": "OYjLlXUV", "emailAddress": "78i8csQI", "languageTag": "O0DRagPX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSendVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'zsBfUhCo' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSendVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 152 AdminVerifyAccountV3
# body param: body
echo '{"Code": "GFgirdML", "ContactType": "exA5zJvQ", "LanguageTag": "d2cOVXFo", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminVerifyAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'aYaSoog7' \
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
    --userId 'pSsQhvXb' \
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
    --userId 'GvqRVSSw' \
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
    --userId 'lRzdNXrf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 156 AdminUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "oKVR4Hhl", "country": "PEfSM2K2", "dateOfBirth": "9oqfZssi", "displayName": "bgoTFQAm", "emailAddress": "IZiTSstC", "password": "2yOumzHM", "validateOnly": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpgradeHeadlessAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'Xysws3Fw' \
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
    --userId 'nu7OX9FZ' \
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
    --userId 'vwJ8OQFu' \
    --after '0.44960385203985576' \
    --before '0.9114964301877354' \
    --limit '31' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 159 AdminUpdateUserPermissionV3
# body param: body
echo '{"Permissions": [{"Action": 90, "Resource": "mT632j8Q", "SchedAction": 11, "SchedCron": "hNDTHb8l", "SchedRange": ["FvBolf9P"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserPermissionV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'di5BLCsT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 160 AdminAddUserPermissionsV3
# body param: body
echo '{"Permissions": [{"Action": 12, "Resource": "72thhduZ", "SchedAction": 27, "SchedCron": "Nj9cRNlT", "SchedRange": ["Bxl3nKj6"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserPermissionsV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'B4ffgtxi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserPermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 161 AdminDeleteUserPermissionBulkV3
# body param: body
echo '[{"Action": 82, "Resource": "LdV0odbf"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionBulkV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'ast4NDIB' \
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
    --action '84' \
    --namespace $TEST_NAMESPACE \
    --resource 'l3UryryO' \
    --userId 'WzhhEmSV' \
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
    --userId 'FhAlEacA' \
    --after 'AoAfsuMB' \
    --before '4W3HIcvS' \
    --limit '53' \
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
    --userId 'L4tYCwCd' \
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
    --targetNamespace 'Cigcxlbl' \
    --userId '30hHHEjM' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 AdminLinkPlatformAccount
# body param: body
echo '{"platformId": "I4LcgkyD", "platformUserId": "sccFdvzo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'afMLoraV' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 AdminPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "j5RiDHvo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '7KepgBTM' \
    --userId 'RiEdeeQw' \
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
    --platformId 'LUW0VLup' \
    --userId 'H83AuxFE' \
    --ticket 'FRDTt2ma' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 AdminDeleteUserRolesV3
# body param: body
echo '["uywaKEsP"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRolesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'BAM1aujN' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 AdminSaveUserRoleV3
# body param: body
echo '[{"namespace": "qlmpKGhv", "roleId": "TKiXeZep"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSaveUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'm7tF1wKh' \
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
    --roleId 'Q4HjEcag' \
    --userId 'yjZITRuo' \
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
    --roleId 'WjICoCN3' \
    --userId 'NyzAV4ni' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 AdminUpdateUserStatusV3
# body param: body
echo '{"enabled": false, "reason": "gDJE12W5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'eoplrOXw' \
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
    --userId 'ASJ1PtQu' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyUserWithoutVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 175 AdminGetRolesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV3 \
    --after 'xOJQKgor' \
    --before '2UMJt4EJ' \
    --isWildcard 'False' \
    --limit '5' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 176 AdminCreateRoleV3
# body param: body
echo '{"adminRole": true, "deletable": false, "isWildcard": false, "managers": [{"displayName": "BNsUvUKh", "namespace": "ANjquBEH", "userId": "OJbaQpz0"}], "members": [{"displayName": "dfiuv051", "namespace": "lkPCaZsj", "userId": "vFvhZdwi"}], "permissions": [{"action": 91, "resource": "i6V2uWuC", "schedAction": 37, "schedCron": "B8FbVDwh", "schedRange": ["pNCLl2bg"]}], "roleName": "Ic1y49bq"}' > $TEMP_JSON_INPUT
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
    --roleId 'pbfyytwm' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 178 AdminDeleteRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV3 \
    --roleId '6jQJpfOI' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 179 AdminUpdateRoleV3
# body param: body
echo '{"deletable": true, "isWildcard": false, "roleName": "gUjKQRjo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV3 \
    --roleId 'yn3bGyFG' \
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
    --roleId 'wcAylTi4' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleAdminStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 AdminUpdateAdminRoleStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAdminRoleStatusV3 \
    --roleId 'qPF190sf' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAdminRoleStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 182 AdminRemoveRoleAdminV3
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleAdminV3 \
    --roleId '2ZwPi5hI' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleAdminV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 183 AdminGetRoleManagersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleManagersV3 \
    --roleId '4k3KwV7P' \
    --after '8R9t4dBR' \
    --before 'pBp4noj3' \
    --limit '71' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 184 AdminAddRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "79DD3bAZ", "namespace": "F4nYBuNx", "userId": "ISmVGVz9"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleManagersV3 \
    --roleId 'Jxj8wegr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 AdminRemoveRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "Do6OmeKL", "namespace": "7GPoI9uW", "userId": "OFTWdRrL"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleManagersV3 \
    --roleId '6yNmv8k1' \
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
    --roleId 'w19JsHSq' \
    --after 'OByh4hhk' \
    --before 'cO6J7jSv' \
    --limit '7' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 AdminAddRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "4J5c6ayF", "namespace": "nSrfmObF", "userId": "TUBRRDGC"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleMembersV3 \
    --roleId 'RQtMc3an' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 AdminRemoveRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "8ZoxLwXH", "namespace": "S1oUzDdD", "userId": "cZ0Rj3YM"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleMembersV3 \
    --roleId '1fz9Cjqt' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 AdminUpdateRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 33, "resource": "eiyDCK7C", "schedAction": 40, "schedCron": "5GcPbmi5", "schedRange": ["KiFDVpfv"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV3 \
    --roleId 'R2Wl0iSh' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 190 AdminAddRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 0, "resource": "gpvFuZu4", "schedAction": 51, "schedCron": "srSpvMLv", "schedRange": ["Qw3sPxFu"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV3 \
    --roleId '8LQGQCAj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 191 AdminDeleteRolePermissionsV3
# body param: body
echo '["6O7ivhNI"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV3 \
    --roleId 'jVT5HSR0' \
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
    --action '93' \
    --resource 'KSLWWzOp' \
    --roleId 'lTLwZQZU' \
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
    --client_id 'MaAJ6ZBT' \
    --extend_exp 'False' \
    --redirect_uri 'GbVtzsBT' \
    --password 'COWEnaLz' \
    --request_id 'HuYKrr89' \
    --user_name 'z0RkL932' \
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
    --platformId 'B7thDQ3h' \
    --userId 'fVnPK8iK' \
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
    --userId '8cdZPnXw' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 AuthorizeV3
$CLI_EXE \
    --sn iam \
    --op AuthorizeV3 \
    --codeChallenge 'GS9fAlxt' \
    --codeChallengeMethod 'S256' \
    --redirectUri 'eZUrqmIc' \
    --scope '7El44MEA' \
    --state 'vaPTwwJr' \
    --targetAuthPage 'G06MtcF7' \
    --clientId 't8DQxcoQ' \
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
    --token 'TWMc41xD' \
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
    --factor 'mUjkXi2L' \
    --mfaToken 'gkALGxw6' \
    >$TEMP_FILE 2>&1
update_status $? 'Change2faMethod'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 Verify2faCode
$CLI_EXE \
    --sn iam \
    --op Verify2faCode \
    --code 'qgvIJBe6' \
    --factor 'rDGbFNzs' \
    --mfaToken 'yQVqvSgt' \
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
    --platformId 'UVddL6A1' \
    --userId 'cTLmuKlG' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveUserThirdPartyPlatformTokenV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 AuthCodeRequestV3
$CLI_EXE \
    --sn iam \
    --op AuthCodeRequestV3 \
    --platformId 'HZdwwo66' \
    --clientId 'H6QOfYzt' \
    --redirectUri 'Hev8RX4M' \
    --requestId 'WRFklN13' \
    >$TEMP_FILE 2>&1
update_status $? 'AuthCodeRequestV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 206 PlatformTokenGrantV3
$CLI_EXE \
    --sn iam \
    --op PlatformTokenGrantV3 \
    --platformId 'WW7U0sRV' \
    --client_id 'CnzRxni0' \
    --device_id 'Kq9Zl2b7' \
    --platform_token 'ChMCxb6x' \
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
    --token 'dzl2OYVR' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenRevocationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 209 TokenGrantV3
$CLI_EXE \
    --sn iam \
    --op TokenGrantV3 \
    --client_id 'JNC7EruV' \
    --code 'ITunbxaO' \
    --code_verifier 'WNrMkfAL' \
    --extend_exp 'True' \
    --password 'rR6M3vzu' \
    --redirect_uri '84TNQYCZ' \
    --refresh_token 'IpKFvpQO' \
    --username 'jjkIYAQE' \
    --grant_type 'authorization_code' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 210 PlatformAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticationV3 \
    --platformId 'xGPTkn2N' \
    --code 'J9gHmB0v' \
    --error 'flV2VptG' \
    --openidAssocHandle 'YAEziSth' \
    --openidClaimedId 'hR9WLiVT' \
    --openidIdentity 'XHhZmByx' \
    --openidMode 'lmWBLyhg' \
    --openidNs 'ZsJoonMp' \
    --openidOpEndpoint 'OQ9Jmh8w' \
    --openidResponseNonce 'wQ28fmxM' \
    --openidReturnTo 'FN8d9fdH' \
    --openidSig 'AHphhby7' \
    --openidSigned 'hGbKeIkY' \
    --state '4Fc8atJ3' \
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
    --languageCode 'bk9YdEm0' \
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
echo '{"platformUserIds": ["o9Rjjnkh"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicListUserIDByPlatformUserIDsV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'wq75VqZH' \
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
    --platformId '8HUq92UF' \
    --platformUserId 'WFC8oFuU' \
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
    --requestId '2OFJ6w1H' \
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
    --by 'bioiiaZ8' \
    --query 'Uc2rWpzX' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 217 PublicCreateUserV3
# body param: body
echo '{"PasswordMD5Sum": "2mgoBhru", "acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "vEzpyRiF", "policyId": "s63b4Pru", "policyVersionId": "2pWiVBYj"}], "authType": "KI1ZlcKX", "code": "BXcPAsjW", "country": "7zBxpVc8", "dateOfBirth": "svjiFtRe", "displayName": "8k7amplf", "emailAddress": "huHropVx", "password": "IvBjsYUE", "reachMinimumAge": true}' > $TEMP_JSON_INPUT
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
    --field 'p1taP9py' \
    --query '4Fl6UoVx' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckUserAvailability'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 219 PublicBulkGetUsers
# body param: body
echo '{"userIds": ["gHJLBm3b"]}' > $TEMP_JSON_INPUT
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
echo '{"emailAddress": "gRvSUyOg", "languageTag": "yu9dhxao"}' > $TEMP_JSON_INPUT
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
echo '{"code": "fTjMYGTM", "emailAddress": "Xy4ypcIN"}' > $TEMP_JSON_INPUT
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
echo '{"emailAddress": "4uUIzvUI", "languageTag": "5b1wxS2y"}' > $TEMP_JSON_INPUT
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
    --invitationId 'BTD8uNea' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 224 CreateUserFromInvitationV3
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "LeXNgQBn", "policyId": "XZkQ06LU", "policyVersionId": "EgyyiBeJ"}], "authType": "ARFVbUvL", "country": "NtDdAntK", "dateOfBirth": "I6vd3QdS", "displayName": "HH2AvosR", "password": "9Nk0JJYX", "reachMinimumAge": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV3 \
    --invitationId 'Qg1LwgzW' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 225 UpdateUserV3
# body param: body
echo '{"country": "Ru5q2i8n", "dateOfBirth": "tDdFSOEI", "displayName": "qFse4ocr", "languageTag": "qjWTbUay", "userName": "IP8oO0z1"}' > $TEMP_JSON_INPUT
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
echo '{"country": "VffDHyFM", "dateOfBirth": "7T2H6g4j", "displayName": "bxDDxngE", "languageTag": "qsAbWEfT", "userName": "c2nSU2Si"}' > $TEMP_JSON_INPUT
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
echo '{"context": "jySpnqX0", "emailAddress": "1uDkQ1tv", "languageTag": "3iMMW8aq"}' > $TEMP_JSON_INPUT
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
echo '{"code": "VbwArhGS", "contactType": "aFxyAsPn", "languageTag": "fbHX5TpI", "validateOnly": false}' > $TEMP_JSON_INPUT
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
echo '{"code": "7dMKaAr2", "country": "VSmtP8qx", "dateOfBirth": "tNo76oPR", "displayName": "uvxUGNJv", "emailAddress": "DRuWXBzy", "password": "WeusWdEJ", "validateOnly": false}' > $TEMP_JSON_INPUT
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
echo '{"emailAddress": "qhXgmVQH", "password": "oZNPy0Wq"}' > $TEMP_JSON_INPUT
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
echo '{"languageTag": "u4qtxTyr", "newPassword": "vNhypNLp", "oldPassword": "orjcAKSu"}' > $TEMP_JSON_INPUT
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
    --targetNamespace 'vgVjdXMn' \
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
    --platformId '2juyP3WX' \
    --redirectUri '3u1OLRUr' \
    --ticket 'Z6vwIqGn' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 PublicPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "oqXXAZd7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'bvO6Xg2x' \
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
    --platformId 'x5vZXC9Y' \
    --clientId 'sEXEe9iC' \
    --redirectUri '3Hp95AtW' \
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
    --platformId 'E8drEipX' \
    --state 'ZfocCS9n' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatformEstablish'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 237 ResetPasswordV3
# body param: body
echo '{"code": "GM6fYF1o", "emailAddress": "77M1VVgH", "newPassword": "HeL0flEP"}' > $TEMP_JSON_INPUT
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
    --userId 'UxHPhE4Y' \
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
    --userId 'wCRBGAR8' \
    --activeOnly 'True' \
    --after 'ZlDIjOfY' \
    --before 'lF5jISj4' \
    --limit '45' \
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
    --userId 'wqLpFnnN' \
    --after '0.3799038459198859' \
    --before '0.9696465709614522' \
    --limit '5' \
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
    --userId 'POtfkEyL' \
    --after 'h6l74AQY' \
    --before '5ulxH0li' \
    --limit '29' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserPlatformAccountsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 242 PublicLinkPlatformAccount
# body param: body
echo '{"platformId": "SoooPhQ9", "platformUserId": "xlLMe7ma"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId '8Qc9aGN5' \
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
    --userId 'UJPLchii' \
    --password 'vOQdByk3' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicValidateUserByUserIDAndPasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 244 PublicGetRolesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRolesV3 \
    --after 'mWQ93Bxb' \
    --before 'P1VP8rKu' \
    --isWildcard 'True' \
    --limit '90' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 245 PublicGetRoleV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRoleV3 \
    --roleId 'TGSX5rG8' \
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
    --platformId 'ymO7ml7S' \
    --code 'CwM6RZNe' \
    --error 'rJQroYUk' \
    --state 'vHx2dAjF' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticateSAMLV3Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 248 LoginSSOClient
$CLI_EXE \
    --sn iam \
    --op LoginSSOClient \
    --platformId 'F0BBGwZ7' \
    --payload 'XWhdoYx1' \
    >$TEMP_FILE 2>&1
update_status $? 'LoginSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 LogoutSSOClient
$CLI_EXE \
    --sn iam \
    --op LogoutSSOClient \
    --platformId '27YYBoxS' \
    >$TEMP_FILE 2>&1
update_status $? 'LogoutSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 AdminBulkCheckValidUserIDV4
# body param: body
echo '{"userIds": ["CFsBbZL1"]}' > $TEMP_JSON_INPUT
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
echo '{"country": "6L2P8eNm", "dateOfBirth": "Oi4OPQ8Z", "displayName": "EV8XzBcA", "languageTag": "niVuoW6w", "userName": "PQlP1zgk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'xv25ZHaR' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 252 AdminUpdateUserEmailAddressV4
# body param: body
echo '{"code": "8vsMhIfo", "emailAddress": "gRB8XeZh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserEmailAddressV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'AM4MAL57' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserEmailAddressV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 253 AdminDisableUserMFAV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableUserMFAV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'riU2QbQF' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDisableUserMFAV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 254 AdminListUserRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminListUserRolesV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'RCXEWG8S' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUserRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 255 AdminUpdateUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["xt5vtTkI"], "roleId": "WbiHTUDD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'L4yzTnQv' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 256 AdminAddUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["0e99zYNk"], "roleId": "H6PuvERG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'P7fmyd8a' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 257 AdminRemoveUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["JkJYGKf4"], "roleId": "wBCsCLrf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'H6V3fTRa' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 AdminGetRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV4 \
    --adminRole 'True' \
    --isWildcard 'True' \
    --limit '59' \
    --offset '34' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 AdminCreateRoleV4
# body param: body
echo '{"adminRole": false, "deletable": false, "isWildcard": true, "roleName": "yfGQvBMJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 260 AdminGetRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV4 \
    --roleId 'Ga0RWFil' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 AdminDeleteRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV4 \
    --roleId 'SDbJxY0Y' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 262 AdminUpdateRoleV4
# body param: body
echo '{"adminRole": true, "deletable": true, "isWildcard": false, "roleName": "yquoA8CG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV4 \
    --roleId 'DmAN0yX8' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 263 AdminUpdateRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 47, "resource": "u01b0bUq", "schedAction": 59, "schedCron": "heu9idRv", "schedRange": ["Q8V1CaeT"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV4 \
    --roleId '74VP6Kqp' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 264 AdminAddRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 70, "resource": "C53CGQXz", "schedAction": 18, "schedCron": "GEvvr9VR", "schedRange": ["6QqaoAup"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV4 \
    --roleId 'KSo0RHRz' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 265 AdminDeleteRolePermissionsV4
# body param: body
echo '["XML3VcaD"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV4 \
    --roleId 'WEzPCi2t' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 266 AdminListAssignedUsersV4
$CLI_EXE \
    --sn iam \
    --op AdminListAssignedUsersV4 \
    --roleId 'WPzhrjLF' \
    --after 'LLuGlXIn' \
    --before 'Vkn9ojnp' \
    --limit '31' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListAssignedUsersV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 267 AdminAssignUserToRoleV4
# body param: body
echo '{"assignedNamespaces": ["iU7rYU09"], "namespace": "8E1JzPma", "userId": "RkeYX8U7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAssignUserToRoleV4 \
    --roleId '1w09mTap' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAssignUserToRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 268 AdminRevokeUserFromRoleV4
# body param: body
echo '{"namespace": "7y90X88q", "userId": "bd2vRMUm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRevokeUserFromRoleV4 \
    --roleId 'qoGBqBax' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRevokeUserFromRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 269 AdminUpdateMyUserV4
# body param: body
echo '{"country": "LbpDekuI", "dateOfBirth": "zTODQZkN", "displayName": "g9XscMV2", "languageTag": "DnOo9Pao", "userName": "BSJJGgg8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateMyUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateMyUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 270 AdminDisableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableMyAuthenticatorV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDisableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 271 AdminEnableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op AdminEnableMyAuthenticatorV4 \
    --code 'epTUehn6' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminEnableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 272 AdminGenerateMyAuthenticatorKeyV4
$CLI_EXE \
    --sn iam \
    --op AdminGenerateMyAuthenticatorKeyV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGenerateMyAuthenticatorKeyV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 273 AdminGetMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 274 AdminGenerateMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminGenerateMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGenerateMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 275 AdminDisableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminDisableMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDisableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 276 AdminDownloadMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminDownloadMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDownloadMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 277 AdminEnableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op AdminEnableMyBackupCodesV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminEnableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 278 AdminGetMyEnabledFactorsV4
$CLI_EXE \
    --sn iam \
    --op AdminGetMyEnabledFactorsV4 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetMyEnabledFactorsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 279 AdminMakeFactorMyDefaultV4
$CLI_EXE \
    --sn iam \
    --op AdminMakeFactorMyDefaultV4 \
    --factor 'IzqXsteu' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminMakeFactorMyDefaultV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 280 AdminInviteUserV4
# body param: body
echo '{"assignedNamespaces": ["4pU694ex"], "emailAddresses": ["0bxtkvXI"], "isAdmin": true, "roleId": "bCB52HlT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminInviteUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 281 PublicCreateTestUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "FVmpXnrW", "policyId": "DCij8S73", "policyVersionId": "sQDNy12G"}], "authType": "1PiTJwxV", "country": "0rwMM7Hs", "dateOfBirth": "MJnUBZ6G", "displayName": "yhfcrdde", "emailAddress": "IOhxQMIm", "password": "B13f1obT", "passwordMD5Sum": "KrwFXC2O", "username": "p2yXEIOA", "verified": false}' > $TEMP_JSON_INPUT
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

#- 282 PublicCreateUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "HWdmibqD", "policyId": "eNic565h", "policyVersionId": "vy1VY236"}], "authType": "5rUHkxww", "code": "pNwFJyOB", "country": "elglT04u", "dateOfBirth": "RmAeOhTe", "displayName": "ibSq4H7x", "emailAddress": "De1jh7cl", "password": "QulgjFzO", "passwordMD5Sum": "E2zPDGQY", "reachMinimumAge": true, "username": "GsklKEj2"}' > $TEMP_JSON_INPUT
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

#- 283 CreateUserFromInvitationV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "ImuLS8rr", "policyId": "BfOaAENF", "policyVersionId": "CnYbIQID"}], "authType": "kTf41ag7", "country": "CX8oWPut", "dateOfBirth": "7xraYvae", "displayName": "aiep5aTd", "password": "bjoDWOL2", "reachMinimumAge": false, "username": "mjDt1rOz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV4 \
    --invitationId '0DT1Axwh' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 284 PublicUpdateUserV4
# body param: body
echo '{"country": "im0K97Zl", "dateOfBirth": "RomBcUU8", "displayName": "6i9DJulX", "languageTag": "4aR8w6Q4", "userName": "PkLkwcg4"}' > $TEMP_JSON_INPUT
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

#- 285 PublicUpdateUserEmailAddressV4
# body param: body
echo '{"code": "w7voonsT", "emailAddress": "uM2oBECn"}' > $TEMP_JSON_INPUT
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

#- 286 PublicUpgradeHeadlessAccountWithVerificationCodeV4
# body param: body
echo '{"code": "fwi61igq", "country": "pB4WwKtA", "dateOfBirth": "nQQIfNq8", "displayName": "tkbUlxAf", "emailAddress": "BvJ3twKU", "password": "1E8SglSH", "reachMinimumAge": true, "username": "OBkao6x7", "validateOnly": true}' > $TEMP_JSON_INPUT
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

#- 287 PublicUpgradeHeadlessAccountV4
# body param: body
echo '{"emailAddress": "SKfNZdIG", "password": "HiCd3vs4", "username": "8k8GmWbZ"}' > $TEMP_JSON_INPUT
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

#- 288 PublicDisableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op PublicDisableMyAuthenticatorV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDisableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 289 PublicEnableMyAuthenticatorV4
$CLI_EXE \
    --sn iam \
    --op PublicEnableMyAuthenticatorV4 \
    --namespace $TEST_NAMESPACE \
    --code 'OgcnbkNs' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicEnableMyAuthenticatorV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 290 PublicGenerateMyAuthenticatorKeyV4
$CLI_EXE \
    --sn iam \
    --op PublicGenerateMyAuthenticatorKeyV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGenerateMyAuthenticatorKeyV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 291 PublicGetMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicGetMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 292 PublicGenerateMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicGenerateMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGenerateMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 293 PublicDisableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicDisableMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDisableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 294 PublicDownloadMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicDownloadMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDownloadMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 295 PublicEnableMyBackupCodesV4
$CLI_EXE \
    --sn iam \
    --op PublicEnableMyBackupCodesV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicEnableMyBackupCodesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 296 PublicRemoveTrustedDeviceV4
$CLI_EXE \
    --sn iam \
    --op PublicRemoveTrustedDeviceV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicRemoveTrustedDeviceV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 297 PublicGetMyEnabledFactorsV4
$CLI_EXE \
    --sn iam \
    --op PublicGetMyEnabledFactorsV4 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyEnabledFactorsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 298 PublicMakeFactorMyDefaultV4
$CLI_EXE \
    --sn iam \
    --op PublicMakeFactorMyDefaultV4 \
    --namespace $TEST_NAMESPACE \
    --factor 'JBKfFAZF' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicMakeFactorMyDefaultV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

delete_file $TEMP_FILE

exit $FAILED_COUNT