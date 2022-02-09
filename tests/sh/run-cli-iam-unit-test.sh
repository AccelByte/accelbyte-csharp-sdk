#!/bin/bash

#Meta:
#- random seed: 512
#- template file: cli-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="dotnet ../../AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/AccelByte.Sdk.Sample.Cli.dll"
CLI_TOKEN_FILE="../../AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/token.txt"

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"

OPERATIONS_COUNT=270

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
    --limit '0.2059190300705097' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserLoginHistories'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 36 UpdatePassword
update_status 0 'UpdatePassword (skipped deprecated)'

#- 37 SaveUserPermission
# body param: body
echo '{"Permissions": [{"Action": 37, "Resource": "5TzT51oV", "SchedAction": 66, "SchedCron": "Tmivmb6t", "SchedRange": ["PmCirkhY"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SaveUserPermission \
    --namespace $TEST_NAMESPACE \
    --userId 'vcOUucjP' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'SaveUserPermission'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 38 AddUserPermission
# body param: body
echo '{"SchedAction": 96, "SchedCron": "GwPsvjLK", "SchedRange": ["1CjPt93u"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddUserPermission \
    --action '39' \
    --namespace $TEST_NAMESPACE \
    --resource 'bMkpUFHT' \
    --userId '0fL9q9SM' \
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
    --action '79' \
    --namespace $TEST_NAMESPACE \
    --resource 'AUQVoiQt' \
    --userId 'SQC2kNSs' \
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
    --userId 'mT0d2aBG' \
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
    --targetNamespace '4zA2zp1L' \
    --userId 's0bD6dGg' \
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
    --platformId 'wkYgHzKu' \
    --userId 'I2RJrboP' \
    --ticket '7kfpIlet' \
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
    --platformId 'XrCK1UVO' \
    --userId '0jcs7nCq' \
    --platform_namespace 'sodoTFTc' \
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
    --userId 'WlaIBJAA' \
    >$TEMP_FILE 2>&1
update_status $? 'GetPublisherUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 46 SaveUserRoles
# body param: body
echo '["knU6HobZ"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op SaveUserRoles \
    --namespace $TEST_NAMESPACE \
    --userId 'gWlaLned' \
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
    --roleId 'DfasTc8g' \
    --userId 'r2znWqD6' \
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
    --roleId 'tIcfI5Z4' \
    --userId 'tUNQ7mQP' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteUserRole'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 49 UpgradeHeadlessAccount
# body param: body
echo '{"LoginID": "jCalZgFV", "Password": "EQyqav09"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpgradeHeadlessAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'OYmxCvMq' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpgradeHeadlessAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 50 UpgradeHeadlessAccountWithVerificationCode
# body param: body
echo '{"Code": "VcXs2OqN", "Password": "z8ZLBsnc", "loginId": "bRrf6uEd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpgradeHeadlessAccountWithVerificationCode \
    --namespace $TEST_NAMESPACE \
    --userId 'jUnr04WZ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpgradeHeadlessAccountWithVerificationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 51 UserVerification
# body param: body
echo '{"Code": "NhgEGvqK", "ContactType": "WQTkE65j", "LanguageTag": "6186p0Wf"}' > $TEMP_JSON_INPUT
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

#- 94 PublicCreateUserV2
# body param: body
echo '{"AuthType": "FcjRpu7w", "Country": "VEzbwHvO", "DisplayName": "Gqwb7FAI", "LoginId": "8lxDoRtw", "Password": "KNHCncWR", "PasswordMD5Sum": "yVDPNRFI"}' > $TEMP_JSON_INPUT
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

#- 95 PublicForgotPasswordV2
# body param: body
echo '{"Context": "bOIi021v", "LanguageTag": "VF26yEKn", "LoginID": "KL26vTDv"}' > $TEMP_JSON_INPUT
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

#- 96 PublicResetPasswordV2
# body param: body
echo '{"Code": "jjj8aEPj", "LoginID": "DWSwW548", "NewPassword": "hHTuJ1jV"}' > $TEMP_JSON_INPUT
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

#- 97 PublicGetUserByUserIDV2
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIDV2 \
    --namespace $TEST_NAMESPACE \
    --userId '4EKppV4D' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByUserIDV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 98 PublicUpdateUserV2
# body param: body
echo '{"Country": "fTxfj3AG", "DateOfBirth": "rDhoJooH", "DisplayName": "5WNF4d6D", "LanguageTag": "ELnHRwig"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdateUserV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'r039B7fw' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdateUserV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 99 PublicGetUserBan
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBan \
    --namespace $TEST_NAMESPACE \
    --userId '1zHG7KQT' \
    --activeOnly 'True' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserBan'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 100 PublicUpdatePasswordV2
# body param: body
echo '{"LanguageTag": "QeIv8R1C", "NewPassword": "tNkXpuQ4", "OldPassword": "g9IiLxJp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicUpdatePasswordV2 \
    --namespace $TEST_NAMESPACE \
    --userId 'TlIMuKCd' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicUpdatePasswordV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 101 GetListJusticePlatformAccounts
$CLI_EXE \
    --sn iam \
    --op GetListJusticePlatformAccounts \
    --namespace $TEST_NAMESPACE \
    --userId 'At0XTdLL' \
    >$TEMP_FILE 2>&1
update_status $? 'GetListJusticePlatformAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 102 PublicPlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV2 \
    --namespace $TEST_NAMESPACE \
    --platformId 'O1WSvdw7' \
    --userId 'FI8mOSB2' \
    --ticket 'rvQkdnYl' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformLinkV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 103 PublicDeletePlatformLinkV2
$CLI_EXE \
    --sn iam \
    --op PublicDeletePlatformLinkV2 \
    --namespace $TEST_NAMESPACE \
    --platformId 'PH6J70BX' \
    --userId 'WVtxOyZz' \
    --platform_namespace 'UrVRKRtJ' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicDeletePlatformLinkV2'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 104 AdminGetBansTypeV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBansTypeV3 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBansTypeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 105 AdminGetListBanReasonV3
