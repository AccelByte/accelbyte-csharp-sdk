using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Repository
{
    public class ConfigRepository
    {
        public static readonly IConfigRepository Default = new DefaultConfigRepository();
    }
}
