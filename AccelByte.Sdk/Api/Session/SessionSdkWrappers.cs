// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Core
{
    public class SessionSdkWrappers
    {
        private AccelByteSDK _SdkObject;

        public Operations Operations
        {
            get
            {
                if (_Operations == null)
                    _Operations = new Operations(_SdkObject);
                return _Operations;
            }
        }
        private Operations? _Operations = null;

        public DSMCDefaultConfiguration DSMCDefaultConfiguration
        {
            get
            {
                if (_DSMCDefaultConfiguration == null)
                    _DSMCDefaultConfiguration = new DSMCDefaultConfiguration(_SdkObject);
                return _DSMCDefaultConfiguration;
            }
        }
        private DSMCDefaultConfiguration? _DSMCDefaultConfiguration = null;

        public ConfigurationTemplate ConfigurationTemplate
        {
            get
            {
                if (_ConfigurationTemplate == null)
                    _ConfigurationTemplate = new ConfigurationTemplate(_SdkObject);
                return _ConfigurationTemplate;
            }
        }
        private ConfigurationTemplate? _ConfigurationTemplate = null;

        public GameSession GameSession
        {
            get
            {
                if (_GameSession == null)
                    _GameSession = new GameSession(_SdkObject);
                return _GameSession;
            }
        }
        private GameSession? _GameSession = null;

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

        internal SessionSdkWrappers(AccelByteSDK sdk)
        {
            _SdkObject = sdk;
        }
    }

    public partial class AccelByteSDK
    {
        public SessionSdkWrappers Session
        {
            get
            {
                if (_Session == null)
                    _Session = new SessionSdkWrappers(this);
                return _Session;
            }
        }
        private SessionSdkWrappers? _Session = null;
    }
}