$CLI_EXE \
    --sn iam \
    --op AdminGetListBanReasonV3 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListBanReasonV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 106 AdminGetInputValidations
$CLI_EXE \
    --sn iam \
    --op AdminGetInputValidations \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 107 AdminUpdateInputValidations
# body param: body
echo '[{"field": "uZ5W7nPr", "validation": {"allowDigit": true, "allowLetter": false, "allowSpace": false, "allowUnicode": true, "description": [{"language": "C31jYv88", "message": ["32yIJUng"]}], "isCustomRegex": false, "letterCase": "7GSrElr5", "maxLength": 24, "maxRepeatingAlphaNum": 12, "maxRepeatingSpecialCharacter": 51, "minCharType": 86, "minLength": 48, "regex": "G8SZmnOv", "specialCharacterLocation": "u24EFzSQ", "specialCharacters": ["yIXv2yW4"]}}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateInputValidations \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 108 AdminResetInputValidations
$CLI_EXE \
    --sn iam \
    --op AdminResetInputValidations \
    --field 'Uka5jsUl' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminResetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 109 ListAdminsV3
$CLI_EXE \
    --sn iam \
    --op ListAdminsV3 \
    --namespace $TEST_NAMESPACE \
    --after 'Aifni52m' \
    --before 'GYo0BjFU' \
    --limit '89' \
    >$TEMP_FILE 2>&1
update_status $? 'ListAdminsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 110 AdminGetAgeRestrictionStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetAgeRestrictionStatusV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetAgeRestrictionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 111 AdminUpdateAgeRestrictionConfigV3
# body param: body
echo '{"ageRestriction": 9, "enable": true}' > $TEMP_JSON_INPUT
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

#- 112 AdminGetListCountryAgeRestrictionV3
$CLI_EXE \
    --sn iam \
    --op AdminGetListCountryAgeRestrictionV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListCountryAgeRestrictionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 113 AdminUpdateCountryAgeRestrictionV3
# body param: body
echo '{"ageRestriction": 82}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateCountryAgeRestrictionV3 \
    --countryCode 'eZ5SaUa0' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateCountryAgeRestrictionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 114 AdminGetBannedUsersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBannedUsersV3 \
    --namespace $TEST_NAMESPACE \
    --activeOnly 'True' \
    --banType 'aP0Kwv68' \
    --limit '80' \
    --offset '36' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBannedUsersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 115 AdminGetBansTypeWithNamespaceV3
$CLI_EXE \
    --sn iam \
    --op AdminGetBansTypeWithNamespaceV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetBansTypeWithNamespaceV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 116 AdminGetClientsByNamespaceV3
$CLI_EXE \
    --sn iam \
    --op AdminGetClientsByNamespaceV3 \
    --namespace $TEST_NAMESPACE \
    --limit '33' \
    --offset 'OUTPXzel' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetClientsByNamespaceV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 117 AdminCreateClientV3
# body param: body
echo '{"audiences": ["ychmgjLv"], "baseUri": "nOWOk5Ae", "clientId": "kVVmTIEG", "clientName": "2ppf1fH3", "clientPermissions": [{"action": 78, "resource": "wfEQkdzI", "schedAction": 70, "schedCron": "QzAp0rF8", "schedRange": ["gvdnF1yM"]}], "namespace": "voXLWNoQ", "oauthClientType": "ZhvPg7VX", "redirectUri": "5rUNWJaq", "secret": "1fjgDypx"}' > $TEMP_JSON_INPUT
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

#- 118 AdminGetClientsbyNamespacebyIDV3
$CLI_EXE \
    --sn iam \
    --op AdminGetClientsbyNamespacebyIDV3 \
    --clientId 'O4ufKfU7' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetClientsbyNamespacebyIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 119 AdminDeleteClientV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteClientV3 \
    --clientId 'OumxSk0E' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteClientV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 120 AdminUpdateClientV3
# body param: body
echo '{"audiences": ["bju4dSLx"], "baseUri": "4vsb6rx9", "clientName": "Xxsu8TJH", "clientPermissions": [{"action": 31, "resource": "dZVC6y6b", "schedAction": 11, "schedCron": "Qpa7b36m", "schedRange": ["y8LWzMOf"]}], "namespace": "njwsIxM4", "redirectUri": "s9m2qWNv"}' > $TEMP_JSON_INPUT
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

#- 121 AdminUpdateClientPermissionV3
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

#- 122 AdminAddClientPermissionsV3
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

#- 123 AdminDeleteClientPermissionV3
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

#- 124 RetrieveAllThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 125 RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllActiveThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 126 RetrieveAllSSOLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllSSOLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --limit '72' \
    --offset 'XMWuoFv0' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllSSOLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 127 RetrieveThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op RetrieveThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'qjBvBzZG' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 128 AddThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "OhAwcbpy", "AWSCognitoRegion": "bZn4ZE5O", "AWSCognitoUserPool": "mbNkHnef", "AppId": "ZWDwi6an", "ClientId": "YnQ92kVB", "Environment": "DkaMy03B", "FederationMetadataURL": "ul4GW3V0", "IsActive": true, "KeyID": "bxvTGycc", "OrganizationId": "HSkFQzgV", "RedirectUri": "R72Dhxbr", "Secret": "4HtKMGr8", "TeamID": "tnOEeip5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '05iJTzZu' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 129 DeleteThirdPartyLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'ksb4hREc' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 130 UpdateThirdPartyLoginPlatformCredentialV3
