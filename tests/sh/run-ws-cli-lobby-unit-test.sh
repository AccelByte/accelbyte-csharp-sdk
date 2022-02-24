#!/bin/bash

#Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
#This is licensed software from AccelByte Inc, for limitations
#and restrictions contact your company contract manager.

#Meta:
#- random seed: 513
#- template file: cli-ws-test.j2

#Instructions:
#- Run the Justice SDK Mock Server first before running this script.

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"

if [ $# -eq 1 ]
    then
        CLI_EXE="$1/$CLI_EXE"
fi

TEMP_FILE="file.tmp"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
TEST_NAMESPACE="test"
SERVICE_NAME="lobby"

OPERATIONS_COUNT=0

FINISHED_COUNT=0
SUCCESS_COUNT=0
FAILED_COUNT=0

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_APP_NAME="UnitTest"
export AB_NAMESPACE=$TEST_NAMESPACE

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

printf "\n"

#- 1 AcceptFriendsNotif
# echo "Testing 'AcceptFriendsNotif'"
printf 'type: acceptFriendsNotif\nfriendId: bniNlQBL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'AcceptFriendsNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 2 AcceptFriendsRequest
# echo "Testing 'AcceptFriendsRequest'"
printf 'type: acceptFriendsRequest\nid: sX0SB8aJ\nfriendId: 3su9AalT' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'AcceptFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 3 AcceptFriendsResponse
# echo "Testing 'AcceptFriendsResponse'"
printf 'type: acceptFriendsResponse\nid: Gg95xZ12\ncode: 18' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'AcceptFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 4 BlockPlayerNotif
# echo "Testing 'BlockPlayerNotif'"
printf 'type: blockPlayerNotif\nblockedUserId: RTjldKeU\nuserId: o7empFLc' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'BlockPlayerNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 5 BlockPlayerRequest
# echo "Testing 'BlockPlayerRequest'"
printf 'type: blockPlayerRequest\nid: zPENpp8n\nblockUserId: IBTwiJ2j\nnamespace: yn1BbpzB' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'BlockPlayerRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 6 BlockPlayerResponse
# echo "Testing 'BlockPlayerResponse'"
printf 'type: blockPlayerResponse\nid: 6SOI0yI0\nblockUserId: g8g0GBZt\ncode: 52\nnamespace: RERdf2O0' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'BlockPlayerResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 7 CancelFriendsNotif
# echo "Testing 'CancelFriendsNotif'"
printf 'type: cancelFriendsNotif\nuserId: H0BGCsSE' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'CancelFriendsNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 8 CancelFriendsRequest
# echo "Testing 'CancelFriendsRequest'"
printf 'type: cancelFriendsRequest\nid: 2FwkuhGp\nfriendId: E15o5oHN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'CancelFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 9 CancelFriendsResponse
# echo "Testing 'CancelFriendsResponse'"
printf 'type: cancelFriendsResponse\nid: mwKucny6\ncode: 70' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'CancelFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 10 CancelMatchmakingRequest
# echo "Testing 'CancelMatchmakingRequest'"
printf 'type: cancelMatchmakingRequest\nid: Zsa8TOTC\ngameMode: 4w8uQfxP\nisTempParty: False' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'CancelMatchmakingRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 11 CancelMatchmakingResponse
# echo "Testing 'CancelMatchmakingResponse'"
printf 'type: cancelMatchmakingResponse\nid: vr1cjWei\ncode: 16' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'CancelMatchmakingResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 12 ChannelChatNotif
# echo "Testing 'ChannelChatNotif'"
printf 'type: channelChatNotif\nchannelSlug: 7hWOQNR1\nfrom: jybSRN0C\npayload: lE1oJe3B\nsentAt: PiiTJL2U' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ChannelChatNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 13 ClientResetRequest
# echo "Testing 'ClientResetRequest'"
printf 'type: clientResetRequest\nnamespace: SZm4KO2H\nuserId: Oi5bIlnl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ClientResetRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 14 ConnectNotif
# echo "Testing 'ConnectNotif'"
printf 'type: connectNotif\nlobbySessionId: gRBvtbFM' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ConnectNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 15 DisconnectNotif
# echo "Testing 'DisconnectNotif'"
printf 'type: disconnectNotif\nconnectionId: rO1CP4BU\nnamespace: zCUSqhaP' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'DisconnectNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 16 DsNotif
# echo "Testing 'DsNotif'"
printf 'type: dsNotif\nalternateIps: [fmggX7Db]\ncustomAttribute: W3FGjw4o\ndeployment: bp6E9fEl\ngameVersion: zxqm9EJV\nimageVersion: 036xHWRM\nip: TfSXhnEf\nisOK: False\nisOverrideGameVersion: False\nlastUpdate: KcSNJD8v\nmatchId: 52oRVIaL\nmessage: f60vZ42M\nnamespace: bFdwImMa\npodName: QbFvqg4m\nport: 66\nports: {"1mEnK6f3":39}\nprotocol: tCEmfK7O\nprovider: 6gPbVYQE\nregion: RicqUWIj\nsessionId: OewU7kff\nstatus: bL6yKErz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'DsNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 17 ErrorNotif
# echo "Testing 'ErrorNotif'"
printf 'type: errorNotif\nmessage: BlMmHKVJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ErrorNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 18 ExitAllChannel
# echo "Testing 'ExitAllChannel'"
printf 'type: exitAllChannel\nnamespace: LQmCxgja\nuserId: rPbgYLLa' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ExitAllChannel'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 19 FriendsStatusRequest
# echo "Testing 'FriendsStatusRequest'"
printf 'type: friendsStatusRequest\nid: s6X0cyrB' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'FriendsStatusRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 20 FriendsStatusResponse
# echo "Testing 'FriendsStatusResponse'"
printf 'type: friendsStatusResponse\nid: hx8RwRsW\nactivity: [wvK2Lv7p]\navailability: [42]\ncode: 91\nfriendIds: [xdnosdyy]\nlastSeenAt: [EkshiFHw]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'FriendsStatusResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 21 GetAllSessionAttributeRequest
# echo "Testing 'GetAllSessionAttributeRequest'"
printf 'type: getAllSessionAttributeRequest\nid: 7hLRCWzo' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllSessionAttributeRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 22 GetAllSessionAttributeResponse
# echo "Testing 'GetAllSessionAttributeResponse'"
printf 'type: getAllSessionAttributeResponse\nid: uzvgNcOW\nattributes: {"F5QQ4AVj":"JtZEIJ9Y"}\ncode: 16' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'GetAllSessionAttributeResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 23 GetFriendshipStatusRequest
# echo "Testing 'GetFriendshipStatusRequest'"
printf 'type: getFriendshipStatusRequest\nid: Ru04L0Ld\nfriendId: 48j5rh5E' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'GetFriendshipStatusRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 24 GetFriendshipStatusResponse
# echo "Testing 'GetFriendshipStatusResponse'"
printf 'type: getFriendshipStatusResponse\nid: J4nkije0\ncode: 77\nfriendshipStatus: XL4x9XOA' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'GetFriendshipStatusResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 25 GetSessionAttributeRequest
# echo "Testing 'GetSessionAttributeRequest'"
printf 'type: getSessionAttributeRequest\nid: 1m7RXjka\nkey: QN4P1GRz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'GetSessionAttributeRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 26 GetSessionAttributeResponse
# echo "Testing 'GetSessionAttributeResponse'"
printf 'type: getSessionAttributeResponse\nid: kNXTmKCZ\ncode: 39\nvalue: mcl7oD0o' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'GetSessionAttributeResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 27 Heartbeat
# echo "Testing 'Heartbeat'"
printf 'type: heartbeat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'Heartbeat'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 28 JoinDefaultChannelRequest
# echo "Testing 'JoinDefaultChannelRequest'"
printf 'type: joinDefaultChannelRequest\nid: S40cTbyx' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'JoinDefaultChannelRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 29 JoinDefaultChannelResponse
# echo "Testing 'JoinDefaultChannelResponse'"
printf 'type: joinDefaultChannelResponse\nid: VpGZi9m9\nchannelSlug: 7HAD95Uh\ncode: 77' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'JoinDefaultChannelResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 30 ListIncomingFriendsRequest
# echo "Testing 'ListIncomingFriendsRequest'"
printf 'type: listIncomingFriendsRequest\nid: goEKIYNw' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListIncomingFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 31 ListIncomingFriendsResponse
# echo "Testing 'ListIncomingFriendsResponse'"
printf 'type: listIncomingFriendsResponse\nid: uV7C4TTf\ncode: 83\nuserIds: [013QoeSF]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListIncomingFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 32 ListOfFriendsRequest
# echo "Testing 'ListOfFriendsRequest'"
printf 'type: listOfFriendsRequest\nid: tNJfUwdG\nfriendId: GCBhCwE0' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListOfFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 33 ListOfFriendsResponse
# echo "Testing 'ListOfFriendsResponse'"
printf 'type: listOfFriendsResponse\nid: V06zV1fR\ncode: 62\nfriendIds: [4Qoy8Itl]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListOfFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 34 ListOnlineFriendsRequest
# echo "Testing 'ListOnlineFriendsRequest'"
printf 'type: listOnlineFriendsRequest\nid: bul0P1BL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListOnlineFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 35 ListOutgoingFriendsRequest
# echo "Testing 'ListOutgoingFriendsRequest'"
printf 'type: listOutgoingFriendsRequest\nid: OCNDnjwH' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListOutgoingFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 36 ListOutgoingFriendsResponse
# echo "Testing 'ListOutgoingFriendsResponse'"
printf 'type: listOutgoingFriendsResponse\nid: KzsoYAmf\ncode: 64\nfriendIds: [9jaKxThK]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ListOutgoingFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 37 MatchmakingNotif
# echo "Testing 'MatchmakingNotif'"
printf 'type: matchmakingNotif\ncounterPartyMember: [0pshHr9M]\nmatchId: HXAlPLYP\nmessage: 3908S7my\npartyMember: [Tzb1oTjA]\nreadyDuration: 84\nstatus: IcdS1tV6' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'MatchmakingNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 38 MessageNotif
# echo "Testing 'MessageNotif'"
printf 'type: messageNotif\nid: sJeI0Xo3\nfrom: goMGyzaf\npayload: PRX0UoeP\nsentAt: 18\nto: pwPjPpmS\ntopic: Z4namb3u' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'MessageNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 39 OfflineNotificationRequest
# echo "Testing 'OfflineNotificationRequest'"
printf 'type: offlineNotificationRequest\nid: Y2AG4Aez' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'OfflineNotificationRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 40 OfflineNotificationResponse
# echo "Testing 'OfflineNotificationResponse'"
printf 'type: offlineNotificationResponse\nid: N3BhAgqG\ncode: 89' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'OfflineNotificationResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 41 OnlineFriends
# echo "Testing 'OnlineFriends'"
printf 'type: onlineFriends\nid: QNZHTghY\ncode: 82\nonlineFriendIds: [SOxqkJQL]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'OnlineFriends'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 42 PartyChatNotif
# echo "Testing 'PartyChatNotif'"
printf 'type: partyChatNotif\nid: Y0jJ178q\nfrom: kuMzHAtT\npayload: lm7T4aCr\nreceivedAt: 14\nto: 1iJ1jTLs' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyChatNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 43 PartyChatRequest
# echo "Testing 'PartyChatRequest'"
printf 'type: partyChatRequest\nid: LwwVpOLF\nfrom: 6XaAhGiN\npayload: ReRnPXes\nreceivedAt: 80\nto: FNqM3sN1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyChatRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 44 PartyChatResponse
# echo "Testing 'PartyChatResponse'"
printf 'type: partyChatResponse\nid: C8qt9vb1\ncode: 36' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyChatResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 45 PartyCreateRequest
# echo "Testing 'PartyCreateRequest'"
printf 'type: partyCreateRequest\nid: rZytNYNo' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyCreateRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 46 PartyCreateResponse
# echo "Testing 'PartyCreateResponse'"
printf 'type: partyCreateResponse\nid: rsjiVGvC\ncode: 58\ninvitationToken: FoR6a65T\ninvitees: y2GUizTS\nleaderId: m36gLoP2\nmembers: qlpPr69b\npartyId: 7TiOroA4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyCreateResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 47 PartyDataUpdateNotif
# echo "Testing 'PartyDataUpdateNotif'"
printf 'type: partyDataUpdateNotif\ncustomAttributes: {"9xFDfAIX":{}}\ninvitees: [EIyvLdBp]\nleader: QJGIufox\nmembers: [LFJaVtWq]\nnamespace: P5Us0uo5\npartyId: RWLsU98h\nupdatedAt: 95' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyDataUpdateNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 48 PartyGetInvitedNotif
# echo "Testing 'PartyGetInvitedNotif'"
printf 'type: partyGetInvitedNotif\nfrom: YPwYfOAs\ninvitationToken: 2RcoS5DI\npartyId: e4YInJW9' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyGetInvitedNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 49 PartyInfoRequest
# echo "Testing 'PartyInfoRequest'"
printf 'type: partyInfoRequest\nid: qXxXn2YQ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyInfoRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 50 PartyInfoResponse
# echo "Testing 'PartyInfoResponse'"
printf 'type: partyInfoResponse\nid: 9XLJZX4L\ncode: 69\ncustomAttributes: {"2ivU2fjW":{}}\ninvitationToken: mJshSupJ\ninvitees: PNHO71P1\nleaderId: vNtuKNp3\nmembers: EFCjrrV4\npartyId: ezSro4M5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyInfoResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 51 PartyInviteNotif
# echo "Testing 'PartyInviteNotif'"
printf 'type: partyInviteNotif\ninviteeId: fnYwGeZO\ninviterId: RgyC4Exm' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyInviteNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 52 PartyInviteRequest
# echo "Testing 'PartyInviteRequest'"
printf 'type: partyInviteRequest\nid: mJisc0oe\nfriendId: o5nFYmW1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyInviteRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 53 PartyInviteResponse
# echo "Testing 'PartyInviteResponse'"
printf 'type: partyInviteResponse\nid: d3CUZrMT\ncode: 20' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyInviteResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 54 PartyJoinNotif
# echo "Testing 'PartyJoinNotif'"
printf 'type: partyJoinNotif\nuserId: SAOi91Bl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyJoinNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 55 PartyJoinRequest
# echo "Testing 'PartyJoinRequest'"
printf 'type: partyJoinRequest\nid: QVmk599T\ninvitationToken: XGX3hyhO\npartyId: ICyEQ6gz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyJoinRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 56 PartyJoinResponse
# echo "Testing 'PartyJoinResponse'"
printf 'type: partyJoinResponse\nid: meVooeoT\ncode: 59\ninvitationToken: MbFZZbyR\ninvitees: 4arFNJ9h\nleaderId: p0Kdtnog\nmembers: FqweLiwg\npartyId: a6RMNd1n' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyJoinResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 57 PartyKickNotif
# echo "Testing 'PartyKickNotif'"
printf 'type: partyKickNotif\nleaderId: 160jKg4r\npartyId: q72AvDIg\nuserId: aVH3k7mx' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyKickNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 58 PartyKickRequest
# echo "Testing 'PartyKickRequest'"
printf 'type: partyKickRequest\nid: UioeyUhe\nmemberId: pkQHxl7p' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyKickRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 59 PartyKickResponse
# echo "Testing 'PartyKickResponse'"
printf 'type: partyKickResponse\nid: 98zMRCYM\ncode: 14' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyKickResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 60 PartyLeaveNotif
# echo "Testing 'PartyLeaveNotif'"
printf 'type: partyLeaveNotif\nleaderId: FCcSwvQO\nuserId: Hu46wxJX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyLeaveNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 61 PartyLeaveRequest
# echo "Testing 'PartyLeaveRequest'"
printf 'type: partyLeaveRequest\nid: X3V4yX2c\nignoreUserRegistry: True' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyLeaveRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 62 PartyLeaveResponse
# echo "Testing 'PartyLeaveResponse'"
printf 'type: partyLeaveResponse\nid: 9Ro0FgQk\ncode: 38' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyLeaveResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 63 PartyPromoteLeaderRequest
# echo "Testing 'PartyPromoteLeaderRequest'"
printf 'type: partyPromoteLeaderRequest\nid: mgRkzgdR\nnewLeaderUserId: 2caaMQbE' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyPromoteLeaderRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 64 PartyPromoteLeaderResponse
# echo "Testing 'PartyPromoteLeaderResponse'"
printf 'type: partyPromoteLeaderResponse\nid: OaJ4dgcq\ncode: 71\ninvitationToken: KCTagxgq\ninvitees: iqJCceuh\nleaderId: slqphFzA\nmembers: oV0XnUEE\npartyId: UUWJR6XR' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyPromoteLeaderResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 65 PartyRejectNotif
# echo "Testing 'PartyRejectNotif'"
printf 'type: partyRejectNotif\nleaderId: r9483TNS\npartyId: AsiGTOTR\nuserId: xnKPVC2c' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyRejectNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 66 PartyRejectRequest
# echo "Testing 'PartyRejectRequest'"
printf 'type: partyRejectRequest\nid: NzL3BSWw\ninvitationToken: a1FSMUDB\npartyId: Uny4GozJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyRejectRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 67 PartyRejectResponse
# echo "Testing 'PartyRejectResponse'"
printf 'type: partyRejectResponse\nid: loeCPQHI\ncode: 75\npartyId: Qex6qhd0' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PartyRejectResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 68 PersonalChatHistoryRequest
# echo "Testing 'PersonalChatHistoryRequest'"
printf 'type: personalChatHistoryRequest\nid: 7miR8d38\nfriendId: XvEFLF5I' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PersonalChatHistoryRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 69 PersonalChatHistoryResponse
# echo "Testing 'PersonalChatHistoryResponse'"
printf 'type: personalChatHistoryResponse\nid: 5JeufZQr\nchat: phmU0H4B\ncode: 11\nfriendId: SmSdPdyJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PersonalChatHistoryResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 70 PersonalChatNotif
# echo "Testing 'PersonalChatNotif'"
printf 'type: personalChatNotif\nid: GMtIF7Kc\nfrom: HNeE7Fct\npayload: dPzRQ78t\nreceivedAt: 89\nto: UkhiCDpO' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PersonalChatNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 71 PersonalChatRequest
# echo "Testing 'PersonalChatRequest'"
printf 'type: personalChatRequest\nid: iuLppqoB\nfrom: yT6M1h9B\npayload: BTExYD8n\nreceivedAt: 78\nto: rf7GNmvJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PersonalChatRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 72 PersonalChatResponse
# echo "Testing 'PersonalChatResponse'"
printf 'type: personalChatResponse\nid: QIXgSLc1\ncode: 61' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'PersonalChatResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 73 RejectFriendsNotif
# echo "Testing 'RejectFriendsNotif'"
printf 'type: rejectFriendsNotif\nuserId: f2hQheTj' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RejectFriendsNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 74 RejectFriendsRequest
# echo "Testing 'RejectFriendsRequest'"
printf 'type: rejectFriendsRequest\nid: WXb8syxx\nfriendId: EKAmoOw6' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RejectFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 75 RejectFriendsResponse
# echo "Testing 'RejectFriendsResponse'"
printf 'type: rejectFriendsResponse\nid: S5ZAwunn\ncode: 27' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RejectFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 76 RematchmakingNotif
# echo "Testing 'RematchmakingNotif'"
printf 'type: rematchmakingNotif\nbanDuration: 67' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RematchmakingNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 77 RequestFriendsNotif
# echo "Testing 'RequestFriendsNotif'"
printf 'type: requestFriendsNotif\nfriendId: TivcigpJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RequestFriendsNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 78 RequestFriendsRequest
# echo "Testing 'RequestFriendsRequest'"
printf 'type: requestFriendsRequest\nid: xdXBUmhy\nfriendId: AXRwzRcl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RequestFriendsRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 79 RequestFriendsResponse
# echo "Testing 'RequestFriendsResponse'"
printf 'type: requestFriendsResponse\nid: Aj5r20DL\ncode: 42' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'RequestFriendsResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 80 SendChannelChatRequest
# echo "Testing 'SendChannelChatRequest'"
printf 'type: sendChannelChatRequest\nid: 6pJ9IwQZ\nchannelSlug: R1LRUI1L\npayload: IzuVnDMq' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SendChannelChatRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 81 SendChannelChatResponse
# echo "Testing 'SendChannelChatResponse'"
printf 'type: sendChannelChatResponse\nid: BCuRWUwT\ncode: 12' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SendChannelChatResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 82 SetReadyConsentNotif
# echo "Testing 'SetReadyConsentNotif'"
printf 'type: setReadyConsentNotif\nmatchId: FhmPTcP3\nuserId: cFma1bJz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetReadyConsentNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 83 SetReadyConsentRequest
# echo "Testing 'SetReadyConsentRequest'"
printf 'type: setReadyConsentRequest\nid: fZv9ZFSq\nmatchId: LFSadLYh' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetReadyConsentRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 84 SetReadyConsentResponse
# echo "Testing 'SetReadyConsentResponse'"
printf 'type: setReadyConsentResponse\nid: VLvrM9qF\ncode: 97' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetReadyConsentResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 85 SetSessionAttributeRequest
# echo "Testing 'SetSessionAttributeRequest'"
printf 'type: setSessionAttributeRequest\nid: id41Iszi\nkey: kj0Menae\nnamespace: UeTXMjbB\nvalue: xNZORd7Q' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetSessionAttributeRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 86 SetSessionAttributeResponse
# echo "Testing 'SetSessionAttributeResponse'"
printf 'type: setSessionAttributeResponse\nid: xkbjRMVs\ncode: 94' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetSessionAttributeResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 87 SetUserStatusRequest
# echo "Testing 'SetUserStatusRequest'"
printf 'type: setUserStatusRequest\nid: LjQZ4LOU\nactivity: Wj7Xkprr\navailability: 67' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetUserStatusRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 88 SetUserStatusResponse
# echo "Testing 'SetUserStatusResponse'"
printf 'type: setUserStatusResponse\nid: hgwVGc2f\ncode: 96' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SetUserStatusResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 89 ShutdownNotif
# echo "Testing 'ShutdownNotif'"
printf 'type: shutdownNotif\nmessage: N3f3KJz4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'ShutdownNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 90 SignalingP2PNotif
# echo "Testing 'SignalingP2PNotif'"
printf 'type: signalingP2PNotif\ndestinationId: rLlah0Oc\nmessage: APTdDm9f' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SignalingP2PNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 91 StartMatchmakingRequest
# echo "Testing 'StartMatchmakingRequest'"
printf 'type: startMatchmakingRequest\nid: rrIP2zmI\nextraAttributes: fWOlCpDW\ngameMode: 7nkNF512\npartyAttributes: {"pRgZ0ShJ":{}}\npriority: 92\ntempParty: AouWpps1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'StartMatchmakingRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 92 StartMatchmakingResponse
# echo "Testing 'StartMatchmakingResponse'"
printf 'type: startMatchmakingResponse\nid: odxZAHpu\ncode: 79' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'StartMatchmakingResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 93 SystemComponentsStatus
# echo "Testing 'SystemComponentsStatus'"
printf 'type: systemComponentsStatus\ncomponents: {"4zWqvHvC":true}' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'SystemComponentsStatus'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 94 UnblockPlayerNotif
# echo "Testing 'UnblockPlayerNotif'"
printf 'type: unblockPlayerNotif\nunblockedUserId: C2pSXPsZ\nuserId: IdSz9twu' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UnblockPlayerNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 95 UnblockPlayerRequest
# echo "Testing 'UnblockPlayerRequest'"
printf 'type: unblockPlayerRequest\nid: ULoS88Yv\nnamespace: HYug7OZt\nunblockedUserId: 4DkQSLSg' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UnblockPlayerRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 96 UnblockPlayerResponse
# echo "Testing 'UnblockPlayerResponse'"
printf 'type: unblockPlayerResponse\nid: 0cM7GzHZ\ncode: 48\nnamespace: DwXUEvAE\nunblockedUserId: CvP162FP' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UnblockPlayerResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 97 UnfriendNotif
# echo "Testing 'UnfriendNotif'"
printf 'type: unfriendNotif\nfriendId: bfGkBHXv' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UnfriendNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 98 UnfriendRequest
# echo "Testing 'UnfriendRequest'"
printf 'type: unfriendRequest\nid: QcX81gIN\nfriendId: xZPQapPT' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UnfriendRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 99 UnfriendResponse
# echo "Testing 'UnfriendResponse'"
printf 'type: unfriendResponse\nid: HnwTZchO\ncode: 98' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UnfriendResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 100 UserBannedNotification
# echo "Testing 'UserBannedNotification'"
printf 'type: userBannedNotification' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UserBannedNotification'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 101 UserMetricRequest
# echo "Testing 'UserMetricRequest'"
printf 'type: userMetricRequest\nid: zcAnJ1M0' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UserMetricRequest'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 102 UserMetricResponse
# echo "Testing 'UserMetricResponse'"
printf 'type: userMetricResponse\nid: BqY2hows\ncode: 75\nplayerCount: 87' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UserMetricResponse'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

#- 103 UserStatusNotif
# echo "Testing 'UserStatusNotif'"
printf 'type: userStatusNotif\nactivity: qyyxgSqr\navailability: 27\nlastSeenAt: 9F8Lpcfn\nuserId: 4cJUpDxc' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    >$TEMP_FILE 2>&1
update_status $? 'UserStatusNotif'
# printf "\n\n"

rm -f $TEMP_FILE_UPLOAD
[ ! -e $TEMP_FILE ] || rm $TEMP_FILE

rm -f $CLI_TOKEN_FILE
exit $FAILED_COUNT