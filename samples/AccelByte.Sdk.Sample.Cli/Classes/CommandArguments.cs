// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Sample.Cli
{
    public class CommandArguments
    {
        public static readonly string LoginTypeUser = "user";

        public static readonly string LoginTypeClient = "client";

        public Dictionary<string, string> Parameters { get { return _Parameters; } }
        private Dictionary<string, string> _Parameters;

        public string RequestFileContent { get { return _RequestFileContent; } }
        private string _RequestFileContent = String.Empty;

        public string LoginType { get; private set; } = LoginTypeUser;

        public string LoginUsername { get; private set; } = String.Empty;

        public string LoginPassword { get; private set; } = String.Empty;

        public string ServiceName { get; private set; } = String.Empty;

        public string OperationName { get; private set; } = String.Empty;

        public Dictionary<string, Stream> FileUploads { get; private set; } = new();

        public bool IsHelpAsked { get; private set; } = false;

        public bool IsListAsked { get; private set; } = false;

        public bool IsListAllAsked { get; private set; } = false;

        public bool IsWebSocket { get; private set; } = false;

        public bool IsWebSocketListenMode { get; private set; } = false;

        public string WebSocketPayload { get; private set; } = String.Empty;

        public bool IsLogEnabled { get; private set; } = false;

        public bool IsInteractive { get; private set; } = false;

        public bool IsRetryOnWSMessageError { get; private set; } = false;

        protected bool HasDoubleHyphen(string text)
        {
            return (text.Substring(0, Math.Min(2, text.Length)) == "--");
        }

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
                        throw new CommandArgumentException();

                    if (HasDoubleHyphen(part))
                    {
                        string aKey = part.Substring(2).Trim();
                        string aValue = String.Empty;
                        string aMoreValue = String.Empty;

                        if (args.Length > (cIndex + 1))
                        {
                            aValue = args[cIndex + 1].Trim();
                            if (HasDoubleHyphen(aValue))
                            {
                                aValue = String.Empty;
                                cIndex += 1;
                            }
                            else
                            {
                                cIndex += 2;
                                if (args.Length > cIndex)
                                {
                                    aMoreValue = args[cIndex].Trim();
                                    if (!HasDoubleHyphen(aMoreValue))
                                        cIndex += 1;
                                    else
                                        aMoreValue = String.Empty;
                                }
                            }
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

                        if (aKey == "reqfile")
                        {
                            //load request body content file (JSON)
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("Request body content file is specified but has empty value.");
                            if (!File.Exists(aValue))
                                throw new CommandArgumentException("Specified request body content file does not exists.");
                            string aContent = File.ReadAllText(aValue);
                            if (aContent.Length <= 0)
                                throw new CommandArgumentException("Specified request body content file is empty.");
                            _RequestFileContent = aContent;
                        }
                        else if (aKey == "reqbody")
                        {
                            //set JSON-formatted request body directly in cli parameter.
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("Request body content is specified but has empty value.");
                            _RequestFileContent = aValue;
                        }
                        else if (aKey == "upload")
                        {
                            //set file to be uploaded.
                            if (aMoreValue != "")
                            {
                                if (!File.Exists(aMoreValue))
                                    throw new CommandArgumentException("Specified file for upload does not exists.");

                                FileUploadStream fuStream = new FileUploadStream(aMoreValue, FileMode.Open, FileAccess.Read);
                                MimeTypes mt = new MimeTypes();
                                fuStream.MimeType = mt.ConvertFromFilename(aMoreValue, "application/octet-stream");
                                FileUploads.Add(aValue, fuStream);
                            }
                            else
                            {
                                if (aValue == String.Empty)
                                    throw new CommandArgumentException("File upload is specified but has empty value.");
                                if (!File.Exists(aValue))
                                    throw new CommandArgumentException("Specified file for upload does not exists.");

                                FileUploadStream fuStream = new FileUploadStream(aValue, FileMode.Open, FileAccess.Read);
                                MimeTypes mt = new MimeTypes();
                                fuStream.MimeType = mt.ConvertFromFilename(aValue, "application/octet-stream");
                                if (FileUploads.ContainsKey("___"))
                                    FileUploads["___"] = fuStream;
                                else
                                    FileUploads.Add("___", fuStream);
                            }
                        }
                        else if (aKey == "lt")
                        {
                            //set login type (user or client)
                            aValue = aValue.ToLower();
                            if ((aValue == LoginTypeClient) || (aValue == LoginTypeUser))
                                LoginType = aValue;
                            else
                                throw new CommandArgumentException("Login type is specified but has invalid value.");
                        }
                        else if (aKey == "sn")
                        {
                            //set service name
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("Service name is specified but has invalid value.");
                            ServiceName = aValue.ToLower();
                        }
                        else if (aKey == "op")
                        {
                            //set operation name
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("Operation name is specified but has invalid value.");
                            OperationName = aValue.ToLower();
                        }
                        else if (aKey == "user")
                        {
                            //set login username
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("Login username is specified but has empty value.");
                            LoginUsername = aValue;
                        }
                        else if (aKey == "pass")
                        {
                            //set login password
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("Login password is specified but has empty value.");
                            LoginPassword = aValue;
                        }
                        else if (aKey == "help")
                        {
                            IsHelpAsked = true;
                        }
                        else if (aKey == "list-ops")
                        {
                            IsListAsked = true;
                        }
                        else if (aKey == "list-all")
                        {
                            IsListAllAsked = true;
                        }
                        else if (aKey == "ws")
                        {
                            IsWebSocket = true;
                        }
                        else if (aKey == "ws-payload")
                        {
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("WebSocket payload is specified but has empty value.");
                            WebSocketPayload = aValue.Replace("\\n", "\n");
                        }
                        else if (aKey == "ws-payload-file")
                        {
                            if (aValue == String.Empty)
                                throw new CommandArgumentException("WebSocket payload file is specified but has empty value.");
                            if (!File.Exists(aValue))
                                throw new CommandArgumentException("WebSocket payload file does not exists.");
                            WebSocketPayload = File.ReadAllText(aValue);
                        }
                        else if (aKey == "ws-listen")
                        {
                            IsWebSocketListenMode = true;
                        }
                        else if (aKey == "interactive")
                        {
                            IsInteractive = true;
                        }
                        else if (aKey == "enable-log")
                        {
                            IsLogEnabled = true;
                        }
                        else if (aKey == "retry-on-ws-message-error")
                        {
                            IsRetryOnWSMessageError = true;
                        }
                        else
                            _Parameters.Add(aKey, aValue);
                    }
                    else
                        throw new CommandArgumentException();
                }
            }
        }

        public void EchoUsage()
        {
            Console.WriteLine("usage: AccelByte.Sdk.Sample.CLI.exe [options]");
            string opts =
                "\t--help\tShow this help\n"
                + "\t--list-ops\tList all available services or operations if '--sn' option is specified\n"
                + "\t--list-all\tList all operations within all services\n"
                + "\t--sn\tSpecify API service name\n"
                + "\t--op\tSpecify which operation to execute\n"
                + "\t--lt\tSpecify login type, default to 'user'\n"
                + "\t--user\tSpecify username for login operation\n"
                + "\t--pass\tSpecify password for login operation\n"
                + "\t--reqfile\tSpecify json file to be used as request body\n"
                + "\t--reqbody\tSpecify json string to be used as request body\n"
                + "\t--upload <filename>\tSpecify a file to be uploaded\n"
                + "\t--upload <parameterName> <fileName>\tSpecify a file to be uploaded with named parameter\n"
                + "\t--ws\tEnable web socket service. Specify which service using '--sn' option\n"
                + "\t--ws-payload\tSet web socket data payload to send\n"
                + "\t--ws-payload-file\tSpecify a file to be loaded as web socket data payload\n"
                + "\t--ws-listen\tStart listening mode for web socket service\n"
                + "\t--interactive\tUse interactive mode for sending web socket data\n"
                + "\t--retry-on-ws-message-error\tRetry sending ws message on 'invalid control message' or 'compressed frame' exception\n"
                + "\nUser Login:\n"
                + "\tAccelByte.Sdk.Sample.CLI.exe --op login --user <username> --password <password>\n\n"
                + "Client Login:\n"
                + "\tAccelByte.Sdk.Sample.CLI.exe --op login --lt client\n\n"
                + "To know about any other parameters used by any operation, use this:\n"
                + "\tAccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation> --help";
            Console.WriteLine(opts);
        }
    }
}