# body param: body
echo '{"ACSURL": "Ox3mATUs", "AWSCognitoRegion": "OS0e5Tma", "AWSCognitoUserPool": "pkimopcl", "AppId": "vfm7fdu7", "ClientId": "isKaWRcv", "Environment": "kLtfmGyS", "FederationMetadataURL": "rACKa0mW", "IsActive": false, "KeyID": "DRcuLbIp", "OrganizationId": "VJnIAFpX", "RedirectUri": "2SKNmncD", "Secret": "RknJortw", "TeamID": "VqipgpXV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'yWoDjOHr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 131 UpdateThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"affectedClientIDs": ["GczaXWip"], "assignedNamespaces": ["cAHtRkBJ"], "domain": "XZwQ443F", "roleId": "fWtsTAAg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'tCnvDp28' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateThirdPartyLoginPlatformDomainV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 132 DeleteThirdPartyLoginPlatformDomainV3
# body param: body
echo '{"domain": "TMvlTcBa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op DeleteThirdPartyLoginPlatformDomainV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'ljk3sB4L' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteThirdPartyLoginPlatformDomainV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 133 RetrieveSSOLoginPlatformCredential
$CLI_EXE \
    --sn iam \
    --op RetrieveSSOLoginPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'S44hWONX' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveSSOLoginPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 134 AddSSOLoginPlatformCredential
# body param: body
echo '{"acsUrl": "uXihqBVE", "apiKey": "XSyrZKBv", "appId": "Ga0LshfP", "federationMetadataUrl": "3LqrZcSs", "isActive": true, "redirectUri": "DDAiSjXH", "secret": "3ypQaqFP", "ssoUrl": "MAjx7edU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AddSSOLoginPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'xN5KMSLs' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AddSSOLoginPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 135 DeleteSSOLoginPlatformCredentialV3
$CLI_EXE \
    --sn iam \
    --op DeleteSSOLoginPlatformCredentialV3 \
    --namespace $TEST_NAMESPACE \
    --platformId '21gdQU0F' \
    >$TEMP_FILE 2>&1
update_status $? 'DeleteSSOLoginPlatformCredentialV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 136 UpdateSSOPlatformCredential
# body param: body
echo '{"acsUrl": "hAQYQaHZ", "apiKey": "7WtAApJt", "appId": "fB0Xt8Zc", "federationMetadataUrl": "puz7BY3J", "isActive": false, "redirectUri": "Mt1HRDFx", "secret": "kSaTdINJ", "ssoUrl": "TdRQmMvx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op UpdateSSOPlatformCredential \
    --namespace $TEST_NAMESPACE \
    --platformId 'BjpVFnEg' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'UpdateSSOPlatformCredential'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 137 AdminGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByPlatformUserIDV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'sovZbx4U' \
    --platformUserId 'F3pYMzeF' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByPlatformUserIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 138 GetAdminUsersByRoleIdV3
$CLI_EXE \
    --sn iam \
    --op GetAdminUsersByRoleIdV3 \
    --namespace $TEST_NAMESPACE \
    --roleId 'csBLCwhT' \
    --after '89' \
    --before '39' \
    --limit '55' \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminUsersByRoleIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 139 AdminGetUserByEmailAddressV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByEmailAddressV3 \
    --namespace $TEST_NAMESPACE \
    --emailAddress 'JZGkISL9' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByEmailAddressV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 140 AdminListUserIDByUserIDsV3
# body param: body
echo '{"userIds": ["Sco6HxX7"]}' > $TEMP_JSON_INPUT
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

#- 141 AdminInviteUserV3
# body param: body
echo '{"emailAddresses": ["9bWJClH3"], "isAdmin": false, "roles": ["XWCq3ysd"]}' > $TEMP_JSON_INPUT
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

#- 142 AdminListUsersV3
$CLI_EXE \
    --sn iam \
    --op AdminListUsersV3 \
    --namespace $TEST_NAMESPACE \
    --limit '31' \
    --offset '96' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUsersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 143 AdminSearchUserV3
$CLI_EXE \
    --sn iam \
    --op AdminSearchUserV3 \
    --namespace $TEST_NAMESPACE \
    --by '3XyQQmft' \
    --endDate 'mA5HUHio' \
    --limit '46' \
    --offset 'zVhzHc1r' \
    --platformBy 'BqAXud4J' \
    --platformId 'QOWZBzUv' \
    --query 'NkxTUqI2' \
    --startDate 'XhbYwTxV' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 144 AdminGetBulkUserByEmailAddressV3
# body param: body
echo '{"listEmailAddressRequest": ["SXpJb2JS"]}' > $TEMP_JSON_INPUT
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

#- 145 AdminGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserByUserIdV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'uHHCRP9x' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 146 AdminUpdateUserV3
# body param: body
echo '{"country": "W9VeYJCD", "dateOfBirth": "ikIapumY", "displayName": "wbaGfsJT", "languageTag": "gobWG93d", "userName": "H2MCGvoh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'rdRx6lVi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 147 AdminGetUserBanV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserBanV3 \
    --namespace $TEST_NAMESPACE \
    --userId '7UcTmEwe' \
    --activeOnly 'False' \
    --after 'WH3XVfye' \
    --before 'jgTi2E85' \
    --limit '95' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 148 AdminBanUserV3
# body param: body
echo '{"ban": "nFsoXaRE", "comment": "a1WpsZ5P", "endDate": "oXUApZEP", "reason": "fic39c2q", "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminBanUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId '6kRuGqHc' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminBanUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 149 AdminUpdateUserBanV3
# body param: body
echo '{"enabled": true, "skipNotif": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserBanV3 \
    --banId 'AQCkWjE3' \
    --namespace $TEST_NAMESPACE \
    --userId 'gJ6AwW95' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserBanV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 150 AdminSendVerificationCodeV3
# body param: body
echo '{"context": "3NlFHpDC", "emailAddress": "Fut39Jhj", "languageTag": "3lmfXJxK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSendVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'JNRD3Kum' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSendVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 151 AdminVerifyAccountV3
# body param: body
echo '{"Code": "Rjk3wZYV", "ContactType": "b3SFssnx", "LanguageTag": "4JYy1kXa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminVerifyAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'kVQoG01u' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyAccountV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 152 GetUserVerificationCode
$CLI_EXE \
    --sn iam \
    --op GetUserVerificationCode \
    --namespace $TEST_NAMESPACE \
    --userId 'psR2PZ0E' \
    >$TEMP_FILE 2>&1
