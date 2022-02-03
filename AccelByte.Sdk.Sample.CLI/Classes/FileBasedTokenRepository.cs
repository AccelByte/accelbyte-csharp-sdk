using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Sample.Cli
{
    public class FileBasedTokenRepository : ITokenRepository
    {
        private string _FileName;

        public FileBasedTokenRepository(string fileName)
        {
            _FileName = fileName;
        }

        public FileBasedTokenRepository()
        {
            string aLoc = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
            _FileName = (aLoc + "\\token.txt");
        }

        public string GetToken()
        {
            if (File.Exists(_FileName))
                return File.ReadAllText(_FileName).Trim();
            else
                return String.Empty;
        }

        public void RemoveToken()
        {
            if (File.Exists(_FileName))
                File.Delete(_FileName);
        }

        public void StoreToken(string token)
        {
            File.WriteAllText(_FileName, token);
        }
    }
}
