using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Repository
{
    public interface ITokenValidationConfig
    {
        bool AllowGlobalRoleFetchForWildcardNamespace { get; }
    }
}