update_status $? 'GetUserVerificationCode'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 153 AdminGetUserDeletionStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserDeletionStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId '2oWaCZcC' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 154 AdminUpdateUserDeletionStatusV3
# body param: body
echo '{"enabled": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserDeletionStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'LiQGTL6O' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserDeletionStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 155 AdminUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "YjLlXUV7", "country": "8i8csQIO", "dateOfBirth": "0DRagPXz", "displayName": "sBfUhCoG", "emailAddress": "FgirdMLe", "password": "xA5zJvQd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpgradeHeadlessAccountV3 \
    --namespace $TEST_NAMESPACE \
    --userId '2cOVXFoi' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpgradeHeadlessAccountV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 156 AdminDeleteUserInformationV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserInformationV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'aYaSoog7' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserInformationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 157 AdminGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserLoginHistoriesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'pSsQhvXb' \
    --after '0.5021168390637625' \
    --before '0.25060815867870634' \
    --limit '0.7375615216008776' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 158 AdminUpdateUserPermissionV3
# body param: body
echo '{"Permissions": [{"Action": 89, "Resource": "wvlRzdNX", "SchedAction": 35, "SchedCron": "foKVR4Hh", "SchedRange": ["lPEfSM2K"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserPermissionV3 \
    --namespace $TEST_NAMESPACE \
    --userId '29oqfZss' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 159 AdminAddUserPermissionsV3
# body param: body
echo '{"Permissions": [{"Action": 17, "Resource": "bgoTFQAm", "SchedAction": 69, "SchedCron": "ZiTSstC2", "SchedRange": ["yOumzHMh"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserPermissionsV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'Xysws3Fw' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserPermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 160 AdminDeleteUserPermissionBulkV3
# body param: body
echo '[{"Action": 27, "Resource": "u7OX9FZv"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionBulkV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'wJ8OQFuC' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserPermissionBulkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 161 AdminDeleteUserPermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserPermissionV3 \
    --action '66' \
    --namespace $TEST_NAMESPACE \
    --resource '68pTmT63' \
    --userId '2j8QfhND' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserPermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 162 AdminGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op AdminGetUserPlatformAccountsV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'THb8lFvB' \
    --after 'olf9Pdi5' \
    --before 'BLCsT8g7' \
    --limit '39' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetUserPlatformAccountsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 163 AdminGetListJusticePlatformAccounts
$CLI_EXE \
    --sn iam \
    --op AdminGetListJusticePlatformAccounts \
    --namespace $TEST_NAMESPACE \
    --userId 'hhduZnNj' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetListJusticePlatformAccounts'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 164 AdminCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op AdminCreateJusticeUser \
    --namespace $TEST_NAMESPACE \
    --targetNamespace '9cRNlTBx' \
    --userId 'l3nKj6B4' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 165 AdminLinkPlatformAccount
# body param: body
echo '{"platformId": "ffgtxiPL", "platformUserId": "dV0odbfa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'st4NDIBQ' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 166 AdminPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "l3UryryO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'WzhhEmSV' \
    --userId 'FhAlEacA' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPlatformUnlinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 167 AdminPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op AdminPlatformLinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'AoAfsuMB' \
    --userId '4W3HIcvS' \
    --ticket '0AL4tYCw' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 168 AdminDeleteUserRolesV3
# body param: body
echo '["CdCigcxl"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRolesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'bl30hHHE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 169 AdminSaveUserRoleV3
# body param: body
echo '[{"namespace": "jMI4Lcgk", "roleId": "yDsccFdv"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminSaveUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'zoafMLor' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminSaveUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 170 AdminAddUserRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --roleId 'aVj5RiDH' \
    --userId 'vo7KepgB' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 171 AdminDeleteUserRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteUserRoleV3 \
    --namespace $TEST_NAMESPACE \
    --roleId 'TMRiEdee' \
    --userId 'QwLUW0VL' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteUserRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 172 AdminUpdateUserStatusV3
# body param: body
echo '{"enabled": true, "reason": "pH83AuxF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserStatusV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'EFRDTt2m' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 173 AdminVerifyUserWithoutVerificationCodeV3
$CLI_EXE \
    --sn iam \
    --op AdminVerifyUserWithoutVerificationCodeV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'auywaKEs' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminVerifyUserWithoutVerificationCodeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 174 AdminGetRolesV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV3 \
    --after 'PBAM1auj' \
    --before 'NqlmpKGh' \
    --isWildcard 'True' \
    --limit '90' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 175 AdminCreateRoleV3
# body param: body
echo '{"adminRole": false, "isWildcard": false, "managers": [{"displayName": "Zepm7tF1", "namespace": "wKhQ4HjE", "userId": "cagyjZIT"}], "members": [{"displayName": "RuoWjICo", "namespace": "CN3NyzAV", "userId": "4niQQVjg"}], "permissions": [{"action": 59, "resource": "JE12W5eo", "schedAction": 30, "schedCron": "lrOXwASJ", "schedRange": ["1PtQuxOJ"]}], "roleName": "QKgor2UM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV3 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 176 AdminGetRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV3 \
    --roleId 'Jt4EJ9Gc' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 177 AdminDeleteRoleV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV3 \
    --roleId 'cYTYxPTg' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 178 AdminUpdateRoleV3
# body param: body
echo '{"isWildcard": false, "roleName": "BNsUvUKh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV3 \
    --roleId 'ANjquBEH' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 179 AdminGetRoleAdminStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleAdminStatusV3 \
    --roleId 'OJbaQpz0' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleAdminStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 180 AdminUpdateAdminRoleStatusV3
