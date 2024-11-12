// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Logging
{
    public class DefaultOutputWriter : ILogOutputWriter
    {
        private string _FilePath = String.Empty;

#if NET8_0_OR_GREATER
        private object _FileLock = new object();
#endif

        public DefaultOutputWriter(string filePath)
        {
            _FilePath = filePath;
        }

        protected void WriteStringDictionary(Dictionary<string, object> keyValues, StringBuilder sb, string prefix)
        {
            foreach (KeyValuePair<string, object> kvp in keyValues)
            {
                if (kvp.Value is string)
                    sb.AppendFormat("{0}{1}: {2}\n", prefix, kvp.Key, kvp.Value.ToString());
                else if (kvp.Value is Dictionary<string, object>)
                {
                    sb.AppendFormat("{0}{1}:\n", prefix, kvp.Key);
                    WriteStringDictionary((kvp.Value as Dictionary<string, object>)!, sb, prefix + " ");
                }
                else if (kvp.Value is byte[])
                {
                    sb.AppendFormat("{0}{1}: !!binary |\n", prefix, kvp.Key);
                    string bEncoded = Convert.ToBase64String((kvp.Value as byte[])!);
                    sb.AppendFormat("{0}\t{1}\n", prefix, bEncoded);
                }
            }
        }

        public void Write(string type, Dictionary<string, object> keyValues)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("--- {0}\n", type.Trim());
            WriteStringDictionary(keyValues, sb, "");
            sb.AppendLine();

#if NET6_0
            File.AppendAllText(_FilePath, sb.ToString());
#elif NET8_0_OR_GREATER
            lock (_FileLock)
            {
                File.AppendAllText(_FilePath, sb.ToString());
            }
#endif
        }
    }
}