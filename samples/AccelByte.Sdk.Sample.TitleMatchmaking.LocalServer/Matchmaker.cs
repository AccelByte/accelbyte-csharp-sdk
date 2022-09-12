// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class Matchmaker
    {
        private AccelByteSDK _Sdk;

        private ICacheProvider _Cache;

        private string _GameMode;

        public string ChannelListKey { get; set; } = "matchmaking:channelList";

        public string MatchmakingRequestQueue { get; set; } = "matchmaking:requestQueue";

        public string MatchmakingNotificationTopic { get; set; } = "NOTIF";

        public string MapName { get; set; } = "CSharp_TM_Map";

        public string SessionMode { get; set; } = "CSharp_TM_GameMode";

        public string SessionPassword { get; set; } = "";

        public string GameVersion { get; set; } = "1.0";

        public string ClientVersion { get; set; } = "1.0";

        public string SessionType { get; set; } = "p2p";

        public string TargetDeployment { get; set; } = "default";

        /// <summary>
        /// Max duration for waiting other users (in milliseconds)
        /// </summary>
        public int WaitMaxDuration { get; set; } = 50000;

        /// <summary>
        /// Other user check interval (in milliseconds)
        /// </summary>
        public int UserCheckInterval { get; set; } = 1000;

        public string ChannelSlug
        {
            get
            {
                return String.Format("{0}:{1}", _Sdk.Namespace, _GameMode);
            }
        }

        public string MatchmakingRequestKey
        {
            get
            {
                return String.Format("{0}:{1}:{2}", MatchmakingRequestQueue, _Sdk.Namespace, _GameMode);
            }
        }

        protected List<PartyData> GetPartyMembers()
        {
            List<PartyData> partyMembers = new List<PartyData>();
            List<string>? rawItems = _Cache.GetItems(MatchmakingRequestKey);
            if (rawItems != null)
            {
                foreach (string rawItem in rawItems)
                {
                    List<PartyData>? partyData = JsonSerializer.Deserialize<List<PartyData>>(rawItem);
                    if (partyData != null)
                        partyMembers.AddRange(partyData);
                }
            }
            return partyMembers;
        }

        protected List<PartyData>? WaitAndGetOtherPartyMembers(string cUserId, bool waitUntilMaxDuration = false)
        {
            int elapsedTime = 0;
            List<PartyData> otherMembers = new List<PartyData>();

            while (elapsedTime < WaitMaxDuration)
            {
                List<PartyData> partyMembers = GetPartyMembers();

                otherMembers.Clear();
                foreach (PartyData member in partyMembers)
                {
                    if (member.UserId != cUserId)
                        otherMembers.Add(member);
                }

                if (otherMembers.Count > 0)
                {
                    if (!waitUntilMaxDuration)
                        return otherMembers;
                }

                Thread.Sleep(UserCheckInterval);
                elapsedTime += UserCheckInterval;
            }

            if (otherMembers.Count > 0)
                return otherMembers;

            return null;
        }

        public Matchmaker(AccelByteSDK sdk, ICacheProvider cache, string gameMode)
        {
            _Sdk = sdk;
            _Cache = cache;
            _GameMode = gameMode;
        }

        public string GetMatchmakingStatus()
        {
            if (_Cache.IsExists(ChannelListKey) && _Cache.IsExists(MatchmakingRequestKey))
            {
                string? channelSlug = _Cache.Load(ChannelListKey);
                if (channelSlug == null)
                    throw new Exception("No active channel");

                return JsonSerializer.Serialize(new MatchmakingStatus()
                {
                    IsActiveMatchmakingAvailable = true,
                    ChannelSlug = channelSlug,
                    Members = GetPartyMembers()
                });
            }
            else
            {
                return JsonSerializer.Serialize(new MatchmakingStatus()
                {
                    IsActiveMatchmakingAvailable = false
                });
            }
        }

        public MatchmakingResult CreateMatchmakingRequest(string authToken)
        {
            // # 1. Validate Access Token
            OauthmodelTokenResponseV3? oauthToken = _Sdk.Iam.OAuth20.VerifyTokenV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute(authToken);
            if (oauthToken == null)
                throw new Exception("NULL oauthToken");
            string cUserId = oauthToken.UserId!;

            // # 2. Create matchmaking request
            ModelsChannel channel = new ModelsChannel()
            {
                Deployment = "",
                Description = "CSharp Server SDK TitleMatchmaking Sample",
                FindMatchTimeoutSeconds = 3600,
                GameMode = _GameMode,
                Joinable = false,
                MaxDelayMs = 0,
                Namespace = _Sdk.Namespace,
                Ruleset = new ModelsRuleSet()
                {
                    Alliance = new ModelsAllianceRule()
                    {
                        MaxNumber = 2,
                        MinNumber = 2,
                        PlayerMaxNumber = 1,
                        PlayerMinNumber = 1
                    },
                    AllianceFlexingRule = new List<ModelsAllianceFlexingRule>(),
                    FlexingRule = new List<ModelsFlexingRule>(),
                    MatchOptions = new ModelsMatchOptionRule()
                    {
                        Options = new List<ModelsMatchOption>()
                    },
                    MatchingRule = new List<ModelsMatchingRule>(),
                    SubGameModes = new Dictionary<string, ModelsSubGameMode>()
                },
                SessionQueueTimeoutSeconds = 0,
                Slug = ChannelSlug,
                SocialMatchmaking = false,
                UpdatedAt = "",
                UseSubGamemode = false
            };

            _Cache.Save(ChannelListKey, channel.Slug);

            List<PartyData> partyData = new List<PartyData>()
            {
                new PartyData()
                {
                    Channel = channel.Slug,
                    PartyId = Guid.NewGuid().ToString().Replace("-", ""),
                    PartyMembers = new List<ModelsPartyMember>()
                    {
                        new ModelsPartyMember()
                        {
                            UserId = cUserId
                        }
                    },
                    UserId = cUserId
                }
            };

            // # 3. Check for existing matchmaking request. Mark if it does not exists.
            bool isMatchmakingRequestExists = _Cache.IsExists(MatchmakingRequestKey);

            string jPartyList = JsonSerializer.Serialize(partyData);
            _Cache.PushItem(MatchmakingRequestKey, jPartyList);

            // # 4. Send search for match notification to user
            ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
            {
                Topic = MatchmakingNotificationTopic,
                Message = "searching"
            };

            _Sdk.Lobby.Notification.FreeFormNotificationByUserIDOp
                .Execute(notifBody, _Sdk.Namespace, cUserId);

            // # 5. If existing matchmaing request does not exists, then skip further process.
            if (!isMatchmakingRequestExists)
            {
                return new MatchmakingResult()
                {
                    IsFirstMember = true
                };
            }

            // # 6. Wait for another user. (2nd parameter is set to false to allow only 2 players)
            List<PartyData>? otherMembers = WaitAndGetOtherPartyMembers(cUserId, false);
            if (otherMembers == null)
                throw new Exception("Timed out! Not enough players.");

            string partyId = otherMembers[0].PartyId;

            List<string> pmUserIds = new List<string>();
            pmUserIds.Add(cUserId);
            foreach (var party in otherMembers)
                pmUserIds.Add(party.UserId);

            // # 7. Return MatchmakingResult object
            return new MatchmakingResult()
            {
                IsFirstMember = false,
                PartyId = partyId,
                Users = pmUserIds
            };
        }

        public MatchmakingResult CreateSessionAndClaimServer(MatchmakingResult mResult)
        {
            if (mResult.Users.Count <= 0)
                throw new Exception("No Player!");

            // # 1. Get username from IAM
            ModelPublicUserResponseV3? userInfo =
                _Sdk.Iam.Users.PublicGetUserByUserIdV3Op
                .Execute(_Sdk.Namespace, mResult.Users[0]);
            if (userInfo == null)
                throw new Exception("NULL userInfo");
            string _UsernameForSB = userInfo.UserName!;

            // # 2. Create session
            Api.Sessionbrowser.Model.ModelsCreateSessionRequest createSessionBody = new Api.Sessionbrowser.Model.ModelsCreateSessionRequest()
            {
                SessionType = SessionType,
                GameVersion = GameVersion,
                Namespace = _Sdk.Namespace,
                Username = _UsernameForSB,
                GameSessionSetting = new Api.Sessionbrowser.Model.ModelsGameSessionSetting()
                {
                    AllowJoinInProgress = true,
                    CurrentInternalPlayer = 0,
                    CurrentPlayer = 0,
                    MapName = MapName,
                    MaxInternalPlayer = 2,
                    MaxPlayer = 0,
                    Mode = SessionMode,
                    NumBot = 0,
                    Password = SessionPassword
                }
            };

            Api.Sessionbrowser.Model.ModelsSessionResponse? crSession =
                _Sdk.Sessionbrowser.Session.CreateSessionOp
                    .Execute(createSessionBody, _Sdk.Namespace);
            if (crSession == null)
                throw new Exception("Could not create session in AB Cloud.");

            // # 3. Register session on DSMC
            List<Api.Dsmc.Model.ModelsRequestMatchMember> srPartyMembers = new List<Api.Dsmc.Model.ModelsRequestMatchMember>();
            foreach (string pmUserId in mResult.Users)
                srPartyMembers.Add(new Api.Dsmc.Model.ModelsRequestMatchMember()
                {
                    UserId = pmUserId,
                });

            Api.Dsmc.Model.ModelsCreateSessionRequest sessionRequest = new Api.Dsmc.Model.ModelsCreateSessionRequest()
            {
                ClientVersion = ClientVersion,
                Configuration = "",
                Deployment = TargetDeployment,
                GameMode = _GameMode,
                MatchingAllies = new List<Api.Dsmc.Model.ModelsRequestMatchingAlly>()
                {
                    new Api.Dsmc.Model.ModelsRequestMatchingAlly()
                    {
                        MatchingParties = new List<Api.Dsmc.Model.ModelsRequestMatchParty>()
                        {
                            new Api.Dsmc.Model.ModelsRequestMatchParty()
                            {
                                PartyAttributes = new Dictionary<string, object>(),
                                PartyId = mResult.PartyId,
                                PartyMembers = srPartyMembers
                            }
                        }
                    }
                },
                Region = "",
                PodName = "",
                SessionId = crSession.SessionId,
                Namespace = _Sdk.Namespace,
            };

            Api.Dsmc.Model.ModelsSessionResponse? regSession =
                _Sdk.Dsmc.Session.CreateSessionOp
                    .Execute(sessionRequest, _Sdk.Namespace);
            if (regSession == null)
                throw new Exception("Could not register session in DSMC.");

            // # 4 Wait for DSMC to register the session
            Thread.Sleep(5000);

            // # 5. Claim server
            Api.Dsmc.Model.ModelsClaimSessionRequest? claimRequest = new Api.Dsmc.Model.ModelsClaimSessionRequest()
            {
                SessionId = crSession.SessionId
            };
            _Sdk.Dsmc.Session.ClaimServerOp.Execute(claimRequest, _Sdk.Namespace);

            // # 6. Get server from DSMC
            Api.Dsmc.Model.ModelsSessionResponse? claimedSession =
                _Sdk.Dsmc.Session.GetSessionOp
                .Execute(_Sdk.Namespace, crSession.SessionId!);
            if (claimedSession == null)
                throw new Exception("Claimed session does not exists.");

            Api.Dsmc.Model.ModelsServer server = claimedSession.Session!.Server!;
            string serverIp = server.Ip!;
            int serverPort = server.Port!.Value;

            // # 7. Add players to server in Session Browser
            foreach (string pmUserId in mResult.Users)
            {
                Api.Sessionbrowser.Model.ModelsAddPlayerRequest apReq = new Api.Sessionbrowser.Model.ModelsAddPlayerRequest()
                {
                    AsSpectator = false,
                    UserId = pmUserId
                };

                _Sdk.Sessionbrowser.Session.AddPlayerToSessionOp
                    .Execute(apReq, _Sdk.Namespace, crSession.SessionId!);
            }

            // # 8. Get session update from Session Browser
            Api.Sessionbrowser.Model.ModelsSessionResponse? uSession =
                _Sdk.Sessionbrowser.Session.GetSessionOp
                    .Execute(_Sdk.Namespace, crSession.SessionId!);
            if (uSession == null)
                throw new Exception("Could not get update from session browser.");

            // # 9. Check if session is joinable
            if (!uSession.Joinable!.Value)
                throw new Exception("Unable to join the session.");

            // # 10. Send notification to all users
            foreach (string pmUserId in mResult.Users)
            {
                _Sdk.Lobby.Notification.FreeFormNotificationByUserIDOp
                    .Execute(new ModelFreeFormNotificationRequest()
                    {
                        Topic = MatchmakingNotificationTopic,
                        Message = String.Format("found {0}:{1}", serverIp, serverPort)
                    }, _Sdk.Namespace, pmUserId);
            }

            // # 11. Return updated MatchmakingResult object
            mResult.ServerIp = serverIp;
            mResult.ServerPort = serverPort;
            mResult.SessionId = crSession.SessionId!;
            return mResult;
        }
    }
}