$CLI_EXE \
    --sn iam \
    --op AdminUpdateAdminRoleStatusV3 \
    --roleId 'dfiuv051' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateAdminRoleStatusV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 181 AdminRemoveRoleAdminV3
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleAdminV3 \
    --roleId 'lkPCaZsj' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleAdminV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 182 AdminGetRoleManagersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleManagersV3 \
    --roleId 'vFvhZdwi' \
    --after '1Ti6V2uW' \
    --before 'uCsB8FbV' \
    --limit '58' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 183 AdminAddRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "whpNCLl2", "namespace": "bgIc1y49", "userId": "bqpbfyyt"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleManagersV3 \
    --roleId 'wm6jQJpf' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 184 AdminRemoveRoleManagersV3
# body param: body
echo '{"managers": [{"displayName": "OIKCegUj", "namespace": "KQRjoyn3", "userId": "bGyFGwcA"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleManagersV3 \
    --roleId 'ylTi4qPF' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleManagersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 185 AdminGetRoleMembersV3
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleMembersV3 \
    --roleId '190sf2Zw' \
    --after 'Pi5hI4k3' \
    --before 'KwV7P8R9' \
    --limit '38' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 186 AdminAddRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "4dBRpBp4", "namespace": "noj3J79D", "userId": "D3bAZF4n"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRoleMembersV3 \
    --roleId 'YBuNxISm' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 187 AdminRemoveRoleMembersV3
# body param: body
echo '{"members": [{"displayName": "VGVz9Jxj", "namespace": "8wegrDo6", "userId": "OmeKL7GP"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveRoleMembersV3 \
    --roleId 'oI9uWOFT' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveRoleMembersV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 188 AdminUpdateRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 97, "resource": "dRrL6yNm", "schedAction": 43, "schedCron": "8k1w19Js", "schedRange": ["HSqOByh4"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV3 \
    --roleId 'hhkcO6J7' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 189 AdminAddRolePermissionsV3
# body param: body
echo '{"permissions": [{"action": 18, "resource": "SvYd4J5c", "schedAction": 1, "schedCron": "yFnSrfmO", "schedRange": ["bFTUBRRD"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV3 \
    --roleId 'GCRQtMc3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 190 AdminDeleteRolePermissionsV3
# body param: body
echo '["an8ZoxLw"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV3 \
    --roleId 'XHS1oUzD' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 191 AdminDeleteRolePermissionV3
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionV3 \
    --action '6' \
    --resource 'DcZ0Rj3Y' \
    --roleId 'M1fz9Cjq' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 192 AdminGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op AdminGetMyUserV3 \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetMyUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 193 UserAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op UserAuthenticationV3 \
    --client_id 'tqeiyDCK' \
    --extend_exp 'True' \
    --redirect_uri '3u5GcPbm' \
    --password 'i5KiFDVp' \
    --request_id 'fvR2Wl0i' \
    --user_name 'ShagpvFu' \
    >$TEMP_FILE 2>&1
update_status $? 'UserAuthenticationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 194 GetCountryLocationV3
$CLI_EXE \
    --sn iam \
    --op GetCountryLocationV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetCountryLocationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 195 Logout
$CLI_EXE \
    --sn iam \
    --op Logout \
    >$TEMP_FILE 2>&1
update_status $? 'Logout'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 196 AdminRetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op AdminRetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'Zu45zsrS' \
    --userId 'pvMLvQw3' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRetrieveUserThirdPartyPlatformTokenV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 197 RevokeUserV3
$CLI_EXE \
    --sn iam \
    --op RevokeUserV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'sPxFu8LQ' \
    >$TEMP_FILE 2>&1
update_status $? 'RevokeUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 198 AuthorizeV3
$CLI_EXE \
    --sn iam \
    --op AuthorizeV3 \
    --codeChallenge 'GQCAj6O7' \
    --codeChallengeMethod 'S256' \
    --redirectUri 'vhNIjVT5' \
    --scope 'HSR00UKS' \
    --state 'LWWzOplT' \
    --targetAuthPage 'LwZQZUMa' \
    --clientId 'AJ6ZBTHY' \
    --responseType 'code' \
    >$TEMP_FILE 2>&1
update_status $? 'AuthorizeV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 199 TokenIntrospectionV3
$CLI_EXE \
    --sn iam \
    --op TokenIntrospectionV3 \
    --token 'GbVtzsBT' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenIntrospectionV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 200 GetJWKSV3
$CLI_EXE \
    --sn iam \
    --op GetJWKSV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetJWKSV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 201 RetrieveUserThirdPartyPlatformTokenV3
$CLI_EXE \
    --sn iam \
    --op RetrieveUserThirdPartyPlatformTokenV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'COWEnaLz' \
    --userId 'HuYKrr89' \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveUserThirdPartyPlatformTokenV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 202 AuthCodeRequestV3
$CLI_EXE \
    --sn iam \
    --op AuthCodeRequestV3 \
    --platformId 'z0RkL932' \
    --clientId 'B7thDQ3h' \
    --redirectUri 'fVnPK8iK' \
    --requestId '8cdZPnXw' \
    >$TEMP_FILE 2>&1
update_status $? 'AuthCodeRequestV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 203 PlatformTokenGrantV3
$CLI_EXE \
    --sn iam \
    --op PlatformTokenGrantV3 \
    --platformId 'GS9fAlxt' \
    --client_id 'jeZUrqmI' \
    --device_id 'c7El44ME' \
    --platform_token 'AvaPTwwJ' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformTokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 204 GetRevocationListV3
$CLI_EXE \
    --sn iam \
    --op GetRevocationListV3 \
    >$TEMP_FILE 2>&1
update_status $? 'GetRevocationListV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 205 TokenRevocationV3
$CLI_EXE \
    --sn iam \
    --op TokenRevocationV3 \
    --token 'rG06MtcF' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenRevocationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 206 TokenGrantV3
$CLI_EXE \
    --sn iam \
    --op TokenGrantV3 \
    --client_id '7t8DQxco' \
    --code 'QBTWMc41' \
    --code_verifier 'xDmUjkXi' \
    --redirect_uri '2LgkALGx' \
    --refresh_token 'w6qgvIJB' \
    --grant_type 'authorization_code' \
    >$TEMP_FILE 2>&1
