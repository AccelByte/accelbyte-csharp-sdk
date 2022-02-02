using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccelByte.Sdk.Sample.CLI
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

                    if (part.Substring(0, 2) == "--")
                    {
                        string aKey = part.Substring(2).Trim();
                        string aValue = String.Empty;
                        if (args.Length > (cIndex + 1))
                        {
                            aValue = args[cIndex + 1].Trim();
                            if (aValue.Substring(0, 2) == "--")
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
                        else
                            _Parameters.Add(aKey, aValue);
                    }
                    else
                        throw new CommandArgumentException();
                }
            }
        }
    }
}
