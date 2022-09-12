// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Sample.TicTacToe.Provider;

namespace AccelByte.Sdk.Sample.TicTacToe.Server.Util
{
    public class CommandArguments : IServerCommandArguments
    {
        public Dictionary<string, string> Parameters { get { return _Parameters; } }
        private Dictionary<string, string> _Parameters;

        public string SdkConfigFile { get; private set; } = String.Empty;

        public int ListenPort { get; private set; } = 9090;

        public bool IsHelpAsked { get; private set; } = false;

        public bool IsLogEnabled { get; private set; } = false;

        public CommandArguments(string[] args)
        {
            _Parameters = new Dictionary<string, string>();

            if (args.Length > 0)
            {
                int cIndex = 0;
                while (true)
                {
                    if (cIndex >= args.Length)
                        break;

                    string part = args[cIndex];
                    if (part.Length <= 2)
                        throw new Exception("Invalid command argument(s).");

                    if (part.Substring(0, Math.Min(2, part.Length)) == "--")
                    {
                        string aKey = part.Substring(2).Trim();
                        string aValue = String.Empty;
                        if (args.Length > (cIndex + 1))
                        {
                            aValue = args[cIndex + 1].Trim();
                            if (aValue.Substring(0, Math.Min(2, aValue.Length)) == "--")
                            {
                                aValue = String.Empty;
                                cIndex += 1;
                            }
                            else
                                cIndex += 2;
                        }
                        else
                        {
                            cIndex += 1;
                        }

                        if (aValue != String.Empty)
                        {
                            if (aValue.Length > 2)
                            {
                                if ((aValue.Substring(0, 1) == "'") && (aValue.Substring(aValue.Length - 1, 1) == "'"))
                                    aValue = aValue.Substring(1, aValue.Length - 2);
                            }
                        }

                        if (aKey == "sdk-config")
                        {
                            if (aValue == String.Empty)
                                throw new Exception("SDK config file is specified but has empty value.");
                            SdkConfigFile = aValue;
                        }
                        else if (aKey == "port")
                        {
                            if (aValue == String.Empty)
                                throw new Exception("Listen port is specified but has empty value.");
                            ListenPort = int.Parse(aValue);
                        }
                        else if (aKey == "help")
                        {
                            IsHelpAsked = true;
                        }
                        else if (aKey == "enable-log")
                        {
                            IsLogEnabled = true;
                        }
                        else
                            _Parameters.Add(aKey, aValue);
                    }
                    else
                        throw new Exception("Invalid command argument(s).");
                }
            }
        }

        public void EchoUsage()
        {
            Console.WriteLine("usage: AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer.exe [options]");
            string opts =
                "\t--help\tShow this help\n"
                + "\t--sdk-config\t(optional) Specify AccelByte SDK configuration JSON file\n"
                + "\t--port\t(optional) Specify server listen port. Default is 9090\n"
                + "\t--enable-log\tEnable HTTP logging\n"
                + "";
            Console.WriteLine(opts);
        }
    }
}