update_status $? 'TokenGrantV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 207 PlatformAuthenticationV3
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticationV3 \
    --platformId '6rDGbFNz' \
    --code 'syQVqvSg' \
    --error 'tpUVddL6' \
    --openidAssocHandle 'A1cTLmuK' \
    --openidClaimedId 'lGHZdwwo' \
    --openidIdentity '66H6QOfY' \
    --openidMode 'ztHev8RX' \
    --openidNs '4MWRFklN' \
    --openidOpEndpoint '13WW7U0s' \
    --openidResponseNonce 'RVCnzRxn' \
    --openidReturnTo 'i0Kq9Zl2' \
    --openidSig 'b7ChMCxb' \
    --openidSigned '6xdzl2OY' \
    --state 'VRJNC7Er' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 208 PublicGetInputValidations
$CLI_EXE \
    --sn iam \
    --op PublicGetInputValidations \
    --defaultOnEmpty 'True' \
    --languageCode 'VITunbxa' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetInputValidations'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 209 RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
$CLI_EXE \
    --sn iam \
    --op RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 210 PublicListUserIDByPlatformUserIDsV3
# body param: body
echo '{"platformUserIds": ["OWNrMkfA"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicListUserIDByPlatformUserIDsV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'LUDrR6M3' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicListUserIDByPlatformUserIDsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 211 PublicGetUserByPlatformUserIDV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByPlatformUserIDV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'vzu84TNQ' \
    --platformUserId 'YCZIpKFv' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByPlatformUserIDV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 212 PublicGetAsyncStatus
$CLI_EXE \
    --sn iam \
    --op PublicGetAsyncStatus \
    --namespace $TEST_NAMESPACE \
    --requestId 'pQOjjkIY' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetAsyncStatus'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 213 PublicSearchUserV3
$CLI_EXE \
    --sn iam \
    --op PublicSearchUserV3 \
    --namespace $TEST_NAMESPACE \
    --by 'AQEcxGPT' \
    --query 'kn2NJ9gH' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicSearchUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 214 PublicCreateUserV3
# body param: body
echo '{"PasswordMD5Sum": "mB0vflV2", "acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "tGYAEziS", "policyId": "thhR9WLi", "policyVersionId": "VTXHhZmB"}], "authType": "yxlmWBLy", "country": "hgZsJoon", "dateOfBirth": "MpOQ9Jmh", "displayName": "8wwQ28fm", "emailAddress": "xMFN8d9f", "password": "dHAHphhb"}' > $TEMP_JSON_INPUT
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

#- 215 CheckUserAvailability
$CLI_EXE \
    --sn iam \
    --op CheckUserAvailability \
    --namespace $TEST_NAMESPACE \
    --field 'y7hGbKeI' \
    --query 'kY4Fc8at' \
    >$TEMP_FILE 2>&1
update_status $? 'CheckUserAvailability'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 216 PublicBulkGetUsers
# body param: body
echo '{"userIds": ["J3J4gbk9"]}' > $TEMP_JSON_INPUT
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

#- 217 PublicForgotPasswordV3
# body param: body
echo '{"emailAddress": "YdEm0o9R", "languageTag": "jjnkhwq7"}' > $TEMP_JSON_INPUT
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

#- 218 GetAdminInvitationV3
$CLI_EXE \
    --sn iam \
    --op GetAdminInvitationV3 \
    --invitationId '5VqZH8HU' \
    --namespace $TEST_NAMESPACE \
    >$TEMP_FILE 2>&1
update_status $? 'GetAdminInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 219 CreateUserFromInvitationV3
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "92UFWFC8", "policyId": "oFuU2OFJ", "policyVersionId": "6w1Hbioi"}], "authType": "iaZ8Uc2r", "country": "WpzX2mgo", "dateOfBirth": "BhruuvEz", "displayName": "pyRiFs63", "password": "b4Pru2pW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV3 \
    --invitationId 'iVBYjKI1' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 220 UpdateUserV3
# body param: body
echo '{"country": "ZlcKXBXc", "dateOfBirth": "PAsjW7zB", "displayName": "xpVc8svj", "languageTag": "iFtRe8k7", "userName": "amplfhuH"}' > $TEMP_JSON_INPUT
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

#- 221 PublicUpdateUserV3
# body param: body
echo '{"country": "ropVxIvB", "dateOfBirth": "jsYUEDp1", "displayName": "taP9py4F", "languageTag": "l6UoVxgH", "userName": "JLBm3bgR"}' > $TEMP_JSON_INPUT
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

#- 222 PublicSendVerificationCodeV3
# body param: body
echo '{"context": "vSUyOgyu", "emailAddress": "9dhxaofT", "languageTag": "jMYGTMXy"}' > $TEMP_JSON_INPUT
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

#- 223 PublicUserVerificationV3
# body param: body
echo '{"code": "4ypcIN4u", "contactType": "UIzvUI5b", "languageTag": "1wxS2yBT"}' > $TEMP_JSON_INPUT
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

#- 224 PublicUpgradeHeadlessAccountV3
# body param: body
echo '{"code": "D8uNeauL", "country": "eXNgQBnX", "dateOfBirth": "ZkQ06LUE", "displayName": "gyyiBeJA", "emailAddress": "RFVbUvLN", "password": "tDdAntKI"}' > $TEMP_JSON_INPUT
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

#- 225 PublicVerifyHeadlessAccountV3
# body param: body
echo '{"emailAddress": "6vd3QdSH", "password": "H2AvosR9"}' > $TEMP_JSON_INPUT
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

#- 226 PublicUpdatePasswordV3
# body param: body
echo '{"languageTag": "Nk0JJYXM", "newPassword": "RcQg1Lwg", "oldPassword": "zWRu5q2i"}' > $TEMP_JSON_INPUT
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

