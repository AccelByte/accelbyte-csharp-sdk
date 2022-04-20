// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Core
{
    public class LobbySdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Friends Friends
        {
            get
            {
                if (_Friends == null)
                    _Friends = new Friends(_SdkObject);
                return _Friends;
            }
        }
        private Friends? _Friends = null;

        public Chat Chat
        {
            get
            {
                if (_Chat == null)
                    _Chat = new Chat(_SdkObject);
                return _Chat;
            }
        }
        private Chat? _Chat = null;

        public Config Config
        {
            get
            {
                if (_Config == null)
                    _Config = new Config(_SdkObject);
                return _Config;
            }
        }
        private Config? _Config = null;

        public Notification Notification
        {
            get
            {
                if (_Notification == null)
                    _Notification = new Notification(_SdkObject);
                return _Notification;
            }
        }
        private Notification? _Notification = null;

        public Party Party
        {
            get
            {
                if (_Party == null)
                    _Party = new Party(_SdkObject);
                return _Party;
            }
        }
        private Party? _Party = null;

        public LobbyOperations LobbyOperations
        {
            get
            {
                if (_LobbyOperations == null)
                    _LobbyOperations = new LobbyOperations(_SdkObject);
                return _LobbyOperations;
            }
        }
        private LobbyOperations? _LobbyOperations = null;

        public Player Player
        {
            get
            {
                if (_Player == null)
                    _Player = new Player(_SdkObject);
                return _Player;
            }
        }
        private Player? _Player = null;

        public Profanity Profanity
        {
            get
            {
                if (_Profanity == null)
                    _Profanity = new Profanity(_SdkObject);
                return _Profanity;
            }
        }
        private Profanity? _Profanity = null;

        public ThirdParty ThirdParty
        {
            get
            {
                if (_ThirdParty == null)
                    _ThirdParty = new ThirdParty(_SdkObject);
                return _ThirdParty;
            }
        }
        private ThirdParty? _ThirdParty = null;

        public Presence Presence
        {
            get
            {
                if (_Presence == null)
                    _Presence = new Presence(_SdkObject);
                return _Presence;
            }
        }
        private Presence? _Presence = null;

        internal LobbySdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public LobbySdkWrappers Lobby
        {
            get
            {
                if (_Lobby == null)
                    _Lobby = new LobbySdkWrappers(this);
                return _Lobby;
            }
        }
        private LobbySdkWrappers? _Lobby = null;
    }
}