// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Lobby.WSModel;

namespace AccelByte.Sdk.Api.Lobby
{
    public class LobbyService : WebSocketService
    {
        public override string ServiceEndpoint => "/lobby";

        public LobbyService(AccelByteConfig abConfig)
            : base(abConfig)
        {
            
        }

        public LobbyService(string baseUrl)
            : base(baseUrl)
        {
            
        }

        [WebSocketEvent("connectNotif")]
        public Action<ConnectNotif>? OnConnectNotif { get; set; } = null;

        [WebSocketEvent("disconnectNotif")]
        public Action<DisconnectNotif>? OnDisconnectNotif { get; set; } = null;

        [WebSocketEvent("errorNotif")]
        public Action<ErrorNotif>? OnErrorNotif { get; set; } = null;

        [WebSocketEvent("shutdownNotif")]
        public Action<ShutdownNotif>? OnShutdownNotif { get; set; } = null;


        public async Task SendPartyInfoRequest(PartyInfoRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyInfoResponse")]
        public Action<PartyInfoResponse>? OnPartyInfoResponse { get; set; } = null;

        public async Task SendPartyCreateRequest(PartyCreateRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyCreateResponse")]
        public Action<PartyCreateResponse>? OnPartyCreateResponse { get; set; } = null;

        public async Task SendPartyLeaveRequest(PartyLeaveRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyLeaveResponse")]
        public Action<PartyLeaveResponse>? OnPartyLeaveResponse { get; set; } = null;

        [WebSocketEvent("partyLeaveNotif")]
        public Action<PartyLeaveNotif>? OnPartyLeaveNotif { get; set; } = null;

        public async Task SendPartyInviteRequest(PartyInviteRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyInviteResponse")]
        public Action<PartyInviteResponse>? OnPartyInviteResponse { get; set; } = null;

        [WebSocketEvent("partyInviteNotif")]
        public Action<PartyInviteNotif>? OnPartyInviteNotif { get; set; } = null;

        [WebSocketEvent("partyGetInvitedNotif")]
        public Action<PartyGetInvitedNotif>? OnPartyGetInvitedNotif { get; set; } = null;

        public async Task SendPartyJoinRequest(PartyJoinRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyJoinResponse")]
        public Action<PartyJoinResponse>? OnPartyJoinResponse { get; set; } = null;

        [WebSocketEvent("partyJoinNotif")]
        public Action<PartyJoinNotif>? OnPartyJoinNotif { get; set; } = null;

        public async Task SendPartyRejectRequest(PartyRejectRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyRejectResponse")]
        public Action<PartyRejectResponse>? OnPartyRejectResponse { get; set; } = null;

        [WebSocketEvent("partyRejectNotif")]
        public Action<PartyRejectNotif>? OnPartyRejectNotif { get; set; } = null;

        public async Task SendPartyKickRequest(PartyKickRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyKickResponse")]
        public Action<PartyKickResponse>? OnPartyKickResponse { get; set; } = null;

        [WebSocketEvent("partyKickNotif")]
        public Action<PartyKickNotif>? OnPartyKickNotif { get; set; } = null;

        public async Task SendPersonalChatRequest(PersonalChatRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("personalChatResponse")]
        public Action<PersonalChatResponse>? OnPersonalChatResponse { get; set; } = null;

        [WebSocketEvent("personalChatNotif")]
        public Action<PersonalChatNotif>? OnPersonalChatNotif { get; set; } = null;

        public async Task SendPartyChatRequest(PartyChatRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyChatResponse")]
        public Action<PartyChatResponse>? OnPartyChatResponse { get; set; } = null;

        [WebSocketEvent("partyChatNotif")]
        public Action<PartyChatNotif>? OnPartyChatNotif { get; set; } = null;

        public async Task SendPersonalChatHistoryRequest(PersonalChatHistoryRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("personalChatHistoryResponse")]
        public Action<PersonalChatHistoryResponse>? OnPersonalChatHistoryResponse { get; set; } = null;

        public async Task SendPartyPromoteLeaderRequest(PartyPromoteLeaderRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("partyPromoteLeaderResponse")]
        public Action<PartyPromoteLeaderResponse>? OnPartyPromoteLeaderResponse { get; set; } = null;

        [WebSocketEvent("partyDataUpdateNotif")]
        public Action<PartyDataUpdateNotif>? OnPartyDataUpdateNotif { get; set; } = null;

        public async Task SendFriendsStatusRequest(FriendsStatusRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("friendsStatusResponse")]
        public Action<FriendsStatusResponse>? OnFriendsStatusResponse { get; set; } = null;

        public async Task SendSetUserStatusRequest(SetUserStatusRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("setUserStatusResponse")]
        public Action<SetUserStatusResponse>? OnSetUserStatusResponse { get; set; } = null;

        [WebSocketEvent("userStatusNotif")]
        public Action<UserStatusNotif>? OnUserStatusNotif { get; set; } = null;

        public async Task SendListOnlineFriendsRequest(ListOnlineFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }


        public async Task SendClientResetRequest(ClientResetRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        public async Task SendOfflineNotificationRequest(OfflineNotificationRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("offlineNotificationResponse")]
        public Action<OfflineNotificationResponse>? OnOfflineNotificationResponse { get; set; } = null;

        [WebSocketEvent("messageNotif")]
        public Action<MessageNotif>? OnMessageNotif { get; set; } = null;

        public async Task SendStartMatchmakingRequest(StartMatchmakingRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("startMatchmakingResponse")]
        public Action<StartMatchmakingResponse>? OnStartMatchmakingResponse { get; set; } = null;

        public async Task SendCancelMatchmakingRequest(CancelMatchmakingRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("cancelMatchmakingResponse")]
        public Action<CancelMatchmakingResponse>? OnCancelMatchmakingResponse { get; set; } = null;

        [WebSocketEvent("matchmakingNotif")]
        public Action<MatchmakingNotif>? OnMatchmakingNotif { get; set; } = null;

        public async Task SendSetReadyConsentRequest(SetReadyConsentRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("setReadyConsentResponse")]
        public Action<SetReadyConsentResponse>? OnSetReadyConsentResponse { get; set; } = null;

        [WebSocketEvent("setReadyConsentNotif")]
        public Action<SetReadyConsentNotif>? OnSetReadyConsentNotif { get; set; } = null;

        [WebSocketEvent("rematchmakingNotif")]
        public Action<RematchmakingNotif>? OnRematchmakingNotif { get; set; } = null;

        public async Task SendRequestFriendsRequest(RequestFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("requestFriendsResponse")]
        public Action<RequestFriendsResponse>? OnRequestFriendsResponse { get; set; } = null;

        [WebSocketEvent("requestFriendsNotif")]
        public Action<RequestFriendsNotif>? OnRequestFriendsNotif { get; set; } = null;

        public async Task SendListIncomingFriendsRequest(ListIncomingFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("listIncomingFriendsResponse")]
        public Action<ListIncomingFriendsResponse>? OnListIncomingFriendsResponse { get; set; } = null;

        public async Task SendListOutgoingFriendsRequest(ListOutgoingFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("listOutgoingFriendsResponse")]
        public Action<ListOutgoingFriendsResponse>? OnListOutgoingFriendsResponse { get; set; } = null;

        public async Task SendAcceptFriendsRequest(AcceptFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("acceptFriendsResponse")]
        public Action<AcceptFriendsResponse>? OnAcceptFriendsResponse { get; set; } = null;

        [WebSocketEvent("acceptFriendsNotif")]
        public Action<AcceptFriendsNotif>? OnAcceptFriendsNotif { get; set; } = null;

        public async Task SendRejectFriendsRequest(RejectFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("rejectFriendsResponse")]
        public Action<RejectFriendsResponse>? OnRejectFriendsResponse { get; set; } = null;

        [WebSocketEvent("rejectFriendsNotif")]
        public Action<RejectFriendsNotif>? OnRejectFriendsNotif { get; set; } = null;

        public async Task SendCancelFriendsRequest(CancelFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("cancelFriendsResponse")]
        public Action<CancelFriendsResponse>? OnCancelFriendsResponse { get; set; } = null;

        [WebSocketEvent("cancelFriendsNotif")]
        public Action<CancelFriendsNotif>? OnCancelFriendsNotif { get; set; } = null;

        public async Task SendUnfriendRequest(UnfriendRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("unfriendResponse")]
        public Action<UnfriendResponse>? OnUnfriendResponse { get; set; } = null;

        [WebSocketEvent("unfriendNotif")]
        public Action<UnfriendNotif>? OnUnfriendNotif { get; set; } = null;

        public async Task SendListOfFriendsRequest(ListOfFriendsRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("listOfFriendsResponse")]
        public Action<ListOfFriendsResponse>? OnListOfFriendsResponse { get; set; } = null;

        public async Task SendGetFriendshipStatusRequest(GetFriendshipStatusRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("getFriendshipStatusResponse")]
        public Action<GetFriendshipStatusResponse>? OnGetFriendshipStatusResponse { get; set; } = null;

        public async Task SendBlockPlayerRequest(BlockPlayerRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("blockPlayerResponse")]
        public Action<BlockPlayerResponse>? OnBlockPlayerResponse { get; set; } = null;

        [WebSocketEvent("blockPlayerNotif")]
        public Action<BlockPlayerNotif>? OnBlockPlayerNotif { get; set; } = null;

        public async Task SendUnblockPlayerRequest(UnblockPlayerRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("unblockPlayerResponse")]
        public Action<UnblockPlayerResponse>? OnUnblockPlayerResponse { get; set; } = null;

        [WebSocketEvent("unblockPlayerNotif")]
        public Action<UnblockPlayerNotif>? OnUnblockPlayerNotif { get; set; } = null;

        [WebSocketEvent("dsNotif")]
        public Action<DsNotif>? OnDsNotif { get; set; } = null;


        public async Task SendJoinDefaultChannelRequest(JoinDefaultChannelRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("joinDefaultChannelResponse")]
        public Action<JoinDefaultChannelResponse>? OnJoinDefaultChannelResponse { get; set; } = null;



        public async Task SendSendChannelChatRequest(SendChannelChatRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("sendChannelChatResponse")]
        public Action<SendChannelChatResponse>? OnSendChannelChatResponse { get; set; } = null;

        [WebSocketEvent("channelChatNotif")]
        public Action<ChannelChatNotif>? OnChannelChatNotif { get; set; } = null;

        public async Task SendGetSessionAttributeRequest(GetSessionAttributeRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("getSessionAttributeResponse")]
        public Action<GetSessionAttributeResponse>? OnGetSessionAttributeResponse { get; set; } = null;

        public async Task SendGetAllSessionAttributeRequest(GetAllSessionAttributeRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("getAllSessionAttributeResponse")]
        public Action<GetAllSessionAttributeResponse>? OnGetAllSessionAttributeResponse { get; set; } = null;

        public async Task SendSetSessionAttributeRequest(SetSessionAttributeRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("setSessionAttributeResponse")]
        public Action<SetSessionAttributeResponse>? OnSetSessionAttributeResponse { get; set; } = null;

        [WebSocketEvent("signalingP2PNotif")]
        public Action<SignalingP2PNotif>? OnSignalingP2PNotif { get; set; } = null;

        public async Task SendUserMetricRequest(UserMetricRequest payload, int errorCode)
        {
            await Send(payload, errorCode);
        }

        [WebSocketEvent("userMetricResponse")]
        public Action<UserMetricResponse>? OnUserMetricResponse { get; set; } = null;

    }
}