#- 227 PublicCreateJusticeUser
$CLI_EXE \
    --sn iam \
    --op PublicCreateJusticeUser \
    --namespace $TEST_NAMESPACE \
    --targetNamespace '8ntDdFSO' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicCreateJusticeUser'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 228 PublicPlatformLinkV3
$CLI_EXE \
    --sn iam \
    --op PublicPlatformLinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'EIqFse4o' \
    --redirectUri 'crqjWTbU' \
    --ticket 'ayIP8oO0' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformLinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 229 PublicPlatformUnlinkV3
# body param: body
echo '{"platformNamespace": "z1VffDHy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicPlatformUnlinkV3 \
    --namespace $TEST_NAMESPACE \
    --platformId 'FM7T2H6g' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicPlatformUnlinkV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 230 PublicWebLinkPlatform
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatform \
    --namespace $TEST_NAMESPACE \
    --platformId '4jbxDDxn' \
    --clientId 'gEqsAbWE' \
    --redirectUri 'fTc2nSU2' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatform'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 231 PublicWebLinkPlatformEstablish
$CLI_EXE \
    --sn iam \
    --op PublicWebLinkPlatformEstablish \
    --namespace $TEST_NAMESPACE \
    --platformId 'SijySpnq' \
    --state 'X01uDkQ1' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicWebLinkPlatformEstablish'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 232 ResetPasswordV3
# body param: body
echo '{"code": "tv3iMMW8", "emailAddress": "aqVbwArh", "newPassword": "GSaFxyAs"}' > $TEMP_JSON_INPUT
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

#- 233 PublicGetUserByUserIdV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserByUserIdV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'PnfbHX5T' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserByUserIdV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 234 PublicGetUserBanHistoryV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserBanHistoryV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'pIV6e7dM' \
    --activeOnly 'False' \
    --after 'Ar2VSmtP' \
    --before '8qxtNo76' \
    --limit '28' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserBanHistoryV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 235 PublicGetUserLoginHistoriesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserLoginHistoriesV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'PRuvxUGN' \
    --after '0.9942829427304808' \
    --before '0.3360188340083251' \
    --limit '0.6723495149599609' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserLoginHistoriesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 236 PublicGetUserPlatformAccountsV3
$CLI_EXE \
    --sn iam \
    --op PublicGetUserPlatformAccountsV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'WXBzyWeu' \
    --after 'sWdEJnqh' \
    --before 'XgmVQHoZ' \
    --limit '79' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetUserPlatformAccountsV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 237 PublicLinkPlatformAccount
# body param: body
echo '{"platformId": "Py0Wqu4q", "platformUserId": "txTyrvNh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op PublicLinkPlatformAccount \
    --namespace $TEST_NAMESPACE \
    --userId 'ypNLporj' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'PublicLinkPlatformAccount'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 238 PublicValidateUserByUserIDAndPasswordV3
$CLI_EXE \
    --sn iam \
    --op PublicValidateUserByUserIDAndPasswordV3 \
    --namespace $TEST_NAMESPACE \
    --userId 'cAKSuvgV' \
    --password 'jdXMn2ju' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicValidateUserByUserIDAndPasswordV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 239 PublicGetRolesV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRolesV3 \
    --after 'yP3WX3u1' \
    --before 'OLRUrZ6v' \
    --isWildcard 'True' \
    --limit '68' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRolesV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 240 PublicGetRoleV3
$CLI_EXE \
    --sn iam \
    --op PublicGetRoleV3 \
    --roleId 'qGnoqXXA' \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetRoleV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 241 PublicGetMyUserV3
$CLI_EXE \
    --sn iam \
    --op PublicGetMyUserV3 \
    >$TEMP_FILE 2>&1
update_status $? 'PublicGetMyUserV3'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 242 PlatformAuthenticateSAMLV3Handler
$CLI_EXE \
    --sn iam \
    --op PlatformAuthenticateSAMLV3Handler \
    --platformId 'Zd7bvO6X' \
    --code 'g2xx5vZX' \
    --error 'C9YsEXEe' \
    --state '9iC3Hp95' \
    >$TEMP_FILE 2>&1
update_status $? 'PlatformAuthenticateSAMLV3Handler'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 243 LoginSSOClient
$CLI_EXE \
    --sn iam \
    --op LoginSSOClient \
    --platformId 'AtWE8drE' \
    --payload 'ipXZfocC' \
    >$TEMP_FILE 2>&1
update_status $? 'LoginSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 244 LogoutSSOClient
$CLI_EXE \
    --sn iam \
    --op LogoutSSOClient \
    --platformId 'S9nGM6fY' \
    >$TEMP_FILE 2>&1
update_status $? 'LogoutSSOClient'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 245 AdminUpdateUserV4
# body param: body
echo '{"country": "F1o77M1V", "dateOfBirth": "VgHHeL0f", "displayName": "lEPUxHPh", "languageTag": "E4YwCRBG", "userName": "AR8TtZlD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'IjOfYlF5' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 246 AdminUpdateUserEmailAddressV4
# body param: body
echo '{"code": "jISj4wwq", "emailAddress": "LpFnnNyd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserEmailAddressV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'TcPOtfkE' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserEmailAddressV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 247 AdminListUserRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminListUserRolesV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'yLh6l74A' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListUserRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 248 AdminUpdateUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["QY5ulxH0"], "roleId": "lioSoooP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'hQ9xlLMe' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 249 AdminAddUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["7ma8Qc9a"], "roleId": "GN5UJPLc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'hiivOQdB' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 250 AdminRemoveUserRoleV4
# body param: body
echo '{"assignedNamespaces": ["yk3mWQ93"], "roleId": "BxbP1VP8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRemoveUserRoleV4 \
    --namespace $TEST_NAMESPACE \
    --userId 'rKuVwTTG' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRemoveUserRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 251 AdminGetRolesV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRolesV4 \
    --adminRole 'True' \
    --isWildcard 'True' \
    --limit '24' \
    --offset '80' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRolesV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 252 AdminCreateRoleV4
# body param: body
echo '{"adminRole": false, "isWildcard": false, "roleName": "7SCwM6RZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminCreateRoleV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminCreateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 253 AdminGetRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminGetRoleV4 \
    --roleId 'NerJQroY' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminGetRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 254 AdminDeleteRoleV4
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRoleV4 \
    --roleId 'UkvHx2dA' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 255 AdminUpdateRoleV4
# body param: body
echo '{"adminRole": false, "isWildcard": true, "roleName": "F0BBGwZ7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRoleV4 \
    --roleId 'XWhdoYx1' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 256 AdminUpdateRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 100, "resource": "YBoxSCFs", "schedAction": 55, "schedCron": "bZL16L2P", "schedRange": ["8eNmOi4O"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateRolePermissionsV4 \
    --roleId 'PQ8ZEV8X' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 257 AdminAddRolePermissionsV4
# body param: body
echo '{"permissions": [{"action": 51, "resource": "BcAniVuo", "schedAction": 96, "schedCron": "6wPQlP1z", "schedRange": ["gkxv25ZH"]}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAddRolePermissionsV4 \
    --roleId 'aR8vsMhI' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAddRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 258 AdminDeleteRolePermissionsV4
# body param: body
echo '["fogRB8Xe"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminDeleteRolePermissionsV4 \
    --roleId 'ZhAM4MAL' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminDeleteRolePermissionsV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 259 AdminListAssignedUsersV4
$CLI_EXE \
    --sn iam \
    --op AdminListAssignedUsersV4 \
    --roleId '57riU2Qb' \
    --after 'QFRCXEWG' \
    --before '8Sxt5vtT' \
    --limit '20' \
    >$TEMP_FILE 2>&1
update_status $? 'AdminListAssignedUsersV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 260 AdminAssignUserToRoleV4
# body param: body
echo '{"assignedNamespaces": ["IWbiHTUD"], "namespace": "DL4yzTnQ", "userId": "v0e99zYN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminAssignUserToRoleV4 \
    --roleId 'kH6PuvER' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminAssignUserToRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 261 AdminRevokeUserFromRoleV4
# body param: body
echo '{"namespace": "GP7fmyd8", "userId": "aJkJYGKf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminRevokeUserFromRoleV4 \
    --roleId '4wBCsCLr' \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminRevokeUserFromRoleV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 262 AdminUpdateMyUserV4
# body param: body
echo '{"country": "fH6V3fTR", "dateOfBirth": "ar0UZS96", "displayName": "wD9rgdYv", "languageTag": "yfGQvBMJ", "userName": "Ga0RWFil"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminUpdateMyUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminUpdateMyUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 263 AdminInviteUserV4
# body param: body
echo '{"assignedNamespaces": ["SDbJxY0Y"], "emailAddresses": ["R9wXVRz5"], "isAdmin": false, "roleId": "yquoA8CG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op AdminInviteUserV4 \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'AdminInviteUserV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 264 PublicCreateTestUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": true, "localizedPolicyVersionId": "mAN0yX8x", "policyId": "u01b0bUq", "policyVersionId": "Dheu9idR"}], "authType": "vQ8V1Cae", "country": "T74VP6Kq", "dateOfBirth": "pZ2JC53C", "displayName": "GQXzjGEv", "emailAddress": "vr9VR6Qq", "password": "aoAupKSo", "passwordMD5Sum": "0RHRzXML", "username": "3VcaDWEz", "verified": true}' > $TEMP_JSON_INPUT
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

#- 265 PublicCreateUserV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "2tWPzhrj", "policyId": "LFLLuGlX", "policyVersionId": "InVkn9oj"}], "authType": "nppiU7rY", "country": "U098E1Jz", "dateOfBirth": "PmaRkeYX", "displayName": "8U71w09m", "emailAddress": "Tap7y90X", "password": "88qbd2vR", "passwordMD5Sum": "MUmqoGBq", "username": "BaxLbpDe"}' > $TEMP_JSON_INPUT
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

#- 266 CreateUserFromInvitationV4
# body param: body
echo '{"acceptedPolicies": [{"isAccepted": false, "localizedPolicyVersionId": "uIzTODQZ", "policyId": "kNg9XscM", "policyVersionId": "V2DnOo9P"}], "authType": "aoBSJJGg", "country": "g8epTUeh", "dateOfBirth": "n6IzqXst", "displayName": "eu4pU694", "password": "ex0bxtkv", "username": "XIrbCB52"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn iam \
    --op CreateUserFromInvitationV4 \
    --invitationId 'HlTeFVmp' \
    --namespace $TEST_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    >$TEMP_FILE 2>&1
update_status $? 'CreateUserFromInvitationV4'
delete_file $TEMP_FILE
rm -f $TEMP_JSON_INPUT
rm -f $TEMP_FILE_UPLOAD

#- 267 PublicUpdateUserV4
# body param: body
echo '{"country": "XnrWDCij", "dateOfBirth": "8S73sQDN", "displayName": "y12G1PiT", "languageTag": "JwxV0rwM", "userName": "M7HsMJnU"}' > $TEMP_JSON_INPUT
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

#- 268 PublicUpdateUserEmailAddressV4
# body param: body
echo '{"code": "BZ6Gyhfc", "emailAddress": "rddeIOhx"}' > $TEMP_JSON_INPUT
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

#- 269 PublicUpgradeHeadlessAccountWithVerificationCodeV4
# body param: body
echo '{"code": "QMImB13f", "country": "1obTKrwF", "dateOfBirth": "XC2Op2yX", "displayName": "EIOAJh6X", "emailAddress": "NWtHWdmi", "password": "bqDeNic5", "username": "65hvy1VY"}' > $TEMP_JSON_INPUT
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

#- 270 PublicUpgradeHeadlessAccountV4
# body param: body
echo '{"emailAddress": "2365rUHk", "password": "xwwpNwFJ", "username": "yOBelglT"}' > $TEMP_JSON_INPUT
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